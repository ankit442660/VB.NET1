Public Class Form1
    Dim s(4) As String
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedIndex = 0) Then
            PictureBox1.Image = Image.FromFile(s(0))
        End If
        If (ListBox1.SelectedIndex = 1) Then
            PictureBox1.Image = Image.FromFile(s(1))
        End If
        If (ListBox1.SelectedIndex = 2) Then
            PictureBox1.Image = Image.FromFile(s(2))
        End If
        If (ListBox1.SelectedIndex = 3) Then
            PictureBox1.Image = Image.FromFile(s(3))
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        s(0) = "C:\Photos\p1.jpg"
        s(1) = "C:\Photos\p2.jpg"
        s(2) = "C:\Photos\p3.jpg"
        s(3) = "C:\Photos\p4.jpg"
        ListBox1.Items.Add("Ankit")
        ListBox1.Items.Add("Harsh")
        ListBox1.Items.Add("Sumit")
        ListBox1.Items.Add("C:\Photos\A(1).jpg")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
