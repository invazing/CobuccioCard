<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SplashScreen
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SplashScreen))
        Panel1 = New Panel()
        ApplicationTitle = New Label()
        Version = New Label()
        PictureBox1 = New PictureBox()
        SplashScreenTimer = New Timer(components)
        FadeIn = New Timer(components)
        FadeOut = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(ApplicationTitle)
        Panel1.Controls.Add(Version)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(563, 313)
        Panel1.TabIndex = 2
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 9.75F)
        ApplicationTitle.ForeColor = Color.White
        ApplicationTitle.Location = New Point(56, 271)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(142, 19)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Peça de Aplicação"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Version
        ' 
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F)
        Version.ForeColor = Color.White
        Version.Location = New Point(56, 290)
        Version.Name = "Version"
        Version.Size = New Size(132, 19)
        Version.TabIndex = 1
        Version.Text = "Versão {0}.{1:00}"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 271)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(47, 39)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' SplashScreenTimer
        ' 
        SplashScreenTimer.Interval = 5000
        ' 
        ' FadeIn
        ' 
        FadeIn.Enabled = True
        ' 
        ' FadeOut
        ' 
        ' 
        ' Form_SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 313)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form_SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SplashScreen"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Version As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplashScreenTimer As Timer
    Friend WithEvents FadeIn As Timer
    Friend WithEvents FadeOut As Timer
End Class
