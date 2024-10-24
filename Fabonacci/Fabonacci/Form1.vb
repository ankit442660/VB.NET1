Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter a number"
        Label2.Text = "Fabonacci series is:"
        Label3.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, x, y, z As Integer
        x = 0
        y = 1
        Label3.Text = Label3.Text + Str(x) + Environment.NewLine + Str(y) + Environment.NewLine
        a = Val(TextBox1.Text)
        While (2 < a)
            z = x + y
            Label3.Text = Label3.Text + Str(z) + Environment.NewLine
            x = y
            y = z
            a = a - 1
        End While
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
