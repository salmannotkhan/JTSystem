﻿Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports Xceed.Words.NET
Imports System.Text.RegularExpressions

Public Class MainActivity
    ReadOnly con As New SqlConnection(My.Settings.JTBASEConnectionString)
    ReadOnly dsBuyers As New DataSet
    Dim query As String
    Dim total As Double
    Dim quant As Integer
    Dim rate As Double
    Dim amount As Double
    Dim taxable As Double
    Dim gst As Double
    Dim fraction As Double

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub Navpanel_MouseMove(sender As Object, e As MouseEventArgs) Handles navpanel.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub
    Private Sub Cmdminimize_Click(sender As Object, e As EventArgs) Handles cmdminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
    Private Sub CmdGenerate_Click(sender As Object, e As EventArgs) Handles cmdGenerate.Click
        If CheckData() Then
            Dim bId As Integer
            con.Open()
            query = "SELECT Id FROM Buyers WHERE Name = @name and City = @city"
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@name", txtBuyer.Text)
                cmd.Parameters.AddWithValue("@city", txtCity.Text)
                bId = cmd.ExecuteScalar
            End Using
            con.Close()
            If bId = 0 Then
                bId = InsertBuyersDetails()
            End If
            UpdateBuyersDetails(bId)
            Calculations()
            InsertOrderDetails(bId)
            GenerateInvoice(txtNewInvoice.Text)
            LoadOrders()
        End If
    End Sub
    Private Sub MainActivity_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadOrders()
        LoadSuggestions()
        LoadProducts()
        cmdsummary.ForeColor = Color.Black
        cmdsummary.BackColor = Color.White
        inventorypanel.Hide()
        detailspanel.Hide()
        billingpanel.Hide()
    End Sub
    Private Sub TxtBuyer_LostFocus(sender As Object, e As EventArgs) Handles txtBuyer.LostFocus
        Dim row As DataRow() = dsBuyers.Tables(0).Select("Name ='" & txtBuyer.Text & "'")
        If row.Count > 0 Then
            txtAddress.Text = row(0).Item(2)
            txtCity.Text = row(0).Item(3)
            txtMobile.Text = row(0).Item(4)
            txtGSTNo.Text = row(0).Item(5)
            txtPlace.Text = row(0).Item(6)
        End If
        txtBuyer.Text = StrConv(txtBuyer.Text, vbProperCase)
    End Sub
    Private Sub Txt_LostFocus(sender As Object, e As EventArgs) Handles txtCity.LostFocus, txtAddress.LostFocus, txtseller.LostFocus, txtNewProduct.LostFocus
        sender.Text = StrConv(sender.Text, vbProperCase)
    End Sub
    Private Sub HoverEffect(sender As Object, e As EventArgs) Handles cmdminimize.MouseEnter, cmdclose.MouseEnter, cmdbilling.MouseEnter, cmdorder.MouseEnter, cmdinventory.MouseEnter, cmdAbout.MouseLeave, cmdsummary.MouseEnter, cmdviewstock.MouseEnter
        sender.ForeColor = Color.Black
        sender.BackColor = Color.White
    End Sub
    Private Sub HoverEffectEnd(sender As Object, e As EventArgs) Handles cmdminimize.MouseLeave, cmdclose.MouseLeave, cmdbilling.MouseLeave, cmdorder.MouseLeave, cmdinventory.MouseLeave, cmdAbout.MouseEnter, cmdsummary.MouseLeave, cmdviewstock.MouseLeave
        For Each control In Me.Controls.OfType(Of Panel)
            If control.Name <> "navpanel" Then
                If Not control.Visible And control.Name Is CType(sender, Label).Tag Then
                    sender.ForeColor = Color.White
                    sender.BackColor = Color.Black
                End If
            End If
        Next
        If sender.Tag = "" Then
            sender.ForeColor = Color.White
            sender.BackColor = Color.Black
        End If
    End Sub
    Private Sub DataDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDetails.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = gridDetails.Columns("Status").Index Then
                If gridDetails.Rows(e.RowIndex).Cells("Status").Value = "Unpaid" Then
                    Dim oid As Integer = gridDetails.Rows(e.RowIndex).Cells("Id").Value
                    Using pay As New RecievePayment("Recieve payment for Order No." & oid)
                        Dim payresult = pay.ShowDialog
                        If payresult = DialogResult.OK Then
                            Dim recieved = pay.amount
                            If IsNumeric(recieved) Then
                                Using confirm As New CustomDialog("Confirmation", "Did you recieved payment for sure?", "Yes", "No")
                                    Dim result = confirm.ShowDialog
                                    If result = DialogResult.Yes Then
                                        query = "SELECT Total-PaidTotal from Orders WHERE Id = @id"
                                        con.Open()
                                        Using cmd As New SqlCommand(query, con)
                                            cmd.Parameters.AddWithValue("@id", oid)
                                            Dim remain As Integer = cmd.ExecuteScalar
                                            If recieved > remain Then
                                                Using msg As New CustomMsgBox("Enter valid amount. Remaining amount is Rs." & remain)
                                                    msg.ShowDialog()
                                                End Using
                                            Else
                                                query = "UPDATE Orders SET PaidTotal += @recamount WHERE Id = @id"
                                                Using cmdupdate As New SqlCommand(query, con)
                                                    cmdupdate.Parameters.AddWithValue("@recamount", recieved)
                                                    cmdupdate.Parameters.AddWithValue("@id", oid)
                                                    cmdupdate.ExecuteNonQuery()
                                                End Using
                                                txtseller.Clear()
                                            End If
                                        End Using
                                        con.Close()
                                        LoadOrders()
                                    End If
                                End Using
                            Else
                                Using msg As New CustomMsgBox("Enter valid amount")
                                    msg.ShowDialog()
                                End Using
                            End If
                        End If
                    End Using
                End If
            End If
            If e.ColumnIndex = gridDetails.Columns("View Details").Index Then
                Dim oId As Integer = gridDetails.Rows(e.RowIndex).Cells("Id").Value
                query = "SELECT * FROM Buyers, Orders WHERE Orders.Id = @oid"
                con.Open()
                Using da As New SqlDataAdapter
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@oid", oId)
                        da.SelectCommand = cmd
                    End Using
                    Using dt As New DataTable
                        da.Fill(dt)
                        Dim dr As DataRow = dt.Rows(0)
                        If Not dr.IsNull(0) Then
                            Dim desc As String = String.Join(
                        Environment.NewLine,
                            "Invoice No.: " & oId,
                            "M/S: " & dr.Item("Name"),
                            "Address: " & dr.Item("Address"),
                            "City: " & dr.Item("City"),
                            "Place of supply: " & dr.Item("State"),
                            "Product Name: " & dr.Item("ProductName"),
                            "Quantity: " & dr.Item("Qty"),
                            "Rate: " & dr.Item("Rate"),
                            "Total: " & dr.Item("Total"),
                            "Paid: " & dr.Item("PaidTotal"))
                            Using details As New ViewDetailsBox(desc)
                                Dim result = details.ShowDialog
                                If result = DialogResult.Yes Then
                                    txtNewInvoice.Text = dr.Item("Id")
                                    txtBuyer.Text = dr.Item("Name")
                                    txtAddress.Text = dr.Item("Address")
                                    txtCity.Text = dr.Item("City")
                                    txtGST.Text = 5
                                    txtGSTNo.Text = dr.Item("GST")
                                    txtHSN.Text = dr.Item("HSN")
                                    txtLabour.Text = dr.Item("Labor")
                                    txtMobile.Text = dr.Item("Mobile")
                                    txtPlace.Text = dr.Item("State")
                                    selectProduct.SelectedText = dr.Item("ProductName")
                                    txtBags.Text = dr.Item("Qty")
                                    txtRate.Text = dr.Item("Rate")
                                    txtTransporter.Text = dr.Item("Transporter")
                                    dateToday.Value = dr.Item("Date")
                                    con.Close()
                                    Calculations()
                                    GenerateInvoice(oId)
                                    ClearValues()
                                    LoadOrders()
                                ElseIf result = DialogResult.No Then
                                    Using cmd As New SqlCommand("DELETE FROM Orders WHERE Id = @oid", con)
                                        cmd.Parameters.AddWithValue("@oid", oId)
                                        cmd.ExecuteNonQuery()
                                    End Using
                                    Using cmd As New SqlCommand("SELECT COUNT(*) FROM Orders WHERE Buyerid = @buyersid", con)
                                        cmd.Parameters.AddWithValue("@buyersid", dr.Item("BuyerId"))
                                        If cmd.ExecuteScalar() = 0 Then
                                            Using cmd2 As New SqlCommand("DELETE FROM Buyers WHERE Id = @buyersid", con)
                                                cmd2.Parameters.AddWithValue("@buyersid", dr.Item("Buyerid"))
                                            End Using
                                        End If
                                    End Using
                                    con.Close()
                                    LoadSuggestions()
                                    LoadOrders()
                                End If
                            End Using
                        End If
                    End Using
                End Using
                con.Close()
            End If
        End If
    End Sub
    Private Sub Cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtNewProduct.Text <> "" Then
            Dim quant As String = New Regex("\d+(?=[k|K][g|G])").Match(txtNewProduct.Text).Value
            If quant = "" Then
                Using confirm As New CustomDialog("Confirmation", "Sure want to add product without weight?", "Yes", "No")
                    Dim result = confirm.ShowDialog
                    If result = DialogResult.Yes Then
                        Using msg As New CustomMsgBox("Default weight is 1Kg")
                            msg.ShowDialog()
                        End Using
                        query = "INSERT INTO Products VALUES(@productname, 0)"
                        con.Open()
                        Using cmd As New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@productname", txtNewProduct.Text)
                            cmd.ExecuteNonQuery()
                        End Using
                        txtNewProduct.Clear()
                        con.Close()
                        LoadProducts()
                    ElseIf result = DialogResult.No Then
                        Using msg As New CustomMsgBox("Don't keep space between weight and unit(KG)")
                            msg.ShowDialog()
                        End Using
                    End If
                End Using
            Else
                query = "INSERT INTO Products VALUES(@productname, 0)"
                con.Open()
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@productname", txtNewProduct.Text)
                    cmd.ExecuteNonQuery()
                End Using
                txtNewProduct.Clear()
                con.Close()
                LoadProducts()
                Using msg As New CustomMsgBox("Product added successfully")
                    msg.ShowDialog()
                End Using
            End If
        Else
            Using msg As New CustomMsgBox("Product name can't be blank")
                msg.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub Cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        If selectProductList.Text <> "" Then
            Using confirm As New CustomDialog("Confirmation", "Do you want to delete this product?", "Yes", "No")
                Dim result = confirm.ShowDialog
                If result = DialogResult.Yes Then
                    query = "DELETE FROM Products WHERE Id = @id"
                    con.Open()
                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@id", selectProductList.SelectedValue)
                        cmd.ExecuteNonQuery()
                    End Using
                    con.Close()
                    LoadProducts()
                End If
            End Using
        Else
            Using msg As New CustomMsgBox("Nothing to delete")
                msg.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub NavigationPanel(sender As Object, e As EventArgs) Handles cmdinventory.Click, cmdbilling.Click, cmdorder.Click, cmdsummary.Click
        For Each control In Me.Controls.OfType(Of Panel)
            If control.Name <> "navpanel" Then
                If TypeOf control Is Panel And control.Name Is CType(sender, Label).Tag Then
                    control.Visible = True
                Else
                    control.Visible = False
                End If
            End If
        Next
        For Each btn In navpanel.Controls.OfType(Of Label)
            If Not btn Is sender Then
                btn.ForeColor = Color.White
                btn.BackColor = Color.Black
            End If
        Next
    End Sub
    Private Sub CmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        If aboutme.ShowDialog() = DialogResult.Yes Then
            ResetApplication()
        End If
    End Sub
    Private Sub Cmdgstdisable_Click(sender As Object, e As EventArgs) Handles cmdgstdisable.Click
        If txtGSTNo.Enabled Then
            txtGSTNo.Text = "               "
            txtGSTNo.Enabled = False
        Else
            txtGSTNo.Clear()
            txtGSTNo.Enabled = True
        End If
    End Sub
    Private Function LoadSuggestions()
        Dim suggestions As New AutoCompleteStringCollection()
        con.Open()
        query = "SELECT * FROM Buyers"
        Using da As New SqlDataAdapter(query, con) 'This link Adapter with command
            da.Fill(dsBuyers) 'Can fill straight to DataTable
        End Using
        con.Close()

        For i As Integer = 0 To dsBuyers.Tables(0).Rows.Count - 1
            suggestions.Add(dsBuyers.Tables(0).Rows(i).Item(1))
        Next
        txtBuyer.AutoCompleteCustomSource = suggestions
        Return 0
    End Function
    Private Function LoadProducts()
        query = "SELECT * FROM Products"
        Using ds As New DataSet
            Using da As New SqlDataAdapter(query, con)
                da.Fill(ds)
            End Using
            With selectProductList
                .DataSource = ds.Tables(0)
                .DisplayMember = "Productname"
                .ValueMember = "Id"
                .DisplayMember = "Productname"
            End With
            With selectProductlistbuy
                .DataSource = ds.Tables(0)
                .DisplayMember = "Productname"
                .ValueMember = "Id"
                .DisplayMember = "Productname"
            End With
            selectProduct.DataSource = ds.Tables(0)
        End Using
        Return 0
    End Function
    Private Function LoadOrders()
        gridDetails.AlternatingRowsDefaultCellStyle = Nothing
        Dim lastOrder As Integer = 100
        query = "SELECT Orders.Id, Name, City, Date, Total, PaidTotal, Total - PaidTotal Remain FROM Buyers, Orders WHERE BuyerId = Buyers.Id"
        Using da As New SqlDataAdapter(query, con)
            Using ds As New DataSet
                da.Fill(ds)
                gridDetails.DataSource = ds.Tables(0)
                gridDetails.Columns("PaidTotal").Visible = False
                If ds.Tables(0).Rows.Count > 0 Then
                    Dim dc As DataRow() = ds.Tables(0).Select("Total - PaidTotal > 0")
                    If dc.Length > 0 Then
                        selectProductlistbuy.DataSource = dc.CopyToDataTable
                        selectProductlistbuy.DisplayMember = "Id"
                        lastOrder = ds.Tables(0).Compute("max(Id)", String.Empty)
                    Else
                        selectProductlistbuy.DataSource = Nothing
                    End If
                Else
                    selectProductlistbuy.DataSource = Nothing
                End If
            End Using
        End Using
        If gridDetails.Columns("Status") Is Nothing Then
            Using viewstatus As New DataGridViewTextBoxColumn
                With viewstatus
                    .Name = "Status"
                    .HeaderText = "Status"
                End With
                gridDetails.Columns.Add(viewstatus)
            End Using
        End If
        If gridDetails.Columns("View Details") Is Nothing Then
            Using viewdetails As New DataGridViewButtonColumn
                With viewdetails
                    .Name = "View Details"
                    .HeaderText = "Details"
                    .Text = "View"
                    .UseColumnTextForButtonValue = True
                    .FlatStyle = FlatStyle.Flat
                End With
                gridDetails.Columns.Add(viewdetails)
            End Using
        End If
        For i As Integer = 0 To gridDetails.Rows.Count - 1
            If gridDetails.Item("Remain", i).Value > 0 Then
                gridDetails.Item("Status", i).Value = "Unpaid"
            Else
                gridDetails.Item("Status", i).Value = "Paid"
            End If
        Next
        gridDetails.Columns("Remain").Visible = False
        gridDetails.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        gridDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        gridDetails.Columns("Id").HeaderText = "Invoice"
        gridDetails.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        txtNewInvoice.Text = lastOrder + 1
        LoadSummary()
        Return 0
    End Function
    Public Function InsertBuyersDetails()
        con.Open()
        query = "INSERT INTO Buyers VALUES(@name, @address, @city, @mobile, @gst, @state); SELECT SCOPE_IDENTITY()"
        Dim bId As Integer
        Using cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txtBuyer.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@city", txtCity.Text)
            cmd.Parameters.AddWithValue("@mobile", txtMobile.Text)
            cmd.Parameters.AddWithValue("@gst", txtGSTNo.Text)
            cmd.Parameters.AddWithValue("@state", txtPlace.Text)
            bId = cmd.ExecuteScalar
        End Using
        con.Close()
        Return bId
    End Function
    Public Function UpdateBuyersDetails(ByVal id As Integer)
        con.Open()
        query = "UPDATE Buyers SET Name = @name, Address = @address, City = @city, Mobile = @mobile, GST = @gst, State = @state WHERE Id = @id"
        Using cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@name", txtBuyer.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@city", txtCity.Text)
            cmd.Parameters.AddWithValue("@mobile", txtMobile.Text)
            cmd.Parameters.AddWithValue("@gst", txtGSTNo.Text)
            cmd.Parameters.AddWithValue("@state", txtPlace.Text)
        End Using
        con.Close()
        Return 0
    End Function
    Public Function InsertOrderDetails(ByVal id As Integer)
        con.Open()
        query = "INSERT INTO Orders VALUES(@id, @buyerid, @date, @productname, @hsn, @rate, @qty, @labor, @transporter, @total, 0)"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", txtNewInvoice.Text)
            cmd.Parameters.AddWithValue("@buyerid", id)
            cmd.Parameters.AddWithValue("@date", dateToday.Value)
            cmd.Parameters.AddWithValue("@productname", selectProduct.Text)
            cmd.Parameters.AddWithValue("@hsn", Val(txtHSN.Text))
            cmd.Parameters.AddWithValue("@rate", Val(txtRate.Text))
            cmd.Parameters.AddWithValue("@qty", Val(txtBags.Text))
            cmd.Parameters.AddWithValue("@labor", Val(txtLabour.Text))
            cmd.Parameters.AddWithValue("@total", Val(total))
            cmd.Parameters.AddWithValue("@transporter", txtTransporter.Text)
            cmd.ExecuteNonQuery()
        End Using
        query = "UPDATE Products SET Stock -= @qty WHERE ProductName = @productname"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@qty", Val(txtBags.Text))
            cmd.Parameters.AddWithValue("@productname", selectProduct.Text)
            cmd.ExecuteNonQuery()
        End Using
        con.Close()
        Return 0
    End Function
    Private Function CheckData()
        If IsNumeric(txtNewInvoice.Text) Then
            Dim flag As Boolean = False
            query = "SELECT Id FROM Orders WHERE Id = @id"
            con.Open()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", txtNewInvoice.Text)
                If cmd.ExecuteScalar = 0 Then
                    flag = True
                End If
            End Using
            con.Close()
            If flag Then
                If txtBuyer.Text <> "" Then
                    If txtCity.Text <> "" Then
                        If IsNumeric(txtMobile.Text) And (txtMobile.Text.Length = 10 Or txtMobile.Text.Length = 11) Then
                            If txtGSTNo.Text <> "" And txtGSTNo.Text.Length = 15 Then
                                If selectProduct.Text <> "" Then
                                    If IsNumeric(txtHSN.Text) Then
                                        If IsNumeric(txtBags.Text) And Val(txtBags.Text) <> 0 Then
                                            query = "SELECT Stock FROM Products WHERE ProductName = @productname"
                                            con.Open()
                                            Dim stock As Integer = 0
                                            Using cmd As New SqlCommand(query, con)
                                                cmd.Parameters.AddWithValue("@productname", selectProduct.Text)
                                                stock = cmd.ExecuteScalar()
                                            End Using
                                            con.Close()
                                            If txtBags.Text <= stock Then
                                                If IsNumeric(txtRate.Text) And Val(txtRate.Text) <> 0 Then
                                                    If IsNumeric(txtGST.Text) Then
                                                        If txtLabour.Text = "" Then
                                                            txtLabour.Text = 0
                                                            Return True
                                                        Else
                                                            If IsNumeric(txtLabour.Text) Then
                                                                Return True
                                                            Else
                                                                Using msg As New CustomMsgBox("Enter valid Labour Charges")
                                                                    msg.ShowDialog()
                                                                End Using
                                                                Return False
                                                            End If
                                                        End If
                                                    Else
                                                        Using msg As New CustomMsgBox("Enter valid GST Rate")
                                                            msg.ShowDialog()
                                                        End Using
                                                        Return False
                                                    End If
                                                Else
                                                    Using msg As New CustomMsgBox("Enter valid Product Rate")
                                                        msg.ShowDialog()
                                                    End Using
                                                    Return False
                                                End If
                                            Else
                                                Using msg As New CustomMsgBox("Insufficient Stock")
                                                    msg.ShowDialog()
                                                End Using
                                                Return False
                                            End If
                                        Else
                                            Using msg As New CustomMsgBox("Enter valid Number of bags")
                                                msg.ShowDialog()
                                            End Using
                                            Return False
                                        End If
                                    Else
                                        Using msg As New CustomMsgBox("Enter valid HSN Code")
                                            msg.ShowDialog()
                                        End Using
                                        Return False
                                    End If
                                Else
                                    Using msg As New CustomMsgBox("Please add product first")
                                        msg.ShowDialog()
                                    End Using
                                    Return False
                                End If
                            Else
                                Using msg As New CustomMsgBox("Enter valid GST No.")
                                    msg.ShowDialog()
                                End Using
                                Return False
                            End If
                        Else
                            Using msg As New CustomMsgBox("Enter valid Mobile No.")
                                msg.ShowDialog()
                            End Using
                            Return False
                        End If
                    Else
                        Using msg As New CustomMsgBox("City name can't be blank")
                            msg.ShowDialog()
                        End Using
                        Return False
                    End If
                Else
                    Using msg As New CustomMsgBox("Buyers name can't be blank")
                        msg.ShowDialog()
                    End Using
                    Return False
                End If
            Else
                Using msg As New CustomMsgBox("Bill with that Invoice No. already exists")
                    msg.ShowDialog()
                End Using
                Return False
            End If
        Else
            Using msg As New CustomMsgBox("Enter valid Invoice No.")
                msg.ShowDialog()
            End Using
            Return False
        End If
        Return True
    End Function
    Private Function Calculations()
        Dim match = New Regex("\d+(?=[k|K][g|G])").Match(selectProduct.Text)
        If match.Success Then
            quant = match.Value
        Else
            quant = 1
        End If
        rate = Math.Round((txtRate.Text * 100) / 105, 2)
        amount = Math.Round(quant * txtBags.Text * (rate / 100), 2) ''Rate * Qty

        taxable = Math.Round(txtLabour.Text + amount, 2) ''Labour + Rate * Qty
        gst = Math.Round((taxable * 2.5) / 100, 2) ''(Labour + Rate * Qty) * 2.5 / 100
        total = Math.Round(taxable + 2 * gst, 2)
        fraction = FractionCalculate(total)
        total += fraction
        Return 0
    End Function
    Private Function GenerateInvoice(ByVal oId As Integer)
        Dim path As String
        Using document = DocX.Load(Application.StartupPath & "/Template.docx")
            document.SetDefaultFont(New Xceed.Document.NET.Font("Arial"), 10)
            '' Buyer's Details
            document.Bookmarks("buyer").Paragraph.ReplaceText("[buyer]", txtBuyer.Text) ''Input Type: Text
            document.Bookmarks("address").Paragraph.ReplaceText("[address]", txtAddress.Text) ''Input Type: Text
            document.Bookmarks("city").Paragraph.ReplaceText("[city]", txtCity.Text) ''Input Type: Text
            document.Bookmarks("mobile").Paragraph.ReplaceText("[mobile]", txtMobile.Text) ''Input Type: Text
            document.Bookmarks("gstno").Paragraph.ReplaceText("[gstno]", txtGSTNo.Text.ToUpper) ''Input Type: Text
            document.Bookmarks("placesupply").Paragraph.ReplaceText("[placesupply]", txtPlace.Text) ''Input Type: Text

            document.Bookmarks("invoice").Paragraph.ReplaceText("[invoice]", oId) ''Automatic
            document.Bookmarks("date").Paragraph.ReplaceText("[date]", dateToday.Text) ''Input Type: Date
            document.Bookmarks("transporter").Paragraph.ReplaceText("[transporter]", txtTransporter.Text) ''Input Type: Text

            '' Product Details
            document.Bookmarks("no").Paragraph.ReplaceText("[no]", "1") ''Automatic
            document.Bookmarks("productname").Paragraph.ReplaceText("[productname]", selectProduct.Text) ''Input Type: Selection
            document.Bookmarks("hsn").Paragraph.ReplaceText("[hsn]", txtHSN.Text) ''Input
            document.Bookmarks("bags").Paragraph.ReplaceText("[bags]", txtBags.Text) ''Input
            document.Bookmarks("qty").Paragraph.ReplaceText("[qty]", Val(quant) * Val(txtBags.Text)) ''Automatic

            document.Bookmarks("net").Paragraph.ReplaceText("[net]", Math.Round(Val(txtRate.Text), 2).ToString("F")) ''Input Probably Automatic
            document.Bookmarks("rate").Paragraph.ReplaceText("[rate]", rate.ToString("F")) ''Input
            document.Bookmarks("gst").Paragraph.ReplaceText("[gst]", txtGST.Text & "%") ''Input

            document.Bookmarks("amount").Paragraph.ReplaceText("[amount]", amount.ToString("F"))
            document.Bookmarks("subtotal").Paragraph.ReplaceText("[subtotal]", amount.ToString("F"))


            '' Office Work
            document.Bookmarks("labour").Paragraph.ReplaceText("[labour]", Math.Round(Val(txtLabour.Text), 2).ToString("F")) ''Input
            document.Bookmarks("taxable").Paragraph.ReplaceText("[taxable]", taxable.ToString("F"))
            document.Bookmarks("cgst").Paragraph.ReplaceText("[cgst]", gst.ToString("F"))
            document.Bookmarks("sgst").Paragraph.ReplaceText("[sgst]", gst.ToString("F"))

            If fraction <> 0 Then
                If fraction > 0 Then
                    document.Bookmarks("round").Paragraph.ReplaceText("[round]", "+" & fraction.ToString("F"))
                Else
                    document.Bookmarks("round").Paragraph.ReplaceText("[round]", fraction.ToString("F"))
                End If
            Else
                document.Tables.First().RemoveRow(14)
            End If
            document.Bookmarks("total").Paragraph.ReplaceText("[total]", total & ".00") ''Taxable amount + CGST + SGST

            ' Past Billings of Buyer
            query = "SELECT Id, Date, Total - PaidTotal Remaining, DATEDIFF(day, Date, @date) Days FROM Orders WHERE Total - PaidTotal > 0 AND BuyerId = (SELECT BuyerId FROM Orders WHERE Id = @id) AND Date <= @date"
            con.Open()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", oId)
                cmd.Parameters.AddWithValue("@date", dateToday.Value)
                Using dr As SqlDataReader = cmd.ExecuteReader
                    Dim invoices As String = ""
                    Dim dates As String = ""
                    Dim amounts As String = ""
                    Dim dues As String = ""
                    While dr.Read
                        invoices &= dr.Item("Id") & vbNewLine
                        dates &= Format(dr.Item("Date"), "dd/MM/yyyy") & vbNewLine
                        amounts &= dr.Item("Remaining") & vbNewLine
                        dues &= (dr.Item("Days") + 1) & vbNewLine
                    End While
                    document.Bookmarks("invoice2").Paragraph.ReplaceText("[invoice2]", invoices)
                    document.Bookmarks("date2").Paragraph.ReplaceText("[date2]", dates)
                    document.Bookmarks("total2").Paragraph.ReplaceText("[total2]", amounts)
                    document.Bookmarks("due").Paragraph.ReplaceText("[due]", dues)
                End Using
            End Using
            con.Close()

            document.Bookmarks("totalwords").Paragraph.ReplaceText("[totalwords]", NumeriCon.ConvertNum(Int(total)) & " Only") ''Automatic
            path = Application.StartupPath & "\Invoice No." & oId & ".docx"
            document.SaveAs(path)
            PdfConversion(path)
            My.Computer.FileSystem.DeleteFile(path)
        End Using
        Return 0
    End Function
    Private Function PdfConversion(ByVal path As String)
        Using doc As New Spire.Doc.Document(path)
            Using confirm As New CustomDialog("Confirmation", "Do you want to print invoice?", "Print", "Save")
                Dim result = confirm.ShowDialog
                If result = Windows.Forms.DialogResult.Yes Then
                    Using dialog As New PrintDialog()
                        dialog.AllowCurrentPage = True
                        dialog.AllowSomePages = True
                        dialog.UseEXDialog = True
                        Try
                            doc.PrintDialog = dialog
                            dialog.Document = doc.PrintDocument
                            dialog.Document.Print()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                ElseIf result = Windows.Forms.DialogResult.No Then
                    Using savebox As New SaveFileDialog
                        savebox.Filter = "Pdf Document|*.pdf"
                        savebox.Title = "Save Invoice Copy"
                        savebox.RestoreDirectory = True
                        savebox.FileName = IO.Path.GetFileNameWithoutExtension(path)
                        If savebox.ShowDialog = DialogResult.OK Then
                            Dim savepath As String = savebox.FileName
                            doc.SaveToFile(savepath, Spire.Doc.FileFormat.PDF)
                            Using msg As New CustomMsgBox("Invoice saved successfully")
                                msg.ShowDialog()
                            End Using
                        End If
                    End Using
                End If
            End Using
        End Using
        Return 0
    End Function
    Private Function FractionCalculate(total)
        Dim fraction As Double = total - Int(total)
        If fraction >= 0.5 Then
            fraction = 1 - fraction
        Else
            fraction = -fraction
        End If
        Return fraction
    End Function
    Private Function ClearValues()
        For Each control In Me.Controls
            If TypeOf control Is TextBox Then
                control.clear()
            ElseIf TypeOf control Is ComboBox Then
                control.SelectedIndex = 0
            End If
        Next
        Return 0
    End Function
    Public Function ResetApplication()
        con.Open()

        'Deleted all data in tables
        query = "DELETE FROM Orders; DELETE FROM Buyers; DELETE FROM Products; DELETE FROM Purchase"
        Using cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using

        query = "DBCC CHECKIDENT('Buyers', RESEED, 1)"
        Using cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using

        query = "DBCC CHECKIDENT('Purchase', RESEED, 1)"
        Using cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
            End Using

            query = "DBCC CHECKIDENT('Products', RESEED, 1)"
        Using cmd As New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
        End Using

        con.Close()
        Using msg As New CustomMsgBox("Application Resetted Successfully")
            msg.ShowDialog()
        End Using
        Me.Close()
        Return 0
    End Function
    Private Sub Cmdpurchase_Click(sender As Object, e As EventArgs) Handles cmdpurchase.Click
        If selectProductlistbuy.Text <> "" Then
            If txtseller.Text <> "" Then
                If IsNumeric(txtbuyrate.Text) And Val(txtbuyrate.Text) <> 0 Then
                    If IsNumeric(txtbuyqty.Text) And Val(txtbuyqty.Text) <> 0 Then
                        query = "INSERT INTO Purchase VALUES(@date, @seller, @productname, @rate, @qty)"
                        con.Open()
                        Using cmd As New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@date", dateBuy.Text)
                            cmd.Parameters.AddWithValue("@productname", selectProductlistbuy.Text)
                            cmd.Parameters.AddWithValue("@seller", txtseller.Text)
                            cmd.Parameters.AddWithValue("@rate", txtbuyrate.Text)
                            cmd.Parameters.AddWithValue("@qty", txtbuyqty.Text)
                            cmd.ExecuteNonQuery()
                        End Using
                        query = "UPDATE Products SET Stock += @qty WHERE Id = @id"
                        Using cmd As New SqlCommand(query, con)
                            cmd.Parameters.AddWithValue("@id", selectProductlistbuy.SelectedValue)
                            cmd.Parameters.AddWithValue("@qty", txtbuyqty.Text)
                            cmd.ExecuteNonQuery()
                        End Using
                        Using msg As New CustomMsgBox("Stock added successfully")
                            msg.ShowDialog()
                        End Using
                        con.Close()
                        LoadSummary()
                    Else
                        Using msg As New CustomMsgBox("Enter Valid Number of Bags")
                            msg.ShowDialog()
                        End Using
                    End If
                Else
                    Using msg As New CustomMsgBox("Enter valid buying rate")
                        msg.ShowDialog()
                    End Using
                End If
            Else
                Using msg As New CustomMsgBox("Seller name can't be blank")
                    msg.ShowDialog()
                End Using
            End If
        Else
            Using msg As New CustomMsgBox("Please add product first")
                msg.ShowDialog()
            End Using
        End If
    End Sub
    Private Function LoadSummary()
        query = "SELECT SUM(Total) Total, SUM(PaidTotal) PaidTotal FROM Orders WHERE Date = @date"
        con.Open()
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@date", Date.Now.Date)
            Using dr As SqlDataReader = cmd.ExecuteReader
                If dr.Read() And Not dr.Item(0) Is DBNull.Value Then
                    lbltotalsell.Text = "Rs." & dr.Item("Total")
                    lbltotalrecieved.Text = "Rs." & dr.Item("PaidTotal")
                End If
            End Using
        End Using
        con.Close()
        query = "SELECT ProductName, Stock FROM Products WHERE Stock < 20"
        Using da As New SqlDataAdapter(query, con)
            Using ds As New DataSet
                da.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    gridlowstock.DataSource = ds.Tables(0)
                    gridlowstock.Visible = True
                    lbllowstock.Visible = True
                    gridlowstock.Columns("ProductName").HeaderText = "Product Name"
                    gridlowstock.Columns("Stock").HeaderText = "Bags"
                    gridlowstock.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    gridlowstock.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If
            End Using
        End Using
        Return 0
    End Function

    Private Sub Cmdviewstock_Click(sender As Object, e As EventArgs) Handles cmdviewstock.Click
        query = "Select * from Products"
        Using da As New SqlDataAdapter(query, con)
            Using ds As New DataSet
                da.Fill(ds)
                Using details As New StockDetails(ds)
                    details.ShowDialog()
                End Using
            End Using
        End Using
    End Sub

    Private Sub MainActivity_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        con.Dispose()
        dsBuyers.Dispose()
    End Sub
End Class