Imports System.Runtime.InteropServices
Public Class CustomDialog
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
    Public Sub New(ByVal title As String, ByVal desc As String, ByVal confirm As String, ByVal abort As String)
        InitializeComponent()

        lbltitle.Text = title
        lbldescription.Text = desc
        cmdconfirm.Text = confirm
        cmdabort.Text = abort
    End Sub
    Private Sub Cmdconfirm_Click(sender As Object, e As EventArgs) Handles cmdconfirm.Click
        DialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cmdabort_Click(sender As Object, e As EventArgs) Handles cmdabort.Click
        DialogResult = DialogResult.No
        Me.Close()
    End Sub
End Class