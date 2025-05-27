Public Class Form_Login

    ' Evento acionado ao clicar no botão de login
    ' Executa o método login para validar usuário e senha
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        login()
    End Sub

    ' Evento acionado ao clicar no botão de sair
    ' Encerra a aplicação
    Private Sub Login_Button_Exit_Click(sender As Object, e As EventArgs) Handles Login_Button_Exit.Click
        End
    End Sub

    ' Método que verifica se o usuário e senha são válidos
    ' Caso corretos, abre o dashboard e esconde o formulário de login
    ' Caso incorretos, mostra mensagem de erro e registra o erro no log
    Private Sub login()
        If tbx_login_pass.Text = "ADMIN" And tbx_login_user.Text = "ADMIN" Then
            Form_Dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.RegistrarErro("Form_Login.login", New Exception("Tentativa de login falhou. Usuário: " & tbx_login_user.Text))
        End If
    End Sub

    ' Evento que detecta quando uma tecla é pressionada no campo de senha
    ' Se for a tecla Enter, chama o método login para tentar autenticar
    Private Sub tbx_login_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_login_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

End Class
