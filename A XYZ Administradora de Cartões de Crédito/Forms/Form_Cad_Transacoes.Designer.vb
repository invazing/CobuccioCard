<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Cad_Transacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Cad_Transacoes))
        GroupBox1 = New GroupBox()
        lbl_cmb_status_transacao = New Label()
        cmb_status_transacao = New ComboBox()
        dtp_data_transacao = New DateTimePicker()
        lbl_numero_cartao = New Label()
        lbl_data_transacao = New Label()
        lbl_valor_transacao = New Label()
        tbx_valor_transacao = New TextBox()
        tbx_descricao = New TextBox()
        lbl_descricao = New Label()
        tbx_numero_cartao = New TextBox()
        btn_novo = New Button()
        btn_salvar = New Button()
        btn_cancelar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbl_cmb_status_transacao)
        GroupBox1.Controls.Add(cmb_status_transacao)
        GroupBox1.Controls.Add(dtp_data_transacao)
        GroupBox1.Controls.Add(lbl_numero_cartao)
        GroupBox1.Controls.Add(lbl_data_transacao)
        GroupBox1.Controls.Add(lbl_valor_transacao)
        GroupBox1.Controls.Add(tbx_valor_transacao)
        GroupBox1.Controls.Add(tbx_descricao)
        GroupBox1.Controls.Add(lbl_descricao)
        GroupBox1.Controls.Add(tbx_numero_cartao)
        GroupBox1.Location = New Point(13, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(469, 142)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados da Transação"
        ' 
        ' lbl_cmb_status_transacao
        ' 
        lbl_cmb_status_transacao.AutoSize = True
        lbl_cmb_status_transacao.Location = New Point(299, 81)
        lbl_cmb_status_transacao.Name = "lbl_cmb_status_transacao"
        lbl_cmb_status_transacao.Size = New Size(39, 15)
        lbl_cmb_status_transacao.TabIndex = 1
        lbl_cmb_status_transacao.Text = "Status"
        ' 
        ' cmb_status_transacao
        ' 
        cmb_status_transacao.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_status_transacao.FormattingEnabled = True
        cmb_status_transacao.Items.AddRange(New Object() {"Aprovada", "Pendente", "Cancelada"})
        cmb_status_transacao.Location = New Point(299, 99)
        cmb_status_transacao.Name = "cmb_status_transacao"
        cmb_status_transacao.Size = New Size(151, 23)
        cmb_status_transacao.TabIndex = 5
        ' 
        ' dtp_data_transacao
        ' 
        dtp_data_transacao.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        dtp_data_transacao.Format = DateTimePickerFormat.Custom
        dtp_data_transacao.Location = New Point(152, 99)
        dtp_data_transacao.Name = "dtp_data_transacao"
        dtp_data_transacao.Size = New Size(141, 23)
        dtp_data_transacao.TabIndex = 4
        ' 
        ' lbl_numero_cartao
        ' 
        lbl_numero_cartao.AutoSize = True
        lbl_numero_cartao.Location = New Point(15, 25)
        lbl_numero_cartao.Name = "lbl_numero_cartao"
        lbl_numero_cartao.Size = New Size(89, 15)
        lbl_numero_cartao.TabIndex = 2
        lbl_numero_cartao.Text = "Numero Cartão"
        ' 
        ' lbl_data_transacao
        ' 
        lbl_data_transacao.AutoSize = True
        lbl_data_transacao.Location = New Point(152, 81)
        lbl_data_transacao.Name = "lbl_data_transacao"
        lbl_data_transacao.Size = New Size(31, 15)
        lbl_data_transacao.TabIndex = 6
        lbl_data_transacao.Text = "Data"
        ' 
        ' lbl_valor_transacao
        ' 
        lbl_valor_transacao.AutoSize = True
        lbl_valor_transacao.Location = New Point(15, 81)
        lbl_valor_transacao.Name = "lbl_valor_transacao"
        lbl_valor_transacao.Size = New Size(33, 15)
        lbl_valor_transacao.TabIndex = 5
        lbl_valor_transacao.Text = "Valor"
        ' 
        ' tbx_valor_transacao
        ' 
        tbx_valor_transacao.Location = New Point(15, 99)
        tbx_valor_transacao.MaxLength = 20
        tbx_valor_transacao.Name = "tbx_valor_transacao"
        tbx_valor_transacao.Size = New Size(131, 23)
        tbx_valor_transacao.TabIndex = 3
        ' 
        ' tbx_descricao
        ' 
        tbx_descricao.CharacterCasing = CharacterCasing.Upper
        tbx_descricao.Location = New Point(152, 43)
        tbx_descricao.MaxLength = 255
        tbx_descricao.Name = "tbx_descricao"
        tbx_descricao.Size = New Size(298, 23)
        tbx_descricao.TabIndex = 2
        ' 
        ' lbl_descricao
        ' 
        lbl_descricao.AutoSize = True
        lbl_descricao.Location = New Point(152, 25)
        lbl_descricao.Name = "lbl_descricao"
        lbl_descricao.Size = New Size(58, 15)
        lbl_descricao.TabIndex = 4
        lbl_descricao.Text = "Descrição"
        ' 
        ' tbx_numero_cartao
        ' 
        tbx_numero_cartao.Location = New Point(15, 43)
        tbx_numero_cartao.MaxLength = 16
        tbx_numero_cartao.Name = "tbx_numero_cartao"
        tbx_numero_cartao.Size = New Size(131, 23)
        tbx_numero_cartao.TabIndex = 1
        ' 
        ' btn_novo
        ' 
        btn_novo.Location = New Point(13, 160)
        btn_novo.Name = "btn_novo"
        btn_novo.Size = New Size(75, 23)
        btn_novo.TabIndex = 6
        btn_novo.Text = "Novo"
        btn_novo.UseVisualStyleBackColor = True
        ' 
        ' btn_salvar
        ' 
        btn_salvar.ForeColor = Color.Blue
        btn_salvar.Location = New Point(407, 160)
        btn_salvar.Name = "btn_salvar"
        btn_salvar.Size = New Size(75, 23)
        btn_salvar.TabIndex = 8
        btn_salvar.Text = "&Salvar"
        btn_salvar.UseVisualStyleBackColor = True
        ' 
        ' btn_cancelar
        ' 
        btn_cancelar.ForeColor = Color.Red
        btn_cancelar.Location = New Point(326, 160)
        btn_cancelar.Name = "btn_cancelar"
        btn_cancelar.Size = New Size(75, 23)
        btn_cancelar.TabIndex = 7
        btn_cancelar.Text = "&Cancelar"
        btn_cancelar.UseVisualStyleBackColor = True
        ' 
        ' Form_Cad_Transacoes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(495, 193)
        Controls.Add(btn_cancelar)
        Controls.Add(btn_salvar)
        Controls.Add(btn_novo)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form_Cad_Transacoes"
        Text = "Cadastro de Transações"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbx_numero_cartao As TextBox
    Friend WithEvents tbx_valor_transacao As TextBox
    Friend WithEvents tbx_descricao As TextBox
    Friend WithEvents lbl_numero_cartao As Label
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents lbl_valor_transacao As Label
    Friend WithEvents lbl_data_transacao As Label
    Friend WithEvents dtp_data_transacao As DateTimePicker
    Friend WithEvents lbl_cmb_status_transacao As Label
    Friend WithEvents cmb_status_transacao As ComboBox
    Friend WithEvents btn_novo As Button
    Friend WithEvents btn_salvar As Button
    Friend WithEvents btn_cancelar As Button
End Class
