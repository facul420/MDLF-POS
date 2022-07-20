Imports MySql.Data.MySqlClient


Public Class POSForm
    Dim conn As MySqlConnection
    Dim command As New MySqlCommand
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim query As String

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
            DiscountTextBox.Text = reader.GetString("Special_Discount")
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
        query = "INSERT INTO `tbl_sales`(`Transaction_Number`,`Transaction_Date`,`Total_Items`,`Total_Discount`,`Total_Amount`) VALUE (@transnumber, @transdate, @totalitems,@totaldiscount, @totalamount)"
        command.CommandText = query
        command.Connection = conn
        command.Parameters.Clear()
        command.Parameters.Add("@transnumber", MySqlDbType.Int16).Value = TransNoTextBox.Text.Trim
        command.Parameters.Add("@transdate", MySqlDbType.VarChar).Value = TransDateTextBox.Text.Trim
        command.Parameters.Add("@totalitems", MySqlDbType.Int16).Value = computeTotalItems()
        command.Parameters.Add("@totaldiscount", MySqlDbType.Double).Value = computeTotalDiscountRows()
        command.Parameters.Add("@totalamount", MySqlDbType.Double).Value = TotalAmountTextBox.Text
        command.ExecuteNonQuery()
    End Sub

    Private Sub addItem()
        dgItems.Rows.Add(ProdNameTextBox.Text, String.Format("{0:F2}", ProdPriceTextBox.Text), QuantityTextBox.Text, String.Format("{0:F2}", computeDiscount), String.Format("{0:F2}", computeTotalPrice))
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
        Dim quantity As New Int16
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
        Dim quantity As New Int16
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
            totalamountDue += dgItems.Rows(i).Cells(4).Value
        Next
        Return totalamountDue
    End Function

    Private Function computeTotalItems()
        Dim totalItems As New Integer
        For i As Integer = 0 To dgItems.RowCount - 1
            totalItems += dgItems.Rows(i).Cells(2).Value
        Next
        Return totalItems
    End Function

    Private Function computeTotalDiscountRows()
        Dim totalDiscount As New Double
        For i As Integer = 0 To dgItems.RowCount - 1
            totalDiscount += dgItems.Rows(i).Cells(3).Value
        Next
        Return totalDiscount
    End Function



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

                QuantityTextBox.Enabled = True
                ProdCodeTextBox.Enabled = False
                RetailRadioButton.Enabled = True
                WholeSaleRadioButton.Enabled = True
                QuantityTextBox.Focus()
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

    Private Sub CashTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CashTextBox.KeyDown
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

    Private Sub CashTextBox_TextChanged(sender As Object, e As EventArgs) Handles CashTextBox.TextChanged
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
            Dim choice As MsgBoxResult = MessageBox.Show("Would you like to continue?", "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If MsgBoxResult.Yes Then
                Dim index As Integer
                index = dgItems.CurrentCell.RowIndex
                dgItems.Rows.RemoveAt(index)
                AmountDueTextBox.Text = amountDue()
            End If

        End If
    End Sub


End Class
