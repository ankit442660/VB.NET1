Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter first number"
        Label2.Text = "Enter second number"
        Label3.Text = "Result"
        Label4.Text = ""
        Button1.Text = "Sum"
        Button2.Text = "Exit"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer

        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x + y
        Label4.Text = z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As EventArgs) Handles TextBox1.KeyPress
        If e.Keychain = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub
End Class
