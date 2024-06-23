Imports System.Data.OleDb
Imports System.IO
Imports iText.IO.Font
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element

Public Class Acesso
    Public Sub GerarPDf(ByVal data As String, ByVal produto As String, ByVal quantidade As Integer, ByVal valorTotal As Decimal)
        ' Criação do objeto SaveFileDialog
        Dim salvarArquivo As New SaveFileDialog()
        salvarArquivo.Filter = "Arquivos PDF (*.pdf)|*.pdf" ' Define o filtro para arquivos PDF
        salvarArquivo.FileName = "NotaDeVenda.pdf" ' Nome padrão do arquivo

        ' Exibe a janela de salvar arquivo
        If salvarArquivo.ShowDialog() = DialogResult.OK Then
            Dim caminhoPDF As String = salvarArquivo.FileName

            Using wPdf = New PdfWriter(caminhoPDF, New WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0))
                Dim pdfDocumente = New PdfDocument(wPdf)

                Dim documento = New Document(pdfDocumente)
                Dim titulo As New iText.Layout.Element.Paragraph("RELATÓRIO DE PEDIDOS")
                titulo.SetFontSize(16)
                titulo.SetBold()
                documento.Add(titulo)
                ' Adicionar informações do pedido atual
                Dim paragrafoPedido As New iText.Layout.Element.Paragraph($"Data: {data} - Produto: {produto} - Quantidade: {quantidade} - Valor Total: R$ {valorTotal:F2}")
                documento.Add(paragrafoPedido)

                documento.Close()

                MsgBox($"Documento gerado em {caminhoPDF}")
            End Using
        End If
    End Sub
End Class