﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.navpanel = New System.Windows.Forms.Panel()
        Me.cmdorder = New System.Windows.Forms.Label()
        Me.cmdinventory = New System.Windows.Forms.Label()
        Me.cmdminimize = New System.Windows.Forms.Label()
        Me.cmdclose = New System.Windows.Forms.Label()
        Me.cmdbilling = New System.Windows.Forms.Label()
        Me.billingpanel = New System.Windows.Forms.Panel()
        Me.txtNewInvoice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.selectProduct = New System.Windows.Forms.ComboBox()
        Me.dateDate = New System.Windows.Forms.DateTimePicker()
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
        Me.detailspanel = New System.Windows.Forms.Panel()
        Me.dataDetails = New System.Windows.Forms.DataGridView()
        Me.inventorypanel = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdrecieved = New System.Windows.Forms.Button()
        Me.selectOrderId = New System.Windows.Forms.ComboBox()
        Me.txtRecTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNewProduct = New System.Windows.Forms.TextBox()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectProductList = New System.Windows.Forms.ComboBox()
        Me.cmdAbout = New System.Windows.Forms.Label()
        Me.navpanel.SuspendLayout()
        Me.billingpanel.SuspendLayout()
        Me.detailspanel.SuspendLayout()
        CType(Me.dataDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventorypanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'navpanel
        '
        Me.navpanel.BackColor = System.Drawing.Color.Black
        Me.navpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        'cmdorder
        '
        Me.cmdorder.AutoSize = True
        Me.cmdorder.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdorder.ForeColor = System.Drawing.Color.White
        Me.cmdorder.Location = New System.Drawing.Point(88, 3)
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
        Me.cmdinventory.Location = New System.Drawing.Point(203, 3)
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
        Me.cmdbilling.Location = New System.Drawing.Point(12, 3)
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
        Me.billingpanel.Controls.Add(Me.txtNewInvoice)
        Me.billingpanel.Controls.Add(Me.Label19)
        Me.billingpanel.Controls.Add(Me.Label9)
        Me.billingpanel.Controls.Add(Me.selectProduct)
        Me.billingpanel.Controls.Add(Me.dateDate)
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
        Me.billingpanel.Size = New System.Drawing.Size(800, 0)
        Me.billingpanel.TabIndex = 1
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
        'dateDate
        '
        Me.dateDate.CustomFormat = "dd/MM/yyyy"
        Me.dateDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateDate.Location = New System.Drawing.Point(563, 24)
        Me.dateDate.Margin = New System.Windows.Forms.Padding(2)
        Me.dateDate.Name = "dateDate"
        Me.dateDate.Size = New System.Drawing.Size(226, 27)
        Me.dateDate.TabIndex = 109
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
        'detailspanel
        '
        Me.detailspanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.detailspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.detailspanel.Controls.Add(Me.dataDetails)
        Me.detailspanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.detailspanel.ForeColor = System.Drawing.Color.Black
        Me.detailspanel.Location = New System.Drawing.Point(0, 45)
        Me.detailspanel.Name = "detailspanel"
        Me.detailspanel.Size = New System.Drawing.Size(800, 405)
        Me.detailspanel.TabIndex = 2
        '
        'dataDetails
        '
        Me.dataDetails.AllowUserToAddRows = False
        Me.dataDetails.AllowUserToDeleteRows = False
        Me.dataDetails.AllowUserToResizeColumns = False
        Me.dataDetails.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dataDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dataDetails.BackgroundColor = System.Drawing.Color.White
        Me.dataDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(1, 5, 1, 5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataDetails.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataDetails.GridColor = System.Drawing.Color.White
        Me.dataDetails.Location = New System.Drawing.Point(0, 0)
        Me.dataDetails.MultiSelect = False
        Me.dataDetails.Name = "dataDetails"
        Me.dataDetails.ReadOnly = True
        Me.dataDetails.RowHeadersVisible = False
        Me.dataDetails.ShowCellErrors = False
        Me.dataDetails.ShowCellToolTips = False
        Me.dataDetails.ShowEditingIcon = False
        Me.dataDetails.ShowRowErrors = False
        Me.dataDetails.Size = New System.Drawing.Size(798, 403)
        Me.dataDetails.TabIndex = 4
        '
        'inventorypanel
        '
        Me.inventorypanel.BackColor = System.Drawing.Color.White
        Me.inventorypanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inventorypanel.Controls.Add(Me.cmdAbout)
        Me.inventorypanel.Controls.Add(Me.GroupBox2)
        Me.inventorypanel.Controls.Add(Me.GroupBox1)
        Me.inventorypanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventorypanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventorypanel.ForeColor = System.Drawing.Color.Black
        Me.inventorypanel.Location = New System.Drawing.Point(0, 45)
        Me.inventorypanel.Name = "inventorypanel"
        Me.inventorypanel.Size = New System.Drawing.Size(800, 0)
        Me.inventorypanel.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.cmdrecieved)
        Me.GroupBox2.Controls.Add(Me.selectOrderId)
        Me.GroupBox2.Controls.Add(Me.txtRecTotal)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recieved Payement"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(274, 49)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 19)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Payment: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(32, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 19)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Order ID:"
        '
        'cmdrecieved
        '
        Me.cmdrecieved.AutoSize = True
        Me.cmdrecieved.BackColor = System.Drawing.Color.Black
        Me.cmdrecieved.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdrecieved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrecieved.ForeColor = System.Drawing.Color.White
        Me.cmdrecieved.Location = New System.Drawing.Point(543, 42)
        Me.cmdrecieved.Name = "cmdrecieved"
        Me.cmdrecieved.Padding = New System.Windows.Forms.Padding(2)
        Me.cmdrecieved.Size = New System.Drawing.Size(157, 35)
        Me.cmdrecieved.TabIndex = 13
        Me.cmdrecieved.Text = "Recieved"
        Me.cmdrecieved.UseVisualStyleBackColor = False
        '
        'selectOrderId
        '
        Me.selectOrderId.DisplayMember = "Id"
        Me.selectOrderId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectOrderId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectOrderId.FormattingEnabled = True
        Me.selectOrderId.Location = New System.Drawing.Point(119, 46)
        Me.selectOrderId.Name = "selectOrderId"
        Me.selectOrderId.Size = New System.Drawing.Size(127, 27)
        Me.selectOrderId.TabIndex = 12
        Me.selectOrderId.ValueMember = "Id"
        '
        'txtRecTotal
        '
        Me.txtRecTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecTotal.Location = New System.Drawing.Point(367, 46)
        Me.txtRecTotal.Name = "txtRecTotal"
        Me.txtRecTotal.Size = New System.Drawing.Size(127, 27)
        Me.txtRecTotal.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNewProduct)
        Me.GroupBox1.Controls.Add(Me.cmddelete)
        Me.GroupBox1.Controls.Add(Me.cmdadd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.selectProductList)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 5)
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
        Me.txtNewProduct.TabIndex = 15
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
        Me.cmdadd.TabIndex = 13
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
        'MainActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.billingpanel)
        Me.Controls.Add(Me.inventorypanel)
        Me.Controls.Add(Me.navpanel)
        Me.Controls.Add(Me.detailspanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainActivity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JTSystem"
        Me.navpanel.ResumeLayout(False)
        Me.navpanel.PerformLayout()
        Me.billingpanel.ResumeLayout(False)
        Me.billingpanel.PerformLayout()
        Me.detailspanel.ResumeLayout(False)
        CType(Me.dataDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventorypanel.ResumeLayout(False)
        Me.inventorypanel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents navpanel As Panel
    Friend WithEvents billingpanel As Panel
    Friend WithEvents cmdorder As Label
    Friend WithEvents cmdbilling As Label
    Friend WithEvents dateDate As DateTimePicker
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
    Friend WithEvents cmdrecieved As Button
    Friend WithEvents selectOrderId As ComboBox
    Friend WithEvents txtRecTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNewProduct As TextBox
    Friend WithEvents cmddelete As Button
    Friend WithEvents cmdadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents selectProductList As ComboBox
    Friend WithEvents txtNewInvoice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents dataDetails As DataGridView
    Friend WithEvents cmdAbout As Label
End Class
