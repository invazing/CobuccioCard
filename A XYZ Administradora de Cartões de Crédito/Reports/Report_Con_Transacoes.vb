Imports ClosedXML.Excel
Imports System.Data

Public Class Report_Con_Transacoes

    ''' <summary>
    ''' Gera um relatório Excel (xlsx) a partir de um DataTable, usando ClosedXML (não precisa ter Excel instalado).
    ''' </summary>
    ''' <param name="dados">DataTable com os dados da transação</param>
    ''' <param name="caminhoArquivo">Caminho completo do arquivo a ser salvo</param>
    Public Sub GerarRelatorioExcel(dados As DataTable, caminhoArquivo As String)
        Try
            Using workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Relatório de Transações")

                worksheet.Cell(1, 1).InsertTable(dados)

                ' Formatações opcionais
                worksheet.Columns().AdjustToContents()

                ' Salva o arquivo
                workbook.SaveAs(caminhoArquivo)
            End Using
        Catch ex As Exception
            Throw New Exception("Erro ao gerar o relatório Excel: " & ex.Message)
        End Try
    End Sub

End Class
