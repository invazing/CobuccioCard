Public Class Form_Dashboard
    Private Sub CADASTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CADASTROToolStripMenuItem.Click
        Form_Cad_Transacoes.ShowDialog()
    End Sub
    Private Sub RELATÓRIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELATÓRIOSToolStripMenuItem.Click
        Form_Con_Transacoes.ShowDialog()
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
End Class
