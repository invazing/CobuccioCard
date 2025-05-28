Imports System.Data

Public Class TransacaoBO
    Private ReadOnly _transacaoDao As TransacaoDAO

    Public Sub New()
        _transacaoDao = New TransacaoDAO()
    End Sub

    Public Function Listar(Optional ByVal filtro As String = "") As DataTable
        Try
            Dim dt As DataTable = _transacaoDao.Listar(filtro)
            Return dt
        Catch ex As Exception
            MessageBox.Show("Erro ao listar transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return New DataTable()
        End Try
    End Function

    Public Function Salvar(objTransacao As TransacaoDTO) As Boolean
        Try

            If Not ValidarTransacao(objTransacao) Then
                Return False
            End If

            If objTransacao.IdTransacao = 0 Then
                Return _transacaoDao.Inserir(objTransacao)
            Else
                Return _transacaoDao.Atualizar(objTransacao)
            End If
        Catch ex As Exception
            MsgBox("Erro ao salvar transação: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function Excluir(idTransacao As Long) As Boolean
        Try
            Return _transacaoDao.Excluir(idTransacao)
        Catch ex As Exception
            MsgBox("Erro ao excluir transação: " & ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Public Function ObterTransacoesCategorizadas(dataInicial As DateTime, dataFinal As DateTime) As DataTable
        Try

            If dataInicial > dataFinal Then
                MsgBox("A data inicial não pode ser maior que a final.", MsgBoxStyle.Exclamation)
                Return New DataTable()
            End If

            Return _transacaoDao.ObterTransacoesCategorizadas(dataInicial, dataFinal)
        Catch ex As Exception
            MsgBox("Erro ao obter transações categorizadas (BO): " & ex.Message, MsgBoxStyle.Critical)
            Return New DataTable()
        End Try
    End Function

    Public Function ObterResumoFinanceiro() As DataTable
        Try
            Return _transacaoDao.ObterResumoFinanceiro()
        Catch ex As Exception
            MsgBox("Erro ao obter resumo financeiro (BO): " & ex.Message, MsgBoxStyle.Critical)
            Return New DataTable()
        End Try
    End Function

    Private Function ValidarTransacao(objTransacao As TransacaoDTO) As Boolean
        If String.IsNullOrWhiteSpace(objTransacao.NumeroCartao) OrElse objTransacao.NumeroCartao.Length <> 16 OrElse Not IsNumeric(objTransacao.NumeroCartao) Then
            MsgBox("Número do cartão deve conter 16 dígitos numéricos.", MsgBoxStyle.Exclamation)
            Return False
        End If

        If objTransacao.ValorTransacao <= 0 Then
            MsgBox("Valor da transação deve ser positivo.", MsgBoxStyle.Exclamation)
            Return False
        End If

        If String.IsNullOrWhiteSpace(objTransacao.StatusTransacao) Then
            MsgBox("Informe o status da transação.", MsgBoxStyle.Exclamation)
            Return False
        End If

        Return True
    End Function
End Class
