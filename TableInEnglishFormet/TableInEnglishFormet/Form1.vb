Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter any number"
        Label3.Text = ""
        Label2.Text = "MultiPlication Table is:"
        Button1.Text = "Click"
        Button2.Text = "cancel"
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = Val(TextBox1.Text)
        For y = 1 To 10
            z = x * y
            Label3.Text = Label3.Text + Str(x) + " * " + Str(y) + " = " + Str(z) + Environment.NewLine
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
