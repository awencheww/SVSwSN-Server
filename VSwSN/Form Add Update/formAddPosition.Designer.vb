<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAddPosition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAddPosition))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLoadLevel = New System.Windows.Forms.Button()
        Me.txtLevelName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtPositionID = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblUserid = New System.Windows.Forms.Label()
        Me.cboPositionName = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(409, 56)
        Me.Panel1.TabIndex = 58
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(4, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(263, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Add | Update Position"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.cboPositionName)
        Me.GroupBox1.Controls.Add(Me.btnLoadLevel)
        Me.GroupBox1.Controls.Add(Me.txtLevelName)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.txtPositionID)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.lblUserid)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 220)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position Information"
        '
        'btnLoadLevel
        '
        Me.btnLoadLevel.BackColor = System.Drawing.SystemColors.Info
        Me.btnLoadLevel.BackgroundImage = CType(resources.GetObject("btnLoadLevel.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLoadLevel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoadLevel.Location = New System.Drawing.Point(342, 107)
        Me.btnLoadLevel.Name = "btnLoadLevel"
        Me.btnLoadLevel.Size = New System.Drawing.Size(26, 26)
        Me.btnLoadLevel.TabIndex = 46
        Me.btnLoadLevel.UseVisualStyleBackColor = False
        '
        'txtLevelName
        '
        Me.txtLevelName.BackColor = System.Drawing.Color.White
        Me.txtLevelName.Location = New System.Drawing.Point(131, 107)
        Me.txtLevelName.Name = "txtLevelName"
        Me.txtLevelName.Size = New System.Drawing.Size(205, 26)
        Me.txtLevelName.TabIndex = 45
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(131, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 49)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = True
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
        Me.btnClose.Location = New System.Drawing.Point(258, 149)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 49)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtPositionID
        '
        Me.txtPositionID.BackColor = System.Drawing.Color.White
        Me.txtPositionID.Location = New System.Drawing.Point(131, 37)
        Me.txtPositionID.Name = "txtPositionID"
        Me.txtPositionID.Size = New System.Drawing.Size(237, 26)
        Me.txtPositionID.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(15, 113)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(87, 20)
        Me.lblPassword.TabIndex = 44
        Me.lblPassword.Text = "Level Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(15, 76)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(106, 20)
        Me.lblUsername.TabIndex = 43
        Me.lblUsername.Text = "Position Name"
        '
        'lblUserid
        '
        Me.lblUserid.AutoSize = True
        Me.lblUserid.ForeColor = System.Drawing.Color.Black
        Me.lblUserid.Location = New System.Drawing.Point(15, 43)
        Me.lblUserid.Name = "lblUserid"
        Me.lblUserid.Size = New System.Drawing.Size(81, 20)
        Me.lblUserid.TabIndex = 42
        Me.lblUserid.Text = "Position ID"
        '
        'cboPositionName
        '
        Me.cboPositionName.FormattingEnabled = True
        Me.cboPositionName.Items.AddRange(New Object() {"Governor", "Vice-Governor", "Secretary", "Treasurer", "Business Manager", "Auditor", "PIO", "1st Year Rep", "2nd Year Rep", "3rd Year Rep", "4th Year Rep"})
        Me.cboPositionName.Location = New System.Drawing.Point(131, 71)
        Me.cboPositionName.Name = "cboPositionName"
        Me.cboPositionName.Size = New System.Drawing.Size(237, 28)
        Me.cboPositionName.TabIndex = 47
        '
        'formAddPosition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "formAddPosition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtPositionID As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblUserid As System.Windows.Forms.Label
    Friend WithEvents txtLevelName As System.Windows.Forms.TextBox
    Friend WithEvents btnLoadLevel As System.Windows.Forms.Button
    Friend WithEvents cboPositionName As System.Windows.Forms.ComboBox
End Class
