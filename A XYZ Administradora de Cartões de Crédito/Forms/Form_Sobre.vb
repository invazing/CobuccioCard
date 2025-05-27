Public NotInheritable Class Form_Sobre

    ' Evento executado quando o formulário "Sobre" é carregado
    Private Sub Form_Sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String

        ' Define o título da aplicação, verificando se o título está definido nas propriedades do app
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ' Se o título estiver vazio, usa o nome do arquivo da aplicação sem extensão
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        ' Define o texto do título da janela com o nome da aplicação
        Me.Text = String.Format("Sobre {0}", ApplicationTitle)

        ' Preenche os labels com as informações do produto retiradas dos dados da aplicação
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName

        ' Define a descrição do aplicativo no TextBox
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    ' Evento acionado ao clicar no botão OK, fecha o formulário
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
