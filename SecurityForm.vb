Public Class SecurityForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter username/password.", vbExclamation)
        ElseIf txtUserName.Text = "admin123" And txtPassword.Text = "pass123" Then
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
            POSForm.Visible = False
            Me.Close()
            DashboardForm.Visible = True
            System.Windows.Forms.Cursor.Show()
        Else
            MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class