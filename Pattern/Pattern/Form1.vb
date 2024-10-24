Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k As Integer
        k = 0

        For i = 1 To i <= 5

            For j = 9 - k To j > 0 Step -2
                Label2.Text = Label2.Text + Str(j) + Space(3)
            Next
            For j = 3 To j < 10 - k Step 2
                Label2.Text = Label2.Text + Str(j) + Space(3)

            Next
            Label2.Text = Label2.Text + Environment.NewLine
            k = k + 2


        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
