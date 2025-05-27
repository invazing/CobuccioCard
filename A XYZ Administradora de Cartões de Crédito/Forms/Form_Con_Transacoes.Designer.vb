<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Con_Transacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Con_Transacoes))
        lbl_cmb_status_transacao = New Label()
        cmb_status_transacao = New ComboBox()
        dtp_data_transacao_inicial = New DateTimePicker()
        lbl_numero_cartao = New Label()
        lbl_data_transacao = New Label()
        tbx_descricao = New TextBox()
        lbl_descricao = New Label()
        tbx_numero_cartao = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        dtp_data_transacao_final = New DateTimePicker()
        dgv_transacoes = New DataGridView()
        GroupBox2 = New GroupBox()
        lbl_valor_total = New Label()
        lbl_registro_total = New Label()
        GroupBox3 = New GroupBox()
        btn_deletar = New Button()
        btn_editar = New Button()
        btn_consultar = New Button()
        GroupBox4 = New GroupBox()
        btn_export_excel = New Button()
        GroupBox5 = New GroupBox()
        lbl_index = New Label()
        btn_pag_anterior = New Button()
        btn_pag_proxima = New Button()
        GroupBox1.SuspendLayout()
        CType(dgv_transacoes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_cmb_status_transacao
        ' 
        lbl_cmb_status_transacao.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_cmb_status_transacao.AutoSize = True
        lbl_cmb_status_transacao.Location = New Point(655, 22)
        lbl_cmb_status_transacao.Name = "lbl_cmb_status_transacao"
        lbl_cmb_status_transacao.Size = New Size(39, 15)
        lbl_cmb_status_transacao.TabIndex = 7
        lbl_cmb_status_transacao.Text = "Status"
        ' 
        ' cmb_status_transacao
        ' 
        cmb_status_transacao.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmb_status_transacao.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_status_transacao.FlatStyle = FlatStyle.Popup
        cmb_status_transacao.FormattingEnabled = True
        cmb_status_transacao.Items.AddRange(New Object() {"Aprovada", "Pendente", "Cancelada"})
        cmb_status_transacao.Location = New Point(655, 40)
        cmb_status_transacao.Name = "cmb_status_transacao"
        cmb_status_transacao.Size = New Size(121, 23)
        cmb_status_transacao.TabIndex = 13
        ' 
        ' dtp_data_transacao_inicial
        ' 
        dtp_data_transacao_inicial.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtp_data_transacao_inicial.Format = DateTimePickerFormat.Short
        dtp_data_transacao_inicial.Location = New Point(443, 40)
        dtp_data_transacao_inicial.Name = "dtp_data_transacao_inicial"
        dtp_data_transacao_inicial.Size = New Size(100, 23)
        dtp_data_transacao_inicial.TabIndex = 11
        ' 
        ' lbl_numero_cartao
        ' 
        lbl_numero_cartao.AutoSize = True
        lbl_numero_cartao.Location = New Point(6, 22)
        lbl_numero_cartao.Name = "lbl_numero_cartao"
        lbl_numero_cartao.Size = New Size(89, 15)
        lbl_numero_cartao.TabIndex = 9
        lbl_numero_cartao.Text = "Numero Cartão"
        ' 
        ' lbl_data_transacao
        ' 
        lbl_data_transacao.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_data_transacao.AutoSize = True
        lbl_data_transacao.Location = New Point(443, 22)
        lbl_data_transacao.Name = "lbl_data_transacao"
        lbl_data_transacao.Size = New Size(65, 15)
        lbl_data_transacao.TabIndex = 14
        lbl_data_transacao.Text = "Data Inicial"
        ' 
        ' tbx_descricao
        ' 
        tbx_descricao.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        tbx_descricao.CharacterCasing = CharacterCasing.Upper
        tbx_descricao.Location = New Point(143, 40)
        tbx_descricao.MaxLength = 255
        tbx_descricao.Name = "tbx_descricao"
        tbx_descricao.Size = New Size(294, 23)
        tbx_descricao.TabIndex = 10
        ' 
        ' lbl_descricao
        ' 
        lbl_descricao.AutoSize = True
        lbl_descricao.Location = New Point(143, 22)
        lbl_descricao.Name = "lbl_descricao"
        lbl_descricao.Size = New Size(58, 15)
        lbl_descricao.TabIndex = 12
        lbl_descricao.Text = "Descrição"
        ' 
        ' tbx_numero_cartao
        ' 
        tbx_numero_cartao.Location = New Point(6, 40)
        tbx_numero_cartao.MaxLength = 16
        tbx_numero_cartao.Name = "tbx_numero_cartao"
        tbx_numero_cartao.Size = New Size(131, 23)
        tbx_numero_cartao.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtp_data_transacao_final)
        GroupBox1.Controls.Add(tbx_numero_cartao)
        GroupBox1.Controls.Add(lbl_cmb_status_transacao)
        GroupBox1.Controls.Add(lbl_numero_cartao)
        GroupBox1.Controls.Add(cmb_status_transacao)
        GroupBox1.Controls.Add(tbx_descricao)
        GroupBox1.Controls.Add(dtp_data_transacao_inicial)
        GroupBox1.Controls.Add(lbl_data_transacao)
        GroupBox1.Controls.Add(lbl_descricao)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(785, 76)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados da Consulta"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(549, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 16
        Label1.Text = "Data Final"
        ' 
        ' dtp_data_transacao_final
        ' 
        dtp_data_transacao_final.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtp_data_transacao_final.Format = DateTimePickerFormat.Short
        dtp_data_transacao_final.Location = New Point(549, 40)
        dtp_data_transacao_final.Name = "dtp_data_transacao_final"
        dtp_data_transacao_final.Size = New Size(100, 23)
        dtp_data_transacao_final.TabIndex = 15
        ' 
        ' dgv_transacoes
        ' 
        dgv_transacoes.AllowUserToAddRows = False
        dgv_transacoes.AllowUserToDeleteRows = False
        dgv_transacoes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgv_transacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_transacoes.BackgroundColor = SystemColors.ControlDarkDark
        dgv_transacoes.BorderStyle = BorderStyle.Fixed3D
        dgv_transacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_transacoes.Location = New Point(6, 15)
        dgv_transacoes.Name = "dgv_transacoes"
        dgv_transacoes.ReadOnly = True
        dgv_transacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_transacoes.Size = New Size(854, 189)
        dgv_transacoes.TabIndex = 16
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(lbl_valor_total)
        GroupBox2.Controls.Add(lbl_registro_total)
        GroupBox2.Location = New Point(12, 346)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(525, 60)
        GroupBox2.TabIndex = 17
        GroupBox2.TabStop = False
        GroupBox2.Text = "Informações Adicionais"
        ' 
        ' lbl_valor_total
        ' 
        lbl_valor_total.AutoSize = True
        lbl_valor_total.Location = New Point(6, 38)
        lbl_valor_total.Name = "lbl_valor_total"
        lbl_valor_total.Size = New Size(86, 15)
        lbl_valor_total.TabIndex = 1
        lbl_valor_total.Text = "VALOR TOTAL: "
        ' 
        ' lbl_registro_total
        ' 
        lbl_registro_total.AutoSize = True
        lbl_registro_total.Location = New Point(6, 19)
        lbl_registro_total.Name = "lbl_registro_total"
        lbl_registro_total.Size = New Size(72, 15)
        lbl_registro_total.TabIndex = 0
        lbl_registro_total.Text = "REGISTROS: "
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox3.Controls.Add(btn_deletar)
        GroupBox3.Controls.Add(btn_editar)
        GroupBox3.Location = New Point(667, 346)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(211, 60)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Gestão"
        ' 
        ' btn_deletar
        ' 
        btn_deletar.ForeColor = Color.Red
        btn_deletar.Location = New Point(11, 21)
        btn_deletar.Name = "btn_deletar"
        btn_deletar.Size = New Size(94, 32)
        btn_deletar.TabIndex = 1
        btn_deletar.Text = "&Deletar"
        btn_deletar.UseVisualStyleBackColor = True
        ' 
        ' btn_editar
        ' 
        btn_editar.ForeColor = Color.Blue
        btn_editar.Location = New Point(111, 20)
        btn_editar.Name = "btn_editar"
        btn_editar.Size = New Size(94, 34)
        btn_editar.TabIndex = 0
        btn_editar.Text = "&Editar"
        btn_editar.UseVisualStyleBackColor = True
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_consultar.Location = New Point(803, 21)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(75, 67)
        btn_consultar.TabIndex = 19
        btn_consultar.Text = "&Consultar"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox4.Controls.Add(btn_export_excel)
        GroupBox4.Location = New Point(543, 346)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(118, 60)
        GroupBox4.TabIndex = 20
        GroupBox4.TabStop = False
        GroupBox4.Text = "Analise de Dados"
        ' 
        ' btn_export_excel
        ' 
        btn_export_excel.ForeColor = Color.ForestGreen
        btn_export_excel.Location = New Point(12, 21)
        btn_export_excel.Name = "btn_export_excel"
        btn_export_excel.Size = New Size(94, 32)
        btn_export_excel.TabIndex = 1
        btn_export_excel.Text = "Excel"
        btn_export_excel.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(lbl_index)
        GroupBox5.Controls.Add(btn_pag_anterior)
        GroupBox5.Controls.Add(btn_pag_proxima)
        GroupBox5.Controls.Add(dgv_transacoes)
        GroupBox5.Location = New Point(12, 88)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(866, 252)
        GroupBox5.TabIndex = 21
        GroupBox5.TabStop = False
        ' 
        ' lbl_index
        ' 
        lbl_index.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_index.AutoSize = True
        lbl_index.Location = New Point(6, 219)
        lbl_index.Name = "lbl_index"
        lbl_index.Size = New Size(35, 15)
        lbl_index.TabIndex = 19
        lbl_index.Text = "Index"
        ' 
        ' btn_pag_anterior
        ' 
        btn_pag_anterior.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_pag_anterior.ForeColor = Color.Purple
        btn_pag_anterior.Location = New Point(704, 210)
        btn_pag_anterior.Name = "btn_pag_anterior"
        btn_pag_anterior.Size = New Size(75, 32)
        btn_pag_anterior.TabIndex = 18
        btn_pag_anterior.Text = "<<<"
        btn_pag_anterior.UseVisualStyleBackColor = True
        ' 
        ' btn_pag_proxima
        ' 
        btn_pag_proxima.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_pag_proxima.ForeColor = Color.Purple
        btn_pag_proxima.Location = New Point(785, 210)
        btn_pag_proxima.Name = "btn_pag_proxima"
        btn_pag_proxima.Size = New Size(75, 32)
        btn_pag_proxima.TabIndex = 17
        btn_pag_proxima.Text = ">>>"
        btn_pag_proxima.UseVisualStyleBackColor = True
        ' 
        ' Form_Con_Transacoes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 413)
        Controls.Add(GroupBox5)
        Controls.Add(GroupBox4)
        Controls.Add(btn_consultar)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form_Con_Transacoes"
        Text = "Consulta de Transações"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgv_transacoes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl_cmb_status_transacao As Label
    Friend WithEvents cmb_status_transacao As ComboBox
    Friend WithEvents dtp_data_transacao_inicial As DateTimePicker
    Friend WithEvents lbl_numero_cartao As Label
    Friend WithEvents lbl_data_transacao As Label
    Friend WithEvents tbx_descricao As TextBox
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents tbx_numero_cartao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_transacoes As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_deletar As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_consultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_data_transacao_final As DateTimePicker
    Friend WithEvents lbl_valor_total As Label
    Friend WithEvents lbl_registro_total As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_export_excel As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_index As Label
    Friend WithEvents btn_pag_anterior As Button
    Friend WithEvents btn_pag_proxima As Button
End Class
