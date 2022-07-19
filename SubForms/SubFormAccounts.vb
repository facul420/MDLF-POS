Imports MySql.Data.MySqlClient
Imports System.IO
Public Class SubFormAccounts

    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String


    Public Sub Connect()
        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost; userid=root; password=; database=fp_db_pos"
            }
        conn.Open()
    End Sub


    Private Sub btnBrowseId_Click(sender As Object, e As EventArgs) Handles btnBrowseId.Click
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

    Private Sub btnAddAcc_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        Dim ms As New MemoryStream


        Try

            If txtNameAcc.Text.Trim() = "" OrElse cmbPosAcc.Text.Trim() = "" Then
                MessageBox.Show("Please enter a product code", "Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNameAcc.Focus()


            Else

                IdPicBoxAcc.Image.Save(ms, IdPicBoxAcc.Image.RawFormat)


                Connect()
                query = "INSERT INTO tbl_accounts(
                                             Acc_Name, 
                                             Acc_Position, 
                                             Acc_Username, 
                                             Acc_Password, 
                                             Acc_DateofEmployment,
                                             Acc_IdPic
                                            ) 
                                            VALUES (
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

    Sub ClearFunction()
        txtNameAcc.Clear()
        cmbPosAcc.Text = "Cashier"
        txtUserAcc.Clear()
        txtPassAcc.Clear()
        txtConPassAcc.Clear()
        txtDate.Clear()
        IdPicBoxAcc.Image = Nothing


        txtNameAcc.Focus()

    End Sub

    Private Sub AccShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles AccShowPass.CheckedChanged
        If AccShowPass.Checked = True Then
            txtPassAcc.UseSystemPasswordChar = False
        Else
            txtPassAcc.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub DateButton_Click(sender As Object, e As EventArgs) Handles DateButton.Click
        DateLabel.Text = txtDate.Text.ToString()



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

    Private Sub SubFormAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatabase()
    End Sub

End Class