Public Class Form1

    Private Sub BunifuFlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BunifuFlatButton1.Click
        If txtid.Text = "" Then
            MsgBox("Enter user ID", vbCritical)
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter user pass ", vbCritical)
        ElseIf txtid.Text = "admin" And txtpass.Text = "12345" Then
            MsgBox("Access Granted", vbInformation)
            Form2.Show()
        Else
            MsgBox("Access Denied",vbCritical)
        End If
    End Sub
End Class
