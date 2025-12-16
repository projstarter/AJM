<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rbtnWSI = New System.Windows.Forms.RadioButton()
        Me.rbtnWSR = New System.Windows.Forms.RadioButton()
        Me.txtticketno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 90)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 42)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(76, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "t1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(274, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rbtnWSI
        '
        Me.rbtnWSI.AutoSize = True
        Me.rbtnWSI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWSI.Location = New System.Drawing.Point(218, 174)
        Me.rbtnWSI.Name = "rbtnWSI"
        Me.rbtnWSI.Size = New System.Drawing.Size(50, 20)
        Me.rbtnWSI.TabIndex = 11
        Me.rbtnWSI.Text = "WSI"
        Me.rbtnWSI.UseVisualStyleBackColor = True
        '
        'rbtnWSR
        '
        Me.rbtnWSR.AutoSize = True
        Me.rbtnWSR.Checked = True
        Me.rbtnWSR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWSR.Location = New System.Drawing.Point(162, 174)
        Me.rbtnWSR.Name = "rbtnWSR"
        Me.rbtnWSR.Size = New System.Drawing.Size(54, 20)
        Me.rbtnWSR.TabIndex = 10
        Me.rbtnWSR.TabStop = True
        Me.rbtnWSR.Text = "WSR"
        Me.rbtnWSR.UseVisualStyleBackColor = True
        '
        'txtticketno
        '
        Me.txtticketno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtticketno.Location = New System.Drawing.Point(12, 173)
        Me.txtticketno.Name = "txtticketno"
        Me.txtticketno.Size = New System.Drawing.Size(144, 23)
        Me.txtticketno.TabIndex = 12
        Me.txtticketno.Text = "00000004"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 242)
        Me.Controls.Add(Me.txtticketno)
        Me.Controls.Add(Me.rbtnWSI)
        Me.Controls.Add(Me.rbtnWSR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents rbtnWSI As RadioButton
    Friend WithEvents rbtnWSR As RadioButton
    Friend WithEvents txtticketno As TextBox
End Class
