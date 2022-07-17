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
        Me.AccountsDataGrid = New System.Windows.Forms.DataGridView()
        Me.IdAccounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEmployment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDeleteAcc = New System.Windows.Forms.Button()
        Me.btnSaveAcc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConPassAcc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassAcc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserAcc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAddAcc = New System.Windows.Forms.Button()
        Me.txtNameAcc = New System.Windows.Forms.TextBox()
        Me.IdPicBoxAcc = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPosAcc = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IdPicBoxAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountsDataGrid
        '
        Me.AccountsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAccounts, Me.NameAcc, Me.PositionAcc, Me.UserAcc, Me.PassAcc, Me.DateOfEmployment})
        Me.AccountsDataGrid.Location = New System.Drawing.Point(431, 22)
        Me.AccountsDataGrid.Name = "AccountsDataGrid"
        Me.AccountsDataGrid.RowHeadersVisible = False
        Me.AccountsDataGrid.Size = New System.Drawing.Size(671, 575)
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
        Me.PositionAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PositionAcc.HeaderText = "Position"
        Me.PositionAcc.Name = "PositionAcc"
        '
        'UserAcc
        '
        Me.UserAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.UserAcc.HeaderText = "User Name"
        Me.UserAcc.Name = "UserAcc"
        Me.UserAcc.Width = 85
        '
        'PassAcc
        '
        Me.PassAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PassAcc.HeaderText = "Password"
        Me.PassAcc.Name = "PassAcc"
        Me.PassAcc.Width = 78
        '
        'DateOfEmployment
        '
        Me.DateOfEmployment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateOfEmployment.HeaderText = "Date of Employment"
        Me.DateOfEmployment.Name = "DateOfEmployment"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.cmbPosAcc)
        Me.Panel1.Controls.Add(Me.txtDeleteAcc)
        Me.Panel1.Controls.Add(Me.btnSaveAcc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtConPassAcc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPassAcc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtUserAcc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnAddAcc)
        Me.Panel1.Controls.Add(Me.txtNameAcc)
        Me.Panel1.Location = New System.Drawing.Point(12, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 418)
        Me.Panel1.TabIndex = 7
        '
        'txtDeleteAcc
        '
        Me.txtDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDeleteAcc.BackColor = System.Drawing.Color.Red
        Me.txtDeleteAcc.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDeleteAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeleteAcc.Location = New System.Drawing.Point(12, 347)
        Me.txtDeleteAcc.Name = "txtDeleteAcc"
        Me.txtDeleteAcc.Size = New System.Drawing.Size(128, 35)
        Me.txtDeleteAcc.TabIndex = 22
        Me.txtDeleteAcc.Text = "Delete Employee"
        Me.txtDeleteAcc.UseVisualStyleBackColor = False
        '
        'btnSaveAcc
        '
        Me.btnSaveAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSaveAcc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSaveAcc.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAcc.Location = New System.Drawing.Point(314, 347)
        Me.btnSaveAcc.Name = "btnSaveAcc"
        Me.btnSaveAcc.Size = New System.Drawing.Size(76, 35)
        Me.btnSaveAcc.TabIndex = 21
        Me.btnSaveAcc.Text = "Save"
        Me.btnSaveAcc.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Confirm Password"
        '
        'txtConPassAcc
        '
        Me.txtConPassAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConPassAcc.Location = New System.Drawing.Point(10, 263)
        Me.txtConPassAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConPassAcc.Name = "txtConPassAcc"
        Me.txtConPassAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConPassAcc.Size = New System.Drawing.Size(110, 27)
        Me.txtConPassAcc.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Password"
        '
        'txtPassAcc
        '
        Me.txtPassAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassAcc.Location = New System.Drawing.Point(7, 197)
        Me.txtPassAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassAcc.Name = "txtPassAcc"
        Me.txtPassAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassAcc.Size = New System.Drawing.Size(113, 27)
        Me.txtPassAcc.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Username"
        '
        'txtUserAcc
        '
        Me.txtUserAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAcc.Location = New System.Drawing.Point(6, 141)
        Me.txtUserAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserAcc.Name = "txtUserAcc"
        Me.txtUserAcc.Size = New System.Drawing.Size(114, 27)
        Me.txtUserAcc.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Position"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Name"
        '
        'btnAddAcc
        '
        Me.btnAddAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddAcc.BackColor = System.Drawing.Color.Turquoise
        Me.btnAddAcc.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAcc.Location = New System.Drawing.Point(12, 306)
        Me.btnAddAcc.Name = "btnAddAcc"
        Me.btnAddAcc.Size = New System.Drawing.Size(128, 35)
        Me.btnAddAcc.TabIndex = 11
        Me.btnAddAcc.Text = "Add Employee"
        Me.btnAddAcc.UseVisualStyleBackColor = False
        '
        'txtNameAcc
        '
        Me.txtNameAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameAcc.Location = New System.Drawing.Point(9, 30)
        Me.txtNameAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNameAcc.Name = "txtNameAcc"
        Me.txtNameAcc.Size = New System.Drawing.Size(165, 27)
        Me.txtNameAcc.TabIndex = 12
        '
        'IdPicBoxAcc
        '
        Me.IdPicBoxAcc.ImageRotate = 0!
        Me.IdPicBoxAcc.Location = New System.Drawing.Point(147, 22)
        Me.IdPicBoxAcc.Name = "IdPicBoxAcc"
        Me.IdPicBoxAcc.Size = New System.Drawing.Size(150, 150)
        Me.IdPicBoxAcc.TabIndex = 8
        Me.IdPicBoxAcc.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 39)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID Picture :"
        '
        'cmbPosAcc
        '
        Me.cmbPosAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbPosAcc.FormattingEnabled = True
        Me.cmbPosAcc.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cmbPosAcc.Location = New System.Drawing.Point(10, 85)
        Me.cmbPosAcc.Name = "cmbPosAcc"
        Me.cmbPosAcc.Size = New System.Drawing.Size(164, 27)
        Me.cmbPosAcc.TabIndex = 29
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold)
        Me.CheckBox1.Location = New System.Drawing.Point(136, 197)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(129, 27)
        Me.CheckBox1.TabIndex = 30
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'SubFormAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 637)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IdPicBoxAcc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccountsDataGrid)
        Me.Name = "SubFormAccounts"
        Me.Text = "Accounts"
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IdPicBoxAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccountsDataGrid As DataGridView
    Friend WithEvents IdAccounts As DataGridViewTextBoxColumn
    Friend WithEvents NameAcc As DataGridViewTextBoxColumn
    Friend WithEvents PositionAcc As DataGridViewTextBoxColumn
    Friend WithEvents UserAcc As DataGridViewTextBoxColumn
    Friend WithEvents PassAcc As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEmployment As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDeleteAcc As Button
    Friend WithEvents btnSaveAcc As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConPassAcc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassAcc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserAcc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddAcc As Button
    Friend WithEvents txtNameAcc As TextBox
    Friend WithEvents IdPicBoxAcc As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPosAcc As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
