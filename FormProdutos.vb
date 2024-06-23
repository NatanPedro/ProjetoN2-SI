Public Class FormProdutos
    Private Sub btn_message_Click(sender As Object, e As EventArgs) Handles btn_message.Click
        Registrar_estoque.ShowDialog()
    End Sub
    Private Sub FormProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        carregar_dados(txt_dataGrid)
    End Sub
End Class