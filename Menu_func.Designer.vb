<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_func
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_func))
        Me.panel_superior = New System.Windows.Forms.Panel()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.icon_logo = New System.Windows.Forms.PictureBox()
        Me.icon_icone = New FontAwesome.Sharp.IconPictureBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_dash = New System.Windows.Forms.Panel()
        Me.Produtos = New FontAwesome.Sharp.IconButton()
        Me.Ordens = New FontAwesome.Sharp.IconButton()
        Me.Dashboard = New FontAwesome.Sharp.IconButton()
        Me.panel_superior.SuspendLayout()
        CType(Me.icon_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon_icone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_dash.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_superior
        '
        Me.panel_superior.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panel_superior.Controls.Add(Me.btn_sair)
        Me.panel_superior.Controls.Add(Me.icon_logo)
        Me.panel_superior.Controls.Add(Me.icon_icone)
        Me.panel_superior.Controls.Add(Me.lbl_nome)
        Me.panel_superior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_superior.Location = New System.Drawing.Point(0, 0)
        Me.panel_superior.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_superior.Name = "panel_superior"
        Me.panel_superior.Size = New System.Drawing.Size(1468, 97)
        Me.panel_superior.TabIndex = 8
        '
        'btn_sair
        '
        Me.btn_sair.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_sair.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sair.ForeColor = System.Drawing.Color.White
        Me.btn_sair.Location = New System.Drawing.Point(1388, 0)
        Me.btn_sair.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(80, 50)
        Me.btn_sair.TabIndex = 10
        Me.btn_sair.Text = "X"
        Me.btn_sair.UseVisualStyleBackColor = False
        '
        'icon_logo
        '
        Me.icon_logo.BackColor = System.Drawing.Color.AliceBlue
        Me.icon_logo.Image = CType(resources.GetObject("icon_logo.Image"), System.Drawing.Image)
        Me.icon_logo.Location = New System.Drawing.Point(-3, -32)
        Me.icon_logo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.icon_logo.Name = "icon_logo"
        Me.icon_logo.Size = New System.Drawing.Size(203, 158)
        Me.icon_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon_logo.TabIndex = 5
        Me.icon_logo.TabStop = False
        '
        'icon_icone
        '
        Me.icon_icone.BackColor = System.Drawing.SystemColors.HotTrack
        Me.icon_icone.IconChar = FontAwesome.Sharp.IconChar.House
        Me.icon_icone.IconColor = System.Drawing.Color.White
        Me.icon_icone.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icon_icone.IconSize = 56
        Me.icon_icone.Location = New System.Drawing.Point(248, 21)
        Me.icon_icone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.icon_icone.Name = "icon_icone"
        Me.icon_icone.Size = New System.Drawing.Size(56, 57)
        Me.icon_icone.TabIndex = 4
        Me.icon_icone.TabStop = False
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome.ForeColor = System.Drawing.Color.White
        Me.lbl_nome.Location = New System.Drawing.Point(309, 34)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(76, 29)
        Me.lbl_nome.TabIndex = 2
        Me.lbl_nome.Text = "Inicio"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.panel_dash)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel3.Location = New System.Drawing.Point(0, 97)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1468, 540)
        Me.Panel3.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(363, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(841, 540)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'panel_dash
        '
        Me.panel_dash.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panel_dash.Controls.Add(Me.Produtos)
        Me.panel_dash.Controls.Add(Me.Ordens)
        Me.panel_dash.Controls.Add(Me.Dashboard)
        Me.panel_dash.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_dash.Location = New System.Drawing.Point(0, 0)
        Me.panel_dash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_dash.Name = "panel_dash"
        Me.panel_dash.Size = New System.Drawing.Size(200, 540)
        Me.panel_dash.TabIndex = 6
        '
        'Produtos
        '
        Me.Produtos.AutoSize = True
        Me.Produtos.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Produtos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Produtos.ForeColor = System.Drawing.Color.White
        Me.Produtos.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.Produtos.IconColor = System.Drawing.Color.Black
        Me.Produtos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Produtos.Location = New System.Drawing.Point(0, 72)
        Me.Produtos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Produtos.Name = "Produtos"
        Me.Produtos.Size = New System.Drawing.Size(200, 66)
        Me.Produtos.TabIndex = 8
        Me.Produtos.Text = "Produtos"
        Me.Produtos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Produtos.UseVisualStyleBackColor = False
        '
        'Ordens
        '
        Me.Ordens.AutoSize = True
        Me.Ordens.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Ordens.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ordens.ForeColor = System.Drawing.Color.White
        Me.Ordens.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.Ordens.IconColor = System.Drawing.Color.Black
        Me.Ordens.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Ordens.Location = New System.Drawing.Point(0, 2)
        Me.Ordens.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Ordens.Name = "Ordens"
        Me.Ordens.Size = New System.Drawing.Size(200, 66)
        Me.Ordens.TabIndex = 7
        Me.Ordens.Text = "Ordens"
        Me.Ordens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Ordens.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.Dashboard.AutoSize = True
        Me.Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.White
        Me.Dashboard.IconChar = FontAwesome.Sharp.IconChar.LineChart
        Me.Dashboard.IconColor = System.Drawing.Color.Black
        Me.Dashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Dashboard.Location = New System.Drawing.Point(0, 474)
        Me.Dashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(200, 66)
        Me.Dashboard.TabIndex = 3
        Me.Dashboard.Text = "Sair"
        Me.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Dashboard.UseVisualStyleBackColor = False
        '
        'Menu_func
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1468, 637)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.panel_superior)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Menu_func"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_func"
        Me.panel_superior.ResumeLayout(False)
        Me.panel_superior.PerformLayout()
        CType(Me.icon_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon_icone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_dash.ResumeLayout(False)
        Me.panel_dash.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_superior As Panel
    Friend WithEvents lbl_nome As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents icon_icone As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents panel_dash As Panel
    Friend WithEvents Produtos As FontAwesome.Sharp.IconButton
    Friend WithEvents Ordens As FontAwesome.Sharp.IconButton
    Friend WithEvents icon_logo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_sair As Button
    Friend WithEvents Dashboard As FontAwesome.Sharp.IconButton
End Class
