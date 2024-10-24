Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Principal"
        Label2.Text = "Rate"
        Label3.Text = "Time"
        Label4.Text = "Interest"
        Label5.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""


        Label6.Text = "To Find the simple intrest"
        Button1.Enabled = False
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = Val(TextBox3.Text)
        Label5.Text = (x * y * z) / 100
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Enabled = True

            Button1_Click(sender, e)
        End If

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
End Class
