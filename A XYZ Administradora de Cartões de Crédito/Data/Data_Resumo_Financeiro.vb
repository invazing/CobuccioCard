Imports System.Data.SqlClient

Public Class Data_Resumo_Financeiro

    '' 
    '' Retorna as transações categorizadas entre as datas informadas.
    '' Utiliza a Table-Valued Function (TVF) 'fn_TransacoesCategorizadas' do banco.
    '' Parâmetros:
    ''   dataInicial - início do período
    ''   dataFinal - fim do período
    '' Retorna um DataTable com as transações já classificadas por categoria.
    Public Function ObterTransacoesCategorizadas(dataInicial As DateTime, dataFinal As DateTime) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
                ' Monta a query para chamar a TVF com os parâmetros
                Dim query As String = "SELECT * FROM fn_TransacoesCategorizadas(@DataInicial, @DataFinal)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@DataInicial", dataInicial)
                    cmd.Parameters.AddWithValue("@DataFinal", dataFinal)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        ' Carrega os resultados no DataTable
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Caso dê erro, registra no log
            LogHelper.RegistrarErro("ObterTransacoesCategorizadas", ex)
        End Try
        Return dt
    End Function


    ' Retorna o resumo financeiro geral consultando a view vw_ResumoFinanceiro.
    ' Não recebe parâmetros.
    ' Retorna um DataTable com os dados da view para facilitar consultas financeiras.
    '
    Public Function ObterResumoFinanceiro() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
                ' Query simples para pegar tudo da view consolidada
                Dim query As String = "SELECT * FROM vw_ResumoFinanceiro"
                Using cmd As New SqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            LogHelper.RegistrarErro("ObterResumoFinanceiro", ex)
        End Try
        Return dt
    End Function

End Class
