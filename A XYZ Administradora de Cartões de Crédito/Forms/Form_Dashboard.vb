Public Class Form_Dashboard

    Private Sub CADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTROToolStripMenuItem.Click
        Form_CadTransacoes.ShowDialog()
    End Sub

    Private Sub RELATÓRIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELATÓRIOSToolStripMenuItem.Click
        Form_PsqTransacoes.ShowDialog()
    End Sub

    Private Sub GERENCIAMENTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERENCIAMENTOToolStripMenuItem.Click
        Form_Sobre.ShowDialog()
    End Sub

    Private Sub Form_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form_Dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub ANALISEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ANALISEToolStripMenuItem.Click
        Form_Analise.ShowDialog()
    End Sub

    Private Sub GERARDADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERARDADOSToolStripMenuItem.Click
        Dim confirmacao As DialogResult = MessageBox.Show(
            "Isso vai gerar 1000 registros no banco de dados. Deseja continuar?",
            "Confirmar geração de dados",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmacao = DialogResult.Yes Then
            Try
                modGerarRegistro.GerarTransacoes(1000)
                MessageBox.Show("Transações geradas com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                modLogHelper.RegistrarErro("Form_Dashboard", ex)
                MessageBox.Show("Erro ao gerar transações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Operação cancelada pelo usuário.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
