Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l1(10) As Label
        Dim c, r, ctr As Integer
        c = 50
        r = 50
        ctr = 1
        For i = 0 To 9
            l1(i) = New Label
            l1(i).Width = 50
            l1(i).Height = 20
            l1(i).Location = New Point(c, r)
            c = c + 100
            ctr = ctr + 1
            If (ctr = 6) Then
                r = r + 100
                c = 50
            End If

            l1(i).Text = Str(i + 1)
            Me.Controls.Add(l1(i))

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t1(10) As TextBox
        Dim c, r, ctr As Integer
        c = 50
        r = 50
        ctr = 1
        For i = 0 To 9
            t1(i) = New TextBox
            t1(i).Width = 50
            t1(i).Height = 20
            t1(i).Location = New Point(c, r)
            c = c + 100
            ctr = ctr + 1
            If (ctr = 6) Then
                r = r + 100
                c = 50
            End If

            t1(i).Text = Str(i + 1)
            Me.Controls.Add(t1(i))

        Next

    End Sub
End Class
