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
        USDisplayData()
        GSDisplayData()
        TSDiscountTextBox.Text = computeGSTotalDiscountRows()
        TSItemsTextBox.Text = computeGSTotalItemsRows()
        TSAmountTextBox.Text = computeGSTotalAmountRows()
        TSCashRecievedTextBox.Text = computeGSTotalCashReceived()
        TSUnitAmountTextBox.Text = computeUSTotalAmountRows()
        TSUnitDiscountTextBox.Text = computeUSTotalDiscountRows()
        USTotalUnitTextBox.Text = computeUSTotalItemsRows()
    End Sub

    Private Sub GSDisplayData()
        DGGeneralSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_sales`"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGGeneralSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Total_Items"), reader.GetString("Total_Discount"), reader.GetString("Cash"), reader.GetString("Total_Amount"))
        End While
    End Sub

    Private Sub USDisplayData()
        DGUnitSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_ussales`"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGUnitSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Product_Code"), reader.GetString("Product_Name"), reader.GetString("Unit_Sold"), reader.GetString("Total_Discount"), reader.GetString("Total_Amount"), reader.GetString("Sales_Type"))
        End While
    End Sub

    Private Sub searchData()
        DGGeneralSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_sales` WHERE `Transaction_Number` LIKE '%" & SearchTextBox.Text & "%' OR `Transaction_Date` LIKE '%" & SearchTextBox.Text & "%' "
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGGeneralSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Total_Items"), reader.GetString("Total_Discount"), reader.GetString("Cash"), reader.GetString("Total_Amount"))
        End While
    End Sub

    Private Function computeGSTotalAmountRows()
        Dim totalamount As New Double
        For i As Integer = 0 To DGGeneralSales.RowCount - 1
            totalamount += DGGeneralSales.Rows(i).Cells(5).Value
        Next
        Return totalamount
    End Function

    Private Function computeGSTotalItemsRows()
        Dim totalItems As New Integer
        For i As Integer = 0 To DGGeneralSales.RowCount - 1
            totalItems += DGGeneralSales.Rows(i).Cells(2).Value
        Next
        Return totalItems
    End Function

    Private Function computeGSTotalDiscountRows()
        Dim totalDiscount As New Double
        For i As Integer = 0 To DGGeneralSales.RowCount - 1
            totalDiscount += DGGeneralSales.Rows(i).Cells(3).Value
        Next
        Return totalDiscount
    End Function
    Private Function computeGSTotalCashReceived()
        Dim totalCashReceived As New Double
        For i As Integer = 0 To DGGeneralSales.RowCount - 1
            totalCashReceived += DGGeneralSales.Rows(i).Cells(4).Value
        Next
        Return totalCashReceived
    End Function

    Private Function computeUSTotalDiscountRows()
        Dim totalDiscount As New Double
        For i As Integer = 0 To DGUnitSales.RowCount - 1
            totalDiscount += DGUnitSales.Rows(i).Cells(5).Value
        Next
        Return totalDiscount
    End Function

    Private Function computeUSTotalAmountRows()
        Dim totalAmount As New Double
        For i As Integer = 0 To DGUnitSales.RowCount - 1
            totalAmount += DGUnitSales.Rows(i).Cells(6).Value
        Next
        Return totalAmount
    End Function

    Private Function computeUSTotalItemsRows()
        Dim totalItems As New Integer
        For i As Integer = 0 To DGUnitSales.RowCount - 1
            totalItems += DGUnitSales.Rows(i).Cells(4).Value
        Next
        Return totalItems
    End Function

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        searchData()
        TSDiscountTextBox.Text = String.Format("{0:F2}", computeGSTotalDiscountRows())
        TSItemsTextBox.Text = computeGSTotalItemsRows()
        TSCashRecievedTextBox.Text = String.Format("{0:F2}", computeGSTotalCashReceived())
        TSAmountTextBox.Text = String.Format("{0:F2}", computeGSTotalAmountRows())
    End Sub

    Private Sub ProductCodeSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductCodeSearchTextBox.TextChanged
        DGUnitSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_ussales` WHERE `Product_Code` LIKE '%" & ProductCodeSearchTextBox.Text & "%' AND `Transaction_Number` LIKE '%" & TransNumSearchTextBox.Text & "%'"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGUnitSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Product_Code"), reader.GetString("Product_Name"), reader.GetString("Unit_Sold"), reader.GetString("Total_Discount"), reader.GetString("Total_Amount"), reader.GetString("Sales_Type"))
        End While
        TSUnitAmountTextBox.Text = computeUSTotalAmountRows()
        TSUnitDiscountTextBox.Text = computeUSTotalDiscountRows()
        USTotalUnitTextBox.Text = computeUSTotalItemsRows()
    End Sub

    Private Sub TransNumSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles TransNumSearchTextBox.TextChanged
        DGUnitSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_ussales` WHERE `Transaction_Number` LIKE '%" & TransNumSearchTextBox.Text & "%' AND `Product_Code` LIKE '%" & ProductCodeSearchTextBox.Text & "%' AND `Transaction_Date` LIKE '%" & TransDateSearchTextBox.Text & "%'"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGUnitSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Product_Code"), reader.GetString("Product_Name"), reader.GetString("Unit_Sold"), reader.GetString("Total_Discount"), reader.GetString("Total_Amount"), reader.GetString("Sales_Type"))
        End While
        TSUnitAmountTextBox.Text = computeUSTotalAmountRows()
        TSUnitDiscountTextBox.Text = computeUSTotalDiscountRows()
        USTotalUnitTextBox.Text = computeUSTotalItemsRows()
    End Sub

    Private Sub TransDateSearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles TransDateSearchTextBox.TextChanged
        DGUnitSales.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_ussales` WHERE `Transaction_Date` LIKE '%" & TransDateSearchTextBox.Text & "%' AND `Product_Code` LIKE '%" & ProductCodeSearchTextBox.Text & "%' AND `Transaction_Number` LIKE '%" & TransNumSearchTextBox.Text & "%'"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        While reader.Read
            DGUnitSales.Rows.Add(reader.GetString("Transaction_Number"), reader.GetString("Transaction_Date"), reader.GetString("Product_Code"), reader.GetString("Product_Name"), reader.GetString("Unit_Sold"), reader.GetString("Total_Discount"), reader.GetString("Total_Amount"), reader.GetString("Sales_Type"))
        End While
        TSUnitAmountTextBox.Text = computeUSTotalAmountRows()
        TSUnitDiscountTextBox.Text = computeUSTotalDiscountRows()
        USTotalUnitTextBox.Text = computeUSTotalItemsRows()
    End Sub
End Class