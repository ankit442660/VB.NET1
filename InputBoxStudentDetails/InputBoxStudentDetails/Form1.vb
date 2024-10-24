Public Class Form1
    Dim sname As String, fee As Integer, roll As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = sname
        Label4.Text = roll
        Label6.Text = fee
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sname = InputBox("Enter Student Name:", "StudentDetails")
        roll = Val(InputBox("Enter Roll:", "StudentDetails"))
        fee = Val(InputBox("Enter Fee:", "StudentDetails"))
    End Sub
End Class
