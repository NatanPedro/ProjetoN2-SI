Imports System.Data.OleDb

Public Class btn_Fornecedor
    Private Sub Fornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carregar_dgv_fornecedores("")
        FormatarDatagrid()

        txt_grifFornecedor.Columns("Excluir").DisplayIndex = txt_grifFornecedor.Columns.Count - 1
        txt_grifFornecedor.Columns("Excluir").Width = 50
    End Sub
    Private Sub btn_Vender_Click(sender As Object, e As EventArgs) Handles btn_Vender.Click
        RegistrarFornecedor.ShowDialog()
        carregar_dgv_fornecedores("")
    End Sub
    Function carregar_dgv_fornecedores(query As String)
        ' Define a consulta padrão se nenhuma consulta for fornecida
        If query = "" Then
            query = "SELECT CNPJ, Nome, Telefone, Email FROM tb_fornecedores"
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
                        With txt_grifFornecedor
                            .Rows.Clear()

                            ' Processa cada linha do banco de dados
                            While reader.Read()
                                Try
                                    ' Adiciona novas linhas ao DataGridView com os dados recuperados
                                    .Rows.Add(
                                    reader("CNPJ").ToString(),
                                    reader("Nome").ToString(),
                                    reader("Telefone").ToString(),
                                    reader("Email").ToString(),
                                    Nothing)
                                    ' Tratamento de erro específico para problemas 
                                Catch ex As Exception
                                    ' Tratamento de outros erros
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
        With txt_grifFornecedor
            .DefaultCellStyle.Font = New Font("Verdana", 9)

            If .Columns.Contains("ValorUnitario") Then
                .Columns("ValorUnitario").DefaultCellStyle.Format = "C"
            End If

            If .Columns.Contains("ValorTotal") Then
                .Columns("ValorTotal").DefaultCellStyle.Format = "C"
            End If

            ' Formatar colunas de data, se existirem
            If .Columns.Contains("Data") Then
                .Columns("Data").DefaultCellStyle.Format = "d" ' Formato de data personalizado
            End If

            txt_grifFornecedor.Refresh()
        End With
    End Sub

    Private Sub txt_grifFornecedor_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles txt_grifFornecedor.CellContentClick
        If e.RowIndex >= 0 AndAlso txt_grifFornecedor.Columns(e.ColumnIndex).Name = "Excluir" Then
            Dim result As DialogResult = MessageBox.Show("Deseja excluir o item?", "ATENÇÃO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                Dim selectedID As String = txt_grifFornecedor.Rows(e.RowIndex).Cells("CNPJ").Value.ToString()
                ExcluirFornecedor(selectedID)
                carregar_dgv_fornecedores("")
                ' Código para excluir o item com o CNPJ correspondente
            End If
        End If
    End Sub
End Class