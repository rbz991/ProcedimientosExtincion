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
        Me.SuspendLayout()
        '
        'txbdurIVrico
        '
        Me.txbdurIVrico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbdurIVrico.Location = New System.Drawing.Point(521, 6)
        Me.txbdurIVrico.Name = "txbdurIVrico"
        Me.txbdurIVrico.Size = New System.Drawing.Size(113, 39)
        Me.txbdurIVrico.TabIndex = 0
        Me.txbdurIVrico.Text = "3"
        '
        'txbdurIVpobre
        '
        Me.txbdurIVpobre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbdurIVpobre.Location = New System.Drawing.Point(521, 51)
        Me.txbdurIVpobre.Name = "txbdurIVpobre"
        Me.txbdurIVpobre.Size = New System.Drawing.Size(113, 39)
        Me.txbdurIVpobre.TabIndex = 1
        Me.txbdurIVpobre.Text = "6"
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
        Me.Button1.Location = New System.Drawing.Point(640, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 129)
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
        Me.txbdurComp.Location = New System.Drawing.Point(521, 96)
        Me.txbdurComp.Name = "txbdurComp"
        Me.txbdurComp.Size = New System.Drawing.Size(113, 39)
        Me.txbdurComp.TabIndex = 6
        Me.txbdurComp.Text = "30"
        '
        'Params
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 153)
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
End Class
