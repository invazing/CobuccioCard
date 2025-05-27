Public Class Form_SplashScreen

    ' Evento chamado quando a splash screen é carregada
    ' Define o título do aplicativo e a versão exibidos na tela
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        ' Exibe a versão completa do aplicativo no formato Major.Minor.Build.Revision
        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
    End Sub

    ' Evento disparado quando o timer da splash screen termina (delay da exibição)
    ' Desativa o timer e inicia o efeito de fade out
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SplashScreenTimer.Tick
        SplashScreenTimer.Enabled = False
        FadeIn.Enabled = False
        FadeOut.Enabled = True
    End Sub

    ' Evento que controla o efeito de fade in (aumenta opacidade gradualmente)
    ' Quando a opacidade chegar a 100%, ativa o timer da splash screen
    Private Sub Opacidade_Tick(sender As Object, e As EventArgs) Handles FadeIn.Tick
        If Me.Opacity >= 1 Then
            SplashScreenTimer.Enabled = True
        Else
            Me.Opacity += 0.05
        End If
    End Sub

    ' Evento que controla o efeito de fade out (diminui opacidade gradualmente)
    ' Quando a opacidade chegar a 0, esconde a splash screen e mostra o formulário de login
    Private Sub FadeOut_Tick(sender As Object, e As EventArgs) Handles FadeOut.Tick
        If Me.Opacity <= 0 Then
            FadeOut.Enabled = False
            Form_Login.Show()
            Me.Hide()
        Else
            Me.Opacity -= 0.05
        End If
    End Sub

End Class
