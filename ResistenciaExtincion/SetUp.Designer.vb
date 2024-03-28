<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetUp))
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.lblParticipante = New System.Windows.Forms.Label()
        Me.txbParticipante = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.Location = New System.Drawing.Point(12, 486)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(449, 138)
        Me.btnComenzar.TabIndex = 0
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'lblParticipante
        '
        Me.lblParticipante.AutoSize = True
        Me.lblParticipante.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblParticipante.Location = New System.Drawing.Point(12, 441)
        Me.lblParticipante.Name = "lblParticipante"
        Me.lblParticipante.Size = New System.Drawing.Size(149, 39)
        Me.lblParticipante.TabIndex = 2
        Me.lblParticipante.Text = "Participante:"
        '
        'txbParticipante
        '
        Me.txbParticipante.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbParticipante.Location = New System.Drawing.Point(167, 441)
        Me.txbParticipante.Name = "txbParticipante"
        Me.txbParticipante.Size = New System.Drawing.Size(294, 39)
        Me.txbParticipante.TabIndex = 3
        Me.txbParticipante.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(457, 395)
        Me.RichTextBox2.TabIndex = 4
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'SetUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 634)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txbParticipante)
        Me.Controls.Add(Me.lblParticipante)
        Me.Controls.Add(Me.btnComenzar)
        Me.Name = "SetUp"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComenzar As Button
    Friend WithEvents lblParticipante As Label
    Friend WithEvents txbParticipante As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
End Class
