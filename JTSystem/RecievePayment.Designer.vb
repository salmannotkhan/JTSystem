<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecievePayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtrecieved = New System.Windows.Forms.TextBox()
        Me.cmdabort = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.cmdconfirm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 1
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(12, 16)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(98, 19)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Confirmation"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtrecieved)
        Me.Panel2.Controls.Add(Me.cmdabort)
        Me.Panel2.Controls.Add(Me.lbldescription)
        Me.Panel2.Controls.Add(Me.cmdconfirm)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 150)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Recieved amount: "
        '
        'txtrecieved
        '
        Me.txtrecieved.Location = New System.Drawing.Point(180, 57)
        Me.txtrecieved.Name = "txtrecieved"
        Me.txtrecieved.Size = New System.Drawing.Size(138, 27)
        Me.txtrecieved.TabIndex = 8
        '
        'cmdabort
        '
        Me.cmdabort.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmdabort.AutoSize = True
        Me.cmdabort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdabort.BackColor = System.Drawing.Color.White
        Me.cmdabort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdabort.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdabort.ForeColor = System.Drawing.Color.Black
        Me.cmdabort.Location = New System.Drawing.Point(224, 95)
        Me.cmdabort.Name = "cmdabort"
        Me.cmdabort.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdabort.Size = New System.Drawing.Size(75, 41)
        Me.cmdabort.TabIndex = 7
        Me.cmdabort.Text = "Cancel"
        Me.cmdabort.UseVisualStyleBackColor = False
        '
        'lbldescription
        '
        Me.lbldescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(12, 21)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(375, 19)
        Me.lbldescription.TabIndex = 6
        Me.lbldescription.Text = "Recieve payment for Order Id "
        Me.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdconfirm
        '
        Me.cmdconfirm.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdconfirm.AutoSize = True
        Me.cmdconfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdconfirm.BackColor = System.Drawing.Color.Black
        Me.cmdconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdconfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdconfirm.ForeColor = System.Drawing.Color.White
        Me.cmdconfirm.Location = New System.Drawing.Point(84, 95)
        Me.cmdconfirm.Name = "cmdconfirm"
        Me.cmdconfirm.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdconfirm.Size = New System.Drawing.Size(90, 41)
        Me.cmdconfirm.TabIndex = 5
        Me.cmdconfirm.Text = "Recieved"
        Me.cmdconfirm.UseVisualStyleBackColor = False
        '
        'RecievePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RecievePayment"
        Me.Text = "RecievePayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdabort As Button
    Friend WithEvents lbldescription As Label
    Friend WithEvents cmdconfirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrecieved As TextBox
End Class
