Public Class Form_SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles SplashScreenTimer.Tick, SplashScreenTimer.Tick
        SplashScreenTimer.Enabled = False
        FadeIn.Enabled = False
        FadeOut.Enabled = True
    End Sub
    Private Sub Opacidade_Tick(sender As Object, e As EventArgs) Handles FadeIn.Tick, FadeIn.Tick
        If My.Forms.Form_SplashScreen.Opacity = 1 Then
            SplashScreenTimer.Enabled = True
        Else
            My.Forms.Form_SplashScreen.Opacity += 0.05
        End If
    End Sub
    Private Sub FadeOut_Tick(sender As Object, e As EventArgs) Handles FadeOut.Tick

        If My.Forms.Form_SplashScreen.Opacity = 0 Then
            FadeOut.Enabled = False
            Form_Login.Show()
        Else
            My.Forms.Form_SplashScreen.Opacity -= 0.05

        End If
    End Sub
End Class