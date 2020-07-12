Imports System.Runtime.InteropServices
Public Class StockDetails
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
    Public Sub New(ByVal ds As DataSet)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        gridDetails.DataSource = ds.Tables(0)
        gridDetails.Columns("Id").Visible = False
        gridDetails.Columns("ProductName").HeaderText = "Product Name"
        gridDetails.Columns("ProductName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        gridDetails.Columns("Stock").HeaderText = "Bags"
        gridDetails.Columns("Stock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub Cmdclose_Click(sender As Object, e As EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub HoverEffect(sender As Object, e As EventArgs) Handles cmdclose.MouseEnter
        sender.ForeColor = Color.Black
        sender.BackColor = Color.White
    End Sub

    Private Sub HoverEffectEnd(sender As Object, e As EventArgs) Handles cmdclose.MouseLeave
        sender.ForeColor = Color.White
        sender.BackColor = Color.Black
    End Sub
End Class