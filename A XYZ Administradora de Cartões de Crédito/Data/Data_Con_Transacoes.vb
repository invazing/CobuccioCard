Imports System.Data.SqlClient

' Classe responsável pelas operações de banco relacionadas às transações.
Public Class Data_Con_Transacoes

    ' Consulta transações com paginação, usando filtros opcionais.
    ' Parâmetros:
    '   numeroCartao, descricao, dataInicial, dataFinal, status: filtros opcionais
    '   pagina: número da página atual
    '   tamanhoPagina: quantidade de registros por página
    ' Retorna um DataTable com as transações da página solicitada.
    Public Function ConsultarTransacoesPaginado(numeroCartao As String, descricao As String, dataInicial As DateTime?, dataFinal As DateTime?, status As String, pagina As Integer, tamanhoPagina As Integer) As DataTable
        Try
            ' Calcula o offset para a paginação
            Dim offset As Integer = (pagina - 1) * tamanhoPagina
            Dim dt As New DataTable()
            Using conn As New SqlConnection(Connection.ConnectionString)
                Using cmd As New SqlCommand("sp_ConsultarTransacoes", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    ' Define os parâmetros da stored procedure, usando DBNull quando não informado
                    cmd.Parameters.AddWithValue("@Numero_Cartao", If(String.IsNullOrWhiteSpace(numeroCartao), DBNull.Value, numeroCartao))
                    cmd.Parameters.AddWithValue("@Descricao", If(String.IsNullOrWhiteSpace(descricao), DBNull.Value, descricao))
                    cmd.Parameters.AddWithValue("@Data_Inicial", If(dataInicial.HasValue, dataInicial.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@Data_Final", If(dataFinal.HasValue, dataFinal.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@Status_Transacao", If(String.IsNullOrWhiteSpace(status), DBNull.Value, status))

                    ' Parâmetros para paginação
                    cmd.Parameters.AddWithValue("@Offset", offset)
                    cmd.Parameters.AddWithValue("@PageSize", tamanhoPagina)

                    conn.Open()

                    ' Executa a consulta e carrega o resultado no DataTable
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using

            Return dt

        Catch ex As Exception
            ' Registra erro em arquivo de log e retorna Nothing
            LogHelper.RegistrarErro("ConsultarTransacoes", ex)
            Return Nothing
        End Try
    End Function

    ' Consulta resumo financeiro com filtro por período e status.
    ' Retorna um DataTable com totalizadores (ex: soma e quantidade).
    Public Function ConsultarResumoPorPeriodo(dataInicial As DateTime, dataFinal As DateTime, status As String) As DataTable
        Try
            Dim dt As New DataTable()
            Using conn As New SqlConnection(Connection.ConnectionString)
                Using cmd As New SqlCommand("sp_TotalTransacoesPorPeriodo", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Data_Inicial", dataInicial)
                    cmd.Parameters.AddWithValue("@Data_Final", dataFinal)
                    cmd.Parameters.AddWithValue("@Status_Transacao", status)

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
            Return dt
        Catch ex As Exception
            LogHelper.RegistrarErro("ConsultarTransacoes", ex)
            Return Nothing
        End Try
    End Function

    ' Consulta transações junto com resumo, com filtros opcionais.
    ' Retorna DataTable contendo as transações e seus respectivos resumos.
    Public Function ConsultarTransacoesComResumo(numeroCartao As String, descricao As String, dataInicial As DateTime?, dataFinal As DateTime?, status As String) As DataTable
        Try
            Dim dtResumo As New DataTable()
            Using conn As New SqlConnection(Connection.ConnectionString)
                Using cmd As New SqlCommand("sp_TransacoesComResumo", conn)
                    cmd.CommandType = CommandType.StoredProcedure

                    cmd.Parameters.AddWithValue("@Numero_Cartao", If(String.IsNullOrWhiteSpace(numeroCartao), DBNull.Value, numeroCartao))
                    cmd.Parameters.AddWithValue("@Descricao", If(String.IsNullOrWhiteSpace(descricao), DBNull.Value, descricao))
                    cmd.Parameters.AddWithValue("@Data_Inicial", If(dataInicial.HasValue, dataInicial.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@Data_Final", If(dataFinal.HasValue, dataFinal.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@Status_Transacao", If(String.IsNullOrWhiteSpace(status), DBNull.Value, status))

                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        dtResumo.Load(reader)
                    End Using
                End Using
            End Using
            Return dtResumo
        Catch ex As Exception
            LogHelper.RegistrarErro("ConsultarResumoTransacoes", ex)
            Return Nothing
        End Try
    End Function

    ' Exclui uma transação pelo ID.
    ' Retorna True se sucesso, False se falha.
    Public Function ExcluirTransacao(idTransacao As Integer) As Boolean
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
                Using cmd As New SqlCommand("sp_ExcluirTransacao", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Id_Transacao", idTransacao)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            LogHelper.RegistrarErro("ExcluirTransacao", ex)
            Return False
        End Try
    End Function

    ' Atualiza os dados de uma transação pelo ID.
    ' Retorna True se sucesso, False se falha.
    Public Function AtualizarTransacao(idTransacao As Integer, numeroCartao As String, valorTransacao As Decimal, dataTransacao As DateTime, descricao As String, statusTransacao As String) As Boolean
        Try
            Using conn As New SqlConnection(Connection.ConnectionString)
                Using cmd As New SqlCommand("sp_AtualizarTransacao", conn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Id_Transacao", idTransacao)
                    cmd.Parameters.AddWithValue("@Numero_Cartao", numeroCartao)
                    cmd.Parameters.AddWithValue("@Valor_Transacao", valorTransacao)
                    cmd.Parameters.AddWithValue("@Data_Transacao", dataTransacao)
                    cmd.Parameters.AddWithValue("@Descricao", descricao)
                    cmd.Parameters.AddWithValue("@Status_Transacao", statusTransacao)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            LogHelper.RegistrarErro("AtualizarTransacao", ex)
            Return False
        End Try
    End Function

End Class
