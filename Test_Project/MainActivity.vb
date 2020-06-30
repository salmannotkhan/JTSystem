Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports Xceed.Words.NET
Imports Spire.Doc
Public Class MainActivity
    ReadOnly con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Salman Shaikh\source\repos\Test_Project\Test_Project\JTBASE.mdf;Integrated Security=True;Connect Timeout=30")
    'ReadOnly con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Application.StartupPath & "\JTBASE.mdf;Integrated Security=True;Connect Timeout=30")
    Dim dsBuyers As New DataSet
    Dim query As String
    Dim total As Double
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
        If txtHSN.Text = "" Then txtHSN.Text = 0
        If txtLabour.Text = "" Then txtLabour.Text = 0
        Dim bId As Integer
        con.Open()
        query = "SELECT Id FROM Buyers WHERE Name = @name and city = @city"
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@name", txtBuyer.Text)
            cmd.Parameters.AddWithValue("@city", txtCity.Text)
            bId = cmd.ExecuteScalar
        End Using
        con.Close()

        If Not bId Then
            bId = InsertBuyersDetails()
        End If
        Calculations()
        Dim oId As Integer = InsertOrderDetails(bId)
        GenerateInvoice(oId)
        LoadOrders()
    End Sub

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

    Public Function InsertOrderDetails(id)
        con.Open()
        query = "INSERT INTO Orders VALUES(@buyerid, @date, @productname, @hsn, @rate, @qty, @labor, @total, @transporter); SELECT SCOPE_IDENTITY();"
        Dim oId As Integer
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@buyerid", id)
            cmd.Parameters.AddWithValue("@date", dateDate.Value)
            cmd.Parameters.AddWithValue("@productname", selectProduct.Text)
            cmd.Parameters.AddWithValue("@hsn", txtHSN.Text)
            cmd.Parameters.AddWithValue("@rate", txtRate.Text)
            cmd.Parameters.AddWithValue("@qty", txtQty.Text)
            cmd.Parameters.AddWithValue("@labor", txtLabour.Text)
            cmd.Parameters.AddWithValue("@total", total)
            cmd.Parameters.AddWithValue("@transporter", txtTransporter.Text)

            oId = cmd.ExecuteScalar
        End Using
        con.Close()
        Return oId
    End Function
    Private Function CheckData()
        Return 0
    End Function

    Private Function Calculations()
        rate = Math.Round((txtRate.Text * 100) / 105, 2)
        amount = Math.Round(txtQty.Text * rate, 2) ''Rate * Qty
        taxable = Math.Round(txtLabour.Text + amount, 2) ''Labour + Rate * Qty
        gst = Math.Round((taxable * 2.5) / 100, 2) ''(Labour + Rate * Qty) * 2.5 / 100
        total = Math.Round(taxable + 2 * gst, 2)
        fraction = FractionCalculate(total)
        total += fraction
        Return 0
    End Function

    Private Function GenerateInvoice(oId)
        Dim templatePath As String = Application.StartupPath & "/Template.docx"


        Using document = (DocX.Load(templatePath))
            '' Buyer's Details
            document.Bookmarks("buyer").SetText(txtBuyer.Text) ''Input Type: Text
            document.Bookmarks("address").SetText(txtAddress.Text) ''Input Type: Text
            document.Bookmarks("city").SetText(txtCity.Text) ''Input Type: Text
            document.Bookmarks("mobile").SetText(txtMobile.Text) ''Input Type: Text
            document.Bookmarks("gstno").SetText(txtGSTNo.Text.ToUpper) ''Input Type: Text
            document.Bookmarks("placesupply").SetText(txtPlace.Text) ''Input Type: Text

            document.Bookmarks("invoice").SetText(oId) ''Automatic
            document.Bookmarks("date").SetText(dateDate.Text) ''Input Type: Date
            document.Bookmarks("transporter").SetText(txtTransporter.Text) ''Input Type: Text

            '' Product Details
            document.Bookmarks("no").SetText("1") ''Automatic
            document.Bookmarks("productname").SetText(selectProduct.Text) ''Input Type: Selection
            document.Bookmarks("hsn").SetText(txtHSN.Text) ''Input
            document.Bookmarks("bags").SetText("") ''Input
            document.Bookmarks("qty").SetText(txtQty.Text) ''Automatic

            document.Bookmarks("net").SetText(Math.Round(Val(txtRate.Text), 2).ToString("F")) ''Input Probably Automatic
            document.Bookmarks("rate").SetText(rate.ToString("F")) ''Input
            document.Bookmarks("gst").SetText(txtGST.Text & "%") ''Input

            document.Bookmarks("amount").SetText(amount.ToString("F"))
            document.Bookmarks("subtotal").SetText(amount.ToString("F"))


            '' Office Work
            document.Bookmarks("labour").SetText(Math.Round(Val(txtLabour.Text), 2).ToString("F")) ''Input
            document.Bookmarks("taxable").SetText(taxable.ToString("F"))
            document.Bookmarks("cgst").SetText(gst.ToString("F"))
            document.Bookmarks("sgst").SetText(gst.ToString("F"))

            If fraction <> 0 Then
                document.Bookmarks("round").SetText(fraction.ToString("F"))
            Else
                document.Tables.First().RemoveRow(14)
            End If

            document.Bookmarks("total").SetText(total & ".00") ''Taxable amount + CGST + SGST

            document.Bookmarks("invoice2").SetText(oId) '' Automatic
            document.Bookmarks("date2").SetText(dateDate.Text) '' Input
            document.Bookmarks("total2").SetText(total & ".00")
            document.Bookmarks("due").SetText(1)

            document.Bookmarks("totalwords").SetText(NumeriCon.ConvertNum(Int(total)) & " Only") ''Automatic

            document.SaveAs(Application.StartupPath & "/Order " & oId & ".docx")
            Using confirm As New CustomDialog("Confirmation", "Do you want to print invoice?", "Print", "No, Thanks")
                Dim result = confirm.ShowDialog
                If result = Windows.Forms.DialogResult.Yes Then
                    PrintInvoice(oId)
                End If
            End Using
        End Using
        Return 0
    End Function

    Private Function PrintInvoice(oId)
        Dim path As String = Application.StartupPath & "/Order " & oId & ".docx"
        Using doc As New Document(path)
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

    Private Sub MainActivity_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadOrders()
        LoadSuggestions()
        LoadProducts()
        inventorypanel.Hide()
        detailspanel.Hide()
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
            selectProductList.DataSource = ds.Tables(0)
            selectProductList.DisplayMember = "Productname"
            selectProductList.ValueMember = "Id"
            selectProduct.DataSource = ds.Tables(0)
            selectProductList.DisplayMember = "Productname"
        End Using
        Return 0
    End Function

    Private Function LoadOrders()
        dataDetails.AlternatingRowsDefaultCellStyle = Nothing
        query = "SELECT Orders.Id, Name, City, Date, Total FROM Buyers, Orders WHERE BuyerId = Buyers.Id"
        Using da As New SqlDataAdapter(query, con)
            Using ds As New DataSet
                da.Fill(ds)
                dataDetails.DataSource = ds.Tables(0)
                dataDetails.Refresh()
            End Using
        End Using
        If dataDetails.Columns("View Details") Is Nothing Then
            Using viewdetails As New DataGridViewButtonColumn
                With viewdetails
                    .Name = "View Details"
                    .HeaderText = "Details"
                    .Text = "View"
                    .UseColumnTextForButtonValue = True
                    .FlatStyle = FlatStyle.Flat
                    .DefaultCellStyle.BackColor = Color.Black
                    .DefaultCellStyle.ForeColor = Color.White
                End With
                dataDetails.Columns.Add(viewdetails)
            End Using
        End If
        dataDetails.Columns("Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dataDetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        dataDetails.Columns("Id").HeaderText = "Invoice"
        dataDetails.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Return 0
    End Function
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

    Private Sub HoverEffect(sender As Object, e As EventArgs) Handles cmdminimize.MouseEnter, cmdclose.MouseEnter, cmdbilling.MouseEnter, cmdorder.MouseEnter, cmdinventory.MouseEnter
        sender.ForeColor = Color.Black
        sender.BackColor = Color.White
    End Sub

    Private Sub HoverEffectEnd(sender As Object, e As EventArgs) Handles cmdminimize.MouseLeave, cmdclose.MouseLeave, cmdbilling.MouseLeave, cmdorder.MouseLeave, cmdinventory.MouseLeave
        sender.ForeColor = Color.White
        sender.BackColor = Color.Black
    End Sub

    Private Sub DataDetails_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataDetails.CellContentClick
        If e.ColumnIndex = dataDetails.Columns("View Details").Index And e.RowIndex >= 0 Then
            Dim oId As Integer = dataDetails.Rows(e.RowIndex).Cells("Id").Value
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
                            "Product Name: ",
                            "Quantity: " & dr.Item("Qty"),
                            "Rate: " & dr.Item("Rate"),
                            "Total: " & dr.Item("Total"))
                        Using details As New ViewDetailsBox(desc)
                            Dim result = details.ShowDialog
                            If result = DialogResult.Yes Then
                                txtBuyer.Text = dr.Item("Name")
                                txtAddress.Text = dr.Item("Address")
                                txtCity.Text = dr.Item("City")
                                txtGST.Text = 5
                                txtGSTNo.Text = dr.Item("GST")
                                txtHSN.Text = dr.Item("HSN")
                                txtLabour.Text = dr.Item("Labor")
                                txtMobile.Text = dr.Item("Mobile")
                                txtPlace.Text = dr.Item("State")
                                txtQty.Text = dr.Item("Qty")
                                txtRate.Text = dr.Item("Rate")
                                txtTransporter.Text = dr.Item("Transporter")
                                dateDate.Value = dr.Item("Date")
                                GenerateInvoice(oId)
                            ElseIf result = DialogResult.No Then
                                Using confirm As New CustomDialog("Confirmation", "Are you sure You want to delete?", "Yes, I'm sure", "No")
                                    Dim confirmation = confirm.ShowDialog
                                    If confirmation = DialogResult.Yes Then
                                        Using cmd As New SqlCommand("DELETE FROM Orders WHERE Id = @oid", con)
                                            cmd.Parameters.AddWithValue("@oid", oId)
                                            cmd.ExecuteNonQuery()
                                        End Using
                                        Using cmd As New SqlCommand("SELECT COUNT(*) FROM Orders WHERE Buyerid = @buyerid", con)
                                            cmd.Parameters.AddWithValue("@buyersid", dr.Item("BuyerId"))
                                            If cmd.ExecuteScalar() = 0 Then
                                                Using cmd2 As New SqlCommand("DELETE FROM Buyers WHERE Id = @buyersid", con)
                                                    cmd2.Parameters.AddWithValue("@buyersid", dr.Item("Buyerid"))
                                                End Using
                                            End If
                                        End Using
                                    End If
                                End Using
                                LoadOrders()
                            End If
                        End Using
                    End If
                End Using
            End Using
            con.Close()
        End If
    End Sub

    Private Sub Cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtProductName.Text <> "" Then
            query = "INSERT INTO Products VALUES(@productname)"
            con.Open()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@productname", txtProductName.Text)
                cmd.ExecuteNonQuery()
            End Using
            con.Close()
            LoadProducts()
        End If
    End Sub

    Private Sub Cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        query = "DELETE FROM Products WHERE Id = @id"
        con.Open()
        Using cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@id", selectProductList.SelectedValue)
            cmd.ExecuteNonQuery()
        End Using
        con.Close()
        LoadProducts()
    End Sub

    Private Sub NavigationPanel(sender As Object, e As EventArgs) Handles cmdinventory.Click, cmdbilling.Click, cmdorder.Click
        For Each control In Me.Controls
            If control.name <> "navpanel" Then
                If TypeOf control Is Panel And control.name Is CType(sender, Label).Tag Then
                    control.Show()
                Else
                    control.Hide()
                End If
            End If
        Next
    End Sub
End Class