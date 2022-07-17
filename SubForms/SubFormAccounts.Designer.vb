<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubFormAccounts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccountsDataGrid = New System.Windows.Forms.DataGridView()
        Me.IdAccounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEmployment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(541, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ACCOUNT SUB FORM "
        '
        'AccountsDataGrid
        '
        Me.AccountsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAccounts, Me.NameAcc, Me.PositionAcc, Me.DateOfEmployment})
        Me.AccountsDataGrid.Location = New System.Drawing.Point(110, 144)
        Me.AccountsDataGrid.Name = "AccountsDataGrid"
        Me.AccountsDataGrid.RowHeadersVisible = False
        Me.AccountsDataGrid.Size = New System.Drawing.Size(917, 462)
        Me.AccountsDataGrid.TabIndex = 2
        '
        'IdAccounts
        '
        Me.IdAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdAccounts.HeaderText = "ID"
        Me.IdAccounts.Name = "IdAccounts"
        Me.IdAccounts.Width = 43
        '
        'NameAcc
        '
        Me.NameAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameAcc.HeaderText = "Name"
        Me.NameAcc.Name = "NameAcc"
        '
        'PositionAcc
        '
        Me.PositionAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PositionAcc.HeaderText = "Position"
        Me.PositionAcc.Name = "PositionAcc"
        Me.PositionAcc.Width = 69
        '
        'DateOfEmployment
        '
        Me.DateOfEmployment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DateOfEmployment.HeaderText = "Date of Employment"
        Me.DateOfEmployment.Name = "DateOfEmployment"
        Me.DateOfEmployment.Width = 116
        '
        'SubFormAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 637)
        Me.Controls.Add(Me.AccountsDataGrid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SubFormAccounts"
        Me.Text = "Accounts"
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AccountsDataGrid As DataGridView
    Friend WithEvents IdAccounts As DataGridViewTextBoxColumn
    Friend WithEvents NameAcc As DataGridViewTextBoxColumn
    Friend WithEvents PositionAcc As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEmployment As DataGridViewTextBoxColumn
End Class
