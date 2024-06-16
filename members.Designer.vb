<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class members
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtmemID = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnAddmem = New System.Windows.Forms.Button()
        Me.memberIDBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usernameBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contactBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.editMemBook = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.updMemBook = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.delMemBook = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label2.Location = New System.Drawing.Point(30, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 37)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Members"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.memberIDBook, Me.usernameBook, Me.emailBook, Me.contactBook, Me.editMemBook, Me.updMemBook, Me.delMemBook})
        Me.DataGridView2.Location = New System.Drawing.Point(83, 179)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(621, 324)
        Me.DataGridView2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(82, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Member ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(82, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Username   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(327, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Email         :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(327, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Contact No :"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(413, 100)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(184, 20)
        Me.txtemail.TabIndex = 20
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(413, 128)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(184, 20)
        Me.txtcontact.TabIndex = 21
        '
        'txtmemID
        '
        Me.txtmemID.Location = New System.Drawing.Point(164, 102)
        Me.txtmemID.Name = "txtmemID"
        Me.txtmemID.Size = New System.Drawing.Size(141, 20)
        Me.txtmemID.TabIndex = 22
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(164, 130)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(141, 20)
        Me.txtusername.TabIndex = 23
        '
        'btnAddmem
        '
        Me.btnAddmem.Location = New System.Drawing.Point(629, 100)
        Me.btnAddmem.Name = "btnAddmem"
        Me.btnAddmem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddmem.TabIndex = 24
        Me.btnAddmem.Text = "ADD"
        Me.btnAddmem.UseVisualStyleBackColor = True
        '
        'memberIDBook
        '
        Me.memberIDBook.HeaderText = "Member ID"
        Me.memberIDBook.Name = "memberIDBook"
        '
        'usernameBook
        '
        Me.usernameBook.HeaderText = "Username"
        Me.usernameBook.Name = "usernameBook"
        '
        'emailBook
        '
        Me.emailBook.HeaderText = "Email"
        Me.emailBook.Name = "emailBook"
        '
        'contactBook
        '
        Me.contactBook.HeaderText = "Contact No"
        Me.contactBook.Name = "contactBook"
        '
        'editMemBook
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.editMemBook.DefaultCellStyle = DataGridViewCellStyle2
        Me.editMemBook.HeaderText = "Edit"
        Me.editMemBook.Name = "editMemBook"
        Me.editMemBook.Text = "Edit"
        Me.editMemBook.UseColumnTextForButtonValue = True
        Me.editMemBook.Width = 60
        '
        'updMemBook
        '
        Me.updMemBook.HeaderText = "Update"
        Me.updMemBook.Name = "updMemBook"
        Me.updMemBook.Text = "Update"
        Me.updMemBook.UseColumnTextForButtonValue = True
        Me.updMemBook.Width = 60
        '
        'delMemBook
        '
        Me.delMemBook.HeaderText = "Delete"
        Me.delMemBook.Name = "delMemBook"
        Me.delMemBook.Text = "Delete"
        Me.delMemBook.UseColumnTextForButtonValue = True
        Me.delMemBook.Width = 60
        '
        'members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 554)
        Me.Controls.Add(Me.btnAddmem)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtmemID)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "members"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "members"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtmemID As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnAddmem As Button
    Friend WithEvents memberIDBook As DataGridViewTextBoxColumn
    Friend WithEvents usernameBook As DataGridViewTextBoxColumn
    Friend WithEvents emailBook As DataGridViewTextBoxColumn
    Friend WithEvents contactBook As DataGridViewTextBoxColumn
    Friend WithEvents editMemBook As DataGridViewButtonColumn
    Friend WithEvents updMemBook As DataGridViewButtonColumn
    Friend WithEvents delMemBook As DataGridViewButtonColumn
End Class
