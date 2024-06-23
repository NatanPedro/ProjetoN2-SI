<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class escrever
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(escrever))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_emailDestino = New System.Windows.Forms.TextBox()
        Me.txt_assunto = New System.Windows.Forms.TextBox()
        Me.txt_corpo = New System.Windows.Forms.TextBox()
        Me.btn_enviarEmail = New FontAwesome.Sharp.IconButton()
        Me.btn_limpar = New FontAwesome.Sharp.IconButton()
        Me.btn_cancelarEmail = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EMAIL DO REMETENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DESTINATÁRIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ASSUNTO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CORPO DO EMAIL"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(281, 95)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(243, 22)
        Me.txt_email.TabIndex = 4
        '
        'txt_emailDestino
        '
        Me.txt_emailDestino.Location = New System.Drawing.Point(281, 137)
        Me.txt_emailDestino.Name = "txt_emailDestino"
        Me.txt_emailDestino.Size = New System.Drawing.Size(243, 22)
        Me.txt_emailDestino.TabIndex = 5
        '
        'txt_assunto
        '
        Me.txt_assunto.Location = New System.Drawing.Point(281, 183)
        Me.txt_assunto.Name = "txt_assunto"
        Me.txt_assunto.Size = New System.Drawing.Size(243, 22)
        Me.txt_assunto.TabIndex = 6
        '
        'txt_corpo
        '
        Me.txt_corpo.Location = New System.Drawing.Point(49, 266)
        Me.txt_corpo.Name = "txt_corpo"
        Me.txt_corpo.Size = New System.Drawing.Size(693, 22)
        Me.txt_corpo.TabIndex = 7
        '
        'btn_enviarEmail
        '
        Me.btn_enviarEmail.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_enviarEmail.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_enviarEmail.IconColor = System.Drawing.Color.Black
        Me.btn_enviarEmail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_enviarEmail.Location = New System.Drawing.Point(645, 313)
        Me.btn_enviarEmail.Name = "btn_enviarEmail"
        Me.btn_enviarEmail.Size = New System.Drawing.Size(96, 44)
        Me.btn_enviarEmail.TabIndex = 8
        Me.btn_enviarEmail.Text = "ENVIAR"
        Me.btn_enviarEmail.UseVisualStyleBackColor = False
        '
        'btn_limpar
        '
        Me.btn_limpar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_limpar.IconColor = System.Drawing.Color.Black
        Me.btn_limpar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_limpar.Location = New System.Drawing.Point(521, 313)
        Me.btn_limpar.Name = "btn_limpar"
        Me.btn_limpar.Size = New System.Drawing.Size(118, 44)
        Me.btn_limpar.TabIndex = 9
        Me.btn_limpar.Text = "LIMPAR"
        Me.btn_limpar.UseVisualStyleBackColor = True
        '
        'btn_cancelarEmail
        '
        Me.btn_cancelarEmail.BackColor = System.Drawing.Color.Red
        Me.btn_cancelarEmail.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_cancelarEmail.IconColor = System.Drawing.Color.Black
        Me.btn_cancelarEmail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_cancelarEmail.Location = New System.Drawing.Point(376, 313)
        Me.btn_cancelarEmail.Name = "btn_cancelarEmail"
        Me.btn_cancelarEmail.Size = New System.Drawing.Size(139, 44)
        Me.btn_cancelarEmail.TabIndex = 10
        Me.btn_cancelarEmail.Text = "CANCELAR"
        Me.btn_cancelarEmail.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(814, 89)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(43, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ESCREVER EMAIL"
        '
        'escrever
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_cancelarEmail)
        Me.Controls.Add(Me.btn_limpar)
        Me.Controls.Add(Me.btn_enviarEmail)
        Me.Controls.Add(Me.txt_corpo)
        Me.Controls.Add(Me.txt_assunto)
        Me.Controls.Add(Me.txt_emailDestino)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "escrever"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escrever Email"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_emailDestino As TextBox
    Friend WithEvents txt_assunto As TextBox
    Friend WithEvents txt_corpo As TextBox
    Friend WithEvents btn_enviarEmail As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_limpar As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_cancelarEmail As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
End Class
