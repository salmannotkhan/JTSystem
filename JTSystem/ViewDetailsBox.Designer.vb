<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewDetailsBox
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdclose = New System.Windows.Forms.Label()
        Me.title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.lbldescription = New System.Windows.Forms.Label()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdclose)
        Me.Panel1.Controls.Add(Me.title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 5
        '
        'cmdclose
        '
        Me.cmdclose.AutoSize = True
        Me.cmdclose.BackColor = System.Drawing.Color.Black
        Me.cmdclose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmdclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdclose.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.White
        Me.cmdclose.Location = New System.Drawing.Point(330, 10)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Padding = New System.Windows.Forms.Padding(5)
        Me.cmdclose.Size = New System.Drawing.Size(57, 31)
        Me.cmdclose.TabIndex = 3
        Me.cmdclose.Text = "Close"
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(3, 3)
        Me.title.Name = "title"
        Me.title.Padding = New System.Windows.Forms.Padding(11, 13, 11, 13)
        Me.title.Size = New System.Drawing.Size(114, 45)
        Me.title.TabIndex = 1
        Me.title.Text = "View Details"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmddelete)
        Me.Panel2.Controls.Add(Me.lbldescription)
        Me.Panel2.Controls.Add(Me.cmdprint)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 350)
        Me.Panel2.TabIndex = 6
        '
        'cmddelete
        '
        Me.cmddelete.BackColor = System.Drawing.Color.White
        Me.cmddelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmddelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.Color.Black
        Me.cmddelete.Location = New System.Drawing.Point(215, 300)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(113, 40)
        Me.cmddelete.TabIndex = 11
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = False
        '
        'lbldescription
        '
        Me.lbldescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescription.Location = New System.Drawing.Point(70, 2)
        Me.lbldescription.Name = "lbldescription"
        Me.lbldescription.Size = New System.Drawing.Size(317, 295)
        Me.lbldescription.TabIndex = 10
        Me.lbldescription.Text = "Do you want to print invoice?"
        Me.lbldescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Black
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Location = New System.Drawing.Point(70, 300)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(128, 40)
        Me.cmdprint.TabIndex = 9
        Me.cmdprint.Text = "Print Invoice"
        Me.cmdprint.UseVisualStyleBackColor = False
        '
        'ViewDetailsBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewDetailsBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewDetailsBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents title As Label
    Friend WithEvents cmdclose As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmddelete As Button
    Friend WithEvents lbldescription As Label
    Friend WithEvents cmdprint As Button
End Class
