Imports System.Data.SqlClient
Imports System.IO

Public Class EditEstok
    Dim openFileDialog As New OpenFileDialog()
    Dim diretorio As String
    Dim codigoSelecionado As Integer
    Dim codigo As Integer
    Dim nomeProduto As String
    Dim categoria As String
    Dim quantidade As Integer
    Dim custo As Decimal
    Dim precoVenda As Decimal
    Dim caminho As String
    Private _produtoID As Integer

    ' Construtor que recebe o ID do produto
    Public Sub New(ByVal produtoID As Integer)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _produtoID = produtoID
    End Sub
    Private Sub EditEstok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Puxar_campos_editar(_produtoID, txt_nomeProduto, txt_categoriaProdutos, txt_quantidade, txt_custoProduto, txt_precoProduto, caminho)
        If Not String.IsNullOrEmpty(caminho) AndAlso File.Exists(caminho) Then
            txt_photo.Image = Image.FromFile(caminho)
            diretorio = caminho
        Else
            MsgBox("Não foi possível carregar a imagem", vbOKOnly + vbYesNo)
        End If
    End Sub
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        If CamposValidos() Then
            ' Convertendo os valores dos campos de texto para os tipos de dados corretos
            Integer.TryParse(txt_quantidade.Text, quantidade)
            Decimal.TryParse(txt_custoProduto.Text, custo)
            Decimal.TryParse(txt_precoProduto.Text, precoVenda)

            EditarProduto(_produtoID, nomeProduto, categoria, quantidade, custo, precoVenda, diretorio)
        Else
            MsgBox("Preencha todos os campos obrigatórios.", vbOKOnly + vbInformation)
        End If
        LimparTela()
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
    Private Function CamposValidos() As Boolean
        ' Verifica se os campos obrigatórios estão preenchidos
        If String.IsNullOrWhiteSpace(txt_nomeProduto.Text) OrElse String.IsNullOrWhiteSpace(txt_categoriaProdutos.Text) OrElse String.IsNullOrWhiteSpace(txt_quantidade.Text) OrElse String.IsNullOrWhiteSpace(txt_custoProduto.Text) OrElse String.IsNullOrWhiteSpace(txt_precoProduto.Text) Then
            Return False
        Else
            nomeProduto = txt_nomeProduto.Text
            categoria = txt_categoriaProdutos.Text
            Return True
        End If
    End Function
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class