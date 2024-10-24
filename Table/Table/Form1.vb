Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, x, y As Integer
        x = Val(TextBox1.Text)
        For i = 1 To x
            For j = 1 To 10
                y = i * j
                Label3.Text = Label3.Text + Str(y) + Space(2)
            Next
            Label3.Text = Label3.Text + Environment.NewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


End Class
