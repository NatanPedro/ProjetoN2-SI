Imports System.Data.SqlClient
Imports System.IO
Public Class CadastroFunc
    Dim diretorio As String
    Dim openFileDialog As New OpenFileDialog()
    Private Sub CadastroFunc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        txt_nomeFunc.Clear()
        txt_CPFfunc.Clear()
        txt_FuncaoFunc.Clear()
        txt_usuarioFunc.Clear()
        txt_senhaFunc.Clear()
        txt_nomeFunc.Focus()
        Me.Close()
    End Sub
    Private Sub btn_minim_Click(sender As Object, e As EventArgs) Handles btn_minim.Click
#Disable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
        WindowState = WindowState.Minimized
#Enable Warning BC42025 ' Acesso do membro compartilhado, membro constante, membro enumerado ou tipo aninhado por meio de uma instância
    End Sub
    Private Sub cbox_senha_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_senha.CheckedChanged
        txt_senhaFunc.UseSystemPasswordChar = Not cbox_senha.Checked
    End Sub
    Private Sub btn_cadastrarFunc_Click(sender As Object, e As EventArgs) Handles btn_cadastrarFunc.Click
        Dim nomeFunc As String = txt_nomeFunc.Text
        Dim CPF As String = txt_CPFfunc.Text
        Dim funcaoF As String = txt_FuncaoFunc.Text
        Dim usuarie As String = txt_usuarioFunc.Text
        Dim senhae As String = txt_senhaFunc.Text
        Dim dataNasc As Date

        If Not Date.TryParse(DateTimePicker1.Text, dataNasc) Then
            MsgBox("Por favor, insira uma data de nascimento válida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(nomeFunc) OrElse String.IsNullOrWhiteSpace(CPF) OrElse String.IsNullOrWhiteSpace(funcaoF) OrElse String.IsNullOrWhiteSpace(usuarie) OrElse String.IsNullOrWhiteSpace(senhae) Then
            MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        Dim mesagem As String = CadastroFuncionario(CPF, nomeFunc, funcaoF, usuarie, senhae, dataNasc)
        MsgBox(mesagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Resultado")
        txt_nomeFunc.Clear()
        txt_CPFfunc.Clear()
        txt_FuncaoFunc.Clear()
        txt_usuarioFunc.Clear()
        txt_senhaFunc.Clear()
        txt_nomeFunc.Focus()
    End Sub
    Private Function ImageToByteArray(img As Image) As Byte()
        Using ms As New MemoryStream()
            img.Save(ms, img.RawFormat)
            Return ms.ToArray()
        End Using
    End Function
    Private Sub btn_editarFunc_Click(sender As Object, e As EventArgs) Handles btn_editarFunc.Click
        Dim CPF As String = txt_CPFfunc.Text.Trim()
        Dim Nome As String = txt_nomeFunc.Text.Trim()
        Dim Funcao As String = txt_FuncaoFunc.Text.Trim()
        Dim Usuario As String = txt_usuarioFunc.Text.Trim()
        Dim Senha As String = txt_senhaFunc.Text.Trim()
        Dim DataNascimento As Date
        Dim Foto As Byte() = Nothing

        If Not Date.TryParse(DateTimePicker1.Text, DataNascimento) Then
            MessageBox.Show("Por favor, insira uma data de nascimento válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not String.IsNullOrEmpty(CPF) AndAlso Not String.IsNullOrEmpty(Nome) AndAlso Not String.IsNullOrEmpty(Funcao) AndAlso Not String.IsNullOrEmpty(Usuario) AndAlso Not String.IsNullOrEmpty(Senha) Then
            EditarFuncionario(CPF, Nome, Funcao, Usuario, Senha, DataNascimento)
        Else
            MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btn_exibirFunc_Click(sender As Object, e As EventArgs) Handles btn_exibirFunc.Click
        txt_CPFfunc.Clear()
        txt_FuncaoFunc.Clear()
        txt_nomeFunc.Clear()
        txt_senhaFunc.Clear()
        txt_usuarioFunc.Clear()
        txt_CPFfunc.Focus()
    End Sub
    Private Sub btn_deletarFunc_Click(sender As Object, e As EventArgs) Handles btn_deletarFunc.Click
        Dim CPF As String = txt_CPFfunc.Text.Trim()

        If Not String.IsNullOrEmpty(CPF) Then
            DemitirFuncionario(CPF)
            txt_CPFfunc.Clear()
            txt_FuncaoFunc.Clear()
            txt_nomeFunc.Clear()
            txt_senhaFunc.Clear()
            txt_usuarioFunc.Clear()
            txt_CPFfunc.Focus()
        Else
            MessageBox.Show("Por favor, insira um CPF de funcionário válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub txt_CPFfunc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_CPFfunc.MaskInputRejected
        Dim cpf As String = txt_CPFfunc.Text
        If Not String.IsNullOrEmpty(cpf) Then
            PuxarFuncionario(cpf, txt_nomeFunc, txt_FuncaoFunc, txt_usuarioFunc, txt_senhaFunc)
        Else
            MessageBox.Show("Por favor, insira um CPF válido.")
        End If
    End Sub
End Class