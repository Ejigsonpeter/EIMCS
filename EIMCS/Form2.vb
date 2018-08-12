Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim imgName1 As String
    Dim imgName2 As String
    Dim imgName3 As String
    Dim imgName4 As String
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
        txtPdate.Text = ""
        txtGdate.Text = ""
        txtFullname.Text = ""
        imgGSignature.Image = BackgroundImage
        imgMsignature.Image = BackgroundImage
        imgPsignature.Image = BackgroundImage

        Call datetime()
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

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtFullname.Text = "" Then
            MsgBox("Please Provide Fullname ,Field cannot be empty", vbCritical)
            txtFullname.Focus()
        ElseIf txtEimcs.Text = "" Then
            MsgBox("Please Provide eimcsno ,Field cannot be empty", vbCritical)
            txtEimcs.Focus()
        ElseIf txtApproved.Text = "" Then
            MsgBox("Please Provide yes or no as an answer ,Field cannot be empty", vbCritical)
            txtApproved.Focus()
       
        Else

        End If


    End Sub
    'method to handle date and time
    Sub datetime()
        Dim a As Date
        Dim b As Date
        Dim c As Date
        txtMDate.Text = a.Date
        txtPdate.Text = b.Date
        txtGdate.Text = c.Date
    End Sub
    'Method to handle Uploading general secretary signature
    Private Sub supload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supload.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If dlgimage.ShowDialog() = DialogResult.OK Then
                imgName2 = dlgimage.FileName

                Dim newImg As New Bitmap(imgName2)
                imgGSignature.SizeMode = PictureBoxSizeMode.StretchImage
                imgGSignature.Image = DirectCast(newImg, Image)
            End If
            dlgimage = Nothing
        Catch ae As System.ArgumentException
            imgName2 = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    'Method to handle Uploading presidents signature
    Private Sub puppload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles puppload.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If dlgimage.ShowDialog() = DialogResult.OK Then
                imgName3 = dlgimage.FileName

                Dim newImg As New Bitmap(imgName3)
                imgPsignature.SizeMode = PictureBoxSizeMode.StretchImage
                imgPsignature.Image = DirectCast(newImg, Image)
            End If
            dlgimage = Nothing
        Catch ae As System.ArgumentException
            imgName3 = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    'Method to handle Uploading Applicant signature
    Private Sub aupload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aupload.Click
        Try
            Dim dlgimage As FileDialog = New OpenFileDialog
            dlgimage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"
            If dlgimage.ShowDialog() = DialogResult.OK Then
                imgName4 = dlgimage.FileName

                Dim newImg As New Bitmap(imgName4)
                imgGSignature.SizeMode = PictureBoxSizeMode.StretchImage
                imgGSignature.Image = DirectCast(newImg, Image)
            End If
            dlgimage = Nothing
        Catch ae As System.ArgumentException
            imgName4 = " "
            MessageBox.Show(ae.Message.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call datetime()

    End Sub
    ' this method handles the save query

    Sub savemember()
        Try
            Myconnection.Close()
            Myconnection.Open()

            If imgName1 <> "" And imgName2 <> "" And imgName3 <> "" And imgName4 <> "" Then
                Dim fs1 As FileStream
                Dim fs2 As FileStream
                Dim fs3 As FileStream
                Dim fs4 As FileStream

                fs1 = New FileStream(imgName1, FileMode.Open, FileAccess.Read)
                Dim picByte As Byte() = New Byte(fs1.Length - 1) {}
                fs1.Read(picByte, 0, System.Convert.ToInt32(fs1.Length))
                fs1.Close()

                fs2 = New FileStream(imgName2, FileMode.Open, FileAccess.Read)
                Dim picByte2 As Byte() = New Byte(fs2.Length - 1) {}
                fs2.Read(picByte2, 0, System.Convert.ToInt32(fs2.Length))
                fs2.Close()

                fs3 = New FileStream(imgName3, FileMode.Open, FileAccess.Read)
                Dim picByte3 As Byte() = New Byte(fs3.Length - 1) {}
                fs3.Read(picByte3, 0, System.Convert.ToInt32(fs3.Length))
                fs3.Close()

                fs4 = New FileStream(imgName4, FileMode.Open, FileAccess.Read)
                Dim picByte4 As Byte() = New Byte(fs4.Length - 1) {}
                fs4.Read(picByte4, 0, System.Convert.ToInt32(fs4.Length))
                fs4.Close()


                Dim sql As String
                sql = "insert into members (surname,firstname,middlename,ippsno,fileno,deptunit,rank,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,presidentdate,gensecdate,applicantdate,passport,signature,presidentsignature,secretarysignature)" _
                    & "VALUES(@surname,@firstname,@middlename,@ippsno,@fileno,@deptunit,@rank,@phoneno1,@phoneno2,@residentialaddress,@nextofkinname1,@nextofkinphoneno1,@nextofkinrelationship1, @nextofkinaddress1,@nextofkinname2, @nextofkinphoneno2, @nextofkinrelationship2,@nextofkinaddress2,@shares, @savings,@Registrationfees, @eimcsno, @approvalstatus, @fullname,@presidentdate,@gensecdate,@applicantdate,@passport,@signature,@president,@sec)"

                Dim imgParam As New MySqlParameter()
                imgParam.MySqlDbType = MySqlDbType.Binary
                imgParam.ParameterName = "passport"
                imgParam.Value = picByte

                Dim imgParam1 As New MySqlParameter()
                imgParam1.MySqlDbType = MySqlDbType.Binary
                imgParam1.ParameterName = "signature"
                imgParam1.Value = picByte2

                Dim imgParam2 As New MySqlParameter()
                imgParam2.MySqlDbType = MySqlDbType.Binary
                imgParam2.ParameterName = "president"
                imgParam2.Value = picByte2

                Dim imgParam3 As New MySqlParameter()
                imgParam3.MySqlDbType = MySqlDbType.Binary
                imgParam3.ParameterName = "sec"
                imgParam3.Value = picByte3

                Dim cmdx As New MySqlCommand(sql, Myconnection)
                cmdx.Parameters.AddWithValue("@surname", txtSurname.Text)
                cmdx.Parameters.AddWithValue("@firstname", txtFirstname.Text)
                cmdx.Parameters.AddWithValue("@middlename", txtMiddlename.Text)
                cmdx.Parameters.AddWithValue("@ippsno", txtippsno.Text)
                cmdx.Parameters.AddWithValue("@fileno", txtfileno.Text)
                cmdx.Parameters.AddWithValue("@deptunit", txtdeptunit.Text)
                cmdx.Parameters.AddWithValue("@rank", txtrank.Text)
                cmdx.Parameters.AddWithValue("@phoneno1", txtphoneno1.Text)
                cmdx.Parameters.AddWithValue("@phoneno2", txtphoneno2.Text)
                cmdx.Parameters.AddWithValue("@residentialaddress", txtresidentialaddress.Text)
                cmdx.Parameters.AddWithValue("@nextofkinname1", nokName1.Text)
                cmdx.Parameters.AddWithValue("@nextofkinphoneno1", nokPhone1.Text)
                cmdx.Parameters.AddWithValue("@nextofkinrelationship1", nokRelationship1.Text)
                cmdx.Parameters.AddWithValue("@nextofkinaddress1", nokAddress1.Text)
                cmdx.Parameters.AddWithValue("@nextofkinname2", nokName2.Text)
                cmdx.Parameters.AddWithValue("@nextofkinphoneno2", nokPhoneno2.Text)
                cmdx.Parameters.AddWithValue("@nextofkinrelationship2", nokRelationship2.Text)
                cmdx.Parameters.AddWithValue("@nextofkinaddress2", nokAddress2.Text)
                cmdx.Parameters.AddWithValue("@shares", txtshares.Text)
                cmdx.Parameters.AddWithValue("@savings", txtSavings.Text)
                cmdx.Parameters.AddWithValue("@Registrationfees", txtRegFee.Text)
                cmdx.Parameters.AddWithValue("@eimcsno", txtEimcs.Text)
                cmdx.Parameters.AddWithValue("@approvalstatus", txtApproved.Text)
                cmdx.Parameters.AddWithValue("@fullname", txtFullname.Text)
                cmdx.Parameters.AddWithValue("@presidentdate", txtPdate.Text)
                cmdx.Parameters.AddWithValue("@gensecdate", txtGdate.Text)
                cmdx.Parameters.AddWithValue("@applicantdate", txtMDate.Text)
                cmdx.Parameters.Add(imgParam)
                cmdx.Parameters.Add(imgParam1)
                cmdx.Parameters.Add(imgParam2)
                cmdx.Parameters.Add(imgParam3)
                cmdx.ExecuteNonQuery()
                MsgBox("Information Saved Successfully ", vbInformation)
                clear()
                'grid()

                Myconnection.Close()
            Else
                MsgBox("Upload all the necccessary documents first",MsgBoxStyle.Information)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    ' this method checks for duplicate data
    Sub save()
        Try
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim query As String
            query = "select * from bas.members where ippsno = '" & txtippsno.Text & "'"
            cmd = New MySqlCommand(query, Myconnection)
            reader = cmd.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While
            If count > 0 Then
                MsgBox("IPPS Number already Exist in Database", vbInformation)
                Myconnection.Close()
            Else
                savemember()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class