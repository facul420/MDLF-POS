Imports MySql.Data.MySqlClient
Public Class POSSecurityForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If txtUserName.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" Then

                MessageBox.Show("Missing Credentials", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUserName.Focus()
            Else
                Connect()
                query = "SELECT * FROM tbl_accounts WHERE Acc_Username=@user and Acc_Password=@pass"

                With command
                    .CommandText = query
                    .Connection = conn
                    .Parameters.Clear()
                    .Parameters.Add("@user", MySqlDbType.VarChar).Value = txtUserName.Text.Trim()
                    .Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text.Trim()
                End With
                reader = command.ExecuteReader

                If reader.Read() Then
                    CurrentID = reader.GetString("Acc_Id")
                    CurrentName = reader.GetString("Acc_Name")
                    CurrentUsername = reader.GetString("Acc_Username")
                    POSForm.posCashierID.Text = CurrentID
                    POSForm.posCashierName.Text = CurrentName
                    ResetLogin()
                    Me.Close()
                    DashboardForm.Close()
                    POSForm.Visible = True
                    Windows.Forms.Cursor.Hide()





                Else
                    MessageBox.Show("Wrong Credentials", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Sub ResetLogin()
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub POSSecurityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Cursor.Show()
    End Sub
End Class