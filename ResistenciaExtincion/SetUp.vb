Imports System.IO
Public Class SetUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Me.Visible = False
        Dim dir As DirectoryInfo = New DirectoryInfo("C:\MyDir")
        dir.Create()
        FileOpen(1, "C:\MyDir\" & txbParticipante.Text & "_" & Dur & "_" & Rich & "_" & Lean & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
        Dim x As New Main
        x.Show()
    End Sub
End Class
