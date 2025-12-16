<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNFA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNFA))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnEditTransaction = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddTransaction = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitem_addtransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuite_edittransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitem_deletetransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitem_refreshall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitem_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitem_portconfiguration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitem_useraccounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblUserAccount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.weighScale = New System.IO.Ports.SerialPort(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnexportpendingtransactionexport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.StatusStrip3 = New System.Windows.Forms.StatusStrip()
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbleditstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblportStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblportError = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblstopbits = New System.Windows.Forms.Label()
        Me.lbldatabits = New System.Windows.Forms.Label()
        Me.lblbaudrate = New System.Windows.Forms.Label()
        Me.lblreadtimeout = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panel_completedtransaction = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.dtgcompletedtransaction = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblcompletedstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncompletedexport = New System.Windows.Forms.Button()
        Me.btnrefreshcompleted = New System.Windows.Forms.Button()
        Me.btnsearchcompleted = New System.Windows.Forms.Button()
        Me.txtsearchcompleted = New System.Windows.Forms.TextBox()
        Me.cbodisplayfilter = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.panel_pendingtransaction = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.dtgpendingtransaction = New System.Windows.Forms.DataGridView()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblpendingstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnpendingexport = New System.Windows.Forms.Button()
        Me.btnrefreshpending = New System.Windows.Forms.Button()
        Me.btnsearchpending = New System.Windows.Forms.Button()
        Me.txtsearchpending = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.panel_transaction = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtfee = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtave = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtnoofbags = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbosupplier = New System.Windows.Forms.ComboBox()
        Me.btnwaive = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbodrivername = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txttransactionid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lbloutbounddate = New System.Windows.Forms.Label()
        Me.lblinbounddate = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtreferenceno = New System.Windows.Forms.TextBox()
        Me.txtOutBound = New System.Windows.Forms.TextBox()
        Me.txttransactiondate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtInBound = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbocargo = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtplateno = New System.Windows.Forms.TextBox()
        Me.txtnet = New System.Windows.Forms.TextBox()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.txttare = New System.Windows.Forms.TextBox()
        Me.btnW2 = New System.Windows.Forms.Button()
        Me.btnW1 = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.btnreprint = New System.Windows.Forms.Button()
        Me.btncanceltransaction = New System.Windows.Forms.Button()
        Me.btnsaveandprint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClearEntry = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.portMonitoring = New System.Windows.Forms.Timer(Me.components)
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsearchpendingtransaction = New System.Windows.Forms.ToolStripButton()
        Me.btnrefreshpendingtransaction = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.btncompletetransactionexport = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panel_completedtransaction.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.dtgcompletedtransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panel_pendingtransaction.SuspendLayout()
        Me.Panel16.SuspendLayout()
        CType(Me.dtgpendingtransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.panel_transaction.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel18.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 121)
        Me.Panel1.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(103, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 17)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Damilag, 8703 Manolo Fortich, Bukidnon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "POLCAS AGRITRADE"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnEditTransaction)
        Me.Panel7.Controls.Add(Me.btnDelete)
        Me.Panel7.Controls.Add(Me.btnAddTransaction)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(664, 24)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(436, 97)
        Me.Panel7.TabIndex = 22
        '
        'btnEditTransaction
        '
        Me.btnEditTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditTransaction.FlatAppearance.BorderSize = 0
        Me.btnEditTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnEditTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTransaction.Image = CType(resources.GetObject("btnEditTransaction.Image"), System.Drawing.Image)
        Me.btnEditTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditTransaction.Location = New System.Drawing.Point(145, 3)
        Me.btnEditTransaction.Name = "btnEditTransaction"
        Me.btnEditTransaction.Size = New System.Drawing.Size(130, 91)
        Me.btnEditTransaction.TabIndex = 4
        Me.btnEditTransaction.Text = "&EDIT TRANSACTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F2)"
        Me.btnEditTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditTransaction.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(277, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 91)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "&DELETE TRANSACTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(DEL)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddTransaction
        '
        Me.btnAddTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTransaction.FlatAppearance.BorderSize = 0
        Me.btnAddTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue
        Me.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTransaction.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTransaction.Image = CType(resources.GetObject("btnAddTransaction.Image"), System.Drawing.Image)
        Me.btnAddTransaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddTransaction.Location = New System.Drawing.Point(13, 3)
        Me.btnAddTransaction.Name = "btnAddTransaction"
        Me.btnAddTransaction.Size = New System.Drawing.Size(130, 91)
        Me.btnAddTransaction.TabIndex = 0
        Me.btnAddTransaction.Text = "&ADD TRANSACTION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(F3)"
        Me.btnAddTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddTransaction.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1100, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitem_addtransaction, Me.menuite_edittransaction, Me.menuitem_deletetransaction, Me.ToolStripSeparator11, Me.menuitem_refreshall, Me.ToolStripSeparator3, Me.menuitem_exit})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'menuitem_addtransaction
        '
        Me.menuitem_addtransaction.Image = CType(resources.GetObject("menuitem_addtransaction.Image"), System.Drawing.Image)
        Me.menuitem_addtransaction.Name = "menuitem_addtransaction"
        Me.menuitem_addtransaction.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.menuitem_addtransaction.Size = New System.Drawing.Size(198, 26)
        Me.menuitem_addtransaction.Text = "&Add Transaction"
        '
        'menuite_edittransaction
        '
        Me.menuite_edittransaction.Image = CType(resources.GetObject("menuite_edittransaction.Image"), System.Drawing.Image)
        Me.menuite_edittransaction.Name = "menuite_edittransaction"
        Me.menuite_edittransaction.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.menuite_edittransaction.Size = New System.Drawing.Size(198, 26)
        Me.menuite_edittransaction.Text = "&Edit Transaction"
        '
        'menuitem_deletetransaction
        '
        Me.menuitem_deletetransaction.Image = CType(resources.GetObject("menuitem_deletetransaction.Image"), System.Drawing.Image)
        Me.menuitem_deletetransaction.Name = "menuitem_deletetransaction"
        Me.menuitem_deletetransaction.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.menuitem_deletetransaction.Size = New System.Drawing.Size(198, 26)
        Me.menuitem_deletetransaction.Text = "&Delete Transaction"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(195, 6)
        '
        'menuitem_refreshall
        '
        Me.menuitem_refreshall.Image = CType(resources.GetObject("menuitem_refreshall.Image"), System.Drawing.Image)
        Me.menuitem_refreshall.Name = "menuitem_refreshall"
        Me.menuitem_refreshall.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.menuitem_refreshall.Size = New System.Drawing.Size(198, 26)
        Me.menuitem_refreshall.Text = "Refresh All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(195, 6)
        '
        'menuitem_exit
        '
        Me.menuitem_exit.Image = CType(resources.GetObject("menuitem_exit.Image"), System.Drawing.Image)
        Me.menuitem_exit.Name = "menuitem_exit"
        Me.menuitem_exit.Size = New System.Drawing.Size(198, 26)
        Me.menuitem_exit.Text = "E&xit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitem_portconfiguration, Me.ToolStripSeparator15, Me.menuitem_useraccounts})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'menuitem_portconfiguration
        '
        Me.menuitem_portconfiguration.Image = CType(resources.GetObject("menuitem_portconfiguration.Image"), System.Drawing.Image)
        Me.menuitem_portconfiguration.Name = "menuitem_portconfiguration"
        Me.menuitem_portconfiguration.Size = New System.Drawing.Size(177, 26)
        Me.menuitem_portconfiguration.Text = "Port Configuration"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(174, 6)
        '
        'menuitem_useraccounts
        '
        Me.menuitem_useraccounts.Image = CType(resources.GetObject("menuitem_useraccounts.Image"), System.Drawing.Image)
        Me.menuitem_useraccounts.Name = "menuitem_useraccounts"
        Me.menuitem_useraccounts.Size = New System.Drawing.Size(177, 26)
        Me.menuitem_useraccounts.Text = "User Accounts"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddTransactionToolStripMenuItem
        '
        Me.AddTransactionToolStripMenuItem.Name = "AddTransactionToolStripMenuItem"
        Me.AddTransactionToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.AddTransactionToolStripMenuItem.Text = "&Transaction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(153, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(153, 6)
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ReportsToolStripMenuItem.Text = "Setting(s)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(174, 6)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1100, 3)
        Me.Panel2.TabIndex = 23
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "Actions-dialog-ok-apply-icon.png")
        Me.ImageList2.Images.SetKeyName(1, "Actions-edit-delete-icon.png")
        Me.ImageList2.Images.SetKeyName(2, "Actions-view-refresh-icon (1).png")
        Me.ImageList2.Images.SetKeyName(3, "search-icon (1).png")
        Me.ImageList2.Images.SetKeyName(4, "Excel-icon.png")
        '
        'lblUserAccount
        '
        Me.lblUserAccount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblUserAccount.Name = "lblUserAccount"
        Me.lblUserAccount.Size = New System.Drawing.Size(123, 19)
        Me.lblUserAccount.Text = "ToolStripStatusLabel1"
        '
        'weighScale
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Downloads-2-icon (1).png")
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(43, 28)
        Me.ToolStripLabel3.Text = "FIND :"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 31)
        '
        'btnexportpendingtransactionexport
        '
        Me.btnexportpendingtransactionexport.Name = "btnexportpendingtransactionexport"
        Me.btnexportpendingtransactionexport.Size = New System.Drawing.Size(23, 23)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(101, 28)
        Me.ToolStripLabel4.Text = "DISPLAY FILTER :"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(43, 28)
        Me.ToolStripLabel1.Text = "FIND :"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 31)
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BackgroundWorker1
        '
        '
        'StatusStrip3
        '
        Me.StatusStrip3.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstatus, Me.lbleditstatus, Me.lblportStatus})
        Me.StatusStrip3.Location = New System.Drawing.Point(0, 745)
        Me.StatusStrip3.Name = "StatusStrip3"
        Me.StatusStrip3.Size = New System.Drawing.Size(1100, 22)
        Me.StatusStrip3.TabIndex = 66
        Me.StatusStrip3.Text = "StatusStrip3"
        '
        'lblstatus
        '
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(119, 17)
        Me.lblstatus.Text = "ToolStripStatusLabel2"
        '
        'lbleditstatus
        '
        Me.lbleditstatus.Name = "lbleditstatus"
        Me.lbleditstatus.Size = New System.Drawing.Size(119, 17)
        Me.lbleditstatus.Text = "ToolStripStatusLabel3"
        '
        'lblportStatus
        '
        Me.lblportStatus.Name = "lblportStatus"
        Me.lblportStatus.Size = New System.Drawing.Size(119, 17)
        Me.lblportStatus.Text = "ToolStripStatusLabel4"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel14)
        Me.Panel8.Controls.Add(Me.lblportError)
        Me.Panel8.Controls.Add(Me.GroupBox1)
        Me.Panel8.Controls.Add(Me.Label7)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(640, 124)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(460, 621)
        Me.Panel8.TabIndex = 67
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label35)
        Me.Panel14.Controls.Add(Me.Label31)
        Me.Panel14.Controls.Add(Me.Label36)
        Me.Panel14.Controls.Add(Me.Label32)
        Me.Panel14.Controls.Add(Me.Label33)
        Me.Panel14.Controls.Add(Me.Label34)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(458, 102)
        Me.Panel14.TabIndex = 49
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(302, 52)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(145, 32)
        Me.Label35.TabIndex = 65
        Me.Label35.Text = "Yaohua"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(12, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(145, 32)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "SERIAL NO"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(302, 18)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(145, 32)
        Me.Label36.TabIndex = 64
        Me.Label36.Text = "BRAND"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(12, 52)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(145, 32)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "XK3190 D2+"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(157, 52)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(145, 32)
        Me.Label33.TabIndex = 63
        Me.Label33.Text = "80,000.00"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(157, 18)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(145, 32)
        Me.Label34.TabIndex = 62
        Me.Label34.Text = " CAPACITY"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblportError
        '
        Me.lblportError.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblportError.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblportError.ForeColor = System.Drawing.Color.Red
        Me.lblportError.Location = New System.Drawing.Point(12, 469)
        Me.lblportError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblportError.Name = "lblportError"
        Me.lblportError.Size = New System.Drawing.Size(439, 46)
        Me.lblportError.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblstopbits)
        Me.GroupBox1.Controls.Add(Me.lbldatabits)
        Me.GroupBox1.Controls.Add(Me.lblbaudrate)
        Me.GroupBox1.Controls.Add(Me.lblreadtimeout)
        Me.GroupBox1.Controls.Add(Me.lblPort)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(436, 191)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONNECTION INFO"
        '
        'lblstopbits
        '
        Me.lblstopbits.AutoSize = True
        Me.lblstopbits.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstopbits.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblstopbits.Location = New System.Drawing.Point(102, 157)
        Me.lblstopbits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblstopbits.Name = "lblstopbits"
        Me.lblstopbits.Size = New System.Drawing.Size(12, 15)
        Me.lblstopbits.TabIndex = 52
        Me.lblstopbits.Text = "_"
        '
        'lbldatabits
        '
        Me.lbldatabits.AutoSize = True
        Me.lbldatabits.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldatabits.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbldatabits.Location = New System.Drawing.Point(102, 127)
        Me.lbldatabits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldatabits.Name = "lbldatabits"
        Me.lbldatabits.Size = New System.Drawing.Size(12, 15)
        Me.lbldatabits.TabIndex = 51
        Me.lbldatabits.Text = "_"
        '
        'lblbaudrate
        '
        Me.lblbaudrate.AutoSize = True
        Me.lblbaudrate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbaudrate.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblbaudrate.Location = New System.Drawing.Point(102, 97)
        Me.lblbaudrate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbaudrate.Name = "lblbaudrate"
        Me.lblbaudrate.Size = New System.Drawing.Size(12, 15)
        Me.lblbaudrate.TabIndex = 50
        Me.lblbaudrate.Text = "_"
        '
        'lblreadtimeout
        '
        Me.lblreadtimeout.AutoSize = True
        Me.lblreadtimeout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreadtimeout.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblreadtimeout.Location = New System.Drawing.Point(102, 67)
        Me.lblreadtimeout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblreadtimeout.Name = "lblreadtimeout"
        Me.lblreadtimeout.Size = New System.Drawing.Size(12, 15)
        Me.lblreadtimeout.TabIndex = 49
        Me.lblreadtimeout.Text = "_"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblPort.Location = New System.Drawing.Point(102, 37)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(12, 15)
        Me.lblPort.TabIndex = 48
        Me.lblPort.Text = "_"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(36, 157)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "STOPBITS :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(37, 127)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "DATABITS :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(29, 97)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "BAUDRATE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 67)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "READTIMEOUT :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(58, 37)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 15)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "PORT :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(9, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 15)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "WEIGHING SCALE READING :"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Controls.Add(Me.lbloutput)
        Me.Panel9.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.ForeColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(12, 125)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(437, 127)
        Me.Panel9.TabIndex = 33
        '
        'lbloutput
        '
        Me.lbloutput.BackColor = System.Drawing.Color.Black
        Me.lbloutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbloutput.Font = New System.Drawing.Font("Calibri", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutput.ForeColor = System.Drawing.Color.Lime
        Me.lbloutput.Location = New System.Drawing.Point(0, 0)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(437, 127)
        Me.lbloutput.TabIndex = 36
        Me.lbloutput.Text = "11111"
        Me.lbloutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 621)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel12)
        Me.TabPage1.Controls.Add(Me.Panel13)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(632, 591)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dashboard"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.panel_completedtransaction)
        Me.Panel4.Controls.Add(Me.panel_pendingtransaction)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 46)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(626, 542)
        Me.Panel4.TabIndex = 57
        '
        'panel_completedtransaction
        '
        Me.panel_completedtransaction.Controls.Add(Me.Panel5)
        Me.panel_completedtransaction.Controls.Add(Me.Panel15)
        Me.panel_completedtransaction.Controls.Add(Me.StatusStrip1)
        Me.panel_completedtransaction.Controls.Add(Me.Panel19)
        Me.panel_completedtransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_completedtransaction.Location = New System.Drawing.Point(0, 217)
        Me.panel_completedtransaction.Name = "panel_completedtransaction"
        Me.panel_completedtransaction.Size = New System.Drawing.Size(626, 325)
        Me.panel_completedtransaction.TabIndex = 68
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.Controls.Add(Me.btnCancel)
        Me.Panel5.Controls.Add(Me.btnApply)
        Me.Panel5.Controls.Add(Me.dtpto)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.dtpfrom)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(70, 29)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(121, 134)
        Me.Panel5.TabIndex = 63
        Me.Panel5.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.ImageKey = "Actions-edit-delete-icon.png"
        Me.btnCancel.ImageList = Me.ImageList2
        Me.btnCancel.Location = New System.Drawing.Point(8, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(43, 25)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnApply.FlatAppearance.BorderSize = 0
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnApply.ImageKey = "Actions-dialog-ok-apply-icon.png"
        Me.btnApply.ImageList = Me.ImageList2
        Me.btnApply.Location = New System.Drawing.Point(70, 102)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(43, 25)
        Me.btnApply.TabIndex = 5
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'dtpto
        '
        Me.dtpto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpto.Location = New System.Drawing.Point(8, 71)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(105, 20)
        Me.dtpto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "END DATE"
        '
        'dtpfrom
        '
        Me.dtpfrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfrom.Location = New System.Drawing.Point(8, 26)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(105, 20)
        Me.dtpfrom.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "START DATE"
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.dtgcompletedtransaction)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel15.Location = New System.Drawing.Point(0, 35)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(626, 268)
        Me.Panel15.TabIndex = 67
        '
        'dtgcompletedtransaction
        '
        Me.dtgcompletedtransaction.AllowUserToAddRows = False
        Me.dtgcompletedtransaction.AllowUserToDeleteRows = False
        Me.dtgcompletedtransaction.AllowUserToResizeColumns = False
        Me.dtgcompletedtransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.dtgcompletedtransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgcompletedtransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgcompletedtransaction.BackgroundColor = System.Drawing.Color.White
        Me.dtgcompletedtransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgcompletedtransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgcompletedtransaction.ColumnHeadersHeight = 30
        Me.dtgcompletedtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgcompletedtransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column9, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn14, Me.Column11, Me.Column12, Me.Column13, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.Column1, Me.Column2, Me.DataGridViewTextBoxColumn19})
        Me.dtgcompletedtransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgcompletedtransaction.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dtgcompletedtransaction.Location = New System.Drawing.Point(0, 0)
        Me.dtgcompletedtransaction.MultiSelect = False
        Me.dtgcompletedtransaction.Name = "dtgcompletedtransaction"
        Me.dtgcompletedtransaction.RowHeadersVisible = False
        Me.dtgcompletedtransaction.RowHeadersWidth = 82
        Me.dtgcompletedtransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcompletedtransaction.Size = New System.Drawing.Size(626, 268)
        Me.dtgcompletedtransaction.TabIndex = 67
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblcompletedstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 303)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 64
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblcompletedstatus
        '
        Me.lblcompletedstatus.Name = "lblcompletedstatus"
        Me.lblcompletedstatus.Size = New System.Drawing.Size(119, 17)
        Me.lblcompletedstatus.Text = "ToolStripStatusLabel1"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel19.Controls.Add(Me.Panel3)
        Me.Panel19.Controls.Add(Me.Label46)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel19.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(626, 35)
        Me.Panel19.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btncompletedexport)
        Me.Panel3.Controls.Add(Me.btnrefreshcompleted)
        Me.Panel3.Controls.Add(Me.btnsearchcompleted)
        Me.Panel3.Controls.Add(Me.txtsearchcompleted)
        Me.Panel3.Controls.Add(Me.cbodisplayfilter)
        Me.Panel3.Controls.Add(Me.Label41)
        Me.Panel3.Controls.Add(Me.Label40)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(-51, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(673, 31)
        Me.Panel3.TabIndex = 2
        '
        'btncompletedexport
        '
        Me.btncompletedexport.FlatAppearance.BorderSize = 0
        Me.btncompletedexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompletedexport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompletedexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompletedexport.ImageKey = "Excel-icon.png"
        Me.btncompletedexport.ImageList = Me.ImageList2
        Me.btncompletedexport.Location = New System.Drawing.Point(546, 4)
        Me.btncompletedexport.Name = "btncompletedexport"
        Me.btncompletedexport.Size = New System.Drawing.Size(121, 22)
        Me.btncompletedexport.TabIndex = 10
        Me.btncompletedexport.Text = "Export to Excel"
        Me.btncompletedexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncompletedexport.UseVisualStyleBackColor = True
        '
        'btnrefreshcompleted
        '
        Me.btnrefreshcompleted.FlatAppearance.BorderSize = 0
        Me.btnrefreshcompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefreshcompleted.ImageKey = "Actions-view-refresh-icon (1).png"
        Me.btnrefreshcompleted.ImageList = Me.ImageList2
        Me.btnrefreshcompleted.Location = New System.Drawing.Point(516, 4)
        Me.btnrefreshcompleted.Name = "btnrefreshcompleted"
        Me.btnrefreshcompleted.Size = New System.Drawing.Size(30, 22)
        Me.btnrefreshcompleted.TabIndex = 9
        Me.btnrefreshcompleted.UseVisualStyleBackColor = True
        '
        'btnsearchcompleted
        '
        Me.btnsearchcompleted.FlatAppearance.BorderSize = 0
        Me.btnsearchcompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchcompleted.ImageKey = "search-icon (1).png"
        Me.btnsearchcompleted.ImageList = Me.ImageList2
        Me.btnsearchcompleted.Location = New System.Drawing.Point(486, 4)
        Me.btnsearchcompleted.Name = "btnsearchcompleted"
        Me.btnsearchcompleted.Size = New System.Drawing.Size(30, 22)
        Me.btnsearchcompleted.TabIndex = 8
        Me.btnsearchcompleted.UseVisualStyleBackColor = True
        '
        'txtsearchcompleted
        '
        Me.txtsearchcompleted.Location = New System.Drawing.Point(290, 4)
        Me.txtsearchcompleted.Name = "txtsearchcompleted"
        Me.txtsearchcompleted.Size = New System.Drawing.Size(191, 22)
        Me.txtsearchcompleted.TabIndex = 7
        '
        'cbodisplayfilter
        '
        Me.cbodisplayfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodisplayfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodisplayfilter.FormattingEnabled = True
        Me.cbodisplayfilter.Items.AddRange(New Object() {"All Transaction", "Recent 30 Days", "Custom Date Range"})
        Me.cbodisplayfilter.Location = New System.Drawing.Point(116, 5)
        Me.cbodisplayfilter.Name = "cbodisplayfilter"
        Me.cbodisplayfilter.Size = New System.Drawing.Size(128, 21)
        Me.cbodisplayfilter.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label41.Location = New System.Drawing.Point(247, 7)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(39, 16)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "FIND:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label40.Location = New System.Drawing.Point(4, 7)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(108, 16)
        Me.Label40.TabIndex = 2
        Me.Label40.Text = "DISPLAY FILTER :"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label46.Location = New System.Drawing.Point(8, 7)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(166, 16)
        Me.Label46.TabIndex = 1
        Me.Label46.Text = "COMPLETED TRANSACTION"
        '
        'panel_pendingtransaction
        '
        Me.panel_pendingtransaction.Controls.Add(Me.Panel16)
        Me.panel_pendingtransaction.Controls.Add(Me.StatusStrip2)
        Me.panel_pendingtransaction.Controls.Add(Me.Panel17)
        Me.panel_pendingtransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_pendingtransaction.Location = New System.Drawing.Point(0, 0)
        Me.panel_pendingtransaction.Name = "panel_pendingtransaction"
        Me.panel_pendingtransaction.Size = New System.Drawing.Size(626, 217)
        Me.panel_pendingtransaction.TabIndex = 67
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.dtgpendingtransaction)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel16.Location = New System.Drawing.Point(0, 35)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(626, 160)
        Me.Panel16.TabIndex = 68
        '
        'dtgpendingtransaction
        '
        Me.dtgpendingtransaction.AllowUserToAddRows = False
        Me.dtgpendingtransaction.AllowUserToDeleteRows = False
        Me.dtgpendingtransaction.AllowUserToResizeColumns = False
        Me.dtgpendingtransaction.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        Me.dtgpendingtransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgpendingtransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgpendingtransaction.BackgroundColor = System.Drawing.Color.White
        Me.dtgpendingtransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtgpendingtransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgpendingtransaction.ColumnHeadersHeight = 30
        Me.dtgpendingtransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgpendingtransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.Column14, Me.DataGridViewTextBoxColumn1, Me.Column8, Me.DataGridViewTextBoxColumn5, Me.Column18, Me.Column10, Me.Column6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12})
        Me.dtgpendingtransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgpendingtransaction.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dtgpendingtransaction.Location = New System.Drawing.Point(0, 0)
        Me.dtgpendingtransaction.MultiSelect = False
        Me.dtgpendingtransaction.Name = "dtgpendingtransaction"
        Me.dtgpendingtransaction.RowHeadersVisible = False
        Me.dtgpendingtransaction.RowHeadersWidth = 82
        Me.dtgpendingtransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpendingtransaction.Size = New System.Drawing.Size(626, 160)
        Me.dtgpendingtransaction.TabIndex = 66
        '
        'StatusStrip2
        '
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblpendingstatus})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 195)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip2.TabIndex = 62
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblpendingstatus
        '
        Me.lblpendingstatus.Name = "lblpendingstatus"
        Me.lblpendingstatus.Size = New System.Drawing.Size(119, 17)
        Me.lblpendingstatus.Text = "ToolStripStatusLabel1"
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel17.Controls.Add(Me.Panel6)
        Me.Panel17.Controls.Add(Me.Label45)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel17.Location = New System.Drawing.Point(0, 0)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(626, 35)
        Me.Panel17.TabIndex = 57
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnpendingexport)
        Me.Panel6.Controls.Add(Me.btnrefreshpending)
        Me.Panel6.Controls.Add(Me.btnsearchpending)
        Me.Panel6.Controls.Add(Me.txtsearchpending)
        Me.Panel6.Controls.Add(Me.Label42)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(192, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(430, 31)
        Me.Panel6.TabIndex = 3
        '
        'btnpendingexport
        '
        Me.btnpendingexport.FlatAppearance.BorderSize = 0
        Me.btnpendingexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpendingexport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpendingexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpendingexport.ImageKey = "Excel-icon.png"
        Me.btnpendingexport.ImageList = Me.ImageList2
        Me.btnpendingexport.Location = New System.Drawing.Point(303, 4)
        Me.btnpendingexport.Name = "btnpendingexport"
        Me.btnpendingexport.Size = New System.Drawing.Size(121, 22)
        Me.btnpendingexport.TabIndex = 10
        Me.btnpendingexport.Text = "Export to Excel"
        Me.btnpendingexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnpendingexport.UseVisualStyleBackColor = True
        '
        'btnrefreshpending
        '
        Me.btnrefreshpending.FlatAppearance.BorderSize = 0
        Me.btnrefreshpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrefreshpending.ImageKey = "Actions-view-refresh-icon (1).png"
        Me.btnrefreshpending.ImageList = Me.ImageList2
        Me.btnrefreshpending.Location = New System.Drawing.Point(273, 4)
        Me.btnrefreshpending.Name = "btnrefreshpending"
        Me.btnrefreshpending.Size = New System.Drawing.Size(30, 22)
        Me.btnrefreshpending.TabIndex = 9
        Me.btnrefreshpending.UseVisualStyleBackColor = True
        '
        'btnsearchpending
        '
        Me.btnsearchpending.FlatAppearance.BorderSize = 0
        Me.btnsearchpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearchpending.ImageKey = "search-icon (1).png"
        Me.btnsearchpending.ImageList = Me.ImageList2
        Me.btnsearchpending.Location = New System.Drawing.Point(243, 4)
        Me.btnsearchpending.Name = "btnsearchpending"
        Me.btnsearchpending.Size = New System.Drawing.Size(30, 22)
        Me.btnsearchpending.TabIndex = 8
        Me.btnsearchpending.UseVisualStyleBackColor = True
        '
        'txtsearchpending
        '
        Me.txtsearchpending.Location = New System.Drawing.Point(47, 4)
        Me.txtsearchpending.Name = "txtsearchpending"
        Me.txtsearchpending.Size = New System.Drawing.Size(191, 22)
        Me.txtsearchpending.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label42.Location = New System.Drawing.Point(4, 7)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(39, 16)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "FIND:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label45.Location = New System.Drawing.Point(8, 7)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(146, 16)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "PENDING TRANSACTION"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(3, 43)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(626, 3)
        Me.Panel12.TabIndex = 56
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel13.Controls.Add(Me.PictureBox3)
        Me.Panel13.Controls.Add(Me.Label28)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(3, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(626, 40)
        Me.Panel13.TabIndex = 55
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label28.Location = New System.Drawing.Point(43, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "DASHBOARD"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.panel_transaction)
        Me.TabPage2.Controls.Add(Me.Panel18)
        Me.TabPage2.Controls.Add(Me.Panel10)
        Me.TabPage2.Controls.Add(Me.Panel11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(632, 591)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaction"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'panel_transaction
        '
        Me.panel_transaction.Controls.Add(Me.Label18)
        Me.panel_transaction.Controls.Add(Me.txtfee)
        Me.panel_transaction.Controls.Add(Me.Label17)
        Me.panel_transaction.Controls.Add(Me.txtave)
        Me.panel_transaction.Controls.Add(Me.Label14)
        Me.panel_transaction.Controls.Add(Me.txtnoofbags)
        Me.panel_transaction.Controls.Add(Me.Label6)
        Me.panel_transaction.Controls.Add(Me.cbosupplier)
        Me.panel_transaction.Controls.Add(Me.btnwaive)
        Me.panel_transaction.Controls.Add(Me.Label16)
        Me.panel_transaction.Controls.Add(Me.cbodrivername)
        Me.panel_transaction.Controls.Add(Me.Label47)
        Me.panel_transaction.Controls.Add(Me.Label5)
        Me.panel_transaction.Controls.Add(Me.Button2)
        Me.panel_transaction.Controls.Add(Me.txttransactionid)
        Me.panel_transaction.Controls.Add(Me.Button1)
        Me.panel_transaction.Controls.Add(Me.PictureBox5)
        Me.panel_transaction.Controls.Add(Me.PictureBox4)
        Me.panel_transaction.Controls.Add(Me.lbloutbounddate)
        Me.panel_transaction.Controls.Add(Me.lblinbounddate)
        Me.panel_transaction.Controls.Add(Me.Label15)
        Me.panel_transaction.Controls.Add(Me.txtreferenceno)
        Me.panel_transaction.Controls.Add(Me.txtOutBound)
        Me.panel_transaction.Controls.Add(Me.txttransactiondate)
        Me.panel_transaction.Controls.Add(Me.Label13)
        Me.panel_transaction.Controls.Add(Me.Label25)
        Me.panel_transaction.Controls.Add(Me.txtInBound)
        Me.panel_transaction.Controls.Add(Me.Label26)
        Me.panel_transaction.Controls.Add(Me.Label23)
        Me.panel_transaction.Controls.Add(Me.cbocargo)
        Me.panel_transaction.Controls.Add(Me.Label22)
        Me.panel_transaction.Controls.Add(Me.Label21)
        Me.panel_transaction.Controls.Add(Me.Label20)
        Me.panel_transaction.Controls.Add(Me.Label19)
        Me.panel_transaction.Controls.Add(Me.txtplateno)
        Me.panel_transaction.Controls.Add(Me.txtnet)
        Me.panel_transaction.Controls.Add(Me.txtgross)
        Me.panel_transaction.Controls.Add(Me.txttare)
        Me.panel_transaction.Controls.Add(Me.btnW2)
        Me.panel_transaction.Controls.Add(Me.btnW1)
        Me.panel_transaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_transaction.Location = New System.Drawing.Point(3, 46)
        Me.panel_transaction.Name = "panel_transaction"
        Me.panel_transaction.Size = New System.Drawing.Size(626, 486)
        Me.panel_transaction.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label18.Location = New System.Drawing.Point(22, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 16)
        Me.Label18.TabIndex = 153
        Me.Label18.Text = "Weighing Fee"
        '
        'txtfee
        '
        Me.txtfee.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfee.Location = New System.Drawing.Point(149, 191)
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(189, 23)
        Me.txtfee.TabIndex = 4
        Me.txtfee.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label17.Location = New System.Drawing.Point(344, 194)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 16)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "Ave. Weight per bag"
        '
        'txtave
        '
        Me.txtave.Enabled = False
        Me.txtave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtave.Location = New System.Drawing.Point(472, 191)
        Me.txtave.Name = "txtave"
        Me.txtave.ReadOnly = True
        Me.txtave.Size = New System.Drawing.Size(119, 23)
        Me.txtave.TabIndex = 5
        Me.txtave.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label14.Location = New System.Drawing.Point(425, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 16)
        Me.Label14.TabIndex = 149
        Me.Label14.Text = "No. of Bag(s)"
        '
        'txtnoofbags
        '
        Me.txtnoofbags.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoofbags.Location = New System.Drawing.Point(514, 158)
        Me.txtnoofbags.Name = "txtnoofbags"
        Me.txtnoofbags.Size = New System.Drawing.Size(77, 23)
        Me.txtnoofbags.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(22, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Supplier"
        '
        'cbosupplier
        '
        Me.cbosupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbosupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbosupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosupplier.FormattingEnabled = True
        Me.cbosupplier.Items.AddRange(New Object() {"MILLING", "TRANSFER", "DISPERSAL"})
        Me.cbosupplier.Location = New System.Drawing.Point(149, 224)
        Me.cbosupplier.Name = "cbosupplier"
        Me.cbosupplier.Size = New System.Drawing.Size(442, 24)
        Me.cbosupplier.TabIndex = 6
        '
        'btnwaive
        '
        Me.btnwaive.BackColor = System.Drawing.Color.Transparent
        Me.btnwaive.BackgroundImage = CType(resources.GetObject("btnwaive.BackgroundImage"), System.Drawing.Image)
        Me.btnwaive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnwaive.FlatAppearance.BorderSize = 0
        Me.btnwaive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnwaive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwaive.ForeColor = System.Drawing.Color.Black
        Me.btnwaive.ImageKey = "computer-remove-icon.png"
        Me.btnwaive.Location = New System.Drawing.Point(364, 333)
        Me.btnwaive.Name = "btnwaive"
        Me.btnwaive.Size = New System.Drawing.Size(27, 27)
        Me.btnwaive.TabIndex = 145
        Me.btnwaive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnwaive.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label16.Location = New System.Drawing.Point(22, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 16)
        Me.Label16.TabIndex = 144
        Me.Label16.Text = "Driver Name"
        '
        'cbodrivername
        '
        Me.cbodrivername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodrivername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodrivername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodrivername.FormattingEnabled = True
        Me.cbodrivername.Items.AddRange(New Object() {"MILLING", "TRANSFER", "DISPERSAL"})
        Me.cbodrivername.Location = New System.Drawing.Point(149, 124)
        Me.cbodrivername.Name = "cbodrivername"
        Me.cbodrivername.Size = New System.Drawing.Size(270, 24)
        Me.cbodrivername.TabIndex = 0
        '
        'Label47
        '
        Me.Label47.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.BackColor = System.Drawing.Color.FloralWhite
        Me.Label47.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DimGray
        Me.Label47.Location = New System.Drawing.Point(8, 37)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(611, 30)
        Me.Label47.TabIndex = 142
        Me.Label47.Text = "*Required Fields"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FloralWhite
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(8, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(611, 30)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "NOTE: Transaction will only be consider as COMPLETE when 2nd Weighing is done. Up" &
    "date is still applicable."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(755, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 34)
        Me.Button2.TabIndex = 136
        Me.Button2.Text = "&Save"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'txttransactionid
        '
        Me.txttransactionid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransactionid.Location = New System.Drawing.Point(149, 67)
        Me.txttransactionid.Name = "txttransactionid"
        Me.txttransactionid.Size = New System.Drawing.Size(71, 23)
        Me.txttransactionid.TabIndex = 55
        Me.txttransactionid.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(755, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 34)
        Me.Button1.TabIndex = 135
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(702, 334)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 17)
        Me.PictureBox5.TabIndex = 132
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(702, 285)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 17)
        Me.PictureBox4.TabIndex = 131
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'lbloutbounddate
        '
        Me.lbloutbounddate.AutoSize = True
        Me.lbloutbounddate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutbounddate.ForeColor = System.Drawing.Color.Black
        Me.lbloutbounddate.Location = New System.Drawing.Point(557, 357)
        Me.lbloutbounddate.Name = "lbloutbounddate"
        Me.lbloutbounddate.Size = New System.Drawing.Size(73, 16)
        Me.lbloutbounddate.TabIndex = 126
        Me.lbloutbounddate.Text = "IN-BOUND :"
        '
        'lblinbounddate
        '
        Me.lblinbounddate.AutoSize = True
        Me.lblinbounddate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinbounddate.ForeColor = System.Drawing.Color.Black
        Me.lblinbounddate.Location = New System.Drawing.Point(557, 308)
        Me.lblinbounddate.Name = "lblinbounddate"
        Me.lblinbounddate.Size = New System.Drawing.Size(73, 16)
        Me.lblinbounddate.TabIndex = 125
        Me.lblinbounddate.Text = "IN-BOUND :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label15.Location = New System.Drawing.Point(392, 338)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 16)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Out-bound (2nd Weighing)"
        '
        'txtreferenceno
        '
        Me.txtreferenceno.Enabled = False
        Me.txtreferenceno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferenceno.Location = New System.Drawing.Point(149, 92)
        Me.txtreferenceno.Name = "txtreferenceno"
        Me.txtreferenceno.Size = New System.Drawing.Size(145, 23)
        Me.txtreferenceno.TabIndex = 0
        '
        'txtOutBound
        '
        Me.txtOutBound.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutBound.Location = New System.Drawing.Point(560, 331)
        Me.txtOutBound.Name = "txtOutBound"
        Me.txtOutBound.Size = New System.Drawing.Size(96, 23)
        Me.txtOutBound.TabIndex = 123
        Me.txtOutBound.Text = "0"
        '
        'txttransactiondate
        '
        Me.txttransactiondate.Enabled = False
        Me.txttransactiondate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransactiondate.Location = New System.Drawing.Point(418, 92)
        Me.txttransactiondate.Name = "txttransactiondate"
        Me.txttransactiondate.Size = New System.Drawing.Size(173, 23)
        Me.txttransactiondate.TabIndex = 1
        Me.txttransactiondate.Text = "2021-04-19"
        Me.txttransactiondate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label13.Location = New System.Drawing.Point(407, 285)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 16)
        Me.Label13.TabIndex = 122
        Me.Label13.Text = "In-bound (1st Weighing)"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label25.Location = New System.Drawing.Point(22, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 16)
        Me.Label25.TabIndex = 116
        Me.Label25.Text = "Reference No."
        '
        'txtInBound
        '
        Me.txtInBound.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInBound.Location = New System.Drawing.Point(560, 282)
        Me.txtInBound.Name = "txtInBound"
        Me.txtInBound.Size = New System.Drawing.Size(96, 23)
        Me.txtInBound.TabIndex = 7
        Me.txtInBound.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label26.Location = New System.Drawing.Point(300, 95)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(104, 16)
        Me.Label26.TabIndex = 115
        Me.Label26.Text = "Transaction Date"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label23.Location = New System.Drawing.Point(22, 161)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 16)
        Me.Label23.TabIndex = 107
        Me.Label23.Text = "Cargo"
        '
        'cbocargo
        '
        Me.cbocargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbocargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbocargo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocargo.FormattingEnabled = True
        Me.cbocargo.Location = New System.Drawing.Point(149, 157)
        Me.cbocargo.Name = "cbocargo"
        Me.cbocargo.Size = New System.Drawing.Size(270, 24)
        Me.cbocargo.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label22.Location = New System.Drawing.Point(425, 128)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(58, 16)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "Plate No."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label21.Location = New System.Drawing.Point(22, 285)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 16)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = "*Gross Weight"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label20.Location = New System.Drawing.Point(22, 318)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 16)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Tare Weight"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(22, 351)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(70, 16)
        Me.Label19.TabIndex = 114
        Me.Label19.Text = "Net Weight"
        '
        'txtplateno
        '
        Me.txtplateno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplateno.Location = New System.Drawing.Point(496, 125)
        Me.txtplateno.Name = "txtplateno"
        Me.txtplateno.Size = New System.Drawing.Size(95, 23)
        Me.txtplateno.TabIndex = 1
        '
        'txtnet
        '
        Me.txtnet.Enabled = False
        Me.txtnet.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnet.Location = New System.Drawing.Point(178, 348)
        Me.txtnet.Name = "txtnet"
        Me.txtnet.Size = New System.Drawing.Size(144, 23)
        Me.txtnet.TabIndex = 113
        Me.txtnet.Text = "0"
        '
        'txtgross
        '
        Me.txtgross.Enabled = False
        Me.txtgross.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgross.Location = New System.Drawing.Point(178, 282)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(144, 23)
        Me.txtgross.TabIndex = 109
        Me.txtgross.Text = "0"
        '
        'txttare
        '
        Me.txttare.Enabled = False
        Me.txttare.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttare.Location = New System.Drawing.Point(178, 315)
        Me.txttare.Name = "txttare"
        Me.txttare.Size = New System.Drawing.Size(144, 23)
        Me.txttare.TabIndex = 111
        Me.txttare.Text = "0"
        '
        'btnW2
        '
        Me.btnW2.BackColor = System.Drawing.Color.Transparent
        Me.btnW2.FlatAppearance.BorderSize = 0
        Me.btnW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW2.ForeColor = System.Drawing.Color.Black
        Me.btnW2.ImageKey = "Downloads-2-icon (1).png"
        Me.btnW2.ImageList = Me.ImageList1
        Me.btnW2.Location = New System.Drawing.Point(660, 329)
        Me.btnW2.Name = "btnW2"
        Me.btnW2.Size = New System.Drawing.Size(27, 27)
        Me.btnW2.TabIndex = 8
        Me.btnW2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnW2.UseVisualStyleBackColor = False
        '
        'btnW1
        '
        Me.btnW1.BackColor = System.Drawing.Color.Transparent
        Me.btnW1.FlatAppearance.BorderSize = 0
        Me.btnW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnW1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnW1.ForeColor = System.Drawing.Color.Black
        Me.btnW1.ImageKey = "Downloads-2-icon (1).png"
        Me.btnW1.ImageList = Me.ImageList1
        Me.btnW1.Location = New System.Drawing.Point(660, 280)
        Me.btnW1.Name = "btnW1"
        Me.btnW1.Size = New System.Drawing.Size(27, 27)
        Me.btnW1.TabIndex = 7
        Me.btnW1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnW1.UseVisualStyleBackColor = False
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel18.Controls.Add(Me.btnreprint)
        Me.Panel18.Controls.Add(Me.btncanceltransaction)
        Me.Panel18.Controls.Add(Me.btnsaveandprint)
        Me.Panel18.Controls.Add(Me.btnSave)
        Me.Panel18.Controls.Add(Me.btnClearEntry)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel18.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel18.Location = New System.Drawing.Point(3, 532)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(626, 56)
        Me.Panel18.TabIndex = 86
        '
        'btnreprint
        '
        Me.btnreprint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnreprint.FlatAppearance.BorderSize = 0
        Me.btnreprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreprint.Location = New System.Drawing.Point(460, 11)
        Me.btnreprint.Name = "btnreprint"
        Me.btnreprint.Size = New System.Drawing.Size(86, 34)
        Me.btnreprint.TabIndex = 5
        Me.btnreprint.Text = "&Re-print"
        Me.btnreprint.UseVisualStyleBackColor = False
        Me.btnreprint.Visible = False
        '
        'btncanceltransaction
        '
        Me.btncanceltransaction.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btncanceltransaction.FlatAppearance.BorderSize = 0
        Me.btncanceltransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncanceltransaction.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncanceltransaction.Location = New System.Drawing.Point(358, 11)
        Me.btncanceltransaction.Name = "btncanceltransaction"
        Me.btncanceltransaction.Size = New System.Drawing.Size(95, 34)
        Me.btncanceltransaction.TabIndex = 2
        Me.btncanceltransaction.Text = "&Cancel"
        Me.btncanceltransaction.UseVisualStyleBackColor = False
        '
        'btnsaveandprint
        '
        Me.btnsaveandprint.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnsaveandprint.FlatAppearance.BorderSize = 0
        Me.btnsaveandprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsaveandprint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsaveandprint.Location = New System.Drawing.Point(460, 11)
        Me.btnsaveandprint.Name = "btnsaveandprint"
        Me.btnsaveandprint.Size = New System.Drawing.Size(155, 34)
        Me.btnsaveandprint.TabIndex = 0
        Me.btnsaveandprint.Text = "Save and &Print"
        Me.btnsaveandprint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(622, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 34)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClearEntry
        '
        Me.btnClearEntry.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClearEntry.FlatAppearance.BorderSize = 0
        Me.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearEntry.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEntry.Location = New System.Drawing.Point(171, 11)
        Me.btnClearEntry.Name = "btnClearEntry"
        Me.btnClearEntry.Size = New System.Drawing.Size(95, 34)
        Me.btnClearEntry.TabIndex = 3
        Me.btnClearEntry.Text = "Clear &Entry"
        Me.btnClearEntry.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(3, 43)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(626, 3)
        Me.Panel10.TabIndex = 54
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel11.Controls.Add(Me.PictureBox2)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(626, 40)
        Me.Panel11.TabIndex = 53
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label27.Location = New System.Drawing.Point(43, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(177, 20)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "TRANSACTION WINDOW"
        '
        'portMonitoring
        '
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Image = CType(resources.GetObject("AddNewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.AddNewToolStripMenuItem.Text = "Add / New"
        '
        'EditUpdateToolStripMenuItem
        '
        Me.EditUpdateToolStripMenuItem.Image = CType(resources.GetObject("EditUpdateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditUpdateToolStripMenuItem.Name = "EditUpdateToolStripMenuItem"
        Me.EditUpdateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.EditUpdateToolStripMenuItem.Size = New System.Drawing.Size(166, 26)
        Me.EditUpdateToolStripMenuItem.Text = "Edit / Update"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'PortConfigurationToolStripMenuItem
        '
        Me.PortConfigurationToolStripMenuItem.Image = CType(resources.GetObject("PortConfigurationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PortConfigurationToolStripMenuItem.Name = "PortConfigurationToolStripMenuItem"
        Me.PortConfigurationToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.PortConfigurationToolStripMenuItem.Text = "&Port Configuration"
        '
        'UserAccountsToolStripMenuItem
        '
        Me.UserAccountsToolStripMenuItem.Image = CType(resources.GetObject("UserAccountsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        Me.UserAccountsToolStripMenuItem.Size = New System.Drawing.Size(177, 26)
        Me.UserAccountsToolStripMenuItem.Text = "&User Account(s)"
        '
        'btnsearchpendingtransaction
        '
        Me.btnsearchpendingtransaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnsearchpendingtransaction.Image = CType(resources.GetObject("btnsearchpendingtransaction.Image"), System.Drawing.Image)
        Me.btnsearchpendingtransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsearchpendingtransaction.Name = "btnsearchpendingtransaction"
        Me.btnsearchpendingtransaction.Size = New System.Drawing.Size(23, 28)
        Me.btnsearchpendingtransaction.Text = "ToolStripButton2"
        '
        'btnrefreshpendingtransaction
        '
        Me.btnrefreshpendingtransaction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnrefreshpendingtransaction.Image = CType(resources.GetObject("btnrefreshpendingtransaction.Image"), System.Drawing.Image)
        Me.btnrefreshpendingtransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrefreshpendingtransaction.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrefreshpendingtransaction.Name = "btnrefreshpendingtransaction"
        Me.btnrefreshpendingtransaction.Size = New System.Drawing.Size(23, 28)
        Me.btnrefreshpendingtransaction.Text = "Refresh"
        Me.btnrefreshpendingtransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 28)
        Me.ToolStripButton3.Text = "ToolStripButton2"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 28)
        Me.ToolStripButton6.Text = "Refresh"
        Me.ToolStripButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btncompletetransactionexport
        '
        Me.btncompletetransactionexport.Image = CType(resources.GetObject("btncompletetransactionexport.Image"), System.Drawing.Image)
        Me.btncompletetransactionexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncompletetransactionexport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncompletetransactionexport.Name = "btncompletetransactionexport"
        Me.btncompletetransactionexport.Size = New System.Drawing.Size(115, 28)
        Me.btncompletetransactionexport.Text = "Export to Excel"
        Me.btncompletetransactionexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.Frozen = True
        Me.DataGridViewCheckBoxColumn1.HeaderText = ""
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 10
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 10
        '
        'Column14
        '
        Me.Column14.HeaderText = "DATE"
        Me.Column14.MinimumWidth = 10
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "REF NO"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'Column8
        '
        Me.Column8.HeaderText = "DRIVER"
        Me.Column8.MinimumWidth = 10
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 75
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "PLATE NO"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 89
        '
        'Column18
        '
        Me.Column18.HeaderText = "CARGO"
        Me.Column18.MinimumWidth = 10
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 73
        '
        'Column10
        '
        Me.Column10.HeaderText = "BAGS"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 63
        '
        'Column6
        '
        Me.Column6.HeaderText = "SUPPLIER"
        Me.Column6.MinimumWidth = 10
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 87
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "1st WEIGHING"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 112
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "DATETIME"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 92
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "keyid"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 61
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.Frozen = True
        Me.DataGridViewCheckBoxColumn2.HeaderText = ""
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 10
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 10
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 63
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "REF NO"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 75
        '
        'Column9
        '
        Me.Column9.HeaderText = "DRIVER"
        Me.Column9.MinimumWidth = 10
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 75
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "PLATE NO"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 89
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "CARGO"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 73
        '
        'Column11
        '
        Me.Column11.HeaderText = "BAGS"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 63
        '
        'Column12
        '
        Me.Column12.HeaderText = "AVE per BAG"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 105
        '
        'Column13
        '
        Me.Column13.HeaderText = "FEE"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 53
        '
        'Column7
        '
        Me.Column7.HeaderText = "SUPPLIER"
        Me.Column7.MinimumWidth = 10
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 87
        '
        'Column3
        '
        Me.Column3.HeaderText = "GROSS"
        Me.Column3.MinimumWidth = 10
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 73
        '
        'Column4
        '
        Me.Column4.HeaderText = "TARE"
        Me.Column4.MinimumWidth = 10
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 63
        '
        'Column5
        '
        Me.Column5.HeaderText = "NET"
        Me.Column5.MinimumWidth = 10
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 55
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "1st WEIGHING"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 112
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "DATETIME"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 92
        '
        'Column1
        '
        Me.Column1.HeaderText = "2nd WEIGHING"
        Me.Column1.MinimumWidth = 10
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 116
        '
        'Column2
        '
        Me.Column2.HeaderText = "DATETME"
        Me.Column2.MinimumWidth = 10
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 88
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "keyid"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        Me.DataGridViewTextBoxColumn19.Width = 61
        '
        'frmNFA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 767)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.StatusStrip3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmNFA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weighing Scale Transaction Pro"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip3.ResumeLayout(False)
        Me.StatusStrip3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.panel_completedtransaction.ResumeLayout(False)
        Me.panel_completedtransaction.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        CType(Me.dtgcompletedtransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panel_pendingtransaction.ResumeLayout(False)
        Me.panel_pendingtransaction.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        CType(Me.dtgpendingtransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.panel_transaction.ResumeLayout(False)
        Me.panel_transaction.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel18.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnEditTransaction As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddTransaction As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditUpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PortConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lblUserAccount As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents weighScale As IO.Ports.SerialPort
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TDGQ As CheckBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents btnsearchpendingtransaction As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents btnexportpendingtransactionexport As ToolStripButton
    Friend WithEvents btnrefreshpendingtransaction As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents btncompletetransactionexport As ToolStripButton
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menuitem_portconfiguration As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents menuitem_useraccounts As ToolStripMenuItem
    Friend WithEvents menuitem_exit As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StatusStrip3 As StatusStrip
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents lblportError As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblstopbits As Label
    Friend WithEvents lbldatabits As Label
    Friend WithEvents lblbaudrate As Label
    Friend WithEvents lblreadtimeout As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lbloutput As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents panel_completedtransaction As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btncompletedexport As Button
    Friend WithEvents btnrefreshcompleted As Button
    Friend WithEvents btnsearchcompleted As Button
    Friend WithEvents txtsearchcompleted As TextBox
    Friend WithEvents cbodisplayfilter As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents panel_pendingtransaction As Panel
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents lblpendingstatus As ToolStripStatusLabel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnpendingexport As Button
    Friend WithEvents btnrefreshpending As Button
    Friend WithEvents btnsearchpending As Button
    Friend WithEvents txtsearchpending As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblstatus As ToolStripStatusLabel
    Friend WithEvents lbleditstatus As ToolStripStatusLabel
    Friend WithEvents lblportStatus As ToolStripStatusLabel
    Friend WithEvents lblcompletedstatus As ToolStripStatusLabel
    Friend WithEvents menuitem_addtransaction As ToolStripMenuItem
    Friend WithEvents menuite_edittransaction As ToolStripMenuItem
    Friend WithEvents menuitem_deletetransaction As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents menuitem_refreshall As ToolStripMenuItem
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents dtgpendingtransaction As DataGridView
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents dtgcompletedtransaction As DataGridView
    Friend WithEvents panel_transaction As Panel
    Friend WithEvents Label47 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txttransactionid As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lbloutbounddate As Label
    Friend WithEvents lblinbounddate As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtreferenceno As TextBox
    Friend WithEvents txtOutBound As TextBox
    Friend WithEvents txttransactiondate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtInBound As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cbocargo As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtplateno As TextBox
    Friend WithEvents txtnet As TextBox
    Friend WithEvents txtgross As TextBox
    Friend WithEvents txttare As TextBox
    Friend WithEvents btnW2 As Button
    Friend WithEvents btnW1 As Button
    Friend WithEvents Panel18 As Panel
    Friend WithEvents btnreprint As Button
    Friend WithEvents btncanceltransaction As Button
    Friend WithEvents btnsaveandprint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClearEntry As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents cbodrivername As ComboBox
    Friend WithEvents portMonitoring As Timer
    Friend WithEvents btnwaive As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbosupplier As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtfee As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtave As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtnoofbags As TextBox
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
