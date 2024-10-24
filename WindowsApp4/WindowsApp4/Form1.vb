Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim com As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ankit\OneDrive\Pictures\Documents\MyTestDBT.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True")


        Dim cmd As SqlCommand = New SqlCommand("select * from Table", com)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class
