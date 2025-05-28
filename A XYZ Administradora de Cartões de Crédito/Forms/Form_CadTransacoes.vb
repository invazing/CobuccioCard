Imports System.Data.SqlClient ' Importa a biblioteca necessária para conectar com o banco de dados SQL Server

Public Class Form_CadTransacoes


    ' BO de transações
    Private ReadOnly transacaoBO As New TransacaoBO()

    ' Objeto que representa a transação
    Private objTransacaoDTO As TransacaoDTO

    ' Controle do modo de edição
    Private ModoEdicao As Boolean = False
    Private idEdicao As Long = 0

    Private Sub LimparFormulario()
        tbx_numero_cartao.Clear()
        tbx_valor_transacao.Clear()
        dtp_data_transacao.Value = DateTime.Now
        tbx_descricao.Clear()
        cmb_status_transacao.SelectedIndex = -1
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close() ' Fecha o formulário
    End Sub

    ' Evento disparado ao clicar no botão "Salvar"
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Try
            If Not ValidarCampos() Then Return

            objTransacaoDTO = New TransacaoDTO With {
                .IdTransacao = If(ModoEdicao, idEdicao, 0),
                .NumeroCartao = tbx_numero_cartao.Text.Trim(),
                .ValorTransacao = Decimal.Parse(tbx_valor_transacao.Text),
                .DataTransacao = dtp_data_transacao.Value,
                .Descricao = tbx_descricao.Text.Trim(),
                .StatusTransacao = cmb_status_transacao.SelectedItem.ToString()
            }

            Dim sucesso As Boolean = transacaoBO.Salvar(objTransacaoDTO)

            If sucesso Then
                MessageBox.Show(If(ModoEdicao, "Transação atualizada com sucesso!", "Transação salva com sucesso!"),
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimparFormulario()
                Me.Close()
            Else
                MessageBox.Show("Falha ao salvar a transação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ModLogHelper.RegistrarErro("SalvarTransacao", ex)
        End Try
    End Sub


    Public Sub CarregarModoEdicao(ByVal idTransacao As Long)
        Try
            Dim dt As DataTable = transacaoBO.Listar("Id_Transacao=" & idTransacao)
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("Transação não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ModoEdicao = True
            idEdicao = idTransacao
            Dim row As DataRow = dt.Rows(0)

            tbx_numero_cartao.Text = row("Numero_Cartao").ToString()
            tbx_valor_transacao.Text = Convert.ToDecimal(row("Valor_Transacao")).ToString("F2")
            dtp_data_transacao.Value = Convert.ToDateTime(row("Data_Transacao"))
            tbx_descricao.Text = row("Descricao").ToString()
            cmb_status_transacao.SelectedItem = row("Status_Transacao").ToString().Trim()

            ' Bloqueia edição se a transação estiver aprovada
            If cmb_status_transacao.SelectedItem.ToString().ToUpper() = "APROVADA" Then
                MessageBox.Show("Transações aprovadas não podem ser alteradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.Close()
            End If

            Me.Text = $"Editar Transação - ID: {idTransacao}"

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean

        If tbx_numero_cartao.Text.Length <> 16 OrElse Not IsNumeric(tbx_numero_cartao.Text) Then
            MessageBox.Show("Número do cartão inválido. Deve ter 16 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbx_numero_cartao.Focus()
            Return False
        End If

        Dim valor As Decimal
        If Not Decimal.TryParse(tbx_valor_transacao.Text, valor) OrElse valor <= 0 Then
            MessageBox.Show("Informe um valor válido para a transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbx_valor_transacao.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(tbx_descricao.Text) Then
            MessageBox.Show("Informe a descrição da transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbx_descricao.Focus()
            Return False
        End If

        If cmb_status_transacao.SelectedIndex = -1 Then
            MessageBox.Show("Selecione o status da transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb_status_transacao.Focus()
            Return False
        End If

        If dtp_data_transacao.Value = Date.MinValue Then
            MessageBox.Show("Informe a data da transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtp_data_transacao.Focus()
            Return False
        End If

        Return True
    End Function

End Class
