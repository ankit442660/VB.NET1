Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter first Number"
        Label2.Text = "Enter Second Number"
        Label3.Text = "Result"
        Label4.Text = ""
        Button1.Text = "Addition"
        Button2.Text = "Subtraction"
        Button3.Text = "Multiplication"
        Button4.Text = "Division"
        Button5.Text = "Cancel"

    End Sub
    Dim X, Y, Z As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = X * Y
        Label4.Text = Z
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = X / Y
        Label4.Text = Z
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = X - Y
        Label4.Text = Z
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = X + Y
        Label4.Text = Z

    End Sub
End Class
