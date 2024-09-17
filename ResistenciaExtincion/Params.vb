Public Class Params
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Dur = txbdurComp.Text * 1000
        Rich = txbdurIVrico.Text
        Lean = txbdurIVpobre.Text
        Ini = cboResInicio.Text
        Proc = cboProc.Text
        RenIV = txbRenIV.Text
        RenPhasesDur(0) = txbP1Dur.Text
        RenPhasesDur(1) = txbP2Dur.Text
        RenPhasesDur(2) = txbP3Dur.Text
        If chkCostoRes.Checked = True Then CostRes = True
        If chkCostoRes.Checked = False Then CostRes = False
        Dim o As New Consent
        o.Show()
    End Sub

    Private Sub Params_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub cboProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProc.SelectedIndexChanged
        If cboProc.Text = "REN" Then
            grpREN.Visible = True
            grpRES.Visible = False
        ElseIf cboProc.Text = "RES" Then
            grpREN.Visible = False
            grpRES.Visible = True
        End If
    End Sub

End Class