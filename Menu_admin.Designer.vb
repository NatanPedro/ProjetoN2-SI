<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_admin
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
        Dim btn_retornar As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cadastroFunc = New System.Windows.Forms.Button()
        Me.btn_estoque = New System.Windows.Forms.Button()
        Me.btn_compras = New System.Windows.Forms.Button()
        Me.btn_pedidos = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Circular1 = New WindowsApp1.Circular()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.btn_minim = New System.Windows.Forms.Button()
        Me.btn_full = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_message = New System.Windows.Forms.Button()
        Me.panel_dashboard = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        btn_retornar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Circular1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.panel_dashboard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_retornar
        '
        btn_retornar.Cursor = System.Windows.Forms.Cursors.Hand
        btn_retornar.Dock = System.Windows.Forms.DockStyle.Bottom
        btn_retornar.FlatAppearance.BorderSize = 0
        btn_retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btn_retornar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btn_retornar.ForeColor = System.Drawing.Color.Snow
        btn_retornar.Image = CType(resources.GetObject("btn_retornar.Image"), System.Drawing.Image)
        btn_retornar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btn_retornar.Location = New System.Drawing.Point(0, 462)
        btn_retornar.Name = "btn_retornar"
        btn_retornar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        btn_retornar.Size = New System.Drawing.Size(165, 36)
        btn_retornar.TabIndex = 9
        btn_retornar.Text = "          Sair"
        btn_retornar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btn_retornar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        btn_retornar.UseVisualStyleBackColor = True
        AddHandler btn_retornar.Click, AddressOf Me.btn_retornar_Click
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_cadastroFunc)
        Me.Panel1.Controls.Add(btn_retornar)
        Me.Panel1.Controls.Add(Me.btn_estoque)
        Me.Panel1.Controls.Add(Me.btn_compras)
        Me.Panel1.Controls.Add(Me.btn_pedidos)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 500)
        Me.Panel1.TabIndex = 0
        '
        'btn_cadastroFunc
        '
        Me.btn_cadastroFunc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastroFunc.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_cadastroFunc.FlatAppearance.BorderSize = 0
        Me.btn_cadastroFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cadastroFunc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastroFunc.ForeColor = System.Drawing.Color.Snow
        Me.btn_cadastroFunc.Image = CType(resources.GetObject("btn_cadastroFunc.Image"), System.Drawing.Image)
        Me.btn_cadastroFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastroFunc.Location = New System.Drawing.Point(0, 251)
        Me.btn_cadastroFunc.Name = "btn_cadastroFunc"
        Me.btn_cadastroFunc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_cadastroFunc.Size = New System.Drawing.Size(165, 36)
        Me.btn_cadastroFunc.TabIndex = 10
        Me.btn_cadastroFunc.Text = "  Usuarios"
        Me.btn_cadastroFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastroFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cadastroFunc.UseVisualStyleBackColor = True
        '
        'btn_estoque
        '
        Me.btn_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_estoque.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_estoque.FlatAppearance.BorderSize = 0
        Me.btn_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_estoque.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_estoque.ForeColor = System.Drawing.Color.Snow
        Me.btn_estoque.Image = CType(resources.GetObject("btn_estoque.Image"), System.Drawing.Image)
        Me.btn_estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estoque.Location = New System.Drawing.Point(0, 215)
        Me.btn_estoque.Name = "btn_estoque"
        Me.btn_estoque.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_estoque.Size = New System.Drawing.Size(165, 36)
        Me.btn_estoque.TabIndex = 5
        Me.btn_estoque.Text = "  Estoque"
        Me.btn_estoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_estoque.UseVisualStyleBackColor = True
        '
        'btn_compras
        '
        Me.btn_compras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_compras.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_compras.FlatAppearance.BorderSize = 0
        Me.btn_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_compras.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compras.ForeColor = System.Drawing.Color.Snow
        Me.btn_compras.Image = CType(resources.GetObject("btn_compras.Image"), System.Drawing.Image)
        Me.btn_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_compras.Location = New System.Drawing.Point(0, 179)
        Me.btn_compras.Name = "btn_compras"
        Me.btn_compras.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_compras.Size = New System.Drawing.Size(165, 36)
        Me.btn_compras.TabIndex = 4
        Me.btn_compras.Text = "  Clientes"
        Me.btn_compras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_compras.UseVisualStyleBackColor = True
        '
        'btn_pedidos
        '
        Me.btn_pedidos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pedidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_pedidos.FlatAppearance.BorderSize = 0
        Me.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pedidos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pedidos.ForeColor = System.Drawing.Color.Snow
        Me.btn_pedidos.Image = CType(resources.GetObject("btn_pedidos.Image"), System.Drawing.Image)
        Me.btn_pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_pedidos.Location = New System.Drawing.Point(0, 143)
        Me.btn_pedidos.Name = "btn_pedidos"
        Me.btn_pedidos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_pedidos.Size = New System.Drawing.Size(165, 36)
        Me.btn_pedidos.TabIndex = 3
        Me.btn_pedidos.Text = "  Pedidos"
        Me.btn_pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_pedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_pedidos.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_home.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.Snow
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(0, 107)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_home.Size = New System.Drawing.Size(165, 36)
        Me.btn_home.TabIndex = 2
        Me.btn_home.Text = "  Home"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Circular1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 61)
        Me.Panel4.TabIndex = 1
        '
        'Circular1
        '
        Me.Circular1.Location = New System.Drawing.Point(145, 51)
        Me.Circular1.Name = "Circular1"
        Me.Circular1.Size = New System.Drawing.Size(100, 50)
        Me.Circular1.TabIndex = 1
        Me.Circular1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 46)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MetroDateTime1)
        Me.Panel3.Controls.Add(Me.btn_minim)
        Me.Panel3.Controls.Add(Me.btn_full)
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Controls.Add(Me.btn_message)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(167, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1113, 46)
        Me.Panel3.TabIndex = 1
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.MetroDateTime1.Location = New System.Drawing.Point(104, 7)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 30)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(83, 30)
        Me.MetroDateTime1.TabIndex = 14
        Me.MetroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'btn_minim
        '
        Me.btn_minim.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minim.FlatAppearance.BorderSize = 0
        Me.btn_minim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minim.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minim.ForeColor = System.Drawing.Color.Snow
        Me.btn_minim.Image = CType(resources.GetObject("btn_minim.Image"), System.Drawing.Image)
        Me.btn_minim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_minim.Location = New System.Drawing.Point(985, 0)
        Me.btn_minim.Name = "btn_minim"
        Me.btn_minim.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_minim.Size = New System.Drawing.Size(39, 36)
        Me.btn_minim.TabIndex = 13
        Me.btn_minim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_minim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_minim.UseVisualStyleBackColor = True
        '
        'btn_full
        '
        Me.btn_full.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_full.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_full.FlatAppearance.BorderSize = 0
        Me.btn_full.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_full.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_full.ForeColor = System.Drawing.Color.Snow
        Me.btn_full.Image = CType(resources.GetObject("btn_full.Image"), System.Drawing.Image)
        Me.btn_full.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_full.Location = New System.Drawing.Point(1030, -2)
        Me.btn_full.Name = "btn_full"
        Me.btn_full.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_full.Size = New System.Drawing.Size(39, 36)
        Me.btn_full.TabIndex = 12
        Me.btn_full.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_full.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_full.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Snow
        Me.btn_exit.Image = CType(resources.GetObject("btn_exit.Image"), System.Drawing.Image)
        Me.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_exit.Location = New System.Drawing.Point(1075, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_exit.Size = New System.Drawing.Size(38, 33)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_message
        '
        Me.btn_message.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_message.FlatAppearance.BorderSize = 0
        Me.btn_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_message.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_message.ForeColor = System.Drawing.Color.Snow
        Me.btn_message.Image = CType(resources.GetObject("btn_message.Image"), System.Drawing.Image)
        Me.btn_message.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_message.Location = New System.Drawing.Point(3, 3)
        Me.btn_message.Name = "btn_message"
        Me.btn_message.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_message.Size = New System.Drawing.Size(39, 36)
        Me.btn_message.TabIndex = 10
        Me.btn_message.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_message.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_message.UseVisualStyleBackColor = True
        '
        'panel_dashboard
        '
        Me.panel_dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.panel_dashboard.Controls.Add(Me.PictureBox1)
        Me.panel_dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_dashboard.Location = New System.Drawing.Point(167, 46)
        Me.panel_dashboard.Name = "panel_dashboard"
        Me.panel_dashboard.Size = New System.Drawing.Size(1113, 454)
        Me.panel_dashboard.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.No
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(305, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(490, 454)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Menu_admin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 500)
        Me.Controls.Add(Me.panel_dashboard)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Circular1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.panel_dashboard.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_estoque As Button
    Friend WithEvents btn_compras As Button
    Friend WithEvents btn_pedidos As Button
    Friend WithEvents panel_dashboard As Panel
    Friend WithEvents btn_message As Button
    Friend WithEvents btn_minim As Button
    Friend WithEvents btn_full As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_cadastroFunc As Button
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Circular1 As Circular
End Class
