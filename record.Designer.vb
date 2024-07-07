<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Record
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtBookID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ddStatus = New System.Windows.Forms.ComboBox()
        Me.PedalPalsDBDataSet1 = New PedalPals.PedalPalsDBDataSet1()
        Me.RentalStatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalStatTableAdapter = New PedalPals.PedalPalsDBDataSet1TableAdapters.RentalStatTableAdapter()
        Me.TableAdapterManager = New PedalPals.PedalPalsDBDataSet1TableAdapters.TableAdapterManager()
        Me.RentalStatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RentalStatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RentalStatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PedalPalsDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalStatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalStatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentalStatBindingNavigator.SuspendLayout()
        CType(Me.RentalStatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Location = New System.Drawing.Point(40, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 48)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Record"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(631, 112)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 28)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtBookID
        '
        Me.txtBookID.Location = New System.Drawing.Point(141, 116)
        Me.txtBookID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBookID.Name = "txtBookID"
        Me.txtBookID.Size = New System.Drawing.Size(187, 22)
        Me.txtBookID.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(345, 119)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Status :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(57, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Book ID :"
        '
        'ddStatus
        '
        Me.ddStatus.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddStatus.FormattingEnabled = True
        Me.ddStatus.Items.AddRange(New Object() {"Booked", "Completed", "Cancel"})
        Me.ddStatus.Location = New System.Drawing.Point(416, 112)
        Me.ddStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.ddStatus.Name = "ddStatus"
        Me.ddStatus.Size = New System.Drawing.Size(172, 31)
        Me.ddStatus.TabIndex = 31
        '
        'PedalPalsDBDataSet1
        '
        Me.PedalPalsDBDataSet1.DataSetName = "PedalPalsDBDataSet1"
        Me.PedalPalsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalStatBindingSource
        '
        Me.RentalStatBindingSource.DataMember = "RentalStat"
        Me.RentalStatBindingSource.DataSource = Me.PedalPalsDBDataSet1
        '
        'RentalStatTableAdapter
        '
        Me.RentalStatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bikeTableAdapter = Nothing
        Me.TableAdapterManager.locationTableAdapter = Nothing
        Me.TableAdapterManager.memberTableAdapter = Nothing
        Me.TableAdapterManager.paymentTableAdapter = Nothing
        Me.TableAdapterManager.RentalStatTableAdapter = Me.RentalStatTableAdapter
        Me.TableAdapterManager.rentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PedalPals.PedalPalsDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentalStatBindingNavigator
        '
        Me.RentalStatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RentalStatBindingNavigator.BindingSource = Me.RentalStatBindingSource
        Me.RentalStatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RentalStatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RentalStatBindingNavigator.ImageScalingSize = New System.Drawing.Size(21, 21)
        Me.RentalStatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RentalStatBindingNavigatorSaveItem})
        Me.RentalStatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RentalStatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RentalStatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RentalStatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RentalStatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RentalStatBindingNavigator.Name = "RentalStatBindingNavigator"
        Me.RentalStatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RentalStatBindingNavigator.Size = New System.Drawing.Size(1060, 29)
        Me.RentalStatBindingNavigator.TabIndex = 32
        Me.RentalStatBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(30, 21)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(30, 21)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 21)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RentalStatBindingNavigatorSaveItem
        '
        Me.RentalStatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RentalStatBindingNavigatorSaveItem.Image = CType(resources.GetObject("RentalStatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RentalStatBindingNavigatorSaveItem.Name = "RentalStatBindingNavigatorSaveItem"
        Me.RentalStatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RentalStatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RentalStatDataGridView
        '
        Me.RentalStatDataGridView.AutoGenerateColumns = False
        Me.RentalStatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalStatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.RentalStatDataGridView.DataSource = Me.RentalStatBindingSource
        Me.RentalStatDataGridView.Location = New System.Drawing.Point(61, 218)
        Me.RentalStatDataGridView.Name = "RentalStatDataGridView"
        Me.RentalStatDataGridView.RowHeadersWidth = 53
        Me.RentalStatDataGridView.RowTemplate.Height = 24
        Me.RentalStatDataGridView.Size = New System.Drawing.Size(941, 398)
        Me.RentalStatDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rent_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rent_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "rent_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "rent_date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "rent_hour"
        Me.DataGridViewTextBoxColumn3.HeaderText = "rent_hour"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "bike_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "bike_id"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "mem_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "mem_id"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "location_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "location_id"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "rent_time_start"
        Me.DataGridViewTextBoxColumn7.HeaderText = "rent_time_start"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "rent_time_end"
        Me.DataGridViewTextBoxColumn8.HeaderText = "rent_time_end"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 130
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "rent_status"
        Me.DataGridViewTextBoxColumn9.HeaderText = "rent_status"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 130
        '
        'Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 695)
        Me.Controls.Add(Me.RentalStatDataGridView)
        Me.Controls.Add(Me.RentalStatBindingNavigator)
        Me.Controls.Add(Me.ddStatus)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtBookID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "record"
        CType(Me.PedalPalsDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalStatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalStatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentalStatBindingNavigator.ResumeLayout(False)
        Me.RentalStatBindingNavigator.PerformLayout()
        CType(Me.RentalStatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtBookID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ddStatus As ComboBox
    Friend WithEvents PedalPalsDBDataSet1 As PedalPalsDBDataSet1
    Friend WithEvents RentalStatBindingSource As BindingSource
    Friend WithEvents RentalStatTableAdapter As PedalPalsDBDataSet1TableAdapters.RentalStatTableAdapter
    Friend WithEvents TableAdapterManager As PedalPalsDBDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents RentalStatBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RentalStatBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RentalStatDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
