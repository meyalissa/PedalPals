<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MemberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditRec = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeleteRec = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnAddmem = New System.Windows.Forms.Button()
        Me.txtmemID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.typeBooking = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberID, Me.BookID, Me.PlaceBook, Me.DateBook, Me.TypeBook, Me.HourBook, Me.PriceBook, Me.StatusBook, Me.EditRec, Me.DeleteRec})
        Me.DataGridView3.Location = New System.Drawing.Point(21, 142)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(752, 385)
        Me.DataGridView3.TabIndex = 13
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
        Me.Label2.Size = New System.Drawing.Size(108, 37)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Record"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MemberID
        '
        Me.MemberID.HeaderText = "Member ID"
        Me.MemberID.MaxInputLength = 4
        Me.MemberID.Name = "MemberID"
        Me.MemberID.Width = 80
        '
        'BookID
        '
        Me.BookID.HeaderText = "Book ID"
        Me.BookID.MaxInputLength = 4
        Me.BookID.Name = "BookID"
        Me.BookID.Width = 80
        '
        'PlaceBook
        '
        Me.PlaceBook.HeaderText = "Place"
        Me.PlaceBook.MaxInputLength = 50
        Me.PlaceBook.Name = "PlaceBook"
        '
        'DateBook
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateBook.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateBook.HeaderText = "Date"
        Me.DateBook.MaxInputLength = 15
        Me.DateBook.Name = "DateBook"
        Me.DateBook.Width = 80
        '
        'TypeBook
        '
        Me.TypeBook.HeaderText = "Type"
        Me.TypeBook.MaxInputLength = 50
        Me.TypeBook.Name = "TypeBook"
        Me.TypeBook.Width = 70
        '
        'HourBook
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.HourBook.DefaultCellStyle = DataGridViewCellStyle4
        Me.HourBook.HeaderText = "Hour"
        Me.HourBook.Name = "HourBook"
        Me.HourBook.Width = 60
        '
        'PriceBook
        '
        Me.PriceBook.HeaderText = "Price"
        Me.PriceBook.MaxInputLength = 10000
        Me.PriceBook.Name = "PriceBook"
        Me.PriceBook.Width = 60
        '
        'StatusBook
        '
        Me.StatusBook.HeaderText = "Status"
        Me.StatusBook.Name = "StatusBook"
        Me.StatusBook.Width = 60
        '
        'EditRec
        '
        Me.EditRec.HeaderText = "Edit"
        Me.EditRec.Name = "EditRec"
        Me.EditRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EditRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EditRec.Text = "Edit"
        Me.EditRec.UseColumnTextForButtonValue = True
        Me.EditRec.Width = 60
        '
        'DeleteRec
        '
        Me.DeleteRec.HeaderText = "Delete"
        Me.DeleteRec.Name = "DeleteRec"
        Me.DeleteRec.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DeleteRec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DeleteRec.Text = "Delete"
        Me.DeleteRec.UseColumnTextForButtonValue = True
        Me.DeleteRec.Width = 60
        '
        'btnAddmem
        '
        Me.btnAddmem.Location = New System.Drawing.Point(473, 86)
        Me.btnAddmem.Name = "btnAddmem"
        Me.btnAddmem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddmem.TabIndex = 29
        Me.btnAddmem.Text = "UPDATE"
        Me.btnAddmem.UseVisualStyleBackColor = True
        '
        'txtmemID
        '
        Me.txtmemID.Location = New System.Drawing.Point(106, 89)
        Me.txtmemID.Name = "txtmemID"
        Me.txtmemID.Size = New System.Drawing.Size(141, 20)
        Me.txtmemID.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(259, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(43, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Book ID :"
        '
        'typeBooking
        '
        Me.typeBooking.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeBooking.FormattingEnabled = True
        Me.typeBooking.Items.AddRange(New Object() {"Pending", "Success", "Cancel"})
        Me.typeBooking.Location = New System.Drawing.Point(312, 86)
        Me.typeBooking.Name = "typeBooking"
        Me.typeBooking.Size = New System.Drawing.Size(130, 25)
        Me.typeBooking.TabIndex = 31
        '
        'record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 554)
        Me.Controls.Add(Me.typeBooking)
        Me.Controls.Add(Me.btnAddmem)
        Me.Controls.Add(Me.txtmemID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "record"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents MemberID As DataGridViewTextBoxColumn
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents PlaceBook As DataGridViewTextBoxColumn
    Friend WithEvents DateBook As DataGridViewTextBoxColumn
    Friend WithEvents TypeBook As DataGridViewTextBoxColumn
    Friend WithEvents HourBook As DataGridViewTextBoxColumn
    Friend WithEvents PriceBook As DataGridViewTextBoxColumn
    Friend WithEvents StatusBook As DataGridViewTextBoxColumn
    Friend WithEvents EditRec As DataGridViewButtonColumn
    Friend WithEvents DeleteRec As DataGridViewButtonColumn
    Friend WithEvents btnAddmem As Button
    Friend WithEvents txtmemID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents typeBooking As ComboBox
End Class
