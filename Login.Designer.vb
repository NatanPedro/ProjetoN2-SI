<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.panel_login = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.Button()
        Me.fechar_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_esqueci = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.logo_login = New System.Windows.Forms.PictureBox()
        Me.panel_login.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo_login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_login
        '
        Me.panel_login.BackColor = System.Drawing.Color.White
        Me.panel_login.Controls.Add(Me.Label1)
        Me.panel_login.Controls.Add(Me.btn_minimizar)
        Me.panel_login.Controls.Add(Me.fechar_btn)
        Me.panel_login.Controls.Add(Me.Label4)
        Me.panel_login.Controls.Add(Me.Label3)
        Me.panel_login.Controls.Add(Me.Label2)
        Me.panel_login.Controls.Add(Me.btn_esqueci)
        Me.panel_login.Controls.Add(Me.btn_login)
        Me.panel_login.Controls.Add(Me.Panel3)
        Me.panel_login.Controls.Add(Me.Panel1)
        Me.panel_login.Controls.Add(Me.logo_login)
        Me.panel_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panel_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_login.ForeColor = System.Drawing.Color.Goldenrod
        Me.panel_login.Location = New System.Drawing.Point(0, 0)
        Me.panel_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_login.Name = "panel_login"
        Me.panel_login.Size = New System.Drawing.Size(999, 526)
        Me.panel_login.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(517, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 42)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Entre na sua conta"
        '
        'btn_minimizar
        '
        Me.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimizar.FlatAppearance.BorderSize = 0
        Me.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimizar.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimizar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btn_minimizar.Location = New System.Drawing.Point(884, 4)
        Me.btn_minimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 49)
        Me.btn_minimizar.TabIndex = 13
        Me.btn_minimizar.Text = "-"
        Me.btn_minimizar.UseVisualStyleBackColor = True
        '
        'fechar_btn
        '
        Me.fechar_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fechar_btn.FlatAppearance.BorderSize = 0
        Me.fechar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fechar_btn.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechar_btn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.fechar_btn.Location = New System.Drawing.Point(941, 4)
        Me.fechar_btn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fechar_btn.Name = "fechar_btn"
        Me.fechar_btn.Size = New System.Drawing.Size(53, 49)
        Me.fechar_btn.TabIndex = 12
        Me.fechar_btn.Text = "X"
        Me.fechar_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(403, 575)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "entre em: liniklinklinklink"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(403, 559)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Para obter acesso ao sistema "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(403, 532)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Suporte"
        '
        'btn_esqueci
        '
        Me.btn_esqueci.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_esqueci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esqueci.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esqueci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_esqueci.Location = New System.Drawing.Point(673, 415)
        Me.btn_esqueci.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_esqueci.Name = "btn_esqueci"
        Me.btn_esqueci.Size = New System.Drawing.Size(219, 42)
        Me.btn_esqueci.TabIndex = 6
        Me.btn_esqueci.Text = "ESQUECI SENHA"
        Me.btn_esqueci.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(465, 415)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(200, 42)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel3.Controls.Add(Me.txt_senha)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(403, 284)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(576, 47)
        Me.Panel3.TabIndex = 4
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(63, 7)
        Me.txt_senha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(492, 26)
        Me.txt_senha.TabIndex = 2
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(43, 43)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.txt_usuario)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(403, 224)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 53)
        Me.Panel1.TabIndex = 3
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_usuario.Location = New System.Drawing.Point(63, 7)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(492, 28)
        Me.txt_usuario.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 49)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'logo_login
        '
        Me.logo_login.Image = CType(resources.GetObject("logo_login.Image"), System.Drawing.Image)
        Me.logo_login.Location = New System.Drawing.Point(0, 0)
        Me.logo_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.logo_login.Name = "logo_login"
        Me.logo_login.Size = New System.Drawing.Size(395, 526)
        Me.logo_login.TabIndex = 1
        Me.logo_login.TabStop = False
        '
        'Login
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 526)
        Me.Controls.Add(Me.panel_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel_login.ResumeLayout(False)
        Me.panel_login.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo_login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_login As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_esqueci As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_senha As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents logo_login As PictureBox
    Friend WithEvents fechar_btn As Button
    Friend WithEvents btn_minimizar As Button
    Friend WithEvents Label1 As Label
End Class
