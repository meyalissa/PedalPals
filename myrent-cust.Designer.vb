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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.BookID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlaceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceBook = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
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
        Me.Label2.Location = New System.Drawing.Point(40, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 46)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "My Rental"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookID, Me.PlaceBook, Me.DateBook, Me.TypeBook, Me.HourBook, Me.PriceBook, Me.btnDelete})
        Me.DataGridView3.Location = New System.Drawing.Point(49, 117)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(976, 507)
        Me.DataGridView3.TabIndex = 14
        '
        'BookID
        '
        Me.BookID.HeaderText = "Book ID"
        Me.BookID.MaxInputLength = 4
        Me.BookID.MinimumWidth = 6
        Me.BookID.Name = "BookID"
        Me.BookID.Width = 125
        '
        'PlaceBook
        '
        Me.PlaceBook.HeaderText = "Place"
        Me.PlaceBook.MaxInputLength = 50
        Me.PlaceBook.MinimumWidth = 6
        Me.PlaceBook.Name = "PlaceBook"
        Me.PlaceBook.Width = 125
        '
        'DateBook
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DateBook.DefaultCellStyle = DataGridViewCellStyle3
        Me.DateBook.HeaderText = "Date"
        Me.DateBook.MaxInputLength = 15
        Me.DateBook.MinimumWidth = 6
        Me.DateBook.Name = "DateBook"
        Me.DateBook.Width = 125
        '
        'TypeBook
        '
        Me.TypeBook.HeaderText = "Type"
        Me.TypeBook.MaxInputLength = 50
        Me.TypeBook.MinimumWidth = 6
        Me.TypeBook.Name = "TypeBook"
        Me.TypeBook.Width = 125
        '
        'HourBook
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.HourBook.DefaultCellStyle = DataGridViewCellStyle4
        Me.HourBook.HeaderText = "Hour"
        Me.HourBook.MinimumWidth = 6
        Me.HourBook.Name = "HourBook"
        Me.HourBook.Width = 125
        '
        'PriceBook
        '
        Me.PriceBook.HeaderText = "Price"
        Me.PriceBook.MaxInputLength = 10000
        Me.PriceBook.MinimumWidth = 6
        Me.PriceBook.Name = "PriceBook"
        Me.PriceBook.Width = 125
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = "Action"
        Me.btnDelete.MinimumWidth = 6
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Width = 125
        '
        'myrent_cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 682)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents btnDelete As DataGridViewButtonColumn
End Class
