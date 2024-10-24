Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter First No"
        Label2.Text = "Enter Second No"
        Label3.Text = "Result"
        Label4.Text = "  "
        Button1.Text = "Sum"
        Button2.Text = "Cancel"
        Button1.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X, Y, Z As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = X + Y
        Label4.Text = Z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Enabled = True
            Button1_Click(sender, e)
        End If
    End Sub
End Class
