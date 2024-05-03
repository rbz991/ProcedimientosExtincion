<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Bahnschrift Condensed", 19.85!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(13, 13)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1577, 744)
        Me.RichTextBox2.TabIndex = 5
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'btnComenzar
        '
        Me.btnComenzar.Font = New System.Drawing.Font("Bahnschrift Condensed", 22.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.Location = New System.Drawing.Point(13, 751)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(599, 172)
        Me.btnComenzar.TabIndex = 6
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1769, 936)
        Me.Controls.Add(Me.btnComenzar)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnComenzar As Button
End Class
