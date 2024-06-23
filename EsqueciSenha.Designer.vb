<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EsqueciSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EsqueciSenha))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_senhaRecuperada = New System.Windows.Forms.TextBox()
        Me.txt_cpfRecuperar = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_fechar = New System.Windows.Forms.Button()
        Me.btn_Atualizaz = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Digite Aqui o seu CPF para alterar a senha"
        '
        'txt_senhaRecuperada
        '
        Me.txt_senhaRecuperada.Location = New System.Drawing.Point(494, 162)
        Me.txt_senhaRecuperada.Name = "txt_senhaRecuperada"
        Me.txt_senhaRecuperada.Size = New System.Drawing.Size(169, 22)
        Me.txt_senhaRecuperada.TabIndex = 3
        '
        'txt_cpfRecuperar
        '
        Me.txt_cpfRecuperar.Location = New System.Drawing.Point(39, 162)
        Me.txt_cpfRecuperar.Mask = "999.999.999-99"
        Me.txt_cpfRecuperar.Name = "txt_cpfRecuperar"
        Me.txt_cpfRecuperar.Size = New System.Drawing.Size(129, 22)
        Me.txt_cpfRecuperar.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(898, 100)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "RECUPERAR SENHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Digite a nova senha"
        '
        'btn_fechar
        '
        Me.btn_fechar.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_fechar.Location = New System.Drawing.Point(222, 225)
        Me.btn_fechar.Name = "btn_fechar"
        Me.btn_fechar.Size = New System.Drawing.Size(156, 47)
        Me.btn_fechar.TabIndex = 8
        Me.btn_fechar.Text = "FECHAR"
        Me.btn_fechar.UseVisualStyleBackColor = False
        '
        'btn_Atualizaz
        '
        Me.btn_Atualizaz.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_Atualizaz.Location = New System.Drawing.Point(457, 225)
        Me.btn_Atualizaz.Name = "btn_Atualizaz"
        Me.btn_Atualizaz.Size = New System.Drawing.Size(156, 47)
        Me.btn_Atualizaz.TabIndex = 9
        Me.btn_Atualizaz.Text = "ATUALIZAR"
        Me.btn_Atualizaz.UseVisualStyleBackColor = False
        '
        'EsqueciSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(898, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Atualizaz)
        Me.Controls.Add(Me.btn_fechar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_cpfRecuperar)
        Me.Controls.Add(Me.txt_senhaRecuperada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EsqueciSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EsqueciSenha"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_senhaRecuperada As TextBox
    Friend WithEvents txt_cpfRecuperar As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_fechar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_Atualizaz As Button
End Class
