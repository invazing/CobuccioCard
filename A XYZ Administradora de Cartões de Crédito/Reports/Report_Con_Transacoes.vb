Imports ClosedXML.Excel
Imports System.Data

Public Class Report_Con_Transacoes

    ' Gera um relatório Excel com os dados da transação
    Public Sub GerarRelatorioExcel(dados As DataTable, caminhoArquivo As String)
        Try
            Using workbook As New XLWorkbook()
                Dim worksheet = workbook.Worksheets.Add("Relatório de Transações")

                worksheet.Cell(1, 1).InsertTable(dados)

                ' Ajusta a largura das colunas automaticamente
                worksheet.Columns().AdjustToContents()

                ' Salva o arquivo no caminho especificado
                workbook.SaveAs(caminhoArquivo)
            End Using
        Catch ex As Exception
            Throw New Exception("Erro ao gerar o relatório Excel: " & ex.Message)
        End Try
    End Sub

End Class
