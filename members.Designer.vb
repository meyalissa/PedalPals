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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(members))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PedalPalsDBDataSet1 = New PedalPals.PedalPalsDBDataSet1()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberTableAdapter = New PedalPals.PedalPalsDBDataSet1TableAdapters.memberTableAdapter()
        Me.TableAdapterManager = New PedalPals.PedalPalsDBDataSet1TableAdapters.TableAdapterManager()
        Me.MemberBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MemberBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New PedalPals.PedalPalsDBDataSet1TableAdapters.rentalTableAdapter()
        Me.MemberDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PedalPalsDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MemberBindingNavigator.SuspendLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label2.Size = New System.Drawing.Size(182, 48)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Members"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PedalPalsDBDataSet1
        '
        Me.PedalPalsDBDataSet1.DataSetName = "PedalPalsDBDataSet1"
        Me.PedalPalsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "member"
        Me.MemberBindingSource.DataSource = Me.PedalPalsDBDataSet1
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bikeTableAdapter = Nothing
        Me.TableAdapterManager.locationTableAdapter = Nothing
        Me.TableAdapterManager.memberTableAdapter = Me.MemberTableAdapter
        Me.TableAdapterManager.paymentTableAdapter = Nothing
        Me.TableAdapterManager.RentalStatTableAdapter = Nothing
        Me.TableAdapterManager.rentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PedalPals.PedalPalsDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MemberBindingNavigator
        '
        Me.MemberBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MemberBindingNavigator.BindingSource = Me.MemberBindingSource
        Me.MemberBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MemberBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MemberBindingNavigator.ImageScalingSize = New System.Drawing.Size(21, 21)
        Me.MemberBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MemberBindingNavigatorSaveItem})
        Me.MemberBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MemberBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MemberBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MemberBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MemberBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MemberBindingNavigator.Name = "MemberBindingNavigator"
        Me.MemberBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MemberBindingNavigator.Size = New System.Drawing.Size(1060, 29)
        Me.MemberBindingNavigator.TabIndex = 25
        Me.MemberBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(30, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.216!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'MemberBindingNavigatorSaveItem
        '
        Me.MemberBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MemberBindingNavigatorSaveItem.Image = CType(resources.GetObject("MemberBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MemberBindingNavigatorSaveItem.Name = "MemberBindingNavigatorSaveItem"
        Me.MemberBindingNavigatorSaveItem.Size = New System.Drawing.Size(30, 25)
        Me.MemberBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "rental"
        Me.RentalBindingSource.DataSource = Me.PedalPalsDBDataSet1
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'MemberDataGridView
        '
        Me.MemberDataGridView.AutoGenerateColumns = False
        Me.MemberDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.MemberDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MemberDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MemberDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.MemberDataGridView.DataSource = Me.MemberBindingSource
        Me.MemberDataGridView.Location = New System.Drawing.Point(48, 160)
        Me.MemberDataGridView.Name = "MemberDataGridView"
        Me.MemberDataGridView.RowHeadersWidth = 53
        Me.MemberDataGridView.RowTemplate.Height = 24
        Me.MemberDataGridView.Size = New System.Drawing.Size(951, 435)
        Me.MemberDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "mem_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "mem_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 87
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "mem_username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "mem_username"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 136
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "mem_password"
        Me.DataGridViewTextBoxColumn3.HeaderText = "mem_password"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 135
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "mem_first_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "mem_first_name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 137
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "mem_last_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "mem_last_name"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 138
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mem_phone_no"
        Me.DataGridViewTextBoxColumn6.HeaderText = "mem_phone_no"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 136
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "mem_email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "mem_email"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 109
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "mem_address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "mem_address"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 7
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 126
        '
        'members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1060, 682)
        Me.Controls.Add(Me.MemberDataGridView)
        Me.Controls.Add(Me.MemberBindingNavigator)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "members"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "members"
        CType(Me.PedalPalsDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MemberBindingNavigator.ResumeLayout(False)
        Me.MemberBindingNavigator.PerformLayout()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PedalPalsDBDataSet1 As PedalPalsDBDataSet1
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As PedalPalsDBDataSet1TableAdapters.memberTableAdapter
    Friend WithEvents TableAdapterManager As PedalPalsDBDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MemberBindingNavigator As BindingNavigator
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
    Friend WithEvents MemberBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RentalBindingSource As BindingSource
    Friend WithEvents RentalTableAdapter As PedalPalsDBDataSet1TableAdapters.rentalTableAdapter
    Friend WithEvents MemberDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
