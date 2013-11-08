Imports System.Data.SqlClient
Imports System.IO
Public Class FrmPricingReceiving
    Inherits System.Windows.Forms.Form
    Private WithEvents cmbItems As System.Windows.Forms.ComboBox
    Private WithEvents cmbsource As System.Windows.Forms.ComboBox

    'textbox
    Private WithEvents txttext As System.Windows.Forms.TextBox

    'button
    Private WithEvents cmdDelete As System.Windows.Forms.Button
    Private WithEvents dataTable As DataTable
    Private ds_dataset As New DataSet
    Private dv_dataview As DataView
    Dim i As Integer
    Dim dgtb As DataGridTextBoxColumn

    Private WithEvents btn As System.Windows.Forms.Button
    Private arrstr() As String

    Private cn As New SqlClient.SqlConnection
    Public sDatasource1 As String
    Public sDatabase1 As String
    Public sUsername1 As String
    Public sPassword1 As String
    Public sDatasource2 As String
    Private ConStr2 As String
    Public sDatabase2 As String
    Public sUsername2 As String
    Public sPassword2 As String
    Dim objclass As New clsCommon
    Dim objcommon As New clsCommon
    Private dt As DataTable
    Private dv As DataView
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Dim dr As SqlDataReader
    Dim msgY, msgP, msgK, msgH As String


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CreateGrid()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents AsysReleasing As System.Windows.Forms.Label
    Friend WithEvents lbl1FA01 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCostCenter As System.Windows.Forms.ComboBox
    Friend WithEvents lblReceive As System.Windows.Forms.Label
    Friend WithEvents lblCostCenter As System.Windows.Forms.Label
    Friend WithEvents lblDateReleased As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents cmbLotNo As System.Windows.Forms.ComboBox
    Friend WithEvents lblLotNo As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnReceiving As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboreceive As System.Windows.Forms.ComboBox
    Friend WithEvents txtreceive As System.Windows.Forms.TextBox
    Friend WithEvents ListView4 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cb As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchLot As System.Windows.Forms.Button
    Friend WithEvents btnUnRec As System.Windows.Forms.Button
    Friend WithEvents txtCostCenter As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPricingReceiving))
        Me.AsysReleasing = New System.Windows.Forms.Label
        Me.lbl1FA01 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCostCenter = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.lblReceive = New System.Windows.Forms.Label
        Me.lblCostCenter = New System.Windows.Forms.Label
        Me.lblDateReleased = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.cboreceive = New System.Windows.Forms.ComboBox
        Me.txtreceive = New System.Windows.Forms.TextBox
        Me.cb = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearchLot = New System.Windows.Forms.Button
        Me.cmbLotNo = New System.Windows.Forms.ComboBox
        Me.lblLotNo = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnReceiving = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnUnRec = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView4 = New System.Windows.Forms.ListView
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AsysReleasing
        '
        Me.AsysReleasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsysReleasing.Location = New System.Drawing.Point(640, 16)
        Me.AsysReleasing.Name = "AsysReleasing"
        Me.AsysReleasing.Size = New System.Drawing.Size(160, 24)
        Me.AsysReleasing.TabIndex = 108
        Me.AsysReleasing.Text = "ASYS Receiving "
        '
        'lbl1FA01
        '
        Me.lbl1FA01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1FA01.Location = New System.Drawing.Point(728, 40)
        Me.lbl1FA01.Name = "lbl1FA01"
        Me.lbl1FA01.Size = New System.Drawing.Size(72, 16)
        Me.lbl1FA01.TabIndex = 109
        Me.lbl1FA01.Text = "1FA01 V5.2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostCenter)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.lblReceive)
        Me.GroupBox1.Controls.Add(Me.lblCostCenter)
        Me.GroupBox1.Controls.Add(Me.lblDateReleased)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox1.Controls.Add(Me.cboreceive)
        Me.GroupBox1.Controls.Add(Me.txtreceive)
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.Location = New System.Drawing.Point(464, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 128)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        '
        'txtCostCenter
        '
        Me.txtCostCenter.Location = New System.Drawing.Point(128, 56)
        Me.txtCostCenter.Name = "txtCostCenter"
        Me.txtCostCenter.ReadOnly = True
        Me.txtCostCenter.Size = New System.Drawing.Size(152, 20)
        Me.txtCostCenter.TabIndex = 146
        Me.txtCostCenter.Text = ""
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(128, 80)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(152, 20)
        Me.txtDate.TabIndex = 127
        Me.txtDate.Text = ""
        '
        'lblReceive
        '
        Me.lblReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblReceive.Location = New System.Drawing.Point(24, 36)
        Me.lblReceive.Name = "lblReceive"
        Me.lblReceive.Size = New System.Drawing.Size(80, 16)
        Me.lblReceive.TabIndex = 108
        Me.lblReceive.Text = "USERNAME"
        Me.lblReceive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCostCenter
        '
        Me.lblCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostCenter.Location = New System.Drawing.Point(24, 60)
        Me.lblCostCenter.Name = "lblCostCenter"
        Me.lblCostCenter.Size = New System.Drawing.Size(88, 16)
        Me.lblCostCenter.TabIndex = 112
        Me.lblCostCenter.Text = "COST CENTER"
        Me.lblCostCenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateReleased
        '
        Me.lblDateReleased.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReleased.Location = New System.Drawing.Point(24, 83)
        Me.lblDateReleased.Name = "lblDateReleased"
        Me.lblDateReleased.Size = New System.Drawing.Size(104, 16)
        Me.lblDateReleased.TabIndex = 114
        Me.lblDateReleased.Text = "DATE RECEIVED"
        Me.lblDateReleased.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Receiver"
        Me.Label10.Visible = False
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostCenter.ItemHeight = 13
        Me.cmbCostCenter.Items.AddRange(New Object() {"MLWB"})
        Me.cmbCostCenter.Location = New System.Drawing.Point(128, 56)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(152, 21)
        Me.cmbCostCenter.TabIndex = 113
        '
        'cboreceive
        '
        Me.cboreceive.Location = New System.Drawing.Point(128, 56)
        Me.cboreceive.Name = "cboreceive"
        Me.cboreceive.Size = New System.Drawing.Size(152, 21)
        Me.cboreceive.TabIndex = 143
        Me.cboreceive.Visible = False
        '
        'txtreceive
        '
        Me.txtreceive.Location = New System.Drawing.Point(128, 56)
        Me.txtreceive.Name = "txtreceive"
        Me.txtreceive.Size = New System.Drawing.Size(133, 20)
        Me.txtreceive.TabIndex = 144
        Me.txtreceive.Text = ""
        Me.txtreceive.Visible = False
        '
        'cb
        '
        Me.cb.BackColor = System.Drawing.Color.White
        Me.cb.Location = New System.Drawing.Point(128, 32)
        Me.cb.Name = "cb"
        Me.cb.ReadOnly = True
        Me.cb.Size = New System.Drawing.Size(152, 20)
        Me.cb.TabIndex = 145
        Me.cb.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(128, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "ComboBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearchLot)
        Me.GroupBox2.Controls.Add(Me.cmbLotNo)
        Me.GroupBox2.Controls.Add(Me.lblLotNo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 128)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'btnSearchLot
        '
        Me.btnSearchLot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchLot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchLot.Location = New System.Drawing.Point(320, 40)
        Me.btnSearchLot.Name = "btnSearchLot"
        Me.btnSearchLot.Size = New System.Drawing.Size(24, 24)
        Me.btnSearchLot.TabIndex = 127
        Me.btnSearchLot.Text = "..."
        '
        'cmbLotNo
        '
        Me.cmbLotNo.Location = New System.Drawing.Point(120, 40)
        Me.cmbLotNo.MaxLength = 10
        Me.cmbLotNo.Name = "cmbLotNo"
        Me.cmbLotNo.Size = New System.Drawing.Size(200, 21)
        Me.cmbLotNo.TabIndex = 125
        '
        'lblLotNo
        '
        Me.lblLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLotNo.Location = New System.Drawing.Point(32, 44)
        Me.lblLotNo.Name = "lblLotNo"
        Me.lblLotNo.Size = New System.Drawing.Size(80, 16)
        Me.lblLotNo.TabIndex = 126
        Me.lblLotNo.Text = "LOT NUMBER"
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(168, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnPrint.TabIndex = 128
        Me.btnPrint.Text = "PRINT F20"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnReceiving
        '
        Me.btnReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiving.Image = CType(resources.GetObject("btnReceiving.Image"), System.Drawing.Image)
        Me.btnReceiving.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReceiving.Location = New System.Drawing.Point(168, 16)
        Me.btnReceiving.Name = "btnReceiving"
        Me.btnReceiving.Size = New System.Drawing.Size(80, 40)
        Me.btnReceiving.TabIndex = 129
        Me.btnReceiving.Text = "Receiving Report"
        Me.btnReceiving.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(480, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Label4"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(808, 128)
        Me.GroupBox3.TabIndex = 140
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 140
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(248, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.btnPrint)
        Me.GroupBox4.Controls.Add(Me.btnReceiving)
        Me.GroupBox4.Controls.Add(Me.btnUnRec)
        Me.GroupBox4.Location = New System.Drawing.Point(480, 520)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 64)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(88, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 127
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnUnRec
        '
        Me.btnUnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnRec.Image = CType(resources.GetObject("btnUnRec.Image"), System.Drawing.Image)
        Me.btnUnRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUnRec.Location = New System.Drawing.Point(8, 16)
        Me.btnUnRec.Name = "btnUnRec"
        Me.btnUnRec.Size = New System.Drawing.Size(80, 40)
        Me.btnUnRec.TabIndex = 143
        Me.btnUnRec.Text = "UNRECEIVED ITEMS"
        Me.btnUnRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(416, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 24)
        Me.Label7.TabIndex = 147
        Me.Label7.Text = "Label7"
        '
        'DgEntry
        '
        Me.DgEntry.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackgroundColor = System.Drawing.Color.Tan
        Me.DgEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgEntry.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DgEntry.DataMember = ""
        Me.DgEntry.FlatMode = True
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Black
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Lime
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DgEntry.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DgEntry.Location = New System.Drawing.Point(8, 240)
        Me.DgEntry.Name = "DgEntry"
        Me.DgEntry.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DgEntry.SelectionForeColor = System.Drawing.Color.White
        Me.DgEntry.Size = New System.Drawing.Size(808, 272)
        Me.DgEntry.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(456, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 48)
        Me.Label5.TabIndex = 143
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader28})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(8, 256)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(808, 256)
        Me.ListView1.TabIndex = 144
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LOTNO"
        Me.ColumnHeader1.Width = 52
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Division"
        Me.ColumnHeader3.Width = 67
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PTN"
        Me.ColumnHeader4.Width = 48
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MPTN"
        Me.ColumnHeader5.Width = 53
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.Width = 36
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ITEMCODE"
        Me.ColumnHeader7.Width = 79
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "PTNItemDesc"
        Me.ColumnHeader8.Width = 88
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "KaratGrading"
        Me.ColumnHeader10.Width = 77
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CaratSize"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SortingClass"
        Me.ColumnHeader12.Width = 71
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Weight"
        Me.ColumnHeader13.Width = 49
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Status"
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "itemappraisevalue"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(8, 256)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(808, 256)
        Me.ListView2.TabIndex = 145
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LOTNO"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "DIVISION"
        Me.ColumnHeader15.Width = 64
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "PTN"
        Me.ColumnHeader16.Width = 82
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ITEMCODE"
        Me.ColumnHeader18.Width = 73
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "PTNItemDESC"
        Me.ColumnHeader19.Width = 98
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Quantity"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "ALLBArcode"
        Me.ColumnHeader21.Width = 77
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "ITEMsource"
        Me.ColumnHeader22.Width = 82
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "ActionID"
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "STATUS"
        '
        'ListView3
        '
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader27, Me.ColumnHeader25, Me.ColumnHeader26})
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(8, 256)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(808, 248)
        Me.ListView3.TabIndex = 146
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "PTN"
        Me.ColumnHeader27.Width = 82
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "ALLBarcode"
        Me.ColumnHeader25.Width = 98
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Status"
        Me.ColumnHeader26.Width = 77
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 531)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "TOTAL NO. OF ITEMS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(136, 530)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(32, 20)
        Me.TextBox1.TabIndex = 149
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListView4
        '
        Me.ListView4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader29})
        Me.ListView4.FullRowSelect = True
        Me.ListView4.GridLines = True
        Me.ListView4.Location = New System.Drawing.Point(344, 352)
        Me.ListView4.Name = "ListView4"
        Me.ListView4.Size = New System.Drawing.Size(216, 128)
        Me.ListView4.TabIndex = 150
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "allbarcode"
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "qty"
        '
        'FrmPricingReceiving
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 588)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl1FA01)
        Me.Controls.Add(Me.AsysReleasing)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.ListView4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPricingReceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRICING RECEIVING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(8) {"NO.", "     PTN", "     A.L.L. BARCODE", "  ITEM SOURCE ", "        DESCRIPTION ", "WEIGHT", "KARAT", "CARAT", "PRICE "}

            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")

            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 8
                Dim str As String = arrstr(i)
                dtCol = New DataColumn(str)
                dtCol.DataType = System.Type.GetType("System.String")

                dtCol.DefaultValue = ""
                dataTable.Columns.Add(dtCol)
            Next i

            'Set the Data Grid Source as the Data Table created above
            DgEntry.DataSource = dataTable
            DgEntry.AllowSorting = False
            'set style property when first time the grid loads, next time onwards it will maintain its property
            If Not DgEntry.TableStyles.Contains("Controls") Then
                'Create a DataGridTableStyle object	
                Dim dgdtblStyle As New DataGridTableStyle
                'Set its properties
                dgdtblStyle.MappingName = dataTable.TableName 'its table name of dataset
                DgEntry.TableStyles.Add(dgdtblStyle)
                dgdtblStyle.RowHeadersVisible = False
                dgdtblStyle.PreferredRowHeight = 22
                DgEntry.BackgroundColor = Color.White

                DgEntry.ReadOnly = True
                'Take the columns in a GridColumnStylesCollection object and set the size of the individual columns	
                Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 75
                colStyle(1).Width = 100
                colStyle(2).Width = 130
                colStyle(3).Width = 90
                colStyle(4).Width = 275
                colStyle(5).Width = 65
                colStyle(6).Width = 65
                colStyle(7).Width = 65
                colStyle(8).Width = 70
                colStyle(8).Alignment = HorizontalAlignment.Right

                'cmdDelete = New Button
                'cmdDelete.ForeColor = ForeColor.Transparent
                'cmdDelete.Text = "DELETE"
                'cmdDelete.Width = 50
                'cmdDelete.Height = 20

                'txttext = New TextBox
                'txttext.Width = 160

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txttext)
                'txttext.BringToFront()


                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txttext)
                'txttext.BringToFront()


                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(cmdDelete)
                'cmdDelete.BringToFront()
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/CreateGrid: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmdAddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.btnSave.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txttext.KeyDown
        Try
            If e.KeyCode = 13 Then
                DgEntry(DgEntry.CurrentCell.RowNumber, DgEntry.CurrentCell.ColumnNumber) = txttext
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/txtText_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        'dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        'If Not ab_isEmpty Then
        '    If deleteData(hi) Then

        '        Dim j As Integer
        '        For j = 1 To Me.ListView1.Items.Count - 1
        '            If j >= Me.ListView1.Items.Count - 1 Then
        '                Exit For
        '            End If
        '            If Me.ListView1.Items(j - 1).SubItems.Item(2).Text = Me.DgEntry.Item(hi.Row, 1) Then
        '                Me.ListView1.Items(j - 1).Remove()
        '            End If
        '        Next

        '        For j = 1 To Me.ListView1.Items.Count - 1
        '            If j >= Me.ListView1.Items.Count - 1 Then
        '                Exit For
        '            End If
        '            If Me.ListView1.Items(j - 1).SubItems.Item(2).Text = Me.DgEntry.Item(hi.Row, 1) Then
        '                Me.ListView1.Items(j - 1).Remove()
        '            End If
        '        Next

        '        dataTable.Rows.RemoveAt(hi.Row)
        '        Dim u, s, tempa As Integer
        '        If Me.DgEntry.VisibleRowCount > 0 Then
        '            For u = 1 To dataTable.Rows.Count
        '                If Me.DgEntry(u - 1, 0) = "" Then
        '                    Me.TextBox1.Text = tempa
        '                Else
        '                    s = (DgEntry(u - 1, 0))
        '                    tempa = tempa + s
        '                End If
        '            Next
        '        End If
        '        Me.TextBox1.Text = tempa
        '    Else
        '        MsgBox("Error in connecting to database.Try Again!", MsgBoxStyle.Critical.OKOnly, "Error!")
        '    End If
        'Else
        '    dataTable.Rows.RemoveAt(hi.Row)
        'End If
        'TextBox1.Text = dataTable.Rows.Count
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        'Dim hi As DataGrid.HitTestInfo
        'Dim pt = New Point(e.X, e.Y)
        'Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)



        'hi = DgEntry.HitTest(e.X, e.Y)

        'If hi.Column = 0 Then
        '    DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
        '    DgEntry.Select(hit.Row)
        'End If

        'If hi.Column = 4 And hi.Row >= 0 Then
        '    If DgEntry(hi.Row, 1) <> "" Then
        '        deleteRow(hi, False)
        '    Else
        '        deleteRow(hi, True)
        '    End If
        'End If

    End Sub

    Private Function deleteData(ByVal hi As DataGrid.HitTestInfo) As Boolean
        'Dim cm As New SqlClient.SqlCommand
        'Dim ls_sql As String
        'Try
        '    If cmdDelete.Text = "DELETE" Then
        '        deleteData = True
        '    Else
        '        deleteData = False
        '    End If

        'Catch ex As Exception

        '    deleteData = False

        'End Try
    End Function

    Function NextPrime(ByVal i As Integer) As Integer
        Try
            Dim ctr As Integer
            ctr = i + 1
            While Not isPrime(ctr)
                ctr = ctr + 1
            End While
            NextPrime = ctr
        Catch ex As Exception
            MsgBox("frmPricingReceiving/NextPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Function isPrime(ByVal i As Integer) As Boolean
        Try
            If i = 3 Or i = 5 Then Return True
            If i Mod 2 = 0 Then Return False
            If i Mod 3 = 0 Then Return False
            If i Mod 5 = 0 Then Return False
            Return True
        Catch ex As Exception
            MsgBox("frmPricingReceiving/isPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Function decryptPass(ByVal RawStr As String) As String
        Try
            Dim i As Integer
            Dim decryptedPass As String
            i = 3
            decryptedPass = ""
            While i < RawStr.Length
                decryptedPass = decryptedPass + RawStr.Substring(i - 1, 1)
                i = NextPrime(i)
            End While
            decryptPass = decryptedPass
        Catch ex As Exception
            MsgBox("frmPricingReceiving/decryptPass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Public Function ConnectDB1() As Boolean
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath
            Try
                Dim sr As StreamReader = New StreamReader(sPath + "\REMSystem.INI")
                Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1 As String

                If sDB = "Luzon" Then
                    Key_Server1 = "[ServerL]="
                    Key_DataBase1 = "[DataBaseL]="
                    Key_User1 = "[UserL]="
                    Key_Pass1 = "[PasswordL]="
                    'ElseIf sDB = "Vismin" Then
                    '    Key_Server1 = "[ServerV]="
                    '    Key_DataBase1 = "[DataBaseV]="
                    '    Key_User1 = "[UserV]="
                    '    Key_Pass1 = "[PasswordV]="
                ElseIf sDB = "Visayas" Then
                    Key_Server1 = "[ServerVis]="
                    Key_DataBase1 = "[DataBaseVis]="
                    Key_User1 = "[UserVis]="
                    Key_Pass1 = "[PasswordVis]="
                ElseIf sDB = "Mindanao" Then
                    Key_Server1 = "[ServerM]="
                    Key_DataBase1 = "[DataBaseM]="
                    Key_User1 = "[UserM]="
                    Key_Pass1 = "[PasswordM]="
                ElseIf sDB = "Showroom" Then
                    Key_Server1 = "[ServerS]="
                    Key_DataBase1 = "[DataBaseS]="
                    Key_User1 = "[UserS]="
                    Key_Pass1 = "[PasswordS]="
                End If

                Dim line As String
                line = sr.ReadLine()
                While Not line Is Nothing
                    line.Replace(" =", "=").Replace("= ", "=")
                    If line.StartsWith(Key_Server1) Then
                        sDatasource1 = Replace(line, Key_Server1, "")
                    End If
                    If line.StartsWith(Key_DataBase1) Then
                        sDatabase1 = Replace(line, Key_DataBase1, "")
                    End If
                    If line.StartsWith(Key_User1) Then
                        sUsername1 = Replace(line, Key_User1, "")
                    End If
                    If line.StartsWith(Key_Pass1) Then
                        sPassword1 = decryptPass(Replace(line, Key_Pass1, ""))
                    End If
                    line = sr.ReadLine()
                End While
                sr.Close()
            Catch Ee As Exception

            End Try

            ConStr2 = "Data Source = " + sDatasource1 + ";"
            ConStr2 = ConStr2 + ";Initial Catalog = " + sDatabase1
            ConStr2 = ConStr2 + ";User ID = " + sUsername1
            ConStr2 = ConStr2 + ";Password = " + sPassword1

            cn.ConnectionString = ConStr2
            cn.Open()

            ConnectDB1 = True
        Catch ex As Exception
            ConnectDB1 = False
        End Try

    End Function

    Private Function ConnectDB() As Boolean
        Try

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If


            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath
            Try
                Dim sr As StreamReader = New StreamReader(sPath + "\REMS.INI")
                Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1 As String


                Key_Server1 = "[Server]="
                Key_DataBase1 = "[DataBase]="
                Key_User1 = "[User]="
                Key_Pass1 = "[Password]="


                Dim line As String
                line = sr.ReadLine()
                While Not line Is Nothing
                    line.Replace(" =", "=").Replace("= ", "=")
                    If line.StartsWith(Key_Server1) Then
                        sDatasource1 = Replace(line, Key_Server1, "")
                    End If
                    If line.StartsWith(Key_DataBase1) Then
                        sDatabase1 = Replace(line, Key_DataBase1, "")
                    End If
                    If line.StartsWith(Key_User1) Then
                        sUsername1 = Replace(line, Key_User1, "")
                    End If
                    If line.StartsWith(Key_Pass1) Then
                        sPassword1 = decryptPass(Replace(line, Key_Pass1, ""))
                    End If

                    line = sr.ReadLine()
                End While
                sr.Close()
            Catch Ee As Exception

            End Try

            ConStr2 = "Data Source = " + sDatasource1 + ";"
            ConStr2 = ConStr2 + ";Initial Catalog = " + sDatabase1
            ConStr2 = ConStr2 + ";User ID = " + sUsername1
            ConStr2 = ConStr2 + ";Password = " + sPassword1

            cn.ConnectionString = ConStr2
            cn.Open()

            ConnectDB = True
        Catch ex As Exception
            ConnectDB = False
        End Try

    End Function

    Private Sub FrmPricingReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            If ambot = 1 Then
                txtCostCenter.Text = "REM"
            End If
            txtDate.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            'Call datereceived()
            force = False
            outsource = False
            CreateGrid()
            btnReceiving.Enabled = True
            'Call costcenters()
            Call validEmpName()
            Call receiver()
            Call lots()
            cboreceive.Text = userLog
            Me.cmbLotNo.Enabled = True
            Me.TextBox1.BackColor = Color.White
            Me.txtCostCenter.Text = "MLWB"
            cb.BackColor = Color.White
            cmbLotNo.Focus()
            cmbLotNo.Select()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/FrmPricingReceiving_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub costcenters()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("Select * from tbl_CostCenter")
            dr = obj.OpenDataReader5
            While dr.Read
                txtCostCenter.Text = (dr.Item("CostDept"))
            End While
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/costcenters: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub validEmpName()
        Try
            cb.Text = Trim(UCase(fullname))
            Me.Label4.Text = idnumber
        Catch ex As Exception

        End Try
    End Sub

    Public Sub generateLOTNO()
        Try
            Dim LOTYr, LOTMonth As Date
            Dim CurrentYr, CurrentMonth As String
            Dim seqno, genLotNo As Integer
            Dim con As New clsCommon
            Dim cn As New clsCommon
            Dim d1 As SqlDataReader
            Dim dr As SqlDataReader
            Dim i As Integer

            cn.Connectionstring3()
            cn.Open3()
            Me.cmbLotNo.Items.Clear()
            cn.Command3("select distinct reflotno from ASYS_MLWB_Detail where status = 'RELEASED'")
            d1 = cn.OpenDataReader3
            While d1.Read
                Me.cmbLotNo.Items.Add(Trim(d1.Item("refLotNo")))
            End While
            d1.Close()
            cn.Execute3()
            cn.Close3()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/generateLOTNO: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If Me.DgEntry.VisibleRowCount > 0 Then
                'Call SeeIFReturn()
                If retbleh = False Then
                    'If Me.cmbCostCenter.Text <> "REM" Then
                    '    Call DetailList()
                    'End If
                    Call saveDatabyCostCenter()

                End If
            End If
            dataTable.Clear()
            Me.TextBox1.Text = ""
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()
            Me.ListView3.Items.Clear()
            reclotno = cmbLotNo.Text
            Me.cmbLotNo.Text = ""
            'generateLOTNO()
            btnSave.Enabled = False
            lots()
            TextBox1.Text = 0
            cmbLotNo.Focus()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DetailList()
        Dim objl As New clsCommon
        Dim dr6 As SqlDataReader

        Try
            Dim u, s, t, a As Integer
            Dim objc As New clsCommon
            Dim dr5 As SqlDataReader
            Dim squery, sqlquery1, sqlquery2, tempz, tempg, tempx As String

            Me.ListView2.Items.Clear()
            If Me.DgEntry.VisibleRowCount > 0 Then
                objl.Connectionstring3()
                objl.Open3()
                For a = 0 To dataTable.Rows.Count - 1
                    sqlquery2 = "Select distinct asys_MLWB_detail.refLOTNO AS reflotno, asys_MLWB_detail.branchname as division, asys_MLWB_detail.ptn as ptn, asys_MLWB_detail.itemcode as itemcode,asys_MLWB_detail.branchitemdesc as ptnitemdesc, asys_MLWB_detail.qty as quantity, asys_MLWB_detail.refallbarcode as barcode,all_desc, asys_MLWB_detail.actionclass as actionclass, asys_MLWB_detail.status as status from asys_MLWB_detail  where asys_MLWB_detail.refallBarcode = '" & Me.DgEntry.Item(a, 2) & "'"
                    objl.Command3(sqlquery2)
                    dr6 = objl.OpenDataReader3
                    While dr6.Read
                        Me.ListView2.Items.Add(Me.cmbLotNo.Text)
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("division"))
                        If dr6.Item("ptn") = "0" Then
                            Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("ptn"))
                        Else
                            Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("ptn"))
                        End If
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("itemcode"))
                        If objl.IsNull(dr6.Item("all_desc")) = "0" Then
                            Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("ptnitemdesc"))
                        Else
                            Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("all_desc"))
                        End If
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("quantity"))
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("Barcode"))
                        tempx = Mid(dr6.Item("Barcode"), 4, 5)
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(tempx)
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("actionclass"))
                        Me.ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr6.Item("status"))
                    End While
                    dr6.Close()
                    objl.Execute3()
                    objl.Close3()
                Next
            End If
        Catch ex As Exception
            dr6.Close()
            objl.Close3()
            MsgBox("frmPricingReceiving/DetailList: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub saveDatabyCostCenter()
        Dim objclass As New clsCommon
        Dim reply As Integer

        Try
            Dim rply As Integer
            Dim obj As New clsCommon
            Dim sqlInsert As String
            Dim dr1, dr2, dr3 As SqlDataReader
            Dim tmpdr As SqlDataReader
            Dim a, b, c, d, e, z, m, s As Integer
            Dim i As Integer
            Dim gotoDetail As Integer
            Dim sqlInsert2, sqlinsert1, sqlinsert3, squery, squery4, temp, squery3 As String
            Dim cn As New clsCommon
            Dim msg, msgs, msgX, temps, tempQ, tempd, msgt, msgb, msgo, msgd, msgf, msgQ, msgL, templot As String

            rply = MsgBox("Are you sure you want to save the data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                lotreport = Me.cmbLotNo.Text
                objclass.Connectionstring3()
                objclass.Opentracker2()
                objclass.CreateCom()

                If Me.txtCostCenter.Text = "MLWB" Then


                    sqlInsert = "insert into rems.dbo.asys_PRICING_header  (lotno) values ('" & Me.cmbLotNo.Text & "')"
                    objclass.commandTrack(sqlInsert)
                    objclass.TrackExecute()
gotoDetail:


                    For m = 0 To dataTable.Rows.Count - 1
                        objclass.commandTrack("Insert into rems.dbo.asys_BarcodeHistory  (Lotno,refallbarcode, ALlBarcode, itemcode, itemid, [description], karat, carat, weight, currency, price, cost, empname, custodian, trandate, costcenter, status,SerialNO) select '" & Me.cmbLotNo.Text & "','" & DgEntry(m, 2) & "', '" & DgEntry(m, 2) & "', itemcode, itemid, all_desc, all_karat, all_carat, all_weight, currency, all_price, all_cost, '" & userLog & "', '" & userLog & "', getdate(),'PRICING', 'RECEIVED',SerialNO from rems.dbo.asys_MLWB_detail  where reflotno = '" & Me.cmbLotNo.Text & "' and refallbarcode = '" & DgEntry(m, 2) & "' and status = 'RELEASED'")
                        objclass.TrackExecute()

                        sqlInsert = "insert into rems.dbo.ASYS_Pricing_detail  (reflotno, LOTNO, refALLbarcode, allbarcode, ptn, itemid, ptnbarcode, branchcode, branchname, loanvalue, refitemcode, itemcode, branchitemdesc,SerialNo, refqty, qty, karatgrading, caratsize, weight, actionclass, sortcode, all_desc, all_karat, all_carat, all_cost, all_weight, appraisevalue, currency, photoname, price_desc, price_karat, price_weight, price_carat, all_price, cellular_cost, watch_cost, repair_cost, cleaning_cost, gold_cost, mount_cost, yg_cost, wg_cost,  maturitydate, expirydate, loandate, receivedate,receiver,custodian,status) "
                        sqlInsert = sqlInsert + " SELECT     RefLotno, refLotno as lotno, RefallBarcode, ALLbarcode, PTN, ItemID, PTNBarcode, BranchCode, BranchName, Loanvalue, RefItemcode, Itemcode, "
                        sqlInsert = sqlInsert + " BranchItemDesc,SerialNo, RefQty, Qty, KaratGrading, CaratSize, Weight, ActionClass, SortCode, ALL_desc, ALL_karat, ALL_carat, ALL_Cost, ALL_Weight, "
                        sqlInsert = sqlInsert + " AppraiseValue, Currency, PhotoName, Price_desc, Price_karat, Price_weight, Price_carat, ALL_price, Cellular_cost, Watch_cost, Repair_cost, "
                        sqlInsert = sqlInsert + " Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, LoanDate,getdate() as receivedate,'" & userLog & "' ,releaser as custodian"
                        If Trim(DgEntry(m, 8)) = "0" Or Trim(DgEntry(m, 8)) = ".00" Or Trim(DgEntry(m, 8)) = "0.00" Or Trim(DgEntry(m, 8)) = "NULL" Then
                            sqlInsert = sqlInsert + " ,'RECEIVED' "
                            'objclass.commandTrack("Insert into rems.dbo.asys_BarcodeHistory  (Lotno,refallbarcode, ALlBarcode, itemcode, itemid, [description], karat, carat, weight, currency, price, cost, empname, custodian, trandate, costcenter, status) select '" & Me.cmbLotNo.Text & "','" & DgEntry(m, 2) & "', '" & DgEntry(m, 2) & "', itemcode, itemid, all_desc, all_karat, all_carat, all_weight, currency, all_price, all_cost, '" & userLog & "', '" & userLog & "', getdate(),'PRICING', 'RECEIVED' from rems.dbo.asys_MLWB_detail  where reflotno = '" & Me.cmbLotNo.Text & "' and refallbarcode = '" & DgEntry(m, 2) & "' and status = 'RELEASED'")
                            'objclass.TrackExecute()

                            'sqlInsert = "insert into rems.dbo.ASYS_Pricing_detail  (reflotno, LOTNO, refALLbarcode, allbarcode, ptn, itemid, ptnbarcode, branchcode, branchname, loanvalue, refitemcode, itemcode, branchitemdesc,SerialNo, refqty, qty, karatgrading, caratsize, weight, actionclass, sortcode, all_desc, all_karat, all_carat, all_cost, all_weight, appraisevalue, currency, photoname, price_desc, price_karat, price_weight, price_carat, all_price, cellular_cost, watch_cost, repair_cost, cleaning_cost, gold_cost, mount_cost, yg_cost, wg_cost,  maturitydate, expirydate, loandate, receivedate,receiver,custodian,status) "
                            'sqlInsert = sqlInsert + " SELECT     RefLotno, refLotno as lotno, RefallBarcode, ALLbarcode, PTN, ItemID, PTNBarcode, BranchCode, BranchName, Loanvalue, RefItemcode, Itemcode, "
                            'sqlInsert = sqlInsert + " BranchItemDesc,SerialNo, RefQty, Qty, KaratGrading, CaratSize, Weight, ActionClass, SortCode, ALL_desc, ALL_karat, ALL_carat, ALL_Cost, ALL_Weight, "
                            'sqlInsert = sqlInsert + " AppraiseValue, Currency, PhotoName, Price_desc, Price_karat, Price_weight, Price_carat, ALL_price, Cellular_cost, Watch_cost, Repair_cost, "
                            'sqlInsert = sqlInsert + " Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, LoanDate,getdate() as receivedate,'" & userLog & "' ,releaser as custodian"
                            'If Trim(DgEntry(m, 8)) = "0" Or Trim(DgEntry(m, 8)) = ".00" Or Trim(DgEntry(m, 8)) = "0.00" Or Trim(DgEntry(m, 8)) = "NULL" Then
                            '    sqlInsert = sqlInsert + " ,'RECEIVED' "
                        Else
                            sqlInsert = sqlInsert + " ,'PRICED' "
                        End If

                        sqlInsert = sqlInsert & " FROM         rems.dbo.ASYS_MLWB_detail "
                        sqlInsert = sqlInsert + " WHERE     RefallBarcode = '" & Trim(DgEntry(m, 2)) & "' and status = 'RELEASED'"
                        'sqlInsert = "Insert into rems.dbo.asys_PRICING_detail(reflotno, LOTNO, refALLbarcode, allbarcode, ptn, itemid, ptnbarcode, branchcode, branchname, loanvalue, refitemcode, itemcode, branchitemdesc, refqty, qty, karatgrading, caratsize, weight, actionclass, sortcode, all_desc, all_karat, all_carat, all_cost, all_weight, appraisevalue, currency, photoname, price_desc, price_karat, price_weight, price_carat, all_price, cellular_cost, watch_cost, repair_cost, cleaning_cost, gold_cost, mount_cost, yg_cost, wg_cost,  maturitydate, expirydate, loandate, status) select '" & Me.cmbLotNo.Text & "', '" & Me.cmbLotNo.Text & "', '" & Me.ListView2.Items(m).SubItems.Item(6).Text & "','" & Me.ListView2.Items(m).SubItems.Item(6).Text & "', '" & Me.ListView2.Items(m).SubItems.Item(2).Text & "', itemid, ptnbarcode, branchcode, branchname, loanvalue, '" & Me.ListView2.Items(m).SubItems.Item(3).Text & "', '" & Me.ListView2.Items(m).SubItems.Item(3).Text & "', branchitemdesc, '" & Me.ListView2.Items(m).SubItems.Item(5).Text & "', '" & Me.ListView2.Items(m).SubItems.Item(5).Text & "', karatgrading, caratsize, weight, actionclass, sortcode, all_desc, all_karat, all_carat, all_cost, all_weight, appraisevalue, currency, photoname, price_desc, price_karat, price_weight, price_carat, all_price, cellular_cost, watch_cost, repair_cost, cleaning_cost, gold_cost, mount_cost, yg_cost, wg_cost,  maturitydate, expirydate, loandate, 'RECEIVED' from rems.dbo.asys_MLWB_detail where reflotno = '" & Me.cmbLotNo.Text & "' and refallbarcode = '" & Me.ListView2.Items(m).SubItems.Item(6).Text & "' and status = 'RELEASED'"
                        objclass.commandTrack(sqlInsert)
                        objclass.TrackExecute()

                        squery4 = "Update rems.dbo.asys_MLWB_detail  set status = 'RECPRICING' where refallbarcode='" & DgEntry(m, 2) & "' and status = 'RELEASED'"
                        objclass.commandTrack(squery4)
                        objclass.TrackExecute()

                    Next

                    objclass.CommitTrack()
                    MsgBox("Successfully received from MLWB Dept.", MsgBoxStyle.Information, TitleMsgBox)

                Else
                    Exit Sub
                End If
                force = False
                outsource = False
            End If
        Catch ex As Exception
            reply = ex.Message.IndexOf("PK_ASYS_PRICING_Header")
            If reply > 0 Then
                GoTo gotodetail
            End If
            objclass.RollBackTrack()

        Finally
            objclass.Close()
        End Try

    End Sub

    Private Sub cmbEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String
            squery = "Select res_id from " & humres2 & " where fullname='" & Me.cb.Text & "'"

            con.ConnDb()
            con.Open5()
            con.Command5(squery)
            dr = con.OpenDataReader5
            If dr.Read Then
                Me.Label4.Text = dr.Item("res_id")
            End If
            dr.Close()
            con.Execute5()
            con.Close5()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/cmbEmployee_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbLotNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLotNo.SelectedIndexChanged
        Try
            dataTable.Clear()
            Me.TextBox1.Text = ""
            btnSave.Enabled = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmbLotNo.Focus()
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub cmbMonth_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.TextChanged
    '    Dim v, s, a, k As Integer
    '    'MsgBox(Mid(cmbMonth.Items(v), 1, s))
    '    For k = 1 To Me.cmbMonth.Text.Length
    '        For v = 0 To Me.cmbMonth.Items.Count - 1
    '            For s = 1 To Len(Me.cmbMonth.Items(v))
    '                If Mid(cmbMonth.Text, 1, k) = Mid(cmbMonth.Items(v), 1, 1) Then
    '                    Me.cmbMonth.Text = Me.cmbMonth.Items(v)
    '                    Exit Sub
    '                Else
    '                    v += 1
    '                End If
    '                'MsgBox(Mid(cmbMonth.Text, 1, k))
    '                'MsgBox(Mid(cmbMonth.Items(v), 1, 1))
    '            Next
    '        Next
    '        'For msgbox((Me.cmbMonth.Items(v)))
    '        '    MsgBox(Len(Me.cmbMonth.Items(s)))
    '        'Next
    '    Next
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbLotNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbLotNo.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(13) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                Exit Sub
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If cmbLotNo.Text = "" Then
                    MsgBox("Please enter or select lot number.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
            End If
            If e.KeyChar = ChrW(13) Then
                dataTable.Clear()
                Me.Cursor = Cursors.WaitCursor
                Dim li_row As Integer = dataTable.Rows.Count
                Dim sQuery, squery1, squery2, temp, id, sqcnt, row As String
                Dim a, b, c, i, tempa, u, s, m As Integer
                Dim d As Integer
                Dim con As New clsCommon
                Dim com As SqlCommand
                Dim conn As New clsCommon
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader

                If cmbLotNo.Text.Length = 10 Then

                    a = Now.MinValue.Day
                    b = Now.MaxValue.Day
                    c = Now.Year
                    'd = Me.cmbMonth.SelectedIndex + 1

                    ds_dataset.Reset()

                    If Me.txtCostCenter.Text = "" Then
                        MsgBox("Please select business center.", MsgBoxStyle.Information, TitleMsgBox)
                        dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                    Else
                        If Me.txtCostCenter.Text = "MLWB" Then
                            ConnectDB()
                            If Me.cmbLotNo.Text = "" Then
                                Exit Sub
                            Else
                                'ang length niya kay insakto jud nga 12(ptn) paopao 03092010 ASYS 3.0 upgrade
                                Dim dm As New SqlClient.SqlDataAdapter("SELECT ptn, refallbarcode as barcode from rems.dbo.asys_MLWB_detail  where refLotno='" & Me.cmbLotNo.Text & "' and status = 'released'", cn)
                                row = 1
                                ds_dataset.Clear()
                                dm.Fill(ds_dataset, "ptn")
                                con.Connectionstring3()
                                con.Open3()
                                conn.Connectionstring3()
                                conn.Open3()
                                For a = 0 To ds_dataset.Tables(0).Rows.Count - 1

                                    Try
                                        cmbItems = New ComboBox
                                        cmbItems.Width = 150
                                        cmbItems.DataSource = ds_dataset.Tables(0)
                                        cmbItems.DisplayMember = "ptn"

                                        If li_row = 0 Then
                                            dataTable.LoadDataRow(arrstr, True)
                                        Else
                                            DgEntry(li_row, 0) = ""
                                            DgEntry(li_row, 1) = ""
                                            DgEntry(li_row, 2) = ""
                                            DgEntry(li_row, 3) = ""
                                            DgEntry(li_row, 4) = ""
                                            DgEntry(li_row, 5) = ""
                                            DgEntry(li_row, 6) = ""
                                            DgEntry(li_row, 7) = ""
                                            DgEntry(li_row, 8) = ""
                                        End If
                                        id = ds_dataset.Tables(0).Rows(a).Item(1)

                                        DgEntry(li_row, 0) = ""
                                        DgEntry(li_row, 1) = con.IsNull(ds_dataset.Tables(0).Rows(a).Item("PTN")).ToString
                                        '------ASYS 3.0 upgrade paopao
                                        If con.IsNull(ds_dataset.Tables(0).Rows(a).Item("PTN")) <> 0 Then
                                            DgEntry(li_row, 1) = Trim(con.IsNull(ds_dataset.Tables(0).Rows(a).Item("PTN"))).ToString.PadLeft(12, "0")
                                        Else
                                            DgEntry(li_row, 1) = ds_dataset.Tables(0).Rows(a).Item("PTN").ToString
                                        End If
                                        DgEntry(li_row, 2) = ""
                                        DgEntry(li_row, 3) = ""
                                        DgEntry(li_row, 4) = ""
                                        DgEntry(li_row, 5) = ""
                                        DgEntry(li_row, 6) = ""
                                        DgEntry(li_row, 7) = ""
                                        DgEntry(li_row, 8) = ""

                                        DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                                        DgEntry.Focus()

                                        'sQuery = "Select refallbarcode, ptn from rems.dbo.asys_MLWB_detail where Isnull(ptn,'0') ='" & DgEntry(li_row, 1) & "'" 'union all select refallbarcode, ptn from asys_remoutsource_detail where Isnull(ptn,'0')='" & DgEntry(li_row, 1) & "'
                                        'sQuery = "Select refallbarcode, ptn from rems.dbo.asys_MLWB_detail  where refallbarcode ='" & id & "'"
                                        'conn.Command3(sQuery)
                                        'dr1 = conn.OpenDataReader3
                                        'temp = DgEntry(li_row, 1)
                                        'i = 1
                                        'While dr1.Read
                                        DgEntry(DgEntry.CurrentCell.RowNumber, DgEntry.CurrentCell.ColumnNumber - 1) = row
                                        'i += 1
                                        'End While
                                        'dr1.Close()
                                        'conn.Execute3()
                                        'conn.Close3()

                                        squery2 = "Select refallbarcode as barcode, all_desc as alldesc, all_weight as weight, all_karat as karat, all_carat as carat, all_price as price from rems.dbo.asys_MLWB_detail  where reflotno ='" & Me.cmbLotNo.Text & "' and refallbarcode= '" & id & "'" 'union all Select refallbarcode as barcode from rems.dbo.asys_remoutsource_detail where reflotno ='" & Me.cmbLotNo.Text & "' and refallbarcode='" & id & "'
                                        con.Command3(squery2)
                                        dr = con.OpenDataReader3
                                        While dr.Read

                                            If DgEntry(li_row, 0) = "NO." Then
                                                DgEntry(li_row, 0) = ""
                                            End If
                                            If DgEntry(li_row, 1) = "PTN" Then
                                                DgEntry(li_row, 1) = ""
                                            End If
                                            DgEntry(li_row, 2) = con.IsNull(dr.Item("barcode"))
                                            DgEntry(li_row, 3) = ""
                                            DgEntry(li_row, 4) = con.IsNull(dr.Item("alldesc"))
                                            DgEntry(li_row, 5) = con.IsNull(dr.Item("weight"))
                                            DgEntry(li_row, 6) = con.IsNull(dr.Item("karat"))
                                            DgEntry(li_row, 7) = con.IsNull(dr.Item("carat"))
                                            If con.IsNull(dr.Item("price")) = False Then
                                                DgEntry(li_row, 8) = 0
                                            Else
                                                DgEntry(li_row, 8) = con.IsNull(FormatNumber(dr.Item("price")))
                                            End If

                                            dataTable.LoadDataRow(arrstr, True)

                                            li_row += 1

                                        End While

                                        dr.Close()
                                        con.Execute3()
                                        con.Close3()

                                        dataTable.LoadDataRow(arrstr, True)
                                        li_row += 1

                                        If DgEntry(li_row, 2) = "PTN" Then
                                            li_row += 1

                                            If li_row = dataTable.Rows.Count Then
                                            Else
                                                dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber + 1))
                                            End If

                                        End If
                                        row = row + 1
                                    Catch ex As Exception
                                        dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                                        Exit For
                                    End Try
                                Next

                                If Me.DgEntry.VisibleRowCount > 0 Then
                                    For u = 1 To dataTable.Rows.Count
                                        If Me.DgEntry(u - 1, 0) = "" Then
                                            Me.TextBox1.Text = tempa
                                        ElseIf Me.DgEntry(u - 1, 0) = "NO." Then
                                        Else
                                            s = (DgEntry(u - 1, 0))
                                            tempa = tempa + s
                                        End If
                                    Next
                                End If
                                Me.TextBox1.Text = tempa

                                If Me.DgEntry.VisibleRowCount > 0 Then
                                    For u = 1 To dataTable.Rows.Count
                                        If Me.DgEntry(u - 1, 2) = "" Then
                                            u += 1
                                        Else
                                            DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 2), 4, 5)
                                        End If
                                    Next
                                End If

                                If Me.DgEntry.VisibleRowCount > 0 Then
                                    For u = 0 To dataTable.Rows.Count
                                        If u = dataTable.Rows.Count Then
                                            u = u - 1
                                            If u >= dataTable.Rows.Count Then
                                                Exit For
                                            End If
                                            If Me.DgEntry(u, 0) = "NO." Then
                                                dataTable.Rows.Remove(dataTable.Rows(u))
                                                Exit For
                                            End If
                                        End If
                                        If Me.DgEntry(u, 0) = "NO." Then
                                            dataTable.Rows.Remove(dataTable.Rows(u))
                                        End If
                                    Next
                                End If

                                DgEntry.CurrentCell = New DataGridCell(li_row, 0)
                                DgEntry.Focus()
                                Me.btnSave.Enabled = True
                            End If
                        End If
                    End If
                Else
                    MsgBox("LOTNO doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                    cmbLotNo.Focus()
                    Me.Cursor = Cursors.Arrow
                    Exit Sub
                End If
                TextBox1.Text = dataTable.Rows.Count
                Call DetailList()
                Me.Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/cmbLotNo_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmPRICINGReceiving_rpt
            frm.txtlot.Text = reclotno
            frm.Show()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/btnPrint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReceiving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiving.Click
        Try
            recrelrep = True
            Dim frm As New Report
            frm.Label6.Visible = False
            frm.TextBox2.Visible = False
            frm.Text = "Receiving Report ASYS 5.0"
            frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbMonth_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCostCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCostCenter.SelectedIndexChanged
        Try
            'cmbCostCenter.Text = MainCost
            cmbCostCenter.Text = "MLWB"
            If MainCost = "REM" Then
                cmbLotNo.Enabled = False
                Me.cboreceive.Enabled = False
                Me.btnReceiving.Visible = True
                Me.btnPrint.Visible = False
                DgEntry.Enabled = False
                ListView1.BringToFront()
            Else
                cmbLotNo.Enabled = True
                Me.cboreceive.Enabled = True
                Me.cboreceive.BringToFront()
                Me.btnReceiving.Visible = False
                Me.btnPrint.Visible = True
                ListView1.SendToBack()
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/cmbCostCenter_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCostCenter.MouseWheel
        'cmbCostCenter.Text = MainCost
    End Sub

    Private Sub cmbLotNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLotNo.TextChanged
        Try
            'If cmbLotNo.Text.Length = 10 Then
            '    If cmbLotNo.Text <> "0" Then
            '        reclotno = cmbLotNo.Text
            '        dataTable.Rows.Clear()
            '    End If
            'End If
            dataTable.Clear()
            Me.TextBox1.Text = "0"
            btnSave.Enabled = False


        Catch ex As Exception
            MsgBox("frmPricingReceiving/cmbLotNo_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListView1.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.Click
        Try
            TextBox1.Text = dataTable.Rows.Count
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try
            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 0
                    txttext.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0)
                    Exit Select
                Case 1
                    cmbItems.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1)
                Case 4
                    cmbsource.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 4)
                    Exit Select

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Function receiver()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("select fullname as fullname2, * from rems.dbo.vw_humresvismin where job_title like 'distri%'order by fullname asc")
            dr = obj.OpenDataReader5
            While dr.Read
                Me.cboreceive.Items.Add(UCase(Trim(dr.Item("fullname2"))))
            End While
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/receiver: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub cboreceive_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboreceive.SelectedIndexChanged
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String

            squery = "Select rtrim(fullname) as fullname2 from " & humres2 & " where fullname='" & Me.cboreceive.SelectedItem & "'"
            con.ConnDb()
            con.Open5()
            con.Command5(squery)
            dr = con.OpenDataReader5
            If dr.Read Then
                Me.cboreceive.Text = Me.txtreceive.Text
                Me.txtreceive.BringToFront()
                Me.txtreceive.Text.TrimEnd()
                Me.txtreceive.Text = UCase(dr.Item(Trim("fullname2")))
                newreceiver = Me.txtreceive.Text
            End If
            dr.Close()
            'con.Execute5()
            con.Close5()
        Catch ex As Exception

        End Try
    End Sub

    Private Function datereceived() As Date
        Try
            Dim sdate As Date
            Dim sysdate, smonth, compl, compt, sday, syear As String

            sysdate = Format(Now, "MM-dd-yyyy")
            sdate = sysdate
            smonth = sdate.Month
            sday = sdate.Day
            syear = sdate.Year
            Select Case smonth
                Case "1"
                    smonth = "January"
                Case "2"
                    smonth = "February"
                Case "3"
                    smonth = "March"
                Case "4"
                    smonth = "April"
                Case "5"
                    smonth = "May"
                Case "6"
                    smonth = "June"
                Case "7"
                    smonth = "July"
                Case "8"
                    smonth = "August"
                Case "9"
                    smonth = "September"
                Case "10"
                    smonth = "October"
                Case "11"
                    smonth = "November"
                Case "12"
                    smonth = "December"
            End Select
            compl = CStr(smonth + " " + sday + ", " + syear)
            compt = compl
            Me.txtDate.Text = UCase(compt)
            Me.txtDate.TextAlign = HorizontalAlignment.Left
        Catch ex As Exception
            MsgBox("frmPricingReceiving/datereceived: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub cboreceive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboreceive.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                Dim sqry As String
                Dim obj As New clsCommon

                cmbLotNo.Items.Clear()
                obj.Connectionstring3()
                obj.Open3()
                sqry = "select distinct reflotno from asys_mlwb_detail where status = 'RELEASED'"
                obj.Command3(sqry)
                dr = obj.OpenDataReader3
                While dr.Read
                    Me.cmbLotNo.Items.Add(Trim(dr.Item("reflotno")))
                End While
                obj.Close3()
                Me.cmbLotNo.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/cboreceive_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function lots()
        Try

            Dim sqry As String
            Dim obj As New clsCommon

            cmbLotNo.Items.Clear()
            obj.Connectionstring3()
            obj.Open3()
            sqry = "select distinct reflotno from asys_mlwb_detail where status = 'RELEASED' and reflotno is not null and reflotno <> ' ' and reflotno <> '' order by reflotno desc"
            obj.Command3(sqry)
            dr = obj.OpenDataReader3
            While dr.Read
                Me.cmbLotNo.Items.Add(Trim(dr.Item("reflotno")))
            End While
            obj.Close3()
            dataTable.Clear()
            Me.cmbLotNo.Focus()
        Catch ex As Exception
            MsgBox("frmPricingReceiving/lots: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub btnSearchLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchLot.Click
        Dim frm As New frmSearchLotno
        frm.Show()
    End Sub

    Private Sub btnUnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnRec.Click
        Dim frm As New frmUnreceivedReport_perDept
        frm.txtCostcenter.Text = "PRICING"
        frm.txtusername.Text = UCase(userLog)
        frm.ShowDialog()
    End Sub

    Private Sub txtCostCenter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostCenter.TextChanged
        Try
            'cmbCostCenter.Text = MainCost
            txtCostCenter.Text = "MLWB"
            If MainCost = "REM" Then
                cmbLotNo.Enabled = False
                Me.cboreceive.Enabled = False
                Me.btnReceiving.Visible = True
                Me.btnPrint.Visible = False
                DgEntry.Enabled = False
                ListView1.BringToFront()
            Else
                cmbLotNo.Enabled = True
                Me.cboreceive.Enabled = True
                Me.cboreceive.BringToFront()
                Me.btnReceiving.Visible = False
                Me.btnPrint.Visible = True
                ListView1.SendToBack()
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving/txtCostCenter_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.TextChanged

    End Sub
End Class
