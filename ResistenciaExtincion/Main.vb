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
    Private blnFinished As Boolean = False

    Private Sub form_click(sender As Object, e As MouseEventArgs) Handles Me.Click
        If currentComponent = 5 Then Finish()
        If blnFinished = False Then
            WriteLine(1, vTimeNow, currentComponent, 0, MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTimeStart = Environment.TickCount
        Me.WindowState = FormWindowState.Maximized
        tmrComponent.Interval = Dur 'Duración del componente
        tmrComponent.Enabled = True
        tmrMasUno.Interval = 1000
        If Ini = "RICO" Then
            imgCircle.Visible = True
            imgTriangle.Visible = False
            imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
            VIGen(Rich)
        ElseIf Ini = "POBRE" Then
            imgTriangle.Visible = True
            imgCircle.Visible = False
            imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
            VIGen(Lean)
        End If
    End Sub

    Private Sub imgClick(sender As Object, e As MouseEventArgs) Handles imgTriangle.Click, imgCircle.Click
        If currentComponent = 5 Then Finish()
        If blnFinished = False Then
            responseCount(currentComponent) += 1
            WriteLine(1, vTimeNow, currentComponent, 1, MousePosition.X, MousePosition.Y)
            If refReady = True Then
                refReady = False
                Reinforce(sender)
                If currentComponent = 1 Then VIGen(Rich)
                If currentComponent = 2 Then VIGen(Lean)
            End If
            'Text = responseCount(1) & "," & responseCount(2) & "," & responseCount(3) & "," & responseCount(4) & "," & tmrVI.Interval
        End If
    End Sub

    Private Sub Reinforce(sender)
        If currentComponent = 1 Or currentComponent = 2 Then
            Points += 1
            lblMasUno.Left = Size.Width / 2
            lblMasUno.Top = Size.Height / 2
            lblMasUno.Visible = True
            tmrMasUno.Enabled = True
            WriteLine(1, vTimeNow, currentComponent, 3)
        End If
        lblPoints.Text = Points
        sender.Left = Rand.Next(0, Size.Width / 1.1)
        sender.Top = Rand.Next(0, Size.Height / 1.1)
        If currentComponent = 1 And Ini = "RICO" Then VIGen(Rich)
        If currentComponent = 2 And Ini = "RICO" Then VIGen(Lean)
        If currentComponent = 1 And Ini = "POBRE" Then VIGen(Lean)
        If currentComponent = 2 And Ini = "POBRE" Then VIGen(Rich)
    End Sub

    Private Sub tmrMasUno_Tick() Handles tmrMasUno.Tick
        tmrMasUno.Enabled = False
        lblMasUno.Visible = False
    End Sub

    Private Sub tmrComponent_Tick() Handles tmrComponent.Tick
        currentComponent += 1
        VIList.Clear()
        refReady = False
        If Ini = "RICO" Then
            If currentComponent = 2 Then
                imgTriangle.Visible = True
                imgCircle.Visible = False
                imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Lean)
            ElseIf currentComponent = 3 Then
                imgCircle.Visible = True
                imgTriangle.Visible = False
                imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Rich)
            ElseIf currentComponent = 4 Then
                imgTriangle.Visible = True
                imgCircle.Visible = False
                imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Lean)
            End If
        ElseIf Ini = "POBRE" Then
            If currentComponent = 2 Then
                imgCircle.Visible = True
                imgTriangle.Visible = False
                imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Rich)
            ElseIf currentComponent = 3 Then
                imgTriangle.Visible = True
                imgCircle.Visible = False
                imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Lean)
            ElseIf currentComponent = 4 Then
                imgCircle.Visible = True
                imgTriangle.Visible = False
                imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
                VIGen(Rich)
            End If
        End If


        If currentComponent = 5 Then Finish()
    End Sub

    Private Sub Finish()
        If blnFinished = False Then
            lblGracias.Visible = True
            lblPoints.Visible = False
            imgCircle.Visible = False
            imgTriangle.Visible = False
            lblGracias.Text = lblGracias.Text & " Obtuviste " & Points & " puntos. Por favor avisa al responsable."
            FileClose(1)
            blnFinished = True
        End If
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