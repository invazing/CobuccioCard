Imports ClosedXML.Excel

Module modReport
    Public Sub GerarRelatorioExcel(dados As DataTable, caminhoArquivo As String)

        Try
            Using workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Relatório de Transações")
                worksheet.Cell(1, 1).InsertTable(dados)
                worksheet.Columns().AdjustToContents()
                workbook.SaveAs(caminhoArquivo)
            End Using
        Catch ex As Exception
            Throw New Exception("Erro ao gerar o relatório Excel: " & ex.Message)
        End Try
    End Sub

End Module
