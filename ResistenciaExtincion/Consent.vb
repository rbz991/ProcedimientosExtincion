Imports System.IO
Public Class Consent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Me.Visible = False
        Dim dir As DirectoryInfo = New DirectoryInfo("C:\Data")
        dir.Create()
        FileOpen(1, "C:\Data\" & txbParticipante.Text & "_" & Dur & "_" & Rich & "_" & Lean & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
        Dim y As New Instructions
        y.Show()
    End Sub

    Private Sub _FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub
End Class
