Imports MySql.Data.MySqlClient
Module DatabaseModule
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim query As String
    Dim da As New MySqlDataAdapter
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String
    Sub Connect()
        Try
            conn = New MySqlConnection With {
            .ConnectionString = "server=localhost; userid=root; password=; database=fp_db_pos"
            }

            conn.Open()

        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
