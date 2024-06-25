<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBook1 = New System.Windows.Forms.Button()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = Global.PedalPals.My.Resources.Resources.qrcode2__1_
        Me.PictureBox2.Location = New System.Drawing.Point(541, 37)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(401, 528)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Receipt :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(57, 253)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(349, 27)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "I admit that the receipt uploaded is true."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.BurlyWood
        Me.Label2.Location = New System.Drawing.Point(67, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 46)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Payment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBook1
        '
        Me.btnBook1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBook1.BackColor = System.Drawing.Color.Transparent
        Me.btnBook1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBook1.FlatAppearance.BorderSize = 2
        Me.btnBook1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBook1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBook1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBook1.Location = New System.Drawing.Point(349, 419)
        Me.btnBook1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBook1.Name = "btnBook1"
        Me.btnBook1.Size = New System.Drawing.Size(148, 40)
        Me.btnBook1.TabIndex = 34
        Me.btnBook1.Text = "SUBMIT"
        Me.btnBook1.UseVisualStyleBackColor = False
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(159, 157)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(75, 23)
        Me.btnFile.TabIndex = 36
        Me.btnFile.Text = "Browse"
        Me.btnFile.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFile.AutoSize = True
        Me.lblFile.BackColor = System.Drawing.Color.Transparent
        Me.lblFile.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFile.ForeColor = System.Drawing.Color.White
        Me.lblFile.Location = New System.Drawing.Point(251, 156)
        Me.lblFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(104, 23)
        Me.lblFile.TabIndex = 38
        Me.lblFile.Text = "filename.pdf"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(964, 578)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBook1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payment"
        Me.TopMost = True
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBook1 As Button
    Friend WithEvents btnFile As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
