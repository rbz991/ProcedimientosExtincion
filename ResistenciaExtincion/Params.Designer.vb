<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Params
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
        Me.txbdurIVrico = New System.Windows.Forms.TextBox()
        Me.txbdurIVpobre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbdurComp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboInicio = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txbdurIVrico
        '
        Me.txbdurIVrico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbdurIVrico.Location = New System.Drawing.Point(504, 6)
        Me.txbdurIVrico.Name = "txbdurIVrico"
        Me.txbdurIVrico.Size = New System.Drawing.Size(130, 39)
        Me.txbdurIVrico.TabIndex = 0
        Me.txbdurIVrico.Text = "10"
        '
        'txbdurIVpobre
        '
        Me.txbdurIVpobre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbdurIVpobre.Location = New System.Drawing.Point(504, 51)
        Me.txbdurIVpobre.Name = "txbdurIVpobre"
        Me.txbdurIVpobre.Size = New System.Drawing.Size(130, 39)
        Me.txbdurIVpobre.TabIndex = 1
        Me.txbdurIVpobre.Text = "30"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Duración IV rico en segundos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Duración IV pobre en segundos:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(643, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 177)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Siguiente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(484, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Duración componentes en segundos:"
        '
        'txbdurComp
        '
        Me.txbdurComp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbdurComp.Location = New System.Drawing.Point(504, 96)
        Me.txbdurComp.Name = "txbdurComp"
        Me.txbdurComp.Size = New System.Drawing.Size(130, 39)
        Me.txbdurComp.TabIndex = 6
        Me.txbdurComp.Text = "240"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Inicia en componente:"
        '
        'cboInicio
        '
        Me.cboInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInicio.FormattingEnabled = True
        Me.cboInicio.Items.AddRange(New Object() {"RICO", "POBRE"})
        Me.cboInicio.Location = New System.Drawing.Point(504, 144)
        Me.cboInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboInicio.Name = "cboInicio"
        Me.cboInicio.Size = New System.Drawing.Size(130, 40)
        Me.cboInicio.TabIndex = 8
        Me.cboInicio.Text = "RICO"
        '
        'Params
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 198)
        Me.Controls.Add(Me.cboInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txbdurComp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbdurIVpobre)
        Me.Controls.Add(Me.txbdurIVrico)
        Me.Name = "Params"
        Me.Text = "Params"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txbdurIVrico As TextBox
    Friend WithEvents txbdurIVpobre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txbdurComp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboInicio As ComboBox
End Class
