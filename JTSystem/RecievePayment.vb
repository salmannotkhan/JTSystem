Imports System.Runtime.InteropServices
Public Class RecievePayment
    Public amount As Integer

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

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lbldescription.Text = desc

    End Sub
    Private Sub Cmdconfirm_Click(sender As Object, e As EventArgs) Handles cmdconfirm.Click
        If IsNumeric(txtrecieved.Text) Then
            amount = txtrecieved.Text
            DialogResult = DialogResult.OK
            Me.Close()
        Else
            Using msg As New CustomMsgBox("Enter valid amount")
                msg.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub Cmdabort_Click(sender As Object, e As EventArgs) Handles cmdabort.Click
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class