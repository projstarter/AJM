<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.img_20x20 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Stencil", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 337)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCALE SYSTEM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(181, 399)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "USERNAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(181, 430)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PASSWORD"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtusername.Location = New System.Drawing.Point(258, 396)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(126, 25)
        Me.txtusername.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(52, 379)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtpassword.Location = New System.Drawing.Point(258, 427)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(126, 25)
        Me.txtpassword.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 301)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 33)
        Me.Panel1.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Bisque
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(397, 3)
        Me.Panel3.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Bisque
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 3)
        Me.Panel2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(172, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LOG IN"
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnlogin.BackColor = System.Drawing.Color.OldLace
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlogin.ImageKey = "bx-logingo-icon.png"
        Me.btnlogin.ImageList = Me.img_20x20
        Me.btnlogin.Location = New System.Drawing.Point(292, 467)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(92, 27)
        Me.btnlogin.TabIndex = 13
        Me.btnlogin.Text = "&PROCEED"
        Me.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'img_20x20
        '
        Me.img_20x20.ImageStream = CType(resources.GetObject("img_20x20.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_20x20.TransparentColor = System.Drawing.Color.Transparent
        Me.img_20x20.Images.SetKeyName(0, "bx-arrowdown-icon.png")
        Me.img_20x20.Images.SetKeyName(1, "bx-arrowup-icon.png")
        Me.img_20x20.Images.SetKeyName(2, "scale-on-icon.png")
        Me.img_20x20.Images.SetKeyName(3, "scale-off-icon.png")
        Me.img_20x20.Images.SetKeyName(4, "bx-add-icon.png")
        Me.img_20x20.Images.SetKeyName(5, "bx-del-icon.png")
        Me.img_20x20.Images.SetKeyName(6, "bx-edit-icon.png")
        Me.img_20x20.Images.SetKeyName(7, "bx-ref-icon.png")
        Me.img_20x20.Images.SetKeyName(8, "bx-exit-icon.png")
        Me.img_20x20.Images.SetKeyName(9, "bx-settings-icon.png")
        Me.img_20x20.Images.SetKeyName(10, "bx-recapture-icon.png")
        Me.img_20x20.Images.SetKeyName(11, "bx-arrowleft-icon.png")
        Me.img_20x20.Images.SetKeyName(12, "bx-arrowright-icon.png")
        Me.img_20x20.Images.SetKeyName(13, "bx-print-icon.png")
        Me.img_20x20.Images.SetKeyName(14, "bx-saveandprint-icon.png")
        Me.img_20x20.Images.SetKeyName(15, "bx-save-icon.png")
        Me.img_20x20.Images.SetKeyName(16, "bx-cancel-icon.png")
        Me.img_20x20.Images.SetKeyName(17, "bx-alllist-icon.png")
        Me.img_20x20.Images.SetKeyName(18, "bx-completed-icon.png")
        Me.img_20x20.Images.SetKeyName(19, "bx-pending-icon.png")
        Me.img_20x20.Images.SetKeyName(20, "bx-find-icon.png")
        Me.img_20x20.Images.SetKeyName(21, "bx-logingo-icon.png")
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Bisque
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(424, 3)
        Me.Panel4.TabIndex = 14
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(95, 13)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 296)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(424, 508)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOG IN : Scale System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnlogin As Button
    Friend WithEvents img_20x20 As ImageList
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
End Class
