Public Class Form1
    Dim i As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("C:\Photos\p1.jpg")
        ListBox1.Items.Add("C:\Photos\p2.jpg")
        ListBox1.Items.Add("C:\Photos\p3.jpg")
        ListBox1.Items.Add("C:\Photos\p4.jpg")
        i = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Image = Image.FromFile(ListBox1.Items.Item(i))
        i = i + 1
        If (i = 4) Then
            i = 0
        End If
    End Sub
End Class
