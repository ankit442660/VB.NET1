Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Eneter First Number"
        Label2.Text = "Enter Second Number"
        Label3.Text = "Sum"
        Label4.Text = ""
        Label5.Text = "Sub"
        Label6.Text = ""
        Label7.Text = "Mul"
        Label8.Text = ""
        Label9.Text = "Div"
        Label10.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        Button1.Text = "Show"
        Button2.Text = "Exit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x, y, z As Integer
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = x + y
        Label4.Text = z
        z = x - y
        Label6.Text = z
        z = x * y
        Label8.Text = z
        z = x / y
        Label10.Text = z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
