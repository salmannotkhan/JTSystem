<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewDetailsBox
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
        Me.cmdclose = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cmdclose)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 50)
        Me.Panel1.TabIndex = 5
        '
        'cmdclose
        '
        Me.cmdclose.AutoSize = True
        Me.cmdclose.BackColor = System.Drawing.Color.Black
        Me.cmdclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.White
        Me.cmdclose.Location = New System.Drawing.Point(320, 11)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdclose.Size = New System.Drawing.Size(65, 30)
        Me.cmdclose.TabIndex = 3
        Me.cmdclose.Text = "Close"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(12, 3)
        Me.title.Name = "title"
        Me.title.Padding = New System.Windows.Forms.Padding(11, 13, 11, 13)
        Me.title.Size = New System.Drawing.Size(127, 44)
        Me.title.TabIndex = 1
        Me.title.Text = "View Details"
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.White
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmddelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.Color.Black
        Me.cmddelete.Location = New System.Drawing.Point(272, 399)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(113, 39)
        Me.cmddelete.TabIndex = 8
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'lbldescription
        '
        Me.lbldescription.AutoSize = True
        Me.lbldescription.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(12, 75)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(237, 18)
        Me.lbldescription.TabIndex = 7
        Me.lbldescription.Text = "Do you want to print invoice?"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Black
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Location = New System.Drawing.Point(15, 399)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(128, 39)
        Me.cmdprint.TabIndex = 6
        Me.cmdprint.Text = "Print Invoice"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'ViewDetailsBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.lbldescription)
        Me.Controls.Add(Me.cmdprint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewDetailsBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewDetailsBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmddelete As Button
    Friend WithEvents lbldescription As Label
    Friend WithEvents cmdprint As Button
    Friend WithEvents title As Label
    Friend WithEvents cmdclose As Label
End Class
