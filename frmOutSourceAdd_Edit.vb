Imports System.Data.SqlClient
Public Class frmOutSourceAdd_Edit
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAllbarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtItemcode As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtKarat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCarat As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblConsign As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRDate As System.Windows.Forms.Label
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLotno As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOutSourceAdd_Edit))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtAllbarcode = New System.Windows.Forms.TextBox
        Me.txtItemcode = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.txtKarat = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtWeight = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCarat = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnRemove = New System.Windows.Forms.Button
        Me.lblConsign = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblRDate = New System.Windows.Forms.Label
        Me.lblReceiver = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLotno = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(664, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 96)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TYPE"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 56)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RETURN"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "OUTSOURCE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 208)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(792, 216)
        Me.ListView1.TabIndex = 15
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "    A.L.L. BARCODE"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM CODE"
        Me.ColumnHeader2.Width = 75
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "                                                DESCRIPTION"
        Me.ColumnHeader3.Width = 355
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "    QTY"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "WEIGHT"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "  KARAT"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "  CARAT"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "STATUS"
        Me.ColumnHeader8.Width = 50
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "A.L.L. BARCODE"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(552, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ITEM CODE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "DESCRIPTION"
        '
        'txtAllbarcode
        '
        Me.txtAllbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAllbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllbarcode.Location = New System.Drawing.Point(112, 152)
        Me.txtAllbarcode.Name = "txtAllbarcode"
        Me.txtAllbarcode.Size = New System.Drawing.Size(144, 20)
        Me.txtAllbarcode.TabIndex = 1
        Me.txtAllbarcode.TabStop = False
        Me.txtAllbarcode.Text = ""
        '
        'txtItemcode
        '
        Me.txtItemcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemcode.Location = New System.Drawing.Point(632, 152)
        Me.txtItemcode.MaxLength = 3
        Me.txtItemcode.Name = "txtItemcode"
        Me.txtItemcode.Size = New System.Drawing.Size(48, 20)
        Me.txtItemcode.TabIndex = 3
        Me.txtItemcode.Text = ""
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(112, 176)
        Me.txtDesc.MaxLength = 150
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(424, 20)
        Me.txtDesc.TabIndex = 2
        Me.txtDesc.TabStop = False
        Me.txtDesc.Text = ""
        '
        'txtKarat
        '
        Me.txtKarat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKarat.Location = New System.Drawing.Point(632, 176)
        Me.txtKarat.MaxLength = 2
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.Size = New System.Drawing.Size(48, 20)
        Me.txtKarat.TabIndex = 4
        Me.txtKarat.TabStop = False
        Me.txtKarat.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(552, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "KARAT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtWeight
        '
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(752, 152)
        Me.txtWeight.MaxLength = 5
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(48, 20)
        Me.txtWeight.TabIndex = 5
        Me.txtWeight.TabStop = False
        Me.txtWeight.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(696, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "WEIGHT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCarat
        '
        Me.txtCarat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarat.Location = New System.Drawing.Point(752, 176)
        Me.txtCarat.Name = "txtCarat"
        Me.txtCarat.Size = New System.Drawing.Size(48, 20)
        Me.txtCarat.TabIndex = 6
        Me.txtCarat.TabStop = False
        Me.txtCarat.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(696, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "CARAT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(400, 432)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 40)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(720, 432)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button3.Location = New System.Drawing.Point(720, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 32)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "ADD"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(560, 432)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 40)
        Me.btnClear.TabIndex = 30
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "TOTAL NO. OF QTY"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(120, 435)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 24)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt3)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(336, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 64)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH BARCODE"
        Me.GroupBox3.Visible = False
        '
        'txt3
        '
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(120, 16)
        Me.txt3.MaxLength = 4
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(64, 20)
        Me.txt3.TabIndex = 37
        Me.txt3.Text = ""
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(136, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "YEAR"
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(64, 16)
        Me.txt2.MaxLength = 5
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(56, 20)
        Me.txt2.TabIndex = 35
        Me.txt2.Text = ""
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(72, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "SUPPLIER"
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(8, 16)
        Me.txt1.MaxLength = 3
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(56, 20)
        Me.txt1.TabIndex = 4
        Me.txt1.Text = ""
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "ITEM CODE"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(264, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 20)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "..."
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(640, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "PRINT"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnRemove
        '
        Me.btnRemove.Enabled = False
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(480, 432)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 40)
        Me.btnRemove.TabIndex = 36
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblConsign
        '
        Me.lblConsign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsign.Location = New System.Drawing.Point(8, 128)
        Me.lblConsign.Name = "lblConsign"
        Me.lblConsign.Size = New System.Drawing.Size(120, 23)
        Me.lblConsign.TabIndex = 37
        Me.lblConsign.Text = "CONSIGNED FROM"
        Me.lblConsign.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(146, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 24)
        Me.Label16.TabIndex = 38
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(112, 122)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 24)
        Me.Label17.TabIndex = 39
        Me.Label17.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"GOODSTOCK", "WATCH", "CELLULAR", "RETURN"})
        Me.ComboBox1.Location = New System.Drawing.Point(272, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.Text = "OUTSOURCE"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ACTION CLASS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRDate
        '
        Me.lblRDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDate.Location = New System.Drawing.Point(96, 64)
        Me.lblRDate.Name = "lblRDate"
        Me.lblRDate.Size = New System.Drawing.Size(88, 20)
        Me.lblRDate.TabIndex = 5
        '
        'lblReceiver
        '
        Me.lblReceiver.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiver.Location = New System.Drawing.Point(96, 40)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(280, 20)
        Me.lblReceiver.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RECEIVE DATE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RECEIVER"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT NO."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtLotno)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblRDate)
        Me.GroupBox1.Controls.Add(Me.lblReceiver)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 96)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtLotno
        '
        Me.txtLotno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLotno.Location = New System.Drawing.Point(96, 16)
        Me.txtLotno.Name = "txtLotno"
        Me.txtLotno.Size = New System.Drawing.Size(144, 20)
        Me.txtLotno.TabIndex = 0
        Me.txtLotno.Text = ""
        '
        'frmOutSourceAdd_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(808, 478)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCarat)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtKarat)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtItemcode)
        Me.Controls.Add(Me.txtAllbarcode)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblConsign)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(816, 512)
        Me.MinimumSize = New System.Drawing.Size(816, 512)
        Me.Name = "frmOutSourceAdd_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD/EDIT OUTSOURCE/RETURNS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private reflotno As String = ""
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Function ALLReturns(ByVal barcode As String) As Boolean
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim SQuery As String
            obj.Connectionstring3()
            obj.Open3()

            SQuery = "SELECT dbo.ASYS_Consign_header.Lotno, dbo.ASYS_Consign_header.ConsignCode, dbo.ASYS_Consign_header.ConsignName, "
            SQuery = SQuery + "  dbo.ASYS_Consign_Detail.ALLBarcode as refallbarcode, dbo.ASYS_DISTRI_detail.PTN, dbo.ASYS_DISTRI_detail.RefItemcode, dbo.ASYS_DISTRI_detail.RefQty, "
            SQuery = SQuery + "                      dbo.ASYS_Consign_Detail.Description as [desc], dbo.ASYS_Consign_Detail.Karat, dbo.ASYS_Consign_Detail.Carat, dbo.ASYS_Consign_Detail.Price as cost, dbo.ASYS_Consign_Detail.Grams as wt, "
            SQuery = SQuery + "                      dbo.ASYS_DISTRI_detail.Status"
            SQuery = SQuery + " FROM         dbo.ASYS_Consign_Detail INNER JOIN"
            SQuery = SQuery + "                      dbo.ASYS_Consign_header ON dbo.ASYS_Consign_Detail.Lotno = dbo.ASYS_Consign_header.Lotno INNER JOIN"
            SQuery = SQuery + "                      dbo.ASYS_DISTRI_detail ON dbo.ASYS_Consign_Detail.ALLBarcode = dbo.ASYS_DISTRI_detail.RefALLBarcode"
            SQuery = SQuery + " WHERE   dbo.ASYS_Consign_Detail.ALLBarcode = '" & txtAllbarcode.Text & "' and dbo.ASYS_Consign_header.ConsignCode = '" & Label17.Text.Trim & "' and dbo.ASYS_Consign_header.ConsignName = '" & Label16.Text.Trim & "'"

            obj.Command3(SQuery)
            dr = obj.OpenDataReader3
            If dr.Read = True Then
                ALLReturns = False
            End If

            dr.Close()
            obj.Close3()
            ''' txtAllbarcode.Focus()''ibalik>>>>>

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/ALLReturns: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Function ALLOutsource() As Boolean
        Dim obj As New clsCommon
        Try
            Dim dr As SqlDataReader
            Dim str As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            str = "Select refallbarcode from ASYS_REM_Detail  where refallbarcode = '" & txtAllbarcode.Text & "' union all Select refallbarcode from ASYS_REMOutSOurce_Detail  where refallbarcode = '" & txtAllbarcode.Text & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3

            ALLOutsource = False

            If dr.Read = True Then
                ALLOutsource = True
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("frmOutSourceAdd_Edit/ALLOutsource: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close3()
        End Try
    End Function

    Function BarcodeExist() As Boolean
        Dim i As Integer

        For i = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).SubItems.Item(0).Text = txtAllbarcode.Text Then
                BarcodeExist = True
                Exit For
            Else
                BarcodeExist = False
            End If
        Next
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            If BarcodeExist() = True Then
                MsgBox("A.L.L. barcode already received.", MsgBoxStyle.Information, TitleMsgBox)
                txtAllbarcode.Focus()
                Exit Sub
            End If

            If RadioButton1.Checked = True Then
                If ALLOutsource() = True Then
                    MsgBox("A.L.L. barcode already received.", MsgBoxStyle.Information, TitleMsgBox)
                    txtAllbarcode.Focus()
                    Exit Sub
                End If
            Else
                If ALLReturns(txtAllbarcode.Text) = True Then
                    MsgBox("A.L.L. barcode already received.", MsgBoxStyle.Information, TitleMsgBox)
                    txtAllbarcode.Focus()
                    Exit Sub
                End If
            End If

            If txtAllbarcode.Text = "" Then
                MsgBox("ALLBarcode is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            ElseIf txtItemcode.Text = "" Then
                MsgBox("Itemcode is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            ElseIf txtDesc.Text = "" Then
                MsgBox("Description is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            ElseIf txtWeight.Text = "" Then
                MsgBox("Weight is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            ElseIf txtKarat.Text = "" Then
                MsgBox("Karat is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            ElseIf txtCarat.Text = "" Then

                MsgBox("Carat is empty.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            Else
                ListView1.Items.Add(txtAllbarcode.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(txtItemcode.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(txtDesc.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("1")
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(txtWeight.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(txtKarat.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(txtCarat.Text)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("0")
                txtAllbarcode.Text = ""
                txtItemcode.Text = ""
                txtDesc.Text = ""
                txtWeight.Text = ""
                txtKarat.Text = ""
                txtCarat.Text = ""
                txtAllbarcode.Focus()
                btnRemove.Enabled = True
                btnUpdate.Enabled = True
                Label12.Text = ListView1.Items.Count
                ListView1.EnsureVisible(ListView1.Items.Count - 1)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLotno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotno.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim notfound As Boolean

            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
                Exit Try
            End If

            If txtLotno.Text.Length = 10 Then
                If e.KeyChar = ChrW(13) Then
                    ListView1.Items.Clear()
                    notfound = False
                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "SELECT     dbo.ASYS_REMOutSource_header.Lotno, dbo.ASYS_REMOutSource_detail.ReceiveDate, dbo.ASYS_REMOutSource_detail.Receiver, "
                    str = str + "     dbo.ASYS_REMOutSource_detail.RefallBarcode,dbo.ASYS_REMOutSource_detail.branchcode,dbo.ASYS_REMOutSource_detail.branchname, dbo.ASYS_REMOutSource_detail.RefItemcode, dbo.ASYS_REMOutSource_detail.BranchItemDesc, "
                    str = str + "          dbo.ASYS_REMOutSource_detail.RefQty, dbo.ASYS_REMOutSource_detail.KaratGrading, dbo.ASYS_REMOutSource_detail.CaratSize, "
                    str = str + "          dbo.ASYS_REMOutSource_detail.Weight"
                    str = str + "   FROM         dbo.ASYS_REMOutSource_detail  INNER JOIN"
                    str = str + "           dbo.ASYS_REMOutSource_header  ON dbo.ASYS_REMOutSource_detail.Lotno = dbo.ASYS_REMOutSource_header.Lotno"
                    str = str + " where  dbo.ASYS_REMOutSource_header.Lotno = '" & txtLotno.Text & "' order by dbo.asys_remoutsource_detail.refallbarcode"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    While dr.Read
                        notfound = True
                        lblReceiver.Text = obj.IsNull(dr.Item("Receiver"))
                        lblRDate.Text = Format(obj.IsNull(dr.Item("Receivedate")), "Short Date")
                        Label17.Text = obj.IsNull(dr.Item("branchcode"))
                        Label16.Text = obj.IsNull(dr.Item("branchname"))
                        ListView1.Items.Add(obj.IsNull(dr.Item("refallbarcode")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("refitemcode")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("BranchItemDesc")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("refqty")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("weight")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("KaratGrading")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("CaratSize")))
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("1")
                        Label12.Text = ListView1.Items.Count
                    End While
                    dr.Close()
                    obj.Close3()
                    obj = Nothing
                    If ListView1.Items.Count <> 0 Then
                        'ListView1.Items(17).SubItems(2).Text = ListView1.Items(17).SubItems(2).Text
                        ListView1.Items(5).Selected = True
                        ListView1.Select()

                        'ListView1.Refresh()
                        'ListView1.Focus()
                        btnRemove.Enabled = True
                    Else
                        btnRemove.Enabled = False
                    End If
                    txtAllbarcode.Focus()
                    If notfound = False Then
                        MsgBox("No Data Found.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtLotno.Text = ""
                        txtLotno.Focus()
                    End If
                End If
            End If
            If txtLotno.TextLength > 9 And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmOutSourceAdd_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            txtItemcode.Enabled = False
            txtItemcode.BackColor = txtItemcode.BackColor.WhiteSmoke()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            ListView1.Items.Clear()
            txtLotno.Text = ""
            lblReceiver.Text = ""
            lblRDate.Text = ""
            txtAllbarcode.Text = ""
            txtDesc.Text = ""
            txtItemcode.Text = ""
            GroupBox3.Visible = False
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txtCarat.Text = ""
            txtWeight.Text = ""
            txtKarat.Text = ""
            Label12.Text = "0"
            txtLotno.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim obj As New clsCommon
        Try
            Dim str As String
            Dim i As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            For i = 0 To ListView1.Items.Count - 1
                If ListView1.Items(i).SubItems.Item(7).Text = "0" Then
                    If RadioButton1.Checked = True Then
                        str = "Insert into ASYS_REMOutSource_detail  (Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,receivedate, receiver,status) values ('" & txtLotno.Text & "','" & txtLotno.Text & "','" & ListView1.Items(i).SubItems.Item(0).Text & "','" & ListView1.Items(i).SubItems.Item(0).Text & "','" & ListView1.Items(i).SubItems.Item(1).Text & "','" & ListView1.Items(i).SubItems.Item(1).Text & "','" & ListView1.Items(i).SubItems.Item(2).Text & "','" & ListView1.Items(i).SubItems.Item(3).Text & "','" & ListView1.Items(i).SubItems.Item(3).Text & "','" & ListView1.Items(i).SubItems.Item(5).Text & "','" & ListView1.Items(i).SubItems.Item(6).Text & "','" & ListView1.Items(i).SubItems.Item(4).Text & "','" & ComboBox1.Text & "','O','" & ListView1.Items(i).SubItems.Item(2).Text & "','" & ListView1.Items(i).SubItems.Item(5).Text & "','" & ListView1.Items(i).SubItems.Item(6).Text & "','" & ListView1.Items(i).SubItems.Item(4).Text & "','" & ListView1.Items(i).SubItems.Item(2).Text & "','" & ListView1.Items(i).SubItems.Item(5).Text & "','" & ListView1.Items(i).SubItems.Item(4).Text & "','" & ListView1.Items(i).SubItems.Item(6).Text & "',getdate(),'" & userLog & "', getdate(), '" & userLog & "','RECEIVED')"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = " insert into ASYS_BarcodeHistory  (lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,"
                        str = str + " empname,trandate,costcenter,status)"
                        str = str + " values ('" & txtLotno.Text & "','" & ListView1.Items(i).SubItems.Item(0).Text & "','" & ListView1.Items(i).SubItems.Item(0).Text & "',"
                        str = str + " '" & ListView1.Items(i).SubItems.Item(1).Text & "','" & ListView1.Items(i).SubItems.Item(2).Text & "',"
                        str = str + " '" & ListView1.Items(i).SubItems.Item(5).Text & "','" & ListView1.Items(i).SubItems.Item(6).Text & "',"
                        str = str + " '" & ListView1.Items(i).SubItems.Item(4).Text & "','" & userLog & "',getdate(),'REM','RECEIVED')"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                    Else
                        str = "insert into ASYS_REMOutsource_detail  ( RefLotno, Lotno, RefallBarcode, ALLbarcode, PTN, PTNbarcode, BranchCode, BranchName, Loanvalue, Loandate, RefItemcode, Itemcode, BranchItemDesc, "
                        str = str + "                      RefQty, Qty, KaratGrading, CaratSize, Weight, ActionClass, SortCode, ALL_desc, ALL_karat, ALL_carat, ALL_Cost, ALL_weight, "
                        str = str + "   		      Currency, PhotoName, Price_desc, Price_karat, Price_weight, Price_carat, AppraiseValue, ALL_price, Cellular_cost, "
                        str = str + "   		      Watch_cost, Repair_cost, Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, receivedate, receiver, status)"
                        str = str + "   SELECT     '" & txtLotno.Text & "' as reflotno,'" & txtLotno.Text & "' as lotno, RefALLBarcode, refALLbarcode as ALLBarcode, PTN, PTNBarcode, '" & Label17.Text.Trim & "' as branchcode, '" & Label16.Text.Trim & "' as BranchName, Loanvalue, Loandate, "
                        str = str + "   	  	      RefItemcode, ItemCode , BranchItemDesc, RefQty, Qty, KaratGrading, CaratSize, Weight, '" & ComboBox1.Text.Trim & "' as Actionclass, SortCode,"
                        str = str + "   		      price_desc as all_desc,price_karat as all_karat,price_carat as all_carat,ALL_Cost,price_weight as all_weight,  Currency,"
                        str = str + "   		      PhotoName, Price_desc, Price_karat,  Price_weight,Price_carat,AppraiseValue, ALL_price, Cellular_cost, Watch_cost, Repair_cost,"
                        str = str + "    		      Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, getdate(), '" & userLog & "', 'COSTED' as status"
                        str = str + "   FROM         dbo.ASYS_DISTRI_detail  where refallbarcode = '" & ListView1.Items(i).SubItems.Item(0).Text & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = " insert into ASYS_BarcodeHistory  (lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,empname,trandate,costcenter,status)"
                        str = str + " SELECT     '" & txtLotno.Text & "' as lotno, RefALLBarcode,RefALLBarcode as allbarcode, RefItemcode, Price_desc, Price_karat, Price_carat, "
                        str = str + " Price_weight, Currency, ALL_price, ALL_Cost,'" & userLog & "' as empname,getdate() as trandate,'REM' as costcenter,'RETURNED' as status"
                        str = str + " FROM         dbo.ASYS_DISTRI_detail  where refallbarcode = '" & ListView1.Items(i).SubItems.Item(0).Text & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = "Update ASYS_Distri_detail  set status = 'RETURNED' where refallbarcode = '" & ListView1.Items(i).SubItems.Item(0).Text & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()


                    End If

                End If

            Next
            obj.CommitTrack()
            MsgBox("Barcode has successfully added.", MsgBoxStyle.Information, TitleMsgBox)
            reflotno = txtLotno.Text
            btnClear_Click(sender, e)
            btnUpdate.Enabled = False
            btnRemove.Enabled = False
            lblConsign.Visible = False
            Label16.Visible = False
            Label17.Visible = False

        Catch ex As Exception
            obj.RollBackTrack()
        Finally
            obj.Close()
            obj = Nothing
        End Try
    End Sub
    Private Function ALLbarcodenotExist() As Boolean
        Try
            Dim z As Integer
            If ListView1.Items.Count > 0 Then
                For z = 0 To ListView1.Items.Count - 1
                    If ListView1.Items(z).SubItems(0).Text.Trim = txtAllbarcode.Text Then
                        ALLbarcodenotExist = False
                    Else
                        ALLbarcodenotExist = True
                    End If
                Next
            Else
                ALLbarcodenotExist = True
            End If
        Catch ex As Exception

        End Try
    End Function
    Private Sub txtAllbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllbarcode.KeyPress
        Dim obj As New clsCommon
        Try
            Dim dr As SqlDataReader
            Dim str As String

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
                Exit Try
            End If
            If txtAllbarcode.Text.Length = 17 Then
                If e.KeyChar = ChrW(13) Then
                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    If RadioButton1.Checked = True Then
                        str = "Select refallbarcode from ASYS_REM_DEtail  where refallbarcode = '" & txtAllbarcode.Text & "' union all select refallbarcode from ASYS_REMOutSource_detail  where refallbarcode = '" & txtAllbarcode.Text & "'"
                    Else
                        str = "select refallbarcode from ASYS_DISTRI_detail  where refallbarcode = '" & txtAllbarcode.Text & "' and status = 'returned'"
                    End If

                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        MsgBox("Allbarcode already receive.", MsgBoxStyle.Information, TitleMsgBox)
                        txtAllbarcode.Text = ""
                        txtAllbarcode.Focus()
                        Button3.Enabled = False
                        Exit Sub
                    Else
                        If ALLbarcodenotExist() = False Then
                            MsgBox("You have inputed the same barcode.", MsgBoxStyle.Information, "ASYS 3.1")
                            txtAllbarcode.Focus()
                            Exit Sub
                        Else
                            If RadioButton1.Checked = True Then
                                txtItemcode.Text = Mid(txtAllbarcode.Text, 1, 3)
                                txtDesc.Focus()
                                Button3.Enabled = True
                            Else
                                ReturnDetails()
                                Button3.Enabled = True
                                Button3.Focus()
                            End If

                        End If
                    End If
                End If
            End If
            If txtAllbarcode.Text.Length > 16 And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                Exit Try
            End If

        Catch ex As Exception
            obj.Close()
            obj = Nothing
        End Try
    End Sub
    Private Sub ReturnDetails()
        Try
            Dim objclass As New clsCommon
            Dim dr1 As SqlDataReader
            Dim str As String

            objclass = New clsCommon
            objclass.Connectionstring4()
            objclass.Open4()
            str = "Select refallbarcode,price_desc,refitemcode,price_karat,price_weight,price_carat from ASYS_Distri_detail  where refallbarcode = '" & txtAllbarcode.Text & "' and status = 'RELEASED'"
            objclass.Command4(str)
            dr1 = objclass.OpenDataReader4
            If dr1.Read Then
                txtDesc.Text = dr1.Item("price_desc")
                txtItemcode.Text = dr1.Item("refitemcode")
                txtKarat.Text = dr1.Item("price_karat")
                txtCarat.Text = dr1.Item("price_carat")
                txtWeight.Text = dr1.Item("price_weight")
            End If
            dr1.Close()
            objclass.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txtDesc.Text <> "" Then
                    txtKarat.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txtKarat.Text = "" Or (txtItemcode.Text = "300" Or txtItemcode.Text = "400") Then
                    txtKarat.Text = "0"
                    txtWeight.Focus()
                Else
                    txtWeight.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." Then
                If txtCarat.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If e.KeyChar = ChrW(13) Then
                If txtCarat.Text = "" Or txtCarat.Text = "0" Or (txtItemcode.Text = "300" Or txtItemcode.Text = "400") Then '''
                    txtCarat.Text = "0"
                    Button3.Focus()
                Else
                    Dim FormatCarat As Double = txtCarat.Text

                    txtCarat.Text = FormatCarat.ToString("##.####")
                    Button3.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." Then
                If txtWeight.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If e.KeyChar = ChrW(13) Then
                If txtWeight.Text = "" Or (txtItemcode.Text = "300" Or txtItemcode.Text = "400") Then
                    txtWeight.Text = "0"
                    txtCarat.Focus()
                Else
                    txtWeight.Text = FormatNumber(txtWeight.Text)
                    txtCarat.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtItemcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemcode.KeyPress
        Try
            If IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar <> ChrW(Keys.Enter) Or e.KeyChar = ChrW(Keys.Delete) Then
                e.Handled = True
            End If
            If txtItemcode.Text.Length > 2 Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            GroupBox3.Visible = True
            txt1.Focus()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then

                Dim obj As New clsCommon
                Dim dr As SqlDataReader
                Dim str, str1 As String
                Dim maxbarc As String

                If Me.txt1.Text = "" And txt2.Text = "" And txt3.Text = "" Then
                    MsgBox("Fill all the textboxes!", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                Else
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "exec ASYS_Barcode_Generator '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "'"

                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read Then
                        maxbarc = obj.IsNull(dr.Item("maxBarcode"))
                        txtAllbarcode.Text = maxbarc
                        txtAllbarcode.Focus()

                    End If
                    dr.Close()
                    'obj.Execute3()
                    obj.Close3()
                    obj = Nothing
                    txt1.Text = ""
                    txt2.Text = ""
                    txt3.Text = ""
                    GroupBox3.Visible = False
                End If

            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txt1.Text = "" Then
                    txt1.Focus()
                Else
                    txt2.Focus()
                End If

            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txt2.Text = "" Then
                    txt2.Focus()
                Else
                    txt3.Focus()
                End If

            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim frm As New frmOutSource_Return
            outsource = True
            sDB = ""
            frm.txtlotno.Text = reflotno
            frm.cmbEmp.Text = userLog
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            If ListView1.Items.Count > 0 Then
                ListView1.FocusedItem.Remove()
                Label12.Text = ListView1.Items.Count
            Else
                btnRemove.Enabled = False
                btnUpdate.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Try
            lblConsign.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            ComboBox1.Text = "OUTSOURCE"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Try
            lblConsign.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            ComboBox1.Text = "RETURN"
        Catch ex As Exception

        End Try
    End Sub
End Class
