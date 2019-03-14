<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCourse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCourse))
        Me.ListViewCourse = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripCourse = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonADD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonUPDATE = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtBoxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripCourse.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewCourse
        '
        Me.ListViewCourse.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ListViewCourse.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListViewCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewCourse.FullRowSelect = True
        Me.ListViewCourse.GridLines = True
        Me.ListViewCourse.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewCourse.Location = New System.Drawing.Point(0, 28)
        Me.ListViewCourse.Name = "ListViewCourse"
        Me.ListViewCourse.Size = New System.Drawing.Size(591, 408)
        Me.ListViewCourse.TabIndex = 8
        Me.ListViewCourse.UseCompatibleStateImageBehavior = False
        Me.ListViewCourse.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CourseID"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Course Code"
        Me.ColumnHeader6.Width = 129
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.Width = 400
        '
        'ToolStripCourse
        '
        Me.ToolStripCourse.BackColor = System.Drawing.Color.LightGray
        Me.ToolStripCourse.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripCourse.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripCourse.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripCourse.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonADD, Me.ToolStripButtonUPDATE, Me.ToolStripLabel1, Me.txtBoxSearch})
        Me.ToolStripCourse.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripCourse.Name = "ToolStripCourse"
        Me.ToolStripCourse.Size = New System.Drawing.Size(591, 28)
        Me.ToolStripCourse.TabIndex = 7
        Me.ToolStripCourse.Text = "ToolStrip1"
        Me.ToolStripCourse.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        '
        'ToolStripButtonADD
        '
        Me.ToolStripButtonADD.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButtonADD.Image = CType(resources.GetObject("ToolStripButtonADD.Image"), System.Drawing.Image)
        Me.ToolStripButtonADD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonADD.Name = "ToolStripButtonADD"
        Me.ToolStripButtonADD.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripButtonADD.Size = New System.Drawing.Size(68, 25)
        Me.ToolStripButtonADD.Text = "New"
        Me.ToolStripButtonADD.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButtonUPDATE
        '
        Me.ToolStripButtonUPDATE.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStripButtonUPDATE.Image = CType(resources.GetObject("ToolStripButtonUPDATE.Image"), System.Drawing.Image)
        Me.ToolStripButtonUPDATE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUPDATE.Name = "ToolStripButtonUPDATE"
        Me.ToolStripButtonUPDATE.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripButtonUPDATE.Size = New System.Drawing.Size(86, 25)
        Me.ToolStripButtonUPDATE.Text = "Update"
        Me.ToolStripButtonUPDATE.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(121, 25)
        Me.ToolStripLabel1.Text = "Search by Code:"
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
        'formCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 436)
        Me.Controls.Add(Me.ListViewCourse)
        Me.Controls.Add(Me.ToolStripCourse)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "formCourse"
        Me.Text = "Course Information"
        Me.ToolStripCourse.ResumeLayout(False)
        Me.ToolStripCourse.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListViewCourse As System.Windows.Forms.ListView
    Friend WithEvents ToolStripCourse As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonADD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonUPDATE As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBoxSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
