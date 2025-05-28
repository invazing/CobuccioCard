Public Class Form_Analise

    Private ReadOnly transacaoBO As New TransacaoBO()

    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        Try
            Dim resumoFinanceiro As DataTable = transacaoBO.ObterTransacoesCategorizadas(
                dtp_data_transacao_inicial.Value.Date,
                dtp_data_transacao_final.Value.Date)

            Dim analiseFinanceira As DataTable = transacaoBO.ObterResumoFinanceiro()

            PreencherGridComDataTable(gridAnaliseFinanceira, analiseFinanceira)
            PreencherGridComDataTable(gridResumoFinanceira, resumoFinanceiro)

        Catch ex As Exception
            modLogHelper.RegistrarErro("Form_Analise", ex)
            MessageBox.Show("Erro ao consultar dados financeiros: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Form_Analise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarGridAnaliseFinanceira(gridAnaliseFinanceira)
        ConfigurarGridResumoFinanceiro(gridResumoFinanceira)

    End Sub

End Class
