Imports MySql.Data.MySqlClient
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
        Try

            Dim ofd As FileDialog = New OpenFileDialog()

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                IdPicBoxAcc.ImageLocation = imgpath
            End If
            ofd.Filter = "Image File(*.jpg;*.png;*.gif;*.jpeg)|*.jpg*.png*.gif*.jpeg"
            IdPicBoxAcc.SizeMode = PictureBoxSizeMode.StretchImage



            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class