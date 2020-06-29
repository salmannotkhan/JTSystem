<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDialog
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
        Me.cmdconfirm = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.cmdabort = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 50)
        Me.Panel1.TabIndex = 0
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.White
        Me.lbltitle.Location = New System.Drawing.Point(12, 16)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(110, 18)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Confirmation"
        '
        'cmdconfirm
        '
        Me.cmdconfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdconfirm.AutoSize = True
        Me.cmdconfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdconfirm.BackColor = System.Drawing.Color.Black
        Me.cmdconfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdconfirm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdconfirm.ForeColor = System.Drawing.Color.White
        Me.cmdconfirm.Location = New System.Drawing.Point(73, 148)
        Me.cmdconfirm.Name = "cmdconfirm"
        Me.cmdconfirm.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdconfirm.Size = New System.Drawing.Size(68, 40)
        Me.cmdconfirm.TabIndex = 2
        Me.cmdconfirm.Text = "Print"
        Me.cmdconfirm.UseVisualStyleBackColor = False
        '
        'lbldescription
        '
        Me.lbldescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(105, 96)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(237, 18)
        Me.lbldescription.TabIndex = 3
        Me.lbldescription.Text = "Do you want to print invoice?"
        '
        'cmdabort
        '
        Me.cmdabort.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdabort.AutoSize = True
        Me.cmdabort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdabort.BackColor = System.Drawing.Color.White
        Me.cmdabort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdabort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdabort.ForeColor = System.Drawing.Color.Black
        Me.cmdabort.Location = New System.Drawing.Point(263, 148)
        Me.cmdabort.Name = "cmdabort"
        Me.cmdabort.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdabort.Size = New System.Drawing.Size(119, 40)
        Me.cmdabort.TabIndex = 4
        Me.cmdabort.Text = "No, Thanks"
        Me.cmdabort.UseVisualStyleBackColor = False
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(456, 200)
        Me.Controls.Add(Me.cmdabort)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.cmdconfirm)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents cmdconfirm As Button
    Friend WithEvents lbldescription As Label
    Friend WithEvents cmdabort As Button
End Class
