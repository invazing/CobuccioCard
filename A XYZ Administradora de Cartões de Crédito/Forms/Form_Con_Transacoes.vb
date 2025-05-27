' Importações necessárias
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class Form_Con_Transacoes

    ' Instância do repositório responsável pela comunicação com o banco de dados
    Dim repo As New Data_Con_Transacoes()

    ' Variáveis de controle para a paginação dos resultados
    Private paginaAtual As Integer = 1
    Private tamanhoPagina As Integer = 31

    ' Evento de clique no botão "Consultar"
    ' Reinicia para a primeira página e carrega os dados
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        paginaAtual = 1
        CarregarTransacoes()
    End Sub

    ' Evento de clique no botão "Deletar"
    ' Remove a transação selecionada após confirmação do usuário
    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        Try
            ' Captura o ID da linha selecionada
            Dim idSelecionado As Integer = Convert.ToInt32(dgv_transacoes.CurrentRow.Cells("ID").Value)

            ' Exibe caixa de confirmação
            If MessageBox.Show("Deseja realmente excluir esta transação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Chama o método de exclusão e recarrega os dados
                If repo.ExcluirTransacao(idSelecionado) Then
                    MessageBox.Show("Transação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao excluir a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                CarregarTransacoes()
            End If
        Catch ex As Exception
            ' Loga o erro e exibe mensagem
            LogHelper.RegistrarErro("ExcluirTransacao", ex)
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento de clique no botão "Editar"
    ' Abre formulário de edição, exceto para transações já aprovadas
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Try
            Dim formEditar As New Form_Atu_Transacoes()
            Dim idSelecionado As Integer = Convert.ToInt32(dgv_transacoes.CurrentRow.Cells("ID").Value)
            Dim StatusSelecionado As String = dgv_transacoes.CurrentRow.Cells("STATUS").Value

            ' Bloqueia edição de transações aprovadas
            If StatusSelecionado = "Aprovada" Then
                MessageBox.Show("Infelizmente não é possível editar transações já aprovadas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' Preenche os dados no formulário de edição
                formEditar.TransacaoID = idSelecionado
                formEditar.NumeroCartao = dgv_transacoes.CurrentRow.Cells("NUMERO DO CARTÃO").Value.ToString()
                formEditar.Descricao = dgv_transacoes.CurrentRow.Cells("DESCRIÇÃO").Value.ToString()
                formEditar.DataTransacao = Convert.ToDateTime(dgv_transacoes.CurrentRow.Cells("DATA").Value)
                formEditar.Status = dgv_transacoes.CurrentRow.Cells("STATUS").Value.ToString()
                formEditar.Valor = Convert.ToDecimal(dgv_transacoes.CurrentRow.Cells("VALOR").Value)

                ' Exibe o formulário de edição
                formEditar.ShowDialog()
                CarregarTransacoes()
            End If
        Catch ex As Exception
            LogHelper.RegistrarErro("EditarTransacao", ex)
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento de clique no botão "Exportar Excel"
    ' Exporta todas as transações para um arquivo Excel
    Private Sub btn_export_excel_Click(sender As Object, e As EventArgs) Handles btn_export_excel.Click
        ' Verifica se há dados para exportar
        If dgv_transacoes.DataSource Is Nothing OrElse CType(dgv_transacoes.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("Nenhuma transação para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Abre caixa de diálogo para salvar o arquivo
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Files|*.xlsx"
        sfd.Title = "Salvar Relatório"
        sfd.FileName = "Relatorio_Transacoes.xlsx"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim report As New Report_Con_Transacoes()

                ' Consulta todas as transações (sem paginação)
                Dim dtCompleto As DataTable = repo.ConsultarTransacoesPaginado(
                    tbx_numero_cartao.Text,
                    tbx_descricao.Text,
                    dtp_data_transacao_inicial.Value,
                    dtp_data_transacao_final.Value,
                    cmb_status_transacao.Text,
                    1,
                    Integer.MaxValue)

                ' Gera o relatório em Excel
                report.GerarRelatorioExcel(dtCompleto, sfd.FileName)
                MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erro ao exportar relatório: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Botão de próxima página da listagem
    Private Sub btn_pag_proxima_Click(sender As Object, e As EventArgs) Handles btn_pag_proxima.Click
        paginaAtual += 1
        CarregarTransacoes()
    End Sub

    ' Botão de página anterior da listagem
    Private Sub btn_pag_anterior_Click(sender As Object, e As EventArgs) Handles btn_pag_anterior.Click
        If paginaAtual > 1 Then
            paginaAtual -= 1
            CarregarTransacoes()
        End If
    End Sub

    ' Função que carrega as transações da base de dados com base nos filtros e paginação
    Private Sub CarregarTransacoes()
        Try
            lbl_index.Text = "Index: " + paginaAtual.ToString

            ' Verifica se foi selecionado um status
            If cmb_status_transacao.Text = "" Then
                MessageBox.Show("Por favor, selecione um status de transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Consulta dados paginados e exibe no DataGridView
            Dim dt As DataTable = repo.ConsultarTransacoesPaginado(
                tbx_numero_cartao.Text,
                tbx_descricao.Text,
                dtp_data_transacao_inicial.Value,
                dtp_data_transacao_final.Value,
                cmb_status_transacao.Text,
                paginaAtual,
                tamanhoPagina)
            dgv_transacoes.DataSource = dt

            ' Consulta e exibe o resumo das transações (total e quantidade)
            Dim dtResumo As DataTable = repo.ConsultarTransacoesComResumo(
                tbx_numero_cartao.Text,
                tbx_descricao.Text,
                dtp_data_transacao_inicial.Value,
                dtp_data_transacao_final.Value,
                cmb_status_transacao.Text)

            If dtResumo IsNot Nothing AndAlso dtResumo.Rows.Count > 0 Then
                lbl_valor_total.Text = "Total: " & Convert.ToDecimal(dtResumo.Rows(0)("Valor_Total")).ToString("C2")
                lbl_registro_total.Text = "Qtd: " & dtResumo.Rows(0)("Quantidade_Transacoes").ToString()
            End If
        Catch ex As Exception
            ' Em caso de erro, loga e zera os indicadores
            LogHelper.RegistrarErro("CarregarTransacoes", ex)
            lbl_valor_total.Text = "Total: R$ 0,00"
            lbl_registro_total.Text = "Qtd: 0"
        End Try
    End Sub

    ' Evento de carregamento do formulário (atualmente sem lógica)
    Private Sub Form_Con_Transacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
