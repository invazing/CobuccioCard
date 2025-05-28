Imports System.Drawing

Module modGridHelper

    Public Sub ConfigurarGridResumoFinanceiro(ByRef grid As DataGridView)
        grid.Columns.Clear()
        grid.Rows.Clear()
        grid.AllowUserToAddRows = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.MultiSelect = False
        grid.RowHeadersVisible = False

        grid.Columns.Add("ID", "ID")
        grid.Columns.Add("NUMERO DO CARTÃO", "NUMERO DO CARTÃO")
        grid.Columns.Add("DESCRIÇÃO", "DESCRIÇÃO")
        grid.Columns.Add("VALOR", "VALOR")
        grid.Columns.Add("DATA", "DATA")
        grid.Columns.Add("STATUS", "STATUS")
        grid.Columns.Add("CATEGORIA", "CATEGORIA")


        For i As Integer = 0 To grid.Columns.Count - 1
            grid.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid.Columns(i).HeaderCell.Style.BackColor = Color.LightGray
            grid.Columns(i).HeaderCell.Style.Font = New Font(grid.Font, FontStyle.Bold)
        Next
    End Sub

    Public Sub ConfigurarGridAnaliseFinanceira(ByRef grid As DataGridView)
        grid.Columns.Clear()
        grid.Rows.Clear()
        grid.AllowUserToAddRows = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.MultiSelect = False
        grid.RowHeadersVisible = False

        grid.Columns.Add("Status_Transacao", "Status")
        grid.Columns.Add("Categoria", "Categoria")
        grid.Columns.Add("Quantidade", "Quantidade")
        grid.Columns.Add("Valor_Total", "Valor_Total")
        grid.Columns.Add("Data_Inicial", "Data_Inicial")
        grid.Columns.Add("Data_Fim", "Data_Fim")

        For i As Integer = 0 To grid.Columns.Count - 1
            grid.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid.Columns(i).HeaderCell.Style.BackColor = Color.LightGray
            grid.Columns(i).HeaderCell.Style.Font = New Font(grid.Font, FontStyle.Bold)
        Next
    End Sub

    Public Sub ConfigurarGridTransacoes(ByRef grid As DataGridView)
        grid.Columns.Clear()
        grid.Rows.Clear()
        grid.AllowUserToAddRows = False
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grid.MultiSelect = False
        grid.RowHeadersVisible = False
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

        grid.Columns.Add("Id", "ID")
        grid.Columns.Add("NumeroCartao", "Número Cartão")
        grid.Columns.Add("Valor", "Valor")
        grid.Columns.Add("DataTransacao", "Data")
        grid.Columns.Add("Descricao", "Descrição")
        grid.Columns.Add("Status", "Status")

        grid.Columns(0).Width = 80
        grid.Columns(1).Width = 180
        grid.Columns(2).Width = 120
        grid.Columns(3).Width = 140
        grid.Columns(4).Width = 300
        grid.Columns(5).Width = 120

        For i As Integer = 0 To grid.Columns.Count - 1
            grid.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            grid.Columns(i).HeaderCell.Style.BackColor = Color.LightGray
            grid.Columns(i).HeaderCell.Style.Font = New Font(grid.Font, FontStyle.Bold)
        Next
    End Sub

    Public Sub AjustarLarguraAutomatica(ByRef grid As DataGridView)
        If grid Is Nothing OrElse grid.Columns.Count = 0 Then Exit Sub
        Dim larguraDisponivel As Integer = grid.Width - 20
        Dim larguraColuna As Integer = larguraDisponivel \ grid.Columns.Count
        For i As Integer = 0 To grid.Columns.Count - 1
            grid.Columns(i).Width = larguraColuna
        Next
    End Sub

    Public Sub AdicionarLinhaGrid(ByRef grid As DataGridView,
                                  ByVal idTransacao As Long,
                                  ByVal numeroCartao As String,
                                  ByVal valor As Decimal,
                                  ByVal dataTransacao As Date,
                                  ByVal descricao As String,
                                  ByVal status As String)
        If grid.Columns.Count = 0 Then ConfigurarGridTransacoes(grid)

        Dim index As Integer = grid.Rows.Add(idTransacao, numeroCartao, valor.ToString("C2"),
                                             dataTransacao.ToString("dd/MM/yyyy HH:mm"), descricao, status)

        AplicarCorPorStatus(grid, index, status)

        grid.Rows(index).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Rows(index).Cells(1).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        grid.Rows(index).Cells(2).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        grid.Rows(index).Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        grid.Rows(index).Cells(4).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        grid.Rows(index).Cells(5).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub


    Public Sub LimparGrid(ByRef grid As DataGridView)
        grid.Rows.Clear()
    End Sub
    Public Function ObterIdSelecionado(ByRef grid As DataGridView) As Long
        If grid.CurrentRow IsNot Nothing Then
            Return CLng(grid.CurrentRow.Cells(0).Value)
        End If
        Return 0
    End Function

    Public Sub AplicarCoresAlternadas(ByRef grid As DataGridView)
        For i As Integer = 0 To grid.Rows.Count - 1
            Dim cor As Color = If(i Mod 2 = 0, Color.White, Color.FromArgb(245, 245, 245))
            For j As Integer = 0 To grid.Columns.Count - 1
                If grid.Rows(i).Cells(j).Style.BackColor = Color.White OrElse grid.Rows(i).Cells(j).Style.BackColor = Color.FromArgb(245, 245, 245) Then
                    grid.Rows(i).Cells(j).Style.BackColor = cor
                End If
            Next
        Next
    End Sub

    Public Sub PreencherGridComDataTable(ByRef grid As DataGridView, ByVal dt As DataTable)
        Try
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("Nenhum dado encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            grid.Rows.Clear()

            For Each row As DataRow In dt.Rows
                Dim valores As Object() = New Object(grid.Columns.Count - 1) {}

                For i As Integer = 0 To grid.Columns.Count - 1
                    Dim nomeColuna = grid.Columns(i).Name
                    If dt.Columns.Contains(nomeColuna) Then
                        valores(i) = row(nomeColuna)
                    Else
                        valores(i) = ""
                    End If
                Next

                Dim index As Integer = grid.Rows.Add(valores)

                If dt.Columns.Contains("Status") Then
                    AplicarCorPorStatus(grid, index, row("Status").ToString())
                ElseIf dt.Columns.Contains("Status_Transacao") Then
                    AplicarCorPorStatus(grid, index, row("Status_Transacao").ToString())
                End If
            Next

            AplicarCoresAlternadas(grid)

        Catch ex As Exception
            MessageBox.Show("Erro ao preencher grid: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub AplicarCorPorStatus(ByRef grid As DataGridView, ByVal linha As Integer, ByVal status As String)
        Dim corFundo As Color
        Dim corTexto As Color

        Select Case UCase(Trim(status))
            Case "APROVADA"
                corFundo = Color.LightGreen
                corTexto = Color.DarkGreen
            Case "PENDENTE"
                corFundo = Color.LightYellow
                corTexto = Color.SaddleBrown
            Case "CANCELADA"
                corFundo = Color.LightPink
                corTexto = Color.DarkRed
            Case Else
                corFundo = Color.White
                corTexto = Color.Black
        End Select

        ' Aplicar cores em todas as células da linha
        For i As Integer = 0 To grid.Columns.Count - 1
            grid.Rows(linha).Cells(i).Style.BackColor = corFundo
            grid.Rows(linha).Cells(i).Style.ForeColor = corTexto
        Next
    End Sub

    Public Function Nz(valor As Object, Optional valorPadrao As Object = "") As Object
        If valor Is Nothing OrElse valor Is DBNull.Value Then
            Return valorPadrao
        Else
            Return valor
        End If
    End Function

End Module
