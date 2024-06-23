Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Data.OleDb
Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        SetupChart()
        'MostrarLabels()

        'TotalPedidos.Text = SomaTotalProdutos()

        Dim dataTable As New DataTable()

        Dim monthlyValues As New List(Of Double)()

        ' Substitua o código a seguir com o trecho fornecido
        Dim query As String = "SELECT Faturas FROM tb_Faturamento"
        Using command As New OleDbCommand(query, db)
            Using reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    monthlyValues.Add(Convert.ToDouble(reader("Faturas")))
                End While
            End Using
        End Using

        ' Cria uma nova série e adiciona os dados
        Dim lineSeries As New LineSeries() With {
    .Values = New ChartValues(Of Double)(monthlyValues),
    .Title = "Faturamento Mensal"
}
        ' Adiciona a nova série ao gráfico
        CartesianChart1.Series.Clear() ' Limpa todas as séries existentes
        CartesianChart1.Series.Add(lineSeries) ' Adiciona a nova série

        ' Passar os dados para o gráfico
        For Each row As DataRow In dataTable.Rows
            Dim nome As String = row("Nome").ToString()
            Dim valor As Integer = Convert.ToInt32(row("Valor"))
            'CartesianChart1.Series("Valores").Points.AddXY(nome, valor)
        Next
    End Sub
    Private Sub SetupChart()

    End Sub
    Private Sub SetPieChart()
        'Cria um novo controle PieChart do LiveCharts
        Dim pieChart As New LiveCharts.WinForms.PieChart()

        ' Configura o tamanho e posição do PieChart

        Dim produtos As New List(Of String)()
        Dim vendas As New List(Of Double)()
        ' Configura os dados do gráfico
        Try
            Dim query As String = "SELECT NomeProduto, ValorTotal FROM tb_pedidos"
            Using command As New OleDbCommand(query, db)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        produtos.Add(reader("NomeProduto").ToString())
                        vendas.Add(Convert.ToDouble(reader("ValorTotal")))
                    End While
                End Using
            End Using
        Catch ex As Exception
            ' Trate a exceção aqui
            'MessageBox.Show("Erro ao executar consulta SQL: " & ex.Message)
        End Try

        'Cria a série de dados para o gráfico de pizza
        Dim seriesCollection As New LiveCharts.SeriesCollection()

        For i As Integer = 0 To produtos.Count - 1
            seriesCollection.Add(New PieSeries() With {
        .Title = produtos(i),
        .Values = New ChartValues(Of Double)({vendas(i)}),
        .DataLabels = True
        })
        Next

        ' Adiciona a série de dados ao PieChart
        pieChart.Series = SeriesCollection

        '  Adiciona o PieChart ao formulário
        Me.Controls.Add(pieChart)
        pieChart.Parent = Panel16
        pieChart.BringToFront()
        pieChart.Size = New Size(225, 238) ' Ajuste o tamanho conforme necessário
    End Sub
    Private Sub colocarCoisa()
        Dim query As String = "SELECT NomeProduto FROM tb_produtos WHERE ID = @ID" ' Supondo que você tenha um campo "ID" para identificar o produto
        Dim produto As String = ""

        ' Certifique-se de que a conexão com o banco de dados esteja aberta antes de criar o comando
        If db.State = ConnectionState.Closed Then
            db.Open()
        End If

        ' Crie o comando com a consulta SQL e a conexão
        Using command As New OleDbCommand(query, db)
            ' Adicione o parâmetro "@ID" se for necessário para filtrar os resultados da consulta
            ' command.Parameters.AddWithValue("@ID", idDoProduto)

            ' Execute a consulta e recupere os resultados usando um OleDbDataReader
            Using reader As OleDbDataReader = command.ExecuteReader()
                ' Verifique se há linhas retornadas pela consulta
                If reader.Read() Then
                    ' Recupere o valor do campo "NomeProduto" da linha atual
                    produto = reader("NomeProduto").ToString()
                Else
                    ' Se não houver linhas retornadas, defina produto como vazio ou outra coisa, conforme necessário
                    produto = ""
                End If
            End Using
        End Using
        ' Atribua o nome do produto à propriedade Text da Label
        TotalPedidos.Text = produto
    End Sub
    Private Sub Panel16_Paint(sender As Object, e As PaintEventArgs) Handles Panel16.Paint
        SetPieChart()
    End Sub
    Public Sub MostrarLabels()
        TotalPedidos.Text = SomaTotalProdutos()
    End Sub
End Class