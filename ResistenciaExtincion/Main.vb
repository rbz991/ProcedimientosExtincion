Imports System.Math
Public Class Main
    Public vTimeStart As Integer = 0
    Private Rand As New Random
    Private VIList As New List(Of Integer)
    Private WithEvents tmrVI As Timer = New Timer
    Private WithEvents tmrComponent As Timer = New Timer
    Private WithEvents tmrMasUno As Timer = New Timer
    Private refReady As Boolean = False
    Private currentComponent As Byte = 1
    Private Points As Byte
    Private prevVI As Byte
    Private responseCount(4) As Integer

    Private Sub form_click(sender As Object, e As MouseEventArgs) Handles Me.Click
        If currentComponent = 5 Then Finish()
        WriteLine(1, vTimeNow, currentComponent, 0, e.X, e.Y)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTimeStart = Environment.TickCount
        Me.WindowState = FormWindowState.Maximized
        VIGen(Rich)
        tmrComponent.Interval = Dur 'Duración del componente
        tmrMasUno.Interval = 1000
        tmrComponent.Enabled = True
        imgTriangle.Visible = False
        imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
    End Sub

    Private Sub imgClick(sender As Object, e As MouseEventArgs) Handles imgTriangle.Click, imgCircle.Click
        If currentComponent = 5 Then Finish()

        responseCount(currentComponent) += 1
        WriteLine(1, vTimeNow, currentComponent, 1, e.X, e.Y)
        If refReady = True Then
            refReady = False
            Reinforce(sender)
            If currentComponent = 1 Then VIGen(Rich)
            If currentComponent = 2 Then VIGen(Lean)
        End If
        Text = responseCount(1) & "," & responseCount(2) & "," & responseCount(3) & "," & responseCount(4) & "," & tmrVI.Interval
    End Sub

    Private Sub Reinforce(sender)
        If currentComponent = 1 Or currentComponent = 2 Then
            Points += 1
            lblMasUno.Left = Size.Width / 2
            lblMasUno.Top = Size.Height / 2
            lblMasUno.Visible = True
            tmrMasUno.Enabled = True
        End If
        lblPoints.Text = Points
        sender.Left = Rand.Next(0, Size.Width / 1.1)
        sender.Top = Rand.Next(0, Size.Height / 1.1)
        If currentComponent = 1 Or currentComponent = 3 Then VIGen(Rich)
        If currentComponent = 2 Or currentComponent = 4 Then VIGen(Lean)
    End Sub

    Private Sub tmrMasUno_Tick() Handles tmrMasUno.Tick
        tmrMasUno.Enabled = False
        lblMasUno.Visible = False
    End Sub

    Private Sub tmrComponent_Tick() Handles tmrComponent.Tick
        currentComponent += 1
        VIList.Clear()
        refReady = False
        If currentComponent = 2 Then
            imgCircle.Visible = False
            imgTriangle.Visible = True
            imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
            VIGen(Lean)
        ElseIf currentComponent = 3 Then
            imgCircle.Visible = True
            imgTriangle.Visible = False
            imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
            VIGen(Rich)
        ElseIf currentComponent = 4 Then
            imgCircle.Visible = False
            imgTriangle.Visible = True
            imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
            VIGen(Lean)
        End If

        If currentComponent = 5 Then Finish()
    End Sub

    Private Sub Finish()
        lblGracias.Visible = True
        lblPoints.Visible = False
        imgCircle.Visible = False
        imgTriangle.Visible = False
        lblGracias.Text = lblGracias.Text & " Obtuviste " & Points & " puntos."
        FileClose(1)
    End Sub

    Private Sub tmrVI_Tick() Handles tmrVI.Tick
        tmrVI.Enabled = False
        refReady = True
    End Sub

    Private Sub VIGen(v)
        Dim n = 10
        Dim rd(n)
        Dim vi(n)
        Dim order
        Randomize()
        If VIList.Count = 0 Then
            For m As Integer = 1 To n
                If m = n Then vi(m) = v * (1 + Log(n)) : GoTo 1
                vi(m) = v * (1 + (Log(n)) + (n - m) * (Log(n - m)) - (n - m + 1) * Log(n - m + 1))
1:              order = Int((n * Rnd() + 1))
                If rd(order) = 0 Then
                    rd(order) = vi(m)
                Else
                    GoTo 1
                End If
            Next
            For a As Integer = 1 To n
                VIList.Add(rd(a))
            Next
        End If
        Dim p As Integer = Rand.Next(VIList.Count)
        tmrVI.Interval = (VIList.Item(p) + 1) * 1000
        tmrVI.Enabled = True
        VIList.RemoveAt(p)
    End Sub

    Private Function vTimeNow()
        Return Environment.TickCount - vTimeStart
    End Function

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub

    Dim test = 0
    Dim bln = False



End Class