Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim dt As DataTable
    Dim rs As DataRow
    Dim count As Integer
    Dim flag As Integer




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CON As SqlConnection = New SqlConnection("Data")


        Dim CMD As SqlCommand = New SqlCommand("INSERT  INTO [dbo].[srecond].
([id],[name],[roll])
values TextBox1.Text+" ',' " +TextBox2.Text+" ','"+TextBox3.Text+ " ',' "+ CON ")
        CON.Open()
        CMD.PxecuteNonQuery()
        MessageBox.Show("Record Insert Successfuly")



    End Sub
End Class
