﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblGracias = New System.Windows.Forms.Label()
        Me.lblMasUno = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgCircleG = New System.Windows.Forms.PictureBox()
        Me.imgCircleR = New System.Windows.Forms.PictureBox()
        Me.tmrLerp = New System.Windows.Forms.Timer(Me.components)
        Me.txbFeedback = New System.Windows.Forms.RichTextBox()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tmrRest = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgCircleG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCircleR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPoints
        '
        Me.lblPoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(830, 9)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(45, 58)
        Me.lblPoints.TabIndex = 5
        Me.lblPoints.Text = "0"
        '
        'lblGracias
        '
        Me.lblGracias.AutoSize = True
        Me.lblGracias.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGracias.Location = New System.Drawing.Point(12, 9)
        Me.lblGracias.Name = "lblGracias"
        Me.lblGracias.Size = New System.Drawing.Size(588, 87)
        Me.lblGracias.TabIndex = 6
        Me.lblGracias.Text = "¡Gracias por participar!"
        Me.lblGracias.Visible = False
        '
        'lblMasUno
        '
        Me.lblMasUno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMasUno.AutoSize = True
        Me.lblMasUno.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasUno.Location = New System.Drawing.Point(733, 43)
        Me.lblMasUno.Name = "lblMasUno"
        Me.lblMasUno.Size = New System.Drawing.Size(107, 115)
        Me.lblMasUno.TabIndex = 7
        Me.lblMasUno.Text = "+1"
        Me.lblMasUno.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'imgCircleG
        '
        Me.imgCircleG.Image = Global.ResistenciaExtincion.My.Resources.Resources.circleg
        Me.imgCircleG.Location = New System.Drawing.Point(540, 197)
        Me.imgCircleG.Name = "imgCircleG"
        Me.imgCircleG.Size = New System.Drawing.Size(150, 160)
        Me.imgCircleG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCircleG.TabIndex = 3
        Me.imgCircleG.TabStop = False
        '
        'imgCircleR
        '
        Me.imgCircleR.Image = Global.ResistenciaExtincion.My.Resources.Resources.circler
        Me.imgCircleR.Location = New System.Drawing.Point(411, 103)
        Me.imgCircleR.Name = "imgCircleR"
        Me.imgCircleR.Size = New System.Drawing.Size(150, 160)
        Me.imgCircleR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCircleR.TabIndex = 2
        Me.imgCircleR.TabStop = False
        '
        'tmrLerp
        '
        Me.tmrLerp.Enabled = True
        Me.tmrLerp.Interval = 25
        '
        'txbFeedback
        '
        Me.txbFeedback.Location = New System.Drawing.Point(27, 283)
        Me.txbFeedback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txbFeedback.Name = "txbFeedback"
        Me.txbFeedback.Size = New System.Drawing.Size(802, 146)
        Me.txbFeedback.TabIndex = 8
        Me.txbFeedback.Text = ""
        Me.txbFeedback.Visible = False
        '
        'btnFeedback
        '
        Me.btnFeedback.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.Location = New System.Drawing.Point(840, 283)
        Me.btnFeedback.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(162, 148)
        Me.btnFeedback.TabIndex = 9
        Me.btnFeedback.Text = "Guardar"
        Me.btnFeedback.UseVisualStyleBackColor = True
        Me.btnFeedback.Visible = False
        '
        'lblFeedback
        '
        Me.lblFeedback.AutoSize = True
        Me.lblFeedback.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(16, 225)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(824, 53)
        Me.lblFeedback.TabIndex = 10
        Me.lblFeedback.Text = "Por favor escribe aqui que hacías para obtener puntos:"
        Me.lblFeedback.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(55, 99)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 244)
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'tmrRest
        '
        Me.tmrRest.Interval = 2000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(914, 449)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.txbFeedback)
        Me.Controls.Add(Me.lblMasUno)
        Me.Controls.Add(Me.lblGracias)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.imgCircleG)
        Me.Controls.Add(Me.imgCircleR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgCircleG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCircleR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgCircleG As PictureBox
    Friend WithEvents imgCircleR As PictureBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblGracias As Label
    Friend WithEvents lblMasUno As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents tmrLerp As Timer
    Friend WithEvents txbFeedback As RichTextBox
    Friend WithEvents btnFeedback As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tmrRest As Timer
End Class
