Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports ADODB

Public Class Estoque
    Public caminho_banco As String = Application.StartupPath & "\Banco_dados\banco.mdb"
    Private conecsao As SqlConnection
    Private commando As SqlCommand
    Private da As SqlDataAdapter
    Private re As SqlDataReader
    Private strSQL As String
    Public conectarString As String

    Private Sub estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dgv_clientes("")

        ' Chama a função para formatar o DataGridView
        FormatarDatagrid()

        ' Ajustar a ordem de exibição das colunas de imagem e botão
        'txt_dataGrid.Columns("Quantidade").DisplayIndex = txt_dataGrid.Columns.Count
        txt_dataGrid.Columns("Foto").DisplayIndex = txt_dataGrid.Columns.Count - 1

        txt_dataGrid.Columns("Editar").DisplayIndex = txt_dataGrid.Columns.Count - 1
        txt_dataGrid.Columns("Excluir").DisplayIndex = txt_dataGrid.Columns.Count - 1
        ' Ajustar a largura das colunas de botão, se necessário
        txt_dataGrid.Columns("Editar").Width = 50
        txt_dataGrid.Columns("Excluir").Width = 50
    End Sub
    Function carregar_dgv_clientes(query As String)
        ' Define a consulta padrão se nenhuma consulta for fornecida
        If query = "" Then
            query = "SELECT * FROM tb_produtos"
        End If

        ' Define a string de conexão para o banco de dados
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho_banco ' Substitua pelo caminho real do seu banco de dados

        Try
            ' Cria uma nova conexão com o banco de dados
            Using connection As New OleDbConnection(connectionString)
                ' Abre a conexão
                connection.Open()

                ' Cria um novo comando para executar a consulta
                Using command As New OleDbCommand(query, connection)
                    ' Executa o comando e obtém um data reader
                    Using reader As OleDbDataReader = command.ExecuteReader()
                        ' Limpa todas as linhas do DataGridView
                        With txt_dataGrid
                            .Rows.Clear()

                            ' Processa cada linha do banco de dados
                            While reader.Read()
                                Try
                                    ' Obtém o caminho da imagem do banco de dados
                                    Dim imagePath As String = reader("caminho").ToString()

                                    ' Verifica se o arquivo de imagem existe
                                    If Not System.IO.File.Exists(imagePath) Then
                                        Throw New FileNotFoundException("Imagem não encontrada: " & imagePath)
                                    End If

                                    ' Carrega a imagem
                                    Dim image As Image = Image.FromFile(imagePath)

                                    ' Redimensiona a imagem para 50x50 pixels
                                    Dim newSize As New Size(50, 50)
                                    Dim resizedImage As New Bitmap(newSize.Width, newSize.Height)

                                    Using g As Graphics = Graphics.FromImage(resizedImage)
                                        g.DrawImage(image, 0, 0, newSize.Width, newSize.Height)
                                    End Using

                                    ' Adiciona novas linhas ao DataGridView com os dados recuperados
                                    .Rows.Add(reader("Código").ToString(), reader("nome").ToString(), reader("categoria").ToString(),
                                          Convert.ToDecimal(reader("custo")), Convert.ToDecimal(reader("precoVenda")), reader("Quantidade").ToString(),
                                          resizedImage, Nothing, Nothing)
                                Catch ex As FileNotFoundException
                                    ' Tratamento de erro específico para arquivo não encontrado
                                    MessageBox.Show("Erro ao carregar a imagem: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Catch ex As OutOfMemoryException
                                    ' Tratamento de erro específico para problemas ao carregar a imagem (formato inválido, etc.)
                                    MessageBox.Show("Erro ao carregar a imagem (arquivo inválido ou corrompido): " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Catch ex As Exception
                                    ' Tratamento de outros erros
                                    MessageBox.Show("Erro ao processar a linha: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                            End While
                        End With
                    End Using
                End Using
            End Using
        Catch ex As OleDbException
            ' Tratamento de erros para problemas de conexão ou execução da consulta
            MessageBox.Show("Erro ao acessar o banco de dados: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Tratamento de outros erros gerais
            MessageBox.Show("Erro inesperado: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub FormatarDatagrid()
        With txt_dataGrid
            .DefaultCellStyle.Font = New Font("Verdana", 9)

            If .Columns.Contains("custo") Then
                .Columns("custo").DefaultCellStyle.Format = "C"
            End If

            If .Columns.Contains("precoVenda") Then
                .Columns("precoVenda").DefaultCellStyle.Format = "C"
            End If
            txt_dataGrid.Refresh()
        End With
    End Sub
    Private Sub btn_message_Click(sender As Object, e As EventArgs) Handles btn_message.Click

        Registrar_estoque.ShowDialog()
        carregar_dgv_clientes("")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Registrar_estoque.ShowDialog()
    End Sub
    Private Sub txt_dataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles txt_dataGrid.CellContentClick
        If txt_dataGrid.Columns(e.ColumnIndex).Name = "Editar" Then
            ' Obter o ID do item da linha selecionada
            Dim selectedRowIndex As Integer = e.RowIndex
            Dim selectedID As Integer = CInt(txt_dataGrid.Rows(selectedRowIndex).Cells("Codigo").Value)

            ' Criar uma nova instância do FormEditarEstoque e passar o ID do produto
            Dim editarForm As New EditEstok(selectedID)
            editarForm.ShowDialog()
            carregar_dgv_clientes("")

        ElseIf txt_dataGrid.Columns(e.ColumnIndex).Name = "Excluir" Then
            ' Código para excluir o item com o ID correspondente
            Dim result As DialogResult = MessageBox.Show("Deseja excluir o item?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = vbOK Then
                Dim selectedRowIndex As Integer = e.RowIndex
                Dim selectedID As Integer = CInt(txt_dataGrid.Rows(selectedRowIndex).Cells("Codigo").Value)
                ExcluirProduto(selectedID)
                carregar_dgv_clientes("")
            End If
        End If
    End Sub
End Class