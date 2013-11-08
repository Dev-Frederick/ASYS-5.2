Imports System.Data.SqlClient
Imports System.IO
Public Class frmReleasing
    Inherits System.Windows.Forms.Form
    Private WithEvents cmbItems As System.Windows.Forms.ComboBox
    Private WithEvents cmbsource As System.Windows.Forms.ComboBox
    Private WithEvents cmbbarcode As System.Windows.Forms.TextBox
    'textbox
    Private WithEvents txttext As System.Windows.Forms.TextBox
    Private WithEvents txtitemdesc As System.Windows.Forms.TextBox
    'Private WithEvents txtgrams As System.Windows.Forms.TextBox
    Private WithEvents txtweight As System.Windows.Forms.TextBox  ' gm 20111124
    Private WithEvents txtkarat As System.Windows.Forms.TextBox
    Private WithEvents txtcarat As System.Windows.Forms.TextBox
    Private WithEvents txtprice As System.Windows.Forms.TextBox

    'button
    Private WithEvents cmdDelete As System.Windows.Forms.Button
    Private WithEvents dataTable As dataTable
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

    Private WithEvents tm As New ContextMenu
    Private WithEvents ti As New NotifyIcon

    Private dt As dataTable
    Private dv As DataView
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Public pi_search_column As Integer
    Public ps_search_result As String
    Public ctrRow As Integer
    Private reflotno As String

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
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbreflotno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblBcCode As System.Windows.Forms.Label
    Friend WithEvents cmbBCcode As System.Windows.Forms.ComboBox
    Friend WithEvents txtbc As System.Windows.Forms.TextBox
    Friend WithEvents lblBCode As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVPPrint As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReleasing))
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.cb = New System.Windows.Forms.ComboBox
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.txtDateReleased = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblBcCode = New System.Windows.Forms.Label
        Me.cmbBCcode = New System.Windows.Forms.ComboBox
        Me.lblBCode = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtbc = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.btnVPPrint = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
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
        Me.lbl1FA01.Location = New System.Drawing.Point(872, 48)
        Me.lbl1FA01.Name = "lbl1FA01"
        Me.lbl1FA01.Size = New System.Drawing.Size(72, 16)
        Me.lbl1FA01.TabIndex = 107
        Me.lbl1FA01.Text = "  1FA01 V5.2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "USERNAME"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "COST CENTER"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "DATE RELEASED"
        '
        'btnLot
        '
        Me.btnLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLot.Location = New System.Drawing.Point(8, 24)
        Me.btnLot.Name = "btnLot"
        Me.btnLot.Size = New System.Drawing.Size(56, 11)
        Me.btnLot.TabIndex = 117
        Me.btnLot.Text = "LOT NO."
        Me.btnLot.Visible = False
        '
        'btnLotNum
        '
        Me.btnLotNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLotNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLotNum.Location = New System.Drawing.Point(208, 24)
        Me.btnLotNum.Name = "btnLotNum"
        Me.btnLotNum.Size = New System.Drawing.Size(88, 24)
        Me.btnLotNum.TabIndex = 118
        Me.btnLotNum.Text = "NEW LOT#"
        Me.btnLotNum.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 11)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "REF LOT NO."
        '
        'cmbreflotno
        '
        Me.cmbreflotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreflotno.Location = New System.Drawing.Point(88, 56)
        Me.cmbreflotno.MaxLength = 10
        Me.cmbreflotno.Name = "cmbreflotno"
        Me.cmbreflotno.Size = New System.Drawing.Size(184, 21)
        Me.cmbreflotno.TabIndex = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDateReleased)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 128)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(208, 20)
        Me.TextBox1.TabIndex = 132
        Me.TextBox1.Text = ""
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
        'cb
        '
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb.Location = New System.Drawing.Point(128, 24)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(208, 21)
        Me.cb.TabIndex = 128
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtDateReleased.Location = New System.Drawing.Point(128, 88)
        Me.txtDateReleased.Name = "txtDateReleased"
        Me.txtDateReleased.Size = New System.Drawing.Size(208, 20)
        Me.txtDateReleased.TabIndex = 127
        Me.txtDateReleased.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblBcCode)
        Me.GroupBox2.Controls.Add(Me.cmbBCcode)
        Me.GroupBox2.Controls.Add(Me.lblBCode)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btnLot)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnLotNum)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtbc)
        Me.GroupBox2.Controls.Add(Me.cmbreflotno)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
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
        Me.btnSearch.Location = New System.Drawing.Point(280, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 21)
        Me.btnSearch.TabIndex = 149
        Me.btnSearch.Text = "...."
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(328, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 24)
        Me.Button7.TabIndex = 147
        Me.Button7.Text = "ADD ROW"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "ACTION"
        Me.Label13.Visible = False
        '
        'lblBcCode
        '
        Me.lblBcCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBcCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBcCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBcCode.Location = New System.Drawing.Point(136, 57)
        Me.lblBcCode.Name = "lblBcCode"
        Me.lblBcCode.Size = New System.Drawing.Size(208, 19)
        Me.lblBcCode.TabIndex = 144
        Me.lblBcCode.Visible = False
        '
        'cmbBCcode
        '
        Me.cmbBCcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBCcode.Location = New System.Drawing.Point(136, 56)
        Me.cmbBCcode.MaxLength = 17
        Me.cmbBCcode.Name = "cmbBCcode"
        Me.cmbBCcode.Size = New System.Drawing.Size(232, 21)
        Me.cmbBCcode.TabIndex = 143
        Me.cmbBCcode.Visible = False
        '
        'lblBCode
        '
        Me.lblBCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBCode.Location = New System.Drawing.Point(8, 60)
        Me.lblBCode.Name = "lblBCode"
        Me.lblBCode.Size = New System.Drawing.Size(72, 16)
        Me.lblBCode.TabIndex = 141
        Me.lblBCode.Text = "BCODE"
        Me.lblBCode.Visible = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(232, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox2.TabIndex = 125
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(192, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 16)
        Me.Label12.TabIndex = 124
        Me.Label12.Text = "YEAR"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(88, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 123
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 122
        Me.Label11.Text = "SORT MONTH"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 121
        Me.Label5.Visible = False
        '
        'txtbc
        '
        Me.txtbc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbc.Location = New System.Drawing.Point(88, 56)
        Me.txtbc.MaxLength = 3
        Me.txtbc.Name = "txtbc"
        Me.txtbc.Size = New System.Drawing.Size(48, 20)
        Me.txtbc.TabIndex = 142
        Me.txtbc.Text = ""
        Me.txtbc.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(88, 24)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox3.TabIndex = 145
        Me.ComboBox3.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(648, 536)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 124
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.GroupBox3.Controls.Add(Me.Label6)
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
        Me.Label6.Location = New System.Drawing.Point(440, 72)
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
        Me.Button5.Location = New System.Drawing.Point(808, 536)
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
        Me.Label8.Location = New System.Drawing.Point(8, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "TOTAL NO. OF ITEMS"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 520)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 24)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label10.Location = New System.Drawing.Point(664, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "Label10"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(728, 536)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 40)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "DELETE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(640, 520)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 64)
        Me.GroupBox4.TabIndex = 139
        Me.GroupBox4.TabStop = False
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader12, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader14, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(8, 264)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(968, 248)
        Me.ListView2.TabIndex = 140
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "  NO."
        Me.ColumnHeader13.Width = 42
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "           PTN"
        Me.ColumnHeader12.Width = 95
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = " ITEM CODE"
        Me.ColumnHeader5.Width = 74
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "                   DESCRIPTION"
        Me.ColumnHeader6.Width = 184
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "QTY    "
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 53
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "KARAT  "
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 52
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CARAT "
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 51
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = " SORTING CLASS"
        Me.ColumnHeader10.Width = 98
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "WEIGHT   "
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 66
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "LOAN VALUE      "
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 116
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "A.L.L. VALUE       "
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader19.Width = 136
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "     ID"
        Me.ColumnHeader20.Width = 0
        '
        'btnVPPrint
        '
        Me.btnVPPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVPPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVPPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVPPrint.Image = CType(resources.GetObject("btnVPPrint.Image"), System.Drawing.Image)
        Me.btnVPPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVPPrint.Location = New System.Drawing.Point(808, 536)
        Me.btnVPPrint.Name = "btnVPPrint"
        Me.btnVPPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnVPPrint.TabIndex = 141
        Me.btnVPPrint.Text = "PRINT"
        Me.btnVPPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Window
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(128, 552)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 24)
        Me.Label15.TabIndex = 138
        Me.Label15.Text = "0"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 552)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 23)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "NO. OF PACKS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label14.Visible = False
        '
        'frmReleasing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.ClientSize = New System.Drawing.Size(976, 586)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnVPPrint)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(992, 624)
        Me.MinimumSize = New System.Drawing.Size(992, 616)
        Me.Name = "frmReleasing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS 5.2 RELEASING"
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
            arrstr = New String(9) {"NO.", "PTN", "A.L.L. BARCODE", "ITEM SOURCE ", "DESCRIPTION", "WEIGHT", "KARAT", "CARAT", "PRICE", " "}

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
                colStyle(0).Width = 70
                colStyle(1).Width = 100
                colStyle(2).Width = 130
                colStyle(3).Width = 80
                colStyle(4).Width = 235
                colStyle(5).Width = 60
                colStyle(5).Alignment = HorizontalAlignment.Right
                colStyle(6).Width = 60
                colStyle(6).Alignment = HorizontalAlignment.Right
                colStyle(7).Width = 60
                colStyle(7).Alignment = HorizontalAlignment.Right
                colStyle(8).Width = 100
                colStyle(8).Alignment = HorizontalAlignment.Right
                colStyle(9).Width = 80


                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                txttext = New TextBox
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
                dgtb.TextBox.Controls.Add(txtweight)
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
            Dim strLotnO As String
            Dim objclass As New clsCommon
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String

            If Me.cmbCostCenter.Text = "MLWB" Then

                objclass.Connectionstring3()
                objclass.Open3()
                objclass.Command3("select lotno from ASYS_LOTNO_gen")
                dr = objclass.OpenDataReader3
                If dr.Read Then
                    GenerateLot = dr.Item("lotno")
                End If
                dr.Close()
                ' objclass.Execute3()
                objclass.Close3()
            End If
            'Me.cmbCostCenter.Text = GenerateLot
        Catch ex As Exception
        End Try
    End Function

    'Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
    '    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    '    'DgEntry.Enabled = True
    'End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            If Not ab_isEmpty Then
                If deleteData(hi) Then
                    dataTable.Rows.RemoveAt(hi.Row)
                Else
                    MsgBox("Error in removing data!", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                End If
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try
            Dim hi As DataGrid.HitTestInfo
            Dim repz As Integer
            hi = DgEntry.HitTest(e.X, e.Y)
            If hi.Column = 9 And hi.Row >= 0 Then
                repz = MsgBox("Are you sure you want to remove the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                If repz = vbYes Then
                    dataTable.Rows.RemoveAt(hi.Row)
                    Label9.Text = dataTable.Rows.Count
                Else
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
                End If
            End If

        Catch ex As Exception
            MsgBox("frmReleasing/dgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            If Label9.Text = "0" Then
                Button6.Enabled = False
            Else
                Button6.Enabled = True
            End If
            deleteData = False
            MsgBox("frmReleasing/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                    cmbItems = New ComboBox
                    cmbItems.Width = 150
                    cmbItems.DataSource = ds_dataset.Tables(0)
                    cmbItems.DisplayMember = "ALLBarcode"

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
                    MsgBox("frmReleasing/releaseoutsourceitems: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
        End Try
    End Sub

    Private Sub REMOutSourceAddrow()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim Li_row As Integer

            dataTable.Rows.Clear()

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            str = "select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from (select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from ASYS_REM_Detail where reflotno = '" & Me.cmbreflotno.Text & "' and actionclass in ('Return','OUTSOURCE','GoodStock','Watch','Cellular') and status = 'COSTED' union all select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from ASYS_REMOutsource_Detail where reflotno = '" & Me.cmbreflotno.Text & "' and actionclass in ('Return','OUTSOURCE','GoodStock','Watch','Cellular') and status = 'COSTED') a  order by refallbarcode"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            While dr.Read
                dataTable.LoadDataRow(arrstr, True)
                DgEntry(Li_row, 0) = Li_row + 1
                DgEntry(Li_row, 1) = obj.IsNull(dr.Item("ptn"))
                DgEntry(Li_row, 2) = obj.IsNull(dr.Item("refallbarcode"))
                DgEntry(Li_row, 3) = Mid(obj.IsNull(dr.Item("refallbarcode")), 4, 5)
                DgEntry(Li_row, 4) = obj.IsNull(dr.Item("all_desc"))
                DgEntry(Li_row, 5) = obj.IsNull(dr.Item("alL_weight"))
                DgEntry(Li_row, 6) = obj.IsNull(dr.Item("all_karat"))
                DgEntry(Li_row, 7) = obj.IsNull(dr.Item("all_carat"))
                DgEntry(Li_row, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                DgEntry(Li_row, 9) = "DELETE"
                Li_row = Li_row + 1

            End While
            dr.Close()
            obj.Close()
        Catch ex As Exception
            MsgBox("frmReleasing/REMOutSourceAddrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                    cmbItems = New ComboBox
                    cmbItems.Width = 150
                    cmbItems.DataSource = ds_dataset.Tables(0)
                    cmbItems.DisplayMember = "PTN_for"

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
                    btnSave.Enabled = True
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
                    MsgBox("frmReleasing/releaseForceitems: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            a = Now.MinValue.Day
            b = Now.MaxValue.Day
            c = Now.Year

            ds_dataset.Reset()

            '-----------------------------MLWB-------------------------'
            If cmbCostCenter.Text = "MLWB" And outsource = True Then
                'Call releaseoutsourceitems()
                Call REMOutSourceAddrow()
                btnSave.Enabled = True
            End If
            'conn = Nothing
            'con = Nothing
        Catch ex As Exception
            MsgBox("frmReleasing/addrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmReleasing/NextPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmReleasing/decryptPass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            Catch Ex As Exception
                MsgBox("frmReleasing/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmReleasing/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            Catch Ex As Exception
                MsgBox(ex.Message, , TitleMsgBox)
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
            MsgBox("frmReleasing/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Sub callActionClass()
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader

            ComboBox3.Items.Clear()
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("select action_type from tbl_action where action_id  in (6,11,10,9,5,13,4,8,3)")
            dr = objclass.OpenDataReader5
            While dr.Read

                If UCase(dr.Item("action_type")) = "MISSINGITEM" Then '12232011 delete cellular,goodstocks and watch
                    ComboBox3.Items.Add("MISSING ITEM")
                ElseIf UCase(dr.Item("action_type")) = "CELLULAR" Then
                ElseIf UCase(dr.Item("action_type")) = "GOODSTOCK" Then
                ElseIf UCase(dr.Item("action_type")) = "WATCH" Then
                Else
                    ComboBox3.Items.Add(Trim(UCase(dr.Item("action_type"))))
                End If

            End While
            dr.Close()
            objclass.Close5()
        Catch ex As Exception
            MsgBox("frmReleasing/callActionClass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub frmReleasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If sDB <> "" Then
                Call callActionClass()
            End If
            If sDB = "" Then
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")
                'cmbCostCenter.Text = "MLWB"
            Else
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")
                cmbCostCenter.Items.Add("VP")
                'cmbCostCenter.Text = "MLWB"
            End If
            force = False
            outsource = False
            Button5.Visible = True
            ctrRow = 0
            'Me.SetDesktopLocation(5, 130) GetNewLotNumber("REM", "")
            Call valEmp()
            Call tuig()
            Me.ComboBox2.Text = Now.Year
            Me.ComboBox1.Text = MonthName(Now.Month)
            'Call CallCostCenter()
            Me.cb.Text = UCase(userLog)
            txtDateReleased.ReadOnly = True
            txtDateReleased.BackColor = Color.White
            txtDateReleased.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            cmbCostCenter.Text = "MLWB"
            cmbCostCenter.Focus()
            '  Me.ComboBox1.Text = Now.Month
            Me.TextBox1.Text = UCase(userLog)
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.BackColor = Color.White
            Label9.Text = "0"
            'If MainCost = "REM" And sDB = "" Then
            '    Button4_Click(sender, e)
            'End If

        Catch ex As Exception
            MsgBox("frmReleasing/frmReleasing_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub valEmp()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("select fullname from rems.dbo.vw_humresvismin where (job_title like 'ALLB%' or  job_title like 'Sorter%' OR FULLNAME LIKE '%jADRAQUE')  and fullname not like '%Pableo' and fullname not like '%Sasaban' and fullname not like '%Briones' and Fullname not like '%Baladjay'")
            dr = obj.OpenDataReader5
            While dr.Read
                cb.Items.Add(UCase(Trim(dr.Item("fullname"))))
            End While
            dr.Close()
            'obj.Execute5()
            obj.Close5()
        Catch ex As Exception
        End Try
    End Sub

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
            MsgBox("frmReleasing/center: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub lotnorefresh()
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader

            dataTable.Rows.Clear()
            Me.cmbreflotno.Items.Clear()

            con.Connectionstring3()
            con.Open3()
            con.Command3("Select distinct reflotno as lotno from ASYS_REMOutsource_detail where status <> 'COSTED' union all select Distinct reflotno as lotno from ASYS_REM_Detail where status = 'COSTED'")
            dr = con.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(dr.Item("lotno"))
            End While
            dr.Close()
            con.Close3()

            'Me.cmbreflotno.Text = ""
            Me.cmbreflotno.Focus()
        Catch ex As Exception
            MsgBox("frmReleasing/lotnorefresh: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
        End Try
    End Sub

    Private Function CountBarcode_photo() As Boolean
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim u, cnt As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            cnt = 0
            For u = 0 To dataTable.Rows.Count - 1
                str = "select photoname from ASYS_REM_detail where refallbarcode = '" & DgEntry(u, 2) & "' union all select photoname from ASYS_REMOutsource_detail where refallbarcode = '" & DgEntry(u, 2) & "'"
                obj.Command3(str)
                dr = obj.OpenDataReader3
                If dr.Read = True Then
                    If obj.IsNull(dr.Item("photoname")) = "0" Then
                        cnt = cnt + 1
                    End If
                End If
                dr.Close()
            Next

            If cnt > 0 Then
                CountBarcode_photo = True
            Else
                CountBarcode_photo = False
            End If

            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("frmReleasing/CountBarcode_photo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim rply As Integer
            Dim sqlinsert, sqlinsert1, sqlinsert2, squery1, sqlinsert3, squery, squery2, temps, temp, msg, m, l, p, w, templot, tempref As String
            Dim a, b, c, d, i, z As Integer
            Dim cn As New clsCommon
            Dim dr, dr1, dr3 As SqlDataReader
            Dim obj As New clsCommon



            reflotno = GetNewLotNumber("REM", "") 'GenerateLot()
            'tempref = Me.cmbreflotno.Text ''''
            'rellot = templot''''

            rply = MsgBox("Are you sure you want to save this data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                If bleh = False Then
                    If Me.cmbCostCenter.Text = "MLWB" Then
                        'Call SeeIFReturn()
                        If relbleh = False Then
                            If dataTable.Rows.Count > 0 Then
                                If CountBarcode_photo() = True Then
                                    MsgBox("Some ALLbarcode dont have pictures. Not successfully released", MsgBoxStyle.Information, TitleMsgBox)
                                    Exit Sub
                                Else
                                    Call NewREMSAVE()
                                End If

                                btnSave.Enabled = False
                            Else
                                MsgBox("No data to save", MsgBoxStyle.Information, TitleMsgBox)
                            End If
                        End If
                    Else
                        If relbleh = False Then
                            If ListView2.Items.Count > 0 Then
                                Call REMRelease_VP()
                                btnSave.Enabled = False
                            Else
                                MsgBox("No data to save", MsgBoxStyle.Information, TitleMsgBox)
                            End If
                        End If
                    End If
                Else
                    If sDB = "" Then
                        If dataTable.Rows.Count > 0 Then
                            NewLotNO()
                            btnSave.Enabled = False
                        Else
                            MsgBox("No data to save", MsgBoxStyle.Information, TitleMsgBox)
                        End If

                    Else
                        If dataTable.Rows.Count > 0 Then
                            Call NewLotNO_goodstock()
                            btnSave.Enabled = False
                        Else
                            MsgBox("No data to save", MsgBoxStyle.Information, TitleMsgBox)
                        End If


                        ' Call saveblehtrue()
                    End If

                End If

                'objclass.Close()
                'objclass = Nothing
                If cmbCostCenter.Text = "MLWB" Then
                    rellotno = reflotno
                    Me.Label5.Text = rellotno
                    Call lotnorefresh()
                End If

                ListView2.Items.Clear()
                dataTable.Rows.Clear()
                Label9.Text = "0"
                Label15.Text = "0"

            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmReleasing/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub NewLotNO()
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1, str2 As String
            Dim i, a As Integer
            Dim templot As String

            reflotno = GetNewLotNumber("REM", "") '''

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Opentracker2()
            objclass.CreateCom()

            objclass.commandTrack("Update [REMS].dbo.ASYS_LOTNO_gen set lotno = '" & reflotno & "' WHERE BusinessCenter ='REM'")
            objclass.TrackExecute()

            For a = 0 To dataTable.Rows.Count - 1
                If Me.DgEntry(a, 1) <> "" Then
                    str = " insert into [REMS].dbo.ASYS_BarcodeHistory(lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,"
                    str = str + "				trandate,status,costcenter,empname,SerialNO)"
                    str = str + "	select lotno,allbarcode as refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,trandate,status,costcenter,empname,SerialNO from"
                    str = str + "	("
                    str = str + "	SELECT     '" & reflotno & "' as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                    str = str + "	FROM         dbo.ASYS_REM_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'"
                    str = str + "	union all "
                    str = str + "	SELECT      '" & reflotno & "' as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                    str = str + "	FROM         dbo.ASYS_REMOutsource_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED' "
                    str = str + "	)a"
                    objclass.commandTrack(str)
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSLUZON].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSSHOWROOM].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMS].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    'objclass.commandTrack("Update [REMSVismin].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    'objclass.TrackExecute()
                    objclass.commandTrack("Update [REMSVisayas].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSMindanao].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSLuzon].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    'objclass.commandTrack("Update [REMSVismin].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    'objclass.TrackExecute()
                    objclass.commandTrack("Update [REMSVisayas].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSMindanao].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMSSHOWROOM].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update [REMS].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                End If
            Next
            objclass.CommitTrack()
            MsgBox("Save Successfully", MsgBoxStyle.Information, TitleMsgBox)
            objclass.Close()


            cmbreflotno.Text = GetNewLotNumber("REM", "")

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmReleasing/NewLotNO: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objclass.Close()
            'bleh = Nothing
        End Try
    End Sub

    Private Sub NewLotNO_goodstock()
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1, str2 As String
            Dim i, a As Integer
            Dim templot As String

            reflotno = GetNewLotNumber("REM", "")

            objclass = New clsCommon

            If sDB = "" Then
                objclass.Connectionstring3()
                objclass.Opentracker2()
            Else
                objclass.ConnectionString1()
                objclass.Opentracker()
            End If

            objclass.CreateCom()

            objclass.commandTrack("Update [REMS].dbo.ASYS_LOTNO_gen set lotno = '" & reflotno & "' WHERE BusinessCenter ='REM'")
            objclass.TrackExecute()

            For a = 0 To dataTable.Rows.Count - 1
                If Me.DgEntry(a, 1) <> "" Then
                    str = " insert into [REMS].dbo.ASYS_BarcodeHistory(lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,"
                    str = str + "				trandate,status,costcenter,empname,SerialNO)"
                    str = str + "	select lotno,allbarcode as refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,trandate,status,costcenter,empname,SerialNO from"
                    str = str + "	("
                    str = str + "	SELECT     '" & reflotno & "' as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                    str = str + "	FROM         dbo.ASYS_REM_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'"
                    str = str + "	union all "
                    str = str + "	SELECT     '" & reflotno & "' as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                    str = str + "	FROM         dbo.ASYS_REMOutsource_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED' "
                    str = str + "	)a"
                    objclass.commandTrack(str)
                    objclass.TrackExecute()
                    '''09-17-2013 changes for update--
                    objclass.commandTrack("Update REMS" & sDB & ".dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                    objclass.commandTrack("Update [REMS].dbo.ASYS_REM_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update REMS" & sDB & ".dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                    objclass.commandTrack("Update [REMS].dbo.ASYS_REMOutsource_detail set reflotno = '" & reflotno & "',releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                End If
            Next
            objclass.Close()
            objclass.CommitTrack()
            MsgBox("Save Successfully", MsgBoxStyle.Information, TitleMsgBox)
            cmbreflotno.Text = GetNewLotNumber("REM", "")
        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmReleasing/NewLotNO_goodstock: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objclass.Close()
            objclass = Nothing
            bleh = Nothing
        End Try
    End Sub

    Private Sub saveblehtrue()
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1, str2 As String
            Dim i, a As Integer
            Dim templot As String


            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Opentracker()
            objclass.CreateCom()

            For a = 0 To dataTable.Rows.Count - 1
                If Me.DgEntry(a, 1) <> "" Then
                    str = " insert into [REMS].dbo.ASYS_BarcodeHistory(lotno,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,"
                    str = str + "				trandate,status,costcenter,empname)"
                    str = str + "	select lotno,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,trandate,status,costcenter,empname from"
                    str = str + "	("
                    str = str + "	SELECT     RefLotno as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname"
                    str = str + "	FROM         dbo.ASYS_REM_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'"
                    str = str + "	union all "
                    str = str + "	SELECT     RefLotno as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                    str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                    str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname"
                    str = str + "	FROM         dbo.ASYS_REMOutsource_Detail where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED' "
                    str = str + "	)a"
                    objclass.commandTrack(str)
                    objclass.TrackExecute()

                    objclass.commandTrack("Update REMS" & sDB & ".dbo.ASYS_REM_detail set releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                    objclass.commandTrack("Update [REMS].dbo.ASYS_REM_detail set releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("Update REMS" & sDB & ".dbo.ASYS_REMOutsource_detail set releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                    objclass.commandTrack("Update [REMS].dbo.ASYS_REMOutsource_detail set releasedate = getdate(),releaser = '" & userLog & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(a, 2) & "' and status = 'COSTED'")
                    objclass.TrackExecute()
                End If
            Next

            objclass.CommitTrack()
            MsgBox("Save Successfully", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmReleasing/saveblehtrue: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objclass.Close()
            objclass = Nothing
            bleh = Nothing
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
                        'objclass.Command3("Update remsvismin.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        'objclass.Execute3()
                        objclass.Command3("Update remsvisayas.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                        objclass.Command3("Update remsmindanao.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                        objclass.Command3("Update remsshowroom.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        objclass.Execute3()
                        'objclass.Command3("Update REMSLNCR.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Me.Label6.Text & "',recreleasingname_for='" & Me.cb.Text & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  and outsource_status_for = 1")
                        'objclass.Execute3()
                    End If
                Next
            End If


            objclass.Close()
        Catch ex As Exception
            MsgBox("frmReleasing/ifREMBlehTru: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function ifListviewFocus(ByVal textfocus As Integer) As Boolean
        If textfocus = "" Then
            ifListviewFocus = False
        Else
            ifListviewFocus = True
        End If
    End Function
    Private Sub REMRelease_VP()
        Dim obj As clsCommon
        Try
            Dim dr As SqlDataReader
            Dim str As String
            Dim i As Integer

            obj = New clsCommon

            obj.ConnectionString1()
            obj.Opentracker()

            obj.CreateCom()
            ListView2.Focus()

            If ListView2.FocusedItem.Selected = True And (ComboBox3.Text.ToUpper <> "TRADE-IN") Then
                ''''09-17-2013 new changes for update--
                obj.commandTrack("update REMS" & sDB & ".dbo.ASYS_REM_Detail  set status ='RELEASED',  releaser = '" + Trim(userLog) + "', releasedate = getdate() where ptn = '" + ListView2.FocusedItem.SubItems.Item(1).Text + "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(11).Text + "'")
                obj.TrackExecute()
                obj.commandTrack("update [REMS].dbo.ASYS_REM_Detail  set status ='RELEASED',  releaser = '" + Trim(userLog) + "', releasedate = getdate() where ptn = '" + ListView2.FocusedItem.SubItems.Item(1).Text + "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(11).Text + "'")
                obj.TrackExecute()

                obj.CommitTrack()
                MsgBox("PTN " + CStr(ListView2.FocusedItem.SubItems.Item(1).Text) + " successfully released.", MsgBoxStyle.Information)
                ListView2.FocusedItem.Remove()
                Exit Sub

            Else
                For i = 0 To ListView2.Items.Count - 1
                    If ComboBox3.Text.ToUpper <> "TRADE-IN" Then
                        str = "Update REMS" & sDB & ".dbo.ASYS_REM_Detail  set releasedate = getdate(),releaser= '" & Trim(userLog) & "',status = 'RELEASED' where ptn = '" & ListView2.Items(i).SubItems.Item(1).Text & "' and status = 'SORTED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = "Update [REMS].dbo.ASYS_REM_Detail  set releasedate = getdate(),releaser = '" & Trim(userLog) & "',status = 'RELEASED' where ptn = '" & ListView2.Items(i).SubItems.Item(1).Text & "' and status = 'SORTED' and itemid = '" & ListView2.Items(i).SubItems.Item(11).Text & "'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                    Else
                        str = "Update REMS" & sDB & ".dbo.ASYS_TRADEIN_Detail  set releasedate = getdate(),releaser= '" & Trim(userLog) & "',status = 'RELEASED' where transaction_no = '" & ListView2.Items(i).SubItems.Item(1).Text & "' and status = 'RECEIVED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = "Update [REMS].dbo.ASYS_TRADEIN_Detail  set releasedate = getdate(),releaser = '" & Trim(userLog) & "',status = 'RELEASED' where transaction_no = '" & ListView2.Items(i).SubItems.Item(1).Text & "' and status = 'RECEIVED' and item_id = '" & ListView2.Items(i).SubItems.Item(11).Text & "'"
                        obj.commandTrack(str)
                        obj.TrackExecute()
                    End If
                Next
            End If
            obj.CommitTrack()
            MsgBox("Save Successfully", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("frmReleasing/REMRelease_VP: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close()
        End Try
    End Sub

    Private Sub NewREMSAVE()
        Dim obj As clsCommon
        Try
            Dim dr As SqlDataReader
            Dim str As String
            Dim i As Integer
            Dim reflotno As String

            reflotno = GetNewLotNumber("REM", "")
            obj = New clsCommon
            If sDB = "" Then
                obj.Connectionstring3()
                obj.Opentracker2()
            Else
                obj.ConnectionString1()
                obj.Opentracker()
            End If

            obj.CreateCom()

            obj.commandTrack("Update [REMS].dbo.ASYS_LOTNO_gen set lotno = '" & reflotno & "' WHERE BusinessCenter ='REM'")
            obj.TrackExecute()

            For i = 0 To dataTable.Rows.Count - 1

                str = " insert into [REMS].dbo.ASYS_BarcodeHistory  (lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,"
                str = str + "				trandate,status,costcenter,empname,SerialNO)"
                str = str + "	select lotno,allbarcode as refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,custodian,trandate,status,costcenter,empname,SerialNO from"
                str = str + "	("
                str = str + "	SELECT    " & reflotno & " as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                str = str + "	FROM         [REMS].dbo.ASYS_REM_Detail  where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED'"
                str = str + "	union all "
                str = str + "	SELECT      " & reflotno & " as lotno, RefALLBarcode as allbarcode, RefItemcode as itemcode, ALL_Desc as [description]"
                str = str + "		   , ALL_Karat as karat, ALL_Carat as carat, ALL_Weight as weight, Currency , ALL_price as price, ALL_Cost as cost"
                str = str + "		   , SorterName as custodian,getdate() as trandate,'RELEASED' as status,'REM' as costcenter,'" & Trim(userLog) & "' as empname,SerialNO"
                str = str + "	FROM         [REMS].dbo.ASYS_REMOutsource_Detail  where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED' "
                str = str + "	)a"
                obj.commandTrack(str)
                obj.TrackExecute()
                '''09-17-2013 new changes for update--
                str = "Update REMS" & sDB & ".dbo.ASYS_REM_Detail  set reflotno =  " & reflotno & " ,releasedate = getdate(),releaser= '" & Trim(userLog) & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update [REMS].dbo.ASYS_REM_Detail  set reflotno =  " & reflotno & " ,releasedate = getdate(),releaser = '" & Trim(userLog) & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update REMS" & sDB & ".dbo.ASYS_REMOutsource_Detail  set reflotno =  " & reflotno & " ,releasedate = getdate(),releaser = '" & Trim(userLog) & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update [REMS].dbo.ASYS_REMOutsource_Detail  set reflotno =  " & reflotno & " ,releasedate = getdate(),releaser = '" & Trim(userLog) & "',status = 'RELEASED' where refallbarcode = '" & DgEntry(i, 2) & "' and status = 'COSTED'"
                obj.commandTrack(str)
                obj.TrackExecute()

            Next
            obj.Close()
            'cmbreflotno.Text = reflotno
            obj.CommitTrack()
            Label5.Text = rellotno
            rellot = GetNewLotNumber("REM", "")
            MsgBox("Save Successfully", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("frmReleasing/NewREMSAVE: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close()
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
                        objclass.Command("Update tbl_receiving_header set recreleasingid='" & idnumber & "',recreleasingname='" & userLog & "', releasedate=getdate(), status_id= 4 where  recallbarcode='" & Me.DgEntry(a, 1) & "' and sortaction_id in (4,3,8)  and status_id = 3")
                        objclass.Execute()
                        objclass.Command("Update rems.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(), forcedout_status_for= 4 where allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8)  ")
                        objclass.Execute()
                        objclass.Command("Update rems.dbo.tbl_receiving_header set recreleasingid='" & idnumber & "',recreleasingname='" & userLog & "', releasedate=getdate(), status_id= 4 where recallbarcode='" & Me.DgEntry(a, 1) & "'  and sortaction_id in (4,3,8)  and status_id = 3")
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
                        'objclass.Command3("Update remsvismin.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        'objclass.Execute3()
                        objclass.Command3("Update remsvisayas.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        objclass.Execute3()
                        objclass.Command3("Update remsmindanao.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        objclass.Execute3()
                        objclass.Command3("Update remsshowroom.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        objclass.Execute3()
                        'objclass.Command3("Update REMSLNCR.dbo.tbl_forcedoutrcv set recreleasingid_for='" & idnumber & "',recreleasingname_for='" & userLog & "', releasedate_for=getdate(),forcedout_status_for= 4, outsource_status_for= 4 where  allbarcode_for='" & Me.DgEntry(a, 2) & "' and sortaction_id_for in (4,3,8) ")
                        'objclass.Execute3()
                    End If

                Next
            End If


            objclass.Close()
        Catch ex As Exception
            MsgBox("frmReleasing/REMSaveRel: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
                Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.cmbCostCenter.Text = "MLWB"
            If cmbCostCenter.Text = "MLWB" Then
                force = True
                outsource = False
                Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.cmbCostCenter.Text = "MLWB"
            If cmbCostCenter.Text = "MLWB" Then
                force = False
                Me.cmbCostCenter.Focus()
            End If
        Catch ex As Exception
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
        End Try
    End Sub

    Private Sub ReleaseAddrow()
        Try
            Dim li_rowd As Integer = dataTable.Rows.Count
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

            cmbsource = New ComboBox
            cmbsource.Width = 70

            cmbItems = New ComboBox
            cmbItems.Width = 100

            cmbbarcode = New TextBox
            cmbbarcode.Width = 130

            txttext = New TextBox
            txttext.Width = 75

            txtitemdesc = New TextBox
            txtitemdesc.Width = 230

            txtweight = New TextBox
            txtweight.Width = 60

            txtkarat = New TextBox
            txtkarat.Width = 60

            txtcarat = New TextBox
            txtcarat.Width = 60

            txtprice = New TextBox
            txtprice.Width = 100

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
            dgtb.TextBox.Controls.Add(txtweight)
            txtweight.BringToFront()


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

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLotNum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLotNum.Click
        Try
            If Me.cmbCostCenter.Text <> "MLWB" Then
                bleh = True

                Dim li_rowd As Integer = dataTable.Rows.Count

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

                cmbsource = New ComboBox
                cmbsource.Width = 161

                cmbItems = New ComboBox
                cmbItems.Width = 161

                cmbbarcode = New TextBox
                cmbbarcode.Width = 161

                txttext = New TextBox
                txttext.Width = 161

                txtitemdesc = New TextBox
                txtitemdesc.Width = 161

                txtweight = New TextBox
                txtweight.Width = 161

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
                dgtb.TextBox.Controls.Add(cmbItems)
                cmbItems.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbbarcode)
                cmbbarcode.MaxLength = 17
                cmbbarcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmbsource)
                cmbsource.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtitemdesc)
                txtitemdesc.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtweight)
                txtweight.BringToFront()


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

            Else
                bleh = False
            End If

        Catch ex As Exception
            MsgBox("frmReleasing/btnLotNum_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbbarcode.KeyPress
        Try
            Dim obj1 As New clsCommon
            Dim dr1 As SqlDataReader
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim a As Integer

            If cmbbarcode.Text.Length > 16 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar = ChrW(13) Then

                    If cmbbarcode.Text.Length <= 0 Then
                        Exit Sub
                    End If


                    obj1.Connectionstring4()
                    obj1.Open4()
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,photoname,price_desc,price_karat,price_carat,price_weight,all_price,status from (select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,photoname,price_desc,price_karat,price_carat,price_weight,all_price,status from ASYS_REM_Detail where refallbarcode ='" & cmbbarcode.Text & "' union all select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,photoname,price_desc,price_karat,price_carat,price_weight,all_price,status from ASYS_REMOutsource_Detail where refallbarcode ='" & cmbbarcode.Text & "')a where status not in ('RECMLWB')"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        If obj.Newstatus(dr.Item("status")) < 3 And Me.cmbCostCenter.Text = "MLWB" Then
                            MsgBox("Not yet Costed", MsgBoxStyle.Information, TitleMsgBox)
                            cmbbarcode.Text = ""
                            cmbbarcode.Focus()
                        ElseIf obj.Newstatus(dr.Item("status")) = 4 And Me.cmbCostCenter.Text = "MLWB" Then
                            MsgBox("ALLBarcode already released", MsgBoxStyle.Information, TitleMsgBox)
                            cmbbarcode.Text = ""
                            cmbbarcode.Focus()
                        ElseIf obj.Newstatus(dr.Item("status")) = 3 Or obj.Newstatus(dr.Item("status")) = 1 Then
                            If obj.IsNull(dr.Item("Photoname")) <> "0" Then
                                If dataTable.Rows.Count > 1 Then

                                    For a = 0 To dataTable.Rows.Count - 1

                                        ''If IsNumeric(DgEntry(a, 1)) = False Then
                                        ''    MsgBox("pag tarung woi...", MsgBoxStyle.Information, TitleMsgBox)
                                        ''    Exit Sub
                                        ''End If

                                        If DgEntry(a, 2) = cmbbarcode.Text Then
                                            MsgBox("You have inputed the same barcode", MsgBoxStyle.Information, TitleMsgBox)
                                            cmbbarcode.Text = ""

                                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                                            DgEntry.Focus()

                                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                                            cmbbarcode.Focus()
                                            Exit For
                                        Else
                                            If a = dataTable.Rows.Count - 1 Then
                                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = obj.IsNull(dr.Item("ptn"))
                                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = cmbbarcode.Text
                                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(cmbbarcode.Text, 4, 5)


                                                If obj.IsNull(dr.Item("all_price")) = "0" Then
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("ALL_DESC")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("ALL_weight")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("ALL_karat")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("all_carat")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                                                Else
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("Price_desc")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("Price_weight")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("Price_karat")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("Price_carat")
                                                    DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                                                End If

                                                btnSave.Enabled = True
                                                Button6.Enabled = True
                                                btnLotNum_Click(sender, e)
                                                If Me.cmbCostCenter.Text = "MLWB" Then
                                                    ReleaseAddrow()
                                                End If
                                                Exit For
                                            End If
                                        End If

                                    Next
                                Else
                                    DgEntry(DgEntry.CurrentCell.RowNumber, 2) = cmbbarcode.Text
                                    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = obj.IsNull(dr.Item("ptn"))
                                    DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Mid(cmbbarcode.Text, 4, 5)

                                    If obj.IsNull(dr.Item("all_price")) = "0" Then
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("ALL_DESC")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("ALL_weight")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("ALL_karat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("all_carat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                                    Else
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 4) = dr.Item("Price_desc")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = dr.Item("Price_weight")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = dr.Item("Price_karat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 7) = dr.Item("Price_carat")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                                    End If
                                    btnSave.Enabled = True
                                    Button6.Enabled = True
                                    btnLotNum_Click(sender, e)
                                    If Me.cmbCostCenter.Text = "MLWB" Then
                                        ReleaseAddrow()
                                    End If
                                End If
                            Else
                                MsgBox("A.L.L. Barcode doesn't have photo", MsgBoxStyle.Information, TitleMsgBox)
                                cmbbarcode.Text = ""
                                cmbbarcode.Focus()
                            End If
                        End If
                    Else
                        MsgBox("A.L.L. Barcode doesn't exist", MsgBoxStyle.Information, TitleMsgBox)
                        cmbbarcode.Text = ""
                        cmbbarcode.Focus()
                    End If

                    dr.Close()
                    ' obj.Execute3()
                    obj.Close3()
                End If
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                DgEntry.Focus()
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmReleasing/cmbbarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                        MsgBox("PTN doesn't exist", MsgBoxStyle.Information, TitleMsgBox)
                        cmbItems.Text = ""
                        cmbItems.Focus()
                    End If
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmReleasing/cmbItems_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("frmReleasing/cmbsource_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try

            If SelectedForm = "frmReleasingReceiving" Then
                Exit Sub
            End If

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            sDB = ""

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            Button7.SetBounds(328, 56, 104, 24)
            Label5.Visible = True
            Me.btnLot.Visible = True
            Me.btnLotNum.Visible = False
            Me.cmbreflotno.Visible = True
            lblBcCode.Visible = False
            lblBCode.Visible = False
            cmbBCcode.Visible = False
            Label11.Visible = False
            Label12.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Me.cmbreflotno.Visible = True
            Label4.Visible = True
            txtbc.Visible = False
            Me.ComboBox1.Visible = False
            Me.ComboBox2.Visible = False
            Me.cmbreflotno.Enabled = True
            outsource = True
            'Me.Label5.Text = GetNewLotNumber("REM", "")
            cmbreflotno.Items.Clear()
            cmbCostCenter.Text = "MLWB"
            force = False
            str = "select reflotno as lotno from ASYS_REMOutsource_Detail where status = 'COSTED' and actionclass in ('Return','Outsource','Cellular','Watch')  group by reflotno order by reflotno desc"
            'str = "select reflotno as lotno from ASYS_REMOutsource_Detail where status = 'COSTED' and actionclass in ('Return','Outsource','GoodStock','Cellular','Watch')  group by reflotno order by reflotno desc"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            While dr.Read
                Me.cmbreflotno.Items.Add(dr.Item("lotno"))
            End While
            dr.Close()
            'obj.Execute3()
            obj.Close3()

            Me.cmbreflotno.Focus()

        Catch ex As Exception
            MsgBox("frmReleasing/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub cmbreflotno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbreflotno.SelectedIndexChanged
    '    Try
    '        Dim obj As New clsCommon
    '        Dim dr As SqlDataReader
    '        Dim str As String
    '        Dim temp, a As Integer

    '        Me.ListView1.Items.Clear()
    '        dataTable.Rows.Clear()

    '        obj.Connectionstring3()
    '        obj.Open3()

    '        If Me.cmbCostCenter.Text = "MLWB" Then
    '            str = "Select Count(lotno_for) as lotno from tbl_forcedoutrcv where lotno_for ='" & Me.cmbreflotno.Text & "' and forcedout_status_for=5 and outsource_status_for = 4 "
    '            obj.Command3(str)
    '            dr = obj.OpenDataReader3
    '            If dr.Read Then
    '                temp = dr.Item("lotno")
    '                If temp >= 1 Then
    '                    outsource = True
    '                Else
    '                    outsource = False
    '                End If
    '            End If
    '            dr.Close()
    '            obj.Execute3()
    '            obj.Close3()
    '        End If

    '        If Me.cmbCostCenter.Text = "PRICING" Then
    '            str = "Select PTN_rec,ALLBarcode_Rec,lotno_rec from tbl_recrel_PRICING where lotno_rec='" & Me.cmbreflotno.Text & "' and status_id_rec= 1 and prcingstat = 1"
    '            obj.Command3(str)
    '            dr = obj.OpenDataReader3
    '            While dr.Read
    '                Me.ListView1.Items.Add(dr.Item("ALLBarcode_rec"))
    '                Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr.Item("PTN_rec"))
    '                Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr.Item("lotno_rec"))
    '            End While
    '            dr.Close()

    '            For a = 0 To Me.ListView1.Items.Count - 1
    '                str = "Select Count(Allbarcode_for) as barcode from tbl_forcedoutrcv where ALLbarcode_for='" & Me.ListView1.Items(a).SubItems.Item(0).Text & "' and forcedout_status_for= 7 and outsource_status_for = 4 "
    '                obj.Command3(str)
    '                dr = obj.OpenDataReader3
    '                If dr.Read Then
    '                    temp = dr.Item("barcode")
    '                    If temp >= 1 Then
    '                        Me.ListView1.Items(a).SubItems.Add("Outsource")
    '                    Else
    '                        Me.ListView1.Items(a).SubItems.Add("Force")
    '                    End If
    '                End If
    '                dr.Close()
    '            Next
    '            obj.Execute3()
    '            obj.Close3()
    '        End If
    '        If Me.cmbCostCenter.Text = "DISTRI" Then
    '            str = "Select PTN_rec,ALLBarcode_Rec,lotno_rec from tbl_recrel_DISTRI where lotno_rec='" & Me.cmbreflotno.Text & "' and status_id_rec= 3 "
    '            obj.Command3(str)
    '            dr = obj.OpenDataReader3
    '            While dr.Read
    '                Me.ListView1.Items.Add(dr.Item("ALLBarcode_rec"))
    '                Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr.Item("PTN_rec"))
    '                Me.ListView1.Items(Me.ListView1.Items.Count - 1).SubItems.Add(dr.Item("lotno_rec"))
    '            End While
    '            dr.Close()

    '            For a = 0 To Me.ListView1.Items.Count - 1
    '                str = "Select Count(Allbarcode_for) as barcode from tbl_forcedoutrcv where ALLbarcode_for='" & Me.ListView1.Items(a).SubItems.Item(0).Text & "' and forcedout_status_for= 9 and outsource_status_for = 4 "
    '                obj.Command3(str)
    '                dr = obj.OpenDataReader3
    '                If dr.Read Then
    '                    temp = dr.Item("barcode")
    '                    If temp >= 1 Then
    '                        Me.ListView1.Items(a).SubItems.Add("Outsource")
    '                    Else
    '                        Me.ListView1.Items(a).SubItems.Add("Force")
    '                    End If
    '                End If
    '                dr.Close()
    '            Next
    '            obj.Execute3()
    '            obj.Close3()
    '        End If
    '        Label9.Text = dataTable.Rows.Count
    '    Catch ex As Exception
    '        msgbox(ex.message,,TitleMsgBox)
    '    End Try
    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmVPRelease_rpt
            frm.txtBranchCode.Text = txtbc.Text
            frm.txtBRanchname.Text = lblBcCode.Text
            frm.Text = "RELEASING REPORT"
            frm.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim frm As New Report
            If outsource = False And bleh = False Then
                frm.Label2.Text = "MONTH"
                frm.TextBox1.Text = reflotno
                frm.Lot.Text = reflotno
                frm.Label6.Visible = True
                frm.TextBox2.Visible = True
            ElseIf bleh = True Then
                frm.TextBox1.Text = reflotno
                frm.Label6.Visible = True
                frm.TextBox2.Visible = False
                frm.Label5.Text = "LOTNO"
                frm.Label5.Visible = False
                frm.TextBox1.Visible = True
            End If

            frm.Text = "RELEASING REPORT"
            recrelrep = False
            frm.Show()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbreflotno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbreflotno.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
            e.Handled = True
        End If
        Try
            If e.KeyChar = ChrW(13) Then
                Me.Cursor = Cursors.WaitCursor
                addrow()
                Label9.Text = dataTable.Rows.Count
                If Label9.Text <> "0" Then
                    Button6.Enabled = True
                Else
                    Button6.Enabled = False
                End If
                Me.Cursor = Cursors.Arrow
                btnSave.Focus()
            End If

        Catch ex As Exception
            MsgBox("frmReleasing/cmbreflotno_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCostCenter.TextChanged
        Try
            If sDB <> "" Then
                If cmbCostCenter.Text = "MLWB" And outsource = False Then
                    DgEntry.BringToFront()
                    GroupBox1.BringToFront()
                    GroupBox2.BringToFront()
                    Label7.BringToFront()
                    Button5.Visible = True
                    btnVPPrint.Visible = False
                    Me.ComboBox2.Text = Now.Year
                    Me.cmbreflotno.Visible = True
                    Me.ComboBox3.Visible = False
                    Me.Label13.Visible = False
                    btnLot.Visible = False
                    btnLotNum.Visible = False
                    txtbc.Visible = False
                    cmbBCcode.Visible = False
                    Me.ComboBox1.Visible = True
                    Me.ComboBox2.Visible = True
                    lblBcCode.Visible = False
                    Button7.Visible = True
                    lblBCode.Visible = False
                    Label11.Visible = True
                    Label12.Visible = True
                    Label5.Visible = False
                    btnSearch.Visible = True
                    Label4.Visible = True
                    Me.Button5.Visible = True
                    Button4.Visible = False
                    Label14.Visible = False
                    Label15.Visible = False
                    GroupBox4.SendToBack()
                    Label8.Text = "TOTAL NO. OF ITEMS"
                    'DgEntry.ReadOnly = True
                    'DgEntry.Enabled = False
                ElseIf cmbCostCenter.Text = "VP" Then
                    'DgEntry.Enabled = False
                    'DgEntry.ReadOnly = True
                    btnSearch.Visible = False
                    Button5.Visible = True
                    btnVPPrint.Visible = True
                    Label8.Text = "TOTAL QTY."
                    ListView2.BringToFront()
                    Me.ComboBox3.Visible = True
                    Me.Label13.Visible = True
                    Me.ComboBox1.Visible = True
                    Me.ComboBox2.Visible = True
                    Me.cmbreflotno.Visible = False
                    Button7.Visible = False
                    Button5.Visible = False
                    txtbc.Visible = True
                    lblBcCode.Visible = True
                    Label14.Visible = True
                    Label15.Visible = True
                    lblBCode.Visible = True
                    cmbBCcode.Visible = True
                    Label11.Visible = True
                    Label12.Visible = True
                    Label4.Visible = False
                    btnLot.Visible = False
                    btnLotNum.Visible = False
                    Label5.Visible = False
                    Label15.Text = "0"
                    ComboBox3.Focus()
                    GroupBox4.SendToBack()
                Else
                    Label8.Text = "TOTAL NO. OF ITEMS"
                    btnSearch.Visible = True
                    Me.ComboBox2.Text = Now.Year
                    Me.cmbreflotno.Visible = True
                    Me.ComboBox3.Visible = False
                    Me.Label13.Visible = False
                    btnLot.Visible = False
                    btnLotNum.Visible = False
                    txtbc.Visible = False
                    cmbBCcode.Visible = False
                    Me.ComboBox1.Visible = False
                    Me.ComboBox2.Visible = False
                    lblBcCode.Visible = False
                    Button7.Visible = True
                    lblBCode.Visible = False
                    Label11.Visible = False
                    Label12.Visible = False
                    Label5.Visible = False
                    Label4.Visible = True
                    Me.Button5.Visible = True
                    Button4.Visible = True
                    Label14.Visible = False
                    Label15.Visible = False
                    cmbCostCenter.Text = "MLWB"
                    ListView2.Visible = False
                    DgEntry.BringToFront()
                    GroupBox1.BringToFront()
                    GroupBox2.BringToFront()
                    GroupBox4.SendToBack()
                    Label7.BringToFront()
                    Button5.Visible = True
                    btnVPPrint.Visible = False

                    'DgEntry.ReadOnly = True
                    'DgEntry.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try


            If bleh = True Then
                If Me.cmbbarcode.Text <> "" Then
                    Label9.Text = dataTable.Rows.Count - 1
                End If
            End If

            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 0
                    txttext.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0).ToString

                Case 1
                    cmbbarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1).ToString

                Case 2
                    cmbItems.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2).ToString

                Case 3
                    cmbsource.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 3).ToString

                Case 4
                    txtitemdesc.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 4).ToString

                Case 5
                    txtweight.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 5).ToString

                Case 6
                    txtkarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 6).ToString

                Case 7
                    txtcarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 7).ToString

                Case 8
                    txtprice.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 8).ToString

            End Select
        Catch ex As Exception
            'MsgBox("frmReleasing/DgEntry_CurrentCellChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCostCenter.SelectedIndexChanged
        Try
            dataTable.Clear()

            ListView2.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub REMAddRow()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim li_row As Integer
            Dim str As String

            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()
            btnLot.Visible = True
            Label5.Visible = True
            str = "select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from (select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from ASYS_REM_Detail  where Year(sortdate) ='" & ComboBox2.Text & "'  and month(sortdate) = '" & ComboBox1.SelectedIndex + 1 & "' and costname = '" & Me.cb.Text & "' and actionclass in ('GoodStock','Watch','Cellular') and status = 'COSTED' union all select refallbarcode,ptn,all_desc,all_weight,all_karat,all_carat,all_cost,all_price from ASYS_REMOutsource_Detail  where Year(sortdate) ='" & ComboBox2.Text & "'  and month(sortdate) = '" & ComboBox1.SelectedIndex + 1 & "' and costname = '" & Me.cb.Text & "' and status = 'COSTED' )a order by refallbarcode"
            obj.Command(str)
            dr = obj.OpenDataReader
            While dr.Read
                dataTable.LoadDataRow(arrstr, True)
                DgEntry(li_row, 0) = li_row + 1
                DgEntry(li_row, 1) = obj.IsNull(dr.Item("ptn"))
                DgEntry(li_row, 2) = obj.IsNull(dr.Item("refallbarcode"))
                DgEntry(li_row, 3) = Mid(obj.IsNull(dr.Item("refallbarcode")), 4, 5)
                DgEntry(li_row, 4) = obj.IsNull(dr.Item("all_desc"))
                DgEntry(li_row, 5) = obj.IsNull(dr.Item("alL_weight"))
                DgEntry(li_row, 6) = obj.IsNull(dr.Item("all_karat"))
                DgEntry(li_row, 7) = obj.IsNull(dr.Item("all_carat"))
                DgEntry(li_row, 8) = FormatNumber(obj.IsNull(dr.Item("all_price")))
                DgEntry(li_row, 9) = "DELETE"
                li_row = li_row + 1
                btnSave.Enabled = True
                Button6.Enabled = True
            End While
            dr.Close()
            obj.Close()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try

            Dim baddz As New clsCommon
            Dim baddzdr As SqlDataReader
            Dim bz As New clsCommon
            Dim dr As SqlDataReader
            Dim rdr As SqlDataReader
            Dim bstr As String
            Dim squery As String
            Dim conn As New clsCommon
            Dim dr1 As SqlDataReader
            Dim con As New clsCommon
            Dim squery2, squery3 As String
            Dim temp As String
            Dim li_row As Integer = dataTable.Rows.Count
            Dim a, b, c, d, i, u As Integer
            Dim tmppackctr As Integer = 0

            If e.KeyChar = ChrW(13) Then
                dataTable.Rows.Clear()
                ListView2.Items.Clear()

                a = Now.MinValue.Day
                b = Now.MaxValue.Day
                c = Now.Year
                bleh = False
                ds_dataset.Reset()
                If Me.cmbCostCenter.Text = "MLWB" Then
                    If force = False And outsource = False Then

                        Call REMAddRow()

                        Label9.Text = dataTable.Rows.Count
                        DgEntry.CurrentCell = New DataGridCell(li_row, 0)
                        DgEntry.Focus()

                        'ElseIf force = True Then
                        '    Call releaseForceitems()
                    End If


                ElseIf cmbCostCenter.Text = "VP" Then

                    Label5.Visible = False
                    btnLotNum.Visible = False
                    btnLot.Visible = False

                    If ComboBox3.Text = "" Then
                        MsgBox("Action is empty ", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    ElseIf txtbc.Text = "" Or txtbc.Text.Length <> 3 Then
                        MsgBox("Invalid Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    ElseIf lblBcCode.Text = "" Then
                        MsgBox("Branch Name is empty", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    ElseIf txtbc.Text = "" And lblBcCode.Text = "" Then
                        MsgBox("Branch Code is empty", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    ElseIf ComboBox2.Text = "" Or ComboBox1.Text = "" Then
                        MsgBox("Select month and year.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If

                    Dim obj As New clsCommon
                    Dim str As String
                    Dim tmpPTN As String

                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()


                    If ComboBox3.Text.ToUpper = "TRADE-IN" Then

                        str = "SELECT     b.Transaction_No as ptn, a.Itemcode as refitemcode, a.Description as all_desc, a.Quantity as refqty, "
                        str = str + " a.Karat as all_karat, a.Carat as all_carat, 'O' AS SortCode, a.Weight as all_weight, b.Appraisal_Amount as loanvalue, '0' as all_cost,a.item_id as itemid"
                        str = str + " FROM         dbo.ASYS_TradeIN_Detail a INNER JOIN"
                        str = str + "                      dbo.ASYS_TradeIN_Header b ON a.Transaction_No = b.Transaction_No"
                        str = str + " where Year(a.receivedate ) = '" & ComboBox2.Text & "' and month(a.receivedate) = '" & ComboBox1.SelectedIndex + 1 & "' and b.division = '" & txtbc.Text & "' and a.status = 'RECEIVED'"
                        str = str + " order by a.transaction_no"

                    Else
                        If ComboBox3.Text.ToUpper = "MISSING ITEM" Then
                            ComboBox3.Text = "MISSINGITEM"
                        End If

                        str = "SELECT     a.PTN, a.LoanValue, b.itemid,b.RefItemcode, b.RefQty, b.ALL_Desc, b.ALL_Karat, b.ALL_Carat, b.ALL_Weight, b.ALL_Cost, b.SortCode FROM rems" & sDB & ".dbo.ASYS_REM_Header a INNER JOIN rems" & sDB & ".dbo.ASYS_REM_Detail b ON a.PTN = b.PTN where Year(b.sortdate) ='" & ComboBox2.Text & "'  and month(b.sortdate) = '" & ComboBox1.SelectedIndex + 1 & "' and a.branchcode = '" & txtbc.Text & "' and  b.actionclass = '" & Replace(ComboBox3.Text, " ", "") & "' and b.status = 'SORTED' order by b.ptn"

                    End If

                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    Dim tmpctr As Integer

                    While dr.Read
                        'ListView2.Items.Add(li_row + 1)

                        If dr.Item("PTN") <> tmpPTN Then
                            tmppackctr = tmppackctr + 1
                        End If

                        ListView2.Items.Add(ListView2.Items.Count + 1)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("PTN")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("refitemcode")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("all_desc")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("Refqty")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("all_karat")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("all_carat")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("sortcode")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("all_weight")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("loanvalue"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("all_cost")), 2, TriState.UseDefault))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("itemid")))
                        tmpctr = tmpctr + CInt(obj.IsNull(dr.Item("Refqty")))
                        li_row = li_row + 1
                        tmpPTN = dr.Item("PTN")
                    End While

                    If li_row <= 0 Then
                        If ComboBox1.Text.Length > 0 Then
                            MsgBox("No Data found.", MsgBoxStyle.Information, TitleMsgBox)
                        End If
                        Exit Sub
                    End If

                    dr.Close()
                    obj.Close()



                    ' Label9.Text = ListView2.Items.Count


                    If ComboBox3.Text.ToUpper = "TRADE-IN" Then
                        ''Dim tempa, s As Integer
                        Dim s As Integer
                        If Me.ListView2.Items.Count > 0 Then
                            ''For u = 0 To ListView2.Items.Count - 1
                            ''    s = ListView2.Items(u).SubItems.Item(4).Text
                            ''    tempa = tempa + s
                            ''Next
                            btnSave.Enabled = True
                            Button6.Enabled = True '''gm enable delete button 08-01-2012
                        End If
                        ''Me.Label9.Text = ListView2.Items.Count
                        ''Me.Label15.Text = tempa
                        Me.Label9.Text = tmpctr
                        Me.Label15.Text = ListView2.Items.Count 'tempa

                        Dim tempptn As String

                        If Me.ListView2.Items.Count > 0 Then
                            For u = 0 To ListView2.Items.Count - 1
                                If u = 0 Then
                                    s = 1
                                    tempptn = ListView2.Items(u).SubItems.Item(1).Text
                                Else
                                    If ListView2.Items(u).SubItems.Item(1).Text <> tempptn Then
                                        s = s + 1
                                        tempptn = ListView2.Items(u).SubItems.Item(1).Text
                                    End If
                                End If

                            Next
                        End If

                        Me.Label15.Text = s

                    Else

                        ''Dim tempa, s As Integer
                        ''If Me.ListView2.Items.Count > 0 Then
                        ''    For u = 0 To ListView2.Items.Count - 1
                        ''        s = ListView2.Items(u).SubItems.Item(4).Text
                        ''        tempa = tempa + s
                        ''    Next
                        btnSave.Enabled = True
                        Button6.Enabled = True '''gm enable delete button 08-01-2012
                        ''End If

                        Me.Label9.Text = tmpctr
                        Me.Label15.Text = tmppackctr

                        ''objclass = New clsCommon
                        ''objclass.ConnectionString1()
                        ''objclass.Open()

                        ''squery3 = "select count(ptn) as noofpacks"
                        ''squery3 = squery3 + " from ( SELECT  dbo.ASYS_REM_Detail.ptn"
                        ''squery3 = squery3 + " FROM         dbo.ASYS_REM_Detail  INNER JOIN"
                        ''squery3 = squery3 + " dbo.ASYS_REM_Header  ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN"
                        ''squery3 = squery3 + " WHERE     (YEAR(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox2.Text & "') AND (MONTH(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox1.SelectedIndex + 1 & "') AND (dbo.ASYS_REM_Header.BranchCode = '" & txtbc.Text & "') "
                        ''squery3 = squery3 + " AND (dbo.ASYS_REM_Detail.Status = 'SORTED')"
                        ''squery3 = squery3 + " AND (dbo.ASYS_REM_Detail.actionclass = '" & Replace(ComboBox3.Text, " ", "") & "')"
                        ''squery3 = squery3 + " group by dbo.ASYS_REM_Detail.ptn)a"

                        ''objclass.Command(squery3)
                        ''rdr = objclass.OpenDataReader()
                        ''If rdr.Read Then
                        ''    Me.Label15.Text = rdr.Item("Noofpacks")
                        ''    btnSave.Enabled = True
                        ''End If
                        ''rdr.Close()
                        ''objclass.CloseDataReader()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmReleasing/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)

        End Try
    End Sub

    Private Sub txtbc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbc.TextChanged
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtbc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbc.KeyPress
        Try
            Dim dr As SqlDataReader
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                    'ElseIf UCase(sDB) = "VISMIN" Then
                    '    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                ElseIf UCase(sDB) = "VISAYAS" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                End If
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    Me.lblBcCode.Text = UCase(dr.Item("bedrnm"))
                    Me.ComboBox1.Focus()
                Else
                    txtbc.Focus()
                End If
                dr.Close()
                'objclass.Execute5()
                objclass.Close5()

                ComboBox1_KeyPress(sender, e)
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If ComboBox3.Text = "" Then
                    MsgBox("Please select actionclass", MsgBoxStyle.Information, TitleMsgBox)
                    ComboBox3.Focus()
                    Exit Sub
                Else
                    txtbc.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCostCenter_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCostCenter.MouseUp
        Try
            If sDB = "" Then
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")

                'cmbCostCenter.Text = "MLWB"
            Else
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")
                cmbCostCenter.Items.Add("VP")
                'cmbCostCenter.Text = "MLWB"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCostCenter_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbCostCenter.MouseWheel
        Try
            If sDB = "" Then
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")
                'cmbCostCenter.Text = "MLWB"
            Else
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("MLWB")
                cmbCostCenter.Items.Add("VP")
                'cmbCostCenter.Text = "MLWB"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim rply As Integer
            Dim u, s, tempa As Integer
            Dim tempptn As String
            rply = MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                If cmbCostCenter.Text = "MLWB" Then
                    dataTable.Rows.RemoveAt(DgEntry.CurrentCell.RowNumber)
                    Label9.Text = dataTable.Rows.Count
                Else
                    ListView2.FocusedItem.Remove()
                    ' Label9.Text = ListView2.Items.Count
                    If Me.ListView2.Items.Count > 0 Then
                        For x As Integer = 0 To ListView2.Items.Count - 1
                            Label9.Text = ListView2.Items(x).SubItems.Item(4).Text
                        Next
                    Else
                        Label9.Text = "0"
                    End If
                    If Me.ListView2.Items.Count > 0 Then
                        For u = 0 To ListView2.Items.Count - 1
                            If u = 0 Then
                                s = 1
                                tempptn = ListView2.Items(u).SubItems.Item(1).Text
                            Else
                                If ListView2.Items(u).SubItems.Item(1).Text <> tempptn Then
                                    s = s + 1
                                    tempptn = ListView2.Items(u).SubItems.Item(1).Text
                                End If
                            End If

                        Next
                    End If

                    Me.Label15.Text = s
                End If
            Else
                Exit Sub
            End If



            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            DgEntry.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.TextChanged
        Try
            Label5.Text = rellotno
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim li_rowd As Integer = dataTable.Rows.Count
            Dim Addrow As String
            If dataTable.Rows.Count = 0 Then
addrow:
                bleh = True
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

                cmbsource = New ComboBox
                cmbsource.Width = 70

                cmbItems = New ComboBox
                cmbItems.Width = 130

                cmbbarcode = New TextBox
                cmbbarcode.Width = 130

                txttext = New TextBox
                txttext.Width = 75

                txtitemdesc = New TextBox
                txtitemdesc.Width = 230

                txtweight = New TextBox
                txtweight.Width = 60

                txtkarat = New TextBox
                txtkarat.Width = 60

                txtcarat = New TextBox
                txtcarat.Width = 60

                txtprice = New TextBox
                txtprice.Width = 100

                cmdDelete = New Button


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
                dgtb.TextBox.Controls.Add(txtweight)
                txtweight.BringToFront()


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

                'ctrRow = ctrRow + 1
                DgEntry(li_rowd, 0) = li_rowd + 1 'ctrRow


                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            ElseIf li_rowd = dataTable.Rows.Count And cmbbarcode.Text <> "" And cmbbarcode.Text.Length = 17 And txtitemdesc.Text.Length > 3 Then
                GoTo addrow
            ElseIf dataTable.Rows.Count = 0 Or cmbbarcode.Text <> "" And cmbbarcode.Text.Length = 17 And txtitemdesc.Text.Length > 3 Then
                GoTo addrow
            ElseIf Label9.Text <> 0 And txtitemdesc.Text = "" Then

                If DgEntry(li_rowd - 1, 2) <> "" Then
                    GoTo Addrow
                    Exit Sub
                End If

                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            Else
                DgEntry.CurrentCell = New DataGridCell(li_rowd, 2)
                DgEntry.Focus()
                cmbbarcode.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.SelectedIndexChanged
        Try
            Dim con As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String
            squery = "Select res_id from " & humres2 & " where fullname='" & Me.cb.SelectedItem & "'"
            con.ConnDb()
            con.Open5()
            con.Command5(squery)
            dr = con.OpenDataReader5
            If dr.Read Then
                Me.Label6.Text = dr.Item("res_id")
            End If
            dr.Close()
            con.Execute5()
            con.Close5()
        Catch ex As Exception
            MsgBox("frmReleasing/cb_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function tuig()
        Try
            Dim tu, ig As Integer

            ig = Now.Year
            For tu = 1 To 5
                Me.ComboBox2.Items.Add(ig)
                ig = ig - 1
            Next
        Catch ex As Exception
        End Try
    End Function

    Private Sub cmbCostCenter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCostCenter.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                ComboBox1.Focus()
            Else
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmReleasing/cmbCostCenter_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtitemdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtitemdesc.KeyPress
        Try
            If Me.txtitemdesc.Text.Length > 99 Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        Try
            If e.KeyCode <> Keys.Enter Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnVPPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPPrint.Click
        Try
            Dim frm As New frmVPRelease_rpt
            frm.txtBranchCode.Text = txtbc.Text
            frm.txtBRanchname.Text = lblBcCode.Text.Trim
            frm.Print_VPReleasing(ComboBox3.Text.Trim)
            frm.Text = "RELEASING REPORT"
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frm As New frmSearchLotno
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtitemdesc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtitemdesc.LostFocus
        Try
            txtitemdesc.Text = txtitemdesc.Text.Replace("'", "`")
        Catch ex As Exception
        End Try
    End Sub
End Class

