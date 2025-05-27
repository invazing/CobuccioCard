Imports System.Data.SqlClient ' Importa a biblioteca necessária para conectar com o banco de dados SQL Server

Public Class Form_Cad_Transacoes

    ' Evento disparado quando o botão "Salvar" é clicado
    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click

        ' Verifica se o status da transação foi selecionado
        If cmb_status_transacao.Text = "" Then
            MessageBox.Show("Por favor, selecione um status de transação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                ' Abre a conexão com o banco de dados
                Using conn As New SqlConnection(Connection.ConnectionString)
                    ' Define o comando que será executado (chamada da stored procedure)
                    Using cmd As New SqlCommand("sp_InserirTransacao", conn)
                        cmd.CommandType = CommandType.StoredProcedure ' Especifica que é uma stored procedure

                        ' Passa os parâmetros necessários para a procedure
                        cmd.Parameters.AddWithValue("@Numero_Cartao", tbx_numero_cartao.Text)
                        cmd.Parameters.AddWithValue("@Valor_Transacao", Decimal.Parse(tbx_valor_transacao.Text))
                        cmd.Parameters.AddWithValue("@Data_Transacao", dtp_data_transacao.Value)
                        cmd.Parameters.AddWithValue("@Descricao", tbx_descricao.Text)
                        cmd.Parameters.AddWithValue("@Status_Transacao", cmb_status_transacao.SelectedItem.ToString())

                        conn.Open() ' Abre a conexão
                        cmd.ExecuteNonQuery() ' Executa o comando (insert)
                    End Using
                End Using

                ' Exibe mensagem de sucesso e limpa o formulário
                MessageBox.Show("Transação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimparFormulario()

            Catch ex As Exception
                ' Exibe mensagem de erro e registra no log
                MessageBox.Show("Erro ao cadastrar transação: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LogHelper.RegistrarErro("ConsultarTransacoes", ex)
            End Try
        End If
    End Sub

    ' Evento disparado quando o botão "Novo" é clicado
    Private Sub btn_novo_Click(sender As Object, e As EventArgs) Handles btn_novo.Click
        LimparFormulario() ' Limpa todos os campos do formulário
    End Sub

    ' Método responsável por limpar o formulário
    Private Sub LimparFormulario()
        tbx_numero_cartao.Clear()
        tbx_valor_transacao.Clear()
        dtp_data_transacao.Value = DateTime.Now
        tbx_descricao.Clear()
        cmb_status_transacao.SelectedIndex = -1
    End Sub

    ' Evento disparado quando o botão "Cancelar" é clicado
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close() ' Fecha o formulário
    End Sub

End Class
