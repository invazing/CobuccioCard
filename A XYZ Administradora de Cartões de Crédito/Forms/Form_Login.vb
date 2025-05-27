Public Class Form_Login
    Private Sub Login_Button_Click(sender As Object, e As EventArgs) Handles Login_Button.Click
        login()
    End Sub
    Private Sub Login_Button_Exit_Click(sender As Object, e As EventArgs) Handles Login_Button_Exit.Click
        End
    End Sub
    Private Sub login()
        If tbx_login_pass.Text = "ADMIN" And tbx_login_user.Text = "ADMIN" Then
            Form_Dashboard.Show()
        Else
            MessageBox.Show("Usuário ou senha inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LogHelper.RegistrarErro("Form_Login.login", New Exception("Tentativa de login falhou. Usuário: " & tbx_login_user.Text))
        End If
    End Sub
    Private Sub tbx_login_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbx_login_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class