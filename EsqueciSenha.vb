Imports System.Data.OleDb

Public Class EsqueciSenha
    Private Sub EsqueciSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txt_cpfRecuperar_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpfRecuperar.MaskInputRejected
        Dim loginCorreto As Boolean = False
        Dim CPF As String = txt_cpfRecuperar.Text.Trim()
        Dim novaSenha As String = txt_senhaRecuperada.Text
        conectar_banco()

        If Not String.IsNullOrEmpty(CPF) Then
            ' Consulta para verificar se o usuário e a senha correspondem a um registro na tabela Login
            Dim query As String = "SELECT COUNT(*) FROM tb_Funcionarios WHERE CPF = @CPF"
            Using cmd As New OleDbCommand(query, db)
                cmd.Parameters.AddWithValue("@CPF", CPF)

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    loginCorreto = True ' Se houver um registro correspondente na tabela, o cpf é validado
                End If
                MsgBox("CPF ENCONTRADO", vbInformation + vbOKOnly, "AVISO")

                Dim uptade As String = "UPTADE tb_Funcionarios SET Senha = @Senha WHERE CPF = @CPF"
                cmd.Parameters.AddWithValue("@Senha", novaSenha)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Dados do funcionário atualizados com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Return True
                Else
                    MessageBox.Show("CPF não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Return False
                End If
            End Using
        Else
                MessageBox.Show("Por favor, insira um CPF válido.")
        End If
    End Sub
    Private Sub btn_fechar_Click(sender As Object, e As EventArgs) Handles btn_fechar.Click
        Me.Close()
    End Sub

    Private Sub btn_Atualizaz_Click(sender As Object, e As EventArgs) Handles btn_Atualizaz.Click
        Dim CPF As String = txt_cpfRecuperar.Text.Trim
        Dim novaSenha As String = txt_senhaRecuperada.Text

        MudarSenha(CPF, novaSenha)
    End Sub
End Class