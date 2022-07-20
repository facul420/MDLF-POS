Public Class AccountsSecurityForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter username/password.", vbExclamation)
        ElseIf txtUserName.Text = "admin123" And txtPassword.Text = "pass123" Then
            Me.Close()
            DashboardForm.OpenSubForm(New SubFormAccounts)
        Else
            MessageBox.Show("Wrong Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class