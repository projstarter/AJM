<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.img_20x20 = New System.Windows.Forms.ImageList(Me.components)
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btndeactivate = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbousertype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpassword2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnickname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnokport = New System.Windows.Forms.Button()
        Me.txtstopbits = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtdatabits = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbaudrate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtreadtimeout = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboports = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(892, 395)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FloralWhite
        Me.TabPage1.Controls.Add(Me.btnrefresh)
        Me.TabPage1.Controls.Add(Me.btndelete)
        Me.TabPage1.Controls.Add(Me.btndeactivate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtg)
        Me.TabPage1.Controls.Add(Me.btncancel)
        Me.TabPage1.Controls.Add(Me.btnsave)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtnickname)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtfirstname)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtlastname)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(884, 367)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Accounts"
        '
        'btnrefresh
        '
        Me.btnrefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnrefresh.BackColor = System.Drawing.Color.OldLace
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefresh.ImageKey = "bx-ref-icon.png"
        Me.btnrefresh.ImageList = Me.img_20x20
        Me.btnrefresh.Location = New System.Drawing.Point(362, 321)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(100, 31)
        Me.btnrefresh.TabIndex = 63
        Me.btnrefresh.Text = "&Refresh List"
        Me.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'img_20x20
        '
        Me.img_20x20.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
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
        Me.img_20x20.Images.SetKeyName(21, "bx-shutdown-icon.png")
        '
        'btndelete
        '
        Me.btndelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndelete.BackColor = System.Drawing.Color.OldLace
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelete.ImageKey = "bx-del-icon.png"
        Me.btndelete.ImageList = Me.img_20x20
        Me.btndelete.Location = New System.Drawing.Point(673, 321)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(73, 31)
        Me.btndelete.TabIndex = 62
        Me.btndelete.Text = "&Delete"
        Me.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btndeactivate
        '
        Me.btndeactivate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btndeactivate.BackColor = System.Drawing.Color.OldLace
        Me.btndeactivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeactivate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeactivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeactivate.ImageKey = "bx-shutdown-icon.png"
        Me.btndeactivate.ImageList = Me.img_20x20
        Me.btndeactivate.Location = New System.Drawing.Point(752, 321)
        Me.btndeactivate.Name = "btndeactivate"
        Me.btndeactivate.Size = New System.Drawing.Size(114, 31)
        Me.btndeactivate.TabIndex = 61
        Me.btndeactivate.Text = "&Update Status"
        Me.btndeactivate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndeactivate.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(362, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "User List"
        '
        'dtg
        '
        Me.dtg.AllowUserToAddRows = False
        Me.dtg.AllowUserToDeleteRows = False
        Me.dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtg.BackgroundColor = System.Drawing.Color.White
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dtg.Location = New System.Drawing.Point(362, 47)
        Me.dtg.Name = "dtg"
        Me.dtg.RowHeadersVisible = False
        Me.dtg.RowTemplate.Height = 25
        Me.dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg.Size = New System.Drawing.Size(504, 259)
        Me.dtg.TabIndex = 59
        '
        'btncancel
        '
        Me.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncancel.BackColor = System.Drawing.Color.OldLace
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancel.ImageKey = "bx-cancel-icon.png"
        Me.btncancel.ImageList = Me.img_20x20
        Me.btncancel.Location = New System.Drawing.Point(230, 321)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(77, 31)
        Me.btncancel.TabIndex = 58
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnsave.BackColor = System.Drawing.Color.OldLace
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsave.ImageKey = "bx-save-icon.png"
        Me.btnsave.ImageList = Me.img_20x20
        Me.btnsave.Location = New System.Drawing.Point(160, 321)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(64, 31)
        Me.btnsave.TabIndex = 11
        Me.btnsave.Text = "&Save"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbousertype)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtpassword2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtusername)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 159)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Credentials"
        '
        'cbousertype
        '
        Me.cbousertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbousertype.FormattingEnabled = True
        Me.cbousertype.Items.AddRange(New Object() {"Super Administrator", "Administrator", "Manager/Supervisor", "User/Staff"})
        Me.cbousertype.Location = New System.Drawing.Point(142, 117)
        Me.cbousertype.Name = "cbousertype"
        Me.cbousertype.Size = New System.Drawing.Size(153, 25)
        Me.cbousertype.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(61, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "User-type : "
        '
        'txtpassword2
        '
        Me.txtpassword2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpassword2.Location = New System.Drawing.Point(142, 87)
        Me.txtpassword2.Name = "txtpassword2"
        Me.txtpassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword2.Size = New System.Drawing.Size(153, 23)
        Me.txtpassword2.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(13, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Re-type Password : "
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtpassword.Location = New System.Drawing.Point(142, 57)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(153, 23)
        Me.txtpassword.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(61, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Password : "
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtusername.Location = New System.Drawing.Point(142, 27)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(153, 23)
        Me.txtusername.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(58, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Username : "
        '
        'txtnickname
        '
        Me.txtnickname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtnickname.Location = New System.Drawing.Point(91, 109)
        Me.txtnickname.Name = "txtnickname"
        Me.txtnickname.Size = New System.Drawing.Size(218, 23)
        Me.txtnickname.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Nickname : "
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtfirstname.Location = New System.Drawing.Point(91, 78)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(218, 23)
        Me.txtfirstname.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Firstname : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Enroll/register user : "
        '
        'txtlastname
        '
        Me.txtlastname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtlastname.Location = New System.Drawing.Point(91, 47)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(218, 23)
        Me.txtlastname.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(12, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Lastname : "
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FloralWhite
        Me.TabPage2.Controls.Add(Me.btnokport)
        Me.TabPage2.Controls.Add(Me.txtstopbits)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtdatabits)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtbaudrate)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtreadtimeout)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.cboports)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(884, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Port Configuration"
        '
        'btnokport
        '
        Me.btnokport.Location = New System.Drawing.Point(791, 324)
        Me.btnokport.Name = "btnokport"
        Me.btnokport.Size = New System.Drawing.Size(75, 29)
        Me.btnokport.TabIndex = 75
        Me.btnokport.Text = "OK"
        Me.btnokport.UseVisualStyleBackColor = True
        '
        'txtstopbits
        '
        Me.txtstopbits.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtstopbits.Location = New System.Drawing.Point(138, 169)
        Me.txtstopbits.Name = "txtstopbits"
        Me.txtstopbits.Size = New System.Drawing.Size(117, 23)
        Me.txtstopbits.TabIndex = 73
        Me.txtstopbits.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(12, 172)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 16)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Stop Bits : "
        '
        'txtdatabits
        '
        Me.txtdatabits.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtdatabits.Location = New System.Drawing.Point(138, 142)
        Me.txtdatabits.Name = "txtdatabits"
        Me.txtdatabits.Size = New System.Drawing.Size(117, 23)
        Me.txtdatabits.TabIndex = 71
        Me.txtdatabits.Text = "8"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(12, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Data Bits : "
        '
        'txtbaudrate
        '
        Me.txtbaudrate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbaudrate.Location = New System.Drawing.Point(138, 115)
        Me.txtbaudrate.Name = "txtbaudrate"
        Me.txtbaudrate.Size = New System.Drawing.Size(117, 23)
        Me.txtbaudrate.TabIndex = 69
        Me.txtbaudrate.Text = "9600"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(12, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Baud Rate : "
        '
        'txtreadtimeout
        '
        Me.txtreadtimeout.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtreadtimeout.Location = New System.Drawing.Point(138, 88)
        Me.txtreadtimeout.Name = "txtreadtimeout"
        Me.txtreadtimeout.Size = New System.Drawing.Size(117, 23)
        Me.txtreadtimeout.TabIndex = 67
        Me.txtreadtimeout.Text = "10000"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(12, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Read Timeout : "
        '
        'cboports
        '
        Me.cboports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboports.FormattingEnabled = True
        Me.cboports.Items.AddRange(New Object() {"Super Administrator", "Administrator", "Manager/Supervisor", "User/Staff"})
        Me.cboports.Location = New System.Drawing.Point(102, 48)
        Me.cboports.Name = "cboports"
        Me.cboports.Size = New System.Drawing.Size(153, 23)
        Me.cboports.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(12, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 16)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Port (COM) : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(8, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 16)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Port Configuration"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 5
        '
        'Column2
        '
        Me.Column2.HeaderText = "UserId"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 65
        '
        'Column3
        '
        Me.Column3.HeaderText = "Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 64
        '
        'Column4
        '
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 85
        '
        'Column5
        '
        Me.Column5.HeaderText = "Password"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 82
        '
        'Column6
        '
        Me.Column6.HeaderText = "User Type"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 82
        '
        'Column7
        '
        Me.Column7.HeaderText = "Status"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 64
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 395)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbousertype As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpassword2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnickname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents img_20x20 As ImageList
    Friend WithEvents btndeactivate As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents dtg As DataGridView
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnrefresh As Button
    Friend WithEvents btnokport As Button
    Friend WithEvents txtstopbits As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtdatabits As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbaudrate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtreadtimeout As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboports As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
