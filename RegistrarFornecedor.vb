Public Class RegistrarFornecedor
    Dim diretorio As String
    Dim openFileDialog As New OpenFileDialog()
    Private Sub RegistrarFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim nome As String = txt_nomeFornecedor.Text
        Dim CNPJ As String = txt_CNPJ.Text
        Dim telefone As String = txt_telFornce.Text
        Dim email As String = txt_emailFornce.Text

        If String.IsNullOrWhiteSpace(nome) OrElse String.IsNullOrWhiteSpace(CNPJ) OrElse String.IsNullOrWhiteSpace(telefone) OrElse String.IsNullOrWhiteSpace(email) Then
            MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If
        Dim mesagem As String = CadastrarFornecedores(CNPJ, nome, telefone, email)
        MsgBox(mesagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Resultado")
    End Sub
    Private Sub bt_sairForn_Click(sender As Object, e As EventArgs) Handles bt_sairForn.Click
        Me.Close()
    End Sub

    Public Sub LimparTela()
        ' Limpar todos os campos de texto
        txt_CNPJ.Clear()
        txt_nomeFornecedor.Clear()
        txt_telFornce.Clear()
        txt_emailFornce.Clear()
        ' Limpar a imagem

    End Sub
End Class