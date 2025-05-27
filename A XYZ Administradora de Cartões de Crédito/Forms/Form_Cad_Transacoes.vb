Imports System.Data.SqlClient
Public Class Form_Cad_Transacoes
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If cmb_status_transacao.Text = "" Then
            MessageBox.Show("Por favor, selecione um status de transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Using conn As New SqlConnection(Connection.ConnectionString)
                    Using cmd As New SqlCommand("sp_InserirTransacao", conn)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@Numero_Cartao", tbx_numero_cartao.Text)
                        cmd.Parameters.AddWithValue("@Valor_Transacao", Decimal.Parse(tbx_valor_transacao.Text))
                        cmd.Parameters.AddWithValue("@Data_Transacao", dtp_data_transacao.Value)
                        cmd.Parameters.AddWithValue("@Descricao", tbx_descricao.Text)
                        cmd.Parameters.AddWithValue("@Status_Transacao", cmb_status_transacao.SelectedItem.ToString())
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Transação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimparFormulario()
            Catch ex As Exception
                MessageBox.Show("Erro ao cadastrar transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogHelper.RegistrarErro("ConsultarTransacoes", ex)
            End Try
        End If
    End Sub
    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        LimparFormulario()
    End Sub
    Private Sub LimparFormulario()
        tbx_numero_cartao.Clear()
        tbx_valor_transacao.Clear()
        dtp_data_transacao.Value = DateTime.Now
        tbx_descricao.Clear()
        cmb_status_transacao.SelectedIndex = -1
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub
End Class