'This program is edited by Marc Neil M. Monsanto.


Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common


Public Class frmEdit
    Inherits System.Windows.Forms.Form
    Dim objclass As New clsCommon
    Private sUserID, sAction, sSortClass As String()
    Private ptn As String
    Private odatetime As New clsCommon.DateTime
    Private sDivision As String
    Private iCellular As Integer = 3
    Private iWatch As Integer = 8
    Private iOverAppraised As Integer = 10
    Dim count As Integer
    Dim ctr As Integer
    Dim getctr As Integer
    Dim allwt As String
    Dim allvalue As String
    Dim allkarat As String
    Dim edit As Integer = 1
    Dim chr As Char
    Dim str As String
    Private iFocus, iEdit As Integer
    Private iAppliance As Integer = 1
    Private iGoodStock As Integer = 4
    Private iCoated As Integer = 5
    Private iJewelry As Integer = 6
    Private iFake As Integer = 9
    Private iMissingItem As Integer = 11
    Dim getsortcode As String
    Dim nonNumberEntered As Boolean = False
    Dim sPTn As String
    Dim sMPTN As String
    Dim SLotno As String
    Dim i As Integer

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
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblSorterIDNo As System.Windows.Forms.Label
    Friend WithEvents lblSortername As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents txtptn As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents txtptnbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtKarat As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtvalue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtlot As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEdit))
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtptnbarcode = New System.Windows.Forms.TextBox
        Me.txtptn = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.btnclose = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtvalue = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtweight = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtKarat = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblSorterIDNo = New System.Windows.Forms.Label
        Me.lblSortername = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.txtlot = New System.Windows.Forms.Label
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchCode.Enabled = False
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(640, 16)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(64, 20)
        Me.txtBranchCode.TabIndex = 115
        Me.txtBranchCode.Text = ""
        '
        'txtptnbarcode
        '
        Me.txtptnbarcode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtptnbarcode.Enabled = False
        Me.txtptnbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptnbarcode.Location = New System.Drawing.Point(640, 112)
        Me.txtptnbarcode.Name = "txtptnbarcode"
        Me.txtptnbarcode.Size = New System.Drawing.Size(168, 20)
        Me.txtptnbarcode.TabIndex = 119
        Me.txtptnbarcode.Text = ""
        '
        'txtptn
        '
        Me.txtptn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtptn.Enabled = False
        Me.txtptn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtptn.Location = New System.Drawing.Point(640, 88)
        Me.txtptn.Name = "txtptn"
        Me.txtptn.Size = New System.Drawing.Size(168, 20)
        Me.txtptn.TabIndex = 118
        Me.txtptn.Text = ""
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(496, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(96, 23)
        Me.Label52.TabIndex = 138
        Me.Label52.Text = "BRANCH CODE"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnclose
        '
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclose.Location = New System.Drawing.Point(944, 552)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(80, 40)
        Me.btnclose.TabIndex = 123
        Me.btnclose.TabStop = False
        Me.btnclose.Text = "CLOSE"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnclear
        '
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnclear.Location = New System.Drawing.Point(944, 552)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(80, 40)
        Me.btnclear.TabIndex = 122
        Me.btnclear.TabStop = False
        Me.btnclear.Text = "Clear"
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnsave
        '
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Image = CType(resources.GetObject("btnsave.Image"), System.Drawing.Image)
        Me.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsave.Location = New System.Drawing.Point(864, 552)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(80, 40)
        Me.btnsave.TabIndex = 120
        Me.btnsave.TabStop = False
        Me.btnsave.Text = "SAVE"
        Me.btnsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(248, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 184)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER INFORMATION"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(72, 144)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(224, 23)
        Me.Label42.TabIndex = 23
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(72, 120)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(224, 23)
        Me.Label41.TabIndex = 22
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(72, 96)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(328, 23)
        Me.Label40.TabIndex = 21
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(72, 72)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(328, 23)
        Me.Label39.TabIndex = 20
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(72, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(328, 23)
        Me.Label38.TabIndex = 19
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(72, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(224, 23)
        Me.Label37.TabIndex = 18
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "TEL NO."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "CITY"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "GENDER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "ADDRESS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID NO."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.txtvalue)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.txtweight)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtKarat)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 168)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ITEM INFORMATION"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 128)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 23)
        Me.Label24.TabIndex = 154
        Me.Label24.Text = "A.L.L. VALUE"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtvalue
        '
        Me.txtvalue.AutoSize = False
        Me.txtvalue.Enabled = False
        Me.txtvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvalue.Location = New System.Drawing.Point(104, 128)
        Me.txtvalue.MaxLength = 10
        Me.txtvalue.Name = "txtvalue"
        Me.txtvalue.Size = New System.Drawing.Size(92, 25)
        Me.txtvalue.TabIndex = 3
        Me.txtvalue.Text = ""
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 23)
        Me.Label23.TabIndex = 152
        Me.Label23.Text = "A.L.L. WEIGHT"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtweight
        '
        Me.txtweight.AutoSize = False
        Me.txtweight.Enabled = False
        Me.txtweight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweight.Location = New System.Drawing.Point(104, 96)
        Me.txtweight.MaxLength = 5
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(91, 25)
        Me.txtweight.TabIndex = 2
        Me.txtweight.Text = ""
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 23)
        Me.Label22.TabIndex = 150
        Me.Label22.Text = "A.L.L. KARAT"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtKarat
        '
        Me.txtKarat.AutoSize = False
        Me.txtKarat.Enabled = False
        Me.txtKarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKarat.Location = New System.Drawing.Point(104, 64)
        Me.txtKarat.MaxLength = 2
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.Size = New System.Drawing.Size(91, 25)
        Me.txtKarat.TabIndex = 1
        Me.txtKarat.Text = ""
        '
        'txtID
        '
        Me.txtID.AutoSize = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(104, 32)
        Me.txtID.MaxLength = 5
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(90, 25)
        Me.txtID.TabIndex = 0
        Me.txtID.Text = ""
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 23)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "ITEM ID"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(496, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 23)
        Me.Label17.TabIndex = 125
        Me.Label17.Text = "PT BARCODE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(496, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 124
        Me.Label16.Text = "PTN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(640, 40)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox4.TabIndex = 116
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(496, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 23)
        Me.Label19.TabIndex = 127
        Me.Label19.Text = "ACTION"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "A.L.L. SORTING CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 544)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "SORTER"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Visible = False
        '
        'lblSorterIDNo
        '
        Me.lblSorterIDNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSorterIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorterIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorterIDNo.Location = New System.Drawing.Point(128, 544)
        Me.lblSorterIDNo.Name = "lblSorterIDNo"
        Me.lblSorterIDNo.Size = New System.Drawing.Size(64, 21)
        Me.lblSorterIDNo.TabIndex = 137
        Me.lblSorterIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSorterIDNo.Visible = False
        '
        'lblSortername
        '
        Me.lblSortername.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSortername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSortername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSortername.Location = New System.Drawing.Point(200, 544)
        Me.lblSortername.Name = "lblSortername"
        Me.lblSortername.Size = New System.Drawing.Size(192, 21)
        Me.lblSortername.TabIndex = 136
        Me.lblSortername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSortername.Visible = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(640, 64)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox5.TabIndex = 119
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "ALL Weight"
        Me.ColumnHeader10.Width = 99
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Carat"
        Me.ColumnHeader5.Width = 55
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ALL Karat"
        Me.ColumnHeader9.Width = 84
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Karat"
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY"
        Me.ColumnHeader3.Width = 49
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Desc."
        Me.ColumnHeader2.Width = 217
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 87
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Weight"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 73
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sorting Class"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 119
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ALL Value"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 91
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Controls.Add(Me.txtlot)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1016, 195)
        Me.GroupBox3.TabIndex = 140
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRANSACTION DETAILS"
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22})
        Me.ListView2.Enabled = False
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 32)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(64, 64)
        Me.ListView2.TabIndex = 53
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "   CODE"
        Me.ColumnHeader22.Width = 63
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(895, 81)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(116, 11)
        Me.TextBox3.TabIndex = 52
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(895, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(116, 11)
        Me.TextBox2.TabIndex = 51
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(895, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(116, 11)
        Me.TextBox1.TabIndex = 50
        Me.TextBox1.Text = ""
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(120, 152)
        Me.Label47.Name = "Label47"
        Me.Label47.TabIndex = 38
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(120, 128)
        Me.Label46.Name = "Label46"
        Me.Label46.TabIndex = 37
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(808, 120)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(120, 23)
        Me.Label45.TabIndex = 36
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(808, 144)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(120, 23)
        Me.Label44.TabIndex = 35
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(808, 168)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(120, 23)
        Me.Label43.TabIndex = 34
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(608, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "DATE LOAN GRANTED"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(608, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(200, 23)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "TRANSACTION APPRAISED VALUE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(608, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 23)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "LOAN VALUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 23)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "MATURITY DATE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(24, 152)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 23)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "EXPIRY DATE"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Default
        Me.ListView1.AutoArrange = False
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader23})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(72, 32)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(944, 64)
        Me.ListView1.TabIndex = 13
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ITEM ID"
        Me.ColumnHeader11.Width = 55
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "          ITEM DESCRIPTION"
        Me.ColumnHeader12.Width = 180
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "  QTY"
        Me.ColumnHeader13.Width = 43
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "KARAT"
        Me.ColumnHeader14.Width = 46
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "A.L.L. KARAT"
        Me.ColumnHeader15.Width = 66
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "CARAT"
        Me.ColumnHeader16.Width = 45
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "SORTING CLASS"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 90
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "WEIGHT "
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 52
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "A.L.L. WEIGHT"
        Me.ColumnHeader19.Width = 76
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "A.L.L. VALUE"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader20.Width = 67
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "APPRAISED VALUE"
        Me.ColumnHeader21.Width = 101
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "     A.L.L. BARCODE"
        Me.ColumnHeader23.Width = 119
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(664, 80)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(48, 16)
        Me.txtlot.TabIndex = 24
        Me.txtlot.Text = "Label11"
        '
        'txtbrname
        '
        Me.txtbrname.AutoSize = False
        Me.txtbrname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbrname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbrname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrname.Enabled = False
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.ForeColor = System.Drawing.Color.Black
        Me.txtbrname.Location = New System.Drawing.Point(712, 16)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.ReadOnly = True
        Me.txtbrname.Size = New System.Drawing.Size(176, 20)
        Me.txtbrname.TabIndex = 141
        Me.txtbrname.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(672, 208)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 128)
        Me.GroupBox4.TabIndex = 142
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "PAWN TICKET INFORMATION"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(80, 91)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(264, 23)
        Me.Label36.TabIndex = 14
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(136, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(208, 23)
        Me.Label21.TabIndex = 13
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(136, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(208, 23)
        Me.Label20.TabIndex = 12
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APPRAISER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAWN TICKET DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 26)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "PAWN TICKET TIME"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(672, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(352, 48)
        Me.GroupBox5.TabIndex = 143
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BRANCH NAME"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(11, 17)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(285, 23)
        Me.Label48.TabIndex = 105
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 144
        Me.PictureBox1.TabStop = False
        '
        'frmEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 606)
        Me.Controls.Add(Me.lblSorterIDNo)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.txtptnbarcode)
        Me.Controls.Add(Me.txtptn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSortername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1036, 640)
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIT SORTED ITEMS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Try
            Dim frmsort As New frmSort
            frmsort.setPtn(txtptn.Text)
            frmsort.setIfEdit(edit)

            If force = False Then
                'frmsort.StartPosition = FormStartPosition.CenterScreen
                frmsort.Button3.Enabled = True
                frmsort.Button1.Enabled = True
                frmsort.Button4.Enabled = True
                frmsort.TextBox28.BackColor = Color.White
                frmsort.Select()
                frmsort.Button2.Focus()
                Me.Dispose()
                frmsort.ShowDialog()

            Else
                'frmsort.StartPosition = FormStartPosition.CenterScreen
                frmsort.Button3.Enabled = True
                frmsort.Button1.Enabled = True
                frmsort.Button4.Enabled = True
                frmsort.Select()
                frmsort.Button2.Focus()
                Me.Dispose()
                frmsort.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub DISPLAY_ALL()
        Try
            Dim sPTN As String
            Dim dr As SqlClient.SqlDataReader
            Dim bRecorded As Boolean
            Dim iset As Integer
            Dim sStatus, sSort_Code As String
            Dim iExist, iStatus, iAction_id, iUser_id As Integer
            Dim tempsbar As Long

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select branchcode,branchname,ptn,ptnbarcode,loanvalue,transdate,pulloutdate,custid,custname,custaddress,custcity,custgender,custtel,pttime,ptdate,maturitydate,expirydate,loandate from ASYS_REM_HEader where ptn = '" + txtptn.Text + "'")
            dr = objclass.OpenDataReader
            If dr.Read Then
                bRecorded = 1
                txtBranchCode.Text = dr.Item("branchcode")
                odatetime.Split(objclass.IsNull(dr.Item("Transdate")))
                If objclass.IsNull(dr.Item("pulloutdate")) = "0" Then
                    pdate = Now.Year
                Else
                    pdate = Year(objclass.IsNull(dr.Item("pulloutdate")))
                End If
                Label20.Text = odatetime.Time
                Label21.Text = odatetime.PTNDate
                Label37.Text = objclass.IsNull(dr.Item("CustID"))
                Label38.Text = objclass.IsNull(UCase(dr.Item("CustName")))
                Label39.Text = objclass.IsNull(UCase(dr.Item("CustAddress")))
                Label40.Text = objclass.IsNull(UCase(dr.Item("CustCity")))
                Label41.Text = objclass.IsNull(UCase(dr.Item("CustGender")))
                Label42.Text = objclass.IsNull(dr.Item("CustTel"))

                Label44.Text = FormatNumber(dr.Item("loanvalue"))
                Label45.Text = Trim(objclass.IsNull(dr.Item("LoanDate")))
                Label46.Text = Trim(objclass.IsNull(dr.Item("MaturityDate")))
                Label47.Text = Trim(objclass.IsNull(dr.Item("ExpiryDate")))

                If iset = 1 Then
                    txtptnbarcode.Text = Trim(objclass.IsNull(dr.Item("ptn_barcode")))
                Else
                    txtptn.Text = Trim(dr.Item("ptn"))
                End If
                odatetime = Nothing
            Else
                bRecorded = 0
                MsgBox("PTN item not found.", MsgBoxStyle.Information, TitleMsgBox)
                objclass.Close()
                objclass = Nothing
                Exit Sub

            End If
            dr.Close()
            objclass.CloseDataReader()



            objclass.Command("select refallbarcode,itemid as id,refitemcode,branchitemdesc,refqty,karatgrading,caratsize,weight,sortcode,all_karat,all_carat,all_weight,all_cost,appraiser,appraisevalue from ASYS_REM_DEtail where ptn ='" + txtptn.Text + "' order by refitemcode asc")
            dr = objclass.OpenDataReader()
            ListView1.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("ID")))
                ListView2.Items.Add(Trim(dr.Item("refItemcode")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(UCase(dr.Item("branchItemDesc")))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                If objclass.IsNull(dr.Item("ALL_KARAT")) = "" Then
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(0)
                Else
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_KARAT")))
                End If
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("sortcode"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("Weight")), 2))
                If objclass.IsNull(dr.Item("ALL_WeighT")) = "" Then
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(0)
                Else
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("ALL_WeighT")), 2))
                End If
                If objclass.IsNull(dr.Item("ALL_Cost")) = "" Then
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(0)
                Else
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("ALL_Cost")), 2))
                End If
                Label36.Text = objclass.IsNull(dr.Item("Appraiser"))
                Label43.Text = FormatNumber(objclass.IsNull(dr.Item("AppraiseValue")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(Label43.Text, 2))
                tempsbar = objclass.IsNull(dr.Item("refALLBarcode"))
                If tempsbar = "0" Then
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(0)
                Else
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(tempsbar)
                End If
                count += 1

            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()

            If Me.ComboBox4.Text.ToUpper = "GOODSTOCK" Or ComboBox4.Text.ToUpper = "WATCH" Or ComboBox4.Text.ToUpper = "CELLULAR" Then
                'If tempsbar = "0" Then
                Call NewGenAllBArcode()
                'End If
                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                End If
            Else
                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                End If
            End If

            If Me.ListView1.Items.Count = 1 Then
                Me.TextBox1.Text = ListView1.Items(ListView1.Items.Count - 1).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 2 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 3 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
                Me.TextBox3.Text = ListView1.Items(2).SubItems.Item(11).Text
            End If


            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select ptnbarcode from ASYS_REM_Header where ptn = '" + txtptn.Text + "'")
            dr = objclass.OpenDataReader
            If dr.Read Then
                txtptnbarcode.Text = Trim(objclass.IsNull(dr.Item("PTNBarcode")))
            End If
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()



            objclass.ConnDb()
            objclass.Open5()

            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'If UCase(sDB) = "LUZON" Then
            '    objclass.Command5("select bedrnm from " & bedryfLuzon & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'ElseIf UCase(sDB) = "VISMIN" Then
            '    objclass.Command5("select bedrnm from " & bedryfVismin & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'ElseIf UCase(sDB) = "SHOWROOM" Then
            '    objclass.Command5("select bedrnm from " & bedryfShowroom & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'ElseIf UCase(sDB) = "MINDANAO" Then
            '    objclass.Command5("select bedrnm from " & bedryfMindanao & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'Else
            '    objclass.Command5("select bedrnm from " & bedryfLNCR & " where bedrnr = '" + Trim(txtBranchCode.Text) + "'")
            'End If
            dr = objclass.OpenDataReader5
            If dr.Read Then
                txtbrname.Text = Trim(dr.Item("bedrnm"))
                Label48.Text = Trim(UCase(dr.Item("bedrnm")))
            End If
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim dr As SqlDataReader
            Dim i As Integer
            Dim ptns As String

            txtlot.Text = GenerateLot()
            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select action_type,action_id from tbl_action where action_id in(6,3,8,11,10,4,9,5) order by action_type")
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

            objclass.Command("select description,code from tbl_sortclass order by description")
            dr = objclass.OpenDataReader()
            i = 0
            While dr.Read
                ReDim Preserve sSortClass(i)
                ComboBox5.Items.Add(Trim(UCase(UCase(dr.Item("description")))))
                sSortClass(i) = Trim(dr.Item("code"))
                i = i + 1
            End While
            dr.Close()
            objclass.Close()

            'objclass.ConnectionString1()
            'objclass.Open()
            objclass.Command("select fullname, res_id from vw_humresall where emp_stat = 'A' and comp='001' and (job_title like 'ALL%' or Job_title ='SORTER') order by fullname")
            'Call SelectAction(objclass.action.Jewelry)
            objclass = Nothing
            'Call RetrievePTN_Barcode()
            'Call clear()
            lblSorterIDNo.Text = idnumber
            lblSortername.Text = UCase(fullname)
            ComboBox4.Text = UCase(s_action)
            ComboBox5.Text = UCase(s_class)
            ListView1.Enabled = False

            If txtptn.Text <> "" Then
                btnsave.Enabled = True
            Else
                Me.btnsave.Enabled = False
            End If
            Call DISPLAY_ALL()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear()
        Try
            txtKarat.Text = ""
            txtvalue.Text = ""
            txtweight.Text = ""
            txtID.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            Label42.Text = ""
            Label48.Text = ""
            Label20.Text = ""
            Label21.Text = ""
            Label36.Text = ""
            Label46.Text = ""
            Label47.Text = ""
            Label45.Text = ""
            Label44.Text = ""
            Label43.Text = ""
            Label37.Text = ""
            getctr = 0
            clear2()
            txtKarat.Enabled = False
            txtweight.Enabled = False
            txtvalue.Enabled = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            txtID.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub clear2()
        Try
            ListView2.Items.Clear()
            ListView1.Items.Clear()
            txtID.Text = ""
            txtID.Focus()
        Catch ex As Exception

        End Try
        'display2()
    End Sub
    Public Sub display2()
        Try
            Dim mptns As String
            Dim ptns As String
            Dim dr As SqlClient.SqlDataReader

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()


            objclass.Command("select itemid as id,refallbarcode,refitemcode,branchitemdesc,refqty,karatgrading,caratsize,weight,sortcode,all_karat,all_carat,all_weight,all_cost from ASYS_REM_Detail where ptn ='" + txtptn.Text + "'")
            dr = objclass.OpenDataReader
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("ID")))
                ListView2.Items.Add(dr.Item("refitemcode"))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(UCase(dr.Item("branchItemDesc")))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refQty"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("sortcode"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("Weight")), 2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("ALL_Weight")), 2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("all_cost")), 2))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("all_cost"))))
                count += 1
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnclear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Private Sub GenBarcode()
        Try
            If Me.ComboBox4.Text.ToString = "GOODSTOCK" Or ComboBox4.Text.ToString = "WATCH" Or ComboBox4.Text.ToString = "CELLULAR" Then
                Call NewGenAllBArcode()
                txtlot.Text = GenerateLot()
                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                End If
            Else
                txtlot.Text = "0"
                If Me.ListView1.Items.Count = 1 Then
                    ListView1.Items(0).SubItems.Item(11).Text = "0"
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 2 Then
                    ListView1.Items(0).SubItems.Item(11).Text = "0"
                    ListView1.Items(1).SubItems.Item(11).Text = "0"
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 3 Then
                    ListView1.Items(0).SubItems.Item(11).Text = "0"
                    ListView1.Items(1).SubItems.Item(11).Text = "0"
                    ListView1.Items(2).SubItems.Item(11).Text = "0"
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                End If
            End If

            If Me.ListView1.Items.Count = 1 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 2 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 3 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
                Me.TextBox3.Text = ListView1.Items(2).SubItems.Item(11).Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub NEwSAVEPTN()
        Dim l As Integer
        Dim obj As New clsCommon
        Dim str As String
        Try
            obj = New clsCommon
            obj.ConnectionString1()
            obj.Opentracker()
            obj.CreateCom()

            For l = 0 To ListView1.Items.Count - 1
                str = "Update ASYS_REM_Detail  set refallbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',allbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',Actionclass = '" & ComboBox4.Text & "',sortcode = '" & getsortcode & "',all_karat = '" & ListView1.Items(l).SubItems.Item(4).Text & "',all_weight = '" & ListView1.Items(l).SubItems.Item(8).Text & "',all_cost = '" & CStr(CDbl(ListView1.Items(l).SubItems.Item(9).Text)) & "',Sortdate = getdate(),sortername = '" & userLog & "',status = 'SORTED' where ptn ='" & txtptn.Text & "' and itemid = '" & ListView1.Items(l).SubItems.Item(0).Text & "' and status not in ('RELEASED','RECMLWB')  "
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update [REMS].dbo.ASYS_REM_Detail  set refallbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',allbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',Actionclass = '" & ComboBox4.Text & "',sortcode = '" & getsortcode & "',all_karat = '" & ListView1.Items(l).SubItems.Item(4).Text & "',all_weight = '" & ListView1.Items(l).SubItems.Item(8).Text & "',all_cost = '" & CStr(CDbl(ListView1.Items(l).SubItems.Item(9).Text)) & "',Sortdate = getdate(),sortername = '" & userLog & "',status = 'SORTED' where ptn ='" & txtptn.Text & "' and itemid = '" & ListView1.Items(l).SubItems.Item(0).Text & "' and status not in ('RELEASED','RECMLWB') "
                obj.commandTrack(str)
                obj.TrackExecute()

                If ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text = "CELLULAR" Or ComboBox4.Text = "WATCH" Then
                    str = "insert into [REMS].DBO.asys_barcodehistory  (lotno, refallbarcode,allbarcode, itemcode,itemid, [description], karat, carat, weight, empname,trandate, costcenter,  status ) values ('" & SLotno & "','" & ListView1.Items(l).SubItems.Item(11).Text & "','" & ListView1.Items(l).SubItems.Item(11).Text & "','" & Mid(ListView1.Items(l).SubItems.Item(11).Text, 1, 3) & "','" & ListView1.Items(l).SubItems.Item(0).Text & "','" & ListView1.Items(l).SubItems.Item(1).Text & "','" & ListView1.Items(l).SubItems.Item(3).Text & "','" & ListView1.Items(l).SubItems.Item(5).Text & "','" & ListView1.Items(l).SubItems.Item(7).Text & "','" & Trim(userLog) & "',getdate(),'REM','RECEIVED')"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                End If
            Next

            obj.CommitTrack()
            MsgBox("SAVE SUCCESSFULLY.", MsgBoxStyle.Information, TitleMsgBox)
            btnsave.Enabled = False
            btnclose.Focus()

        Catch ex As Exception
            obj.RollBackTrack()
        Finally
            obj.Close()
        End Try

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Try
            'If ComboBox5.SelectedIndex = 0 Or ComboBox5.SelectedIndex = -1 Then
            '    getsortcode = "C"
            'ElseIf ComboBox5.SelectedIndex = 1 Then
            '    getsortcode = "OG"
            'ElseIf ComboBox5.SelectedIndex = 2 Then
            '    getsortcode = "S"
            'End If
            getsortcode = ComboBox5.SelectedItem
            If ComboBox5.Text = "OTHERS" Then
                getsortcode = "O"
            End If
            If ComboBox4.Text = "JEWELRY" Then
                If ComboBox5.Text = "" Then
                    MsgBox("Please choose desired sorting class.", MsgBoxStyle.Information, TitleMsgBox)
                    ComboBox5.Select()
                    ComboBox5.Focus()
                    Exit Sub
                End If
            End If
            Call GenBarcode()
            'txtlot.Text = GenerateLot()
            Call NEwSAVEPTN()

            '  clear()
            objclass = Nothing
            'saveALLEdit1()
            'txtID.Focus()
        Catch ex As Exception

        End Try
    End Sub
    'Passing by parameter
    Public Sub setPtn(ByVal ptn1 As String, ByVal lotno As String)
        Try
            SLotno = lotno
            ptn = ptn1
            txtptn.Text = ptn
            'Msgbox(ptn)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtID_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown
        Try


            Dim f As Integer
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
                f = 0
                For ctr = 0 To ListView1.Items.Count - 1
                    If ListView1.Items.Item(ctr).Text = Trim(txtID.Text) Then
                        getctr = ctr
                        f = 1
                        Exit For
                    End If
                Next
                If f = 0 Then
                    MsgBox("Select Item ID in the table below.", MsgBoxStyle.Information, TitleMsgBox)
                    txtID.Text = ""
                    txtID.Focus()
                    txtKarat.Enabled = False
                    txtweight.Enabled = False
                    txtvalue.Enabled = False
                Else
                    txtKarat.Enabled = True
                    txtweight.Enabled = True
                    txtvalue.Enabled = True
                    txtKarat.Focus()
                End If

                If Me.ComboBox4.Text.ToString = "GOODSTOCK" Or ComboBox4.Text.ToString = "WATCH" Or ComboBox4.Text.ToString = "CELLULAR" Then
                    Call NewGenAllBArcode()
                    If Me.ListView1.Items.Count = 1 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox2.BackColor = Nothing
                        Me.TextBox3.BackColor = Nothing
                    ElseIf Me.ListView1.Items.Count = 2 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.BackColor = Color.White
                        Me.TextBox3.Enabled = False
                        Me.TextBox3.BackColor = Nothing
                    ElseIf Me.ListView1.Items.Count = 3 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.BackColor = Color.White
                        Me.TextBox3.BackColor = Color.White
                    Else
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox1.BackColor = Nothing
                        Me.TextBox2.BackColor = Nothing
                        Me.TextBox3.BackColor = Nothing
                    End If
                Else
                    If Me.ListView1.Items.Count = 1 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox2.BackColor = Nothing
                        Me.TextBox3.BackColor = Nothing
                        Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                    ElseIf Me.ListView1.Items.Count = 2 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.BackColor = Color.White
                        Me.TextBox3.Enabled = False
                        Me.TextBox3.BackColor = Nothing
                        Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                        Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                    ElseIf Me.ListView1.Items.Count = 3 Then
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox1.BackColor = Color.White
                        Me.TextBox2.BackColor = Color.White
                        Me.TextBox3.BackColor = Color.White
                        Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                        Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                        Me.ListView1.Items.Item(2).SubItems.Item(11).Text = "0"
                    Else
                        Me.TextBox1.Enabled = False
                        Me.TextBox2.Enabled = False
                        Me.TextBox3.Enabled = False
                        Me.TextBox1.BackColor = Nothing
                        Me.TextBox2.BackColor = Nothing
                        Me.TextBox3.BackColor = Nothing
                        Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                        Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                        Me.ListView1.Items.Item(2).SubItems.Item(11).Text = "0"
                    End If
                End If

                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Text = ListView1.Items(ListView1.Items.Count - 1).SubItems.Item(11).Text
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                    Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                    Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
                    Me.TextBox3.Text = ListView1.Items(2).SubItems.Item(11).Text
                End If

            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub txtKarat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKarat.KeyDown
        Try
            If e.KeyCode = 13 Or e.KeyCode = 9 Then
                If txtID.Text = "" Then
                    MsgBox("Select Item ID in the table below...", MsgBoxStyle.Information, TitleMsgBox)
                    txtID.Focus()
                    Exit Sub
                End If

                If txtKarat.Text = "" Then
                    txtweight.Text = ""
                    txtweight.Focus()
                    Exit Sub
                End If
                ListView1.Items(getctr).SubItems.Item(4).Text = FormatNumber(CDbl(txtKarat.Text), 0)
                txtweight.Text = ""
                txtweight.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtweight_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtweight.KeyDown
        Try
            If e.KeyCode = 13 Or e.KeyCode = 9 Then

                If txtID.Text = "" Then
                    MsgBox("Select Item ID in the table below...", MsgBoxStyle.Information, TitleMsgBox)
                    txtID.Focus()
                    Exit Sub
                End If

                If txtweight.Text = "" Then
                    txtvalue.Text = ""
                    txtvalue.Focus()
                    Exit Sub
                End If
                ListView1.Items(getctr).SubItems.Item(8).Text = FormatNumber(CDbl(txtweight.Text), 2)
                txtvalue.Text = ""
                txtvalue.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtvalue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtvalue.KeyDown
        Try
            nonNumberEntered = False
            ' Determine whether the keystroke is a number from the top of the keyboard.
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                ' Determine whether the keystroke is a number from the keypad.
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    ' Determine whether the keystroke is a backspace.
                    If e.KeyCode <> Keys.Back And e.KeyCode <> Keys.Decimal And e.KeyCode <> Keys.OemPeriod Then
                        ' A non-numerical keystroke was pressed. 
                        ' Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = True
                    End If
                End If
            End If

            If e.KeyCode = 13 Or e.KeyCode = 9 Then
                If txtID.Text = "" Then
                    MsgBox("Select Item ID in the table below...", MsgBoxStyle.Information, TitleMsgBox)
                    txtID.Focus()
                    Exit Sub
                End If

                If txtvalue.Text <> "" Then
                    ListView1.Items(getctr).SubItems(9).Text = FormatNumber(CDbl(txtvalue.Text), 2)
                    'txtID.Text = ""
                End If
                txtKarat.Enabled = False
                txtweight.Enabled = False
                txtvalue.Enabled = False
                btnsave.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        Try
            txtKarat.Text = ""
            txtweight.Text = ""
            txtvalue.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtID.KeyPress
        Try
            If nonNumberEntered = True Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtweight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtweight.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If txtweight.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If txtweight.SelectionStart > txtweight.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtvalue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalue.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
        End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            Dim frm As New frmSort

            If ComboBox4.Text = "JEWELRY" Then
                ComboBox5.Text = ""
                ComboBox5.Items.Clear()

                'asys 3.0 specs
                Me.ComboBox5.Text = frm.ComboBox5.SelectedItem
                ComboBox5.Items.Add("9K/10K")
                ComboBox5.Items.Add("12K/14K")
                ComboBox5.Items.Add("16K/18K")
                ComboBox5.Items.Add("20K")
                ComboBox5.Items.Add("21K/22K/24K")
                ComboBox5.Enabled = True
                txtID.Focus()
            End If

            If ComboBox4.Text = "JEWELRY" Then
                If ComboBox5.Text <> "" Then
                    btnsave.Enabled = True
                Else
                    btnsave.Enabled = False
                    ComboBox5.Focus()
                    Exit Sub
                End If
            End If
            If ComboBox4.Text = "FAKE" Or ComboBox4.Text = "COATED" Or ComboBox4.Text = "MISSINGITEM" Or ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text = "OVERAPPRAISED" Or ComboBox4.Text = "CELLULAR" Or ComboBox4.Text = "WATCH" Or ComboBox4.Text = "APPLIANCE" Then

                ComboBox5.Text = "OTHERS"
                ComboBox5.Enabled = False

                txtID.Focus()
            ElseIf ComboBox4.Text = "TAKENBACK" Or ComboBox4.Text = "AUCTIONBUYER" Then
                ComboBox5.Text = ""
                ComboBox5.Enabled = False
                txtID.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub NewGenAllBArcode()
    '    Try
    '        Dim obcls As New clsCommon
    '        Dim dr4 As SqlDataReader
    '        Dim ptncode, itemcode1, itemcode2, itemcode3, supcode1, supcode2, yearcode, seqcode, AllCode1, allcode2, allcode3, divcode, drcode As String
    '        Dim tempall, Squery As String
    '        Dim x As Integer
    '        'Dim pulldate As Integer

    '        'pulldate = pulldate1


    '        obcls.ConnectionString2()
    '        obcls.Open2()
    '        If Me.ListView2.Items.Count > 1 Then
    '            For x = 0 To ListView2.Items.Count - 1
    '                Squery = "IF (SELECT Max(Substring(refALLBarcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033') > (SELECT ISNUll(Max(Substring(refallbarcode,9,16)),0) as Barcode FROM rems.dbo.ASYS_REMOUtsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033') BEGIN (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033')END ELSE (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REMOutsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033')"
    '                obcls.Command2(Squery)
    '                dr4 = obcls.OpenDataReader2
    '                If dr4.Read Then
    '                    tempall = obcls.IsNull(dr4.Item("Barcode"))
    '                    If tempall = "0" Then
    '                        If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
    '                            If Me.ListView1.Items.Count = 3 Then
    '                                If (Me.ListView2.Items(0).Text = Me.ListView2.Items(1).Text And Me.ListView2.Items(1).Text = Me.ListView2.Items(2).Text) And (Me.ListView2.Items(0).Text = Me.ListView2.Items(2).Text) Then
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    ElseIf x = 1 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 3)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).Text <> Me.ListView2.Items(1).Text) And (Me.ListView2.Items(0).Text = Me.ListView2.Items(2).Text) Then
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    ElseIf x = 1 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).Text <> Me.ListView2.Items(1).Text) And (Me.ListView2.Items(1).Text = Me.ListView2.Items(2).Text) Then
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    ElseIf x = 1 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).Text = Me.ListView2.Items(1).Text) And (Me.ListView2.Items(1).Text <> Me.ListView2.Items(2).Text) Then
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    ElseIf x = 1 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    End If
    '                                Else
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    ElseIf x = 1 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    End If
    '                                End If
    '                            ElseIf Me.ListView2.Items.Count = 2 Then
    '                                If Me.ListView2.Items(0).Text = Me.ListView2.Items(1).Text Then
    '                                    If x = 0 Then
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    '                                    Else
    '                                        itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                        supcode1 = "39033"

    '                                        If CStr(pdate) <> "0" Then
    '                                            yearcode = pdate
    '                                        Else
    '                                            yearcode = Now.Year
    '                                        End If

    '                                        seqcode = "0000"
    '                                        allcode2 = Replace(itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2), " ", "")
    '                                        ListView1.Items(x).SubItems.Item(11).Text = allcode2
    '                                    End If
    '                                Else
    '                                    itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                                    supcode1 = "39033"
    '                                    If CStr(pdate) <> "0" Then
    '                                        yearcode = pdate
    '                                    Else
    '                                        yearcode = Now.Year
    '                                    End If
    '                                    seqcode = "0000"
    '                                    allcode2 = Replace(itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1), " ", "")
    '                                    ListView1.Items(x).SubItems.Item(11).Text = allcode2
    '                                End If
    '                            End If
    '                        End If
    '                    Else
    '                        If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
    '                            itemcode1 = ListView2.Items(x).SubItems.Item(0).Text.Trim
    '                            supcode1 = "39033"
    '                            drcode = tempall
    '                            AllCode1 = itemcode1 & supcode1 & Val(drcode + 1)
    '                            'ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                            If ListView2.Items.Count = 3 Then
    '                                If (Me.ListView2.Items(0).SubItems.Item(0).Text = Me.ListView2.Items(1).SubItems.Item(0).Text) And (Me.ListView2.Items(1).SubItems.Item(0).Text = Me.ListView2.Items(2).SubItems.Item(0).Text) Then
    '                                    If x = 0 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    ElseIf x = 1 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    '                                    Else
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 3)
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).SubItems.Item(0).Text <> Me.ListView2.Items(1).SubItems.Item(0).Text) And (Me.ListView2.Items(0).SubItems.Item(0).Text = Me.ListView2.Items(2).SubItems.Item(0).Text) Then
    '                                    If x = 0 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    ElseIf x = 1 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    Else
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).SubItems.Item(0).Text <> Me.ListView2.Items(1).SubItems.Item(0).Text) And (Me.ListView2.Items(1).SubItems.Item(0).Text = Me.ListView2.Items(2).SubItems.Item(0).Text) Then
    '                                    If x = 0 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    ElseIf x = 1 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 1)
    '                                    Else
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    '                                    End If
    '                                ElseIf (Me.ListView2.Items(0).SubItems.Item(0).Text = Me.ListView2.Items(1).SubItems.Item(0).Text) And (Me.ListView2.Items(1).SubItems.Item(0).Text <> Me.ListView2.Items(2).SubItems.Item(0).Text) Then
    '                                    If x = 0 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 1)
    '                                    ElseIf x = 1 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    '                                    Else
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    End If
    '                                Else
    '                                    ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                End If
    '                            Else
    '                                If (Me.ListView2.Items(0).SubItems.Item(0).Text = Me.ListView2.Items(1).SubItems.Item(0).Text) Then
    '                                    If x = 0 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                    ElseIf x = 1 Then
    '                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    '                                    End If
    '                                Else
    '                                    ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '                dr4.Close()
    '            Next
    '        Else
    '            Squery = "IF (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "') > (SELECT ISNUll(Max(Substring(refALLBArcode,9,16)),0) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "') BEGIN (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "')END ELSE (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REMOutsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.ListView2.Items(x).SubItems.Item(0).Text & "')"
    '            obcls.Command2(Squery)
    '            dr4 = obcls.OpenDataReader2
    '            If dr4.Read Then
    '                tempall = obcls.IsNull(dr4.Item("Barcode"))
    '                If tempall = "0" Then
    '                    itemcode1 = ListView2.Items(0).SubItems.Item(0).Text.Trim
    '                    supcode1 = "30"
    '                    If Me.txtptn.Text.Trim.Length = 12 Then
    '                        ptncode = Mid(Me.txtptn.Text.Trim, 8, 12)
    '                    Else
    '                        ptncode = Mid(Me.txtptn.Text.Trim, 7, 11)
    '                    End If
    '                    divcode = Me.txtBranchCode.Text

    '                    If CStr(pdate) <> "0" Then
    '                        yearcode = pdate
    '                    Else
    '                        yearcode = Now.Year
    '                    End If

    '                    seqcode = "00001"
    '                    AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
    '                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                Else
    '                    itemcode1 = ListView2.Items(0).SubItems.Item(0).Text.Trim
    '                    supcode1 = "30"
    '                    divcode = Me.txtBranchCode.Text
    '                    If Me.txtptn.Text.Trim.Length = 12 Then
    '                        ptncode = Mid(Me.txtptn.Text.Trim, 8, 12)
    '                    Else
    '                        ptncode = Mid(Me.txtptn.Text.Trim, 7, 11)
    '                    End If
    '                    If CStr(pdate) <> "0" Then
    '                        yearcode = pdate
    '                    Else
    '                        yearcode = Now.Year
    '                    End If

    '                    'seqcode = "00001"
    '                    drcode = tempall
    '                    AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
    '                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                End If
    '                dr4.Close()
    '            End If
    '        End If
    '        obcls.Execute2()
    '        obcls.Close2()
    '        pdate = Nothing
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub NewGenAllBArcode()
        Try
            Dim i As Integer
            Dim x As Integer
            Dim tmpItemCode As String
            Dim tmpBranchCode As String
            Dim tmpYearCode As String
            Dim tmpSequence As String
            Dim tmpBarcode As String
            Dim obj As New clsCommon
            Dim objClass As New clsCommon
            Dim dr As SqlDataReader
            Dim drClass As SqlDataReader
            Dim strSQL As String
            Dim tmpctr As String

            tmpYearCode = Now.Year
            tmpBranchCode = Trim(Me.txtBranchCode.Text)
            tmpSequence = Mid(txtptn.Text, 8)

            If listview2.Items.Count <= 1 Then
                tmpItemCode = Trim(listview2.Items(0).SubItems.Item(0).Text)
                tmpBarcode = tmpItemCode & "30" & tmpBranchCode & tmpYearCode & tmpSequence
                tmpctr = tmpItemCode & "30" & tmpBranchCode & tmpYearCode

                strSQL = "exec ASYS_GetMaxBarcode '" & tmpBarcode & "',3"
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3(strSQL)
                dr = obj.OpenDataReader3

                If dr.Read Then
                    strSQL = "exec ASYS_GetMaxBarcode '" & tmpctr & "',1"
                    objClass = New clsCommon
                    objClass.Connectionstring3()
                    objClass.Open3()
                    objClass.Command3(strSQL)
                    drClass = objClass.OpenDataReader3

                    If drClass.Read Then
                        ListView1.Items(0).SubItems.Item(11).Text = tmpctr & drClass.Item("Barcode") + 1
                    End If
                    objClass.Close()
                    drClass.Close()
                Else
                    ListView1.Items(0).SubItems.Item(11).Text = tmpBarcode
                End If

                ListView1.Items(0).SubItems.Item(11).Text = tmpItemCode & "30" & tmpBranchCode & tmpYearCode & tmpSequence
            Else
                For i = 0 To listview2.Items.Count - 1
                    tmpItemCode = Trim(Me.listview2.Items(i).Text())
                    tmpctr = tmpItemCode & "39033" & tmpYearCode

                    strSQL = "exec ASYS_GetMaxBarcode '" & tmpctr & "',1"
                    objClass = New clsCommon
                    objClass.Connectionstring3()
                    objClass.Open3()
                    objClass.Command3(strSQL)
                    drClass = objClass.OpenDataReader3

                    If drClass.Read Then
                        If (tmpSequence - 1) = drClass.Item("Barcode") + 1 Then
                            tmpSequence = tmpSequence
                        ElseIf (tmpSequence - 2) = drClass.Item("Barcode") + 1 Then
                            tmpSequence = tmpSequence
                        Else
                            tmpSequence = drClass.Item("Barcode") + 1
                        End If

                    Else
                        tmpSequence = 1
                    End If

                    ' For x = i To ListView1.Items.Count - 1
                    ListView1.Items(i).SubItems.Item(11).Text = tmpctr & tmpSequence.PadLeft(5, "0")
                    tmpSequence = CInt(tmpSequence) + 1
                    'Next
                    ' tmpSequence = CInt(tmpSequence) + 1
                Next
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim sss As String
            'MsgBox('" & FormatLot & "' '" & userlog & "')
            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()

            sss = "if (select Count([REMS" & sDB & "].dbo.ASYS_REM_Detail.reflotno) as lotno from [REMS" & sDB & "].dbo.ASYS_REM_Detail  where "
            sss = sss + " ( [REMS" & sDB & "].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND  [REMS" & sDB & "].dbo.ASYS_REM_detail.Actionclass = '" & Trim(ComboBox4.Text) & "' and "
            sss = sss + " (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_Detail.RefLotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " AND (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_Detail.RefLotno, 1, 4) AS int(2)) = YEAR(GETDATE()))) = 0 "
            sss = sss + " begin "
            sss = sss + "   if (Select Count(LOTNO) as lotno from REMS.dbo.ASYS_LOTNO_gen  where  (CAST(SUBSTRING(Lotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " and (CAST(SUBSTRING(LOTNO, 1, 4) AS int(2)) = YEAR(GETDATE()))) = 0"
            sss = sss + "  begin "
            sss = sss + "   select  Cast(YEar(getdate()) as char(4)) + Cast(REPLACE(STR(month(getdate()), 2, 0), SPACE(1), '0')  as char(2))"
            sss = sss + " + '0001' LOTNO   from [REMS].dbo.ASYS_LOTNO_Gen "
            sss = sss + "  end else"
            sss = sss + "   select LOTNO from [REMS].dbo.ASYS_lotno_Gen "
            sss = sss + " end  else"
            sss = sss + "  select Isnull(Max(reflotno),0) as lotno from [REMS" & sDB & "].dbo.ASYS_REM_Detail  where "
            sss = sss + " ( [REMS" & sDB & "].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND  [REMS" & sDB & "].dbo.ASYS_REM_detail.Actionclass = '" & Trim(ComboBox4.Text) & "' and "
            sss = sss + " (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_detail.RefLotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " AND (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_Detail.RefLotno, 1, 4) AS int(2)) = YEAR(GETDATE()))"

            'objclass.Command3("if (Select Count(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) <> 0 begin If (select Max(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) > (Select Max(reclotno) as lotno from rems.dbo.tbl_receiving_header) begin Select Coalesce(Max(lotno_for),(Select Max(lotno_for) from tbl_forcedoutrcv) + 1) as lotno from rems.dbo.tbl_forcedoutrcv where recname_for ='" & userLog & "'  and day(receivedate_FOR) = day(getdate()) and Month(receivedate_FOR)= MOnth(getdate()) and year(receivedate_FOR) = Year(getdate())end else	Select Coalesce(Max(reclotno),(select max(reclotno) from tbl_receiving_header) + 1) as lotno from rems.dbo.tbl_receiving_header where recname ='" & userLog & "' and day(receivedate) = day(getdate()) and Month(receivedate)= MOnth(getdate()) and year(receivedate) = Year(getdate()) end else Select Isnull(Max(reclotno) + 1," & FormatLot & ") as lotno from rems.dbo.tbl_receiving_header ")
            objclass.Command(sss)
            dr = objclass.OpenDataReader
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            objclass.Execute()
            objclass.Close()
        Catch ex As Exception

        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function
    Private Sub SavePTN()
        Dim l, f As Integer
        'Try catch in UPDATING

        Try
            For f = 0 To Me.ListView1.Items.Count - 1
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                If CInt(sAction(ComboBox4.SelectedIndex)) = iAppliance Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate=getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCellular Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iGoodStock Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCoated Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iJewelry Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + " 'where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iWatch Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iFake Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iOverAppraised Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "',sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iMissingItem Then
                    objclass.Command("update tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If
                objclass.Execute()
            Next
            objclass.Close()


            For f = 0 To Me.ListView1.Items.Count - 1
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                If CInt(sAction(ComboBox4.SelectedIndex)) = iAppliance Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate=getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCellular Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iGoodStock Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCoated Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iJewelry Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + " 'where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iWatch Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iFake Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iOverAppraised Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='0',recItem_ID='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', reccostid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iMissingItem Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno = null,recAllBarcode='0',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', reccostid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + txtptn.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If
                objclass.Execute()
            Next
            objclass.Close()


            For l = 0 To ListView1.Items.Count - 1
                objclass.Open()
                If ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text = "CELLULAR" Or ComboBox4.Text = "WATCH" Then
                    objclass.Command("Update tbl_receiving_detail set dlotno = '" & txtlot.Text & "',DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.txtptn.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                Else
                    objclass.Command("Update tbl_receiving_detail set dlotno = null,DALLBarcode = '0' where Dptn = '" & Me.txtptn.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")

                End If
                objclass.Execute()
                objclass.Close()
            Next
            For l = 0 To ListView1.Items.Count - 1
                objclass.Open()
                If ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text = "CELLULAR" Or ComboBox4.Text = "WATCH" Then
                    objclass.Command("Update REMS.dbo.tbl_receiving_detail set dlotno = '" & txtlot.Text & "',DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.txtptn.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                Else
                    objclass.Command("Update REMS.dbo.tbl_receiving_detail set dlotno = null,DALLBarcode = '0' where Dptn = '" & Me.txtptn.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                End If

                objclass.Execute()
                objclass.Close()
            Next
            returnfocus1()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
    Private Sub returnfocus1()
        Try
            If iFocus = 15 Then
                txtptn.Text = ""
                txtptn.Focus()
            ElseIf iFocus = 16 Then
                txtptnbarcode.Text = ""
                txtptnbarcode.Focus()
            End If
            iEdit = iFocus
            iFocus = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditAction()
        Try
            If Me.ComboBox4.Text.ToString = "GOODSTOCK" Or ComboBox4.Text.ToString = "WATCH" Or ComboBox4.Text.ToString = "CELLULAR" Then
                Call NewGenAllBArcode()
                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                End If
            Else
                If Me.ListView1.Items.Count = 1 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                    Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                ElseIf Me.ListView1.Items.Count = 2 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.Enabled = False
                    Me.TextBox3.BackColor = Nothing
                    Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                    Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                ElseIf Me.ListView1.Items.Count = 3 Then
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Color.White
                    Me.TextBox2.BackColor = Color.White
                    Me.TextBox3.BackColor = Color.White
                    Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                    Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                    Me.ListView1.Items.Item(2).SubItems.Item(11).Text = "0"
                Else
                    Me.TextBox1.Enabled = False
                    Me.TextBox2.Enabled = False
                    Me.TextBox3.Enabled = False
                    Me.TextBox1.BackColor = Nothing
                    Me.TextBox2.BackColor = Nothing
                    Me.TextBox3.BackColor = Nothing
                    Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0"
                    Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0"
                    Me.ListView1.Items.Item(2).SubItems.Item(11).Text = "0"
                End If
            End If

            If Me.ListView1.Items.Count = 1 Then
                Me.TextBox1.Text = ListView1.Items(ListView1.Items.Count - 1).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 2 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
            ElseIf Me.ListView1.Items.Count = 3 Then
                Me.TextBox1.Text = ListView1.Items(0).SubItems.Item(11).Text
                Me.TextBox2.Text = ListView1.Items(1).SubItems.Item(11).Text
                Me.TextBox3.Text = ListView1.Items(2).SubItems.Item(11).Text
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboBox4_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.Leave
        Try
            EditAction()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            If ComboBox5.Text <> "" Then
                btnsave.Enabled = True
                txtID.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
