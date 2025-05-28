<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PsqTransacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PsqTransacoes))
        lbl_cmb_status_transacao = New Label()
        cmbStatus = New ComboBox()
        dtInicio = New DateTimePicker()
        lbl_numero_cartao = New Label()
        lbl_data_transacao = New Label()
        txtDescricao = New TextBox()
        lbl_descricao = New Label()
        txtNumCartao = New TextBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        dtFim = New DateTimePicker()
        gridTransacoes = New DataGridView()
        GroupBox3 = New GroupBox()
        btnExport = New Button()
        btnDeletar = New Button()
        btnEditar = New Button()
        btnPesquisa = New Button()
        GroupBox5 = New GroupBox()
        lblIndex = New Label()
        btnAnterior = New Button()
        btnProximo = New Button()
        GroupBox1.SuspendLayout()
        CType(gridTransacoes, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox5.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbl_cmb_status_transacao
        ' 
        lbl_cmb_status_transacao.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_cmb_status_transacao.AutoSize = True
        lbl_cmb_status_transacao.Location = New Point(701, 22)
        lbl_cmb_status_transacao.Margin = New Padding(4, 0, 4, 0)
        lbl_cmb_status_transacao.Name = "lbl_cmb_status_transacao"
        lbl_cmb_status_transacao.Size = New Size(39, 15)
        lbl_cmb_status_transacao.TabIndex = 7
        lbl_cmb_status_transacao.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FlatStyle = FlatStyle.Popup
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Todos", "Aprovada", "Pendente", "Cancelada"})
        cmbStatus.Location = New Point(701, 40)
        cmbStatus.Margin = New Padding(4, 3, 4, 3)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(148, 23)
        cmbStatus.TabIndex = 13
        ' 
        ' dtInicio
        ' 
        dtInicio.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtInicio.Format = DateTimePickerFormat.Short
        dtInicio.Location = New Point(489, 40)
        dtInicio.Margin = New Padding(4, 3, 4, 3)
        dtInicio.Name = "dtInicio"
        dtInicio.Size = New Size(100, 23)
        dtInicio.TabIndex = 11
        ' 
        ' lbl_numero_cartao
        ' 
        lbl_numero_cartao.AutoSize = True
        lbl_numero_cartao.Location = New Point(6, 22)
        lbl_numero_cartao.Margin = New Padding(4, 0, 4, 0)
        lbl_numero_cartao.Name = "lbl_numero_cartao"
        lbl_numero_cartao.Size = New Size(89, 15)
        lbl_numero_cartao.TabIndex = 9
        lbl_numero_cartao.Text = "Numero Cartão"
        ' 
        ' lbl_data_transacao
        ' 
        lbl_data_transacao.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbl_data_transacao.AutoSize = True
        lbl_data_transacao.Location = New Point(489, 22)
        lbl_data_transacao.Margin = New Padding(4, 0, 4, 0)
        lbl_data_transacao.Name = "lbl_data_transacao"
        lbl_data_transacao.Size = New Size(65, 15)
        lbl_data_transacao.TabIndex = 14
        lbl_data_transacao.Text = "Data Inicial"
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtDescricao.CharacterCasing = CharacterCasing.Upper
        txtDescricao.Location = New Point(144, 40)
        txtDescricao.Margin = New Padding(4, 3, 4, 3)
        txtDescricao.MaxLength = 255
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(340, 23)
        txtDescricao.TabIndex = 10
        ' 
        ' lbl_descricao
        ' 
        lbl_descricao.AutoSize = True
        lbl_descricao.Location = New Point(144, 22)
        lbl_descricao.Margin = New Padding(4, 0, 4, 0)
        lbl_descricao.Name = "lbl_descricao"
        lbl_descricao.Size = New Size(58, 15)
        lbl_descricao.TabIndex = 12
        lbl_descricao.Text = "Descrição"
        ' 
        ' txtNumCartao
        ' 
        txtNumCartao.Location = New Point(6, 40)
        txtNumCartao.Margin = New Padding(4, 3, 4, 3)
        txtNumCartao.MaxLength = 16
        txtNumCartao.Name = "txtNumCartao"
        txtNumCartao.Size = New Size(131, 23)
        txtNumCartao.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtFim)
        GroupBox1.Controls.Add(txtNumCartao)
        GroupBox1.Controls.Add(lbl_cmb_status_transacao)
        GroupBox1.Controls.Add(lbl_numero_cartao)
        GroupBox1.Controls.Add(cmbStatus)
        GroupBox1.Controls.Add(txtDescricao)
        GroupBox1.Controls.Add(dtInicio)
        GroupBox1.Controls.Add(lbl_data_transacao)
        GroupBox1.Controls.Add(lbl_descricao)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(855, 76)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados da Consulta"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(595, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 16
        Label1.Text = "Data Final"
        ' 
        ' dtFim
        ' 
        dtFim.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        dtFim.Format = DateTimePickerFormat.Short
        dtFim.Location = New Point(595, 40)
        dtFim.Margin = New Padding(4, 3, 4, 3)
        dtFim.Name = "dtFim"
        dtFim.Size = New Size(100, 23)
        dtFim.TabIndex = 15
        ' 
        ' gridTransacoes
        ' 
        gridTransacoes.AllowUserToAddRows = False
        gridTransacoes.AllowUserToDeleteRows = False
        gridTransacoes.AllowUserToResizeColumns = False
        gridTransacoes.AllowUserToResizeRows = False
        gridTransacoes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gridTransacoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gridTransacoes.BackgroundColor = SystemColors.ControlDarkDark
        gridTransacoes.BorderStyle = BorderStyle.Fixed3D
        gridTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridTransacoes.Location = New Point(6, 15)
        gridTransacoes.Margin = New Padding(4, 3, 4, 3)
        gridTransacoes.Name = "gridTransacoes"
        gridTransacoes.ReadOnly = True
        gridTransacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridTransacoes.Size = New Size(924, 393)
        gridTransacoes.TabIndex = 16
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        GroupBox3.Controls.Add(btnExport)
        GroupBox3.Controls.Add(btnDeletar)
        GroupBox3.Controls.Add(btnEditar)
        GroupBox3.Location = New Point(12, 546)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(936, 60)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        ' 
        ' btnExport
        ' 
        btnExport.ForeColor = Color.Black
        btnExport.Location = New Point(724, 18)
        btnExport.Margin = New Padding(4, 3, 4, 3)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(62, 33)
        btnExport.TabIndex = 1
        btnExport.Text = "Exportar"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnDeletar
        ' 
        btnDeletar.ForeColor = Color.Red
        btnDeletar.Location = New Point(793, 18)
        btnDeletar.Margin = New Padding(4, 3, 4, 3)
        btnDeletar.Name = "btnDeletar"
        btnDeletar.Size = New Size(62, 33)
        btnDeletar.TabIndex = 1
        btnDeletar.Text = "&Deletar"
        btnDeletar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.ForeColor = Color.Blue
        btnEditar.Location = New Point(861, 18)
        btnEditar.Margin = New Padding(4, 3, 4, 3)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(62, 33)
        btnEditar.TabIndex = 0
        btnEditar.Text = "&Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnPesquisa
        ' 
        btnPesquisa.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPesquisa.Location = New Point(873, 21)
        btnPesquisa.Margin = New Padding(4, 3, 4, 3)
        btnPesquisa.Name = "btnPesquisa"
        btnPesquisa.Size = New Size(75, 67)
        btnPesquisa.TabIndex = 19
        btnPesquisa.Text = "&Consultar"
        btnPesquisa.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox5.Controls.Add(lblIndex)
        GroupBox5.Controls.Add(btnAnterior)
        GroupBox5.Controls.Add(btnProximo)
        GroupBox5.Controls.Add(gridTransacoes)
        GroupBox5.Location = New Point(12, 88)
        GroupBox5.Margin = New Padding(4, 3, 4, 3)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Padding = New Padding(4, 3, 4, 3)
        GroupBox5.Size = New Size(936, 457)
        GroupBox5.TabIndex = 21
        GroupBox5.TabStop = False
        ' 
        ' lblIndex
        ' 
        lblIndex.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblIndex.AutoSize = True
        lblIndex.Location = New Point(8, 424)
        lblIndex.Margin = New Padding(4, 0, 4, 0)
        lblIndex.Name = "lblIndex"
        lblIndex.Size = New Size(61, 15)
        lblIndex.TabIndex = 19
        lblIndex.Text = "Página:   0"
        ' 
        ' btnAnterior
        ' 
        btnAnterior.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnAnterior.ForeColor = Color.Purple
        btnAnterior.Location = New Point(800, 415)
        btnAnterior.Margin = New Padding(4, 3, 4, 3)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(62, 33)
        btnAnterior.TabIndex = 18
        btnAnterior.Text = "<<<"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' btnProximo
        ' 
        btnProximo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnProximo.ForeColor = Color.Purple
        btnProximo.Location = New Point(868, 415)
        btnProximo.Margin = New Padding(4, 3, 4, 3)
        btnProximo.Name = "btnProximo"
        btnProximo.Size = New Size(62, 33)
        btnProximo.TabIndex = 17
        btnProximo.Text = ">>>"
        btnProximo.UseVisualStyleBackColor = True
        ' 
        ' Form_PsqTransacoes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(960, 618)
        Controls.Add(GroupBox5)
        Controls.Add(btnPesquisa)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form_PsqTransacoes"
        Text = "Pesquisa de Transações"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(gridTransacoes, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbl_cmb_status_transacao As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents lbl_numero_cartao As Label
    Friend WithEvents lbl_data_transacao As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents txtNumCartao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gridTransacoes As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtFim As DateTimePicker
    Friend WithEvents btnExport As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblIndex As Label
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnProximo As Button
End Class
