Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter number upto Fabonacci Series"
        Label2.Text = "Fabonacci Series is"
        Label3.Text = ""
        TextBox1.Text = ""
        Button1.Text = "Click"
        Button2.Text = "Cancel"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, x, y, z As Integer
        a = Val(TextBox1.Text)
        x = 0
        y = 1
        Label3.Text = Label3.Text + Str(x) + Environment.NewLine + Str(y) + Environment.NewLine
        While (x + y <= a)
            z = x + y


            Label3.Text = Label3.Text + Str(z) + Environment.NewLine



            x = y
            y = z

        End While


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
