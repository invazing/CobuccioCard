<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Dashboard))
        MenuStrip1 = New MenuStrip()
        CADASTROToolStripMenuItem = New ToolStripMenuItem()
        RELATÓRIOSToolStripMenuItem = New ToolStripMenuItem()
        GERENCIAMENTOToolStripMenuItem = New ToolStripMenuItem()
        ANALISEToolStripMenuItem = New ToolStripMenuItem()
        GERARDADOSToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {CADASTROToolStripMenuItem, RELATÓRIOSToolStripMenuItem, GERENCIAMENTOToolStripMenuItem, ANALISEToolStripMenuItem, GERARDADOSToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(642, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CADASTROToolStripMenuItem
        ' 
        CADASTROToolStripMenuItem.Image = CType(resources.GetObject("CADASTROToolStripMenuItem.Image"), Image)
        CADASTROToolStripMenuItem.Name = "CADASTROToolStripMenuItem"
        CADASTROToolStripMenuItem.Size = New Size(96, 20)
        CADASTROToolStripMenuItem.Text = "CADASTRO"
        ' 
        ' RELATÓRIOSToolStripMenuItem
        ' 
        RELATÓRIOSToolStripMenuItem.Image = CType(resources.GetObject("RELATÓRIOSToolStripMenuItem.Image"), Image)
        RELATÓRIOSToolStripMenuItem.Name = "RELATÓRIOSToolStripMenuItem"
        RELATÓRIOSToolStripMenuItem.Size = New Size(131, 20)
        RELATÓRIOSToolStripMenuItem.Text = "GERENCIAMENTO"
        ' 
        ' GERENCIAMENTOToolStripMenuItem
        ' 
        GERENCIAMENTOToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        GERENCIAMENTOToolStripMenuItem.Image = CType(resources.GetObject("GERENCIAMENTOToolStripMenuItem.Image"), Image)
        GERENCIAMENTOToolStripMenuItem.Name = "GERENCIAMENTOToolStripMenuItem"
        GERENCIAMENTOToolStripMenuItem.Size = New Size(62, 20)
        GERENCIAMENTOToolStripMenuItem.Text = "INFO"
        ' 
        ' ANALISEToolStripMenuItem
        ' 
        ANALISEToolStripMenuItem.Image = CType(resources.GetObject("ANALISEToolStripMenuItem.Image"), Image)
        ANALISEToolStripMenuItem.Name = "ANALISEToolStripMenuItem"
        ANALISEToolStripMenuItem.Size = New Size(81, 20)
        ANALISEToolStripMenuItem.Text = "ANALISE"
        ' 
        ' GERARDADOSToolStripMenuItem
        ' 
        GERARDADOSToolStripMenuItem.Alignment = ToolStripItemAlignment.Right
        GERARDADOSToolStripMenuItem.Image = CType(resources.GetObject("GERARDADOSToolStripMenuItem.Image"), Image)
        GERARDADOSToolStripMenuItem.Name = "GERARDADOSToolStripMenuItem"
        GERARDADOSToolStripMenuItem.Size = New Size(113, 20)
        GERARDADOSToolStripMenuItem.Text = "GERAR DADOS"
        ' 
        ' Form_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(642, 296)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form_Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CobuccioCard - Grupo Adriano Cobuccio"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CADASTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERENCIAMENTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RELATÓRIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ANALISEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GERARDADOSToolStripMenuItem As ToolStripMenuItem

End Class
