Public Class Form1

    Dim n(3, 3), i, j As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To 2
            For j = 0 To 2
                Label3.Text = Label3.Text + Str(n(i, j)) + Space(3)
            Next
            Label3.Text = Label3.Text + Environment.NewLine
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n(i, j) = Val(TextBox1.Text)
        j = j + 1
        If (j = 3) Then
            i = i + 1
            j = 0
            If (i = 3) Then
                Button1.Enabled = False
                Button2.Enabled = True
                TextBox1.Enabled = False

            Else
                TextBox1.Focus()
                TextBox1.Clear()
            End If
        Else
            TextBox1.Focus()
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        i = 0
        j = 0
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
