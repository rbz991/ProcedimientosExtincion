Public Class SetUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Me.Visible = False
        FileOpen(1, "C:\Data\" & txbParticipante.Text & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
        Dim x As New Main
        x.Show()
    End Sub
End Class
