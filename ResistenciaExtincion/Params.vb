Public Class Params
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Dur = txbdurComp.Text * 1000
        Rich = txbdurIVrico.Text
        Lean = txbdurIVpobre.Text
        Dim o As New SetUp
        o.Show()
    End Sub
End Class