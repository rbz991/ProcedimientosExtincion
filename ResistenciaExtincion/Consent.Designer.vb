<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consent))
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txbParticipante = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Bahnschrift Condensed", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.Location = New System.Drawing.Point(16, 1107)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(599, 172)
        Me.btnComenzar.TabIndex = 0
        Me.btnComenzar.Text = "Acepto"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.85!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(16, 15)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1451, 723)
        Me.RichTextBox2.TabIndex = 4
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.85!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 808)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1451, 256)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'txbParticipante
        '
        Me.txbParticipante.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbParticipante.Location = New System.Drawing.Point(77, 821)
        Me.txbParticipante.Margin = New System.Windows.Forms.Padding(4)
        Me.txbParticipante.Multiline = False
        Me.txbParticipante.Name = "txbParticipante"
        Me.txbParticipante.Size = New System.Drawing.Size(334, 48)
        Me.txbParticipante.TabIndex = 3
        Me.txbParticipante.Text = ""
        '
        'Consent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1711, 1292)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txbParticipante)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Consent"
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnComenzar As Button
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txbParticipante As RichTextBox
End Class
