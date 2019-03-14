<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLoadStudent
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbFilterLevel = New System.Windows.Forms.ComboBox()
        Me.cmbFilterDept = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBoxSearch = New System.Windows.Forms.TextBox()
        Me.ListViewStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbFilterLevel)
        Me.GroupBox3.Controls.Add(Me.cmbFilterDept)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(243, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 70)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter by"
        '
        'cmbFilterLevel
        '
        Me.cmbFilterLevel.FormattingEnabled = True
        Me.cmbFilterLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbFilterLevel.Location = New System.Drawing.Point(187, 30)
        Me.cmbFilterLevel.Name = "cmbFilterLevel"
        Me.cmbFilterLevel.Size = New System.Drawing.Size(144, 23)
        Me.cmbFilterLevel.TabIndex = 1
        '
        'cmbFilterDept
        '
        Me.cmbFilterDept.FormattingEnabled = True
        Me.cmbFilterDept.Location = New System.Drawing.Point(37, 30)
        Me.cmbFilterDept.Name = "cmbFilterDept"
        Me.cmbFilterDept.Size = New System.Drawing.Size(144, 23)
        Me.cmbFilterDept.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtBoxSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 70)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Student Lastname"
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.Location = New System.Drawing.Point(24, 30)
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Size = New System.Drawing.Size(180, 23)
        Me.txtBoxSearch.TabIndex = 0
        '
        'ListViewStudent
        '
        Me.ListViewStudent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStudent.FullRowSelect = True
        Me.ListViewStudent.GridLines = True
        Me.ListViewStudent.Location = New System.Drawing.Point(-2, 88)
        Me.ListViewStudent.Name = "ListViewStudent"
        Me.ListViewStudent.Size = New System.Drawing.Size(1126, 409)
        Me.ListViewStudent.TabIndex = 70
        Me.ListViewStudent.UseCompatibleStateImageBehavior = False
        Me.ListViewStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "StudentID"
        Me.ColumnHeader10.Width = 81
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Lastname"
        Me.ColumnHeader11.Width = 98
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Firstname"
        Me.ColumnHeader12.Width = 93
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Middlename"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Contact"
        Me.ColumnHeader14.Width = 130
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Gender"
        Me.ColumnHeader15.Width = 87
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Address"
        Me.ColumnHeader16.Width = 161
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Course"
        Me.ColumnHeader17.Width = 101
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Department"
        Me.ColumnHeader18.Width = 98
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Year Level"
        Me.ColumnHeader19.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Age"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Birthdate"
        Me.ColumnHeader2.Width = 113
        '
        'formLoadStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 497)
        Me.Controls.Add(Me.ListViewStudent)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formLoadStudent"
        Me.Text = "Double click to Select item"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbFilterLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFilterDept As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBoxSearch As System.Windows.Forms.TextBox
    Friend WithEvents ListViewStudent As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
