Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.OleDb

Public Class SubFormSales
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim sda As New MySqlDataAdapter
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource
    Dim query As String

    Sub connect()
        conn = New MySqlConnection With {
         .ConnectionString = "server=localhost; userid=root; password=; database=fp_db_pos"
        }
        conn.Open()
    End Sub
    Private Sub SubFormSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchData()
        TSDiscountTextBox.Text = computeTotalDiscountRows()
        TSItemsTextBox.Text = computeTotalItemsRows()
        TSAmountTextBox.Text = computeTotalAmountRows()
    End Sub
    Private Sub searchData()
        connect()
        query = "SELECT * FROM `tbl_sales` WHERE `Transaction_Number` LIKE '%" & SearchTextBox.Text & "%' OR `Transaction_Date` LIKE '%" & SearchTextBox.Text & "%' OR `Total_Items` LIKE '%" & SearchTextBox.Text & "%' OR `Total_Discount` LIKE '%" & SearchTextBox.Text & "%' OR `Total_Amount` LIKE '%" & SearchTextBox.Text & "%' "
        command.CommandText = query
        command.Connection = conn
        sda.SelectCommand = command
        Using dt As New DataTable
            sda.Fill(dt)
            DGSales.DataSource = dt
        End Using
    End Sub

    Private Function computeTotalAmountRows()
        Dim totalamount As New Double
        For i As Integer = 0 To DGSales.RowCount - 1
            totalamount += DGSales.Rows(i).Cells(4).Value
        Next
        Return totalamount
    End Function

    Private Function computeTotalItemsRows()
        Dim totalItems As New Integer
        For i As Integer = 0 To DGSales.RowCount - 1
            totalItems += DGSales.Rows(i).Cells(2).Value
        Next
        Return totalItems
    End Function

    Private Function computeTotalDiscountRows()
        Dim totalDiscount As New Double
        For i As Integer = 0 To DGSales.RowCount - 1
            totalDiscount += DGSales.Rows(i).Cells(3).Value
        Next
        Return totalDiscount
    End Function


    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        searchData()
        TSDiscountTextBox.Text = String.Format("{0:F2}", computeTotalDiscountRows())
        TSItemsTextBox.Text = computeTotalItemsRows()
        TSAmountTextBox.Text = String.Format("{0:F2}", computeTotalAmountRows())
    End Sub


End Class