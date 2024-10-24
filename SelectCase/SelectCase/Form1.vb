Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "MAIN MENU"
        Label2.Text = "1.ADD"
        Label3.Text = "2.Sub"
        Label4.Text = "3.Mul"
        Label5.Text = "4.Div"
        Label6.Text = "Exit"
        Label7.Text = "Enter your Choice"
        Label8.Text = "Enter first No:"
        Label9.Text = "Enter Second No:"
        Label10.Text = "Result"
        Label11.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Button1.Text = "OK"
        Button2.Text = "Cancel"
        Button1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = Val(TextBox3.Text)
        Select Case x
            Case 1
                Label11.Text = y + z
            Case 2
                Label11.Text = y - z
            Case 3
                Label11.Text = y * z
            Case 4
                Label11.Text = y / z
            Case 5
                End
            Case Else
                Label11.Text = "Invalid choice"
        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub



    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Enabled = True

        End If
    End Sub
End Class
