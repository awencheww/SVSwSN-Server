Imports MySql.Data.MySqlClient

Public Class formAddCandidate
    Dim a As OpenFileDialog = New OpenFileDialog

    Private Sub formAddCandidate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If formCandidate.adding = True Then
            lblTitle.Text = "Adding New Candidate Information"
            ClearAllfields()
            DisableAllTxtBox()
            loadLevel()
            cmbGender.Text = "Gender"
            Button1.Visible = True
        Else
            lblTitle.Text = "Updating Candidate Information"
            LoadStudent()
            GetUpdateCandidate()
            Button1.Visible = False
            txtCourse.ReadOnly = True
            txtDepartment.ReadOnly = True
            txtCandidateID.ReadOnly = True
            txtParty.ReadOnly = True
            txtPosition.ReadOnly = True
        End If
    End Sub

    Private Sub ClearAllfields()
        txtAddress.Text = ""
        txtAge.Text = ""
        txtBdate.Text = ""
        txtCellNumber.Text = "+639"
        txtCourse.Text = ""
        txtDepartment.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddlename.Text = ""
        cmbLevel.Text = ""
        txtParty.Text = ""
        txtPosition.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub DisableAllTxtBox()
        txtCandidateID.ReadOnly = True
        txtCellNumber.ReadOnly = True
        txtLastname.ReadOnly = True
        txtFirstname.ReadOnly = True
        txtMiddlename.ReadOnly = True
        txtAge.ReadOnly = True
        cmbGender.Enabled = False
        cmbYearLevel.Enabled = False
        txtCourse.ReadOnly = True
        txtDepartment.ReadOnly = True
        txtParty.ReadOnly = True
        txtPosition.ReadOnly = True
        txtAddress.ReadOnly = True
        txtBdate.ReadOnly = True
    End Sub

    Private Sub loadLevel()
        Try
            query = "SELECT * FROM voting_level ORDER By LevelID"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            cmbLevel.Items.Clear()
            Do While sqlreader.Read = True
                cmbLevel.Items.Add(sqlreader("LevelName"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub LoadStudent()
        Try
            Connection()
            query = "SELECT studentID,cellnumber,lastname,firstname,middlename,age,gender,bdate,address,yearlevel FROM thesis.student as s, thesis.course as c, thesis.department as d WHERE d.DepartmentID=s.DepartmentID AND c.CourseID=s.CourseID AND lastname LIKE '" & txtBoxSearch.Text & "%' ORDER BY lastname, firstname ASC "
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader

            If sqlreader.Read = True Then
                txtCandidateID.Text = sqlreader("studentID")
                txtCellNumber.Text = sqlreader("cellnumber")
                txtLastname.Text = sqlreader("lastname")
                txtFirstname.Text = sqlreader("firstname")
                txtMiddlename.Text = sqlreader("middlename")
                txtAge.Text = sqlreader("age")
                cmbGender.Text = sqlreader("gender")
                txtBdate.Text = sqlreader("bdate")
                txtAddress.Text = sqlreader("address")
                cmbYearLevel.Text = sqlreader("yearlevel")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoadCandidate()
        Try
            query = "SELECT CandidateID, cellnumber, Lastname, Firstname, Middlename, age, bdate, Sex, Address, C.DepartmentID, Deptname, C.CourseID, Description, C.PartyID, PartyName, C.PositionID, PositionName, yearlevel,LevelName,cellnumber,PicFile FROM Candidate as C, Department as D, Course as Co, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.DepartmentID = D.DepartmentID AND Co.CourseID = C.CourseID AND P.PartyID = C.PartyID AND Po.PositionID = C.PositionID AND Lastname LIKE '" & txtBoxSearch.Text & "%' ORDER BY Lastname, Firstname ASC "
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader()

            If sqlreader.Read = True Then
                txtCandidateID.Text = sqlreader("CandidateID")
                txtLastname.Text = sqlreader("Lastname")
                txtFirstname.Text = sqlreader("Firstname")
                txtMiddlename.Text = sqlreader("Middlename")
                txtAge.Text = sqlreader("Age")
                txtBdate.Text = sqlreader("bdate")
                cmbGender.Text = sqlreader("SEX")
                txtAddress.Text = sqlreader("Address")
                txtDepartment.Text = sqlreader("Deptname")
                txtDepartment.Tag = sqlreader("DepartmentID")
                txtCourse.Text = sqlreader("Description")
                txtCourse.Tag = sqlreader("CourseID")
                txtParty.Text = sqlreader("PartyName")
                txtParty.Tag = sqlreader("PartyID")
                txtPosition.Text = sqlreader("PositionName")
                txtPosition.Tag = sqlreader("PositionID")
                txtCellNumber.Text = sqlreader("cellnumber")
                cmbYearLevel.SelectedItem = sqlreader("yearlevel")
                cmbLevel.Text = sqlreader("LevelName")
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub AddCandidate()
        Dim mstream As New System.IO.MemoryStream
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()
        Try
            Connection()
            query = "INSERT INTO Candidate(CandidateID,cellnumber,Lastname,Firstname,Middlename,age,bdate,sex,address,CourseID,DepartmentID,yearlevel,PartyID,PositionID,Votes,PicFile) VALUES('" & txtCandidateID.Text & "','" & txtCellNumber.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMiddlename.Text & "', '" & txtAge.Text & "', '" & txtBdate.Text & "', '" & cmbGender.SelectedItem & "', '" & txtAddress.Text & "','" & txtCourse.Tag & "', '" & txtDepartment.Tag & "', '" & cmbYearLevel.SelectedItem & "', '" & txtParty.Tag & "', '" & txtPosition.Tag & "', '0',@PicFile) "
            sqlcommand = New MySqlCommand(query, conn)
            sqlcommand.Parameters.AddWithValue("@PicFile", arrImage)

            If txtCellNumber.Text = "+639" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtMiddlename.Text = "" Or txtAge.Text = "" Or cmbGender.SelectedItem = "" Or txtBdate.Text = "" Or txtAddress.Text = "" Or txtCourse.Text = "" Or txtDepartment.Text = "" Or cmbYearLevel.SelectedItem = "" Or cmbLevel.Text = "" Or txtParty.Text = "" Or txtPosition.Text = "" Or PictureBox1.InitialImage.Equals(Nothing) Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Adding New Candidate Informatoin")
            Else
                sqlcommand.ExecuteNonQuery()
                MsgBox("New Candidate successfully added.", MsgBoxStyle.Information, "Adding New Candidate Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateCandidate()
        Dim mstream As New System.IO.MemoryStream
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()
        Try
            Connection()
            query = "UPDATE Candidate SET cellnumber='" & txtCellNumber.Text & "',Lastname='" & txtLastname.Text & "',Firstname='" & txtFirstname.Text & "',Middlename='" & txtMiddlename.Text & "',age='" & txtAge.Text & "',bdate='" & txtBdate.Text & "',sex='" & cmbGender.Text & "',address='" & txtAddress.Text & "',CourseID='" & txtCourse.Tag & "',DepartmentID='" & txtDepartment.Tag & "',yearlevel='" & cmbYearLevel.Text & "',PartyID='" & txtParty.Tag & "',PositionID='" & txtPosition.Tag & "',Votes='0', PicFile=@PicFile WHERE CandidateID='" & txtCandidateID.Text & "' "
            sqlcommand = New MySqlCommand(query, conn)
            sqlcommand.Parameters.AddWithValue("@PicFile", arrImage)

            If txtCellNumber.Text = "+639" Or txtLastname.Text = "" Or txtFirstname.Text = "" Or txtMiddlename.Text = "" Or txtAge.Text = "" Or cmbGender.SelectedItem = "" Or txtBdate.Text = "" Or txtAddress.Text = "" Or txtCourse.Text = "" Or txtDepartment.Text = "" Or cmbYearLevel.SelectedItem = "" Or cmbLevel.Text = "" Or txtParty.Text = "" Or txtPosition.Text = "" Then
                MsgBox("All fields Required", MsgBoxStyle.Exclamation, "Update Candidate Informatoin")
            Else
                sqlcommand.ExecuteNonQuery()
                MsgBox("Candidate successfully Updated.", MsgBoxStyle.Information, "Update Candidate Information")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetUpdateCandidate()
        Try
            query = "SELECT CandidateID, cellnumber, Lastname, Firstname, Middlename, age, bdate, Sex, Address, C.DepartmentID, Deptname, C.CourseID, Description, C.PartyID, PartyName, C.PositionID, PositionName, yearlevel,LevelName,cellnumber,PicFile FROM Candidate as C, Department as D, Course as Co, Party as P, Positions as Po, voting_level as L WHERE L.LevelID = Po.LevelID AND C.DepartmentID = D.DepartmentID AND Co.CourseID = C.CourseID AND P.PartyID = C.PartyID AND Po.PositionID = C.PositionID AND CandidateID = '" & formCandidate.ListViewCandidate.FocusedItem.Text & "'"
            Connection()
            sqlcommand = New MySqlCommand(query, conn)
            sqlreader = sqlcommand.ExecuteReader()

            If sqlreader.Read = True Then
                txtCandidateID.Text = sqlreader("CandidateID")
                txtLastname.Text = sqlreader("Lastname")
                txtFirstname.Text = sqlreader("Firstname")
                txtMiddlename.Text = sqlreader("Middlename")
                txtAge.Text = sqlreader("Age")
                txtBdate.Text = sqlreader("bdate")
                cmbGender.Text = sqlreader("SEX")
                txtAddress.Text = sqlreader("Address")
                txtDepartment.Text = sqlreader("Deptname")
                txtDepartment.Tag = sqlreader("DepartmentID")
                txtCourse.Text = sqlreader("Description")
                txtCourse.Tag = sqlreader("CourseID")
                txtParty.Text = sqlreader("PartyName")
                txtParty.Tag = sqlreader("PartyID")
                txtPosition.Text = sqlreader("PositionName")
                txtPosition.Tag = sqlreader("PositionID")
                txtCellNumber.Text = sqlreader("cellnumber")
                cmbYearLevel.SelectedItem = sqlreader("yearlevel")
                cmbLevel.Text = sqlreader("LevelName")
                Dim data As Byte() = DirectCast(sqlreader("PicFile"), Byte())
                Dim ms As New System.IO.MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcommand.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If formCandidate.SearchCandidate = False Then
            formLoadStudent.ShowDialog()
        Else
        End If
    End Sub

    Private Sub btnLoadParty_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadParty.Click
        formLoadParty.ShowDialog()
    End Sub

    Private Sub btnLoadPosition_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadPosition.Click
        If cmbLevel.Text = "" Then
            MsgBox("Please select Level.", MsgBoxStyle.Exclamation, "Validation")
            Exit Sub
        End If
        formLoadPosition.ShowDialog()
    End Sub

    Private Sub txtBoxSearch_Click(sender As Object, e As System.EventArgs) Handles txtBoxSearch.Click
        If formCandidate.SearchCandidate = True Then
            LoadCandidate()
        Else
            LoadStudent()
        End If
    End Sub

    'Search Box
    Private Sub txtBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBoxSearch.TextChanged
        If formCandidate.SearchCandidate = True Then
            LoadCandidate()
        Else
            LoadStudent()
        End If
    End Sub

    'Block Character input, only integer allowed
    Private Sub txtCellNumber_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If txtCellNumber.Text.Length > 11 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnLoadCourse_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadCourse.Click
        formLoadCourse.ShowDialog()
    End Sub

    Private Sub btnLoadDepartment_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadDepartment.Click
        formLoadDepartment.ShowDialog()
    End Sub

    Private Sub btnRegister_Click(sender As System.Object, e As System.EventArgs) Handles btnRegister.Click
        If formCandidate.adding = True Then
            AddCandidate()
            formCandidate.LoadCandidate()
        Else
            UpdateCandidate()
            formCandidate.LoadCandidate()
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnBrowsePic_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowsePic.Click
        Try
            a.Filter = "Image Files | *.gif;*.jpg;*.jpeg;*.wmf;*.png;*.bmp)"
            If a.ShowDialog = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(a.FileName)
                PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class