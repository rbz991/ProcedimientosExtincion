Public Class Params
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Dur = txbdurComp.Text * 1000
        Rich = txbdurIVrico.Text
        Lean = txbdurIVpobre.Text
        Ini = cboInicio.Text
        Dim o As New Consent
        o.Show()
    End Sub

    Private Sub Params_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub

End Class