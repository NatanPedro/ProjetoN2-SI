Public Class Form1
    Private Usuario As String 'Declaração da variável de classe para o nome de usuário
    Private Senha As String 'Declaração da variável de classe para a senha
    Dim conectar As New Acesso()
    Private Sub fechar_btn_Click(sender As Object, e As EventArgs) Handles fechar_btn.Click
        Me.Close() 'Fechar a janela
    End Sub
    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
#Disable Warning BC42025 'Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        Me.WindowState = WindowState.Minimized 'Minimizar a janela
#Enable Warning BC42025 'Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
    End Sub
    Private Sub txt_usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_usuario.TextChanged
        Usuario = txt_usuario.Text 'Text box usuario recebe variavel Usuario
    End Sub
    Private Sub txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        Senha = txt_senha.Text 'Text box senha recebe variavel Senha
    End Sub
    Private Sub txt_senha_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt_senha.KeyDown
        'Ao pressionar a tecla Enter o botão Login será acionado
        If e.KeyCode = Keys.Enter Then
            btn_login_Click(Nothing, New EventArgs())
        End If
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim resultado As Integer = conectar.Conectar() 'Variavel que trará o resultado ao conectar no banco
        If Usuario = "admin" And Senha = "admin" Then
            Menu_func.ShowDialog()
        ElseIf resultado = 0 Then 'Laço condicional para a conexão do banco de dados
        MsgBox("Banco de dados conectado com sucesso", vbInformation, vbOKOnly)
            Menu_func.ShowDialog()
        End If
    End Sub
    Private Sub btn_esqueci_Click(sender As Object, e As EventArgs) Handles btn_esqueci.Click

    End Sub
End Class