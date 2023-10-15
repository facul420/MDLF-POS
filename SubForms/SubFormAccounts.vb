﻿Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data

Public Class SubFormAccounts

    Private Sub SubFormAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatabase()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As FileDialog = New OpenFileDialog()

        Try
            'If ofd.ShowDialog() = DialogResult.OK Then
            '    imgpath = ofd.FileName
            '    IdPicBoxAcc.ImageLocation = imgpath
            'End If
            'ofd.Filter = "Image File(*.jpg;*.png;*.gif;*.jpeg)|*.jpg*.png*.gif*.jpeg"
            'IdPicBoxAcc.SizeMode = PictureBoxSizeMode.StretchImage

            ofd.ShowDialog()
            ofd.Filter = "Image File(*.jpg;*.png;*.gif;*.jpeg)|*.jpg*.png*.gif*.jpeg"
            IdPicBoxAcc.SizeMode = PictureBoxSizeMode.StretchImage
            IdPicBoxAcc.Image = Image.FromFile(ofd.FileName)



        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub AccShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles AccShowPass.CheckedChanged
        If AccShowPass.Checked = True Then
            txtPassAcc.UseSystemPasswordChar = False
        Else
            txtPassAcc.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        autoGeneratedCode()
    End Sub

    Private Sub AccountsDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGrid.CellClick

        Try
            Connect()
            query = "SELECT * FROM tbl_accounts WHERE Acc_Id=@Id"

            With command
                .CommandText = query
                .Connection = conn
                .Parameters.Clear()
                .Parameters.Add("@Id", MySqlDbType.Int32).Value = AccountsDataGrid.Rows(e.RowIndex).Cells(0).Value.ToString
            End With

            Dim table As New DataTable()
            Dim da As New MySqlDataAdapter(command)

            da.Fill(table)

            ShowImage()
            reader = command.ExecuteReader
            reader.Read()
            lbID.Text = reader.GetString("Acc_Id")
            txtNameAcc.Text = reader.GetString("Acc_Name")
            cmbPosAcc.Text = reader.GetString("Acc_Position")
            txtUserAcc.Text = reader.GetString("Acc_Username")
            txtPassAcc.Text = reader.GetString("Acc_Password")
            txtDate.Text = reader.GetString("Acc_DateofEmployment")

            AccShowPass.Checked = True
            btnAddAcc.Enabled = False
        Catch ex As Exception
            MsgBox("Header Sorted", MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        lbID.Text = txtID.Text.Trim()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFunction()
        btnAddAcc.Enabled = True
    End Sub

#Region "-----Functions-----"
    Private Sub autoGeneratedCode()
        Dim x As String
        Dim rand As Random = New Random()

        For y As Integer = 1 To 5
            x += Convert.ToString(rand.Next(0, 9))
        Next

        txtID.Text = x
        If txtID.Text = x Then
            x = Nothing
        End If

    End Sub

    Sub ShowImage()
        conn.Close()
        Dim table As New DataTable()
        Dim da As New MySqlDataAdapter(command)

        da.Fill(table)
        'If table.Rows.Count() <= 0 Then
        '    MessageBox.Show("No image available", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtIdSearch.Focus()
        'Else

        'End If
        arrimage = table.Rows(0)(6)
        Dim ms As New MemoryStream(arrimage)
        IdPicBoxAcc.Image = Image.FromStream(ms)
        IdPicBoxAcc.SizeMode = PictureBoxSizeMode.StretchImage
        conn.Open()

    End Sub

    Sub ClearFunction()
        txtNameAcc.Clear()
        cmbPosAcc.Text = "Cashier"
        txtUserAcc.Clear()
        txtPassAcc.Clear()
        txtConPassAcc.Clear()
        txtDate.Clear()
        IdPicBoxAcc.Image = Nothing
        txtIdSearch.Clear()
        txtID.Clear()
        lbID.Text = "#####"
        txtNameAcc.Focus()

    End Sub

    Sub LoadDatabase()

        Connect()
        query = "SELECT * FROM tbl_accounts"
        With command
            .CommandText = query
            .Connection = conn
        End With
        reader = command.ExecuteReader
        AccountsDataGrid.Rows.Clear()
        While reader.Read
            AccountsDataGrid.Rows.Add(reader.GetString("Acc_Id"), reader.GetString("Acc_Name"),
                                                           reader.GetString("Acc_Position"),
                                                           reader.GetString("Acc_Username"),
                                                           reader.GetString("Acc_Password"),
                                                           reader.GetString("Acc_DateofEmployment"))

        End While

    End Sub


#End Region

#Region "----Add-Update-Delete-Search---"

    Private Sub btnAddAcc_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        Dim ms As New MemoryStream


        Try

            If txtNameAcc.Text.Trim() = "" OrElse cmbPosAcc.Text.Trim() = "" OrElse txtPassAcc.Text.Trim() = "" OrElse txtPassAcc.Text.Trim() = "" OrElse txtDate.Text.Trim() = "" OrElse lbID.Text.Trim() = "#####" OrElse lbID.Text.Trim() = "" Then
                MessageBox.Show("Enter missing data", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNameAcc.Focus()

            ElseIf IdPicBoxAcc.Image Is Nothing Then

                MsgBox("Please enter an ID PIC", MsgBoxStyle.Exclamation)

            ElseIf txtPassAcc.Text.Trim() <> txtConPassAcc.Text.Trim() Then

                MsgBox("Password does not match", MsgBoxStyle.Exclamation)

            Else

                IdPicBoxAcc.Image.Save(ms, IdPicBoxAcc.Image.RawFormat)


                Connect()
                query = "INSERT INTO tbl_accounts(
                                             Acc_Id,
                                             Acc_Name, 
                                             Acc_Position, 
                                             Acc_Username, 
                                             Acc_Password, 
                                             Acc_DateofEmployment,
                                             Acc_IdPic
                                            ) 
                                            VALUES (
                                                    @Id,
                                                    @name,
                                                    @position,
                                                    @username,
                                                    @password,
                                                    @date,
                                                    @pic
                                                    )"
                With command
                    .CommandText = query
                    .Connection = conn
                    With .Parameters
                        .Clear()
                        .Add("@Id", MySqlDbType.VarChar).Value = lbID.Text.Trim()
                        .Add("@name", MySqlDbType.VarChar).Value = txtNameAcc.Text.Trim()
                        .Add("@position", MySqlDbType.VarChar).Value = cmbPosAcc.Text.Trim()
                        .Add("@username", MySqlDbType.VarChar).Value = txtUserAcc.Text.Trim()
                        .Add("@password", MySqlDbType.VarChar).Value = txtPassAcc.Text.Trim()
                        .Add("@date", MySqlDbType.VarChar).Value = txtDate.Text.Trim()
                        .Add("@pic", MySqlDbType.LongBlob).Value = ms.ToArray()
                    End With
                    .ExecuteNonQuery()
                End With
                MsgBox("Product Saved", MsgBoxStyle.Information)
                LoadDatabase()
                ClearFunction()
            End If

        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ms As New MemoryStream


        Try

            If lbID.Text.Trim() = "" Then
                MessageBox.Show("Please input an ID number", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdSearch.Focus()
            Else
                IdPicBoxAcc.Image.Save(ms, IdPicBoxAcc.Image.RawFormat)
                Connect()

                query = "UPDATE tbl_accounts SET Acc_Id=@Id,
                                            Acc_Name=@name, 
                                            Acc_Position=@position,
                                            Acc_Username=@username,
                                            Acc_Password=@password,
                                            Acc_DateofEmployment=@date, 
                                            Acc_IdPic=@pic WHERE Acc_Id=@Id"
                With command
                    .CommandText = query
                    .Connection = conn
                    With .Parameters
                        .Clear()
                        .Add("@Id", MySqlDbType.VarChar).Value = lbID.Text.Trim()
                        .Add("@name", MySqlDbType.VarChar).Value = txtNameAcc.Text.Trim()
                        .Add("@position", MySqlDbType.VarChar).Value = cmbPosAcc.Text.Trim()
                        .Add("@username", MySqlDbType.VarChar).Value = txtUserAcc.Text.Trim()
                        .Add("@password", MySqlDbType.VarChar).Value = txtPassAcc.Text.Trim()
                        .Add("@date", MySqlDbType.VarChar).Value = txtDate.Text.Trim()
                        .Add("@pic", MySqlDbType.LongBlob).Value = ms.ToArray()
                    End With
                    .ExecuteNonQuery()

                End With
                MsgBox("Account Updated", MsgBoxStyle.Information)


                LoadDatabase()
                ClearFunction()
                btnAddAcc.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Please enter the right info" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtDeleteAcc_Click(sender As Object, e As EventArgs) Handles txtDeleteAcc.Click
        Try
            If lbID.Text.Trim() = "#####" Then
                MessageBox.Show("No Account Selected", "No account", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdSearch.Focus()
            Else
                Connect()
                query = "DELETE FROM tbl_accounts WHERE Acc_Id=@Id"
                With command
                    .CommandText = query
                    .Connection = conn
                    With .Parameters
                        .Clear()
                        .Add("@Id", MySqlDbType.Int32).Value = lbID.Text.Trim()
                    End With
                    .ExecuteNonQuery()
                End With
                ClearFunction()
                LoadDatabase()
                btnAddAcc.Enabled = True
                MessageBox.Show("Account Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If txtIdSearch.Text.Trim() = "" Then
                MessageBox.Show("Please input an ID number", "No ID", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtIdSearch.Focus()
            Else
                Connect()
                query = "SELECT * FROM tbl_accounts WHERE Acc_Id=@Id"

                With command
                    .CommandText = query
                    .Connection = conn
                    .Parameters.Clear()
                    .Parameters.Add("@Id", MySqlDbType.Int32).Value = txtIdSearch.Text.Trim()
                End With

                Dim table As New DataTable()
                Dim da As New MySqlDataAdapter(command)

                da.Fill(table)

                If table.Rows.Count() <= 0 Then
                    MessageBox.Show("Account Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtIdSearch.Focus()

                Else
                    ShowImage()
                    reader = command.ExecuteReader
                    reader.Read()
                    lbID.Text = reader.GetString("Acc_Id")
                    txtNameAcc.Text = reader.GetString("Acc_Name")
                    cmbPosAcc.Text = reader.GetString("Acc_Position")
                    txtUserAcc.Text = reader.GetString("Acc_Username")
                    txtPassAcc.Text = reader.GetString("Acc_Password")
                    txtDate.Text = reader.GetString("Acc_DateofEmployment")

                    AccShowPass.Checked = True
                End If

                LoadDatabase()
                txtIdSearch.Clear()
                btnAddAcc.Enabled = False

            End If
        Catch ex As Exception
            MsgBox("Please enter the right data" & ControlChars.NewLine & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AccountsDataGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AccountsDataGrid.CellContentClick

    End Sub



#End Region
End Class