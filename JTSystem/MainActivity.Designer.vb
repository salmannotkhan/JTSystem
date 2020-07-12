<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainActivity
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainActivity))
        Me.navpanel = New System.Windows.Forms.Panel()
        Me.cmdsummary = New System.Windows.Forms.Label()
        Me.cmdorder = New System.Windows.Forms.Label()
        Me.cmdinventory = New System.Windows.Forms.Label()
        Me.cmdminimize = New System.Windows.Forms.Label()
        Me.cmdclose = New System.Windows.Forms.Label()
        Me.cmdbilling = New System.Windows.Forms.Label()
        Me.billingpanel = New System.Windows.Forms.Panel()
        Me.cmdgstdisable = New System.Windows.Forms.Button()
        Me.txtNewInvoice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.selectProduct = New System.Windows.Forms.ComboBox()
        Me.dateToday = New System.Windows.Forms.DateTimePicker()
        Me.txtTransporter = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLabour = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.txtGST = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBags = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHSN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGSTNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBuyer = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.inventorypanel = New System.Windows.Forms.Panel()
        Me.cmdviewstock = New System.Windows.Forms.Label()
        Me.cmdAbout = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.dateBuy = New System.Windows.Forms.DateTimePicker()
        Me.selectProductlistbuy = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtbuyqty = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtbuyrate = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdpurchase = New System.Windows.Forms.Button()
        Me.txtseller = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewProduct = New System.Windows.Forms.TextBox()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectProductList = New System.Windows.Forms.ComboBox()
        Me.summarypanel = New System.Windows.Forms.Panel()
        Me.gridlowstock = New System.Windows.Forms.DataGridView()
        Me.lbllowstock = New System.Windows.Forms.Label()
        Me.lbltotalrecieved = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbltotalsell = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.detailspanel = New System.Windows.Forms.Panel()
        Me.gridDetails = New System.Windows.Forms.DataGridView()
        Me.navpanel.SuspendLayout()
        Me.billingpanel.SuspendLayout()
        Me.inventorypanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.summarypanel.SuspendLayout()
        CType(Me.gridlowstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailspanel.SuspendLayout()
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'navpanel
        '
        Me.navpanel.BackColor = System.Drawing.Color.Black
        Me.navpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.navpanel.Controls.Add(Me.cmdsummary)
        Me.navpanel.Controls.Add(Me.cmdorder)
        Me.navpanel.Controls.Add(Me.cmdinventory)
        Me.navpanel.Controls.Add(Me.cmdminimize)
        Me.navpanel.Controls.Add(Me.cmdclose)
        Me.navpanel.Controls.Add(Me.cmdbilling)
        Me.navpanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.navpanel.Location = New System.Drawing.Point(0, 0)
        Me.navpanel.Name = "navpanel"
        Me.navpanel.Size = New System.Drawing.Size(800, 45)
        Me.navpanel.TabIndex = 0
        '
        'cmdsummary
        '
        Me.cmdsummary.AutoSize = True
        Me.cmdsummary.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsummary.ForeColor = System.Drawing.Color.White
        Me.cmdsummary.Location = New System.Drawing.Point(11, 3)
        Me.cmdsummary.Name = "cmdsummary"
        Me.cmdsummary.Padding = New System.Windows.Forms.Padding(10)
        Me.cmdsummary.Size = New System.Drawing.Size(88, 39)
        Me.cmdsummary.TabIndex = 5
        Me.cmdsummary.Tag = "summarypanel"
        Me.cmdsummary.Text = "Summary"
        '
        'cmdorder
        '
        Me.cmdorder.AutoSize = True
        Me.cmdorder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdorder.ForeColor = System.Drawing.Color.White
        Me.cmdorder.Location = New System.Drawing.Point(181, 3)
        Me.cmdorder.Name = "cmdorder"
        Me.cmdorder.Padding = New System.Windows.Forms.Padding(10)
        Me.cmdorder.Size = New System.Drawing.Size(109, 39)
        Me.cmdorder.TabIndex = 1
        Me.cmdorder.Tag = "detailspanel"
        Me.cmdorder.Text = "View Orders"
        '
        'cmdinventory
        '
        Me.cmdinventory.AutoSize = True
        Me.cmdinventory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdinventory.ForeColor = System.Drawing.Color.White
        Me.cmdinventory.Location = New System.Drawing.Point(296, 3)
        Me.cmdinventory.Name = "cmdinventory"
        Me.cmdinventory.Padding = New System.Windows.Forms.Padding(10)
        Me.cmdinventory.Size = New System.Drawing.Size(89, 39)
        Me.cmdinventory.TabIndex = 4
        Me.cmdinventory.Tag = "inventorypanel"
        Me.cmdinventory.Text = "Inventory"
        '
        'cmdminimize
        '
        Me.cmdminimize.AutoSize = True
        Me.cmdminimize.BackColor = System.Drawing.Color.Black
        Me.cmdminimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdminimize.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdminimize.ForeColor = System.Drawing.Color.White
        Me.cmdminimize.Location = New System.Drawing.Point(635, 8)
        Me.cmdminimize.Name = "cmdminimize"
        Me.cmdminimize.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdminimize.Size = New System.Drawing.Size(80, 31)
        Me.cmdminimize.TabIndex = 3
        Me.cmdminimize.Text = "Minimize"
        '
        'cmdclose
        '
        Me.cmdclose.AutoSize = True
        Me.cmdclose.BackColor = System.Drawing.Color.Black
        Me.cmdclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.White
        Me.cmdclose.Location = New System.Drawing.Point(721, 8)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdclose.Size = New System.Drawing.Size(57, 31)
        Me.cmdclose.TabIndex = 2
        Me.cmdclose.Text = "Close"
        '
        'cmdbilling
        '
        Me.cmdbilling.AutoSize = True
        Me.cmdbilling.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbilling.ForeColor = System.Drawing.Color.White
        Me.cmdbilling.Location = New System.Drawing.Point(105, 3)
        Me.cmdbilling.Name = "cmdbilling"
        Me.cmdbilling.Padding = New System.Windows.Forms.Padding(10)
        Me.cmdbilling.Size = New System.Drawing.Size(70, 39)
        Me.cmdbilling.TabIndex = 0
        Me.cmdbilling.Tag = "billingpanel"
        Me.cmdbilling.Text = "Billing"
        '
        'billingpanel
        '
        Me.billingpanel.BackColor = System.Drawing.Color.White
        Me.billingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.billingpanel.Controls.Add(Me.cmdgstdisable)
        Me.billingpanel.Controls.Add(Me.txtNewInvoice)
        Me.billingpanel.Controls.Add(Me.Label19)
        Me.billingpanel.Controls.Add(Me.Label9)
        Me.billingpanel.Controls.Add(Me.selectProduct)
        Me.billingpanel.Controls.Add(Me.dateToday)
        Me.billingpanel.Controls.Add(Me.txtTransporter)
        Me.billingpanel.Controls.Add(Me.Label13)
        Me.billingpanel.Controls.Add(Me.txtLabour)
        Me.billingpanel.Controls.Add(Me.Label12)
        Me.billingpanel.Controls.Add(Me.cmdGenerate)
        Me.billingpanel.Controls.Add(Me.txtGST)
        Me.billingpanel.Controls.Add(Me.Label11)
        Me.billingpanel.Controls.Add(Me.txtRate)
        Me.billingpanel.Controls.Add(Me.Label10)
        Me.billingpanel.Controls.Add(Me.txtBags)
        Me.billingpanel.Controls.Add(Me.Label8)
        Me.billingpanel.Controls.Add(Me.txtHSN)
        Me.billingpanel.Controls.Add(Me.Label7)
        Me.billingpanel.Controls.Add(Me.txtMobile)
        Me.billingpanel.Controls.Add(Me.Label4)
        Me.billingpanel.Controls.Add(Me.txtGSTNo)
        Me.billingpanel.Controls.Add(Me.Label5)
        Me.billingpanel.Controls.Add(Me.txtPlace)
        Me.billingpanel.Controls.Add(Me.Label6)
        Me.billingpanel.Controls.Add(Me.txtCity)
        Me.billingpanel.Controls.Add(Me.Label3)
        Me.billingpanel.Controls.Add(Me.txtAddress)
        Me.billingpanel.Controls.Add(Me.Label14)
        Me.billingpanel.Controls.Add(Me.txtBuyer)
        Me.billingpanel.Controls.Add(Me.Label15)
        Me.billingpanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.billingpanel.ForeColor = System.Drawing.Color.White
        Me.billingpanel.Location = New System.Drawing.Point(0, 45)
        Me.billingpanel.Name = "billingpanel"
        Me.billingpanel.Size = New System.Drawing.Size(800, 405)
        Me.billingpanel.TabIndex = 1
        '
        'cmdgstdisable
        '
        Me.cmdgstdisable.BackColor = System.Drawing.Color.White
        Me.cmdgstdisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgstdisable.ForeColor = System.Drawing.Color.Black
        Me.cmdgstdisable.Location = New System.Drawing.Point(327, 199)
        Me.cmdgstdisable.Name = "cmdgstdisable"
        Me.cmdgstdisable.Size = New System.Drawing.Size(22, 23)
        Me.cmdgstdisable.TabIndex = 112
        Me.cmdgstdisable.Text = "X"
        Me.cmdgstdisable.UseVisualStyleBackColor = False
        '
        'txtNewInvoice
        '
        Me.txtNewInvoice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewInvoice.Location = New System.Drawing.Point(157, 27)
        Me.txtNewInvoice.Name = "txtNewInvoice"
        Me.txtNewInvoice.Size = New System.Drawing.Size(72, 27)
        Me.txtNewInvoice.TabIndex = 111
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(15, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 19)
        Me.Label19.TabIndex = 110
        Me.Label19.Text = "Invoice No.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(432, 110)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 19)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Product Name:"
        '
        'selectProduct
        '
        Me.selectProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.selectProduct.Cursor = System.Windows.Forms.Cursors.Default
        Me.selectProduct.DisplayMember = "ProductName"
        Me.selectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectProduct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectProduct.FormattingEnabled = True
        Me.selectProduct.ItemHeight = 19
        Me.selectProduct.Location = New System.Drawing.Point(563, 107)
        Me.selectProduct.Margin = New System.Windows.Forms.Padding(2)
        Me.selectProduct.Name = "selectProduct"
        Me.selectProduct.Size = New System.Drawing.Size(226, 27)
        Me.selectProduct.TabIndex = 8
        Me.selectProduct.ValueMember = "ProductName"
        '
        'dateToday
        '
        Me.dateToday.CustomFormat = "dd/MM/yyyy"
        Me.dateToday.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateToday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateToday.Location = New System.Drawing.Point(563, 24)
        Me.dateToday.Margin = New System.Windows.Forms.Padding(2)
        Me.dateToday.Name = "dateToday"
        Me.dateToday.Size = New System.Drawing.Size(226, 27)
        Me.dateToday.TabIndex = 109
        '
        'txtTransporter
        '
        Me.txtTransporter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransporter.Location = New System.Drawing.Point(157, 257)
        Me.txtTransporter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransporter.Name = "txtTransporter"
        Me.txtTransporter.Size = New System.Drawing.Size(132, 27)
        Me.txtTransporter.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(15, 260)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 19)
        Me.Label13.TabIndex = 107
        Me.Label13.Text = "Transporter:"
        '
        'txtLabour
        '
        Me.txtLabour.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabour.Location = New System.Drawing.Point(563, 257)
        Me.txtLabour.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLabour.Name = "txtLabour"
        Me.txtLabour.Size = New System.Drawing.Size(92, 27)
        Me.txtLabour.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(432, 260)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 19)
        Me.Label12.TabIndex = 105
        Me.Label12.Text = "Labor:"
        '
        'cmdGenerate
        '
        Me.cmdGenerate.BackColor = System.Drawing.Color.White
        Me.cmdGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGenerate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.ForeColor = System.Drawing.Color.Black
        Me.cmdGenerate.Location = New System.Drawing.Point(276, 325)
        Me.cmdGenerate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(216, 48)
        Me.cmdGenerate.TabIndex = 14
        Me.cmdGenerate.Text = "Generate Bill"
        Me.cmdGenerate.UseVisualStyleBackColor = False
        '
        'txtGST
        '
        Me.txtGST.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGST.Location = New System.Drawing.Point(563, 227)
        Me.txtGST.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGST.Name = "txtGST"
        Me.txtGST.Size = New System.Drawing.Size(91, 27)
        Me.txtGST.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(432, 230)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 19)
        Me.Label11.TabIndex = 102
        Me.Label11.Text = "GST:"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(563, 197)
        Me.txtRate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(91, 27)
        Me.txtRate.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(432, 200)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 19)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "Rate:"
        '
        'txtBags
        '
        Me.txtBags.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBags.Location = New System.Drawing.Point(563, 167)
        Me.txtBags.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBags.Name = "txtBags"
        Me.txtBags.Size = New System.Drawing.Size(91, 27)
        Me.txtBags.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(432, 170)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 19)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Bags:"
        '
        'txtHSN
        '
        Me.txtHSN.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHSN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtHSN.Location = New System.Drawing.Point(563, 137)
        Me.txtHSN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtHSN.Name = "txtHSN"
        Me.txtHSN.Size = New System.Drawing.Size(91, 27)
        Me.txtHSN.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(432, 140)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 19)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "HSN Code:"
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(157, 167)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(165, 27)
        Me.txtMobile.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "GST No.:"
        '
        'txtGSTNo
        '
        Me.txtGSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtGSTNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGSTNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSTNo.Location = New System.Drawing.Point(157, 197)
        Me.txtGSTNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGSTNo.Name = "txtGSTNo"
        Me.txtGSTNo.Size = New System.Drawing.Size(165, 27)
        Me.txtGSTNo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 110)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 19)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Address:"
        '
        'txtPlace
        '
        Me.txtPlace.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlace.Location = New System.Drawing.Point(157, 227)
        Me.txtPlace.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(132, 27)
        Me.txtPlace.TabIndex = 6
        Me.txtPlace.Text = "24-Gujarat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(15, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 19)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "M/S:"
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(157, 137)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(165, 27)
        Me.txtCity.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Place Of Supply:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(157, 107)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(230, 27)
        Me.txtAddress.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 140)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 19)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "City:"
        '
        'txtBuyer
        '
        Me.txtBuyer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBuyer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtBuyer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuyer.Location = New System.Drawing.Point(157, 77)
        Me.txtBuyer.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuyer.Name = "txtBuyer"
        Me.txtBuyer.Size = New System.Drawing.Size(230, 27)
        Me.txtBuyer.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(15, 170)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 19)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Mobile No.:"
        '
        'inventorypanel
        '
        Me.inventorypanel.BackColor = System.Drawing.Color.White
        Me.inventorypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inventorypanel.Controls.Add(Me.cmdviewstock)
        Me.inventorypanel.Controls.Add(Me.cmdAbout)
        Me.inventorypanel.Controls.Add(Me.GroupBox2)
        Me.inventorypanel.Controls.Add(Me.GroupBox1)
        Me.inventorypanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventorypanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventorypanel.ForeColor = System.Drawing.Color.Black
        Me.inventorypanel.Location = New System.Drawing.Point(0, 45)
        Me.inventorypanel.Name = "inventorypanel"
        Me.inventorypanel.Size = New System.Drawing.Size(800, 405)
        Me.inventorypanel.TabIndex = 3
        '
        'cmdviewstock
        '
        Me.cmdviewstock.AutoSize = True
        Me.cmdviewstock.BackColor = System.Drawing.Color.Black
        Me.cmdviewstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdviewstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdviewstock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdviewstock.ForeColor = System.Drawing.Color.White
        Me.cmdviewstock.Location = New System.Drawing.Point(84, 364)
        Me.cmdviewstock.Name = "cmdviewstock"
        Me.cmdviewstock.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdviewstock.Size = New System.Drawing.Size(91, 31)
        Me.cmdviewstock.TabIndex = 17
        Me.cmdviewstock.Text = "View Stock"
        '
        'cmdAbout
        '
        Me.cmdAbout.AutoSize = True
        Me.cmdAbout.BackColor = System.Drawing.Color.White
        Me.cmdAbout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.Black
        Me.cmdAbout.Location = New System.Drawing.Point(19, 364)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdAbout.Size = New System.Drawing.Size(59, 31)
        Me.cmdAbout.TabIndex = 16
        Me.cmdAbout.Text = "About"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.dateBuy)
        Me.GroupBox2.Controls.Add(Me.selectProductlistbuy)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtbuyqty)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtbuyrate)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmdpurchase)
        Me.GroupBox2.Controls.Add(Me.txtseller)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 137)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product Purchase"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(565, 50)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 19)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Date:"
        '
        'dateBuy
        '
        Me.dateBuy.CustomFormat = "dd/MM/yyyy"
        Me.dateBuy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateBuy.Location = New System.Drawing.Point(620, 46)
        Me.dateBuy.Name = "dateBuy"
        Me.dateBuy.Size = New System.Drawing.Size(119, 27)
        Me.dateBuy.TabIndex = 21
        '
        'selectProductlistbuy
        '
        Me.selectProductlistbuy.DisplayMember = "Id"
        Me.selectProductlistbuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectProductlistbuy.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectProductlistbuy.FormattingEnabled = True
        Me.selectProductlistbuy.Location = New System.Drawing.Point(157, 46)
        Me.selectProductlistbuy.Name = "selectProductlistbuy"
        Me.selectProductlistbuy.Size = New System.Drawing.Size(159, 27)
        Me.selectProductlistbuy.TabIndex = 20
        Me.selectProductlistbuy.ValueMember = "Id"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(333, 100)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 19)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Bags:"
        '
        'txtbuyqty
        '
        Me.txtbuyqty.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuyqty.Location = New System.Drawing.Point(398, 97)
        Me.txtbuyqty.Name = "txtbuyqty"
        Me.txtbuyqty.Size = New System.Drawing.Size(127, 27)
        Me.txtbuyqty.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(32, 100)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 19)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Rate:"
        '
        'txtbuyrate
        '
        Me.txtbuyrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuyrate.Location = New System.Drawing.Point(157, 97)
        Me.txtbuyrate.Name = "txtbuyrate"
        Me.txtbuyrate.Size = New System.Drawing.Size(127, 27)
        Me.txtbuyrate.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(333, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 19)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Seller:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 19)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Product Name: "
        '
        'cmdpurchase
        '
        Me.cmdpurchase.AutoSize = True
        Me.cmdpurchase.BackColor = System.Drawing.Color.Black
        Me.cmdpurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdpurchase.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdpurchase.ForeColor = System.Drawing.Color.White
        Me.cmdpurchase.Location = New System.Drawing.Point(542, 92)
        Me.cmdpurchase.Name = "cmdpurchase"
        Me.cmdpurchase.Padding = New System.Windows.Forms.Padding(2)
        Me.cmdpurchase.Size = New System.Drawing.Size(157, 35)
        Me.cmdpurchase.TabIndex = 20
        Me.cmdpurchase.Text = "Purchase"
        Me.cmdpurchase.UseVisualStyleBackColor = False
        '
        'txtseller
        '
        Me.txtseller.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtseller.Location = New System.Drawing.Point(398, 46)
        Me.txtseller.Name = "txtseller"
        Me.txtseller.Size = New System.Drawing.Size(145, 27)
        Me.txtseller.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewProduct)
        Me.GroupBox1.Controls.Add(Me.cmddelete)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.selectProductList)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 167)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Management"
        '
        'txtNewProduct
        '
        Me.txtNewProduct.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewProduct.Location = New System.Drawing.Point(157, 46)
        Me.txtNewProduct.Name = "txtNewProduct"
        Me.txtNewProduct.Size = New System.Drawing.Size(159, 27)
        Me.txtNewProduct.TabIndex = 13
        '
        'cmddelete
        '
        Me.cmddelete.AutoSize = True
        Me.cmddelete.BackColor = System.Drawing.Color.Black
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmddelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.Color.White
        Me.cmddelete.Location = New System.Drawing.Point(337, 119)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Padding = New System.Windows.Forms.Padding(2)
        Me.cmddelete.Size = New System.Drawing.Size(157, 35)
        Me.cmddelete.TabIndex = 14
        Me.cmddelete.Text = "Delete Product"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'cmdadd
        '
        Me.cmdadd.AutoSize = True
        Me.cmdadd.BackColor = System.Drawing.Color.Black
        Me.cmdadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdadd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdadd.ForeColor = System.Drawing.Color.White
        Me.cmdadd.Location = New System.Drawing.Point(337, 42)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Padding = New System.Windows.Forms.Padding(2)
        Me.cmdadd.Size = New System.Drawing.Size(156, 35)
        Me.cmdadd.TabIndex = 15
        Me.cmdadd.Text = "Add Product"
        Me.cmdadd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product Name:"
        '
        'selectProductList
        '
        Me.selectProductList.DisplayMember = "Id"
        Me.selectProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectProductList.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectProductList.FormattingEnabled = True
        Me.selectProductList.Location = New System.Drawing.Point(157, 123)
        Me.selectProductList.Name = "selectProductList"
        Me.selectProductList.Size = New System.Drawing.Size(159, 27)
        Me.selectProductList.TabIndex = 10
        Me.selectProductList.ValueMember = "Id"
        '
        'summarypanel
        '
        Me.summarypanel.BackColor = System.Drawing.Color.White
        Me.summarypanel.Controls.Add(Me.gridlowstock)
        Me.summarypanel.Controls.Add(Me.lbllowstock)
        Me.summarypanel.Controls.Add(Me.lbltotalrecieved)
        Me.summarypanel.Controls.Add(Me.Label22)
        Me.summarypanel.Controls.Add(Me.lbltotalsell)
        Me.summarypanel.Controls.Add(Me.Label20)
        Me.summarypanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.summarypanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.summarypanel.Location = New System.Drawing.Point(0, 45)
        Me.summarypanel.Name = "summarypanel"
        Me.summarypanel.Size = New System.Drawing.Size(800, 405)
        Me.summarypanel.TabIndex = 5
        '
        'gridlowstock
        '
        Me.gridlowstock.AllowUserToAddRows = False
        Me.gridlowstock.AllowUserToDeleteRows = False
        Me.gridlowstock.AllowUserToResizeColumns = False
        Me.gridlowstock.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.gridlowstock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridlowstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridlowstock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridlowstock.BackgroundColor = System.Drawing.Color.White
        Me.gridlowstock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridlowstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridlowstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridlowstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridlowstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(1, 5, 1, 5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridlowstock.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridlowstock.GridColor = System.Drawing.Color.White
        Me.gridlowstock.Location = New System.Drawing.Point(277, 138)
        Me.gridlowstock.MultiSelect = False
        Me.gridlowstock.Name = "gridlowstock"
        Me.gridlowstock.ReadOnly = True
        Me.gridlowstock.RowHeadersVisible = False
        Me.gridlowstock.ShowCellErrors = False
        Me.gridlowstock.ShowCellToolTips = False
        Me.gridlowstock.ShowEditingIcon = False
        Me.gridlowstock.ShowRowErrors = False
        Me.gridlowstock.Size = New System.Drawing.Size(233, 236)
        Me.gridlowstock.TabIndex = 5
        Me.gridlowstock.Visible = False
        '
        'lbllowstock
        '
        Me.lbllowstock.AutoSize = True
        Me.lbllowstock.Location = New System.Drawing.Point(236, 108)
        Me.lbllowstock.Name = "lbllowstock"
        Me.lbllowstock.Size = New System.Drawing.Size(133, 19)
        Me.lbllowstock.TabIndex = 4
        Me.lbllowstock.Text = "Low stock warning:"
        Me.lbllowstock.Visible = False
        '
        'lbltotalrecieved
        '
        Me.lbltotalrecieved.AutoSize = True
        Me.lbltotalrecieved.Location = New System.Drawing.Point(431, 77)
        Me.lbltotalrecieved.Name = "lbltotalrecieved"
        Me.lbltotalrecieved.Size = New System.Drawing.Size(61, 19)
        Me.lbltotalrecieved.TabIndex = 3
        Me.lbltotalrecieved.Text = "Rs. 0.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(236, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(189, 19)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Total collection of the day : "
        '
        'lbltotalsell
        '
        Me.lbltotalsell.AutoSize = True
        Me.lbltotalsell.Location = New System.Drawing.Point(431, 46)
        Me.lbltotalsell.Name = "lbltotalsell"
        Me.lbltotalsell.Size = New System.Drawing.Size(61, 19)
        Me.lbltotalsell.TabIndex = 1
        Me.lbltotalsell.Text = "Rs. 0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(256, 46)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(169, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Total selling of the day : "
        '
        'detailspanel
        '
        Me.detailspanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.detailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.detailspanel.Controls.Add(Me.gridDetails)
        Me.detailspanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.detailspanel.ForeColor = System.Drawing.Color.Black
        Me.detailspanel.Location = New System.Drawing.Point(0, 45)
        Me.detailspanel.Name = "detailspanel"
        Me.detailspanel.Size = New System.Drawing.Size(800, 405)
        Me.detailspanel.TabIndex = 2
        '
        'gridDetails
        '
        Me.gridDetails.AllowUserToAddRows = False
        Me.gridDetails.AllowUserToDeleteRows = False
        Me.gridDetails.AllowUserToResizeColumns = False
        Me.gridDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.gridDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridDetails.BackgroundColor = System.Drawing.Color.White
        Me.gridDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(1, 5, 1, 5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridDetails.DefaultCellStyle = DataGridViewCellStyle6
        Me.gridDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDetails.GridColor = System.Drawing.Color.White
        Me.gridDetails.Location = New System.Drawing.Point(0, 0)
        Me.gridDetails.MultiSelect = False
        Me.gridDetails.Name = "gridDetails"
        Me.gridDetails.ReadOnly = True
        Me.gridDetails.RowHeadersVisible = False
        Me.gridDetails.ShowCellErrors = False
        Me.gridDetails.ShowCellToolTips = False
        Me.gridDetails.ShowEditingIcon = False
        Me.gridDetails.ShowRowErrors = False
        Me.gridDetails.Size = New System.Drawing.Size(798, 403)
        Me.gridDetails.TabIndex = 4
        '
        'MainActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inventorypanel)
        Me.Controls.Add(Me.summarypanel)
        Me.Controls.Add(Me.detailspanel)
        Me.Controls.Add(Me.billingpanel)
        Me.Controls.Add(Me.navpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTSystem"
        Me.navpanel.ResumeLayout(False)
        Me.navpanel.PerformLayout()
        Me.billingpanel.ResumeLayout(False)
        Me.billingpanel.PerformLayout()
        Me.inventorypanel.ResumeLayout(False)
        Me.inventorypanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.summarypanel.ResumeLayout(False)
        Me.summarypanel.PerformLayout()
        CType(Me.gridlowstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailspanel.ResumeLayout(False)
        CType(Me.gridDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navpanel As Panel
    Friend WithEvents billingpanel As Panel
    Friend WithEvents cmdorder As Label
    Friend WithEvents cmdbilling As Label
    Friend WithEvents dateToday As DateTimePicker
    Friend WithEvents txtTransporter As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtLabour As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdGenerate As Button
    Friend WithEvents txtGST As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBags As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtHSN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents selectProduct As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGSTNo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPlace As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBuyer As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cmdclose As Label
    Friend WithEvents cmdminimize As Label
    Friend WithEvents detailspanel As Panel
    Friend WithEvents inventorypanel As Panel
    Friend WithEvents cmdinventory As Label
    Friend WithEvents txtNewInvoiceNo As TextBox
    Friend WithEvents cmdSetInvoiceNo As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmdpurchase As Button
    Friend WithEvents txtseller As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNewProduct As TextBox
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents selectProductList As ComboBox
    Friend WithEvents txtNewInvoice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents gridDetails As DataGridView
    Friend WithEvents cmdAbout As Label
    Friend WithEvents cmdgstdisable As Button
    Friend WithEvents cmdsummary As Label
    Friend WithEvents summarypanel As Panel
    Friend WithEvents lbltotalsell As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbltotalrecieved As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents gridlowstock As DataGridView
    Friend WithEvents lbllowstock As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtbuyqty As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbuyrate As TextBox
    Friend WithEvents selectProductlistbuy As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents dateBuy As DateTimePicker
    Friend WithEvents cmdviewstock As Label
End Class
