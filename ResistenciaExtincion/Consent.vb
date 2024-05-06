Imports System.IO
Public Class Consent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        If txbParticipante.Text = "" Then
            MessageBox.Show("Por favor introduce los datos del participante.")
        Else
            Participante = txbParticipante.Text
            Me.Visible = False
            Dim dir As DirectoryInfo = New DirectoryInfo("C:\Data")
            dir.Create()
            FileOpen(1, "C:\Data\" & Participante & "_" & Dur & "_" & Rich & "_" & Lean & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
            Dim y As New Instructions
            y.Show()
        End If

    End Sub

    Private Sub _FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub
End Class
