Imports System.IO

Public Class LogHelper

    ' Caminho onde o arquivo de log será salvo (AppData\Common\Cobucciocard\cobucciocard.log)
    Private Shared ReadOnly caminhoLog As String = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
        "Cobucciocard",
        "cobucciocard.log"
    )

    ' Registra erros em um arquivo de log
    Public Shared Sub RegistrarErro(metodo As String, ex As Exception)
        Try
            ' Garante que a pasta existe
            Dim pastaLog As String = Path.GetDirectoryName(caminhoLog)
            If Not Directory.Exists(pastaLog) Then
                Directory.CreateDirectory(pastaLog)
            End If

            ' Escreve as informações do erro no arquivo de log
            Using sw As New StreamWriter(caminhoLog, True)
                sw.WriteLine("[" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "] ERRO em " & metodo)
                sw.WriteLine("Mensagem: " & ex.Message)
                sw.WriteLine("StackTrace: " & ex.StackTrace)
                If ex.InnerException IsNot Nothing Then
                    sw.WriteLine("InnerException: " & ex.InnerException.Message)
                End If
                sw.WriteLine(New String("-"c, 80)) ' Linha separadora
            End Using
        Catch
            ' Evita que erros no log gerem exceções na aplicação
        End Try
    End Sub

End Class
