<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Analise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Analise))
        GroupBox4 = New GroupBox()
        dgv_ResumoFinanceiro = New DataGridView()
        dgv_AnaliseFinanceira = New DataGridView()
        Label1 = New Label()
        dtp_data_transacao_final = New DateTimePicker()
        lbl_data_transacao = New Label()
        dtp_data_transacao_inicial = New DateTimePicker()
        btn_consultar = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox4.SuspendLayout()
        CType(dgv_ResumoFinanceiro, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_AnaliseFinanceira, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox4.Controls.Add(dgv_ResumoFinanceiro)
        GroupBox4.Location = New Point(12, 83)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(866, 132)
        GroupBox4.TabIndex = 26
        GroupBox4.TabStop = False
        GroupBox4.Text = "Resumo Financeiro"
        ' 
        ' dgv_ResumoFinanceiro
        ' 
        dgv_ResumoFinanceiro.AllowUserToAddRows = False
        dgv_ResumoFinanceiro.AllowUserToDeleteRows = False
        dgv_ResumoFinanceiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_ResumoFinanceiro.BackgroundColor = SystemColors.ControlDarkDark
        dgv_ResumoFinanceiro.BorderStyle = BorderStyle.Fixed3D
        dgv_ResumoFinanceiro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_ResumoFinanceiro.Dock = DockStyle.Fill
        dgv_ResumoFinanceiro.Location = New Point(3, 19)
        dgv_ResumoFinanceiro.Name = "dgv_ResumoFinanceiro"
        dgv_ResumoFinanceiro.ReadOnly = True
        dgv_ResumoFinanceiro.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_ResumoFinanceiro.Size = New Size(860, 110)
        dgv_ResumoFinanceiro.TabIndex = 18
        ' 
        ' dgv_AnaliseFinanceira
        ' 
        dgv_AnaliseFinanceira.AllowUserToAddRows = False
        dgv_AnaliseFinanceira.AllowUserToDeleteRows = False
        dgv_AnaliseFinanceira.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv_AnaliseFinanceira.BackgroundColor = SystemColors.ControlDarkDark
        dgv_AnaliseFinanceira.BorderStyle = BorderStyle.Fixed3D
        dgv_AnaliseFinanceira.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_AnaliseFinanceira.Dock = DockStyle.Fill
        dgv_AnaliseFinanceira.Location = New Point(3, 19)
        dgv_AnaliseFinanceira.Name = "dgv_AnaliseFinanceira"
        dgv_AnaliseFinanceira.ReadOnly = True
        dgv_AnaliseFinanceira.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_AnaliseFinanceira.Size = New Size(860, 196)
        dgv_AnaliseFinanceira.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(116, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 37
        Label1.Text = "Data Final"
        ' 
        ' dtp_data_transacao_final
        ' 
        dtp_data_transacao_final.Format = DateTimePickerFormat.Short
        dtp_data_transacao_final.Location = New Point(116, 38)
        dtp_data_transacao_final.Name = "dtp_data_transacao_final"
        dtp_data_transacao_final.Size = New Size(100, 23)
        dtp_data_transacao_final.TabIndex = 36
        ' 
        ' lbl_data_transacao
        ' 
        lbl_data_transacao.AutoSize = True
        lbl_data_transacao.Location = New Point(10, 20)
        lbl_data_transacao.Name = "lbl_data_transacao"
        lbl_data_transacao.Size = New Size(65, 15)
        lbl_data_transacao.TabIndex = 35
        lbl_data_transacao.Text = "Data Inicial"
        ' 
        ' dtp_data_transacao_inicial
        ' 
        dtp_data_transacao_inicial.Format = DateTimePickerFormat.Short
        dtp_data_transacao_inicial.Location = New Point(10, 38)
        dtp_data_transacao_inicial.Name = "dtp_data_transacao_inicial"
        dtp_data_transacao_inicial.Size = New Size(100, 23)
        dtp_data_transacao_inicial.TabIndex = 32
        ' 
        ' btn_consultar
        ' 
        btn_consultar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_consultar.Location = New Point(767, 17)
        btn_consultar.Name = "btn_consultar"
        btn_consultar.Size = New Size(93, 44)
        btn_consultar.TabIndex = 25
        btn_consultar.Text = "&Consultar"
        btn_consultar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btn_consultar)
        GroupBox1.Controls.Add(dtp_data_transacao_final)
        GroupBox1.Controls.Add(dtp_data_transacao_inicial)
        GroupBox1.Controls.Add(lbl_data_transacao)
        GroupBox1.Location = New Point(12, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(866, 73)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Dados"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.Controls.Add(dgv_AnaliseFinanceira)
        GroupBox2.Location = New Point(12, 221)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(866, 218)
        GroupBox2.TabIndex = 28
        GroupBox2.TabStop = False
        GroupBox2.Text = "Analise Financeira"
        ' 
        ' Form_Analise
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 451)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox4)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form_Analise"
        Text = "Análise de Transações"
        GroupBox4.ResumeLayout(False)
        CType(dgv_ResumoFinanceiro, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_AnaliseFinanceira, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_consultar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_data_transacao_final As DateTimePicker
    Friend WithEvents dtp_data_transacao_inicial As DateTimePicker
    Friend WithEvents lbl_data_transacao As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_AnaliseFinanceira As DataGridView
    Friend WithEvents dgv_ResumoFinanceiro As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
End Class
