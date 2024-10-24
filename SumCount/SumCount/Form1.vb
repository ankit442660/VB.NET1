Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter any number"
        Label2.Text = "Sum:"
        Label4.Text = "Count:"
        Label3.Text = ""
        Label5.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y, d, z, a As Integer
        Dim x As Integer
        x = Val(TextBox1.Text)
        d = x

        While (d > 0)
            y = d Mod 10
            z = z + y
            d = d / 10
            a = a + 1





        End While
        Label3.Text = z
        Label5.Text = a
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
