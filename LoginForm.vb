Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Data
Public Class LoginForm



#Region "======GUI-Codes====="
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub pnlTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

#End Region



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'If txtUserName.Text = "" Or txtPassword.Text = "" Then
        '    MsgBox("Please enter username/password.", vbExclamation)
        'ElseIf txtUserName.Text = "admin123" And txtPassword.Text = "pass123" And cmbCredentials.Text = "Admin" Then
        '    Me.Visible = False
        '    DashboardForm.Visible = True
        '    ResetLogin()
        '    DashboardForm.LogoPanel.Focus()
        'Else
        '    MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
        Try
            If txtUserName.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" OrElse cmbCredentials.Text.Trim() = "" Then
                MessageBox.Show("Missing Credentials", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserName.Focus()
            Else
                Connect()
                query = "SELECT * FROM tbl_accounts WHERE Acc_Username=@user and Acc_Password=@pass and Acc_Position=@position"

                With command
                    .CommandText = query
                    .Connection = conn
                    .Parameters.Clear()
                    .Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUserName.Text.Trim()
                    .Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text.Trim()
                    .Parameters.Add("@position", MySqlDbType.VarChar).Value = cmbCredentials.Text.Trim()
                End With
                reader = command.ExecuteReader

                If reader.Read() Then
                    CurrentID = reader.GetString("Acc_Id")
                    CurrentName = reader.GetString("Acc_Name")
                    CurrentCredentials = reader.GetString("Acc_Position")
                    CurrentUsername = reader.GetString("Acc_Username")
                    POSForm.posCashierID.Text = CurrentID
                    POSForm.posCashierName.Text = CurrentName
                    Me.Visible = False
                    DashboardForm.Visible = True
                    ResetLogin()
                    DashboardForm.LogoPanel.Focus()



                    MessageBox.Show("You are Log in As " & CurrentCredentials&, "Welcome " & CurrentUsername&, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Wrong Credentials", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

                'Dim table As New DataTable()
                'Dim da As New MySqlDataAdapter(command)

                'da.Fill(table)

                'If table.Rows.Count() <= 0 Then
                '    MessageBox.Show("Account Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    txtIdSearch.Focus()

                'Else
                '    ShowImage()
                '    reader = command.ExecuteReader
                '    reader.Read()
                '    lbID.Text = reader.GetString("Acc_Id")
                '    txtNameAcc.Text = reader.GetString("Acc_Name")
                '    cmbPosAcc.Text = reader.GetString("Acc_Position")
                '    txtUserAcc.Text = reader.GetString("Acc_Username")
                '    txtPassAcc.Text = reader.GetString("Acc_Password")
                '    txtDate.Text = reader.GetString("Acc_DateofEmployment")

                '    AccShowPass.Checked = True
                'End If

                'LoadDatabase()
                'txtIdSearch.Clear()
                'btnAddAcc.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


    Sub ResetLogin()
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub checkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles checkShowPass.CheckedChanged
        If checkShowPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class