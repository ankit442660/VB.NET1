Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter Any number"
        Label2.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, count As Integer

        x = Val(TextBox1.Text)

        count = 0
        y = 1
        While (y <= x)
            If (x Mod y = 0) Then
                count = count + 1
            End If
            y = y + 1

        End While
        If (count = 2) Then
            Label2.Text = "The inputted Number is prime" + Str(x)
        Else
            Label2.Text = "The inputted number is not prime" + Str(x)

        End If

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
