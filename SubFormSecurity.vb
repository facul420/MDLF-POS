Imports MySql.Data.MySqlClient

Public Class SubFormSecurity
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If txtUserName.Text = "" Or txtPassword.Text = "" Then
        '    MsgBox("Please enter username/password.", vbExclamation)
        'ElseIf txtUserName.Text = "admin123" And txtPassword.Text = "pass123" Then
        '    POSForm.ProdCodeTextBox.Clear()
        '    POSForm.ProdNameTextBox.Clear()
        '    POSForm.ProdPriceTextBox.Text = "0.00"
        '    POSForm.QuantityTextBox.Clear()
        '    POSForm.CashTextBox.Clear()
        '    POSForm.AmountDueTextBox.Text = "0.00"
        '    POSForm.TotalAmountTextBox.Text = "0.00"
        '    POSForm.Cash2TextBox.Text = "0.00"
        '    POSForm.ChangeTextBox.Text = "0.00"
        '    POSForm.OptionLabel1.Visible = False
        '    POSForm.dgItems.Rows.Clear()
        '    POSForm.ProdCodeTextBox.Enabled = True
        '    POSForm.ProdCodeTextBox.Focus()
        '    Me.Close()
        'Else
        '    MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
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
                    If inv Then

                        Me.Close()
                        DashboardForm.OpenSubForm(New SubFormInventory)


                    ElseIf acc Then

                        Me.Close()
                        DashboardForm.OpenSubForm(New SubFormAccounts)

                    ElseIf sales Then

                        Me.Close()
                        DashboardForm.OpenSubForm(New SubFormSales)


                    End If

                Else

                    MessageBox.Show("Wrong Credentials", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                ResetLogin()
            End If
        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Function btnInventory_Click() As Boolean
        Throw New NotImplementedException()
    End Function

    Sub ResetLogin()
        txtPassword.Clear()
        txtUserName.Clear()
    End Sub

    Private Sub SubFormSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class