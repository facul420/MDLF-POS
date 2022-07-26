<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubFormSales
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
        Me.DGGeneralSales = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TSItemsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TSCashRecievedTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TransDateSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TransNumSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ProductCodeSearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TSUnitAmountTextBox = New System.Windows.Forms.TextBox()
        Me.TSUnitDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.DGUnitSales = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USTotalUnitTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DGGeneralSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGUnitSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGGeneralSales
        '
        Me.DGGeneralSales.AllowUserToAddRows = False
        Me.DGGeneralSales.AllowUserToDeleteRows = False
        Me.DGGeneralSales.AllowUserToResizeColumns = False
        Me.DGGeneralSales.AllowUserToResizeRows = False
        Me.DGGeneralSales.BackgroundColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGGeneralSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGGeneralSales.ColumnHeadersHeight = 35
        Me.DGGeneralSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGGeneralSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column12, Me.Column11})
        Me.DGGeneralSales.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGGeneralSales.Location = New System.Drawing.Point(20, 96)
        Me.DGGeneralSales.Name = "DGGeneralSales"
        Me.DGGeneralSales.ReadOnly = True
        Me.DGGeneralSales.RowHeadersVisible = False
        Me.DGGeneralSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGGeneralSales.RowTemplate.ReadOnly = True
        Me.DGGeneralSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGGeneralSales.Size = New System.Drawing.Size(492, 396)
        Me.DGGeneralSales.TabIndex = 0
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column7.HeaderText = "Transaction Number"
        Me.Column7.MinimumWidth = 90
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 183
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column8.FillWeight = 355.0724!
        Me.Column8.HeaderText = "Transaction Date"
        Me.Column8.MinimumWidth = 100
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.Width = 158
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column9.FillWeight = 36.23189!
        Me.Column9.HeaderText = "Total Items"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 116
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column10.FillWeight = 36.23189!
        Me.Column10.HeaderText = "Total Discount"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column10.Width = 138
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column12.FillWeight = 36.23189!
        Me.Column12.HeaderText = "Cash"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column12.Width = 71
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column11.FillWeight = 36.23189!
        Me.Column11.HeaderText = "Total Amount"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 132
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 36)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(20, 61)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(220, 30)
        Me.SearchTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 539)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Sales Amount"
        '
        'TSAmountTextBox
        '
        Me.TSAmountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSAmountTextBox.Location = New System.Drawing.Point(126, 536)
        Me.TSAmountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSAmountTextBox.Name = "TSAmountTextBox"
        Me.TSAmountTextBox.ReadOnly = True
        Me.TSAmountTextBox.Size = New System.Drawing.Size(127, 27)
        Me.TSAmountTextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 499)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Sales Item"
        '
        'TSItemsTextBox
        '
        Me.TSItemsTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSItemsTextBox.Location = New System.Drawing.Point(125, 497)
        Me.TSItemsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSItemsTextBox.Name = "TSItemsTextBox"
        Me.TSItemsTextBox.ReadOnly = True
        Me.TSItemsTextBox.Size = New System.Drawing.Size(128, 27)
        Me.TSItemsTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 39)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sales Inventory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 500)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Sales Discount"
        '
        'TSDiscountTextBox
        '
        Me.TSDiscountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSDiscountTextBox.Location = New System.Drawing.Point(378, 497)
        Me.TSDiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSDiscountTextBox.Name = "TSDiscountTextBox"
        Me.TSDiscountTextBox.ReadOnly = True
        Me.TSDiscountTextBox.Size = New System.Drawing.Size(134, 27)
        Me.TSDiscountTextBox.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TSCashRecievedTextBox)
        Me.GroupBox1.Controls.Add(Me.SearchTextBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TSAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.TSDiscountTextBox)
        Me.GroupBox1.Controls.Add(Me.DGGeneralSales)
        Me.GroupBox1.Controls.Add(Me.TSItemsTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 574)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General Sales"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bahnschrift Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(268, 539)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Total Cash Received"
        '
        'TSCashRecievedTextBox
        '
        Me.TSCashRecievedTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSCashRecievedTextBox.Location = New System.Drawing.Point(378, 536)
        Me.TSCashRecievedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSCashRecievedTextBox.Name = "TSCashRecievedTextBox"
        Me.TSCashRecievedTextBox.ReadOnly = True
        Me.TSCashRecievedTextBox.Size = New System.Drawing.Size(134, 27)
        Me.TSCashRecievedTextBox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TransDateSearchTextBox)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TransNumSearchTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ProductCodeSearchTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TSUnitAmountTextBox)
        Me.GroupBox2.Controls.Add(Me.TSUnitDiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.DGUnitSales)
        Me.GroupBox2.Controls.Add(Me.USTotalUnitTextBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(546, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 574)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unit Sales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(244, 45)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 19)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Transaction Date"
        '
        'TransDateSearchTextBox
        '
        Me.TransDateSearchTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransDateSearchTextBox.Location = New System.Drawing.Point(248, 70)
        Me.TransDateSearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TransDateSearchTextBox.Name = "TransDateSearchTextBox"
        Me.TransDateSearchTextBox.Size = New System.Drawing.Size(110, 23)
        Me.TransDateSearchTextBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 45)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Transaction #"
        '
        'TransNumSearchTextBox
        '
        Me.TransNumSearchTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransNumSearchTextBox.Location = New System.Drawing.Point(134, 70)
        Me.TransNumSearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TransNumSearchTextBox.Name = "TransNumSearchTextBox"
        Me.TransNumSearchTextBox.Size = New System.Drawing.Size(110, 23)
        Me.TransNumSearchTextBox.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Product Code"
        '
        'ProductCodeSearchTextBox
        '
        Me.ProductCodeSearchTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductCodeSearchTextBox.Location = New System.Drawing.Point(20, 70)
        Me.ProductCodeSearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProductCodeSearchTextBox.Name = "ProductCodeSearchTextBox"
        Me.ProductCodeSearchTextBox.Size = New System.Drawing.Size(110, 23)
        Me.ProductCodeSearchTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(296, 501)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Sales Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 540)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Sales Amount"
        '
        'TSUnitAmountTextBox
        '
        Me.TSUnitAmountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSUnitAmountTextBox.Location = New System.Drawing.Point(154, 536)
        Me.TSUnitAmountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSUnitAmountTextBox.Name = "TSUnitAmountTextBox"
        Me.TSUnitAmountTextBox.ReadOnly = True
        Me.TSUnitAmountTextBox.Size = New System.Drawing.Size(180, 30)
        Me.TSUnitAmountTextBox.TabIndex = 5
        '
        'TSUnitDiscountTextBox
        '
        Me.TSUnitDiscountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSUnitDiscountTextBox.Location = New System.Drawing.Point(436, 497)
        Me.TSUnitDiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSUnitDiscountTextBox.Name = "TSUnitDiscountTextBox"
        Me.TSUnitDiscountTextBox.ReadOnly = True
        Me.TSUnitDiscountTextBox.Size = New System.Drawing.Size(101, 30)
        Me.TSUnitDiscountTextBox.TabIndex = 11
        '
        'DGUnitSales
        '
        Me.DGUnitSales.AllowUserToAddRows = False
        Me.DGUnitSales.AllowUserToDeleteRows = False
        Me.DGUnitSales.AllowUserToResizeColumns = False
        Me.DGUnitSales.AllowUserToResizeRows = False
        Me.DGUnitSales.BackgroundColor = System.Drawing.Color.SandyBrown
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGUnitSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGUnitSales.ColumnHeadersHeight = 35
        Me.DGUnitSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGUnitSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column13, Me.Column2, Me.Column14, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DGUnitSales.Location = New System.Drawing.Point(20, 96)
        Me.DGUnitSales.Name = "DGUnitSales"
        Me.DGUnitSales.ReadOnly = True
        Me.DGUnitSales.RowHeadersVisible = False
        Me.DGUnitSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DGUnitSales.RowTemplate.ReadOnly = True
        Me.DGUnitSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUnitSales.Size = New System.Drawing.Size(517, 396)
        Me.DGUnitSales.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1.HeaderText = "Transaction #"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 134
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column13.HeaderText = "Transaction Date"
        Me.Column13.MinimumWidth = 65
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column13.Width = 158
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column2.HeaderText = "Product Code"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 134
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column14.HeaderText = "Product Name"
        Me.Column14.MinimumWidth = 100
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column14.Width = 140
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column3.HeaderText = "Unit Sold"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column3.Width = 101
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column4.HeaderText = "Total Discount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 138
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column5.HeaderText = "Total Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 132
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column6.HeaderText = "Sales Type"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 113
        '
        'USTotalUnitTextBox
        '
        Me.USTotalUnitTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USTotalUnitTextBox.Location = New System.Drawing.Point(154, 497)
        Me.USTotalUnitTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.USTotalUnitTextBox.Name = "USTotalUnitTextBox"
        Me.USTotalUnitTextBox.ReadOnly = True
        Me.USTotalUnitTextBox.Size = New System.Drawing.Size(83, 30)
        Me.USTotalUnitTextBox.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 500)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total Unit Sold"
        '
        'SubFormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubFormSales"
        Me.Text = "Sales"
        CType(Me.DGGeneralSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGUnitSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGGeneralSales As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TSAmountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TSItemsTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TSDiscountTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TransNumSearchTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ProductCodeSearchTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TSUnitAmountTextBox As TextBox
    Friend WithEvents TSUnitDiscountTextBox As TextBox
    Friend WithEvents DGUnitSales As DataGridView
    Friend WithEvents USTotalUnitTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TSCashRecievedTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TransDateSearchTextBox As TextBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
