<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class myrent_cust
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(147, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "My Rental"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.PlaceBook, Me.DateBook, Me.TypeBook, Me.HourBook, Me.PriceBook, Me.StatusBook})
        Me.DataGridView3.Location = New System.Drawing.Point(37, 95)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(732, 412)
        Me.DataGridView3.TabIndex = 14
        '
        'BookID
        '
        Me.BookID.HeaderText = "Book ID"
        Me.BookID.MaxInputLength = 4
        Me.BookID.Name = "BookID"
        '
        'PlaceBook
        '
        Me.PlaceBook.HeaderText = "Place"
        Me.PlaceBook.MaxInputLength = 50
        Me.PlaceBook.Name = "PlaceBook"
        '
        'DateBook
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DateBook.DefaultCellStyle = DataGridViewCellStyle1
        Me.DateBook.HeaderText = "Date"
        Me.DateBook.MaxInputLength = 15
        Me.DateBook.Name = "DateBook"
        '
        'TypeBook
        '
        Me.TypeBook.HeaderText = "Type"
        Me.TypeBook.MaxInputLength = 50
        Me.TypeBook.Name = "TypeBook"
        '
        'HourBook
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.HourBook.DefaultCellStyle = DataGridViewCellStyle2
        Me.HourBook.HeaderText = "Hour"
        Me.HourBook.Name = "HourBook"
        '
        'PriceBook
        '
        Me.PriceBook.HeaderText = "Price"
        Me.PriceBook.MaxInputLength = 10000
        Me.PriceBook.Name = "PriceBook"
        '
        'StatusBook
        '
        Me.StatusBook.HeaderText = "Status"
        Me.StatusBook.Name = "StatusBook"
        '
        'myrent_cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(795, 554)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "myrent_cust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "myrent_cust"
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents BookID As DataGridViewTextBoxColumn
    Friend WithEvents PlaceBook As DataGridViewTextBoxColumn
    Friend WithEvents DateBook As DataGridViewTextBoxColumn
    Friend WithEvents TypeBook As DataGridViewTextBoxColumn
    Friend WithEvents HourBook As DataGridViewTextBoxColumn
    Friend WithEvents PriceBook As DataGridViewTextBoxColumn
    Friend WithEvents StatusBook As DataGridViewTextBoxColumn
End Class
