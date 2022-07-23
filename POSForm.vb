Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing


Public Class POSForm
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim query As String

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub changeLongPaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = dgItems.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 500
    End Sub

    Private Sub print()
        changeLongPaper()
        PPD.Document = PD
        PPD.ShowDialog()

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f12 As New Font("Calibri", 12, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "******************************************************************************************************"

        e.Graphics.DrawString("Store: ", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("MDLF POS", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel + 09974139205", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Transaction Number :   " & TransNoTextBox.Text, f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString("Transaction Date :   " & Date.Now(), f8, Brushes.Black, 0, 75)
        'add cashier name
        e.Graphics.DrawString("Cashier: ", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 105)

        Dim height As Integer
        Dim i As Long

        dgItems.AllowUserToAddRows = False

        For row As Integer = 0 To dgItems.RowCount - 1
            height += 15
            e.Graphics.DrawString(dgItems.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 115 + height)
            e.Graphics.DrawString(dgItems.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 25, 115 + height)

            i = dgItems.Rows(row).Cells(2).Value
            dgItems.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(dgItems.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 115 + height, right)
        Next

        Dim height2 As Integer
        height2 = 125 + height


        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("TOTAL AMOUNT:   " & TotalAmountTextBox.Text, f10, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString("TOTAL ITEMS:   " & computeTotalItems(), f10, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString("Thanks For Shopping", f10, Brushes.Black, centermargin, 35 + height2, center)

    End Sub
    'Functions
    Sub connect()
        conn = New MySqlConnection With {
         .ConnectionString = "server=localhost; userid=root; password=; database=fp_db_pos"
        }
        conn.Open()
    End Sub


    'Subs
    Private Sub POSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Cursor.Hide()
        Cursor.Position = New Point(0, 0)
        OptionLabel.Visible = False
        AmountDueTextBox.ReadOnly = True
        TotalAmountTextBox.ReadOnly = True
        Cash2TextBox.ReadOnly = True
        ChangeTextBox.ReadOnly = True
        transactionNumber()
        TransDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy")

    End Sub
    Private Sub displaydata()
        connect()
        query = "SELECT * FROM `tbl_prodinventoryinfo` WHERE `Product_Code` = @productcode"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@productcode", MySqlDbType.Int16).Value = ProdCodeTextBox.Text.Trim
        reader = command.ExecuteReader

        If reader.Read Then
            ProdNameTextBox.Text = reader.GetString("Product_Name")
            ProdPriceTextBox.Text = String.Format("{0:F2}", reader.GetString("Product_Price"))
            UnitInStockTextBox.Text = reader.GetString("Unit_In_Stock")
            DiscountTextBox.Text = reader.GetString("Special_Discount")
            QuantityTextBox.Enabled = True
            ProdCodeTextBox.Enabled = False
            RetailRadioButton.Enabled = True
            WholeSaleRadioButton.Enabled = True
            QuantityTextBox.Focus()
        Else
            MsgBox("No Such Information", vbExclamation)
            ProdCodeTextBox.Enabled = True
            ProdCodeTextBox.Focus()
        End If
    End Sub

    Private Sub transactionNumber()
        Dim transNumber As New Integer
        connect()
        query = "SELECT MAX(Transaction_Number) `Transaction_Number` FROM `tbl_sales`"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        reader = command.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                transNumber = reader.Item("Transaction_Number") + 1
            End While
        End If
        TransNoTextBox.Text = "000" + String.Concat(transNumber)
    End Sub

    Private Sub savingData()
        connect()
        query = "INSERT INTO `tbl_sales`(`Transaction_Number`,`Transaction_Date`,`Total_Items`,`Total_Discount`,`Cash`,`Total_Amount`) VALUE (@transnumber, @transdate, @totalitems,@totaldiscount,@cash, @totalamount)"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@transnumber", MySqlDbType.Int16).Value = TransNoTextBox.Text.Trim
        command.Parameters.Add("@transdate", MySqlDbType.VarChar).Value = TransDateTextBox.Text.Trim
        command.Parameters.Add("@totalitems", MySqlDbType.Int16).Value = computeTotalItems()
        command.Parameters.Add("@totaldiscount", MySqlDbType.Double).Value = computeTotalDiscountRows()
        command.Parameters.Add("@cash", MySqlDbType.Double).Value = Cash2TextBox.Text
        command.Parameters.Add("@totalamount", MySqlDbType.Double).Value = TotalAmountTextBox.Text
        command.ExecuteNonQuery()
    End Sub

    Private Sub saveUnitItem()

        connect()
        query = "INSERT INTO `tbl_ussales`(`Transaction_Number`, `Transaction_Date`, `Product_Code`,`Product_Name`, `Unit_Sold`, `Total_Discount`, `Total_Amount`, `Sales_Type`) VALUES (@transnumber,@transdate,@productcode,@productname,@unitsold,@totaldiscount,@totalamount,@salestype)"
        command.Parameters.Clear()
        For i As Integer = 0 To dgItems.Rows.Count - 1
            command.CommandText = query
            command.Connection = conn
            command.Parameters.Clear()
            command.Parameters.Add("@transnumber", MySqlDbType.Int64).Value = TransNoTextBox.Text.Trim
            command.Parameters.Add("@transdate", MySqlDbType.VarChar).Value = TransDateTextBox.Text.Trim
            command.Parameters.Add("@productcode", MySqlDbType.Int64).Value = dgItems.Rows(i).Cells(0).Value
            command.Parameters.Add("@productname", MySqlDbType.VarChar).Value = dgItems.Rows(i).Cells(1).Value
            command.Parameters.Add("@unitsold", MySqlDbType.Int64).Value = dgItems.Rows(i).Cells(3).Value
            command.Parameters.Add("@totaldiscount", MySqlDbType.Double).Value = dgItems.Rows(i).Cells(4).Value
            command.Parameters.Add("@totalamount", MySqlDbType.Double).Value = dgItems.Rows(i).Cells(6).Value
            command.Parameters.Add("@salestype", MySqlDbType.VarChar).Value = dgItems.Rows(i).Cells(5).Value
        Next
        command.ExecuteNonQuery()
    End Sub

    Private Sub deleteUnitItem()
        connect()
        query = "DELETE FROM `tbl_ussales` WHERE `Product_Code`= '" & ProdCodeTextBox.Text & "', `Product_Code`= '" & TransNoTextBox.Text & "' "
        command.CommandText = query
        command.Connection = conn
    End Sub

    Private Function unitsalestype()
        Dim salestype As String
        If RetailRadioButton.Checked = True Then
            salestype = "Retail"
        ElseIf WholeSaleRadioButton.Checked = True Then
            salestype = "Wholesale"
        End If
        Return salestype
    End Function
    Private Sub addItem()
        updateminusStock()
        dgItems.Rows.Add(ProdCodeTextBox.Text, ProdNameTextBox.Text, String.Format("{0:F2}", ProdPriceTextBox.Text), QuantityTextBox.Text, String.Format("{0:F2}", computeDiscount), unitsalestype, String.Format("{0:F2}", computeTotalPrice))
        UnitInStockTextBox.Clear()
        ProdCodeTextBox.Clear()
        QuantityTextBox.Clear()
        ProdNameTextBox.Clear()
        ProdPriceTextBox.Text = "0.00"
        QuantityTextBox.Enabled = False
        ProdCodeTextBox.Enabled = True
        DiscountTextBox.Clear()
        RetailRadioButton.Enabled = False
        WholeSaleRadioButton.Enabled = False
        RetailRadioButton.Checked = True
        ProdCodeTextBox.Focus()
    End Sub


    'functions

    Private Function computeDiscount()
        Dim preDiscountValue As New Double
        Dim postDiscountValue As New Double
        Dim pricePerItem As New Double
        Dim quantity As New Integer
        Dim totalDiscount As New Double
        Dim salesTypeDiscount As New Double
        pricePerItem = Double.Parse(ProdPriceTextBox.Text)
        quantity = Integer.Parse(QuantityTextBox.Text)
        preDiscountValue = Double.Parse(DiscountTextBox.Text)
        postDiscountValue = preDiscountValue / 100

        If RetailRadioButton.Checked = True Then
            salesTypeDiscount = 0
        ElseIf WholeSaleRadioButton.Checked = True Then
            salesTypeDiscount = (pricePerItem * 0.05) * quantity
        End If
        totalDiscount = ((postDiscountValue * pricePerItem) * quantity) + salesTypeDiscount
        Return totalDiscount
    End Function

    Private Function computeTotalPrice()
        Dim pricePerItem As New Double
        Dim quantity As New Integer
        Dim totalPrice As New Double
        pricePerItem = Double.Parse(ProdPriceTextBox.Text)
        quantity = Integer.Parse(QuantityTextBox.Text)

        totalPrice = (pricePerItem * quantity) - computeDiscount()
        Return totalPrice
    End Function

    Private Function computeChange()
        Dim cash As New Double
        Dim totalAmount As New Double
        Dim change As New Double
        cash = Double.Parse(Cash2TextBox.Text)
        totalAmount = Double.Parse(TotalAmountTextBox.Text)
        change = cash - totalAmount

        Return change
    End Function

    Private Function amountDue()
        Dim totalamountDue As New Double
        For i As Integer = 0 To dgItems.RowCount - 1
            totalamountDue += dgItems.Rows(i).Cells(6).Value
        Next
        Return totalamountDue
    End Function

    Private Function computeTotalItems()
        Dim totalItems As New Integer
        For i As Integer = 0 To dgItems.RowCount - 1
            totalItems += dgItems.Rows(i).Cells(3).Value
        Next
        Return totalItems
    End Function

    Private Function computeTotalDiscountRows()
        Dim totalDiscount As New Double
        For i As Integer = 0 To dgItems.RowCount - 1
            totalDiscount += dgItems.Rows(i).Cells(4).Value
        Next
        Return totalDiscount
    End Function
    Private Sub updateminusStock()
        connect()
        Dim unitinstock As Integer
        Dim quantity As Integer
        Dim stock As Integer
        unitinstock = Integer.Parse(UnitInStockTextBox.Text)
        quantity = Integer.Parse(QuantityTextBox.Text)
        stock = unitinstock - quantity
        query = "UPDATE `tbl_prodinventoryinfo` SET `Unit_In_Stock`= @stock WHERE `Product_Code` = '" & ProdCodeTextBox.Text & "'"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@stock", MySqlDbType.Int64).Value = stock
        command.ExecuteNonQuery()
    End Sub

    Private Sub updateoriginStock()
        connect()
        Dim unitinstock As Integer
        Dim quantity As Integer
        Dim stock As Integer
        unitinstock = Integer.Parse(UnitInStockTextBox.Text)
        quantity = Integer.Parse(QuantityTextBox.Text)
        stock = unitinstock + quantity
        query = "UPDATE `tbl_prodinventoryinfo` SET `Unit_In_Stock`= @stock WHERE `Product_Code` = '" & ProdCodeTextBox.Text & "'"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@stock", MySqlDbType.Int64).Value = stock
        command.ExecuteNonQuery()
    End Sub

    'KeyDowns

    Private Sub ProdCodeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ProdCodeTextBox.KeyDown
        If e.KeyCode = Keys.F8 Then
            If dgItems.RowCount > 0 Then
                MsgBox("Please cancel the transaction first", MsgBoxStyle.Exclamation)
            Else
                SecurityForm.Visible = True
                SecurityForm.txtUserName.Focus()
            End If
            System.Windows.Forms.Cursor.Show()
        ElseIf e.KeyCode = Keys.F7 Then
            ProdCodeTextBox.Enabled = False
            OptionLabel1.Visible = True
            OptionLabel1.Focus()
        ElseIf e.KeyCode = Keys.F1 Or e.KeyCode = Keys.Enter Then
            If ProdCodeTextBox.Text = "" Then
                MsgBox("Invalid Entry", vbExclamation)
                ProdCodeTextBox.Focus()
            Else
                displaydata()
            End If
        ElseIf e.KeyCode = Keys.F4 Then
            AmountDueTextBox.Text = String.Format("{0:F2}", amountDue())
            ProdCodeTextBox.Enabled = False
            QuantityTextBox.Enabled = False
            ProdCodeTextBox.Clear()
            ProdPriceTextBox.Text = "0.00"
            ProdNameTextBox.Clear()
            QuantityTextBox.Clear()
            WholeSaleRadioButton.Enabled = False
            RetailRadioButton.Enabled = False
            RetailRadioButton.Checked = True
            CashTextBox.Enabled = True
            CashTextBox.Focus()
        ElseIf e.KeyCode = Keys.Down Then
            dgItems.Focus()
        End If
    End Sub

    Private Sub QuantityTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles QuantityTextBox.KeyDown
        If e.KeyCode = Keys.F7 Then
            ProdCodeTextBox.Enabled = False
            OptionLabel1.Visible = True
            OptionLabel1.Focus()
        ElseIf e.KeyCode = Keys.F2 Or e.KeyCode = Keys.Enter Then
            If QuantityTextBox.Text = "" Then
                MsgBox("Invalid Entry", vbExclamation)
            Else
                addItem()
                saveUnitItem()
                AmountDueTextBox.Text = String.Format("{0:F2}", amountDue())
            End If
        ElseIf e.KeyCode = Keys.F3 Then
            ProdCodeTextBox.Clear()
            QuantityTextBox.Clear()
            ProdNameTextBox.Clear()
            ProdPriceTextBox.Text = "0.00"
            QuantityTextBox.Enabled = False
            ProdCodeTextBox.Enabled = True
            DiscountTextBox.Clear()
            RetailRadioButton.Enabled = False
            WholeSaleRadioButton.Enabled = False
            RetailRadioButton.Checked = True
            ProdCodeTextBox.Focus()
        ElseIf e.KeyCode = Keys.F10 Then
            RetailRadioButton.Checked = True
        ElseIf e.KeyCode = Keys.F11 Then
            WholeSaleRadioButton.Checked = True
        End If
    End Sub



    Private Sub ChangeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ChangeTextBox.KeyDown
        If e.KeyCode = Keys.N Then

            savingData()
            transactionNumber()
            TransDateTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy")
            dgItems.Rows.Clear()
            ProdCodeTextBox.Clear()
            ProdNameTextBox.Clear()
            ProdPriceTextBox.Text = "0.00"
            QuantityTextBox.Clear()
            CashTextBox.Clear()
            AmountDueTextBox.Text = "0.00"
            TotalAmountTextBox.Text = "0.00"
            Cash2TextBox.Text = "0.00"
            ChangeTextBox.Text = "0.00"
            ProdCodeTextBox.Enabled = True
            ProdCodeTextBox.Focus()
            MsgBox("New Transaction Added Successfully", MsgBoxStyle.MsgBoxRight)
        ElseIf e.keycode = keys.f6 Then
            print()
        End If
    End Sub

    Private Sub TransNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TransNoTextBox.TextChanged
        If Not IsNumeric(TransNoTextBox.Text) Then
            TransNoTextBox.Clear()
        End If
    End Sub

    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged
        If Not IsNumeric(QuantityTextBox.Text) Then
            QuantityTextBox.Clear()
        End If
    End Sub

    Private Sub CashTextBox_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(CashTextBox.Text) Then
            CashTextBox.Clear()
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub


    Private Sub OptionLabel1_KeyDown(sender As Object, e As KeyEventArgs) Handles OptionLabel1.KeyDown
        If e.KeyCode = Keys.F9 Then
            SecurityForm02.Visible = True
            SecurityForm02.txtUserName.Focus()
        ElseIf e.KeyCode = Keys.A Then
            OptionLabel1.Visible = False
            AmountDueTextBox.Text = "0.00"
            TotalAmountTextBox.Text = "0.00"
            Cash2TextBox.Text = "0.00"
            ChangeTextBox.Text = "0.00"
            ProdCodeTextBox.Clear()
            QuantityTextBox.Clear()
            ProdNameTextBox.Clear()
            CashTextBox.Clear()
            DiscountTextBox.Clear()
            ProdPriceTextBox.Text = "0.00"
            QuantityTextBox.Enabled = False
            ProdCodeTextBox.Enabled = True
            ProdCodeTextBox.Focus()

        ElseIf e.KeyCode = Keys.C Then
            OptionLabel1.Visible = False
            ProdCodeTextBox.Clear()
            ProdCodeTextBox.Enabled = True
            QuantityTextBox.Clear()
            QuantityTextBox.Enabled = False
            WholeSaleRadioButton.Enabled = False
            RetailRadioButton.Enabled = False
            RetailRadioButton.Checked = True
            CashTextBox.Clear()
            DiscountTextBox.Clear()
            ProdCodeTextBox.Focus()
        End If
    End Sub


    Private Sub dgItems_KeyDown(sender As Object, e As KeyEventArgs) Handles dgItems.KeyDown
        If e.KeyCode = Keys.Escape Then
            ProdCodeTextBox.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            UnitInStockTextBox.Enabled = True
            UnitInStockTextBox.ReadOnly = True
            UnitInStockTextBox.Focus()
            Dim x As Integer
                x = dgItems.CurrentRow.Index
                ProdCodeTextBox.Text = dgItems.Item(0, x).Value.ToString
                ProdNameTextBox.Text = dgItems.Item(1, x).Value.ToString
                QuantityTextBox.Text = dgItems.Item(3, x).Value.ToString
                connect()
                query = "SELECT * FROM `tbl_prodinventoryinfo` WHERE `Product_Code` = @productcode"
                command.CommandText = query
                command.Connection = conn
                command.Parameters.Clear()
                command.Parameters.Add("@productcode", MySqlDbType.Int16).Value = ProdCodeTextBox.Text.Trim
                reader = command.ExecuteReader
            If reader.Read Then
                UnitInStockTextBox.Text = reader.GetString("Unit_In_Stock")
            End If
        End If
    End Sub


    Private Sub UnitInStockTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles UnitInStockTextBox.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim choice = MessageBox.Show("Would you like to continue?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If choice = DialogResult.Yes Then
                Dim index As Integer
                index = dgItems.CurrentCell.RowIndex
                dgItems.Rows.RemoveAt(index)
                deleteUnitItem()
                updateoriginStock()
                ProdCodeTextBox.Clear()
                QuantityTextBox.Clear()
                ProdNameTextBox.Clear()
                ProdPriceTextBox.Text = "0.00"
                UnitInStockTextBox.Clear()
                ProdCodeTextBox.Focus()
                AmountDueTextBox.Text = amountDue()
            Else
                UnitInStockTextBox.Enabled = False
                ProdCodeTextBox.Clear()
                QuantityTextBox.Clear()
                ProdNameTextBox.Clear()
                ProdPriceTextBox.Text = "0.00"
                UnitInStockTextBox.Clear()
                ProdCodeTextBox.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            UnitInStockTextBox.Enabled = False
            ProdCodeTextBox.Clear()
            QuantityTextBox.Clear()
            ProdNameTextBox.Clear()
            ProdPriceTextBox.Text = "0.00"
            UnitInStockTextBox.Clear()
            dgItems.Focus()
        End If
    End Sub

    Private Sub CashTextBox_KeyDown_1(sender As Object, e As KeyEventArgs) Handles CashTextBox.KeyDown
        If e.KeyCode = Keys.F7 Then
            ProdCodeTextBox.Enabled = False
            OptionLabel1.Visible = True
            OptionLabel1.Focus()
        ElseIf e.KeyCode = Keys.F5 Or e.KeyCode = Keys.Enter Then
            If CashTextBox.Text = "" Then
                MsgBox("Invalid Entry", MsgBoxStyle.Exclamation)
            Else
                CashTextBox.Enabled = False
                TotalAmountTextBox.Text = String.Format("{0:F2}", AmountDueTextBox.Text)
                Cash2TextBox.Text = CashTextBox.Text + ".00"
                ChangeTextBox.Text = String.Format("{0:F2}", computeChange())
                ChangeTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub ProdCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProdCodeTextBox.TextChanged
        If Not IsNumeric(ProdCodeTextBox.Text) Then
            ProdCodeTextBox.Clear()
        End If
    End Sub


End Class
