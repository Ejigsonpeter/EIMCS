Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    ' creating mysql connection
    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim cmd As MySqlCommand


    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If txtid.Text = "" Then
            MsgBox("Enter user ID", vbCritical)
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter user pass ", vbCritical)
        ElseIf txtid.Text = "admin" And txtpass.Text = "12345" Then
            MsgBox("Access Granted", vbInformation)
            Form2.Show()
        Else
            Try
                Myconnection.Open()
                Dim query As String
                Dim reader As MySqlDataReader
                Dim status As String
                status = "active"
                query = "Select * from users where userid = '" & txtid.Text & "' and password = '" & txtpass.Text & "' and status = '" & status & "'"
                cmd = New MySqlCommand(query, Myconnection)
                reader = cmd.ExecuteReader
                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While
                If count > 0 Then
                    MsgBox("Access Granted ", vbInformation)
                    Me.Hide()
                    Form2.Show()
                Else
                    MsgBox("Access Denied! Incorret Login Details",vbCritical)
                    clear()
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Sub clear()
        txtid.Text = ""
        txtpass.Text = ""
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        clear()
    End Sub
End Class
