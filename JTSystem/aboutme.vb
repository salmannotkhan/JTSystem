﻿Imports System.Runtime.InteropServices
Public NotInheritable Class AboutMe
    Dim count As Integer = 0

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub AboutMe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        count = 0
        lblpass.Visible = False
        cmdreset.Visible = False
        txtpasscode.Visible = False
        Me.Close()
    End Sub

    Private Sub Trigger_Click(sender As Object, e As EventArgs) Handles trigger.Click
        If count = 11 Then
            lblpass.Visible = True
            cmdreset.Visible = True
            txtpasscode.Visible = True
            count = 0
        Else
            count += 1
        End If
    End Sub

    Private Sub Cmdreset_Click(sender As Object, e As EventArgs) Handles cmdreset.Click
        If txtpasscode.Text = "warmachinerocks" Then
            Using confirm As New CustomDialog("Confirmation", "Are you sure you want to reset application?", "Yes", "No")
                If confirm.ShowDialog = DialogResult.Yes Then
                    Using confirm2 As New CustomDialog("Confirmation", "Are you sure everything will be deleted", "Yes", "No")
                        If confirm2.ShowDialog = DialogResult.Yes Then
                            DialogResult = DialogResult.Yes
                            Me.Close()
                        End If
                    End Using
                End If
            End Using
        Else
            Using msg As New CustomMsgBox("You're not dev, step aside kid!")
                msg.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub HoverEffect(sender As Object, e As EventArgs) Handles cmdreset.MouseEnter, cmdclose.MouseEnter
        sender.ForeColor = Color.Black
        sender.BackColor = Color.White
    End Sub

    Private Sub HoverEffectEnd(sender As Object, e As EventArgs) Handles cmdreset.MouseLeave, cmdclose.MouseLeave
        sender.ForeColor = Color.White
        sender.BackColor = Color.Black
    End Sub
End Class
