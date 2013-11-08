Imports System.Data.SqlClient
Imports System.Diagnostics
Public Class frmnewrec
    Inherits System.Windows.Forms.Form
    Dim ErrFlag As Boolean

   
#Region " private declarations "

    'Private sUserID, s_PTN, sPTNBarcode As String()
    Private sUserID As String()
    Private sAction As String()
    Private sDivision As String
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private odatetime1 As clsCommon.DateTime
    Private nonNumberEntered As Boolean = False
    Dim flag As Boolean = False
    Dim fl As Boolean = False
    Dim f As Boolean = False
    Dim tempflag As Boolean = False
    Dim fls As Boolean = False
    Dim isgen As Boolean = False
    Private isForce As Boolean = False
    Private oForce As Boolean = False
    Private cn As SqlClient.SqlConnection
    Private ds As DataSet
    Private da As SqlClient.SqlDataAdapter
    Dim dr As SqlClient.SqlDataReader
    Dim temp_MPTN As String
    Dim sid As Integer = 0
    Dim ff As Integer
    Dim counter As Integer = 0
#End Region

#Region " public declarations "
    Public iFocus, iEdit As Integer
    Public bEdit As Boolean
#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents lblReceiverIDNo As System.Windows.Forms.Label
    Friend WithEvents lblReceiverName As System.Windows.Forms.Label
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents RadBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtPTN As System.Windows.Forms.TextBox
    Friend WithEvents txtPTNBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cmbCostCenter As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents bleh1 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmnewrec))
        Me.lblReceiverIDNo = New System.Windows.Forms.Label
        Me.lblReceiverName = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label35 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.RadBarcode = New System.Windows.Forms.RadioButton
        Me.radNone = New System.Windows.Forms.RadioButton
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtPTNBarcode = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtPTN = New System.Windows.Forms.TextBox
        Me.bleh1 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblArea = New System.Windows.Forms.Label
        Me.lblRegion = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceiverIDNo
        '
        Me.lblReceiverIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiverIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverIDNo.Location = New System.Drawing.Point(144, 600)
        Me.lblReceiverIDNo.Name = "lblReceiverIDNo"
        Me.lblReceiverIDNo.Size = New System.Drawing.Size(64, 20)
        Me.lblReceiverIDNo.TabIndex = 138
        Me.lblReceiverIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReceiverIDNo.Visible = False
        '
        'lblReceiverName
        '
        Me.lblReceiverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverName.Location = New System.Drawing.Point(208, 600)
        Me.lblReceiverName.Name = "lblReceiverName"
        Me.lblReceiverName.Size = New System.Drawing.Size(232, 20)
        Me.lblReceiverName.TabIndex = 137
        Me.lblReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReceiverName.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(40, 600)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 23)
        Me.Label35.TabIndex = 136
        Me.Label35.Text = "USER NAME"
        Me.Label35.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(104, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(288, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(936, 208)
        Me.GroupBox3.TabIndex = 131
        Me.GroupBox3.TabStop = False
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(800, 128)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 23)
        Me.Label33.TabIndex = 61
        Me.Label33.Text = "Label33"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(704, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 23)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "APPRAISE VALUE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(592, 152)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(104, 23)
        Me.Label42.TabIndex = 59
        Me.Label42.Text = "(mm/dd/yyyy)"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(240, 152)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 23)
        Me.Label41.TabIndex = 58
        Me.Label41.Text = "(mm/dd/yyyy)"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(240, 128)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 23)
        Me.Label40.TabIndex = 57
        Me.Label40.Text = "(mm/dd/yyyy)"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(472, 152)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 23)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "Label32"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(472, 128)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 23)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Label31"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(120, 152)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 23)
        Me.Label30.TabIndex = 42
        Me.Label30.Text = "Label30"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(120, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 23)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "Label29"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(352, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "DATE LOAN GRANTED"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(352, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 23)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "LOAN VALUE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 23)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "MATURITY DATE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "EXPIRY DATE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 19)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(905, 85)
        Me.ListView1.TabIndex = 12
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM CODE"
        Me.ColumnHeader1.Width = 77
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                                                    ITEM DESCRIPTION"
        Me.ColumnHeader2.Width = 450
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY    "
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 59
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "KARAT    "
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 61
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CARAT   "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 61
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SORTING CLASS  "
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "WEIGHT     "
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 90
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 0
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(144, 574)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(192, 23)
        Me.Label37.TabIndex = 47
        Me.Label37.Text = "Label37"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label37.Visible = False
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(40, 576)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 23)
        Me.Label38.TabIndex = 46
        Me.Label38.Text = "RECEIVED DATE"
        Me.Label38.Visible = False
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 167)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER INFORMATION"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(144, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(224, 23)
        Me.Label28.TabIndex = 21
        Me.Label28.Text = "Label28"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(144, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(224, 23)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "Label27"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(144, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(384, 23)
        Me.Label26.TabIndex = 19
        Me.Label26.Text = "Label26"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(144, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(384, 23)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Label25"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(144, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(384, 23)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Label24"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(144, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(224, 23)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Label23"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "TEL NO."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "CUSTOMER CITY"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "GENDER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "CUSTOMER ADDRESS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CUSTOMER NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CUSTOMER ID NO."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(592, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 168)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAWN TICKET INFORMATION"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(136, 93)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(216, 23)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "Label36"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(17, 93)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(124, 23)
        Me.Label44.TabIndex = 15
        Me.Label44.Text = "TRANSACTION DATE"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(136, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(17, 69)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(117, 23)
        Me.Label34.TabIndex = 13
        Me.Label34.Text = "PULL-OUT DATE"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(136, 118)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(216, 23)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Label22"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(136, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 23)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Label21"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(136, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 23)
        Me.Label20.TabIndex = 10
        Me.Label20.Text = "Label20"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APPRAISER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAWN TICKET DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAWN TICKET TIME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnPrint)
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.btnSave)
        Me.GroupBox6.Controls.Add(Me.btnEdit)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(624, 568)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(344, 64)
        Me.GroupBox6.TabIndex = 142
        Me.GroupBox6.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(208, 16)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(68, 40)
        Me.btnPrint.TabIndex = 131
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(144, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 40)
        Me.Button3.TabIndex = 129
        Me.Button3.TabStop = False
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(272, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 40)
        Me.Button2.TabIndex = 130
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(8, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 40)
        Me.btnSave.TabIndex = 127
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(76, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(68, 40)
        Me.btnEdit.TabIndex = 148
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(8, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(68, 40)
        Me.Button4.TabIndex = 128
        Me.Button4.TabStop = False
        Me.Button4.Text = "EDIT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboBox3)
        Me.GroupBox5.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.txtBranchCode)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.ComboBox4)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.txtbrname)
        Me.GroupBox5.Controls.Add(Me.TextBox16)
        Me.GroupBox5.Controls.Add(Me.ComboBox2)
        Me.GroupBox5.Controls.Add(Me.txtPTNBarcode)
        Me.GroupBox5.Controls.Add(Me.TextBox15)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.txtPTN)
        Me.GroupBox5.Location = New System.Drawing.Point(520, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(448, 152)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"asc", "desc"})
        Me.ComboBox3.Location = New System.Drawing.Point(288, 48)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(64, 21)
        Me.ComboBox3.TabIndex = 169
        Me.ComboBox3.Text = "asc"
        Me.ComboBox3.Visible = False
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCostCenter.Location = New System.Drawing.Point(112, 112)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(169, 21)
        Me.cmbCostCenter.TabIndex = 168
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(16, 112)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 23)
        Me.Label43.TabIndex = 167
        Me.Label43.Text = "COST CENTER"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(112, 16)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 53
        Me.txtBranchCode.Text = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 23)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "BRANCH CODE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 23)
        Me.Label17.TabIndex = 150
        Me.Label17.Text = " PTN BARCODE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 23)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "PTN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(112, 40)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox4.TabIndex = 146
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 23)
        Me.Label19.TabIndex = 151
        Me.Label19.Text = "ACTION"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadBarcode)
        Me.GroupBox7.Controls.Add(Me.radNone)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(288, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(144, 61)
        Me.GroupBox7.TabIndex = 156
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "BARCODE SCANNER"
        '
        'RadBarcode
        '
        Me.RadBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadBarcode.Location = New System.Drawing.Point(13, 36)
        Me.RadBarcode.Name = "RadBarcode"
        Me.RadBarcode.Size = New System.Drawing.Size(87, 22)
        Me.RadBarcode.TabIndex = 1
        Me.RadBarcode.Text = "BARCODE"
        '
        'radNone
        '
        Me.radNone.Checked = True
        Me.radNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNone.Location = New System.Drawing.Point(13, 12)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(91, 24)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "NONE"
        '
        'txtbrname
        '
        Me.txtbrname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.Location = New System.Drawing.Point(176, 16)
        Me.txtbrname.MaxLength = 100
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.ReadOnly = True
        Me.txtbrname.Size = New System.Drawing.Size(208, 20)
        Me.txtbrname.TabIndex = 155
        Me.txtbrname.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.Enabled = False
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(112, 88)
        Me.TextBox16.MaxLength = 17
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(151, 20)
        Me.TextBox16.TabIndex = 148
        Me.TextBox16.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(112, 88)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox2.TabIndex = 153
        Me.ComboBox2.Text = "ComboBox2"
        '
        'txtPTNBarcode
        '
        Me.txtPTNBarcode.AutoSize = False
        Me.txtPTNBarcode.Location = New System.Drawing.Point(112, 88)
        Me.txtPTNBarcode.Name = "txtPTNBarcode"
        Me.txtPTNBarcode.Size = New System.Drawing.Size(168, 23)
        Me.txtPTNBarcode.TabIndex = 165
        Me.txtPTNBarcode.Text = ""
        Me.txtPTNBarcode.Visible = False
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(112, 64)
        Me.TextBox15.MaxLength = 12
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(151, 20)
        Me.TextBox15.TabIndex = 1
        Me.TextBox15.Text = "TextBox15"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(112, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.ComboBox1.TabIndex = 152
        '
        'txtPTN
        '
        Me.txtPTN.AutoSize = False
        Me.txtPTN.Location = New System.Drawing.Point(112, 64)
        Me.txtPTN.Name = "txtPTN"
        Me.txtPTN.Size = New System.Drawing.Size(168, 23)
        Me.txtPTN.TabIndex = 164
        Me.txtPTN.Text = ""
        Me.txtPTN.Visible = False
        '
        'bleh1
        '
        Me.bleh1.Location = New System.Drawing.Point(216, 600)
        Me.bleh1.Name = "bleh1"
        Me.bleh1.Size = New System.Drawing.Size(96, 24)
        Me.bleh1.TabIndex = 144
        Me.bleh1.Text = "0"
        Me.bleh1.Visible = False
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(208, 80)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 32)
        Me.Label39.TabIndex = 145
        Me.Label39.Visible = False
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(208, 72)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.TabIndex = 146
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(208, 96)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.TabIndex = 147
        '
        'frmnewrec
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 638)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lblReceiverIDNo)
        Me.Controls.Add(Me.lblReceiverName)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bleh1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblRegion)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmnewrec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECEIVE PTN INDIVIDUALLY"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " private sub "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            Dim dr As SqlDataReader
            Dim i As Integer
            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select * from rems.dbo.tbl_action where action_id in (6,1,3,8,11) order by action_type")
            dr = objclass.OpenDataReader
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(Trim(UCase(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()

            Call SelectAction(objclass.action.Jewelry)
            Call Clear()
            Me.Label37.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            lblReceiverIDNo.Text = UserPassW
            lblReceiverName.Text = UCase(userLog)

            'Me.cmbLOTno.Items.Clear()
            Me.ListView1.Height = 78
            Me.ListView1.Width = 904
            'displayLOT()
            Call displayCostCenter()
            TextBox15.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetBranch_Lotno() As Integer
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim sQuery As String

            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()

            sQuery = " if (SELECT   top 1   Count(dbo.ASYS_REM_Detail.Lotno) as Lotno"
            sQuery = sQuery + " FROM         dbo.ASYS_REM_Detail INNER JOIN"
            sQuery = sQuery + "                     dbo.ASYS_REM_Header ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN"
            sQuery = sQuery + " where year(receivedate) = year(getdate()) and month(receivedate) =Month(getdate()) and branchcode ='" & txtBranchCode.Text.Trim & "' and lotno is not null"
            sQuery = sQuery + " group by branchcode,lotno order by lotno desc) <> 0 "
            sQuery = sQuery + " begin"
            sQuery = sQuery + " SELECT  top 1    dbo.ASYS_REM_Detail.Lotno"
            sQuery = sQuery + " FROM         dbo.ASYS_REM_Detail INNER JOIN"
            sQuery = sQuery + "                      dbo.ASYS_REM_Header ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN"
            sQuery = sQuery + " where year(receivedate) = year(getdate()) and month(receivedate) = Month(getdate()) and branchcode = '" & txtBranchCode.Text.Trim & "' and lotno is not null"
            sQuery = sQuery + " group by branchcode,lotno order by lotno desc"
            sQuery = sQuery + " end"
            sQuery = sQuery + " else"
            sQuery = sQuery + " begin"
            sQuery = sQuery + " select Lotno from REMS.dbo.ASYS_Lotno_Gen WHERE BusinessCenter ='REM'"
            sQuery = sQuery + " update REMS.dbo.ASYS_Lotno_Gen set lotno = lotno + 1 WHERE BusinessCenter ='REM'"
            sQuery = sQuery + " end "

            'sQuery = sQuery + " update REMS.dbo.ASYS_Lotno_Gen set lotno = lotno + 1"

            obj.Command(sQuery)
            dr = obj.OpenDataReader
            If dr.Read Then
                GetBranch_Lotno = dr.Item("Lotno")
            End If
            dr.Close()
            obj.Close()
        Catch ex As Exception

        End Try
    End Function
    'retrieves ptn and ptn barcode that are available for receiving action
    Private Sub RetrievePTN_Barcode()
        Try
            Dim dr As SqlDataReader

            Dim sptn, sptn_barcode As String

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select ptn, ptn_barcode from tbl_pt_tran where Year(transdate) = Year(getdate()) and  pulloutstocks = 1 and transtype <> 'LUKAT' and pulloutdate is not null and received = 0 and division='" + txtBranchCode.Text + "' order by ptn, ptn_barcode")
            dr = objclass.OpenDataReader
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            While dr.Read
                sptn = CStr(objclass.IsNull(dr.Item("ptn")))
                sptn_barcode = CStr(objclass.IsNull(dr.Item("ptn_barcode")))
                If Not (sptn Is "") Then
                    ComboBox1.Items.Add(sptn)
                End If
                If Not (sptn_barcode Is "") Then
                    If sptn_barcode <> "0" Then
                        ComboBox2.Items.Add(sptn_barcode)
                    End If
                End If
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
    'retrieves ptn information from tbl_pt_tran, tbl_ptn_item
    Private Sub RetrieveInfo(ByVal sPTN As String, ByVal iSet As Integer, ByVal bSave As Boolean)
        Try
            Dim L1, L2 As Double
            Dim dr As SqlDataReader
            Dim rdr As SqlDataReader
            Dim sMPTN, sStatus, iStatus As String
            Dim fstatus As String = ""
            Dim iExist, iAction_id, iUser_id As Integer
            Dim objclass2 As clsCommon
            Dim ds As DataSet
            Dim da As SqlDataAdapter
            Dim id, tempid As Integer
            Dim objclass As New clsCommon

            'tbl_receiving if exist===============================================================
            objclass = New clsCommon
            objclass2 = New clsCommon
            odatetime = New clsCommon.DateTime
            objclass.ConnectionString1()
            objclass.Open()

            ErrFlag = False

            If iSet = 1 Then
                'objclass.Command("select rec_id, action_id, status_id,receivedate from tbl_receiving where ptn = '" + sPTN + "'")
                objclass.Command("select  status from ASYS_REM_Detail  where ptn = '" + sPTN + "'")
                flag = True
            Else
                'objclass.Command("select rec_id, action_id, status_id,receivedate from tbl_receiving where ptnbarcode = '" + sPTN + "'")
                objclass.Command("SELECT ASYS_REM_Detail.Status as status FROM  ASYS_REM_Detail  INNER JOIN  ASYS_REM_Header ON ASYS_REM_Detail.PTN = ASYS_REM_Header.PTN  where ASYS_REM_Header.ptnbarcode = '" + sPTN + "'")
            End If
            dr = objclass.OpenDataReader
            If dr.Read Then
                Dim x As String
                x = dr.Item("status")
                If IsDBNull(Trim(dr.Item("status"))) Then
                    iExist = 0
                Else
                    iExist = 1
                    fl = True
                    iStatus = Trim(dr.Item("status"))
                    'fstatus = objclass.IsNull(dr.Item("forcedstatus"))
                    If fstatus = "" Then
                        fstatus = 0
                    End If

                    If iStatus = "RECEIVED" Then
                        sStatus = "PTN already received"
                        btnEdit.Enabled = True
                        display2(sPTN, iSet)
                    ElseIf iStatus = "SORTED" Then
                        sStatus = "PTN already sorted"
                    ElseIf iStatus = "COSTED" Then
                        sStatus = "PTN already costed"
                    Else
                        sStatus = "PTN already released"
                    End If
                    'iAction_id = CInt(dr.Item("recactionid"))
                    'SelectAction(iAction_id)
                    'iUser_id = CInt(dr.Item("recid"))
                End If
            End If
            dr.Close()
            objclass.CloseDataReader()


            If iExist Then
                If iStatus = "RECEIVED" Then
                    MsgBox(sStatus, , TitleMsgBox)
                    'ComboBox3.Enabled = False
                    ComboBox4.Enabled = False
                    btnSave.Enabled = False
                    Button4.Enabled = True
                    btnEdit.Enabled = True
                    btnEdit.Focus()
                    Exit Sub
                ElseIf iStatus = "SORTED" Then
                    MsgBox(sStatus, , TitleMsgBox)
                    btnSave.Enabled = False
                    Call Clear()
                    'ComboBox3.Enabled = False
                    ComboBox4.Enabled = False
                    Exit Sub
                ElseIf iStatus = "COSTED" Or iStatus = "RELEASED" Or iStatus = "RECMLWB" Then
                    MsgBox(sStatus, , TitleMsgBox)
                    btnSave.Enabled = False
                    Button4.Enabled = False
                    btnEdit.Enabled = False
                    Call Clear()
                    'ComboBox3.Enabled = False
                    ComboBox4.Enabled = False
                    Exit Sub
                End If
                display2(sPTN, iSet)
                tempflag = True
                Exit Sub
            End If

            'End=======================================================================================

            ' for ptn barcode
            Dim aaa As String
            If iSet = 1 Then
                'objclass.Command("select top 1 getdate() as curdate, transdate, division, mptn, appraiser, custid, custmiddleinitial, custfirstname, custlastname, custadd, custcity, custgender, custtelno, ptnprincipal, loandate, maturitydate, expirydate, appraisevalue, ptn, ptn_barcode  from tbl_pt_tran  where ptn = '" + sPTN + "' and transtype <> 'LUKAT' and DateDiff(month,transdate,getdate()) >= 6 ") 'order by id " & ComboBox3.Text & "")
                aaa = ("select top 1 getdate() as curdate, transdate, division, mptn, appraiser, custid, custmiddleinitial, custfirstname, custlastname, custadd, custcity, custgender, custtelno, ptnprincipal, loandate, maturitydate, expirydate, appraisevalue, ptn, ptn_barcode  from tbl_pt_tran  where ptn = '" + sPTN + "' and transtype <> 'LUKAT' and received = 0  ") ' ptstatus = 0 and  DateDiff(month,transdate,getdate()) >= 6 ") 'order by id " & ComboBox3.Text & "")
            Else
                aaa = ("select top 1 getdate() as curdate, transdate, division, mptn, appraiser, custid, custmiddleinitial, custfirstname, custlastname, custadd, custcity, custgender, custtelno, ptnprincipal, loandate, maturitydate, expirydate, appraisevalue, ptn, ptn_barcode  from tbl_pt_tran  where ptn_barcode = '" + sPTN + "' and transtype <> 'LUKAT' and received = 0 ") 'ptstatus = 0 and  DateDiff(month,transdate,getdate()) >= 6 ")
            End If
            objclass.Command(aaa)
            dr = objclass.OpenDataReader
            If dr.Read Then
                If DateDiff(DateInterval.Month, CDate(dr.Item("transdate")), dr.Item("curdate")) < 6 Then
                    MsgBox("Advance receiving of the PTN is not allowed.", MsgBoxStyle.Information, TitleMsgBox)
                    dr.Close()
                    Exit Sub
                ElseIf DateDiff(DateInterval.Month, CDate(dr.Item("transdate")), dr.Item("curdate")) >= 6 Then
                    sDivision = Trim(dr.Item("Division"))
                    txtBranchCode.Text = sDivision
                    getBedryf1()
                    odatetime.Split(dr.Item("Transdate"))
                    Label20.Text = odatetime.Time
                    Label21.Text = odatetime.PTNDate
                    sMPTN = Trim(dr.Item("mptn"))
                    temp_MPTN = sMPTN
                    Label22.Text = dr.Item("Appraiser")
                    Label23.Text = dr.Item("CustID")
                    If IsDBNull(dr.Item("CustMiddleInitial")) Then
                        Label24.Text = Trim(dr.Item("CustFirstName")) + " " + Trim(dr.Item("CustLastName"))
                    Else
                        Label24.Text = Trim(dr.Item("CustFirstName")) + " " + Trim(dr.Item("CustLastName")) + " " + Trim(dr.Item("CustMiddleInitial"))
                    End If

                    Label25.Text = objclass.IsNull(dr.Item("CustAdd"))
                    Label26.Text = objclass.IsNull(dr.Item("CustCity"))
                    Label27.Text = objclass.IsNull(UCase(dr.Item("CustGender")))
                    Label28.Text = objclass.IsNull(dr.Item("CustTelno"))
                    Label31.Text = FormatNumber(dr.Item("PTNPrincipal"))
                    Label10.Text = Format(Now, "MM/dd/yyyy")
                    Label36.Text = Format(dr.Item("transdate"), "MM/dd/yyyy")
                    L2 = Label31.Text
                    Label32.Text = Trim(dr.Item("LoanDate"))
                    Label29.Text = Trim(dr.Item("MaturityDate"))
                    Label30.Text = Trim(dr.Item("ExpiryDate"))
                    Label33.Text = FormatNumber(dr.Item("AppraiseValue"))
                    btnSave.Enabled = True
                End If

                If iSet = 1 Then
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptn_barcode")))
                Else
                    TextBox15.Text = Trim(dr.Item("ptn"))
                End If
                dr.Close()
                objclass.CloseDataReader()
                ListView1.Items.Clear()
                objclass.Command("select distinct top 3 [id],itemcode,ptnitemdesc,quantity,karatgrading,caratsize,sortingclass,weight from tbl_ptn_item where mptn = '" + sMPTN + "' ") 'order by id " & ComboBox3.Text & "")
                dr = objclass.OpenDataReader
                While dr.Read
                    If ListView1.Items.Count > 0 Then
                        If ComboBox3.Text = "desc" Then
                            id = tempid - 2
                            If id <= dr.Item("ID") Then
                                ListView1.Items.Add(Trim(dr.Item("ItemCode")))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(Trim(objclass.IsNull(dr.Item("PTNItemDesc"))), "'", "''")))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("id"))))

                            End If
                        Else
                            id = tempid + 3
                            If id >= dr.Item("ID") Then
                                ListView1.Items.Add(Trim(dr.Item("ItemCode")))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(Trim(objclass.IsNull(dr.Item("PTNItemDesc"))), "'", "''")))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("id"))))

                            End If
                        End If


                    Else
                        tempid = dr.Item("ID")
                        ListView1.Items.Add(Trim(dr.Item("ItemCode")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Replace(Trim(objclass.IsNull(dr.Item("PTNItemDesc"))), "'", "''")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("id"))))
                    End If
                End While
                dr.Close()
                objclass.CloseDataReader()
                objclass.Close()

                'Get Branch name in the bedryf table 
                'getBedryf()

                If ListView1.Items.Count > 0 Then
                    btnSave.Enabled = True
                    Button4.Enabled = False
                    btnEdit.Enabled = False
                    btnSave.Focus()
                End If
                odatetime = Nothing
            Else
                If flag = True Then
                    MsgBox("PTN not found.", MsgBoxStyle.Information, TitleMsgBox)
                    ErrFlag = True
                    returnfocus()
                Else
                    MsgBox("PTN Barcode not found.", MsgBoxStyle.Information, TitleMsgBox)
                    returnfocus()
                End If
                Clear()
                objclass.Close()
                Exit Sub
            End If

            'If L1 < L2 Then
            '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical)
            'End If
            iExist = Nothing
            iSet = Nothing
            objclass = Nothing
            TextBox15.Focus()
        Catch ex As Exception

        End Try
    End Sub
    'returns to the last focus textbox
    Private Sub returnfocus()
        Try
            If iFocus = 15 Then
                TextBox15.Focus()
            ElseIf iFocus = 16 Then
                TextBox16.Focus()
            ElseIf iFocus = 14 Then
                txtBranchCode.Focus()
            End If
            iEdit = iFocus
            iFocus = 0
        Catch ex As Exception

        End Try
    End Sub
    'returns to the last focus of textbox and clears the content
    Private Sub returnfocus1()
        Try
            If iFocus = 15 Then
                TextBox15.Text = ""
                TextBox15.Focus()
            ElseIf iFocus = 16 Then
                TextBox16.Text = ""
                TextBox16.Focus()
            End If
            iEdit = iFocus
            iFocus = 0
        Catch ex As Exception

        End Try
    End Sub
    ' selects action class
    Private Sub SelectAction(ByVal iAction As Integer)
        Try
            Dim i, itemp As Integer
            For i = 0 To sAction.Length - 1
                itemp = CInt(sAction(i))
                If itemp = iAction Then
                    ComboBox4.SelectedIndex = i
                    Exit Sub
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    'clear all text information
    Private Sub Clear()
        Try
            Me.txtPTN.Text = ""
            Me.txtPTNBarcode.Text = ""
            ' Me.txtLoanValue.Text = ""
            'Label33.Text = 0
            txtBranchCode.Text = ""
            txtbrname.Text = ""
            lblArea.Text = ""
            lblRegion.Text = ""
            Label10.Text = ""
            Label36.Text = ""
            Label20.Text = ""
            Label21.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""
            Label25.Text = ""
            Label26.Text = ""
            Label27.Text = ""
            Label28.Text = ""
            Label29.Text = ""
            Label30.Text = ""
            Label31.Text = ""
            Label32.Text = ""
            Label33.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
            ComboBox2.Items.Clear()
            ComboBox1.SelectedText = ""
            ComboBox2.SelectedText = ""
            ListView1.Items.Clear()
            ComboBox4.Enabled = True
            btnSave.Enabled = False
            Button4.Enabled = False
            btnEdit.Enabled = False
            flag = False
            fl = False
            bEdit = False
            tempflag = False
            sid = 0

            TextBox15.Focus()
            temp_MPTN = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            sUserID = Nothing
            sAction = Nothing
            sDivision = Nothing
            iFocus = Nothing
            's_PTN = Nothing
            'sPTNBarcode = Nothing
            iEdit = Nothing
        Catch ex As Exception

        End Try
    End Sub

#End Region

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/ComboBox4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            Dim dr As SqlDataReader

            ff = 0
            If e.KeyCode = Keys.Enter Then
                If ListView1.Items.Count > 0 Then
                    Button3_Click(sender, e)
                End If

                iFocus = 14
                'get branch name in the bedryf table
                getBedryf1()

                ' Label34.Text = txtbrname.Text
                If ff = 1 Then
                    Call RetrievePTN_Barcode()
                    ff = 0
                End If
                TextBox15.Text = ""
                TextBox15.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/txtBranchCode_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtbrname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbrname.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim str As String

            f = 0
            If e.KeyCode = Keys.Enter Then
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                If UCase(sDB) = "LUZON" Then
                    str = "Select top 1* from REMS.dbo.bedryf" & sDB & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"
                ElseIf UCase(sDB) = "VISMIN" Then
                    str = "Select top 1* from REMS.dbo.bedryf" & sDB & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    str = "Select top 1* from REMS.dbo.bedryf" & sDB & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"
                ElseIf UCase(sDB) = "MINDANAO" Then
                    str = "Select top 1* from REMS.dbo.bedryf" & sDB & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"
                ElseIf UCase(sDB) = "LNCR" Then
                    str = "Select top 1* from REMS.dbo.bedryf" & sDB & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"
                End If

                objclass.Command5(str)
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    txtBranchCode.Text = Trim(dr.Item("bedrnr"))
                    txtbrname.Text = Trim(dr.Item("bedrnm"))
                    'Label34.Text = txtbrname.Text.Trim
                    ff = 1
                Else
                    MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
                objclass = Nothing
                If ff = 1 Then
                    Call RetrievePTN_Barcode()
                    ff = 0
                End If
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/txtbrname_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Public Sub display2(ByVal txtbox As String, ByVal isets As Integer)
        Try
            clear_me()
            Dim dr As SqlDataReader
            Dim rdr As SqlDataReader
            Dim sMPTN, sStatus As String
            Dim iExist, iStatus, iAction_id, iUser_id As Integer
            Dim objclass As clsCommon
            Dim idx As Integer = 0


            'Button1.Enabled = True
            ComboBox4.Enabled = True

            'tbl_receiving if exist
            objclass = New clsCommon
            objclass = New clsCommon
            odatetime = New clsCommon.DateTime
            objclass.ConnectionString1()
            objclass.Open()

            If isets = 1 Then
                objclass.Command("Select BranchCode,BranchName,PTN,PTNBarcode,Loanvalue,Transdate,PullOutDate,custid,custname,custaddress,custcity,custgender,custtel,maturitydate,expirydate,loandate from ASYS_REM_HEADER  where ptn ='" + txtbox + "'")
            Else
                objclass.Command("Select BranchCode,BranchName,PTN,PTNBarcode,Loanvalue,Transdate,PullOutDate,custid,custname,custaddress,custcity,custgender,custtel,maturitydate,expirydate,loandate from ASYS_REM_HEADER  where ptnBarcode ='" + txtbox + "'")
            End If

            dr = objclass.OpenDataReader
            If dr.Read Then
                'Me.cmbLOTno.Text = dr.Item("recLotno")
                Me.cmbCostCenter.Text = "REM"
                Me.txtBranchCode.Text = dr.Item("BranchCode")
                Me.txtbrname.Text = dr.Item("BranchName")
                Me.TextBox16.Text = objclass.IsNull(dr.Item("PTNBarcode"))
                Me.Label31.Text = FormatNumber(dr.Item("LoanValue"), 2)
                'Me.Label34.Text = Me.txtbrname.Text.Trim
                Me.TextBox16.Text = objclass.IsNull(dr.Item("PTNBarcode"))
                Me.TextBox15.Text = dr.Item("PTN")
                Label36.Text = Format(dr.Item("Transdate"), "Short Date")
                Label10.Text = Format(dr.Item("Pulloutdate"), "Short Date")
                odatetime.Split(dr.Item("transdate"))
                Label20.Text = odatetime.Time
                Label21.Text = Format(dr.Item("Transdate"), "Short Date")

                Label23.Text = objclass.IsNull(dr.Item("CustID"))
                Label24.Text = objclass.IsNull(dr.Item("CustName"))
                Label25.Text = objclass.IsNull(dr.Item("CustAddress"))
                Label26.Text = objclass.IsNull(dr.Item("CustCity"))
                Label27.Text = objclass.IsNull(UCase(dr.Item("CustGender")))
                Label28.Text = objclass.IsNull(dr.Item("CustTel"))
                Label29.Text = objclass.IsNull(dr.Item("MaturityDate"))
                Label30.Text = objclass.IsNull(dr.Item("ExpiryDate"))
                Label32.Text = objclass.IsNull(dr.Item("loandate"))


            End If
            dr.Close()
            objclass.CloseDataReader()

            objclass.Command("select distinct Itemcode,BranchItemDesc,Qty,KaratGrading,CaratSize,ActionClass,Weight,appraisevalue,appraiser from ASYS_REM_DEtail  where ptn ='" + TextBox15.Text.Trim + "' order by itemcode")
            ListView1.Items.Clear()
            dr = objclass.OpenDataReader
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("ItemCode")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("BranchItemDesc"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Qty"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ActionClass"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(Trim(objclass.IsNull(dr.Item("Weight"))), 2))
                ' ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(Trim(dr.Item("ItemAppraiseValue")), 2))
                'ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                Label22.Text = objclass.IsNull(dr.Item("Appraiser"))
                Label33.Text = FormatNumber(objclass.IsNull(dr.Item("AppraiseValue")))
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()

            odatetime = Nothing
            iExist = Nothing
            isets = Nothing
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmnewrec/display2: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function getActionID(ByVal intID As Integer)
        Try
            Dim cm As New SqlClient.SqlCommand
            cm.Connection = cn
            cm.CommandText = "Select Action_type from tbl_action where action_id = '" + CStr(intID) + "'"
            dr = cm.ExecuteReader
            If dr.Read Then
                getActionID = dr.Item("Action_Type")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("frmnewrec/getActionID: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub TextBox15_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown
        Try

            If e.KeyCode = Keys.Enter Then
                Me.Timer1.Enabled = False
                'fls = False
                If TextBox15.Text = "" Then
                    MsgBox("Input PTN.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox15.Text = ""
                    TextBox15.Focus()
                    btnSave.Enabled = False
                    Exit Sub
                End If

                If IsNumeric(TextBox15.Text) Then

                    If Len(TextBox15.Text) < 0 Or Len(TextBox15.Text.Trim) > 12 Then
                        MsgBox("Input a valid PTN.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox15.Text = ""
                        TextBox15.Focus()
                        btnSave.Enabled = False
                        Exit Sub
                    End If

                    iFocus = 15
                    TextBox15.Text = TextBox15.Text.PadLeft(12, "0")
                    RetrieveInfo(CStr(TextBox15.Text), 1, True)
                Else
                    MsgBox("Enter a numeric value.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox15.Text = ""
                    TextBox15.Focus()
                End If

                If fl = True Then
                    btnEdit.Focus()
                Else
                    btnSave.Focus()
                End If
                fl = False
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox15_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox16.KeyDown
        Try
            nonNumberEntered = False
            ' Determine whether the keystroke is a number from the top of the keyboard.
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' Determine whether the keystroke is a backspace.
                    If e.KeyCode <> Keys.Back Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If

            If e.KeyCode = Keys.Enter Then
                Me.Timer1.Enabled = False
                'fls = True
                If TextBox16.Text = "" Then
                    MsgBox("Input PTN barcode.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox16.Text = ""
                    TextBox16.Focus()
                    btnSave.Enabled = False
                    Exit Sub
                End If

                If Trim(TextBox16.Text) <= 0 Or Len(TextBox16.Text) = 33767 Then
                    MsgBox("Input a valid PTN Barcode.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox16.Text = ""
                    TextBox16.Focus()
                    btnSave.Enabled = False
                    Exit Sub
                End If

                If IsNumeric(TextBox16.Text) Then
                    iFocus = 16
                    RetrieveInfo(CStr(TextBox16.Text), 2, True)
                Else
                    MsgBox("Enter numeric.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox16.Text = ""
                    TextBox16.Focus()
                End If
                If fl = True Then
                    btnEdit.Focus()
                Else
                    btnSave.Focus()
                End If
                fl = False
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox16_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox16_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        Try
            If TextBox15.Text <> "" Then
                Exit Sub
            End If
            If TextBox16.Text = "" Then
                TextBox16.Focus()
                Exit Sub
            End If
            If TextBox16.Text.StartsWith(0) = True Then
                TextBox16.Text = ""
            End If
            If TextBox16.TextLength = 9 Then
                'If radNone.Checked = True Then
                '    Me.Timer1.Enabled = False
                '    Me.TextBox15.Focus()
                '    Exit Sub
                'Else
                '    Me.Timer1.Enabled = True
                'End If

                'Me.Timer1.Enabled = True
                'Me.Timer1.Interval = 350
                'Me.Timer1.Start()
                RetrieveInfo(CStr(TextBox16.Text), 2, True)
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox16_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If TextBox16.Text = "" Then
                TextBox15.Text = ""
                TextBox16.Focus()
                Clear()
                Exit Sub
            End If

            If fl = True Then
                Me.Timer1.Enabled = False
                Me.Timer1.Stop()
                fl = False
                Exit Sub
            End If

            If ListView1.Items.Count > 0 Then
                Me.Timer1.Enabled = False
                Me.Timer1.Stop()
                Exit Sub
            Else
                Me.Timer1.Enabled = False
                Me.Timer1.Stop()
                iFocus = 16
                RetrieveInfo(CStr(TextBox16.Text), 2, True)
            End If

            If ListView1.Items.Count > 0 Then
                If tempflag = True Then
                    btnSave.Enabled = False
                    btnEdit.Enabled = True
                    btnEdit.Focus()
                Else
                    btnSave.Enabled = True
                    btnEdit.Enabled = False
                    btnSave.Focus()
                End If
            End If

            Me.Timer1.Enabled = False
            Me.Timer1.Stop()
        Catch ex As Exception
            MsgBox("frmnewrec/Timer1_Tick: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub radNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radNone.Click
        Try
            If radNone.Checked = True Then
                BcodeScanner(True)
                Button3_Click(sender, e)
            End If
            TextBox15.Text = ""
            TextBox15.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/radNone_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub RadBarcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadBarcode.Click
        Try
            If RadBarcode.Checked = True Then
                BcodeScanner(True)
                Button3_Click(sender, e)
            End If
            TextBox16.Text = ""
            TextBox16.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/RadBarcode_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function checkduplicate() As Boolean
        Try
            Dim cm As New SqlClient.SqlCommand
            Dim dr As SqlClient.SqlDataReader
            Dim stats As String = ""

            checkduplicate = False
            cm.Connection = cn
            cm.CommandText = "Select recptn,status_id from tbl_receiving_header where recptn = '" + Me.txtPTN.Text.Trim + "'"
            dr = cm.ExecuteReader
            If dr.Read = True Then
                stats = dr.Item("status_id")
                If stats = 1 Then
                    MsgBox("PTN received.", MsgBoxStyle.Information, TitleMsgBox)
                    checkduplicate = True
                ElseIf stats = 2 Then
                    MsgBox("PTN Sorted.", MsgBoxStyle.Information, TitleMsgBox)
                    checkduplicate = True
                ElseIf stats = 3 Then
                    MsgBox("PTN Sorted and Costed.", MsgBoxStyle.Information, TitleMsgBox)
                    checkduplicate = True
                Else
                    MsgBox("PTN released.", MsgBoxStyle.Information, TitleMsgBox)
                    checkduplicate = True
                End If
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("frmnewrec/checkduplicate: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    'Save item in Tbl_receiving_detail
    Private Function ConnectDB() As Boolean
        Try
            If cn Is Nothing Then
                cn = New SqlClient.SqlConnection
            End If

            If cn.State = ConnectionState.Closed Then
                cn.ConnectionString = ConStrs
                cn.Open()
            End If

            ConnectDB = True

        Catch ex As Exception

            cn = Nothing
            objclass = Nothing
            ConnectDB = False
            MsgBox("frmnewrec/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            bEdit = True
            btnSave.Enabled = True
            ComboBox4.Enabled = True
            Button4.Enabled = False
            btnSave.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If Me.isForce = True Then
                Call Clear()
            Else
                Call Clear()
                txtBranchCode.Text = ""
                txtbrname.Text = ""
                ComboBox1.Items.Clear()
                ComboBox2.Items.Clear()
                ComboBox4.Enabled = True
                txtBranchCode.Focus()
                ClearText()
                Me.cmbCostCenter.Text = "REM"

            End If
            TextBox15.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ComboBox4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectionChangeCommitted
        Try
            btnSave.Focus()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            Call ptn()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub ptn()
        Try
            iFocus = 15
            TextBox15.Text = ComboBox1.SelectedItem
            RetrieveInfo(CStr(TextBox15.Text), 1, False)
        Catch ex As Exception
            MsgBox("frmnewrec/ptn: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ptn_barcode()
        Try
            iFocus = 16
            'TextBox15.Text = s_PTN(ComboBox3.SelectedIndex)
            TextBox16.Text = ComboBox2.SelectedItem
            RetrieveInfo(CStr(TextBox16.Text), 3, False)
            If ListView1.Items.Count > 0 Then
                btnSave.Enabled = True
                btnSave.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/ptn_barcode: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Public Sub FRVisibleFields()
        Try
            Me.ListView1.Height = 78
            Me.ListView1.Width = 904
            Me.txtPTN.Visible = False
            'Me.txtLoanValue.Visible = False
            Me.txtPTNBarcode.Visible = False
        Catch ex As Exception
            MsgBox("frmnewrec/FRVisibleFields: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Public Sub FRdisplayFields()
        Try
            Me.ListView1.Height = 85
            Me.ListView1.Width = 905
            Me.txtPTN.Visible = True
            'Me.txtLoanValue.Visible = True
            Me.txtPTNBarcode.Visible = True
        Catch ex As Exception
            MsgBox("frmnewrec/FRdisplayFields: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Public Sub MainFeildsShow()
        Try
            Me.TextBox15.Visible = True
            Me.TextBox16.Visible = True
            Me.ComboBox1.Visible = True
            'Me.Label33.Visible = True
            Me.Label31.Visible = True
        Catch ex As Exception
            MsgBox("frmnewrec/MainFeildsShow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Public Sub visibleFields()
        Try
            Me.TextBox15.Visible = False
            Me.TextBox16.Visible = False
            Me.ComboBox1.Visible = False
            Me.Label31.Visible = False
        Catch ex As Exception
            MsgBox("frmnewrec/visibleFields: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress
        Try
            If nonNumberEntered = True Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox16_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            isgen = True
            Me.ComboBox1.Items.Clear()
            Clear()
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            txtBranchCode.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/btnNew_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ClearText()
        Try
            Me.txtPTN.Text = ""
            Me.txtPTNBarcode.Text = ""
            'Me.txtLoanValue.Text = ""
        Catch ex As Exception
            MsgBox("frmnewrec/ClearText: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (isForce = True) Or (oForce = True) Or ret = True Then
                ClearText()
                FRVisibleFields()
                MainFeildsShow()
                Me.Button2.Text = "Close"
                Me.txtPTNBarcode.Visible = True
                Me.TextBox16.Visible = True
                Me.TextBox15.Visible = True
                Me.ComboBox1.Visible = True
                Me.ComboBox2.Visible = True
                Me.ComboBox1.BringToFront()
                Me.TextBox15.BringToFront()
                Me.txtPTNBarcode.Visible = True
                Me.Label17.Visible = True
                Me.Label16.Visible = True
                Me.txtBranchCode.Enabled = True
                Me.txtbrname.Enabled = True
                Me.txtBranchCode.Focus()
                Me.ListView1.Items.Clear()
                Me.cmbCostCenter.SetBounds(112, 160, 168, 24)
                Me.Label43.SetBounds(32, 160, 72, 23)
                isForce = False
                oForce = False
                ret = False
            Else
                Me.Dispose()
                cn = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnOutsource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Shell("Notepad.exe", AppWinStyle.NormalFocus, True)
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            Me.txtPTNBarcode.Visible = False
            Me.TextBox16.Visible = False
            Me.TextBox15.Visible = False
            Me.ComboBox1.Visible = False
            Me.ComboBox2.Visible = False
            Me.txtPTNBarcode.Visible = False
            Me.Label17.Visible = False
            Me.Label16.Visible = False
            Me.cmbCostCenter.SetBounds(112, 128, 168, 24)
            'Me.cmbCostCenter.SetBounds(112, 160, 168, 24)
            Me.Label43.SetBounds(24, 128, 72, 23)
            Me.txtBranchCode.Enabled = False
            Me.txtbrname.Enabled = False
            Clear()
            oForce = True
            Me.Timer1.Enabled = False
            visibleFields()
            FRdisplayFields()
            'FRVisibleFields()
            Button2.Text = "Cancel"
            btnSave.Enabled = True
        Catch ex As Exception
            MsgBox("frmnewrec/btnOutsource_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub displayCostCenter()
        Try
            Dim cm As New SqlClient.SqlCommand

            If cn Is Nothing Then
                ConnectDB()
            End If
            cm.Connection = cn
            cm.CommandText = "Select * from rems.dbo.tbl_COSTCenter where costdept = 'REM' "
            dr = cm.ExecuteReader
            While dr.Read
                Me.cmbCostCenter.Items.Add(dr.Item("CostDept"))
                Me.cmbCostCenter.Text = "REM"
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("frmnewrec/displayCostCenter: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function genItemID()
        Try
            Dim value As Integer = CInt(1 + 1)
            genItemID = value
        Catch ex As Exception
            MsgBox("frmnewrec/genItemID: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Function Trappings() As Boolean
        Try
            Trappings = False
            If isForce = False And oForce = False Then
                If Len(Me.cmbCostCenter.Text.Trim) = 0 Then
                    MsgBox("Input Cost Center.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.cmbCostCenter.Focus()
                    Trappings = True
                    Exit Function
                End If

                If Len(Me.txtBranchCode.Text.Trim) = 0 Then
                    MsgBox("Input Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtBranchCode.Focus()
                    Trappings = True
                    Exit Function

                ElseIf Len(Me.txtbrname.Text.Trim) = 0 Then
                    MsgBox("Input Branch Name.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtbrname.Focus()
                    Trappings = True
                    Exit Function
                End If
            End If


            If Me.isForce = True Then
                If Me.txtPTN.Text = "" Then
                    MsgBox("Input a PTN.", MsgBoxStyle.Information, TitleMsgBox)
                    txtPTN.Focus()
                    Trappings = True
                    Exit Function
                End If
            End If

            If Me.cmbCostCenter.Text.Trim = "" Then
                MsgBox("Select Cost Center", MsgBoxStyle.Information, TitleMsgBox)
                Me.cmbCostCenter.Focus()
                Trappings = True
                Exit Function
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/Trappings: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub getBedryf1()
        Try
            Dim obj1 As New clsCommon
            obj1 = New clsCommon
            obj1.ConnDb()
            obj1.Open5()
            If UCase(sDB) = "LUZON" Then
                obj1.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISMIN" Then
                obj1.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                obj1.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "MINDANAO" Then
                obj1.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "LNCR" Then
                obj1.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            End If

            dr = obj1.OpenDataReader5
            If dr.Read Then
                txtbrname.Text = Trim(UCase(dr.Item("bedrnm")))
                lblArea.Text = Trim(dr.Item("Class_04"))
                lblRegion.Text = Trim(dr.Item("Class_03"))
                ff = 1
            Else
                MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Focus()
            End If
            dr.Close()
            obj1.Execute5()
            obj1.Close5()
            obj1 = Nothing
        Catch ex As Exception
            MsgBox("frmnewrec/getBedryf1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub getheader()
        Try
            objclass.Command("select * from tbl_receiving_header where recptn = '" + TextBox15.Text.Trim + "'")
            dr = objclass.OpenDataReader
            If dr.Read Then
                Me.cmbCostCenter.Text = Trim(dr.Item("reccostcenter"))
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("frmnewrec/getheader: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtPTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/txtPTN_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtPTNBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTNBarcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/txtPTNBarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub clear_me()
        Try
            Label20.Text = ""
            Label21.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""
            Label25.Text = ""
            Label26.Text = ""
            Label27.Text = ""
            Label28.Text = ""
            Label29.Text = ""
            Label30.Text = ""
            Label32.Text = ""
            'Label33.Text = ""
            ListView1.Items.Clear()
        Catch ex As Exception
            MsgBox("frmnewrec/clear_me: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If TextBox15.Text = "" Then
                    TextBox15.Focus()
                End If
            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox15_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            TextBox15.Focus()
        Catch ex As Exception
            MsgBox("frmnewrec/ComboBox3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim obj As New clsCommon
        Try
            Dim str, str1 As String
            Dim a As Integer
            Dim dr As SqlDataReader
            Dim toinks As String
            Dim BrancHLotno As String

            If TextBox15.TextLength <> 12 Then
                TextBox15.Text = TextBox15.Text.PadLeft(12, "0")
            End If

            RetrieveInfo(CStr(TextBox15.Text), 1, True)

            If ErrFlag = True Then
                ErrFlag = False
                Clear()
                Exit Sub
            End If


            BrancHLotno = GetBranch_Lotno()

            If ListView1.Items.Count > 0 Then

                obj = New clsCommon
                obj.ConnectionString1()
                obj.Opentracker()
                obj.CreateCom()

                str1 = "Insert Into REMS" & sDB & ".dbo.ASYS_REM_Header  (BranchCode,BranchName,Region,Area,PTN,PTNBarcode,LoanValue,Transdate,PulloutDate,CustId,CustName,CustAddress,CustCity,CustGender,CustTel,PTTime,PTDate,MaturityDate,ExpiryDate,LoanDate) Values ('" & txtBranchCode.Text & "', '" & Trim(txtbrname.Text) & "','" & Trim(lblRegion.Text) & "','" & Trim(lblArea.Text) & "', '" & TextBox15.Text & "','" & TextBox16.Text & "','" & CStr(CDbl(Label31.Text)) & "','" & Label36.Text & "','" & Label10.Text & "','" & Trim(Label23.Text) & "','" & Replace(Label24.Text, "'", "") & "','" & Replace(Trim(Label25.Text), "'", "") & "','" & Replace(Trim(Label26.Text), "'", "") & "','" & Label27.Text & "','" & Trim(Label28.Text) & "','" & Label36.Text & "','" & Label36.Text & "','" & Label29.Text & "','" & Label30.Text & "','" & Label32.Text & "' )"
                obj.commandTrack(str1)
                obj.TrackExecute()

                str1 = "Insert Into [REMS].dbo.ASYS_REM_Header  (Lotno,BranchCode,BranchName,Region,Area,PTN,PTNBarcode,LoanValue,Transdate,PulloutDate,CustId,CustName,CustAddress,CustCity,CustGender,CustTel,PTTime,PTDate,MaturityDate,ExpiryDate,LoanDate) Values ('" & BrancHLotno & "','" & txtBranchCode.Text & "', '" & Trim(txtbrname.Text) & "','" & Trim(lblRegion.Text) & "','" & Trim(lblArea.Text) & "', '" & TextBox15.Text & "','" & TextBox16.Text & "','" & CStr(CDbl(Label31.Text)) & "','" & Label36.Text & "','" & Label10.Text & "','" & Trim(Label23.Text) & "','" & Replace(Label24.Text, "'", "") & "','" & Replace(Trim(Label25.Text), "'", "") & "','" & Replace(Trim(Label26.Text), "'", "") & "','" & Label27.Text & "','" & Trim(Label28.Text) & "','" & Label36.Text & "','" & Label36.Text & "','" & Label29.Text & "','" & Label30.Text & "','" & Label32.Text & "' )"
                obj.commandTrack(str1)
                obj.TrackExecute()

                For a = 0 To ListView1.Items.Count - 1
                    str = "Insert into REMS" & sDB & ".dbo.ASYS_REM_detail (reflotno,lotno,PTN,itemid,RefItemcode,ItemCode,BranchItemDesc,RefQty,Qty,KaratGrading,CaratSize,Weight,ActionClass,Sortcode,ALL_desc,ALL_Karat,ALL_carat,ALL_Weight,Price_desc,Price_Karat,Price_weight,Price_carat,Appraiser,AppraiseValue,ReceiveDate,Receiver,Status) Values ('" & BrancHLotno & "','" & BrancHLotno & "','" & TextBox15.Text & "','" & ListView1.Items(a).SubItems.Item(7).Text & "','" & ListView1.Items(a).SubItems.Item(0).Text & "','" & ListView1.Items(a).SubItems.Item(0).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(2).Text & "','" & ListView1.Items(a).SubItems.Item(2).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ComboBox4.Text & "','" & ListView1.Items(a).SubItems.Item(5).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & Trim(Label22.Text) & "','" & CStr(CDbl(Label33.Text)) & "',getdate(),'" & Trim(lblReceiverName.Text) & "','RECEIVED')"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                    'obj.CommitTrack()

                    str = "Insert into [REMS].dbo.ASYS_REM_detail  (reflotno,lotno,PTN,itemid,RefItemcode,ItemCode,BranchItemDesc,RefQty,Qty,KaratGrading,CaratSize,Weight,ActionClass,Sortcode,ALL_desc,ALL_Karat,ALL_carat,ALL_Weight,Price_desc,Price_Karat,Price_weight,Price_carat,Appraiser,AppraiseValue,ReceiveDate,Receiver,Status) Values ('" & BrancHLotno & "','" & BrancHLotno & "','" & TextBox15.Text & "','" & ListView1.Items(a).SubItems.Item(7).Text & "','" & ListView1.Items(a).SubItems.Item(0).Text & "','" & ListView1.Items(a).SubItems.Item(0).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(2).Text & "','" & ListView1.Items(a).SubItems.Item(2).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ComboBox4.Text & "','" & ListView1.Items(a).SubItems.Item(5).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ListView1.Items(a).SubItems.Item(1).Text & "','" & ListView1.Items(a).SubItems.Item(3).Text & "','" & ListView1.Items(a).SubItems.Item(6).Text & "','" & ListView1.Items(a).SubItems.Item(4).Text & "','" & Trim(Label22.Text) & "','" & CStr(CDbl(Label33.Text)) & "',getdate(),'" & Trim(lblReceiverName.Text) & "','RECEIVED')"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                Next

                obj.commandTrack("Update tbl_pt_tran  set received =1 where division = '" + Me.txtBranchCode.Text.Trim + "' and ptn = '" + Me.TextBox15.Text.Trim + "'")
                obj.TrackExecute()

                obj.CommitTrack()
                toinks = "Successfully received from " + Trim(Me.txtbrname.Text) + " Branch"
                MsgBox(toinks, MsgBoxStyle.Information, TitleMsgBox)
            Else
                MsgBox("No details to save.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("Transaction has not been successfully saved.", MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close()
            obj = Nothing
            Call Clear()
        End Try

    End Sub
    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Try
            If TextBox15.Text <> "" Then
                Button3.Enabled = True
            Else
                Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/TextBox15_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function BcodeScanner(ByVal check As Boolean)
        Try
            If radNone.Checked = check Then

                ComboBox2.Enabled = False
                TextBox16.Enabled = False
                TextBox15.Enabled = True
                ComboBox1.Enabled = True
            ElseIf RadBarcode.Checked = check Then
                TextBox15.Enabled = False
                ComboBox1.Enabled = False
                ComboBox2.Enabled = True
                TextBox16.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmnewrec/BcodeScanner: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            recrelrep = True
            Dim frm As New Report
            frm.txtBranchCode.Text = txtBranchCode.Text
            frm.txtBranchName.Text = txtbrname.Text
            frm.Button3.Focus()
            frm.Label6.Visible = False
            frm.TextBox2.Visible = False
            frm.Text = "RECEIVING REPORT"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmnewrec/btnPrint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            If btnEdit.Text.ToUpper = "EDIT" Then
                ComboBox4.Enabled = True
                btnEdit.Text = "Update"
            Else
                If ListView1.Items.Count > 0 Then
                    objclass = New clsCommon
                    objclass.ConnectionString1()
                    objclass.Opentracker()
                    objclass.CreateCom()

                    objclass.commandTrack("update ASYS_REM_Detail set receivedate =  getdate(), receiver = '" + lblReceiverName.Text + "', actionclass = '" + ComboBox4.Text.Trim + "' where ptn = '" + TextBox15.Text + "' and status = 'RECEIVED'")
                    objclass.TrackExecute()

                    objclass.commandTrack("update rems.dbo.ASYS_REM_Detail set receivedate =  getdate(), receiver = '" + lblReceiverName.Text + "', actionclass = '" + ComboBox4.Text.Trim + "' where ptn = '" + TextBox15.Text + "' and status  = 'RECEIVED' ")
                    objclass.TrackExecute()
                    objclass.CommitTrack()

                    MsgBox("Item updated.", MsgBoxStyle.Information, TitleMsgBox)
                    Clear()
                    btnEdit.Text = "EDIT"
                    ComboBox4.Enabled = False
                    objclass.Close()
                    objclass = Nothing
                End If
            End If

        Catch ex As Exception
            MsgBox("frmnewrec/btnEdit_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

End Class
