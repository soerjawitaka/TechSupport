<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerIncident
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerIncident))
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FKIncidentsCustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.IDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIDToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripbtnFindCustByState = New System.Windows.Forms.ToolStripButton()
        Me.FillByIDToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TechSupportDataSet = New TechSupport.TechSupportDataSet()
        Me.IncidentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New TechSupport.TechSupportDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New TechSupport.TechSupportDataSetTableAdapters.TableAdapterManager()
        Me.IncidentsTableAdapter = New TechSupport.TechSupportDataSetTableAdapters.IncidentsTableAdapter()
        Me.ProductsTableAdapter = New TechSupport.TechSupportDataSetTableAdapters.ProductsTableAdapter()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncidentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CustomerIDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.FKIncidentsCustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIDToolStrip.SuspendLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechSupportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(12, 41)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(12, 69)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 97)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 126)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(104, 17)
        CityLabel.TabIndex = 7
        CityLabel.Text = "City, State, Zip:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(12, 153)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 13
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 181)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 15
        EmailLabel.Text = "Email:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(123, 38)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(153, 22)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(123, 66)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(249, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(123, 94)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(249, 22)
        Me.AddressTextBox.TabIndex = 6
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(123, 122)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(93, 22)
        Me.CityTextBox.TabIndex = 8
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(221, 122)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.Size = New System.Drawing.Size(37, 22)
        Me.StateTextBox.TabIndex = 10
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(264, 122)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.ReadOnly = True
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(108, 22)
        Me.ZipCodeTextBox.TabIndex = 12
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(123, 150)
        Me.PhoneTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(136, 22)
        Me.PhoneTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(123, 178)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(249, 22)
        Me.EmailTextBox.TabIndex = 16
        '
        'FKIncidentsCustomersBindingSource
        '
        Me.FKIncidentsCustomersBindingSource.DataMember = "FK_Incidents_Customers"
        Me.FKIncidentsCustomersBindingSource.DataSource = Me.CustomersBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Programmed By: John Soerjawitaka"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(605, 463)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 36)
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Add New Incident"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'IDToolStripLabel
        '
        Me.IDToolStripLabel.Name = "IDToolStripLabel"
        Me.IDToolStripLabel.Size = New System.Drawing.Size(94, 24)
        Me.IDToolStripLabel.Text = "Customer ID:"
        '
        'IDToolStripTextBox
        '
        Me.IDToolStripTextBox.Name = "IDToolStripTextBox"
        Me.IDToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'FillByIDToolStripButton
        '
        Me.FillByIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIDToolStripButton.Name = "FillByIDToolStripButton"
        Me.FillByIDToolStripButton.Size = New System.Drawing.Size(51, 24)
        Me.FillByIDToolStripButton.Text = "[Find]"
        '
        'ToolStripbtnFindCustByState
        '
        Me.ToolStripbtnFindCustByState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripbtnFindCustByState.Image = CType(resources.GetObject("ToolStripbtnFindCustByState.Image"), System.Drawing.Image)
        Me.ToolStripbtnFindCustByState.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripbtnFindCustByState.Name = "ToolStripbtnFindCustByState"
        Me.ToolStripbtnFindCustByState.Size = New System.Drawing.Size(125, 24)
        Me.ToolStripbtnFindCustByState.Text = "[Search By State]"
        '
        'FillByIDToolStrip
        '
        Me.FillByIDToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByIDToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripLabel, Me.IDToolStripTextBox, Me.FillByIDToolStripButton, Me.ToolStripbtnFindCustByState})
        Me.FillByIDToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByIDToolStrip.Name = "FillByIDToolStrip"
        Me.FillByIDToolStrip.Size = New System.Drawing.Size(771, 27)
        Me.FillByIDToolStrip.TabIndex = 18
        Me.FillByIDToolStrip.Text = "FillByIDToolStrip"
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.TechSupportDataSet
        '
        'TechSupportDataSet
        '
        Me.TechSupportDataSet.DataSetName = "TechSupportDataSet"
        Me.TechSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncidentsBindingSource
        '
        Me.IncidentsBindingSource.DataMember = "Incidents"
        Me.IncidentsBindingSource.DataSource = Me.TechSupportDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.IncidentsTableAdapter = Me.IncidentsTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = TechSupport.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IncidentsTableAdapter
        '
        Me.IncidentsTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.TechSupportDataSet
        '
        'IncidentsDataGridView
        '
        Me.IncidentsDataGridView.AutoGenerateColumns = False
        Me.IncidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IncidentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.IncidentsDataGridView.DataSource = Me.FKIncidentsCustomersBindingSource
        Me.IncidentsDataGridView.Location = New System.Drawing.Point(12, 221)
        Me.IncidentsDataGridView.Name = "IncidentsDataGridView"
        Me.IncidentsDataGridView.RowTemplate.Height = 24
        Me.IncidentsDataGridView.Size = New System.Drawing.Size(747, 220)
        Me.IncidentsDataGridView.TabIndex = 20
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProductCode"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DateOpened"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DateOpened"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'frmCustomerIncident
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 545)
        Me.Controls.Add(Me.IncidentsDataGridView)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FillByIDToolStrip)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCustomerIncident"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Incident "
        CType(Me.FKIncidentsCustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIDToolStrip.ResumeLayout(False)
        Me.FillByIDToolStrip.PerformLayout()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechSupportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TechSupportDataSet As TechSupportDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As TechSupportDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As TechSupportDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsTableAdapter As TechSupportDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents IncidentsTableAdapter As TechSupportDataSetTableAdapters.IncidentsTableAdapter
    Friend WithEvents IncidentsBindingSource As BindingSource
    Friend WithEvents FKIncidentsCustomersBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents IDToolStripLabel As ToolStripLabel
    Friend WithEvents IDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillByIDToolStripButton As ToolStripButton
    Friend WithEvents ToolStripbtnFindCustByState As ToolStripButton
    Friend WithEvents FillByIDToolStrip As ToolStrip
    Friend WithEvents IncidentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
