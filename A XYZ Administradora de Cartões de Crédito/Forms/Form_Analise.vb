Public Class Form_Analise
    Dim repo As New Data_Resumo_Financeiro()
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        Dim repo As New Data_Resumo_Financeiro()

        Dim ResumoFinanceiro As DataTable = repo.ObterTransacoesCategorizadas(dtp_data_transacao_inicial.Value.Date, dtp_data_transacao_final.Value.Date)
        dgv_ResumoFinanceiro.DataSource = ResumoFinanceiro

        Dim AnaliseFinanceira As DataTable = repo.ObterResumoFinanceiro()
        dgv_AnaliseFinanceira.DataSource = AnaliseFinanceira


    End Sub


End Class