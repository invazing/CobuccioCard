<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Label7 = New Label()
        Login_Panel_Login = New Panel()
        Login_Info = New Label()
        Login_Button_Exit = New Button()
        Login_Button = New Button()
        Label6 = New Label()
        Label4 = New Label()
        tbx_login_user = New TextBox()
        tbx_login_pass = New TextBox()
        Login_Panel_Logo = New Panel()
        Login_Panel_Login.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(68, 31)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 30)
        Label7.TabIndex = 6
        Label7.Text = "Seja bem-vindo!"
        ' 
        ' Login_Panel_Login
        ' 
        Login_Panel_Login.BackColor = Color.FromArgb(CByte(26), CByte(46), CByte(70))
        Login_Panel_Login.Controls.Add(Login_Info)
        Login_Panel_Login.Controls.Add(Login_Button_Exit)
        Login_Panel_Login.Controls.Add(Label7)
        Login_Panel_Login.Controls.Add(Login_Button)
        Login_Panel_Login.Controls.Add(Label6)
        Login_Panel_Login.Controls.Add(Label4)
        Login_Panel_Login.Controls.Add(tbx_login_user)
        Login_Panel_Login.Controls.Add(tbx_login_pass)
        Login_Panel_Login.Dock = DockStyle.Right
        Login_Panel_Login.Location = New Point(282, 0)
        Login_Panel_Login.Name = "Login_Panel_Login"
        Login_Panel_Login.Size = New Size(281, 300)
        Login_Panel_Login.TabIndex = 2
        ' 
        ' Login_Info
        ' 
        Login_Info.AutoSize = True
        Login_Info.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold Or FontStyle.Italic)
        Login_Info.ForeColor = Color.White
        Login_Info.Location = New Point(16, 224)
        Login_Info.Name = "Login_Info"
        Login_Info.Size = New Size(253, 13)
        Login_Info.TabIndex = 8
        Login_Info.Text = "Use as crêdencias fornecidas pelo Grupo Cobuccio"
        Login_Info.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Login_Button_Exit
        ' 
        Login_Button_Exit.FlatStyle = FlatStyle.Flat
        Login_Button_Exit.ForeColor = Color.Silver
        Login_Button_Exit.Location = New Point(247, 5)
        Login_Button_Exit.Name = "Login_Button_Exit"
        Login_Button_Exit.Size = New Size(29, 23)
        Login_Button_Exit.TabIndex = 7
        Login_Button_Exit.Text = "X"
        Login_Button_Exit.UseVisualStyleBackColor = True
        ' 
        ' Login_Button
        ' 
        Login_Button.FlatStyle = FlatStyle.Flat
        Login_Button.ForeColor = Color.White
        Login_Button.Location = New Point(100, 250)
        Login_Button.Name = "Login_Button"
        Login_Button.Size = New Size(79, 28)
        Login_Button.TabIndex = 3
        Login_Button.Text = "Login"
        Login_Button.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(43, 143)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 17)
        Label6.TabIndex = 4
        Label6.Text = "Pass"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(43, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 17)
        Label4.TabIndex = 3
        Label4.Text = "User"
        ' 
        ' tbx_login_user
        ' 
        tbx_login_user.BackColor = Color.FromArgb(CByte(31), CByte(29), CByte(30))
        tbx_login_user.BorderStyle = BorderStyle.FixedSingle
        tbx_login_user.CharacterCasing = CharacterCasing.Upper
        tbx_login_user.ForeColor = Color.Silver
        tbx_login_user.Location = New Point(43, 117)
        tbx_login_user.MaxLength = 14
        tbx_login_user.Name = "tbx_login_user"
        tbx_login_user.Size = New Size(205, 23)
        tbx_login_user.TabIndex = 1
        ' 
        ' tbx_login_pass
        ' 
        tbx_login_pass.BackColor = Color.FromArgb(CByte(31), CByte(29), CByte(30))
        tbx_login_pass.BorderStyle = BorderStyle.FixedSingle
        tbx_login_pass.CharacterCasing = CharacterCasing.Upper
        tbx_login_pass.ForeColor = Color.Silver
        tbx_login_pass.Location = New Point(43, 163)
        tbx_login_pass.MaxLength = 14
        tbx_login_pass.Name = "tbx_login_pass"
        tbx_login_pass.Size = New Size(205, 23)
        tbx_login_pass.TabIndex = 2
        tbx_login_pass.UseSystemPasswordChar = True
        ' 
        ' Login_Panel_Logo
        ' 
        Login_Panel_Logo.BackColor = Color.Transparent
        Login_Panel_Logo.Dock = DockStyle.Fill
        Login_Panel_Logo.Location = New Point(0, 0)
        Login_Panel_Logo.Name = "Login_Panel_Logo"
        Login_Panel_Logo.Size = New Size(563, 300)
        Login_Panel_Logo.TabIndex = 3
        ' 
        ' Form_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(563, 300)
        Controls.Add(Login_Panel_Login)
        Controls.Add(Login_Panel_Logo)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form_Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Login_Panel_Login.ResumeLayout(False)
        Login_Panel_Login.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Login_Panel_Login As Panel
    Friend WithEvents Login_Info As Label
    Friend WithEvents Login_Button_Exit As Button
    Friend WithEvents Login_Button As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbx_login_user As TextBox
    Friend WithEvents tbx_login_pass As TextBox
    Friend WithEvents Login_Panel_Logo As Panel
End Class
