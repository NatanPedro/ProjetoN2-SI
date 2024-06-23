<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarFornecedor
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarFornecedor))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bt_sairForn = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.txt_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nomeFornecedor = New System.Windows.Forms.MaskedTextBox()
        Me.txt_telFornce = New System.Windows.Forms.MaskedTextBox()
        Me.txt_emailFornce = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 204)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cadastrar Clientes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(277, 316)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(11, 316)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Telefone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(277, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(11, 215)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CPF/CNPJ"
        '
        'bt_sairForn
        '
        Me.bt_sairForn.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bt_sairForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_sairForn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_sairForn.ForeColor = System.Drawing.Color.White
        Me.bt_sairForn.Location = New System.Drawing.Point(228, 438)
        Me.bt_sairForn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.bt_sairForn.Name = "bt_sairForn"
        Me.bt_sairForn.Size = New System.Drawing.Size(200, 42)
        Me.bt_sairForn.TabIndex = 27
        Me.bt_sairForn.Text = "Fechar"
        Me.bt_sairForn.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(20, 438)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(200, 42)
        Me.btn_cadastrar.TabIndex = 26
        Me.btn_cadastrar.Text = "Salvar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'txt_CNPJ
        '
        Me.txt_CNPJ.Location = New System.Drawing.Point(16, 255)
        Me.txt_CNPJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_CNPJ.Mask = "999-999-999-9"
        Me.txt_CNPJ.Name = "txt_CNPJ"
        Me.txt_CNPJ.Size = New System.Drawing.Size(227, 22)
        Me.txt_CNPJ.TabIndex = 28
        '
        'txt_nomeFornecedor
        '
        Me.txt_nomeFornecedor.Location = New System.Drawing.Point(283, 255)
        Me.txt_nomeFornecedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nomeFornecedor.Name = "txt_nomeFornecedor"
        Me.txt_nomeFornecedor.Size = New System.Drawing.Size(277, 22)
        Me.txt_nomeFornecedor.TabIndex = 29
        '
        'txt_telFornce
        '
        Me.txt_telFornce.Location = New System.Drawing.Point(12, 353)
        Me.txt_telFornce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_telFornce.Mask = "00000-9999"
        Me.txt_telFornce.Name = "txt_telFornce"
        Me.txt_telFornce.Size = New System.Drawing.Size(89, 22)
        Me.txt_telFornce.TabIndex = 30
        '
        'txt_emailFornce
        '
        Me.txt_emailFornce.Location = New System.Drawing.Point(283, 353)
        Me.txt_emailFornce.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_emailFornce.Name = "txt_emailFornce"
        Me.txt_emailFornce.Size = New System.Drawing.Size(227, 22)
        Me.txt_emailFornce.TabIndex = 31
        '
        'RegistrarFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 506)
        Me.Controls.Add(Me.txt_emailFornce)
        Me.Controls.Add(Me.txt_telFornce)
        Me.Controls.Add(Me.txt_nomeFornecedor)
        Me.Controls.Add(Me.txt_CNPJ)
        Me.Controls.Add(Me.bt_sairForn)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "RegistrarFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Fornecedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bt_sairForn As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents txt_CNPJ As MaskedTextBox
    Friend WithEvents txt_nomeFornecedor As MaskedTextBox
    Friend WithEvents txt_telFornce As MaskedTextBox
    Friend WithEvents txt_emailFornce As MaskedTextBox
End Class
