Imports FontAwesome.Sharp

Public Class Menu_admin
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private Formularios As Form
    Private childForm As Form
    Public Property Usuario As String
    Public Sub SetUserName(Usuario As String)
        Me.Usuario = Usuario
    End Sub
    Private Sub novo()
        InitializeComponent()

        Me.Text = String.Empty
        Me.ControlBox = True
        Me.DoubleBuffered = True
    End Sub
    Private Sub Menu_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mudarUsuario()
    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
    Private Sub btn_pedidos_Click(sender As Object, e As EventArgs) Handles btn_pedidos.Click
        chamaFormulario(New Pedidos)
    End Sub
    Private Sub btn_estoque_Click(sender As Object, e As EventArgs) Handles btn_estoque.Click
        chamaFormulario(New Estoque)
    End Sub
    Private Sub chamaFormulario(childForm As Form)
        If Formularios IsNot Nothing Then
            Formularios.Close()
        End If
        Formularios = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel_dashboard.Controls.Add(childForm)
        panel_dashboard.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        chamaFormulario(New Home)
    End Sub
    Private Sub btn_minim_Click(sender As Object, e As EventArgs) Handles btn_minim.Click
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        Me.WindowState = WindowState.Minimized
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
    End Sub
    Private Sub btn_message_Click(sender As Object, e As EventArgs) Handles btn_message.Click
        escrever.ShowDialog()
    End Sub
    Private Sub btn_retornar_Click(sender As Object, e As EventArgs)
        Dim resposta As DialogResult
        resposta = MsgBox("Deseja deslogar?", vbQuestion + vbYesNo, "AVISO")
        If resposta = DialogResult.Yes Then
            Me.Close()
        Else
            MsgBox("Você optou por ficar, parabens idiota", vbInformation + vbOKOnly, "DAORA")
        End If
    End Sub
    Private Sub btn_full_Click(sender As Object, e As EventArgs) Handles btn_full.Click
        If Me.WindowState = FormWindowState.Maximized Then
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            Me.WindowState = WindowState.Normal
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        Else
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
            Me.WindowState = WindowState.Maximized
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        End If
    End Sub
    Private Sub btn_compras_Click(sender As Object, e As EventArgs) Handles btn_compras.Click
        chamaFormulario(New btn_Fornecedor)
    End Sub
    Private Sub btn_cadastroFunc_Click(sender As Object, e As EventArgs) Handles btn_cadastroFunc.Click
        chamaFormulario(New Funcionarios)
    End Sub
    Private Sub Circular2_Click(sender As Object, e As EventArgs)
        If Formularios IsNot Nothing Then 'Fechar o formulário que foi chamado e voltar para o "Home"
            Formularios.Close()
        End If
    End Sub
    Private Sub btn_Fornecedor_Click(sender As Object, e As EventArgs)
        chamaFormulario(New btn_Fornecedor)
    End Sub
End Class