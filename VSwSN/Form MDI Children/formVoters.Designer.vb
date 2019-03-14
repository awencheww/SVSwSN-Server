<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formVoters
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
        Me.ListViewStudent = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripStudent = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFilterVoted = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbFilterDept = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbFilterLevel = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewStudent
        '
        Me.ListViewStudent.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewStudent.CheckBoxes = True
        Me.ListViewStudent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListViewStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStudent.FullRowSelect = True
        Me.ListViewStudent.GridLines = True
        Me.ListViewStudent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewStudent.Location = New System.Drawing.Point(0, 25)
        Me.ListViewStudent.Name = "ListViewStudent"
        Me.ListViewStudent.Size = New System.Drawing.Size(1333, 455)
        Me.ListViewStudent.TabIndex = 14
        Me.ListViewStudent.UseCompatibleStateImageBehavior = False
        Me.ListViewStudent.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.DisplayIndex = 0
        Me.ColumnHeader1.Text = "Student ID"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.DisplayIndex = 1
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.DisplayIndex = 2
        Me.ColumnHeader3.Text = "Course Code"
        Me.ColumnHeader3.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.DisplayIndex = 3
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 300
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.DisplayIndex = 4
        Me.ColumnHeader5.Text = "Department"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.DisplayIndex = 5
        Me.ColumnHeader6.Text = "Contact"
        Me.ColumnHeader6.Width = 150
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.DisplayIndex = 6
        Me.ColumnHeader7.Text = "Address"
        Me.ColumnHeader7.Width = 200
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.DisplayIndex = 7
        Me.ColumnHeader8.Text = "is Voted?"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'ToolStripStudent
        '
        Me.ToolStripStudent.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripStudent.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripStudent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripStudent.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripStudent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtBoxSearch, Me.ToolStripLabel3, Me.ToolStripLabel2, Me.cmbFilterVoted, Me.cmbFilterDept, Me.cmbFilterLevel})
        Me.ToolStripStudent.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripStudent.Name = "ToolStripStudent"
        Me.ToolStripStudent.Size = New System.Drawing.Size(1333, 25)
        Me.ToolStripStudent.TabIndex = 13
        Me.ToolStripStudent.Text = "ToolStrip1"
        Me.ToolStripStudent.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripLabel1.Text = "Search by Lastname:"
        Me.ToolStripLabel1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'txtBoxSearch
        '
        Me.txtBoxSearch.AutoSize = False
        Me.txtBoxSearch.Name = "txtBoxSearch"
        Me.txtBoxSearch.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.txtBoxSearch.Size = New System.Drawing.Size(150, 25)
        Me.txtBoxSearch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.AutoSize = False
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(116, 21)
        Me.ToolStripLabel3.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(81, 22)
        Me.ToolStripLabel2.Text = "Filter By   :"
        Me.ToolStripLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'cmbFilterVoted
        '
        Me.cmbFilterVoted.Items.AddRange(New Object() {"", "Voted Students", "Did Not Vote"})
        Me.cmbFilterVoted.Name = "cmbFilterVoted"
        Me.cmbFilterVoted.Size = New System.Drawing.Size(121, 25)
        Me.cmbFilterVoted.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'cmbFilterDept
        '
        Me.cmbFilterDept.Name = "cmbFilterDept"
        Me.cmbFilterDept.Size = New System.Drawing.Size(121, 25)
        Me.cmbFilterDept.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'cmbFilterLevel
        '
        Me.cmbFilterLevel.Items.AddRange(New Object() {"First Year", "Second Year", "Third Year", "Fourth Year", "Fifth Year"})
        Me.cmbFilterLevel.Name = "cmbFilterLevel"
        Me.cmbFilterLevel.Size = New System.Drawing.Size(121, 25)
        Me.cmbFilterLevel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'formVoters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 480)
        Me.Controls.Add(Me.ListViewStudent)
        Me.Controls.Add(Me.ToolStripStudent)
        Me.Name = "formVoters"
        Me.Text = "Voters"
        Me.ToolStripStudent.ResumeLayout(False)
        Me.ToolStripStudent.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewStudent As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripStudent As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtBoxSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbFilterDept As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbFilterLevel As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents cmbFilterVoted As System.Windows.Forms.ToolStripComboBox
End Class
