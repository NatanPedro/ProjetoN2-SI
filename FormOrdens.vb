Public Class FormOrdens
    Private Sub FormOrdens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        Carrega_Dados_Pedidos(txt_dataGrid_Func)
    End Sub
    Private Sub btn_Vender_Click(sender As Object, e As EventArgs) Handles btn_Vender.Click
        RegistrarVendas.ShowDialog()
    End Sub
End Class