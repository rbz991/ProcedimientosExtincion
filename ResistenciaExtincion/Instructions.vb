Imports System.IO

Public Class Instructions
    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Me.Visible = False
        Dim x As New Main
        x.Show()
    End Sub

    Private Sub _FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub


End Class