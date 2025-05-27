' Formulário responsável por exibir análises e resumos financeiros
Public Class Form_Analise

    ' Instancia o repositório que contém os métodos de acesso aos dados de resumo financeiro
    Dim repo As New Data_Resumo_Financeiro()

    ' Evento do botão "Consultar" — quando clicado, realiza a consulta e exibe os dados nos DataGrids
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click

        ' Instancia local do repositório (poderia ser usado diretamente o `repo` declarado no início da classe)
        Dim repo As New Data_Resumo_Financeiro()

        ' Obtém os dados de transações categorizadas, filtradas pelo intervalo de datas
        Dim ResumoFinanceiro As DataTable = repo.ObterTransacoesCategorizadas(
            dtp_data_transacao_inicial.Value.Date,
            dtp_data_transacao_final.Value.Date
        )
        ' Exibe os dados no DataGridView correspondente
        dgv_ResumoFinanceiro.DataSource = ResumoFinanceiro

        ' Obtém um resumo financeiro geral (não filtrado por data, assumidamente)
        Dim AnaliseFinanceira As DataTable = repo.ObterResumoFinanceiro()
        ' Exibe os dados no DataGridView correspondente
        dgv_AnaliseFinanceira.DataSource = AnaliseFinanceira

    End Sub

End Class
