<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubFormInventory
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
        Me.DGInventory = New System.Windows.Forms.DataGridView()
        Me.prodCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prodSpecialDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemsLeft = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AdditionalItemsTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProductTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UnitInStockTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SpecialDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.ProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        CType(Me.DGInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGInventory
        '
        Me.DGInventory.AllowUserToAddRows = False
        Me.DGInventory.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prodCode, Me.prodType, Me.prodName, Me.prodPrice, Me.prodSpecialDiscount, Me.itemsLeft})
        Me.DGInventory.Location = New System.Drawing.Point(404, 0)
        Me.DGInventory.Name = "DGInventory"
        Me.DGInventory.ReadOnly = True
        Me.DGInventory.RowHeadersVisible = False
        Me.DGInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGInventory.Size = New System.Drawing.Size(715, 651)
        Me.DGInventory.TabIndex = 1
        '
        'prodCode
        '
        Me.prodCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prodCode.HeaderText = "Product Code"
        Me.prodCode.MinimumWidth = 20
        Me.prodCode.Name = "prodCode"
        Me.prodCode.ReadOnly = True
        Me.prodCode.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'prodType
        '
        Me.prodType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prodType.HeaderText = "Product Type"
        Me.prodType.Name = "prodType"
        Me.prodType.ReadOnly = True
        Me.prodType.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'prodName
        '
        Me.prodName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prodName.HeaderText = "Product Name"
        Me.prodName.MinimumWidth = 50
        Me.prodName.Name = "prodName"
        Me.prodName.ReadOnly = True
        Me.prodName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'prodPrice
        '
        Me.prodPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prodPrice.HeaderText = "Product Price"
        Me.prodPrice.Name = "prodPrice"
        Me.prodPrice.ReadOnly = True
        Me.prodPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'prodSpecialDiscount
        '
        Me.prodSpecialDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.prodSpecialDiscount.HeaderText = "Special Discount"
        Me.prodSpecialDiscount.Name = "prodSpecialDiscount"
        Me.prodSpecialDiscount.ReadOnly = True
        Me.prodSpecialDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'itemsLeft
        '
        Me.itemsLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemsLeft.HeaderText = "Unit in Stock"
        Me.itemsLeft.Name = "itemsLeft"
        Me.itemsLeft.ReadOnly = True
        Me.itemsLeft.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SkyBlue
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(128, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Search Product Code"
        '
        'SearchCodeTextBox
        '
        Me.SearchCodeTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchCodeTextBox.Location = New System.Drawing.Point(81, 101)
        Me.SearchCodeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchCodeTextBox.Name = "SearchCodeTextBox"
        Me.SearchCodeTextBox.Size = New System.Drawing.Size(257, 30)
        Me.SearchCodeTextBox.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.Panel1.Controls.Add(Me.ClearButton)
        Me.Panel1.Controls.Add(Me.AdditionalItemsTextBox)
        Me.Panel1.Controls.Add(Me.GenerateButton)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ProductTypeTextBox)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.UnitInStockTextBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SpecialDiscountTextBox)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ProductPriceTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ProductNameTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AddItemButton)
        Me.Panel1.Controls.Add(Me.ProductCodeTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 226)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 412)
        Me.Panel1.TabIndex = 6
        '
        'AdditionalItemsTextBox
        '
        Me.AdditionalItemsTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdditionalItemsTextBox.Location = New System.Drawing.Point(221, 261)
        Me.AdditionalItemsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AdditionalItemsTextBox.Name = "AdditionalItemsTextBox"
        Me.AdditionalItemsTextBox.Size = New System.Drawing.Size(105, 27)
        Me.AdditionalItemsTextBox.TabIndex = 31
        '
        'GenerateButton
        '
        Me.GenerateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GenerateButton.Location = New System.Drawing.Point(241, 30)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(85, 27)
        Me.GenerateButton.TabIndex = 30
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(156, 264)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 23)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "%"
        '
        'ProductTypeTextBox
        '
        Me.ProductTypeTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductTypeTextBox.Location = New System.Drawing.Point(39, 84)
        Me.ProductTypeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductTypeTextBox.Name = "ProductTypeTextBox"
        Me.ProductTypeTextBox.Size = New System.Drawing.Size(287, 27)
        Me.ProductTypeTextBox.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(236, 172)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 23)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Unit in Stock"
        '
        'UnitInStockTextBox
        '
        Me.UnitInStockTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitInStockTextBox.Location = New System.Drawing.Point(221, 197)
        Me.UnitInStockTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UnitInStockTextBox.Name = "UnitInStockTextBox"
        Me.UnitInStockTextBox.ReadOnly = True
        Me.UnitInStockTextBox.Size = New System.Drawing.Size(105, 27)
        Me.UnitInStockTextBox.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 236)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "+Items"
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeleteButton.BackColor = System.Drawing.Color.Red
        Me.DeleteButton.Enabled = False
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(130, 316)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(85, 35)
        Me.DeleteButton.TabIndex = 22
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SaveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SaveButton.Enabled = False
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(221, 316)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(105, 35)
        Me.SaveButton.TabIndex = 21
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Special Discount"
        '
        'SpecialDiscountTextBox
        '
        Me.SpecialDiscountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialDiscountTextBox.Location = New System.Drawing.Point(40, 261)
        Me.SpecialDiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SpecialDiscountTextBox.Name = "SpecialDiscountTextBox"
        Me.SpecialDiscountTextBox.Size = New System.Drawing.Size(112, 27)
        Me.SpecialDiscountTextBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Product Price"
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(39, 197)
        Me.ProductPriceTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(113, 27)
        Me.ProductPriceTextBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Product Name"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(39, 138)
        Me.ProductNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(287, 27)
        Me.ProductNameTextBox.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Product Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product Code"
        '
        'AddItemButton
        '
        Me.AddItemButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AddItemButton.BackColor = System.Drawing.Color.Turquoise
        Me.AddItemButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddItemButton.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddItemButton.Location = New System.Drawing.Point(39, 316)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(83, 35)
        Me.AddItemButton.TabIndex = 11
        Me.AddItemButton.Text = "Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = False
        '
        'ProductCodeTextBox
        '
        Me.ProductCodeTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCodeTextBox.Location = New System.Drawing.Point(39, 30)
        Me.ProductCodeTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductCodeTextBox.MaxLength = 50000
        Me.ProductCodeTextBox.Name = "ProductCodeTextBox"
        Me.ProductCodeTextBox.ReadOnly = True
        Me.ProductCodeTextBox.Size = New System.Drawing.Size(197, 27)
        Me.ProductCodeTextBox.TabIndex = 12
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClearButton.Enabled = False
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(120, 357)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(105, 35)
        Me.ClearButton.TabIndex = 32
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SubFormInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1117, 650)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SearchCodeTextBox)
        Me.Controls.Add(Me.DGInventory)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubFormInventory"
        Me.Text = "Inventory"
        CType(Me.DGInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGInventory As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchCodeTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents SpecialDiscountTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AddItemButton As Button
    Friend WithEvents ProductCodeTextBox As TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ProductTypeTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents UnitInStockTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GenerateButton As Button
    Friend WithEvents AdditionalItemsTextBox As TextBox
    Friend WithEvents prodCode As DataGridViewTextBoxColumn
    Friend WithEvents prodType As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodPrice As DataGridViewTextBoxColumn
    Friend WithEvents prodSpecialDiscount As DataGridViewTextBoxColumn
    Friend WithEvents itemsLeft As DataGridViewTextBoxColumn
    Friend WithEvents ClearButton As Button
End Class
