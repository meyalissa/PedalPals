<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPriceBooking = New System.Windows.Forms.Label()
        Me.hourBooking = New System.Windows.Forms.NumericUpDown()
        Me.dateBooking = New System.Windows.Forms.DateTimePicker()
        Me.typeBooking = New System.Windows.Forms.ComboBox()
        Me.placeBooking = New System.Windows.Forms.ComboBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.btnBook1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.addBooking = New System.Windows.Forms.Button()
        Me.btnCalcPrice = New System.Windows.Forms.Button()
        Me.placeBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.typeBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hourBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.priceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.hourBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(123, 37)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Booking"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(48, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(45, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Place :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(356, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Type :"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(354, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hour :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(556, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Price :"
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrice.Location = New System.Drawing.Point(621, 112)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 17)
        Me.lblPrice.TabIndex = 25
        '
        'lblPriceBooking
        '
        Me.lblPriceBooking.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPriceBooking.AutoSize = True
        Me.lblPriceBooking.BackColor = System.Drawing.Color.Transparent
        Me.lblPriceBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPriceBooking.Location = New System.Drawing.Point(612, 112)
        Me.lblPriceBooking.Name = "lblPriceBooking"
        Me.lblPriceBooking.Size = New System.Drawing.Size(15, 17)
        Me.lblPriceBooking.TabIndex = 26
        Me.lblPriceBooking.Text = "0"
        '
        'hourBooking
        '
        Me.hourBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourBooking.Location = New System.Drawing.Point(406, 153)
        Me.hourBooking.Name = "hourBooking"
        Me.hourBooking.Size = New System.Drawing.Size(130, 25)
        Me.hourBooking.TabIndex = 28
        '
        'dateBooking
        '
        Me.dateBooking.CalendarFont = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBooking.Location = New System.Drawing.Point(103, 153)
        Me.dateBooking.Name = "dateBooking"
        Me.dateBooking.Size = New System.Drawing.Size(233, 25)
        Me.dateBooking.TabIndex = 29
        '
        'typeBooking
        '
        Me.typeBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeBooking.FormattingEnabled = True
        Me.typeBooking.Items.AddRange(New Object() {"Trialthon", "Road Bike", "BMX", "Mountain Bike", "Electrical Bike", "City Bike"})
        Me.typeBooking.Location = New System.Drawing.Point(406, 109)
        Me.typeBooking.Name = "typeBooking"
        Me.typeBooking.Size = New System.Drawing.Size(130, 25)
        Me.typeBooking.TabIndex = 30
        '
        'placeBooking
        '
        Me.placeBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.placeBooking.FormattingEnabled = True
        Me.placeBooking.Items.AddRange(New Object() {"Bukit Kiara Park", "Perdana Botanical Garden", "Titiwangsa Lake Garden"})
        Me.placeBooking.Location = New System.Drawing.Point(103, 109)
        Me.placeBooking.Name = "placeBooking"
        Me.placeBooking.Size = New System.Drawing.Size(233, 25)
        Me.placeBooking.TabIndex = 31
        '
        'Button
        '
        Me.Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button.BackColor = System.Drawing.Color.Transparent
        Me.Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button.FlatAppearance.BorderSize = 2
        Me.Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button.Location = New System.Drawing.Point(1041, 39)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(120, 38)
        Me.Button.TabIndex = 32
        Me.Button.Text = "NEXT"
        Me.Button.UseVisualStyleBackColor = False
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
        Me.btnBook1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnBook1.Location = New System.Drawing.Point(641, 28)
        Me.btnBook1.Name = "btnBook1"
        Me.btnBook1.Size = New System.Drawing.Size(120, 38)
        Me.btnBook1.TabIndex = 33
        Me.btnBook1.Text = "CONTINUE"
        Me.btnBook1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.placeBook, Me.dateBook, Me.typeBook, Me.hourBook, Me.priceBook, Me.Delete})
        Me.DataGridView1.Location = New System.Drawing.Point(103, 212)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(602, 293)
        Me.DataGridView1.TabIndex = 34
        '
        'addBooking
        '
        Me.addBooking.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addBooking.FlatAppearance.BorderSize = 2
        Me.addBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBooking.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addBooking.Location = New System.Drawing.Point(641, 155)
        Me.addBooking.Name = "addBooking"
        Me.addBooking.Size = New System.Drawing.Size(66, 29)
        Me.addBooking.TabIndex = 35
        Me.addBooking.Text = "ADD"
        Me.addBooking.UseVisualStyleBackColor = False
        '
        'btnCalcPrice
        '
        Me.btnCalcPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCalcPrice.FlatAppearance.BorderSize = 2
        Me.btnCalcPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcPrice.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalcPrice.Location = New System.Drawing.Point(559, 155)
        Me.btnCalcPrice.Name = "btnCalcPrice"
        Me.btnCalcPrice.Size = New System.Drawing.Size(66, 29)
        Me.btnCalcPrice.TabIndex = 36
        Me.btnCalcPrice.Text = "TOTAL"
        Me.btnCalcPrice.UseVisualStyleBackColor = False
        '
        'placeBook
        '
        Me.placeBook.HeaderText = "Place"
        Me.placeBook.Name = "placeBook"
        '
        'dateBook
        '
        Me.dateBook.HeaderText = "Date"
        Me.dateBook.Name = "dateBook"
        '
        'typeBook
        '
        Me.typeBook.HeaderText = "Type"
        Me.typeBook.Name = "typeBook"
        '
        'hourBook
        '
        Me.hourBook.HeaderText = "Hour"
        Me.hourBook.Name = "hourBook"
        '
        'priceBook
        '
        Me.priceBook.HeaderText = "Price"
        Me.priceBook.Name = "priceBook"
        '
        'Delete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle3
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 60
        '
        'booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 554)
        Me.Controls.Add(Me.btnCalcPrice)
        Me.Controls.Add(Me.addBooking)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBook1)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.placeBooking)
        Me.Controls.Add(Me.typeBooking)
        Me.Controls.Add(Me.dateBooking)
        Me.Controls.Add(Me.hourBooking)
        Me.Controls.Add(Me.lblPriceBooking)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "booking"
        CType(Me.hourBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblPriceBooking As Label
    Friend WithEvents hourBooking As NumericUpDown
    Friend WithEvents dateBooking As DateTimePicker
    Friend WithEvents typeBooking As ComboBox
    Friend WithEvents placeBooking As ComboBox
    Friend WithEvents Button As Button
    Friend WithEvents btnBook1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents addBooking As Button
    Friend WithEvents btnCalcPrice As Button
    Friend WithEvents placeBook As DataGridViewTextBoxColumn
    Friend WithEvents dateBook As DataGridViewTextBoxColumn
    Friend WithEvents typeBook As DataGridViewTextBoxColumn
    Friend WithEvents hourBook As DataGridViewTextBoxColumn
    Friend WithEvents priceBook As DataGridViewTextBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
