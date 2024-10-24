Imports System.Security.Policy

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter Any Number:"
        Label2.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z, num As Integer
        x = Val(TextBox1.Text)
        num = x
        While (x > 0)
            y = x Mod 10
            z = z * 10 + y
            x = x / 10


        End While
        If (z = num) Then
            Label2.Text = "The Inputted Number is Palindrome:" + Str(num)
        Else
            Label2.Text = "The Inputted Number is Not palindrome:" + Str(num)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
