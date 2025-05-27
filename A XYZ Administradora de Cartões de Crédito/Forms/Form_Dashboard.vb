Public Class Form_Dashboard

    ' Evento acionado ao clicar no menu "CADASTRO"
    ' Abre o formulário de cadastro de transações como diálogo modal
    Private Sub CADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTROToolStripMenuItem.Click
        Form_Cad_Transacoes.ShowDialog()
    End Sub

    ' Evento acionado ao clicar no menu "RELATÓRIOS"
    ' Abre o formulário de consulta de transações como diálogo modal
    Private Sub RELATÓRIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELATÓRIOSToolStripMenuItem.Click
        Form_Con_Transacoes.ShowDialog()
    End Sub

    ' Evento acionado ao clicar no menu "GERENCIAMENTO"
    ' Abre o formulário "Sobre" como diálogo modal
    Private Sub GERENCIAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERENCIAMENTOToolStripMenuItem.Click
        Form_Sobre.ShowDialog()
    End Sub

    ' Evento disparado quando o formulário Dashboard é carregado
    ' Atualmente não possui nenhuma ação definida
    Private Sub Form_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Evento disparado quando o formulário Dashboard é fechado
    ' Encerra a aplicação
    Private Sub Form_Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    ' Evento acionado ao clicar no menu "ANÁLISE"
    ' Abre o formulário de análise como diálogo modal
    Private Sub ANALISEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ANALISEToolStripMenuItem.Click
        Form_Analise.ShowDialog()
    End Sub

    ' Evento acionado ao clicar no menu "GERAR DADOS"
    ' Exibe uma confirmação antes de gerar 1000 registros no banco de dados
    Private Sub GERARDADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERARDADOSToolStripMenuItem.Click
        Dim confirmacao As DialogResult = MessageBox.Show(
            "Isso vai gerar 1000 registros no banco de dados. Deseja continuar?",
            "Confirmar geração de dados",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        ' Se o usuário confirmar, tenta gerar as transações e mostra mensagem de sucesso ou erro
        If confirmacao = DialogResult.Yes Then
            Try
                GeradorDeTransacoes.GerarTransacoes(1000)
                MessageBox.Show("Transações geradas com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erro ao gerar transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Caso o usuário cancele, exibe mensagem de operação cancelada
            MessageBox.Show("Operação cancelada pelo usuário.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
