Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Menu_func
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form
    Private childForm As Form
    Public Property Usuario As String

    Public Sub SetFuncName(Usuario As String)
        Me.Usuario = Usuario
    End Sub
    Public Sub New()
        InitializeComponent()
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panel_dash.Controls.Add(leftBorderBtn)
        'Form
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
    End Sub
    Private Sub Menu_func_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MudarFuncName()
    End Sub
    Private Sub AtivarBotao(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DesativarBotao()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(31, 81, 185)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            icon_icone.IconChar = currentBtn.IconChar
            icon_icone.IconColor = customColor
        End If
    End Sub
    Private Sub DesativarBotao() 'Metodo para mudar a aparencia do botão desativado
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(35, 87, 198)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.Black
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form) 'Metodo para abrir o formulário dentro do Menu
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel3.Controls.Add(childForm)
        Panel3.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lbl_nome.Text = childForm.Text
    End Sub
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        Dim opcao = MsgBox("Deseja deslogar? ", vbQuestion + vbYesNo, "ATENÇÂO")
        If opcao = vbYes Then
            Me.Close()
        Else
            MsgBox("Continue a trabalhar otario", vbInformation + vbOKOnly, "BELEZA")
        End If
    End Sub
    Private Sub Ordens_Click(sender As Object, e As EventArgs) Handles Ordens.Click
        AtivarBotao(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New FormOrdens) 'Chamar o formulário de Ordens
    End Sub
    Private Sub Produtos_Click(sender As Object, e As EventArgs) Handles Produtos.Click
        AtivarBotao(sender, Color.FromArgb(255, 255, 255))
        OpenChildForm(New FormProdutos) 'Chamar o formulário de Produtos
    End Sub

    Private Sub icon_icone_Click(sender As Object, e As EventArgs) Handles icon_icone.Click
        If currentChildForm IsNot Nothing Then 'Fechar o formulário que foi chamado e voltar para o "Home"
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DesativarBotao()  'Resetar o dashboard 
        leftBorderBtn.Visible = False
        icon_icone.IconChar = IconChar.Home
        icon_icone.IconColor = Color.White
        lbl_nome.Text = "Inicio"
    End Sub
    Private Sub icon_logo_Click_(sender As Object, e As EventArgs) Handles icon_logo.Click
        'Resetar o dasboard pelo icone do Delta Gestão
        Reset()
    End Sub
    'Metodos para mecher o formulário
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub
    Private Sub panel_superior_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_superior.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close() 'Botão para fechar o formulário e voltar para o login
    End Sub
    Private Sub MudarFuncName()

    End Sub
End Class