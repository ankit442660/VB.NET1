Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter number to find factorail"
        Label2.Text = "Factorial:"
        Label3.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y As Integer
        x = Val(TextBox1.Text)
        y = 1
        While (x > 0)
            y = y * x
            x = x - 1
        End While

        Label3.Text = y

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
