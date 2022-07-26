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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.AccountsDataGrid = New System.Windows.Forms.DataGridView()
        Me.IdAccounts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassAcc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEmployment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnApply = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.AccShowPass = New System.Windows.Forms.CheckBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.cmbPosAcc = New System.Windows.Forms.ComboBox()
        Me.txtDeleteAcc = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConPassAcc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassAcc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtUserAcc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddAcc = New System.Windows.Forms.Button()
        Me.txtNameAcc = New System.Windows.Forms.TextBox()
        Me.btnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtIdSearch = New System.Windows.Forms.TextBox()
        Me.IdPicBoxAcc = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbID = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IdPicBoxAcc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountsDataGrid
        '
        Me.AccountsDataGrid.AllowUserToAddRows = False
        Me.AccountsDataGrid.AllowUserToDeleteRows = False
        Me.AccountsDataGrid.AllowUserToResizeColumns = False
        Me.AccountsDataGrid.AllowUserToResizeRows = False
        Me.AccountsDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AccountsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAccounts, Me.NameAcc, Me.PositionAcc, Me.UserAcc, Me.PassAcc, Me.DateOfEmployment})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift Condensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AccountsDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.AccountsDataGrid.Location = New System.Drawing.Point(432, 69)
        Me.AccountsDataGrid.Name = "AccountsDataGrid"
        Me.AccountsDataGrid.ReadOnly = True
        Me.AccountsDataGrid.RowHeadersVisible = False
        Me.AccountsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.AccountsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccountsDataGrid.Size = New System.Drawing.Size(671, 556)
        Me.AccountsDataGrid.TabIndex = 2
        Me.AccountsDataGrid.TabStop = False
        '
        'IdAccounts
        '
        Me.IdAccounts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IdAccounts.HeaderText = "ID"
        Me.IdAccounts.Name = "IdAccounts"
        Me.IdAccounts.ReadOnly = True
        Me.IdAccounts.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.IdAccounts.Width = 44
        '
        'NameAcc
        '
        Me.NameAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameAcc.HeaderText = "Name"
        Me.NameAcc.Name = "NameAcc"
        Me.NameAcc.ReadOnly = True
        Me.NameAcc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'PositionAcc
        '
        Me.PositionAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PositionAcc.HeaderText = "Position"
        Me.PositionAcc.Name = "PositionAcc"
        Me.PositionAcc.ReadOnly = True
        Me.PositionAcc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PositionAcc.Width = 75
        '
        'UserAcc
        '
        Me.UserAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.UserAcc.HeaderText = "User Name"
        Me.UserAcc.Name = "UserAcc"
        Me.UserAcc.ReadOnly = True
        Me.UserAcc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserAcc.Width = 84
        '
        'PassAcc
        '
        Me.PassAcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PassAcc.HeaderText = "Password"
        Me.PassAcc.Name = "PassAcc"
        Me.PassAcc.ReadOnly = True
        Me.PassAcc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PassAcc.Width = 86
        '
        'DateOfEmployment
        '
        Me.DateOfEmployment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DateOfEmployment.HeaderText = "Date of Employment"
        Me.DateOfEmployment.Name = "DateOfEmployment"
        Me.DateOfEmployment.ReadOnly = True
        Me.DateOfEmployment.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateOfEmployment.Width = 127
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.Panel1.Controls.Add(Me.btnApply)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.AccShowPass)
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Controls.Add(Me.cmbPosAcc)
        Me.Panel1.Controls.Add(Me.txtDeleteAcc)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtConPassAcc)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPassAcc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.txtUserAcc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnAddAcc)
        Me.Panel1.Controls.Add(Me.txtNameAcc)
        Me.Panel1.Location = New System.Drawing.Point(13, 179)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(413, 446)
        Me.Panel1.TabIndex = 0
        '
        'btnApply
        '
        Me.btnApply.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnApply.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnApply.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnApply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnApply.FillColor = System.Drawing.Color.LightSkyBlue
        Me.btnApply.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.Black
        Me.btnApply.Location = New System.Drawing.Point(214, 30)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(63, 27)
        Me.btnApply.TabIndex = 31
        Me.btnApply.Text = "Apply"
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.Location = New System.Drawing.Point(9, 322)
        Me.txtDate.Mask = "00/00/0000"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(122, 27)
        Me.txtDate.TabIndex = 7
        Me.txtDate.ValidatingType = GetType(Date)
        '
        'AccShowPass
        '
        Me.AccShowPass.AutoSize = True
        Me.AccShowPass.BackColor = System.Drawing.Color.Transparent
        Me.AccShowPass.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccShowPass.Location = New System.Drawing.Point(132, 197)
        Me.AccShowPass.Name = "AccShowPass"
        Me.AccShowPass.Size = New System.Drawing.Size(129, 27)
        Me.AccShowPass.TabIndex = 30
        Me.AccShowPass.Text = "Show Password"
        Me.AccShowPass.UseVisualStyleBackColor = False
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.BackColor = System.Drawing.Color.Transparent
        Me.DateLabel.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.Location = New System.Drawing.Point(291, 5)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(88, 23)
        Me.DateLabel.TabIndex = 11
        Me.DateLabel.Text = "ID generator"
        '
        'cmbPosAcc
        '
        Me.cmbPosAcc.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbPosAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmbPosAcc.FormattingEnabled = True
        Me.cmbPosAcc.Items.AddRange(New Object() {"Admin", "Cashier"})
        Me.cmbPosAcc.Location = New System.Drawing.Point(10, 85)
        Me.cmbPosAcc.Name = "cmbPosAcc"
        Me.cmbPosAcc.Size = New System.Drawing.Size(164, 27)
        Me.cmbPosAcc.TabIndex = 3
        Me.cmbPosAcc.Text = "Cashier"
        '
        'txtDeleteAcc
        '
        Me.txtDeleteAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDeleteAcc.BackColor = System.Drawing.Color.Red
        Me.txtDeleteAcc.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.txtDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDeleteAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeleteAcc.Location = New System.Drawing.Point(282, 374)
        Me.txtDeleteAcc.Name = "txtDeleteAcc"
        Me.txtDeleteAcc.Size = New System.Drawing.Size(128, 35)
        Me.txtDeleteAcc.TabIndex = 22
        Me.txtDeleteAcc.Text = "Delete Employee"
        Me.txtDeleteAcc.UseVisualStyleBackColor = False
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
        Me.txtConPassAcc.TabIndex = 6
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
        Me.txtPassAcc.Location = New System.Drawing.Point(9, 197)
        Me.txtPassAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPassAcc.Name = "txtPassAcc"
        Me.txtPassAcc.Size = New System.Drawing.Size(113, 27)
        Me.txtPassAcc.TabIndex = 5
        Me.txtPassAcc.UseSystemPasswordChar = True
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
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(282, 30)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(112, 27)
        Me.txtID.TabIndex = 2
        '
        'txtUserAcc
        '
        Me.txtUserAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserAcc.Location = New System.Drawing.Point(10, 141)
        Me.txtUserAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserAcc.Name = "txtUserAcc"
        Me.txtUserAcc.Size = New System.Drawing.Size(112, 27)
        Me.txtUserAcc.TabIndex = 4
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 296)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date of Employment"
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
        'btnGenerate
        '
        Me.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnGenerate.BackColor = System.Drawing.Color.PaleGreen
        Me.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(295, 62)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(84, 34)
        Me.btnGenerate.TabIndex = 11
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.Color.Coral
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(145, 374)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(128, 35)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update Employee"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAddAcc
        '
        Me.btnAddAcc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAddAcc.BackColor = System.Drawing.Color.Turquoise
        Me.btnAddAcc.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAcc.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAcc.Location = New System.Drawing.Point(9, 374)
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
        Me.txtNameAcc.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Animated = True
        Me.btnClear.CustomBorderColor = System.Drawing.Color.White
        Me.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClear.FillColor = System.Drawing.Color.LightYellow
        Me.btnClear.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!)
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(346, 129)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 27)
        Me.btnClear.TabIndex = 31
        Me.btnClear.Text = "Clear"
        '
        'txtIdSearch
        '
        Me.txtIdSearch.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSearch.Location = New System.Drawing.Point(559, 38)
        Me.txtIdSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdSearch.Name = "txtIdSearch"
        Me.txtIdSearch.Size = New System.Drawing.Size(161, 27)
        Me.txtIdSearch.TabIndex = 1
        '
        'IdPicBoxAcc
        '
        Me.IdPicBoxAcc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IdPicBoxAcc.ImageRotate = 0!
        Me.IdPicBoxAcc.Location = New System.Drawing.Point(8, 6)
        Me.IdPicBoxAcc.Name = "IdPicBoxAcc"
        Me.IdPicBoxAcc.Size = New System.Drawing.Size(150, 150)
        Me.IdPicBoxAcc.TabIndex = 8
        Me.IdPicBoxAcc.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID Picture :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.lbID)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnBrowse)
        Me.Panel2.Controls.Add(Me.IdPicBoxAcc)
        Me.Panel2.Location = New System.Drawing.Point(13, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 161)
        Me.Panel2.TabIndex = 30
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.BackColor = System.Drawing.Color.Transparent
        Me.lbID.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(276, 30)
        Me.lbID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(68, 29)
        Me.lbID.TabIndex = 29
        Me.lbID.Text = "#####"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 29)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "ID #:"
        '
        'btnBrowse
        '
        Me.btnBrowse.Animated = True
        Me.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(271, 74)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(94, 29)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSearch
        '
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(432, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(122, 29)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "Search ID"
        '
        'SubFormAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1114, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtIdSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AccountsDataGrid)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubFormAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        CType(Me.AccountsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IdPicBoxAcc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccountsDataGrid As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDeleteAcc As Button
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
    Friend WithEvents AccShowPass As CheckBox
    Friend WithEvents txtIdSearch As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDate As MaskedTextBox
    Friend WithEvents DateLabel As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Public WithEvents cmbPosAcc As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnApply As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbID As Label
    Friend WithEvents IdAccounts As DataGridViewTextBoxColumn
    Friend WithEvents NameAcc As DataGridViewTextBoxColumn
    Friend WithEvents PositionAcc As DataGridViewTextBoxColumn
    Friend WithEvents UserAcc As DataGridViewTextBoxColumn
    Friend WithEvents PassAcc As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEmployment As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Guna.UI2.WinForms.Guna2Button
End Class
