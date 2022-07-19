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
        Me.btnLogout = New FontAwesome.Sharp.IconButton()
        Me.btnPOS = New FontAwesome.Sharp.IconButton()
        Me.btnAccount = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.LogoPanel = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.TitleBarPanel = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnMaximize = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.labelHome = New System.Windows.Forms.Label()
        Me.IconCurrentFormIcon = New FontAwesome.Sharp.IconPictureBox()
        Me.panelDesktop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.MenuPanel.SuspendLayout()
        Me.LogoPanel.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleBarPanel.SuspendLayout()
        CType(Me.IconCurrentFormIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnPOS.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPOS.FlatAppearance.BorderSize = 0
        Me.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPOS.IconChar = FontAwesome.Sharp.IconChar.CashRegister
        Me.btnPOS.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.btnAccount.BackgroundImage = CType(resources.GetObject("btnAccount.BackgroundImage"), System.Drawing.Image)
        Me.btnAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccount.FlatAppearance.BorderSize = 0
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAccount.IconChar = FontAwesome.Sharp.IconChar.DriversLicense
        Me.btnAccount.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.btnSales.BackgroundImage = CType(resources.GetObject("btnSales.BackgroundImage"), System.Drawing.Image)
        Me.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.MoneyBill
        Me.btnSales.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.btnInventory.BackgroundImage = CType(resources.GetObject("btnInventory.BackgroundImage"), System.Drawing.Image)
        Me.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.Dropbox
        Me.btnInventory.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'LogoPanel
        '
        Me.LogoPanel.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPanel.Controls.Add(Me.ShapeContainer1)
        Me.LogoPanel.Controls.Add(Me.imgHome)
        Me.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoPanel.Location = New System.Drawing.Point(0, 0)
        Me.LogoPanel.Name = "LogoPanel"
        Me.LogoPanel.Size = New System.Drawing.Size(220, 162)
        Me.LogoPanel.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(220, 162)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.logo
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.Location = New System.Drawing.Point(12, 5)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(196, 153)
        '
        'imgHome
        '
        Me.imgHome.Image = Global.MDLF_POS.My.Resources.Resources.logo
        Me.imgHome.Location = New System.Drawing.Point(234, 12)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(140, 102)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 0
        Me.imgHome.TabStop = False
        '
        'TitleBarPanel
        '
        Me.TitleBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.TitleBarPanel.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.TitleBarPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TitleBarPanel.Controls.Add(Me.btnMinimize)
        Me.TitleBarPanel.Controls.Add(Me.btnMaximize)
        Me.TitleBarPanel.Controls.Add(Me.btnExit)
        Me.TitleBarPanel.Controls.Add(Me.labelHome)
        Me.TitleBarPanel.Controls.Add(Me.IconCurrentFormIcon)
        Me.TitleBarPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBarPanel.Location = New System.Drawing.Point(220, 0)
        Me.TitleBarPanel.Name = "TitleBarPanel"
        Me.TitleBarPanel.Size = New System.Drawing.Size(1130, 50)
        Me.TitleBarPanel.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BackgroundImage = CType(resources.GetObject("btnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Location = New System.Drawing.Point(1040, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(25, 22)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximize.BackgroundImage = CType(resources.GetObject("btnMaximize.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.Location = New System.Drawing.Point(1067, 12)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(25, 22)
        Me.btnMaximize.TabIndex = 2
        Me.btnMaximize.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(1093, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(25, 22)
        Me.btnExit.TabIndex = 2
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'labelHome
        '
        Me.labelHome.AutoSize = True
        Me.labelHome.BackColor = System.Drawing.Color.Transparent
        Me.labelHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.labelHome.Location = New System.Drawing.Point(75, 19)
        Me.labelHome.Name = "labelHome"
        Me.labelHome.Size = New System.Drawing.Size(62, 24)
        Me.labelHome.TabIndex = 1
        Me.labelHome.Text = "Home"
        '
        'IconCurrentFormIcon
        '
        Me.IconCurrentFormIcon.BackColor = System.Drawing.Color.Transparent
        Me.IconCurrentFormIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconCurrentFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentFormIcon.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.IconCurrentFormIcon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentFormIcon.IconSize = 37
        Me.IconCurrentFormIcon.Location = New System.Drawing.Point(26, 11)
        Me.IconCurrentFormIcon.Name = "IconCurrentFormIcon"
        Me.IconCurrentFormIcon.Size = New System.Drawing.Size(43, 37)
        Me.IconCurrentFormIcon.TabIndex = 0
        Me.IconCurrentFormIcon.TabStop = False
        '
        'panelDesktop
        '
        Me.panelDesktop.AutoSize = True
        Me.panelDesktop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelDesktop.BackColor = System.Drawing.Color.White
        Me.panelDesktop.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.bganw
        Me.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelDesktop.Controls.Add(Me.Label1)
        Me.panelDesktop.Controls.Add(Me.PictureBox1)
        Me.panelDesktop.Controls.Add(Me.ShapeContainer2)
        Me.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktop.Location = New System.Drawing.Point(220, 50)
        Me.panelDesktop.Name = "panelDesktop"
        Me.panelDesktop.Size = New System.Drawing.Size(1130, 676)
        Me.panelDesktop.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(483, 472)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "POINT OF SALE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.newa
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-460, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 258)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1130, 676)
        Me.ShapeContainer2.TabIndex = 2
        Me.ShapeContainer2.TabStop = False
        '
        'OvalShape2
        '
        Me.OvalShape2.BackgroundImage = Global.MDLF_POS.My.Resources.Resources.logo
        Me.OvalShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape2.Location = New System.Drawing.Point(263, 24)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(585, 546)
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
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleBarPanel.ResumeLayout(False)
        Me.TitleBarPanel.PerformLayout()
        CType(Me.IconCurrentFormIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDesktop.ResumeLayout(False)
        Me.panelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnMaximize As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
End Class
