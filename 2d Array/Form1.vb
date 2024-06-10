Imports System.Drawing.Drawing2D

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        sum = 0
        Dim num(2, 2) As Integer
        num(0, 0) = 1
        num(0, 1) = 2
        num(1, 0) = 3
        num(1, 1) = 4

        For i As Integer = 0 To num.GetLength(0) - 1
            For j As Integer = 0 To num.GetLength(0) - 1
                sum = sum + num(i, j)
            Next
        Next

        TextBox1.Text = sum

    End Sub
End Class
