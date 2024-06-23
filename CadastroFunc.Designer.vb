<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroFunc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroFunc))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minim = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.txt_CPFfunc = New System.Windows.Forms.MaskedTextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_FuncaoFunc = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_nomeFunc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbox_senha = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_senhaFunc = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_usuarioFunc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_cadastrarFunc = New System.Windows.Forms.Button()
        Me.btn_exibirFunc = New System.Windows.Forms.Button()
        Me.btn_deletarFunc = New System.Windows.Forms.Button()
        Me.btn_editarFunc = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_minim)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 65)
        Me.Panel1.TabIndex = 0
        '
        'btn_minim
        '
        Me.btn_minim.FlatAppearance.BorderSize = 0
        Me.btn_minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minim.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minim.ForeColor = System.Drawing.Color.Snow
        Me.btn_minim.Image = CType(resources.GetObject("btn_minim.Image"), System.Drawing.Image)
        Me.btn_minim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minim.Location = New System.Drawing.Point(853, 0)
        Me.btn_minim.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_minim.Name = "btn_minim"
        Me.btn_minim.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btn_minim.Size = New System.Drawing.Size(52, 44)
        Me.btn_minim.TabIndex = 14
        Me.btn_minim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_minim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_minim.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Snow
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(900, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.btn_exit.Size = New System.Drawing.Size(51, 41)
        Me.btn_exit.TabIndex = 12
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CADASTRO DE FUNCIONÁRIO"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(16, 73)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(921, 314)
        Me.Panel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(646, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(257, 25)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "DATA DE NASCIMENTO"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(689, 66)
        Me.DateTimePicker1.MaxDate = New Date(2007, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2007, 1, 1, 0, 0, 0, 0)
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel10.Controls.Add(Me.txt_CPFfunc)
        Me.Panel10.Location = New System.Drawing.Point(28, 155)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(171, 47)
        Me.Panel10.TabIndex = 43
        '
        'txt_CPFfunc
        '
        Me.txt_CPFfunc.Location = New System.Drawing.Point(11, 11)
        Me.txt_CPFfunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_CPFfunc.Mask = "999,999,999-99"
        Me.txt_CPFfunc.Name = "txt_CPFfunc"
        Me.txt_CPFfunc.Size = New System.Drawing.Size(136, 22)
        Me.txt_CPFfunc.TabIndex = 40
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel7.Controls.Add(Me.txt_FuncaoFunc)
        Me.Panel7.Location = New System.Drawing.Point(28, 245)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(216, 47)
        Me.Panel7.TabIndex = 42
        '
        'txt_FuncaoFunc
        '
        Me.txt_FuncaoFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FuncaoFunc.Location = New System.Drawing.Point(15, 10)
        Me.txt_FuncaoFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_FuncaoFunc.Name = "txt_FuncaoFunc"
        Me.txt_FuncaoFunc.Size = New System.Drawing.Size(184, 26)
        Me.txt_FuncaoFunc.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel6.Controls.Add(Me.txt_nomeFunc)
        Me.Panel6.Location = New System.Drawing.Point(28, 55)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(576, 47)
        Me.Panel6.TabIndex = 41
        '
        'txt_nomeFunc
        '
        Me.txt_nomeFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeFunc.Location = New System.Drawing.Point(11, 7)
        Me.txt_nomeFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nomeFunc.Name = "txt_nomeFunc"
        Me.txt_nomeFunc.Size = New System.Drawing.Size(547, 26)
        Me.txt_nomeFunc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FUNÇÃO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CPF"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "NOME"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cbox_senha)
        Me.Panel4.Controls.Add(Me.Panel9)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(16, 394)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(923, 106)
        Me.Panel4.TabIndex = 3
        '
        'cbox_senha
        '
        Me.cbox_senha.AutoSize = True
        Me.cbox_senha.Location = New System.Drawing.Point(756, 57)
        Me.cbox_senha.Margin = New System.Windows.Forms.Padding(4)
        Me.cbox_senha.Name = "cbox_senha"
        Me.cbox_senha.Size = New System.Drawing.Size(147, 20)
        Me.cbox_senha.TabIndex = 15
        Me.cbox_senha.Text = "MOSTRAR SENHA"
        Me.cbox_senha.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel9.Controls.Add(Me.txt_senhaFunc)
        Me.Panel9.Location = New System.Drawing.Point(427, 43)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(321, 47)
        Me.Panel9.TabIndex = 43
        '
        'txt_senhaFunc
        '
        Me.txt_senhaFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senhaFunc.Location = New System.Drawing.Point(15, 10)
        Me.txt_senhaFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_senhaFunc.Name = "txt_senhaFunc"
        Me.txt_senhaFunc.Size = New System.Drawing.Size(287, 26)
        Me.txt_senhaFunc.TabIndex = 2
        Me.txt_senhaFunc.UseSystemPasswordChar = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel8.Controls.Add(Me.txt_usuarioFunc)
        Me.Panel8.Location = New System.Drawing.Point(28, 43)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(321, 47)
        Me.Panel8.TabIndex = 42
        '
        'txt_usuarioFunc
        '
        Me.txt_usuarioFunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuarioFunc.Location = New System.Drawing.Point(15, 9)
        Me.txt_usuarioFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuarioFunc.Name = "txt_usuarioFunc"
        Me.txt_usuarioFunc.Size = New System.Drawing.Size(287, 26)
        Me.txt_usuarioFunc.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SENHA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "USUARIO"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_cadastrarFunc)
        Me.Panel5.Controls.Add(Me.btn_exibirFunc)
        Me.Panel5.Controls.Add(Me.btn_deletarFunc)
        Me.Panel5.Controls.Add(Me.btn_editarFunc)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 507)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(950, 103)
        Me.Panel5.TabIndex = 4
        '
        'btn_cadastrarFunc
        '
        Me.btn_cadastrarFunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_cadastrarFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrarFunc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrarFunc.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrarFunc.Location = New System.Drawing.Point(25, 31)
        Me.btn_cadastrarFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cadastrarFunc.Name = "btn_cadastrarFunc"
        Me.btn_cadastrarFunc.Size = New System.Drawing.Size(219, 42)
        Me.btn_cadastrarFunc.TabIndex = 33
        Me.btn_cadastrarFunc.Text = "CADASTRAR"
        Me.btn_cadastrarFunc.UseVisualStyleBackColor = False
        '
        'btn_exibirFunc
        '
        Me.btn_exibirFunc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_exibirFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exibirFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exibirFunc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exibirFunc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_exibirFunc.Location = New System.Drawing.Point(479, 31)
        Me.btn_exibirFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_exibirFunc.Name = "btn_exibirFunc"
        Me.btn_exibirFunc.Size = New System.Drawing.Size(219, 42)
        Me.btn_exibirFunc.TabIndex = 36
        Me.btn_exibirFunc.Text = "LIMPAR"
        Me.btn_exibirFunc.UseVisualStyleBackColor = False
        '
        'btn_deletarFunc
        '
        Me.btn_deletarFunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btn_deletarFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deletarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deletarFunc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deletarFunc.ForeColor = System.Drawing.Color.Snow
        Me.btn_deletarFunc.Location = New System.Drawing.Point(705, 31)
        Me.btn_deletarFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_deletarFunc.Name = "btn_deletarFunc"
        Me.btn_deletarFunc.Size = New System.Drawing.Size(219, 42)
        Me.btn_deletarFunc.TabIndex = 34
        Me.btn_deletarFunc.Text = "DELETAR"
        Me.btn_deletarFunc.UseVisualStyleBackColor = False
        '
        'btn_editarFunc
        '
        Me.btn_editarFunc.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_editarFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_editarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editarFunc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editarFunc.ForeColor = System.Drawing.Color.White
        Me.btn_editarFunc.Location = New System.Drawing.Point(252, 31)
        Me.btn_editarFunc.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editarFunc.Name = "btn_editarFunc"
        Me.btn_editarFunc.Size = New System.Drawing.Size(219, 42)
        Me.btn_editarFunc.TabIndex = 35
        Me.btn_editarFunc.Text = "EDITAR"
        Me.btn_editarFunc.UseVisualStyleBackColor = False
        '
        'CadastroFunc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(950, 610)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CadastroFunc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadastroFunc"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cadastrarFunc As Button
    Friend WithEvents btn_exibirFunc As Button
    Friend WithEvents btn_deletarFunc As Button
    Friend WithEvents btn_editarFunc As Button
    Friend WithEvents txt_CPFfunc As MaskedTextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_minim As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_nomeFunc As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txt_FuncaoFunc As TextBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txt_senhaFunc As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_usuarioFunc As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cbox_senha As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
End Class
