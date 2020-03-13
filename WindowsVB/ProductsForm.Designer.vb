<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelyearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BikeStoreDataSet1 = New WindowsVB.bikeStoreDataSet1()
        Me.ProductsTableAdapter = New WindowsVB.bikeStoreDataSet1TableAdapters.productsTableAdapter()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextProductName = New System.Windows.Forms.TextBox()
        Me.TextproductId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBandId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextcategoryId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextModelYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextListPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeStoreDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_id, Me.ProductnameDataGridViewTextBoxColumn, Me.BrandidDataGridViewTextBoxColumn, Me.CategoryidDataGridViewTextBoxColumn, Me.ModelyearDataGridViewTextBoxColumn, Me.ListpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProductsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(992, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'product_id
        '
        Me.product_id.DataPropertyName = "product_id"
        Me.product_id.HeaderText = "product_id"
        Me.product_id.MinimumWidth = 8
        Me.product_id.Name = "product_id"
        Me.product_id.ReadOnly = True
        Me.product_id.Width = 150
        '
        'ProductnameDataGridViewTextBoxColumn
        '
        Me.ProductnameDataGridViewTextBoxColumn.DataPropertyName = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.HeaderText = "product_name"
        Me.ProductnameDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProductnameDataGridViewTextBoxColumn.Name = "ProductnameDataGridViewTextBoxColumn"
        Me.ProductnameDataGridViewTextBoxColumn.Width = 150
        '
        'BrandidDataGridViewTextBoxColumn
        '
        Me.BrandidDataGridViewTextBoxColumn.DataPropertyName = "brand_id"
        Me.BrandidDataGridViewTextBoxColumn.HeaderText = "brand_id"
        Me.BrandidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.BrandidDataGridViewTextBoxColumn.Name = "BrandidDataGridViewTextBoxColumn"
        Me.BrandidDataGridViewTextBoxColumn.Width = 150
        '
        'CategoryidDataGridViewTextBoxColumn
        '
        Me.CategoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id"
        Me.CategoryidDataGridViewTextBoxColumn.HeaderText = "category_id"
        Me.CategoryidDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CategoryidDataGridViewTextBoxColumn.Name = "CategoryidDataGridViewTextBoxColumn"
        Me.CategoryidDataGridViewTextBoxColumn.Width = 150
        '
        'ModelyearDataGridViewTextBoxColumn
        '
        Me.ModelyearDataGridViewTextBoxColumn.DataPropertyName = "model_year"
        Me.ModelyearDataGridViewTextBoxColumn.HeaderText = "model_year"
        Me.ModelyearDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ModelyearDataGridViewTextBoxColumn.Name = "ModelyearDataGridViewTextBoxColumn"
        Me.ModelyearDataGridViewTextBoxColumn.Width = 150
        '
        'ListpriceDataGridViewTextBoxColumn
        '
        Me.ListpriceDataGridViewTextBoxColumn.DataPropertyName = "list_price"
        Me.ListpriceDataGridViewTextBoxColumn.HeaderText = "list_price"
        Me.ListpriceDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ListpriceDataGridViewTextBoxColumn.Name = "ListpriceDataGridViewTextBoxColumn"
        Me.ListpriceDataGridViewTextBoxColumn.Width = 150
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "products"
        Me.ProductsBindingSource.DataSource = Me.BikeStoreDataSet1
        '
        'BikeStoreDataSet1
        '
        Me.BikeStoreDataSet1.DataSetName = "bikeStoreDataSet1"
        Me.BikeStoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Location = New System.Drawing.Point(27, 169)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(141, 45)
        Me.ButtonInsert.TabIndex = 2
        Me.ButtonInsert.Text = "INSERT"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(185, 169)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(148, 45)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(365, 169)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(148, 45)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(543, 169)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 45)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "NEW PRODUCT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Product Name"
        '
        'TextProductName
        '
        Me.TextProductName.Location = New System.Drawing.Point(143, 12)
        Me.TextProductName.Name = "TextProductName"
        Me.TextProductName.Size = New System.Drawing.Size(202, 26)
        Me.TextProductName.TabIndex = 7
        '
        'TextproductId
        '
        Me.TextproductId.Location = New System.Drawing.Point(143, 47)
        Me.TextproductId.Name = "TextproductId"
        Me.TextproductId.Size = New System.Drawing.Size(202, 26)
        Me.TextproductId.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Product ID"
        '
        'TextBandId
        '
        Me.TextBandId.Location = New System.Drawing.Point(143, 88)
        Me.TextBandId.Name = "TextBandId"
        Me.TextBandId.Size = New System.Drawing.Size(202, 26)
        Me.TextBandId.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Band ID"
        '
        'TextcategoryId
        '
        Me.TextcategoryId.Location = New System.Drawing.Point(528, 12)
        Me.TextcategoryId.Name = "TextcategoryId"
        Me.TextcategoryId.Size = New System.Drawing.Size(175, 26)
        Me.TextcategoryId.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Category ID"
        '
        'TextModelYear
        '
        Me.TextModelYear.Location = New System.Drawing.Point(528, 47)
        Me.TextModelYear.Name = "TextModelYear"
        Me.TextModelYear.Size = New System.Drawing.Size(175, 26)
        Me.TextModelYear.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(388, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Model Year"
        '
        'TextListPrice
        '
        Me.TextListPrice.Location = New System.Drawing.Point(528, 82)
        Me.TextListPrice.Name = "TextListPrice"
        Me.TextListPrice.Size = New System.Drawing.Size(175, 26)
        Me.TextListPrice.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(388, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "List Price"
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 460)
        Me.Controls.Add(Me.TextListPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextModelYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextcategoryId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBandId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextproductId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ProductsForm"
        Me.Text = "ProductsForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeStoreDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BikeStoreDataSet1 As WindowsVB.bikeStoreDataSet1
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As WindowsVB.bikeStoreDataSet1TableAdapters.productsTableAdapter
    Friend WithEvents ButtonInsert As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextProductName As TextBox
    Friend WithEvents TextproductId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBandId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextcategoryId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextModelYear As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextListPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents product_id As DataGridViewTextBoxColumn
    Friend WithEvents ProductnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelyearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
