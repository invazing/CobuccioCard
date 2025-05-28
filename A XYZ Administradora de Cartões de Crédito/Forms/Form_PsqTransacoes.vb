Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Public Class Form_PsqTransacoes

    Private ReadOnly objTransacaoBO As New TransacaoBO()

    Private paginaAtual As Integer = 1
    Private tamanhoPagina As Integer = 100

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        paginaAtual = 1
        CarregarTransacoes()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim idSelecionado As Long = ObterIdSelecionado(gridTransacoes)
            If idSelecionado = 0 Then
                MessageBox.Show("Selecione uma transação para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim status As String = TryCast(gridTransacoes.CurrentRow?.Cells("Status")?.Value, String)

            If String.Equals(status, "Aprovada", StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("Transações aprovadas não podem ser alteradas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using formEditar As New Form_CadTransacoes()
                formEditar.CarregarModoEdicao(idSelecionado)
                formEditar.ShowDialog()
            End Using

            CarregarTransacoes()

        Catch ex As Exception
            modLogHelper.RegistrarErro("Form_PsqTransacoes", ex)
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnProxima_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        paginaAtual += 1
        CarregarTransacoes()
    End Sub

    Private Sub btn_pag_anterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If paginaAtual > 1 Then
            paginaAtual -= 1
            CarregarTransacoes()
        End If
    End Sub
    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            Dim idTransacao As Long = ObterIdSelecionado(gridTransacoes)
            If idTransacao = 0 Then
                MessageBox.Show("Selecione uma transação para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If MessageBox.Show($"Deseja realmente excluir a transação ID: {idTransacao}?",
                               "Confirmação",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            If objTransacaoBO.Excluir(idTransacao) Then
                MessageBox.Show("Transação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CarregarTransacoes()
            Else
                MessageBox.Show("Erro ao excluir a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            modLogHelper.RegistrarErro("Form_PsqTransacoes", ex)
            MessageBox.Show("Erro ao excluir: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ObterIdSelecionado(dgv As DataGridView) As Long
        If dgv Is Nothing OrElse dgv.CurrentRow Is Nothing Then Return 0
        Dim valor = dgv.CurrentRow.Cells("Id")?.Value
        Return If(valor IsNot Nothing AndAlso Long.TryParse(valor.ToString(), Nothing), CLng(valor), 0)
    End Function

    Private Sub CarregarTransacoes()
        Try
            Dim objTransacaoBO As New TransacaoBO()

            LimparGrid(gridTransacoes)
            Dim filtro As String = ConstruirFiltro()
            Dim dtTemp As DataTable = objTransacaoBO.Listar(filtro)

            If dtTemp Is Nothing OrElse dtTemp.Rows.Count = 0 Then
                MessageBox.Show("Nenhuma transação encontrada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnAnterior.Enabled = False
                btnProximo.Enabled = False
                Exit Sub
            End If

            PreencherGridComPaginacao(dtTemp)

        Catch ex As Exception
            modLogHelper.RegistrarErro("Form_PsqTransacoes", ex)
            MessageBox.Show("Erro ao carregar transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnAnterior.Enabled = False
            btnProximo.Enabled = False
        End Try
    End Sub

    Private Sub AtualizarControlesNavegacao(temProximaPagina As Boolean)
        btnAnterior.Enabled = (paginaAtual > 1)
        btnProximo.Enabled = temProximaPagina
        lblIndex.Text = $"Página {paginaAtual} - {gridTransacoes.Rows.Count} registro(s)"
    End Sub


    Private Function ConstruirFiltro() As String
        Dim filtro As New List(Of String)

        If Not String.IsNullOrWhiteSpace(txtDescricao.Text) Then
            filtro.Add($"Descricao LIKE '%{txtDescricao.Text.Trim()}%'")
        End If

        If Not String.IsNullOrWhiteSpace(txtNumCartao.Text) Then
            filtro.Add($"Numero_Cartao LIKE '%{txtNumCartao.Text.Trim()}%'")
        End If

        If cmbStatus.SelectedIndex >= 1 Then
            filtro.Add($"Status_Transacao='{cmbStatus.Text}'")
        End If

        If IsDate(dtInicio.Value) Then
            filtro.Add($"Data_Transacao >= '{dtInicio.Value:yyyy-MM-dd} 00:00:00'")
        End If

        If IsDate(dtFim.Value) Then
            filtro.Add($"Data_Transacao <= '{dtFim.Value:yyyy-MM-dd} 23:59:59'")
        End If

        Return String.Join(" AND ", filtro)
    End Function

    Private Sub PreencherGridComPaginacao(dt As DataTable)
        Dim offset As Integer = (paginaAtual - 1) * tamanhoPagina
        Dim pagina As DataTable = dt.AsEnumerable().Skip(offset).Take(tamanhoPagina).CopyToDataTable()

        LimparGrid(gridTransacoes)

        For Each row As DataRow In pagina.Rows
            AdicionarLinhaGrid(gridTransacoes,
                               row("Id_Transacao"),
                               row("Numero_Cartao"),
                               row("Valor_Transacao"),
                               row("Data_Transacao"),
                               row("Descricao").ToString(),
                               row("Status_Transacao"))
        Next

        AtualizarControlesNavegacao(offset + pagina.Rows.Count < dt.Rows.Count)
    End Sub

    Private Sub Form_PsqTransacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.SelectedIndex = 0
        ConfigurarGridTransacoes(gridTransacoes)
        AjustarLarguraAutomatica(gridTransacoes)
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        Dim objTransacaoBO As New TransacaoBO()
        Dim filtro As String = ConstruirFiltro()
        Dim dtTemp As DataTable = objTransacaoBO.Listar(filtro)

        If dtTemp Is Nothing OrElse dtTemp.Rows.Count = 0 Then
            MessageBox.Show("Nenhuma transação para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Files|*.xlsx"
        sfd.Title = "Salvar Relatório"
        sfd.FileName = "Relatorio_Transacoes.xlsx"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                modReport.GerarRelatorioExcel(dtTemp, sfd.FileName)
                MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                modLogHelper.RegistrarErro("Form_PsqTransacoes", ex)
                MessageBox.Show("Erro ao exportar relatório: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class


