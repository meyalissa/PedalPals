<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sidebar_admin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignout2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnProfile2 = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnMembers = New System.Windows.Forms.Button()
        Me.btnDashboard2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSignout2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnProfile2)
        Me.Panel1.Controls.Add(Me.btnRecord)
        Me.Panel1.Controls.Add(Me.btnMembers)
        Me.Panel1.Controls.Add(Me.btnDashboard2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 578)
        Me.Panel1.TabIndex = 4
        '
        'btnSignout2
        '
        Me.btnSignout2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSignout2.FlatAppearance.BorderSize = 0
        Me.btnSignout2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSignout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignout2.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSignout2.Image = Global.PedalPals.My.Resources.Resources.signout_icon
        Me.btnSignout2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignout2.Location = New System.Drawing.Point(0, 506)
        Me.btnSignout2.Name = "btnSignout2"
        Me.btnSignout2.Size = New System.Drawing.Size(179, 46)
        Me.btnSignout2.TabIndex = 3
        Me.btnSignout2.Text = "Sign Out"
        Me.btnSignout2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PedalPals.My.Resources.Resources.logo3
        Me.PictureBox1.Location = New System.Drawing.Point(3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnProfile2
        '
        Me.btnProfile2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnProfile2.FlatAppearance.BorderSize = 0
        Me.btnProfile2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProfile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile2.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnProfile2.Image = Global.PedalPals.My.Resources.Resources.profile_icon3
        Me.btnProfile2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile2.Location = New System.Drawing.Point(0, 325)
        Me.btnProfile2.Name = "btnProfile2"
        Me.btnProfile2.Size = New System.Drawing.Size(179, 46)
        Me.btnProfile2.TabIndex = 2
        Me.btnProfile2.Text = "Profile"
        Me.btnProfile2.UseVisualStyleBackColor = True
        '
        'btnRecord
        '
        Me.btnRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnRecord.FlatAppearance.BorderSize = 0
        Me.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecord.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecord.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRecord.Image = Global.PedalPals.My.Resources.Resources.record_icon2
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.Location = New System.Drawing.Point(0, 273)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(179, 46)
        Me.btnRecord.TabIndex = 2
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnMembers
        '
        Me.btnMembers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnMembers.FlatAppearance.BorderSize = 0
        Me.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMembers.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMembers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMembers.Image = Global.PedalPals.My.Resources.Resources.member_icon
        Me.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMembers.Location = New System.Drawing.Point(0, 221)
        Me.btnMembers.Name = "btnMembers"
        Me.btnMembers.Size = New System.Drawing.Size(179, 46)
        Me.btnMembers.TabIndex = 1
        Me.btnMembers.Text = "Members"
        Me.btnMembers.UseVisualStyleBackColor = True
        '
        'btnDashboard2
        '
        Me.btnDashboard2.FlatAppearance.BorderSize = 0
        Me.btnDashboard2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard2.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard2.Image = Global.PedalPals.My.Resources.Resources.dash_icon3
        Me.btnDashboard2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard2.Location = New System.Drawing.Point(0, 169)
        Me.btnDashboard2.Name = "btnDashboard2"
        Me.btnDashboard2.Size = New System.Drawing.Size(179, 46)
        Me.btnDashboard2.TabIndex = 0
        Me.btnDashboard2.Text = "Dashboard"
        Me.btnDashboard2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(185, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(795, 554)
        Me.Panel3.TabIndex = 5
        '
        'sidebar_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 578)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sidebar_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sidebar_admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignout2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProfile2 As Button
    Friend WithEvents btnRecord As Button
    Friend WithEvents btnMembers As Button
    Friend WithEvents btnDashboard2 As Button
    Friend WithEvents Panel3 As Panel
End Class
