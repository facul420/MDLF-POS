Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data
Module DatabaseModule
    Public conn As MySqlConnection
    Public command As New MySqlCommand
    Public reader As MySqlDataReader
    Public query As String
    Public da As New MySqlDataAdapter
    Public result As Integer
    Public imgpath As String
    Public arrimage() As Byte
    Public sql As String
    Public dset As New DataSet
    Public CurrentCredentials As String
    Public CurrentUsername As String
    Public CurrentName As String
    Public CurrentID As String

    Public inv As Boolean = False
    Public acc As Boolean = False
    Public sales As Boolean = False

    Public Sub Connect()
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
