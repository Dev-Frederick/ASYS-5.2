Imports System.Data.SqlClient

Public Class frmPTQuery
    Inherits System.Windows.Forms.Form
#Region " private declarations "

    'Private s_PTN, sPTNBarcode As String()
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private iFocus As Integer
    Private sDivision As String

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
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPTQuery))
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
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
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtbranchname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(568, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 23)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "PTN BARCODE"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(336, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "PTN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(656, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox2.TabIndex = 23
        Me.ComboBox2.Text = "ComboBox2"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(424, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(88, 120)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(712, 112)
        Me.ListView2.TabIndex = 38
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "                                ACTION"
        Me.ColumnHeader9.Width = 237
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "                        DATE"
        Me.ColumnHeader10.Width = 182
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "                                 USER NAME"
        Me.ColumnHeader11.Width = 292
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label49)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(792, 168)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TRANSACTION DETAILS"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(672, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 44
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(528, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "PRICE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(104, 131)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(144, 23)
        Me.Label49.TabIndex = 42
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(104, 107)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(144, 23)
        Me.Label48.TabIndex = 41
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(392, 131)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(136, 23)
        Me.Label47.TabIndex = 40
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(392, 107)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(136, 23)
        Me.Label46.TabIndex = 39
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(672, 107)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(104, 23)
        Me.Label45.TabIndex = 38
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(264, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "DATE LOAN GRANTED"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(528, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 23)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "TOTAL APPRAISED VALUE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(264, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 23)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "LOAN VALUE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 23)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "MATURITY DATE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "EXPIRY DATE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(16, 24)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(765, 76)
        Me.ListView1.TabIndex = 6
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM CODE"
        Me.ColumnHeader1.Width = 77
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                  ITEM DESCRIPTION"
        Me.ColumnHeader2.Width = 214
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY    "
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 57
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "KARAT  "
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 57
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CARAT   "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 66
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SORTING CLASS"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 99
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "WEIGHT  "
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 70
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "APPRAISED VALUE  "
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 124
        '
        'TextBox28
        '
        Me.TextBox28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox28.Location = New System.Drawing.Point(424, 40)
        Me.TextBox28.MaxLength = 12
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(118, 20)
        Me.TextBox28.TabIndex = 2
        Me.TextBox28.Text = ""
        '
        'TextBox29
        '
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(656, 40)
        Me.TextBox29.MaxLength = 15
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(112, 20)
        Me.TextBox29.TabIndex = 3
        Me.TextBox29.Text = ""
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(640, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(720, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "PTN STATUS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 23)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "RECEIVING"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 74
        Me.Label20.Text = "SORTING"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 75
        Me.Label21.Text = "RELEASING"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(424, 66)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(184, 23)
        Me.Label51.TabIndex = 107
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(304, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 108
        Me.PictureBox3.TabStop = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(336, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 23)
        Me.Label18.TabIndex = 109
        Me.Label18.Text = "BRANCH CODE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(424, 16)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(64, 20)
        Me.txtBranchCode.TabIndex = 0
        Me.txtBranchCode.Text = ""
        '
        'txtbranchname
        '
        Me.txtbranchname.BackColor = System.Drawing.Color.White
        Me.txtbranchname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchname.Location = New System.Drawing.Point(496, 16)
        Me.txtbranchname.Name = "txtbranchname"
        Me.txtbranchname.ReadOnly = True
        Me.txtbranchname.Size = New System.Drawing.Size(184, 20)
        Me.txtbranchname.TabIndex = 110
        Me.txtbranchname.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(16, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "COSTING"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPTQuery
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(824, 468)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbranchname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox29)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPTQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAWN TICKET QUERY"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " private sub "
    'retrieves ptn information from tbl_pt_tran and tbl_ptn_item
    Private Sub RetrieveInfo(ByVal sPTN As String, ByVal iSet As Integer)
        Dim dr As SqlDataReader
        Dim sMPTN As String
        Dim iExist, SForced As Integer
        Dim iStatus, sStatus, sort_code, sdate, msg, squery, sQuery1, squery2, str As String
        Dim iCellular, iWatch As Integer
        Dim bRelease As Boolean
        Dim Release As String
        Dim PullOut As Integer
        Dim Flag_Received As Integer = 0
        Dim transtype As String
        Dim ptstatus As Integer
        Try
            PullOut = 0
            iCellular = 3
            iWatch = 8

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime

            objclass.ConnectionString1()
            objclass.Open()

            Label51.Text = ""
            If iSet = 1 Then
                objclass.Command("select rtrim(status) as status, sortcode, actionclass from asys_rem_detail  where ptn ='" + sPTN + "'")
            Else
                objclass.Command("select rtrim(status) as status, sortcode, actionclass from asys_rem_detail  where ptn ='" + sPTN + "' ")
            End If

            dr = objclass.OpenDataReader
            If dr.Read Then
                If IsDBNull(dr.Item("status")) Then
                    iExist = 0
                Else
                    iExist = 1
                    iStatus = CStr(dr.Item("status"))
                    If iStatus = "RECEIVED" Then
                        sStatus = "PTN received"
                    ElseIf iStatus = "SORTED" Then
                        sStatus = "PTN sorted"
                        If "Cellular" = CStr(dr.Item("actionclass")) Or "Watch" = CStr(dr.Item("actionclass")) Then
                            sort_code = ""
                        Else
                            sort_code = Trim(dr.Item("sortcode"))
                        End If
                    ElseIf iStatus = "RELEASED" Then
                        sStatus = "PTN released"
                        sort_code = Trim(dr.Item("sortcode"))
                    ElseIf iStatus = "COSTED" Then
                        sStatus = "PTN sorted and costed"
                    ElseIf iStatus = "RECMLWB" Then
                        sStatus = "PTN received by MLWB"
                    End If
                End If
                Flag_Received = 1
            End If
            dr.Close()
            objclass.Execute()

            squery = "select asys_REM_header.branchcode as division, asys_REM_header.loanvalue, isnull(asys_REM_detail.appraisevalue,0) as totalappraisevalue from asys_REM_header  inner join asys_REM_detail on asys_rem_header.ptn = asys_REM_detail.ptn where asys_rem_header.ptn= '" & sPTN & "' "
            objclass.Command(squery)
            dr = objclass.OpenDataReader()
            If dr.Read Then
                sDivision = objclass.IsNull(dr.Item("division"))
                Label46.Text = FormatNumber(dr.Item("LoanValue"))
                Label45.Text = FormatNumber(dr.Item("TotalAppraiseValue"))
            End If
            dr.Close()
            objclass.Execute()

            squery2 = "select asys_REM_header.branchcode as division, asys_REM_header.ptnbarcode, asys_REM_detail.appraisevalue as appraisevalue, asys_REM_header.loanvalue as loanvalue, asys_REM_header.loandate, asys_REM_header.maturitydate, asys_REM_header.expirydate from asys_REM_header  inner join asys_REM_detail on asys_REM_header.ptn = asys_REM_detail.ptn where asys_REM_header.ptn = '" + sPTN + "'"
            objclass.Command(squery2)
            dr = objclass.OpenDataReader()
            If dr.Read Then
                sDivision = Trim(dr.Item("Division"))
                TextBox29.Text = dr.Item("ptnbarcode")
                'Label47.Text = Trim(CStr(objclass.IsNull(dr.Item("loandate"))))
                Call stringdate_loan()
                Call stringdate_maturity()
                Call stringdate_expiry()

                If iSet = 1 Then
                    TextBox29.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                Else
                    TextBox28.Text = Trim(dr.Item("ptn"))
                End If
                odatetime = Nothing
            Else
                MsgBox("PTN item not found", MsgBoxStyle.Information, "ASYS 3.0")
                objclass.Close()
                returnfocus1()
                Exit Sub
            End If
            dr.Close()
            objclass.Execute()

            objclass.Command("Select asys_REM_detail.refitemcode as itemcode, asys_REM_detail.branchitemdesc as itemdesc, asys_REM_detail.refqty as quantity, asys_REM_detail.karatgrading as karat, asys_REM_detail.caratsize as carat, asys_REM_detail.actionclass as sortclass, asys_REM_detail.weight as weight, asys_REM_detail.appraisevalue as appraisevalue, asys_REM_detail.all_price as all_price from asys_REM_header  inner join asys_REM_detail  on asys_REM_header.ptn = asys_REM_detail.ptn where asys_REM_detail.ptn = '" + sPTN + "'")
            dr = objclass.OpenDataReader()
            ListView1.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("ItemCode")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(UCase(dr.Item("itemdesc")))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Karat"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Carat"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(UCase(dr.Item("SortClass")))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("AppraiseValue"))))
                Label3.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))
            End While
            dr.Close()
            objclass.Execute()

            ListView2.Items.Clear()
            If (iExist > 0) And (iStatus = "RECEIVED" Or iStatus = "SORTED" Or iStatus = "COSTED" Or iStatus = "RELEASED" Or iStatus = "RECMLWB") Then

                str = " select asys_REM_detail.receivedate as receivedate,"
                str = str + " asys_REM_detail.actionclass as recactionid, "
                str = str + "      asys_REM_detail.receiver as recname, asys_REM_detail.sortername as recsortername,"
                str = str + "      asys_REM_detail.sortdate as sortdate, asys_REM_detail.costdate as costdate, "
                str = str + " asys_REM_detail.costname as costname, asys_REM_detail.releasedate as releasedate,"
                str = str + "  asys_REM_detail.releaser as releaser "
                str = str + "     from  asys_REM_detail  "
                str = str + "     where       asys_REM_detail.ptn = '" & sPTN & "'"
                objclass.Command(str)
                dr = objclass.OpenDataReader
                If dr.Read Then
                    ListView2.Items.Add("JEWELRY")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receivedate"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(UCase(dr.Item("recName")))))
                End If
                dr.Close()
                objclass.Execute()

                objclass.Command(str)
                dr = objclass.OpenDataReader()
                If dr.Read Then
                    If IsDBNull(dr.Item("sortdate")) Then
                        bRelease = False
                    Else
                        ListView2.Items.Add(objclass.IsNull(UCase(dr.Item("recactionid"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortdate"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((UCase(dr.Item("recSorterName")))))
                    End If
                End If
                dr.Close()
                objclass.Execute()

                objclass.Command(str)
                dr = objclass.OpenDataReader()
                If dr.Read Then
                    If IsDBNull(dr.Item("costdate")) Then
                        bRelease = False
                        ListView2.Items.Add("")
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                    Else
                        ListView2.Items.Add(objclass.IsNull(UCase(dr.Item("recactionid"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("costdate"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((UCase(dr.Item("costname")))))
                    End If
                End If
                dr.Close()
                objclass.Execute()

                objclass.Command(str)
                dr = objclass.OpenDataReader()
                If dr.Read Then
                    If IsDBNull(dr.Item("releaser")) Then
                        bRelease = False
                    Else
                        ListView2.Items.Add(objclass.IsNull(UCase(dr.Item("recactionid"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("releasedate")))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((UCase(dr.Item("releaser")))))
                    End If
                End If
                dr.Close()
                objclass.Execute()

                'objclass.Command(str)
                'dr = objclass.OpenDataReader()
                'If dr.Read Then
                '    If IsDBNull(dr.Item("recReleasingName")) Then
                '        bRelease = False
                '    Else
                '        bRelease = True
                '        sdate = dr.Item("releasedate")
                '        Release = dr.Item("recReleasingName")
                '    End If
                'End If
                'dr.Close()
                'objclass.Execute()

                If bRelease = True Then
                    objclass.Command("select action_type from tbl_action where action_type = 'RELEASE'")
                    dr = objclass.OpenDataReader()
                    If dr.Read Then
                        ListView2.Items.Add(Trim(UCase(dr.Item("action_type"))))
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(sdate)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(UCase(Release))
                    End If
                End If
                dr.Close()
                objclass.Execute()

                objclass.Command("select description from tbl_sortclass where code = '" + sort_code + "'")
                dr = objclass.OpenDataReader()
                If dr.Read Then
                    ListView2.Items(1).Text = ListView2.Items(1).Text + " \ " + Trim((UCase(dr.Item("description"))))
                End If
                dr.Close()
                objclass.Execute()
                objclass.Close()

                Label51.Text = UCase(sStatus)
                If iFocus = 15 Then
                    TextBox28.Focus()
                ElseIf iFocus = 16 Then
                    TextBox29.Focus()
                End If
                iFocus = 0

                'ElseIf iExist > 0 And (iStatus >= "RECEIVED" Or iStatus <= "RELEASED") Then
                '    objclass.Connectionstring3()
                '    objclass.Open3()
                '    'objclass.Command3("SELECT dbo.tbl_RecRel_MLWB_Dtail.Action_ID_DRec, dbo.tbl_action.action_type, dbo.tbl_RecRel_MLWB.DateReceived_MLWB,  dbo.tbl_RecRel_MLWB.EmpName_Rec FROM  dbo.tbl_action INNER JOIN dbo.tbl_RecRel_MLWB_Dtail ON dbo.tbl_action.action_id = dbo.tbl_RecRel_MLWB_Dtail.Action_ID_DRec INNER JOIN dbo.tbl_RecRel_MLWB ON dbo.tbl_RecRel_MLWB_Dtail.PTN_DRec = dbo.tbl_RecRel_MLWB.PTN_Rec where dbo.tbl_RecRel_MLWB.PTN_Rec = " + TextBox28.Text)
                '    objclass.Command3("SELECT rems.dbo.asys_MLWB_detail.actionclass as actionclass, rems.dbo.asys_MLWB_header.receivedate as receivedate, rems.dbo.asys_MLWB_header.receiver as receiver FROM  rems.dbo.asys_MLWB_header INNER JOIN rems.dbo.asys_MLWB_detail ON rems.dbo.asys_MLWB_header.lotno = rems.dbo.asys_MLWB_detail.lotno where rems.dbo.asys_MLWB_detail.ptn = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receivedate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receiver"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()

                '    'objclass.Command3("SELECT dbo.tbl_action.action_type, dbo.tbl_Receiving_Header.sortdate,dbo.tbl_Receiving_Header.recSorterName, dbo.tbl_RecRel_MLWB.LOTNO_Rec FROM dbo.tbl_RecRel_MLWB INNER JOIN dbo.tbl_Receiving_Header ON dbo.tbl_RecRel_MLWB.PTN_Rec = dbo.tbl_Receiving_Header.recPTN INNER JOIN dbo.tbl_action ON dbo.tbl_Receiving_Header.recActionID = dbo.tbl_action.action_id where dbo.tbl_RecRel_MLWB.PTN_Rec = " + TextBox28.Text)
                '    objclass.Command3("SELECT dbo.asys_REM_detail.sortdate, dbo.asys_REM_detail.actionclass, asys_REM_detail.SorterName, rems.dbo.asys_MLWB_detail.LOTNO FROM rems.dbo.asys_MLWB_detail, dbo.asys_REM_header, dbo.asys_REM_detail where dbo.asys_REM_header.ptn = dbo.asys_REM_detail.ptn and dbo.asys_REM_detail.ptn = rems.dbo.asys_MLWB_detail.ptn and rems.dbo.asys_MLWB_detail.PTN = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortdate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("SorterName"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()

                '    objclass.Command3("SELECT dbo.asys_REM_detail.costdate, dbo.asys_REM_detail.actionclass, asys_REM_detail.costname, rems.dbo.asys_MLWB_detail.LOTNO FROM rems.dbo.asys_MLWB_detail, dbo.asys_REM_header, dbo.asys_REM_detail where dbo.asys_REM_header.ptn = dbo.asys_REM_detail.ptn and dbo.asys_REM_detail.ptn = rems.dbo.asys_MLWB_detail.ptn and rems.dbo.asys_MLWB_detail.PTN = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        If IsDBNull(dr.Item("costdate")) Then
                '            bRelease = False
                '        Else
                '            ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("costdate"))))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("costname"))))
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()

                '    'objclass.Command3("SELECT dbo.tbl_action.action_type, dbo.tbl_RecRel_MLWB_Dtail.Action_ID_DRec, dbo.tbl_RecRel_MLWB.DateReleased_MLWB, dbo.tbl_RecRel_MLWB.EmpName_Rel fROM dbo.tbl_RecRel_MLWB_Dtail INNER JOIN dbo.tbl_RecRel_MLWB ON dbo.tbl_RecRel_MLWB_Dtail.PTN_DRec = dbo.tbl_RecRel_MLWB.PTN_Rec INNER JOIN dbo.tbl_action ON dbo.tbl_RecRel_MLWB_Dtail.Action_ID_DRec = dbo.tbl_action.action_id where dbo.tbl_RecRel_MLWB.PTN_Rec  = " + TextBox28.Text)
                '    objclass.Command3("SELECT rems.dbo.asys_MLWB_Detail.Actionclass, rems.dbo.asys_MLWB_detail.releasedate, rems.dbo.asys_MLWB_detail.releaser fROM rems.dbo.asys_MLWB_header INNER JOIN rems.dbo.asys_MLWB_detail ON rems.dbo.asys_MLWB_header.lotno = rems.dbo.asys_MLWB_detail.lotno where rems.dbo.asys_MLWB_detail.ptn  = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        If IsDBNull(dr.Item("releasedate")) Then
                '            bRelease = False
                '        Else
                '            ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("releasedate"))))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("releaser"))))
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    'If dr.Read Then
                '    '    If IsDBNull(dr.Item("releasedate")) Then
                '    '        bRelease = False
                '    '    Else
                '    '        bRelease = True
                '    '        sdate = dr.Item("releasedate")
                '    '        Release = dr.Item("releaser")
                '    '    End If
                '    'End If
                '    'dr.Close()
                '    'objclass.Execute3()

                '    If bRelease = True Then
                '        objclass.Command3("select action_type from tbl_action where action_type = 'RELEASED'")
                '        dr = objclass.OpenDataReader3()
                '        If dr.Read Then
                '            ListView2.Items.Add(Trim(dr.Item("action_type")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(sdate)
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Release)
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("select description from tbl_sortclass where code = '" + sort_code + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items(1).Text = ListView2.Items(1).Text + " \ " + Trim((dr.Item("description")))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    Label51.Text = sStatus
                '    If iFocus = 15 Then
                '        TextBox28.Focus()
                '    ElseIf iFocus = 16 Then
                '        TextBox29.Focus()
                '    End If
                '    iFocus = 0
                'ElseIf iExist > 0 And (iStatus = "RECEIVED" And iStatus = "RELEASED") Then
                '    'objclass.Open()
                '    objclass.Command3("SELECT rems.dbo.asys_PRICING_detail.actionclass, rems.dbo.asys_PRICING_header.receivedate, rems.dbo.asys_PRICING_header.receiver FROM rems.dbo.asys_PRICING_header INNER JOIN rems.dbo.asys_PRICING_detail on rems.dbo.asys_PRICING_header.lotno = rems.dbo.asys_PRICING_detail.lotno where rems.dbo.asys_PRICING_detail.PTN = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receivedate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receiver"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    'objclass.Command3("SELECT dbo.tbl_action.action_type, dbo.tbl_Receiving_Header.sortdate,dbo.tbl_Receiving_Header.recSorterName, dbo.tbl_RecRel_MLWB.LOTNO_Rec FROM dbo.tbl_RecRel_MLWB INNER JOIN dbo.tbl_Receiving_Header ON dbo.tbl_RecRel_MLWB.PTN_Rec = dbo.tbl_Receiving_Header.recPTN INNER JOIN dbo.tbl_action ON dbo.tbl_Receiving_Header.recActionID = dbo.tbl_action.action_id where dbo.tbl_RecRel_MLWB.PTN_Rec = " + TextBox28.Text)
                '    objclass.Command3("SELECT dbo.asys_REM_detail.sortdate, dbo.asys_REM_detail.SorterName, rems.dbo.asys_MLWB_detail.LOTNO FROM rems.dbo.asys_MLWB_detail, dbo.asys_REM_header, dbo.asys_REM_detail where dbo.asys_REM_header.ptn = dbo.asys_REM_detail.PTN and dbo.asys_REM_detail.ptn = rems.dbo.asys_MLWB_detail.ptn and rems.dbo.asys_MLWB_detail.ptn = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortdate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortername"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("SELECT rems.dbo.asys_PRICING_detail.actionclass, rems.dbo.asys_PRICING_detail.releasedate, rems.dbo.asys_PRICING_header.releaser fROM rems.dbo.asys_PRICING_header INNER JOIN rems.dbo.asys_PRICING_detail ON rems.dbo.asys_PRICING_header.lotno = rems.dbo.asys_PRICING_detail.lotno where rems.dbo.asys_PRICING_detail.PTN = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        If IsDBNull(dr.Item("releasedate")) Then
                '            bRelease = False
                '        Else
                '            bRelease = True
                '            sdate = dr.Item("releasedate")
                '            Release = dr.Item("releaser")
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    If bRelease = True Then
                '        objclass.Command3("select action_type from tbl_action where action_id = 'RELEASED'")
                '        dr = objclass.OpenDataReader3()
                '        If dr.Read Then
                '            ListView2.Items.Add(Trim(dr.Item("action_type")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(sdate)
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Release)
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("select description from tbl_sortclass where code = '" + sort_code + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items(1).Text = ListView2.Items(1).Text + " \ " + Trim((dr.Item("description")))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    Label51.Text = sStatus
                '    If iFocus = 15 Then
                '        TextBox28.Focus()
                '    ElseIf iFocus = 16 Then
                '        TextBox29.Focus()
                '    End If
                '    iFocus = 0
                'ElseIf iExist > 0 And (iStatus = "RECEIVED" And iStatus = "CONSIGNED" And iStatus = "RELEASED") Then
                '    'objclass.Open()
                '    objclass.Command3("SELECT rems.dbo.asys_DISTRI_detail.actionclass, rems.dbo.asys_DISTRI_header.receivedate, rems.dbo.asys_DISTRI_header.receiver FROM rems.dbo.asys_DISTRI_header INNER JOIN rems.dbo.asys_DISTRI_detail on rems.dbo.asys_DISTRI_header.lotno = rems.dbo.asys_DISTRI_detail.lotno where rems.dbo.asys_DISTRI_detail.ptn = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receivedate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receiver"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    'objclass.Command3("SELECT dbo.tbl_action.action_type, dbo.tbl_Receiving_Header.sortdate,dbo.tbl_Receiving_Header.recSorterName, dbo.tbl_RecRel_MLWB.LOTNO_Rec FROM dbo.tbl_RecRel_MLWB INNER JOIN dbo.tbl_Receiving_Header ON dbo.tbl_RecRel_MLWB.PTN_Rec = dbo.tbl_Receiving_Header.recPTN INNER JOIN dbo.tbl_action ON dbo.tbl_Receiving_Header.recActionID = dbo.tbl_action.action_id where dbo.tbl_RecRel_MLWB.PTN_Rec = " + TextBox28.Text)
                '    objclass.Command3("SELECT dbo.asys_REM_detail.sortdate, dbo.asys_REM_detail.SorterName, rems.dbo.asys_MLWB_detail.lotno FROM dbo.asys_REM_header, dbo.asys_REM_detail, rems.dbo.asys_MLWB_detail where dbo.asys_REM_header.ptn = dbo.asys_REM_detail.ptn and dbo.asys_REM_detail.ptn = rems.dbo.asys_MLWB_detail.ptn and rems.dbo.asys_MLWB_detail.ptn = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortdate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("SorterName"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("SELECT rems.dbo.asys_DISTRI_detail.actionclass, rems.dbo.asys_DISTRI_detail.releasedate, rems.dbo.asys_DISTRI_detail.releaser fROM rems.dbo.asys_DISTRI_detail where rems.dbo.asys_DISTRI_detail.PTN  = '" + TextBox28.Text + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        If IsDBNull(dr.Item("releasedate")) Then
                '            bRelease = False
                '        Else
                '            bRelease = True
                '            sdate = dr.Item("releasedate")
                '            Release = dr.Item("releaser")
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    If bRelease = True Then
                '        objclass.Command3("select action_type from tbl_action where action_type = 'RELEASED'")
                '        dr = objclass.OpenDataReader3()
                '        If dr.Read Then
                '            ListView2.Items.Add(Trim(dr.Item("action_type")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(sdate)
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Release)
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("select description from tbl_sortclass where code = '" + sort_code + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items(1).Text = ListView2.Items(1).Text + " \ " + Trim((dr.Item("description")))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    Label51.Text = sStatus
                '    If iFocus = 15 Then
                '        TextBox28.Focus()
                '    ElseIf iFocus = 16 Then
                '        TextBox29.Focus()
                '    End If
                '    iFocus = 0
                'ElseIf iExist > 0 And iStatus = "PARTIALLUKAT" Then
                '    str = "select distinct ptn, receivedate, actionclass, receiver, sortername, releaser, sortdate, costdate, releasedate from ( select * from (	select dbo.asys_REM_detail.ptn, dbo.asys_REM_header.receivedate, dbo.asys_REM_detail.actionclass, dbo.asys_REM_header.receiver, dbo.asys_REM_detail.sortername, dbo.asys_REM_detail.releaser, dbo.asys_REM_detail.sortdate, dbo.asys_REM_detail.costdate, dbo.asys_REM_detail.releasedate from dbo.asys_REM_header inner join dbo.asys_REM_detail on dbo.asys_REM_header.ptn = dbo.asys_REM_detail.ptn	union all select dbo.asys_remoutsource_detail.ptn, dbo.asys_remoutsource_header.receivedate, dbo.asys_remoutsource_detail.actionclass, dbo.asys_remoutsource_header.receiver, dbo.asys_remoutsource_detail.sortername, dbo.asys_remoutsource_detail.releaser, dbo.asys_remoutsource_detail.sortdate,	dbo.asys_remoutsource_detail.costdate, dbo.asys_remoutsource_detail.releasedate	from dbo.asys_remoutsource_header inner join dbo.asys_remoutsource_detail on	dbo.asys_remoutsource_header.lotno = dbo.asys_remoutsource_detail.lotno )k )q where ptn = '" & sPTN & "'"
                '    objclass.Command3(str)
                '    dr = objclass.OpenDataReader3
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receivedate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull(CStr(dr.Item("receiver"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3(str)
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items.Add(objclass.IsNull(dr.Item("actionclass")))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("sortdate"))))
                '        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(objclass.IsNull((dr.Item("SorterName"))))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3(str)
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        If IsDBNull(dr.Item("releaser")) Then
                '            bRelease = False
                '        Else
                '            bRelease = True
                '            sdate = dr.Item("releasedate")
                '            Release = dr.Item("releaser")
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()

                '    If bRelease = True Then
                '        objclass.Command3("select action_type from tbl_action where action_type = 'partiallukat'")
                '        dr = objclass.OpenDataReader3()
                '        If dr.Read Then
                '            ListView2.Items.Add(Trim(dr.Item("action_type")))
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(sdate)
                '            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Release)
                '        End If
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    objclass.Command3("select description from tbl_sortclass where code = '" + sort_code + "'")
                '    dr = objclass.OpenDataReader3()
                '    If dr.Read Then
                '        ListView2.Items(1).Text = ListView2.Items(1).Text + " \ " + Trim((dr.Item("description")))
                '    End If
                '    dr.Close()
                '    objclass.Execute3()
                '    objclass.Close3()

                '    Label51.Text = sStatus
                '    If iFocus = 15 Then
                '        TextBox28.Focus()
                '    ElseIf iFocus = 16 Then
                '        TextBox29.Focus()
                '    End If
                '    iFocus = 0
            Else
                If Flag_Received = 0 Then
                    If ptstatus = 0 Then
                        Label51.Text = "PTN is open"
                    ElseIf PullOut = 1 Then
                        Label51.Text = "PTN not yet received"
                    Else
                        Label51.Text = transtype.Trim
                    End If
                Else
                    If PullOut = 0 Then
                        Label51.Text = "PTN not yet pulled out"
                    End If
                End If
            End If

            'If CDbl(Label45.Text) < CDbl(Label46.Text) Then
            '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical, "ASYS 3.0")
            'End If
            iExist = Nothing
            objclass = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'returns to the last focus textbox
    Private Sub returnfocus()
        If iFocus = 15 Then
            TextBox28.Focus()
        ElseIf iFocus = 16 Then
            TextBox29.Focus()
        End If
        iFocus = 0
    End Sub
    'returns to the last focus of textbox and clears the content
    Private Sub returnfocus1()
        If iFocus = 15 Then
            TextBox28.Text = ""
            TextBox28.Focus()
        ElseIf iFocus = 16 Then
            TextBox29.Text = ""
            TextBox29.Focus()
        End If
        iFocus = 0
    End Sub
    'clears all text information
    Private Sub Clear()
        txtBranchCode.Text = ""
        TextBox28.Text = ""
        TextBox29.Text = ""
        Label45.Text = ""
        Label46.Text = ""
        Label47.Text = ""
        Label48.Text = ""
        Label49.Text = ""
        Label51.Text = ""
        Me.txtbranchname.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.SelectedText = ""
        ComboBox2.SelectedText = ""
        ListView1.Items.Clear()
        ListView2.Items.Clear()
    End Sub
    'retrieves ptn and ptn barcode 
    Private Sub RetrievePTN_Barcode()
        Dim dr As SqlDataReader
        Dim sptn, sptn_barcode As String
        Dim PTNStr As String
        Dim Ctr As Integer

        objclass = New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select distinct ptn, ptnbarcode from asys_rem_header where branchcode = '" + txtBranchCode.Text + "' order by ptn, ptnbarcode")
        dr = objclass.OpenDataReader()
        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        While dr.Read
            sptn = CStr(objclass.IsNull(Trim(dr.Item("ptn")))) '.ToString.PadLeft(12, "0")
            sptn_barcode = CStr(objclass.IsNull(dr.Item("ptnbarcode")))
            If Not (sptn Is "") Then
                ComboBox1.Items.Add(sptn)
            End If
            If Not (sptn_barcode Is "") Then
                ComboBox2.Items.Add(sptn_barcode)
            End If
            TextBox28.Focus()
        End While
        dr.Close()
        objclass.Close()
        objclass = Nothing
    End Sub
#End Region
#Region " control attributes "
    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        iFocus = 15
        TextBox28.Text = ComboBox1.SelectedItem
        RetrieveInfo(CStr(TextBox28.Text), 1)
        TextBox28.Focus()
    End Sub
    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        iFocus = 16
        TextBox29.Text = ComboBox2.SelectedItem
        RetrieveInfo(CStr(TextBox29.Text), 2)
        TextBox29.Focus()
    End Sub
    Private Sub TextBox29_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If TextBox29.Text = "" Then
                MsgBox("Select PTN barcode", MsgBoxStyle.Information, "ASYS 3.0")
                TextBox29.Text = ""
                TextBox29.Focus()
            ElseIf IsNumeric(TextBox29.Text) Then
                iFocus = 16
                RetrieveInfo(CStr(TextBox29.Text), 2)
            Else
                MsgBox("Enter numeric", MsgBoxStyle.Information, "ASYS 3.0")
                TextBox29.Text = ""
                TextBox29.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox28_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox28.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If TextBox28.TextLength = 12 Then
                If TextBox28.Text = "" Then
                    MsgBox("Select PTN", MsgBoxStyle.Information, "ASYS 3.0")
                    TextBox28.Text = ""
                    TextBox28.Focus()
                ElseIf IsNumeric(TextBox28.Text) Then
                    iFocus = 15
                    RetrieveInfo(CStr(TextBox28.Text), 1)
                    Dim x As String
                    x = Trim(Mid(TextBox28.Text, 1, 3))
                    txtBranchCode.Text = x
                    Call branch(x)
                Else
                    MsgBox("Enter numeric", MsgBoxStyle.Information, "ASYS 3.0")
                    TextBox28.Text = ""
                    TextBox28.Focus()
                End If
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call Clear()
        Me.txtBranchCode.Focus()
    End Sub
#End Region

    Private Sub txtBranchCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim PTNStr As String
            Dim F As Integer

            If e.KeyCode = Keys.Enter Then
                objclass.Connectionstring3()
                objclass.Open3()
                If UCase(sDB) = "LUZON" Then
                    objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text + "'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text + "'")  
                End If
                dr = objclass.OpenDataReader3
                If dr.Read Then
                    txtbranchname.Text = Trim(dr.Item("bedrnm"))
                    F = 1
                    TextBox28.Focus()
                Else
                    MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Clear()
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute3()
                objclass.Close3()
                If F = 1 Then
                    Try
                        Call RetrievePTN_Barcode()
                    Catch ex As Exception
                        MsgBox(ex.message, , TitleMsgBox)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/txtBranchCode_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmPTQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SetDesktopLocation(185, 80)
            Call Clear()
            Me.txtbranchname.ReadOnly = True
            Me.txtbranchname.BackColor = Color.White
            Me.ComboBox2.Enabled = False
            Me.TextBox29.ReadOnly = True
            Me.TextBox29.BackColor = Color.White
        Catch ex As Exception
            MsgBox("frmPTQuery/frmPTQuery_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtbranchname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbranchname.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim f As Integer
            f = 0
            If e.KeyCode = Keys.Enter Then
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                objclass.Command("Select * from rems" & sDB & ".dbo.vw_bedryf" & sDB & " where bedrnm='" + txtbranchname.Text.Trim + "'")
                dr = objclass.OpenDataReader
                If dr.Read Then
                    txtBranchCode.Text = dr.Item("bedrnr")
                    f = 1
                Else
                    MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.CloseDataReader()
                objclass.Close()
                objclass = Nothing
                If f = 1 Then
                    Call RetrievePTN_Barcode()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/txtbranchname_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If Me.txtBranchCode.Text.Length <> 2 And e.KeyChar <> ChrW(13) Then
                Me.txtbranchname.Text = ""
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub stringdate_maturity()
        Try
            Dim mtemp, dtemp, ytemp, squery, smonth, sday, syear, smdy As String
            Dim dr As SqlDataReader
            Dim con As New clsCommon

            con.Connectionstring3()
            con.Open3()
            squery = "If (Select Count(ptn) from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "') <> 0 begin select month(maturitydate) as month, day(maturitydate) as day, year(maturitydate) as year from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "' end else Select month(maturitydate) as month, day(maturitydate) as day, year(maturitydate) as year from asys_remoutsource_detail  where ptn = '" & Me.TextBox28.Text & "'"
            con.Command3(squery)
            dr = con.OpenDataReader3
            If dr.Read Then
                mtemp = dr.Item("month")
                smonth = mtemp
                dtemp = dr.Item("day")
                ytemp = dr.Item("year")
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
                smdy = CStr(smonth + " " + dtemp + "," + " " + ytemp)
                Me.Label48.Text = UCase(smdy)
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/stringdate_maturity: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub stringdate_expiry()
        Try
            Dim mtemp, dtemp, ytemp, squery, smonth, sday, syear, smdy As String
            Dim dr As SqlDataReader
            Dim con As New clsCommon

            con.Connectionstring3()
            con.Open3()
            squery = "If (Select Count(ptn) from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "') <> 0 begin select month(expirydate) as month, day(expirydate) as day, year(expirydate) as year from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "' end else Select month(expirydate) as month, day(expirydate) as day, year(expirydate) as year from asys_remoutsource_detail  where ptn = '" & Me.TextBox28.Text & "'"
            con.Command3(squery)
            dr = con.OpenDataReader3
            If dr.Read Then
                mtemp = dr.Item("month")
                smonth = mtemp
                dtemp = dr.Item("day")
                ytemp = dr.Item("year")
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
                smdy = CStr(smonth + " " + dtemp + "," + " " + ytemp)
                Me.Label49.Text = UCase(smdy)
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/stringdate_expiry: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub stringdate_loan()
        Try
            Dim mtemp, dtemp, ytemp, squery, smonth, sday, syear, smdy As String
            Dim dr As SqlDataReader
            Dim con As New clsCommon

            con.Connectionstring3()
            con.Open3()
            squery = "If (Select Count(ptn) from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "') <> 0 begin select month(loandate) as month, day(loandate) as day, year(loandate) as year from asys_REM_header  where ptn = '" & Me.TextBox28.Text & "' end else Select month(loandate) as month, day(loandate) as day, year(loandate) as year from asys_remoutsource_detail  where ptn = '" & Me.TextBox28.Text & "'"
            con.Command3(squery)
            dr = con.OpenDataReader3
            If dr.Read Then
                mtemp = dr.Item("month")
                smonth = mtemp
                dtemp = dr.Item("day")
                ytemp = dr.Item("year")
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
                smdy = CStr(smonth + " " + dtemp + "," + " " + ytemp)
                Me.Label47.Text = UCase(smdy)
            End If
        Catch ex As Exception
            MsgBox("frmPTQuery/stringdate_loan: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function branch(ByVal x As Object)
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim PTNStr As String
            Dim F As Integer

            objclass.Connectionstring3()
            objclass.Open3()
            If UCase(sDB) = "LUZON" Then
                objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + x + "'")
            ElseIf UCase(sDB) = "VISMIN" Then
                objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + x + "'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + x + "'")
            ElseIf UCase(sDB) = "MINDANAO" Then
                objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + x + "'")
            ElseIf UCase(sDB) = "LNCR" Then
                objclass.Command3("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + x + "'")
            End If
            dr = objclass.OpenDataReader3
            If dr.Read Then
                txtbranchname.Text = Trim(dr.Item("bedrnm"))
                F = 1
            Else
                MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Clear()
                txtBranchCode.Focus()
            End If
            If F = 1 Then
                Try
                    Call RetrievePTN_Barcode()
                Catch ex As Exception
                    MsgBox(ex.message, , TitleMsgBox)
                End Try
            End If
            dr.Close()
            objclass.Execute3()
            objclass.Close3()
        Catch ex As Exception
            MsgBox("frmPTQuery/branch: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged

    End Sub
End Class



