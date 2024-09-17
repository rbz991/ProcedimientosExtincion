Imports System.Math
Public Class Main
    Public vTimeStart As Integer = 0
    Private Rand As New Random
    Private VIList As New List(Of String)
    Private WithEvents tmrVI As Timer = New Timer
    Private WithEvents tmrComponent As Timer = New Timer
    Private WithEvents tmrMasUno As Timer = New Timer
    Private refReady As Boolean = False
    Private currentComponent As Byte = 1
    Private Points As Integer
    Private prevVI As Byte
    Private responseCount(4) As Integer
    Private blnFinished As Boolean = False

    Private Sub form_click(sender As Object, e As MouseEventArgs) Handles Me.Click
        If currentComponent = 5 Then Finish()
        If blnFinished = False Then
            WriteLine(1, vTimeNow, currentComponent, 0, MousePosition.X, MousePosition.Y)
        End If
        If CostRes = True Then Points -= 1
        If CostRes = True Then lblPoints.Text = Points
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vTimeStart = Environment.TickCount
        Me.WindowState = FormWindowState.Maximized
        If Proc = "RES" Then tmrComponent.Interval = Dur 'Duración del componente
        If Proc = "REN" Then tmrComponent.Interval = RenPhasesDur(0)
        tmrComponent.Enabled = True
        tmrMasUno.Interval = 1000
        If CostRes = True Then Points = 1000
        If CostRes = True Then lblPoints.Text = 1000
        If CostRes = True Then lblMasUno.Text = "+100"
        If Proc = "RES" Then
            If Ini = "RIC" Then
                imgCircleR.Visible = True
                imgCircleG.Visible = False
                imgCircleR.Left = Rand.Next(0, 1250)
                imgCircleR.Top = Rand.Next(0, 600)
                VIGen(Rich)
                BackColor = Color.FromArgb(255, 255, 192)
            ElseIf Ini = "POB" Then
                imgCircleG.Visible = True
                imgCircleR.Visible = False
                imgCircleG.Left = Rand.Next(0, 1250)
                imgCircleG.Top = Rand.Next(0, 600)
                VIGen(Lean)
                BackColor = Color.FromArgb(192, 255, 255)
            End If
        ElseIf Proc = "REN" Then
            imgCircleR.Visible = True
            imgCircleG.Visible = False
            imgCircleR.Left = Rand.Next(0, 1250)
            imgCircleR.Top = Rand.Next(0, 600)
            VIGen(RenIV)
            BackColor = Color.FromArgb(255, 255, 192)
        End If
    End Sub

    Private Sub imgClick(sender As Object, e As MouseEventArgs) Handles imgCircleG.Click, imgCircleR.Click
        If currentComponent = 5 Then Finish()
        If blnFinished = False Then
            responseCount(currentComponent) += 1
            WriteLine(1, vTimeNow, currentComponent, 1, MousePosition.X, MousePosition.Y)
            If CostRes = True Then Points -= 1
            If CostRes = True Then lblPoints.Text = Points
            If refReady = True Then
                refReady = False
                Reinforce(sender)
                'If currentComponent = 1 Then VIGen(Rich)
                'If currentComponent = 2 Then VIGen(Lean)
            End If
            'Text = responseCount(1) & "," & responseCount(2) & "," & responseCount(3) & "," & responseCount(4) & "," & tmrVI.Interval
        End If
    End Sub

    Private Sub Reinforce(sender)
        If currentComponent = 1 Or currentComponent = 2 Then

            If CostRes = True Then Points += 100
            If CostRes = False Then Points += 1

            lblMasUno.Left = Size.Width / 2
            lblMasUno.Top = Size.Height / 2
            lblMasUno.Visible = True
            tmrMasUno.Enabled = True
            WriteLine(1, vTimeNow, currentComponent, 3, 0, 0)
        End If
        lblPoints.Text = Points
        sender.Left = Rand.Next(0, 1250)
        sender.Top = Rand.Next(0, 600)
        If Proc = "RES" Then
            If currentComponent = 1 And Ini = "RIC" Then VIGen(Rich)
            If currentComponent = 2 And Ini = "RIC" Then VIGen(Lean)
            If currentComponent = 1 And Ini = "POB" Then VIGen(Lean)
            If currentComponent = 2 And Ini = "POB" Then VIGen(Rich)
        ElseIf Proc = "REN" Then
            VIGen(RenIV)
        End If

    End Sub

    Private Sub tmrMasUno_Tick() Handles tmrMasUno.Tick
        tmrMasUno.Enabled = False
        lblMasUno.Visible = False
    End Sub

    Private Sub tmrComponent_Tick() Handles tmrComponent.Tick
        currentComponent += 1
        VIList.Clear()
        refReady = False
        If Proc = "RES" Then
            If Ini = "RIC" Then
                If currentComponent = 2 Then
                    imgCircleG.Visible = True
                    imgCircleR.Visible = False
                    VIGen(Lean)
                    BackColor = Color.FromArgb(192, 255, 255)
                ElseIf currentComponent = 3 Then
                    imgCircleR.Visible = True
                    imgCircleG.Visible = False
                    VIGen(Rich)
                    BackColor = Color.FromArgb(255, 255, 192)
                ElseIf currentComponent = 4 Then
                    imgCircleG.Visible = True
                    imgCircleR.Visible = False
                    VIGen(Lean)
                    BackColor = Color.FromArgb(192, 255, 255)
                End If
            ElseIf Ini = "POB" Then
                If currentComponent = 2 Then
                    imgCircleR.Visible = True
                    imgCircleG.Visible = False
                    VIGen(Rich)
                    BackColor = Color.FromArgb(255, 255, 192)
                ElseIf currentComponent = 3 Then
                    imgCircleG.Visible = True
                    imgCircleR.Visible = False
                    VIGen(Lean)
                    BackColor = Color.FromArgb(192, 255, 255)
                ElseIf currentComponent = 4 Then
                    imgCircleR.Visible = True
                    imgCircleG.Visible = False
                    VIGen(Rich)
                    BackColor = Color.FromArgb(255, 255, 192)
                End If
            End If
        ElseIf Proc = "REN" Then
            tmrComponent.Enabled = False
            If currentComponent = 2 Then
                tmrComponent.Interval = RenPhasesDur(1)
                imgCircleR.Visible = False
                imgCircleG.Visible = True
                BackColor = Color.FromArgb(192, 255, 255)
            ElseIf currentComponent = 3 Then
                tmrComponent.Interval = RenPhasesDur(2)
                imgCircleR.Visible = True
                imgCircleG.Visible = False
                BackColor = Color.FromArgb(255, 255, 192)
            End If
            tmrComponent.Enabled = True
        End If

        If Proc = "RES" And currentComponent = 5 Then Finish()
        If Proc = "REN" And currentComponent = 4 Then Finish()
    End Sub

    Private Sub Finish()
        If blnFinished = False Then
            BackColor = SystemColors.Control
            lblGracias.Visible = True
            lblPoints.Visible = False
            imgCircleR.Visible = False
            imgCircleG.Visible = False
            lblGracias.Text = "Obtuviste " & Points & " puntos."
            lblFeedback.Visible = True
            btnFeedback.Visible = True
            txbFeedback.Visible = True
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

        ListBox1.Items.Clear()

        ListBox1.Items.Add(tmrVI.Interval / 1000)
        For i = 0 To VIList.Count - 1
            ListBox1.Items.Add(VIList.Item(i))
        Next


    End Sub

    Private Function vTimeNow()
        Return Environment.TickCount - vTimeStart
    End Function

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Process.GetCurrentProcess.Kill()
    End Sub

    Dim test = 0
    Dim bln = False

    Dim topi As Byte = 250
    Dim blntop As Boolean = True
    Private Sub tmrLerp_Tick(sender As Object, e As EventArgs) Handles tmrLerp.Tick

        If blntop = True Then
            If imgCircleR.Location.Y <= 0 Or imgCircleG.Location.Y <= 0 Then topi = 5
            topi -= 5
            If topi = 0 Then blntop = False
            Dim x As New Point(imgCircleR.Location.X, imgCircleR.Location.Y - 5)
            Dim y As New Point(imgCircleG.Location.X, imgCircleG.Location.Y - 5)
            imgCircleR.Location = x
            imgCircleG.Location = y
        ElseIf blntop = False Then
            If imgCircleR.Location.Y >= Size.Height - 150 Or imgCircleG.Location.Y >= Size.Height - 150 Then topi = 245
            topi += 5
            If topi = 250 Then blntop = True
            Dim x As New Point(imgCircleR.Location.X, imgCircleR.Location.Y + 5)
            Dim y As New Point(imgCircleG.Location.X, imgCircleG.Location.Y + 5)
            imgCircleR.Location = x
            imgCircleG.Location = y
        End If



    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        txbFeedback.Enabled = False
        btnFeedback.Enabled = False
        lblFeedback.Text = "¡Felicidades! Has conseguido un premio. Por favor avisa al responsable que termimnaste."
        FileOpen(2, "C:\Data\ResExt\Feedback_" & Participante & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
        WriteLine(2, txbFeedback.Text)
        FileClose(2)
    End Sub


End Class