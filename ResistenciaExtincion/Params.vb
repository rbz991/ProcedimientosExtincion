Public Class Params
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Dur = txbdurComp.Text * 1000
        Rich = txbdurIVrico.Text
        Lean = txbdurIVpobre.Text
        Ini = cboResInicio.Text
        Proc = cboProc.Text

        If Proc = "RENO" Then
            SingleIV = txbRenoIV.Text
            PhasesDur(0) = txbRenoP1Dur.Text * 1000
            PhasesDur(1) = txbRenoP2Dur.Text * 1000
            PhasesDur(2) = txbRenoP3Dur.Text * 1000
        ElseIf Proc = "RESU" Then
            SingleIV = txbResuIV.Text
            PhasesDur(0) = txbResuP1Dur.Text * 1000
            PhasesDur(1) = txbResuP2Dur.Text * 1000
            PhasesDur(2) = txbResuP3Dur.Text * 1000
        ElseIf Proc = "REST" Then
            SingleIV = txbRestIV.Text
            PhasesDur(0) = txbRestP1Dur.Text * 1000
            PhasesDur(1) = txbRestP2Dur.Text * 1000
            PhasesDur(2) = txbRestP3Dur.Text * 1000
        End If


        If chkCostoRes.Checked = True Then CostRes = True
        If chkCostoRes.Checked = False Then CostRes = False
        Dim o As New Consent
        o.Show()
    End Sub

    Private Sub Params_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub cboProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProc.SelectedIndexChanged
        If cboProc.Text = "RENO" Then
            grpRENO.Visible = True
            grpRESI.Visible = False
            grpRESU.Visible = False
            grpREST.Visible = False
        ElseIf cboProc.Text = "RESI" Then
            grpRESI.Visible = True
            grpRENO.Visible = False
            grpRESU.Visible = False
            grpREST.Visible = False
        ElseIf cboProc.Text = "RESU" Then
            grpRESU.Visible = True
            grpRESI.Visible = False
            grpREST.Visible = False
            grpRENO.Visible = False
        ElseIf cboProc.Text = "REST" Then
            grpREST.Visible = True
            grpRESI.Visible = False
            grpRESU.Visible = False
            grpRENO.Visible = False
        End If
    End Sub

End Class