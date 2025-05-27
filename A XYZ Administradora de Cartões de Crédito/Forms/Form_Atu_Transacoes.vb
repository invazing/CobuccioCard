Public Class Form_Atu_Transacoes

    ' Propriedades públicas que serão preenchidas pelo form de origem (ex: ID da transação, dados atuais etc.)
    Public Property TransacaoID As Integer
    Public Property NumeroCartao As String
    Public Property Descricao As String
    Public Property DataTransacao As DateTime
    Public Property Status As String
    Public Property Valor As Decimal

    ' Evento do botão "Salvar" — usado para atualizar a transação no banco de dados
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            ' Lê os dados atualizados do formulário
            Dim dataTransacao As DateTime = dtp_data_transacao.Value
            Dim numeroCartao As String = tbx_numero_cartao.Text.Trim()
            Dim descricao As String = tbx_descricao.Text.Trim()
            Dim status As String = cmb_status_transacao.Text.Trim()

            ' Cria instância do repositório de dados
            Dim dataCon As New Data_Con_Transacoes()

            ' Chama método para atualizar os dados no banco
            Dim sucesso As Boolean = dataCon.AtualizarTransacao(TransacaoID, numeroCartao, Valor, dataTransacao, descricao, status)

            ' Verifica se a operação foi bem-sucedida
            If sucesso Then
                MessageBox.Show("Transação atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close() ' Fecha o formulário
            Else
                MessageBox.Show("Erro ao atualizar a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Em caso de erro, registra no log e exibe uma mensagem
            LogHelper.RegistrarErro("btn_salvar_Click", ex)
            MessageBox.Show("Erro inesperado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento do botão "Cancelar" — fecha o formulário sem salvar alterações
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    ' Evento que ocorre ao carregar o formulário — preenche os campos com os dados atuais da transação
    Private Sub Form_Atu_Transacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_ID.Text = TransacaoID.ToString() ' Mostra o ID
        tbx_numero_cartao.Text = NumeroCartao ' Preenche número do cartão
        tbx_descricao.Text = Descricao ' Preenche descrição
        tbx_valor_transacao.Text = Valor ' Preenche valor
        dtp_data_transacao.Value = DataTransacao ' Preenche a data da transação
        cmb_status_transacao.Text = Status ' Preenche o status da transação

        ' (Essa linha pode ser redundante e até causar confusão, pois está sobrescrevendo a propriedade "Valor" com uma string formatada)
        Valor = Valor.ToString("F2")
    End Sub

End Class
