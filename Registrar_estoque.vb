Imports System.Globalization
Imports System.IO
Imports System.Security.AccessControl

Public Class Registrar_estoque
    Dim diretorio As String
    Dim openFileDialog As New OpenFileDialog()
    Dim caminhoRelativo
    Dim custo As Decimal
    Dim caminhoFoto
    Private Sub Registrar_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub
    Private Sub btn_buscarFoto_Click(sender As Object, e As EventArgs) Handles btn_buscarFoto.Click
        Try
            With openFileDialog
                .Title = "SELECIONE UMA FOTO DO CLIENTE"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                diretorio = .FileName
                txt_photo.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        ' Captura os valores dos campos de entrada
        Dim nome As String = txt_nomeProduto.Text
        Dim categoria As String = txt_categoriaProdutos.Text
        Dim quantidade As Integer
        Dim preco As Decimal

        Decimal.TryParse(txt_precoProduto.Text, preco)

        custo = LimparFormatacaoMoeda(txt_custoProduto.Text)

        ' Validação dos campos de entrada
        If String.IsNullOrWhiteSpace(nome) OrElse String.IsNullOrWhiteSpace(categoria) OrElse String.IsNullOrWhiteSpace(diretorio) Then
            MsgBox("Por favor, preencha todos os campos.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        ' Tenta converter a quantidade para Integer
        If Not Integer.TryParse(txt_quantidade.Text, quantidade) Then
            MsgBox("Quantidade inválida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "AVISO")
            Exit Sub
        End If

        Dim mensagem As String = CadastrarProdutos(nome, categoria, quantidade, custo, preco, diretorio)
        ' Exibe a mensagem de retorno para o usuário
        MsgBox(mensagem, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Resultado")

        LimparTela()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Public Sub validarDec(Sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 And
                e.KeyChar <> "," And e.KeyChar <> "." Then
            e.Handled = True
        ElseIf e.KeyChar = "," And Sender.Text.contains(",") Then
            e.Handled = True
        End If
    End Sub
    Private Sub txt_custoProduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_custoProduto.KeyPress
        validarDec(sender, e)
    End Sub
    Public Sub LimparTela()
        ' Limpar todos os campos de texto
        txt_nomeProduto.Clear()
        txt_categoriaProdutos.Clear()
        txt_quantidade.Clear()
        txt_custoProduto.Clear()
        txt_precoProduto.Clear()

        ' Limpar a imagem
        txt_photo.Image = Nothing
        diretorio = String.Empty

        ' Focar no primeiro campo de entrada
        txt_nomeProduto.Focus()
    End Sub
    Public Function LimparFormatacaoMoeda(valorFormatado As String) As String
        ' Remove o símbolo de moeda
        valorFormatado = valorFormatado.Replace("R$", "")

        ' Substitui a vírgula por um ponto para o formato decimal correto
        valorFormatado = valorFormatado.Replace(",", ".")

        Return valorFormatado
    End Function
    Private Sub txt_photo_Click(sender As Object, e As EventArgs) Handles txt_photo.Click

    End Sub
End Class