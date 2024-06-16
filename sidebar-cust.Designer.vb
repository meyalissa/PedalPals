<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sidebar_cust
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignout1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnProfile1 = New System.Windows.Forms.Button()
        Me.btnMyrental = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnDashboard1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSignout1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnProfile1)
        Me.Panel1.Controls.Add(Me.btnMyrental)
        Me.Panel1.Controls.Add(Me.btnBooking)
        Me.Panel1.Controls.Add(Me.btnDashboard1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 578)
        Me.Panel1.TabIndex = 1
        '
        'btnSignout1
        '
        Me.btnSignout1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnSignout1.FlatAppearance.BorderSize = 0
        Me.btnSignout1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSignout1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignout1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignout1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSignout1.Image = Global.PedalPals.My.Resources.Resources.signout_icon
        Me.btnSignout1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignout1.Location = New System.Drawing.Point(0, 506)
        Me.btnSignout1.Name = "btnSignout1"
        Me.btnSignout1.Size = New System.Drawing.Size(179, 46)
        Me.btnSignout1.TabIndex = 3
        Me.btnSignout1.Text = "Sign Out"
        Me.btnSignout1.UseVisualStyleBackColor = True
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
        'btnProfile1
        '
        Me.btnProfile1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnProfile1.FlatAppearance.BorderSize = 0
        Me.btnProfile1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProfile1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnProfile1.Image = Global.PedalPals.My.Resources.Resources.profile_icon3
        Me.btnProfile1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile1.Location = New System.Drawing.Point(0, 325)
        Me.btnProfile1.Name = "btnProfile1"
        Me.btnProfile1.Size = New System.Drawing.Size(179, 46)
        Me.btnProfile1.TabIndex = 2
        Me.btnProfile1.Text = "Profile"
        Me.btnProfile1.UseVisualStyleBackColor = True
        '
        'btnMyrental
        '
        Me.btnMyrental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnMyrental.FlatAppearance.BorderSize = 0
        Me.btnMyrental.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMyrental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyrental.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyrental.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnMyrental.Image = Global.PedalPals.My.Resources.Resources.myrent_icon3
        Me.btnMyrental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyrental.Location = New System.Drawing.Point(0, 273)
        Me.btnMyrental.Name = "btnMyrental"
        Me.btnMyrental.Size = New System.Drawing.Size(179, 46)
        Me.btnMyrental.TabIndex = 2
        Me.btnMyrental.Text = "My Rental"
        Me.btnMyrental.UseVisualStyleBackColor = True
        '
        'btnBooking
        '
        Me.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBooking.Image = Global.PedalPals.My.Resources.Resources.book_icon3
        Me.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBooking.Location = New System.Drawing.Point(0, 221)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(179, 46)
        Me.btnBooking.TabIndex = 1
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = True
        '
        'btnDashboard1
        '
        Me.btnDashboard1.FlatAppearance.BorderSize = 0
        Me.btnDashboard1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDashboard1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDashboard1.Image = Global.PedalPals.My.Resources.Resources.dash_icon3
        Me.btnDashboard1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard1.Location = New System.Drawing.Point(0, 169)
        Me.btnDashboard1.Name = "btnDashboard1"
        Me.btnDashboard1.Size = New System.Drawing.Size(179, 46)
        Me.btnDashboard1.TabIndex = 0
        Me.btnDashboard1.Text = "Dashboard"
        Me.btnDashboard1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(185, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(795, 554)
        Me.Panel2.TabIndex = 2
        '
        'sidebar_cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(992, 578)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sidebar_cust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sidebar_cust"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignout1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnProfile1 As Button
    Friend WithEvents btnMyrental As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnDashboard1 As Button
    Friend WithEvents Panel2 As Panel
End Class
