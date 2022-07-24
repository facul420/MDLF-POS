Imports MySql.Data.MySqlClient

Public Class SecurityForm

    Private Sub deleteTransaction()
        Connect()
        query = "DELETE FROM `tbl_ussales` WHERE `Transaction_Number`= '" & POSForm.TransNoTextBox.Text & "' "
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.ExecuteNonQuery()
    End Sub
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
                    Dim cred As String
                    cred = reader.GetString("Acc_Position")
                    If cred.Equals("Cashier") Then
                        MessageBox.Show("You are not authorized", "NOT AUTHROIZED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        ResetLogin()
                        deleteTransaction()
                        POSForm.ProdCodeTextBox.Clear()
                        POSForm.ProdNameTextBox.Clear()
                        POSForm.ProdPriceTextBox.Text = "0.00"
                        POSForm.QuantityTextBox.Clear()
                        POSForm.CashTextBox.Clear()
                        POSForm.AmountDueTextBox.Text = "0.00"
                        POSForm.TotalAmountTextBox.Text = "0.00"
                        POSForm.Cash2TextBox.Text = "0.00"
                        POSForm.ChangeTextBox.Text = "0.00"
                        POSForm.OptionLabel1.Visible = False
                        POSForm.dgItems.Rows.Clear()
                        Me.Close()
                        POSForm.ProdCodeTextBox.Enabled = True
                        POSForm.ProdCodeTextBox.Focus()
                    End If






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

    Private Sub SecurityForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        System.Windows.Forms.Cursor.Hide()
    End Sub
End Class