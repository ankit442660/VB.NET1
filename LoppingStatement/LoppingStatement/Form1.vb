Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Click me"
        Label1.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a = 1 To 5
            Label1.Text = Label1.Text + Str(a) + Environment.NewLine
        Next
    End Sub
End Class
