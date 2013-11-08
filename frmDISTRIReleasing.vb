Imports System.Data.SqlClient
Imports System.IO
Public Class frmDISTRIReleasing
    Inherits System.Windows.Forms.Form
    Private WithEvents cmbItems As System.Windows.Forms.Label
    Private WithEvents cmbsource As System.Windows.Forms.Label
    Private WithEvents cmbbarcode As System.Windows.Forms.TextBox
    'textbox
    Private WithEvents txttext As System.Windows.Forms.Label
    Private WithEvents txtitemdesc As System.Windows.Forms.Label
    Private WithEvents txtgrams As System.Windows.Forms.Label
    Private WithEvents txtkarat As System.Windows.Forms.Label
    Private WithEvents txtcarat As System.Windows.Forms.Label
    Private WithEvents txtprice As System.Windows.Forms.Label
    Dim barcode As String
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
    Public xx As String
    Private WithEvents tm As New ContextMenu
    Private WithEvents ti As New NotifyIcon

    Private dt As DataTable
    Private dv As DataView
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Public pi_search_column As Integer
    Public ps_search_result As String
    Dim XMLFile As String
    Dim ShowALL As String
    Dim zonecode As String
    Dim serverDate As Date
    Dim consignBCCode As String
    Dim ConsignBCName As String
    Dim Upload As String

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents AsysReleasing As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtreflot As System.Windows.Forms.TextBox
    Friend WithEvents txtclear As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDISTRIReleasing))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lbl1FA01 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnLot = New System.Windows.Forms.Label
        Me.btnLotNum = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbreflotno = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.txtDateReleased = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtclear = New System.Windows.Forms.TextBox
        Me.cb = New System.Windows.Forms.ComboBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtreflot = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.AsysReleasing = New System.Windows.Forms.Label
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
        'lbl1FA01
        '
        Me.lbl1FA01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1FA01.Location = New System.Drawing.Point(864, 48)
        Me.lbl1FA01.Name = "lbl1FA01"
        Me.lbl1FA01.Size = New System.Drawing.Size(72, 16)
        Me.lbl1FA01.TabIndex = 107
        Me.lbl1FA01.Text = "1FA01 V5.2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Releaser"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "COST CENTER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "DATE RELEASED"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLot
        '
        Me.btnLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLot.Location = New System.Drawing.Point(56, 40)
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
        Me.btnLotNum.Location = New System.Drawing.Point(296, 32)
        Me.btnLotNum.Name = "btnLotNum"
        Me.btnLotNum.Size = New System.Drawing.Size(88, 24)
        Me.btnLotNum.TabIndex = 118
        Me.btnLotNum.Text = "ADD ROW"
        Me.btnLotNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "LOT NUMBER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbreflotno
        '
        Me.cmbreflotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreflotno.Location = New System.Drawing.Point(176, 64)
        Me.cmbreflotno.MaxLength = 10
        Me.cmbreflotno.Name = "cmbreflotno"
        Me.cmbreflotno.Size = New System.Drawing.Size(176, 21)
        Me.cmbreflotno.TabIndex = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDateReleased)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtclear)
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 128)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 135
        Me.TextBox1.Text = "DISTRIBUTION"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 24)
        Me.Label14.TabIndex = 132
        Me.Label14.Text = "USERNAME"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.BackColor = System.Drawing.Color.White
        Me.cmbCostCenter.ItemHeight = 13
        Me.cmbCostCenter.Location = New System.Drawing.Point(128, 56)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(208, 21)
        Me.cmbCostCenter.TabIndex = 113
        '
        'txtDateReleased
        '
        Me.txtDateReleased.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDateReleased.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateReleased.Location = New System.Drawing.Point(128, 80)
        Me.txtDateReleased.Name = "txtDateReleased"
        Me.txtDateReleased.Size = New System.Drawing.Size(208, 20)
        Me.txtDateReleased.TabIndex = 127
        Me.txtDateReleased.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Label6"
        '
        'txtclear
        '
        Me.txtclear.Location = New System.Drawing.Point(160, 56)
        Me.txtclear.Name = "txtclear"
        Me.txtclear.Size = New System.Drawing.Size(40, 20)
        Me.txtclear.TabIndex = 134
        Me.txtclear.Text = ""
        '
        'cb
        '
        Me.cb.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb.Location = New System.Drawing.Point(128, 32)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(208, 21)
        Me.cb.TabIndex = 128
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.Color.White
        Me.txtuser.Location = New System.Drawing.Point(128, 32)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(208, 20)
        Me.txtuser.TabIndex = 133
        Me.txtuser.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtreflot)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.btnLot)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnLotNum)
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
        Me.btnSearch.Location = New System.Drawing.Point(360, 64)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 148
        Me.btnSearch.Text = "...."
        '
        'txtreflot
        '
        Me.txtreflot.BackColor = System.Drawing.Color.White
        Me.txtreflot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreflot.Location = New System.Drawing.Point(176, 32)
        Me.txtreflot.Name = "txtreflot"
        Me.txtreflot.Size = New System.Drawing.Size(104, 20)
        Me.txtreflot.TabIndex = 147
        Me.txtreflot.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(48, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 24)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "TEMP LOT NUMBER"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(640, 528)
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
        Me.btnPrint.Location = New System.Drawing.Point(800, 528)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnPrint.TabIndex = 125
        Me.btnPrint.Text = "Print F20"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.Visible = False
        '
        'DgEntry
        '
        Me.DgEntry.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackgroundColor = System.Drawing.Color.Tan
        Me.DgEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgEntry.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'AsysReleasing
        '
        Me.AsysReleasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsysReleasing.Location = New System.Drawing.Point(776, 16)
        Me.AsysReleasing.Name = "AsysReleasing"
        Me.AsysReleasing.Size = New System.Drawing.Size(160, 24)
        Me.AsysReleasing.TabIndex = 106
        Me.AsysReleasing.Text = "ASYS Releasing"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(880, 528)
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
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(800, 528)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 40)
        Me.Button5.TabIndex = 132
        Me.Button5.Text = "PRINT F20"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 24)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "TOTAL NO. OF ITEMS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(160, 528)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 24)
        Me.Label9.TabIndex = 134
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(744, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Label10"
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(720, 528)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 40)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "DELETE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(624, 512)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 64)
        Me.GroupBox4.TabIndex = 137
        Me.GroupBox4.TabStop = False
        '
        'frmDISTRIReleasing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 582)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDISTRIReleasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISTRIBUTION RELEASING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(9) {"NO.", "PTN", "A.L.L. BARCODE   ", "ITEM SOURCE ", "DESCRIPTION", "WEIGHT", "KARAT", "CARAT", "PRICE", " "}

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
                Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 75
                colStyle(1).Width = 90
                colStyle(2).Width = 115
                colStyle(3).Width = 90
                colStyle(4).Width = 275
                colStyle(5).Width = 65
                colStyle(6).Width = 65
                colStyle(7).Width = 65
                colStyle(8).Width = 85
                colStyle(8).Alignment = HorizontalAlignment.Right
                colStyle(9).Width = 60


                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                txttext = New Label
                txttext.Width = 160



                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                cmdDelete.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtitemdesc)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtgrams)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtkarat)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtcarat)
                txttext.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtprice)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

            End If
            'Take the text box from the second column of the grid where u will be adding the controls of your choice	
        Catch ex As Exception

        End Try
    End Sub

    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim strLotnO, kani As String
            Dim objclass As New clsCommon
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String


            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select lotno from ASYS_LOTNO_Gen")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            objclass.Close3()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/GenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    'Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    '    'DgEntry.Enabled = True
    'End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            If Not ab_isEmpty Then
                dataTable.Rows.RemoveAt(hi.Row)
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/deleteRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try

            Dim hi As DataGrid.HitTestInfo
            'barcode = cmbbarcode.Text
            'MsgBox(cmbbarcode.Text)
            'Dim pt = New Point(e.X, e.Y)
            'Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)

            'hi = DgEntry.HitTest(e.X, e.Y)

            'If hi.Column = 0 Then
            '    DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            '    DgEntry.Select(hit.Row)
            'End If

            'Dim repz As String
            'repz = MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.YesNo)
            'If repz = vbYes Then
            '    If hi.Column = 9 And hi.Row >= 0 Then
            '        If DgEntry(hi.Row, 1) <> "" Then
            '            deleteRow(hi, False)
            '        Else
            '            deleteRow(hi, True)
            '        End If
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
                        If dataTable.Rows.Count = 0 Then
                            Me.btnLotNum.Enabled = True
                            Me.btnSave.Enabled = False
                        End If
                        If dataTable.Rows.Count = 0 And cmbbarcode.Text = "" Then
                            Me.btnLotNum.Enabled = True
                            Me.btnSave.Enabled = False
                        End If
                    Else
                        Exit Sub
                    End If
                    If Label9.Text = "0" Then
                        Me.btnSave.Enabled = False
                        Me.Button6.Enabled = False
                    End If
                Else
                    Exit Sub
                End If

                If dataTable.Rows.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To dataTable.Rows.Count - 1
                        DgEntry(i, 0) = i + 1
                    Next
                End If

                DgEntry.Focus()
                Me.cmbbarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/dgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub releaseoutsourceitems()
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

            ConnectDB1()

            Dim dm As New SqlClient.SqlDataAdapter("select allbarcode,ptn from (SELECT distinct ALLBarcode_for as allbarcode,ptn_for as ptn from tbl_ForcedOUtRcv where Lotno_for='" & cmbreflotno.Text & "' and recname_for = '" & Trim(Me.cb.Text) & "' and sortaction_id_for = 4 and forcedout_status_for in (3,1) and DeptStatus_for ='0' union all SELECT distinct recALLBarcode as allbarcode,recptn as ptn from tbl_receiving_header where recLotno='" & cmbreflotno.Text & "' and recname = '" & Trim(Me.cb.Text) & "' and sortaction_id = 4 and status_id = 3 and DeptStatus ='0') a ", cn)
            ds_dataset.Clear()
            dm.Fill(ds_dataset, "allbarcode")

            For a = 0 To ds_dataset.Tables(0).Rows.Count - 1
                Try
                    cmbItems = New Label
                    cmbItems.Width = 150

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
                        DgEntry(li_row, 9) = "DELETE"
                    End If

                    DgEntry(li_row, 0) = ""
                    DgEntry(li_row, 1) = ds_dataset.Tables(0).Rows(a).Item(0)
                    DgEntry(li_row, 2) = ds_dataset.Tables(0).Rows(a).Item(1)
                    DgEntry(li_row, 3) = ""
                    DgEntry(li_row, 4) = ""
                    DgEntry(li_row, 5) = ""
                    DgEntry(li_row, 6) = ""
                    DgEntry(li_row, 7) = ""
                    DgEntry(li_row, 8) = ""
                    DgEntry(li_row, 9) = "DELETE"



                    DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                    DgEntry.Focus()



                    squery = "If (Select Count(*) from tbl_receiving_header where recallbarcode ='" & DgEntry(li_row, 1) & "' and status_id in (1,3)) = 0 begin SELECT Allbarcode_for from tbl_forcedoutrcv where allbarcode_for ='" & DgEntry(li_row, 1) & "' end else SELECT recAllbarcode from tbl_receiving_header where recallbarcode ='" & DgEntry(li_row, 1) & "'"

                    conn = New clsCommon
                    conn.Connectionstring3()
                    conn.Open3()
                    conn.Command3(squery)
                    dr1 = conn.OpenDataReader3
                    temp = DgEntry(li_row, 1)
                    i = 1
                    While dr1.Read
                        DgEntry(DgEntry.CurrentCell.RowNumber, DgEntry.CurrentCell.ColumnNumber - 1) = i
                        i += 1
                    End While
                    dr1.Close()
                    conn.Execute3()
                    conn.Close3()
                    conn = Nothing

                    con = New clsCommon
                    con.Connectionstring3()
                    con.Open3()
                    squery2 = "If (Select Count(*) from tbl_receiving_header where reclotno = '" & Me.cmbreflotno.Text & "' and recallbarcode ='" & temp & "') = 0 begin SELECT Allbarcode_dfor as allbarcode,ptnitemdesc_dfor as itemdesc,all_desc_dfor as all_desc,all_karat_dfor as all_karat,all_carat_dfor as all_carat,all_wt_dfor as all_wt,weight_dfor as weight,karatgrading_dfor as karatgrading,caratsize_dfor as caratsize,all_valuecost_dfor as all_valuecost,price_desc_dfor as price_desc,price_karat_dfor as price_karat,price_carat_dfor as price_carat,price_weight_dfor as price_weight,all_price_dfor as all_price from tbl_forcedoutrcv_detail where lotno_dfor ='" & Me.cmbreflotno.Text & "' and allbarcode_dfor ='" & temp & "' end else SELECT dAllbarcode as allbarcode,ptnitemdesc as itemdesc, all_desc,all_karat, all_carat, all_wt,weight,karatgrading,caratsize,all_valuecost,price_desc,price_karat,price_carat,price_weight,all_price from tbl_receiving_detail where dlotno = '" & Me.cmbreflotno.Text & "' and dallbarcode ='" & temp & "'"
                    con.Command3(squery2)
                    dr = con.OpenDataReader3
                    While dr.Read

                        If DgEntry(li_row, 0) = "NO." Then
                            DgEntry(li_row, 0) = ""
                        End If
                        If con.IsNull(dr.Item("all_price")) = "0" Then
                            DgEntry(li_row, 1) = con.IsNull(dr.Item("ALLBarcode"))
                            DgEntry(li_row, 4) = con.IsNull(dr.Item("all_desc"))
                            DgEntry(li_row, 5) = con.IsNull(dr.Item("all_wt"))
                            DgEntry(li_row, 6) = con.IsNull(dr.Item("all_karat"))
                            DgEntry(li_row, 7) = con.IsNull(dr.Item("all_carat"))
                            DgEntry(li_row, 8) = con.IsNull(dr.Item("all_valuecost"))
                        Else
                            DgEntry(li_row, 1) = con.IsNull(dr.Item("ALLBarcode"))
                            DgEntry(li_row, 4) = con.IsNull(dr.Item("price_desc"))
                            DgEntry(li_row, 5) = con.IsNull(dr.Item("price_weight"))
                            DgEntry(li_row, 6) = con.IsNull(dr.Item("price_karat"))
                            DgEntry(li_row, 7) = con.IsNull(dr.Item("price_carat"))
                            DgEntry(li_row, 8) = con.IsNull(dr.Item("all_price"))

                        End If

                        dataTable.LoadDataRow(arrstr, True)

                        li_row += 1

                        DgEntry(li_row, 0) = ""
                        DgEntry(li_row, 1) = ""
                        DgEntry(li_row, 2) = ""
                        DgEntry(li_row, 3) = ""
                        DgEntry(li_row, 4) = ""
                        DgEntry(li_row, 5) = ""
                        DgEntry(li_row, 6) = ""
                        DgEntry(li_row, 7) = ""
                        DgEntry(li_row, 8) = ""
                        DgEntry(li_row, 9) = "DELETE"

                    End While

                    dataTable.LoadDataRow(arrstr, True)
                    li_row += 1

                    If DgEntry(li_row, 0) = "NO." And DgEntry(li_row, 1) = "ALLBarcode" Then

                        DgEntry(li_row, 0) = ""
                        DgEntry(li_row, 1) = ""
                        DgEntry(li_row, 2) = ""
                        DgEntry(li_row, 3) = ""
                        DgEntry(li_row, 4) = ""
                        DgEntry(li_row, 5) = ""
                        DgEntry(li_row, 6) = ""
                        DgEntry(li_row, 7) = ""
                        DgEntry(li_row, 8) = ""
                        DgEntry(li_row, 9) = "DELETE"

                        If li_row = dataTable.Rows.Count Then
                        Else
                            dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber + 1))
                        End If

                    End If

                    dr.Close()
                    con.Execute3()
                    con.Close3()
                    con = Nothing

                Catch ex As Exception
                    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                    Exit For
                End Try

            Next

            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 0 To dataTable.Rows.Count
                    If u >= dataTable.Rows.Count Then
                        u = u - 1
                        If ((Me.DgEntry(u, 0) = "NO." Or Me.DgEntry(u, 0) = "") And Me.DgEntry(u, 1) = "A.L.L Barcode" And Me.DgEntry(u, 2) = "PTN") Then
                            dataTable.Rows.Remove(dataTable.Rows(u))
                            Exit For
                        End If

                    End If
                    If Me.DgEntry(u, 0) = "" And Me.DgEntry(u, 1) = "" Then
                        dataTable.Rows.Remove(dataTable.Rows(u))
                    End If
                Next
            End If


            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 1 To dataTable.Rows.Count
                    If Me.DgEntry(u - 1, 1) = "" Then
                        u += 1
                    Else
                        DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 1), 4, 5)
                    End If
                Next
            End If


            DgEntry.CurrentCell = New DataGridCell(li_row, 0)
            DgEntry.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/releaseoutsourceitems: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub releaseForceitems()
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

            ConnectDB()

            ds_dataset.Reset()

            Dim dm As New SqlClient.SqlDataAdapter("SELECT distinct PTN_for from tbl_ForcedOUtRcv where Lotno_for='" & Me.cmbreflotno.Text & "' and sortaction_id_for = 4 and forcedout_status_for = 3 and DeptStatus_for ='0'", cn)
            ds_dataset.Clear()
            dm.Fill(ds_dataset, "tbl_ForcedOUtRcv")

            For a = 0 To ds_dataset.Tables(0).Rows.Count - 1
                Try
                    cmbItems = New Label
                    cmbItems.Width = 150

                    If li_row = 0 Then
                        dataTable.LoadDataRow(arrstr, True)
                    Else
                        'dataTable.LoadDataRow(arrstr, True)

                        DgEntry(li_row, 0) = ""
                        DgEntry(li_row, 1) = ""
                        DgEntry(li_row, 2) = ""
                        DgEntry(li_row, 3) = ""
                        DgEntry(li_row, 4) = ""
                        DgEntry(li_row, 5) = ""
                        DgEntry(li_row, 6) = ""
                        DgEntry(li_row, 7) = ""
                        DgEntry(li_row, 8) = ""
                        DgEntry(li_row, 9) = "DELETE"
                    End If

                    DgEntry(li_row, 0) = ""
                    DgEntry(li_row, 1) = ""
                    DgEntry(li_row, 2) = ds_dataset.Tables(0).Rows(a).Item(0)
                    DgEntry(li_row, 3) = ""
                    DgEntry(li_row, 4) = ""
                    DgEntry(li_row, 5) = ""
                    DgEntry(li_row, 6) = ""
                    DgEntry(li_row, 7) = ""
                    DgEntry(li_row, 8) = ""
                    DgEntry(li_row, 9) = "DELETE"

                    DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                    DgEntry.Focus()



                    squery = "SELECT dbo.tbl_PTN_Item.MPTN FROM dbo.tbl_PT_Tran INNER JOIN dbo.tbl_PTN_Item ON dbo.tbl_PT_Tran.MPTN = dbo.tbl_PTN_Item.MPTN WHERE dbo.tbl_PT_Tran.PTN ='" & DgEntry(li_row, 2) & "'"
                    conn.ConnectionString1()
                    conn.Open()
                    conn.Command(squery)
                    dr1 = conn.OpenDataReader
                    temp = DgEntry(li_row, 2)
                    i = 1
                    While dr1.Read
                        DgEntry(DgEntry.CurrentCell.RowNumber, DgEntry.CurrentCell.ColumnNumber - 1) = i
                        i += 1
                    End While
                    dr1.Close()
                    conn.Execute()
                    conn.Close()

                    con.ConnectionString2()
                    con.Open2()
                    squery2 = "Select * from tbl_ForcedOutRcv_detail where lotno_dfor = '" & Me.cmbreflotno.Text & "' and PTN_dfor='" & temp & "'"
                    con.Command2(squery2)
                    dr = con.OpenDataReader2
                    While dr.Read

                        If DgEntry(li_row, 0) = "NO." Then
                            DgEntry(li_row, 0) = ""
                        End If
                        DgEntry(li_row, 1) = con.IsNull(dr.Item("ALLBarcode_dfor"))
                        DgEntry(li_row, 4) = con.IsNull(dr.Item("ptnitemdesc_dfor"))
                        DgEntry(li_row, 5) = con.IsNull(dr.Item("weight_dfor"))
                        DgEntry(li_row, 6) = con.IsNull(dr.Item("karatgrading_dfor"))
                        DgEntry(li_row, 7) = con.IsNull(dr.Item("caratsize_dfor"))
                        DgEntry(li_row, 8) = con.IsNull(dr.Item("all_valuecost_dfor"))
                        dataTable.LoadDataRow(arrstr, True)

                        li_row += 1

                        DgEntry(li_row, 0) = ""
                        DgEntry(li_row, 1) = ""
                        DgEntry(li_row, 2) = ""
                        DgEntry(li_row, 3) = ""
                        DgEntry(li_row, 4) = ""
                        DgEntry(li_row, 5) = ""
                        DgEntry(li_row, 6) = ""
                        DgEntry(li_row, 7) = ""
                        DgEntry(li_row, 8) = ""
                        DgEntry(li_row, 9) = "DELETE"
                    End While

                    dataTable.LoadDataRow(arrstr, True)
                    li_row += 1

                    If DgEntry(li_row, 0) = "NO." And DgEntry(li_row, 1) = "ALLBarcode" Then

                        DgEntry(li_row, 0) = ""
                        DgEntry(li_row, 1) = ""
                        DgEntry(li_row, 2) = ""
                        DgEntry(li_row, 3) = ""
                        DgEntry(li_row, 4) = ""
                        DgEntry(li_row, 5) = ""
                        DgEntry(li_row, 6) = ""
                        DgEntry(li_row, 7) = ""
                        DgEntry(li_row, 8) = ""
                        DgEntry(li_row, 9) = "DELETE"
                        If li_row = dataTable.Rows.Count Then
                        Else
                            dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber + 1))
                        End If

                    End If

                    dr.Close()
                    con.Execute2()
                    con.Close2()

                Catch ex As Exception
                    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                    Exit For
                End Try
            Next


            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 0 To dataTable.Rows.Count
                    If u >= dataTable.Rows.Count Then
                        u = u - 1
                        If ((Me.DgEntry(u, 0) = "NO." Or Me.DgEntry(u, 0) = "") And Me.DgEntry(u, 2) = "A.L.L Barcode" And Me.DgEntry(u, 1) = "PTN") Then
                            dataTable.Rows.Remove(dataTable.Rows(u))
                            Exit For
                        End If

                    End If
                    If Me.DgEntry(u, 0) = "" And Me.DgEntry(u, 1) = "" Then
                        dataTable.Rows.Remove(dataTable.Rows(u))
                    End If
                Next
            End If


            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 1 To dataTable.Rows.Count
                    If Me.DgEntry(u - 1, 1) = "" Then
                        u += 1
                    Else
                        DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 1), 4, 5)
                    End If
                Next
            End If


            DgEntry.CurrentCell = New DataGridCell(li_row, 0)
            DgEntry.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/releaseForceitems: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

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


            dataTable.Rows.Clear()
            dataTable.Clear()
            con.Connectionstring3()
            con.Open3()
            con.Command3("select ptn,Barcode as 'refallbarcode',Description as 'price_desc',Karat as 'price_karat',carat as 'price_carat',grams as 'price_weight',price as 'all_price' from ASYS_GetConsignDetails where lotno = '" & Me.cmbreflotno.Text & "'")
            dr1 = con.OpenDataReader3
            While dr1.Read

                cmbbarcode = New TextBox
                cmbbarcode.Width = 161

                Dim li_rowd As Integer = dataTable.Rows.Count
                dataTable.LoadDataRow(arrstr, True)

                DgEntry(li_rowd, 0) = li_rowd + 1
                If Trim(dr1.Item("PTN")).ToString.Length = 1 Then
                    DgEntry(li_rowd, 1) = Trim(dr1.Item("PTN"))
                Else
                    DgEntry(li_rowd, 1) = Trim(dr1.Item("PTN")).ToString.PadLeft(12, "0")
                End If

                DgEntry(li_rowd, 2) = dr1.Item("refallbarcode")

                DgEntry(li_rowd, 3) = ""
                DgEntry(li_rowd, 4) = con.IsNull(dr1.Item("price_desc"))
                DgEntry(li_rowd, 5) = con.IsNull(dr1.Item("price_weight"))
                DgEntry(li_rowd, 6) = con.IsNull(dr1.Item("price_karat"))
                DgEntry(li_rowd, 7) = con.IsNull(dr1.Item("price_carat"))
                DgEntry(li_rowd, 8) = FormatNumber(con.IsNull(dr1.Item("all_price")))
                DgEntry(li_rowd, 9) = "DELETE"

                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()

                If Me.DgEntry.VisibleRowCount > 0 Then
                    For u = 1 To dataTable.Rows.Count
                        If Me.DgEntry(u - 1, 2) = "" Then
                            u += 1
                        Else
                            DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 2), 4, 5)
                        End If
                    Next
                End If

                cmbsource = New Label
                cmbsource.Width = 161

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbsource)
                cmbsource.BringToFront()

                'dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                'dgtb.TextBox.Controls.Add(cmbItems)
                'cmbItems.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbbarcode)
                cmbbarcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.ForeColor = ForeColor.Red
                cmdDelete.BringToFront()
                Me.btnSave.Enabled = True

            End While
            dr1.Close()
            con.Execute3()
            con.Close3()

            'MsgBox("A")
            'If Me.DgEntry.VisibleRowCount > 0 Then
            '    For u = 0 To dataTable.Rows.Count
            '        If u >= dataTable.Rows.Count Then
            '            u = u - 1
            '            If ((Me.DgEntry(u, 0) = "NO." Or Me.DgEntry(u, 0) = "") And Me.DgEntry(u, 1) = "A.L.L Barcode" And Me.DgEntry(u, 2) = "PTN") Then
            '                dataTable.Rows.Remove(dataTable.Rows(u))
            '                Exit For
            '            End If

            '        End If
            '        If Me.DgEntry(u, 0) = "" And Me.DgEntry(u, 1) = "" Then
            '            dataTable.Rows.Remove(dataTable.Rows(u))
            '            'Exit For
            '        End If
            '    Next
            'End If


            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 0 To dataTable.Rows.Count - 1
                    If u >= dataTable.Rows.Count Then
                        Exit For
                    End If
                    If Me.DgEntry(u, 0) = "" And Me.DgEntry(u, 1) = "" And Me.DgEntry(u, 2) = "" And Me.DgEntry(u, 3) = "" Then
                        dataTable.Rows.Remove(dataTable.Rows(u))
                    End If
                Next
            End If



            If Me.DgEntry.VisibleRowCount > 0 Then
                For u = 1 To dataTable.Rows.Count
                    If Me.DgEntry(u - 1, 2) = "" Then
                        u += 1
                    Else
                        DgEntry(u - 1, 3) = Mid(Me.DgEntry(u - 1, 2), 4, 5)
                    End If
                Next
            End If

            DgEntry.CurrentCell = New DataGridCell(li_row, 0)
            DgEntry.Focus()
            con = Nothing
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/addrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/NextPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/isPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/decryptPass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                MsgBox(Ee.Message, , TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                ElseIf sDB = "Vismin" Then
                    Key_Server1 = "[ServerV]="
                    Key_DataBase1 = "[DataBaseV]="
                    Key_User1 = "[UserV]="
                    Key_Pass1 = "[PasswordV]="
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

            ConnectDB = True
        Catch ex As Exception
            ConnectDB = False
            MsgBox("frmDISTRIReleasing/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Sub frmDISTRIReleasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.cmbCostCenter.Text = "DISTRI"
            Me.cmbCostCenter.Enabled = False
            force = False
            outsource = False
            Button5.Visible = True
            Call valEmp()
            Call CallCostCenter()
            'Call pao()
            'Call releaser()
            Call GenerateLot()
            'Me.cb.Text = fullname2
            txtDateReleased.ReadOnly = True
            txtDateReleased.BackColor = Color.White
            'Call strdate()
            lotnorefresh()
            txtDateReleased.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            cmbCostCenter.Text = MainCost
            Me.cmbCostCenter.BackColor = Color.White
            Me.Label13.Visible = True
            Me.txtreflot.ReadOnly = True
            Me.txtreflot.BackColor = Color.White
            Me.txtreflot.Text = GetNewLotNumber("DISTRI", "") ' GenerateLot()
            Me.btnLotNum.Visible = True
            Me.cmbreflotno.Enabled = True
            Me.btnLotNum.Enabled = True
            Me.cb.Visible = False
            Me.Label1.Visible = False
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.BackColor = Color.White
            btnSave.Enabled = False
            Button6.Enabled = False
            Me.cmbreflotno.Focus()
            Me.cmbreflotno.Select()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/frmDISTRIReleasing_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CallCostCenter()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If sDB = "" Then
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3("Select * from vw_CostCenter")
                dr = obj.OpenDataReader3
                While dr.Read
                    cmbCostCenter.Items.Add(dr.Item("CostDept"))
                End While
                dr.Close()
                obj.Execute3()
                obj.Close3()
            Else
                obj.ConnectionString1()
                obj.Open()
                obj.Command("Select * from tbl_CostCenter")
                dr = obj.OpenDataReader
                While dr.Read
                    cmbCostCenter.Items.Add(dr.Item("CostDept"))
                End While
                dr.Close()
                obj.Execute()
                obj.Close()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/CallCostCenter: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub valEmp()
        Try
            Me.txtuser.Text = UCase(fullname)
            Me.txtuser.ReadOnly = True
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/valEmp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function releaser()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("select  fullname as fullname2, * from rems.dbo.vw_humresvismin where job_title like 'distri%' order by fullname asc")
            dr = obj.OpenDataReader5
            While dr.Read
                Me.cb.Items.Add(UCase(dr.Item("fullname2")))
            End While
            Me.cb.Focus()
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/releaser: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Public Function center()
        Try
            If Me.cmbCostCenter.Text = "REM" Then
                center = "REM"
            End If

            If Me.cmbCostCenter.Text = "MLWB" Then
                center = "MLWB"
            End If

            If Me.cmbCostCenter.Text = "PRICING" Then
                center = "PRICING"
            End If

            If Me.cmbCostCenter.Text = "DISTRI" Then
                center = "DISTRI"
            End If
            If Me.cmbCostCenter.Text = "SHOWROOM" Or Me.cmbCostCenter.Text = "VIP" Then
                Exit Function
            End If

        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/center: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub lotnorefresh()
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim generatelot As String

            If Me.cmbCostCenter.Text = "DISTRI" Then
                dataTable.Rows.Clear()
                Me.cmbreflotno.Items.Clear()
                con.Connectionstring3()
                con.Open3()
                con.Command3("select distinct(lotno) as reflotno from ASYS_GetConsignDetails  order by reflotno desc")
                dr = con.OpenDataReader3
                While dr.Read
                    cmbreflotno.Items.Add(Trim(dr.Item("reflotno")))
                End While
                dr.Close()
                con.Close3()
            End If
            Me.cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/lotnorefresh: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            dr.Close()
        End Try
    End Sub

    Private Sub cmbEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Me.cmbCostCenter.Focus()
            ElseIf e.KeyCode = Keys.Tab Then
                Me.cmbCostCenter.Focus()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbEmployee_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCostCenter.KeyPress
        Try

            Dim con As New clsCommon
            Dim dr As SqlDataReader
            If e.KeyChar = ChrW(13) Then
                Dim fr As New frmMain
                If UCase(job_title) = "SORTER" Then
                    If cmbCostCenter.Text <> "REM" Then
                        MsgBox("You dont have the right to access!", MsgBoxStyle.Exclamation, TitleMsgBox)
                        cmbCostCenter.Text = "REM"
                        Exit Sub
                    Else
                        'ComboBox1.Focus()
                        Me.cmbreflotno.Focus()
                    End If
                Else
                    If cmbCostCenter.Text = "REM" Or cmbCostCenter.Text = "VIP" Then
                        If sDB = "" Then
                            If outsource = False Then
                                sDB = myregion
                            End If
                        Else
                            'ComboBox1.Focus()
                            Me.cmbreflotno.Focus()
                        End If
                    Else
                        sDB = ""
                        fr.Text = "ASYS 5.0"
                    End If
                End If
            End If
            If Me.cmbCostCenter.Text = "PRICING" Then
                dataTable.Rows.Clear()
                Me.cmbreflotno.Items.Clear()
                con.Connectionstring3()
                con.Open3()
                con.Command3("Select distinct reflotno from asys_PRICING_detail where status = 'received'")
                dr = con.OpenDataReader3
                While dr.Read
                    Me.cmbreflotno.Items.Add(dr.Item("reflotno"))
                End While
                dr.Close()
                con.Execute3()
                con.Close3()

            End If
            If Me.cmbCostCenter.Text = "DISTRI" Then
                dataTable.Rows.Clear()
                Me.cmbreflotno.Items.Clear()
                con.Connectionstring3()
                con.Open3()
                con.Command3("Select distinct LOTno_rec from tbl_recrel_DISTRI where status_id_rec = 3 ")
                dr = con.OpenDataReader3
                While dr.Read
                    Me.cmbreflotno.Items.Add(dr.Item("lotno_rec"))
                End While
                dr.Close()
                con.Execute3()
                con.Close3()

            End If
            If cmbCostCenter.Text = "VIP" Then
                'ComboBox3.Focus()
            End If

            Me.cmbreflotno.Text = ""
            Me.cb.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbCostCenter_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub SeeIFReturn()
        Dim obj As New clsCommon
        Dim obj1 As New clsCommon
        Dim dr As SqlDataReader

        Try

            Dim str As String

            Dim i As Integer

            Me.txtreflot.Text = GenerateLot()

            obj1 = New clsCommon
            obj1.Connectionstring4()
            obj1.Open4()

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            If cmbCostCenter.Text = "MLWB" Then
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select * from asys_PRICING_detail where refallbarcode = '" & DgEntry(i, 2) & "'" ' interchanged 
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        obj1.Command3("Update asys_MLWB_header set lotno= '" & cmbreflotno.Text & "', employee = '" & cb.Text & "' where lotno = '" & cmbreflotno.Text & "'")
                        obj1.Execute3()
                        obj1.Command3("UPdate asys_MLWB_detail set lotno= '" & Label10.Text & "', reflotno='" & cmbreflotno.Text & "', status = 'released' where refallbarcode = '" & DgEntry(i, 2) & "'")
                        obj1.Execute3()

                        str = " update rems.dbo.asys_remoutsource_detail set status = 'released' where refallbarcode = '" & DgEntry(i, 2) & "'"
                        obj1.Command3(str)
                        obj1.Execute3()

                        str = " update remsluzon.dbo.asys_remoutsource_detail set status = 'released' where refallbarcode = '" & DgEntry(i, 2) & "'"
                        obj1.Command3(str)
                        obj1.Execute3()

                        str = "update remsvismin.dbo.asys_remoutsource_detail set status = 'released' where refallbarcode = '" & DgEntry(i, 2) & "'"
                        obj1.Command3(str)
                        obj1.Execute3()
                        obj1.Close4()

                        relbleh = True
                    Else
                        relbleh = False
                    End If
                    dr.Close()
                Next
                obj.Close3()
                obj = Nothing
            ElseIf cmbCostCenter.Text = "PRICING" Then
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select * from asys_DISTRI_detail where refallbarcode = '" & DgEntry(i, 2) & "'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        obj1.Command4("Update asys_PRiCING_header set lotno= '" & cmbreflotno.Text & "', employee = '" & Me.txtuser.Text & "' where refallbarcode = '" & DgEntry(i, 2) & "'")
                        obj1.Execute4()
                        obj1.Command4("UPdate asys_PRICING_detail set lotno= '" & cmbreflotno.Text & "', releasedate = getdate(), status = 'RELEASED'  where refallbarcode = '" & DgEntry(i, 2) & "'")
                        obj1.Execute4()
                        relbleh = True
                    Else
                        relbleh = False
                    End If
                    dr.Close()
                Next
                obj.Close3()
                obj = Nothing
            ElseIf cmbCostCenter.Text = "DISTRI" Then
                Dim templot, tempref, tempa As String
                templot = GenerateLot()
                tempref = Me.cmbreflotno.Text
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select * from asys_Consign_detail where allbarcode = '" & DgEntry(i, 2) & "'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then

                        obj1.Command4("Update asys_DISTRI_header set lotno = '" & cmbreflotno.Text & "', Employee ='" & Me.txtuser.Text & "' where refallbarcode = '" & DgEntry(i, 2) & "'")
                        obj1.Execute4()
                        obj1.Command4("UPdate asys_DISTRI_detail set reflotno = '" & cmbreflotno.Text & "', lotno = '" & cmbreflotno.Text & "', datereleased = getdate(), releaser = '" & Me.cb.SelectedItem & "', status  = 'RELEASED'  where refallbarcode = '" & DgEntry(i, 2) & "'")
                        obj1.Execute4()
                        obj1.Close4()

                        relbleh = True
                    Else
                        relbleh = False
                    End If
                    dr.Close()
                Next
                obj.Close3()
                obj = Nothing
            End If

            If relbleh = True Then
                MsgBox("ALLBARCODE RELEASED.", MsgBoxStyle.Information, TitleMsgBox)
                dataTable.Clear()
            End If

        Catch ex As Exception
            dr.Close()
            obj1.Close4()
            obj1 = Nothing
            obj = Nothing
            MsgBox("frmDISTRIReleasing/SeeIFReturn: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    '''end here
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objclass As New clsCommon

        Try
            Dim rply As Integer
            Dim sqlinsert, sqlinsert1, sqlinsert2, squery1, sqlinsert3, squery, squery2, temps, temp, msg, m, l, p, w, templot, tempref As String
            Dim a, b, c, d, i, z As Integer
            Dim cn As New clsCommon
            Dim dr, dr1, dr3 As SqlDataReader
            Dim obj As New clsCommon

            Dim reflotno As String
            Dim li_rowd As Integer = dataTable.Rows.Count

            rply = MsgBox("Are you sure you want to release this data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then

                objclass = New clsCommon
                objclass.Connectionstring4()
                objclass.Opentracker3()
                objclass.CreateCom()

                If Me.cmbCostCenter.Text = "DISTRI" Then
                    If Me.DgEntry.VisibleRowCount > 0 Then
                        reflotno = GetNewLotNumber("DISTRI", "") 'GenerateLot()
                        distrilot = txtreflot.Text
                        txtreflot.Text = reflotno

                        squery = "update asys_lotno_gen set lotno ='" & reflotno & "' WHERE BusinessCenter ='DISTRI'"
                        objclass.commandTrack(squery)
                        objclass.TrackExecute()

                        For a = 0 To dataTable.Rows.Count - 1
                            sqlinsert2 = "insert into rems.dbo.asys_barcodehistory (lotno, refallbarcode, allbarcode, itemcode, itemid, [description], karat, carat, SerialNo, weight, currency, price, cost, empname, custodian, trandate, costcenter, consignto, status) select '" & reflotno & "', '" & DgEntry.Item(a, 2) & "', '" & DgEntry.Item(a, 2) & "', refitemcode, itemid, price_desc, price_karat, price_carat, SerialNo, price_weight, currency, all_price, all_price, '" & Me.txtuser.Text & "', '" & Me.cb.SelectedItem & "', getdate(), 'DISTRI', 'NULL', 'RELEASED' from asys_DISTRI_detail where refallbarcode = '" & DgEntry.Item(a, 2) & "' and status = 'CONSIGNED'"
                            objclass.commandTrack(sqlinsert2)
                            objclass.TrackExecute()

                            sqlinsert = "update asys_DISTRI_detail Set reflotno ='" & reflotno & "', releasedate = getdate(), releaser = '" & userLog & "', custodian = '" & Me.cb.Text & "', status = 'RELEASED' where refallbarcode ='" & DgEntry.Item(a, 2) & "' and status = 'CONSIGNED'"
                            objclass.commandTrack(sqlinsert)
                            objclass.TrackExecute()

                        Next
                    Else
                        MsgBox("Pls Add Details on the data grid.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If
                    xx = reflotno
                End If
            Else
                Exit Sub
            End If

            'Dim XMLDBFilename As String

            'XMLDBFilename = GetXMLFilename(cmbreflotno.Text)

            If GetXMLFilename(cmbreflotno.Text) = True Then
                'fnGetZoneCode(consignBCCode, ConsignBCName)
                If GetXMLPatch(cmbreflotno.Text) = True Then
                    GC.Collect()
                    File.Copy(XMLSource & XMLFile, CreateDestination & XMLFile, True)
                    MsgBox("XML File successfully UPLOADED", MsgBoxStyle.Information, TitleMsgBox)
                    sqlinsert = "UPDATE REMS.DBO.ASYS_CONSIGN_HEADER SET IsUpload = 1 WHERE LOTNO = '" & cmbreflotno.Text & "'"
                    objclass.commandTrack(sqlinsert)
                    objclass.TrackExecute()

                End If
            End If

            objclass.CommitTrack()
            MsgBox("Successfully released from DISTRI.", MsgBoxStyle.Information, TitleMsgBox)
            cmbreflotno.Text = ""
            Label9.Text = 0
            btnSave.Enabled = False
            cmbreflotno.Focus()

            Call lotnorefresh()
            dataTable.Rows.Clear()
            Me.ListView1.Items.Clear()
            bleh = False

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmDISTRIReleasing/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objclass.Close()
            objclass = Nothing
        End Try
    End Sub
    Private Function fnGetZoneCode(ByVal bCCode As String, ByVal bcname As String) As Boolean
        Dim objclass1 As New clsCommon
        Dim dr As SqlDataReader

        fnGetZoneCode = False
        If cmbreflotno.Text <> "" Then
            objclass1 = New clsCommon
            objclass1.ConnDb()
            objclass1.Open5()
            'nigel commented here bang.. aheheh
            'If sDB = "" Then
            objclass1.Command5("Select getdate() as ServerDate,* from " & bedryf2 & " where bedrnr='" + bCCode + "' and bedrnm = '" & bcname & "'")
            'End If

            dr = objclass1.OpenDataReader5
            If dr.Read Then
                serverDate = dr.Item("ServerDate")
                zonecode = UCase(Trim(dr.Item("class_02")))
                ShowALL = Trim(dr.Item("class_03"))

            Else
                MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
            End If
            dr.Close()
            'objclass.CloseDataReader()
            objclass1.Close5()
            objclass1 = Nothing
            fnGetZoneCode = True
        End If
        If (zonecode = "MINDANAO") Or (zonecode = "VISAYAS") Then
            zonecode = "VISMIN"
        ElseIf zonecode = "SHOWROOMS" Then
            ShowALL = Replace(ShowALL, "/NCR-SHOWROOMS", "")
            ShowALL = Replace(ShowALL, "-SHOWROOMS", "")
            zonecode = ShowALL
        End If
        If zonecode = "<NONE>" Then
            zonecode = "US-HO"
        End If

        'If (zonecode <> "LUZON") Or (zonecode <> "VISMIN") Or (zonecode <> "VISAYAS") Or (zonecode <> "LUZON") Then
        '    ShowALL = Replace(ShowALL, "/NCR-SHOWROOMS", "")
        '    ShowALL = Replace(ShowALL, "-SHOWROOMS", "")
        '    zonecode = ShowALL
        'End If
    End Function
    Private Function GetXMLPatch(ByVal Clotno As String) As Boolean
        Dim obj As New clsCommon
        Dim dr As SqlDataReader
        Dim str As String

        GetXMLPatch = False
        obj.Connectionstring3()
        obj.Open3()
        str = "SELECT TOP 1 a.Assortment FROM [264].dbo.Items a INNER JOIN REMS.dbo.ASYS_Consign_Detail b ON a.ItemCode = b.ALLBarcode WHERE (LEN(a.ItemCode) = 17) AND (a.UserDate_05 IS NOT NULL) AND (a.UserNumber_01 IS NOT NULL) and b.lotno = '" & Clotno & "'"
        obj.Command3(str)
        dr = obj.OpenDataReader3
        If dr.Read Then
            If dr.FieldCount > 0 Then
                If dr.Item(0).ToString = "400" Or dr.Item(0).ToString = "300" Then

                    If fnGetZoneCode(consignBCCode, ConsignBCName) = True Then
                        If zonecode <> "<none>" Then
                            GetXMLPatch = True
                            Upload = ImportFolderWC & zonecode & "/" & consignBCCode & "/"
                        End If
                        CreateDestination = "\\" & ImportExportServer & "\c$\IMPORT\WC\" & zonecode & "\" & consignBCCode & "\"
                        If Not Directory.Exists(CreateDestination) Then
                            IO.Directory.CreateDirectory(CreateDestination)
                        End If
                    Else
                        MsgBox("XML not successfully uploaded.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Function
                    End If

                    'CreateXML(Upload & div1 & serverDate.Year & Mid(TextBox3.Text, 5, 6) & ".XML")

                Else


                    If fnGetZoneCode(consignBCCode, ConsignBCName) = True Then
                        If zonecode <> "<none>" Then
                            GetXMLPatch = True
                            Upload = ImportFolderJW & zonecode & "/" & consignBCCode & "/"
                        End If
                        CreateDestination = "\\" & ImportExportServer & "\c$\IMPORT\JW\" & zonecode & "\" & consignBCCode & "\"
                        If Not Directory.Exists(CreateDestination) Then
                            IO.Directory.CreateDirectory(CreateDestination)
                        End If
                    Else
                        MsgBox("XML not successfully uploaded.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Function
                    End If

                    'CreateXML(Upload & div1 & serverDate.Year & Mid(TextBox3.Text, 5, 6) & ".XML")

                End If
            End If
        End If
        dr.Close()
        obj.Close3()

    End Function
    Private Function GetXMLFilename(ByVal CLotno As String) As Boolean

        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            GetXMLFilename = False
            obj.Connectionstring3()
            obj.Open3()
            str = "Select XMLFilename,IsUpload,ConsignCode,ConsignName from ASYS_Consign_Header WHERE lotno ='" & CLotno & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read Then
                If obj.IsNull(dr.Item("IsUpload")) = 0 Then
                    If obj.IsNull(dr.Item("XMLFilename")) <> "0" Then
                        XMLFile = obj.IsNull(dr.Item("XMLFilename"))
                        consignBCCode = obj.IsNull(dr.Item("ConsignCode"))
                        ConsignBCName = obj.IsNull(dr.Item("ConsignName"))
                        GetXMLFilename = True
                    End If

                End If
            End If
            dr.Close()
            obj.Close3()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub saveblehtrue()
        Try

            Dim obj As New clsCommon
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1, str2, str3, str4, squery As String
            Dim i, a As Integer
            Dim templot As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If Me.cmbCostCenter.Text = "DISTRI" Then

                templot = GenerateLot()
                squery = "update asys_lotno_gen set lotno = '" & templot & "' "
                obj.commandTrack(squery)
                obj.TrackExecute()

                For i = 0 To Me.ListView1.Items.Count - 1
                    str1 = "Update asys_DISTRI_detail set reflotno ='" & templot & "', releasedate = getdate(), custodian = '" & Me.cb.Text & "', status = 'RELEASED' where refallbarcode='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and status = 'PRICED'  "
                    obj.commandTrack(str1)
                    obj.TrackExecute()

                    str3 = "insert into asys_barcodehistory (lotno, allbarcode, itemcode, itemid, [description], karat, carat, SerialNo, weight, currency, price, cost, empname, custodian,trandate, costcenter, consignto, status)select asys_DISTRI_detail.reflotno, asys_DISTRI_detail.refallbarcode, asys_DISTRI_detail.itemcode, asys_DISTRI_detail.itemid, asys_DISTRI_detail.all_desc, asys_DISTRI_detail.all_karat, asys_DISTRI_detail.all_carat, asys_DISTRI_detail.all_weight, asys_DISTRI_detail.currency, asys_DISTRI_detail.all_price, asys_DISTRI_detail.all_cost, asys_DISTRI_header.employee, asys_DISTRI_detail.releaser, asys_DISTRI_detail.releasedate, 'DISTRI', 'NULL', 'RELEASED' from asys_DISTRI_header inner join asys_DISTRI_detail on asys_DISTRI_header.lotno = asys_DISTRI_detail.lotno where asys_DISTRI_detail.status = 'PRICED' "
                    obj.commandTrack(str3)
                    obj.TrackExecute()
                Next

                'ElseIf Me.cmbCostCenter.Text = "DISTRI" Then

                '    templot = GenerateLot()
                '    squery = "update asys_lotno_gen set lotno = '" & templot & "' "
                '    obj.commandTrack(squery)
                '    obj.TrackExecute()

                '    For i = 0 To Me.ListView1.Items.Count - 1
                '        str = "Update tbl_recrel_DISTRI set lotno_rec ='" & templot & "',Reflotno_rec = '" & Me.ListView1.Items(i).SubItems.Item(2).Text & "',datereleased_DISTRI =getdate(),EmpID_Rel='" & Me.Label6.Text & "',EmpName_Rel='" & Me.cb.Text & "', status_id_rec = 4 where allbarcode_rec='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and status_id_rec=3  "
                '        str1 = "Update tbl_recrel_DISTRI_dtail set lotno_drec='" & templot & "',RefLotno_drec='" & Me.ListView1.Items(i).SubItems.Item(2).Text & "',status_id_drec=4  where  allbarcode = '" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and status_id_drec=3 "
                '        'str2 = "Update tbl_receiving_header set status_id=10 where recAllbarcode='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and recptn='" & Me.ListView1.Items(i).SubItems.Item(1).Text & "' and status_id = 9"
                '        If Me.ListView1.Items(i).SubItems.Item(3).Text = "Force" Then
                '            str2 = "Update tbl_forcedoutrcv set  recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(), forcedout_status_for= 11 where allbarcode_for ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and forcedout_status_for = 10 "
                '            obj.Command3(str2)
                '            obj.Execute3()
                '            str2 = " Update tbl_receiving_header set recreleasingid='" & Me.Label6.Text & "',recreleasingname='" & Me.cb.Text & "', releasedate=getdate(),status_id = 11 where  recallbarcode = '" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and status_id = 10"
                '            obj.Command3(str2)
                '            obj.Execute3()
                '        Else
                '            str2 = "Update tbl_forcedoutrcv set  recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(), forcedout_status_for= 11 where allbarcode_for ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and forcedout_status_for = 10 and outsource_status_for = 4"
                '            obj.Command3(str2)
                '            obj.Execute3()
                '        End If

                '        obj.Command3(str)
                '        obj.Execute3()
                '        obj.Command3(str1)
                '        obj.Execute3()

                '    Next
            End If
            obj.CommitTrack()
            MsgBox("SUCCESSFULLY RELEASED.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            objclass.RollBackTrack()
            objclass.Close3()
            bleh = Nothing
            MsgBox("frmDISTRIReleasing/saveblehtrue: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ifREMBlehTru()
        Try

            Dim objclass As New clsCommon
            Dim a, b, c, d, u As Integer



            If outsource = False Then

            ElseIf outsource = True Then
                objclass.Connectionstring3()
                objclass.Open3()
                For a = 0 To Me.dataTable.Rows.Count - 1
                    If Me.DgEntry(a, 1) <> "" Then
                        objclass.Command3("Update tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                        objclass.Command3("Update remsluzon.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                        objclass.Command3("Update remsvismin.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                    End If

                Next
            End If


            objclass.Close()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/ifREMBlehTru: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub REMSaveRel()
        Try

            Dim objclass As New clsCommon
            Dim a, b, c, d, u As Integer



            If outsource = False Then
                objclass.ConnectionString1()
                objclass.Open()

                For a = 0 To dataTable.Rows.Count - 1
                    If Me.DgEntry(a, 1) <> "" Then
                        objclass.Command("Update tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(), forcedout_status_for= 4 where allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  ")
                        objclass.Execute()
                        objclass.Command("Update tbl_receiving_header set recreleasingid='" & idnumber & "',recreleasingname='" & userLog & "', releasedate=getdate(), status_id= 4 where  recallbarcode='" & Me.DgEntry(a, 2) & "' and sortaction_id in (4,3,8)  and status_id = 3")
                        objclass.Execute()
                        objclass.Command("Update rems.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(), forcedout_status_for= 4 where allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  ")
                        objclass.Execute()
                        objclass.Command("Update rems.dbo.tbl_receiving_header set recreleasingid='" & idnumber & "',recreleasingname='" & userLog & "', releasedate=getdate(), status_id= 4 where recallbarcode='" & Me.DgEntry(a, 2) & "'  and sortaction_id in (4,3,8)  and status_id = 3")
                        objclass.Execute()
                    End If


                Next
            ElseIf outsource = True Then
                objclass.Connectionstring3()
                objclass.Open3()
                For a = 0 To Me.dataTable.Rows.Count - 1
                    If Me.DgEntry(a, 1) <> "" Then
                        objclass.Command3("Update tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  ")
                        objclass.Execute3()
                        objclass.Command3("Update remsluzon.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)")
                        objclass.Execute3()
                        objclass.Command3("Update remsvismin.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        objclass.Execute3()
                    End If

                Next
            End If


            objclass.Close()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/REMSaveRel: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                Me.cmbreflotno.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cb_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.cmbCostCenter.Text = "REM"
            If cmbCostCenter.Text = "REM" Then
                force = True
                outsource = False
                Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.cmbCostCenter.Text = "REM"
            If cmbCostCenter.Text = "REM" Then
                force = False
                Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txttext_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttext.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar = ChrW(13) And Me.txttext.Text.Length = 17 Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 0) = txttext.Text
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 1)
                    cmbbarcode.Focus()
                    Me.btnSave.Enabled = True
                End If
            End If
            If Me.txttext.Text.Length >= 16 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/txttext_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnLotNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotNum.Click
        Try

            Dim gotoAddrow As String
            Dim li_rowd As Integer = dataTable.Rows.Count
            btnLotNum.Enabled = True

            If dataTable.Rows.Count = 0 Then

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

                cmbsource = New Label
                cmbsource.Width = 75

                cmbItems = New Label
                cmbItems.Width = 90

                cmbbarcode = New TextBox
                cmbbarcode.Width = 115

                txttext = New Label
                txttext.Width = 70

                txtitemdesc = New Label
                txtitemdesc.Width = 275

                txtgrams = New Label
                txtgrams.Width = 65

                txtkarat = New Label
                txtkarat.Width = 65

                txtcarat = New Label
                txtcarat.Width = 65

                txtprice = New Label
                txtprice.Width = 75

                cmdDelete = New Button


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                txttext.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbbarcode)
                cmbbarcode.MaxLength = 17
                cmbbarcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
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



                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            ElseIf cmbbarcode.Text <> "" Then
                If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "" Then
                    DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                    DgEntry.Focus()
                    cmbbarcode.Focus()
                    Exit Sub
                End If

                btnSave.Enabled = True
                Button6.Enabled = True
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
            MsgBox("frmDISTRIReleasing/btnLotNum_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbbarcode.KeyPress
        Try
            Dim obj1 As New clsCommon
            Dim dr1 As SqlDataReader
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, SQuery As String
            Dim a As Integer
            Dim y, z As String

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If cmbbarcode.Text = "" Then
                    MsgBox("Please enter A.L.L. barcode.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
            If e.KeyChar = ChrW(13) Then
                If Me.cmbbarcode.Text.Length = 17 Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                        e.Handled = True
                        obj.Connectionstring3()
                        obj.Open3()
                        SQuery = "SELECT RefallBarcode , PTN, RefItemcode, RefQty, price_desc as [desc],price_karat as karat, price_carat as carat, all_price as cost, price_Weight as wt,status FROM dbo.ASYS_DISTRI_detail where refallbarcode = '" & cmbbarcode.Text & "' and status = 'CONSIGNED'"
                        obj.Command3(SQuery)
                        dr = obj.OpenDataReader3
                        If dr.Read = True Then
                            'asys 3.0
                            If dataTable.Rows.Count > 1 Then
                                'asys 3.0
                                For a = 0 To dataTable.Rows.Count - 1
                                    ' y = CType(y, Long)
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
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = cmbbarcode.Text
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(cmbbarcode.Text, 4, 5)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("desc")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("wt")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("karat")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("carat")
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = dr.Item("cost")

                                btnLotNum_Click(sender, e)
                            End If
                        Else
                            MsgBox("A.L.L. barcode already released or not yet receive in DISTRI.", MsgBoxStyle.Information, TitleMsgBox)
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
                    Me.btnSave.Enabled = True
                Else
                    MsgBox("Wrong Barcode.", MsgBoxStyle.Information, TitleMsgBox)
                    cmbbarcode.Text = ""
                    cmbbarcode.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbbarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbItems_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbItems.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar = ChrW(13) Then
                    obj.Connectionstring3()
                    obj.Open3()
                    If Me.cmbCostCenter.Text = "MLWB" Then
                        str = "select * from tbl_recrel_MLWB_dtail where  Allbarcode = '" & Me.cmbbarcode.Text & "' and Status_ID_dRec = 1"
                    ElseIf Me.cmbCostCenter.Text = "PRICING" Then
                        str = "select * from tbl_recrel_PRICING_dtail where  Allbarcode = '" & Me.cmbbarcode.Text & "' and Status_ID_dRec = 1"
                    ElseIf Me.cmbCostCenter.Text = "DISTRI" Then
                        str = "select * from tbl_recrel_DISTRI_dtail where  Allbarcode = '" & Me.cmbbarcode.Text & "' and Status_ID_dRec = 1"
                    End If
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        DgEntry(DgEntry.CurrentCell.RowNumber, 2) = cmbItems.Text
                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 4)
                        cmbsource.Focus()
                    Else
                        MsgBox("PTN doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                        cmbItems.Text = ""
                        cmbItems.Focus()
                    End If
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbItems_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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

            If Me.cmbCostCenter.Text = "DISTRI" Then
                For i = 0 To dataTable.Rows.Count - 1
                    str = "Select  reflotno, refALLBarcode, ptn from asys_DISTRI_detail where refALLBarcode='" & Me.DgEntry.Item(i, 2) & "' and status = 'CONSIGNED'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    While dr.Read = True
                        Me.ListView1.Items.Add(dr("refALLBarcode"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("ptn"))
                        Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr("reflotno"))
                    End While
                    dr.Close()
                Next
                'For i = 0 To Me.ListView1.Items.Count - 1
                '    str = "Select Count(allbarcode_for) as barcode from tbl_forcedoutrcv where allbarcode_for ='" & Me.ListView1.Items(i).SubItems.Item(0).Text & "' and forcedout_status_for=10 and outsource_status_for = 4"
                '    obj.Command3(str)
                '    dr = obj.OpenDataReader3
                '    If dr.Read Then
                '        temp = dr.Item("barcode")
                '        If temp >= 1 Then
                '            Me.ListView1.Items(i).SubItems.Add("Outsource")
                '        Else
                '            Me.ListView1.Items(i).SubItems.Add("Force")
                '        End If
                '    End If
                '    dr.Close()
                'Next
                obj.Execute3()
                obj.Close3()
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/ifblehtrue: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmDISTRIReleasing/cmbsource_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbreflotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflotno.SelectedIndexChanged
        Try
            Label9.Text = dataTable.Rows.Count
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbreflotno_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim frm As New frmSummary
        'frm.iSummary = 3
        'frm.Text = "F20"
        'frm.Label7.Text = rellotno
        'frm.Label4.Text = Me.cmbCostCenter.Text
        'recrel = 4
        'frm.Show()
        'Dim frm As New frmPRICINGReleasing_rpt
        'frm.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim frmdistrirel As New frmDISTRIReleasing_rpt
            frmdistrirel.txtlot.Text = xx
            frmdistrirel.Show()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/Button5_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbreflotno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreflotno.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If cmbreflotno.Text = "" Then
                    MsgBox("Please enter or select A.L.L. lot number.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
            End If
            If e.KeyChar = ChrW(13) And Me.cmbreflotno.Text.Length = 10 Then
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                    addrow()
                    Label9.Text = dataTable.Rows.Count
                    Me.Button6.Enabled = True
                    btnSave.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbreflotno_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try


            If bleh = True Then
                Label9.Text = dataTable.Rows.Count - 1
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
            MsgBox("frmDISTRIReleasing/cmbCostCenter_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub txtbc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dataTable.Clear()
    '    ListView1.Items.Clear()
    'End Sub

    'Private Sub txtbc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    Dim dr As SqlDataReader
    '    If e.KeyChar = ChrW(13) Then
    '        objclass = New clsCommon
    '        objclass.ConnDb()
    '        objclass.Open5()
    '        If UCase(sDB) = "LUZON" Then
    '            objclass.Command5("Select bedrnm from " & bedryfluzon2 & " where bedrnr='" + txtbc.Text.Trim + "'")
    '        ElseIf UCase(sDB) = "VISMIN" Then
    '            objclass.Command5("Select bedrnm from " & bedryfvismin2 & " where bedrnr='" + txtbc.Text.Trim + "'")
    '        End If
    '        dr = objclass.OpenDataReader5
    '        If dr.Read Then
    '            Me.lblBcCode.Text = dr.Item("bedrnm")
    '        Else
    '            Msgbox("Branch code doesn't exist.")
    '            txtbc.Focus()
    '        End If
    '        dr.Close()
    '        objclass.Execute5()
    '        objclass.Close5()

    '    Else
    '        Exit Sub
    '    End If
    'End Sub
    'Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
    '    txtbc.Focus()
    'End Sub

    'Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    dataTable.Clear()
    '    ListView1.Items.Clear()
    'End Sub

    Private Sub cmbCostCenter_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCostCenter.MouseWheel
        Try
            cmbCostCenter.Text = MainCost
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbCostCenter_MouseWheel: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim rply As Integer
            Dim u, s, tempa As Integer

            rply = MsgBox("Are you sure you want to delete. " & DgEntry(DgEntry.CurrentCell.RowNumber, 2) & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                dataTable.Rows.RemoveAt(DgEntry.CurrentCell.RowNumber)
            Else
                Exit Sub
            End If

            Label9.Text = dataTable.Rows.Count

            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            DgEntry.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/Button6_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtreflot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtreflot.Text = rellotno
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/txtreflot_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            bleh = True

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

            cmbsource = New Label
            cmbsource.Width = 75

            cmbItems = New Label
            cmbItems.Width = 90

            cmbbarcode = New TextBox
            cmbbarcode.Width = 115

            txttext = New Label
            txttext.Width = 70

            txtitemdesc = New Label
            txtitemdesc.Width = 275

            txtgrams = New Label
            txtgrams.Width = 65

            txtkarat = New Label
            txtkarat.Width = 65

            txtcarat = New Label
            txtcarat.Width = 65

            txtprice = New Label
            txtprice.Width = 75

            cmdDelete = New Button


            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(txttext)
            txttext.BringToFront()

            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
            dgtb.TextBox.Controls.Add(cmbbarcode)
            cmbbarcode.BringToFront()

            dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
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


            DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
            DgEntry.Focus()
            cmbbarcode.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/Button7_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.SelectedIndexChanged
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery, sqry As String

            Me.cmbreflotno.Text = ""
            Me.cmbreflotno.Items.Clear()

            con.Connectionstring3()
            con.Open3()
            sqry = "select distinct(reflotno) as reflotno from asys_distri_detail where status = 'CONSIGNED' order by reflotno asc"
            con.Command3(sqry)
            dr = con.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(Trim(dr.Item("reflotno")))
            End While
            con.Close3()
            Me.btnLotNum.Enabled = True
            Me.cmbreflotno.Enabled = True
            pricerel = Me.cb.Text
            Me.cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cb_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub strdate()
        Try
            'paopao
            Dim sysdate As Date
            Dim xday, xyear, xmonth, sysdate2, xdate, xdate2, tempdate As String

            sysdate2 = Format(System.DateTime.Now, "MM-dd-yyyy")
            sysdate = sysdate2
            xmonth = sysdate.Month
            xday = sysdate.Day
            xyear = sysdate.Year
            Select Case xmonth
                Case "1"
                    xmonth = "January"
                Case "2"
                    xmonth = "February"
                Case "3"
                    xmonth = "March"
                Case "4"
                    xmonth = "April"
                Case "5"
                    xmonth = "May"
                Case "6"
                    xmonth = "June"
                Case "7"
                    xmonth = "July"
                Case "8"
                    xmonth = "August"
                Case "9"
                    xmonth = "September"
                Case "10"
                    xmonth = "October"
                Case "11"
                    xmonth = "November"
                Case "12"
                    xmonth = "December"
            End Select
            xdate2 = CStr(xmonth + " " + xday + ", " + xyear)
            xdate = xdate2
            Me.txtDateReleased.Text = UCase(xdate)
            Me.txtDateReleased.ReadOnly = True
            Me.txtDateReleased.TextAlign = HorizontalAlignment.Left
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/strdate: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function pao() 'paopao 02172010
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery, sqry As String

            con.Connectionstring3()
            con.Open3()
            sqry = "select distinct(lotno) as reflotno from ASYS_GetConsignDetails  order by reflotno desc"
            con.Command3(sqry)
            dr = con.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(Trim(dr.Item("reflotno")))
            End While
            con.Close3()
            Me.btnLotNum.Enabled = True
            Me.cmbreflotno.Enabled = True
            pricerel = Me.cb.Text
            Me.cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/pao: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub cmbreflotno_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbreflotno.TextChanged
        Try
            dataTable.Clear()
            Label9.Text = 0
            btnSave.Enabled = False
            Button6.Enabled = False

        Catch ex As Exception
            MsgBox("frmDISTRIReleasing/cmbreflotno_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frm As New frmSearchLotno
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgEntry.Navigate

    End Sub
End Class

