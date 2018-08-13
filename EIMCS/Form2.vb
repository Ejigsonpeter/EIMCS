Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim imgName1 As String
    Dim imgName2 As String
    Dim imgName3 As String
    Dim imgName4 As String
    Dim dr As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim ds As New DataSet
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
    ' this is the submission button
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
            save()

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
                imgMsignature.SizeMode = PictureBoxSizeMode.StretchImage
                imgMsignature.Image = DirectCast(newImg, Image)
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
        Call grid()

    End Sub
    ' this method handles the save query

    Sub search()
        Try
            Myconnection.Close()
            Myconnection.Open()
            Dim reader As MySqlDataReader
            Dim command As MySqlCommand = New MySqlCommand
            command.Connection = Myconnection

            '----retrieve student's particulars
            command.CommandText = "SELECT * FROM members WHERE ippsno = '" & txtSearch.Text & "'"

            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count > 0 Then
                MsgBox(count & " Matching Record found in Database  ", vbInformation)

            txtSurname.Text = reader.Item("surname").ToString
            txtFirstname.Text = reader.Item("firstname").ToString
            txtMiddlename.Text = reader.Item("middlename").ToString
            txtippsno.Text = reader.Item("ippsno").ToString
            txtfileno.Text = reader.Item("fileno").ToString
            txtdeptunit.Text = reader.Item("deptunit").ToString
            txtrank.Text = reader.Item("rank").ToString
            txtlocation.Text = reader.Item("location").ToString
            txtphoneno1.Text = reader.Item("phoneno1").ToString
            txtphoneno2.Text = reader.Item("phoneno2").ToString
            txtresidentialaddress.Text = reader.Item("residentialaddress").ToString
            nokName1.Text = reader.Item("nextofkinname1").ToString
            nokPhone1.Text = reader.Item("nextofkinphoneno1").ToString
            nokRelationship1.Text = reader.Item("nextofkinrelationship1").ToString
            nokAddress1.Text = reader.Item("nextofkinaddress1").ToString
            nokName2.Text = reader.Item("nextofkinname2").ToString
            nokPhoneno2.Text = reader.Item("nextofkinphoneno2").ToString
            nokRelationship2.Text = reader.Item("nextofkinrelationship2").ToString
            nokAddress2.Text = reader.Item("nextofkinaddress2").ToString
            txtshares.Text = reader.Item("shares").ToString
            txtSavings.Text = reader.Item("savings").ToString
            txtRegFee.Text = reader.Item("Registrationfees").ToString
            txtEimcs.Text = reader.Item("eimcsno").ToString
            txtApproved.Text = reader.Item("approvalstatus").ToString
            txtFullname.Text = reader.Item("fullname").ToString
            txtPdate.Text = reader.Item("presidentdate").ToString
            txtGdate.Text = reader.Item("gensecdate").ToString
            txtMDate.Text = reader.Item("applicantdate").ToString


            'txtlevel.Text = .Item("level").ToString
            'txtdept.Text = reader.Item("department").ToString

            Dim imagepic As Byte() = CType(reader("passport"), Byte())
            Dim ms As New System.IO.MemoryStream(imagepic)
            Dim img As Image = Image.FromStream(ms)
            Me.imgpix.Image = img
            'studPic.Image = image.FromFile("image.jpg")
            imgpix.SizeMode = PictureBoxSizeMode.StretchImage
            imgpix.Refresh()

            Dim imagepic1 As Byte() = CType(reader("signature"), Byte())
            Dim ms1 As New System.IO.MemoryStream(imagepic1)
            Dim img1 As Image = Image.FromStream(ms1)
            Me.imgMsignature.Image = img1
            'studPic.Image = image.FromFile("image.jpg")
            imgMsignature.SizeMode = PictureBoxSizeMode.StretchImage
            imgMsignature.Refresh()


            Dim imagepic2 As Byte() = CType(reader("presidentsignature"), Byte())
            Dim ms2 As New System.IO.MemoryStream(imagepic2)
            Dim img2 As Image = Image.FromStream(ms2)
            Me.imgPsignature.Image = img2
            'studPic.Image = image.FromFile("image.jpg")
            imgPsignature.SizeMode = PictureBoxSizeMode.StretchImage
            imgPsignature.Refresh()

            Dim imagepic3 As Byte() = CType(reader("secretarysignature"), Byte())
            Dim ms3 As New System.IO.MemoryStream(imagepic3)
            Dim img3 As Image = Image.FromStream(ms3)
            Me.imgGSignature.Image = img3
            'studPic.Image = image.FromFile("image.jpg")
            imgGSignature.SizeMode = PictureBoxSizeMode.StretchImage
            imgGSignature.Refresh()
            Myconnection.Close()


            Else
                MsgBox("No Matching record found in Database", vbCritical)
                clear()
            End If
            '---reset the timer to another five seconds---
            'Timer1.Enabled = False
            'Timer1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub

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
                sql = "insert into members (surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,presidentdate,gensecdate,applicantdate,passport,signature,presidentsignature,secretarysignature)" _
                    & "VALUES(@surname,@firstname,@middlename,@ippsno,@fileno,@deptunit,@rank,@location,@phoneno1,@phoneno2,@residentialaddress,@nextofkinname1,@nextofkinphoneno1,@nextofkinrelationship1, @nextofkinaddress1,@nextofkinname2, @nextofkinphoneno2, @nextofkinrelationship2,@nextofkinaddress2,@shares, @savings,@Registrationfees, @eimcsno, @approvalstatus, @fullname,@presidentdate,@gensecdate,@applicantdate,@passport,@signature,@president,@sec)"

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
                cmdx.Parameters.AddWithValue("@location", txtlocation.Text)
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
            query = "select * from members where ippsno = '" & txtippsno.Text & "'"
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

    'handle and validates keystrokes for validating surname
    Private Sub txtSurname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSurname.KeyPress

        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character  Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtSurname.Focus()
            End If
        End If
    End Sub

    Private Sub txtFirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character  Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtFirstname.Focus()
            End If
        End If
    End Sub

    Private Sub txtMiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMiddlename.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character  Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtMiddlename.Focus()
            End If
        End If
    End Sub

    
    Private Sub txtippsno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtippsno.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtippsno.Focus()
            End If
        End If
    End Sub

    Private Sub txtrank_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrank.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtrank.Focus()
            End If
        End If
    End Sub

    Private Sub txtdeptunit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdeptunit.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtdeptunit.Focus()
            End If
        End If
    End Sub

    Private Sub txtfileno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfileno.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtfileno.Focus()
            End If
        End If
    End Sub

    Private Sub txtphoneno1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphoneno1.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtphoneno1.Focus()
            End If
        End If
    End Sub

    Private Sub txtphoneno2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtphoneno2.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtphoneno2.Focus()
            End If
        End If
    End Sub

    Private Sub txtlocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlocation.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtdeptunit.Focus()
            End If
        End If
    End Sub

    Private Sub txtresidentialaddress_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtresidentialaddress.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Or (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character Digits & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtdeptunit.Focus()
            End If
        End If
    End Sub

    Private Sub txtshares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtshares.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtshares.Focus()
            End If
        End If
    End Sub

    Private Sub txtSavings_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSavings.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtSavings.Focus()
            End If
        End If
    End Sub

    Private Sub txtRegFee_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegFee.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtRegFee.Focus()
            End If
        End If
    End Sub

    Private Sub txtEimcs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEimcs.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtEimcs.Focus()
            End If
        End If
    End Sub

    Private Sub txtApproved_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApproved.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtApproved.Focus()
            End If
        End If
    End Sub


    Private Sub txtFullname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFullname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                txtFullname.Focus()
            End If
        End If
    End Sub

    Private Sub nokName1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokName1.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokName1.Focus()
            End If
        End If
    End Sub

    Private Sub nokName2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokName2.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokName2.Focus()
            End If
        End If
    End Sub

    Private Sub nokRelationship1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokRelationship1.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character  Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokRelationship1.Focus()
            End If
        End If
    End Sub

    Private Sub nokRelationship2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokRelationship2.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character  Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokRelationship2.Focus()
            End If
        End If
    End Sub

   

    Private Sub nokPhone1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokPhone1.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokPhone1.Focus()
            End If
        End If
    End Sub

    Private Sub nokPhoneno2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokPhoneno2.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokPhoneno2.Focus()
            End If
        End If
    End Sub

    Private Sub nokAddress1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokAddress1.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Or (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character Digits & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokAddress1.Focus()
            End If
        End If
    End Sub

    Private Sub nokAddress2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nokAddress2.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Or (Char.IsDigit(e.KeyChar)) Then
                'do nothing
            Else
                e.Handled = True
                MsgBox("Sorry Only Character Digits & Spaces Allowed!!", _
                       MsgBoxStyle.Information, "Verify")
                nokAddress2.Focus()
            End If
        End If
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        search()
    End Sub

    Sub grid()

        Try
            Myconnection.Close()
            Myconnection.Open()

            Dim selectQuery As String = "select sno,surname,firstname,middlename,ippsno,fileno,deptunit,rank,location,phoneno1,phoneno2,residentialaddress,nextofkinname1,nextofkinphoneno1,nextofkinrelationship1,nextofkinaddress1,nextofkinname2,nextofkinphoneno2,nextofkinrelationship2,nextofkinaddress2,shares,savings,Registrationfees,eimcsno,approvalstatus,fullname,presidentdate,gensecdate,applicantdate from members"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(selectQuery, Myconnection)
            da = New MySql.Data.MySqlClient.MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            dgw.DataSource = ds.Tables(0)

           

            Myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtm.SelectedIndexChanged

        If txtm.SelectedIndex = 0 Then  'LTCL
            txtmonth.Text = "24"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            txtmonth.Text = "6"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS
            txtmonth.Text = "36"
            txtinterestRate.Text = "10"
        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            txtmonth.Text = "4"
            txtinterestRate.Text = "5"
        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            txtmonth.Text = "12"
            txtinterestRate.Text = "10"
        ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
            txtmonth.Text = "4"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 6 Then ' saving
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"


        End If
    End Sub

    Private Sub txtamountneeded_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamountneeded.Leave

    End Sub

   

    Private Sub txtamountneeded_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtamountneeded.Validated
        If txtm.SelectedIndex = 0 Then  'LTCL
            If Val(txtamountneeded.Text) > 2000000 Then
                MsgBox("Maximum Amount for this Loan is 2,000,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text)) / Val(txtmonth.Text)
            End If
        ElseIf txtm.SelectedIndex = 1 Then 'STCL
            If Val(txtamountneeded.Text) > 100000 Then
                MsgBox("Maximum Amount for this Loan is 100,000", vbCritical)
                txtamountneeded.Text = ""
                txtamountneeded.Focus()
            Else
                txtamountpayable.Text = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text)) / Val(txtmonth.Text)
            End If
        ElseIf txtm.SelectedIndex = 2 Then 'LMTS
           
                txtamountpayable.Text = (Val(txtamountneeded.Text) + Val(txtinterestRate.Text)) / Val(txtmonth.Text)

        ElseIf txtm.SelectedIndex = 3 Then 'STML i
            txtmonth.Text = "4"
            txtinterestRate.Text = "5"
        ElseIf txtm.SelectedIndex = 4 Then 'STML ii
            txtmonth.Text = "12"
            txtinterestRate.Text = "10"
        ElseIf txtm.SelectedIndex = 5 Then ' emergencyloan
            txtmonth.Text = "4"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 6 Then ' saving
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
        ElseIf txtm.SelectedIndex = 7 Then 'emergency savings
            txtmonth.Text = "1"
            txtinterestRate.Text = "0"
        End If

    End Sub
End Class