Imports System.Data.OleDb

Public Class RegistrarVendas
    Private Sub RegistrarVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim qtd As Integer
        Dim valorUni As Integer
        Dim totalValue As Decimal
        If Integer.TryParse(txt_quantidadePedido.Text, qtd) And Integer.TryParse(txt_valorUnitario.Text, valorUni) Then
            totalValue = qtd * valorUni
            txt_valorTotal.Text = totalValue.ToString()
        End If
    End Sub
    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Try
            Dim codigo As Integer = Integer.Parse(txt_codigoPedido.Text)
            Dim data As String = MetroDateTime1.Text
            Dim nomeCliente As String = txt_nomeCliente.Text
            Dim quantidade As Integer = Integer.Parse(txt_quantidadePedido.Text)
            Dim valorUnitario As Decimal = Decimal.Parse(txt_valorUnitario.Text)
            Dim total As Decimal = valorUnitario * quantidade
            Dim qtdMInima = ObterQuantidadeMinimaEstoque(codigo)

            If quantidade > 0 AndAlso quantidade <= qtdMInima Then
                ' Chama a função para cadastrar o pedido
                CadastrarPedidos(data, quantidade, nomeCliente, valorUnitario, total, codigo)
            Else
                ' Exibe uma mensagem de erro
                MsgBox("A quantidade deve ser maior que zero e menor ou igual à quantidade mínima em estoque.", vbCritical + vbOKOnly, "Aviso!")
            End If
        Catch ex As Exception
            MsgBox("TA ERRADE!" & ex.Message, vbInformation + vbOKOnly, "AVISO!")
        End Try
        txt_nomeCliente.Clear()
        txt_quantidadePedido.Clear()
        txt_valorUnitario.Clear()
        txt_valorTotal.Clear()
        txt_codigoPedido.Clear()
    End Sub
    Private Sub txt_valorUnitario_TextChanged(sender As Object, e As EventArgs) Handles txt_valorUnitario.TextChanged
        ' Evento do valor unitário
    End Sub
    Private Sub txt_codigoPedido_LostFocus(sender As Object, e As EventArgs) Handles txt_codigoPedido.LostFocus
        Dim codigo As Integer
        Dim nomeProduto As TextBox = txt_nomeCliente
        Dim quantidade As TextBox = txt_quantidadePedido
        Dim valorUnitario As TextBox = txt_valorUnitario

        Try
            If Integer.TryParse(txt_codigoPedido.Text, codigo) Then
                ' Chama a sub-rotina global para conectar ao banco de dados
                conectar_banco()
                ' Chama a sub-rotina global para carregar os dados do produto
                CarregarDadosProdutos(codigo, nomeProduto, quantidade, valorUnitario)
                CalcularValorTotal()
            Else
                MessageBox.Show("Por favor, insira um número de ID válido.")
            End If

        Catch ex As Exception
            MsgBox("Deu merda Pai!!" & ex.Message, vbOKOnly + vbInformation)
        End Try
    End Sub
    Private Sub CalcularValorTotal()
        Dim qtd As Integer
        Dim valorUni As Decimal
        Dim totalValue As Decimal
        If Integer.TryParse(txt_quantidadePedido.Text, qtd) AndAlso Decimal.TryParse(txt_valorUnitario.Text, valorUni) Then
            totalValue = qtd * valorUni
            txt_valorTotal.Text = totalValue.ToString()
        Else
            txt_valorTotal.Clear()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub txt_quantidadePedido_Leave(sender As Object, e As EventArgs) Handles txt_quantidadePedido.Leave
        CalcularValorTotal()
    End Sub
    Private Sub txt_valorUnitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valorUnitario.KeyPress
        ' Bloqueia a entrada de caracteres no campo txt_valorUnitario
        e.Handled = True
    End Sub
    Private Sub txt_valorTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valorTotal.KeyPress
        ' Bloqueia a entrada de caracteres no campo txt_valorTotal
        e.Handled = True
    End Sub
    Public Function ObterQuantidadeMinimaEstoque(codigoProduto As Integer) As Integer
        Dim quantidadeMinima As Integer = 0
        Try
            ' Abre a conexão se estiver fechada
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            ' Consulta SQL para obter a quantidade mínima em estoque do produto
            Dim query As String = "SELECT quantidade FROM tb_Produtos WHERE Código = @CodigoProduto"

            Using command As New OleDbCommand(query, db)
                command.Parameters.AddWithValue("@CodigoProduto", codigoProduto)

                ' Executa o comando e obtém o resultado
                Dim resultado As Object = command.ExecuteScalar()

                ' Verifica se o resultado não é nulo e converte para inteiro
                If resultado IsNot Nothing AndAlso Integer.TryParse(resultado.ToString(), quantidadeMinima) Then
                    ' Retorna a quantidade mínima em estoque
                    Return quantidadeMinima
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao obter a quantidade mínima em estoque: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fecha a conexão se estiver aberta
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
        ' Retorna zero se não conseguir obter a quantidade mínima
        Return quantidadeMinima
    End Function
End Class