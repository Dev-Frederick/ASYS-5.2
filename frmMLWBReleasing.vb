Imports System.Data.SqlClient
Imports System.IO
Public Class frmMLWBReleasing
    Inherits System.Windows.Forms.Form
    Private WithEvents cmbItems As System.Windows.Forms.ComboBox
    Private WithEvents cmbsource As System.Windows.Forms.TextBox
    Private WithEvents cmbbarcode As System.Windows.Forms.TextBox
    'textbox
    Private WithEvents txttext As System.Windows.Forms.TextBox
    Private WithEvents txtitemdesc As System.Windows.Forms.TextBox
    Private WithEvents txtgrams As System.Windows.Forms.TextBox
    Private WithEvents txtkarat As System.Windows.Forms.TextBox
    Private WithEvents txtcarat As System.Windows.Forms.TextBox
    Private WithEvents txtprice As System.Windows.Forms.TextBox

    'button
    Private WithEvents cmdDelete As System.Windows.Forms.Button
    Private WithEvents dataTable As DataTable
    Private ds_dataset As New DataSet
    Private dv_dataview As DataView
    Dim i As Integer
    Dim dgtb As DataGridTextBoxColumn
    Dim tmp As String
    Private WithEvents btn As System.Windows.Forms.Button
    Private arrstr() As String

    Private cn As New SqlClient.SqlConnection
    Public sDatasource1 As String
    Public sDatabase1 As String
    Public sUsername1 As String
    Public sPassword1 As String
    Public sDatasource2 As String
    Private ConStr2 As String
    Dim mdate As Date
    Public sDatabase2 As String
    Private sAction As String()
    Public sUsername2 As String
    Public sPassword2 As String
    Dim slotno As String
    Dim objclass As New clsCommon
    Dim objcommon As New clsCommon
    Dim dr As SqlDataReader
    Dim objcommom As New clsCommon
    Dim p As String

    Private WithEvents tm As New ContextMenu
    Private WithEvents ti As New NotifyIcon

    Private dt As DataTable
    Private dv As DataView
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Dim colStyle As GridColumnStylesCollection
    Public pi_search_column As Integer
    Public ps_search_result As String
    Dim barcode As String

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        CreateGrid()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AsysReleasing As System.Windows.Forms.Label
    Friend WithEvents lbl1FA01 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLot As System.Windows.Forms.Label
    Friend WithEvents btnLotNum As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCostCenter As System.Windows.Forms.ComboBox
    Friend WithEvents txtDateReleased As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbreflotno As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblBCode As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtreflot As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCostCenter As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMLWBReleasing))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.AsysReleasing = New System.Windows.Forms.Label
        Me.lbl1FA01 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnLot = New System.Windows.Forms.Label
        Me.btnLotNum = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbreflotno = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCostCenter = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtDateReleased = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.cb = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtreflot = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblBCode = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(40, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'AsysReleasing
        '
        Me.AsysReleasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsysReleasing.Location = New System.Drawing.Point(792, 16)
        Me.AsysReleasing.Name = "AsysReleasing"
        Me.AsysReleasing.Size = New System.Drawing.Size(160, 24)
        Me.AsysReleasing.TabIndex = 106
        Me.AsysReleasing.Text = "ASYS Releasing"
        '
        'lbl1FA01
        '
        Me.lbl1FA01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1FA01.Location = New System.Drawing.Point(880, 48)
        Me.lbl1FA01.Name = "lbl1FA01"
        Me.lbl1FA01.Size = New System.Drawing.Size(72, 16)
        Me.lbl1FA01.TabIndex = 107
        Me.lbl1FA01.Text = "1FA01 V5.2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(48, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Releaser"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "COST CENTER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "DATE RELEASED"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLot
        '
        Me.btnLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLot.Location = New System.Drawing.Point(80, 40)
        Me.btnLot.Name = "btnLot"
        Me.btnLot.Size = New System.Drawing.Size(38, 11)
        Me.btnLot.TabIndex = 117
        Me.btnLot.Text = "LOT#"
        Me.btnLot.Visible = False
        '
        'btnLotNum
        '
        Me.btnLotNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLotNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLotNum.Image = CType(resources.GetObject("btnLotNum.Image"), System.Drawing.Image)
        Me.btnLotNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLotNum.Location = New System.Drawing.Point(256, 31)
        Me.btnLotNum.Name = "btnLotNum"
        Me.btnLotNum.Size = New System.Drawing.Size(88, 25)
        Me.btnLotNum.TabIndex = 118
        Me.btnLotNum.Text = "ADD ROW"
        Me.btnLotNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLotNum.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "LOT NUMBER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'cmbreflotno
        '
        Me.cmbreflotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreflotno.Location = New System.Drawing.Point(128, 62)
        Me.cmbreflotno.MaxLength = 10
        Me.cmbreflotno.Name = "cmbreflotno"
        Me.cmbreflotno.Size = New System.Drawing.Size(192, 21)
        Me.cmbreflotno.TabIndex = 120
        Me.cmbreflotno.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCostCenter)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDateReleased)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 128)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'txtCostCenter
        '
        Me.txtCostCenter.Location = New System.Drawing.Point(128, 56)
        Me.txtCostCenter.Name = "txtCostCenter"
        Me.txtCostCenter.ReadOnly = True
        Me.txtCostCenter.Size = New System.Drawing.Size(208, 20)
        Me.txtCostCenter.TabIndex = 135
        Me.txtCostCenter.Text = ""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 24)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "USERNAME"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(344, 84)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 36)
        Me.Button4.TabIndex = 131
        Me.Button4.Text = "OUTSOURCE/ RETURNS"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(344, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 32)
        Me.Button3.TabIndex = 130
        Me.Button3.Text = "Release items received by branch"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(344, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 32)
        Me.Button2.TabIndex = 129
        Me.Button2.Text = "Release Forced Received Items"
        '
        'txtDateReleased
        '
        Me.txtDateReleased.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDateReleased.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateReleased.Location = New System.Drawing.Point(128, 80)
        Me.txtDateReleased.Name = "txtDateReleased"
        Me.txtDateReleased.ReadOnly = True
        Me.txtDateReleased.Size = New System.Drawing.Size(208, 20)
        Me.txtDateReleased.TabIndex = 127
        Me.txtDateReleased.Text = ""
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(128, 32)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.ReadOnly = True
        Me.txtuser.Size = New System.Drawing.Size(208, 20)
        Me.txtuser.TabIndex = 133
        Me.txtuser.Text = ""
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCostCenter.ItemHeight = 13
        Me.cmbCostCenter.Items.AddRange(New Object() {"PRICING"})
        Me.cmbCostCenter.Location = New System.Drawing.Point(128, 56)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(208, 21)
        Me.cmbCostCenter.TabIndex = 113
        '
        'cb
        '
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb.Location = New System.Drawing.Point(128, 56)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(208, 21)
        Me.cb.TabIndex = 128
        Me.cb.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(128, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 134
        Me.TextBox1.Text = "PRICING"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtreflot)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnLot)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnLotNum)
        Me.GroupBox2.Controls.Add(Me.lblBCode)
        Me.GroupBox2.Controls.Add(Me.cmbreflotno)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 128)
        Me.GroupBox2.TabIndex = 122
        Me.GroupBox2.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(322, 62)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 22)
        Me.btnSearch.TabIndex = 150
        Me.btnSearch.Text = "...."
        '
        'txtreflot
        '
        Me.txtreflot.BackColor = System.Drawing.Color.White
        Me.txtreflot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreflot.Location = New System.Drawing.Point(128, 32)
        Me.txtreflot.Name = "txtreflot"
        Me.txtreflot.ReadOnly = True
        Me.txtreflot.Size = New System.Drawing.Size(120, 20)
        Me.txtreflot.TabIndex = 149
        Me.txtreflot.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 23)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "TEMP LOT NO."
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(56, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "Action"
        Me.Label13.Visible = False
        '
        'lblBCode
        '
        Me.lblBCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBCode.Location = New System.Drawing.Point(48, 64)
        Me.lblBCode.Name = "lblBCode"
        Me.lblBCode.Size = New System.Drawing.Size(48, 16)
        Me.lblBCode.TabIndex = 141
        Me.lblBCode.Text = "BCcode"
        Me.lblBCode.Visible = False
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(8, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 124
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(808, 536)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnPrint.TabIndex = 125
        Me.btnPrint.Text = "PRINT F20"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'DgEntry
        '
        Me.DgEntry.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackgroundColor = System.Drawing.Color.Tan
        Me.DgEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgEntry.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DgEntry.DataMember = ""
        Me.DgEntry.FlatMode = True
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Tan
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DgEntry.Location = New System.Drawing.Point(8, 248)
        Me.DgEntry.Name = "DgEntry"
        Me.DgEntry.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.RowHeadersVisible = False
        Me.DgEntry.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DgEntry.SelectionForeColor = System.Drawing.Color.White
        Me.DgEntry.Size = New System.Drawing.Size(968, 264)
        Me.DgEntry.TabIndex = 126
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AsysReleasing)
        Me.GroupBox3.Controls.Add(Me.lbl1FA01)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(968, 136)
        Me.GroupBox3.TabIndex = 127
        Me.GroupBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(232, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 32)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(888, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(192, 272)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(616, 136)
        Me.ListView1.TabIndex = 130
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ALLBarcode"
        Me.ColumnHeader1.Width = 132
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "PTN"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "LOTNO"
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(480, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 24)
        Me.Label7.TabIndex = 131
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(808, 536)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 40)
        Me.Button5.TabIndex = 132
        Me.Button5.Text = "Print F20"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 16)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "TOTAL NO. OF ITEMS"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 524)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 24)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(192, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 8)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Label10"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(88, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 40)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "DELETE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(640, 520)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 64)
        Me.GroupBox4.TabIndex = 137
        Me.GroupBox4.TabStop = False
        '
        'frmMLWBReleasing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 588)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMLWBReleasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MLWB RELEASING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(9) {"NO.", "PTN", "A.L.L. BARCODE            ", "ITEM SOURCE", "     DESCRIPTION", "WEIGHT", "KARAT", "CARAT", "PRICE", " "}

            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")

            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 9
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
                'Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 75
                colStyle(1).Width = 90
                colStyle(2).Width = 115
                colStyle(3).Width = 90
                colStyle(4).Width = 275
                colStyle(5).Width = 65
                colStyle(5).Alignment = HorizontalAlignment.Right
                colStyle(6).Width = 65
                colStyle(6).Alignment = HorizontalAlignment.Right
                colStyle(7).Width = 65
                colStyle(7).Alignment = HorizontalAlignment.Right
                colStyle(8).Width = 85
                colStyle(8).Alignment = HorizontalAlignment.Right
                colStyle(9).Width = 60
                colStyle(9).Alignment = HorizontalAlignment.Center

                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                txttext = New TextBox
                txttext.Width = 75
                cmbItems = New ComboBox
                cmbItems.Width = 90
                cmbbarcode = New TextBox
                cmbbarcode.Width = 115
                cmbsource = New TextBox
                cmbsource.Width = 90
                txtitemdesc = New TextBox
                txtitemdesc.Width = 275

                txtgrams = New TextBox
                txtgrams.Width = 65
                txtkarat = New TextBox
                txtkarat.Width = 65
                txtcarat = New TextBox
                txtcarat.Width = 65
                txtprice = New TextBox
                txtprice.Width = 85

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbItems)
                cmbItems.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbbarcode)
                cmbbarcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbsource)
                cmbsource.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtitemdesc)
                txtitemdesc.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtgrams)
                txtgrams.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtkarat)
                txtkarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtcarat)
                txtcarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtprice)
                txtprice.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/CreatedGrid: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
        'Take the text box from the second column of the grid where u will be adding the controls of your choice	
    End Sub

    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim strLotnO As String
            Dim objclass As New clsCommon
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String

            ' ConnectDB1()

            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select lotno from ASYS_Lotno_gen")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
                Me.txtreflot.Text = GenerateLot
            End If
            dr.Close()
            objclass.Execute3()
            objclass.Close3()

            'Me.cmbCostCenter.Text = GenerateLot
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/GenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    'Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    '    'DgEntry.Enabled = True
    'End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            Dim repz As Integer
            If Not ab_isEmpty Then
                If deleteData(hi) Then
                    repz = MsgBox("Are you sure you want to remove the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                    If repz = vbYes Then
                        dataTable.Rows.RemoveAt(hi.Row)
                        Label9.Text = dataTable.Rows.Count - 1
                    Else
                        cmdDelete.BringToFront()
                        cmdDelete.ForeColor = Color.Black
                        Exit Sub
                    End If
                Else
                    MsgBox("Error in removing data!", MsgBoxStyle.Information, TitleMsgBox)
                End If
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/deleteRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try
            Dim hi As DataGrid.HitTestInfo
            'Dim pt = New Point(e.X, e.Y)
            'Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)



            'hi = DgEntry.HitTest(e.X, e.Y)

            ''If hi.Column = 0 Then
            ''    DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            ''    DgEntry.Select(hit.Row)
            ''End If

            'If hi.Column = 9 And hi.Row >= 0 Then
            '    If DgEntry(hi.Row, 1) <> "" Then
            '        deleteRow(hi, False)
            '    Else
            '        deleteRow(hi, True)
            '    End If
            'End If

            Dim repz, x As Integer
            hi = DgEntry.HitTest(e.X, e.Y)
            If DgEntry.CurrentCell.ColumnNumber = 9 Then
                If hi.Column = 9 And hi.Row >= 0 Then
                    repz = MsgBox("Are you sure you want to remove the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                    If repz = vbYes Then
                        dataTable.Rows.RemoveAt(hi.Row)
                        Label9.Text = dataTable.Rows.Count
                        ' Label9.Text = hi.Row
                        If dataTable.Rows.Count = 0 Then
                            Me.btnLotNum.Enabled = True
                            Me.btnSave.Enabled = False
                        End If
                        If cmbbarcode.Text = "" Then
                            Me.btnLotNum.Enabled = True
                            Me.btnSave.Enabled = False
                        End If
                    Else
                        cmdDelete.BringToFront()
                        cmdDelete.ForeColor = Color.Black
                        Exit Sub
                    End If

                    If dataTable.Rows.Count > 0 Then
                        Dim i As Integer = 0
                        For i = 0 To dataTable.Rows.Count - 1
                            DgEntry(i, 0) = i + 1
                        Next
                    End If

                    If Label9.Text = "0" Then
                        Me.btnSave.Enabled = False
                        Me.Button6.Enabled = False
                    Else
                        Me.btnSave.Enabled = True
                        Me.Button6.Enabled = True
                    End If
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/dgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function deleteData(ByVal hi As DataGrid.HitTestInfo) As Boolean
        Try
            Dim cm As New SqlClient.SqlCommand
            Dim ls_sql As String
            If cmdDelete.Text = "DELETE" Then
                deleteData = True
            Else
                deleteData = False
            End If

        Catch ex As Exception
            deleteData = False
            MsgBox("frmMLWBReleasing/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub addrow()
        Try
            Dim squery As String
            Dim conn As New clsCommon
            Dim dr1 As SqlDataReader
            Dim dr As SqlDataReader
            Dim con As New clsCommon
            Dim squery2 As String
            Dim temp As String
            Dim li_row As Integer = dataTable.Rows.Count
            Dim a, b, c, d, i, u As Integer
            a = Now.MinValue.Day
            b = Now.MaxValue.Day
            c = Now.Year


            ds_dataset.Reset()

            '-----------------------------MLWB-------------------------'
            If Me.TextBox1.Text = "PRICING" Then
                Me.Cursor = Cursors.WaitCursor
                conn.Connectionstring4()
                conn.Open4()
                con.Connectionstring3()
                con.Open3()
                i = 1
                'con.Command3("select * from asys_MLWB_detail inner join asys_MLWB_header on asys_MLWB_header.lotno = asys_MLWB_detail.lotno where asys_MLWB_detail.reflotno = '" & Me.cmbreflotno.Text & "' and asys_MLWB_detail.status= 'received'")
                con.Command3("select * from asys_MLWB_detail where lotno = '" & Me.cmbreflotno.Text & "' and status= 'received'")
                dr1 = con.OpenDataReader3
                While dr1.Read
                    ds_dataset.Reset()
                    Try
                        ConnectDB1()
                        ds_dataset.Clear()

                        Dim dg As New SqlClient.SqlDataAdapter("select ptn, refallbarcode from ASYS_MLWB_Detail where lotno = '" & Me.cmbreflotno.Text & "' and status = 'RECEIVED'", cn)
                        'Dim dg As New SqlClient.SqlDataAdapter("select right('00000000000' + ltrim(rtrim(ptn)), 12) as ptn, refallbarcode from ASYS_MLWB_Detail where lotno = '" & Me.cmbreflotno.Text & "' and status = 'RECEIVED'", cn)
                        ds_dataset.Clear()
                        dg.Fill(ds_dataset, "asys_MWLB_detail")

                        'txttext = New TextBox
                        'txttext.Width = 150

                        'cmbbarcode = New TextBox
                        'cmbbarcode.Width = 161
                        'cmbbarcode.DataSource = ds_dataset.Tables(0)
                        'cmbbarcode.DisplayMember = "ALLBarcode"

                        cmbItems = New ComboBox
                        cmbItems.Width = 161
                        cmbItems.DataSource = ds_dataset.Tables(0)
                        cmbItems.DisplayMember = "PTN"

                        Dim li_rowd As Integer = dataTable.Rows.Count
                        dataTable.LoadDataRow(arrstr, True)

                        DgEntry(li_rowd, 0) = ""
                        If ds_dataset.Tables(0).Rows(li_rowd).Item("PTN") <> 0 Then
                            'ang length niya kay insakto jud nga 12(ptn) paopao 03092010 asys 3.0 upgrade
                            DgEntry(li_rowd, 1) = Trim(ds_dataset.Tables(0).Rows(li_rowd).Item("PTN")).ToString.PadLeft(12, "0")
                        Else
                            DgEntry(li_rowd, 1) = ds_dataset.Tables(0).Rows(li_rowd).Item("PTN").ToString
                        End If
                        DgEntry(li_rowd, 2) = ds_dataset.Tables(0).Rows(li_rowd).Item("refALLBarcode").ToString

                        DgEntry(li_rowd, 3) = ""
                        DgEntry(li_rowd, 4) = ""
                        DgEntry(li_rowd, 5) = ""
                        DgEntry(li_rowd, 6) = ""
                        DgEntry(li_rowd, 7) = ""
                        DgEntry(li_rowd, 8) = ""
                        DgEntry(li_rowd, 9) = "DELETE"

                        DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                        DgEntry.Focus()
                        DgEntry(DgEntry.CurrentCell.RowNumber, DgEntry.CurrentCell.ColumnNumber - 2) = i

                        squery = "Select branchitemdesc as itemdesc, weight,karatgrading as karat,caratsize as carat,all_weight,all_karat,all_carat,all_cost,all_desc,all_price,price_desc,price_karat,price_carat,price_weight from asys_MLWB_detail where refallbarcode ='" & DgEntry(li_rowd, 2) & "' and lotno = '" & cmbreflotno.Text & "'"
                        conn.Command4(squery)
                        dr = conn.OpenDataReader4
                        If dr.Read Then
                            If conn.IsNull(dr.Item("all_price")) = "0" Then
                                DgEntry(li_rowd, 4) = conn.IsNull(dr.Item("all_desc"))
                                DgEntry(li_rowd, 5) = conn.IsNull(dr.Item("all_weight"))
                                DgEntry(li_rowd, 6) = conn.IsNull(dr.Item("all_karat"))
                                DgEntry(li_rowd, 7) = conn.IsNull(dr.Item("all_carat"))
                                If conn.IsNull(dr.Item("all_price")) = True Then
                                    DgEntry(li_rowd, 8) = conn.IsNull(FormatNumber(dr.Item("all_price")))
                                Else
                                    DgEntry(li_rowd, 8) = 0
                                End If

                            Else
                                DgEntry(li_rowd, 4) = conn.IsNull(dr.Item("price_desc"))
                                DgEntry(li_rowd, 5) = conn.IsNull(dr.Item("price_weight"))
                                DgEntry(li_rowd, 6) = conn.IsNull(dr.Item("price_karat"))
                                DgEntry(li_rowd, 7) = conn.IsNull(dr.Item("price_carat"))
                                DgEntry(li_rowd, 8) = conn.IsNull(FormatNumber(dr.Item("all_price")))
                            End If

                            DgEntry(li_rowd, 9) = "DELETE"
                        End If
                        barcode = DgEntry(li_rowd, 2)  '-------barcode
                        dr.Close()
                        conn.Execute4()
                        conn.Close4()

                        If Me.DgEntry.VisibleRowCount > 0 Then
                            For u = 1 To dataTable.Rows.Count
                                If Me.DgEntry(u - 1, 1) = "" Then
                                    u += 1
                                Else
                                    DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 2), 4, 5)
                                End If
                            Next
                        End If

                        'cmbsource = New TextBox
                        'cmbsource.Width = 161


                        'cmbbarcode = New TextBox
                        'cmbbarcode.Width = 161

                        'txttext = New TextBox
                        'txttext.Width = 161

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txttext)
                        txttext.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(cmbItems)
                        cmbItems.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(cmbbarcode)
                        cmbbarcode.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(cmbsource)
                        cmbsource.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(cmbsource)
                        cmbsource.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txtitemdesc)
                        txtitemdesc.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txtgrams)
                        txtgrams.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txtkarat)
                        txtkarat.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txtcarat)
                        txtcarat.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(txtprice)
                        txtprice.BringToFront()

                        dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                        dgtb.TextBox.Controls.Add(cmdDelete)
                        cmdDelete.ForeColor = ForeColor.Red
                        cmdDelete.BringToFront()

                        i = i + 1
                    Catch ex As Exception
                        dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                    End Try

                End While
                dr1.Close()
                'con.Execute4()
                con.Close4()


            End If
            conn = Nothing
            con = Nothing
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Addrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Function NextPrime(ByVal i As Integer) As Integer
        Try
            Dim ctr As Integer
            ctr = i + 1
            While Not isPrime(ctr)
                ctr = ctr + 1
            End While
            NextPrime = ctr
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/NextPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmMLWBReleasing/isPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmMLWBReleasing/decryptPass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function ConnectDB1() As Boolean
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
                MsgBox("frmMLWBReleasing/ConnectDB1: " & Ee.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmMLWBReleasing/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                MsgBox("frmMLWBReleasing/ConnectDB: " & Ee.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmMLWBReleasing/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub RetrieveAction()
        Try
            objclass = New clsCommon
            Dim dr As SqlDataReader
            Dim i As Double
            Dim sQuery As String

            sQuery = "select a.sortaction_id, b.action_type "
            sQuery = sQuery + " from (select distinct sortaction_id"
            sQuery = sQuery + " from tbl_receiving_header  "
            sQuery = sQuery + " where status_id = 2 or status_id = 3) a "
            sQuery = sQuery + " inner join tbl_action b on a.sortaction_id = b.action_id "
            sQuery = sQuery + "  order by b.action_type"

            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                sAction(i) = Trim(dr.Item("sortaction_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/RetrieveAction: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CAllLotno()
        Try
            Dim con As New clsCommon

            Me.cmbreflotno.Items.Clear()
            dataTable.Rows.Clear()
            con.Connectionstring3()
            con.Open3()
            con.Command3("Select distinct LOTno from asys_MLWB_detail where status = 'RECEIVED' order by lotno desc")
            dr = con.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(Trim(dr.Item("lotno")))
            End While
            dr.Close()
            ' con.Execute3()
            con.Close3()
            cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/CAllLotno: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmReleasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txtCostCenter.Text = "PRICING"
            TextBox1.Text = "PRICING"
            If sDB <> "" Then
                Call RetrieveAction()
            End If

            force = False
            outsource = False
            Button5.Visible = True
            Call valEmp()
            'Call CallCostCenter()
            Call CAllLotno()
            Call releaser()
            Me.txtreflot.Text = GetNewLotNumber("MLWB", "") 'templot()
            cb.Text = userLog
            'Me.cb.Items.Add(userLog)
            Me.cb.Text = fullname
            txtDateReleased.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            recrel2 = "releasing"
            Me.txtreflot.BackColor = Color.White
            Me.Button6.Enabled = False
            Me.btnSave.Enabled = False
            Me.cmbreflotno.Focus()
            Me.cmbreflotno.Select()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/frmReleasing_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CallCostCenter()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("Select * from vw_CostCenter")
            dr = obj.OpenDataReader3
            While dr.Read
                txtCostCenter.Text = (dr.Item("CostDept"))
            End While
            dr.Close()
            obj.Execute3()
            obj.Close3()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/CallCostCenter: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub valEmp()
        Try
            Me.txtuser.Text = UCase(fullname)
        Catch ex As Exception
        End Try
    End Sub

    Private Function releaser()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("select fullname from vw_humresvismin where job_title = 'MLWB'")
            dr = obj.OpenDataReader5
            While dr.Read
                Me.cb.Items.Add(UCase(dr.Item("fullname")))
            End While
            Me.cb.Focus()
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/releaser: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Public Function center()
        Try
            If Me.txtCostCenter.Text = "REM" Then
                center = "REM"
            End If

            If Me.txtCostCenter.Text = "MLWB" Then
                center = "MLWB"
            End If

            If Me.txtCostCenter.Text = "PRICING" Then
                center = "PRICING"
            End If

            If Me.txtCostCenter.Text = "DISTRI" Then
                center = "DISTRI"
            End If
            If Me.txtCostCenter.Text = "SHOWROOM" Or Me.txtCostCenter.Text = "VIP" Then
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/center: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub lotnorefresh()
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader

            Me.cmbreflotno.Items.Clear()
            dataTable.Rows.Clear()
            con.Connectionstring3()
            con.Open3()
            con.Command3("Select distinct reflotno from ASYS_REM_Detail  where status = 'RECEIVED'")
            dr = con.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(dr.Item("reflotno"))
            End While
            dr.Close()
            con.Execute3()
            con.Close3()

            Me.cmbreflotno.Text = ""
            Me.cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/lotnorefresh: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Enter Then
        '    Me.cmbCostCenter.Focus()
        'ElseIf e.KeyCode = Keys.Tab Then
        '    Me.cmbCostCenter.Focus()
        'Else
        '    Exit Sub
        'End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objclass As New clsCommon
        Try
            Dim rply As Integer
            Dim sqlinsert, sqlinsert1, sqlinsert2, squery1, sqlinsert3, squery, squery2, temps, temp, msg, m, l, p, w, templot, tempref As String
            Dim a, b, c, d, i, z As Integer
            Dim cn As New clsCommon
            Dim dr, dr1, dr3 As SqlDataReader
            Dim obj As New clsCommon
            Dim li_rowd As Integer = dataTable.Rows.Count

            'Label9.Text = dataTable.Rows.Count
            'templot = GenerateLot()
            'tempref = Me.cmbreflotno.Text
            'rellot = templot

            rply = MsgBox("Are you sure you want to release this data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                Me.Cursor = Cursors.WaitCursor
                If bleh = False Then
                    If relbleh = False Then
                        objclass = New clsCommon
                        objclass.Connectionstring3()
                        objclass.Opentracker2()
                        objclass.CreateCom()

                        i = Me.DgEntry.VisibleRowCount
                        If Me.DgEntry.VisibleRowCount > 0 Then

                            templot = GetNewLotNumber("MLWB", "")
                            Me.txtreflot.Text = templot
                            tempref = Me.cmbreflotno.Text
                            rellot = templot

                            sqlinsert3 = "Update ASYS_Lotno_Gen set lotno ='" & templot & "' WHERE BusinessCenter ='MLWB'"
                            objclass.commandTrack(sqlinsert3)
                            objclass.TrackExecute()

                            For a = 0 To dataTable.Rows.Count - 1
                                sqlinsert2 = "insert into asys_barcodehistory (lotno, refallbarcode,allbarcode, itemcode, [description], karat, carat, SerialNo, weight, currency, price, cost, empname, custodian, trandate, costcenter, consignto, status ) select '" & templot & "', refallbarcode as refallbarcode, refallbarcode as allbarcode, refitemcode, all_desc, price_karat, price_carat, SerialNo, price_weight, currency, all_price, all_cost,'" & txtuser.Text.Trim & "' as  empname, receiver as custodian, getdate() as trandate, 'MLWB', 'NULL', 'RELEASED' from asys_MLWB_detail where refallbarcode='" & Me.DgEntry.Item(a, 2) & "' and status = 'RECEIVED'"
                                objclass.commandTrack(sqlinsert2)
                                objclass.TrackExecute()

                                sqlinsert2 = "Update asys_MLWB_detail  set reflotno ='" & templot & "', releaser = '" & userLog & "', releasedate = getdate(), status = 'RELEASED' where refallbarcode='" & Me.DgEntry.Item(a, 2) & "' and status = 'received'"
                                objclass.commandTrack(sqlinsert2)
                                objclass.TrackExecute()
                            Next

                        Else
                            MsgBox("Pls Add Details on the data grid.", MsgBoxStyle.Information, TitleMsgBox)
                            Exit Sub
                        End If

                        objclass.CommitTrack()
                        MsgBox("Successfully released to PRICING Department.", MsgBoxStyle.Information, TitleMsgBox)
                        tmp = templot
                        Me.Button6.Enabled = False
                        Me.btnSave.Enabled = False
                        Me.Cursor = Cursors.Arrow
                    End If
                Else
                    'Call ifblehtrue()
                    Call saveblehtrue()
                End If

                'objclass.Close()
                'objclass = Nothing
                If bleh = True Then
                    rellotno = templot
                    MsgBox("SUCCESSFULLY RELEASED!", MsgBoxStyle.OKOnly, TitleMsgBox)
                    Exit Try
                ElseIf txtCostCenter.Text <> "REM" Then 'i need to know.. kung anong transaction to magagamit
                    rellotno = templot
                End If
            Else
                Exit Sub
            End If

            Call lotnorefresh()
            Call CAllLotno()
            'Call GenerateLot()
            Me.txtreflot.Text = GetNewLotNumber("MLWB", "")
            dataTable.Rows.Clear()
            Me.ListView1.Items.Clear()
            If Label9.Text = 0 Then
                Me.btnSave.Enabled = False
                Me.Button6.Enabled = False
            End If
            bleh = False
            Label9.Text = 0
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmMLWBReleasing/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objclass.Close()
        End Try
    End Sub

    Private Sub saveblehtrue()
        Dim obj As New clsCommon
        Try

            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1, str2, str3, str4 As String
            Dim i, a As Integer
            Dim templot As String

            templot = GetNewLotNumber("MLWB", "") 'GenerateLot()
            Me.txtreflot.Text = templot

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            str3 = "Update ASYS_Lotno_Gen set lotno ='" & templot & "' WHERE BusinessCenter ='MLWB'"
            obj.commandTrack(str3)
            obj.TrackExecute()

            For i = 0 To dataTable.Rows.Count - 1
                If DgEntry(i, 1) <> "" Then
                    str = "insert into asys_barcodehistory (lotno, refallbarcode,allbarcode, itemcode, [description], karat, carat, SerialNo, weight, currency, price, cost, empname, custodian, trandate, costcenter, consignto, status ) select '" & templot & "', refallbarcode as refallbarcode, refallbarcode as allbarcode, refitemcode, all_desc, price_karat, price_carat,SerialNo, price_weight, currency, all_price, all_cost,'" & txtuser.Text.Trim & "' as  empname, '" & txtuser.Text.Trim & "' as custodian, getdate() as trandate, 'MLWB', 'NULL', 'RELEASED' from asys_MLWB_detail where refallbarcode='" & Me.DgEntry.Item(i, 2) & "' and status = 'RECEIVED'"
                    obj.commandTrack(str)
                    obj.TrackExecute()

                    str = "Update asys_MLWB_detail  set reflotno ='" & templot & "', releasedate =getdate(), releaser='" & Me.cb.Text & "', status = 'RELEASED' where  refallbarcode='" & DgEntry(i, 2) & "'  and status = 'RECEIVED'"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                End If
            Next
            obj.CommitTrack()
            MsgBox("Successfully released to PRICING.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("frmMLWBReleasing/saveblehtrue: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close3()
            bleh = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
                Dim con As New clsCommon
                Dim dr As SqlDataReader
                If e.KeyChar = ChrW(13) Then
                    Dim fr As New frmMain
                    If UCase(job_title) = "SORTER" Then
                        If cmbCostCenter.Text <> "REM" Then
                            MsgBox("You dont have the right to access!", MsgBoxStyle.Exclamation, TitleMsgBox)
                            cmbCostCenter.Text = "REM"
                            Exit Sub
                        End If
                    Else
                        If cmbCostCenter.Text = "REM" Or cmbCostCenter.Text = "VIP" Then
                            If sDB = "" Then
                                If outsource = False Then
                                    sDB = myregion
                                End If
                            End If
                        Else
                            sDB = ""
                            fr.Text = "ASYS 5.2 Synergy Showroom"
                        End If
                    End If


                    If Me.cmbCostCenter.Text = "MLWB" Then
                        Me.cmbreflotno.Items.Clear()
                        dataTable.Rows.Clear()
                        con.Connectionstring3()
                        con.Open3()
                        con.Command3("Select distinct refLOTno from asys_MLWB_detail where status = 'RECEIVED' ")
                        dr = con.OpenDataReader3
                        While dr.Read
                            Me.cmbreflotno.Items.Add(Trim(dr.Item("reflotno")))
                        End While
                        dr.Close()
                        con.Execute3()
                        con.Close3()
                        Me.cb.Focus()
                    End If


                    Me.cmbreflotno.Text = ""
                    Me.cb.Focus()

                End If
                Me.cmbreflotno.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cb_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.txtCostCenter.Text = "REM"
            If txtCostCenter.Text = "REM" Then
                force = True
                outsource = False
                'Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.txtCostCenter.Text = "REM"
            If txtCostCenter.Text = "REM" Then
                force = False
                'Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txttext_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttext.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar = ChrW(13) Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 0) = txttext.Text
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 1)
                    cmbbarcode.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/txttext_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub btnLotNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotNum.Click
        Try
            Dim gotoAddrow As String
            Dim li_rowd As Integer = dataTable.Rows.Count

            If dataTable.Rows.Count = 0 Then
                btnSave.Enabled = False
                Button6.Enabled = True
                btnLotNum.Enabled = True

gotoaddrow:
                bleh = True



                dataTable.LoadDataRow(arrstr, True)

                DgEntry(li_rowd, 0) = li_rowd + 1
                DgEntry(li_rowd, 1) = ""
                DgEntry(li_rowd, 2) = ""
                DgEntry(li_rowd, 3) = ""
                DgEntry(li_rowd, 4) = ""
                DgEntry(li_rowd, 5) = ""
                DgEntry(li_rowd, 6) = ""
                DgEntry(li_rowd, 7) = ""
                DgEntry(li_rowd, 8) = ""
                DgEntry(li_rowd, 9) = "DELETE"

                cmbsource = New TextBox
                cmbsource.Width = 161

                cmbItems = New ComboBox
                cmbItems.Width = 161

                cmbbarcode = New TextBox
                cmbbarcode.Width = 161

                txttext = New TextBox
                txttext.Width = 161

                txtitemdesc = New TextBox
                txtitemdesc.Width = 161

                txtgrams = New TextBox
                txtgrams.Width = 161

                txtkarat = New TextBox
                txtkarat.Width = 161

                txtcarat = New TextBox
                txtcarat.Width = 161

                txtprice = New TextBox
                txtprice.Width = 161

                cmdDelete = New Button


                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txttext)
                'txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbbarcode)
                cmbbarcode.MaxLength = 17
                cmbbarcode.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(cmbItems)
                'cmbItems.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(cmbsource)
                'cmbsource.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txtitemdesc)
                'txtitemdesc.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txtgrams)
                'txtgrams.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txtkarat)
                'txtkarat.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txtcarat)
                'txtcarat.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(txtprice)
                'txtprice.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.ForeColor = ForeColor.Red
                cmdDelete.BringToFront()


                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            ElseIf cmbbarcode.Text <> "" Then
                ' ElseIf barcode <> "" Then
                If DgEntry(DgEntry.CurrentCell.RowNumber, 2) = "" Then
                    DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                    DgEntry.Focus()
                    cmbbarcode.Focus()
                    Exit Sub
                End If

                btnSave.Enabled = True
                GoTo gotoaddrow
            Else

                If dataTable.Rows.Count > 0 Then
                    If DgEntry(DgEntry.CurrentCell.RowNumber, 2) <> "" Then
                        GoTo gotoaddrow
                    End If
                End If

                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()

            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/btnLotNum_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbbarcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            Dim obj1 As New clsCommon
            Dim dr1 As SqlDataReader
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, SQuery As String
            Dim a As Integer
            Dim z As String
            Dim y As String
            'If cmbbarcode.Text = "" Then
            '    btnLotNum.Enabled = False
            '    Exit Try
            'End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If cmbbarcode.Text = "" Then
                    MsgBox("Please enter ALL barcode.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Try
                End If
            End If

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar = ChrW(13) Then

                    obj.Connectionstring3()
                    obj.Open3()
                    SQuery = "SELECT     RefallBarcode , PTN, RefItemcode, RefQty, ALL_desc as [desc], ALL_karat as karat, ALL_carat as carat, SerialNo, ALL_price as cost, ALL_Weight as wt,status FROM dbo.ASYS_MLWB_detail where refallbarcode = '" & cmbbarcode.Text & "' and status = 'RECEIVED'"
                    obj.Command3(SQuery)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        p = Trim(dr.Item("Refallbarcode"))
                        If Trim(dr.Item("status")) = "RELEASED" Then
                            MsgBox("ALLBarcode already released.", MsgBoxStyle.Information, TitleMsgBox)
                            cmbbarcode.Text = ""
                            cmbbarcode.Focus()
                        ElseIf Trim(dr.Item("status")) = "RECEIVED" Then
                            If dataTable.Rows.Count > 1 Then
                                'asys 3.0
                                For a = 0 To dataTable.Rows.Count - 1
                                    y = Trim(DgEntry(a, 2))
                                    If y = "" Then
                                        y = 0
                                    End If
                                    z = cmbbarcode.Text
                                    If y = z Then
                                        MsgBox("You have entered the same barcode.", MsgBoxStyle.Information, TitleMsgBox)
                                        cmbbarcode.Text = ""

                                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                                        DgEntry.Focus()

                                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                                        cmbbarcode.Focus()
                                        Exit For
                                    ElseIf a = dataTable.Rows.Count - 1 Then
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 1) = dr.Item("ptn")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 2) = cmbbarcode.Text
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(cmbbarcode.Text, 4, 5)
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("desc")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("wt")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("karat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("carat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("cost")))
                                        btnLotNum_Click(sender, e)
                                        Me.btnSave.Enabled = True
                                        'End If
                                    End If
                                Next
                            Else
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = dr.Item("ptn")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = Me.cmbbarcode.Text
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(cmbbarcode.Text, 4, 5)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("desc")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("wt")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("karat")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("carat")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("cost")))

                                btnLotNum_Click(sender, e)
                                Me.btnSave.Enabled = True
                            End If
                        Else
                            MsgBox("ALLBarcode doesn't exist or already released.", MsgBoxStyle.Information, TitleMsgBox)
                            cmbbarcode.Text = ""
                            cmbbarcode.Focus()
                        End If

                    Else
                        MsgBox("ALLBarcode doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                        cmbbarcode.Text = ""
                        cmbbarcode.Focus()
                    End If
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                End If
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                DgEntry.Focus()
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cmbbarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ifblehtrue()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1 As String
            Dim i, temp, u As Integer
            obj.Connectionstring3()
            obj.Open3()

            ListView1.Items.Clear()

            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 1 To dataTable.Rows.Count
                    If Me.DgEntry(u - 1, 1) = "" Then
                        dataTable.Rows.Remove(dataTable.Rows(u - 1))
                    End If
                Next
            End If

            If Me.txtCostCenter.Text = "MLWB" Then
                For i = 0 To Me.dataTable.Rows.Count - 1
                    str = "Select reflotno, refALLBarcode,ptn from asys_MLWB_detail where refALLBarcode='" & Me.DgEntry.Item(i, 2) & "' and status= 'received'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    While dr.Read = True
                        Me.ListView1.Items.Add(dr("refALLBarcode"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("ptn"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("reflotno"))
                    End While
                    dr.Close()
                Next

                For i = 0 To Me.ListView1.Items.Count - 1
                    str = "Select Count(refallbarcode) as barcode from asys_remoutsource_detail where refallbarcode ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and status = 'received'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        temp = dr.Item("barcode")
                        If temp >= 1 Then
                            Me.ListView1.Items(i).SubItems.Add("Outsource")
                        Else
                            Me.ListView1.Items(i).SubItems.Add("Force")
                        End If
                    End If
                    dr.Close()
                Next
                obj.Execute3()
                obj.Close3()
            ElseIf Me.txtCostCenter.Text = "PRICING" Then
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select  lotno_drec,ALLBarcode,ptn_drec from tbl_recrel_PRICING_dtail where ALLBarcode='" & Me.DgEntry.Item(i, 1) & "'  and status_id_drec= 1"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    While dr.Read = True
                        Me.ListView1.Items.Add(dr("ALLBarcode"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("ptn_drec"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("lotno_drec"))
                    End While
                    dr.Close()
                Next
                For i = 0 To Me.ListView1.Items.Count - 1
                    str = "Select Count(allbarcode_for) as barcode from tbl_forcedoutrcv where allbarcode_for ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and forcedout_status_for=7 and outsource_status_for = 4"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        temp = dr.Item("barcode")
                        If temp >= 1 Then
                            Me.ListView1.Items(i).SubItems.Add("Outsource")
                        Else
                            Me.ListView1.Items(i).SubItems.Add("Force")
                        End If
                    End If
                    dr.Close()
                Next
                obj.Execute3()
                obj.Close3()

            ElseIf Me.txtCostCenter.Text = "DISTRI" Then
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select  lotno_drec,ALLBarcode,ptn_drec from tbl_recrel_DISTRI_dtail where ALLBarcode='" & Me.DgEntry.Item(i, 1) & "' and status_id_drec= 3"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    While dr.Read = True
                        Me.ListView1.Items.Add(dr("ALLBarcode"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("ptn_drec"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("lotno_drec"))
                    End While
                    dr.Close()
                Next
                For i = 0 To Me.ListView1.Items.Count - 1
                    str = "Select Count(allbarcode_for) as barcode from tbl_forcedoutrcv where allbarcode_for ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and forcedout_status_for=10 and outsource_status_for = 4"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        temp = dr.Item("barcode")
                        If temp >= 1 Then
                            Me.ListView1.Items(i).SubItems.Add("Outsource")
                        Else
                            Me.ListView1.Items(i).SubItems.Add("Force")
                        End If
                    End If
                    dr.Close()
                Next
                obj.Execute3()
                obj.Close3()
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/ifblehtrue: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbsource_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbsource.KeyPress
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True

                If e.KeyChar = ChrW(13) Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(Me.cmbbarcode.Text, 4, 5)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 1)
                    btnLotNum_Click(sender, e)
                    txttext.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cmbsource_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmMLWBReport
            frm.Text = "RELEASING REPORT"
            frm.Label7.Text = rellotno
            'frm.Label7.Text = tmp
            frm.Label4.Text = Me.txtCostCenter.Text
            recrel = 4
            recrel2 = "releasing"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/btnPrint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim frm As New Report
            If outsource = False And bleh = False Then
                frm.Label2.Text = "Month"
                frm.TextBox1.Text = rellot
                frm.Label6.Visible = True
                frm.TextBox2.Visible = True
            ElseIf bleh = True Then
                frm.TextBox1.Text = rellot
                frm.Label6.Visible = False
                frm.TextBox2.Visible = False
                frm.Label5.Text = "LOTNO"
                frm.Label5.Visible = True
                frm.TextBox1.Visible = True
            End If

            frm.Text = "Releasing Report ASYS 5.2 Synergy Showroom"
            recrelrep = False
            frm.Show()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Button5_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbreflotno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreflotno.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If cmbreflotno.Text = "" Then
                    MsgBox("Please enter or select ALL lot number.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                dataTable.Rows.Clear()
                addrow()
                Label9.Text = dataTable.Rows.Count
                If Label9.Text <> 0 Then
                    Me.Button6.Enabled = True
                    Me.btnSave.Enabled = True
                    btnSave.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cmbreflotno_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCostCenter.TextChanged
        Try
            If cmbCostCenter.Text = "REM" And outsource = False Then
                Me.cmbreflotno.Visible = False
                Me.Label13.Visible = False
                btnLot.Visible = False
                btnLotNum.Visible = False
                lblBCode.Visible = False
                Me.Button5.Visible = True
                Me.btnPrint.Visible = False
                Button2.Visible = True
                Button3.Visible = True
                Button4.Visible = True
                'DgEntry.ReadOnly = True
                'DgEntry.Enabled = False
            ElseIf cmbCostCenter.Text = "VIP" Then
                'DgEntry.Enabled = False
                'DgEntry.ReadOnly = True
                Me.Label13.Visible = True
                Me.cmbreflotno.Visible = False
                lblBCode.Visible = True
                Label4.Visible = False
                btnLot.Visible = False
                btnLotNum.Visible = False
            Else
                outsource = False
                Me.btnLot.Visible = True
                Me.btnLotNum.Visible = True
                Me.cmbreflotno.Visible = True
                Me.btnLotNum.Visible = True
                lblBCode.Visible = False
                Me.cmbreflotno.Visible = True
                Label4.Visible = True
                Me.Label13.Visible = False
                Me.cmbreflotno.Enabled = True
                Me.btnLotNum.Enabled = True
                Me.Button5.Visible = False
                Me.btnPrint.Visible = True
                Button2.Visible = False
                Button3.Visible = False
                Button4.Visible = False
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cmbCostCenter_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try
            If bleh = True Then
                If cmbbarcode.Text <> "" Then
                    Label9.Text = dataTable.Rows.Count - 1
                End If
            End If

            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 0
                    txttext.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0).ToString

                Case 1
                    cmbItems.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1).ToString
                Case 2

                    cmbbarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2).ToString

                Case 3
                    cmbsource.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 3).ToString

                Case 4
                    txtitemdesc.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 4).ToString

                Case 5
                    txtgrams.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 5).ToString

                Case 6
                    txtkarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 6).ToString

                Case 7
                    txtcarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 7).ToString

                Case 8
                    txtprice.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 8).ToString

            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbCostCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCostCenter.SelectedIndexChanged
        Try
            dataTable.Clear()
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cmbCostCenter_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dataTable.Clear()
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/ComboBox1_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtbc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dataTable.Clear()
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/txtbc_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dataTable.Clear()
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/ComboBox3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            dataTable.Clear()
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/ComboBox2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCostCenter.MouseWheel
        Try
            cmbCostCenter.Text = MainCost
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim rply As Integer
            Dim u, s, tempa As Integer

            rply = MsgBox("Are you sure you want to delete " & DgEntry(DgEntry.CurrentCell.RowNumber, 2) & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                dataTable.Rows.RemoveAt(DgEntry.CurrentCell.RowNumber)
                If dataTable.Rows.Count = 0 Then
                    Me.btnLotNum.Enabled = True
                    Me.btnSave.Enabled = False
                End If
            Else
                Exit Sub
            End If

            Label9.Text = dataTable.Rows.Count
            'DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            DgEntry.Focus()
            If Label9.Text = 0 Then
                Me.btnSave.Enabled = False
                Me.Button6.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Button6_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            bleh = True

            btnSave.Enabled = True
            Button6.Enabled = True

            Dim li_rowd As Integer = dataTable.Rows.Count

            dataTable.LoadDataRow(arrstr, True)

            DgEntry(li_rowd, 0) = ""
            DgEntry(li_rowd, 1) = ""
            DgEntry(li_rowd, 2) = ""
            DgEntry(li_rowd, 3) = ""
            DgEntry(li_rowd, 4) = ""
            DgEntry(li_rowd, 5) = ""
            DgEntry(li_rowd, 6) = ""
            DgEntry(li_rowd, 7) = ""
            DgEntry(li_rowd, 8) = ""
            DgEntry(li_rowd, 9) = "DELETE"

            cmbsource = New TextBox
            cmbsource.Width = 161

            cmbItems = New ComboBox
            cmbItems.Width = 161

            cmbbarcode = New TextBox
            cmbbarcode.Width = 161

            txttext = New TextBox
            txttext.Width = 161

            txtitemdesc = New TextBox
            txtitemdesc.Width = 161

            txtgrams = New TextBox
            txtgrams.Width = 161

            txtkarat = New TextBox
            txtkarat.Width = 161

            txtcarat = New TextBox
            txtcarat.Width = 161

            txtprice = New TextBox
            txtprice.Width = 161

            cmdDelete = New Button


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txttext)
            txttext.BringToFront()

            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(cmbbarcode)
            cmbbarcode.BringToFront()

            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(cmbItems)
            cmbItems.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(cmbsource)
            cmbsource.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txtitemdesc)
            txtitemdesc.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txtgrams)
            txtgrams.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txtkarat)
            txtkarat.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txtcarat)
            txtcarat.BringToFront()


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txtprice)
            txtprice.BringToFront()

            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(cmdDelete)
            cmdDelete.ForeColor = ForeColor.Red
            cmdDelete.BringToFront()

            DgEntry(li_rowd, 0) = "1"


            DgEntry.CurrentCell = New DataGridCell(li_rowd, 1)
            DgEntry.Focus()
            cmbbarcode.Focus()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Button7_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.SelectedIndexChanged
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String

            squery = "Select rtrim(fullname) as fullname3 from " & humres2 & " where fullname='" & Me.cb.SelectedItem & "'"
            con.ConnDb()
            con.Open5()
            con.Command5(squery)
            dr = con.OpenDataReader5
            If dr.Read Then
                Me.cb.Text = UCase(dr.Item(Trim("fullname3")))
            End If
            dr.Close()
            con.Execute5()
            con.Close5()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/cb_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function templot() As String
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("select max(lotno) as lotno from asys_lotno_gen")
            dr = obj.OpenDataReader3
            If dr.Read Then
                templot = dr.Item("lotno")
            End If
            Me.cmbreflotno.Focus()
            dr.Close()
            obj.Execute3()
            obj.Close3()
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/templot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Try
            If Me.Label9.Text <> 0 Then
                Button6.Enabled = True
                btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/Label9_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frm As New frmSearchLotno
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCostCenter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostCenter.TextChanged
        Try
            If txtCostCenter.Text = "REM" And outsource = False Then
                Me.cmbreflotno.Visible = False
                Me.Label13.Visible = False
                btnLot.Visible = False
                btnLotNum.Visible = False
                lblBCode.Visible = False
                Me.Button5.Visible = True
                Me.btnPrint.Visible = False
                Button2.Visible = True
                Button3.Visible = True
                Button4.Visible = True
                'DgEntry.ReadOnly = True
                'DgEntry.Enabled = False
            ElseIf txtCostCenter.Text = "VIP" Then
                'DgEntry.Enabled = False
                'DgEntry.ReadOnly = True
                Me.Label13.Visible = True
                Me.cmbreflotno.Visible = False
                lblBCode.Visible = True
                Label4.Visible = False
                btnLot.Visible = False
                btnLotNum.Visible = False
            Else
                outsource = False
                Me.btnLot.Visible = True
                Me.btnLotNum.Visible = True
                Me.cmbreflotno.Visible = True
                Me.btnLotNum.Visible = True
                lblBCode.Visible = False
                Me.cmbreflotno.Visible = True
                Label4.Visible = True
                Me.Label13.Visible = False
                Me.cmbreflotno.Enabled = True
                Me.btnLotNum.Enabled = True
                Me.Button5.Visible = False
                Me.btnPrint.Visible = True
                Button2.Visible = False
                Button3.Visible = False
                Button4.Visible = False
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReleasing/txtCostCenter_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgEntry.Navigate

    End Sub

    Private Sub cmbreflotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflotno.SelectedIndexChanged

    End Sub
End Class
