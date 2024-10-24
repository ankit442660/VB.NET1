
Public Class Form1
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If (GunaTextBox1.Text = "Ankit" And GunaTextBox3.Text = "123") Then
            Me.Visible = False
            Form2.Visible = True
        Else
            MsgBox("Wrong userId or Password")

        End If

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBox1.TextChanged

    End Sub
End Class
