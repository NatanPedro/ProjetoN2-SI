Public Class Funcionarios
    Private Sub btn_cadastrarFunc_Click(sender As Object, e As EventArgs) Handles btn_cadastrarFunc.Click
        CadastroFunc.ShowDialog()
    End Sub
    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
        CarregarFuncionarios(txt_dataGrid_Func)
    End Sub
End Class