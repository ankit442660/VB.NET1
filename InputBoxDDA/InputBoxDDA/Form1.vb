Public Class Form1
    Dim n(3, 3), i, j As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To 2
            For j = 0 To 2
                Label2.Text = Label2.Text + Str(n(i, j)) + Space(3)
            Next
            Label2.Text = Label2.Text + Environment.NewLine
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 2
            For j = 0 To 2
                n(i, j) = Val(InputBox("Enter content in Array", "DDA", "0"))
            Next
        Next
    End Sub


End Class
