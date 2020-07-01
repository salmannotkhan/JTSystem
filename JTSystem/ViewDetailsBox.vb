Imports System.Runtime.InteropServices
Public Class ViewDetailsBox
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
    Public Sub New(ByVal desc As String)
        InitializeComponent()
        lbldescription.Text = desc
    End Sub

    Private Sub Cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub
    Private Sub Cmdclose_MouseEnter(sender As Object, e As EventArgs) Handles cmdclose.MouseEnter
        cmdclose.ForeColor = Color.Black
        cmdclose.BackColor = Color.White
    End Sub

    Private Sub Cmdclose_MouseLeave(sender As Object, e As EventArgs) Handles cmdclose.MouseLeave
        cmdclose.ForeColor = Color.White
        cmdclose.BackColor = Color.Black
    End Sub

    Private Sub Cmdprint_Click(sender As Object, e As EventArgs) Handles cmdprint.Click
        DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cmddelete_Click(sender As Object, e As EventArgs) Handles cmddelete.Click
        Using confirm As New CustomDialog("Confirmation", "Are you sure want to delete?", "Yes", "No")
            Dim result = confirm.ShowDialog
            If result = DialogResult.Yes Then
                DialogResult = DialogResult.No
                Me.Close()
            End If
        End Using
    End Sub
End Class