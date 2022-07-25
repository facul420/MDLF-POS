<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.labelHome = New System.Windows.Forms.Label()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconCurrentFormIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnPOS = New FontAwesome.Sharp.IconButton()
        Me.btnAccount = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.MenuPanel.SuspendLayout()
        Me.LogoPanel.SuspendLayout()
        Me.TitleBarPanel.SuspendLayout()
        Me.panelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentFormIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.MenuPanel.Controls.Add(Me.btnLogout)
        Me.MenuPanel.Controls.Add(Me.btnPOS)
        Me.MenuPanel.Controls.Add(Me.btnAccount)
        Me.MenuPanel.Controls.Add(Me.btnSales)
        Me.MenuPanel.Controls.Add(Me.btnInventory)
        Me.MenuPanel.Controls.Add(Me.LogoPanel)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(220, 726)
        Me.MenuPanel.TabIndex = 0
        '
        'LogoPanel
        '
        Me.LogoPanel.Controls.Add(Me.imgHome)
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(220, 162)
        Me.LogoPanel.TabIndex = 0
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TitleBarPanel.Controls.Add(Me.IDTextBox)
        Me.TitleBarPanel.Controls.Add(Me.labelHome)
        Me.TitleBarPanel.Controls.Add(Me.IconCurrentFormIcon)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.Location = New System.Drawing.Point(220, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(1130, 50)
        Me.TitleBarPanel.TabIndex = 1
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(1056, 12)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(62, 19)
        Me.IDTextBox.TabIndex = 2
        '
        'labelHome
        '
        Me.labelHome.AutoSize = True
        Me.labelHome.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHome.ForeColor = System.Drawing.Color.Gainsboro
        Me.labelHome.Location = New System.Drawing.Point(75, 19)
        Me.labelHome.Name = "labelHome"
        Me.labelHome.Size = New System.Drawing.Size(64, 22)
        Me.labelHome.TabIndex = 1
        Me.labelHome.Text = "Home"
        '
        'panelDesktop
        '
        Me.panelDesktop.AutoSize = True
        Me.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.panelDesktop.Controls.Add(Me.Guna2HtmlLabel1)
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(220, 50)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1130, 676)
        Me.panelDesktop.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(483, 396)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(215, 88)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = resources.GetString("Guna2HtmlLabel1.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.MDLF_POS.My.Resources.Resources.homepagelogo
        Me.PictureBox1.Location = New System.Drawing.Point(355, 181)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'IconCurrentFormIcon
        '
        Me.IconCurrentFormIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconCurrentFormIcon.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentFormIcon.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentFormIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentFormIcon.IconSize = 37
        Me.IconCurrentFormIcon.Location = New System.Drawing.Point(26, 11)
        Me.IconCurrentFormIcon.Name = "IconCurrentFormIcon"
        Me.IconCurrentFormIcon.Size = New System.Drawing.Size(43, 37)
        Me.IconCurrentFormIcon.TabIndex = 0
        Me.IconCurrentFormIcon.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.AngleLeft
        Me.btnLogout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 32
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 684)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnLogout.Size = New System.Drawing.Size(220, 42)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnPOS
        '
        Me.btnPOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPOS.FlatAppearance.BorderSize = 0
        Me.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOS.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOS.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPOS.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btnPOS.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPOS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPOS.IconSize = 32
        Me.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOS.Location = New System.Drawing.Point(0, 342)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPOS.Size = New System.Drawing.Size(220, 384)
        Me.btnPOS.TabIndex = 4
        Me.btnPOS.Text = "POS"
        Me.btnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'btnAccount
        '
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnAccount.IconChar = FontAwesome.Sharp.IconChar.DriversLicense
        Me.btnAccount.IconColor = System.Drawing.Color.Gainsboro
        Me.btnAccount.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAccount.IconSize = 32
        Me.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.Location = New System.Drawing.Point(0, 282)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnAccount.Size = New System.Drawing.Size(220, 60)
        Me.btnAccount.TabIndex = 3
        Me.btnAccount.Text = "Account"
        Me.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccount.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.btnSales.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSales.IconSize = 32
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 222)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSales.Size = New System.Drawing.Size(220, 60)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Dropbox
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 32
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 162)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(220, 60)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'imgHome
        '
        Me.imgHome.Image = Global.MDLF_POS.My.Resources.Resources.logo
        Me.imgHome.Location = New System.Drawing.Point(34, 12)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(140, 102)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelDesktop)
        Me.Controls.Add(Me.TitleBarPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuPanel.ResumeLayout(False)
        Me.LogoPanel.ResumeLayout(False)
        Me.TitleBarPanel.ResumeLayout(False)
        Me.TitleBarPanel.PerformLayout()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentFormIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents LogoPanel As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents btnPOS As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAccount As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents TitleBarPanel As Panel
    Friend WithEvents IconCurrentFormIcon As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents labelHome As Label
    Friend WithEvents panelDesktop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
