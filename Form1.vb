Imports System.Drawing
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data


Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents lblNoItems As System.Windows.Forms.Label ''label
    Private WithEvents txtAllBarcode As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtDesc As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtPrice As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtCPrice As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtGrams As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtKarat As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtCarat As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents pbPicture As New System.Windows.Forms.PictureBox  ''textbox
    Private WithEvents txtSocialNo As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents txtModelNo As New System.Windows.Forms.TextBox ''textbox
    Private WithEvents btnDelete As New System.Windows.Forms.Button ''button
    Private WithEvents lblphoto As System.Windows.Forms.Label ''label
    Private WithEvents lblCurrency As New System.Windows.Forms.Label  ''textbox
    Private WithEvents dataTable As dataTable
    Private sDatasource1 As String
    Private sDatabase1 As String
    Private sUsername1 As String
    Private sPassword1 As String
    Private sDatasource2 As String
    Private ConStr2 As String
    Private sDatabase2 As String
    Private sUsername2 As String
    Private sPassword2 As String


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
    Friend WithEvents lbl1FA01 As System.Windows.Forms.Label
    Friend WithEvents AsysReleasing As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLot As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCostCenter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBOSUpload As System.Windows.Forms.Button
    Friend WithEvents btnConsignment As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtlotno As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.lbl1FA01 = New System.Windows.Forms.Label
        Me.AsysReleasing = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtlotno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnLot = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbCostCenter = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbEmployee = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnBOSUpload = New System.Windows.Forms.Button
        Me.btnConsignment = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1FA01
        '
        Me.lbl1FA01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1FA01.Location = New System.Drawing.Point(920, 40)
        Me.lbl1FA01.Name = "lbl1FA01"
        Me.lbl1FA01.Size = New System.Drawing.Size(72, 16)
        Me.lbl1FA01.TabIndex = 114
        Me.lbl1FA01.Text = "1FA01 V5.2"
        '
        'AsysReleasing
        '
        Me.AsysReleasing.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsysReleasing.Location = New System.Drawing.Point(696, 16)
        Me.AsysReleasing.Name = "AsysReleasing"
        Me.AsysReleasing.Size = New System.Drawing.Size(304, 24)
        Me.AsysReleasing.TabIndex = 113
        Me.AsysReleasing.Text = "ASYS DISTRI : CONSIGNMENT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtlotno)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnLot)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 128)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(248, 40)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(32, 24)
        Me.btnSearch.TabIndex = 138
        Me.btnSearch.Text = "...."
        '
        'txtlotno
        '
        Me.txtlotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlotno.Location = New System.Drawing.Point(72, 40)
        Me.txtlotno.MaxLength = 10
        Me.txtlotno.Name = "txtlotno"
        Me.txtlotno.Size = New System.Drawing.Size(168, 20)
        Me.txtlotno.TabIndex = 136
        Me.txtlotno.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 16)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "---------------------------------------------------------------------------------" & _
        "--------------------------------"
        '
        'btnLot
        '
        Me.btnLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLot.Location = New System.Drawing.Point(16, 40)
        Me.btnLot.Name = "btnLot"
        Me.btnLot.Size = New System.Drawing.Size(56, 26)
        Me.btnLot.TabIndex = 117
        Me.btnLot.Text = "LOT NO."
        Me.btnLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCostCenter)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbEmployee)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(336, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 128)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        '
        'cmbCostCenter
        '
        Me.cmbCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCostCenter.ItemHeight = 13
        Me.cmbCostCenter.Location = New System.Drawing.Point(424, 56)
        Me.cmbCostCenter.Name = "cmbCostCenter"
        Me.cmbCostCenter.Size = New System.Drawing.Size(184, 21)
        Me.cmbCostCenter.TabIndex = 113
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(232, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "..."
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(128, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(384, 20)
        Me.TextBox2.TabIndex = 131
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 56)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 129
        Me.TextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "BRANCH CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(344, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "USER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEmployee
        '
        Me.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployee.Location = New System.Drawing.Point(424, 24)
        Me.cmbEmployee.Name = "cmbEmployee"
        Me.cmbEmployee.Size = New System.Drawing.Size(184, 21)
        Me.cmbEmployee.Sorted = True
        Me.cmbEmployee.TabIndex = 109
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "CONSIGN TO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 32)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "DATE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(128, 24)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(184, 20)
        Me.txtDate.TabIndex = 127
        Me.txtDate.Text = ""
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(520, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 24)
        Me.Button3.TabIndex = 140
        Me.Button3.Text = "ADD ROW"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 24)
        Me.Label7.TabIndex = 130
        Me.Label7.Text = "BRANCH NAME"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBOSUpload
        '
        Me.btnBOSUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBOSUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBOSUpload.Image = CType(resources.GetObject("btnBOSUpload.Image"), System.Drawing.Image)
        Me.btnBOSUpload.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBOSUpload.Location = New System.Drawing.Point(856, 528)
        Me.btnBOSUpload.Name = "btnBOSUpload"
        Me.btnBOSUpload.Size = New System.Drawing.Size(80, 40)
        Me.btnBOSUpload.TabIndex = 133
        Me.btnBOSUpload.Text = "UPLOAD"
        Me.btnBOSUpload.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBOSUpload.Visible = False
        '
        'btnConsignment
        '
        Me.btnConsignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsignment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsignment.Image = CType(resources.GetObject("btnConsignment.Image"), System.Drawing.Image)
        Me.btnConsignment.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsignment.Location = New System.Drawing.Point(856, 528)
        Me.btnConsignment.Name = "btnConsignment"
        Me.btnConsignment.Size = New System.Drawing.Size(80, 40)
        Me.btnConsignment.TabIndex = 132
        Me.btnConsignment.Text = "HOIF"
        Me.btnConsignment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(696, 528)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 130
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
        Me.DgEntry.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DgEntry.DataMember = ""
        Me.DgEntry.FlatMode = True
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Tan
        Me.DgEntry.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DgEntry.Location = New System.Drawing.Point(8, 296)
        Me.DgEntry.Name = "DgEntry"
        Me.DgEntry.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DgEntry.SelectionForeColor = System.Drawing.Color.White
        Me.DgEntry.Size = New System.Drawing.Size(1008, 224)
        Me.DgEntry.TabIndex = 134
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1008, 165)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.PictureBox2)
        Me.GroupBox4.Controls.Add(Me.AsysReleasing)
        Me.GroupBox4.Controls.Add(Me.lbl1FA01)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1008, 128)
        Me.GroupBox4.TabIndex = 137
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 80)
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-224, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(182, 50)
        Me.PictureBox2.TabIndex = 115
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(936, 528)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 139
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(776, 528)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 140
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 536)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 141
        Me.Label8.Text = "NO. OF ITEMS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(104, 536)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(184, 536)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 23)
        Me.Label10.TabIndex = 143
        Me.Label10.Text = "TOTAL SELLING PRICE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(328, 536)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 23)
        Me.Label11.TabIndex = 144
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1026, 580)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnConsignment)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.btnBOSUpload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONSIGNMENT FORM"
        Me.TopMost = True
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ds_dataset As New DataSet
    Private con_dataset As New DataSet
    Private dv_dataview As DataView
    Private arrstr() As String
    Private cn As New SqlClient.SqlConnection
    Dim jpoy As New clsConnection
    Dim dr As SqlClient.SqlDataReader
    Dim i As Integer
    Dim dgtb As DataGridTextBoxColumn
    Dim objclass As New clsCommon
    Dim whatto As Boolean
    Public spath As String = Application.StartupPath

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.txtlotno.Text = GetNewLotNumber("CONSIGNMENT", "") 'GenerateLot()
            txtDate.Text = UCase(Format(Date.Now, "MMMM dd, yyyy"))
            Me.cmbCostCenter.Focus()
            'Call emp()
            Call costcenter()
            Call CreateGrid()
            cmbCostCenter.Text = showvip
            cmbEmployee.Text = UCase(userLog)
            cmbEmployee.DropDownStyle = ComboBoxStyle.Simple
            cmbEmployee.Enabled = False
            cmbEmployee.BackColor = Color.White
            Button4.Enabled = False
            btnSave.Enabled = False
            btnBOSUpload.Enabled = False
            TextBox2.ReadOnly = True
            Button4.Enabled = False
            Button1.Enabled = False
            'mydata_table()
            If Me.TextBox1.Text <> "" Then
                Me.btnBOSUpload.Enabled = True
            End If
            If cmbCostCenter.Text = "" Then
                Button1.Enabled = False
                Button3.Enabled = False
            Else
                Button1.Enabled = True
                Button3.Enabled = True
            End If
            If pao = True Then
                Dim frms As New frmALL
                If p <> "" Then
                    Me.TextBox1.Text = p
                    Me.TextBox2.Text = a
                    Me.Label6.Text = o
                    Me.Label7.Text = l
                End If
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                Button3.Enabled = False
                cmbCostCenter.Items.Clear()
                cmbCostCenter.Items.Add("SHOWROOM")
                cmbCostCenter.Items.Add("VIP")
            End If

            oo = True
            If TextBox1.Text <> "" And TextBox2.Text <> "" And cmbCostCenter.Text <> "" And cmbEmployee.Text <> "" And txtlotno.Text <> "" Then
                btnBOSUpload.Enabled = True
            End If
            TextBox1.Focus()
            Me.BringToFront()
        Catch ex As Exception
            MsgBox("Form1/Form1_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub mydata_table()
        Try

            Dim ldc_datacolumn As New DataColumn
            Dim lddt_datatable As DataTable
            Dim i As Integer
            Dim lddt_temp As New DataTable
            Dim ldc_temp As New DataColumn
            Dim str As String = "select allbarcode from ASYS_Consign_detail"
            ConnectDB()

            con_dataset.Reset()
            Dim sql_adptr As New SqlClient.SqlDataAdapter(str, cn)
            con_dataset.Clear()
            sql_adptr.Fill(con_dataset, "allbarcode")

            If con_dataset.Tables(0).Rows.Count > 0 Then
                ldc_datacolumn = New DataColumn

                ldc_datacolumn.ColumnName = " "
                ldc_datacolumn.Caption = " "
                ldc_datacolumn.DataType = System.Type.GetType("System.String")
                ldc_datacolumn.DefaultValue = ""

                'add extra blank column
                con_dataset.Tables(0).Columns.Add(ldc_datacolumn)

                'recreate here
                lddt_datatable = con_dataset.Tables(0)

                For Each ldc_datacolumn In lddt_datatable.Columns
                    ldc_temp = New DataColumn
                    ldc_temp.ColumnName = ldc_datacolumn.ColumnName
                    ldc_temp.DataType = System.Type.GetType("System.String")
                    lddt_temp.Columns.Add(ldc_temp)
                Next

                'add the rows
                For Each ldr_datarow As DataRow In lddt_datatable.Rows
                    lddt_temp.ImportRow(ldr_datarow)
                Next


                dv_dataview = New DataView(con_dataset.Tables(0))
                dv_dataview = New DataView(lddt_temp)
            End If
        Catch ex As Exception
            MsgBox("Form1/mydata_table: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function Consigned_items(ByVal ads_dataset As DataSet, ByVal allbarcode As String) As Boolean
        Try


            Dim ldc_datacolumn As DataColumn
            Dim lddt_datatable As DataTable
            Dim ls_condition As String

            lddt_datatable = ads_dataset.Tables(0)
            For Each ldc_datacolumn In lddt_datatable.Columns
                If Trim(ldc_datacolumn.ColumnName) = "allbarcode" Then
                    ls_condition += "[" & ldc_datacolumn.ColumnName & "]" & " LIKE '%" & allbarcode & "%'"
                End If
            Next
            dv_dataview.RowFilter = ls_condition
            If dv_dataview.Count = 0 Then
                Consigned_items = False
            Else
                Consigned_items = True
            End If
        Catch ex As Exception

        End Try
    End Function

    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(13) {"NO.", "A.L.L. BARCODE", "DESCRIPTION", "SELLING PRICE  ", "COST PRICE  ", "GRAMS  ", "KARAT  ", "CARAT  ", "PICTURE", "SERIAL NUMBER", "MODEL NUMBER", "", "", " "}
            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")
            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 13
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
                ''Set its properties
                dgdtblStyle.MappingName = dataTable.TableName 'its table name of dataset
                DgEntry.TableStyles.Add(dgdtblStyle)
                dgdtblStyle.RowHeadersVisible = False
                dgdtblStyle.PreferredRowHeight = 22
                DgEntry.BackgroundColor = Color.White

                DgEntry.ReadOnly = True
                'Take the columns in a GridColumnStylesCollection object and set the size of the individual columns	

                Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 50
                colStyle(1).Width = 150
                colStyle(2).Width = 350
                colStyle(3).Width = 100
                colStyle(3).Alignment = HorizontalAlignment.Right
                colStyle(4).Width = 100
                colStyle(4).Alignment = HorizontalAlignment.Right
                colStyle(5).Width = 50
                colStyle(5).Alignment = HorizontalAlignment.Right
                colStyle(6).Width = 50
                colStyle(6).Alignment = HorizontalAlignment.Right
                colStyle(7).Width = 50
                colStyle(7).Alignment = HorizontalAlignment.Right
                colStyle(8).Width = 50
                colStyle(8).Alignment = HorizontalAlignment.Right
                colStyle(9).Width = 100
                colStyle(9).Alignment = HorizontalAlignment.Right
                colStyle(10).Width = 100
                colStyle(10).Alignment = HorizontalAlignment.Right
                colStyle(11).Width = 0
                colStyle(12).Width = 0
                colStyle(13).Width = 100
            End If
            'Take the text box from the second column of the grid where u will be adding the controls of your choice	
        Catch ex As Exception
            MsgBox("Form1/CreateGrid: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmddelete_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
        Catch ex As Exception
            MsgBox("Form1/cmddelete_click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            If Not ab_isEmpty Then
                If deleteData(hi) Then
                    dataTable.Rows.RemoveAt(hi.Row)
                Else
                    MsgBox("Error in connecting to database.Try Again!", MsgBoxStyle.Critical.OKOnly, TitleMsgBox)
                End If
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
        Catch ex As Exception
            MsgBox("Form1/deleteRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try

            Dim hi As DataGrid.HitTestInfo
            Dim pt = New Point(e.X, e.Y)
            Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)

            hi = DgEntry.HitTest(e.X, e.Y)

            'If hi.Column = 0 Then
            '    DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
            '    DgEntry.Select(hit.Row)
            'End If

            If hi.Column = 13 Then 'And hi.Row >= 0 Then
                'If DgEntry(hi.Row, 1) <> "" Then
                '    deleteRow(hi, False)
                'Else
                '    deleteRow(hi, True)
                'End If
                If dataTable.Rows.Count > 0 Then
                    Dim repz As Integer
                    repz = MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                    If repz = vbYes Then
                        dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
                        'dataTable.Rows.RemoveAt(hi.Row)
                        DgEntry.CurrentCell = New DataGridCell(hi.Row, 1)
                        DgEntry.Focus()
                        txtAllBarcode.Focus()
                        'If dataTable.Rows.Count >= 1 And Me.txtAllBarcode.Text <> "" Then
                        'End If
                        Button3.Enabled = True
                    Else
                        Exit Sub
                    End If
                    'End If
                    Call deleyt()
                   
                End If
            End If
        Catch ex As Exception
            MsgBox("Form1/dgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function deleteData(ByVal hi As DataGrid.HitTestInfo) As Boolean
        Try
            Dim cm As New SqlClient.SqlCommand
            Dim ls_sql As String

            If btnDelete.Text = "DELETE" Then
                deleteData = True
            Else
                deleteData = False
            End If

        Catch ex As Exception
            deleteData = False
            MsgBox("Form1/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub callnew()
        Try

            txtAllBarcode = New TextBox
            txtDesc = New TextBox
            txtPrice = New TextBox
            txtCPrice = New TextBox
            txtGrams = New TextBox
            txtKarat = New TextBox

            txtCarat = New TextBox
            pbPicture = New PictureBox
            txtSocialNo = New TextBox
            txtModelNo = New TextBox
            lblphoto = New Label
            lblCurrency = New Label
            btnDelete = New Button


        Catch ex As Exception
            MsgBox("Form1/callnew: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub addrow()
        Try

            Dim a, b, c As Integer


            a = Now.Month.MaxValue
            b = Now.Month.MinValue
            'ConnectDB()
            'ds_dataset.Reset()


            Dim li_row As Integer = dataTable.Rows.Count

            Dim gotoAddrow As String

            If dataTable.Rows.Count = 0 Then
                btnSave.Enabled = False
                'Button3.Enabled = False

gotoaddrow:

                dataTable.LoadDataRow(arrstr, True)

                DgEntry(li_row, 0) = li_row + 1
                DgEntry(li_row, 1) = ""
                DgEntry(li_row, 2) = ""
                DgEntry(li_row, 3) = ""
                DgEntry(li_row, 4) = "" 'Str(li_row)
                DgEntry(li_row, 5) = ""
                DgEntry(li_row, 6) = ""
                DgEntry(li_row, 7) = ""
                DgEntry(li_row, 8) = "" 'Str(li_row)
                DgEntry(li_row, 9) = ""
                DgEntry(li_row, 10) = ""
                DgEntry(li_row, 11) = ""
                DgEntry(li_row, 12) = ""
                DgEntry(li_row, 13) = "DELETE"
                callnew()

                '/-text box maker
                txtAllBarcode.Width = 150
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtAllBarcode)

                txtAllBarcode.BringToFront()

                txtDesc.Width = 350
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtDesc)
                txtDesc.CharacterCasing = CharacterCasing.Upper
                txtDesc.BringToFront()

                txtPrice.Width = 100
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtPrice)
                txtPrice.BringToFront()
                txtPrice.TextAlign = HorizontalAlignment.Right

                txtCPrice.Width = 100
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtCPrice)
                txtCPrice.BringToFront()
                txtCPrice.TextAlign = HorizontalAlignment.Right

                txtGrams.Width = 50
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtGrams)
                txtGrams.BringToFront()
                txtGrams.TextAlign = HorizontalAlignment.Right

                txtKarat.Width = 50
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtKarat)
                txtKarat.BringToFront()
                txtKarat.TextAlign = HorizontalAlignment.Right

                txtCarat.Width = 50
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtCarat)
                txtCarat.BringToFront()
                txtCarat.TextAlign = HorizontalAlignment.Right

                pbPicture.Width = 50
                pbPicture.Height = 17
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(pbPicture)
                pbPicture.BringToFront()

                txtSocialNo.Width = 100
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(9), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtSocialNo)
                txtSocialNo.BringToFront()

                txtModelNo.Width = 100
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(10), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtModelNo)
                txtModelNo.BringToFront()

                lblphoto.Width = 0
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(11), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(lblphoto)
                lblphoto.BringToFront()

                lblCurrency.Width = 0
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(12), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(lblCurrency)
                lblCurrency.BringToFront()

                btnDelete.Width = 100
                btnDelete.Text = "DELETE"
                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(13), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(btnDelete)
                btnDelete.BringToFront()



                DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                DgEntry.Focus()
                txtAllBarcode.Focus()
            ElseIf txtAllBarcode.Text <> "" Then
                If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "" Then
                    Exit Sub
                End If
                btnSave.Enabled = True
                GoTo gotoaddrow
            Else
                DgEntry.CurrentCell = New DataGridCell(li_row, 1)
                DgEntry.Focus()
                txtAllBarcode.Focus()
            End If

        Catch ex As Exception
            MsgBox("Form1/addrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function UploadFile(ByVal FileName As String, ByVal allbarcode As String) As Long
        Try
            If (Not File.Exists(FileName)) Then
                Return -1
            End If

            Dim fs As FileStream = Nothing

            '#Region "Reading file"

            fs = New FileStream(FileName, FileMode.Open)

            '
            ' Finding out the size of the file to be uploaded
            '
            Dim fi As FileInfo = New FileInfo(FileName)
            Dim temp As Long = fi.Length
            Dim lung As Integer = Convert.ToInt32(temp)
            ' ------------------------------------------

            '
            ' Reading the content of the file into an array of bytes.
            '
            Dim picture As Byte() = New Byte(lung - 1) {}
            fs.Read(picture, 0, lung)
            fs.Close()
            ' ------------------------------------------
            '#End Region
            Dim result As Long = uploadFileToDatabase(picture, fi.Name, allbarcode)

            Return result
        Catch e As Exception
            Console.WriteLine(e.Message & "	- " & e.StackTrace)
            Return -1
        End Try
    End Function

    Private Function Connectionstring() As String
        Try

            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath
            Dim Constr3, sDatasource1, sDatabase1, sPassword1, sUsername1 As String
            Try
                Dim sr As StreamReader = New StreamReader(sPath + "\REMS.INI")
                Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1, Key_Photo As String



                Key_Server1 = "[Server]="
                Key_DataBase1 = "[DataBase]="
                Key_User1 = "[User]="
                Key_Pass1 = "[Password]="
                Key_Photo = "[Photo]="

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
                        sPassword1 = "ml"
                    End If
                    If line.StartsWith(Key_Photo) Then
                        photodes = Replace(line, Key_Photo, "")
                    End If
                    line = sr.ReadLine()
                End While
                sr.Close()
            Catch Ee As Exception

            End Try
         
            Constr3 = "Data Source = " + sDatasource1 + ";"
            Constr3 = Constr3 + ";Initial Catalog = " + sDatabase1
            Constr3 = Constr3 + ";User ID = " + sUsername1
            Constr3 = Constr3 + ";Password = " + sPassword1
            ConStrs = Constr3

            Return ConStrs
        Catch ex As Exception
            MsgBox("Form1/Connectionstring: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function uploadFileToDatabase(ByVal picture As Byte(), ByVal fileName As String, ByVal allbarcode As String) As Long
        '
        ' Defining the variables required for accesing the database server.
        '
        Try
            Dim conn As SqlConnection = Nothing
            Dim cmd As SqlCommand = Nothing
            Dim kFileName As SqlParameter = Nothing
            'INSTANT VB NOTE: The local variable FileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
            Dim FileName_Renamed As SqlParameter = Nothing
            Dim pic As SqlParameter = Nothing
            ' By default, we assume we have an error. If we succed in uploading the file, we'll change this 
            '  to the unique id of the file
            Dim result As Long = -1

            Try
                '
                ' Connecting to database.
                '
                conn = New SqlConnection(Connectionstring())
                cmd = New SqlCommand("spUploadFile", conn) ' We assume there is a stored procedure called UploadFile
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                ' ----------------------------------------------

                '
                ' Initializing parameters and assigning the values to be sent to the server
                '
                kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.VarChar, 17)
                kFileName.Value = allbarcode
                ' This parameter does not have a size because we do not know what the size is going to be.
                pic = New SqlParameter("@picture", SqlDbType.Image)
                pic.Value = picture

                FileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
                FileName_Renamed.Value = fileName
                ' ----------------------------------------------

                '
                ' Adding the parameters to the database. Remember that the order in which the parameters 
                '  are added is VERY important!
                '
                cmd.Parameters.Add(pic)
                cmd.Parameters.Add(FileName_Renamed)
                cmd.Parameters.Add(kFileName)
                ' ----------------------------------------------

                '
                ' Opening the connection and executing the command.
                '
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                ' ----------------------------------------------

                '
                ' The result is the unique identifier created on the database.
                '
                'result = (long)kFileName.Value;
                result = CLng(kFileName.Value)
                ' ----------------------------------------------

                '
                ' Disposing of the objects so we don't occupy memory.
                '
                conn.Dispose()
                cmd.Dispose()
                ' ----------------------------------------------
            Catch e As Exception
                '
                ' If an error occurs, we report it to the user, with StackTrace for debugging purposes
                Console.WriteLine(e.Message & "	- " & e.StackTrace)
                result = -1
                ' ----------------------------------------------
            End Try
            Return result
        Catch ex As Exception
            MsgBox("Form1/uploadFileToDatabase: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    'Private Function ImageConvert(ByVal Filename As String) As Long
    '    ImageConvert = UploadFile(Filename)

    'End Function

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
            MsgBox("Form1/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim objclass As New clsCommon
            Dim str, sQuery, gl1, gl2, gl3, gl4 As String
            Dim u As Integer
            Dim rply As Integer
            '--Dim ItemCat As String

            '  Dim picfilename As String
            ' Dim ImageBlob As Long

            Try

                If TextBox1.Text = "" Or TextBox2.Text = "" Or cmbCostCenter.Text = "" Then
                    MsgBox("Please select where to consign.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If

                If DgEntry.VisibleRowCount < 1 Then
                    MsgBox("No data to consign.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If

                If Me.DgEntry.VisibleRowCount > 1 Then
                    For u = 1 To dataTable.Rows.Count
                        If Me.DgEntry(u - 1, 1) = "" Then
                            dataTable.Rows.Remove(dataTable.Rows(u - 1))
                        End If
                    Next
                End If
                rply = MsgBox("Are you sure you want to consign this data?", MsgBoxStyle.YesNo, TitleMsgBox)
                If rply = vbYes Then

                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Opentracker2()
                    obj.CreateCom()

                    txtlotno.Text = GetNewLotNumber("CONSIGNMENT", "") 'GenerateLot()
                    lot1234 = txtlotno.Text


                    obj.commandTrack("Update ASYS_Lotno_gen set lotno ='" & lot1234 & "' WHERE BusinessCenter ='CONSIGNMENT'")
                    obj.TrackExecute()

                    obj.commandTrack("insert into ASYS_Consign_Header(lotno,consignee,consigncode,consignname,consigndate) values ('" & Me.txtlotno.Text & "','" & Me.cmbEmployee.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "',getdate())")
                    obj.TrackExecute()

                    gl1 = "  4100001"
                    gl2 = "  5000001"
                    gl3 = "  1030002"
                    gl4 = " 39995"

                    mydata_table()

                    For u = 0 To dataTable.Rows.Count - 1
                        ''If Mid(DgEntry(u, 1), 1, 3) = "300" And Mid(DgEntry(u, 1), 1, 3) = "400" Then
                        ''    ItemCat = "SP"
                        ''Else
                        ''    ItemCat = "JW"
                        ''End If

                        If Consigned_items(con_dataset, DgEntry(u, 1)) = True Then
                            sQuery = "Insert into ASYS_Consign_Detail(lotno,allbarcode,description,price,cost,grams,karat,carat,photoname,currency,serialno,modelno)Values('" & txtlotno.Text & "','" & DgEntry(u, 1) & "','" & DgEntry(u, 2) & "','" & CStr(CDbl(DgEntry(u, 3))) & "','" & CStr(CDbl(DgEntry(u, 4))) & "','" & DgEntry(u, 5) & "','" & DgEntry(u, 6) & "','" & DgEntry(u, 7) & "','" & DgEntry(u, 11) & "','" & DgEntry(u, 12) & "','" & DgEntry(u, 9) & "','" & DgEntry(u, 10) & "')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()


                            sQuery = "update [264].dbo.items set description ='" & DgEntry(u, 2) & "',type ='S',assortment ='" & Mid(DgEntry(u, 1), 1, 3) & "',class_10 ='JW',"
                            sQuery = sQuery + "IsSalesItem =1,IsPurchaseItem =1,IsstockItem =1,warehouse =1,costpricecurrency ='" & Trim(DgEntry(u, 12)) & "',costpricestandard =" & CStr(CDbl(DgEntry(u, 4))) & ""
                            sQuery = sQuery + ",userdate_05 =getdate(),usernumber_01 =" & CDbl(DgEntry(u, 5)) & ",usernumber_02 =" & CDbl(DgEntry(u, 6)) & ",usernumber_03 =" & CDbl(DgEntry(u, 7)) & ""
                            sQuery = sQuery + ",usernumber_04 =0,usernumber_05 =0,itemtype ='V',searchcode ='" & Mid(DgEntry(u, 1), 1, 13) & "',aant_verp =1,salespackageprice =" & CStr(CDbl(DgEntry(u, 3))) & ""
                            sQuery = sQuery + ",salesvatcode ='INC',packagedescription ='pc/s',serialbatchitem ='G',statisticalunits =0,Netweight =0,Grossweight =0,salesmarginpercent =0,condition ='A',lev_crdnr ='" & gl4 & "',"
                            sQuery = sQuery + "description_0 ='" & DgEntry(u, 2) & "',glaccountrevenue ='" & gl1 & "',glaccountcost ='" & gl2 & "',glaccountdistribution ='" & gl3 & "',statisticalfactorsales =1,"
                            sQuery = sQuery + "statisticalfactorpurchase =1 where itemcode = '" & DgEntry(u, 1) & "'"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "update [264].DBO.ITEMACCOUNTS set "
                            sQuery = sQuery + "crdnr='" & gl4 & "',MAINACCOUNT=1,ITEMCODEACCOUNT='" & DgEntry(u, 1) & "',PURCHASECURRENCY='" & DgEntry(u, 12) & "',"
                            sQuery = sQuery + "PURCHASEPRICE=" & CStr(CDbl(DgEntry(u, 4))) & ",PurchaseVATCode=0,PurchaseVATPerc=0,PurchaseVATIncl=0,pURCHASEPACKAGE='pc/s',"
                            sQuery = sQuery + "PurchaseUnitToInternalUnitFactor =1,PurchaseUnitToPurchasePackageFactor =1,PurchaseOrderSize =1,DiscountMargin=0,SalesPriceRecommended=0,"
                            sQuery = sQuery + "SlsPkgsPerPurPkg=1,DeliveryTimeInDays=0,DeliverableFromStock=0 where ITEMCODE='" & DgEntry(u, 1) & "'"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "update [264].dbo.itemcountries set "
                            sQuery = sQuery + "description='" & DgEntry(u, 2) & "',availablefrom='" & txtDate.Text & "'"
                            sQuery = sQuery + " where itemcode='" & DgEntry(u, 1) & "'"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "update [264].dbo.staffl set "
                            sQuery = sQuery + "prijslijst='SALESPRICE',kort_pbn='N',prijs83='" & CStr(CDbl(DgEntry(u, 3))) & "',unitcode='pc/s',validfrom='" & txtDate.Text & "'"
                            sQuery = sQuery + "where artcode='" & DgEntry(u, 1) & "'"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "update [264].DBO.voorrd set magcode = '1'"
                            sQuery = sQuery + " where artcode ='" & DgEntry(u, 1) & "'"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            obj.commandTrack("Update ASYS_Distri_detail set status='CONSIGNED' where refallbarcode='" & Me.DgEntry(u, 1) & "' and status = 'RECEIVED'")
                            obj.TrackExecute()

                            sQuery = "Insert into ASYS_BarcodeHistory (Lotno,refallbarcode,allbarcode,itemcode,description,karat,carat,weight,currency,price,cost,empname,trandate,costcenter,consignto,status) values ('" & txtlotno.Text & "','" & DgEntry(u, 1) & "','" & DgEntry(u, 1) & "','" & Mid(DgEntry(u, 1), 1, 3) & "','" & DgEntry(u, 2) & "','" & DgEntry(u, 6) & "','" & DgEntry(u, 7) & "','" & DgEntry(u, 5) & "','" & DgEntry(u, 12) & "','" & CStr(CDbl(DgEntry(u, 3))) & "','" & CStr(CDbl(DgEntry(u, 4))) & "','" & userLog & "',getdate(),'DISTRI','" & TextBox2.Text & "','CONSIGNED')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                        Else

                            sQuery = "insert into [264].dbo.items(itemcode,description,type,assortment"
                            sQuery = sQuery + ",class_10,IsSalesItem,IsPurchaseItem,"
                            sQuery = sQuery + "IsstockItem,"
                            sQuery = sQuery + "warehouse,costpricecurrency,"
                            sQuery = sQuery + "costpricestandard,"
                            sQuery = sQuery + "userdate_05,"
                            sQuery = sQuery + "usernumber_01,usernumber_02,usernumber_03,usernumber_04,usernumber_05,"
                            sQuery = sQuery + "itemtype,"
                            sQuery = sQuery + "searchcode,aant_verp,salespackageprice,salesvatcode,packagedescription,"
                            sQuery = sQuery + "serialbatchitem,statisticalunits,Netweight,Grossweight,salesmarginpercent,"
                            sQuery = sQuery + "condition,"
                            sQuery = sQuery + "lev_crdnr,description_0,glaccountrevenue,"
                            sQuery = sQuery + "glaccountcost,glaccountdistribution,"
                            sQuery = sQuery + "statisticalfactorsales,statisticalfactorpurchase)values"
                            sQuery = sQuery + "('" & DgEntry(u, 1) & "','" & DgEntry(u, 2) & "','S',"
                            sQuery = sQuery + "'" & Mid(DgEntry(u, 1), 1, 3) & "','JW',1,1,1,1,"
                            sQuery = sQuery + "'" & Trim(DgEntry(u, 12)) & "'," & CStr(CDbl(DgEntry(u, 4))) & ",getdate(),"
                            sQuery = sQuery + "" & CDbl(DgEntry(u, 5)) & "," & CDbl(DgEntry(u, 6)) & ","
                            sQuery = sQuery + "" & CDbl(DgEntry(u, 7)) & ",0,0,'V',"
                            sQuery = sQuery + "'" & Mid(DgEntry(u, 1), 1, 13) & "',1," & CStr(CDbl(DgEntry(u, 3))) & ""
                            sQuery = sQuery + ",'INC','pc/s','G',0,0,0,0,'A','" & gl4 & "'"
                            sQuery = sQuery + ",'" & DgEntry(u, 2) & "','" & gl1 & "','" & gl2 & "','" & gl3 & "',1,1)"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()


                            ' picfilename = DgEntry(u, 1) & ".JPG"

                            sQuery = "INSERT INTO [264].DBO.ITEMACCOUNTS(ITEMCODE,AccountCode,crdnr,MAINACCOUNT,ITEMCODEACCOUNT,PURCHASECURRENCY,"
                            sQuery = sQuery + "PURCHASEPRICE,PurchaseVATCode,PurchaseVATPerc,PurchaseVATIncl,pURCHASEPACKAGE,"
                            sQuery = sQuery + "PurchaseUnitToInternalUnitFactor,PurchaseUnitToPurchasePackageFactor,"
                            sQuery = sQuery + "PurchaseOrderSize,DiscountMargin,SalesPriceRecommended,"
                            sQuery = sQuery + "SlsPkgsPerPurPkg,DeliveryTimeInDays,DeliverableFromStock)"
                            sQuery = sQuery + "VALUES('" & DgEntry(u, 1) & "','{CD667286-93B4-45C5-8D1C-EF787C686976}',"
                            sQuery = sQuery + "'" & gl4 & "',1,'" & DgEntry(u, 1) & "','" & DgEntry(u, 12) & "'," & CStr(CDbl(DgEntry(u, 4))) & ","
                            sQuery = sQuery + "0,0,0,'pc/s',1,1,1,0,0,1,0,0)"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "Insert into [264].dbo.itemcountries(ID,itemcode,description,availablefrom)values(NEWID(),'" & DgEntry(u, 1) & "','" & DgEntry(u, 2) & "','" & txtDate.Text & "')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "Insert into [264].dbo.staffl(prijslijst,artcode,kort_pbn,prijs83,unitcode,validfrom)values('SALESPRICE','" & DgEntry(u, 1) & "','N','" & CStr(CDbl(DgEntry(u, 3))) & "','pc/s','" & txtDate.Text & "')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "INSERT INTO [264].DBO.voorrd(magcode,artcode)values('1','" & DgEntry(u, 1) & "')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            sQuery = "Insert into ASYS_Consign_Detail(lotno,allbarcode,description,price,cost,grams,karat,carat,photoname,currency,serialno,modelno)Values('" & txtlotno.Text & "','" & DgEntry(u, 1) & "','" & DgEntry(u, 2) & "','" & CStr(CDbl(DgEntry(u, 3))) & "','" & CStr(CDbl(DgEntry(u, 4))) & "','" & DgEntry(u, 5) & "','" & DgEntry(u, 6) & "','" & DgEntry(u, 7) & "','" & DgEntry(u, 11) & "','" & DgEntry(u, 12) & "','" & DgEntry(u, 9) & "','" & DgEntry(u, 10) & "')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()

                            obj.commandTrack("Update ASYS_Distri_detail set status='CONSIGNED' where refallbarcode='" & Me.DgEntry(u, 1) & "' and status = 'RECEIVED'")
                            obj.TrackExecute()

                            sQuery = "Insert into ASYS_BarcodeHistory (Lotno,refallbarcode,allbarcode,itemcode,description,karat,carat,weight,currency,price,cost,empname,trandate,costcenter,consignto,status) values ('" & txtlotno.Text & "','" & DgEntry(u, 1) & "','" & DgEntry(u, 1) & "','" & Mid(DgEntry(u, 1), 1, 3) & "','" & DgEntry(u, 2) & "','" & DgEntry(u, 6) & "','" & DgEntry(u, 7) & "','" & DgEntry(u, 5) & "','" & DgEntry(u, 12) & "','" & CStr(CDbl(DgEntry(u, 3))) & "','" & CStr(CDbl(DgEntry(u, 4))) & "','" & userLog & "',getdate(),'DISTRI','" & TextBox2.Text & "','CONSIGNED')"
                            obj.commandTrack(sQuery)
                            obj.TrackExecute()
                        End If

                    Next


                    obj.CommitTrack()

                    For u = 0 To dataTable.Rows.Count - 1
                        Call UploadFile(photodes & "\" & DgEntry(u, 1) & ".JPG", DgEntry(u, 1))
                    Next

                    MsgBox("CONSIGNED SUCCESSFULLY.", MsgBoxStyle.Information, TitleMsgBox)
                    dataTable.Rows.Clear()
                    btnSave.Enabled = False
                    txtlotno.Text = txtlotno.Text 'GetNewLotNumber("CONSIGNMENT", "") - 1 'GenerateLot()
                    'txtlotno.Text = ""
                    'TextBox1.Text = ""
                    'TextBox2.Text = ""
                    Button3.Enabled = False
                    cmbCostCenter.Items.Clear()
                    cmbCostCenter.Items.Add("SHOWROOM")
                    cmbCostCenter.Items.Add("VIP")
                    Label9.Text = 0
                    Label11.Text = 0
                Else
                    MsgBox("CONSIGNMENT HAS BEEN CANCELLED", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If

            Catch ex As Exception
                obj.RollBackTrack()
                MsgBox("Form1/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            Finally
                obj.Close()
            End Try
        Catch ex As Exception
            MsgBox("Form1/btnSave_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim repz As Integer
            repz = MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If repz = vbYes Then
                dataTable.Rows.Remove(dataTable.Rows(DgEntry.CurrentCell.RowNumber))
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Form1/btnDelete_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub emp()
        Try


            Dim sQuery As String = "select  fullname,usr_id,blocked from " & humres2 & " where job_title like 'ALLBOS%' and blocked =0"
            'Dim squery2 As String = "select * from tbl_consignment"
            Dim jpoy As New clsCommon
            Dim rdr As SqlClient.SqlDataReader
            Dim name As String

            jpoy.ConnDb()
            jpoy.Open5()
            jpoy.Command5(sQuery)
            rdr = jpoy.OpenDataReader5
            While rdr.Read
                name = Trim(rdr.Item("fullname"))
                cmbEmployee.Items.Add(UCase(name))
            End While
            rdr.Close()
            jpoy.Close5()
        Catch ex As Exception
            MsgBox("Form1/emp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub costcenter()
        Try


            Dim jpoy As New clsConnection
            Dim rdr As SqlClient.SqlDataReader
            Dim squery As String = "select * from tbl_costcenter where costdept in('SHOWROOM','VIP')"
            If Not jpoy.Connection Then Exit Sub
            If Not jpoy.DR(squery, rdr) Then Exit Sub

            While rdr.Read
                cmbCostCenter.Items.Add(Trim(rdr.Item("costdept").ToString))
            End While
        Catch ex As Exception
            MsgBox("Form1/costcenter: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnConsignment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsignment.Click
        Try
            
            Dim con As New frmConsignRpt
            Dim month2 As Integer
            Dim year2 As Integer

            div1 = TextBox1.Text
            month2 = Month(Me.txtDate.Text)
            month1 = CStr(month2)
            year2 = Year((Me.txtDate.Text))
            year1 = CStr(year2)
            lot1234 = txtlotno.Text
            TextBox1.Text = TextBox1.Text
            TextBox2.Text = TextBox2.Text
            con.Label1.Text = Label6.Text
            con.Label2.Text = Label7.Text
            con.TextBox1.Text = TextBox1.Text
            con.TextBox2.Text = TextBox2.Text
            con.TextBox3.Text = lot1234 'txtlotno.Text
            con.ShowDialog()
            'con.TopMost = True


        Catch ex As Exception
            MsgBox("Form1/btnConsignment_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function GenerateLot() As String
        Try


            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String

            objclass.Connectionstring3()
            objclass.Open3()

            objclass.Command3("Select lotno from ASYS_LOTNO_gen")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            'objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
            MsgBox("Form1/GenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub txtAllBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllBarcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If txtAllBarcode.Text.Length > 16 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            Dim a As Integer
            Dim status As String
            If e.KeyChar = ChrW(13) Then
                If txtAllBarcode.Text = "" Or txtAllBarcode.Text.Length <> 17 Then
                    MsgBox("Please enter correct ALLBarcode.", MsgBoxStyle.Information, TitleMsgBox)
                    txtAllBarcode.Focus()
                Else
                    Dim obj As New clsCommon
                    Dim obj1 As New clsCommon
                    Dim dr1 As SqlDataReader
                    Dim dr As SqlDataReader
                    Dim str As String
                    obj1 = New clsCommon
                    obj1.Connectionstring4()
                    obj1.Open4()
                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "select refallbarcode,price_desc,price_KARAT,price_CARAT,price_WeighT,all_cost,all_price,currency,serialno,photoname,status from ASYS_Distri_detail where refallbarcode = '" & txtAllBarcode.Text & "' and status = 'RECEIVED'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        status = Trim(obj.IsNull(dr.Item("status")))
                        If dataTable.Rows.Count > 1 Then
                            For a = 0 To dataTable.Rows.Count - 1
                                If DgEntry(a, 1) = txtAllBarcode.Text Then
                                    MsgBox("You have entered the same barcode.", MsgBoxStyle.Information, TitleMsgBox)
                                    txtAllBarcode.Text = ""

                                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                                    DgEntry.Focus()

                                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                                    txtAllBarcode.Focus()
                                    Exit For
                                Else
                                    If a = dataTable.Rows.Count - 1 Then
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 1) = txtAllBarcode.Text
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 2) = obj.IsNull(dr.Item("price_desc"))
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Format(obj.IsNull(dr.Item("all_price")), "standard")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 4) = Format(obj.IsNull(dr.Item("all_cost")), "standard")
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = FormatNumber(obj.IsNull(dr.Item("price_weight")), 1)
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = obj.IsNull(dr.Item("price_karat"))
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 7) = obj.IsNull(dr.Item("price_carat"))
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 9) = obj.IsNull(dr.Item("serialno"))
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 11) = obj.IsNull(dr.Item("photoname"))
                                        DgEntry(DgEntry.CurrentCell.RowNumber, 12) = obj.IsNull(dr.Item("currency"))

                                        addrow()

                                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 0)
                                        DgEntry.Focus()
                                        Exit For
                                    End If
                                End If
                            Next
                        Else
                            DgEntry(DgEntry.CurrentCell.RowNumber, 1) = txtAllBarcode.Text
                            DgEntry(DgEntry.CurrentCell.RowNumber, 2) = obj.IsNull(dr.Item("price_desc"))
                            DgEntry(DgEntry.CurrentCell.RowNumber, 3) = Format(obj.IsNull(dr.Item("all_price")), "standard")
                            DgEntry(DgEntry.CurrentCell.RowNumber, 4) = Format(obj.IsNull(dr.Item("all_cost")), "standard")
                            DgEntry(DgEntry.CurrentCell.RowNumber, 5) = FormatNumber(obj.IsNull(dr.Item("price_weight")), 1)
                            DgEntry(DgEntry.CurrentCell.RowNumber, 6) = obj.IsNull(dr.Item("price_karat"))
                            DgEntry(DgEntry.CurrentCell.RowNumber, 7) = obj.IsNull(dr.Item("price_carat"))
                            DgEntry(DgEntry.CurrentCell.RowNumber, 9) = obj.IsNull(dr.Item("serialno"))
                            DgEntry(DgEntry.CurrentCell.RowNumber, 11) = obj.IsNull(dr.Item("photoname"))
                            DgEntry(DgEntry.CurrentCell.RowNumber, 12) = obj.IsNull(dr.Item("currency"))

                            addrow()

                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentRowIndex, 0)
                            DgEntry.Focus()
                        End If
                        Call deleyt()
                    Else
                        MsgBox("ALLBarcode doesn't exist or already consigned.", MsgBoxStyle.Information, TitleMsgBox)
                        txtAllBarcode.Text = ""
                        txtAllBarcode.Focus()
                    End If
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                End If
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                DgEntry.Focus()
                txtAllBarcode.Focus()
            End If
            If Label9.Text = 0 Then
                Me.Button4.Enabled = False
                Me.btnSave.Enabled = False
            Else
                Me.Button4.Enabled = True
                Me.btnSave.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Form1/txtAllBarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCostCenter.SelectedIndexChanged
        Try
            If Me.cmbCostCenter.Text = "SHOWROOM" Then
                Label6.Text = "BRANCH CODE"
                Label7.Text = "BRANCH NAME"
                TextBox1.ReadOnly = False
                TextBox2.ReadOnly = False
                TextBox2.Focus()
                Button1.Enabled = True
                Button3.Enabled = True
                TextBox1.Text = ""
                TextBox2.Text = ""
                whatto = True
            Else
                Label6.Text = "CUSTOMER ID"
                Label7.Text = "CUSTOMER NAME"
                TextBox1.ReadOnly = False
                TextBox2.ReadOnly = False
                TextBox2.Focus()
                Button1.Enabled = True
                Button3.Enabled = False
                TextBox1.Text = ""
                TextBox2.Text = ""
                whatto = False
            End If
            showvip = cmbCostCenter.Text
            Button1.Focus()
        Catch ex As Exception
            MsgBox("Form1/cmbCostCenter_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                If cmbCostCenter.Text = "SHOWROOM" Then
                    Me.Cursor = Cursors.WaitCursor
                    objclass = New clsCommon
                    objclass.ConnDb()
                    objclass.Open5()
                    If sDB = "" Then
                        objclass.Command5("Select * from " & bedryf2 & " where bedrnr='" + TextBox1.Text.Trim + "'")
                    End If

                    dr = objclass.OpenDataReader5
                    If dr.Read Then
                        TextBox2.Text = Trim(dr.Item("bedrnm"))
                        addrow()
                        Button3.Enabled = True
                        txtAllBarcode.Focus()
                        btnBOSUpload.Enabled = True
                    Else
                        MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Focus()
                    End If
                    dr.Close()
                    objclass.Close5()
                    objclass = Nothing
                    Me.Cursor = Cursors.Arrow

                Else
                    Dim obj As New clsCommon

                    obj = New clsCommon
                    obj.ConnDb()
                    obj.Open5()
                    obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo where customerid like '" & TextBox1.Text & "%' order by customerfname")
                    dr = obj.OpenDataReader5
                    While dr.Read
                        TextBox1.Text = Trim(dr.Item("CustomerID"))
                        TextBox2.Text = Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname"))
                        addrow()
                        Button3.Enabled = True
                        txtAllBarcode.Focus()
                        btnBOSUpload.Enabled = True
                    End While
                    dr.Close()
                    obj.Execute5()
                    obj.Close5()
                End If
            End If
        Catch ex As Exception
            MsgBox("Form1/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try

            If e.KeyChar = ChrW(13) Then
                If UCase(cmbCostCenter.Text) = "SHOWROOM" Then
                    Dim dr As SqlDataReader
                    Dim str As String

                    objclass = New clsCommon
                    objclass.ConnDb()
                    objclass.Open5()

                    str = "Select top 1 * from " & bedryf2 & " where bedrnm like '%" + TextBox2.Text.Trim + "%'"
                    objclass.Command5(str)
                    dr = objclass.OpenDataReader5
                    If dr.Read Then
                        TextBox1.Text = Trim(dr.Item("bedrnr"))
                        TextBox2.Text = Trim(dr.Item("bedrnm"))
                        addrow()
                        txtAllBarcode.Focus()
                    Else
                        MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Focus()
                    End If
                    dr.Close()
                    'objclass.CloseDataReader()
                    objclass.Close5()
                    objclass = Nothing
                Else
                    addrow()
                    txtAllBarcode.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Form1/TextBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBOSUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBOSUpload.Click
        Try
            Dim frm As New frmCreateXML
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            frm.TextBox2.Text = Me.TextBox1.Text
            frm.TextBox3.Text = Trim(Me.TextBox2.Text)
            frm.TextBox4.Text = Me.txtlotno.Text
            frm.ShowDialog()
            'Me.Hide()
        Catch ex As Exception
            MsgBox("Form1/btnBOSUpload_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim frm As New frmALL
            frm.WhatDisplay(whatto)
            Me.Hide()
            frm.ShowDialog()


            If TextBox1.Text <> "" And TextBox2.Text <> "" And cmbCostCenter.Text <> "" And cmbEmployee.Text <> "" And txtlotno.Text <> "" Then
                btnBOSUpload.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Form1/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            oo = False
            pao = False
            Me.Close()
        Catch ex As Exception
            MsgBox("Form1/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEmployee.SelectedIndexChanged
        Try
            form1user = cmbEmployee.Text
        Catch ex As Exception
            MsgBox("Form1/cmbEmployee_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtSocialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSocialNo.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                DgEntry(DgEntry.CurrentCell.RowNumber, 9) = txtSocialNo.Text
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 10)
                DgEntry.Focus()
                txtModelNo.Focus()
            End If
        Catch ex As Exception
            MsgBox("Form1/txtSocialNo_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtModelNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtModelNo.KeyPress
        Try

            If e.KeyChar = ChrW(13) Then
                DgEntry(DgEntry.CurrentCell.RowNumber, 10) = txtModelNo.Text
                DgEntry.CurrentCell = New DataGridCell(dataTable.Rows.Count, 1)
                DgEntry.Focus()
                txtAllBarcode.Focus()
            End If

        Catch ex As Exception
            MsgBox("Form1/txtModelNo_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            addrow()
            txtAllBarcode.Focus()
        Catch ex As Exception
            MsgBox("Form1/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim rply As Integer
            Dim u, s, tempa As Integer

            rply = MsgBox("Are you sure you want to delete " & DgEntry(DgEntry.CurrentCell.RowNumber, 1) & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then
                dataTable.Rows.RemoveAt(DgEntry.CurrentCell.RowNumber)
            Else
                Exit Sub
            End If

            Label9.Text = dataTable.Rows.Count

            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            DgEntry.Focus()

        Catch ex As Exception
            MsgBox("Form1/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try
            Label9.Text = dataTable.Rows.Count - 1

            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 0
                    lblNoItems.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0)
                    Exit Select
                Case 1
                    txtAllBarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1)
                    Exit Select
                Case 2
                    txtDesc.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2)
                    Exit Select
                Case 3
                    txtPrice.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 3)
                    Exit Select
                Case 4
                    txtCPrice.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 4)
                    Exit Select
                Case 5
                    txtGrams.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 5)
                    Exit Select
                Case 6
                    txtKarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 6)
                    Exit Select
                Case 7
                    txtCarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 7)
                    Exit Select
                Case 8
                    pbPicture.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 8)
                    Exit Select
                Case 9
                    txtSocialNo.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 9)
                    Exit Select
                Case 10
                    txtModelNo.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 10)
                    Exit Select

            End Select

        Catch ex As Exception
        End Try
    End Sub

    Public Function rowcount()
        Try
            Label9.Text = dataTable.Rows.Count
        Catch ex As Exception
        End Try
    End Function

    Public Function deleyt()
        Try
            Dim x, y, z As Integer
            If Me.DgEntry.VisibleRowCount Then
                For x = 0 To dataTable.Rows.Count - 1
                    If DgEntry(x, 3) <> "" Then
                        y = DgEntry(x, 3)
                        z = z + y
                    End If
                Next
            End If
            Me.Label11.Text = Format(z, "standard")
            Call rowcount()

        Catch ex As Exception
            MsgBox("Form1/deleyt: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("Form1/NextPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("Form1/isPrime: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            MsgBox("Form1/decryptPass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub btnNewLot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            txtlotno.Text = GetNewLotNumber("CONSIGNMENT", "")
            'Call GenerateLot()
        Catch ex As Exception
            MsgBox("Form1/btnNewLot_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlotno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlotno.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Form1/txtlotno_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmbCostCenter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCostCenter.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Form1/cmbCostCenter_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If FlagDistriClose = True Then
                Me.Show()
                Me.TopMost = True
                FlagDistriClose = False
                Exit Sub
            End If
            oo = False
            pao = False
            Me.Dispose()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtAllBarcode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAllBarcode.Click
        Try
            txtAllBarcode.Enabled = True
            txtAllBarcode.Focus()
        Catch ex As Exception
            MsgBox("Form1/txtAllBarcode_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frm As New frmSearchLotno
            'frm.ShowVIP = cmbCostCenter.Text
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgEntry.Navigate

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
