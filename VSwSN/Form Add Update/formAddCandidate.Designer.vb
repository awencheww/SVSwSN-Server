<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddCandidate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddCandidate))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoadDepartment = New System.Windows.Forms.Button()
        Me.txtCellNumber = New System.Windows.Forms.TextBox()
        Me.btnLoadCourse = New System.Windows.Forms.Button()
        Me.txtBdate = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbYearLevel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCandidateID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtParty = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLoadPosition = New System.Windows.Forms.Button()
        Me.btnLoadParty = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePic = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OFDClient = New System.Windows.Forms.OpenFileDialog()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLoadDepartment)
        Me.GroupBox1.Controls.Add(Me.txtCellNumber)
        Me.GroupBox1.Controls.Add(Me.btnLoadCourse)
        Me.GroupBox1.Controls.Add(Me.txtBdate)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbYearLevel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMiddlename)
        Me.GroupBox1.Controls.Add(Me.txtFirstname)
        Me.GroupBox1.Controls.Add(Me.txtLastname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCandidateID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(13, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 362)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'btnLoadDepartment
        '
        Me.btnLoadDepartment.BackColor = System.Drawing.SystemColors.Info
        Me.btnLoadDepartment.BackgroundImage = CType(resources.GetObject("btnLoadDepartment.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadDepartment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadDepartment.ForeColor = System.Drawing.Color.Black
        Me.btnLoadDepartment.Location = New System.Drawing.Point(536, 287)
        Me.btnLoadDepartment.Name = "btnLoadDepartment"
        Me.btnLoadDepartment.Size = New System.Drawing.Size(26, 27)
        Me.btnLoadDepartment.TabIndex = 72
        Me.btnLoadDepartment.UseVisualStyleBackColor = False
        '
        'txtCellNumber
        '
        Me.txtCellNumber.BackColor = System.Drawing.Color.White
        Me.txtCellNumber.ForeColor = System.Drawing.Color.Black
        Me.txtCellNumber.Location = New System.Drawing.Point(357, 38)
        Me.txtCellNumber.MaxLength = 13
        Me.txtCellNumber.Name = "txtCellNumber"
        Me.txtCellNumber.Size = New System.Drawing.Size(205, 26)
        Me.txtCellNumber.TabIndex = 70
        '
        'btnLoadCourse
        '
        Me.btnLoadCourse.BackColor = System.Drawing.SystemColors.Info
        Me.btnLoadCourse.BackgroundImage = CType(resources.GetObject("btnLoadCourse.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadCourse.ForeColor = System.Drawing.Color.Black
        Me.btnLoadCourse.Location = New System.Drawing.Point(536, 254)
        Me.btnLoadCourse.Name = "btnLoadCourse"
        Me.btnLoadCourse.Size = New System.Drawing.Size(26, 27)
        Me.btnLoadCourse.TabIndex = 69
        Me.btnLoadCourse.UseVisualStyleBackColor = False
        '
        'txtBdate
        '
        Me.txtBdate.BackColor = System.Drawing.Color.White
        Me.txtBdate.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.0!)
        Me.txtBdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBdate.Location = New System.Drawing.Point(118, 189)
        Me.txtBdate.Mask = "00 - 00 - 0000"
        Me.txtBdate.Name = "txtBdate"
        Me.txtBdate.Size = New System.Drawing.Size(294, 26)
        Me.txtBdate.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(419, 195)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 20)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "mm - dd - yyyy"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAge.Location = New System.Drawing.Point(118, 154)
        Me.txtAge.MaxLength = 3
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(144, 28)
        Me.txtAge.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(118, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Age"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(268, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.White
        Me.cmbGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(268, 154)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(294, 28)
        Me.cmbGender.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(9, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Birthdate :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(264, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Contact No."
        '
        'txtDepartment
        '
        Me.txtDepartment.BackColor = System.Drawing.Color.White
        Me.txtDepartment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtDepartment.Location = New System.Drawing.Point(118, 287)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(412, 26)
        Me.txtDepartment.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Department :"
        '
        'cmbYearLevel
        '
        Me.cmbYearLevel.BackColor = System.Drawing.Color.White
        Me.cmbYearLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbYearLevel.FormattingEnabled = True
        Me.cmbYearLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbYearLevel.Location = New System.Drawing.Point(118, 319)
        Me.cmbYearLevel.Name = "cmbYearLevel"
        Me.cmbYearLevel.Size = New System.Drawing.Size(144, 28)
        Me.cmbYearLevel.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Year Level :"
        '
        'txtCourse
        '
        Me.txtCourse.BackColor = System.Drawing.Color.White
        Me.txtCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCourse.Location = New System.Drawing.Point(118, 255)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(412, 26)
        Me.txtCourse.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Course :"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAddress.Location = New System.Drawing.Point(118, 223)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(444, 26)
        Me.txtAddress.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Address :"
        '
        'txtMiddlename
        '
        Me.txtMiddlename.BackColor = System.Drawing.Color.White
        Me.txtMiddlename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMiddlename.Location = New System.Drawing.Point(418, 101)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(144, 26)
        Me.txtMiddlename.TabIndex = 4
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.White
        Me.txtFirstname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFirstname.Location = New System.Drawing.Point(268, 101)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(144, 26)
        Me.txtFirstname.TabIndex = 3
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.White
        Me.txtLastname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLastname.Location = New System.Drawing.Point(118, 101)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(144, 26)
        Me.txtLastname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(420, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Middlename"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(268, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(118, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Lastname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name :"
        '
        'txtCandidateID
        '
        Me.txtCandidateID.BackColor = System.Drawing.Color.White
        Me.txtCandidateID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCandidateID.Location = New System.Drawing.Point(118, 38)
        Me.txtCandidateID.Name = "txtCandidateID"
        Me.txtCandidateID.Size = New System.Drawing.Size(144, 26)
        Me.txtCandidateID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Candidate ID :"
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.Color.White
        Me.cmbLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbLevel.Location = New System.Drawing.Point(125, 30)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(243, 28)
        Me.cmbLevel.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(16, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 20)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Voting Level :"
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.Color.White
        Me.txtPosition.ForeColor = System.Drawing.Color.Black
        Me.txtPosition.Location = New System.Drawing.Point(125, 101)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(243, 26)
        Me.txtPosition.TabIndex = 15
        '
        'txtParty
        '
        Me.txtParty.BackColor = System.Drawing.Color.White
        Me.txtParty.ForeColor = System.Drawing.Color.Black
        Me.txtParty.Location = New System.Drawing.Point(125, 69)
        Me.txtParty.Name = "txtParty"
        Me.txtParty.Size = New System.Drawing.Size(243, 26)
        Me.txtParty.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Position :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Party List :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 56)
        Me.Panel1.TabIndex = 64
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(4, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add | Update Candidate"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtBoxSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 70)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Student Lastname"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Info
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(13, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 26)
        Me.Button1.TabIndex = 69
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.BackColor = System.Drawing.Color.White
        Me.txtBoxSearch.Location = New System.Drawing.Point(45, 26)
        Me.txtBoxSearch.Multiline = True
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(224, 26)
        Me.txtBoxSearch.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbLevel)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtParty)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtPosition)
        Me.GroupBox3.Controls.Add(Me.btnLoadPosition)
        Me.GroupBox3.Controls.Add(Me.btnLoadParty)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.0!)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(602, 292)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(409, 149)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Candidate Information"
        '
        'btnLoadPosition
        '
        Me.btnLoadPosition.BackColor = System.Drawing.SystemColors.Info
        Me.btnLoadPosition.BackgroundImage = CType(resources.GetObject("btnLoadPosition.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadPosition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadPosition.ForeColor = System.Drawing.Color.Black
        Me.btnLoadPosition.Location = New System.Drawing.Point(374, 101)
        Me.btnLoadPosition.Name = "btnLoadPosition"
        Me.btnLoadPosition.Size = New System.Drawing.Size(26, 26)
        Me.btnLoadPosition.TabIndex = 16
        Me.btnLoadPosition.UseVisualStyleBackColor = False
        '
        'btnLoadParty
        '
        Me.btnLoadParty.BackColor = System.Drawing.SystemColors.Info
        Me.btnLoadParty.BackgroundImage = CType(resources.GetObject("btnLoadParty.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadParty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadParty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadParty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadParty.ForeColor = System.Drawing.Color.Black
        Me.btnLoadParty.Location = New System.Drawing.Point(374, 68)
        Me.btnLoadParty.Name = "btnLoadParty"
        Me.btnLoadParty.Size = New System.Drawing.Size(26, 27)
        Me.btnLoadParty.TabIndex = 14
        Me.btnLoadParty.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBrowsePic)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.0!)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox4.Location = New System.Drawing.Point(683, 61)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(296, 225)
        Me.GroupBox4.TabIndex = 68
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Upload Photo"
        '
        'btnBrowsePic
        '
        Me.btnBrowsePic.AutoSize = True
        Me.btnBrowsePic.BackColor = System.Drawing.SystemColors.Info
        Me.btnBrowsePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowsePic.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.0!)
        Me.btnBrowsePic.ForeColor = System.Drawing.Color.Black
        Me.btnBrowsePic.Location = New System.Drawing.Point(91, 188)
        Me.btnBrowsePic.Name = "btnBrowsePic"
        Me.btnBrowsePic.Size = New System.Drawing.Size(137, 26)
        Me.btnBrowsePic.TabIndex = 1
        Me.btnBrowsePic.Text = "Browse"
        Me.btnBrowsePic.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.VSwSN.My.Resources.Resources.Name_100
        Me.PictureBox1.Location = New System.Drawing.Point(43, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'OFDClient
        '
        Me.OFDClient.FileName = "OpenFileDialog1"
        '
        'btnRegister
        '
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Black
        Me.btnRegister.Image = CType(resources.GetObject("btnRegister.Image"), System.Drawing.Image)
        Me.btnRegister.Location = New System.Drawing.Point(776, 451)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(110, 49)
        Me.btnRegister.TabIndex = 18
        Me.btnRegister.Text = "&Save"
        Me.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatAppearance.BorderSize = 2
        Me.btnClose.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(898, 451)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 49)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'formAddCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1022, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formAddCandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLoadPosition As System.Windows.Forms.Button
    Friend WithEvents btnLoadParty As System.Windows.Forms.Button
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtParty As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtBdate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents cmbYearLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtCandidateID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnLoadCourse As System.Windows.Forms.Button
    Friend WithEvents txtCellNumber As System.Windows.Forms.TextBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadDepartment As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePic As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OFDClient As System.Windows.Forms.OpenFileDialog
End Class
