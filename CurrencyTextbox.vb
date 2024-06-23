Imports System.Windows.Forms

Public Class CurrencyTextBox
    Inherits System.Windows.Forms.MaskedTextBox

    Public Sub New()
        MyBase.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
    End Sub

    Public Function TryGetValue(ByRef data As Decimal) As Boolean
        Return Decimal.TryParse(RemovePromptAndLiterals(Me.Text), data)
    End Function
    Public Property Value() As Decimal
        Get
            Dim result As Decimal = 0
            TryGetValue(result)
            Return result
        End Get
        Set(ByVal value As Decimal)
            MyBase.Text = ReplaceLeadingZeros(value.ToString(Me.Mask))
        End Set
    End Property

    Private Function RemovePromptAndLiterals(ByVal data As String) As String
        Return If(data IsNot Nothing, data.Replace(" ", "").Replace(Me.PromptChar.ToString(), "").Replace("$", ""), "")
    End Function

    Protected Overrides Sub OnValidated(ByVal e As EventArgs)
        Dim data As Decimal = 0
        If TryGetValue(data) = True Then
            MyBase.Text = ReplaceLeadingZeros(data.ToString(Me.Mask))
        End If
        MyBase.OnValidated(e)
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
    End Sub
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            Dim data As Decimal = 0
            If Decimal.TryParse(RemovePromptAndLiterals(value), data) = True Then
                MyBase.Text = ReplaceLeadingZeros(data.ToString(Me.Mask))
            Else
                MyBase.Text = value
            End If
        End Set
    End Property
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        If e.KeyChar = "." Then
            Dim data As Decimal = 0
            If TryGetValue(data) = True Then
                Dim mask As String = Me.Mask.Replace(".00", ".##").Replace(".99", ".##")
                MyBase.Text = ReplaceLeadingZeros(data.ToString(mask))
            End If
        End If
        MyBase.OnKeyPress(e)
    End Sub
    Protected Function ReplaceLeadingZeros(ByVal data As String) As String
        Dim chars As Char() = data.ToCharArray()
        For i As Integer = 0 To chars.Length - 1
            If chars(i) <> "$" AndAlso chars(i) <> " " Then
                If chars(i) = "0" Then
                    chars(i) = Me.PromptChar
                Else
                    Exit For
                End If
            End If
        Next
        Return New String(chars)
    End Function
End Class