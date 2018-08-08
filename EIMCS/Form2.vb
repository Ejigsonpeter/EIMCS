Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim imgName1 As String
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim cmd As MySqlCommand
    Dim Myconnection As New MySqlConnection With {.ConnectionString = "server = localhost; userid = root ; password =; database = eimcs ;"}



    'method to handle clearing fields in the registration form
    Sub clear()
        'group 1
        txtSearch.Text = ""
        txtdeptunit.Text = ""
        txtfileno.Text = ""
        txtFirstname.Text = ""
        txtippsno.Text = ""
        txtlocation.Text = ""
        txtMiddlename.Text = ""
        txtphoneno1.Text = ""
        txtphoneno2.Text = ""
        txtrank.Text = ""
        txtresidentialaddress.Text = ""
        txtSurname.Text = ""
        imgpix.Image = BackgroundImage

        'group 2 

        txtRegFee.Text = ""
        txtSavings.Text = ""
        txtshares.Text = ""
        nokAddress1.Text = ""
        nokAddress2.Text = ""
        nokName1.Text = ""
        nokName2.Text = ""
        nokPhone1.Text = ""
        nokPhoneno2.Text = ""
        nokRelationship1.Text = ""
        nokRelationship2.Text = ""


        'group 3
        txtEimcs.Text = ""
        txtApproved.Text = ""
        txtMDate.Text = ""
        TxtNotApproved.Text = ""
        txtPdate.Text = ""
        txtGdate.Text = ""
        txtFullname.Text = ""
        imgGSignature.Image = BackgroundImage
        imgMsignature.Image = BackgroundImage
        imgPsignature.Image = BackgroundImage
    End Sub

    'This method handles the field confirmation and ensures no field is left blank....1/3'
    Sub empty1()
        Try
            If txtSurname.Text = "" Then
                MsgBox("Please Provide Surname ,Field cannot be empty", vbCritical)
                txtSurname.Focus()
            ElseIf txtFirstname.Text = "" Then
                MsgBox("Please Provide Surname,Field cannot be empty", vbCritical)
                txtFirstname.Focus()
            ElseIf txtMiddlename.Text = "" Then
                MsgBox("Please Provide Middlename,Field cannot be empty", vbCritical)
                txtMiddlename.Focus()
            ElseIf txtippsno.Text = "" Then
                MsgBox("Please Provide IPPS No ,Field cannot be empty", vbCritical)
                txtippsno.Focus()
            ElseIf txtfileno.Text = "" Then
                MsgBox("Please Provide File number Field cannot be empty", vbCritical)
                txtfileno.Focus()
            ElseIf txtdeptunit.Text = "" Then
                MsgBox("Please Provide Department  unit ,Field cannot be empty", vbCritical)
                txtdeptunit.Focus()
            ElseIf txtrank.Text = "" Then
                MsgBox("Please Provide Rank,Field cannot be empty", vbCritical)
                txtrank.Focus()
            ElseIf txtlocation.Text = "" Then
                MsgBox("Please Provide Location,Field cannot be empty", vbCritical)
                txtlocation.Focus()
            ElseIf txtphoneno1.Text = "" Then
                MsgBox("Please Provide Phone number, Field cannot be empty", vbCritical)
                txtphoneno1.Focus()
            ElseIf txtphoneno2.Text = "" Then
                MsgBox("Please Provide Phone number ,Field cannot be empty", vbCritical)
                txtphoneno2.Focus()
            ElseIf txtresidentialaddress.Text = "" Then
                MsgBox("Please Provide Residential Address ,Field cannot be empty", vbCritical)
                ' ElseIf imgpix.Image = BackgroundImage Then
            Else
                nextbutton()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    'next button function
    Sub nextbutton()
        group1.Visible = False
        group2.Visible = True
        group3.Visible = False
    End Sub

    'this metho add the fields confirmation and ensures no field is blank for .....2/3
    Sub empty2()
        If nokName1.Text = "" Then
            MsgBox("Please provide Name , Space cannot be empty")
            nokName1.Focus()
        ElseIf nokPhone1.Text = "" Then
            MsgBox("Please provide Phone number  , Space cannot be empty")
            nokPhone1.Focus()
        ElseIf nokRelationship1.Text = "" Then
            MsgBox("Please provide Relationship with next of kin , Space cannot be empty")
            nokRelationship1.Focus()
        ElseIf nokAddress1.Text = "" Then
            MsgBox("Please provide Address, Space cannot be empty")
            nokAddress1.Focus()
        ElseIf nokName2.Text = "" Then
            MsgBox("Please provide Name , Space cannot be empty")
            nokName2.Focus()
        ElseIf nokPhoneno2.Text = "" Then
            MsgBox("Please provide Phone number , Space cannot be empty")
            nokPhoneno2.Focus()
        ElseIf nokRelationship2.Text = "" Then
            MsgBox("Please provide Relationship , Space cannot be empty")
            nokRelationship2.Focus()
        ElseIf nokAddress2.Text = "" Then
            MsgBox("Please provide Address, Space cannot be empty")
            nokAddress2.Focus()
        ElseIf txtRegFee.Text = "" Then
            MsgBox("Please provide Amount, Space cannot be empty")
            txtRegFee.Focus()
        ElseIf txtSavings.Text = "" Then
            MsgBox("Please provide Amount , Space cannot be empty")
            txtSavings.Focus()
        ElseIf txtshares.Text = "" Then
            MsgBox("Please provide Amount , Space cannot be empty")
            txtshares.Focus()
        Else
            nextbutton2()
        End If
    End Sub
    'nextbutton2 function
    Sub nextbutton2()
        group1.Visible = False
        group2.Visible = False
        group3.Visible = True
    End Sub

    'this button loads the previous form 1/3
    Private Sub btnprev1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev1.Click
        group1.Visible = True
        group2.Visible = False
        group3.Visible = False
    End Sub
    'this button loads the next form 2 / 3
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        empty1()
    End Sub
    'This button loads the final form 3/3
    Private Sub btnnext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext2.Click
        empty2()
    End Sub
    'this button loads the previous form 2/3
    Private Sub btnprevious_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprevious.Click
        group1.Visible = False
        group2.Visible = True
        group3.Visible = False
    End Sub

    Private Sub btnclear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub
    'Method to handle Uploading user profile picture via button click
    Private Sub btnUploadPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadPicture.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If dlgimage.ShowDialog() = DialogResult.OK Then
                imgName1 = dlgimage.FileName

                Dim newImg As New Bitmap(imgName1)
                imgpix.SizeMode = PictureBoxSizeMode.StretchImage
                imgpix.Image = DirectCast(newImg, Image)
            End If
            dlgimage = Nothing
        Catch ae As System.ArgumentException
            imgName1 = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
End Class