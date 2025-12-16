<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionWindow))
        Me.txtslipno = New System.Windows.Forms.TextBox()
        Me.txttransactiondate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbloutbounddate = New System.Windows.Forms.Label()
        Me.lblinbounddate = New System.Windows.Forms.Label()
        Me.btnW2 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtOutBound = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtInBound = New System.Windows.Forms.TextBox()
        Me.rbtnWSI = New System.Windows.Forms.RadioButton()
        Me.rbtnWSR = New System.Windows.Forms.RadioButton()
        Me.cboTransactionType = New System.Windows.Forms.ComboBox()
        Me.btnW1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbodrivername = New System.Windows.Forms.ComboBox()
        Me.cbotruckername = New System.Windows.Forms.ComboBox()
        Me.cbowarehouse = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbovarietycode = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtqtyave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttare = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtplateno = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClearEntry = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.chkPrintAfterSave = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtslipno
        '
        Me.txtslipno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtslipno.Location = New System.Drawing.Point(117, 83)
        Me.txtslipno.Name = "txtslipno"
        Me.txtslipno.Size = New System.Drawing.Size(194, 29)
        Me.txtslipno.TabIndex = 0
        '
        'txttransactiondate
        '
        Me.txttransactiondate.Enabled = False
        Me.txttransactiondate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransactiondate.Location = New System.Drawing.Point(563, 83)
        Me.txttransactiondate.Name = "txttransactiondate"
        Me.txttransactiondate.Size = New System.Drawing.Size(127, 29)
        Me.txttransactiondate.TabIndex = 15
        Me.txttransactiondate.Text = "2021-04-19"
        Me.txttransactiondate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(33, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "SLIP NO. :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(503, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "DATE :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 53)
        Me.Panel1.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(665, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(58, 53)
        Me.Panel5.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ImageKey = "close x -2.png"
        Me.btnClose.ImageList = Me.ImageList1
        Me.btnClose.Location = New System.Drawing.Point(13, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 26)
        Me.btnClose.TabIndex = 16
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close x.png")
        Me.ImageList1.Images.SetKeyName(1, "close x -2.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(48, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRANSACTION WINDOW"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(10, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "TRUCKER NAME :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(10, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DRIVER'S NAME :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbloutbounddate)
        Me.GroupBox2.Controls.Add(Me.lblinbounddate)
        Me.GroupBox2.Controls.Add(Me.btnW2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtOutBound)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtInBound)
        Me.GroupBox2.Controls.Add(Me.rbtnWSI)
        Me.GroupBox2.Controls.Add(Me.rbtnWSR)
        Me.GroupBox2.Controls.Add(Me.cboTransactionType)
        Me.GroupBox2.Controls.Add(Me.btnW1)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbodrivername)
        Me.GroupBox2.Controls.Add(Me.cbotruckername)
        Me.GroupBox2.Controls.Add(Me.cbowarehouse)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cbovarietycode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtqtyave)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtnet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txttare)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtgross)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtplateno)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox2.Location = New System.Drawing.Point(17, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 438)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TRANSACTION DETAILS"
        '
        'lbloutbounddate
        '
        Me.lbloutbounddate.AutoSize = True
        Me.lbloutbounddate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutbounddate.ForeColor = System.Drawing.Color.Black
        Me.lbloutbounddate.Location = New System.Drawing.Point(438, 392)
        Me.lbloutbounddate.Name = "lbloutbounddate"
        Me.lbloutbounddate.Size = New System.Drawing.Size(78, 17)
        Me.lbloutbounddate.TabIndex = 52
        Me.lbloutbounddate.Text = "IN-BOUND :"
        '
        'lblinbounddate
        '
        Me.lblinbounddate.AutoSize = True
        Me.lblinbounddate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinbounddate.ForeColor = System.Drawing.Color.Black
        Me.lblinbounddate.Location = New System.Drawing.Point(438, 325)
        Me.lblinbounddate.Name = "lblinbounddate"
        Me.lblinbounddate.Size = New System.Drawing.Size(78, 17)
        Me.lblinbounddate.TabIndex = 51
        Me.lblinbounddate.Text = "IN-BOUND :"
        '
        'btnW2
        '
        Me.btnW2.BackColor = System.Drawing.Color.Transparent
        Me.btnW2.FlatAppearance.BorderSize = 0
        Me.btnW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW2.ForeColor = System.Drawing.Color.Black
        Me.btnW2.ImageKey = "Downloads-2-icon (1).png"
        Me.btnW2.ImageList = Me.ImageList2
        Me.btnW2.Location = New System.Drawing.Point(534, 361)
        Me.btnW2.Name = "btnW2"
        Me.btnW2.Size = New System.Drawing.Size(27, 27)
        Me.btnW2.TabIndex = 50
        Me.btnW2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnW2.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Downloads-2-icon (1).png")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(323, 364)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 21)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "OUT-BOUND :"
        '
        'txtOutBound
        '
        Me.txtOutBound.Enabled = False
        Me.txtOutBound.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutBound.Location = New System.Drawing.Point(438, 360)
        Me.txtOutBound.Name = "txtOutBound"
        Me.txtOutBound.Size = New System.Drawing.Size(90, 29)
        Me.txtOutBound.TabIndex = 48
        Me.txtOutBound.Text = "0"
        Me.txtOutBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(338, 297)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 21)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "IN-BOUND :"
        '
        'txtInBound
        '
        Me.txtInBound.Enabled = False
        Me.txtInBound.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInBound.Location = New System.Drawing.Point(438, 293)
        Me.txtInBound.Name = "txtInBound"
        Me.txtInBound.Size = New System.Drawing.Size(90, 29)
        Me.txtInBound.TabIndex = 46
        Me.txtInBound.Text = "0"
        Me.txtInBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'rbtnWSI
        '
        Me.rbtnWSI.AutoSize = True
        Me.rbtnWSI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWSI.Location = New System.Drawing.Point(611, 41)
        Me.rbtnWSI.Name = "rbtnWSI"
        Me.rbtnWSI.Size = New System.Drawing.Size(56, 25)
        Me.rbtnWSI.TabIndex = 45
        Me.rbtnWSI.Text = "WSI"
        Me.rbtnWSI.UseVisualStyleBackColor = True
        '
        'rbtnWSR
        '
        Me.rbtnWSR.AutoSize = True
        Me.rbtnWSR.Checked = True
        Me.rbtnWSR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnWSR.Location = New System.Drawing.Point(539, 41)
        Me.rbtnWSR.Name = "rbtnWSR"
        Me.rbtnWSR.Size = New System.Drawing.Size(62, 25)
        Me.rbtnWSR.TabIndex = 44
        Me.rbtnWSR.TabStop = True
        Me.rbtnWSR.Text = "WSR"
        Me.rbtnWSR.UseVisualStyleBackColor = True
        '
        'cboTransactionType
        '
        Me.cboTransactionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboTransactionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTransactionType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTransactionType.FormattingEnabled = True
        Me.cboTransactionType.Items.AddRange(New Object() {"MILLING", "TRANSFER", "DISPERSAL"})
        Me.cboTransactionType.Location = New System.Drawing.Point(155, 39)
        Me.cboTransactionType.Name = "cboTransactionType"
        Me.cboTransactionType.Size = New System.Drawing.Size(361, 29)
        Me.cboTransactionType.TabIndex = 0
        '
        'btnW1
        '
        Me.btnW1.BackColor = System.Drawing.Color.Transparent
        Me.btnW1.FlatAppearance.BorderSize = 0
        Me.btnW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW1.ForeColor = System.Drawing.Color.Black
        Me.btnW1.ImageKey = "Downloads-2-icon (1).png"
        Me.btnW1.ImageList = Me.ImageList2
        Me.btnW1.Location = New System.Drawing.Point(534, 294)
        Me.btnW1.Name = "btnW1"
        Me.btnW1.Size = New System.Drawing.Size(27, 27)
        Me.btnW1.TabIndex = 6
        Me.btnW1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnW1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label12.Location = New System.Drawing.Point(90, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 21)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "TYPE :"
        '
        'cbodrivername
        '
        Me.cbodrivername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodrivername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodrivername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodrivername.FormattingEnabled = True
        Me.cbodrivername.Location = New System.Drawing.Point(155, 127)
        Me.cbodrivername.Name = "cbodrivername"
        Me.cbodrivername.Size = New System.Drawing.Size(512, 29)
        Me.cbodrivername.TabIndex = 2
        '
        'cbotruckername
        '
        Me.cbotruckername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbotruckername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotruckername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotruckername.FormattingEnabled = True
        Me.cbotruckername.Location = New System.Drawing.Point(155, 83)
        Me.cbotruckername.Name = "cbotruckername"
        Me.cbotruckername.Size = New System.Drawing.Size(512, 29)
        Me.cbotruckername.TabIndex = 1
        '
        'cbowarehouse
        '
        Me.cbowarehouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbowarehouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbowarehouse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbowarehouse.FormattingEnabled = True
        Me.cbowarehouse.Location = New System.Drawing.Point(154, 215)
        Me.cbowarehouse.Name = "cbowarehouse"
        Me.cbowarehouse.Size = New System.Drawing.Size(513, 29)
        Me.cbowarehouse.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(31, 219)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 21)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "WAREHOUSE :"
        '
        'cbovarietycode
        '
        Me.cbovarietycode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbovarietycode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbovarietycode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbovarietycode.FormattingEnabled = True
        Me.cbovarietycode.Location = New System.Drawing.Point(582, 171)
        Me.cbovarietycode.Name = "cbovarietycode"
        Me.cbovarietycode.Size = New System.Drawing.Size(85, 29)
        Me.cbovarietycode.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(267, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "QTY / AVE. :"
        '
        'txtqtyave
        '
        Me.txtqtyave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqtyave.Location = New System.Drawing.Point(360, 171)
        Me.txtqtyave.Name = "txtqtyave"
        Me.txtqtyave.Size = New System.Drawing.Size(82, 29)
        Me.txtqtyave.TabIndex = 4
        Me.txtqtyave.Text = "0"
        Me.txtqtyave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(456, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 21)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "VARIETY CODE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(35, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 21)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "NET WEIGHT :"
        '
        'txtnet
        '
        Me.txtnet.Enabled = False
        Me.txtnet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnet.Location = New System.Drawing.Point(154, 381)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Size = New System.Drawing.Size(90, 29)
        Me.txtnet.TabIndex = 30
        Me.txtnet.Text = "0"
        Me.txtnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(28, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 21)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "TARE WEIGHT :"
        '
        'txttare
        '
        Me.txttare.Enabled = False
        Me.txttare.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttare.Location = New System.Drawing.Point(154, 337)
        Me.txttare.Name = "txttare"
        Me.txttare.Size = New System.Drawing.Size(90, 29)
        Me.txttare.TabIndex = 28
        Me.txttare.Text = "0"
        Me.txttare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(12, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "GROSS WEIGHT :"
        '
        'txtgross
        '
        Me.txtgross.Enabled = False
        Me.txtgross.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgross.Location = New System.Drawing.Point(154, 293)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(90, 29)
        Me.txtgross.TabIndex = 26
        Me.txtgross.Text = "0"
        Me.txtgross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(51, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "PLATE NO. :"
        '
        'txtplateno
        '
        Me.txtplateno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplateno.Location = New System.Drawing.Point(154, 171)
        Me.txtplateno.Name = "txtplateno"
        Me.txtplateno.Size = New System.Drawing.Size(107, 29)
        Me.txtplateno.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.btnClearEntry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 584)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(723, 45)
        Me.Panel3.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(518, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 34)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(621, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClearEntry
        '
        Me.btnClearEntry.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClearEntry.FlatAppearance.BorderSize = 0
        Me.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearEntry.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEntry.Location = New System.Drawing.Point(7, 5)
        Me.btnClearEntry.Name = "btnClearEntry"
        Me.btnClearEntry.Size = New System.Drawing.Size(95, 34)
        Me.btnClearEntry.TabIndex = 2
        Me.btnClearEntry.Text = "Clear &Entry"
        Me.btnClearEntry.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ControlToolStripMenuItem
        '
        Me.ControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancelToolStripMenuItem})
        Me.ControlToolStripMenuItem.Name = "ControlToolStripMenuItem"
        Me.ControlToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ControlToolStripMenuItem.Text = "Control"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(679, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 53)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(723, 3)
        Me.Panel4.TabIndex = 27
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'chkPrintAfterSave
        '
        Me.chkPrintAfterSave.AutoSize = True
        Me.chkPrintAfterSave.Checked = True
        Me.chkPrintAfterSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrintAfterSave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintAfterSave.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkPrintAfterSave.Location = New System.Drawing.Point(317, 85)
        Me.chkPrintAfterSave.Name = "chkPrintAfterSave"
        Me.chkPrintAfterSave.Size = New System.Drawing.Size(135, 25)
        Me.chkPrintAfterSave.TabIndex = 28
        Me.chkPrintAfterSave.Text = "Print after Save"
        Me.chkPrintAfterSave.UseVisualStyleBackColor = True
        '
        'frmTransactionWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(723, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkPrintAfterSave)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtslipno)
        Me.Controls.Add(Me.txttransactiondate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmTransactionWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Transaction Window"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtslipno As TextBox
    Friend WithEvents txttransactiondate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbovarietycode As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtqtyave As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnet As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txttare As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtgross As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtplateno As TextBox
    Friend WithEvents cbowarehouse As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClearEntry As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbodrivername As ComboBox
    Friend WithEvents cbotruckername As ComboBox
    Friend WithEvents ControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents btnW1 As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents chkPrintAfterSave As CheckBox
    Friend WithEvents cboTransactionType As ComboBox
    Friend WithEvents rbtnWSI As RadioButton
    Friend WithEvents rbtnWSR As RadioButton
    Friend WithEvents btnW2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtOutBound As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtInBound As TextBox
    Friend WithEvents lbloutbounddate As Label
    Friend WithEvents lblinbounddate As Label
End Class
