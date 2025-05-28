Imports System.Data
Imports System.Data.SqlClient

Public Class TransacaoDAO
    Private ReadOnly _connectionString As String

    Public Sub New()
        _connectionString = modConnection.ConnectionString
    End Sub

    Public Function Inserir(objTransacaoDto As TransacaoDTO) As Boolean
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Dim sql As String = "INSERT INTO Transacoes (Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao) " &
                                    "VALUES (@NumeroCartao, @ValorTransacao, @DataTransacao, @Descricao, @StatusTransacao)"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NumeroCartao", objTransacaoDto.NumeroCartao)
                    cmd.Parameters.AddWithValue("@ValorTransacao", objTransacaoDto.ValorTransacao)
                    cmd.Parameters.AddWithValue("@DataTransacao", objTransacaoDto.DataTransacao)
                    cmd.Parameters.AddWithValue("@Descricao", objTransacaoDto.Descricao)
                    cmd.Parameters.AddWithValue("@StatusTransacao", objTransacaoDto.StatusTransacao)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao inserir transação: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Atualizar(objTransacaoDto As TransacaoDTO) As Boolean
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()

                Dim status As String = String.Empty
                Using cmdCheck As New SqlCommand("SELECT Status_Transacao FROM Transacoes WHERE Id_Transacao=@Id", cn)
                    cmdCheck.Parameters.AddWithValue("@Id", objTransacaoDto.IdTransacao)
                    Dim result = cmdCheck.ExecuteScalar()
                    If result IsNot Nothing Then status = result.ToString()
                End Using

                If status = "Aprovada" Then
                    MsgBox("Transações aprovadas não podem ser alteradas.", MsgBoxStyle.Exclamation)
                    Return False
                End If

                Dim sql As String = "UPDATE Transacoes SET Numero_Cartao=@NumeroCartao, Valor_Transacao=@ValorTransacao, " &
                                    "Data_Transacao=@DataTransacao, Descricao=@Descricao, Status_Transacao=@StatusTransacao " &
                                    "WHERE Id_Transacao=@Id"
                Using cmd As New SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@NumeroCartao", objTransacaoDto.NumeroCartao)
                    cmd.Parameters.AddWithValue("@ValorTransacao", objTransacaoDto.ValorTransacao)
                    cmd.Parameters.AddWithValue("@DataTransacao", objTransacaoDto.DataTransacao)
                    cmd.Parameters.AddWithValue("@Descricao", objTransacaoDto.Descricao)
                    cmd.Parameters.AddWithValue("@StatusTransacao", objTransacaoDto.StatusTransacao)
                    cmd.Parameters.AddWithValue("@Id", objTransacaoDto.IdTransacao)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao atualizar transação: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Excluir(idTransacao As Long) As Boolean
        Try
            If MsgBox($"Confirma exclusão da transação {idTransacao}?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Return False
            End If

            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand("DELETE FROM Transacoes WHERE Id_Transacao=@Id", cn)
                    cmd.Parameters.AddWithValue("@Id", idTransacao)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao excluir transação: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Listar(Optional filtro As String = "") As DataTable
        Dim dt As New DataTable()
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Dim sql As String = "SELECT Id_Transacao, Numero_Cartao, Valor_Transacao, Data_Transacao, Descricao, Status_Transacao FROM Transacoes"
                If Not String.IsNullOrEmpty(filtro) Then
                    sql &= " WHERE " & filtro
                End If
                sql &= " ORDER BY Id_Transacao ASC"
                Using cmd As New SqlCommand(sql, cn)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao listar transações: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return dt
    End Function

    Public Function ObterTransacoesCategorizadas(dataInicial As DateTime, dataFinal As DateTime) As DataTable
        Dim dt As New DataTable()
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand("SELECT * FROM fn_TransacoesCategorizadas(@DataInicial, @DataFinal)", cn)
                    cmd.Parameters.AddWithValue("@DataInicial", dataInicial)
                    cmd.Parameters.AddWithValue("@DataFinal", dataFinal)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao obter transações categorizadas: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return dt
    End Function

    Public Function ObterResumoFinanceiro() As DataTable
        Dim dt As New DataTable()
        Try
            Using cn As New SqlConnection(_connectionString)
                cn.Open()
                Using cmd As New SqlCommand("SELECT * FROM vw_ResumoFinanceiro", cn)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            modLogHelper.RegistrarErro("TransacaoDAO", ex)
            MsgBox("Erro ao obter resumo financeiro: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Return dt
    End Function
End Class
