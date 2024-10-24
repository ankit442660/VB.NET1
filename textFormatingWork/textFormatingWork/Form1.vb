Public Class Form1
    Dim fname, style As String
    Dim size1, i As Integer



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        size1 = Val(ComboBox1.Text)
        TextBox1.Font = New Font(fname, size1)

    End Sub

    Private Sub ListBox1_click(sender As Object, e As EventArgs) Handles ListBox1.Click
        fname = ListBox1.SelectedItem
        TextBox1.Font = New Font(fname, size1)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.ForeColor = Color.Pink
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 8 To 72 Step 2
            ComboBox1.Items.Add(Str(i))

        Next
        ComboBox1.Text = "15"
        size1 = 20


    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged


        If (ListBox2.SelectedIndex = 0) Then
            TextBox1.Font = New Font(fname, size1, FontStyle.Bold)
        End If
        If (ListBox2.SelectedIndex = 1) Then
            TextBox1.Font = New Font(fname, size1, FontStyle.Italic)
        End If
        If (ListBox2.SelectedIndex = 2) Then
            TextBox1.Font = New Font(fname, size1, FontStyle.Underline)
        End If
        If (ListBox2.SelectedIndex = 3) Then
            TextBox1.Font = New Font(fname, size1, FontStyle.Regular)
        End If

    End Sub
End Class
