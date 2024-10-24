Public Class Form1
    Dim x, y, z As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(InputBox("Enter First No:", "Sum", "0"))
        y = Val(InputBox("Enter Second No:", "Sum", "0"))

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        z = x + y
        Label2.Text = z

    End Sub



End Class
