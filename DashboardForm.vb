﻿Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class DashboardForm


    'Fields
    Private currentbtn As IconButton
    Private leftBorderBtn As Panel
    Private currentSubForm As Form

#Region "======Current GUI Dashboard Codes======"
    'Constructor
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

#Region "====== Methods ======"
    'Methods
    Private Sub ActiveButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentbtn = CType(senderBtn, IconButton)
            currentbtn.BackColor = Color.FromArgb(0, 29, 74)
            currentbtn.ForeColor = customcolor
            currentbtn.IconColor = customcolor
            currentbtn.TextAlign = ContentAlignment.MiddleCenter
            currentbtn.ImageAlign = ContentAlignment.MiddleRight
            currentbtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentbtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentFormIcon.IconChar = currentbtn.IconChar
            IconCurrentFormIcon.IconColor = customcolor
        End If
    End Sub
    Private Sub DisableButton()
        If currentbtn IsNot Nothing Then
            currentbtn.BackColor = Color.FromArgb(0, 29, 74)
            currentbtn.ForeColor = Color.Gainsboro
            currentbtn.IconColor = Color.Gainsboro
            currentbtn.TextAlign = ContentAlignment.MiddleLeft
            currentbtn.ImageAlign = ContentAlignment.MiddleLeft
            currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub
#End Region

#Region "====== Button-Clicks-Change ======"
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        inv = True
        ActiveButton(sender, Color.FromArgb(236, 164, 0))
        'InventorySecurityForm.Visible = True
        'AccountsSecurityForm.Visible = False
        'SalesSecurityForm.Visible = False
        'SubFormSecurity.Visible = True
        OpenSubForm(New SubFormInventory)
        sales = False
        acc = False
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        sales = True
        ActiveButton(sender, Color.FromArgb(236, 164, 0))
        'SalesSecurityForm.Visible = True
        'InventorySecurityForm.Visible = False
        'AccountsSecurityForm.Visible = False
        OpenSubForm(New SubFormSales)
        acc = False
        inv = False
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        acc = True
        ActiveButton(sender, Color.FromArgb(236, 164, 0))
        'AccountsSecurityForm.Visible = True
        'SalesSecurityForm.Visible = False
        'InventorySecurityForm.Visible = False
        OpenSubForm(New SubFormAccounts)
        sales = False
        inv = False
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentSubForm IsNot Nothing Then
            currentSubForm.Close()
            sales = False
            acc = False
            inv = False
        End If
        Reset()
    End Sub

#End Region

    Public Sub OpenSubForm(subForm As Form)
        'Open only form
        If currentSubForm IsNot Nothing Then
            currentSubForm.Close()
        End If
        currentSubForm = subForm
        subForm.TopLevel = False
        subForm.FormBorderStyle = FormBorderStyle.None
        subForm.Dock = DockStyle.Fill
        panelDesktop.Controls.Add(subForm)
        panelDesktop.Tag = subForm
        subForm.Show()
        subForm.BringToFront()
        labelHome.Text = subForm.Text()


    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentFormIcon.IconChar = IconChar.Home
        IconCurrentFormIcon.IconColor = Color.Gainsboro
        labelHome.Text = "Home"

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub TitleBarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBarPanel.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    Private Sub DashboardForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable

        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        LoginForm.Visible = True


    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        POSForm.Visible = True

        If currentSubForm IsNot Nothing Then
            currentSubForm.Close()
        End If
        Reset()

    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If CurrentCredentials = "Cashier" Then
            btnAccount.Enabled = False
            btnSales.Enabled = False
            btnInventory.Enabled = False
        End If

    End Sub








#End Region



End Class
