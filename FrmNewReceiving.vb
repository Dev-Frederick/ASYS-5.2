Imports System.Data.SqlClient
Imports System.IO
Public Class FrmNewReceiving
    Inherits System.Windows.Forms.Form
    Private WithEvents cmbItems As System.Windows.Forms.ComboBox
    Private WithEvents cmbsource As System.Windows.Forms.ComboBox

    'textbox
    Private WithEvents txttext As System.Windows.Forms.TextBox

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
    Public sDatabase2 As String
    Public sUsername2 As String
    Public sPassword2 As String
    Dim objclass As New clsCommon
    Dim objcommon As New clsCommon
    Private dt As dataTable
    Private dv As DataView
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Dim dr As SqlDataReader
    Dim msgY, msgP, msgK, msgH As String
    Dim tmpUserName As String


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
    Friend WithEvents lblReceive As System.Windows.Forms.Label
    Friend WithEvents lblCostCenter As System.Windows.Forms.Label
    Friend WithEvents lblDateReleased As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblBCode As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReceiving As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtbc As System.Windows.Forms.TextBox
    Friend WithEvents lblBcCode As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cb As System.Windows.Forms.ComboBox
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
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUnreceived As System.Windows.Forms.Button
    Friend WithEvents txtCostCenter As System.Windows.Forms.TextBox
    Friend WithEvents BCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmNewReceiving))
        Me.AsysReleasing = New System.Windows.Forms.Label
        Me.lbl1FA01 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCostCenter = New System.Windows.Forms.TextBox
        Me.lblReceive = New System.Windows.Forms.Label
        Me.lblCostCenter = New System.Windows.Forms.Label
        Me.lblDateReleased = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.cb = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtbc = New System.Windows.Forms.TextBox
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMonth = New System.Windows.Forms.Label
        Me.lblBCode = New System.Windows.Forms.Label
        Me.lblBcCode = New System.Windows.Forms.Label
        Me.BCode = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnReceiving = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnUnreceived = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
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
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
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
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
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
        Me.GroupBox1.Controls.Add(Me.lblReceive)
        Me.GroupBox1.Controls.Add(Me.lblCostCenter)
        Me.GroupBox1.Controls.Add(Me.lblDateReleased)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.cb)
        Me.GroupBox1.Location = New System.Drawing.Point(536, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 128)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        '
        'txtCostCenter
        '
        Me.txtCostCenter.Location = New System.Drawing.Point(112, 56)
        Me.txtCostCenter.Name = "txtCostCenter"
        Me.txtCostCenter.ReadOnly = True
        Me.txtCostCenter.Size = New System.Drawing.Size(152, 20)
        Me.txtCostCenter.TabIndex = 142
        Me.txtCostCenter.Text = ""
        '
        'lblReceive
        '
        Me.lblReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblReceive.Location = New System.Drawing.Point(16, 24)
        Me.lblReceive.Name = "lblReceive"
        Me.lblReceive.Size = New System.Drawing.Size(72, 16)
        Me.lblReceive.TabIndex = 108
        Me.lblReceive.Text = "USERNAME"
        '
        'lblCostCenter
        '
        Me.lblCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostCenter.Location = New System.Drawing.Point(16, 56)
        Me.lblCostCenter.Name = "lblCostCenter"
        Me.lblCostCenter.Size = New System.Drawing.Size(88, 16)
        Me.lblCostCenter.TabIndex = 112
        Me.lblCostCenter.Text = "COST CENTER"
        '
        'lblDateReleased
        '
        Me.lblDateReleased.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateReleased.Location = New System.Drawing.Point(16, 88)
        Me.lblDateReleased.Name = "lblDateReleased"
        Me.lblDateReleased.Size = New System.Drawing.Size(96, 16)
        Me.lblDateReleased.TabIndex = 114
        Me.lblDateReleased.Text = "DATE RECEIVED"
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(112, 88)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(152, 20)
        Me.txtDate.TabIndex = 127
        Me.txtDate.Text = ""
        '
        'cb
        '
        Me.cb.BackColor = System.Drawing.SystemColors.Menu
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb.Location = New System.Drawing.Point(112, 24)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(152, 21)
        Me.cb.TabIndex = 141
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txtbc)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblMonth)
        Me.GroupBox2.Controls.Add(Me.lblBCode)
        Me.GroupBox2.Controls.Add(Me.lblBcCode)
        Me.GroupBox2.Controls.Add(Me.BCode)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 128)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(183, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 147
        Me.Button2.Text = "..."
        Me.Button2.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(60, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 18)
        Me.Label12.TabIndex = 146
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(10, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "LOT NO"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"REMATADO", "TRADE-IN"})
        Me.ComboBox3.Location = New System.Drawing.Point(60, 24)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(232, 21)
        Me.ComboBox3.TabIndex = 144
        Me.ComboBox3.Text = "REMATADO"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(10, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "TYPE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(132, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 142
        Me.Label8.Text = "MONTH"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(60, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox1.TabIndex = 141
        '
        'txtbc
        '
        Me.txtbc.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbc.Location = New System.Drawing.Point(60, 48)
        Me.txtbc.MaxLength = 3
        Me.txtbc.Name = "txtbc"
        Me.txtbc.Size = New System.Drawing.Size(64, 20)
        Me.txtbc.TabIndex = 1
        Me.txtbc.Text = ""
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbMonth.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.cmbMonth.Location = New System.Drawing.Point(200, 72)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(112, 21)
        Me.cmbMonth.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(394, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "(PRENDA MONTH)"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(394, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "(PRENDA BCODE)"
        '
        'lblMonth
        '
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMonth.Location = New System.Drawing.Point(10, 72)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 16)
        Me.lblMonth.TabIndex = 129
        Me.lblMonth.Text = "YEAR"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBCode
        '
        Me.lblBCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBCode.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBCode.Location = New System.Drawing.Point(10, 48)
        Me.lblBCode.Name = "lblBCode"
        Me.lblBCode.Size = New System.Drawing.Size(48, 16)
        Me.lblBCode.TabIndex = 127
        Me.lblBCode.Text = "BCODE"
        Me.lblBCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBcCode
        '
        Me.lblBcCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBcCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBcCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBcCode.Location = New System.Drawing.Point(128, 48)
        Me.lblBcCode.Name = "lblBcCode"
        Me.lblBcCode.Size = New System.Drawing.Size(216, 18)
        Me.lblBcCode.TabIndex = 140
        Me.lblBcCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BCode
        '
        Me.BCode.Location = New System.Drawing.Point(128, 48)
        Me.BCode.Name = "BCode"
        Me.BCode.Size = New System.Drawing.Size(216, 20)
        Me.BCode.TabIndex = 148
        Me.BCode.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"asc", "desc"})
        Me.ComboBox2.Location = New System.Drawing.Point(192, 48)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox2.TabIndex = 143
        Me.ComboBox2.Text = "desc"
        Me.ComboBox2.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(176, 536)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(48, 20)
        Me.txtTotal.TabIndex = 134
        Me.txtTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(8, 536)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "TOTAL NUMBER OF PACKS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnReceiving
        '
        Me.btnReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceiving.Image = CType(resources.GetObject("btnReceiving.Image"), System.Drawing.Image)
        Me.btnReceiving.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnReceiving.Location = New System.Drawing.Point(152, 16)
        Me.btnReceiving.Name = "btnReceiving"
        Me.btnReceiving.Size = New System.Drawing.Size(72, 40)
        Me.btnReceiving.TabIndex = 129
        Me.btnReceiving.Text = "PRINT"
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
        Me.Button1.Location = New System.Drawing.Point(224, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "CLOSE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnUnreceived)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btnReceiving)
        Me.GroupBox4.Controls.Add(Me.btnSave)
        Me.GroupBox4.Location = New System.Drawing.Point(512, 520)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(304, 64)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        '
        'btnUnreceived
        '
        Me.btnUnreceived.Enabled = False
        Me.btnUnreceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnreceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnreceived.Image = CType(resources.GetObject("btnUnreceived.Image"), System.Drawing.Image)
        Me.btnUnreceived.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUnreceived.Location = New System.Drawing.Point(8, 16)
        Me.btnUnreceived.Name = "btnUnreceived"
        Me.btnUnreceived.Size = New System.Drawing.Size(72, 40)
        Me.btnUnreceived.TabIndex = 142
        Me.btnUnreceived.Text = "UNRECEIVED ITEMS"
        Me.btnUnreceived.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(80, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 40)
        Me.btnSave.TabIndex = 127
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 88)
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
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Tan
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
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
        Me.Label5.Location = New System.Drawing.Point(512, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 48)
        Me.Label5.TabIndex = 143
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 256)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(808, 256)
        Me.ListView1.TabIndex = 144
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "      LOT NO"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BRANCH CODE"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "       PTN"
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "      MPTN"
        Me.ColumnHeader5.Width = 79
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ID"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 36
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = " ITEM CODE"
        Me.ColumnHeader7.Width = 79
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DESCRIPTION"
        Me.ColumnHeader8.Width = 88
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "QTY"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 67
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "KARAT       "
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 96
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CARAT     "
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 70
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SORTING CLASS"
        Me.ColumnHeader12.Width = 71
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "WEIGHT      "
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 49
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = " STATUS"
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "LOAN AMOUNT"
        Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader28.Width = 78
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "APPRAISE VALUE"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader29.Width = 73
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "  APPRAISER"
        Me.ColumnHeader30.Width = 78
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader17, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 256)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(808, 256)
        Me.ListView2.TabIndex = 145
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "    LOT NO"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = " DIVISION"
        Me.ColumnHeader15.Width = 64
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "TRANSACTION NO."
        Me.ColumnHeader16.Width = 120
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ITEM CODE"
        Me.ColumnHeader18.Width = 73
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "                     DESCRIPTION"
        Me.ColumnHeader19.Width = 208
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "QUANTITY"
        Me.ColumnHeader20.Width = 70
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "KARAT    "
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader21.Width = 70
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "CARAT      "
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader22.Width = 82
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "WEIGHT"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "RESOURCE ID"
        Me.ColumnHeader17.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "CUSTOMER ID"
        Me.ColumnHeader25.Width = 0
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "PULL OUT DATE"
        Me.ColumnHeader26.Width = 0
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "ITEM ID"
        Me.ColumnHeader27.Width = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 560)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 16)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "TOTAL QTY"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(176, 560)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 20)
        Me.TextBox1.TabIndex = 149
        Me.TextBox1.Text = "0"
        '
        'FrmNewReceiving
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 588)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl1FA01)
        Me.Controls.Add(Me.AsysReleasing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.ListView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNewReceiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS  RECEIVING FORM"
        Me.TopMost = True
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
            arrstr = New String(4) {"No. of Items", "PTN", "    A.L.L Barcode", "   ITEM Source ", " "}

            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")

            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 4
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
                colStyle(0).Width = 161
                colStyle(1).Width = 161
                colStyle(2).Width = 161
                colStyle(3).Width = 161
                colStyle(4).Width = 161

                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                txttext = New TextBox
                txttext.Width = 160

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                txttext.BringToFront()



                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txttext)
                txttext.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()
            End If
            'Take the text box from the second column of the grid where u will be adding the controls of your choice	
        Catch ex As Exception
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
        End Try
    End Sub

    Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            If Not ab_isEmpty Then
                If deleteData(hi) Then

                    Dim j As Integer
                    For j = 1 To Me.ListView1.Items.Count - 1
                        If j >= Me.ListView1.Items.Count - 1 Then
                            Exit For
                        End If
                        If Me.ListView1.Items(j - 1).SubItems.Item(2).Text = Me.DgEntry.Item(hi.Row, 1) Then
                            Me.ListView1.Items(j - 1).Remove()
                        End If
                    Next

                    For j = 1 To Me.ListView1.Items.Count - 1
                        If j >= Me.ListView1.Items.Count - 1 Then
                            Exit For
                        End If
                        If Me.ListView1.Items(j - 1).SubItems.Item(2).Text = Me.DgEntry.Item(hi.Row, 1) Then
                            Me.ListView1.Items(j - 1).Remove()
                        End If
                    Next

                    dataTable.Rows.RemoveAt(hi.Row)
                    Dim u, s, tempa As Integer
                    If Me.DgEntry.VisibleRowCount > 0 Then
                        For u = 1 To dataTable.Rows.Count
                            If Me.DgEntry(u - 1, 0) = "" Then
                                Me.txtTotal.Text = tempa
                            Else
                                s = (DgEntry(u - 1, 0))
                                tempa = tempa + s
                            End If
                        Next
                    End If
                    Me.txtTotal.Text = tempa
                Else
                    MsgBox("Error in connecting to database.Try Again!", MsgBoxStyle.Information, TitleMsgBox)
                End If
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
            txtTotal.Text = dataTable.Rows.Count
        Catch ex As Exception
            MsgBox("FrmNewReceiving/deleteRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try
            Dim hi As DataGrid.HitTestInfo
            Dim pt = New Point(e.X, e.Y)
            Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)
            hi = DgEntry.HitTest(e.X, e.Y)

            If hi.Column = 0 Then
                DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
                DgEntry.Select(hit.Row)
            End If

            If hi.Column = 4 And hi.Row >= 0 Then
                If DgEntry(hi.Row, 1) <> "" Then
                    deleteRow(hi, False)
                Else
                    deleteRow(hi, True)
                End If
            End If
        Catch ex As Exception
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
            MsgBox("FrmNewReceiving/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
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
                    '''========03-20-2013============'''ibalik
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
                ElseIf sDB = "LNCR" Then
                    Key_Server1 = "[ServerLNCR]="
                    Key_DataBase1 = "[DataBaseLNCR]="
                    Key_User1 = "[UserLNCR]="
                    Key_Pass1 = "[PasswordLNCR]="
                    '==================================='
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
                MsgBox("FrmNewReceiving/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("FrmNewReceiving/ConnectDB1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            Catch Ex As Exception
                MsgBox("FrmNewReceiving/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("FrmNewReceiving/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Sub TempLotno()
        Try
            Dim conn As New clsCommon
            Dim SLotno As String
            Dim dr As SqlDataReader

            conn = New clsCommon
            conn.Connectionstring3()
            conn.Open3()
            conn.Command3("Select lotno from ASYS_LOTNO_Gen WHERE BusinessCenter ='REM'")
            dr = conn.OpenDataReader3
            If dr.Read Then
                SLotno = dr.Item("LOTNO")
                Label12.Text = SLotno
            End If
            dr.Close()
            conn.Close3()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmNewReceiving_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim yr, tmp As Integer

            'If sDB <> "" Then
            '    Me.cmbCostCenter.Text = "REM"
            '    Me.cmbCostCenter.Enabled = tru
            'Else
            '    Me.cmbCostCenter.Enabled = True
            'End If
            If ambot = 1 Then
                txtCostCenter.Text = "REM"
            End If
            txtCostCenter.Text = "REM"
            force = False
            outsource = False
            'Me.grd.Rows = 1
            txtDate.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            cmbMonth.Text = CStr(MonthName(Now.Month))
            CreateGrid()
            'btnSave.Enabled = False
            btnReceiving.Enabled = True
            'Call costcenters()
            Call validEmpName()
            Call BCodeItems()
            'Call TempLotno()
            Label12.Text = GetNewLotNumber("REM", "")

            yr = Now.Year
            For tmp = 1 To 5
                ComboBox1.Items.Add(yr)
                yr = yr - 1
            Next
            ComboBox1.Text = Now.Year
            If Me.txtCostCenter.Text = "REM" Then
                Me.cmbMonth.Enabled = True
                Me.txtbc.Enabled = True
                Me.BCode.Enabled = True
                Me.lblBcCode.Enabled = True
            Else
                Me.txtbc.Enabled = False
                Me.BCode.Enabled = False
                Me.lblBcCode.Enabled = False
                Me.cmbMonth.Enabled = False
            End If
            Me.txtbc.Text = ""
            Me.lblBcCode.Text = ""
            txtDate.ReadOnly = True
            txtDate.BackColor = Color.White
            txtTotal.ReadOnly = True
            txtTotal.BackColor = Color.White
            TextBox1.ReadOnly = True
            TextBox1.BackColor = Color.White
            'Me.cmbCostCenter.Text = MainCost

            txtbc.Focus()
        Catch ex As Exception
            MsgBox("FrmNewReceiving/FrmNewReceiving_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            obj.Close5()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub validEmpName()
        Try
            tmpUserName = UCase(fullname)
            cb.Text = UCase(fullname)
            Me.Label4.Text = idnumber
        Catch ex As Exception
        End Try
    End Sub

    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()

            objclass.Command3("Select lotno from ASYS_LOTNO_Gen")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            ' objclass.Execute()
            objclass.Close3()

        Catch ex As Exception
            MsgBox("FrmNewReceiving/GenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function

    Private Sub BCodeItems()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim sq As String

            obj.ConnDb()
            obj.Open5()
            If UCase(sDB) = "LUZON" Then
                ''sq = "Select bedrnm from " & bedryfluzon2 & " order by bedrnm"
                '''sq = "Select bedrnm from " & bedryfluzon2 & " where bedrnm not like '%Showroom%' order by bedrnm"  '----Asys 5.0 Showroom
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
            ElseIf UCase(sDB) = "VISMIN" Then
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
            ElseIf UCase(sDB) = "VISAYAS" Then
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
                ''sq = "Select bedrnm from " & bedryfvismin2 & " order by bedrnm"
                '''sq = "Select bedrnm from " & bedryfvismin2 & " where bedrnm not like '%Showroom%' order by bedrnm" '----Asys 5.0 Showroom
                'sq = "select * from REMS.dbo.vw_bedryfvismin where bedrnm like '%Showroom%'"
            ElseIf UCase(sDB) = "SHOWROOM" Then
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
                '''sq = "Select bedrnm from " & bedryfShowroom & " order by bedrnm"
            ElseIf UCase(sDB) = "MINDANAO" Then
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
                ''sq = "Select bedrnm from " & bedryfMindanao & " order by bedrnm"
                'Else
            ElseIf UCase(sDB) = "LNCR" Then
                sq = "Select bedrnm from REMS.dbo.vw_bedryf" & sDB & "  order by bedrnm"
                ''' sq = "Select bedrnm from " & bedryfLNCR & " order by bedrnm"
            End If
            obj.Command5(sq)
            dr = obj.OpenDataReader5
            While dr.Read
                BCode.Text = (UCase(dr.Item("bedrnm")))
            End While
            dr.Close()
            obj.Close5()
        Catch ex As Exception
            MsgBox("FrmNewReceiving/BCodeItems: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbBCcode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            Me.lblBcCode.Text = BCode.Text

            If UCase(sDB) = "LUZON" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISMIN" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISAYAS" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "MINDANAO" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "LNCR" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            End If

            dr = objclass.OpenDataReader5
            If dr.Read Then
                txtbc.Text = dr.Item("bedrnr")
            End If
            dr.Close()

            objclass.Close5()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Label6.Text = Me.cmbLotNo.Text
        Try
            If txtbc.Text = "" Then
                MsgBox("Branch code is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If lblBcCode.Text = "" Then
                MsgBox("Branch name is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            'Call TempLotno()
            Label12.Text = GetNewLotNumber("REM", "")


            If ComboBox3.Text.ToUpper = "REMATADO" Then
                Call saveDatabyCostCenter()
            Else
                If ListView2.Items.Count > 0 Then
                    Call SaveTradeIN_transaction()
                End If

            End If



        Catch ex As Exception
            MsgBox("FrmNewReceiving/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub SaveTradeIN_transaction()
        Dim cn As New clsCommon

        Try
            Dim objclass As New clsCommon
            Dim rply, balik As Integer
            Dim sqlInsert, Str, toinks As String
            Dim dr1, dr2, dr3 As SqlDataReader
            Dim a, b, c, d, s As Integer
            Dim i As Integer
            Dim sqlInsert2, sqlinsert1, sqlinsert3, sQuery, sQuery1 As String
            Dim msg, msgs As String
            Dim con As New clsCommon
            Dim connect As New clsCommon

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()

            cn = New clsCommon
            cn.ConnectionString1()
            cn.Opentracker()
            cn.CreateCom()

            Str = "update REMS.dbo.ASYS_LOTNO_Gen set lotno ='" & GetNewLotNumber("REM", "") & "' WHERE BusinessCenter ='REM'"
            cn.commandTrack(Str)
            cn.TrackExecute()

            sqlinsert3 = " SELECT     Division,[ID], transaction_no, resource_id, customer_id, appraisal_amount, pull_out_date, received"
            sqlinsert3 = sqlinsert3 + " FROM         dbo.cstTradeIn_Transactions "
            sqlinsert3 = sqlinsert3 + " where division = '" & txtbc.Text & "' and Year(pull_out_date) = '" & ComboBox1.Text & "' and MOnth(pull_out_date) = '" & cmbMonth.SelectedIndex + 1 & "' and received =  0"

            objclass.Command(sqlinsert3)
            dr1 = objclass.OpenDataReader

            While dr1.Read

                sqlInsert = "Insert into REMS" & sDB & ".dbo.ASYS_TradeIN_header(Tran_ID, Division,Divisionname,Transaction_No,Resource_ID,Customer_ID,Appraisal_Amount,Pull_out_DATE) values ('" & dr1.Item("ID") & "','" & txtbc.Text & "','" & Trim(lblBcCode.Text) & "','" & dr1.Item("Transaction_No") & "','" & dr1.Item("Resource_ID") & "','" & dr1.Item("Customer_ID") & "','" & dr1.Item("appraisal_amount") & "','" & dr1.Item("pull_out_date") & "')"
                cn.commandTrack(sqlInsert)
                cn.TrackExecute()

                sqlInsert = "Insert into [REMS].dbo.ASYS_TradeIN_header  (Lotno,Tran_ID, Division,Divisionname,Transaction_No,Resource_ID,Customer_ID,Appraisal_Amount,Pull_out_DATE) values ('" & Label12.Text & "','" & dr1.Item("ID") & "','" & txtbc.Text & "','" & Trim(lblBcCode.Text) & "','" & dr1.Item("Transaction_No") & "','" & dr1.Item("Resource_ID") & "','" & dr1.Item("Customer_ID") & "','" & dr1.Item("appraisal_amount") & "','" & dr1.Item("pull_out_date") & "')"
                cn.commandTrack(sqlInsert)
                cn.TrackExecute()

            End While
            For s = 0 To Me.ListView2.Items.Count - 1
                sQuery = "Insert into REMS" & sDB & ".dbo.ASYS_TradeIN_Detail  (item_id,reflotno,lotno,transaction_no,itemcode,description,quantity,karat,carat,weight,receivedate,receiver,Status) values ('" & ListView2.Items(s).SubItems.Item(12).Text & "','" & Label12.Text & "','" & Label12.Text & "','" & ListView2.Items(s).SubItems.Item(2).Text & "','" & ListView2.Items(s).SubItems.Item(3).Text & "','" & ListView2.Items(s).SubItems.Item(4).Text & "','" & ListView2.Items(s).SubItems.Item(5).Text & "','" & ListView2.Items(s).SubItems.Item(6).Text & "','" & ListView2.Items(s).SubItems.Item(7).Text & "','" & ListView2.Items(s).SubItems.Item(8).Text & "',getdate(),'" & userLog & "','RECEIVED')"
                cn.commandTrack(sQuery)
                cn.TrackExecute()

                sQuery = "Insert into [REMS].dbo.ASYS_TradeIN_Detail  (item_id,reflotno,lotno,transaction_no,itemcode,description,quantity,karat,carat,weight,receivedate,receiver,Status) values ('" & ListView2.Items(s).SubItems.Item(12).Text & "','" & Label12.Text & "','" & Label12.Text & "','" & ListView2.Items(s).SubItems.Item(2).Text & "','" & ListView2.Items(s).SubItems.Item(3).Text & "','" & ListView2.Items(s).SubItems.Item(4).Text & "','" & ListView2.Items(s).SubItems.Item(5).Text & "','" & ListView2.Items(s).SubItems.Item(6).Text & "','" & ListView2.Items(s).SubItems.Item(7).Text & "','" & ListView2.Items(s).SubItems.Item(8).Text & "',getdate(),'" & userLog & "','RECEIVED')"
                cn.commandTrack(sQuery)
                cn.TrackExecute()
            Next
            dr1.Close()

            Str = "update REMS" & sDB & ".dbo.cstTradeIn_Transactions  set received = 1 where dbo.cstTradeIn_Transactions.Division = '" & txtbc.Text & "' and Month(pull_out_date) = '" & cmbMonth.SelectedIndex + 1 & "' and year(pull_out_date) = '" & ComboBox1.Text & "' and received = 0"
            cn.commandTrack(Str)
            cn.TrackExecute()

            cn.CommitTrack()
            toinks = "Successfully received from " + Trim(Me.lblBcCode.Text) + " Branch"
            MsgBox(toinks, MsgBoxStyle.Information, TitleMsgBox)
            Me.ListView1.Items.Clear()
            dataTable.Clear()
            Me.txtTotal.Text = "0"
            TextBox1.Text = "0"
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()

            btnSave.Enabled = False
        Catch ex As Exception
            cn.RollBackTrack()
            MsgBox("Items were not successfully saved. You have to receive the items individually.", MsgBoxStyle.Information, TitleMsgBox)
        Finally
            cn.Close()
            objclass.Close()
        End Try
    End Sub

    Private Sub txtbc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbc.KeyDown
        Try
            Dim dr As SqlDataReader
            If e.KeyCode = Keys.Enter Then

                If txtbc.Text = "" Then
                    MsgBox("Branch Code is empty.", MsgBoxStyle.Information, TitleMsgBox)
                    lblBcCode.Text = ""
                    txtbc.Focus()
                    Exit Sub
                End If

                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()

                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'and Class_02 in('Luzon')")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "' and Class_02 in('Visayas','Mindanao') ")
                ElseIf UCase(sDB) = "VISAYAS" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "' and Class_02 in('Visayas') ")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "' and Class_02 in('SHOWROOMS')")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "' and Class_02 in('Mindanao')")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtbc.Text.Trim + "'")
                End If

                dr = objclass.OpenDataReader5
                If dr.Read Then
                    Me.lblBcCode.Text = Replace(UCase(dr.Item("bedrnm")), "'", "")
                    Me.ComboBox1.Focus()
                Else
                    MsgBox("Branch code doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtbc.Focus()
                End If
                dr.Close()
                objclass.Close5()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("FrmNewReceiving/txtbc_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtbc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbc.TextChanged
        Try
            dataTable.Clear()
            Me.txtTotal.Text = "0"
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()

            btnSave.Enabled = False
            Me.txtTotal.Text = "0"
            TextBox1.Text = "0"
            If Me.txtCostCenter.Text = "" Then
                MsgBox("Please select cost center.", MsgBoxStyle.Information, TitleMsgBox)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub updateTRANptn()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim a, b, c, d As Integer

            a = Now.MinValue.Day
            b = Now.MaxValue.Day
            c = ComboBox1.Text
            'c = Now.Year
            d = Me.cmbMonth.SelectedIndex + 1


            obj.ConnectionString1()
            obj.Open()
            For a = 0 To dataTable.Rows.Count - 1
                str = "update tbl_pt_tran set received = 1 where division ='" & Me.txtbc.Text & "' and ptn='" & DgEntry(a, 1) & "' and month(transdate) ='" & d & "' and year(transdate)='" & c & "'  and pulloutstocks= 1 and pulloutdate is not null and ptstatus =1 and received=0"
                obj.Command(str)
                obj.Execute()
            Next
            'where division ='" & Me.txtbc.Text & "' and month(transdate) ='" & d & "' and year(transdate)='" & c & "'  and pulloutstocks= 1 and pulloutdate is not null and ptstatus =1 and received = 0  
            obj.Close()
            obj = Nothing
        Catch ex As Exception
        End Try

    End Sub

    Private Sub saveDatabyCostCenter()
        Try
            Dim rply As Integer
            Dim objclass As New clsCommon
            Dim obj As New clsCommon

            Dim sqlInsert As String
            Dim dr1, dr2, dr3 As SqlDataReader
            Dim a, b, c, d, e, z, m As Integer
            Dim i As Integer
            Dim sqlInsert2, sqlinsert1, sqlinsert3, squery, squery4, temp, squery3 As String
            Dim cn As New clsCommon
            Dim msg, msgs, msgX, temps, tempQ, tempd, msgt, msgb, msgo, msgd, msgf, msgQ, msgL, templot As String

            rply = MsgBox("Are you sure you want to save the data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, TitleMsgBox)
            If rply = vbYes Then
                If Me.txtCostCenter.Text = "REM" Then
                    'Me.cmbLotNo.Text = GenerateLot()
                    If Me.ListView1.Items.Count > 0 Then
                        Call SavePTNbyBatch()
                        'Call NewREMSave()
                        'Call updateTRANptn()
                    Else
                        MsgBox("NO ITEM FOUND.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If
                End If
            Else
                Exit Sub
            End If
            force = False
            outsource = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub SavePTNbyBatch()
        Dim objclass As New clsCommon
        Dim cn As New clsCommon

        Try
            Dim rply, balik As Integer
            Dim sqlInsert, Str, toinks As String
            Dim dr1, dr2, dr3 As SqlDataReader
            Dim a, b, c, d, s As Integer
            Dim i As Integer
            Dim sqlInsert2, sqlinsert1, sqlinsert3, sQuery, sQuery1 As String
            Dim msg, msgs As String
            Dim con As New clsCommon
            Dim connect As New clsCommon

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()

            cn = New clsCommon
            cn.ConnectionString1()
            cn.Opentracker()

            Label12.Text = GetNewLotNumber("REM", "")

            Str = "update REMS.dbo.ASYS_LOTNO_Gen set lotno ='" & GetNewLotNumber("REM", "") & "' WHERE BusinessCenter ='REM'"
            cn.commandTrack(Str)
            cn.TrackExecute()

            sqlinsert3 = "SELECT    dbo.tbl_PT_Tran.Division AS BranchCode, RTRIM(REMS.dbo.vw_bedryf" & sDB & ".bedrnm) AS BranchName, RTRIM(REMS.dbo.vw_bedryf" & sDB & ".Class_03) AS Region, "
            sqlinsert3 = sqlinsert3 + " RTRIM(REMS.dbo.vw_bedryf" & sDB & ".Class_04) AS Area, Cast(REPLACE(STR(dbo.tbl_PT_Tran.PTN, 12, 0), SPACE(1), '0') as char(12)) AS PTN, dbo.tbl_PT_Tran.ptn_barcode AS PTNBarcode, "
            sqlinsert3 = sqlinsert3 + "         dbo.tbl_PT_Tran.PTNPrincipal AS LoanValue, dbo.tbl_PT_Tran.TransDate AS Transdate, dbo.tbl_PT_Tran.PullOutDate AS PullOutDate, "
            sqlinsert3 = sqlinsert3 + "         dbo.tbl_PT_Tran.CustID, RTrim(dbo.tbl_PT_Tran.CustFirstName) + ' ' + RTrim(dbo.tbl_PT_Tran.CustLastName) + ' ' + Replace(RTrim(dbo.tbl_PT_Tran.CustMiddleInitial),'''','.') AS CustName, "
            sqlinsert3 = sqlinsert3 + "         Replace(RTRIM(dbo.tbl_PT_Tran.CustAdd),'''','') AS CustAddress, Replace(RTRIM(dbo.tbl_PT_Tran.CustCity),'''','') as CustCity, dbo.tbl_PT_Tran.CustGender, dbo.tbl_PT_Tran.CustTelNO as CustTel, "
            sqlinsert3 = sqlinsert3 + "         RTRIM(dbo.tbl_PT_Tran.Appraiser) as Appraiser, dbo.tbl_PT_Tran.AppraiseValue, dbo.tbl_PT_Tran.MaturityDate, dbo.tbl_PT_Tran.ExpiryDate, "
            sqlinsert3 = sqlinsert3 + "   dbo.tbl_PT_Tran.LoanDate"
            sqlinsert3 = sqlinsert3 + " FROM         dbo.tbl_PT_Tran  INNER JOIN"
            sqlinsert3 = sqlinsert3 + "   REMS.dbo.vw_bedryf" & sDB & " ON dbo.tbl_PT_Tran.Division = REMS.dbo.vw_bedryf" & sDB & ".bedrnr"
            sqlinsert3 = sqlinsert3 + " where dbo.tbl_PT_Tran.Division = '" & txtbc.Text & "' and dbo.tbl_pt_tran.transtype <> 'LUKAT' and Month(transdate) = '" & cmbMonth.SelectedIndex + 1 & "' and year(transdate) = '" & ComboBox1.Text & "' and pulloutstocks = 1 and pulloutdate is not null and ptstatus = 1 and received = 0"

            objclass.Command(sqlinsert3)
            dr1 = objclass.OpenDataReader
            cn.CreateCom()
            While dr1.Read

                sqlInsert = "Insert into REMS" & sDB & ".dbo.ASYS_REM_header  (Branchcode, BranchName, Region, Area,PTN, PTNBarcode, LoanValue,  Transdate, PullOutDate, CustId,CustName,CustAddress,CustCity,CustGender,CustTel,PTTime,PTDate ,MaturityDate,ExpiryDate,LoanDate) values ('" & Me.txtbc.Text & "', '" & Trim(Me.lblBcCode.Text) & "','" & dr1.Item("REgion") & "', '" & dr1.Item("Area") & "','" & dr1.Item("PTN") & "', '" & dr1.Item("PTNBarcode") & "', " & dr1.Item("LoanValue") & " ,'" & dr1.Item("Transdate") & "', '" & dr1.Item("PullOutDate") & "','" & dr1.Item("CustID") & "','" & dr1.Item("CustName") & "','" & dr1.Item("CustAddress") & "','" & dr1.Item("CustCity") & "','" & dr1.Item("CustGender") & "','" & dr1.Item("CustTel") & "','" & dr1.Item("Transdate") & "','" & dr1.Item("Transdate") & "','" & dr1.Item("MaturityDate") & "','" & dr1.Item("ExpiryDate") & "','" & dr1.Item("LoanDate") & "')"
                cn.commandTrack(sqlInsert)
                cn.TrackExecute()

                sqlInsert = "Insert into [REMS].dbo.ASYS_REM_header  (Branchcode, BranchName, Region, Area,PTN, PTNBarcode, LoanValue,  Transdate, PullOutDate, CustId,CustName,CustAddress,CustCity,CustGender,CustTel,PTTime,PTDate ,MaturityDate,ExpiryDate,LoanDate) values ('" & Me.txtbc.Text & "', '" & Me.lblBcCode.Text & "','" & dr1.Item("REgion") & "', '" & dr1.Item("Area") & "','" & dr1.Item("PTN") & "', '" & dr1.Item("PTNBarcode") & "', " & dr1.Item("LoanValue") & " ,'" & dr1.Item("Transdate") & "', '" & dr1.Item("PullOutDate") & "','" & dr1.Item("CustID") & "','" & dr1.Item("CustName") & "','" & dr1.Item("CustAddress") & "','" & dr1.Item("CustCity") & "','" & dr1.Item("CustGender") & "','" & dr1.Item("CustTel") & "','" & dr1.Item("Transdate") & "','" & dr1.Item("Transdate") & "','" & dr1.Item("MaturityDate") & "','" & dr1.Item("ExpiryDate") & "','" & dr1.Item("LoanDate") & "')"
                cn.commandTrack(sqlInsert)
                cn.TrackExecute()

            End While
            For s = 0 To Me.ListView1.Items.Count - 1
                Str = "Update [REMS].dbo.ASYS_REM_Header  set lotno = '" & Label12.Text & "' where ptn ='" & ListView1.Items(s).SubItems.Item(2).Text & "' and branchcode = '" & txtbc.Text & "' and branchname = '" & lblBcCode.Text.Trim & "'"
                cn.commandTrack(Str)
                cn.TrackExecute()

                ''09-17-2013 changes for insert & update--
                sQuery = "Insert into REMS" & sDB & ".dbo.ASYS_REM_Detail  (reflotno,lotno,PTN,Itemid,RefItemcode,Itemcode,BranchItemDesc,RefQty,Qty,KaratGrading,CaratSize,Weight,ActionClass,SortCode,ALL_desc,ALL_Karat,ALL_Carat,ALL_Weight,Price_desc,Price_karat,Price_Weight,Price_carat,Appraiser, AppraiseValue, ReceiveDate,Receiver,Status) values ('" & Label12.Text & "','" & Label12.Text & "','" & ListView1.Items(s).SubItems.Item(2).Text & "','" & ListView1.Items(s).SubItems.Item(4).Text & "','" & ListView1.Items(s).SubItems.Item(5).Text & "','" & ListView1.Items(s).SubItems.Item(5).Text & "','" & Replace(ListView1.Items(s).SubItems.Item(6).Text, "'", "") & "','" & ListView1.Items(s).SubItems.Item(7).Text & "','" & ListView1.Items(s).SubItems.Item(7).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & ListView1.Items(s).SubItems.Item(11).Text & "','Jewelry','" & ListView1.Items(s).SubItems.Item(10).Text & "','" & ListView1.Items(s).SubItems.Item(6).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(11).Text) & "','" & ListView1.Items(s).SubItems.Item(6).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(11).Text) & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & ListView1.Items(s).SubItems.Item(15).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(14).Text) & "',getdate(),'" & userLog & "','RECEIVED')"
                cn.commandTrack(sQuery)
                cn.TrackExecute()

                sQuery = "Insert into [REMS].DBO.ASYS_REM_Detail  (reflotno,lotno,PTN,Itemid,RefItemcode,Itemcode,BranchItemDesc,RefQty,Qty,KaratGrading,CaratSize,Weight,ActionClass,SortCode,ALL_desc,ALL_Karat,ALL_Carat,ALL_Weight,Price_desc,Price_karat,Price_Weight,Price_carat,Appraiser, AppraiseValue,ReceiveDate,Receiver,Status) values ('" & Label12.Text & "','" & Label12.Text & "','" & ListView1.Items(s).SubItems.Item(2).Text & "','" & ListView1.Items(s).SubItems.Item(4).Text & "','" & ListView1.Items(s).SubItems.Item(5).Text & "','" & ListView1.Items(s).SubItems.Item(5).Text & "','" & Replace(ListView1.Items(s).SubItems.Item(6).Text, "'", "") & "','" & ListView1.Items(s).SubItems.Item(7).Text & "','" & ListView1.Items(s).SubItems.Item(7).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & ListView1.Items(s).SubItems.Item(11).Text & "','Jewelry','" & ListView1.Items(s).SubItems.Item(10).Text & "','" & ListView1.Items(s).SubItems.Item(6).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(11).Text) & "','" & ListView1.Items(s).SubItems.Item(6).Text & "','" & ListView1.Items(s).SubItems.Item(8).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(11).Text) & "','" & ListView1.Items(s).SubItems.Item(9).Text & "','" & ListView1.Items(s).SubItems.Item(15).Text & "','" & CDbl(ListView1.Items(s).SubItems.Item(14).Text) & "',getdate(),'" & userLog & "','RECEIVED')"
                cn.commandTrack(sQuery)
                cn.TrackExecute()
            Next
            dr1.Close()

            Str = "update dbo.tbl_pt_tran  set received = 1 where dbo.tbl_PT_Tran.Division = '" & txtbc.Text & "' and dbo.tbl_pt_tran.transtype <> 'LUKAT' and Month(transdate) = '" & cmbMonth.SelectedIndex + 1 & "' and year(transdate) = '" & ComboBox1.Text & "' and pulloutstocks = 1 and pulloutdate is not null and ptstatus = 1 and received = 0"
            cn.commandTrack(Str)
            cn.TrackExecute()

            cn.CommitTrack()
            toinks = "Successfully received from " + Trim(Me.lblBcCode.Text) + " Branch"
            MsgBox(toinks, MsgBoxStyle.Information, TitleMsgBox)
            Me.ListView1.Items.Clear()
            dataTable.Clear()
            Me.txtTotal.Text = "0"
            TextBox1.Text = "0"
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()

            btnSave.Enabled = False
        Catch ex As Exception
            cn.RollBackTrack()
            MsgBox(Err.Description)
            ' MsgBox("Items were not successfully saved. You have to receive the items individually.", MsgBoxStyle.Information, TitleMsgBox)
        Finally
            cn.Close()
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
            con.Close5()
        Catch ex As Exception
        End Try
    End Sub

    Private Function REMPopulateData(ByVal Smonth As Integer, ByVal SYear As Integer, ByVal sBranch As Integer)
        Try
            Dim c, d As Integer
            Dim sqlStr, sortNull, tempid, tmpPTN As String
            Dim objc As New clsCommon
            Dim dr5 As SqlDataReader
            Dim tmpQty, tmpPacks As Integer

            If txtCostCenter.Text = "REM" Then
                'ConnectDB1()

                ds_dataset.Reset()
                c = ComboBox1.Text
                d = Me.cmbMonth.SelectedIndex + 1

                sqlStr = "select Cast(REPLACE(STR(a.ptn, 12, 0), SPACE(1), '0') as char(12)) AS ptn, a.mptn, b.[ID], b.itemcode, b.PTNItemDesc, b.Quantity, b.KaratGrading, b.caratsize, b.SortingClass, b.Weight, a.PTNPrincipal, a.appraisevalue, a.appraiser " & _
                         "from tbl_pt_tran a " & _
                         "INNER JOIN tbl_PTN_Item b " & _
                         "ON a.mptn = b.mptn  " & _
                         "WHERE  a.division ='" & txtbc.Text & "' and TransType <> 'LUKAT' and month(transdate) ='" & Smonth & "' and year(transdate)='" & SYear & "' and pulloutstocks= 1 and pulloutdate is not null and ptstatus =1 and received = 0 " & _
                         "order by a.ptn, b.[ID]"

                objc = New clsCommon
                objc.ConnectionString1()

                objc.Open()
                objc.Command(sqlStr)
                dr5 = objc.OpenDataReader
                tmpQty = 0

                While dr5.Read
                    tempid = dr5.Item("ID")
                    Me.ListView1.Items.Add(Label12.Text)
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Me.txtbc.Text)
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("PTN")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("MPTN")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("ID")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objc.IsNull(dr5.Item("itemcode"))))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(objc.IsNull(dr5.Item("ptnitemdesc")), "'", "")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("quantity")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("KaratGrading")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("CaratSize")))
                    If objc.IsNull(dr5.Item("SortingClass")) = "0" Then
                        sortNull = ""
                    Else
                        sortNull = objc.IsNull(dr5.Item("SortingClass"))
                    End If
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sortNull)
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("Weight")))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(1)
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("ptnprincipal"))))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("appraisevalue"))))
                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("appraiser")))

                    If objc.IsNull(dr5.Item("PTN")) <> tmpPTN Then
                        tmpPacks = tmpPacks + 1
                    End If

                    tmpPTN = objc.IsNull(dr5.Item("PTN"))
                    tmpQty = tmpQty + CInt(dr5.Item("quantity"))
                    btnSave.Enabled = True
                End While
                dr5.Close()
                objc.Close()

                txtTotal.Text = tmpPacks
                TextBox1.Text = tmpQty

            End If

            If ListView1.Items.Count <= 0 Then
                MsgBox("No data found", MsgBoxStyle.Information, TitleMsgBox)
                Exit Function
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Function RetrievePullOut_Items(ByVal Smonth As Integer, ByVal SYear As Integer, ByVal sBranch As Integer)
        Try
            Dim conn As New clsCommon
            Dim d As Integer
            Dim a, b, c, i, m, n, temp_li, z, v, u, s, tempa As Integer
            Dim temp, SLotno As String
            Dim li_rowm As Integer = dataTable.Rows.Count
            Dim id, tempid As Integer

            dataTable.Rows.Clear()

            Dim li_row As Integer = 0 'Row counter for datagrid

            '-----------------------------------REM---------------------------'
            If Me.ComboBox1.Text = "" Or cmbMonth.Text = "" Then
                MsgBox("Empty fields not allowed.", MsgBoxStyle.Information, TitleMsgBox)
                ComboBox1.Focus()
            Else
                If txtCostCenter.Text = "REM" Then
                    ListView1.Items.Clear()
                    Call REMPopulateData(Smonth, SYear, sBranch)
                    ''''ConnectDB1()

                    ''''ds_dataset.Reset()
                    ''''c = ComboBox1.Text
                    ''''d = Me.cmbMonth.SelectedIndex + 1

                    ''''ds_dataset.Reset()

                    ''''Try
                    ''''    Dim dd As New SqlClient.SqlDataAdapter("select ptn from tbl_pt_tran  where division ='" & txtbc.Text & "' and TransType <> 'LUKAT' and month(transdate) ='" & Smonth & "' and year(transdate)='" & SYear & "' and pulloutstocks= 1 and ptstatus =1 and received = 0 and pulloutdate is not null", cn) ' and mptn in (select mptn from dbo.tbl_ptn_item  where itemcode not like '2%')", cn)
                    ''''    ds_dataset.Clear()
                    ''''    dd.Fill(ds_dataset, "tbl_pt_tran")
                    ''''    If ds_dataset.Tables(0).Rows.Count < 1 Then
                    ''''        MsgBox("No Data found.", MsgBoxStyle.Information, TitleMsgBox)
                    ''''        Exit Function
                    ''''    End If
                    ''''    For a = 0 To ds_dataset.Tables(0).Rows.Count - 1

                    ''''        cmbItems = New ComboBox
                    ''''        cmbItems.Width = 150
                    ''''        cmbItems.DataSource = ds_dataset.Tables(0)
                    ''''        cmbItems.DisplayMember = "PTN"
                    ''''        Me.Cursor = Cursors.WaitCursor
                    ''''        If li_row = 0 Then
                    ''''            dataTable.LoadDataRow(arrstr, True)
                    ''''        Else
                    ''''            dataTable.LoadDataRow(arrstr, True)

                    ''''            DgEntry(li_row, 0) = ""
                    ''''            DgEntry(li_row, 1) = ""
                    ''''            DgEntry(li_row, 2) = ""
                    ''''            DgEntry(li_row, 3) = ""
                    ''''            DgEntry(li_row, 4) = "DELETE"
                    ''''        End If

                    ''''        DgEntry(li_row, 0) = ""
                    ''''        DgEntry(li_row, 1) = ds_dataset.Tables(0).Rows(a).Item(0)
                    ''''        DgEntry(li_row, 2) = ""
                    ''''        DgEntry(li_row, 3) = ""
                    ''''        DgEntry(li_row, 4) = "DELETE"

                    ''''        DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                    ''''        DgEntry.Focus()

                    ''''        If DgEntry(li_row, 2) = "" Then
                    ''''            li_row += 1

                    ''''            If li_row = dataTable.Rows.Count Then
                    ''''            Else
                    ''''                dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber + 1))
                    ''''            End If

                    ''''        End If
                    ''''    Next

                    Me.btnSave.Enabled = True
                    Me.btnSave.Focus()

                    ''''Catch ex As Exception
                    ''''    dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                    ''''    MsgBox("FrmNewReceiving/RetrievePullOut_Items: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
                    ''''End Try

                    ''''cmbsource = New ComboBox
                    ''''cmbsource.Width = 150

                    ''''dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                    ''''dgtb.TextBox.Controls.Add(cmbsource)
                    ''''cmbsource.BringToFront()

                    ''''dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                    ''''dgtb.TextBox.Controls.Add(cmbItems)
                    ''''cmbItems.BringToFront()

                    ''''dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                    ''''dgtb.TextBox.Controls.Add(cmdDelete)
                    ''''cmdDelete.BringToFront()
                    ''''cmdDelete.BackColor = Color.Bisque

                    ''''Me.txtTotal.Text = dataTable.Rows.Count
                    '''''Me.Label7.Text = tempa

                    ''''If Me.DgEntry.VisibleRowCount > 0 Then
                    ''''    For u = 1 To dataTable.Rows.Count
                    ''''        If Me.DgEntry(u - 1, 0) = "" And Me.DgEntry(u - 1, 1) = "" And Me.DgEntry(u - 1, 2) = "" Then
                    ''''            dataTable.Rows.Remove(dataTable.Rows(u - 1))
                    ''''        End If
                    ''''    Next
                    ''''End If

                    ''''DgEntry.CurrentCell = New DataGridCell(li_row, 0)
                    ''''DgEntry.Focus()
                    ''''Call PtnItemList()
                End If

                ''''If Me.ListView1.Items.Count > 0 Then
                ''''    For u = 0 To ListView1.Items.Count - 1
                ''''        s = ListView1.Items(u).SubItems.Item(7).Text
                ''''        tempa = tempa + s
                ''''    Next
                ''''    Me.txtTotal.Text = dataTable.Rows.Count
                ''''    Me.TextBox1.Text = tempa
                ''''Else
                ''''    Me.txtTotal.Text = 0
                ''''    Me.TextBox1.Text = 0
                ''''End If

            End If
        Catch ex As Exception
        End Try
    End Function

    Private Function RetrieveTradeIN_Items(ByVal Smonth As Integer, ByVal SYear As Integer, ByVal sBranch As String)
        Try
            Dim conn As New clsCommon
            Dim dr As SqlDataReader
            Dim d As Integer
            Dim a, b, c, i, m, n, temp_li, z, v, u, s, tempa As Integer
            Dim sQuery, SLotNo As String
            Dim id, tempid As Integer
            Dim tranCon As Boolean = False
            Dim ifDataexist As Boolean = False


            If Me.ComboBox1.Text = "" Or cmbMonth.Text = "" Then
                MsgBox("Empty fields not allowed.", MsgBoxStyle.Information, TitleMsgBox)
                ComboBox1.Focus()
            Else
                ifDataexist = False

                conn = New clsCommon
                conn.ConnectionString1()
                conn.Open()

                sQuery = "SELECT     dbo.cstTradeIn_Transactions.Division, dbo.cstTradeIn_Transactions.transaction_no, dbo.cstTradeIn_Transactions.resource_id, "
                sQuery = sQuery + "  dbo.cstTradeIn_Transactions.customer_id, dbo.cstTradeIn_Transactions.appraisal_amount, dbo.cstTradeIn_Transactions.pull_out_date, "
                sQuery = sQuery + "  dbo.cstTradeIn_Transactions.received, dbo.cstTradeIn_Items.ID, dbo.cstTradeIn_Items.itemcode, dbo.cstTradeIn_Items.description, "
                sQuery = sQuery + "  dbo.cstTradeIn_Items.quantity, dbo.cstTradeIn_Items.karat, dbo.cstTradeIn_Items.carat, dbo.cstTradeIn_Items.weight"
                sQuery = sQuery + " FROM dbo.cstTradeIn_Items INNER JOIN"
                sQuery = sQuery + " dbo.cstTradeIn_Transactions ON dbo.cstTradeIn_Items.transaction_no = dbo.cstTradeIn_Transactions.transaction_no"
                sQuery = sQuery + " where division = '" & sBranch & "' and Year(pull_out_date) = '" & SYear & "' and MOnth(pull_out_date) = '" & Smonth & "' and received =  0"
                conn.Command(sQuery)
                dr = conn.OpenDataReader
                While dr.Read

                    tranCon = True
                    ListView2.Items.Add(Label12.Text)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Division"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Transaction_no"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Itemcode"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(UCase(dr.Item("Description")))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Quantity"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Karat"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Carat"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Weight"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Resource_ID"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("Customer_ID"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatDateTime(dr.Item("Pull_out_date"), 0))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("ID"))
                    btnSave.Enabled = True
                    ifDataexist = True
                End While
                dr.Close()
                conn.Close3()
                conn = Nothing
            End If

            If Me.ListView2.Items.Count > 0 Then
                For u = 0 To ListView2.Items.Count - 1
                    s = ListView2.Items(u).SubItems.Item(5).Text
                    tempa = tempa + s
                Next
            End If
            'Me.txtTotal.Text = tempa
            Me.TextBox1.Text = tempa
            Dim tempptn As String

            If Me.ListView2.Items.Count > 0 Then
                For u = 0 To ListView2.Items.Count - 1
                    If u = 0 Then
                        s = 1
                        tempptn = ListView2.Items(u).SubItems.Item(2).Text
                    Else
                        If ListView2.Items(u).SubItems.Item(2).Text <> tempptn Then
                            s = s + 1
                            tempptn = ListView2.Items(u).SubItems.Item(2).Text
                        End If
                    End If

                Next
            End If

            'Me.TextBox1.Text = s
            Me.txtTotal.Text = s
            If ifDataexist = False Then
                MsgBox("No Data Found.", MsgBoxStyle.Information, TitleMsgBox)
                txtbc.Focus()
                Exit Function
            End If

        Catch ex As Exception
            MsgBox("FrmNewReceiving/RetrieveTradeIN_Items: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    'Private Sub cmbMonth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMonth.KeyDown
    '    Try

    '        If e.KeyCode = Keys.Enter Then
    '            Me.Cursor = Cursors.WaitCursor
    '            Dim con As New clsCommon
    '            Dim com As SqlCommand
    '            Dim conn As New clsCommon
    '            Dim dr As SqlDataReader
    '            Dim dr1 As SqlDataReader
    '            Dim d As Integer
    '            Dim squery, sQuery2 As String
    '            Dim sQuery1, sQuery7 As String
    '            Dim a, b, c, i, m, n, temp_li, z, v, u, s, tempa As Integer
    '            Dim temp As String
    '            Dim li_rowm As Integer = dataTable.Rows.Count
    '            Dim id, tempid As Integer

    '            dataTable.Rows.Clear()

    '            Dim li_row As Integer = 0 'Row counter for datagrid

    '            '-----------------------------------REM---------------------------'

    '            If Me.ComboBox1.Text = "" Or cmbMonth.Text = "" Then
    '                MsgBox("Please select year or month", MsgBoxStyle.Information, TitleMsgBox)
    '                ComboBox1.Focus()
    '                'dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    '            Else
    '                If cmbCostCenter.Text = "REM" Then
    '                    ConnectDB1()


    '                    ds_dataset.Reset()

    '                    a = Now.MinValue.Day
    '                    b = Now.MaxValue.Day
    '                    c = ComboBox1.Text
    '                    'c = Now.Year
    '                    d = Me.cmbMonth.SelectedIndex + 1

    '                    ds_dataset.Reset()
    '                    If Me.txtbc.Text.Length <> 0 Then
    '                        If Me.cmbMonth.Text.Length <> 0 Then
    '                            Try
    '                                con.ConnectionString2()
    '                                con.Open2()

    '                                sQuery7 = "select ptn from tbl_pt_tran  where division ='" & Me.txtbc.Text & "' and TransType <> 'LUKAT' and month(transdate) ='" & d & "' and year(transdate)='" & c & "'  and pulloutstocks= 1 and pulloutdate is not null and ptstatus =1 and received = 0"
    '                                con.Command2(sQuery7)
    '                                dr = con.OpenDataReader2
    '                                If dr.Read Then
    '                                    Dim dd As New SqlClient.SqlDataAdapter("select ptn from tbl_pt_tran  where division ='" & Me.txtbc.Text & "' and TransType <> 'LUKAT' and month(transdate) ='" & d & "' and year(transdate)='" & c & "' and pulloutstocks= 1 and pulloutdate is not null and ptstatus =1 and received = 0", cn)
    '                                    ds_dataset.Clear()
    '                                    dd.Fill(ds_dataset, "tbl_pt_tran")

    '                                    For a = 0 To ds_dataset.Tables(0).Rows.Count - 1

    '                                        cmbItems = New ComboBox
    '                                        cmbItems.Width = 150
    '                                        cmbItems.DataSource = ds_dataset.Tables(0)
    '                                        cmbItems.DisplayMember = "PTN"
    '                                        Me.Cursor = Cursors.WaitCursor
    '                                        If li_row = 0 Then
    '                                            dataTable.LoadDataRow(arrstr, True)
    '                                        Else
    '                                            dataTable.LoadDataRow(arrstr, True)

    '                                            DgEntry(li_row, 0) = ""
    '                                            DgEntry(li_row, 1) = ""
    '                                            DgEntry(li_row, 2) = ""
    '                                            DgEntry(li_row, 3) = ""
    '                                            DgEntry(li_row, 4) = "DELETE"
    '                                        End If

    '                                        DgEntry(li_row, 0) = ""
    '                                        DgEntry(li_row, 1) = ds_dataset.Tables(0).Rows(a).Item(0)
    '                                        DgEntry(li_row, 2) = ""
    '                                        DgEntry(li_row, 3) = ""
    '                                        DgEntry(li_row, 4) = "DELETE"

    '                                        DgEntry.CurrentCell = New DataGridCell(li_row, 1)
    '                                        DgEntry.Focus()

    '                                        If DgEntry(li_row, 2) = "" Then
    '                                            li_row += 1

    '                                            If li_row = dataTable.Rows.Count Then
    '                                            Else
    '                                                dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber + 1))
    '                                            End If

    '                                        End If
    '                                        'i = Nothing
    '                                        'dr1.Close()
    '                                        'conn.Execute()
    '                                        'conn.Close()
    '                                    Next

    '                                    Me.btnSave.Enabled = True
    '                                    Me.btnSave.Focus()
    '                                Else
    '                                    MsgBox("NO APPROXIMATE DATA FOUND", MsgBoxStyle.Information, TitleMsgBox)
    '                                    Me.Cursor = Cursors.Arrow
    '                                    txtbc.Focus()
    '                                    Exit Sub
    '                                End If
    '                            Catch ex As Exception
    '                                dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
    'msgbox(ex.message,,TitleMsgBox)
    '                            End Try
    '                        Else
    '                            MsgBox("pls select month", MsgBoxStyle.Information, TitleMsgBox)
    '                            Exit Sub
    '                        End If
    '                    Else
    '                        MsgBox("Please select business center", MsgBoxStyle.Information, TitleMsgBox)
    '                        Exit Sub
    '                    End If

    '                    cmbsource = New ComboBox
    '                    cmbsource.Width = 150

    '                    dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
    '                    dgtb.TextBox.Controls.Add(cmbsource)
    '                    cmbsource.BringToFront()

    '                    dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
    '                    dgtb.TextBox.Controls.Add(cmbItems)
    '                    cmbItems.BringToFront()

    '                    dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
    '                    dgtb.TextBox.Controls.Add(cmdDelete)
    '                    cmdDelete.BringToFront()
    '                    cmdDelete.BackColor = Color.Bisque

    '                    Me.txtTotal.Text = dataTable.Rows.Count
    '                    'Me.Label7.Text = tempa

    '                    If Me.DgEntry.VisibleRowCount > 0 Then
    '                        For u = 1 To dataTable.Rows.Count
    '                            If Me.DgEntry(u - 1, 0) = "" And Me.DgEntry(u - 1, 1) = "" And Me.DgEntry(u - 1, 2) = "" Then
    '                                dataTable.Rows.Remove(dataTable.Rows(u - 1))
    '                            End If
    '                        Next
    '                    End If

    '                    DgEntry.CurrentCell = New DataGridCell(li_row, 0)
    '                    DgEntry.Focus()
    '                    Call PtnItemList()
    '                End If

    '                If Me.DgEntry.VisibleRowCount > 0 Then
    '                    For u = 0 To ListView1.Items.Count - 1
    '                        s = ListView1.Items(u).SubItems.Item(7).Text
    '                        tempa = tempa + s

    '                    Next
    '                End If
    '                Me.txtTotal.Text = dataTable.Rows.Count
    '                Me.TextBox1.Text = tempa
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    'msgbox(ex.message,,TitleMsgBox)
    '    End Try
    '    Me.Cursor = Cursors.Arrow
    'End Sub

    Private Sub PtnItemList()
        Try

            Dim a, u, s, t, c As Integer
            Dim objc As New clsCommon
            Dim dr5 As SqlDataReader
            Dim sqlQuery1, sqlQuery2 As String
            Dim objl As New clsCommon
            Dim dr6 As SqlDataReader
            Dim id, tempid As Integer
            Dim sortNull As String
            Dim templotno As Integer

            c = Me.ComboBox1.Text
            If Me.DgEntry.VisibleRowCount > 0 Then
                Me.Cursor = Cursors.WaitCursor
                objc = New clsCommon
                objl = New clsCommon
                objc.ConnectionString1()
                objl.ConnectionString2()
                Me.ListView1.Items.Clear()
                For a = 0 To dataTable.Rows.Count - 1
                    sqlQuery1 = "Select Cast(REPLACE(STR(ptn, 12, 0), SPACE(1), '0') as char(12)) as ptn,Cast(REPLACE(STR(mptn, 12, 0), SPACE(1), '0') as char(12)) as mptn,ptnprincipal,appraiser,appraisevalue from tbl_pt_tran where division ='" & Me.txtbc.Text & "' and ptn = '" & DgEntry(a, 1) & "' and transtype <> 'LUKAT' and month(transdate) ='" & Me.cmbMonth.SelectedIndex + 1 & "' and year(transdate)='" & c & "'  and pulloutstocks= 1 and ptstatus = 1 and received = 0"
                    objc.Open()
                    objc.Command(sqlQuery1)
                    dr5 = objc.OpenDataReader
                    If dr5.Read Then
                        sqlQuery2 = "Select DISTINCT top 3 * from tbl_ptn_item where mptn='" & dr5.Item("mptn") & "'  order by id " & ComboBox2.Text & ""
                        objl.Open2()
                        objl.Command2(sqlQuery2)
                        dr6 = objl.OpenDataReader2
                        While dr6.Read
                            If ListView1.Items.Count > 0 Then
                                If tempid = Nothing Then
                                    tempid = dr6.Item("ID")
                                    Me.ListView1.Items.Add(Label12.Text)
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Me.txtbc.Text)
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("PTN")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("MPTN")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("ID")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objl.IsNull(dr6.Item("itemcode"))))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(objl.IsNull(dr6.Item("ptnitemdesc")), "'", "")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("quantity")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("KaratGrading")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("CaratSize")))
                                    If objl.IsNull(dr6.Item("SortingClass")) = "0" Then
                                        sortNull = ""
                                    Else
                                        sortNull = objl.IsNull(dr6.Item("SortingClass"))
                                    End If
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sortNull)
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("Weight")))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(1)
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("ptnprincipal"))))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("appraisevalue"))))
                                    Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("appraiser")))
                                Else
                                    If ComboBox2.Text = "desc" Then
                                        id = tempid - 2
                                        If id <= dr6.Item("ID") Then
                                            Me.ListView1.Items.Add(Label12.Text)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Me.txtbc.Text)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("PTN")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("MPTN")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("ID")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objl.IsNull(dr6.Item("itemcode"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(objl.IsNull(dr6.Item("ptnitemdesc")), "'", "")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("quantity")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("KaratGrading")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("CaratSize")))
                                            If objl.IsNull(dr6.Item("SortingClass")) = "0" Then
                                                sortNull = ""
                                            Else
                                                sortNull = objl.IsNull(dr6.Item("SortingClass"))
                                            End If
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sortNull)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("Weight")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(1)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("ptnprincipal"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("appraisevalue"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("appraiser")))
                                        End If
                                    Else
                                        id = tempid + 3
                                        If id >= dr6.Item("ID") Then
                                            Me.ListView1.Items.Add(Label12.Text)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Me.txtbc.Text)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("PTN")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("MPTN")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("ID")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objl.IsNull(dr6.Item("itemcode"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(objl.IsNull(dr6.Item("ptnitemdesc")), "'", "")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("quantity")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("KaratGrading")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("CaratSize")))
                                            If objl.IsNull(dr6.Item("SortingClass")) = "0" Then
                                                sortNull = ""
                                            Else
                                                sortNull = objl.IsNull(dr6.Item("SortingClass"))
                                            End If
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sortNull)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("Weight")))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(1)
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("ptnprincipal"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("appraisevalue"))))
                                            Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("appraiser")))
                                        End If
                                    End If

                                End If

                            Else
                                tempid = dr6.Item("ID")
                                Me.ListView1.Items.Add(Label12.Text)
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Me.txtbc.Text)
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("PTN")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("MPTN")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("ID")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objl.IsNull(dr6.Item("itemcode"))))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(objl.IsNull(dr6.Item("ptnitemdesc"))))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("quantity")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("KaratGrading")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("CaratSize")))
                                If objl.IsNull(dr6.Item("SortingClass")) = "0" Then
                                    sortNull = ""
                                Else
                                    sortNull = objl.IsNull(dr6.Item("SortingClass"))
                                End If
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(sortNull)
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objl.IsNull(dr6.Item("Weight")))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(1)
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("ptnprincipal"))))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objc.IsNull(dr5.Item("appraisevalue"))))
                                Me.ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objc.IsNull(dr5.Item("appraiser")))
                            End If

                        End While

                        dr6.Close()
                        'objl.Execute2()
                        objl.Close2()
                    End If
                    dr5.Close()
                    'objc.Execute()
                    objc.Close()
                    tempid = Nothing
                    Me.Cursor = Cursors.Default
                Next
            End If
            TextBox1.Text = ListView1.Items.Count
        Catch ex As Exception
            MsgBox("FrmNewReceiving/PtnItemList: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbEmployee_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Then
                Me.txtCostCenter.Focus()
            Else
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtbc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbc.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmSummary
            If Me.txtCostCenter.Text = "" Or Me.txtCostCenter.Text = "REM" Then
                MsgBox("Pls. select costcenter.", MsgBoxStyle.Information, TitleMsgBox)
            Else
                recrel = 1
                frm.Label7.Text = reclotno
                frm.iSummary = 3
                frm.Label4.Text = Me.txtCostCenter.Text
                frm.Show()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReceiving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiving.Click
        Try
            recrelrep = True
            Dim frm As New Report
            frm.txtBranchCode.Text = txtbc.Text
            frm.txtBranchName.Text = lblBcCode.Text
            frm.Button3.Focus()
            frm.Label6.Visible = False
            frm.TextBox2.Visible = False
            frm.Text = "RECEIVING REPORT"
            If ComboBox3.Text.ToUpper = "REMATADO" Then
                frm.Print_TradeIn(False, "RECEIVING")
                If FlagRptPrvw = False Then
                    FlagRptPrvw = True
                Else
                    Exit Sub
                End If
            Else
                frm.Print_TradeIn(True, "RECEIVING")
            End If
            frm.Show()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbMonth_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectionChangeCommitted
        Try
            dataTable.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                Me.cmbMonth.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbCostCenter_MouseWheel(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        txtCostCenter.Text = MainCost
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        Try
            dataTable.Clear()
            Me.txtTotal.Text = "0"
            TextBox1.Text = "0"
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()
            btnUnreceived.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.Click
        Try
            txtTotal.Text = dataTable.Rows.Count
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
            MsgBox("FrmNewReceiving/DgEntry_CurrentCellChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            cmbMonth.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            dataTable.Clear()
            Me.txtTotal.Text = "0"
            TextBox1.Text = "0"
            Me.ListView1.Items.Clear()
            Me.ListView2.Items.Clear()

            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            Else
                txtbc.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim frm As New frmSearchLotno
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbMonth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMonth.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If ComboBox3.Text.Trim.ToUpper = "REMATADO" Then
                    RetrievePullOut_Items(cmbMonth.SelectedIndex + 1, ComboBox1.Text.Trim, txtbc.Text)
                Else
                    ListView2.Items.Clear()
                    RetrieveTradeIN_Items(cmbMonth.SelectedIndex + 1, ComboBox1.Text.Trim, txtbc.Text)

                End If

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.TextChanged
        Try
            If ComboBox3.Text.ToUpper = "REMATADO" Then
                Label3.Text = "[PRENDA MONTH]"
                ListView1.BringToFront()
                GroupBox2.BringToFront()
                GroupBox1.BringToFront()
                Label5.BringToFront()
                txtbc.Focus()
            Else
                Label3.Text = "[HABWA MONTH]"
                GroupBox2.BringToFront()
                GroupBox1.BringToFront()
                Label5.BringToFront()
                ListView2.BringToFront()
                txtbc.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUnreceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnreceived.Click
        If ComboBox1.Text = "" And cmbMonth.Text = "" Then
            MsgBox("Please select month and year")
            Exit Sub
        End If

        Dim frm As New frmUnreceivedReport
        frm.GetDepartment("REMATADO", cmbMonth.SelectedIndex + 1, ComboBox1.Text)
        frm.ShowDialog()
    End Sub
    Private Sub BCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCode.TextChanged
        Try
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()

            Me.lblBcCode.Text = BCode.Text
            If UCase(sDB) = "LUZON" Then
                objclass.Command5("Select bedrnr from REMS.dbo.bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'") ''and class_02 like '%" & sDB & "%'
                '''objclass.Command5("Select bedrnr from " & bedryfluzon2 & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISMIN" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'") ''and class_02 like '%" & sDB & "%'")
                '''objclass.Command5("Select bedrnr from " & bedryfvismin2 & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISAYAS" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'") ''and class_02 like '%" & sDB & "%'")
                '''objclass.Command5("Select bedrnr from " & bedryfShowroom & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "MINDANAO" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'") ''and class_02 like '%" & sDB & "%'")
                '''objclass.Command5("Select bedrnr from " & bedryfMindanao & " where bedrnm='" + BCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "LNCR" Then
                objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + BCode.Text.Trim + "'") ''and class_02 like '%" & sDB & "%'")
                '''objclass.Command5("Select bedrnr from " & bedryfLNCR & " where bedrnm='" + BCode.Text.Trim + "'")
            End If

            dr = objclass.OpenDataReader5
            If dr.Read Then
                txtbc.Text = dr.Item("bedrnr")
            End If
            dr.Close()

            objclass.Close5()
        Catch ex As Exception
        End Try
    End Sub
    ''Private Sub BCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCode.SelectedIndexChanged
    ''    Try
    ''        objclass = New clsCommon
    ''        objclass.ConnDb()
    ''        objclass.Open5()
    ''        Me.lblBcCode.Text = BCode.Text
    ''        If UCase(sDB) = "LUZON" Then
    ''            objclass.Command5("Select bedrnr from " & bedryfluzon2 & " where bedrnm='" + BCode.Text.Trim + "'")
    ''        Else
    ''            objclass.Command5("Select bedrnr from " & bedryfvismin2 & " where bedrnm='" + BCode.Text.Trim + "'")
    ''        End If

    ''        dr = objclass.OpenDataReader5
    ''        If dr.Read Then
    ''            txtbc.Text = dr.Item("bedrnr")
    ''        End If
    ''        dr.Close()

    ''        objclass.Close5()
    ''    Catch ex As Exception
    ''    End Try
    ''End Sub

    Private Sub cb_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb.TextChanged
        Try
            cb.Text = tmpUserName
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblBcCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBcCode.Click

    End Sub
End Class
