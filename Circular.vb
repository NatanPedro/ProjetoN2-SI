Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Public Class Circular
    Inherits PictureBox
    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim grPath As GraphicsPath = New GraphicsPath()
        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grPath)
        MyBase.OnPaint(pe)
    End Sub
End Class
