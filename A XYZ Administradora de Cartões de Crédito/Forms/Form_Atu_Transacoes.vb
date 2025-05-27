Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form_Atu_Transacoes
    Public Property TransacaoID As Integer
    Public Property NumeroCartao As String
    Public Property Descricao As String
    Public Property DataTransacao As DateTime
    Public Property Status As String
    Public Property Valor As Decimal
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            Dim dataTransacao As DateTime = dtp_data_transacao.Value
            Dim numeroCartao As String = tbx_numero_cartao.Text.Trim()
            Dim descricao As String = tbx_descricao.Text.Trim()
            Dim status As String = cmb_status_transacao.Text.Trim()
            Dim dataCon As New Data_Con_Transacoes()
            Dim sucesso As Boolean = dataCon.AtualizarTransacao(TransacaoID, numeroCartao, Valor, dataTransacao, descricao, status)

            If sucesso Then
                MessageBox.Show("Transação atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Erro ao atualizar a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            LogHelper.RegistrarErro("btn_salvar_Click", ex)
            MessageBox.Show("Erro inesperado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub Form_Atu_Transacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_ID.Text = TransacaoID.ToString()
        tbx_numero_cartao.Text = NumeroCartao
        tbx_descricao.Text = Descricao
        tbx_valor_transacao.Text = Valor
        dtp_data_transacao.Value = DataTransacao
        cmb_status_transacao.Text = Status
        Valor = Valor.ToString("F2")
    End Sub
End Class