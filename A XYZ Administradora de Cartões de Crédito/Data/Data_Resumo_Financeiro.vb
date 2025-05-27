Imports System.Data.SqlClient

Public Class Data_Resumo_Financeiro

    ' Retorna transações categorizadas entre duas datas (usa a TVF)
    Public Function ObterTransacoesCategorizadas(dataInicial As DateTime, dataFinal As DateTime) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
                Dim query As String = "SELECT * FROM fn_TransacoesCategorizadas(@DataInicial, @DataFinal)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@DataInicial", dataInicial)
                    cmd.Parameters.AddWithValue("@DataFinal", dataFinal)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            LogHelper.RegistrarErro("ObterTransacoesCategorizadas", ex)
        End Try
        Return dt
    End Function

    ' Retorna dados da view vw_ResumoFinanceiro
    Public Function ObterResumoFinanceiro() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
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
