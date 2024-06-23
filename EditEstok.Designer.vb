<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEstok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditEstok))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_precoProduto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_custoProduto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_categoriaProdutos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nomeProduto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.btn_buscarFoto = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_photo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txt_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 118)
        Me.Panel1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(4, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 37)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Editar Estoque"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 263)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "R$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 263)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "R$"
        '
        'txt_precoProduto
        '
        Me.txt_precoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_precoProduto.Location = New System.Drawing.Point(479, 260)
        Me.txt_precoProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_precoProduto.Name = "txt_precoProduto"
        Me.txt_precoProduto.Size = New System.Drawing.Size(227, 26)
        Me.txt_precoProduto.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(473, 231)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Preço de Venda"
        '
        'txt_custoProduto
        '
        Me.txt_custoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custoProduto.Location = New System.Drawing.Point(204, 260)
        Me.txt_custoProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_custoProduto.Name = "txt_custoProduto"
        Me.txt_custoProduto.Size = New System.Drawing.Size(227, 26)
        Me.txt_custoProduto.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(203, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Custo"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(11, 260)
        Me.txt_quantidade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(113, 22)
        Me.txt_quantidade.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(5, 231)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Quantidade"
        '
        'txt_categoriaProdutos
        '
        Me.txt_categoriaProdutos.Location = New System.Drawing.Point(277, 171)
        Me.txt_categoriaProdutos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_categoriaProdutos.Name = "txt_categoriaProdutos"
        Me.txt_categoriaProdutos.Size = New System.Drawing.Size(227, 22)
        Me.txt_categoriaProdutos.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(272, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Categoria"
        '
        'txt_nomeProduto
        '
        Me.txt_nomeProduto.Location = New System.Drawing.Point(11, 171)
        Me.txt_nomeProduto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_nomeProduto.Multiline = True
        Me.txt_nomeProduto.Name = "txt_nomeProduto"
        Me.txt_nomeProduto.Size = New System.Drawing.Size(227, 24)
        Me.txt_nomeProduto.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(5, 143)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nome"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(277, 350)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 42)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(68, 350)
        Me.btn_cadastrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(200, 42)
        Me.btn_cadastrar.TabIndex = 35
        Me.btn_cadastrar.Text = "Salvar"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'btn_buscarFoto
        '
        Me.btn_buscarFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_buscarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscarFoto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscarFoto.ForeColor = System.Drawing.Color.White
        Me.btn_buscarFoto.Location = New System.Drawing.Point(821, 388)
        Me.btn_buscarFoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_buscarFoto.Name = "btn_buscarFoto"
        Me.btn_buscarFoto.Size = New System.Drawing.Size(200, 42)
        Me.btn_buscarFoto.TabIndex = 38
        Me.btn_buscarFoto.Text = " Buscar foto"
        Me.btn_buscarFoto.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Controls.Add(Me.txt_photo)
        Me.Panel3.Location = New System.Drawing.Point(787, 126)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 255)
        Me.Panel3.TabIndex = 37
        '
        'txt_photo
        '
        Me.txt_photo.BackColor = System.Drawing.Color.Snow
        Me.txt_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_photo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_photo.Location = New System.Drawing.Point(19, 14)
        Me.txt_photo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_photo.Name = "txt_photo"
        Me.txt_photo.Size = New System.Drawing.Size(230, 226)
        Me.txt_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.txt_photo.TabIndex = 8
        Me.txt_photo.TabStop = False
        '
        'EditEstok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 444)
        Me.Controls.Add(Me.btn_buscarFoto)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_precoProduto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_custoProduto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_categoriaProdutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nomeProduto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EditEstok"
        Me.Text = "EditEstok"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.txt_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_precoProduto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_custoProduto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_categoriaProdutos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nomeProduto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents btn_buscarFoto As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_photo As PictureBox
End Class
