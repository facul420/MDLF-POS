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
        Me.DGSales = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TSItemsTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TSDiscountTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGSales
        '
        Me.DGSales.AllowUserToAddRows = False
        Me.DGSales.AllowUserToResizeColumns = False
        Me.DGSales.AllowUserToResizeRows = False
        Me.DGSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGSales.BackgroundColor = System.Drawing.Color.White
        Me.DGSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSales.Location = New System.Drawing.Point(13, 69)
        Me.DGSales.Name = "DGSales"
        Me.DGSales.RowHeadersVisible = False
        Me.DGSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGSales.RowTemplate.ReadOnly = True
        Me.DGSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSales.Size = New System.Drawing.Size(1089, 442)
        Me.DGSales.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 34)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(220, 30)
        Me.SearchTextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(609, 556)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Sales Amount"
        '
        'TSAmountTextBox
        '
        Me.TSAmountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSAmountTextBox.Location = New System.Drawing.Point(743, 552)
        Me.TSAmountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSAmountTextBox.Name = "TSAmountTextBox"
        Me.TSAmountTextBox.ReadOnly = True
        Me.TSAmountTextBox.Size = New System.Drawing.Size(180, 30)
        Me.TSAmountTextBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(408, 555)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total Sales Item"
        '
        'TSItemsTextBox
        '
        Me.TSItemsTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSItemsTextBox.Location = New System.Drawing.Point(522, 552)
        Me.TSItemsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSItemsTextBox.Name = "TSItemsTextBox"
        Me.TSItemsTextBox.ReadOnly = True
        Me.TSItemsTextBox.Size = New System.Drawing.Size(83, 30)
        Me.TSItemsTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 24)
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
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(146, 556)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Sales Discount"
        '
        'TSDiscountTextBox
        '
        Me.TSDiscountTextBox.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSDiscountTextBox.Location = New System.Drawing.Point(286, 552)
        Me.TSDiscountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TSDiscountTextBox.Name = "TSDiscountTextBox"
        Me.TSDiscountTextBox.ReadOnly = True
        Me.TSDiscountTextBox.Size = New System.Drawing.Size(101, 30)
        Me.TSDiscountTextBox.TabIndex = 11
        '
        'SubFormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TSDiscountTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TSItemsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TSAmountTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.DGSales)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubFormSales"
        Me.Text = "Sales"
        CType(Me.DGSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGSales As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TSAmountTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TSItemsTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TSDiscountTextBox As TextBox
End Class
