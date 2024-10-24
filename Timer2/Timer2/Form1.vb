Public Class Form1
    Dim ctr As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Left = Label1.Left + 10
        ctr = ctr + 1
        If (ctr = 20) Then
            Label1.Left = 47
            ctr = 0

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ctr = 0
    End Sub
End Class
