Imports System.Data.SqlClient
Public Class Form2
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
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lblReceiverIDNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblReceiverName As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents bleh1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents cmbLOTno As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents txtAll As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtPTN As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtItemCode3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCode1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemApp3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemWt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemSortingCls3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCarat3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemKarat3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemQty3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemApp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemWt2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemSortingCls2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCarat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemKarat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemQty2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemApp1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemWt1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemSortingCls1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemCarat1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemKarat1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemQty1 As System.Windows.Forms.TextBox
    Friend WithEvents txtItemDesc1 As System.Windows.Forms.TextBox
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
    Friend WithEvents cmbcostcenter As System.Windows.Forms.TextBox
    Friend WithEvents btnMaxBar As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtLoanValue As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblcostcenter As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.Label39 = New System.Windows.Forms.Label
        Me.lblReceiverIDNo = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblReceiverName = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.bleh1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.btnMaxBar = New System.Windows.Forms.Button
        Me.cmbcostcenter = New System.Windows.Forms.TextBox
        Me.lblcostcenter = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.txtAll = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtPTN = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cmbLOTno = New System.Windows.Forms.ComboBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtItemCode3 = New System.Windows.Forms.TextBox
        Me.txtItemCode2 = New System.Windows.Forms.TextBox
        Me.txtItemCode1 = New System.Windows.Forms.TextBox
        Me.txtItemApp3 = New System.Windows.Forms.TextBox
        Me.txtItemWt3 = New System.Windows.Forms.TextBox
        Me.txtItemSortingCls3 = New System.Windows.Forms.TextBox
        Me.txtItemCarat3 = New System.Windows.Forms.TextBox
        Me.txtItemKarat3 = New System.Windows.Forms.TextBox
        Me.txtItemQty3 = New System.Windows.Forms.TextBox
        Me.txtItemDesc3 = New System.Windows.Forms.TextBox
        Me.txtItemApp2 = New System.Windows.Forms.TextBox
        Me.txtItemWt2 = New System.Windows.Forms.TextBox
        Me.txtItemSortingCls2 = New System.Windows.Forms.TextBox
        Me.txtItemCarat2 = New System.Windows.Forms.TextBox
        Me.txtItemKarat2 = New System.Windows.Forms.TextBox
        Me.txtItemQty2 = New System.Windows.Forms.TextBox
        Me.txtItemDesc2 = New System.Windows.Forms.TextBox
        Me.txtItemApp1 = New System.Windows.Forms.TextBox
        Me.txtItemWt1 = New System.Windows.Forms.TextBox
        Me.txtItemSortingCls1 = New System.Windows.Forms.TextBox
        Me.txtItemCarat1 = New System.Windows.Forms.TextBox
        Me.txtItemKarat1 = New System.Windows.Forms.TextBox
        Me.txtItemQty1 = New System.Windows.Forms.TextBox
        Me.txtItemDesc1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.txtLoanValue = New System.Windows.Forms.TextBox
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(208, 17)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(136, 32)
        Me.Label39.TabIndex = 157
        Me.Label39.Visible = False
        '
        'lblReceiverIDNo
        '
        Me.lblReceiverIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiverIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverIDNo.Location = New System.Drawing.Point(112, 424)
        Me.lblReceiverIDNo.Name = "lblReceiverIDNo"
        Me.lblReceiverIDNo.Size = New System.Drawing.Size(64, 20)
        Me.lblReceiverIDNo.TabIndex = 153
        Me.lblReceiverIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReceiverIDNo.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(696, 408)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(272, 64)
        Me.GroupBox6.TabIndex = 154
        Me.GroupBox6.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(96, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 139
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
        Me.Button2.Location = New System.Drawing.Point(176, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 140
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 127
        Me.Button1.TabStop = False
        Me.Button1.Text = "SAVE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(16, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 128
        Me.Button4.TabStop = False
        Me.Button4.Text = "Edit"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblReceiverName
        '
        Me.lblReceiverName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReceiverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiverName.Location = New System.Drawing.Point(184, 424)
        Me.lblReceiverName.Name = "lblReceiverName"
        Me.lblReceiverName.Size = New System.Drawing.Size(184, 20)
        Me.lblReceiverName.TabIndex = 152
        Me.lblReceiverName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReceiverName.Visible = False
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(32, 424)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 23)
        Me.Label35.TabIndex = 151
        Me.Label35.Text = "RECEIVER"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'bleh1
        '
        Me.bleh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bleh1.Location = New System.Drawing.Point(200, 392)
        Me.bleh1.Name = "bleh1"
        Me.bleh1.Size = New System.Drawing.Size(96, 24)
        Me.bleh1.TabIndex = 156
        Me.bleh1.Text = "0"
        Me.bleh1.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnSearch)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.btnMaxBar)
        Me.GroupBox5.Controls.Add(Me.cmbcostcenter)
        Me.GroupBox5.Controls.Add(Me.lblcostcenter)
        Me.GroupBox5.Controls.Add(Me.txtBranchCode)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.ComboBox4)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.txtbrname)
        Me.GroupBox5.Controls.Add(Me.txtAll)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.Controls.Add(Me.txtPTN)
        Me.GroupBox5.Controls.Add(Me.Label36)
        Me.GroupBox5.Controls.Add(Me.cmbLOTno)
        Me.GroupBox5.Controls.Add(Me.btnNew)
        Me.GroupBox5.Location = New System.Drawing.Point(424, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(544, 144)
        Me.GroupBox5.TabIndex = 158
        Me.GroupBox5.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Location = New System.Drawing.Point(336, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 23)
        Me.btnSearch.TabIndex = 174
        Me.btnSearch.Text = "...."
        Me.btnSearch.Visible = False
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(8, 76)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 169
        Me.Label44.Text = "A.L.L. BARCODE"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label44.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.Label48)
        Me.GroupBox7.Controls.Add(Me.txt2)
        Me.GroupBox7.Controls.Add(Me.Label49)
        Me.GroupBox7.Controls.Add(Me.txt3)
        Me.GroupBox7.Controls.Add(Me.txt1)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(336, 56)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(168, 80)
        Me.GroupBox7.TabIndex = 172
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SEARCH MAX BARCODE"
        Me.GroupBox7.Visible = False
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(110, 48)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(40, 16)
        Me.Label47.TabIndex = 2
        Me.Label47.Text = "YEAR"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(56, 48)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(56, 24)
        Me.Label48.TabIndex = 1
        Me.Label48.Text = "ITEM SOURCE"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(57, 24)
        Me.txt2.MaxLength = 5
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(48, 20)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = "39033"
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(16, 48)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(40, 24)
        Me.Label49.TabIndex = 0
        Me.Label49.Text = "ITEM CODE"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt3
        '
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(106, 24)
        Me.txt3.MaxLength = 4
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(48, 20)
        Me.txt3.TabIndex = 3
        Me.txt3.Text = "2010"
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(8, 24)
        Me.txt1.MaxLength = 3
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(48, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = ""
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMaxBar
        '
        Me.btnMaxBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMaxBar.Location = New System.Drawing.Point(288, 75)
        Me.btnMaxBar.Name = "btnMaxBar"
        Me.btnMaxBar.Size = New System.Drawing.Size(24, 16)
        Me.btnMaxBar.TabIndex = 171
        Me.btnMaxBar.Text = "...."
        '
        'cmbcostcenter
        '
        Me.cmbcostcenter.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmbcostcenter.Enabled = False
        Me.cmbcostcenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcostcenter.Location = New System.Drawing.Point(112, 96)
        Me.cmbcostcenter.Name = "cmbcostcenter"
        Me.cmbcostcenter.Size = New System.Drawing.Size(168, 20)
        Me.cmbcostcenter.TabIndex = 170
        Me.cmbcostcenter.Text = "REM"
        '
        'lblcostcenter
        '
        Me.lblcostcenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcostcenter.Location = New System.Drawing.Point(8, 96)
        Me.lblcostcenter.Name = "lblcostcenter"
        Me.lblcostcenter.Size = New System.Drawing.Size(88, 20)
        Me.lblcostcenter.TabIndex = 167
        Me.lblcostcenter.Text = "COST CENTER"
        Me.lblcostcenter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(112, 24)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(64, 20)
        Me.txtBranchCode.TabIndex = 53
        Me.txtBranchCode.Text = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 23)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "BRANCH CODE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(112, 48)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox4.TabIndex = 146
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 23)
        Me.Label19.TabIndex = 151
        Me.Label19.Text = "ACTION"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbrname
        '
        Me.txtbrname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.Location = New System.Drawing.Point(176, 24)
        Me.txtbrname.MaxLength = 30
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.Size = New System.Drawing.Size(152, 20)
        Me.txtbrname.TabIndex = 155
        Me.txtbrname.Text = ""
        '
        'txtAll
        '
        Me.txtAll.AutoSize = False
        Me.txtAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAll.Location = New System.Drawing.Point(112, 72)
        Me.txtAll.MaxLength = 17
        Me.txtAll.Name = "txtAll"
        Me.txtAll.Size = New System.Drawing.Size(168, 23)
        Me.txtAll.TabIndex = 0
        Me.txtAll.Text = ""
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(112, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(169, 24)
        Me.ComboBox1.TabIndex = 152
        '
        'txtPTN
        '
        Me.txtPTN.AutoSize = False
        Me.txtPTN.Location = New System.Drawing.Point(112, 72)
        Me.txtPTN.Name = "txtPTN"
        Me.txtPTN.Size = New System.Drawing.Size(168, 23)
        Me.txtPTN.TabIndex = 164
        Me.txtPTN.Text = ""
        Me.txtPTN.Visible = False
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(24, 25)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 24)
        Me.Label36.TabIndex = 157
        Me.Label36.Text = "LOT No :"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLOTno
        '
        Me.cmbLOTno.AllowDrop = True
        Me.cmbLOTno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbLOTno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLOTno.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.cmbLOTno.Location = New System.Drawing.Point(112, 24)
        Me.cmbLOTno.MaxDropDownItems = 1
        Me.cmbLOTno.MaxLength = 10
        Me.cmbLOTno.Name = "cmbLOTno"
        Me.cmbLOTno.Size = New System.Drawing.Size(216, 24)
        Me.cmbLOTno.TabIndex = 162
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(368, 24)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(96, 23)
        Me.btnNew.TabIndex = 163
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "NEW LOT NO."
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtItemCode3)
        Me.GroupBox3.Controls.Add(Me.txtItemCode2)
        Me.GroupBox3.Controls.Add(Me.txtItemCode1)
        Me.GroupBox3.Controls.Add(Me.txtItemApp3)
        Me.GroupBox3.Controls.Add(Me.txtItemWt3)
        Me.GroupBox3.Controls.Add(Me.txtItemSortingCls3)
        Me.GroupBox3.Controls.Add(Me.txtItemCarat3)
        Me.GroupBox3.Controls.Add(Me.txtItemKarat3)
        Me.GroupBox3.Controls.Add(Me.txtItemQty3)
        Me.GroupBox3.Controls.Add(Me.txtItemDesc3)
        Me.GroupBox3.Controls.Add(Me.txtItemApp2)
        Me.GroupBox3.Controls.Add(Me.txtItemWt2)
        Me.GroupBox3.Controls.Add(Me.txtItemSortingCls2)
        Me.GroupBox3.Controls.Add(Me.txtItemCarat2)
        Me.GroupBox3.Controls.Add(Me.txtItemKarat2)
        Me.GroupBox3.Controls.Add(Me.txtItemQty2)
        Me.GroupBox3.Controls.Add(Me.txtItemDesc2)
        Me.GroupBox3.Controls.Add(Me.txtItemApp1)
        Me.GroupBox3.Controls.Add(Me.txtItemWt1)
        Me.GroupBox3.Controls.Add(Me.txtItemSortingCls1)
        Me.GroupBox3.Controls.Add(Me.txtItemCarat1)
        Me.GroupBox3.Controls.Add(Me.txtItemKarat1)
        Me.GroupBox3.Controls.Add(Me.txtItemQty1)
        Me.GroupBox3.Controls.Add(Me.txtItemDesc1)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Controls.Add(Me.txtLoanValue)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(936, 200)
        Me.GroupBox3.TabIndex = 159
        Me.GroupBox3.TabStop = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(608, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 23)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "(mm/dd/yyyy)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(248, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 23)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "(mm/dd/yyyy)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(790, 152)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(136, 23)
        Me.Label46.TabIndex = 79
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(728, 152)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(48, 24)
        Me.Label45.TabIndex = 78
        Me.Label45.Text = "PRICE"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(248, 144)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 23)
        Me.Label41.TabIndex = 76
        Me.Label41.Text = "(mm/dd/yyyy)"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(126, 168)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(120, 23)
        Me.Label37.TabIndex = 73
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(16, 168)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(98, 23)
        Me.Label38.TabIndex = 72
        Me.Label38.Text = "RECEIVED DATE"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(790, 120)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(136, 23)
        Me.Label33.TabIndex = 71
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(478, 144)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(120, 23)
        Me.Label32.TabIndex = 70
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(478, 120)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(120, 23)
        Me.Label31.TabIndex = 69
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(126, 144)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 23)
        Me.Label30.TabIndex = 68
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(126, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(120, 23)
        Me.Label29.TabIndex = 67
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(344, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 23)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "DATE LOAN GRANTED"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(627, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 23)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "TOTAL APPRAISED VALUE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(344, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "LOAN VALUE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 23)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "MATURITY DATE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "EXPIRY DATE"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtItemCode3
        '
        Me.txtItemCode3.AutoSize = False
        Me.txtItemCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCode3.Enabled = False
        Me.txtItemCode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode3.Location = New System.Drawing.Point(16, 79)
        Me.txtItemCode3.Name = "txtItemCode3"
        Me.txtItemCode3.ReadOnly = True
        Me.txtItemCode3.Size = New System.Drawing.Size(83, 20)
        Me.txtItemCode3.TabIndex = 44
        Me.txtItemCode3.Text = ""
        Me.txtItemCode3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemCode2
        '
        Me.txtItemCode2.AutoSize = False
        Me.txtItemCode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCode2.Enabled = False
        Me.txtItemCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode2.Location = New System.Drawing.Point(16, 58)
        Me.txtItemCode2.Name = "txtItemCode2"
        Me.txtItemCode2.ReadOnly = True
        Me.txtItemCode2.Size = New System.Drawing.Size(83, 20)
        Me.txtItemCode2.TabIndex = 36
        Me.txtItemCode2.Text = ""
        Me.txtItemCode2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemCode1
        '
        Me.txtItemCode1.AutoSize = False
        Me.txtItemCode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCode1.Location = New System.Drawing.Point(16, 37)
        Me.txtItemCode1.Name = "txtItemCode1"
        Me.txtItemCode1.ReadOnly = True
        Me.txtItemCode1.Size = New System.Drawing.Size(83, 20)
        Me.txtItemCode1.TabIndex = 28
        Me.txtItemCode1.Text = ""
        Me.txtItemCode1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtItemApp3
        '
        Me.txtItemApp3.AutoSize = False
        Me.txtItemApp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemApp3.Enabled = False
        Me.txtItemApp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemApp3.Location = New System.Drawing.Point(784, 79)
        Me.txtItemApp3.Name = "txtItemApp3"
        Me.txtItemApp3.ReadOnly = True
        Me.txtItemApp3.Size = New System.Drawing.Size(136, 20)
        Me.txtItemApp3.TabIndex = 51
        Me.txtItemApp3.Text = ""
        Me.txtItemApp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemWt3
        '
        Me.txtItemWt3.AutoSize = False
        Me.txtItemWt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemWt3.Enabled = False
        Me.txtItemWt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemWt3.Location = New System.Drawing.Point(697, 79)
        Me.txtItemWt3.MaxLength = 5
        Me.txtItemWt3.Name = "txtItemWt3"
        Me.txtItemWt3.ReadOnly = True
        Me.txtItemWt3.Size = New System.Drawing.Size(86, 20)
        Me.txtItemWt3.TabIndex = 50
        Me.txtItemWt3.Text = ""
        Me.txtItemWt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemSortingCls3
        '
        Me.txtItemSortingCls3.AutoSize = False
        Me.txtItemSortingCls3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSortingCls3.Enabled = False
        Me.txtItemSortingCls3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSortingCls3.Location = New System.Drawing.Point(601, 79)
        Me.txtItemSortingCls3.MaxLength = 1
        Me.txtItemSortingCls3.Name = "txtItemSortingCls3"
        Me.txtItemSortingCls3.ReadOnly = True
        Me.txtItemSortingCls3.Size = New System.Drawing.Size(95, 20)
        Me.txtItemSortingCls3.TabIndex = 49
        Me.txtItemSortingCls3.Text = ""
        '
        'txtItemCarat3
        '
        Me.txtItemCarat3.AutoSize = False
        Me.txtItemCarat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCarat3.Enabled = False
        Me.txtItemCarat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCarat3.Location = New System.Drawing.Point(539, 79)
        Me.txtItemCarat3.MaxLength = 5
        Me.txtItemCarat3.Name = "txtItemCarat3"
        Me.txtItemCarat3.ReadOnly = True
        Me.txtItemCarat3.Size = New System.Drawing.Size(61, 20)
        Me.txtItemCarat3.TabIndex = 48
        Me.txtItemCarat3.Text = ""
        Me.txtItemCarat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemKarat3
        '
        Me.txtItemKarat3.AutoSize = False
        Me.txtItemKarat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemKarat3.Enabled = False
        Me.txtItemKarat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemKarat3.Location = New System.Drawing.Point(478, 79)
        Me.txtItemKarat3.MaxLength = 6
        Me.txtItemKarat3.Name = "txtItemKarat3"
        Me.txtItemKarat3.ReadOnly = True
        Me.txtItemKarat3.Size = New System.Drawing.Size(60, 20)
        Me.txtItemKarat3.TabIndex = 47
        Me.txtItemKarat3.Text = ""
        Me.txtItemKarat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemQty3
        '
        Me.txtItemQty3.AutoSize = False
        Me.txtItemQty3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemQty3.Enabled = False
        Me.txtItemQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemQty3.Location = New System.Drawing.Point(419, 79)
        Me.txtItemQty3.Name = "txtItemQty3"
        Me.txtItemQty3.ReadOnly = True
        Me.txtItemQty3.Size = New System.Drawing.Size(58, 20)
        Me.txtItemQty3.TabIndex = 46
        Me.txtItemQty3.Text = "1"
        Me.txtItemQty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemDesc3
        '
        Me.txtItemDesc3.AutoSize = False
        Me.txtItemDesc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDesc3.Enabled = False
        Me.txtItemDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc3.Location = New System.Drawing.Point(100, 79)
        Me.txtItemDesc3.Name = "txtItemDesc3"
        Me.txtItemDesc3.ReadOnly = True
        Me.txtItemDesc3.Size = New System.Drawing.Size(317, 20)
        Me.txtItemDesc3.TabIndex = 45
        Me.txtItemDesc3.Text = ""
        '
        'txtItemApp2
        '
        Me.txtItemApp2.AutoSize = False
        Me.txtItemApp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemApp2.Enabled = False
        Me.txtItemApp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemApp2.Location = New System.Drawing.Point(784, 58)
        Me.txtItemApp2.Name = "txtItemApp2"
        Me.txtItemApp2.ReadOnly = True
        Me.txtItemApp2.Size = New System.Drawing.Size(136, 20)
        Me.txtItemApp2.TabIndex = 43
        Me.txtItemApp2.Text = ""
        Me.txtItemApp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemWt2
        '
        Me.txtItemWt2.AutoSize = False
        Me.txtItemWt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemWt2.Enabled = False
        Me.txtItemWt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemWt2.Location = New System.Drawing.Point(697, 58)
        Me.txtItemWt2.MaxLength = 5
        Me.txtItemWt2.Name = "txtItemWt2"
        Me.txtItemWt2.ReadOnly = True
        Me.txtItemWt2.Size = New System.Drawing.Size(86, 20)
        Me.txtItemWt2.TabIndex = 42
        Me.txtItemWt2.Text = ""
        Me.txtItemWt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemSortingCls2
        '
        Me.txtItemSortingCls2.AutoSize = False
        Me.txtItemSortingCls2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSortingCls2.Enabled = False
        Me.txtItemSortingCls2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSortingCls2.Location = New System.Drawing.Point(601, 58)
        Me.txtItemSortingCls2.MaxLength = 1
        Me.txtItemSortingCls2.Name = "txtItemSortingCls2"
        Me.txtItemSortingCls2.ReadOnly = True
        Me.txtItemSortingCls2.Size = New System.Drawing.Size(95, 20)
        Me.txtItemSortingCls2.TabIndex = 41
        Me.txtItemSortingCls2.Text = ""
        '
        'txtItemCarat2
        '
        Me.txtItemCarat2.AutoSize = False
        Me.txtItemCarat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCarat2.Enabled = False
        Me.txtItemCarat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCarat2.Location = New System.Drawing.Point(539, 58)
        Me.txtItemCarat2.MaxLength = 5
        Me.txtItemCarat2.Name = "txtItemCarat2"
        Me.txtItemCarat2.ReadOnly = True
        Me.txtItemCarat2.Size = New System.Drawing.Size(61, 20)
        Me.txtItemCarat2.TabIndex = 40
        Me.txtItemCarat2.Text = ""
        Me.txtItemCarat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemKarat2
        '
        Me.txtItemKarat2.AutoSize = False
        Me.txtItemKarat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemKarat2.Enabled = False
        Me.txtItemKarat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemKarat2.Location = New System.Drawing.Point(478, 58)
        Me.txtItemKarat2.MaxLength = 6
        Me.txtItemKarat2.Name = "txtItemKarat2"
        Me.txtItemKarat2.ReadOnly = True
        Me.txtItemKarat2.Size = New System.Drawing.Size(60, 20)
        Me.txtItemKarat2.TabIndex = 39
        Me.txtItemKarat2.Text = ""
        Me.txtItemKarat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemQty2
        '
        Me.txtItemQty2.AutoSize = False
        Me.txtItemQty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemQty2.Enabled = False
        Me.txtItemQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemQty2.Location = New System.Drawing.Point(419, 58)
        Me.txtItemQty2.Name = "txtItemQty2"
        Me.txtItemQty2.ReadOnly = True
        Me.txtItemQty2.Size = New System.Drawing.Size(58, 20)
        Me.txtItemQty2.TabIndex = 38
        Me.txtItemQty2.Text = "1"
        Me.txtItemQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemDesc2
        '
        Me.txtItemDesc2.AutoSize = False
        Me.txtItemDesc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDesc2.Enabled = False
        Me.txtItemDesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc2.Location = New System.Drawing.Point(100, 58)
        Me.txtItemDesc2.Name = "txtItemDesc2"
        Me.txtItemDesc2.ReadOnly = True
        Me.txtItemDesc2.Size = New System.Drawing.Size(317, 20)
        Me.txtItemDesc2.TabIndex = 37
        Me.txtItemDesc2.Text = ""
        '
        'txtItemApp1
        '
        Me.txtItemApp1.AutoSize = False
        Me.txtItemApp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemApp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemApp1.Location = New System.Drawing.Point(784, 37)
        Me.txtItemApp1.MaxLength = 7
        Me.txtItemApp1.Name = "txtItemApp1"
        Me.txtItemApp1.ReadOnly = True
        Me.txtItemApp1.Size = New System.Drawing.Size(136, 20)
        Me.txtItemApp1.TabIndex = 35
        Me.txtItemApp1.Text = ""
        Me.txtItemApp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemWt1
        '
        Me.txtItemWt1.AutoSize = False
        Me.txtItemWt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemWt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemWt1.Location = New System.Drawing.Point(697, 37)
        Me.txtItemWt1.MaxLength = 5
        Me.txtItemWt1.Name = "txtItemWt1"
        Me.txtItemWt1.Size = New System.Drawing.Size(86, 20)
        Me.txtItemWt1.TabIndex = 34
        Me.txtItemWt1.Text = ""
        Me.txtItemWt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemSortingCls1
        '
        Me.txtItemSortingCls1.AutoSize = False
        Me.txtItemSortingCls1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemSortingCls1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemSortingCls1.Location = New System.Drawing.Point(601, 37)
        Me.txtItemSortingCls1.MaxLength = 1
        Me.txtItemSortingCls1.Name = "txtItemSortingCls1"
        Me.txtItemSortingCls1.ReadOnly = True
        Me.txtItemSortingCls1.Size = New System.Drawing.Size(95, 20)
        Me.txtItemSortingCls1.TabIndex = 33
        Me.txtItemSortingCls1.Text = "O"
        '
        'txtItemCarat1
        '
        Me.txtItemCarat1.AutoSize = False
        Me.txtItemCarat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCarat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemCarat1.Location = New System.Drawing.Point(539, 37)
        Me.txtItemCarat1.MaxLength = 5
        Me.txtItemCarat1.Name = "txtItemCarat1"
        Me.txtItemCarat1.Size = New System.Drawing.Size(61, 20)
        Me.txtItemCarat1.TabIndex = 32
        Me.txtItemCarat1.Text = ""
        Me.txtItemCarat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemKarat1
        '
        Me.txtItemKarat1.AutoSize = False
        Me.txtItemKarat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemKarat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemKarat1.Location = New System.Drawing.Point(478, 37)
        Me.txtItemKarat1.MaxLength = 2
        Me.txtItemKarat1.Name = "txtItemKarat1"
        Me.txtItemKarat1.Size = New System.Drawing.Size(60, 20)
        Me.txtItemKarat1.TabIndex = 31
        Me.txtItemKarat1.Text = ""
        Me.txtItemKarat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemQty1
        '
        Me.txtItemQty1.AutoSize = False
        Me.txtItemQty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemQty1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemQty1.Location = New System.Drawing.Point(419, 37)
        Me.txtItemQty1.Name = "txtItemQty1"
        Me.txtItemQty1.ReadOnly = True
        Me.txtItemQty1.Size = New System.Drawing.Size(58, 20)
        Me.txtItemQty1.TabIndex = 30
        Me.txtItemQty1.Text = "1"
        Me.txtItemQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtItemDesc1
        '
        Me.txtItemDesc1.AutoSize = False
        Me.txtItemDesc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDesc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtItemDesc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDesc1.Location = New System.Drawing.Point(100, 37)
        Me.txtItemDesc1.MaxLength = 150
        Me.txtItemDesc1.Name = "txtItemDesc1"
        Me.txtItemDesc1.Size = New System.Drawing.Size(317, 20)
        Me.txtItemDesc1.TabIndex = 29
        Me.txtItemDesc1.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(15, 19)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(905, 80)
        Me.ListView1.TabIndex = 12
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM CODE"
        Me.ColumnHeader1.Width = 86
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DESCRIPTION"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 318
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 59
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "KARAT"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 61
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CARAT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 61
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "SORTING CLASS"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 98
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "WEIGHT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 86
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "APPRRAISED VALUE    "
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 141
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ITEM CODE"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 0
        '
        'txtLoanValue
        '
        Me.txtLoanValue.AutoSize = False
        Me.txtLoanValue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLoanValue.Location = New System.Drawing.Point(478, 120)
        Me.txtLoanValue.Name = "txtLoanValue"
        Me.txtLoanValue.Size = New System.Drawing.Size(120, 23)
        Me.txtLoanValue.TabIndex = 74
        Me.txtLoanValue.Text = ""
        Me.txtLoanValue.Visible = False
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
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(424, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 167)
        Me.GroupBox2.TabIndex = 160
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label28.Location = New System.Drawing.Point(136, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(224, 23)
        Me.Label28.TabIndex = 21
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Location = New System.Drawing.Point(136, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(224, 23)
        Me.Label27.TabIndex = 20
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Location = New System.Drawing.Point(136, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(384, 23)
        Me.Label26.TabIndex = 19
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Location = New System.Drawing.Point(136, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(384, 23)
        Me.Label25.TabIndex = 18
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Location = New System.Drawing.Point(136, 40)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(384, 23)
        Me.Label24.TabIndex = 17
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Location = New System.Drawing.Point(136, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(224, 23)
        Me.Label23.TabIndex = 16
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Tel # :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Customer City :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Gender :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Customer Address :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Customer Name :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Customer ID# :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 184)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 61)
        Me.GroupBox4.TabIndex = 162
        Me.GroupBox4.TabStop = False
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(144, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(192, 23)
        Me.Label34.TabIndex = 103
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 23)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Branch Name : "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 248)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 102)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pawn Ticket Information"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label22.Location = New System.Drawing.Point(136, 68)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(216, 23)
        Me.Label22.TabIndex = 12
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label21.Location = New System.Drawing.Point(136, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 23)
        Me.Label21.TabIndex = 11
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label20.Location = New System.Drawing.Point(136, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 23)
        Me.Label20.TabIndex = 10
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Appraiser :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pawn Ticket Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pawn Ticket Time :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(990, 494)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lblReceiverIDNo)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lblReceiverName)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bleh1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 719)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS V5.2 Synergy Showroom"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
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
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim dr As SqlDataReader
            Dim i As Integer
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("select action_type,action_id from tbl_action where action_id in (4,3,8) order by action_type")
            dr = objclass.OpenDataReader5
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(Trim(UCase(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            'objclass.Execute5()
            objclass.Close5()

            txtBranchCode.Enabled = True
            txtbrname.Enabled = True
            Me.txtItemCode1.ReadOnly = True
            Me.btnNew.Visible = False
            Me.cmbLOTno.Visible = False
            Me.Label36.Visible = False
            Me.CenterToScreen()
            txt3.Text = Now.Year

            Me.cmbLOTno.Items.Clear()
            Me.ListView1.Height = 78
            Me.ListView1.Width = 904
            Call Clear()
            lblReceiverName.Text = UCase(fullname)
            lblReceiverIDNo.Text = idnumber
            Label44.Visible = True
            txtAll.Focus()
            ComboBox4.Text = "Goodstock"
            'Me.txtItemCode1.ReadOnly = True

            'Me.CenterToScreen()
            'Me.Button3.Enabled = False
            'Dim dr As SqlDataReader
            'Dim i As Integer
            'objclass = New clsCommon
            'objclass.ConnDb()
            'objclass.Open5()
            'objclass.Command5("select action_type,action_id from tbl_action where action_id in (4,6,1,3,8,11) order by action_type")
            'dr = objclass.OpenDataReader5
            'i = 0
            'While dr.Read
            '    ReDim Preserve sAction(i)
            '    ComboBox4.Items.Add(Trim(dr.Item("action_type")))
            '    sAction(i) = Trim(dr.Item("action_id"))
            '    i = i + 1
            'End While
            'dr.Close()
            ''objclass.Execute5()
            'objclass.Close5()

            'Call SelectAction(objclass.action.GoodStock)
            'txt3.Text = Now.Year

            'lblReceiverIDNo.Text = UserPassW
            'lblReceiverName.Text = userLog
            'Me.cmbLOTno.Items.Clear()
            'Me.ListView1.Height = 78
            'Me.ListView1.Width = 904
            ''displayLOT()
            'btnOthers_Click(sender, e)
            'Call Clear()
            'Me.Button1.Enabled = False
            ''Label43.BringToFront()
            ''Label43.Visible = True
            'txtAll.Focus()
        Catch ex As Exception
            MsgBox("Form2/Form2_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ClearText()
        Try
            Me.txtPTN.Text = ""
            Me.txtItemCode1.Text = ""
            Me.txtItemCode3.Text = ""
            Me.txtItemCode3.Text = ""
            Me.txtItemDesc1.Text = ""
            Me.txtItemDesc3.Text = ""
            Me.txtItemDesc3.Text = ""
            Me.txtItemQty1.Text = "1"
            Me.txtItemQty3.Text = "1"
            Me.txtItemQty3.Text = "1"
            Me.txtItemKarat1.Text = ""
            Me.txtItemKarat3.Text = ""
            Me.txtItemKarat3.Text = ""
            Me.txtItemCarat1.Text = ""
            Me.txtItemCarat3.Text = ""
            Me.txtItemCarat3.Text = ""
            Me.txtItemSortingCls1.Text = "O"
            Me.txtItemSortingCls3.Text = "O"
            Me.txtItemSortingCls3.Text = "O"
            Me.txtItemWt1.Text = ""
            Me.txtItemWt3.Text = ""
            Me.txtItemWt3.Text = ""
            Me.txtItemApp1.Text = ""
            Me.txtItemApp3.Text = ""
            Me.txtItemApp3.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FRVisibleFields()
        Try
            Me.ListView1.Height = 78
            Me.ListView1.Width = 904
            Me.txtPTN.Visible = False

            Me.txtItemCode1.Visible = False
            Me.txtItemCode2.Visible = False
            Me.txtItemCode3.Visible = False
            Me.txtItemDesc1.Visible = False
            Me.txtItemDesc2.Visible = False
            Me.txtItemDesc3.Visible = False
            Me.txtItemQty1.Visible = False
            Me.txtItemQty2.Visible = False
            Me.txtItemQty3.Visible = False
            Me.txtItemKarat1.Visible = False
            Me.txtItemKarat2.Visible = False
            Me.txtItemKarat3.Visible = False
            Me.txtItemCarat1.Visible = False
            Me.txtItemCarat2.Visible = False
            Me.txtItemCarat3.Visible = False
            Me.txtItemSortingCls1.Visible = False
            Me.txtItemSortingCls2.Visible = False
            Me.txtItemSortingCls3.Visible = False
            Me.txtItemWt1.Visible = False
            Me.txtItemWt2.Visible = False
            Me.txtItemWt3.Visible = False
            Me.txtItemApp1.Visible = False
            Me.txtItemApp2.Visible = False
            Me.txtItemApp3.Visible = False
        Catch ex As Exception
        End Try
    End Sub

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
            MsgBox("Form2/ConnectDB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
        End Try
    End Sub

    Public Sub visibleFields()
        Try
            Me.ComboBox1.Visible = False
            'Me.ComboBox3.Visible = False
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FRdisplayFields()
        Try
            Me.ListView1.Height = 85
            Me.ListView1.Width = 905
            Me.txtPTN.Visible = True
            Me.txtItemCode1.Visible = True
            Me.txtItemCode2.Visible = True
            Me.txtItemCode3.Visible = True
            Me.txtItemDesc1.Visible = True
            Me.txtItemDesc2.Visible = True
            Me.txtItemDesc3.Visible = True
            Me.txtItemQty1.Visible = True
            Me.txtItemQty2.Visible = True
            Me.txtItemQty3.Visible = True
            Me.txtItemKarat1.Visible = True
            Me.txtItemKarat2.Visible = True
            Me.txtItemKarat3.Visible = True
            Me.txtItemCarat1.Visible = True
            Me.txtItemCarat2.Visible = True
            Me.txtItemCarat3.Visible = True
            Me.txtItemSortingCls1.Visible = True
            Me.txtItemSortingCls2.Visible = True
            Me.txtItemSortingCls3.Visible = True
            Me.txtItemWt1.Visible = True
            Me.txtItemWt2.Visible = True
            Me.txtItemWt3.Visible = True
            Me.txtItemApp1.Visible = True
            Me.txtItemApp2.Visible = True
            Me.txtItemApp3.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Clear()
        Try
            Me.txtAll.Text = ""
            Me.txtPTN.Text = ""
            Me.txtItemCode1.Text = ""
            Me.txtItemCode2.Text = ""
            Me.txtItemCode3.Text = ""
            Me.txtItemDesc1.Text = ""
            Me.txtItemDesc2.Text = ""
            Me.txtItemDesc3.Text = ""
            GroupBox7.Visible = False
            Me.txtItemKarat1.Text = ""
            Me.txtItemKarat2.Text = ""
            Me.txtItemKarat3.Text = ""
            Me.txtItemCarat1.Text = ""
            Me.txtItemCarat2.Text = ""
            Me.txtItemCarat3.Text = ""
            Me.txtItemSortingCls1.Text = "O"
            Me.txtItemSortingCls2.Text = "O"
            Me.txtItemSortingCls3.Text = "O"

            Me.txtItemWt1.Text = ""
            Me.txtItemWt2.Text = ""
            Me.txtItemWt3.Text = ""
            Me.txtItemApp1.Text = ""
            Me.txtItemApp2.Text = ""
            Me.txtItemApp3.Text = ""
            Me.ComboBox4.SelectedIndex = -1
            'Label34.Text = ""
            'Label43.Text = ""

            ComboBox1.Text = ""

            ComboBox1.SelectedText = ""

            'txtBranchCode.Text = ""
            'txtbrname.Text = ""
            ListView1.Items.Clear()
            Button4.Enabled = False
            flag = False
            fl = False
            bEdit = False
            tempflag = False
            sid = 0
            temp_MPTN = Nothing

            Me.txtItemQty1.Text = "1"
            Me.txtItemQty2.Text = "1"
            Me.txtItemQty3.Text = "1"
            txt1.Text = ""
            txtBranchCode.Text = ""
            txtbrname.Text = ""
            ComboBox4.Text = "Goodstock"
            txtAll.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            Me.Label44.Visible = True
            Me.txtAll.Visible = True

            Me.ComboBox1.Visible = False

            Me.txtAll.BringToFront()

            Me.txtAll.Focus()
            cmbLOTno.Text = GenerateLot()
            ret = True
            Me.cmbcostcenter.SetBounds(112, 128, 168, 24)
            'Me.cmbCostCenter.SetBounds(112, 160, 168, 24)
            'Me.Label43.SetBounds(24, 128, 72, 23)
            Me.txtBranchCode.Enabled = False
            Me.txtbrname.Enabled = False
            Clear()
            txtAll.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOutsource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Shell("Notepad.exe", AppWinStyle.NormalFocus, True)
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""
            Me.Label44.Visible = True
            Me.txtAll.Visible = True
            Me.ComboBox1.Visible = False
            Me.txtAll.BringToFront()
            outsource = True
            Me.txtAll.Focus()
            Me.cmbcostcenter.SetBounds(112, 128, 168, 24)
            'Me.cmbCostCenter.SetBounds(112, 160, 168, 24)
            'Me.Label43.SetBounds(24, 128, 72, 23)
            Me.txtBranchCode.Enabled = False
            Me.txtbrname.Enabled = False
            Clear()
            Me.Timer1.Enabled = False
            visibleFields()
            FRdisplayFields()
            'FRVisibleFields()
            ret = False
            Button2.Text = "Close"
            Button1.Enabled = True
            Me.txtItemSortingCls1.Text = "O"
            Me.txtItemSortingCls2.Text = "O"
            Me.txtItemSortingCls3.Text = "O"
            Me.txtItemQty1.Text = "1"
            Me.txtItemQty2.Text = "1"
            Me.txtItemQty3.Text = "1"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode1.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Len(txtItemCode1.Text.Trim) = 0 Then
                    MsgBox("Input Item code.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Exit Sub
                End If
                Me.txtItemDesc1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Len(txtItemCode2.Text.Trim) = 0 Then
                    MsgBox("Input Item code.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode2.Focus()
                    Exit Sub
                End If
                Me.txtItemDesc2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCode3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Len(txtItemCode3.Text.Trim) = 0 Then
                    MsgBox("Input Item code.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode3.Focus()
                    Exit Sub
                End If
                Me.txtItemDesc3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemDesc1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemDesc1.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemDesc1.Text = "" Or Len(Trim(txtItemDesc1.Text)) = 0 Then
                    MsgBox("Input Item Description.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemDesc1.Focus()
                    Exit Sub
                End If
                Me.txtItemKarat1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemDesc2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemDesc2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Len(Trim(txtItemDesc2.Text)) = 0 Then
                    MsgBox("Input Item Description.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemDesc2.Focus()
                    Exit Sub
                End If
                Me.txtItemQty2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemDesc3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemDesc3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemDesc3.Text = "" Or Len(Trim(txtItemDesc3.Text)) = 0 Then
                    MsgBox("Input Item Description.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemDesc3.Focus()
                    Exit Sub
                End If
                Me.txtItemQty3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemQty1.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemQty1.Text = "" Then
                    MsgBox("Input Quantity.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty1.Focus()
                    Exit Sub
                ElseIf CInt(txtItemQty1.Text) <= 0 Then
                    MsgBox("Invalid Quantity value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty1.Text = ""
                    Me.txtItemQty1.Focus()
                    Exit Sub
                End If
                Me.txtItemKarat1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemQty2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemQty2.Text.Trim = "" Then
                    MsgBox("Input Quantity.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty2.Focus()
                    Exit Sub
                ElseIf CInt(txtItemQty2.Text.Trim) <= 0 Then
                    MsgBox("Invalid Quantity value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty2.Text = ""
                    Me.txtItemQty2.Focus()
                    Exit Sub
                End If
                Me.txtItemKarat2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemQty3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemQty3.Text = "" Then
                    MsgBox("Input Quantity.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty3.Focus()
                    Exit Sub
                ElseIf CInt(txtItemQty3.Text) <= 0 Then
                    MsgBox("Invalid Quantity value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemQty3.Text = ""
                    Me.txtItemQty3.Focus()
                    Exit Sub
                End If
                Me.txtItemKarat3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemKarat1.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemKarat1.Text.Trim = "" Then
                    If txtItemCode1.Text = "400" Then
                        txtItemKarat1.Text = "0"
                        txtItemCarat1.Focus()
                    ElseIf txtItemCode1.Text <> "300" Then
                        MsgBox("Input Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemKarat1.Focus()
                        Exit Sub
                    ElseIf txtItemCode1.Text = "300" Then
                        txtItemKarat1.Text = "0"
                        txtItemCarat1.Focus()
                    End If

                ElseIf txtItemCode1.Text = "400" And txtItemKarat1.Text.Trim.ToString > 0 Then
                    MsgBox("Invalid Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat1.Text = ""
                    Me.txtItemKarat1.Focus()
                    Exit Sub
                ElseIf txtItemCode1.Text <> "300" And txtItemCode1.Text <> "400" And txtItemKarat1.Text <= 0 Then
                    MsgBox("Invalid Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat1.Text = ""
                    Me.txtItemKarat1.Focus()
                    Exit Sub
                End If
                Me.txtItemCarat1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemKarat2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemKarat2.Text.Trim = "" Then
                    MsgBox("Input Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat2.Focus()
                    Exit Sub
                ElseIf txtItemKarat2.Text.Trim.ToString <= 0 Then
                    MsgBox("Invalid Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat2.Text = ""
                    Me.txtItemKarat2.Focus()
                    Exit Sub
                End If
                Me.txtItemCarat2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemKarat3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemKarat3.Text.Trim = "" Then
                    MsgBox("Input Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat3.Focus()
                    Exit Sub
                ElseIf txtItemKarat3.Text.Trim.ToString <= 0 Then
                    MsgBox("Invalid Karat Grading.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemKarat3.Text = ""
                    Me.txtItemKarat3.Focus()
                    Exit Sub
                End If
                Me.txtItemCarat3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCarat1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCarat1.KeyDown
        If e.KeyCode = 13 Then
            If txtItemCarat1.Text = "" Then
                Me.txtItemCarat1.Text = 0
            End If

            If (txtItemCode1.Text = "300" Or txtItemCode1.Text = "400") And txtItemCarat1.Text.Trim.ToString > 0 Then
                MsgBox("Invalid Carat.", MsgBoxStyle.Information, TitleMsgBox)
                Me.txtItemCarat1.Text = ""
                Me.txtItemCarat1.Focus()
                Exit Sub
            End If

            Me.txtItemCarat1.Focus()
            If txtItemCarat1.Text = 0 Then
                Me.txtItemCarat1.Text = 0
            End If
            Me.txtItemWt1.Focus()
        End If
    End Sub

    Private Sub txtItemCarat2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCarat2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemCarat2.Text = "" Then
                    Me.txtItemCarat2.Text = 0
                End If
                Me.txtItemWt2.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCarat3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemCarat3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemCarat3.Text = "" Then
                    Me.txtItemCarat3.Text = 0
                End If
                Me.txtItemWt3.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemWt1.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemWt1.Text = "" Then
                    Me.txtItemWt1.Text = "0"
                    If txtItemCode1.Text <> "300" And txtItemCode1.Text <> "400" And txtItemWt1.Text <= 0 Then
                        MsgBox("Invalid weight.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemWt1.Text = ""
                        Me.txtItemWt1.Focus()
                        Exit Sub
                    Else
                        Button1.Enabled = True
                        Me.Button1.Focus()
                    End If

                    'End If
                Else
                    'If txtItemCode1.Text = "300" And txtItemWt1.Text.Trim.ToString > 0 Then
                    '    MsgBox("Invalid weight.", MsgBoxStyle.Information, TitleMsgBox)
                    '    Me.txtItemWt1.Text = ""
                    '    Me.txtItemWt1.Focus()
                    '    Exit Sub
                    'Else
                    If txtItemCode1.Text = "400" And txtItemWt1.Text.Trim.ToString > 0 Then
                        MsgBox("Invalid weight.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemWt1.Text = ""
                        Me.txtItemWt1.Focus()
                        Exit Sub

                    ElseIf txtItemCode1.Text <> "300" And txtItemCode1.Text <> "400" And txtItemWt1.Text <= 0 Then
                        MsgBox("Invalid weight.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemWt1.Text = ""
                        Me.txtItemWt1.Focus()
                        Exit Sub
                    End If

                    Me.txtItemWt1.Text = Format(CDbl(Me.txtItemWt1.Text.Trim), "###0.00")
                    Button1.Enabled = True
                    Me.Button1.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemWt2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPTN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPTN.KeyDown
        Try
            If e.KeyCode = 13 Then
                Me.txtItemCode1.Visible = True
                Me.txtItemCode1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPTNBarcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = 13 Then
                Me.txtItemCode1.Visible = True
                Me.txtItemCode1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPTNBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemApp1.KeyDown
        Try
            If e.KeyCode = 13 Then
                'If Me.txtItemApp1.Text.Trim = "" Then
                '    MsgBox("Input a valid value for Item Appraise Value.", MsgBoxStyle.Information, TitleMsgBox)
                '    Me.txtItemApp1.Text = ""
                '    Me.txtItemApp1.Focus()
                '    Exit Sub
                'ElseIf CDbl(Me.txtItemApp1.Text.Trim) = 0 Then
                '    MsgBox("Invalid Input.", MsgBoxStyle.Information, TitleMsgBox)
                '    Me.txtItemApp1.Text = ""
                '    Me.txtItemApp1.Focus()
                '    Exit Sub
                'Else
                '    If Me.txtAll.Text.Length = 0 Then
                '        Me.txtItemApp1.Text = Format(Me.txtItemApp1.Text.Trim, "standard")
                '        Me.txtItemCode2.Focus()
                '    Else
                '        Button1.Focus()
                '    End If

                'End If

                Button1.Focus()

                If Me.txtItemApp1.Text.Trim = "" Then
                    Me.txtItemCode2.ReadOnly = True
                Else
                    Me.txtItemCode2.ReadOnly = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemApp2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Me.txtItemApp2.Text.Trim = "" Then
                    MsgBox("Input a valid value for Item Appraise Value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemApp2.Text = ""
                    Me.txtItemApp2.Focus()
                    Exit Sub
                ElseIf CDbl(Me.txtItemApp2.Text.Trim) = 0 Then
                    MsgBox("Invalid Input.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemApp2.Text = ""
                    Me.txtItemApp2.Focus()
                    Exit Sub
                Else
                    Me.txtItemApp2.Text = Format(Me.txtItemApp2.Text.Trim, "standard")
                    Me.txtItemCode3.Focus()
                End If
                If Me.txtItemApp2.Text.Trim = "" Then
                    Me.txtItemCode3.ReadOnly = True
                Else
                    Me.txtItemCode3.ReadOnly = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemApp3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If Me.txtItemApp3.Text.Trim = "" Then
                    MsgBox("Input a valid value for Item Appraise Value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemApp3.Text = ""
                    Me.txtItemApp3.Focus()
                    Exit Sub
                ElseIf CDbl(Me.txtItemApp3.Text.Trim) = 0 Then
                    MsgBox("Invalid Input.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemApp3.Text = ""
                    Me.txtItemApp3.Focus()
                    Exit Sub
                Else
                    Me.txtItemApp3.Text = Format(Me.txtItemApp3.Text.Trim, "standard")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemWt1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                Me.Button1.Focus()
            End If

            If txtItemWt1.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemWt2.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemWt2.Text = "" Then
                    MsgBox("Input weight value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemWt2.Focus()
                    Exit Sub
                Else
                    If CDbl(txtItemWt2.Text) <= 0 Then
                        MsgBox("Invalid weight value.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemWt2.Text = ""
                        Me.txtItemWt2.Focus()
                        Exit Sub
                    Else
                        Me.txtItemWt2.Text = Format(CDbl(txtItemWt2.Text.Trim), "###0.00")
                        Me.txtItemApp2.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemWt3.KeyDown
        Try
            If e.KeyCode = 13 Then
                If txtItemWt3.Text = "" Then
                    MsgBox("Input weight value.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemWt3.Focus()
                    Exit Sub
                Else
                    If CDbl(txtItemWt3.Text) <= 0 Then
                        MsgBox("Invalid weight value.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemWt3.Text = ""
                        Me.txtItemWt3.Focus()
                        Exit Sub
                    Else
                        Me.txtItemWt3.Text = Format(CDbl(Me.txtItemWt3.Text.Trim), "###0.00")
                        Me.txtItemApp3.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemApp1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemWt3.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItemCode1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If txtItemCode1.Text.Length > 2 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode3.KeyPress

        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemApp2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemApp3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemKarat1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemQty2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemQty3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemQty1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemQty1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemKarat3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtLoanValue_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode1.TextChanged
        Try
            txtItemApp1.Enabled = False
            If txtItemCode1.Text = "" Then
                txtItemDesc1.ReadOnly = True
                txtItemDesc1.Clear()

                txtItemQty1.ReadOnly = True
                txtItemQty1.Clear()

                txtItemKarat1.ReadOnly = True
                txtItemKarat1.Clear()

                txtItemCarat1.ReadOnly = True
                txtItemCarat1.Clear()

                txtItemSortingCls1.ReadOnly = True
                txtItemSortingCls1.Text = "O"

                txtItemWt1.ReadOnly = True
                txtItemWt1.Clear()

                txtItemApp1.ReadOnly = True
                txtItemApp1.Clear()

                txtItemCode2.ReadOnly = True
                txtItemCode2.Clear()

                txtItemCode3.ReadOnly = True
                txtItemCode3.Clear()
            Else

                txtItemDesc1.ReadOnly = False
                txtItemQty1.ReadOnly = True
                txtItemKarat1.ReadOnly = False
                txtItemCarat1.ReadOnly = False
                txtItemSortingCls1.ReadOnly = True
                txtItemWt1.ReadOnly = False
                txtItemApp1.ReadOnly = False

                'txtItemCode3.ReadOnly = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode2.TextChanged
        Try
            If txtItemCode2.Text = "" Then
                txtItemDesc2.ReadOnly = True
                txtItemDesc2.Clear()

                txtItemQty2.ReadOnly = True
                txtItemQty2.Clear()

                txtItemKarat2.ReadOnly = True
                txtItemKarat2.Clear()

                txtItemCarat2.ReadOnly = True
                txtItemCarat2.Clear()

                txtItemSortingCls2.ReadOnly = True
                txtItemSortingCls2.Text = "O"

                txtItemWt2.ReadOnly = True
                txtItemWt2.Clear()

                txtItemApp2.ReadOnly = True
                txtItemApp2.Clear()
            Else
                txtItemDesc2.ReadOnly = True
                txtItemQty2.ReadOnly = True
                txtItemKarat2.ReadOnly = True
                txtItemCarat2.ReadOnly = True
                txtItemSortingCls2.ReadOnly = True
                txtItemWt2.ReadOnly = True
                txtItemApp2.ReadOnly = True
                'txtItemCode3.ReadOnly = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemCode3.TextChanged
        Try
            If txtItemCode3.Text = "" Then
                txtItemDesc3.ReadOnly = True
                txtItemDesc3.Clear()

                txtItemQty3.ReadOnly = True
                txtItemQty3.Clear()

                txtItemKarat3.ReadOnly = True
                txtItemKarat3.Clear()

                txtItemCarat3.ReadOnly = True
                txtItemCarat3.Clear()

                txtItemSortingCls3.ReadOnly = True
                txtItemSortingCls3.Text = "O"

                txtItemWt3.ReadOnly = True
                txtItemWt3.Clear()

                txtItemApp3.ReadOnly = True
                txtItemApp3.Clear()
            Else
                txtItemDesc3.ReadOnly = True
                txtItemQty3.ReadOnly = True
                txtItemKarat3.ReadOnly = True
                txtItemCarat3.ReadOnly = True
                txtItemSortingCls3.ReadOnly = True
                txtItemWt3.ReadOnly = True
                txtItemApp3.ReadOnly = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtLoanValue_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = 13 Then
                'If Len(txtLoanValue.Text) = 0 Then
                '    MsgBox("Input Loan Amount", MsgBoxStyle.Information, TitleMsgBox)
                '    txtLoanValue.Focus()
                '    Exit Sub
                'End If

                'If CDbl(txtLoanValue.Text.Trim) > CDbl(Me.Label33.Text.Trim) Then
                '    MsgBox("OverAppraised Value", MsgBoxStyle.Information, TitleMsgBox)
                '    Me.txtLoanValue.Text = ""
                '    Me.txtLoanValue.Focus()
                '    Exit Sub
                'End If

                Button1.Focus()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemKarat2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemKarat2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCode2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCode2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCarat1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCarat1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If txtItemCarat1.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCarat2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCarat2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemCarat3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemCarat3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub clear_me()
        Try
            ListView1.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            Dim dr As SqlDataReader

            ff = 0
            If e.KeyCode = Keys.Enter Then
                iFocus = 14
                'get branch name in the bedryf table
                getBedryf1()

            End If
        Catch ex As Exception
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

                str = "Select top 1 * from " & bedryf2 & " where bedrnm like '%" + txtbrname.Text.Trim + "%'"

                objclass.Command5(str)
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    txtBranchCode.Text = Trim(dr.Item("bedrnr"))
                    txtbrname.Text = Trim(dr.Item("bedrnm"))

                    ff = 1
                Else
                    MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
                objclass = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub sumApp()
        Try
            Dim t1, t2, t3 As String
            If Me.txtItemApp1.Text = "" Or Not IsNumeric(Me.txtItemApp1.Text) Then
                t1 = "0"
            Else
                t1 = Me.txtItemApp1.Text
            End If
            If Me.txtItemApp2.Text = "" Or Not IsNumeric(Me.txtItemApp2.Text) Then
                t2 = "0"
            Else
                t2 = Me.txtItemApp2.Text
            End If
            If Me.txtItemApp3.Text = "" Or Not IsNumeric(Me.txtItemApp3.Text) Then
                t3 = "0"
            Else
                t3 = Me.txtItemApp3.Text
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemApp1.TextChanged
        Try
            sumApp()
            If txtItemApp1.Text = "" Then
                txtItemDesc3.ReadOnly = True
                txtItemDesc3.Clear()

                txtItemDesc3.ReadOnly = True
                txtItemDesc3.Clear()

                txtItemQty3.ReadOnly = True
                txtItemQty3.Clear()

                txtItemKarat3.ReadOnly = True
                txtItemKarat3.Clear()

                txtItemCarat3.ReadOnly = True
                txtItemCarat3.Clear()

                txtItemSortingCls3.ReadOnly = True
                txtItemSortingCls3.Text = "O"

                txtItemWt3.ReadOnly = True
                txtItemWt3.Clear()

                txtItemApp3.ReadOnly = True
                txtItemApp3.Clear()

                txtItemCode2.ReadOnly = True
                txtItemCode2.Clear()

                txtItemDesc2.ReadOnly = True
                txtItemDesc2.Clear()

                txtItemQty2.ReadOnly = True
                txtItemQty2.Clear()

                txtItemKarat2.ReadOnly = True
                txtItemKarat2.Clear()

                txtItemCarat2.ReadOnly = True
                txtItemCarat2.Clear()

                txtItemSortingCls2.ReadOnly = True
                txtItemSortingCls2.Text = "O"

                txtItemWt2.ReadOnly = True
                txtItemWt2.Clear()

                txtItemApp2.ReadOnly = True
                txtItemApp2.Clear()

                txtItemCode2.ReadOnly = True
                txtItemCode2.Clear()
            End If
            If Me.txtItemApp1.Text <> "" Then
                Me.Button1.Enabled = True
            ElseIf Me.txtItemApp1.Text = "" Then
                Me.Button1.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemApp2.TextChanged
        Try
            sumApp()
            If txtItemApp3.Text.Trim = "" Then
                txtItemDesc3.ReadOnly = True
                txtItemDesc3.Clear()

                txtItemQty3.ReadOnly = True
                txtItemQty3.Clear()

                txtItemKarat3.ReadOnly = True
                txtItemKarat3.Clear()

                txtItemCarat3.ReadOnly = True
                txtItemCarat3.Clear()

                txtItemSortingCls3.ReadOnly = True
                txtItemSortingCls3.Text = "O"

                txtItemCode3.ReadOnly = True
                txtItemCode3.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemApp3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItemApp3.TextChanged
        Try
            sumApp()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub getBedryf1()
        Try
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()

            ' objclass.Command5("Select * from " & bedryf2 & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            If UCase(sDB) = "LUZON" Then
                objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "VISMIN" Then
                objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "MINDANAO" Then
                objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            ElseIf UCase(sDB) = "LNCR" Then
                objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            End If

            dr = objclass.OpenDataReader5

            If dr.Read Then
                txtbrname.Text = Trim(dr.Item("bedrnm"))
                ff = 1
            Else
                MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Focus()
            End If
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Public Sub MainFeildsShow()
        Try
            Me.ComboBox1.Visible = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If (isForce = True) Or (oForce = True) Or ret = True Or outsource = True Then
                ClearText()
                FRVisibleFields()
                MainFeildsShow()
                Me.Button2.Text = "Close"
                Me.txtAll.Visible = False
                Me.ComboBox1.Visible = True
                Me.ComboBox1.BringToFront()
                Me.txtBranchCode.Enabled = True
                Me.txtbrname.Enabled = True
                Me.txtBranchCode.Focus()
                Me.ListView1.Items.Clear()
                Me.cmbcostcenter.SetBounds(112, 160, 168, 24)
                'Me.Label43.SetBounds(32, 160, 72, 23)
                isForce = False
                oForce = False
                ret = False
                outsource = False
            Else
                Me.Dispose()
                cn = Nothing
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Function Trappings() As Boolean
        Try
            Trappings = False

            If Me.isForce = True Then
                If Me.txtPTN.Text = "" Then
                    MsgBox("Input a PTN.", MsgBoxStyle.Information, TitleMsgBox)
                    txtPTN.Focus()
                    Trappings = True
                    Exit Function
                End If

                If Len(Me.txtItemApp1.Text) = 0 Then
                    txtItemApp1.Text = 0
                End If
                'Else

                '    If TextBox15.Text = "" Then
                '        MsgBox("Input a PTN.", MsgBoxStyle.Information, TitleMsgBox)
                '        TextBox15.Focus()
                '        Trappings = True
                '        Exit Function
                '    End If

            End If

            If Me.cmbcostcenter.Text.Trim = "" Then
                MsgBox("Select Cost Center.", MsgBoxStyle.Information, TitleMsgBox)
                Me.cmbcostcenter.Focus()
                Trappings = True
                Exit Function
            End If

            If isForce = True Then
                'trap item
                If Len(Me.txtItemCode1.Text.Trim) = 0 And Len(Me.txtItemCode2.Text.Trim) = 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                    MsgBox("Input Item data.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Trappings = True
                    Exit Function
                End If

                '1 item
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) = 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                    If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 Then
                    Else
                        MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemCode1.Focus()
                        Trappings = True
                        Exit Function
                    End If
                End If

                '2 item
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                    If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 And _
                    Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 And Len(Me.txtItemApp2.Text.Trim) <> 0 Then
                    Else
                        MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemCode1.Focus()
                        Trappings = True
                        Exit Function
                    End If
                End If

                '3 item
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) <> 0 Then
                    If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 And _
                    Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 And Len(Me.txtItemApp2.Text.Trim) <> 0 And _
                    Len(Me.txtItemCode3.Text.Trim) <> 0 And Len(Me.txtItemDesc3.Text.Trim) <> 0 And Len(Me.txtItemQty3.Text.Trim) <> 0 And Len(Me.txtItemKarat3.Text.Trim) <> 0 And Len(Me.txtItemCarat3.Text.Trim) <> 0 And Len(Me.txtItemSortingCls3.Text.Trim) <> 0 And Len(Me.txtItemWt3.Text.Trim) <> 0 And Len(Me.txtItemApp3.Text.Trim) <> 0 Then
                    Else
                        MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtItemCode1.Focus()
                        Trappings = True
                        Exit Function
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Form2/Trappings: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function REMGenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim sss As String



            'MsgBox('" & FormatLot & "' '" & userlog & "')
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()




            sss = "if (select Count([REMS" & sDB & "].dbo.ASYS_REM_Detail.reflotno) as lotno from [REMS" & sDB & "].dbo.ASYS_REM_Detail  where "
            sss = sss + " ( [REMS" & sDB & "].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND ( [REMS" & sDB & "].dbo.ASYS_REM_detail.actionclass = '" & ComboBox4.Text.Trim & "') and"
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
            sss = sss + " ( [REMS" & sDB & "].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND ( [REMS" & sDB & "].dbo.ASYS_REM_detail.actionclass = '" & ComboBox4.Text.Trim & "') and "
            sss = sss + " (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_Detail.RefLotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " AND (CAST(SUBSTRING( [REMS" & sDB & "].dbo.ASYS_REM_Detail.RefLotno, 1, 4) AS int(2)) = YEAR(GETDATE()))"




            'objclass.Command3("if (Select Count(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) <> 0 begin If (select Max(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) > (Select Max(reclotno) as lotno from rems.dbo.tbl_receiving_header) begin Select Coalesce(Max(lotno_for),(Select Max(lotno_for) from tbl_forcedoutrcv) + 1) as lotno from rems.dbo.tbl_forcedoutrcv where recname_for ='" & userLog & "'  and day(receivedate_FOR) = day(getdate()) and Month(receivedate_FOR)= MOnth(getdate()) and year(receivedate_FOR) = Year(getdate())end else	Select Coalesce(Max(reclotno),(select max(reclotno) from tbl_receiving_header) + 1) as lotno from rems.dbo.tbl_receiving_header where recname ='" & userLog & "' and day(receivedate) = day(getdate()) and Month(receivedate)= MOnth(getdate()) and year(receivedate) = Year(getdate()) end else Select Isnull(Max(reclotno) + 1," & FormatLot & ") as lotno from rems.dbo.tbl_receiving_header ")
            objclass.Command3(sss)
            dr = objclass.OpenDataReader3
            If dr.Read Then
                REMGenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            'objclass.Execute3()
            objclass.Close3()


        Catch ex As Exception
            MsgBox("Form2/REMGenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function

    Private Function GenerateLot() As String
        Try
            Dim dr As SqlDataReader
            Dim sss As String



            'MsgBox('" & FormatLot & "' '" & userlog & "')
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()




            sss = "if (select Count([REMS].dbo.ASYS_REM_Detail.reflotno) as lotno from [REMS].dbo.ASYS_REM_Detail  where "
            sss = sss + " ( [REMS].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND "
            sss = sss + " (CAST(SUBSTRING( [REMS].dbo.ASYS_REM_Detail.RefLotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " AND (CAST(SUBSTRING( [REMS].dbo.ASYS_REM_Detail.RefLotno, 1, 4) AS int(2)) = YEAR(GETDATE()))) = 0 "
            sss = sss + " begin "
            sss = sss + "   if (Select Count(LOTNO) as lotno from REMS.dbo.ASYS_LOTNO_gen  where  (CAST(SUBSTRING(Lotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " and (CAST(SUBSTRING(LOTNO, 1, 4) AS int(2)) = YEAR(GETDATE()))) = 0"
            sss = sss + "  begin "
            sss = sss + "   select  Cast(YEar(getdate()) as char(4)) + Cast(REPLACE(STR(month(getdate()), 2, 0), SPACE(1), '0')  as char(2))"
            sss = sss + " + '0001' LOTNO   from [REMS].dbo.ASYS_LOTNO_Gen "
            sss = sss + "  end else"
            sss = sss + "   select LOTNO from [REMS].dbo.ASYS_lotno_Gen "
            sss = sss + " end  else"
            sss = sss + "  select Isnull(Max(reflotno),0) as lotno from [REMS].dbo.ASYS_REM_Detail  where "
            sss = sss + " ( [REMS].dbo.ASYS_REM_detail.SorterName = '" & userLog & "') AND "
            sss = sss + " (CAST(SUBSTRING( [REMS].dbo.ASYS_REM_Detail.RefLotno, 5, 2) AS int(2)) = MONTH(GETDATE()))"
            sss = sss + " AND (CAST(SUBSTRING( [REMS].dbo.ASYS_REM_Detail.RefLotno, 1, 4) AS int(2)) = YEAR(GETDATE()))"




            'objclass.Command3("if (Select Count(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) <> 0 begin If (select Max(lotno_for) as lotno from rems.dbo.tbl_forcedoutrcv) > (Select Max(reclotno) as lotno from rems.dbo.tbl_receiving_header) begin Select Coalesce(Max(lotno_for),(Select Max(lotno_for) from tbl_forcedoutrcv) + 1) as lotno from rems.dbo.tbl_forcedoutrcv where recname_for ='" & userLog & "'  and day(receivedate_FOR) = day(getdate()) and Month(receivedate_FOR)= MOnth(getdate()) and year(receivedate_FOR) = Year(getdate())end else	Select Coalesce(Max(reclotno),(select max(reclotno) from tbl_receiving_header) + 1) as lotno from rems.dbo.tbl_receiving_header where recname ='" & userLog & "' and day(receivedate) = day(getdate()) and Month(receivedate)= MOnth(getdate()) and year(receivedate) = Year(getdate()) end else Select Isnull(Max(reclotno) + 1," & FormatLot & ") as lotno from rems.dbo.tbl_receiving_header ")
            objclass.Command3(sss)
            dr = objclass.OpenDataReader3
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            'objclass.Execute3()
            objclass.Close3()


        Catch ex As Exception
            MsgBox("Form2/GenerateLot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function

    Private Function GenerateLotNo1() As String
        Try
            Dim dr As SqlDataReader
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps, sss As String
            Dim obj As New clsCommon




            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            sss = "Select lotno from ASYS_LOTNO_Gen"
            obj.Command3(sss)
            dr = obj.OpenDataReader3
            If dr.Read Then
                GenerateLotNo1 = dr.Item("lotno")
            End If
            dr.Close()
            'obj.Execute3()
            obj.Close3()

        Catch ex As Exception
            MsgBox("Form2/GenerateLotNo1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Function

    Private Function FormatLotNo(ByVal strLotNo As String) As String
        Try
            Dim li_count As Integer
            Dim ls_zero As String
            Dim ls_lotno As String
            Dim ls_year As String
            Dim ls_month As String

            ls_year = CStr(Year(Today))
            ls_month = CStr(Month(Today))

            If ls_month.Length = 1 Then
                ls_month = "0" & ls_month
            End If

            If strLotNo.Length < 4 Then
                For li_count = 1 To (4 - strLotNo.Length)
                    ls_zero += "0"
                Next
                ls_lotno = ls_year & ls_month & ls_zero & strLotNo
            Else
                ls_lotno = ls_year & ls_month & "001"
            End If

            FormatLotNo = ls_lotno
        Catch ex As Exception
            MsgBox("Form2/FormatLotNo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function checkduplicate() As Boolean
        Try
            Dim cm As New clsCommon
            Dim dr As SqlClient.SqlDataReader
            Dim stats As String = ""

            checkduplicate = False
            cm.ConnectionString1()
            cm.Open()
            cm.Command("Select lotno from ASYS_REMOutsource_header where lotno = '" + Me.cmbLOTno.Text + "'")
            dr = cm.OpenDataReader
            If dr.Read = True Then
                checkduplicate = True
            End If
            dr.Close()
            cm.Close()
        Catch ex As Exception
        End Try
    End Function

    Private Sub saveITemReceiving()
        Try
            Dim STRINGSQL As String = ""
            Dim cm As New SqlClient.SqlCommand
            Dim s_id As Integer = 0
            Dim temp_bleh As String


            'ConnectDB()
            'IF 1 ITEM
            If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) = 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 Then
                    temp_bleh = CStr(bleh1.Text)
                    cm.Connection = cn
                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()
                Else
                    MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Exit Sub
                End If
            End If

            'IF 2 ITEMs
            If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 And _
                Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 And Len(Me.txtItemApp2.Text.Trim) <> 0 Then
                    temp_bleh = CStr(bleh1.Text)

                    cm.Connection = cn

                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    temp_bleh = Val(bleh1.Text) + 1
                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                Else
                    MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Exit Sub
                End If
            End If

            'if 3 Items
            If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) <> 0 Then
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And Len(Me.txtItemApp1.Text.Trim) <> 0 And _
                Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 And Len(Me.txtItemApp2.Text.Trim) <> 0 And _
                Len(Me.txtItemCode3.Text.Trim) <> 0 And Len(Me.txtItemDesc3.Text.Trim) <> 0 And Len(Me.txtItemQty3.Text.Trim) <> 0 And Len(Me.txtItemKarat3.Text.Trim) <> 0 And Len(Me.txtItemCarat3.Text.Trim) <> 0 And Len(Me.txtItemSortingCls3.Text.Trim) <> 0 And Len(Me.txtItemWt3.Text.Trim) <> 0 And Len(Me.txtItemApp3.Text.Trim) <> 0 Then
                    temp_bleh = CStr(bleh1.Text)
                    cm.Connection = cn

                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,FSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = ""
                    temp_bleh = Val(bleh1.Text) + 1
                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,fSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(temp_bleh) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,fSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(temp_bleh) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = ""
                    temp_bleh = Val(bleh1.Text) + 2
                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,fSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(temp_bleh) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode3.Text.Trim + "','" + Me.txtItemDesc3.Text.Trim + "','" + CStr(CInt(Me.txtItemQty3.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat3.Text.Trim)) + "','" + Me.txtItemSortingCls3.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp3.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,fSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(temp_bleh) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode3.Text.Trim + "','" + Me.txtItemDesc3.Text.Trim + "','" + CStr(CInt(Me.txtItemQty3.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat3.Text.Trim)) + "','" + Me.txtItemSortingCls3.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp3.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    temp_bleh = Nothing
                Else
                    MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Exit Sub
                End If

            End If
            MsgBox("Successfully Save.", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            MsgBox("Form2/saveITemReceiving: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub createFOR_ID()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim bleh As String
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("select Max(Maxi) as Maxi from ( select Max(for_ptn_id) as Maxi from [rems].dbo.tbl_forcedoutrcv union all select Max(for_ptn_id) as Maxi  from rems" & sDB & ".dbo.tbl_forcedoutrcv ) a")
            dr = obj.OpenDataReader3
            If dr.Read Then
                bleh = obj.IsNull(dr.Item("Maxi"))
                If bleh = "0" Then
                    bleh1.Text = Val(bleh) + 1
                Else
                    bleh1.Text = Val(bleh) + 1
                End If
            End If
            dr.Close()
            obj.Execute3()
            obj.Close3()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ifsdbnotNUllITem()
        Try
            Dim STRINGSQL As String = ""
            Dim cm As New SqlClient.SqlCommand
            Dim s_id As Integer = 0
            Dim temp_bleh As String




            temp_bleh = CStr(bleh1.Text)
            cm.Connection = cn
            STRINGSQL = "insert into rems" & sDB & ".dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            cm.CommandText = STRINGSQL
            cm.ExecuteNonQuery()

            'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            'cm.CommandText = STRINGSQL
            'cm.ExecuteNonQuery()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ifSDBnotnull()

        Try
            Dim sqlstr, stringSQL, str, strSQL As String
            Dim temp_ptnbarcode, temp_bleh As String
            Dim e As Integer

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Opentracker2()
            objclass.CreateCom()

            If sDB = "" Then
                sDB = myregion
            End If



            If txtItemApp1.Text.Length = 0 Then
                txtItemApp1.Text = 0
            End If


            temp_bleh = bleh1.Text
            If checkduplicate() = False Then
                str = "Insert into rems" & sDB & ".dbo.ASYS_REMOutSource_Header(Lotno,TYPE)  values ('" & cmbLOTno.Text & "','REMGOODSTOCK')"
                objclass.commandTrack(str)
                objclass.TrackExecute()


                str = "Insert into rems" & sDB & ".dbo.ASYS_REMOutSource_detail(Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,Receivedate,Receiver,status) values ('" & cmbLOTno.Text & "','" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemQty1.Text & "','" & txtItemQty1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & ComboBox4.Text & "','O','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemCarat1.Text & "',getdate(),'" & userLog & "',getdate(),'" & Trim(userLog) & "','RECEIVED')"
                objclass.commandTrack(str)
                objclass.TrackExecute()


                str = "Insert into ASYS_REMOutSource_Header(Lotno,TYPE)  values ('" & cmbLOTno.Text & "','REMGOODSTOCK')"
                objclass.commandTrack(str)
                objclass.TrackExecute()


                str = "Insert into ASYS_REMOutSource_detail(Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,Receivedate,Receiver,status) values ('" & cmbLOTno.Text & "','" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemQty1.Text & "','" & txtItemQty1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & ComboBox4.Text & "','O','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemCarat1.Text & "',getdate(),'" & userLog & "',getdate(),'" & Trim(userLog) & "','RECEIVED')"
                objclass.commandTrack(str)
                objclass.TrackExecute()


                ''str = "Insert into ASYS_BarcodeHistory(lotno,refallbarcode,allbarcode,itemcode,Description,karat,carat,weight,currency,empname,custodian,trandate,costcenter,status)values ('" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','PHP','" & userLog & "','" & userLog & "',getdate(),'REM','RECEIVED')"
                ''objclass.commandTrack(str)
                ''objclass.TrackExecute()

            Else
                str = "Insert into rems" & sDB & ".dbo.ASYS_REMOutSource_detail(Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,Receivedate,Receiver,status) values ('" & cmbLOTno.Text & "','" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemQty1.Text & "','" & txtItemQty1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & ComboBox4.Text & "','O','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemCarat1.Text & "',getdate(),'" & userLog & "',getdate(),'" & Trim(userLog) & "','RECEIVED')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Insert into ASYS_REMOutSource_detail(Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,Receivedate,Receiver,status) values ('" & cmbLOTno.Text & "','" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemQty1.Text & "','" & txtItemQty1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & ComboBox4.Text & "','O','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemWt1.Text & "','" & txtItemCarat1.Text & "',getdate(),'" & userLog & "',getdate(),'" & Trim(userLog) & "','RECEIVED')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                ''str = "Insert into ASYS_BarcodeHistory(lotno,refallbarcode,allbarcode,itemcode,Description,karat,carat,weight,currency,empname,custodian,trandate,costcenter,status)values ('" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','PHP','" & userLog & "','" & userLog & "',getdate(),'REM','RECEIVED')"
                ''objclass.commandTrack(str)
                ''objclass.TrackExecute()
            End If

            str = "Insert into ASYS_BarcodeHistory(lotno,refallbarcode,allbarcode,itemcode,Description,karat,carat,weight,currency,empname,custodian,trandate,costcenter,status)values ('" & cmbLOTno.Text & "','" & txtAll.Text & "','" & txtAll.Text & "','" & txtItemCode1.Text & "','" & txtItemDesc1.Text & "','" & txtItemKarat1.Text & "','" & txtItemCarat1.Text & "','" & txtItemWt1.Text & "','PHP','" & userLog & "','" & userLog & "',getdate(),'REM','RECEIVED')"
            objclass.commandTrack(str)
            objclass.TrackExecute()

            objclass.CommitTrack()

            MsgBox("SAVE SUCCESSFULLY.", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            MsgBox("TRANSACTION NOT SAVE:" & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            objclass.RollBackTrack()

        Finally
            objclass.Close()
        End Try
    End Sub

    Private Sub saveTBLReceiving1()
        Dim temp_ptnbarcode, temp_bleh As String

        Try
            Dim sqlstr, strSQL, str As String
            Dim objclass As New clsCommon
            Dim e As Integer

            If txtItemApp1.Text = "" Then
                txtItemApp1.Text = 0
            End If

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Opentracker2()

            'str = "Update ASYS_LOTNo_Gen set lotno = '" & ""


            sqlstr = "insert into ASYS_REMOutSource_Header (Lotno,ReceiveDate,Receiver,type) values ('" & cmbLOTno.Text & "',getdate(),'" & userLog & "','OUTSOURCE')"
            objclass.CreateCom()
            objclass.commandTrack(sqlstr)
            objclass.TrackExecute()

            strSQL = "insert into ASYS_REMOutSource_Detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            objclass.commandTrack(strSQL)
            objclass.TrackExecute()

            objclass.CommitTrack()




        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("Form2/saveTBLReceiving1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            temp_bleh = Nothing
            objclass.Close3()
            objclass = Nothing
        End Try
    End Sub

    Private Sub saveITemReceiving1()
        Try
            Dim STRINGSQL As String = ""
            Dim cm As New SqlClient.SqlCommand
            Dim s_id As Integer = 0
            Dim temp_bleh As String

            If txtItemApp1.Text = "" Then
                txtItemApp1.Text = 0
            End If

            'ConnectDB()
            'IF 1 ITEM
            If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) = 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
                If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 Then
                    temp_bleh = CStr(bleh1.Text)
                    cm.Connection = cn
                    STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    cm.CommandText = STRINGSQL
                    cm.ExecuteNonQuery()

                    'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
                    'cm.CommandText = STRINGSQL
                    'cm.ExecuteNonQuery()
                Else
                    MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtItemCode1.Focus()
                    Exit Sub
                End If
            End If

            'IF 2 ITEMs
            'If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) = 0 Then
            '    If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And _
            '    Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 Then
            '        temp_bleh = CStr(bleh1.Text)
            '        cm.Connection = cn
            '        STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        cm.CommandText = STRINGSQL
            '        cm.ExecuteNonQuery()

            '        'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        'cm.CommandText = STRINGSQL
            '        'cm.ExecuteNonQuery()

            '        temp_bleh = Val(bleh1.Text) + 1
            '        STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        cm.CommandText = STRINGSQL
            '        cm.ExecuteNonQuery()

            '        'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
            '        'cm.CommandText = STRINGSQL
            '        'cm.ExecuteNonQuery()

            '    Else
            '        MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
            '        Me.txtItemCode1.Focus()
            '        Exit Sub
            '    End If
            'End If

            'if 3 Items
            'If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemCode3.Text.Trim) <> 0 Then
            '    If Len(Me.txtItemCode1.Text.Trim) <> 0 And Len(Me.txtItemDesc1.Text.Trim) <> 0 And Len(Me.txtItemQty1.Text.Trim) <> 0 And Len(Me.txtItemKarat1.Text.Trim) <> 0 And Len(Me.txtItemCarat1.Text.Trim) <> 0 And Len(Me.txtItemSortingCls1.Text.Trim) <> 0 And Len(Me.txtItemWt1.Text.Trim) <> 0 And _
            '    Len(Me.txtItemCode2.Text.Trim) <> 0 And Len(Me.txtItemDesc2.Text.Trim) <> 0 And Len(Me.txtItemQty2.Text.Trim) <> 0 And Len(Me.txtItemKarat2.Text.Trim) <> 0 And Len(Me.txtItemCarat2.Text.Trim) <> 0 And Len(Me.txtItemSortingCls2.Text.Trim) <> 0 And Len(Me.txtItemWt2.Text.Trim) <> 0 And _
            '    Len(Me.txtItemCode3.Text.Trim) <> 0 And Len(Me.txtItemDesc3.Text.Trim) <> 0 And Len(Me.txtItemQty3.Text.Trim) <> 0 And Len(Me.txtItemKarat3.Text.Trim) <> 0 And Len(Me.txtItemCarat3.Text.Trim) <> 0 And Len(Me.txtItemSortingCls3.Text.Trim) <> 0 And Len(Me.txtItemWt3.Text.Trim) <> 0 Then
            '        temp_bleh = CStr(bleh1.Text)
            '        cm.Connection = cn

            '        STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        cm.CommandText = STRINGSQL
            '        cm.ExecuteNonQuery()

            '        'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        'cm.CommandText = STRINGSQL
            '        'cm.ExecuteNonQuery()

            '        STRINGSQL = ""
            '        temp_bleh = Val(bleh1.Text) + 1
            '        STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"
            '        cm.CommandText = STRINGSQL
            '        cm.ExecuteNonQuery()

            '        'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode2.Text.Trim + "','" + Me.txtItemDesc2.Text.Trim + "','" + CStr(CInt(Me.txtItemQty2.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat2.Text.Trim)) + "','" + Me.txtItemSortingCls2.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt2.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp2.Text.Trim)) + "','1')"
            '        'cm.CommandText = STRINGSQL
            '        'cm.ExecuteNonQuery()

            '        STRINGSQL = ""
            '        temp_bleh = Val(bleh1.Text) + 2
            '        STRINGSQL = "insert into tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,All_wt_dfor,All_carat_dfor,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + temp_bleh + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode1.Text.Trim + "','" + Me.txtItemDesc1.Text.Trim + "','" + CStr(CInt(Me.txtItemQty1.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + Me.txtItemSortingCls1.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemWt1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat1.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp1.Text.Trim)) + "','1')"

            '        cm.CommandText = STRINGSQL
            '        cm.ExecuteNonQuery()

            '        'STRINGSQL = "insert into rems.dbo.tbl_ForcedOutRcv_detail(LOTNO_DFOR,ALLBArcode_dfor,DIVISION_DFOR,PTN_DFOR,FOR_ID_DFOR,MPTN_DFOR,ITEMCODE_DFOR,PTNITEMDESC_DFOR,QUANTITY_DFOR,KARATGRADING_DFOR,CARATSIZE_DFOR,SORTINGCLASS_DFOR,WEIGHT_DFOR,ITEMAPPRAISEVALUE_DFOR,oSTATUS_DFOR)VALUES('" + Me.cmbLOTno.Text.Trim + "','" + Me.txtAll.Text + "','" + Me.txtBranchCode.Text.Trim + "','" + Me.txtPTN.Text.Trim + "','" + CStr(bleh1.Text) + "','" + Me.txtPTN.Text.Trim + "','" + Me.txtItemCode3.Text.Trim + "','" + Me.txtItemDesc3.Text.Trim + "','" + CStr(CInt(Me.txtItemQty3.Text.Trim)) + "','" + CStr(CInt(Me.txtItemKarat3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemCarat3.Text.Trim)) + "','" + Me.txtItemSortingCls3.Text.Trim + "','" + CStr(CDbl(Me.txtItemWt3.Text.Trim)) + "','" + CStr(CDbl(Me.txtItemApp3.Text.Trim)) + "','1')"
            '        'cm.CommandText = STRINGSQL
            '        'cm.ExecuteNonQuery()

            '        temp_bleh = Nothing
            '    Else
            '        MsgBox("Item cannot be save.", MsgBoxStyle.Information, TitleMsgBox)
            '        Me.txtItemCode1.Focus()
            '        Exit Sub
            '    End If

            ' End If
            MsgBox("Successfully Save.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            MsgBox("Form2/saveITemReceiving1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub CallReturn()
        Dim objA As New clsCommon

        Try
            Dim str As String

            Dim temp As String

            objA.Connectionstring3()
            objA.Opentracker2()

            str = " update remsluzon.dbo.tbl_receiving_header set  reclotno = '" & cmbLOTno.Text & "',recID = '" & UserPassW & "',recname = '" & userLog & "', status_id = 3,deptstatus = 0 where recallbarcode ='" & txtAll.Text & "'"
            objA.CreateCom()
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update remsluzon.dbo.tbl_receiving_detail set  dlotno = '" & cmbLOTno.Text & "' where dallbarcode ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update rems.dbo.tbl_receiving_header set reclotno = '" & cmbLOTno.Text & "', recID = '" & UserPassW & "',recname = '" & userLog & "', status_id = 3,deptstatus = 0 where recallbarcode ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update rems.dbo.tbl_receiving_detail set  dlotno = '" & cmbLOTno.Text & "' where dallbarcode ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update remsvismin.dbo.tbl_receiving_header set reclotno = '" & cmbLOTno.Text & "',recID = '" & UserPassW & "',recname = '" & userLog & "', status_id = 3,deptstatus = 0 where recallbarcode ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update remsvismin.dbo.tbl_receiving_detail set  dlotno = '" & cmbLOTno.Text & "' where dallbarcode ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update rems.dbo.tbl_receiving_header set reclotno = '" & cmbLOTno.Text & "',recID = '" & UserPassW & "',recname = '" & userLog & "', status_id = 3,deptstatus = 0 where recallbarcode = '" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update remsluzon.dbo.tbl_forcedoutrcv set lotno_for = '" & cmbLOTno.Text & "',recID_for = '" & UserPassW & "',recname_for = '" & userLog & "', forcedout_status_for = 3,outsource_status_for=4, deptstatus_for = 0 where allbarcode_for ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update remsluzon.dbo.tbl_forcedoutrcv_detail set lotno_dfor = '" & cmbLOTno.Text & "' where allbarcode_dfor ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update rems.dbo.tbl_forcedoutrcv set lotno_for = '" & cmbLOTno.Text & "',recID_for = '" & UserPassW & "',recname_for = '" & userLog & "', forcedout_status_for = 3,outsource_status_for=4, deptstatus_for = 0 where allbarcode_for = '" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update rems.dbo.tbl_forcedoutrcv_detail set lotno_dfor = '" & cmbLOTno.Text & "' where allbarcode_dfor ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = str + " update remsvismin.dbo.tbl_forcedoutrcv set lotno_for = '" & cmbLOTno.Text & "',recID_for = '" & UserPassW & "',recname_for = '" & userLog & "', forcedout_status_for = 3,outsource_status_for=4, deptstatus_for = 0 where allbarcode_for = '" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()

            str = " update remsvismin.dbo.tbl_forcedoutrcv_detail set lotno_dfor = '" & cmbLOTno.Text & "' where allbarcode_dfor ='" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " update rems.dbo.tbl_forcedoutrcv set lotno_for = '" & cmbLOTno.Text & "',recID_for = '" & UserPassW & "',recname_for = '" & userLog & "', forcedout_status_for = 3,outsource_status_for=4, deptstatus_for = 0 where allbarcode_for = '" & txtAll.Text & "'"
            objA.commandTrack(str)
            objA.TrackExecute()


            str = " Insert into tbl_returned(LotnoReturn,allbarcode,datereturned)values('" & cmbLOTno.Text & "','" & txtAll.Text & "',getdate())"
            objA.commandTrack(str)
            objA.TrackExecute()

            objA.CommitTrack()



            MsgBox("ALLBARCODE RETURNED.", MsgBoxStyle.Information, TitleMsgBox)
            Call Clear()
            txtBranchCode.Text = ""
            txtbrname.Text = ""
            ComboBox1.Items.Clear()
            ComboBox4.Enabled = True
            txtBranchCode.Focus()
            ClearText()
            'Me.cmbLOTno.Text = ""
            Me.cmbcostcenter.Text = "REM"
        Catch ex As Exception
            objA.RollBackTrack()
            MsgBox("ALLBarcode was not been successfully returned:" & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            objA.Close4()
        End Try

    End Sub

    Private Function ITEMBarcode(ByVal barcode As String) As Boolean
        Try
            Dim itemcode As String
            itemcode = Mid(barcode, 1, 3)

            If itemcode = "101" Or itemcode = "102" Or itemcode = "103" Or itemcode = "104" Or itemcode = "105" Or itemcode = "106" Or itemcode = "107" Or itemcode = "108" Or itemcode = "109" Or itemcode = "110" Or itemcode = "400" Or itemcode = "300" Then
                ITEMBarcode = True
            Else
                ITEMBarcode = False
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtAll_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAll.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
                Exit Try
            End If
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            If txtAll.Text.Length = 17 Then
                If e.KeyChar = ChrW(13) Then
                    If Len(txtAll.Text.Trim) = 17 Then
                        If ITEMBarcode(txtAll.Text) = True Then
                            Dim obj1 As New clsCommon
                            Dim dr1 As SqlDataReader
                            obj1.Connectionstring3()
                            obj1.Open3()
                            obj1.Command3("If (Select Count(refallbarcode) from ASYS_REM_detail  where refallbarcode = '" & txtAll.Text & "')<> 0 begin Select refAllbarcode from ASYS_REM_Detail  where refallbarcode ='" & txtAll.Text & "' end else Select refAllbarcode from ASYS_REMOutSource_detail  where refallbarcode = '" & txtAll.Text & "'")
                            dr1 = obj1.OpenDataReader3
                            If dr1.Read Then
                                MsgBox("ALLBarcode already receive.", MsgBoxStyle.Information, TitleMsgBox)
                                txtAll.Text = ""
                                txtAll.Focus()
                            Else
                                txtItemCode1.Text = Mid(txtAll.Text, 1, 3)
                                Me.txtItemCode1.Enabled = True
                                Me.txtItemCode1.ReadOnly = True
                                txtItemDesc1.Focus()
                            End If
                            dr1.Close()
                            ' obj1.Execute3()
                            obj1.Close3()
                            obj1 = Nothing
                        Else
                            MsgBox("Please enter correct A.L.L. barcode", MsgBoxStyle.Information, TitleMsgBox)
                            txtAll.Text = ""
                            txtAll.Focus()
                        End If
                    Else
                        MsgBox("ALLBarcode must have 17 digit code.", MsgBoxStyle.Information, TitleMsgBox)
                        txtAll.Text = ""
                        txtAll.Focus()
                    End If
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            ex = Nothing
            MsgBox("Form2/txtAll_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOthers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Shell("Notepad.exe", AppWinStyle.NormalFocus, True)
            Me.txtBranchCode.Text = ""
            Me.txtbrname.Text = ""

            Me.Label44.Visible = True
            Me.txtAll.Visible = True

            Me.ComboBox1.Visible = False

            Me.txtAll.BringToFront()

            Me.txtAll.Focus()
            Me.cmbcostcenter.SetBounds(112, 128, 168, 24)
            'Me.cmbCostCenter.SetBounds(112, 160, 168, 24)
            'Me.Label43.SetBounds(24, 128, 72, 23)
            Me.txtBranchCode.Enabled = False
            Me.txtbrname.Enabled = False
            Clear()
            Me.Timer1.Enabled = False
            visibleFields()
            FRdisplayFields()
            'FRVisibleFields()
            ret = False
            Button2.Text = "Close"
            If Me.txtItemApp1.Text <> "" Then
                Button1.Enabled = True
            ElseIf Me.txtItemApp1.Text = "" Then
                Button1.Enabled = False
            End If
            Button1.Enabled = True
            Me.txtItemSortingCls1.Text = "O"
            Me.txtItemSortingCls2.Text = "O"
            Me.txtItemSortingCls3.Text = "O"
            Me.txtItemQty1.Text = "1"
            Me.txtItemQty2.Text = "1"
            Me.txtItemQty3.Text = "1"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnMaxBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaxBar.Click
        Try
            txt3.Text = Now.Year
            txt2.Text = "39033"
            GroupBox7.Visible = True
            txt1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmSearchLotno
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txtAll.Text = "" Then
                MsgBox("ALLBarcode is empty.", MsgBoxStyle.Information, TitleMsgBox)
                txtAll.Focus()
                Call Clear()
                Exit Sub
            End If



            'If txtItemCode1.Text = "300" Or txtItemCode1.Text = "400" Then
            '    If txtItemDesc1.Text = "" Or txtItemKarat1.Text = "" Or txtItemCarat1.Text = "" Or CDbl(txtItemWt1.Text) = 0 Then
            '        'MsgBox("Please enter valid values on blank textboxes", MsgBoxStyle.Information)
            '        If txtItemDesc1.Text = "" Then
            '            MsgBox("Please input values on Item description!", MsgBoxStyle.Information, TitleMsgBox)
            '            txtItemDesc1.Focus()
            '        ElseIf txtItemKarat1.Text = "" Then
            '            MsgBox("Please input values on karat!", MsgBoxStyle.Information, TitleMsgBox)
            '            txtItemKarat1.Focus()
            '        ElseIf txtItemCarat1.Text = "" Then
            '            MsgBox("Please input values on carat!", MsgBoxStyle.Information, TitleMsgBox)
            '            txtItemCarat1.Focus()
            '        ElseIf txtItemWt1.Text = "" Then
            '            MsgBox("Please input values on weight!", MsgBoxStyle.Information, TitleMsgBox)
            '            txtItemWt1.Focus()
            '        End If
            '        Exit Sub
            '    End If

            'End If

            If txtItemKarat1.Text = "" Then
                MsgBox("Please input values on karat!", MsgBoxStyle.Information, TitleMsgBox)
                txtItemKarat1.Focus()
                Exit Sub
            End If

            If txtItemCarat1.Text = "" Then
                txtItemCarat1.Text = 0
            End If

            If txtItemDesc1.Text.Length <= 0 Then
                MsgBox("Please input Description.", MsgBoxStyle.Information, TitleMsgBox)
                txtItemDesc1.Focus()
                Exit Sub
            End If

            If txtItemCode1.Text = "101" Or txtItemCode1.Text = "102" Or txtItemCode1.Text = "103" Or txtItemCode1.Text = "104" Or txtItemCode1.Text = "105" Or txtItemCode1.Text = "106" Or txtItemCode1.Text = "108" Or txtItemCode1.Text = "110" Then
                If txtItemKarat1.Text = 0 Or txtItemKarat1.Text = "" Then
                    MsgBox("Please input values on karat!", MsgBoxStyle.Information, TitleMsgBox)
                    txtItemKarat1.Focus()
                    Exit Sub
                End If

                If txtItemWt1.Text.Length <= 0 Or CDbl(txtItemWt1.Text) <= 0 Then
                    MsgBox("Please input a valid value on weight!", MsgBoxStyle.Information, TitleMsgBox)
                    txtItemWt1.Focus()
                    Exit Sub

                End If
            End If

            txtItemDesc1.Text = txtItemDesc1.Text.Replace("'", "''")
            If Not Trappings() Then
                If ret = False And outsource = False Then

                    If cmbLOTno.Text.Trim = "" Then
                        Me.cmbLOTno.Text = REMGenerateLot()
                        Me.cmbLOTno.Items.Add(Me.cmbLOTno.Text.Trim)
                        isgen = False
                    End If

                    If IfBarcodeExist() = True Then
                        Call Clear()
                        Exit Sub
                    Else
                        ifSDBnotnull()
                        Call Clear()
                    End If
                End If
            End If
            ComboBox4.Text = "Goodstock"
            txtAll.Focus()
        Catch ex As Exception
            MsgBox("Form2/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function IfBarcodeExist() As Boolean
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("If (Select Count(refallbarcode) from ASYS_REM_DEtail where refallbarcode = '" & txtAll.Text & "')<> 0 begin Select refAllbarcode from ASYS_REM_Detail where refallbarcode ='" & txtAll.Text & "' end else Select refallbarcode from ASYS_REMOutsource_detail where refallbarcode = '" & txtAll.Text & "'")
            dr = obj.OpenDataReader3
            If dr.Read Then
                MsgBox("ALLBarcode already receive.", MsgBoxStyle.Information, TitleMsgBox)
                IfBarcodeExist = True
                txtAll.Text = ""
                txtAll.Focus()
                'Exit Function
            End If
            dr.Close()
            'obj.Execute3()
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("Form2/IfBarcodeExist: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                ''If txt1.Text = "" Then
                ''    txt1.Focus()
                ''Else
                ''    txt2.Focus()
                ''End If

                If txt1.Text = "101" Or txt1.Text = "102" Or txt1.Text = "103" Or txt1.Text = "104" Or txt1.Text = "105" Or txt1.Text = "106" Or txt1.Text = "107" Or txt1.Text = "108" Or txt1.Text = "109" Or txt1.Text = "110" Or txt1.Text = "300" Or txt1.Text = "400" Then
                    txt2.Focus()
                Else
                    MsgBox("Not valid item code.", MsgBoxStyle.Information, TitleMsgBox)
                    txt1.Text = ""
                    txt1.Focus()
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox("Form2/txt1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txt2.Text = "" Then
                    txt2.Focus()
                Else
                    txt3.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("Form2/txt2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then

                Dim obj As New clsCommon
                Dim dr As SqlDataReader
                Dim str, str1 As String
                Dim maxbarc As String

                If Me.txt1.Text = "" And txt2.Text = "" And txt3.Text = "" Then
                    MsgBox("Fill all the textboxes!", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                Else

                    If txt3.Text.Length <> 4 Then
                        MsgBox("Input a valid year.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If

                    If txt3.Text <> Now.Year Then
                        MsgBox("Input a valid year.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If

                    obj.ConnectionString1()
                    obj.Open()
                    str = "exec [REMS].dbo.ASYS_Barcode_Generator '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "'"
                    obj.Command(str)
                    dr = obj.OpenDataReader
                    If dr.Read Then
                        maxbarc = obj.IsNull(dr.Item("maxBarcode"))
                        txtAll.Text = maxbarc
                        txtAll.Focus()
                    End If
                    dr.Close()
                    'obj.Execute3()
                    obj.Close()
                    obj = Nothing
                    txt1.Text = ""
                    'txt2.Text = ""
                    'txt3.Text = ""
                    GroupBox7.Visible = False
                    Me.txtItemCode1.Enabled = True

                    '-- added 1st QC with Loel (2010-09-02) --
                    If Len(txtAll.Text.Trim) = 17 Then

                        Dim obj1 As New clsCommon
                        Dim dr1 As SqlDataReader
                        obj1.Connectionstring3()
                        obj1.Open3()
                        obj1.Command3("If (Select Count(refallbarcode) from ASYS_REM_detail  where refallbarcode = '" & txtAll.Text & "')<> 0 begin Select refAllbarcode from ASYS_REM_Detail  where refallbarcode ='" & txtAll.Text & "' end else Select refAllbarcode from ASYS_REMOutSource_detail  where refallbarcode = '" & txtAll.Text & "'")
                        dr1 = obj1.OpenDataReader3
                        If dr1.Read Then
                            MsgBox("ALLBarcode already receive.", MsgBoxStyle.Information, TitleMsgBox)
                            txtAll.Text = ""
                            txtAll.Focus()
                        Else
                            txtItemCode1.Text = Mid(txtAll.Text, 1, 3)
                            Me.txtItemCode1.Enabled = True
                            Me.txtItemCode1.ReadOnly = True
                            txtItemDesc1.Focus()
                        End If
                        dr1.Close()
                        obj1.Execute3()
                        obj1.Close3()
                        obj1 = Nothing

                    Else
                        MsgBox("ALLBarcode must have 17 digit code.", MsgBoxStyle.Information, TitleMsgBox)
                        txtAll.Text = ""
                        txtAll.Focus()
                    End If
                    '----------------------

                End If
            End If
        Catch ex As Exception
            MsgBox("Form2/txt3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt1.LostFocus
        ''If txt1.Text.Length <> 3 Then
        ''    MsgBox("Invalid item code.", MsgBoxStyle.Information, TitleMsgBox)
        ''    txt1.Focus()
        ''    Exit Sub
        ''Else
        ''    If txt1.Text = "101" Or txt1.Text = "102" Or txt1.Text = "103" Or txt1.Text = "104" Or txt1.Text = "105" Or txt1.Text = "106" Or txt1.Text = "107" Or txt1.Text = "108" Or txt1.Text = "109" Or txt1.Text = "110" Or txt1.Text = "300" Or txt1.Text = "400" Then
        ''        txt2.Focus()
        ''    Else
        ''        txt1.Focus()
        ''        Exit Sub
        ''    End If
        ''End If
    End Sub

    Private Sub txt2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2.LostFocus
        Try
            If txt2.Text.Length <> 5 Then
                MsgBox("Invalid item source.", MsgBoxStyle.Information, TitleMsgBox)
                txt2.Focus()
                Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Try
            If txt1.Text.Length = 3 Then
                ''If txt1.Text = "101" Or txt1.Text = "102" Or txt1.Text = "103" Or txt1.Text = "104" Or txt1.Text = "105" Or txt1.Text = "106" Or txt1.Text = "107" Or txt1.Text = "108" Or txt1.Text = "109" Or txt1.Text = "110" Or txt1.Text = "300" Or txt1.Text = "400" Then
                ''    txt2.Focus()
                ''Else
                ''    MsgBox("Not valid item code.", MsgBoxStyle.Information, TitleMsgBox)
                ''    txt1.Focus()
                ''    Exit Sub
                ''End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtItemWt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemWt1.TextChanged

    End Sub

    Private Sub txtItemKarat1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemKarat1.TextChanged

    End Sub

    Private Sub txt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.TextChanged

    End Sub

    Private Sub txtAll_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAll.TextChanged

    End Sub
End Class
