' Classe responsável por fornecer a string de conexão com o banco de dados SQL Server.
Public Class Connection

    ' Propriedade compartilhada que retorna a string de conexão.
    ' Essa string contém as informações necessárias para acessar o banco de dados:
    ' - Server: endereço IP do servidor
    ' - Database: nome do banco de dados
    ' - User Id e Password: credenciais de acesso
    ' Observação: o banco informado é temporário e pode ser usado para testes.
    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return "Server=45.229.176.141;Database=CobuccioCard;User Id=cobuccio;Password=A@kB]vxW12u2025;"
            ' Pode usar esse banco de dados, ele é temporário para facilitar
        End Get
    End Property

End Class
