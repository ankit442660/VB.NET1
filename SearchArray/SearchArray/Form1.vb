﻿Public Class Form1

    Dim n(10) As Integer, i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        i = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n(i) = Val(TextBox1.Text)
        i = i + 1
        If (i = 10) Then
            TextBox1.Enabled = False
            Button1.Enabled = False
            Button2.Enabled = True
        Else
            TextBox1.Clear()
            TextBox1.Focus()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 0 To 9
            Label3.Text = Label3.Text + n(i) + Space(3)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num, f As Integer
        num = Val(InputBox("Enter number to Search", "Input", "0"))
        For i = 0 To 9
            If (n(i) = num) Then
                MsgBox("Number is Found")
                f = 1
                Exit For

            End If

        Next
        If (f = 0) Then
            MsgBox("Number not found")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1_Click(sender, e)
        End If
    End Sub
End Class
