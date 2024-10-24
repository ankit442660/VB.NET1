Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedIndex = 0) Then
            If (ComboBox2.SelectedIndex = 0) Then
                TextBox1.BackColor = Color.Red
            End If
            If (ComboBox2.SelectedIndex = 1) Then
                TextBox1.BackColor = Color.Green
            End If
            If (ComboBox2.SelectedIndex = 2) Then
                TextBox1.BackColor = Color.Blue
            End If
            If (ComboBox2.SelectedIndex = 3) Then
                TextBox1.BackColor = Color.Yellow
            End If
        End If
        If (ComboBox1.SelectedIndex = 1) Then
            If (ComboBox2.SelectedIndex = 0) Then
                TextBox1.ForeColor = Color.Red

            End If
            If (ComboBox2.SelectedIndex = 1) Then
                TextBox1.ForeColor = Color.Green

            End If
            If (ComboBox2.SelectedIndex = 2) Then
                TextBox1.ForeColor = Color.Blue

            End If
            If (ComboBox2.SelectedIndex = 3) Then
                TextBox1.ForeColor = Color.Yellow

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
