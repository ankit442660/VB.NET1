Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Enter Principal"
        Label2.Text = "Rate(%)"
        Label3.Text = "Time(month)"
        Label4.Text = "Simple Intrest"
        Label5.Text = ""
        Button1.Text = "Click Here"
        Button2.Text = "Cancel"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X, Y, Z As Integer
        Dim SimInt As Integer
        X = Val(TextBox1.Text)
        Y = Val(TextBox2.Text)
        Z = Val(TextBox3.Text)
        SimInt = (X * Y * Z) / 100
        Label5.Text = SimInt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
