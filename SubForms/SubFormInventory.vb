Imports MySql.Data.MySqlClient


Public Class SubFormInventory
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader

    'Functions
    Sub connect()
        conn = New MySqlConnection With {
         .ConnectionString = "server=localhost; userid=root; password=; database=fp_db_pos"
        }
        conn.Open()
    End Sub
    Private Sub addingItems()
        connect()

        If ProductCodeTextBox.Text = "" Or ProductNameTextBox.Text = "" Or ProductPriceTextBox.Text = "" Or SpecialDiscountTextBox.Text = "" Or ProductTypeTextBox.Text = "" Or AdditionalItemsTextBox.Text = "" Then
            MsgBox("Lacking information", MsgBoxStyle.Exclamation)
        Else
            query = "INSERT INTO `tbl_prodinventoryinfo`(`Product_Code`, `Product_Name`, `Product_Price`, `Product_Type`, `Special_Discount`, `Unit_In_Stock`) VALUE ('" & ProductCodeTextBox.Text & "', @productname, @productprice, @producttype, @specialdiscount, @unitinstock)"
            command.CommandText = query
            command.Connection = conn
            command.Parameters.Clear()
            command.Parameters.Add("@productname", MySqlDbType.VarChar).Value = ProductNameTextBox.Text.Trim
            command.Parameters.Add("@productprice", MySqlDbType.Double).Value = ProductPriceTextBox.Text
            command.Parameters.Add("@producttype", MySqlDbType.VarChar).Value = ProductTypeTextBox.Text.Trim
            command.Parameters.Add("@specialdiscount", MySqlDbType.Double).Value = SpecialDiscountTextBox.Text.Trim
            command.Parameters.Add("@unitinstock", MySqlDbType.Int64).Value = AdditionalItemsTextBox.Text.Trim
            command.ExecuteNonQuery()
            ProductCodeTextBox.Clear()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            SpecialDiscountTextBox.Clear()
            ProductTypeTextBox.Clear()
            UnitInStockTextBox.Clear()
            AdditionalItemsTextBox.Clear()
            MsgBox("Added Successfully", MsgBoxStyle.Information)
            displayData()
        End If
    End Sub

    Private Sub update()

        connect()
        If AdditionalItemsTextBox.Text = "" Then
            query = "UPDATE `tbl_prodinventoryinfo` SET `Product_Name`= '" & ProductNameTextBox.Text & "' ,`Product_Price`= '" & ProductPriceTextBox.Text & "',`Product_Type`= '" & ProductTypeTextBox.Text & "',`Special_Discount`= '" & SpecialDiscountTextBox.Text & "',`Unit_In_Stock`= '" & UnitInStockTextBox.Text & "' WHERE `Product_Code`= @productcode"
        Else
             query = "UPDATE `tbl_prodinventoryinfo` SET `Product_Name`= '" & ProductNameTextBox.Text & "' ,`Product_Price`= '" & ProductPriceTextBox.Text & "',`Product_Type`= '" & ProductTypeTextBox.Text & "',`Special_Discount`= '" & SpecialDiscountTextBox.Text & "',`Unit_In_Stock`= '" & unitinstockadd(UnitInStockTextBox, AdditionalItemsTextBox) & "' WHERE `Product_Code`= @productcode"
        End If

        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@productcode", MySqlDbType.Int64).Value = ProductCodeTextBox.Text.Trim
        command.ExecuteNonQuery()

        ProductCodeTextBox.Clear()
        ProductNameTextBox.Clear()
        ProductPriceTextBox.Clear()
        SpecialDiscountTextBox.Clear()
        ProductTypeTextBox.Clear()
        UnitInStockTextBox.Clear()
        AdditionalItemsTextBox.Clear()
        MsgBox("Updated Successfully", MsgBoxStyle.Information)
        SaveButton.Enabled = False
        DeleteButton.Enabled = False
        AddItemButton.Enabled = True
        GenerateButton.Enabled = True
        displayData()
    End Sub

    Private Sub delete()
        connect()
        query = "DELETE FROM `tbl_prodinventoryinfo` WHERE `Product_Code` = @productcode"
        Dim choice As MsgBoxResult = MessageBox.Show("Would you like to continue?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes Then
            command.CommandText = query
            command.Connection = conn
            command.Parameters.Clear()
            command.Parameters.Add("@productcode", MySqlDbType.Int64).Value = ProductCodeTextBox.Text.Trim
            command.ExecuteNonQuery()

            ProductCodeTextBox.Clear()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            SpecialDiscountTextBox.Clear()
            ProductTypeTextBox.Clear()
            UnitInStockTextBox.Clear()
            AdditionalItemsTextBox.Clear()
            MsgBox("Deleted Successfully", MsgBoxStyle.Information)
            AddItemButton.Enabled = True
            GenerateButton.Enabled = True
            DeleteButton.Enabled = False
            SaveButton.Enabled = False
            displayData()
        End If

    End Sub
    Private Sub displayData()
        DGInventory.Rows.Clear()
        connect()
        query = "SELECT * FROM `tbl_prodinventoryinfo`"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        reader = command.ExecuteReader
        While reader.Read
            DGInventory.Rows.Add(reader.GetString("Product_Code"), reader.GetString("Product_Type"), reader.GetString("Product_Name"), reader.GetString("Product_Price"), reader.GetString("Special_Discount"), reader.GetString("Unit_In_Stock"))
        End While
    End Sub
    Private Sub autoGeneratedCode()
        Dim x As String
        Dim rand As Random = New Random()

        For y As Integer = 1 To 9
            x += Convert.ToString(rand.Next(0, 9))

        Next
        ProductCodeTextBox.Text = x
        If ProductCodeTextBox.Text = x Then
            x = Nothing
        End If
        ProductTypeTextBox.Focus()
    End Sub

    Private Function unitinstockadd(unitinstock As TextBox, additem As TextBox)

        Dim unitinstock1 As Integer
            Dim additem1 As Integer
            Dim totalstock As Integer
            unitinstock1 = Integer.Parse(unitinstock.Text)
            additem1 = Integer.Parse(additem.Text)
            totalstock = unitinstock1 + additem1
        Return totalstock

    End Function
    Private Sub search()
        connect()
        query = "SELECT * FROM `tbl_prodinventoryinfo` WHERE `Product_Code` LIKE '%" & SearchCodeTextBox.Text & "%'"
        command.CommandText = query
        command.Connection = conn
        reader = command.ExecuteReader
        DGInventory.Rows.Clear()

        While reader.Read
            DGInventory.Rows.Add(reader.GetString("Product_Code"), reader.GetString("Product_Type"), reader.GetString("Product_Name"), reader.GetString("Product_Price"), reader.GetString("Special_Discount"), reader.GetString("Unit_In_Stock"))
        End While
    End Sub
    Private Sub DGInventory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGInventory.CellClick
        AddItemButton.Enabled = False
        GenerateButton.Enabled = False
        DeleteButton.Enabled = True
        SaveButton.Enabled = True
        ClearButton.Enabled = True
        ProductCodeTextBox.Clear()
        Dim x As Integer
        x = DGInventory.CurrentRow.Index
        ProductCodeTextBox.Text = DGInventory.Item(0, x).Value.ToString
        ProductTypeTextBox.Text = DGInventory.Item(1, x).Value.ToString
        ProductNameTextBox.Text = DGInventory.Item(2, x).Value.ToString
        ProductPriceTextBox.Text = DGInventory.Item(3, x).Value.ToString
        SpecialDiscountTextBox.Text = DGInventory.Item(4, x).Value.ToString
        UnitInStockTextBox.Text = DGInventory.Item(5, x).Value
    End Sub
    Private Sub AddItemButton_Click(sender As Object, e As EventArgs) Handles AddItemButton.Click
        addingItems()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        autoGeneratedCode()
    End Sub

    Private Sub SubFormInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayData()
    End Sub

    Private Sub ProdCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchCodeTextBox.TextChanged

        search()
  
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        update()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        delete()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ProductCodeTextBox.Clear()
        ProductNameTextBox.Clear()
        ProductPriceTextBox.Clear()
        SpecialDiscountTextBox.Clear()
        ProductTypeTextBox.Clear()
        UnitInStockTextBox.Clear()
        AdditionalItemsTextBox.Clear()
        GenerateButton.Enabled = True
        AddItemButton.Enabled = True
        SaveButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub



    Private Sub ProductPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductPriceTextBox.TextChanged
        If Not IsNumeric(ProductPriceTextBox.Text) Then
            ProductPriceTextBox.Clear()
        End If
    End Sub

    Private Sub SpecialDiscountTextBox_TextChanged(sender As Object, e As EventArgs) Handles SpecialDiscountTextBox.TextChanged
        If Not IsNumeric(SpecialDiscountTextBox.Text) Then
            SpecialDiscountTextBox.Clear()
        End If
    End Sub

    Private Sub AdditionalItemsTextBox_TextChanged(sender As Object, e As EventArgs) Handles AdditionalItemsTextBox.TextChanged
        If Not IsNumeric(AdditionalItemsTextBox.Text) Then
            AdditionalItemsTextBox.Clear()
        End If
    End Sub
End Class