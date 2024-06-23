Imports System.Net
Imports System.Net.Mail

Public Class escrever
    Public Sub enviarEmail(destinatario As String, assunto As String, mensagem As String)
        Try
            Dim emailRemetente = txt_email.Text
            Dim emailDestinatario = txt_emailDestino.Text
            Dim assuntoo = txt_assunto.Text
            Dim corpoEmail = txt_corpo.Text
            Dim smtp As New SmtpClient("smpt.gmail.com") 'coloca o endereço do servidor SMTP
            smtp.Port = 0 'coloca a porta do servidor
            smtp.EnableSsl = True 'habilita o SSL, para uma conexão segura
            smtp.Credentials = New NetworkCredential("seuemail@gmail.com", "suasenha") 'email e senha

            Dim email As New MailMessage()
            email.From = New MailAddress(emailRemetente) 'email do remetente
            email.To.Add(emailDestinatario) ' Destinatário
            email.Subject = assuntoo ' Assunto do e-mail
            email.Body = corpoEmail ' Corpo do e-mail

            ' Enviando o e-mail
            smtp.Send(email)
            MessageBox.Show("E-mail enviado com sucesso!")
        Catch ex As Exception
            MessageBox.Show("Erro ao enviar e-mail: " & ex.Message)
        End Try
    End Sub
    Public Sub limpar()
        txt_assunto.Clear()
        txt_corpo.Clear()
        txt_email.Clear()
        txt_emailDestino.Clear()
    End Sub
    Private Sub btn_enviarEmail_Click(sender As Object, e As EventArgs) Handles btn_enviarEmail.Click
        Dim destinatario As String = txt_emailDestino.Text
        Dim assunto As String = txt_assunto.Text
        Dim mensagem As String = txt_corpo.Text

        enviarEmail(destinatario, assunto, mensagem)
    End Sub
    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        limpar()
    End Sub
    Private Sub btn_cancelarEmail_Click(sender As Object, e As EventArgs) Handles btn_cancelarEmail.Click
        Dim pergunta As DialogResult
        pergunta = MsgBox("Deseja realmente cancelar o envio?", vbQuestion + vbYesNo, "ATENÇÃO")
        If pergunta = DialogResult.Yes Then
            limpar()
            Me.Close()
        Else
            MsgBox("Continue escrevendo", vbInformation + vbOKOnly, "BELEZA")
        End If
    End Sub
    Private Sub escrever_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txt_corpo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_corpo.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_enviarEmail_Click(Nothing, New EventArgs())
        End If
    End Sub
End Class