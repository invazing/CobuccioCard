Imports System.IO

Public Class LogHelper

    Private Shared ReadOnly caminhoLog As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
        "Cobucciocard",
        "cobucciocard.log"
    )

    Public Shared Sub RegistrarErro(metodo As String, ex As Exception)
        Try
            Dim pastaLog As String = Path.GetDirectoryName(caminhoLog)
            If Not Directory.Exists(pastaLog) Then
                Directory.CreateDirectory(pastaLog)
            End If
            Using sw As New StreamWriter(caminhoLog, True)
                sw.WriteLine("[" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "] ERRO em " & metodo)
                sw.WriteLine("Mensagem: " & ex.Message)
                sw.WriteLine("StackTrace: " & ex.StackTrace)
                If ex.InnerException IsNot Nothing Then
                    sw.WriteLine("InnerException: " & ex.InnerException.Message)
                End If
                sw.WriteLine(New String("-"c, 80))
            End Using
        Catch
        End Try
    End Sub

End Class
