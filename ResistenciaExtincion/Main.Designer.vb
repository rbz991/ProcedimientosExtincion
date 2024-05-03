<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.imgTriangle = New System.Windows.Forms.PictureBox()
        Me.imgCircle = New System.Windows.Forms.PictureBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblGracias = New System.Windows.Forms.Label()
        Me.lblMasUno = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgTriangle
        '
        Me.imgTriangle.Image = Global.ResistenciaExtincion.My.Resources.Resources.triangle
        Me.imgTriangle.Location = New System.Drawing.Point(719, 246)
        Me.imgTriangle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgTriangle.Name = "imgTriangle"
        Me.imgTriangle.Size = New System.Drawing.Size(344, 301)
        Me.imgTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgTriangle.TabIndex = 3
        Me.imgTriangle.TabStop = False
        '
        'imgCircle
        '
        Me.imgCircle.Image = Global.ResistenciaExtincion.My.Resources.Resources.circle
        Me.imgCircle.Location = New System.Drawing.Point(547, 128)
        Me.imgCircle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imgCircle.Name = "imgCircle"
        Me.imgCircle.Size = New System.Drawing.Size(391, 294)
        Me.imgCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCircle.TabIndex = 2
        Me.imgCircle.TabStop = False
        '
        'lblPoints
        '
        Me.lblPoints.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Bahnschrift Condensed", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(1001, 11)
        Me.lblPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(60, 77)
        Me.lblPoints.TabIndex = 5
        Me.lblPoints.Text = "0"
        '
        'lblGracias
        '
        Me.lblGracias.AutoSize = True
        Me.lblGracias.Font = New System.Drawing.Font("Bahnschrift Condensed", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGracias.Location = New System.Drawing.Point(16, 11)
        Me.lblGracias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGracias.Name = "lblGracias"
        Me.lblGracias.Size = New System.Drawing.Size(785, 115)
        Me.lblGracias.TabIndex = 6
        Me.lblGracias.Text = "¡Gracias por participar!"
        Me.lblGracias.Visible = False
        '
        'lblMasUno
        '
        Me.lblMasUno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMasUno.AutoSize = True
        Me.lblMasUno.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMasUno.Location = New System.Drawing.Point(343, 311)
        Me.lblMasUno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMasUno.Name = "lblMasUno"
        Me.lblMasUno.Size = New System.Drawing.Size(141, 153)
        Me.lblMasUno.TabIndex = 7
        Me.lblMasUno.Text = "+1"
        Me.lblMasUno.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.lblMasUno)
        Me.Controls.Add(Me.lblGracias)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.imgTriangle)
        Me.Controls.Add(Me.imgCircle)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.imgTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgTriangle As PictureBox
    Friend WithEvents imgCircle As PictureBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents lblGracias As Label
    Friend WithEvents lblMasUno As Label
    Friend WithEvents Timer1 As Timer
End Class
