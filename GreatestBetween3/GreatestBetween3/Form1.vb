Public Class Form1
    Dim x, y, z As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = Val(TextBox3.Text)

        If (x > y) Then
            If (x > z) Then
                Label5.Text = " x is Greater" + Str(x)

            Else
                Label5.Text = " z is Greater" + Str(z)
            End If

        Else
            If (y > z) Then
                Label5.Text = " y is Greater" + Str(y)
            Else
                Label5.Text = " z is Greater" + Str(z)


            End If


        End If
    End Sub
End Class
