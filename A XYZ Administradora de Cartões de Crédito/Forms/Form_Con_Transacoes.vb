Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles

Public Class Form_Con_Transacoes
    Dim repo As New Data_Con_Transacoes()
    Private paginaAtual As Integer = 1
    Private tamanhoPagina As Integer = 31
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        paginaAtual = 1
        CarregarTransacoes()
    End Sub
    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click

        Try
            Dim idSelecionado As Integer = Convert.ToInt32(dgv_transacoes.CurrentRow.Cells("ID").Value)
            If MessageBox.Show("Deseja realmente excluir esta transação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If repo.ExcluirTransacao(idSelecionado) Then
                    MessageBox.Show("Transação excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CarregarTransacoes()
                Else
                    MessageBox.Show("Erro ao excluir a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    CarregarTransacoes()
                End If
            End If
        Catch ex As Exception
            LogHelper.RegistrarErro("ExcluirTransacao", ex)
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            If cmb_status_transacao.Text = "" Then
                MessageBox.Show("Por favor, selecione um status de transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim dt As DataTable = repo.ConsultarTransacoesPaginado(
                tbx_numero_cartao.Text,
                tbx_descricao.Text,
                dtp_data_transacao_inicial.Value,
                dtp_data_transacao_final.Value,
                cmb_status_transacao.Text,
                paginaAtual,
                tamanhoPagina)
                dgv_transacoes.DataSource = dt
            End If
        Catch ex As Exception
            LogHelper.RegistrarErro("ExcluirTransacao", ex)
        End Try

    End Sub
    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click

        Try
            Dim formEditar As New Form_Atu_Transacoes()
            Dim idSelecionado As Integer = Convert.ToInt32(dgv_transacoes.CurrentRow.Cells("ID").Value)
            Dim StatusSelecionado As String = dgv_transacoes.CurrentRow.Cells("STATUS").Value
            If StatusSelecionado = "Aprovada" Then
                MessageBox.Show("Infelizmente não é possivel editar transações já aprovadas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                formEditar.TransacaoID = idSelecionado
                formEditar.NumeroCartao = dgv_transacoes.CurrentRow.Cells("NUMERO DO CARTÃO").Value.ToString()
                formEditar.Descricao = dgv_transacoes.CurrentRow.Cells("DESCRIÇÃO").Value.ToString()
                formEditar.DataTransacao = Convert.ToDateTime(dgv_transacoes.CurrentRow.Cells("DATA").Value)
                formEditar.Status = dgv_transacoes.CurrentRow.Cells("STATUS").Value.ToString()
                formEditar.Valor = Convert.ToDecimal(dgv_transacoes.CurrentRow.Cells("VALOR").Value)
                formEditar.ShowDialog()
                CarregarTransacoes()
            End If
        Catch ex As Exception
            LogHelper.RegistrarErro("EditarTransacao", ex)
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btn_export_excel_Click(sender As Object, e As EventArgs) Handles btn_export_excel.Click
        If dgv_transacoes.DataSource Is Nothing OrElse CType(dgv_transacoes.DataSource, DataTable).Rows.Count = 0 Then
            MessageBox.Show("Nenhuma transação para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Excel Files|*.xlsx"
        sfd.Title = "Salvar Relatório"
        sfd.FileName = "Relatorio_Transacoes.xlsx"

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim report As New Report_Con_Transacoes()
                Dim dtCompleto As DataTable = repo.ConsultarTransacoesPaginado(
                tbx_numero_cartao.Text,
                tbx_descricao.Text,
                dtp_data_transacao_inicial.Value,
                dtp_data_transacao_final.Value,
                cmb_status_transacao.Text,
                1,
                Integer.MaxValue)
                report.GerarRelatorioExcel(dtCompleto, sfd.FileName)
                MessageBox.Show("Relatório exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erro ao exportar relatório: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btn_pag_proxima_Click(sender As Object, e As EventArgs) Handles btn_pag_proxima.Click
        paginaAtual += 1
        CarregarTransacoes()
    End Sub

    Private Sub btn_pag_anterior_Click(sender As Object, e As EventArgs) Handles btn_pag_anterior.Click
        If paginaAtual > 1 Then
            paginaAtual -= 1
            CarregarTransacoes()
        End If
    End Sub

    Private Sub CarregarTransacoes()
        Try
            lbl_index.Text = "Index: " + paginaAtual.ToString
            If cmb_status_transacao.Text = "" Then
                MessageBox.Show("Por favor, selecione um status de transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim dt As DataTable = repo.ConsultarTransacoesPaginado(
            tbx_numero_cartao.Text,
            tbx_descricao.Text,
            dtp_data_transacao_inicial.Value,
            dtp_data_transacao_final.Value,
            cmb_status_transacao.Text,
            paginaAtual,
            tamanhoPagina)

            dgv_transacoes.DataSource = dt

            ' Atualizar resumo
            Dim resumo As New DataTable()
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
            LogHelper.RegistrarErro("CarregarTransacoes", ex)
            lbl_valor_total.Text = "Total: R$ 0,00"
            lbl_registro_total.Text = "Qtd: 0"
        End Try
    End Sub

End Class