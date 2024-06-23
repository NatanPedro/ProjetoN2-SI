Imports System.Data.OleDb
Imports System.IO

Public Class Pedidos
    Private Sub Pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dgv_pedidos("")
        FormatarDatagrid()
    End Sub
    Function carregar_dgv_pedidos(query As String)
        ' Define a consulta padrão se nenhuma consulta for fornecida
        If query = "" Then
            query = "SELECT Data, NomeProduto, Quantidade, ValorUnitario, ValorTotal FROM tb_pedidos"
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
                        With txt_dataGrid_Func
                            .Rows.Clear()

                            ' Processa cada linha do banco de dados
                            While reader.Read()
                                Try
                                    ' Adiciona novas linhas ao DataGridView com os dados recuperados
                                    .Rows.Add(
                                          reader("Data").ToString(),
                                          reader("NomeProduto").ToString(),
                                          reader("Quantidade").ToString(),
                                          Convert.ToDecimal(reader("ValorUnitario")),
                                          Convert.ToDecimal(reader("ValorTotal")).ToString(),
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
    Private Sub btn_Vender_Click(sender As Object, e As EventArgs) Handles btn_Vender.Click
        RegistrarVendas.ShowDialog()
        carregar_dgv_pedidos("")
    End Sub
    Private Sub FormatarDatagrid()
        With txt_dataGrid_Func
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
            txt_dataGrid_Func.Refresh()
        End With
    End Sub
    Private Sub txt_dataGrid_Func_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles txt_dataGrid_Func.CellContentClick

    End Sub
    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        ' Obter os valores selecionados no DataGridView
        Dim data As String = txt_dataGrid_Func.CurrentRow.Cells("Data").Value.ToString()
        Dim produto As String = txt_dataGrid_Func.CurrentRow.Cells("NomeProduto").Value.ToString()
        Dim quantidade As Integer = Convert.ToInt32(txt_dataGrid_Func.CurrentRow.Cells("Quantidade").Value)
        Dim valorTotal As Decimal = Convert.ToDecimal(txt_dataGrid_Func.CurrentRow.Cells("ValorTotal").Value)

        ' Criar uma instância da classe Acesso e chamar o método GerarPDf() com os valores obtidos
        Dim acesso As New Acesso
        acesso.GerarPDf(data, produto, quantidade, valorTotal)
    End Sub
End Class