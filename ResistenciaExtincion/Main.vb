Imports System.Math
Public Class Main

    Private Dur As Integer = 30000
    Private Rich As Byte = 3
    Private Lean As Byte = 6

    Public vTimeStart As Integer = 0
    Private Rand As New Random
    Private VIList As New List(Of Integer)
    Private WithEvents tmrVI As Timer = New Timer
    Private WithEvents tmrComponent As Timer = New Timer
    Private WithEvents tmrMasUno As Timer = New Timer
    Private WithEvents tmrMouseHover As Timer = New Timer
    Private refReady(2) As Boolean
    Private currentComponent As Byte = 1
    Private Points As Byte
    Private prevVI As Byte
    Private responseCount(4) As Integer
    Private hoverCounter As Integer

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
        tmrMouseHover.Interval = 2000
    End Sub

    Private Sub imgClick(sender As Object, e As MouseEventArgs) Handles imgTriangle.Click, imgCircle.Click
        If currentComponent = 5 Then Finish()
        tmrMouseHover.Enabled = False
        tmrMouseHover.Enabled = True

        responseCount(currentComponent) += 1
        WriteLine(1, vTimeNow, currentComponent, 1, e.X, e.Y)
        If refReady(0) = True Then
            refReady(0) = False
            Reinforce(sender)
            If currentComponent = 1 Then VIGen(Rich)
            If currentComponent = 2 Then VIGen(Lean)
        End If
        Text = responseCount(1) & "," & responseCount(2) & "," & responseCount(3) & "," & responseCount(4) & "," & tmrVI.Interval
    End Sub

    Private Sub imgMouseOver(sender As Object, e As EventArgs) Handles imgTriangle.MouseEnter, imgCircle.MouseEnter
        If currentComponent = 5 Then Finish()
        tmrMouseHover.Enabled = False
        tmrMouseHover.Enabled = True

        responseCount(currentComponent) += 1
        WriteLine(1, vTimeNow, currentComponent, 2, Cursor.Position.X, Cursor.Position.Y)
        If refReady(1) = True Then
            refReady(1) = False
            Reinforce(sender)
            If currentComponent = 1 Then VIGen(Rich)
            If currentComponent = 2 Then VIGen(Lean)
        End If
        Text = responseCount(1) & "," & responseCount(2) & "," & responseCount(3) & "," & responseCount(4) & "," & tmrVI.Interval
    End Sub

    Private Sub imgMouseExit(sender As Object, e As EventArgs) Handles imgTriangle.MouseLeave, imgCircle.MouseLeave
        tmrMouseHover.Enabled = False
    End Sub

    Private Sub tmrMouseHover_Tick(sender As Object, e As EventArgs) Handles tmrMouseHover.Tick
        If currentComponent = 5 Then Finish()
        responseCount(currentComponent) += 1
        WriteLine(1, vTimeNow, currentComponent, 3, Cursor.Position.X, Cursor.Position.Y)
        If refReady(2) = True Then
            refReady(2) = False
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
        If currentComponent = 1 Or 3 Then
            imgCircle.Left = Rand.Next(0, Size.Width / 1.1)
            imgCircle.Top = Rand.Next(0, Size.Height / 1.1)
        End If
        If currentComponent = 2 Or 4 Then
            imgTriangle.Left = Rand.Next(0, Size.Width / 1.1)
            imgTriangle.Top = Rand.Next(0, Size.Height / 1.1)
        End If


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

        For i = 0 To 2
            refReady(i) = False
        Next

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
        lblGracias.Text = lblGracias.Text & " Obtuviste " & Points & "puntos."
        FileClose(1)
    End Sub

    Private Sub tmrVI_Tick() Handles tmrVI.Tick
        tmrVI.Enabled = False
        Dim x = Rand.Next(0, 90)
        If x < 30 Then
            refReady(0) = True
        ElseIf x > 30 And x < 60 Then
            refReady(1) = True
        ElseIf x > 60 Then
            refReady(2) = True
        End If
        Text = Text & "," & x
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
    Dim test = 0
    Dim bln = False


End Class