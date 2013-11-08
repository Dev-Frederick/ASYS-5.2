Imports System.Data.SqlClient
Imports System.IO
Public Class frmBarcodeQuery
    Inherits System.Windows.Forms.Form
    Public objcommon As clsCommon
    Public arrstr() As String
    Dim picStr As String
    Dim loc1 As String = Application.StartupPath


#Region " private declarations "
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private sUserID, sAction, sSortClass As String()
    Private iDataEntry, iFocus, iAction_id As Integer
    Private sDivision As String
    Private dCostA, dCostB, dCostC, dCostD As Double
    Private iRecord As Integer
    Private isedit As Integer = 0
    Private nonNumberEntered As Boolean = False
    Private ctr As Integer
    Private allkarat As String
    Private allwt As String
    Private allcarat As String
    Private allvaluecost As String
    Private dCost1, dCost2, dCost3, dCost4, dCost5 As Double
    Private mountcost As String
    Private ygcost As String
    Private wgcost As String
    Private repaircost As String
    Private cleaningcost As String
    Private flag As Boolean = False
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
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cboALL As System.Windows.Forms.ComboBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txteditbarcode As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtserialno As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBarcodeQuery))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.cboALL = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtserialno = New System.Windows.Forms.TextBox
        Me.TextBox30 = New System.Windows.Forms.TextBox
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox32 = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txteditbarcode = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox27 = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.TextBox26 = New System.Windows.Forms.TextBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(56, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(344, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 167
        Me.PictureBox3.TabStop = False
        '
        'cboALL
        '
        Me.cboALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboALL.Location = New System.Drawing.Point(144, 200)
        Me.cboALL.MaxLength = 17
        Me.cboALL.Name = "cboALL"
        Me.cboALL.Size = New System.Drawing.Size(256, 21)
        Me.cboALL.TabIndex = 0
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(24, 206)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 16)
        Me.Label58.TabIndex = 170
        Me.Label58.Text = "A.L.L BARCODE"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbrname
        '
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.Location = New System.Drawing.Point(200, 128)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.Size = New System.Drawing.Size(200, 20)
        Me.txtbrname.TabIndex = 169
        Me.txtbrname.Text = ""
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(144, 128)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 157
        Me.txtBranchCode.Text = ""
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(24, 130)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(104, 23)
        Me.Label56.TabIndex = 168
        Me.Label56.Text = "BRANCH CODE"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button13
        '
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(704, 448)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 40)
        Me.Button13.TabIndex = 166
        Me.Button13.Text = "Save"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button13.Visible = False
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(704, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 159
        Me.Button4.Text = "SAVE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(864, 448)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 161
        Me.Button3.Text = "CLOSE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(784, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 160
        Me.Button2.Text = "CLEAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtserialno)
        Me.GroupBox3.Controls.Add(Me.TextBox30)
        Me.GroupBox3.Controls.Add(Me.TextBox21)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox32)
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 271)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(936, 168)
        Me.GroupBox3.TabIndex = 165
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EDIT"
        '
        'txtserialno
        '
        Me.txtserialno.BackColor = System.Drawing.Color.White
        Me.txtserialno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtserialno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtserialno.Location = New System.Drawing.Point(356, 71)
        Me.txtserialno.MaxLength = 25
        Me.txtserialno.Name = "txtserialno"
        Me.txtserialno.TabIndex = 153
        Me.txtserialno.Text = ""
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.Color.White
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox30.Location = New System.Drawing.Point(772, 71)
        Me.TextBox30.MaxLength = 6
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(153, 13)
        Me.TextBox30.TabIndex = 152
        Me.TextBox30.Text = ""
        Me.TextBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.White
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.Location = New System.Drawing.Point(683, 71)
        Me.TextBox21.MaxLength = 5
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(89, 13)
        Me.TextBox21.TabIndex = 151
        Me.TextBox21.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Location = New System.Drawing.Point(603, 71)
        Me.TextBox12.MaxLength = 5
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(80, 13)
        Me.TextBox12.TabIndex = 150
        Me.TextBox12.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Location = New System.Drawing.Point(523, 71)
        Me.TextBox9.MaxLength = 2
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(80, 13)
        Me.TextBox9.TabIndex = 149
        Me.TextBox9.Text = ""
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(458, 71)
        Me.TextBox4.MaxLength = 1
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(65, 13)
        Me.TextBox4.TabIndex = 148
        Me.TextBox4.Text = ""
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(9, 71)
        Me.TextBox1.MaxLength = 150
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 13)
        Me.TextBox1.TabIndex = 147
        Me.TextBox1.Text = ""
        '
        'TextBox32
        '
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox32.Location = New System.Drawing.Point(760, 115)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.ReadOnly = True
        Me.TextBox32.Size = New System.Drawing.Size(144, 20)
        Me.TextBox32.TabIndex = 61
        Me.TextBox32.Text = ""
        '
        'ListView2
        '
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader6, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Enabled = False
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(8, 51)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(920, 37)
        Me.ListView2.TabIndex = 39
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "A.L.L. DESCRIPTION"
        Me.ColumnHeader12.Width = 347
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SERIAL NO."
        Me.ColumnHeader6.Width = 103
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "A.L.L. QTY"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 65
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "A.L.L. KARAT"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 80
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "A.L.L. CARAT"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 80
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "A.L.L. WEIGHT"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 89
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "A.L.L. COST"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 155
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(520, 115)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(104, 20)
        Me.Label44.TabIndex = 35
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(688, 115)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "A.L.L. PRICE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(440, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "LOAN VALUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(920, 72)
        Me.ListView1.TabIndex = 6
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM ID"
        Me.ColumnHeader1.Width = 58
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM CODE"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "                                            DESCRIPTION"
        Me.ColumnHeader3.Width = 369
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 41
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "KARAT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CARAT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "WEIGHT"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 72
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "COST                        "
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 160
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(144, 152)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox4.TabIndex = 155
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(24, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 23)
        Me.Label19.TabIndex = 163
        Me.Label19.Text = "ACTION"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 23)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "A.L.L SORTING CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(144, 176)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox5.TabIndex = 156
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(528, 456)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 23)
        Me.Label43.TabIndex = 162
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(496, 144)
        Me.GroupBox6.TabIndex = 175
        Me.GroupBox6.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(395, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 20)
        Me.Button1.TabIndex = 172
        Me.Button1.Text = "EDIT"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(136, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(344, 20)
        Me.TextBox2.TabIndex = 171
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "BARCODE STATUS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txteditbarcode
        '
        Me.txteditbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txteditbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteditbarcode.Location = New System.Drawing.Point(144, 202)
        Me.txteditbarcode.MaxLength = 17
        Me.txteditbarcode.Name = "txteditbarcode"
        Me.txteditbarcode.Size = New System.Drawing.Size(256, 20)
        Me.txteditbarcode.TabIndex = 176
        Me.txteditbarcode.Text = ""
        Me.txteditbarcode.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Panel8)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.Controls.Add(Me.Panel6)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Controls.Add(Me.Panel7)
        Me.GroupBox4.Location = New System.Drawing.Point(608, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(334, 256)
        Me.GroupBox4.TabIndex = 177
        Me.GroupBox4.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label30)
        Me.Panel8.Controls.Add(Me.TextBox27)
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(-16, 264)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(280, 40)
        Me.Panel8.TabIndex = 63
        Me.Panel8.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(0, 8)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 23)
        Me.Label30.TabIndex = 10
        Me.Label30.Text = "A.L.L LUKAT Value :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox27
        '
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox27.Location = New System.Drawing.Point(136, 8)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(88, 23)
        Me.TextBox27.TabIndex = 9
        Me.TextBox27.Text = "TextBox27"
        Me.TextBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button18)
        Me.Panel4.Controls.Add(Me.Button19)
        Me.Panel4.Controls.Add(Me.Button20)
        Me.Panel4.Controls.Add(Me.Button21)
        Me.Panel4.Controls.Add(Me.Button22)
        Me.Panel4.Controls.Add(Me.TextBox17)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.TextBox23)
        Me.Panel4.Controls.Add(Me.TextBox24)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 256)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 88)
        Me.Panel4.TabIndex = 62
        Me.Panel4.Visible = False
        '
        'Button18
        '
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Enabled = False
        Me.Button18.Location = New System.Drawing.Point(264, 57)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(48, 23)
        Me.Button18.TabIndex = 25
        Me.Button18.Text = "Clear"
        '
        'Button19
        '
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.Enabled = False
        Me.Button19.Location = New System.Drawing.Point(264, 33)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(48, 23)
        Me.Button19.TabIndex = 24
        Me.Button19.Text = "Clear"
        '
        'Button20
        '
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Enabled = False
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(208, 57)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(56, 23)
        Me.Button20.TabIndex = 23
        Me.Button20.Text = "Cost C"
        '
        'Button21
        '
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.Enabled = False
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(208, 33)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(56, 23)
        Me.Button21.TabIndex = 22
        Me.Button21.Text = "Cost B"
        '
        'Button22
        '
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Enabled = False
        Me.Button22.Location = New System.Drawing.Point(208, 9)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(56, 23)
        Me.Button22.TabIndex = 21
        Me.Button22.Text = "Cost A"
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Location = New System.Drawing.Point(120, 56)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(88, 23)
        Me.TextBox17.TabIndex = 19
        Me.TextBox17.Text = "TextBox17"
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(24, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 23)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "A.L.L. Karat :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(8, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 23)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "A.L.L. Weight :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox23
        '
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Location = New System.Drawing.Point(120, 32)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(88, 23)
        Me.TextBox23.TabIndex = 18
        Me.TextBox23.Text = "TextBox23"
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Location = New System.Drawing.Point(120, 8)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(88, 23)
        Me.TextBox24.TabIndex = 17
        Me.TextBox24.Text = "TextBox24"
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(24, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 23)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "A.L.L Value :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Location = New System.Drawing.Point(88, 88)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(178, 138)
        Me.Panel6.TabIndex = 64
        Me.Panel6.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(176, 136)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button12)
        Me.Panel5.Controls.Add(Me.Button11)
        Me.Panel5.Controls.Add(Me.Button10)
        Me.Panel5.Controls.Add(Me.Button8)
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.Button6)
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.Label53)
        Me.Panel5.Controls.Add(Me.Label52)
        Me.Panel5.Controls.Add(Me.Label51)
        Me.Panel5.Controls.Add(Me.Label50)
        Me.Panel5.Controls.Add(Me.Label49)
        Me.Panel5.Controls.Add(Me.Label26)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(8, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(320, 240)
        Me.Panel5.TabIndex = 61
        Me.Panel5.Visible = False
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(264, 192)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 23)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "CLEAR"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(264, 168)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 23)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "CLEAR"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(264, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(56, 23)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "CLEAR"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(208, 192)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "COST D"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(208, 168)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "COST C"
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(208, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "COST B"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(208, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "COST A"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(128, 216)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 23)
        Me.Label53.TabIndex = 15
        Me.Label53.Text = "Label53"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(128, 192)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(81, 23)
        Me.Label52.TabIndex = 14
        Me.Label52.Text = "Label52"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(128, 168)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 23)
        Me.Label51.TabIndex = 13
        Me.Label51.Text = "Label51"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(128, 144)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 23)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Label50"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(128, 120)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(81, 23)
        Me.Label49.TabIndex = 11
        Me.Label49.Text = "Label49"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 23)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "WG CLEANING COST"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "YG CLEANING COST"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 23)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "MOUNT COST"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 23)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "GOLD COST"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 23)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "A.L.L. VALUE"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(112, 8)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(136, 96)
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.PictureBox4)
        Me.Panel7.Controls.Add(Me.Button14)
        Me.Panel7.Controls.Add(Me.Button15)
        Me.Panel7.Controls.Add(Me.Label54)
        Me.Panel7.Controls.Add(Me.Label31)
        Me.Panel7.Controls.Add(Me.TextBox25)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.TextBox26)
        Me.Panel7.Controls.Add(Me.TextBox29)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(8, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(320, 240)
        Me.Panel7.TabIndex = 65
        Me.Panel7.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(112, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        '
        'Button14
        '
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Enabled = False
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(224, 200)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(56, 24)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "CLEAR"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Enabled = False
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(224, 176)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(56, 24)
        Me.Button15.TabIndex = 19
        Me.Button15.Text = "CLEAR"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(120, 135)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 24)
        Me.Label54.TabIndex = 11
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(16, 208)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 16)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "A.L.L. VLAUE"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(120, 184)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(88, 20)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.Text = ""
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 160)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 16)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "REPAIR COST"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(120, 208)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(88, 20)
        Me.TextBox26.TabIndex = 9
        Me.TextBox26.Text = ""
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(120, 160)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(88, 20)
        Me.TextBox29.TabIndex = 14
        Me.TextBox29.Text = ""
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(16, 184)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 16)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "CLEANING COST"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(16, 136)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 16)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "CELLULAR COST"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmBarcodeQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(950, 502)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.txteditbarcode)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.cboALL)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBarcodeQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Returned Items"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub cboALL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboALL.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/cboALL_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RetrieveInfo(ByVal AllBar As String)
        Try
            Dim dr As SqlDataReader
            Dim sMPTN As String
            Dim iCost_id, iItem_id As Integer
            Dim iRecorded As Integer
            Dim sStatus, sort_code, iStatus, sSort_Code, SPtn As String
            Dim img As Drawing.Image
            Dim obj As New clsCommon
            Dim tmpLotno As String

            ListView1.Items.Clear()
            ListView2.Items.Clear()

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime
            tmpLotno = ""

            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("If (Select Count(refallbarcode) from ASYS_REM_Detail where refALLBarcode='" & Me.cboALL.Text & "' and status not in ('RECMLWB'))<> 0 begin select 1 as st,ptn,photoname as photo,itemID ,costdate as cost_id,actionclass,sortcode, status, reflotno  from ASYS_REM_Detail where  refALLBarcode='" & Me.cboALL.Text & "' and status not in ('RECMLWB') end else select 0 as st,ptn,photoname as photo,itemid ,costdate as cost_id,actionclass,sortcode, status, reflotno from ASYS_REMOutsource_detail where  refALLBarcode='" & Me.cboALL.Text & "' and status not in ('RECMLWB')")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                st = dr.Item("st")
                If IsDBNull(dr.Item("cost_id")) = True Then
                    iRecorded = 0
                Else
                    iRecorded = 1
                    'iCost_id = CInt(dr.Item("cost_id"))
                End If
                iItem_id = dr.Item("itemid")
                iRecord = iRecorded
                picStr = Trim(objclass.IsNull(dr.Item("photo")))
                iStatus = Trim(dr.Item("status"))
                SPtn = Trim(objclass.IsNull(dr.Item("ptn")))
                tmpLotno = Trim(objclass.IsNull(dr.Item("reflotno")))

                If iStatus = "SORTED" Then
                    sStatus = "PTN received and sorted"
                ElseIf iStatus = "RELEASED" Then
                    sStatus = "PTN released"
                    iRecorded = 1
                    MsgBox("Item already released", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                ElseIf iStatus = "COSTED" Then
                    sStatus = "PTN Costed"
                    iRecorded = 1
                ElseIf iStatus = "RECMLWB" Then
                    sStatus = "PTN already received in MLWB"
                    iRecorded = 1
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If

                TextBox1.Enabled = True
                TextBox1.Focus()
                ComboBox4.Text = UCase(dr.Item("actionclass"))
                iAction_id = ComboBox4.SelectedIndex + 1
                sSort_Code = Trim(objclass.IsNull(dr.Item("sortcode")))
                TextBox2.Text = iStatus
            Else
                iStatus = 0
                sStatus = "Item not received"
            End If
            dr.Close()
            objclass.Close3()

            If st = 1 Then
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                'objclass.Command("select * from tbl_pt_tran where ptn = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                obj.Command3("select branchcode,branchname,ptn,ptnbarcode,loanvalue,maturitydate,expirydate,loandate from ASYS_REM_Header where ptn = '" + SPtn + "' and lotno = '" & tmpLotno & "'")
                dr = obj.OpenDataReader3()
                If dr.Read Then
                    txtBranchCode.Text = Trim(dr.Item("branchcode"))
                    txtbrname.Text = Trim(dr.Item("branchname"))

                    Label44.Text = FormatNumber(dr.Item("loanvalue"))
                Else
                    MsgBox("Barcode not found", MsgBoxStyle.Information, TitleMsgBox)
                    obj.Close()
                    Clear()
                    Button1.Enabled = False
                    Button2.Enabled = False
                    Exit Sub
                End If
                dr.Close()
                obj.Close3()
                'objclass.CloseDataReader()
                ListView1.Items.Clear()
                ListView2.Items.Clear()
                objclass.Command3("select itemid,refallbarcode,appraisevalue,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,all_desc,serialno,all_karat,all_carat,all_weight,all_cost,photoname,price_desc,price_karat,price_carat,price_weight,all_price,cellular_cost,watch_cost,repair_cost,cleaning_cost,Gold_cost,mount_cost,yg_cost,wg_cost from ASYS_REM_Detail where refALLBarcode = '" & AllBar & "' and status not in ('RECMLWB')")
                dr = objclass.OpenDataReader3()
                While dr.Read
                    ListView1.Items.Add(Trim(dr.Item("itemid")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("itemcode"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("caratsize"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("weight"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("price_desc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("serialno"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_carat"))))

                    'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_weight"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))
                    TextBox32.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))
                    Label43.Text = FormatNumber(objclass.IsNull(dr.Item("appraisevalue")))
                End While
                dr.Close()
                objclass.Execute3()
                objclass.Close3()
            Else
                'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                objclass.Command3("select itemid,ptn,ptnbarcode,branchcode,branchname,loanvalue,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,all_desc,serialno,all_karat,all_carat,all_weight,all_cost,photoname,price_desc,price_karat,price_carat,price_weight,all_price,appraisevalue,cellular_cost,watch_cost,repair_cost,cleaning_cost,gold_cost,mount_cost,yg_cost,wg_cost,status from ASYS_REMOutsource_detail where refallbarcode='" & Me.cboALL.Text & "' and status not in ('RECMLWB')")
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    picStr = objclass.IsNull(dr.Item("photoname"))
                    sDivision = Trim(objclass.IsNull(dr.Item("branchcode")))
                    Label43.Text = FormatNumber(objclass.IsNull(dr.Item("appraisevalue")))
                    Label44.Text = FormatNumber(objclass.IsNull(dr.Item("loanvalue")))

                    ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("itemid"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("itemcode"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("caratsize"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("weight"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("price_desc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("serialno"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_carat"))))
                    'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_weight"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_cost"))))
                    TextBox32.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))

                    TextBox1.Enabled = True
                    TextBox1.Focus()
                Else
                    MsgBox("Item not found!", MsgBoxStyle.Information, TitleMsgBox)
                    objclass.Close()
                    Clear()
                    Exit Sub
                End If
                dr.Close()
            End If

            objclass.Close3()
            '------------------------FOrce Rcv-------------------'


            If File.Exists(picStr) Then
                img = img.FromFile(picStr)
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img
            Else

                img = img.FromFile(loc1 & "\" & "questionmark2" & ".jpg")
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img
                'MsgBox("Image Don't Exist ", MsgBoxStyle.Information, TitleMsgBox)
                'PictureBox1.Hide()
                'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information, TitleMsgBox)
            End If


            Call List2()

            objclass.ConnDb()
            objclass.Open5()

            If UCase(sDB) = "" Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + sDivision + "'")
                ElseIf UCase(sDB) = "VISAYAS" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + sDivision + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + sDivision + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + sDivision + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + sDivision + "'")

                End If
                ''comment 'dr = objclass.OpenDataReader5
                'objclass.Command5("select bedrnm from " & bedryf2 & " where bedrnr = '" + sDivision + "'")

                'dr = objclass.OpenDataReader5
                If UCase(sDB) = "" Or UCase(sDB) = Nothing Then
                    txtBranchCode.Text = "0"
                    txtbrname.Text = "NONE"
                Else

                    If dr.Read Then
                        txtBranchCode.Text = sDivision
                        txtbrname.Text = Trim(objclass.IsNull(dr.Item("bedrnm")))

                        dr.Close()
                        objclass.Execute5()
                        objclass.Close5()
                    End If
                End If

            End If


            If iRecorded = 1 Then
                DisplayAction(ComboBox4.Text, 1)
                'SelectUser(iCost_id)
                'SelectAction(iAction_id)
                If ComboBox4.Text = "CELLULAR" Then
                    ComboBox5.Text = "OTHERS"
                    ComboBox5.Enabled = False
                ElseIf ComboBox4.Text = "Watch" Then
                    ComboBox5.Text = "OTHERS"
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)

                    'MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                End If
            Else
                If iStatus = "SORTED" Or iStatus = "RECEIVED" Then
                    DisplayAction(ComboBox4.Text, 1)
                    'SelectAction(iAction_id)
                    If ComboBox4.Text = "CELLULAR" Then
                        ComboBox5.Text = "OTHERS"
                        ComboBox5.Enabled = False
                    ElseIf ComboBox4.Text = "WATCH" Then
                        ComboBox5.Text = "OTHERS"
                        ComboBox5.Enabled = False
                    Else
                        SelectClass(sSort_Code)
                    End If
                    'ComboBox3.Enabled = True
                ElseIf iStatus = "RELEASED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECEIVED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "COSTED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECMLWB" Then
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Button13.Enabled = False
                    Button2.Enabled = True
                Else
                    MsgBox(sStatus, MsgBoxStyle.Information, TitleMsgBox)
                    Button13.Enabled = True
                    Button2.Enabled = True
                End If
            End If
            'Button13.Enabled = True
            Button2.Enabled = True
            'If CDbl(Label43.Text) < CDbl(Label44.Text) Then
            '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Information, TitleMsgBox)
            'End If
            TextBox1.Focus()
            iRecorded = Nothing
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmReturnItems/RetrieveInfo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub List2()
        Try
            If ListView2.Items.Count = 1 Then
                Dim g, h, i As Integer
                For g = 0 To ListView2.Items.Count - 1

                    Me.TextBox1.Text = ListView2.Items.Item(g).SubItems.Item(0).Text
                    Me.txtserialno.Text = ListView2.Items.Item(g).SubItems.Item(1).Text
                    Me.TextBox4.Text = ListView2.Items.Item(g).SubItems.Item(2).Text
                    Me.TextBox9.Text = ListView2.Items.Item(g).SubItems.Item(3).Text
                    Me.TextBox12.Text = ListView2.Items.Item(g).SubItems.Item(4).Text
                    Me.TextBox21.Text = ListView2.Items.Item(g).SubItems.Item(5).Text
                    Me.TextBox30.Text = FormatNumber(ListView2.Items.Item(g).SubItems.Item(6).Text)



                    If outsource = False Then
                        Me.TextBox1.Enabled = False
                        Me.txtserialno.Enabled = False
                        Me.TextBox4.Enabled = False
                        Me.TextBox9.Enabled = False
                        Me.TextBox12.Enabled = False
                        Me.TextBox21.Enabled = False
                        Me.TextBox30.Enabled = False
                    Else
                        Me.TextBox1.Enabled = True
                    End If


                    Me.TextBox1.BackColor = Color.White
                    Me.txtserialno.BackColor = Color.White
                    Me.TextBox4.BackColor = Color.White
                    Me.TextBox9.BackColor = Color.White
                    Me.TextBox12.BackColor = Color.White
                    Me.TextBox21.BackColor = Color.White
                    Me.TextBox30.BackColor = Color.White
                Next
            Else
                'Me.TextBox1.Enabled = False
                Me.txtserialno.Enabled = False
                Me.TextBox4.Enabled = False
                Me.TextBox9.Enabled = False
                Me.TextBox12.Enabled = False

                Me.TextBox21.Enabled = False
                Me.TextBox30.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/List2: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DisplayAction(ByVal iselect As String, ByVal iRecorded As Integer)
        Try
            Dim dr As SqlDataReader
            Dim dCost1, dCost2, dCost3, dCost4, dCost5 As Double
            Dim ALLVALUE As Double

            If iselect.ToUpper = "RETURN" And Mid(cboALL.Text, 1, 3) = "300" Then
                iselect = "WATCH"
            ElseIf iselect.ToUpper = "RETURN" And Mid(cboALL.Text, 1, 3) = "400" Then
                iselect = "CELLULAR"
            ElseIf iselect = "OUTSOURCE" Or iselect = "RETURN" Then
                iselect = "GOODSTOCK"
            End If


            Panels(False, False, False, False, False)
            dCostA = Nothing
            dCostB = Nothing
            dCostC = Nothing
            dCostD = Nothing

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select CostA, CostB, CostC, CostD from tbl_action where action_type ='" & iselect & "'")
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                dCostA = CDbl(Trim(dr.Item("CostA")))
                dCostB = CDbl(Trim(dr.Item("CostB")))
                dCostC = CDbl(Trim(dr.Item("CostC")))
                dCostD = CDbl(Trim(dr.Item("CostD")))
            End If
            dr.Close()
            If st = 1 Then
                'If iRecorded = 1 Then
                If iselect.ToUpper = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                    objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost, ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect.ToUpper = "CELLULAR" Then
                    objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect.ToUpper = "WATCH" Then
                    objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'")
                End If
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    If iselect = "OverAppraised" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Wt"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                        dCost3 = Label44.Text
                    ElseIf iselect.ToUpper = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                        dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))

                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    ElseIf iselect = "TakenBack" Then
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    ElseIf iselect.ToUpper = "CELLULAR" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    ElseIf iselect.ToUpper = "WATCH" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    End If
                End If
                dr.Close()
                'End If
                objclass.Close3()

            Else
                'If iRecorded = 1 Then

                If iselect = "OverAppraised" Then
                    objclass.Command3("select ALL_Weight, ALL_Karat,ALL_Cost from ASYS_REMOutsource_detail where  refallbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect.ToUpper = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                    objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost,  ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect = "TakenBack" Then
                    objclass.Command3("select  ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect.ToUpper = "CELLULAR" Then
                    objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "'")
                ElseIf iselect.ToUpper = "WATCH" Then
                    objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "'")
                End If
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    If iselect = "OverAppraised" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Weight"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        ' ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    ElseIf iselect.ToUpper = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                        dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))
                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    ElseIf iselect = "TakenBack" Then
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    ElseIf iselect.ToUpper = "CELLULAR" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    ElseIf iselect.ToUpper = "WATCH" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = Label44.Text
                        End If

                    End If
                End If
                dr.Close()
                'End If
                objclass.Close3()
            End If

            If iselect = "OverAppraised" Then
                Panels(True, False, False, False, False)
                If iRecorded = 1 Then
                    TextBox24.Text = FormatNumber(dCost1)
                    TextBox23.Text = dCost2
                    TextBox17.Text = FormatNumber(dCost3)
                    If prcing = False Then
                        control(False)
                    Else
                        control(True)
                    End If

                Else
                    TextBox24.Text = FormatNumber(0)
                    TextBox23.Text = 0
                    TextBox17.Text = FormatNumber(0)
                    control(True)
                End If
            ElseIf iselect.ToUpper = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                Panels(False, True, False, False, False)
                Button5.Visible = False
                If iRecorded = 1 Then
                    Button5.Visible = True
                    Label49.Text = FormatNumber(dCost1)
                    Label50.Text = FormatNumber(dCost2)
                    Label51.Text = FormatNumber(dCost3)
                    Label52.Text = FormatNumber(dCost4)
                    Label53.Text = FormatNumber(dCost5)
                    'ListView1.Items(ListView1.Items.Count - 1).SubItems.Item(7).Text = Label53.Text
                    If sDB = "" Then
                        Label53.Text = FormatNumber(ALLVALUE)
                    End If

                    If prcing = False Then
                        control(True)
                    Else
                        control(True)
                    End If

                Else
                    Label49.Text = FormatNumber(CDbl(Label44.Text) + (CDbl(Label44.Text) * dCostA))
                    Label50.Text = FormatNumber(0)
                    Label51.Text = FormatNumber(0)
                    Label52.Text = FormatNumber(0)
                    Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
                    'ListView1.Items(ListView1.Items.Count - 1).SubItems.Item(7).Text = Label53.Text
                    If sDB = "" Then
                        Label53.Text = FormatNumber(ALLVALUE)
                    End If

                    control(True)
                End If
            ElseIf iselect = "TakenBack" Then
                Panels(False, False, False, False, True)
                If iRecorded = 1 Then
                    TextBox27.Text = FormatNumber(dCost3)
                    control(False)
                Else
                    TextBox27.Text = FormatNumber(0)
                    control(True)
                End If
            ElseIf iselect.ToUpper = "CELLULAR" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "CELLULAR COST :"

                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)
                    control(True)
                Else
                    Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    control(True)
                End If
            ElseIf iselect.ToUpper = "WATCH" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "WATCH COST :"
                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)

                    control(True)

                Else
                    Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    control(True)
                End If
            End If

            dr = Nothing
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmReturnItems/DisplayAction: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Panels(ByVal bPanel4 As Boolean, ByVal bPanel5 As Boolean, ByVal bPanel6 As Boolean, ByVal bPanel7 As Boolean, ByVal bPanel8 As Boolean)
        Try
            Panel4.Visible = bPanel4
            Panel5.Visible = bPanel5
            Panel6.Visible = bPanel6
            Panel7.Visible = bPanel7
            Panel8.Visible = bPanel8
        Catch ex As Exception
            MsgBox("frmReturnItems/Panels: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'enables or disables textboxes and buttons

    Private Sub control(ByVal bEnabled As Boolean)
        Try
            TextBox24.Enabled = bEnabled
            TextBox23.Enabled = bEnabled
            TextBox17.Enabled = bEnabled
            Button5.Enabled = bEnabled
            Button6.Enabled = bEnabled
            Button7.Enabled = bEnabled
            Button8.Enabled = bEnabled
            'Button9.Enabled = bEnabled
            Button10.Enabled = bEnabled
            Button11.Enabled = bEnabled
            Button12.Enabled = bEnabled
            TextBox27.Enabled = bEnabled
            'Button1.Enabled = bEnabled
            'Button9.Enabled = bEnabled
            TextBox29.Enabled = bEnabled
            TextBox25.Enabled = bEnabled
            TextBox26.Enabled = bEnabled
        Catch ex As Exception
            MsgBox("frmReturnItems/control: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function IsNull_Value(ByVal odata As Object) As Double
        Try
            If IsDBNull(odata) Then
                Return "0"
            Else
                Return CDbl(odata)
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/IsNull_Value: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

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
            MsgBox("frmReturnItems/SelectAction: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub SelectClass(ByVal sClass As String)
        Try
            Dim i As Integer
            Dim sTemp As String
            For i = 0 To sSortClass.Length - 1
                sTemp = sSortClass(i)
                If sTemp = sClass Then
                    ComboBox5.SelectedIndex = i
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox("frmReturnItems/SelectClass: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmBarcodeQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            photozoom = 0
            Dim dr As SqlDataReader
            Dim i As Integer

            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("select action_id, action_type from tbl_action where action_id in(1,3,8,11,10,2,4,7,9,5) order by action_type")
            dr = objclass.OpenDataReader5
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(UCase(Trim(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()

            objclass.Command5("select * from tbl_sortclass order by description")
            dr = objclass.OpenDataReader5()
            i = 0
            While dr.Read
                ReDim Preserve sSortClass(i)
                ComboBox5.Items.Add(UCase(Trim(dr.Item("description"))))
                sSortClass(i) = Trim(dr.Item("code"))
                i = i + 1
            End While
            dr.Close()
            objclass.Close5()

            TextBox1.Enabled = False
            TextBox4.Enabled = False
            TextBox9.Enabled = False
            TextBox12.Enabled = False
            TextBox21.Enabled = False
            TextBox30.Enabled = False

            Button13.Enabled = False
            Button2.Enabled = False
            Me.txtBranchCode.ReadOnly = True
            Me.txtBranchCode.BackColor = Color.White
            Me.txtbrname.ReadOnly = True
            Me.txtbrname.BackColor = Color.White
            Me.Button4.Enabled = False
            Button1.Enabled = False
            Label44.Text = ""
            cboALL.Focus()
        Catch ex As Exception
            MsgBox("frmReturnItems/frmBarcodeQuery_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Call Clear()
            cboALL.Visible = True
            txteditbarcode.Visible = False
            Button13.Enabled = False
            Button2.Enabled = False
            Button1.Enabled = False
            cboALL.Focus()
        Catch ex As Exception
            MsgBox("frmReturnItems/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Dim i As Integer
            For i = 0 To ListView2.Items.Count - 1
                If ListView2.Items.Item(i).SubItems.Item(0).Text = "" Then
                    flag = True
                    Exit For
                End If
            Next
            If flag = True Then
                MsgBox("Item description is empty. Item not save...", MsgBoxStyle.Information, TitleMsgBox)
                'txtitemid.Focus()
                Exit Sub
            End If

            MsgBox("Item Save!", MsgBoxStyle.Information, TitleMsgBox)

            Call control(False)
            Call Clear()

            Button4.Enabled = False
            Button2.Enabled = False
            iRecord = Nothing

            Me.cboALL.Text = ""
            Me.TextBox32.Text = ""
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            PictureBox1.Image = Nothing
            PictureBox4.Image = Nothing
            Me.cboALL.Focus()

        Catch ex As Exception
            MsgBox("frmReturnItems/Button13_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub Clear()
        Try
            Label43.Text = ""
            Label44.Text = ""
            TextBox17.Text = ""
            Label49.Text = ""
            Label50.Text = ""
            Label51.Text = ""
            Label52.Text = ""
            Label53.Text = ""
            TextBox23.Text = ""
            TextBox24.Text = ""
            TextBox25.Text = ""
            TextBox26.Text = ""
            TextBox27.Text = ""
            TextBox2.Text = ""
            Label54.Text = ""
            TextBox29.Text = ""
            ComboBox4.SelectedIndex = -1
            ComboBox5.SelectedIndex = -1

            cboALL.Text = ""
            txtBranchCode.Text = ""
            txtbrname.Text = ""

            Button13.Enabled = False
            TextBox32.Text = ""
            PictureBox1.Image = Nothing
            PictureBox4.Image = Nothing
            TextBox1.Text = ""
            TextBox4.Text = ""
            TextBox9.Text = ""
            TextBox12.Text = ""
            TextBox21.Text = ""
            TextBox30.Text = ""
            Button4.Enabled = False
            TextBox1.Enabled = False
            TextBox4.Enabled = False
            TextBox9.Enabled = False
            TextBox12.Enabled = False
            TextBox21.Enabled = False
            TextBox30.Enabled = False
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            txteditbarcode.Text = ""
            txteditbarcode.Visible = False
            PictureBox1.Image = Nothing
            picStr = ""
            'Panels(False, False, False, False, False)
            cboALL.Focus()
        Catch ex As Exception
            MsgBox("frmReturnItems/Clear: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub trappedcost()
        Try
            If mountcost = "" Then
                mountcost = FormatNumber(0)
            End If
            If ygcost = "" Then
                ygcost = FormatNumber(0)
            End If
            If wgcost = "" Then
                wgcost = FormatNumber(0)
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/trappedcost: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub trappedcost2()
        Try
            If repaircost = "" Then
                repaircost = FormatNumber(0)
            End If
            If cleaningcost = "" Then
                cleaningcost = FormatNumber(0)
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/trappedcost2: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub Label53_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label53.TextChanged
    '    Me.TextBox30.Text = Label53.Text
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ListView1.Items.Count > 0 Then
                txteditbarcode.Visible = True
                txteditbarcode.BringToFront()
                txteditbarcode.Text = cboALL.Text
                cboALL.Visible = False
                Button4.Enabled = False
                txteditbarcode.Focus()
            Else
                MsgBox("No Barcode information appear!", MsgBoxStyle.Information, TitleMsgBox)
                cboALL.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txteditbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txteditbarcode.TextChanged
        'ListView1.Items.Item(0).SubItems.Item(1).Text = Mid(txteditbarcode.Text, 1, 3)
        Try
            If txteditbarcode.Text <> "" Then
                Button2.Enabled = True
            ElseIf txteditbarcode.Text = "" Then
                Button2.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/txteditbarcode_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txteditbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txteditbarcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If e.KeyChar = ChrW(13) Then
                'PictureBox1.Image.Dispose()
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3("if (Select Count(refallbarcode) from ASYS_REM_Detail  where refallbarcode= '" & Me.txteditbarcode.Text & "') <> 0 begin Select refAllBarcode from ASYS_REM_Detail where refallbarcode = '" & Me.txteditbarcode.Text & "' end else Select refallbarcode from ASYS_REMOutsource_detail where refallbarcode = '" & Me.txteditbarcode.Text & "'")
                dr = obj.OpenDataReader3
                If dr.Read = True Then
                    MsgBox("A.L.L. Barcode already exist!", MsgBoxStyle.Information, TitleMsgBox)
                    'Button4.Visible = False
                    txteditbarcode.Focus()
                    Exit Sub
                Else
                    Button4.Visible = True
                    Button4.Enabled = True
                    Button4.Focus()
                End If
                dr.Close()
                obj.Execute3()
                obj.Close3()
                Button13.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/txteditbarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim obj As New clsCommon

        Try
            Dim str As String
            Dim strpc As String
            Dim img As Drawing.Image

            If txteditbarcode.Text.Length < 17 Then
                MsgBox("A.L.L. Barcode not allowed. Must have 17 digit code.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If File.Exists(picStr) = True Then
                '''change rems.dbo05-12-2013
                str = "Update REMS.dbo.ASYS_REM_Detail set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update REMSLuzon.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                ''str = "Update REMSVismin.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                str = "Update REMSVisayas.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()
                '''REMSShowroom 03-07
                str = "Update REMSShowroom.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()


                str = "Update ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update REMSLuzon.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                'str = "Update REMSVismin.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                str = "Update REMSVisayas.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "',photoname = '" & photodes & txteditbarcode.Text.Trim & ".jpg" & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                ''------REM SHOWROOM 03-07
                str = "Update REMSShowroom.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update ASYS_BarcodeHistory  set refallbarcode ='" & txteditbarcode.Text & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()
                obj.CommitTrack()

                img = Nothing
                PictureBox1.Image.Dispose()
                'PictureBox4.Image = img'''
                PictureBox4.Image.Dispose()
                PictureBox4.Image = Nothing
                PictureBox1.Image = Nothing

                File.Copy(picStr, photodes & "\" & txteditbarcode.Text.Trim & ".jpg", True)
                cboALL.Text = ""
                'Dim y As String'''''
                'y = photodes & txteditbarcode.Text.Trim & ".jpg"'''''
                'img = img.FromFile(y)''''
               
                GC.Collect()
                File.Delete(picStr)

            Else

                str = "Update ASYS_REM_Detail set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update REMSLuzon.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                'str = "Update REMSVismin.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                str = "Update REMSVisayas.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()
                '-----REM Showroom 
                str = "Update REMSShowroom.dbo.ASYS_REM_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                ''str = "Update REMSVismin.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                str = "Update REMSVisayas.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Update REMSLuzon.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                '------REM SHOWROOM 
                str = "Update REMSShowroom.dbo.ASYS_REMOutsource_Detail  set refallbarcode = '" & txteditbarcode.Text & "',refitemcode = '" & Mid(txteditbarcode.Text, 1, 3) & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()


                str = "Update ASYS_BarcodeHistory  set refallbarcode ='" & txteditbarcode.Text & "' where refallbarcode ='" & cboALL.Text & "'"
                obj.commandTrack(str)
                obj.TrackExecute()

                obj.CommitTrack()
            End If

            MsgBox("A.L.L. Barcode Saved", MsgBoxStyle.Information, TitleMsgBox)
            Panel7.Visible = False
            obj.Close3()

        Catch ex As Exception
            MsgBox("frmReturnItems/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            obj.RollBackTrack()

        Finally
            Call Clear()
            PictureBox1.Refresh()
            PictureBox5.SendToBack()
            PictureBox1.Image = Nothing
            cboALL.Visible = True
            txteditbarcode.Visible = False
            Button1.Enabled = False
            Button2.Enabled = False
            cboALL.Focus()

        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If txtBranchCode.Text.Length > 2 Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboALL_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboALL.KeyUp

    End Sub

    Private Sub TextBox12_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            'only fist 2 digits ra iya dawaton like maskedtextbox... paopao 03302010
            If TextBox12.Text.Length > 1 Or e.KeyChar = "." And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                If e.KeyChar = "." And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                    If TextBox12.Text.IndexOf(".") > -1 Then
                        e.Handled = True
                    End If
                Else
                    e.Handled = True
                End If
            End If

            'usa ra ka decimal(.) iya dawaton... paopao 03222010
            If TextBox12.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If TextBox12.SelectionStart > TextBox12.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                        Exit Sub
                    End If
                    e.Handled = False
                End If
            End If
            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                'additional trappings
                If TextBox12.Text = "0" Or TextBox12.Text = "0." Or TextBox12.Text = ".0" Or TextBox12.Text = "" Or TextBox12.Text = "." Or TextBox12.Text = ".00" Or TextBox12.Text = "00." Or TextBox12.Text = "0.00" Or TextBox12.Text = "00.0" Or TextBox12.Text = "00.00" Then
                    TextBox12.Text = "00.00"
                    TextBox21.Enabled = True
                    TextBox21.Focus()
                Else
                    'rounding off decimal values... paopao 03302010
                    Dim giro As Double = TextBox12.Text
                    TextBox12.Text = giro.ToString("##.##")
                    TextBox21.Enabled = True
                    TextBox21.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/TextBox12_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox21_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox21.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
            'only fist 2 digits ra iya dawaton like maskedtextbox... paopao 03302010
            If TextBox21.Text.Length > 1 Or e.KeyChar = "." And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                If e.KeyChar = "." And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                    If TextBox21.Text.IndexOf(".") > -1 Then
                        e.Handled = True
                    End If
                Else
                    e.Handled = True
                End If
            End If

            'usa ra ka decimal(.) iya dawaton... paopao 03222010
            If TextBox21.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If TextBox21.SelectionStart > TextBox21.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                        Exit Sub
                    End If
                    e.Handled = False
                End If
            End If
            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            End If
            'additional trappings...
            If e.KeyChar = ChrW(13) Then
                If TextBox21.Text = "0" Or TextBox21.Text = "0." Or TextBox21.Text = ".0" Or TextBox21.Text = "" Or TextBox21.Text = "." Or TextBox21.Text = ".00" Or TextBox21.Text = "00." Or TextBox21.Text = "0.00" Or TextBox21.Text = "00.0" Or TextBox21.Text = "00.00" Then
                    TextBox21.Text = "00.00"
                    TextBox30.Enabled = True
                    TextBox30.Focus()
                Else
                    'rounding off decimal values... paopao 03302010
                    Dim giro As Double = TextBox21.Text
                    TextBox21.Text = giro.ToString("##.##")
                    TextBox30.Enabled = True
                    TextBox30.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/TextBox21_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox30_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox30.KeyPress
        Try
            'usa ra ka decimal(.) iya dawaton... paopao 03222010
            If TextBox30.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If TextBox30.SelectionStart > TextBox21.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/TextBox30_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/TextBox4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim frmown As New frmBarcodeQuery
            Dim x As Integer = photozoom

            If picStr = "" Then
                Exit Sub
            End If

            If x <= 0 Then
                x = 0
                Dim frm As New frmPhotoZoom
                frm.photoname(picStr)
                x = x + 1
                frm.ShowDialog()
            ElseIf x > 0 Then
                MsgBox("Image already zoomed.", MsgBoxStyle.Information, TitleMsgBox)
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/PictureBox1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboALL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboALL.KeyDown


        Try
            If cboALL.Text <> "" Then
                Button2.Enabled = True
            ElseIf cboALL.Text = "" Then
                Button2.Enabled = False
            End If
            If cboALL.Text.Length = 17 Then
                Button1.Enabled = True
            ElseIf cboALL.Text.Length <> 17 Then
                Button1.Enabled = False
            End If
            If e.KeyCode = Keys.Enter And Me.cboALL.Text.Length = 17 Then
                Call RetrieveInfo(Trim(cboALL.Text))
                TextBox1.TabIndex = 0
                'TextBox1.Focus()
                cboALL.Focus()
            ElseIf e.KeyCode = Keys.Enter Then
                Call Clear()
                Button1.Enabled = False
                Button2.Enabled = False
                TextBox1.TabIndex = 0
                TextBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmReturnItems/cboALL_KeyUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboALL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboALL.SelectedIndexChanged

    End Sub

    Private Sub txtserialno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtserialno.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
