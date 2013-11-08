Imports System.Data.SqlClient
Imports System.Math
Imports System.Drawing.SystemColors

Public Class frmSort
    Inherits System.Windows.Forms.Form
    ' Boolean flag used to determine when a character other than a number is entered.
    Private nonNumberEntered As Boolean = False
    Private MStatus As Boolean = False
    Dim naa, balik As Boolean

#Region " private declarations "

    Public oCNN As New SqlClient.SqlConnection
    Private iAction As String
    'Private sUserID, sAction, sSortClass, s_PTN, sPTNBarcode As String()
    Private sUserID, sAction, sSortClass As String()
    Private sDivision As String
    Private iFocus, iEdit As Integer
    Private bEdit As Boolean
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private bRecorded As Boolean
    Private iAppliance As Integer = 1
    Private iCellular As Integer = 3
    Private iGoodStock As Integer = 4
    Private iCoated As Integer = 5
    Private iJewelry As Integer = 6
    Private iWatch As Integer = 8
    Private iFake As Integer = 9
    Private iMissingItem As Integer = 11
    Private iOverAppraised As Integer = 10
    Dim dr As SqlDataReader
    Dim bptn As String
    Dim sortcode As String
    Dim edit As Integer = 0
    Dim allwt As String
    Dim allkarat As String
    Dim allvalue As String
    Dim ptns As String
    Dim isedit As Integer
    Dim str As String
    Dim flag As Boolean = False
    Dim chr As Char
    Dim fl As Boolean = False
    Dim getsortcode As String
    Dim ctr As Integer
    Dim i As Integer
    Dim f As Boolean = False
    Dim flg As Boolean = False


    Public Sub ptntxt(ByVal x As String)
        x = TextBox28.Text
    End Sub

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
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents lblSorterIDNo As System.Windows.Forms.Label
    Friend WithEvents lblSortername As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
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
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents listview2 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents radPTNBarcode As System.Windows.Forms.RadioButton
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblLotno As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSortForceOut As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtlot As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSort))
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
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
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.listview2 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
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
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
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
        Me.txtlot = New System.Windows.Forms.Label
        Me.txt = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lblLotno = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.lblSorterIDNo = New System.Windows.Forms.Label
        Me.lblSortername = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.radPTNBarcode = New System.Windows.Forms.RadioButton
        Me.radNone = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label23 = New System.Windows.Forms.Label
        Me.btnSortForceOut = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(464, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 23)
        Me.Label19.TabIndex = 37
        Me.Label19.Text = "ACTION CLASS"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 552)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "SORTER"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(464, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 23)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "PT BARCODE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(464, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "PTN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(600, 40)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox4.TabIndex = 10
        '
        'ComboBox1
        '
        Me.ComboBox1.CausesValidation = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(600, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "A.L.L. SORTING CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(600, 64)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox5.TabIndex = 5
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
        Me.GroupBox2.Location = New System.Drawing.Point(456, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 182)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CUSTOMER INFORMATION"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(144, 144)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(240, 23)
        Me.Label42.TabIndex = 23
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(144, 120)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(240, 23)
        Me.Label41.TabIndex = 22
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(144, 96)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(392, 23)
        Me.Label40.TabIndex = 21
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(144, 72)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(392, 23)
        Me.Label39.TabIndex = 20
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(144, 48)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(392, 23)
        Me.Label38.TabIndex = 19
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(144, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(240, 23)
        Me.Label37.TabIndex = 18
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "TELL NO."
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "CUSTOMER CITY"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "GENDER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "CUSTOMER ADDRESS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CUSTOMER NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "CUSTOMER ID NO."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 104)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PAWN TICKET INFORMATION"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(136, 72)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(288, 23)
        Me.Label36.TabIndex = 14
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(136, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 23)
        Me.Label21.TabIndex = 13
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(136, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 23)
        Me.Label20.TabIndex = 12
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APPRAISER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PAWN TICKET DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "PAWN TICKET TIME"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.listview2)
        Me.GroupBox3.Controls.Add(Me.ListView1)
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
        Me.GroupBox3.Controls.Add(Me.txtlot)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 336)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1016, 204)
        Me.GroupBox3.TabIndex = 53
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRANSACTION DETAILS"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(888, 70)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(116, 11)
        Me.TextBox3.TabIndex = 49
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(889, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(116, 11)
        Me.TextBox2.TabIndex = 48
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(889, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(116, 11)
        Me.TextBox1.TabIndex = 43
        Me.TextBox1.Text = ""
        '
        'listview2
        '
        Me.listview2.Alignment = System.Windows.Forms.ListViewAlignment.Default
        Me.listview2.AutoArrange = False
        Me.listview2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listview2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.listview2.Enabled = False
        Me.listview2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listview2.FullRowSelect = True
        Me.listview2.GridLines = True
        Me.listview2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listview2.Location = New System.Drawing.Point(8, 20)
        Me.listview2.Name = "listview2"
        Me.listview2.Size = New System.Drawing.Size(80, 65)
        Me.listview2.TabIndex = 46
        Me.listview2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM CODE"
        Me.ColumnHeader1.Width = 80
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.Default
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.AutoArrange = False
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader2})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(88, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(920, 65)
        Me.ListView1.TabIndex = 45
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ITEM ID"
        Me.ColumnHeader11.Width = 51
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DESCRIPTION"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader12.Width = 169
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "QTY"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 43
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "KARAT"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 46
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "A.L.L. KARAT"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 66
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "CARAT"
        Me.ColumnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader16.Width = 42
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "SORTING CLASS"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 86
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "WEIGHT"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 52
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "A.L.L. WEIGHT"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader19.Width = 76
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "APPRAISED VALUE"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader20.Width = 67
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "A.L.L. VALUE"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader21.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "A.L.L BARCODE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 119
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(160, 136)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(120, 23)
        Me.Label47.TabIndex = 38
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(160, 112)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(120, 23)
        Me.Label46.TabIndex = 37
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(160, 160)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(120, 23)
        Me.Label45.TabIndex = 36
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(832, 112)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(120, 23)
        Me.Label44.TabIndex = 35
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(832, 136)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(120, 23)
        Me.Label43.TabIndex = 34
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "DATE LOAN GRANTED"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(680, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 23)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "TOTAL APPRAISED VALUE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(680, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "LOAN VALUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 23)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "MATURITY DATE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(32, 136)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 23)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "EXPIRY DATE"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(368, 64)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(120, 24)
        Me.txtlot.TabIndex = 120
        Me.txtlot.Text = "Label24"
        '
        'txt
        '
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(184, 552)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(192, 20)
        Me.txt.TabIndex = 121
        Me.txt.Text = ""
        Me.txt.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(704, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SAVE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(864, 552)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(944, 552)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(600, 88)
        Me.TextBox28.MaxLength = 12
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(150, 20)
        Me.TextBox28.TabIndex = 3
        Me.TextBox28.Text = ""
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(784, 552)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "EDIT"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(40, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 23)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "BRANCH NAME"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblLotno)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(440, 69)
        Me.GroupBox4.TabIndex = 105
        Me.GroupBox4.TabStop = False
        '
        'lblLotno
        '
        Me.lblLotno.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotno.Location = New System.Drawing.Point(136, 39)
        Me.lblLotno.Name = "lblLotno"
        Me.lblLotno.Size = New System.Drawing.Size(199, 23)
        Me.lblLotno.TabIndex = 107
        Me.lblLotno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(40, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 23)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "LOT NO."
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(136, 11)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(199, 23)
        Me.Label48.TabIndex = 105
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSorterIDNo
        '
        Me.lblSorterIDNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSorterIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorterIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorterIDNo.Location = New System.Drawing.Point(112, 552)
        Me.lblSorterIDNo.Name = "lblSorterIDNo"
        Me.lblSorterIDNo.Size = New System.Drawing.Size(64, 21)
        Me.lblSorterIDNo.TabIndex = 112
        Me.lblSorterIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSorterIDNo.Visible = False
        '
        'lblSortername
        '
        Me.lblSortername.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSortername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSortername.Location = New System.Drawing.Point(184, 552)
        Me.lblSortername.Name = "lblSortername"
        Me.lblSortername.Size = New System.Drawing.Size(192, 21)
        Me.lblSortername.TabIndex = 111
        Me.lblSortername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSortername.Visible = False
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(464, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(112, 23)
        Me.Label52.TabIndex = 113
        Me.Label52.Text = "BRANCH CODE"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(600, 16)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(64, 20)
        Me.txtBranchCode.TabIndex = 7
        Me.txtBranchCode.Text = ""
        '
        'txtbrname
        '
        Me.txtbrname.AutoSize = False
        Me.txtbrname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.ForeColor = System.Drawing.Color.Black
        Me.txtbrname.Location = New System.Drawing.Point(672, 16)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.ReadOnly = True
        Me.txtbrname.Size = New System.Drawing.Size(176, 20)
        Me.txtbrname.TabIndex = 114
        Me.txtbrname.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Location = New System.Drawing.Point(600, 112)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 100
        '
        'TextBox29
        '
        Me.TextBox29.Enabled = False
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(600, 112)
        Me.TextBox29.MaxLength = 12
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(150, 20)
        Me.TextBox29.TabIndex = 4
        Me.TextBox29.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.radPTNBarcode)
        Me.GroupBox5.Controls.Add(Me.radNone)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(784, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 56)
        Me.GroupBox5.TabIndex = 115
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "BARCODE SCANNER"
        '
        'radPTNBarcode
        '
        Me.radPTNBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPTNBarcode.Location = New System.Drawing.Point(16, 32)
        Me.radPTNBarcode.Name = "radPTNBarcode"
        Me.radPTNBarcode.Size = New System.Drawing.Size(104, 16)
        Me.radPTNBarcode.TabIndex = 1
        Me.radPTNBarcode.Text = "PTN BARCODE"
        '
        'radNone
        '
        Me.radNone.Checked = True
        Me.radNone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radNone.Location = New System.Drawing.Point(16, 16)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(105, 16)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "NONE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(72, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(320, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 24)
        Me.Label23.TabIndex = 117
        Me.Label23.Text = "Label23"
        '
        'btnSortForceOut
        '
        Me.btnSortForceOut.Enabled = False
        Me.btnSortForceOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSortForceOut.Location = New System.Drawing.Point(856, 8)
        Me.btnSortForceOut.Name = "btnSortForceOut"
        Me.btnSortForceOut.Size = New System.Drawing.Size(160, 32)
        Me.btnSortForceOut.TabIndex = 118
        Me.btnSortForceOut.Text = "SORT FORCED RECEIVE ITEMS"
        Me.btnSortForceOut.Visible = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(856, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(160, 32)
        Me.Button5.TabIndex = 119
        Me.Button5.Text = "SORT ITEMS FROM REPLICATED DATA"
        Me.Button5.Visible = False
        '
        'frmSort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1026, 604)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnSortForceOut)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox29)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblSorterIDNo)
        Me.Controls.Add(Me.lblSortername)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label23)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1036, 640)
        Me.Name = "frmSort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SORTING"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " private sub "
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'force = False
        'outsource = False

        Try
            Button4.Enabled = False
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select * from tbl_action where action_id in(6,3,8,11,10,4,9,5) order by action_type")
            dr = objclass.OpenDataReader3
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(Trim(UCase(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.Close3()

            objclass.Command3("select * from tbl_sortclass order by description")
            dr = objclass.OpenDataReader3()
            i = 0
            While dr.Read
                ReDim Preserve sSortClass(i)
                ComboBox5.Items.Add(Trim(dr.Item("description")))
                sSortClass(i) = Trim(dr.Item("code"))
                i = i + 1
            End While
            dr.Close()
            objclass.Close3()
            lblSorterIDNo.Text = idnumber
            lblSortername.Text = UCase(fullname)
            txt.Hide()
            If isedit = 1 Then
                ComboBox4.Text = s_action
                ComboBox5.Text = s_class
                If radbutton = 1 Then
                    radNone.Checked = True
                Else
                    radPTNBarcode.Checked = True
                End If
                NewRetrieveInfo(CStr(TextBox28.Text), 1, True)
                Button1.Enabled = True
                Button4.Enabled = True
                Button1.Focus()
            Else
                Call SelectAction(objclass.action.Jewelry)
                objclass = Nothing

                Button1.Enabled = False
                Button4.Enabled = False
                If radNone.Checked = True Then
                    radNone.Checked = True
                    TextBox28.Focus()
                    Exit Sub
                End If
                If radPTNBarcode.Checked = True Then
                    TextBox29.Focus()
                    Exit Sub
                End If
            End If
            'Me.Button3.Enabled = False
            'objclass.Command("select fullname, res_id from vw_humresall where emp_stat = 'A' and comp='001' and (job_title like 'ALL%' or Job_title ='SORTER') order by fullname")

            'Call RetrievePTN_Barcode()
            'Call Clear()
            'Button4.Enabled = False
            ' ComboBox5.Text = ""
            TextBox29.Enabled = False
            ComboBox2.Enabled = False

            naa = False
            balik = False
            TextBox28.BackColor = Color.White
            TextBox28.Focus()
            TextBox28.Select()
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        Finally
            dr.Close()
            objclass = Nothing
        End Try
    End Sub

    'retrieves ptn and ptn barcode that are available for sorting action
    Private Sub RetrievePTN_Barcode()
        Try
            Dim dr As SqlDataReader
            Dim sptn, sptn_barcode As String
            Dim i As Double

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()

            objclass.Command("SELECT  distinct TOP 100 PERCENT dbo.ASYS_REM_Header.PTNBarcode, dbo.ASYS_REM_Detail.PTN  FROM         dbo.ASYS_REM_Detail  INNER JOIN                       dbo.ASYS_REM_Header  ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN WHERE     (dbo.ASYS_REM_Detail.Status ='RECEIVED') AND (dbo.ASYS_REM_Header.BranchCode = '" & txtBranchCode.Text & "') and YeaR(dbo.ASYS_REM_Detail.receivedate) =  year(getdate()) and Month(dbo.ASYS_REM_Detail.receivedate) = month(getdate()) ORDER BY dbo.ASYS_REM_Detail.PTN ")
            dr = objclass.OpenDataReader()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            While dr.Read
                sptn = CStr(objclass.IsNull(dr.Item("ptn")))
                sptn_barcode = CStr(objclass.IsNull(dr.Item("ptnbarcode")))
                If Not (sptn Is "") Then
                    ComboBox1.Items.Add(sptn)
                End If
                If Not (sptn_barcode Is "") Then
                    ComboBox2.Items.Add(sptn_barcode)
                End If
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            objclass = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    'retrieves ptn information from tbl_pt_tran, tlb_ptn_item
    Private Sub RetrieveInfo(ByVal sPTN As String, ByVal iSet As Integer, ByVal bSave As Boolean)

        Dim obj As New clsCommon
        Dim objclass As New clsCommon
        Dim rd As SqlDataReader
        Dim dr As SqlDataReader
        Dim str, sqlstr As String
        Try
            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()

            objclass = New clsCommon
            objclass.ConnectionString2()
            objclass.Open2()

            If iSet = 1 Then
                str = "Select BranchCode,BranchName,Ptn,PtnBarcode,Loanvalue,transdate,pulloutdate,custId,custname,custaddress,custcity,"
                str = str + " custgender,custtel,pttime,ptdate,maturitydate,expirydate,loandate from ASYS_REM_Header  where ptn = '" & sPTN & "'"
            Else
                str = "Select BranchCode,BranchName,Ptn,PtnBarcode,Loanvalue,transdate,pulloutdate,custId,custname,custaddress,custcity,"
                str = str + " custgender,custtel,pttime,ptdate,maturitydate,expirydate,loandate from ASYS_REM_Header  where ptnbarcode = '" & sPTN & "'"
            End If
            obj.Command(str)
            dr = obj.OpenDataReader
            If dr.Read Then
                txtBranchCode.Text = obj.IsNull(dr.Item("branchcode"))
                Label23.Text = obj.IsNull(dr.Item("branchcode"))
                txtbrname.Text = obj.IsNull(dr.Item("branchname"))
                If iSet = 1 Then
                    TextBox29.Text = obj.IsNull(dr.Item("ptnbarcode"))
                Else
                    TextBox28.Text = obj.IsNull(dr.Item("ptn"))
                End If

                Label48.Text = obj.IsNull(dr.Item("branchname"))
                Label20.Text = Format(obj.IsNull(dr.Item("pttime")), "Short Time")
                Label21.Text = Format(obj.IsNull(dr.Item("ptdate")), "Short Date")

                Label37.Text = obj.IsNull(dr.Item("custid"))
                Label38.Text = obj.IsNull(dr.Item("Custname"))
                Label39.Text = obj.IsNull(dr.Item("custaddress"))
                Label40.Text = obj.IsNull(dr.Item("custcity"))
                Label41.Text = obj.IsNull(UCase(dr.Item("custgender")))
                Label42.Text = obj.IsNull(dr.Item("custtel"))

                Label44.Text = obj.IsNull(dr.Item("loanvalue"))
                Label45.Text = obj.IsNull(dr.Item("loandate"))
                Label46.Text = obj.IsNull(dr.Item("maturitydate"))
                Label47.Text = obj.IsNull(dr.Item("expirydate"))

                If objclass.IsNull(Year(dr.Item("pulloutdate"))) = "0" Then
                    pdate = Now.Year
                Else
                    pdate = objclass.IsNull(Year(dr.Item("pulloutdate")))
                End If

                ListView1.Items.Clear()
                listview2.Items.Clear()

                sqlstr = "Select reflotno,refallbarcode,itemid as id,refitemcode,branchitemdesc,refqty,karatgrading,caratsize,weight,actionclass,sortcode,all_karat,all_cost,all_weight,appraiser,appraisevalue,status from ASYS_REM_detail  where ptn = '" & Me.TextBox28.Text & "'"
                objclass.Command2(sqlstr)
                rd = objclass.OpenDataReader2
                While rd.Read
                    If rd.Item("STATUS") <> "RECEIVED" Then
                        If objclass.IsNull(rd.Item("actionclass")) = "0" Then
                            ComboBox4.Text = "Jewelry"
                        Else
                            ComboBox4.Text = rd.Item("actionclass")
                        End If

                        'If Trim(objclass.IsNull(rd.Item("sortcode"))) = "S" Then
                        '    ComboBox5.Text = "Singaporean"
                        'ElseIf (Trim(objclass.IsNull(rd.Item("sortcode"))) = "C") Then
                        '    ComboBox5.Text = "Chinese Gold"
                        'ElseIf (Trim(objclass.IsNull(rd.Item("sortcode"))) = "OG") Then
                        '    ComboBox5.Text = "Old Gold"
                        'Else

                        'asys 2.2
                        If ComboBox4.Text.Trim.ToUpper = "JEWELRY" Then
                            ComboBox5.Text = Trim(objclass.IsNull(rd.Item("sortcode")))
                        ElseIf ComboBox4.Text.Trim.ToUpper <> "JEWELRY" Then
                            ComboBox5.Text = "Others"
                        End If
                        If Trim(rd.Item("status")) = "SORTED" Then
                            balik = True
                        End If
                        'End If
                        MStatus = True

                    End If

                    listview2.Items.Add(objclass.IsNull(rd.Item("refitemcode")))
                    ListView1.Items.Add(objclass.IsNull(rd.Item("id")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("branchitemdesc")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("refqty")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(objclass.IsNull(rd.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_karat")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("caratsize")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("sortcode")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("weight")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_weight")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_cost")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("appraisevalue")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("refallbarcode")))
                    Label43.Text = objclass.IsNull(rd.Item("appraisevalue"))
                    Label36.Text = objclass.IsNull(rd.Item("appraiser"))
                    lblLotno.Text = objclass.IsNull(rd.Item("reflotno"))

                    If ComboBox4.Text = "Jewelry" And ComboBox5.Text <> "" Then
                        Button1.Enabled = True
                    Else
                        Button1.Enabled = False
                        Button4.Enabled = False
                    End If
                    If ComboBox4.Text <> "Jewelry" Then
                        Button1.Enabled = True
                    End If
                    naa = True
                    If balik = True Then
                        naa = False
                        MsgBox("PTN barcode already sorted.", MsgBoxStyle.Information, TitleMsgBox)
                    End If
                End While
                rd.Close()

                Call GenBarcode()
            Else
                MsgBox("PTN barcode not Found", MsgBoxStyle.Information, TitleMsgBox)
                If radNone.Checked = True Then
                    TextBox28.Text = ""
                    TextBox28.Focus()
                Else
                    TextBox29.Text = ""
                    TextBox29.Focus()
                End If

                f = True
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        Finally
            obj.Close()
            objclass.Close()
        End Try
    End Sub

    Private Sub NewRetrieveInfo(ByVal sptn As String, ByVal iSet As Integer, ByVal bSave As Boolean)
        Dim obj As New clsCommon
        Dim objclass As New clsCommon
        Dim rd As SqlDataReader
        Dim dr As SqlDataReader
        Dim str, sqlstr As String
        Dim FlagExist As Boolean

        Try
            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()

            objclass = New clsCommon
            objclass.ConnectionString2()
            objclass.Open2()

            If iSet = 1 Then
                str = "Select BranchCode,BranchName,Ptn,PtnBarcode,Loanvalue,transdate,pulloutdate,custId,custname,custaddress,custcity,"
                str = str + " custgender,custtel,pttime,ptdate,maturitydate,expirydate,loandate from ASYS_REM_Header  where ptn = '" & sptn & "'"
            Else
                str = "Select BranchCode,BranchName,Ptn,PtnBarcode,Loanvalue,transdate,pulloutdate,custId,custname,custaddress,custcity,"
                str = str + " custgender,custtel,pttime,ptdate,maturitydate,expirydate,loandate from ASYS_REM_Header  where ptnbarcode = '" & sptn & "'"
            End If
            obj.Command(str)
            dr = obj.OpenDataReader
            If dr.Read Then
                txtBranchCode.Text = obj.IsNull(dr.Item("branchcode"))
                Label23.Text = obj.IsNull(dr.Item("branchcode"))
                txtbrname.Text = obj.IsNull(dr.Item("branchname"))
                If iSet = 1 Then
                    TextBox29.Text = obj.IsNull(dr.Item("ptnbarcode"))
                Else
                    TextBox28.Text = obj.IsNull(dr.Item("ptn"))
                End If

                Label48.Text = obj.IsNull(dr.Item("branchname"))
                Label20.Text = Format(obj.IsNull(dr.Item("pttime")), "Short Time")
                Label21.Text = Format(obj.IsNull(dr.Item("ptdate")), "Short Date")

                Label37.Text = obj.IsNull(dr.Item("custid"))
                Label38.Text = obj.IsNull(dr.Item("Custname"))
                Label39.Text = obj.IsNull(dr.Item("custaddress"))
                Label40.Text = obj.IsNull(dr.Item("custcity"))
                Label41.Text = obj.IsNull(UCase(dr.Item("custgender")))
                Label42.Text = obj.IsNull(dr.Item("custtel"))

                Label44.Text = FormatNumber(obj.IsNull(dr.Item("loanvalue")))
                Label45.Text = obj.IsNull(dr.Item("loandate"))
                Label46.Text = obj.IsNull(dr.Item("maturitydate"))
                Label47.Text = obj.IsNull(dr.Item("expirydate"))

                If objclass.IsNull(Year(dr.Item("pulloutdate"))) = "0" Then
                    pdate = Now.Year
                Else
                    pdate = objclass.IsNull(Year(dr.Item("pulloutdate")))
                End If

                ListView1.Items.Clear()
                listview2.Items.Clear()

                FlagExist = False

                sqlstr = "Select reflotno,refallbarcode,itemid as id,refitemcode,branchitemdesc,refqty,karatgrading,caratsize,weight,actionclass,sortcode,all_karat,all_cost,all_weight,appraiser,appraisevalue,status from ASYS_REM_detail  where ptn = '" & sptn & "' order by refitemcode asc"
                objclass.Command2(sqlstr)
                rd = objclass.OpenDataReader2
                While rd.Read
                    FlagExist = True

                    Dim x As String
                    x = Trim(rd.Item("status"))
                    If rd.Item("STATUS") <> "RECEIVED" Then
                        'If objclass.IsNull(rd.Item("actionclass")) = "0" Then
                        '    ComboBox4.Text = "Jewelry"
                        'Else
                        '    ComboBox4.Text = rd.Item("actionclass")
                        'End If

                        'If Trim(objclass.IsNull(rd.Item("sortcode"))) = "S" Then
                        '    ComboBox5.Text = "Singaporean"
                        'ElseIf (Trim(objclass.IsNull(rd.Item("sortcode"))) = "C") Then
                        '    ComboBox5.Text = "Chinese Gold"
                        'ElseIf (Trim(objclass.IsNull(rd.Item("sortcode"))) = "OG") Then
                        '    ComboBox5.Text = "Old Gold"
                        'Else

                        'asys 2.2
                        If x = "SORTED" Then
                            ComboBox4.Text = rd.Item("actionclass")
                        End If
                        If ComboBox4.Text.Trim.ToUpper = "JEWELRY" Then
                            ComboBox5.Text = Trim(objclass.IsNull(rd.Item("sortcode")))
                        ElseIf ComboBox4.Text.Trim.ToUpper <> "JEWELRY" Then
                            ComboBox5.Text = "Others"
                        End If
                        'End If
                        If objclass.IsNull(Trim(rd.Item("actionclass"))) = "NULL" Then
                            MStatus = False
                        Else
                            MStatus = True
                        End If
                    End If

                    listview2.Items.Add(objclass.IsNull(rd.Item("refitemcode")))
                    ListView1.Items.Add(objclass.IsNull(rd.Item("id")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("branchitemdesc")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("refqty")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(objclass.IsNull(rd.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_karat")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("caratsize")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("sortcode")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("weight")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_weight")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(rd.Item("appraisevalue"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("all_cost")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(objclass.IsNull(rd.Item("refallbarcode")))
                    Label43.Text = FormatNumber(objclass.IsNull(rd.Item("appraisevalue")))
                    Label36.Text = objclass.IsNull(rd.Item("appraiser"))
                    lblLotno.Text = objclass.IsNull(rd.Item("reflotno"))
                    Me.Button4.Enabled = False
                End While
                rd.Close()

                Call GenBarcode()

            Else
                MsgBox("PTN not Found", MsgBoxStyle.Information, TitleMsgBox)
                If radNone.Checked = True Then
                    TextBox28.Text = ""
                    TextBox28.Focus()
                Else
                    TextBox29.Text = ""
                    TextBox29.Focus()
                End If

                f = True
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        Finally
            obj.Close()
            objclass.Close()
        End Try
    End Sub
    Private Sub GenBarcode()
        Try
            If Me.ComboBox4.Text.ToUpper = "GOODSTOCK" Or ComboBox4.Text.ToUpper = "WATCH" Or ComboBox4.Text.ToUpper = "CELLULAR" Then
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
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub NewGenForceALLBarcode()
        Try
            Dim obcls As New clsCommon
            Dim dr4 As SqlDataReader
            Dim ptncode, itemcode1, itemcode2, itemcode3, supcode1, supcode2, yearcode, seqcode, AllCode1, allcode2, allcode3, divcode, drcode As String
            Dim tempall, Squery As String
            Dim x As Integer

            obcls.ConnectionString2()
            obcls.Open2()
            If Me.listview2.Items.Count > 1 Then
                For x = 0 To listview2.Items.Count - 1
                    Squery = "IF (SELECT Max(Substring(DALLBarcode,9,16)) as Barcode FROM tbl_receiving_detail WHERE Substring(DALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(DALLBarcode,4,5) = '39033') > (SELECT ISNUll(Max(Substring(ALLBarcode_DFOR,9,16)),0) as Barcode FROM tbl_ForcedOutRcv_detail WHERE Substring(ALLBArcode_DFOR,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(ALLBarcode_dfor,4,5) = '39033') BEGIN (SELECT Max(Substring(DALLBarcode,9,16)) as Barcode FROM tbl_receiving_detail WHERE Substring(DALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(DALLBarcode,4,5) = '39033')END ELSE (SELECT Max(Substring(ALLBarcode_DFOR,9,16)) as Barcode FROM tbl_ForcedOutRcv_detail WHERE Substring(ALLBArcode_DFOR,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(ALLBarcode_dfor,4,5) = '39033')"
                    obcls.Command2(Squery)
                    dr4 = obcls.OpenDataReader2
                    If dr4.Read Then
                        tempall = obcls.IsNull(dr4.Item("Barcode"))
                        If tempall = "0" Then
                            If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
                                If Me.ListView1.Items.Count = 3 Then
                                    If Me.listview2.Items(0).Text = Me.listview2.Items(1).Text Or Me.listview2.Items(1).Text = Me.listview2.Items(2).Text Then
                                        If x = 0 Then
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        ElseIf x = 1 Then
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        Else
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 3)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        End If
                                    ElseIf Me.listview2.Items(0).Text <> Me.listview2.Items(1).Text Or Me.listview2.Items(0).Text = Me.listview2.Items(2).Text Then
                                        If x = 0 Then
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        ElseIf x = 1 Then
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        Else
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        End If
                                    End If
                                ElseIf Me.listview2.Items.Count = 2 Then
                                    If Me.listview2.Items(0).Text = Me.listview2.Items(1).Text Then
                                        If x = 0 Then
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        Else
                                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                            supcode1 = "39033"
                                            yearcode = Now.Year
                                            seqcode = "0000"
                                            allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
                                            ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                        End If
                                    Else
                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                        supcode1 = "39033"
                                        yearcode = Now.Year
                                        seqcode = "0000"
                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
                                        ListView1.Items(x).SubItems.Item(11).Text = allcode2
                                    End If
                                End If
                            End If
                        Else
                            If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
                                itemcode1 = listview2.Items(x).SubItems.Item(0).Text
                                supcode1 = "39033"
                                drcode = tempall
                                AllCode1 = itemcode1 & supcode1 & Val(drcode + 1)
                                ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                If listview2.Items.Count = 3 Then
                                    If (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(1).SubItems.Item(0).Text = Me.listview2.Items(2).SubItems.Item(0).Text) Then
                                        If x = 0 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                        ElseIf x = 1 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
                                        Else
                                            ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 3)
                                        End If
                                    ElseIf (Me.listview2.Items(0).SubItems.Item(0).Text <> Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(2).SubItems.Item(0).Text) Then
                                        If x = 0 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                        ElseIf x = 1 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                        Else
                                            ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 1)
                                        End If
                                    End If
                                Else
                                    If (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(1).SubItems.Item(0).Text) Then
                                        If x = 0 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                        ElseIf x = 1 Then
                                            ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
                                        End If
                                    Else
                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
                                    End If
                                End If
                            End If
                        End If
                    End If
                    dr4.Close()
                Next

            Else

                Squery = "IF (SELECT Max(Substring(DALLBarcode,9,16)) as Barcode FROM tbl_receiving_detail WHERE Substring(DALLBArcode,1,3) = '" & Me.listview2.Items(0).SubItems.Item(0).Text & "') > (SELECT ISNUll(Max(Substring(ALLBarcode_DFOR,9,16)),0) as Barcode FROM tbl_ForcedOutRcv_detail WHERE Substring(ALLBArcode_DFOR,1,3) = '" & Me.listview2.Items(0).SubItems.Item(0).Text & "') BEGIN (SELECT Max(Substring(DALLBarcode,9,16)) as Barcode FROM tbl_receiving_detail WHERE Substring(DALLBArcode,1,3) = '" & Me.listview2.Items(0).SubItems.Item(0).Text & "')END ELSE (SELECT Max(Substring(ALLBarcode_DFOR,9,16)) as Barcode FROM tbl_ForcedOutRcv_detail WHERE Substring(ALLBArcode_DFOR,1,3) = '" & Me.listview2.Items(0).SubItems.Item(0).Text & "')"
                obcls.Command2(Squery)
                dr4 = obcls.OpenDataReader2
                If dr4.Read Then
                    tempall = obcls.IsNull(dr4.Item("Barcode"))
                    If tempall = "0" Then
                        itemcode1 = listview2.Items(0).SubItems.Item(0).Text
                        supcode1 = "30"
                        If Me.TextBox28.Text.Length = 12 Then
                            ptncode = Mid(Me.TextBox28.Text, 8, 12)
                        Else
                            ptncode = Mid(Me.TextBox28.Text, 7, 11)
                        End If
                        divcode = Me.txtBranchCode.Text
                        yearcode = Now.Year
                        seqcode = "00001"
                        AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
                        ListView1.Items(0).SubItems.Item(11).Text = AllCode1
                    Else
                        itemcode1 = listview2.Items(0).SubItems.Item(0).Text
                        supcode1 = "30"
                        divcode = Me.txtBranchCode.Text
                        If Me.TextBox28.Text.Length = 12 Then
                            ptncode = Mid(Me.TextBox28.Text, 8, 12)
                        Else
                            ptncode = Mid(Me.TextBox28.Text, 7, 11)
                        End If
                        yearcode = Now.Year
                        'seqcode = "00001"
                        drcode = tempall
                        AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
                        ListView1.Items(0).SubItems.Item(11).Text = AllCode1
                    End If
                    dr4.Close()
                End If
            End If
            obcls.Execute2()
            obcls.Close2()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim sss As String

            'MsgBox('" & FormatLot & "' '" & userlog & "', MsgBoxStyle.Information, TitleMsgBox)
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
                If ComboBox4.Text.ToUpper = "JEWELRY" Then
                    GenerateLot = 0
                Else
                    GenerateLot = dr.Item("lotno")
                End If
            End If
            dr.Close()
            'objclass.Execute()
            objclass.Close()


        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function

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
            tmpBranchCode = Trim(Me.Label23.Text)
            tmpSequence = Mid(TextBox28.Text, 8)

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

                    strSQL = "exec ASYS_GetMaxBarcode '" & tmpctr & "',2"
                    objClass = New clsCommon
                    objClass.Connectionstring3()
                    objClass.Open3()
                    objClass.Command3(strSQL)
                    drClass = objClass.OpenDataReader3

                    If Not drClass.Read Then
                        tmpSequence = 1
                    Else

                        strSQL = "exec ASYS_GetMaxBarcode '" & tmpctr & "',1"
                        objClass = New clsCommon
                        objClass.Connectionstring3()
                        objClass.Open3()
                        objClass.Command3(strSQL)
                        drClass = objClass.OpenDataReader3

                        If drClass.Read Then
                            If (tmpSequence - 1) = objClass.IsNull(drClass.Item("Barcode")) + 1 Then
                                tmpSequence = tmpSequence
                            ElseIf (tmpSequence - 2) = drClass.Item("Barcode") + 1 Then
                                tmpSequence = tmpSequence
                            Else
                                tmpSequence = drClass.Item("Barcode") + 1
                            End If
                        Else
                            tmpSequence = 1
                        End If

                    End If

                    ' For x = i To ListView1.Items.Count - 1
                    ListView1.Items(i).SubItems.Item(11).Text = tmpctr & tmpSequence.PadLeft(5, "0")
                    tmpSequence = CInt(tmpSequence) + 1
                    'Next
                    ' tmpSequence = CInt(tmpSequence) + 1
                Next

                drClass.Close()
                drClass = Nothing
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    ''''Private Sub NewGenAllBArcode()
    ''''    Try

    ''''        '--------added 2010-10-06 (naijeru)----------
    ''''        Dim obj As New clsCommon
    ''''        Dim dr As SqlDataReader
    ''''        Dim str, str1 As String
    ''''        Dim maxbarc As String
    ''''        '--------added 2010-10-06 (end)----------

    ''''        '''obj.ConnectionString1()
    ''''        '''obj.Open()
    ''''        '''str = "exec [REMS].dbo.ASYS_Barcode_Generator '" & 101 & "','" & 30022 & "','" & 2010 & "'"
    ''''        '''obj.Command(str)
    ''''        '''dr = obj.OpenDataReader
    ''''        '''If dr.Read Then
    ''''        '''    maxbarc = obj.IsNull(dr.Item("maxBarcode"))
    ''''        '''End If
    ''''        '''dr.Close()
    ''''        ''''obj.Execute3()
    ''''        '''obj.Close()
    ''''        '''obj = Nothing

    ''''        Dim obcls As New clsCommon
    ''''        Dim dr4 As SqlDataReader
    ''''        Dim ptncode, itemcode1, itemcode2, itemcode3, supcode1, supcode2, yearcode, seqcode, AllCode1, allcode2, allcode3, divcode, drcode As String
    ''''        Dim tempall, Squery As String
    ''''        Dim x As Integer
    ''''        'Dim pulldate As Integer

    ''''        'pulldate = pulldate1


    ''''        obcls.ConnectionString2()
    ''''        obcls.Open2()
    ''''        If Me.listview2.Items.Count > 1 Then
    ''''            For x = 0 To listview2.Items.Count - 1
    ''''                Squery = "IF (SELECT Max(Substring(refALLBarcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033') > (SELECT ISNUll(Max(Substring(refallbarcode,9,16)),0) as Barcode FROM rems.dbo.ASYS_REMOUtsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033') BEGIN (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033')END ELSE (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REMOutsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "' and Substring(refALLBArcode,4,5) = '39033')"
    ''''                obcls.Command2(Squery)
    ''''                dr4 = obcls.OpenDataReader2
    ''''                If dr4.Read Then
    ''''                    tempall = obcls.IsNull(dr4.Item("Barcode"))
    ''''                    If tempall = "0" Then
    ''''                        If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
    ''''                            If Me.ListView1.Items.Count = 3 Then
    ''''                                If (Me.listview2.Items(0).Text = Me.listview2.Items(1).Text And Me.listview2.Items(1).Text = Me.listview2.Items(2).Text) And (Me.listview2.Items(0).Text = Me.listview2.Items(2).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    ElseIf x = 1 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 3)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).Text <> Me.listview2.Items(1).Text) And (Me.listview2.Items(0).Text = Me.listview2.Items(2).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    ElseIf x = 1 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).Text <> Me.listview2.Items(1).Text) And (Me.listview2.Items(1).Text = Me.listview2.Items(2).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    ElseIf x = 1 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).Text = Me.listview2.Items(1).Text) And (Me.listview2.Items(1).Text <> Me.listview2.Items(2).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    ElseIf x = 1 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    End If
    ''''                                Else
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    ElseIf x = 1 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    End If
    ''''                                End If
    ''''                            ElseIf Me.listview2.Items.Count = 2 Then
    ''''                                If Me.listview2.Items(0).Text = Me.listview2.Items(1).Text Then
    ''''                                    If x = 0 Then
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = Replace(allcode2, " ", "")
    ''''                                    Else
    ''''                                        itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                        supcode1 = "39033"

    ''''                                        If CStr(pdate) <> "0" Then
    ''''                                            yearcode = pdate
    ''''                                        Else
    ''''                                            yearcode = Now.Year
    ''''                                        End If

    ''''                                        seqcode = "0000"
    ''''                                        allcode2 = Replace(itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2), " ", "")
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = allcode2
    ''''                                    End If
    ''''                                Else
    ''''                                    itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                                    supcode1 = "39033"
    ''''                                    If CStr(pdate) <> "0" Then
    ''''                                        yearcode = pdate
    ''''                                    Else
    ''''                                        yearcode = Now.Year
    ''''                                    End If
    ''''                                    seqcode = "0000"
    ''''                                    allcode2 = Replace(itemcode1 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1), " ", "")
    ''''                                    ListView1.Items(x).SubItems.Item(11).Text = allcode2
    ''''                                End If
    ''''                            End If
    ''''                        End If
    ''''                    Else
    ''''                        If Me.ListView1.Items(x).SubItems.Item(11).Text = "0" Then
    ''''                            itemcode1 = listview2.Items(x).SubItems.Item(0).Text.Trim
    ''''                            supcode1 = "39033"
    ''''                            drcode = tempall
    ''''                            AllCode1 = itemcode1 & supcode1 & Val(drcode + 1)
    ''''                            'ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                            If listview2.Items.Count = 3 Then
    ''''                                If (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(1).SubItems.Item(0).Text = Me.listview2.Items(2).SubItems.Item(0).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    ElseIf x = 1 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    ''''                                    Else
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 3)
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).SubItems.Item(0).Text <> Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(2).SubItems.Item(0).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    ElseIf x = 1 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    Else
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).SubItems.Item(0).Text <> Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(1).SubItems.Item(0).Text = Me.listview2.Items(2).SubItems.Item(0).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    ElseIf x = 1 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 1)
    ''''                                    Else
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    ''''                                    End If
    ''''                                ElseIf (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(1).SubItems.Item(0).Text) And (Me.listview2.Items(1).SubItems.Item(0).Text <> Me.listview2.Items(2).SubItems.Item(0).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 1)
    ''''                                    ElseIf x = 1 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    ''''                                    Else
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    End If
    ''''                                Else
    ''''                                    ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                End If
    ''''                            Else
    ''''                                If (Me.listview2.Items(0).SubItems.Item(0).Text = Me.listview2.Items(1).SubItems.Item(0).Text) Then
    ''''                                    If x = 0 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                    ElseIf x = 1 Then
    ''''                                        ListView1.Items(x).SubItems.Item(11).Text = itemcode1 & supcode1 & Val(drcode + 2)
    ''''                                    End If
    ''''                                Else
    ''''                                    ListView1.Items(x).SubItems.Item(11).Text = AllCode1
    ''''                                End If
    ''''                            End If
    ''''                        End If
    ''''                    End If
    ''''                End If
    ''''                dr4.Close()
    ''''            Next
    ''''        Else
    ''''            Squery = "IF (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "') > (SELECT ISNUll(Max(Substring(refALLBArcode,9,16)),0) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "') BEGIN (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REM_Detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "')END ELSE (SELECT Max(Substring(refALLBArcode,9,16)) as Barcode FROM rems.dbo.ASYS_REMOutsource_detail  WHERE Substring(refALLBArcode,1,3) = '" & Me.listview2.Items(x).SubItems.Item(0).Text & "')"
    ''''            obcls.Command2(Squery)
    ''''            dr4 = obcls.OpenDataReader2
    ''''            If dr4.Read Then
    ''''                tempall = obcls.IsNull(dr4.Item("Barcode"))
    ''''                If tempall = "0" Then
    ''''                    itemcode1 = listview2.Items(0).SubItems.Item(0).Text.Trim
    ''''                    supcode1 = "30"
    ''''                    If Me.TextBox28.Text.Trim.Length = 12 Then
    ''''                        ptncode = Mid(Me.TextBox28.Text.Trim, 8, 12)
    ''''                    Else
    ''''                        ptncode = Mid(Me.TextBox28.Text.Trim, 7, 11)
    ''''                    End If
    ''''                    divcode = Me.txtBranchCode.Text

    ''''                    If CStr(pdate) <> "0" Then
    ''''                        yearcode = pdate
    ''''                    Else
    ''''                        yearcode = Now.Year
    ''''                    End If

    ''''                    seqcode = "00001"
    ''''                    AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
    ''''                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    ''''                Else
    ''''                    itemcode1 = listview2.Items(0).SubItems.Item(0).Text.Trim
    ''''                    supcode1 = "30"
    ''''                    divcode = Me.txtBranchCode.Text
    ''''                    ''If Me.TextBox28.Text.Trim.Length = 12 Then
    ''''                    ''    ptncode = Mid(Me.TextBox28.Text.Trim, 8, 12)
    ''''                    ''Else
    ''''                    ''    ptncode = Mid(Me.TextBox28.Text.Trim, 7, 11)
    ''''                    ''End If
    ''''                    If CStr(pdate) <> "0" Then
    ''''                        yearcode = pdate
    ''''                    Else
    ''''                        yearcode = Now.Year
    ''''                    End If
    ''''                    '----------added 2010-10-06 (naijeru)--------------
    ''''                    obj.ConnectionString1()
    ''''                    obj.Open()
    ''''                    str = "exec [REMS].dbo.ASYS_Barcode_Generator '" & itemcode1 & "','" & supcode1 & divcode & "','" & yearcode & "'"
    ''''                    obj.Command(str)
    ''''                    dr = obj.OpenDataReader
    ''''                    If dr.Read Then
    ''''                        maxbarc = obj.IsNull(dr.Item("maxBarcode"))
    ''''                        AllCode1 = maxbarc
    ''''                    End If
    ''''                    dr.Close()
    ''''                    'obj.Execute3()
    ''''                    obj.Close()
    ''''                    obj = Nothing
    ''''                    '----------added 2010-10-06 (end)--------------

    ''''                    'seqcode = "00001"
    ''''                    drcode = tempall
    ''''                    'AllCode1 = itemcode1 & supcode1 & divcode & yearcode & ptncode
    ''''                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    ''''                End If
    ''''                dr4.Close()
    ''''            End If
    ''''        End If
    ''''        ' obcls.Execute2()
    ''''        obcls.Close2()
    ''''        pdate = Nothing

    ''''    Catch ex As Exception
    ''''        MsgBox(ex.Message, , TitleMsgBox)
    ''''    End Try
    ''''End Sub
    'Private Sub GenAllBarcode()
    '    Dim obcls As New clsCommon
    '    Dim dr4 As SqlDataReader
    '    Dim itemcode1, itemcode2, itemcode3, supcode1, supcode2, yearcode, seqcode, AllCode1, allcode2, allcode3, divcode, drcode As String
    '    Dim tempAll As String


    '    obcls.ConnectionString2()
    '    obcls.Open2()
    '    obcls.Command2("select Max(right(DAllBarcode,9)) as Barcode from tbl_receiving_detail")
    '    dr4 = obcls.OpenDataReader2
    '    If dr4.Read Then
    '        tempAll = objclass.IsNull(dr4.Item("Barcode"))
    '        If tempAll = "0" Then
    '            If listview2.Items.Count > 1 Then
    '                If Me.ListView1.Items.Count = 2 Then
    '                    If Me.ListView1.Items(0).SubItems.Item(11).Text = "0" And Me.ListView1.Items(1).SubItems.Item(11).Text = "0" Then
    '                        itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                        itemcode2 = listview2.Items(1).SubItems.Item(0).Text
    '                        supcode1 = "39033"
    '                        yearcode = Now.Year
    '                        seqcode = "00001"
    '                        AllCode1 = itemcode1 & supcode1 & yearcode & seqcode
    '                        allcode2 = itemcode2 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                        ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                        ListView1.Items(1).SubItems.Item(11).Text = allcode2
    '                    End If
    '                ElseIf Me.ListView1.Items.Count = 3 Then
    '                    If Me.ListView1.Items(0).SubItems.Item(11).Text = "0" And Me.ListView1.Items(1).SubItems.Item(11).Text = "0" And Me.ListView1.Items(2).SubItems.Item(11).Text = "0" Then
    '                        itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                        itemcode2 = listview2.Items(1).SubItems.Item(0).Text
    '                        itemcode3 = listview2.Items(2).SubItems.Item(0).Text
    '                        supcode1 = "39033"
    '                        yearcode = Now.Year
    '                        seqcode = "00001"
    '                        AllCode1 = itemcode1 & supcode1 & yearcode & seqcode
    '                        allcode2 = itemcode2 & supcode1 & yearcode & "0000" & (Val(seqcode) + 1)
    '                        allcode3 = itemcode3 & supcode1 & yearcode & "0000" & (Val(seqcode) + 2)
    '                        ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                        ListView1.Items(1).SubItems.Item(11).Text = allcode2
    '                        ListView1.Items(2).SubItems.Item(11).Text = allcode3
    '                    End If
    '                End If
    '            Else
    '                itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                supcode1 = "30"
    '                divcode = Me.Label23.Text
    '                yearcode = Now.Year
    '                seqcode = "00001"
    '                AllCode1 = itemcode1 & supcode1 & divcode & yearcode & seqcode
    '                ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '            End If
    '        Else
    '            If listview2.Items.Count > 1 Then
    '                If Me.ListView1.Items.Count = 2 Then
    '                    itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                    itemcode2 = listview2.Items(1).SubItems.Item(0).Text
    '                    supcode1 = "39033"
    '                    'yearcode = Now.Year
    '                    'seqcode = "00001"
    '                    drcode = dr4.Item("Barcode")
    '                    AllCode1 = itemcode1 & supcode1 & Val(drcode + 1)
    '                    allcode2 = itemcode2 & supcode1 & Val(drcode + 2)
    '                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                    ListView1.Items(1).SubItems.Item(11).Text = allcode2
    '                ElseIf Me.ListView1.Items.Count = 3 Then
    '                    itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                    itemcode2 = listview2.Items(1).SubItems.Item(0).Text
    '                    itemcode3 = listview2.Items(2).SubItems.Item(0).Text
    '                    supcode1 = "39033"
    '                    'yearcode = Now.Year
    '                    'seqcode = "00001"
    '                    drcode = dr4.Item("Barcode")
    '                    AllCode1 = itemcode1 & supcode1 & Val(drcode + 1)
    '                    allcode2 = itemcode2 & supcode1 & Val(drcode + 2)
    '                    allcode3 = itemcode3 & supcode1 & Val(drcode + 3)
    '                    ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '                    ListView1.Items(1).SubItems.Item(11).Text = allcode2
    '                    ListView1.Items(2).SubItems.Item(11).Text = allcode3
    '                End If
    '            Else
    '                itemcode1 = listview2.Items(0).SubItems.Item(0).Text
    '                supcode1 = "30"
    '                divcode = Me.Label23.Text
    '                'yearcode = Now.Year
    '                'seqcode = "00001"
    '                drcode = dr4.Item("Barcode")
    '                AllCode1 = itemcode1 & supcode1 & divcode & Val(drcode + 1)
    '                ListView1.Items(0).SubItems.Item(11).Text = AllCode1
    '            End If
    '        End If
    '    End If
    '    dr4.Close()
    '    obcls.Execute2()
    '    obcls.Close2()

    'End Sub
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
            'Button4.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub SelectClass(ByVal sClass As String)
        Try
            Dim i As Integer
            Dim sTemp As String
            For i = 0 To sSortClass.Length - 1
                sTemp = sSortClass(i)
                If sTemp = sClass Then
                    'ComboBox5.SelectedIndex = i
                    ComboBox5.Text = ComboBox5.SelectedItem
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Public Sub getclass(ByVal scCode As String)
        Try
            If scCode = "C" Then
                ComboBox5.Text = "Chinese Gold"
            End If
            If scCode = "OG" Then
                ComboBox5.Text = "Old Gold"
            End If
            If scCode = "S" Then
                ComboBox5.Text = "Singaporean"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'returns to the last focus textbox
    Private Sub returnfocus()
        Try
            If iFocus = 15 Then
                TextBox28.Focus()
            ElseIf iFocus = 16 Then
                TextBox29.Focus()
            End If
            iEdit = iFocus
            iFocus = 0
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'returns to the last focus of textbox and clears the content
    Private Sub returnfocus1()
        Try
            If iFocus = 15 Then
                TextBox28.Text = ""
                TextBox28.Focus()
            ElseIf iFocus = 16 Then
                TextBox29.Text = ""
                TextBox29.Focus()
            End If
            iEdit = iFocus
            iFocus = 0
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'clear all text information
    Private Sub Clear()
        Try
            Label20.Text = ""
            Label21.Text = ""
            Label36.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            Label42.Text = ""
            Label43.Text = ""
            Label44.Text = ""
            Label45.Text = ""
            Label46.Text = ""
            Label47.Text = ""
            Label48.Text = ""
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            TextBox1.BackColor = Nothing
            TextBox2.BackColor = Nothing
            TextBox3.BackColor = Nothing
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False

            'TextBox28.Text = 0
            'TextBox28.Text = ""
            'TextBox29.Text = 0
            'TextBox29.Text = ""
            'ComboBox1.Items.Clear()
            'ComboBox2.Items.Clear()
            'txtBranchCode.Text = ""
            'txtbrname.Text = ""
            'ComboBox1.Text = ""
            'ComboBox2.Text = ""
            'ComboBox4.Text = "Jewelry"
            'ComboBox5.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Me.lblLotno.Text = ""
            ListView1.Items.Clear()
            listview2.Items.Clear()
            'force = False
            'outsource = False

            Button1.Enabled = False
            Button4.Enabled = False
            flag = False
            fl = False
            ctr = 0
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Public Sub clear2()
        Try
            Label20.Text = ""
            Label21.Text = ""
            Label36.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            Label42.Text = ""
            Label43.Text = ""
            Label44.Text = ""
            Label45.Text = ""
            Label46.Text = ""
            Label47.Text = ""
            Label48.Text = ""
            TextBox28.Text = ""
            TextBox29.Text = ""
            'ComboBox1.Items.Clear()
            'ComboBox2.Items.Clear()
            'ComboBox1.SelectedText = ""
            'ComboBox2.SelectedText = ""
            ListView1.Items.Clear()
            listview2.Items.Clear()
            Button1.Enabled = False
            Button4.Enabled = False
            flag = False
            TextBox28.Focus()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox1.BackColor = Nothing
            TextBox2.BackColor = Nothing
            TextBox3.BackColor = Nothing
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'updates ptn information on status, sortaction_id, and sortdate in tbl_receiving

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
                str = "Update REMS" & sDB & ".dbo.ASYS_REM_Detail  set refallbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',allbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',Actionclass = '" & ComboBox4.Text & "',sortcode = '" & getsortcode & "',Sortdate = getdate(),sortername = '" & userLog & "',status = 'SORTED' where ptn ='" & TextBox28.Text & "' and itemid = '" & ListView1.Items(l).SubItems.Item(0).Text & "' and status not in ('RELEASED','RECMLWB') "
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update [REMS].dbo.ASYS_REM_Detail  set refallbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',allbarcode='" & ListView1.Items(l).SubItems.Item(11).Text & "',Actionclass = '" & ComboBox4.Text & "',sortcode = '" & getsortcode & "',Sortdate = getdate(),sortername = '" & userLog & "',status = 'SORTED' where ptn ='" & TextBox28.Text & "' and itemid = '" & ListView1.Items(l).SubItems.Item(0).Text & "' and status not in ('RELEASED','RECMLWB') "
                obj.commandTrack(str)
                obj.TrackExecute()

                If ComboBox4.Text.ToUpper = "GOODSTOCK" Or ComboBox4.Text.ToUpper = "CELLULAR" Or ComboBox4.Text.ToUpper = "WATCH" Then
                    str = "insert into [REMS].DBO.asys_barcodehistory  (lotno, refallbarcode,allbarcode, itemcode,itemid, [description], karat, carat, weight, empname,trandate, costcenter,  status ) values ('" & lblLotno.Text & "','" & ListView1.Items(l).SubItems.Item(11).Text & "','" & ListView1.Items(l).SubItems.Item(11).Text & "','" & Mid(ListView1.Items(l).SubItems.Item(11).Text, 1, 3) & "','" & ListView1.Items(l).SubItems.Item(0).Text & "','" & ListView1.Items(l).SubItems.Item(1).Text & "','" & ListView1.Items(l).SubItems.Item(3).Text & "','" & ListView1.Items(l).SubItems.Item(5).Text & "','" & ListView1.Items(l).SubItems.Item(7).Text & "','" & Trim(userLog) & "',getdate(),'REM','RECEIVED')"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                End If
            Next

            obj.CommitTrack()
            MsgBox("SAVE SUCCESSFULLY", MsgBoxStyle.Information, TitleMsgBox)
            'ComboBox5.Text = ""
            'ComboBox4.Text = "Jewelry"

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message, , TitleMsgBox)
        Finally
            obj.Close()
        End Try

    End Sub
    Private Sub SavePTN()
        Dim l, f As Integer
        'Try catch in UPDATING

        Try

            For f = 0 To Me.ListView1.Items.Count - 1
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                If CInt(sAction(ComboBox4.SelectedIndex)) = iAppliance Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "', sortdate= getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCellular Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iGoodStock Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCoated Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iJewelry Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + " 'where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iWatch Then
                    objclass.Command("update tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iFake Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iOverAppraised Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', reccostid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iMissingItem Then
                    objclass.Command("update tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =  getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', reccostid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If
                objclass.Execute()
            Next
            objclass.Close()


            For f = 0 To Me.ListView1.Items.Count - 1
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                If CInt(sAction(ComboBox4.SelectedIndex)) = iAppliance Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate= getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCellular Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iGoodStock Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iCoated Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iJewelry Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + " 'where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iWatch Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set reclotno =" & txtlot.Text & ",recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "',  sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iFake Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid =' " + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code ='" + getsortcode + "', status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "'and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iOverAppraised Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If

                If CInt(sAction(ComboBox4.SelectedIndex)) = iMissingItem Then
                    objclass.Command("update REMS.DBO.tbl_receiving_header set recAllBarcode='" & Me.ListView1.Items(f).SubItems.Item(11).Text & "',sortdate =   getdate(), recsortername = '" + lblSortername.Text + "', recsorterid = '" + lblSorterIDNo.Text + "', reccostid = '" + lblSorterIDNo.Text + "', sortaction_id = '" + sAction(ComboBox4.SelectedIndex) + "', sort_code = '" + getsortcode + "',  status_id ='" + CStr(objclass.status.sorting) + "' where recptn = '" + TextBox28.Text + "' and recItem_id='" & Me.ListView1.Items(f).SubItems.Item(0).Text & "'")
                End If
                objclass.Execute()
            Next
            objclass.Close()

            For i = 0 To ListView1.Items.Count - 1
                saveALLEdit(i)
            Next
            For l = 0 To ListView1.Items.Count - 1
                If CInt(sAction(ComboBox4.SelectedIndex)) = iGoodStock Or CInt(sAction(ComboBox4.SelectedIndex)) = iCellular Or CInt(sAction(ComboBox4.SelectedIndex)) = iWatch Then
                    objclass.Open()
                    objclass.Command("Update tbl_receiving_detail set dlotno =" & txtlot.Text & ",DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.TextBox28.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                    objclass.Execute()
                    objclass.Command("Update REMS.dbo.tbl_receiving_detail set dlotno =" & txtlot.Text & ",DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.TextBox28.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                    objclass.Execute()
                    objclass.Close()
                Else
                    objclass.Open()
                    objclass.Command("Update tbl_receiving_detail set DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.TextBox28.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                    objclass.Execute()
                    objclass.Command("Update REMS.dbo.tbl_receiving_detail set DALLBarcode = '" & Me.ListView1.Items(l).SubItems.Item(11).Text & "' where Dptn = '" & Me.TextBox28.Text & "' and ID='" & Me.ListView1.Items(l).SubItems.Item(0).Text & "'")
                    objclass.Execute()
                    objclass.Close()
                End If
            Next
            returnfocus1()
            objclass = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Public Sub saveALLEdit(ByVal i As Integer)
        Try
            Dim itmID As String
            objclass.ConnectionString1()
            objclass.Open()
            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            '--------------------
            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID = '" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "',ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from REMS.DBO.tbl_receiving_detail where ID ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update REMS.DBO.tbl_receiving_detail set ALL_Karat ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ID='" + itmID + "'and ddivision ='" + Trim(txtBranchCode.Text) + "' and Dptn='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Public Sub saveALLEdit1(ByVal i As Integer)
        Try
            Dim itmID As String
            objclass.ConnectionString1()
            objclass.Open()
            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR ='" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR = '" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR ='" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR = '" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(3).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR = '" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) = 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR ='" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(7).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and division_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) = 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR = '" + itmID + "' and ptn_dfor ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "' where ptn_dfor='" + itmID + "'and ptn_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If

            If Trim(ListView1.Items.Item(i).SubItems.Item(8).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(4).Text) <> 0 And Trim(ListView1.Items.Item(i).SubItems.Item(9).Text) <> 0 Then
                itmID = ListView1.Items.Item(i).SubItems.Item(0).Text
                objclass.Command("select * from tbl_ForcedOutRcv_Detail where FOR_ID_DFOR ='" + itmID + "' and Dptn ='" & Me.TextBox28.Text & "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    objclass.Command("Update tbl_ForcedOutRcv_Detail set ALL_Karat_dfor ='" + CStr(CInt(ListView1.Items.Item(i).SubItems.Item(4).Text)) + "',ALL_WT_dfor ='" + CStr(CDbl(FormatNumber(ListView1.Items.Item(i).SubItems.Item(8).Text, 2))) + "', ALL_Value_dfor ='" + CStr(CDbl(FormatNumber(Label44.Text, 2))) + "'  where ptn_dfor='" + itmID + "'and ptn_dfor ='" + Trim(txtBranchCode.Text) + "' and ptn_dfor='" & Me.TextBox28.Text & "'")
                End If
                objclass.CloseDataReader()
                objclass.Execute()
                objclass.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Private Sub Form1_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            iAction = Nothing
            sUserID = Nothing
            sSortClass = Nothing
            's_PTN = Nothing
            'sPTNBarcode = Nothing
            sDivision = Nothing
            iFocus = Nothing
            iEdit = Nothing
            Clear()
            sort = False

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
#End Region
#Region " control attributes "

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            edit = 1
            s_action = ComboBox4.Text.Trim
            s_class = ComboBox5.Text.Trim
            If radNone.Checked = True Then
                radbutton = 1
            Else
                radbutton = 2
            End If
            'If Len(TextBox28.Text) = 0 Then
            '    MsgBox("Select a PTN", MsgBoxStyle.Information)
            '    TextBox28.Text = ""
            '    TextBox28.Focus()
            '    Exit Sub
            'ElseIf Len(TextBox29.Text) = 0 Then
            '    MsgBox("Select PTN barcode", MsgBoxStyle.Information)
            '    TextBox29.Text = ""
            '    TextBox29.Focus()
            '    Exit Sub
            'End If

            If Len(txtBranchCode.Text) = 0 Or Len(Trim(txtbrname.Text)) = 0 Then
                MsgBox("Input Branch Code and press enter", MsgBoxStyle.Information)
                txtBranchCode.Text = ""
                txtBranchCode.Focus()
                Exit Sub
            End If

            If ListView1.Items.Count = 0 Then
                MsgBox("PTN has no item. Data can't update.", MsgBoxStyle.Information)
                TextBox28.Text = ""
                TextBox28.Focus()
                Exit Sub
            End If

            'HIDE MAIN FORM display form edit
            Dim frmEdit As New frmEdit
            frmEdit.setPtn(TextBox28.Text, lblLotno.Text)
            Me.Dispose()
            frmEdit.ShowDialog()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Clear()
            sort = False
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Clear()
            ComboBox4.Enabled = True
            'ComboBox4.Text = "Jewelry"
            'ComboBox5.Text = ""
            If ComboBox4.Text = "JEWELRY" Then
                ComboBox5.Enabled = True
            End If
            TextBox28.Text = ""
            TextBox29.Text = ""
            If radNone.Checked = True Then
                TextBox28.Focus()
            Else
                TextBox29.Focus()
            End If
            MStatus = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If TextBox28.TextLength <> 12 Then
                TextBox28.Text = TextBox28.Text.PadLeft(12, "0")
            End If

            NewRetrieveInfo(CStr(TextBox28.Text.Trim), 1, True)

            If f = True Then
                Clear()
                Exit Sub
            End If

            If ComboBox4.Text = "" Or ComboBox5.Text = "" Or TextBox28.Text = "" Then
                MsgBox("Please fill-up the missing/blank boxes", MsgBoxStyle.Information)
                Exit Try
            End If

            If Len(TextBox28.Text) = 0 Then
                MsgBox("Select a PTN", MsgBoxStyle.Information)
                TextBox28.Text = ""
                TextBox28.Focus()
                Exit Sub
            End If

            If Len(txtBranchCode.Text) = 0 Then
                MsgBox("Input Branch Code and press ENTER", MsgBoxStyle.Information)
                txtBranchCode.Text = ""
                txtBranchCode.Focus()
                Exit Sub
            End If

            If Len(txtbrname.Text) = 0 Then
                MsgBox("Input Branch code and press ENTER!", MsgBoxStyle.Information)
                txtBranchCode.Focus()
                Exit Sub
            End If
            If ListView1.Items.Count = 0 Then
                MsgBox("PTN has no item. Data not saved.", MsgBoxStyle.Information)
                TextBox28.Text = ""
                TextBox28.Focus()
                Exit Sub
            End If

            If ComboBox4.Text = "" Then
                MsgBox("Select action.", MsgBoxStyle.Information)
                ComboBox4.Focus()
                Exit Sub
            End If

            If ComboBox5.Text = "" Then
                MsgBox("Select a sorting class.", MsgBoxStyle.Information)
                ComboBox5.Focus()
                Exit Sub
            End If


            getsortcode = ComboBox5.SelectedItem
            If ComboBox5.Text.ToUpper = "OTHERS" Then
                getsortcode = "O"
            End If

            Call GenBarcode()
            Call NEwSAVEPTN()

            Clear()
            TextBox28.Text = ""
            TextBox29.Text = ""

            If radNone.Checked = True Then
                TextBox28.Focus()
            Else
                TextBox29.Focus()
            End If
            'Call RetrievePTN_Barcode()
            naa = False
            balik = False
            MStatus = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ptn()
        Try
            iFocus = 15
            'TextBox29.Text = sPTNBarcode(ComboBox1.SelectedIndex)
            TextBox28.Text = ComboBox1.SelectedItem
            NewRetrieveInfo(CStr(TextBox28.Text), 1, False)
            TextBox1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ptn_barcode()
        Try
            iFocus = 16
            'TextBox28.Text = s_PTN(ComboBox2.SelectedIndex)
            TextBox29.Text = ComboBox2.SelectedItem
            RetrieveInfo(CStr(TextBox29.Text), 2, False)
            TextBox29.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            If Len(txtBranchCode.Text) = 0 Then
                MsgBox("Input Branch code!", MsgBoxStyle.Information)
                txtBranchCode.Focus()
                Exit Sub
            End If
            If Len(txtbrname.Text) = 0 Then
                MsgBox("Input Branch code!", MsgBoxStyle.Information)
                txtBranchCode.Focus()
                Exit Sub
            End If
            ListView1.Items.Clear()
            listview2.Items.Clear()
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Call ptn()

            If ListView1.Items.Count > 0 Then
                If fl = True Then
                    Button1.Enabled = False
                    Button4.Enabled = True
                    Button4.Focus()
                    fl = False
                Else
                    If f = True Then
                        Button1.Enabled = False
                        Button4.Enabled = False
                        f = False
                    Else
                        Button1.Enabled = True
                        Button4.Enabled = True
                        Button1.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Try
            If Len(txtBranchCode.Text) = 0 Then
                MsgBox("Input Branch code!", MsgBoxStyle.Information)
                txtBranchCode.Focus()
                Exit Sub
            End If
            If Len(txtbrname.Text) = 0 Then
                MsgBox("Input Branch code!", MsgBoxStyle.Information)
                txtBranchCode.Focus()
                Exit Sub
            End If
            ListView1.Items.Clear()
            listview2.Items.Clear()
            Call ptn_barcode()
            If ListView1.Items.Count > 0 Then
                If fl = True Then
                    Button1.Enabled = False
                    Button4.Enabled = True
                    Button4.Focus()
                    fl = False
                Else
                    If f = True Then
                        Button1.Enabled = False
                        Button4.Enabled = False
                        f = False
                    Else
                        Button1.Enabled = True
                        Button4.Enabled = True
                        Button1.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub ComboBox4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectionChangeCommitted
    '    objclass = New clsCommon
    '    If objclass.action.Cellular = CInt(sAction(ComboBox4.SelectedIndex)) Then
    '        ComboBox5.Text = ""
    '        ComboBox5.Enabled = False
    '    ElseIf objclass.action.Watch = CInt(sAction(ComboBox4.SelectedIndex)) Then
    '        ComboBox5.Text = ""
    '        ComboBox5.Enabled = False
    '    ElseIf objclass.action.OverAppraised = CInt(sAction(ComboBox4.SelectedIndex)) Then
    '        Button4.Enabled = True
    '    End If
    '    objclass = Nothing
    'End Sub

#End Region

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox5_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim F As Integer
            objclass = New clsCommon
            F = 0
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
                If txtBranchCode.Text.Trim.Length = 0 Then
                    MsgBox("Enter a Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Text = ""
                    txtBranchCode.Focus()
                    Exit Sub
                End If

                If Not IsNumeric(txtBranchCode.Text) Then
                    MsgBox("Input a numeric value for branch code", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Text = ""
                    txtBranchCode.Focus()
                    Exit Sub
                End If

                If Len(txtBranchCode.Text) > 32767 And Len(txtBranchCode.Text) < 0 Then
                    MsgBox("Invalid Value", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Text = ""
                    txtBranchCode.Focus()
                    Exit Sub
                End If

                objclass.ConnDb()
                objclass.Open5()
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                    'ElseIf UCase(sDB) = "VISMIN" Then
                ElseIf UCase(sDB) = "VISAYAS" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                End If

                dr = objclass.OpenDataReader5
                If dr.Read = True Then
                    txtbrname.Text = UCase(Trim(dr.Item("bedrnm")))
                    F = 1
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
                If F = 1 Then
                    Call RetrievePTN_Barcode()
                Else
                    MsgBox("Branch Code does not exist", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Text = ""
                    txtbrname.Text = ""
                    txtBranchCode.Focus()
                    Exit Sub
                End If
                clear2()
                If radNone.Checked = True Then
                    TextBox28.Focus()
                Else
                    TextBox29.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmSort/txtBranchCode_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtbrname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbrname.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim f As Integer
            f = 0
            If e.KeyCode = Keys.Enter Then
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbrname.Text.Trim + "'")
                    'ElseIf UCase(sDB) = "VISMIN" Then
                ElseIf UCase(sDB) = "VISAYAS" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbrname.Text.Trim + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbrname.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbrname.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbrname.Text.Trim + "'")
                End If
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    txtBranchCode.Text = dr.Item("bedrnr")
                    f = 1
                Else
                    MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
                objclass = Nothing
                If f = 1 Then
                    Call RetrievePTN_Barcode()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/txtbrname_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            ComboBox5.Items.Clear()
            ComboBox5.Text = ""

            If ComboBox4.Text = "JEWELRY" Then

                'asys 3.0 upgrade
                'ComboBox5.Items.Add("Chinese Gold")
                'ComboBox5.Items.Add("Old Gold")
                'ComboBox5.Items.Add("Singaporean")

                'asys 3.0 upgrade
                ComboBox5.Items.Add("9K/10K")
                ComboBox5.Items.Add("12K/14K")
                ComboBox5.Items.Add("16K/18K")
                ComboBox5.Items.Add("20K")
                ComboBox5.Items.Add("21K/22K/24K")
                ComboBox5.Enabled = True

                If listview2.Items.Count > 0 Then
                    Button1.Enabled = True
                    'Button4.Enabled = True
                    Button1.Focus()
                Else
                    Button1.Enabled = False
                End If
                Exit Sub
            Else
                ComboBox5.Items.Add("OTHERS")
                ComboBox5.Text = "OTHERS"
                ComboBox5.Enabled = False
            End If

            If ComboBox4.Text = "FAKE" Or ComboBox4.Text = "COATED" Or ComboBox4.Text = "MISSINGITEM" Or ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text = "OVERAPPRAISED" Or ComboBox4.Text = "CELLULAR" Or ComboBox4.Text = "WATCH" Or ComboBox4.Text = "APPLIANCE" Then
                Button1.Enabled = True
                'Button4.Enabled = True
                ComboBox5.Items.Add("OTHERS")
                ComboBox5.Text = "OTHERS"
                ComboBox5.Enabled = False
                GroupBox5.Enabled = True
                ComboBox1.Enabled = True
                If radNone.Checked = True Then
                    TextBox28.Enabled = False
                    TextBox28.BackColor = Color.White
                Else
                    TextBox28.Enabled = True
                End If

                If listview2.Items.Count > 0 Then
                    Button1.Enabled = True
                    'Button4.Enabled = True
                    Button1.Focus()
                Else
                    Button1.Enabled = False
                    Button4.Enabled = False
                End If
                TextBox29.Enabled = False
                ComboBox2.Enabled = False
                TextBox28.Enabled = True
                TextBox28.BackColor = Color.White
                TextBox28.Focus()
            ElseIf ComboBox4.Text = "TakenBack" Or ComboBox4.Text = "AuctionBuyer" Then
                ComboBox5.Text = ""
                ComboBox5.Enabled = False
                Button4.Enabled = False
                Button1.Enabled = False
                GroupBox5.Enabled = True
                ComboBox1.Enabled = True
                TextBox28.Enabled = True
                ComboBox2.Enabled = True
                TextBox29.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox4_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub getPTN()
        Try
            objclass.Open()
            objclass.Command("Select ptn from ASYS_REM_Header where ptnbarcode =" + TextBox29.Text)
            dr = objclass.OpenDataReader
            If dr.Read Then
                bptn = objclass.IsNull(dr.Item("PTN"))
            Else
                Exit Sub
            End If
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            TextBox28.Text = bptn
        Catch ex As Exception
            MsgBox("frmSort/getPTN: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub getptnbarcode()
        Try
            objclass.Open()
            objclass.Command("Select ptnbarcode from ASYS_REM_Header where ptn =" + TextBox28.Text)
            dr = objclass.OpenDataReader
            If dr.Read Then
                bptn = objclass.IsNull(dr.Item("PTNBarcode"))
            Else
                Exit Sub
            End If
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            TextBox29.Text = bptn
        Catch ex As Exception
            MsgBox("frmSort/getptnbarcode: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub trappingALL()
        Try
            If allvalue = "" Then
                allvalue = "0.0"
            End If
            If allkarat = "" Then
                allkarat = "0.0"
            End If

            If allwt = "" Then
                allwt = "0.0"
            End If
        Catch ex As Exception
            MsgBox("frmSort/trappingALL: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Passing by parameter

    Public Sub setPtn(ByVal ptn1 As String)
        Try
            ptns = ptn1
            TextBox28.Text = ptns
        Catch ex As Exception
            MsgBox("frmSort/setPtn: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub setIfEdit(ByVal edited As Integer)
        Try
            isedit = edited
        Catch ex As Exception
            MsgBox("frmSort/setIfEdit: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub trapIfNotExisting()
        Try
            If flag = True Then
                MsgBox("PTN not found!", MsgBoxStyle.Information, TitleMsgBox)
                Clear()
            Else
                MsgBox("PTN Barcode not found!", MsgBoxStyle.Information, TitleMsgBox)
                Clear()
            End If

            Button1.Enabled = False
            Button4.Enabled = False

            If radNone.Checked = True Then
                TextBox28.Text = ""
                TextBox29.Text = ""
                TextBox28.Focus()
            Else
                TextBox28.Text = ""
                TextBox29.Text = ""
                TextBox29.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmSort/trapIfNotExisting: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox28_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox28.KeyDown
        Try
            If e.KeyCode = 13 Then
                If TextBox28.TextLength <> 12 Then
                    TextBox28.Text = TextBox28.Text.PadLeft(12, "0")
                End If
                If force = False Then
                    Me.Timer1.Enabled = False
                    flg = True
                    allwt = ""
                    allkarat = ""
                    allvalue = ""

                    If TextBox28.Text.Trim = "" Then
                        MsgBox("Enter PTN", MsgBoxStyle.Information, TitleMsgBox)
                        Clear()
                        TextBox28.Text = ""
                        TextBox28.Focus()
                        Clear()
                        Exit Sub
                    End If

                    If IsNumeric(TextBox28.Text) Then
                        ListView1.Items.Clear()
                        listview2.Items.Clear()
                        Clear()
                        Me.TextBox1.Text = ""
                        Me.TextBox2.Text = ""
                        Me.TextBox3.Text = ""
                        NewRetrieveInfo(CStr(TextBox28.Text.Trim), 1, True)
                        If MStatus = True Then
                            MsgBox("PTN already sorted", MsgBoxStyle.Information, TitleMsgBox)
                            ComboBox4.Enabled = False
                            ComboBox5.Enabled = False
                            Button1.Enabled = False
                            Button4.Enabled = True
                            Button4.Focus()
                            MStatus = False
                        Else
                            If f = True Then
                                Button1.Enabled = False
                                Button4.Enabled = False
                                f = False
                            Else
                                Button1.Enabled = True
                                Button4.Enabled = True
                                Button1.Focus()
                            End If
                        End If
                    Else
                        MsgBox("Input a numeric value.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox28.Text = ""
                        TextBox28.Focus()
                    End If
                Else
                    Me.Timer1.Enabled = False
                    flg = True
                    allwt = ""
                    allkarat = ""
                    allvalue = ""

                    If TextBox28.Text.Trim = "" Then
                        MsgBox("Input PTN", MsgBoxStyle.Information, TitleMsgBox)
                        Clear()
                        TextBox28.Text = ""
                        TextBox28.Focus()
                        Clear()
                        Exit Sub
                    End If

                    If IsNumeric(TextBox28.Text) Then
                        ListView1.Items.Clear()
                        listview2.Items.Clear()
                        Clear()
                        Me.TextBox1.Text = ""
                        Me.TextBox2.Text = ""
                        Me.TextBox3.Text = ""
                        NewRetrieveInfo(CStr(TextBox28.Text.Trim), 1, True)
                        If MStatus = True Then
                            MsgBox("PTN already sorted", MsgBoxStyle.Information, TitleMsgBox)
                            Button1.Enabled = False
                            Button4.Enabled = True
                            Button4.Focus()
                            MStatus = False

                        Else
                            If f = True Then
                                Button1.Enabled = False
                                Button4.Enabled = False
                                f = False
                            Else
                                Button1.Enabled = True
                                Button4.Enabled = True
                                Button1.Focus()
                            End If
                        End If
                    Else
                        MsgBox("Input a numeric value.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox28.Text = ""
                        TextBox28.Focus()
                    End If
                End If
            End If

            If Me.ListView1.Items.Count = 1 Then
                Me.TextBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox28_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox29_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox29.KeyDown
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
                allwt = ""
                allkarat = ""
                allvalue = ""

                If TextBox29.Text = "" Then
                    MsgBox("Input PTN barcode", MsgBoxStyle.Information, TitleMsgBox)
                    Clear()
                    TextBox29.Text = ""
                    TextBox29.Focus()
                    Clear()
                    Exit Sub
                End If

                If IsNumeric(TextBox29.Text) Then
                    'iFocus = 16
                    ListView1.Items.Clear()
                    listview2.Items.Clear()
                    Clear()
                    'NewRetrieveInfo(CStr(TextBox29.Text), 2, True)
                    RetrieveInfo(CStr(TextBox29.Text), 2, True)
                    If fl = True Then
                        Button1.Enabled = False
                        Button4.Enabled = True
                        Button4.Focus()
                        fl = False
                    Else
                        If f = True Then
                            Button1.Enabled = False
                            Button4.Enabled = False
                            f = False
                        Else
                            Button1.Enabled = True
                            Button4.Enabled = True
                            Button1.Focus()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox29_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox28_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox28.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox28_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox29_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        Try
            If nonNumberEntered = True Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox29_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            Button1.Focus()
            If ComboBox4.Text = "JEWELRY" And ComboBox5.Text <> "" Then
                GroupBox5.Enabled = True
                ComboBox1.Enabled = True
                TextBox28.BackColor = Color.White
                TextBox28.Enabled = True
                ComboBox2.Enabled = True
                TextBox29.Enabled = True
                TextBox28.Focus()
                If radNone.Checked = True Then
                    TextBox29.Enabled = False
                    ComboBox2.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox5_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub radNone_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radNone.Click
        Try
            If radNone.Checked = True Then
                BcodeScanner(True)
                Button3_Click(sender, e)
                TextBox28.TabIndex = 0
                TextBox28.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmSort/radNone_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub radPTNBarcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radPTNBarcode.Click
        Try
            If radPTNBarcode.Checked = True Then
                BcodeScanner(True)
                Button3_Click(sender, e)
                TextBox29.TabIndex = 0
                TextBox29.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmSort/radPTNBarcode_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            txtbrname.Text = ""
            txtBranchCode.Focus()
            ListView1.Items.Clear()
            listview2.Items.Clear()
            Label20.Text = ""
            Label21.Text = ""
            Label36.Text = ""
            Label37.Text = ""
            Label38.Text = ""
            Label39.Text = ""
            Label40.Text = ""
            Label41.Text = ""
            Label42.Text = ""
            Label43.Text = ""
            Label44.Text = ""
            Label45.Text = ""
            Label46.Text = ""
            Label47.Text = ""
            Label48.Text = ""
        Catch ex As Exception
            MsgBox("frmSort/txtBranchCode_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged
        Try
            If TextBox29.Text = "" Then
                TextBox29.Focus()
                TextBox28.Text = ""
                Clear()
                Exit Sub
            End If
            ListView1.Items.Clear()
            listview2.Items.Clear()
            If radNone.Checked = True Then
                Me.Timer1.Enabled = False
                Me.TextBox28.Focus()
                Exit Sub
                'Else
                '    Me.Timer1.Enabled = True
            End If
            If TextBox29.Text.StartsWith(0) = True Then
                TextBox29.Text = ""
            End If
            If TextBox29.TextLength = 9 Then
                'If flg = True Then
                '    Me.Timer1.Enabled = False
                '    Me.Timer1.Stop()
                '    flg = False
                '    Exit Sub
                'Else
                '    Me.Timer1.Enabled = True
                '    Me.Timer1.Interval = 250
                '    Me.Timer1.Start()
                RetrieveInfo(CStr(TextBox29.Text), 2, True)
                'End If
            End If
            If naa = True Then
                If ComboBox4.Text = "JEWELRY" And ComboBox5.Text <> "" Then
                    Button1.Enabled = True
                    Button4.Enabled = True
                Else
                    Button1.Enabled = False
                    Button4.Enabled = False
                End If
                If ComboBox4.Text <> "JEWELRY" Then
                    Button1.Enabled = True
                End If
            End If
            If balik = True Then
                Button1.Enabled = False
                Button4.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox29_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If Me.ListView1.Items.Item(0).SubItems.Item(11).Text = "0" Then
                    ListView1.Items.Item(0).SubItems.Item(11).Text = Me.TextBox1.Text.ToString
                End If
                If Me.ListView1.Items.Count = 1 Then
                    Button1.Focus()
                    Button1.Enabled = True
                ElseIf Me.ListView1.Items.Count > 2 Then
                    TextBox2.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If Me.ListView1.Items.Item(1).SubItems.Item(11).Text = "0" Then
                    ListView1.Items.Item(1).SubItems.Item(11).Text = Me.TextBox2.Text.ToString
                    If Me.ListView1.Items.Count > 3 Then
                        TextBox3.Focus()
                    Else
                        Button1.Focus()
                        Button1.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If Me.ListView1.Items.Item(2).SubItems.Item(11).Text = "0" Then
                    ListView1.Items.Item(2).SubItems.Item(11).Text = Me.TextBox3.Text.ToString
                    If Me.ListView1.Items.Count = 3 Then
                        Button1.Focus()
                        Button1.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSort/TextBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSortForceOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortForceOut.Click
        Try
            force = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            force = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox4.KeyDown
        Try
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Delete Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox4_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox5.KeyDown
        Try
            If e.KeyCode = Keys.Back Or e.KeyCode = Keys.Enter Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/ComboBox5_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub radPTNBarcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPTNBarcode.CheckedChanged
        Try
            TextBox28.BackColor = Color.White
            TextBox28.Enabled = False
            ComboBox1.Enabled = False
        Catch ex As Exception
            MsgBox("frmSort/radPTNBarcode_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function BcodeScanner(ByVal check As Boolean)
        Try
            If radNone.Checked = check Then
                ComboBox2.Enabled = False
                TextBox29.Enabled = False
                TextBox28.Enabled = True
                ComboBox1.Enabled = True
            ElseIf radPTNBarcode.Checked = check Then
                TextBox28.Enabled = False
                ComboBox1.Enabled = False
                ComboBox2.Enabled = True
                TextBox29.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/BcodeScanner: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub radNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNone.CheckedChanged
        Try
            TextBox29.Enabled = False
            ComboBox2.Enabled = False
            TextBox28.BackColor = Color.White
        Catch ex As Exception
            MsgBox("frmSort/radNone_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt.KeyPress
        Try
            If IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
            If txt.TextLength = 0 Or ispes = True Then
                If Char.IsLower(e.KeyChar) = True Then
                    e.Handled = True
                    txt.Text = Char.ToUpper(e.KeyChar)
                    ispes = False
                    txt.Focus()
                End If
            Else
                Char.ToLower(e.KeyChar)
            End If
            If e.KeyChar = ChrW(Keys.Space) Then
                ispes = True
            End If
        Catch ex As Exception
            MsgBox("frmSort/txt_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
