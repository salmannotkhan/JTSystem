<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutme
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutme))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdreset = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtpasscode = New System.Windows.Forms.TextBox()
        Me.trigger = New System.Windows.Forms.Label()
        Me.lblcreated = New System.Windows.Forms.Label()
        Me.cmdclose = New System.Windows.Forms.Label()
        Me.LabelCopyright = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About Application"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.cmdreset)
        Me.Panel2.Controls.Add(Me.lblpass)
        Me.Panel2.Controls.Add(Me.txtpasscode)
        Me.Panel2.Controls.Add(Me.trigger)
        Me.Panel2.Controls.Add(Me.lblcreated)
        Me.Panel2.Controls.Add(Me.cmdclose)
        Me.Panel2.Controls.Add(Me.LabelCopyright)
        Me.Panel2.Controls.Add(Me.LabelVersion)
        Me.Panel2.Controls.Add(Me.LabelProductName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 226)
        Me.Panel2.TabIndex = 2
        '
        'cmdreset
        '
        Me.cmdreset.AutoSize = True
        Me.cmdreset.BackColor = System.Drawing.Color.Black
        Me.cmdreset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdreset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreset.ForeColor = System.Drawing.Color.White
        Me.cmdreset.Location = New System.Drawing.Point(179, 186)
        Me.cmdreset.Name = "cmdreset"
        Me.cmdreset.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdreset.Size = New System.Drawing.Size(135, 31)
        Me.cmdreset.TabIndex = 10
        Me.cmdreset.Text = "Reset Application"
        Me.cmdreset.Visible = False
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(18, 134)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Padding = New System.Windows.Forms.Padding(5)
        Me.lblpass.Size = New System.Drawing.Size(84, 29)
        Me.lblpass.TabIndex = 9
        Me.lblpass.Text = "Passcode:"
        Me.lblpass.Visible = False
        '
        'txtpasscode
        '
        Me.txtpasscode.Location = New System.Drawing.Point(107, 136)
        Me.txtpasscode.Name = "txtpasscode"
        Me.txtpasscode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpasscode.Size = New System.Drawing.Size(100, 27)
        Me.txtpasscode.TabIndex = 8
        Me.txtpasscode.Visible = False
        '
        'trigger
        '
        Me.trigger.AutoSize = True
        Me.trigger.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trigger.Location = New System.Drawing.Point(103, 110)
        Me.trigger.Name = "trigger"
        Me.trigger.Size = New System.Drawing.Size(122, 19)
        Me.trigger.TabIndex = 7
        Me.trigger.Text = "@salmannotkhan"
        '
        'lblcreated
        '
        Me.lblcreated.AutoSize = True
        Me.lblcreated.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcreated.Location = New System.Drawing.Point(18, 105)
        Me.lblcreated.Name = "lblcreated"
        Me.lblcreated.Padding = New System.Windows.Forms.Padding(5)
        Me.lblcreated.Size = New System.Drawing.Size(94, 29)
        Me.lblcreated.TabIndex = 6
        Me.lblcreated.Text = "Created By:"
        '
        'cmdclose
        '
        Me.cmdclose.AutoSize = True
        Me.cmdclose.BackColor = System.Drawing.Color.Black
        Me.cmdclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.White
        Me.cmdclose.Location = New System.Drawing.Point(320, 186)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.cmdclose.Size = New System.Drawing.Size(67, 31)
        Me.cmdclose.TabIndex = 5
        Me.cmdclose.Text = "Close"
        '
        'LabelCopyright
        '
        Me.LabelCopyright.AutoSize = True
        Me.LabelCopyright.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCopyright.Location = New System.Drawing.Point(18, 76)
        Me.LabelCopyright.Name = "LabelCopyright"
        Me.LabelCopyright.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelCopyright.Size = New System.Drawing.Size(62, 29)
        Me.LabelCopyright.TabIndex = 2
        Me.LabelCopyright.Text = "Label4"
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.LabelVersion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVersion.Location = New System.Drawing.Point(18, 47)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelVersion.Size = New System.Drawing.Size(62, 29)
        Me.LabelVersion.TabIndex = 1
        Me.LabelVersion.Text = "Label3"
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.LabelProductName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductName.Location = New System.Drawing.Point(18, 18)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Padding = New System.Windows.Forms.Padding(5)
        Me.LabelProductName.Size = New System.Drawing.Size(62, 29)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(302, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'aboutme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 276)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aboutme"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "aboutme"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelCopyright As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents LabelProductName As Label
    Friend WithEvents lblcreated As Label
    Friend WithEvents cmdclose As Label
    Friend WithEvents trigger As Label
    Friend WithEvents cmdreset As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents txtpasscode As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
