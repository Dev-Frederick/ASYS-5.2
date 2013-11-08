
Imports System.Data.SqlClient

Public Class frmMountedPricing
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGoldPrice As System.Windows.Forms.Label
    Friend WithEvents lblGoldKaratPrice As System.Windows.Forms.Label
    Friend WithEvents txtGoldKarat As System.Windows.Forms.TextBox
    Friend WithEvents cboGoldKarat As System.Windows.Forms.ComboBox
    Friend WithEvents lblCStonePC3 As System.Windows.Forms.Label
    Friend WithEvents lblCStonePC2 As System.Windows.Forms.Label
    Friend WithEvents lblCSStonePC As System.Windows.Forms.Label
    Friend WithEvents lblCStoneNS As System.Windows.Forms.Label
    Friend WithEvents txtCStonCW3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCStonCW2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCStonCW As System.Windows.Forms.TextBox
    Friend WithEvents cboCStoneQty3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneQty2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneQty As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStonePS3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStonePS2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStonePS As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlQty3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlQty2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlQty As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlSize3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlSize2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboPreciousStoneSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboPreciousStoneSize2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPreciousStoneSize3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneSize2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneSize3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlName3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlName2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPearlName As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiaPC5 As System.Windows.Forms.Label
    Friend WithEvents lblDiaPC4 As System.Windows.Forms.Label
    Friend WithEvents lblDiaPC3 As System.Windows.Forms.Label
    Friend WithEvents lblDiaPC2 As System.Windows.Forms.Label
    Friend WithEvents lblDiaPC As System.Windows.Forms.Label
    Friend WithEvents txtDiaCW5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaCW4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaCW3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaCW2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaCW As System.Windows.Forms.TextBox
    Friend WithEvents cboDiaClarity5 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaClarity4 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaClarity3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaClarity2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaClarity As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaColor5 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaColor4 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaColor3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaColor2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaColor As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCut5 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCut4 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCut3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCut2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiaCut As System.Windows.Forms.ComboBox
    Friend WithEvents txtDiaNoDia5 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaNoDia4 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaNoDia3 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaNoDia2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaNoDia As System.Windows.Forms.TextBox
    Friend WithEvents lblCStoneNSPC3 As System.Windows.Forms.Label
    Friend WithEvents lblCStoneNSPC2 As System.Windows.Forms.Label
    Friend WithEvents lblCStoneNSPC As System.Windows.Forms.Label
    Friend WithEvents txtCStoneNSCW3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCStoneNSCW2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCStoneNSCW As System.Windows.Forms.TextBox
    Friend WithEvents cboCStoneNSQty3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneNSQty2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneNSQty As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneNS3 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneNS2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboCStoneNS As System.Windows.Forms.ComboBox
    Friend WithEvents lblTPearlPrice As System.Windows.Forms.Label
    Friend WithEvents lblTDiaPrice As System.Windows.Forms.Label
    Friend WithEvents lblTGoldPrice As System.Windows.Forms.Label
    Friend WithEvents lblTSellingPrice As System.Windows.Forms.Label
    Friend WithEvents lblTCStonePrice As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtNoPearl As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPearl2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPearl3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPearPrice2x As System.Windows.Forms.Label
    Friend WithEvents lblPearPricex As System.Windows.Forms.Label
    Friend WithEvents lblPearPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPearPrice2 As System.Windows.Forms.TextBox
    Friend WithEvents lblPearPrice3 As System.Windows.Forms.TextBox
    Friend WithEvents lblPearPrice3x As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCW5 As System.Windows.Forms.TextBox
    Friend WithEvents txtCW4 As System.Windows.Forms.TextBox
    Friend WithEvents txtCW3 As System.Windows.Forms.TextBox
    Friend WithEvents txtCW2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCW As System.Windows.Forms.TextBox
    Friend WithEvents lblCStonePC As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMountedPricing))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblGoldPrice = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblGoldKaratPrice = New System.Windows.Forms.Label
        Me.txtGoldKarat = New System.Windows.Forms.TextBox
        Me.cboGoldKarat = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblCStonePC = New System.Windows.Forms.Label
        Me.lblCStoneNSPC3 = New System.Windows.Forms.Label
        Me.lblCStoneNSPC2 = New System.Windows.Forms.Label
        Me.lblCStoneNSPC = New System.Windows.Forms.Label
        Me.cboCStoneNSQty3 = New System.Windows.Forms.ComboBox
        Me.cboCStoneNSQty2 = New System.Windows.Forms.ComboBox
        Me.cboCStoneNSQty = New System.Windows.Forms.ComboBox
        Me.cboCStoneNS3 = New System.Windows.Forms.ComboBox
        Me.cboCStoneNS2 = New System.Windows.Forms.ComboBox
        Me.cboCStoneNS = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblCStonePC3 = New System.Windows.Forms.Label
        Me.lblCStonePC2 = New System.Windows.Forms.Label
        Me.txtCStonCW3 = New System.Windows.Forms.TextBox
        Me.txtCStonCW2 = New System.Windows.Forms.TextBox
        Me.txtCStonCW = New System.Windows.Forms.TextBox
        Me.cboCStoneQty3 = New System.Windows.Forms.ComboBox
        Me.cboCStoneQty2 = New System.Windows.Forms.ComboBox
        Me.cboCStoneQty = New System.Windows.Forms.ComboBox
        Me.cboCStonePS3 = New System.Windows.Forms.ComboBox
        Me.cboCStonePS2 = New System.Windows.Forms.ComboBox
        Me.cboCStonePS = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtCStoneNSCW3 = New System.Windows.Forms.TextBox
        Me.txtCStoneNSCW2 = New System.Windows.Forms.TextBox
        Me.txtCStoneNSCW = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblPearPrice3 = New System.Windows.Forms.TextBox
        Me.lblPearPrice2 = New System.Windows.Forms.TextBox
        Me.lblPearPrice = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoPearl3 = New System.Windows.Forms.TextBox
        Me.txtNoPearl2 = New System.Windows.Forms.TextBox
        Me.txtNoPearl = New System.Windows.Forms.TextBox
        Me.cboPearlQty3 = New System.Windows.Forms.ComboBox
        Me.cboPearlQty2 = New System.Windows.Forms.ComboBox
        Me.cboPearlQty = New System.Windows.Forms.ComboBox
        Me.cboPearlName3 = New System.Windows.Forms.ComboBox
        Me.cboPearlName2 = New System.Windows.Forms.ComboBox
        Me.cboPearlName = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblPearPrice3x = New System.Windows.Forms.Label
        Me.lblPearPrice2x = New System.Windows.Forms.Label
        Me.lblPearPricex = New System.Windows.Forms.Label
        Me.cboPearlSize3 = New System.Windows.Forms.ComboBox
        Me.cboPearlSize2 = New System.Windows.Forms.ComboBox
        Me.cboPearlSize = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtCW5 = New System.Windows.Forms.TextBox
        Me.txtCW4 = New System.Windows.Forms.TextBox
        Me.txtCW3 = New System.Windows.Forms.TextBox
        Me.txtCW2 = New System.Windows.Forms.TextBox
        Me.txtCW = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDiaPC5 = New System.Windows.Forms.Label
        Me.lblDiaPC4 = New System.Windows.Forms.Label
        Me.lblDiaPC3 = New System.Windows.Forms.Label
        Me.lblDiaPC2 = New System.Windows.Forms.Label
        Me.lblDiaPC = New System.Windows.Forms.Label
        Me.txtDiaCW5 = New System.Windows.Forms.TextBox
        Me.txtDiaCW4 = New System.Windows.Forms.TextBox
        Me.txtDiaCW3 = New System.Windows.Forms.TextBox
        Me.txtDiaCW2 = New System.Windows.Forms.TextBox
        Me.txtDiaCW = New System.Windows.Forms.TextBox
        Me.cboDiaClarity5 = New System.Windows.Forms.ComboBox
        Me.cboDiaClarity4 = New System.Windows.Forms.ComboBox
        Me.cboDiaClarity3 = New System.Windows.Forms.ComboBox
        Me.cboDiaClarity2 = New System.Windows.Forms.ComboBox
        Me.cboDiaClarity = New System.Windows.Forms.ComboBox
        Me.cboDiaColor5 = New System.Windows.Forms.ComboBox
        Me.cboDiaColor4 = New System.Windows.Forms.ComboBox
        Me.cboDiaColor3 = New System.Windows.Forms.ComboBox
        Me.cboDiaColor2 = New System.Windows.Forms.ComboBox
        Me.cboDiaColor = New System.Windows.Forms.ComboBox
        Me.cboDiaCut5 = New System.Windows.Forms.ComboBox
        Me.cboDiaCut4 = New System.Windows.Forms.ComboBox
        Me.cboDiaCut3 = New System.Windows.Forms.ComboBox
        Me.cboDiaCut2 = New System.Windows.Forms.ComboBox
        Me.cboDiaCut = New System.Windows.Forms.ComboBox
        Me.txtDiaNoDia5 = New System.Windows.Forms.TextBox
        Me.txtDiaNoDia4 = New System.Windows.Forms.TextBox
        Me.txtDiaNoDia3 = New System.Windows.Forms.TextBox
        Me.txtDiaNoDia2 = New System.Windows.Forms.TextBox
        Me.txtDiaNoDia = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.lblTPearlPrice = New System.Windows.Forms.Label
        Me.lblTDiaPrice = New System.Windows.Forms.Label
        Me.lblTGoldPrice = New System.Windows.Forms.Label
        Me.lblTSellingPrice = New System.Windows.Forms.Label
        Me.lblTCStonePrice = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGoldPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblGoldKaratPrice)
        Me.GroupBox1.Controls.Add(Me.txtGoldKarat)
        Me.GroupBox1.Controls.Add(Me.cboGoldKarat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "                                                                         GOLD"
        '
        'lblGoldPrice
        '
        Me.lblGoldPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGoldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoldPrice.Location = New System.Drawing.Point(408, 24)
        Me.lblGoldPrice.Name = "lblGoldPrice"
        Me.lblGoldPrice.Size = New System.Drawing.Size(104, 20)
        Me.lblGoldPrice.TabIndex = 3
        Me.lblGoldPrice.Tag = "0"
        Me.lblGoldPrice.Text = "0.00"
        Me.lblGoldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(392, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "="
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(280, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "x"
        '
        'lblGoldKaratPrice
        '
        Me.lblGoldKaratPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGoldKaratPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldKaratPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoldKaratPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblGoldKaratPrice.Location = New System.Drawing.Point(296, 24)
        Me.lblGoldKaratPrice.Name = "lblGoldKaratPrice"
        Me.lblGoldKaratPrice.Size = New System.Drawing.Size(88, 20)
        Me.lblGoldKaratPrice.TabIndex = 2
        Me.lblGoldKaratPrice.Tag = "0"
        Me.lblGoldKaratPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoldKarat
        '
        Me.txtGoldKarat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGoldKarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoldKarat.Location = New System.Drawing.Point(216, 24)
        Me.txtGoldKarat.MaxLength = 4
        Me.txtGoldKarat.Name = "txtGoldKarat"
        Me.txtGoldKarat.Size = New System.Drawing.Size(56, 20)
        Me.txtGoldKarat.TabIndex = 1
        Me.txtGoldKarat.Tag = "0"
        Me.txtGoldKarat.Text = ""
        Me.txtGoldKarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboGoldKarat
        '
        Me.cboGoldKarat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGoldKarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGoldKarat.Location = New System.Drawing.Point(56, 24)
        Me.cboGoldKarat.Name = "cboGoldKarat"
        Me.cboGoldKarat.Size = New System.Drawing.Size(152, 21)
        Me.cboGoldKarat.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KARAT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCStonePC)
        Me.GroupBox2.Controls.Add(Me.lblCStoneNSPC3)
        Me.GroupBox2.Controls.Add(Me.lblCStoneNSPC2)
        Me.GroupBox2.Controls.Add(Me.lblCStoneNSPC)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNSQty3)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNSQty2)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNSQty)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNS3)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNS2)
        Me.GroupBox2.Controls.Add(Me.cboCStoneNS)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.lblCStonePC3)
        Me.GroupBox2.Controls.Add(Me.lblCStonePC2)
        Me.GroupBox2.Controls.Add(Me.txtCStonCW3)
        Me.GroupBox2.Controls.Add(Me.txtCStonCW2)
        Me.GroupBox2.Controls.Add(Me.txtCStonCW)
        Me.GroupBox2.Controls.Add(Me.cboCStoneQty3)
        Me.GroupBox2.Controls.Add(Me.cboCStoneQty2)
        Me.GroupBox2.Controls.Add(Me.cboCStoneQty)
        Me.GroupBox2.Controls.Add(Me.cboCStonePS3)
        Me.GroupBox2.Controls.Add(Me.cboCStonePS2)
        Me.GroupBox2.Controls.Add(Me.cboCStonePS)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(528, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 264)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "                                                       COLORED STONE"
        '
        'lblCStonePC
        '
        Me.lblCStonePC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStonePC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStonePC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStonePC.Location = New System.Drawing.Point(328, 56)
        Me.lblCStonePC.Name = "lblCStonePC"
        Me.lblCStonePC.Size = New System.Drawing.Size(112, 20)
        Me.lblCStonePC.TabIndex = 67
        Me.lblCStonePC.Tag = "0"
        Me.lblCStonePC.Text = "0.00"
        Me.lblCStonePC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCStoneNSPC3
        '
        Me.lblCStoneNSPC3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStoneNSPC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStoneNSPC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStoneNSPC3.Location = New System.Drawing.Point(328, 232)
        Me.lblCStoneNSPC3.Name = "lblCStoneNSPC3"
        Me.lblCStoneNSPC3.Size = New System.Drawing.Size(112, 20)
        Me.lblCStoneNSPC3.TabIndex = 66
        Me.lblCStoneNSPC3.Tag = "0"
        Me.lblCStoneNSPC3.Text = "0.00"
        Me.lblCStoneNSPC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCStoneNSPC2
        '
        Me.lblCStoneNSPC2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStoneNSPC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStoneNSPC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStoneNSPC2.Location = New System.Drawing.Point(328, 208)
        Me.lblCStoneNSPC2.Name = "lblCStoneNSPC2"
        Me.lblCStoneNSPC2.Size = New System.Drawing.Size(112, 20)
        Me.lblCStoneNSPC2.TabIndex = 63
        Me.lblCStoneNSPC2.Tag = "0"
        Me.lblCStoneNSPC2.Text = "0.00"
        Me.lblCStoneNSPC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCStoneNSPC
        '
        Me.lblCStoneNSPC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStoneNSPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStoneNSPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStoneNSPC.Location = New System.Drawing.Point(328, 184)
        Me.lblCStoneNSPC.Name = "lblCStoneNSPC"
        Me.lblCStoneNSPC.Size = New System.Drawing.Size(112, 20)
        Me.lblCStoneNSPC.TabIndex = 60
        Me.lblCStoneNSPC.Tag = "0"
        Me.lblCStoneNSPC.Text = "0.00"
        Me.lblCStoneNSPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboCStoneNSQty3
        '
        Me.cboCStoneNSQty3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNSQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNSQty3.Location = New System.Drawing.Point(200, 232)
        Me.cboCStoneNSQty3.Name = "cboCStoneNSQty3"
        Me.cboCStoneNSQty3.Size = New System.Drawing.Size(120, 21)
        Me.cboCStoneNSQty3.TabIndex = 65
        '
        'cboCStoneNSQty2
        '
        Me.cboCStoneNSQty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNSQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNSQty2.Location = New System.Drawing.Point(200, 208)
        Me.cboCStoneNSQty2.Name = "cboCStoneNSQty2"
        Me.cboCStoneNSQty2.Size = New System.Drawing.Size(120, 21)
        Me.cboCStoneNSQty2.TabIndex = 62
        '
        'cboCStoneNSQty
        '
        Me.cboCStoneNSQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNSQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNSQty.Location = New System.Drawing.Point(200, 184)
        Me.cboCStoneNSQty.Name = "cboCStoneNSQty"
        Me.cboCStoneNSQty.Size = New System.Drawing.Size(120, 21)
        Me.cboCStoneNSQty.TabIndex = 59
        '
        'cboCStoneNS3
        '
        Me.cboCStoneNS3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNS3.Location = New System.Drawing.Point(8, 232)
        Me.cboCStoneNS3.Name = "cboCStoneNS3"
        Me.cboCStoneNS3.Size = New System.Drawing.Size(184, 21)
        Me.cboCStoneNS3.Sorted = True
        Me.cboCStoneNS3.TabIndex = 64
        '
        'cboCStoneNS2
        '
        Me.cboCStoneNS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNS2.Location = New System.Drawing.Point(8, 208)
        Me.cboCStoneNS2.Name = "cboCStoneNS2"
        Me.cboCStoneNS2.Size = New System.Drawing.Size(184, 21)
        Me.cboCStoneNS2.Sorted = True
        Me.cboCStoneNS2.TabIndex = 61
        '
        'cboCStoneNS
        '
        Me.cboCStoneNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneNS.Location = New System.Drawing.Point(8, 184)
        Me.cboCStoneNS.Name = "cboCStoneNS"
        Me.cboCStoneNS.Size = New System.Drawing.Size(184, 21)
        Me.cboCStoneNS.Sorted = True
        Me.cboCStoneNS.TabIndex = 58
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(344, 152)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 16)
        Me.Label38.TabIndex = 64
        Me.Label38.Text = "PRICE"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(216, 152)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 16)
        Me.Label40.TabIndex = 62
        Me.Label40.Text = "QUALITY"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(16, 152)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(160, 16)
        Me.Label41.TabIndex = 61
        Me.Label41.Text = "NATURAL/ SYNTHETIC"
        '
        'lblCStonePC3
        '
        Me.lblCStonePC3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStonePC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStonePC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStonePC3.Location = New System.Drawing.Point(328, 104)
        Me.lblCStonePC3.Name = "lblCStonePC3"
        Me.lblCStonePC3.Size = New System.Drawing.Size(112, 20)
        Me.lblCStonePC3.TabIndex = 57
        Me.lblCStonePC3.Tag = "0"
        Me.lblCStonePC3.Text = "0.00"
        Me.lblCStonePC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCStonePC2
        '
        Me.lblCStonePC2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCStonePC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCStonePC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCStonePC2.Location = New System.Drawing.Point(328, 80)
        Me.lblCStonePC2.Name = "lblCStonePC2"
        Me.lblCStonePC2.Size = New System.Drawing.Size(112, 20)
        Me.lblCStonePC2.TabIndex = 53
        Me.lblCStonePC2.Tag = "0"
        Me.lblCStonePC2.Text = "0.00"
        Me.lblCStonePC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCStonCW3
        '
        Me.txtCStonCW3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStonCW3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStonCW3.Location = New System.Drawing.Point(277, 104)
        Me.txtCStonCW3.MaxLength = 4
        Me.txtCStonCW3.Name = "txtCStonCW3"
        Me.txtCStonCW3.Size = New System.Drawing.Size(40, 20)
        Me.txtCStonCW3.TabIndex = 56
        Me.txtCStonCW3.Tag = "0"
        Me.txtCStonCW3.Text = ""
        Me.txtCStonCW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCStonCW2
        '
        Me.txtCStonCW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStonCW2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStonCW2.Location = New System.Drawing.Point(277, 80)
        Me.txtCStonCW2.MaxLength = 4
        Me.txtCStonCW2.Name = "txtCStonCW2"
        Me.txtCStonCW2.Size = New System.Drawing.Size(40, 20)
        Me.txtCStonCW2.TabIndex = 52
        Me.txtCStonCW2.Tag = "0"
        Me.txtCStonCW2.Text = ""
        Me.txtCStonCW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCStonCW
        '
        Me.txtCStonCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStonCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStonCW.Location = New System.Drawing.Point(277, 56)
        Me.txtCStonCW.MaxLength = 4
        Me.txtCStonCW.Name = "txtCStonCW"
        Me.txtCStonCW.Size = New System.Drawing.Size(40, 20)
        Me.txtCStonCW.TabIndex = 48
        Me.txtCStonCW.Tag = "0"
        Me.txtCStonCW.Text = ""
        Me.txtCStonCW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboCStoneQty3
        '
        Me.cboCStoneQty3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneQty3.Location = New System.Drawing.Point(168, 104)
        Me.cboCStoneQty3.Name = "cboCStoneQty3"
        Me.cboCStoneQty3.Size = New System.Drawing.Size(102, 21)
        Me.cboCStoneQty3.TabIndex = 55
        '
        'cboCStoneQty2
        '
        Me.cboCStoneQty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneQty2.Location = New System.Drawing.Point(168, 80)
        Me.cboCStoneQty2.Name = "cboCStoneQty2"
        Me.cboCStoneQty2.Size = New System.Drawing.Size(102, 21)
        Me.cboCStoneQty2.TabIndex = 51
        '
        'cboCStoneQty
        '
        Me.cboCStoneQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStoneQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStoneQty.Location = New System.Drawing.Point(168, 56)
        Me.cboCStoneQty.Name = "cboCStoneQty"
        Me.cboCStoneQty.Size = New System.Drawing.Size(102, 21)
        Me.cboCStoneQty.TabIndex = 47
        '
        'cboCStonePS3
        '
        Me.cboCStonePS3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStonePS3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStonePS3.Location = New System.Drawing.Point(8, 104)
        Me.cboCStonePS3.Name = "cboCStonePS3"
        Me.cboCStonePS3.Size = New System.Drawing.Size(152, 21)
        Me.cboCStonePS3.Sorted = True
        Me.cboCStonePS3.TabIndex = 54
        '
        'cboCStonePS2
        '
        Me.cboCStonePS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStonePS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStonePS2.Location = New System.Drawing.Point(8, 80)
        Me.cboCStonePS2.Name = "cboCStonePS2"
        Me.cboCStonePS2.Size = New System.Drawing.Size(152, 21)
        Me.cboCStonePS2.Sorted = True
        Me.cboCStonePS2.TabIndex = 50
        '
        'cboCStonePS
        '
        Me.cboCStonePS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCStonePS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCStonePS.Location = New System.Drawing.Point(8, 56)
        Me.cboCStonePS.Name = "cboCStonePS"
        Me.cboCStonePS.Size = New System.Drawing.Size(152, 21)
        Me.cboCStonePS.Sorted = True
        Me.cboCStonePS.TabIndex = 46
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(344, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 16)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "PRICE/CARAT"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(272, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 32)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "CARAT WEIGHT"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(184, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 26
        Me.Label27.Text = "QUALITY"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(24, 24)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 16)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "PRECIOUS STONE"
        '
        'txtCStoneNSCW3
        '
        Me.txtCStoneNSCW3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStoneNSCW3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStoneNSCW3.Location = New System.Drawing.Point(520, 256)
        Me.txtCStoneNSCW3.Name = "txtCStoneNSCW3"
        Me.txtCStoneNSCW3.Size = New System.Drawing.Size(24, 20)
        Me.txtCStoneNSCW3.TabIndex = 74
        Me.txtCStoneNSCW3.Tag = "0"
        Me.txtCStoneNSCW3.Text = ""
        Me.txtCStoneNSCW3.Visible = False
        '
        'txtCStoneNSCW2
        '
        Me.txtCStoneNSCW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStoneNSCW2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStoneNSCW2.Location = New System.Drawing.Point(520, 232)
        Me.txtCStoneNSCW2.Name = "txtCStoneNSCW2"
        Me.txtCStoneNSCW2.Size = New System.Drawing.Size(24, 20)
        Me.txtCStoneNSCW2.TabIndex = 73
        Me.txtCStoneNSCW2.Tag = "0"
        Me.txtCStoneNSCW2.Text = ""
        Me.txtCStoneNSCW2.Visible = False
        '
        'txtCStoneNSCW
        '
        Me.txtCStoneNSCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStoneNSCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCStoneNSCW.Location = New System.Drawing.Point(520, 208)
        Me.txtCStoneNSCW.Name = "txtCStoneNSCW"
        Me.txtCStoneNSCW.Size = New System.Drawing.Size(24, 20)
        Me.txtCStoneNSCW.TabIndex = 72
        Me.txtCStoneNSCW.Tag = "0"
        Me.txtCStoneNSCW.Text = ""
        Me.txtCStoneNSCW.Visible = False
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(520, 168)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(40, 32)
        Me.Label39.TabIndex = 63
        Me.Label39.Text = "CARAT WEIGHT"
        Me.Label39.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.lblPearPrice3)
        Me.GroupBox3.Controls.Add(Me.lblPearPrice2)
        Me.GroupBox3.Controls.Add(Me.lblPearPrice)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNoPearl3)
        Me.GroupBox3.Controls.Add(Me.txtNoPearl2)
        Me.GroupBox3.Controls.Add(Me.txtNoPearl)
        Me.GroupBox3.Controls.Add(Me.cboPearlQty3)
        Me.GroupBox3.Controls.Add(Me.cboPearlQty2)
        Me.GroupBox3.Controls.Add(Me.cboPearlQty)
        Me.GroupBox3.Controls.Add(Me.cboPearlName3)
        Me.GroupBox3.Controls.Add(Me.cboPearlName2)
        Me.GroupBox3.Controls.Add(Me.cboPearlName)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "                                                                         PEARL"
        '
        'lblPearPrice3
        '
        Me.lblPearPrice3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPrice3.Location = New System.Drawing.Point(416, 96)
        Me.lblPearPrice3.Name = "lblPearPrice3"
        Me.lblPearPrice3.Size = New System.Drawing.Size(96, 20)
        Me.lblPearPrice3.TabIndex = 64
        Me.lblPearPrice3.Text = "0.00"
        Me.lblPearPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPearPrice2
        '
        Me.lblPearPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPrice2.Location = New System.Drawing.Point(416, 72)
        Me.lblPearPrice2.Name = "lblPearPrice2"
        Me.lblPearPrice2.Size = New System.Drawing.Size(96, 20)
        Me.lblPearPrice2.TabIndex = 63
        Me.lblPearPrice2.Text = "0.00"
        Me.lblPearPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPearPrice
        '
        Me.lblPearPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPrice.Location = New System.Drawing.Point(416, 48)
        Me.lblPearPrice.Name = "lblPearPrice"
        Me.lblPearPrice.Size = New System.Drawing.Size(96, 20)
        Me.lblPearPrice.TabIndex = 62
        Me.lblPearPrice.Tag = "0"
        Me.lblPearPrice.Text = "0.00"
        Me.lblPearPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 27)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "NO. OF PEARL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNoPearl3
        '
        Me.txtNoPearl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPearl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPearl3.Location = New System.Drawing.Point(8, 96)
        Me.txtNoPearl3.MaxLength = 3
        Me.txtNoPearl3.Name = "txtNoPearl3"
        Me.txtNoPearl3.Size = New System.Drawing.Size(40, 20)
        Me.txtNoPearl3.TabIndex = 42
        Me.txtNoPearl3.Tag = "0"
        Me.txtNoPearl3.Text = ""
        Me.txtNoPearl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoPearl2
        '
        Me.txtNoPearl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPearl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPearl2.Location = New System.Drawing.Point(8, 72)
        Me.txtNoPearl2.MaxLength = 3
        Me.txtNoPearl2.Name = "txtNoPearl2"
        Me.txtNoPearl2.Size = New System.Drawing.Size(40, 20)
        Me.txtNoPearl2.TabIndex = 38
        Me.txtNoPearl2.Tag = "0"
        Me.txtNoPearl2.Text = ""
        Me.txtNoPearl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNoPearl
        '
        Me.txtNoPearl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPearl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPearl.Location = New System.Drawing.Point(8, 48)
        Me.txtNoPearl.MaxLength = 3
        Me.txtNoPearl.Name = "txtNoPearl"
        Me.txtNoPearl.Size = New System.Drawing.Size(40, 20)
        Me.txtNoPearl.TabIndex = 34
        Me.txtNoPearl.Tag = "0"
        Me.txtNoPearl.Text = ""
        Me.txtNoPearl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboPearlQty3
        '
        Me.cboPearlQty3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlQty3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlQty3.Location = New System.Drawing.Point(272, 96)
        Me.cboPearlQty3.Name = "cboPearlQty3"
        Me.cboPearlQty3.Size = New System.Drawing.Size(136, 21)
        Me.cboPearlQty3.TabIndex = 44
        '
        'cboPearlQty2
        '
        Me.cboPearlQty2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlQty2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlQty2.Location = New System.Drawing.Point(272, 72)
        Me.cboPearlQty2.Name = "cboPearlQty2"
        Me.cboPearlQty2.Size = New System.Drawing.Size(136, 21)
        Me.cboPearlQty2.TabIndex = 40
        '
        'cboPearlQty
        '
        Me.cboPearlQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlQty.Location = New System.Drawing.Point(272, 48)
        Me.cboPearlQty.Name = "cboPearlQty"
        Me.cboPearlQty.Size = New System.Drawing.Size(136, 21)
        Me.cboPearlQty.TabIndex = 36
        '
        'cboPearlName3
        '
        Me.cboPearlName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlName3.Location = New System.Drawing.Point(56, 96)
        Me.cboPearlName3.Name = "cboPearlName3"
        Me.cboPearlName3.Size = New System.Drawing.Size(208, 21)
        Me.cboPearlName3.Sorted = True
        Me.cboPearlName3.TabIndex = 43
        '
        'cboPearlName2
        '
        Me.cboPearlName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlName2.Location = New System.Drawing.Point(56, 72)
        Me.cboPearlName2.Name = "cboPearlName2"
        Me.cboPearlName2.Size = New System.Drawing.Size(208, 21)
        Me.cboPearlName2.Sorted = True
        Me.cboPearlName2.TabIndex = 39
        '
        'cboPearlName
        '
        Me.cboPearlName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlName.Location = New System.Drawing.Point(56, 48)
        Me.cboPearlName.Name = "cboPearlName"
        Me.cboPearlName.Size = New System.Drawing.Size(208, 21)
        Me.cboPearlName.Sorted = True
        Me.cboPearlName.TabIndex = 35
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(416, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "PEARL PRICE"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(304, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 16)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "QUALITY"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(120, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "PEARL"
        '
        'lblPearPrice3x
        '
        Me.lblPearPrice3x.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPearPrice3x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPrice3x.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPrice3x.Location = New System.Drawing.Point(520, 88)
        Me.lblPearPrice3x.Name = "lblPearPrice3x"
        Me.lblPearPrice3x.Size = New System.Drawing.Size(24, 24)
        Me.lblPearPrice3x.TabIndex = 45
        Me.lblPearPrice3x.Tag = "0"
        Me.lblPearPrice3x.Text = "0.00"
        Me.lblPearPrice3x.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPearPrice3x.Visible = False
        '
        'lblPearPrice2x
        '
        Me.lblPearPrice2x.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPearPrice2x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPrice2x.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPrice2x.Location = New System.Drawing.Point(520, 136)
        Me.lblPearPrice2x.Name = "lblPearPrice2x"
        Me.lblPearPrice2x.Size = New System.Drawing.Size(24, 24)
        Me.lblPearPrice2x.TabIndex = 40
        Me.lblPearPrice2x.Tag = "0"
        Me.lblPearPrice2x.Text = "0.00"
        Me.lblPearPrice2x.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPearPrice2x.Visible = False
        '
        'lblPearPricex
        '
        Me.lblPearPricex.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPearPricex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPearPricex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPearPricex.Location = New System.Drawing.Point(520, 112)
        Me.lblPearPricex.Name = "lblPearPricex"
        Me.lblPearPricex.Size = New System.Drawing.Size(24, 24)
        Me.lblPearPricex.TabIndex = 37
        Me.lblPearPricex.Tag = "0"
        Me.lblPearPricex.Text = "0.00"
        Me.lblPearPricex.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPearPricex.Visible = False
        '
        'cboPearlSize3
        '
        Me.cboPearlSize3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlSize3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlSize3.Location = New System.Drawing.Point(520, 352)
        Me.cboPearlSize3.Name = "cboPearlSize3"
        Me.cboPearlSize3.Size = New System.Drawing.Size(32, 21)
        Me.cboPearlSize3.TabIndex = 40
        Me.cboPearlSize3.Visible = False
        '
        'cboPearlSize2
        '
        Me.cboPearlSize2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlSize2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlSize2.Location = New System.Drawing.Point(520, 328)
        Me.cboPearlSize2.Name = "cboPearlSize2"
        Me.cboPearlSize2.Size = New System.Drawing.Size(32, 21)
        Me.cboPearlSize2.TabIndex = 39
        Me.cboPearlSize2.Visible = False
        '
        'cboPearlSize
        '
        Me.cboPearlSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPearlSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPearlSize.Location = New System.Drawing.Point(520, 304)
        Me.cboPearlSize.Name = "cboPearlSize"
        Me.cboPearlSize.Size = New System.Drawing.Size(32, 21)
        Me.cboPearlSize.TabIndex = 38
        Me.cboPearlSize.Visible = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(520, 280)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "SIZE"
        Me.Label19.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtCW5)
        Me.GroupBox4.Controls.Add(Me.txtCW4)
        Me.GroupBox4.Controls.Add(Me.txtCW3)
        Me.GroupBox4.Controls.Add(Me.txtCW2)
        Me.GroupBox4.Controls.Add(Me.txtCW)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.lblDiaPC5)
        Me.GroupBox4.Controls.Add(Me.lblDiaPC4)
        Me.GroupBox4.Controls.Add(Me.lblDiaPC3)
        Me.GroupBox4.Controls.Add(Me.lblDiaPC2)
        Me.GroupBox4.Controls.Add(Me.lblDiaPC)
        Me.GroupBox4.Controls.Add(Me.txtDiaCW5)
        Me.GroupBox4.Controls.Add(Me.txtDiaCW4)
        Me.GroupBox4.Controls.Add(Me.txtDiaCW3)
        Me.GroupBox4.Controls.Add(Me.txtDiaCW2)
        Me.GroupBox4.Controls.Add(Me.txtDiaCW)
        Me.GroupBox4.Controls.Add(Me.cboDiaClarity5)
        Me.GroupBox4.Controls.Add(Me.cboDiaClarity4)
        Me.GroupBox4.Controls.Add(Me.cboDiaClarity3)
        Me.GroupBox4.Controls.Add(Me.cboDiaClarity2)
        Me.GroupBox4.Controls.Add(Me.cboDiaClarity)
        Me.GroupBox4.Controls.Add(Me.cboDiaColor5)
        Me.GroupBox4.Controls.Add(Me.cboDiaColor4)
        Me.GroupBox4.Controls.Add(Me.cboDiaColor3)
        Me.GroupBox4.Controls.Add(Me.cboDiaColor2)
        Me.GroupBox4.Controls.Add(Me.cboDiaColor)
        Me.GroupBox4.Controls.Add(Me.cboDiaCut5)
        Me.GroupBox4.Controls.Add(Me.cboDiaCut4)
        Me.GroupBox4.Controls.Add(Me.cboDiaCut3)
        Me.GroupBox4.Controls.Add(Me.cboDiaCut2)
        Me.GroupBox4.Controls.Add(Me.cboDiaCut)
        Me.GroupBox4.Controls.Add(Me.txtDiaNoDia5)
        Me.GroupBox4.Controls.Add(Me.txtDiaNoDia4)
        Me.GroupBox4.Controls.Add(Me.txtDiaNoDia3)
        Me.GroupBox4.Controls.Add(Me.txtDiaNoDia2)
        Me.GroupBox4.Controls.Add(Me.txtDiaNoDia)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 184)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "                                                                      DIAMOND"
        '
        'txtCW5
        '
        Me.txtCW5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCW5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW5.Location = New System.Drawing.Point(388, 152)
        Me.txtCW5.MaxLength = 3
        Me.txtCW5.Name = "txtCW5"
        Me.txtCW5.Size = New System.Drawing.Size(32, 20)
        Me.txtCW5.TabIndex = 39
        Me.txtCW5.Tag = "0"
        Me.txtCW5.Text = "0"
        Me.txtCW5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCW4
        '
        Me.txtCW4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCW4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW4.Location = New System.Drawing.Point(388, 128)
        Me.txtCW4.MaxLength = 3
        Me.txtCW4.Name = "txtCW4"
        Me.txtCW4.Size = New System.Drawing.Size(32, 20)
        Me.txtCW4.TabIndex = 38
        Me.txtCW4.Tag = "0"
        Me.txtCW4.Text = "0"
        Me.txtCW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCW3
        '
        Me.txtCW3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCW3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW3.Location = New System.Drawing.Point(388, 104)
        Me.txtCW3.MaxLength = 3
        Me.txtCW3.Name = "txtCW3"
        Me.txtCW3.Size = New System.Drawing.Size(32, 20)
        Me.txtCW3.TabIndex = 36
        Me.txtCW3.Tag = "0"
        Me.txtCW3.Text = "0"
        Me.txtCW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCW2
        '
        Me.txtCW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCW2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW2.Location = New System.Drawing.Point(388, 80)
        Me.txtCW2.MaxLength = 3
        Me.txtCW2.Name = "txtCW2"
        Me.txtCW2.Size = New System.Drawing.Size(32, 20)
        Me.txtCW2.TabIndex = 35
        Me.txtCW2.Tag = "0"
        Me.txtCW2.Text = "0"
        Me.txtCW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCW
        '
        Me.txtCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCW.Location = New System.Drawing.Point(388, 56)
        Me.txtCW.MaxLength = 3
        Me.txtCW.Name = "txtCW"
        Me.txtCW.Size = New System.Drawing.Size(32, 20)
        Me.txtCW.TabIndex = 34
        Me.txtCW.Tag = "0"
        Me.txtCW.Text = "0"
        Me.txtCW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 27)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "CARAT WEIGHT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDiaPC5
        '
        Me.lblDiaPC5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiaPC5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiaPC5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaPC5.Location = New System.Drawing.Point(424, 152)
        Me.lblDiaPC5.Name = "lblDiaPC5"
        Me.lblDiaPC5.Size = New System.Drawing.Size(88, 20)
        Me.lblDiaPC5.TabIndex = 33
        Me.lblDiaPC5.Tag = "0"
        Me.lblDiaPC5.Text = "0.00"
        Me.lblDiaPC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiaPC4
        '
        Me.lblDiaPC4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiaPC4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiaPC4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaPC4.Location = New System.Drawing.Point(424, 128)
        Me.lblDiaPC4.Name = "lblDiaPC4"
        Me.lblDiaPC4.Size = New System.Drawing.Size(88, 20)
        Me.lblDiaPC4.TabIndex = 27
        Me.lblDiaPC4.Tag = "0"
        Me.lblDiaPC4.Text = "0.00"
        Me.lblDiaPC4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiaPC3
        '
        Me.lblDiaPC3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiaPC3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiaPC3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaPC3.Location = New System.Drawing.Point(424, 104)
        Me.lblDiaPC3.Name = "lblDiaPC3"
        Me.lblDiaPC3.Size = New System.Drawing.Size(88, 20)
        Me.lblDiaPC3.TabIndex = 21
        Me.lblDiaPC3.Tag = "0"
        Me.lblDiaPC3.Text = "0.00"
        Me.lblDiaPC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiaPC2
        '
        Me.lblDiaPC2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiaPC2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiaPC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaPC2.Location = New System.Drawing.Point(424, 80)
        Me.lblDiaPC2.Name = "lblDiaPC2"
        Me.lblDiaPC2.Size = New System.Drawing.Size(88, 20)
        Me.lblDiaPC2.TabIndex = 15
        Me.lblDiaPC2.Tag = "0"
        Me.lblDiaPC2.Text = "0.00"
        Me.lblDiaPC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiaPC
        '
        Me.lblDiaPC.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDiaPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiaPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiaPC.Location = New System.Drawing.Point(424, 56)
        Me.lblDiaPC.Name = "lblDiaPC"
        Me.lblDiaPC.Size = New System.Drawing.Size(88, 20)
        Me.lblDiaPC.TabIndex = 9
        Me.lblDiaPC.Tag = "0"
        Me.lblDiaPC.Text = "0.00"
        Me.lblDiaPC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDiaCW5
        '
        Me.txtDiaCW5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaCW5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCW5.Location = New System.Drawing.Point(48, 152)
        Me.txtDiaCW5.MaxLength = 4
        Me.txtDiaCW5.Name = "txtDiaCW5"
        Me.txtDiaCW5.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaCW5.TabIndex = 32
        Me.txtDiaCW5.Tag = "0"
        Me.txtDiaCW5.Text = "0"
        Me.txtDiaCW5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaCW4
        '
        Me.txtDiaCW4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaCW4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCW4.Location = New System.Drawing.Point(48, 128)
        Me.txtDiaCW4.MaxLength = 4
        Me.txtDiaCW4.Name = "txtDiaCW4"
        Me.txtDiaCW4.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaCW4.TabIndex = 26
        Me.txtDiaCW4.Tag = "0"
        Me.txtDiaCW4.Text = "0"
        Me.txtDiaCW4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaCW3
        '
        Me.txtDiaCW3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaCW3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCW3.Location = New System.Drawing.Point(48, 104)
        Me.txtDiaCW3.MaxLength = 4
        Me.txtDiaCW3.Name = "txtDiaCW3"
        Me.txtDiaCW3.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaCW3.TabIndex = 20
        Me.txtDiaCW3.Tag = "0"
        Me.txtDiaCW3.Text = "0"
        Me.txtDiaCW3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaCW2
        '
        Me.txtDiaCW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaCW2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCW2.Location = New System.Drawing.Point(48, 80)
        Me.txtDiaCW2.MaxLength = 4
        Me.txtDiaCW2.Name = "txtDiaCW2"
        Me.txtDiaCW2.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaCW2.TabIndex = 14
        Me.txtDiaCW2.Tag = "0"
        Me.txtDiaCW2.Text = "0"
        Me.txtDiaCW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaCW
        '
        Me.txtDiaCW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaCW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaCW.Location = New System.Drawing.Point(48, 56)
        Me.txtDiaCW.MaxLength = 4
        Me.txtDiaCW.Name = "txtDiaCW"
        Me.txtDiaCW.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaCW.TabIndex = 8
        Me.txtDiaCW.Tag = "0"
        Me.txtDiaCW.Text = "0"
        Me.txtDiaCW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboDiaClarity5
        '
        Me.cboDiaClarity5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaClarity5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaClarity5.Location = New System.Drawing.Point(304, 152)
        Me.cboDiaClarity5.Name = "cboDiaClarity5"
        Me.cboDiaClarity5.Size = New System.Drawing.Size(80, 21)
        Me.cboDiaClarity5.TabIndex = 31
        '
        'cboDiaClarity4
        '
        Me.cboDiaClarity4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaClarity4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaClarity4.Location = New System.Drawing.Point(304, 128)
        Me.cboDiaClarity4.Name = "cboDiaClarity4"
        Me.cboDiaClarity4.Size = New System.Drawing.Size(80, 21)
        Me.cboDiaClarity4.TabIndex = 25
        '
        'cboDiaClarity3
        '
        Me.cboDiaClarity3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaClarity3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaClarity3.Location = New System.Drawing.Point(304, 104)
        Me.cboDiaClarity3.Name = "cboDiaClarity3"
        Me.cboDiaClarity3.Size = New System.Drawing.Size(80, 21)
        Me.cboDiaClarity3.TabIndex = 19
        '
        'cboDiaClarity2
        '
        Me.cboDiaClarity2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaClarity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaClarity2.Location = New System.Drawing.Point(304, 80)
        Me.cboDiaClarity2.Name = "cboDiaClarity2"
        Me.cboDiaClarity2.Size = New System.Drawing.Size(80, 21)
        Me.cboDiaClarity2.TabIndex = 13
        '
        'cboDiaClarity
        '
        Me.cboDiaClarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaClarity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaClarity.Location = New System.Drawing.Point(304, 56)
        Me.cboDiaClarity.Name = "cboDiaClarity"
        Me.cboDiaClarity.Size = New System.Drawing.Size(80, 21)
        Me.cboDiaClarity.TabIndex = 7
        '
        'cboDiaColor5
        '
        Me.cboDiaColor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaColor5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaColor5.Location = New System.Drawing.Point(208, 152)
        Me.cboDiaColor5.Name = "cboDiaColor5"
        Me.cboDiaColor5.Size = New System.Drawing.Size(88, 21)
        Me.cboDiaColor5.Sorted = True
        Me.cboDiaColor5.TabIndex = 30
        '
        'cboDiaColor4
        '
        Me.cboDiaColor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaColor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaColor4.Location = New System.Drawing.Point(208, 128)
        Me.cboDiaColor4.Name = "cboDiaColor4"
        Me.cboDiaColor4.Size = New System.Drawing.Size(88, 21)
        Me.cboDiaColor4.Sorted = True
        Me.cboDiaColor4.TabIndex = 24
        '
        'cboDiaColor3
        '
        Me.cboDiaColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaColor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaColor3.Location = New System.Drawing.Point(208, 104)
        Me.cboDiaColor3.Name = "cboDiaColor3"
        Me.cboDiaColor3.Size = New System.Drawing.Size(88, 21)
        Me.cboDiaColor3.Sorted = True
        Me.cboDiaColor3.TabIndex = 18
        '
        'cboDiaColor2
        '
        Me.cboDiaColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaColor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaColor2.Location = New System.Drawing.Point(208, 80)
        Me.cboDiaColor2.Name = "cboDiaColor2"
        Me.cboDiaColor2.Size = New System.Drawing.Size(88, 21)
        Me.cboDiaColor2.Sorted = True
        Me.cboDiaColor2.TabIndex = 12
        '
        'cboDiaColor
        '
        Me.cboDiaColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaColor.Location = New System.Drawing.Point(208, 56)
        Me.cboDiaColor.Name = "cboDiaColor"
        Me.cboDiaColor.Size = New System.Drawing.Size(88, 21)
        Me.cboDiaColor.Sorted = True
        Me.cboDiaColor.TabIndex = 6
        '
        'cboDiaCut5
        '
        Me.cboDiaCut5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCut5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaCut5.Location = New System.Drawing.Point(88, 152)
        Me.cboDiaCut5.Name = "cboDiaCut5"
        Me.cboDiaCut5.Size = New System.Drawing.Size(115, 21)
        Me.cboDiaCut5.Sorted = True
        Me.cboDiaCut5.TabIndex = 29
        '
        'cboDiaCut4
        '
        Me.cboDiaCut4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCut4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaCut4.Location = New System.Drawing.Point(88, 128)
        Me.cboDiaCut4.Name = "cboDiaCut4"
        Me.cboDiaCut4.Size = New System.Drawing.Size(115, 21)
        Me.cboDiaCut4.Sorted = True
        Me.cboDiaCut4.TabIndex = 23
        '
        'cboDiaCut3
        '
        Me.cboDiaCut3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCut3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaCut3.Location = New System.Drawing.Point(88, 104)
        Me.cboDiaCut3.Name = "cboDiaCut3"
        Me.cboDiaCut3.Size = New System.Drawing.Size(115, 21)
        Me.cboDiaCut3.Sorted = True
        Me.cboDiaCut3.TabIndex = 17
        '
        'cboDiaCut2
        '
        Me.cboDiaCut2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCut2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaCut2.Location = New System.Drawing.Point(88, 80)
        Me.cboDiaCut2.Name = "cboDiaCut2"
        Me.cboDiaCut2.Size = New System.Drawing.Size(115, 21)
        Me.cboDiaCut2.Sorted = True
        Me.cboDiaCut2.TabIndex = 11
        '
        'cboDiaCut
        '
        Me.cboDiaCut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDiaCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDiaCut.Location = New System.Drawing.Point(88, 56)
        Me.cboDiaCut.Name = "cboDiaCut"
        Me.cboDiaCut.Size = New System.Drawing.Size(115, 21)
        Me.cboDiaCut.Sorted = True
        Me.cboDiaCut.TabIndex = 5
        '
        'txtDiaNoDia5
        '
        Me.txtDiaNoDia5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaNoDia5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaNoDia5.Location = New System.Drawing.Point(8, 152)
        Me.txtDiaNoDia5.MaxLength = 3
        Me.txtDiaNoDia5.Name = "txtDiaNoDia5"
        Me.txtDiaNoDia5.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaNoDia5.TabIndex = 28
        Me.txtDiaNoDia5.Tag = "0"
        Me.txtDiaNoDia5.Text = ""
        Me.txtDiaNoDia5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaNoDia4
        '
        Me.txtDiaNoDia4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaNoDia4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaNoDia4.Location = New System.Drawing.Point(8, 128)
        Me.txtDiaNoDia4.MaxLength = 3
        Me.txtDiaNoDia4.Name = "txtDiaNoDia4"
        Me.txtDiaNoDia4.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaNoDia4.TabIndex = 22
        Me.txtDiaNoDia4.Tag = "0"
        Me.txtDiaNoDia4.Text = ""
        Me.txtDiaNoDia4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaNoDia3
        '
        Me.txtDiaNoDia3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaNoDia3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaNoDia3.Location = New System.Drawing.Point(8, 104)
        Me.txtDiaNoDia3.MaxLength = 3
        Me.txtDiaNoDia3.Name = "txtDiaNoDia3"
        Me.txtDiaNoDia3.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaNoDia3.TabIndex = 16
        Me.txtDiaNoDia3.Tag = "0"
        Me.txtDiaNoDia3.Text = ""
        Me.txtDiaNoDia3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaNoDia2
        '
        Me.txtDiaNoDia2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaNoDia2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaNoDia2.Location = New System.Drawing.Point(8, 80)
        Me.txtDiaNoDia2.MaxLength = 3
        Me.txtDiaNoDia2.Name = "txtDiaNoDia2"
        Me.txtDiaNoDia2.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaNoDia2.TabIndex = 10
        Me.txtDiaNoDia2.Tag = "0"
        Me.txtDiaNoDia2.Text = ""
        Me.txtDiaNoDia2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDiaNoDia
        '
        Me.txtDiaNoDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiaNoDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaNoDia.Location = New System.Drawing.Point(8, 56)
        Me.txtDiaNoDia.MaxLength = 3
        Me.txtDiaNoDia.Name = "txtDiaNoDia"
        Me.txtDiaNoDia.Size = New System.Drawing.Size(32, 20)
        Me.txtDiaNoDia.TabIndex = 4
        Me.txtDiaNoDia.Tag = "0"
        Me.txtDiaNoDia.Text = ""
        Me.txtDiaNoDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(432, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 16)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "PRICE/CARAT"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(376, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 40)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "TOTAL CARAT WEIGHT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "CLARITY"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(224, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "COLOR"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "CUT"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "NO. OF DIAS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(592, 288)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(128, 16)
        Me.Label42.TabIndex = 62
        Me.Label42.Text = "TOTAL GOLD PRICE"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(592, 336)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(128, 16)
        Me.Label43.TabIndex = 63
        Me.Label43.Text = "TOTAL PEARL PRICE"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(592, 312)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(136, 16)
        Me.Label44.TabIndex = 64
        Me.Label44.Text = "TOTAL DIAMOND PRICE"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(592, 384)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(184, 16)
        Me.Label45.TabIndex = 65
        Me.Label45.Text = "TOTAL SELLING PRICE"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(592, 360)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(192, 16)
        Me.Label46.TabIndex = 66
        Me.Label46.Text = "TOTAL COLORED STONE PRICE"
        '
        'lblTPearlPrice
        '
        Me.lblTPearlPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTPearlPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTPearlPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPearlPrice.Location = New System.Drawing.Point(800, 336)
        Me.lblTPearlPrice.Name = "lblTPearlPrice"
        Me.lblTPearlPrice.Size = New System.Drawing.Size(144, 20)
        Me.lblTPearlPrice.TabIndex = 69
        Me.lblTPearlPrice.Tag = "0"
        Me.lblTPearlPrice.Text = "0.00"
        Me.lblTPearlPrice.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTDiaPrice
        '
        Me.lblTDiaPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTDiaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTDiaPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTDiaPrice.Location = New System.Drawing.Point(800, 312)
        Me.lblTDiaPrice.Name = "lblTDiaPrice"
        Me.lblTDiaPrice.Size = New System.Drawing.Size(144, 20)
        Me.lblTDiaPrice.TabIndex = 68
        Me.lblTDiaPrice.Tag = "0"
        Me.lblTDiaPrice.Text = "0.00"
        Me.lblTDiaPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTGoldPrice
        '
        Me.lblTGoldPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTGoldPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTGoldPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTGoldPrice.Location = New System.Drawing.Point(800, 288)
        Me.lblTGoldPrice.Name = "lblTGoldPrice"
        Me.lblTGoldPrice.Size = New System.Drawing.Size(144, 20)
        Me.lblTGoldPrice.TabIndex = 67
        Me.lblTGoldPrice.Tag = "0"
        Me.lblTGoldPrice.Text = "0.00"
        Me.lblTGoldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTSellingPrice
        '
        Me.lblTSellingPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTSellingPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTSellingPrice.Location = New System.Drawing.Point(800, 384)
        Me.lblTSellingPrice.Name = "lblTSellingPrice"
        Me.lblTSellingPrice.Size = New System.Drawing.Size(144, 20)
        Me.lblTSellingPrice.TabIndex = 71
        Me.lblTSellingPrice.Tag = "0"
        Me.lblTSellingPrice.Text = "0.00"
        Me.lblTSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTCStonePrice
        '
        Me.lblTCStonePrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTCStonePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTCStonePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCStonePrice.Location = New System.Drawing.Point(800, 360)
        Me.lblTCStonePrice.Name = "lblTCStonePrice"
        Me.lblTCStonePrice.Size = New System.Drawing.Size(144, 20)
        Me.lblTCStonePrice.TabIndex = 70
        Me.lblTCStonePrice.Tag = "0"
        Me.lblTCStonePrice.Text = "0.00"
        Me.lblTCStonePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(528, 272)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(456, 144)
        Me.GroupBox5.TabIndex = 72
        Me.GroupBox5.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOK.Location = New System.Drawing.Point(800, 424)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 40)
        Me.btnOK.TabIndex = 73
        Me.btnOK.Text = "SAVE"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(880, 424)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 74
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmMountedPricing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(994, 472)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTSellingPrice)
        Me.Controls.Add(Me.lblTCStonePrice)
        Me.Controls.Add(Me.lblTPearlPrice)
        Me.Controls.Add(Me.lblTDiaPrice)
        Me.Controls.Add(Me.lblTGoldPrice)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.cboPearlSize3)
        Me.Controls.Add(Me.cboPearlSize2)
        Me.Controls.Add(Me.cboPearlSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCStoneNSCW3)
        Me.Controls.Add(Me.txtCStoneNSCW2)
        Me.Controls.Add(Me.txtCStoneNSCW)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.lblPearPrice3x)
        Me.Controls.Add(Me.lblPearPrice2x)
        Me.Controls.Add(Me.lblPearPricex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMountedPricing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOUNTED PRICING FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Dim obj As New clsCommon
    'Dim dr As SqlDataReader
    'Dim str As String
    Dim tmpDiaCW As Double
    Dim tmpDiaNoDia As Double
    Dim tmpDiaColor As String
    Dim tmpDiaClarity As String
    Dim tmpQuality As String
    Dim tmpPreciousStoneQty As String

    Dim tmpPearlType As String
    Dim tmpPreciousStoneType As String
    Dim tmpCStoneNSType As String
    Dim tmpNo As Integer

    Private Sub frmRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            '----- Load Data for Gold Karat [start] -----
            MountedPrice = 0

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT GOLD_KARAT, Plain FROM ASYS_GOLDKARAT ORDER BY [ID]"

            obj.Command3(str)
            dr = obj.OpenDataReader3
            cboGoldKarat.Items.Add("")
            While dr.Read
                cboGoldKarat.Items.Add(Trim(dr.Item("GOLD_KARAT")))
            End While

            cboGoldKarat.SelectedIndex = 0
            dr.Close()
            obj.Close3()
            '------ Load Data for Gold Karat [end] ------

            LoadDiaCombo()
            LoadPearlCombo()
            LoadColoredStoneCombo()

            If FlagPricingNotSave = True Then
                RetrieveDataNotSave()
            Else
                RetrieveData()
            End If

        Catch ex As Exception
            MsgBox("frmRec/frmRec_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RetrieveDataNotSave()
        Try

            Dim i As Integer


            '--- Gold Saving [start] ---
            If ArrGold.Count > 0 Then
                'ArrGold.Item(0)
                cboGoldKarat.Text = ArrGold.Item(0)
                txtGoldKarat.Text = ArrGold.Item(1)
                lblGoldKaratPrice.Text = ArrGold.Item(2)
                lblGoldPrice.Text = ArrGold.Item(3)
            End If
            '---- Gold Saving [end] ----

            '--- Dia Saving [start] ---
            If ArrDia.Count > 0 Then
                'ArrDia.Item(0)

                For i = 0 To ctrArrDia - 1
                    If i = 0 Then
                        txtDiaNoDia.Text = ArrDia.Item(0)
                        txtDiaCW.Text = ArrDia.Item(1)
                        cboDiaCut.Text = ArrDia.Item(2)
                        cboDiaColor.Text = ArrDia.Item(3)
                        cboDiaClarity.Text = ArrDia.Item(4)
                        txtCW.Text = ArrDia.Item(5)
                        lblDiaPC.Text = ArrDia.Item(6)
                    ElseIf i = 1 Then
                        txtDiaNoDia2.Text = ArrDia.Item(7)
                        txtDiaCW2.Text = ArrDia.Item(8)
                        cboDiaCut2.Text = ArrDia.Item(9)
                        cboDiaColor2.Text = ArrDia.Item(10)
                        cboDiaClarity2.Text = ArrDia.Item(11)
                        txtCW2.Text = ArrDia.Item(12)
                        lblDiaPC2.Text = ArrDia.Item(13)
                    ElseIf i = 2 Then
                        txtDiaNoDia3.Text = ArrDia.Item(14)
                        txtDiaCW3.Text = ArrDia.Item(15)
                        cboDiaCut3.Text = ArrDia.Item(16)
                        cboDiaColor3.Text = ArrDia.Item(17)
                        cboDiaClarity3.Text = ArrDia.Item(18)
                        txtCW3.Text = ArrDia.Item(19)
                        lblDiaPC3.Text = ArrDia.Item(20)
                    ElseIf i = 3 Then
                        txtDiaNoDia4.Text = ArrDia.Item(21)
                        txtDiaCW4.Text = ArrDia.Item(22)
                        cboDiaCut4.Text = ArrDia.Item(23)
                        cboDiaColor4.Text = ArrDia.Item(24)
                        cboDiaClarity4.Text = ArrDia.Item(25)
                        txtCW4.Text = ArrDia.Item(26)
                        lblDiaPC4.Text = ArrDia.Item(27)
                    ElseIf i = 4 Then
                        txtDiaNoDia5.Text = ArrDia.Item(28)
                        txtDiaCW5.Text = ArrDia.Item(29)
                        cboDiaCut5.Text = ArrDia.Item(30)
                        cboDiaColor5.Text = ArrDia.Item(31)
                        cboDiaClarity5.Text = ArrDia.Item(32)
                        txtCW5.Text = ArrDia.Item(33)
                        lblDiaPC5.Text = ArrDia.Item(34)
                    End If
                Next
            End If
            '---- Dia Saving [end] ----

            '--- Pearl Saving [start] ---
            If ArrPearl.Count > 0 Then
                For i = 0 To ctrArrPearl - 1
                    If i = 0 Then
                        txtNoPearl.Text = ArrPearl.Item(0)
                        cboPearlName.Text = ArrPearl.Item(1)
                        cboPearlSize.Text = ArrPearl.Item(2)
                        cboPearlQty.Text = ArrPearl.Item(3)
                        lblPearPrice.Text = ArrPearl.Item(4)
                    ElseIf i = 1 Then
                        txtNoPearl2.Text = ArrPearl.Item(5)
                        cboPearlName2.Text = ArrPearl.Item(6)
                        cboPearlSize2.Text = ArrPearl.Item(7)
                        cboPearlQty2.Text = ArrPearl.Item(8)
                        lblPearPrice2.Text = ArrPearl.Item(9)
                    ElseIf i = 2 Then
                        txtNoPearl3.Text = ArrPearl.Item(10)
                        cboPearlName3.Text = ArrPearl.Item(11)
                        cboPearlSize3.Text = ArrPearl.Item(12)
                        cboPearlQty3.Text = ArrPearl.Item(13)
                        lblPearPrice3.Text = ArrPearl.Item(14)
                    End If
                Next
            End If
            '---- Pearl Saving [end] ----

            '--- Precious Saving [start] ---
            If ArrPrecious.Count > 0 Then
                For i = 0 To ctrArrPrecious - 1
                    If i = 0 Then
                        cboCStonePS.Text = ArrPrecious.Item(0)
                        cboCStoneQty.Text = ArrPrecious.Item(1)
                        txtCStonCW.Text = ArrPrecious.Item(2)
                        lblCStonePC.Text = ArrPrecious.Item(3)
                    ElseIf i = 1 Then
                        cboCStonePS2.Text = ArrPrecious.Item(4)
                        cboCStoneQty2.Text = ArrPrecious.Item(5)
                        txtCStonCW2.Text = ArrPrecious.Item(6)
                        lblCStonePC2.Text = ArrPrecious.Item(7)
                    ElseIf i = 2 Then
                        cboCStonePS3.Text = ArrPrecious.Item(8)
                        cboCStoneQty3.Text = ArrPrecious.Item(9)
                        txtCStonCW3.Text = ArrPrecious.Item(10)
                        lblCStonePC3.Text = ArrPrecious.Item(11)
                    End If
                Next
            End If
            '---- Precious Saving [end] ----

            '--- Synthetic Saving [start] ---
            If ArrSynthetic.Count > 0 Then
                For i = 0 To ctrArrSynthetic - 1
                    If i = 0 Then
                        cboCStoneNS.Text = ArrSynthetic.Item(0)
                        cboCStoneNSQty.Text = ArrSynthetic.Item(1)
                        txtCStoneNSCW.Text = ArrSynthetic.Item(2)
                        lblCStoneNSPC.Text = ArrSynthetic.Item(3)
                    ElseIf i = 1 Then
                        cboCStoneNS2.Text = ArrSynthetic.Item(4)
                        cboCStoneNSQty2.Text = ArrSynthetic.Item(5)
                        txtCStoneNSCW2.Text = ArrSynthetic.Item(6)
                        lblCStoneNSPC2.Text = ArrSynthetic.Item(7)
                    ElseIf i = 2 Then
                        cboCStoneNS3.Text = ArrSynthetic.Item(8)
                        cboCStoneNSQty3.Text = ArrSynthetic.Item(9)
                        txtCStoneNSCW3.Text = ArrSynthetic.Item(10)
                        lblCStoneNSPC3.Text = ArrSynthetic.Item(11)
                    End If
                Next
            End If
            '---- Synthetic Saving [end] ----

            '--- Mounted Saving [start] ---
            If ArrMountedTotal.Count > 0 Then
                lblTGoldPrice.Text = ArrMountedTotal.Item(0)
                lblTDiaPrice.Text = ArrMountedTotal.Item(1)
                lblTPearlPrice.Text = ArrMountedTotal.Item(2)
                lblTCStonePrice.Text = ArrMountedTotal.Item(3)
                lblTSellingPrice.Text = ArrMountedTotal.Item(4)
                lblTSellingPrice.Tag = ArrMountedTotal.Item(4)
            End If
            '---- Mounted Saving [end] ----

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadColoredStoneCombo()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            '----- Load Data for Colored Stone Precious [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Precious_Stones FROM ASYS_PreciousType_Stones"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboCStonePS.Items.Add("")
            cboCStonePS2.Items.Add("")
            cboCStonePS3.Items.Add("")

            While dr.Read
                cboCStonePS.Items.Add(Trim(dr.Item("Precious_Stones")))
                cboCStonePS2.Items.Add(Trim(dr.Item("Precious_Stones")))
                cboCStonePS3.Items.Add(Trim(dr.Item("Precious_Stones")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Colored Stone Precious [end] -----

            '----- Load Data for Colored Stone Precious Quality [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT [Quality] FROM ASYS_Quality ORDER BY [ID]"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboCStoneQty.Items.Add("")
            cboCStoneQty2.Items.Add("")
            cboCStoneQty3.Items.Add("")

            cboCStoneNSQty.Items.Add("")
            cboCStoneNSQty2.Items.Add("")
            cboCStoneNSQty3.Items.Add("")

            While dr.Read
                '--- quality for Precious [start] ---
                cboCStoneQty.Items.Add(Trim(dr.Item("Quality")))
                cboCStoneQty2.Items.Add(Trim(dr.Item("Quality")))
                cboCStoneQty3.Items.Add(Trim(dr.Item("Quality")))
                '--- quality for Precious [end] ---

                '--- quality for Synthetic [start] ---
                cboCStoneNSQty.Items.Add(Trim(dr.Item("Quality")))
                cboCStoneNSQty2.Items.Add(Trim(dr.Item("Quality")))
                cboCStoneNSQty3.Items.Add(Trim(dr.Item("Quality")))
                '--- quality for Synthetic [end] ---
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Colored Stone Precious Quality [end] -----

            '----- Load Data for Colored Stone Synthetic [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Synthetic_Stones FROM ASYS_Synthetic_Stones ORDER BY Synthetic_Stones"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboCStoneNS.Items.Add("")
            cboCStoneNS2.Items.Add("")
            cboCStoneNS3.Items.Add("")

            While dr.Read
                cboCStoneNS.Items.Add(Trim(dr.Item("Synthetic_Stones")))
                cboCStoneNS2.Items.Add(Trim(dr.Item("Synthetic_Stones")))
                cboCStoneNS3.Items.Add(Trim(dr.Item("Synthetic_Stones")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Colored Stone Synthetic [end] -----


        Catch ex As Exception
            MsgBox("frmRec/LoadColoredStoneCombo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub LoadPearlCombo()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            '----- Load Data for Pearl Name [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Pearl_Type FROM ASYS_PearlType ORDER BY Pearl_Type"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboPearlName.Items.Add("")
            cboPearlName2.Items.Add("")
            cboPearlName3.Items.Add("")

            While dr.Read
                cboPearlName.Items.Add(Trim(dr.Item("Pearl_Type")))
                cboPearlName2.Items.Add(Trim(dr.Item("Pearl_Type")))
                cboPearlName3.Items.Add(Trim(dr.Item("Pearl_Type")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Pearl Name [end] -----

            '----- Load Data for Pearl Size [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Pearl_Size FROM ASYS_PearlSize ORDER BY [ID]"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboPearlSize.Items.Add("")
            cboPearlSize2.Items.Add("")
            cboPearlSize3.Items.Add("")

            While dr.Read
                cboPearlSize.Items.Add(Trim(dr.Item("Pearl_Size")))
                cboPearlSize2.Items.Add(Trim(dr.Item("Pearl_Size")))
                cboPearlSize3.Items.Add(Trim(dr.Item("Pearl_Size")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Pearl Size [end] -----

            '----- Load Data for Pearl Quality [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT [Quality] FROM ASYS_Quality ORDER BY [ID]"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboPearlQty.Items.Add("")
            cboPearlQty2.Items.Add("")
            cboPearlQty3.Items.Add("")

            While dr.Read
                cboPearlQty.Items.Add(Trim(dr.Item("Quality")))
                cboPearlQty2.Items.Add(Trim(dr.Item("Quality")))
                cboPearlQty3.Items.Add(Trim(dr.Item("Quality")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Pearl Quality [end] -----

        Catch ex As Exception
            MsgBox("frmRec/LoadPearlCombo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub LoadDiaCombo()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            '----- Load Data for Dia Cut [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Cut_Type FROM ASYS_DiaTypeCut ORDER BY Cut_Type"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboDiaCut.Items.Add("")
            cboDiaCut2.Items.Add("")
            cboDiaCut3.Items.Add("")
            cboDiaCut4.Items.Add("")
            cboDiaCut5.Items.Add("")

            While dr.Read
                cboDiaCut.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaCut2.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaCut3.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaCut4.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaCut5.Items.Add(Trim(dr.Item("Cut_Type")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Dia Cut [end] -----

            '----- Load Data for Dia Color [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Cut_Type FROM ASYS_DiaTypeColor ORDER BY Cut_Type"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboDiaColor.Items.Add("")
            cboDiaColor2.Items.Add("")
            cboDiaColor3.Items.Add("")
            cboDiaColor4.Items.Add("")
            cboDiaColor5.Items.Add("")

            While dr.Read
                cboDiaColor.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaColor2.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaColor3.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaColor4.Items.Add(Trim(dr.Item("Cut_Type")))
                cboDiaColor5.Items.Add(Trim(dr.Item("Cut_Type")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Dia Color [end] -----

            '----- Load Data for Dia Clarity [start] -----
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Clarity_Type FROM ASYS_DiaTypeClarity ORDER BY Clarity_Type"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            cboDiaClarity.Items.Add("")
            cboDiaClarity2.Items.Add("")
            cboDiaClarity3.Items.Add("")
            cboDiaClarity4.Items.Add("")
            cboDiaClarity5.Items.Add("")

            While dr.Read
                cboDiaClarity.Items.Add(Trim(dr.Item("Clarity_Type")))
                cboDiaClarity2.Items.Add(Trim(dr.Item("Clarity_Type")))
                cboDiaClarity3.Items.Add(Trim(dr.Item("Clarity_Type")))
                cboDiaClarity4.Items.Add(Trim(dr.Item("Clarity_Type")))
                cboDiaClarity5.Items.Add(Trim(dr.Item("Clarity_Type")))
            End While

            dr.Close()
            obj.Close3()
            '----- Load Data for Dia Clarity [end] -----

        Catch ex As Exception
            MsgBox("frmRec/LoadDiaCombo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmMountedPricing_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'MountedPrice = lblTSellingPrice.Text
        MountedPrice = SPrice
        'Smounted = lblTGoldPrice.Text
        Smounted = lblTSellingPrice.Text
        GKarat = txtGoldKarat.Text
        SearchFlag = True
        'FlagPricingNotSave = True
        PopulateArray()

        Me.Dispose()
    End Sub

    Private Sub cboGoldKarat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGoldKarat.SelectedIndexChanged
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            If cboGoldKarat.SelectedIndex = 0 Then
                txtGoldKarat.Text = ""
                lblGoldKaratPrice.Text = ""
                lblGoldPrice.Text = "0.00"
                lblGoldKaratPrice.Tag = "0"
                lblTGoldPrice.Text = "0.00"
                lblTGoldPrice.Tag = "0"
                Call AllTotal()
                Exit Sub
            End If

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Mounted FROM ASYS_GOLDKARAT WHERE Gold_Karat = '" & cboGoldKarat.Text & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            While dr.Read
                lblGoldKaratPrice.Text = Format(dr.Item("Mounted"), "#,###,##0.00")
                lblGoldKaratPrice.Tag = lblGoldKaratPrice.Text
            End While

            dr.Close()
            obj.Close3()

            lblGoldPrice.Text = FormatNumber(IIf(txtGoldKarat.Text.Length <= 0, 0, txtGoldKarat.Text) * CDbl(lblGoldKaratPrice.Text))
            lblGoldPrice.Text = Format(Computation("GOLDKARAT"), "#,###,##0.00")
            Call AllTotal()
            txtGoldKarat.Focus()

        Catch ex As Exception
            MsgBox("frmRec/cboGoldKarat_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtGoldKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGoldKarat.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtGoldKarat.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If e.KeyChar = ChrW(13) Then
                txtDiaNoDia.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtGoldKarat_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Function Computation(ByVal PricingType As String) As Double
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            If PricingType = "GOLDKARAT" Then
                lblGoldPrice.Text = FormatNumber(CDbl(IIf(txtGoldKarat.Text.Length <= 0, 0, txtGoldKarat.Text)) * CDbl(lblGoldKaratPrice.Tag))
                Computation = lblGoldPrice.Text

            ElseIf PricingType = "DIAMOND" Then
                str = "SELECT VS, SI, I FROM ASYS_DiaPriceGuide " & _
                      "WHERE (carat_WT_FROM <=" & tmpDiaCW & " AND Carat_WT_To >=" & tmpDiaCW & ") " & _
                      "AND Color_Type = '" & tmpDiaColor & "'"

                obj.Command3(str)
                dr = obj.OpenDataReader3

                While dr.Read
                    If tmpDiaClarity = "VS" Then
                        Computation = Format(dr.Item("VS"), "#,###,##0.00")
                    ElseIf tmpDiaClarity = "SI" Then
                        Computation = Format(dr.Item("SI"), "#,###,##0.00")
                    ElseIf tmpDiaClarity = "I" Then
                        Computation = Format(dr.Item("I"), "#,###,##0.00")
                    End If
                End While

                dr.Close()
                obj.Close3()

            ElseIf PricingType = "PEARL" Then
                str = "SELECT VeryGood, Good, Poor FROM ASYS_PearlGuide WHERE Pearl_Type = '" & tmpPearlType & "'"

                obj.Command3(str)
                dr = obj.OpenDataReader3

                While dr.Read
                    If UCase(tmpQuality) = "VERY GOOD" Then
                        Computation = Format(dr.Item("VeryGood"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "GOOD" Then
                        Computation = Format(dr.Item("Good"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "POOR" Then
                        Computation = Format(dr.Item("POOR"), "#,###,##0.00")
                    End If
                End While

                dr.Close()
                obj.Close3()

            ElseIf PricingType = "COLORED PRECIOUS" Then
                str = "SELECT ColStoneVeryGood, ColStoneGood, ColStonePoor FROM ASYS_ColStoneGuide WHERE ColStone_Type LIKE 'PRECIOUS%'"

                obj.Command3(str)
                dr = obj.OpenDataReader3

                While dr.Read
                    If UCase(tmpQuality) = "VERY GOOD" Then
                        Computation = Format(dr.Item("ColStoneVeryGood"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "GOOD" Then
                        Computation = Format(dr.Item("ColStoneGood"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "POOR" Then
                        Computation = Format(dr.Item("ColStonePoor"), "#,###,##0.00")
                    End If
                End While

                dr.Close()
                obj.Close3()

            ElseIf PricingType = "COLORED NATURAL" Then
                str = "SELECT ColStoneVeryGood, ColStoneGood, ColStonePoor FROM ASYS_ColStoneGuide WHERE ColStone_Type LIKE 'NATURAL%'"

                obj.Command3(str)
                dr = obj.OpenDataReader3

                While dr.Read
                    If UCase(tmpQuality) = "VERY GOOD" Then
                        Computation = Format(dr.Item("ColStoneVeryGood"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "GOOD" Then
                        Computation = Format(dr.Item("ColStoneGood"), "#,###,##0.00")
                    ElseIf UCase(tmpQuality) = "POOR" Then
                        Computation = Format(dr.Item("ColStonePoor"), "#,###,##0.00")
                    End If
                End While

                dr.Close()
                obj.Close3()
            End If

        Catch ex As Exception
            MsgBox("frmRec/Computation: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub txtDiaCW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaCW.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtDiaCW.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    'If txtDiaCW.Text.Length >= 0 Then
                    '    If cboDiaClarity.SelectedIndex = -1 Then
                    '        MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                    '        txtDiaCW.Text = String.Empty
                    '        Exit Sub
                    '    End If
                    'End If
                    cboDiaCut.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCW.TextChanged
        Try
            If txtDiaCW.Text = "" Then
                Exit Sub
            Else
                If Replace(txtDiaCW.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW.Text.Length <= 0, 0, txtDiaCW.Text)
            tmpDiaColor = cboDiaColor.Text
            tmpDiaClarity = cboDiaClarity.Text
            txtDiaCW.Tag = txtDiaCW.Text

            If cboDiaCut.Text = "DIAMANTE" Then
                txtDiaCW.Text = ""
                ''lblDiaPC.Text = "1,000.00"
                ''lblDiaPC.Tag = "1,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut.Text = "OLD CUT" Then
                txtDiaCW.Text = ""
                ''lblDiaPC.Text = "15,000.00"
                ''lblDiaPC.Tag = "15,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                txtDiaCW.Text = ""
                ''lblDiaPC.Text = "12,000.00"
                ''lblDiaPC.Tag = "12,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            Else
                lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC.Tag = lblDiaPC.Text
                Call AllTotal()
            End If

            ''lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            ''lblDiaPC.Tag = lblDiaPC.Text
            ''Call AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaColor.SelectedIndexChanged
        Try
            If cboDiaColor.SelectedIndex >= 1 And cboDiaColor.Text <> "" Then
                If cboDiaCut.SelectedIndex = 0 Then
                    MsgBox("Please select type of cut.     ", MsgBoxStyle.OKOnly)
                    cboDiaColor.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            If cboDiaCut.Text = "DIAMANTE" Then
                cboDiaColor.SelectedIndex = 0
                Exit Sub
            ElseIf cboDiaCut.Text = "OLD CUT" Then
                cboDiaColor.SelectedIndex = 0
                Exit Sub
            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                cboDiaColor.SelectedIndex = 0
                Exit Sub
            End If

            tmpDiaCW = IIf(txtDiaCW.Text.Length <= 0, 0, txtDiaCW.Text)
            tmpDiaColor = cboDiaColor.Text
            tmpDiaClarity = cboDiaClarity.Text

            lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaColor_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaClarity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaClarity.SelectedIndexChanged
        Try

            If cboDiaCut.Text = "DIAMANTE" Then
                cboDiaClarity.SelectedIndex = 0
                Exit Sub
            ElseIf cboDiaCut.Text = "OLD CUT" Then
                cboDiaClarity.SelectedIndex = 0
                Exit Sub
            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                cboDiaClarity.SelectedIndex = 0
                Exit Sub
            End If

            If cboDiaClarity.SelectedIndex >= 1 And cboDiaClarity.Text <> "" Then
                If cboDiaColor.SelectedIndex = 0 Then
                    MsgBox("Please select type of color.     ", MsgBoxStyle.OKOnly)
                    cboDiaClarity.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW.Text.Length <= 0, 0, txtDiaCW.Text)
            tmpDiaColor = cboDiaColor.Text
            tmpDiaClarity = cboDiaClarity.Text

            lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
            txtDiaCW.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaClarity_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaColor2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaColor2.SelectedIndexChanged
        Try
            If cboDiaColor2.SelectedIndex >= 0 And cboDiaColor2.Text <> "" Then
                If cboDiaCut2.SelectedIndex = -1 Then
                    MsgBox("Please select type of cut.     ", MsgBoxStyle.OKOnly)
                    cboDiaColor2.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            If cboDiaCut2.Text = "DIAMANTE" Then
                cboDiaColor2.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                cboDiaColor2.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                cboDiaColor2.SelectedIndex = -1
                Exit Sub
            End If

            tmpDiaCW = IIf(txtDiaCW2.Text.Length <= 0, 0, txtDiaCW2.Text)
            tmpDiaColor = cboDiaColor2.Text
            tmpDiaClarity = cboDiaClarity2.Text

            lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaColor2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaClarity2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaClarity2.SelectedIndexChanged
        Try

            If cboDiaCut2.Text = "DIAMANTE" Then
                cboDiaClarity2.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                cboDiaClarity2.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                cboDiaClarity2.SelectedIndex = -1
                Exit Sub
            End If

            If cboDiaClarity2.SelectedIndex >= 0 And cboDiaClarity2.Text <> "" Then
                If cboDiaColor2.SelectedIndex = -1 Then
                    MsgBox("Please select type of color.     ", MsgBoxStyle.OKOnly)
                    cboDiaClarity2.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW2.Text.Length <= 0, 0, txtDiaCW2.Text)
            tmpDiaColor = cboDiaColor2.Text
            tmpDiaClarity = cboDiaClarity2.Text

            lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaClarity2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaCW2.KeyPress
        Try


            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtDiaCW2.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    'If txtDiaCW2.Text.Length >= 0 Then
                    '    If cboDiaClarity2.SelectedIndex = -1 Then
                    '        MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                    '        txtDiaCW2.Text = String.Empty
                    '    End If
                    'End If
                    cboDiaCut2.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCW2.TextChanged
        Try

            If txtDiaCW2.Text = "" Then
                Exit Sub
            Else
                If Replace(txtDiaCW2.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW2.Text.Length <= 0, 0, txtDiaCW2.Text)
            tmpDiaColor = cboDiaColor2.Text
            tmpDiaClarity = cboDiaClarity2.Text
            txtDiaCW2.Tag = txtDiaCW2.Text

            If cboDiaCut2.Text = "DIAMANTE" Then
                txtDiaCW2.Text = ""
                ''lblDiaPC2.Text = "1,000.00"
                ''lblDiaPC2.Tag = "1,000.00"
                ''lblDiaPC2.Tag = lblDiaPC2.Text
                ''Call AllTotal()
            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                txtDiaCW2.Text = ""
                ''lblDiaPC2.Text = "15,000.00"
                ''lblDiaPC2.Tag = "15,000.00"
                ''lblDiaPC2.Tag = lblDiaPC2.Text
                ''Call AllTotal()
            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                txtDiaCW2.Text = ""
                ''lblDiaPC2.Text = "12,000.00"
                ''lblDiaPC2.Tag = "12,000.00"
                ''lblDiaPC2.Tag = lblDiaPC2.Text
                ''Call AllTotal()
            Else
                lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC2.Tag = lblDiaPC2.Text
                Call AllTotal()
            End If

            '''lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            '''lblDiaPC2.Tag = lblDiaPC2.Text
            '''Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaColor3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaColor3.SelectedIndexChanged
        Try
            If cboDiaColor3.SelectedIndex >= 0 And cboDiaColor3.Text <> "" Then
                If cboDiaCut3.SelectedIndex = -1 Then
                    MsgBox("Please select type of cut.     ", MsgBoxStyle.OKOnly)
                    cboDiaColor3.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            If cboDiaCut3.Text = "DIAMANTE" Then
                cboDiaColor3.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                cboDiaColor3.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                cboDiaColor3.SelectedIndex = -1
                Exit Sub
            End If

            tmpDiaCW = IIf(txtDiaCW3.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor3.Text
            tmpDiaClarity = cboDiaClarity3.Text

            lblDiaPC3.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaColor3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaClarity3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaClarity3.SelectedIndexChanged
        Try


            If cboDiaCut3.Text = "DIAMANTE" Then
                cboDiaClarity3.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                cboDiaClarity3.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                cboDiaClarity3.SelectedIndex = -1
                Exit Sub
            End If

            If cboDiaClarity3.SelectedIndex >= 0 And cboDiaClarity3.Text <> "" Then
                If cboDiaColor3.SelectedIndex = -1 Then
                    MsgBox("Please select type of color.     ", MsgBoxStyle.OKOnly)
                    cboDiaClarity3.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW3.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor3.Text
            tmpDiaClarity = cboDiaClarity3.Text

            lblDiaPC3.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaClarity3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaCW3.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtDiaCW3.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    'If txtDiaCW3.Text.Length >= 0 Then
                    '    If cboDiaClarity3.SelectedIndex = -1 Then
                    '        MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                    '        txtDiaCW3.Text = String.Empty
                    '    End If
                    'End If
                    cboDiaCut3.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCW3.TextChanged
        Try

            If txtDiaCW3.Text = "" Then
                Exit Sub
            Else
                If Replace(txtDiaCW3.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW3.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor3.Text
            tmpDiaClarity = cboDiaClarity3.Text
            txtDiaCW3.Tag = txtDiaCW3.Text

            If cboDiaCut3.Text = "DIAMANTE" Then
                txtDiaCW3.Text = ""
                ''lblDiaPC.Text = "1,000.00"
                ''lblDiaPC.Tag = "1,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                txtDiaCW3.Text = ""
                ''lblDiaPC.Text = "15,000.00"
                ''lblDiaPC.Tag = "15,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                txtDiaCW3.Text = ""
                ''lblDiaPC.Text = "12,000.00"
                ''lblDiaPC.Tag = "12,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            Else
                lblDiaPC3.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC3.Tag = lblDiaPC3.Text
                Call AllTotal()
            End If

        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaCW4.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtDiaCW4.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    'If txtDiaCW4.Text.Length >= 0 Then
                    '    If cboDiaClarity4.SelectedIndex = -1 Then
                    '        MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                    '        txtDiaCW4.Text = String.Empty
                    '    End If
                    'End If
                    cboDiaCut3.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCW4.TextChanged
        Try

            If txtDiaCW4.Text = "" Then
                Exit Sub
            Else
                If Replace(txtDiaCW4.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW4.Text.Length <= 0, 0, txtDiaCW4.Text)
            tmpDiaColor = cboDiaColor4.Text
            tmpDiaClarity = cboDiaClarity4.Text
            txtDiaCW4.Tag = txtDiaCW4.Text

            If cboDiaCut4.Text = "DIAMANTE" Then
                txtDiaCW4.Text = ""
                ''lblDiaPC.Text = "1,000.00"
                ''lblDiaPC.Tag = "1,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut4.Text = "OLD CUT" Then
                txtDiaCW4.Text = ""
                ''lblDiaPC.Text = "15,000.00"
                ''lblDiaPC.Tag = "15,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                txtDiaCW4.Text = ""
                ''lblDiaPC.Text = "12,000.00"
                ''lblDiaPC.Tag = "12,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            Else
                lblDiaPC4.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC4.Tag = lblDiaPC4.Text
                Call AllTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW4_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaClarity4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaClarity4.SelectedIndexChanged
        Try

            If cboDiaCut4.Text = "DIAMANTE" Then
                cboDiaClarity4.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut4.Text = "OLD CUT" Then
                cboDiaClarity4.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                cboDiaClarity4.SelectedIndex = -1
                Exit Sub
            End If

            If cboDiaClarity4.SelectedIndex >= 0 And cboDiaClarity4.Text <> "" Then
                If cboDiaColor4.SelectedIndex = -1 Then
                    MsgBox("Please select type of color.     ", MsgBoxStyle.OKOnly)
                    cboDiaClarity4.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW4.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor4.Text
            tmpDiaClarity = cboDiaClarity4.Text

            lblDiaPC4.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaClarity4_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaColor4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaColor4.SelectedIndexChanged
        Try
            If cboDiaColor4.SelectedIndex >= 0 And cboDiaColor4.Text <> "" Then
                If cboDiaCut4.SelectedIndex = -1 Then
                    MsgBox("Please select type of cut.     ", MsgBoxStyle.OKOnly)
                    cboDiaColor4.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            If cboDiaCut4.Text = "DIAMANTE" Then
                cboDiaColor4.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut4.Text = "OLD CUT" Then
                cboDiaColor4.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                cboDiaColor4.SelectedIndex = -1
                Exit Sub
            End If

            tmpDiaCW = IIf(txtDiaCW4.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor4.Text
            tmpDiaClarity = cboDiaClarity4.Text

            lblDiaPC4.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaColor4_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaColor5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaColor5.SelectedIndexChanged
        Try
            If cboDiaColor5.SelectedIndex >= 0 And cboDiaColor5.Text <> "" Then
                If cboDiaCut5.SelectedIndex = -1 Then
                    MsgBox("Please select type of cut.     ", MsgBoxStyle.OKOnly)
                    cboDiaColor5.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            If cboDiaCut5.Text = "DIAMANTE" Then
                cboDiaColor5.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                cboDiaColor5.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                cboDiaColor5.SelectedIndex = -1
                Exit Sub
            End If

            tmpDiaCW = IIf(txtDiaCW5.Text.Length <= 0, 0, txtDiaCW5.Text)
            tmpDiaColor = cboDiaColor5.Text
            tmpDiaClarity = cboDiaClarity5.Text

            lblDiaPC5.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaColor5_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaClarity5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaClarity5.SelectedIndexChanged
        Try


            If cboDiaCut5.Text = "DIAMANTE" Then
                cboDiaClarity5.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                cboDiaClarity5.SelectedIndex = -1
                Exit Sub
            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then

                Exit Sub
            End If

            If cboDiaClarity5.SelectedIndex >= 0 And cboDiaClarity5.Text <> "" Then
                If cboDiaColor5.SelectedIndex = -1 Then
                    MsgBox("Please select type of color.     ", MsgBoxStyle.OKOnly)
                    cboDiaClarity5.SelectedIndex = -1
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW5.Text.Length <= 0, 0, txtDiaCW5.Text)
            tmpDiaColor = cboDiaColor5.Text
            tmpDiaClarity = cboDiaClarity5.Text

            lblDiaPC5.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/cboDiaClarity5_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaCW5.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtDiaCW5.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    'If txtDiaCW5.Text.Length >= 0 Then
                    '    If cboDiaClarity5.SelectedIndex = -1 Then
                    '        MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                    '        txtDiaCW5.Text = String.Empty
                    '    End If
                    'End If
                    cboDiaCut5.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW5_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaCW5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaCW5.TextChanged
        Try

            If txtDiaCW5.Text = "" Then
                Exit Sub
            Else
                If Replace(txtDiaCW5.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW5.Text.Length <= 0, 0, txtDiaCW5.Text)
            tmpDiaColor = cboDiaColor5.Text
            tmpDiaClarity = cboDiaClarity5.Text
            txtDiaCW5.Tag = txtDiaCW5.Text

            If cboDiaCut5.Text = "DIAMANTE" Then
                txtDiaCW5.Text = ""
                ''lblDiaPC.Text = "1,000.00"
                ''lblDiaPC.Tag = "1,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                txtDiaCW5.Text = ""
                ''lblDiaPC.Text = "15,000.00"
                ''lblDiaPC.Tag = "15,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                txtDiaCW5.Text = ""
                ''lblDiaPC.Text = "12,000.00"
                ''lblDiaPC.Tag = "12,000.00"
                ''lblDiaPC.Tag = lblDiaPC.Text
                ''Call AllTotal()
            Else
                lblDiaPC5.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC5.Tag = lblDiaPC5.Text
                Call AllTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaCW5_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function RoundedTotal(ByVal tmpRoundOff As String) As Double
        Dim tmpRoundedTotal As Double
        Dim tmpTotalLenght As Integer

        'Total for Gold Karat
        If CDbl(tmpRoundOff) <= 0 Then
            RoundedTotal = "0.00"
        Else
            tmpTotalLenght = tmpRoundOff.Length
            tmpRoundedTotal = tmpRoundOff.Substring((tmpTotalLenght - 5), 2)

            If tmpRoundedTotal > 50 Then
                RoundedTotal = CDbl(tmpRoundOff) + (100 - CDbl(tmpRoundOff.Substring((tmpTotalLenght - 5), 5)))
            Else
                RoundedTotal = CDbl(tmpRoundOff) - CDbl(tmpRoundOff.Substring((tmpTotalLenght - 5), 5))
            End If
            'lblTGoldPrice.Text = lblGoldPrice.Text
        End If
    End Function
    Private Sub clearTotal()
        Try

            '--------Clear Diamond Data
            If (cboDiaCut.Text = "DIAMANTE" Or cboDiaCut.Text = "OLD CUT" Or cboDiaCut.Text = "SINGLE CUT") Or (cboDiaCut2.Text = "DIAMANTE" Or cboDiaCut2.Text = "OLD CUT" Or cboDiaCut2.Text = "SINGLE CUT") Or (cboDiaCut3.Text = "DIAMANTE" Or cboDiaCut3.Text = "OLD CUT" Or cboDiaCut3.Text = "SINGLE CUT") Or (cboDiaCut4.Text = "DIAMANTE" Or cboDiaCut4.Text = "OLD CUT" Or cboDiaCut4.Text = "SINGLE CUT") Or (cboDiaCut5.Text = "DIAMANTE" Or cboDiaCut5.Text = "OLD CUT" Or cboDiaCut5.Text = "SINGLE CUT") Then
                If txtDiaNoDia.Text = "" Or cboDiaCut.Text = "" Then
                    lblDiaPC.Text = "0.00"
                    cboDiaCut.SelectedIndex = 0
                End If
                If txtDiaNoDia2.Text = "" Or cboDiaCut2.Text = "" Then
                    lblDiaPC2.Text = "0.00"
                    cboDiaCut2.SelectedIndex = 0
                End If
                If txtDiaNoDia3.Text = "" Or cboDiaCut3.Text = "" Then
                    lblDiaPC3.Text = "0.00"
                    cboDiaCut3.SelectedIndex = 0
                End If
                If txtDiaNoDia4.Text = "" Or cboDiaCut4.Text = "" Then
                    lblDiaPC4.Text = "0.00"
                    cboDiaCut4.SelectedIndex = 0
                End If
                If txtDiaNoDia5.Text = "" Or cboDiaCut5.Text = "" Then
                    lblDiaPC5.Text = "0.00"
                    cboDiaCut5.SelectedIndex = 0
                End If


            End If
            AllTotal()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub AllTotal()
        Try
            Dim tmpTotalColored As Double
            Dim tmpTotalDia As Double
            Dim WithFixedAmount As Double = 0
            Dim WithFixedAmount2 As Double = 0
            Dim WithFixedAmount3 As Double = 0
            Dim WithFixedAmount4 As Double = 0
            Dim WithFixedAmount5 As Double = 0

            lblTGoldPrice.Text = IIf(CDbl(lblGoldPrice.Text) <= 0, "0.00", lblGoldPrice.Text)
            'lblTGoldPrice.Text = Format(lblGoldPrice.Text, "#,###,##0.00")
            lblGoldPrice.Tag = lblTGoldPrice.Text
            lblTGoldPrice.Tag = lblTGoldPrice.Text


            'Total for Diamond

            If cboDiaCut.Text = "DIAMANTE" Then
                WithFixedAmount = "1,000.00"
                WithFixedAmount = WithFixedAmount * txtDiaNoDia.Tag
            ElseIf cboDiaCut.Text = "OLD CUT" Then
                WithFixedAmount = "15,000.00"
                WithFixedAmount = WithFixedAmount * txtDiaNoDia.Tag
            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                WithFixedAmount = "12,000.00"
                WithFixedAmount = WithFixedAmount * txtDiaNoDia.Tag
            End If

            If cboDiaCut2.Text = "DIAMANTE" Then
                WithFixedAmount2 = "1,000.00"
                WithFixedAmount2 = WithFixedAmount2 * txtDiaNoDia2.Tag
            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                WithFixedAmount2 = "15,000.00"
                WithFixedAmount2 = WithFixedAmount2 * txtDiaNoDia2.Tag
            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                WithFixedAmount2 = "12,000.00"
                WithFixedAmount2 = WithFixedAmount2 * txtDiaNoDia2.Tag
            End If

            If cboDiaCut3.Text = "DIAMANTE" Then
                WithFixedAmount3 = "1,000.00"
                WithFixedAmount3 = WithFixedAmount3 * txtDiaNoDia3.Tag
            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                WithFixedAmount3 = "15,000.00"
                WithFixedAmount3 = WithFixedAmount3 * txtDiaNoDia3.Tag
            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                WithFixedAmount3 = "12,000.00"
                WithFixedAmount3 = WithFixedAmount3 * txtDiaNoDia3.Tag
            End If

            If cboDiaCut4.Text = "DIAMANTE" Then
                WithFixedAmount4 = "1,000.00"
                WithFixedAmount4 = WithFixedAmount4 * txtDiaNoDia4.Tag
            ElseIf cboDiaCut4.Text = "OLD CUT" Then
                WithFixedAmount4 = "15,000.00"
                WithFixedAmount4 = WithFixedAmount4 * txtDiaNoDia4.Tag
            ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                WithFixedAmount4 = "12,000.00"
                WithFixedAmount4 = WithFixedAmount4 * txtDiaNoDia4.Tag
            End If

            If cboDiaCut5.Text = "DIAMANTE" Then
                WithFixedAmount5 = "1,000.00"
                WithFixedAmount5 = WithFixedAmount5 * txtDiaNoDia5.Tag
            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                WithFixedAmount5 = "15,000.00"
                WithFixedAmount5 = WithFixedAmount5 * txtDiaNoDia5.Tag
            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                WithFixedAmount = "12,000.00"
                WithFixedAmount5 = WithFixedAmount5 * txtDiaNoDia5.Tag
            End If

            tmpTotalDia = txtDiaNoDia.Tag * (CDbl(txtDiaCW.Tag) * CDbl(lblDiaPC.Text)) + WithFixedAmount
            tmpTotalDia = tmpTotalDia + txtDiaNoDia2.Tag * (CDbl(txtDiaCW2.Tag) * CDbl(lblDiaPC2.Text)) + WithFixedAmount2
            tmpTotalDia = tmpTotalDia + txtDiaNoDia3.Tag * (CDbl(txtDiaCW3.Tag) * CDbl(lblDiaPC3.Text)) + WithFixedAmount3
            tmpTotalDia = tmpTotalDia + txtDiaNoDia4.Tag * (CDbl(txtDiaCW4.Tag) * CDbl(lblDiaPC4.Text)) + WithFixedAmount4
            tmpTotalDia = tmpTotalDia + txtDiaNoDia5.Tag * (CDbl(txtDiaCW5.Tag) * CDbl(lblDiaPC5.Text)) + WithFixedAmount5

            txtCW.Text = txtDiaNoDia.Tag * CDbl(txtDiaCW.Tag)
            txtCW2.Text = txtDiaNoDia2.Tag * CDbl(txtDiaCW2.Tag)
            txtCW3.Text = txtDiaNoDia3.Tag * CDbl(txtDiaCW3.Tag)
            txtCW4.Text = txtDiaNoDia4.Tag * CDbl(txtDiaCW4.Tag)
            txtCW5.Text = txtDiaNoDia5.Tag * CDbl(txtDiaCW5.Tag)

            lblTDiaPrice.Text = Format(tmpTotalDia, "#,###,##0.00") ' Format(tmpTotalDia, "#,###,##0.00")
            lblTDiaPrice.Tag = lblTDiaPrice.Text

            'Total for Pearl
            lblTPearlPrice.Text = Format(CDbl(lblPearPrice.Text) + CDbl(lblPearPrice2.Text) + CDbl(lblPearPrice3.Text), "#,###,##0.00") 'Format(CDbl(lblPearPrice.Text) + CDbl(lblPearPrice2.Text) + CDbl(lblPearPrice3.Text), "#,###,##0.00")
            lblTPearlPrice.Tag = lblTPearlPrice.Text

            'Total for Colored
            tmpTotalColored = CDbl(txtCStonCW.Tag) * CDbl(lblCStonePC.Text)
            tmpTotalColored = tmpTotalColored + CDbl(txtCStonCW2.Tag) * CDbl(lblCStonePC2.Text)
            tmpTotalColored = tmpTotalColored + CDbl(txtCStonCW3.Tag) * CDbl(lblCStonePC3.Text)
            '''''add here for total sum of precious stones and natural/synthetic 10'17'2011
            ''''tmpTotalColored = tmpTotalColored + CDbl(lblCStonePC.Text) + tmpTotalColored + CDbl(lblCStoneNSPC.Text) 'CDbl(txtCStoneNSCW.Tag) *
            ''''tmpTotalColored = tmpTotalColored + CDbl(lblCStonePC2.Text) + tmpTotalColored + CDbl(lblCStoneNSPC2.Text) 'CDbl(txtCStoneNSCW2.Tag) * 
            ''''tmpTotalColored = tmpTotalColored + CDbl(lblCStonePC3.Text) + tmpTotalColored + CDbl(lblCStoneNSPC3.Text) 'CDbl(txtCStoneNSCW3.Tag) * 

            tmpTotalColored = tmpTotalColored + CDbl(lblCStoneNSPC.Text) 'CDbl(txtCStoneNSCW.Tag) *
            tmpTotalColored = tmpTotalColored + CDbl(lblCStoneNSPC2.Text) 'CDbl(txtCStoneNSCW2.Tag) * 
            tmpTotalColored = tmpTotalColored + CDbl(lblCStoneNSPC3.Text) 'CDbl(txtCStoneNSCW3.Tag) * 
            lblTCStonePrice.Text = Format(tmpTotalColored, "#,###,##0.00")  'Format(tmpTotalColored, "#,###,##0.00")
            lblTCStonePrice.Tag = lblTCStonePrice.Text

            'Total for selling Price
            lblTSellingPrice.Text = Format(RoundedTotal(Format(CDbl(lblTGoldPrice.Text) + CDbl(lblTDiaPrice.Text) + CDbl(lblTPearlPrice.Text) + CDbl(lblTCStonePrice.Text), "#,###,##0.00")), "#,###,##0.00")
            lblTSellingPrice.Tag = lblTSellingPrice.Text
        Catch ex As Exception
            MsgBox("frmRec/AllTotal: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlQty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlQty.SelectedIndexChanged
        Try

            tmpQuality = cboPearlQty.Text

            If cboPearlSize.Text.Length <= 0 Then
                tmpPearlType = cboPearlName.Text
            Else
                tmpPearlType = cboPearlName.Text + " (" + cboPearlSize.Text + ")"
            End If

            lblPearPrice.Text = Format(Computation("PEARL") * txtNoPearl.Tag, "#,###,##0.00")
            lblPearPrice.Tag = lblPearPrice.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlQty_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlQty2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlQty2.SelectedIndexChanged
        Try
            tmpQuality = cboPearlQty2.Text

            If cboPearlSize2.Text.Length <= 0 Then
                tmpPearlType = cboPearlName2.Text
            Else
                tmpPearlType = cboPearlName2.Text + " (" + cboPearlSize2.Text + ")"
            End If

            lblPearPrice2.Text = Format(Computation("PEARL") * txtNoPearl2.Tag, "#,###,##0.00")
            lblPearPrice2.Tag = lblPearPrice2.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlQty2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlQty3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlQty3.SelectedIndexChanged
        Try
            tmpQuality = cboPearlQty3.Text

            If cboPearlSize3.Text.Length <= 0 Then
                tmpPearlType = cboPearlName3.Text
            Else
                tmpPearlType = cboPearlName3.Text + " (" + cboPearlSize3.Text + ")"
            End If

            lblPearPrice3.Text = Format(Computation("PEARL") * txtNoPearl3.Tag, "#,###,##0.00")
            lblPearPrice3.Tag = lblPearPrice3.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlQty3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlName.SelectedIndexChanged
        Try
            cboPearlSize.Enabled = True
            tmpQuality = cboPearlQty.Text
            If cboPearlName.Text = "ROUND" Then
                cboPearlSize.SelectedIndex = 1
                Call cboPearlSize_SelectedIndexChanged(sender, e)
                Exit Sub
            ElseIf cboPearlName.Text = "SOUTH SEA PEARL" Then
                cboPearlSize.SelectedIndex = 2
                Call cboPearlSize_SelectedIndexChanged(sender, e)
                Exit Sub
            Else
                cboPearlSize.SelectedIndex = 0
                cboPearlSize.Enabled = False
            End If

            tmpPearlType = cboPearlName.Text + " (" + cboPearlSize.Text + ")"
            lblPearPrice.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice.Tag = lblPearPrice.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlName_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlSize.SelectedIndexChanged
        Try

            If cboPearlSize.SelectedIndex >= 0 Then
                If cboPearlName.SelectedIndex = -1 Then
                    MsgBox("Please select type of pearl.     ", MsgBoxStyle.OKOnly)
                    cboPearlSize.SelectedIndex = -1
                    Exit Sub
                End If

            End If

            tmpQuality = cboPearlQty.Text
            tmpPearlType = cboPearlName.Text + " (" + cboPearlSize.Text + ")"
            lblPearPrice.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice.Tag = lblPearPrice.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlSize_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStonCW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStonCW.TextChanged
        Try
            If txtCStonCW.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStonCW.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty.Text
            lblCStonePC.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            txtCStonCW.Tag = txtCStonCW.Text
            lblCStonePC.Tag = lblCStonePC.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStonCW_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    '''Private Sub txtCStonCW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStonCW.KeyPress
    '''    Try

    '''        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
    '''            e.Handled = True
    '''            Exit Sub
    '''        End If

    '''        If e.KeyChar = "." Then
    '''            If txtCStonCW.Text.IndexOf(".") > -1 Then
    '''                e.Handled = True
    '''                Exit Sub
    '''            End If
    '''        End If

    '''        If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
    '''            e.Handled = True
    '''        Else
    '''            If e.KeyChar = ChrW(13) Then
    '''                If txtCStonCW.Text.Length >= 0 Then
    '''                    If cboCStoneQty.SelectedIndex = -1 Then
    '''                        MsgBox("Please select type of quality.     ", MsgBoxStyle.OKOnly)
    '''                        txtCStonCW.Text = String.Empty
    '''                        Exit Sub
    '''                    End If
    '''                End If
    '''                cboCStonePS2.Focus()
    '''            End If
    '''        End If
    '''    Catch ex As Exception
    '''        MsgBox("frmRec/txtCStonCW_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '''    End Try
    '''End Sub

    Private Sub txtCStonCW2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStonCW2.TextChanged
        Try

            If txtCStonCW2.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStonCW2.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty2.Text
            lblCStonePC2.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            txtCStonCW2.Tag = txtCStonCW2.Text
            lblCStonePC2.Tag = lblCStonePC2.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStonCW2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStonCW3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStonCW3.TextChanged
        Try

            If txtCStonCW3.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStonCW3.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty3.Text
            lblCStonePC3.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            txtCStonCW3.Tag = txtCStonCW3.Text
            lblCStonePC3.Tag = lblCStonePC3.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStonCW3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStonCW2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStonCW2.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCStonCW2.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCStonCW2.Text.Length >= 0 Then
                        If cboCStoneQty2.SelectedIndex = -1 Then
                            MsgBox("Please select type of quality.     ", MsgBoxStyle.OKOnly)
                            txtCStonCW2.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    cboCStonePS3.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCStonCW2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStonCW3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStonCW3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCStonCW3.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCStonCW3.Text.Length >= 0 Then
                        If cboCStoneQty3.SelectedIndex = -1 Then
                            MsgBox("Please select type of quality.     ", MsgBoxStyle.OKOnly)
                            txtCStonCW3.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    cboCStoneNS.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCStonCW3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneQty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneQty.SelectedIndexChanged
        Try

            If cboCStoneQty.SelectedIndex >= 1 Then
                If cboCStonePS.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneQty.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty.Text
            lblCStonePC.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            AllTotal()
            txtCStonCW.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneQty_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneQty2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneQty2.SelectedIndexChanged
        Try

            If cboCStoneQty2.SelectedIndex >= 1 Then
                If cboCStonePS2.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneQty2.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty2.Text
            lblCStonePC2.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            AllTotal()
            txtCStonCW2.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneQty2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneQty3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneQty3.SelectedIndexChanged
        Try

            If cboCStoneQty3.SelectedIndex >= 1 Then
                If cboCStonePS3.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneQty3.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneQty3.Text
            lblCStonePC3.Text = Format(Computation("COLORED PRECIOUS"), "#,###,##0.00")
            AllTotal()
            txtCStonCW3.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneQty3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStoneNSCW.TextChanged
        Try

            If txtCStoneNSCW.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStoneNSCW.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty.Text
            lblCStoneNSPC.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            txtCStoneNSCW.Tag = txtCStoneNSCW.Text
            lblCStoneNSPC.Tag = lblCStoneNSPC.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStoneNSCW2.TextChanged
        Try

            If txtCStoneNSCW2.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStoneNSCW2.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty2.Text
            lblCStoneNSPC2.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            txtCStoneNSCW2.Tag = txtCStoneNSCW2.Text
            lblCStoneNSPC2.Tag = lblCStoneNSPC2.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCStoneNSCW3.TextChanged
        Try

            If txtCStoneNSCW3.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCStoneNSCW3.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty3.Text
            lblCStoneNSPC3.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            txtCStoneNSCW3.Tag = txtCStoneNSCW3.Text
            lblCStoneNSPC3.Tag = lblCStoneNSPC3.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneNSQty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneNSQty.SelectedIndexChanged
        Try

            If cboCStoneNSQty.SelectedIndex >= 1 Then
                If cboCStoneNS.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneNSQty.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty.Text
            lblCStoneNSPC.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            lblCStoneNSPC.Tag = lblCStoneNSPC.Text
            AllTotal()
            txtCStoneNSCW.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneNSQty_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneNSQty2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneNSQty2.SelectedIndexChanged
        Try

            If cboCStoneNSQty2.SelectedIndex >= 1 Then
                If cboCStoneNS2.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneNSQty2.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty2.Text
            lblCStoneNSPC2.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            lblCStoneNSPC2.Tag = lblCStoneNSPC2.Text
            AllTotal()
            txtCStoneNSCW2.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneNSQty2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboCStoneNSQty3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCStoneNSQty3.SelectedIndexChanged
        Try

            If cboCStoneNSQty3.SelectedIndex >= 1 Then
                If cboCStoneNS3.SelectedIndex = 0 Then
                    MsgBox("Please select type of stone.     ", MsgBoxStyle.OKOnly)
                    cboCStoneNSQty3.SelectedIndex = 0
                    Exit Sub
                End If
            End If

            tmpQuality = cboCStoneNSQty3.Text
            lblCStoneNSPC3.Text = Format(Computation("COLORED NATURAL"), "#,###,##0.00")
            lblCStoneNSPC3.Tag = lblCStoneNSPC3.Text
            AllTotal()
            txtCStoneNSCW3.Focus()
        Catch ex As Exception
            MsgBox("frmRec/cboCStoneNSQty3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtGoldKarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGoldKarat.TextChanged
        Try
            If Not IsNumeric(txtGoldKarat.Text) Or txtGoldKarat.Text = "" Then
                Exit Sub
            End If

            If txtGoldKarat.Text = "" Then
                Exit Sub
            Else
                If Replace(txtGoldKarat.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            lblGoldPrice.Text = Format(Computation("GOLDKARAT"), "#,###,##0.00")
            txtGoldKarat.Tag = txtGoldKarat.Text
            Call AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtGoldKarat_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaCut_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaCut.SelectedIndexChanged
        Try
            If cboDiaCut.SelectedIndex >= 1 And cboDiaCut.Text <> "" Then
                If txtDiaNoDia.Text.Length <= 0 Or txtDiaNoDia.Text = "0" Then
                    MsgBox("Please fill in No. of Dias.    ", MsgBoxStyle.OKOnly)
                    cboDiaCut.SelectedIndex = 0

                    Exit Sub
                End If

                If cboDiaCut.Text = "DIAMANTE" Then
                    lblDiaPC.Text = "1,000.00"
                    lblDiaPC.Tag = "1,000.00"
                    txtDiaCW.Text = 0
                    txtDiaCW.Tag = 0
                ElseIf cboDiaCut.Text = "OLD CUT" Then
                    lblDiaPC.Text = "15,000.00"
                    lblDiaPC.Tag = "15,000.00"
                    txtDiaCW.Text = 0
                    txtDiaCW.Tag = 0
                ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                    lblDiaPC.Text = "12,000.00"
                    lblDiaPC.Tag = "12,000.00"
                    txtDiaCW.Text = 0
                    txtDiaCW.Tag = 0
                End If

                lblDiaPC.Tag = lblDiaPC.Text
                Call AllTotal()
            Else
                clearTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/cboDiaCut_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaNoDia.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else

                If e.KeyChar = ChrW(13) Then
                    txtDiaCW.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaCut2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaCut2.SelectedIndexChanged
        Try
            If cboDiaCut2.SelectedIndex >= 0 And cboDiaCut2.Text <> "" Then
                If txtDiaNoDia2.Text.Length <= 0 Or txtDiaNoDia2.Text = "0" Then
                    MsgBox("Please fill in No. of Dias.    ", MsgBoxStyle.OKOnly)
                    cboDiaCut2.SelectedIndex = -1
                    Exit Sub
                End If

                If cboDiaCut2.Text = "DIAMANTE" Then
                    lblDiaPC2.Text = "1,000.00"
                    lblDiaPC2.Tag = "1,000.00"
                    txtDiaCW2.Text = 0
                    txtDiaCW2.Tag = 0
                ElseIf cboDiaCut2.Text = "OLD CUT" Then
                    lblDiaPC2.Text = "15,000.00"
                    lblDiaPC2.Tag = "15,000.00"
                    txtDiaCW2.Text = 0
                    txtDiaCW2.Tag = 0
                ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                    lblDiaPC2.Text = "12,000.00"
                    lblDiaPC2.Tag = "12,000.00"
                    txtDiaCW2.Text = 0
                    txtDiaCW2.Tag = 0
                End If

                lblDiaPC2.Tag = lblDiaPC2.Text
                Call AllTotal()

            Else
                clearTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/cboDiaCut2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaCut3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaCut3.SelectedIndexChanged
        Try
            If cboDiaCut3.SelectedIndex >= 0 And cboDiaCut3.Text <> "" Then
                If txtDiaNoDia3.Text.Length <= 0 Or txtDiaNoDia3.Text = "0" Then
                    MsgBox("Please fill in No. of Dias.    ", MsgBoxStyle.OKOnly)
                    cboDiaCut3.SelectedIndex = -1

                    Exit Sub
                End If

                If cboDiaCut3.Text = "DIAMANTE" Then
                    lblDiaPC3.Text = "1,000.00"
                    lblDiaPC3.Tag = "1,000.00"
                    txtDiaCW3.Text = 0
                    txtDiaCW3.Tag = 0
                ElseIf cboDiaCut3.Text = "OLD CUT" Then
                    lblDiaPC3.Text = "15,000.00"
                    lblDiaPC3.Tag = "15,000.00"
                    txtDiaCW3.Text = 0
                    txtDiaCW3.Tag = 0
                ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                    lblDiaPC3.Text = "12,000.00"
                    lblDiaPC3.Tag = "12,000.00"
                    txtDiaCW3.Text = 0
                    txtDiaCW3.Tag = 0
                End If

                lblDiaPC3.Tag = lblDiaPC3.Text
                Call AllTotal()
            Else
                clearTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/cboDiaCut3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaCut4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaCut4.SelectedIndexChanged
        Try
            If cboDiaCut4.SelectedIndex >= 0 And cboDiaCut4.Text <> "" Then
                If txtDiaNoDia4.Text.Length <= 0 Or txtDiaNoDia4.Text = "0" Then
                    MsgBox("Please fill in No. of Dias.    ", MsgBoxStyle.OKOnly)
                    cboDiaCut4.SelectedIndex = -1

                    Exit Sub
                End If

                If cboDiaCut4.Text = "DIAMANTE" Then
                    lblDiaPC4.Text = "1,000.00"
                    lblDiaPC4.Tag = "1,000.00"
                    txtDiaCW4.Text = 0
                    txtDiaCW4.Tag = 0
                ElseIf cboDiaCut4.Text = "OLD CUT" Then
                    lblDiaPC4.Text = "15,000.00"
                    lblDiaPC4.Tag = "15,000.00"
                    txtDiaCW4.Text = 0
                    txtDiaCW4.Tag = 0
                ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                    lblDiaPC4.Text = "12,000.00"
                    lblDiaPC4.Tag = "12,000.00"
                    txtDiaCW4.Text = 0
                    txtDiaCW4.Tag = 0
                End If

                lblDiaPC4.Tag = lblDiaPC4.Text
                Call AllTotal()
            Else
                clearTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/cboDiaCut4_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboDiaCut5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDiaCut5.SelectedIndexChanged
        Try
            If cboDiaCut5.SelectedIndex >= 0 And cboDiaCut5.Text <> "" Then
                If txtDiaNoDia.Text.Length <= 0 Or txtDiaNoDia5.Text = "0" Then
                    MsgBox("Please fill in No. of Dias.    ", MsgBoxStyle.OKOnly)
                    cboDiaCut5.SelectedIndex = -1

                    Exit Sub
                End If

                If cboDiaCut5.Text = "DIAMANTE" Then
                    lblDiaPC5.Text = "1,000.00"
                    lblDiaPC5.Tag = "1,000.00"
                    txtDiaCW5.Text = 0
                    txtDiaCW5.Tag = 0
                ElseIf cboDiaCut5.Text = "OLD CUT" Then
                    lblDiaPC5.Text = "15,000.00"
                    lblDiaPC5.Tag = "15,000.00"
                    txtDiaCW5.Text = 0
                    txtDiaCW5.Tag = 0
                ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                    lblDiaPC5.Text = "12,000.00"
                    lblDiaPC5.Tag = "12,000.00"
                    txtDiaCW5.Text = 0
                    txtDiaCW5.Tag = 0
                End If

                lblDiaPC5.Tag = lblDiaPC5.Text
                Call AllTotal()
            Else
                clearTotal()
            End If
        Catch ex As Exception
            MsgBox("frmRec/cboDiaCut5_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlSize2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlSize2.SelectedIndexChanged
        Try

            If cboPearlSize2.SelectedIndex >= 0 Then
                If cboPearlName2.SelectedIndex = -1 Then
                    MsgBox("Please select type of pearl.     ", MsgBoxStyle.OKOnly)
                    cboPearlSize2.SelectedIndex = -1
                    Exit Sub
                End If

            End If

            tmpQuality = cboPearlQty2.Text
            tmpPearlType = cboPearlName2.Text + " (" + cboPearlSize2.Text + ")"
            lblPearPrice2.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice2.Tag = lblPearPrice2.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlSize2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlSize3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlSize3.SelectedIndexChanged
        Try

            If cboPearlSize3.SelectedIndex >= 0 Then
                If cboPearlName3.SelectedIndex = -1 Then
                    MsgBox("Please select type of pearl.     ", MsgBoxStyle.OKOnly)
                    cboPearlSize3.SelectedIndex = -1
                    Exit Sub
                End If

            End If

            tmpQuality = cboPearlQty3.Text
            tmpPearlType = cboPearlName3.Text + " (" + cboPearlSize3.Text + ")"
            lblPearPrice3.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice3.Tag = lblPearPrice3.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlSize3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaNoDia2.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtDiaCW2.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaNoDia3.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtDiaCW3.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaNoDia4.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtDiaCW4.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaNoDia5.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtDiaCW5.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia5_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStoneNSCW.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCStoneNSCW.Text.IndexOf(".") > -1 Then
                    txtCStoneNSCW.Text = ""
                    e.Handled = False
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCStoneNSCW.Text.Length >= 0 Then
                        If cboCStoneNSQty.SelectedIndex = -1 Then
                            MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                            txtCStoneNSCW.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    cboCStoneNS2.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStoneNSCW2.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCStoneNSCW2.Text.IndexOf(".") > -1 Then
                    txtCStoneNSCW2.Text = ""
                    e.Handled = False
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCStoneNSCW2.Text.Length >= 0 Then
                        If cboCStoneNSQty2.SelectedIndex = -1 Then
                            MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                            txtCStoneNSCW2.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    cboCStoneNS3.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCStoneNSCW3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCStoneNSCW3.KeyPress
        Try

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCStoneNSCW3.Text.IndexOf(".") > -1 Then
                    txtCStoneNSCW3.Text = ""
                    e.Handled = False
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCStoneNSCW3.Text.Length >= 0 Then
                        If cboCStoneNSQty3.SelectedIndex = -1 Then
                            MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                            txtCStoneNSCW3.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    btnOK.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCStoneNSCW3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try

            'If MsgBox("You are about to save mounted price. " & vbCrLf & "A.L.L. price will be changed to current mounted price. " & vbCrLf & "Do you want to proceed?  ", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            '    Exit Sub
            'End If

            If lblTSellingPrice.Text = "0.00" Then
                SearchFlag = True
                FlagPricingNotSave = True
                Me.Dispose()
                Exit Sub
            End If

            SPrice = lblTSellingPrice.Text
            Smounted = lblTGoldPrice.Text
            'Smounted = lblTSellingPrice.Text
            If txtGoldKarat.Text = "" Then
                GKarat = txtGoldKarat.Tag
            Else
                GKarat = txtGoldKarat.Text
            End If

            SearchFlag = True
            FlagPricingNotSave = True
            PopulateArray()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("frmRec/btnOK_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RetrieveData()
        Try
            Dim tmpLotNo As String
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim ctr As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "select Lotno from ASYS_PRICING_detail where refallBarcode = '" & Me.Tag & "' and status not in ('RELEASED','RECDISTRI')"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            While dr.Read
                tmpLotNo = Trim(dr.Item("Lotno"))
            End While

            dr.Close()
            obj.Close3()

            '--- Gold Karat [start] ---
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            'str = "SELECT * FROM ASYS_Gold WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"
            str = "SELECT * FROM ASYS_Gold WHERE AllBarcode = '" & Me.Tag & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3 'lblGoldPrice

            If dr.Read Then
                cboGoldKarat.Text = dr.Item("Karat")
                txtGoldKarat.Text = dr.Item("Grams") ' GKarat '
                lblGoldKaratPrice.Text = Format(dr.Item("KaratPrice"), "#,###,##0.00")
                'lblGoldPrice.Text = Format(dr.Item("GoldPrice"), "#,###,##0.00")
                lblGoldPrice.Text = Format(txtGoldKarat.Text * lblGoldKaratPrice.Text, "#,###,##0.00")
            Else
                txtGoldKarat.Text = GKarat
                txtGoldKarat.Tag = GKarat
            End If

            dr.Close()
            obj.Close3()
            '---- Gold Karat [end] ----

            '--- Dia [start] ---
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            'str = "SELECT * FROM ASYS_Diamond WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"
            str = "SELECT * FROM ASYS_Diamond WHERE AllBarcode = '" & Me.Tag & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3
            ctr = 1

            While dr.Read

                If ctr = 1 Then
                    txtDiaNoDia.Text = dr.Item("NoOfDias")
                    txtDiaCW.Text = Format(dr.Item("Diamond_CWT"), "#,###,##0.00")
                    cboDiaCut.Text = dr.Item("Diamond_Cut")
                    cboDiaColor.Text = Trim(dr.Item("Diamond_Color"))
                    cboDiaClarity.Text = Trim(dr.Item("Diamond_Clarity"))

                    lblDiaPC.Text = Format(dr.Item("Diamond_Price"), "#,###,##0.00")
                ElseIf ctr = 2 Then
                    txtDiaNoDia2.Text = dr.Item("NoOfDias")
                    cboDiaCut2.Text = dr.Item("Diamond_Cut")
                    cboDiaColor2.Text = Trim(dr.Item("Diamond_Color"))
                    cboDiaClarity2.Text = Trim(dr.Item("Diamond_Clarity"))
                    txtDiaCW2.Text = Format(dr.Item("Diamond_CWT"), "#,###,##0.00")
                    lblDiaPC2.Text = Format(dr.Item("Diamond_Price"), "#,###,##0.00")
                ElseIf ctr = 3 Then
                    txtDiaNoDia3.Text = dr.Item("NoOfDias")
                    cboDiaCut3.Text = dr.Item("Diamond_Cut")
                    cboDiaColor3.Text = Trim(dr.Item("Diamond_Color"))
                    cboDiaClarity3.Text = Trim(dr.Item("Diamond_Clarity"))
                    txtDiaCW3.Text = Format(dr.Item("Diamond_CWT"), "#,###,##0.00")
                    lblDiaPC3.Text = Format(dr.Item("Diamond_Price"), "#,###,##0.00")
                ElseIf ctr = 4 Then
                    txtDiaNoDia4.Text = dr.Item("NoOfDias")
                    cboDiaCut4.Text = dr.Item("Diamond_Cut")
                    cboDiaColor4.Text = Trim(dr.Item("Diamond_Color"))
                    cboDiaClarity4.Text = Trim(dr.Item("Diamond_Clarity"))
                    txtDiaCW4.Text = Format(dr.Item("Diamond_CWT"), "#,###,##0.00")
                    lblDiaPC4.Text = Format(dr.Item("Diamond_Price"), "#,###,##0.00")
                ElseIf ctr = 5 Then
                    txtDiaNoDia5.Text = dr.Item("NoOfDias")
                    cboDiaCut5.Text = dr.Item("Diamond_Cut")
                    cboDiaColor5.Text = Trim(dr.Item("Diamond_Color"))
                    cboDiaClarity5.Text = Trim(dr.Item("Diamond_Clarity"))
                    txtDiaCW5.Text = Format(dr.Item("Diamond_CWT"), "#,###,##0.00")
                    lblDiaPC5.Text = Format(dr.Item("Diamond_Price"), "#,###,##0.00")
                End If
                ctr = ctr + 1
            End While

            dr.Close()
            obj.Close3()
            '---- Dia [end] ----

            '--- Pearl [start] ---
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            'str = "SELECT * FROM ASYS_Pearl WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"
            str = "SELECT * FROM ASYS_Pearl WHERE AllBarcode = '" & Me.Tag & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3
            ctr = 1

            While dr.Read

                If ctr = 1 Then
                    txtNoPearl.Text = dr.Item("Pearl_No_of_Pear")
                    cboPearlName.Text = dr.Item("Pearl_Type")
                    cboPearlSize.Text = dr.Item("Pearl_Size")
                    cboPearlQty.Text = dr.Item("Pearl_Quality")
                    lblPearPrice.Text = Format(dr.Item("Pearl_Price"), "#,###,##0.00")
                ElseIf ctr = 2 Then
                    txtNoPearl2.Text = dr.Item("Pearl_No_of_Pear")
                    cboPearlName2.Text = dr.Item("Pearl_Type")
                    cboPearlSize2.Text = dr.Item("Pearl_Size")
                    cboPearlQty2.Text = dr.Item("Pearl_Quality")
                    lblPearPrice2.Text = Format(dr.Item("Pearl_Price"), "#,###,##0.00")
                ElseIf ctr = 3 Then
                    txtNoPearl3.Text = dr.Item("Pearl_No_of_Pear")
                    cboPearlName3.Text = dr.Item("Pearl_Type")
                    cboPearlSize3.Text = dr.Item("Pearl_Size")
                    cboPearlQty3.Text = dr.Item("Pearl_Quality")
                    lblPearPrice3.Text = Format(dr.Item("Pearl_Price"), "#,###,##0.00")
                End If
                ctr = ctr + 1
            End While

            dr.Close()
            obj.Close3()
            '---- Pearl [end] ----

            '--- Precious [start] ---
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            'str = "SELECT * FROM ASYS_PreciousStone WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"
            str = "SELECT * FROM ASYS_PreciousStone WHERE AllBarcode = '" & Me.Tag & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3
            ctr = 1

            While dr.Read

                If ctr = 1 Then
                    cboCStonePS.Text = dr.Item("PStone_Type")
                    cboCStoneQty.Text = dr.Item("PStone_Quality")
                    txtCStonCW.Text = Format(dr.Item("PStone_CWT"), "#,###,##0.00")
                    lblCStonePC.Text = Format(dr.Item("PStone_Price"), "#,###,##0.00")
                ElseIf ctr = 2 Then
                    cboCStonePS2.Text = dr.Item("PStone_Type")
                    cboCStoneQty2.Text = dr.Item("PStone_Quality")
                    txtCStonCW2.Text = Format(dr.Item("PStone_CWT"), "#,###,##0.00")
                    lblCStonePC2.Text = Format(dr.Item("PStone_Price"), "#,###,##0.00")
                ElseIf ctr = 3 Then
                    cboCStonePS3.Text = dr.Item("PStone_Type")
                    cboCStoneQty3.Text = dr.Item("PStone_Quality")
                    txtCStonCW3.Text = Format(dr.Item("PStone_CWT"), "#,###,##0.00")
                    lblCStonePC3.Text = Format(dr.Item("PStone_Price"), "#,###,##0.00")
                End If
                ctr = ctr + 1
            End While

            dr.Close()
            obj.Close3()
            '---- Precious [end] ----

            '--- Synthetic [start] ---
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            'str = "SELECT * FROM ASYS_SyntheticStone WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"
            str = "SELECT * FROM ASYS_SyntheticStone WHERE AllBarcode = '" & Me.Tag & "'"

            obj.Command3(str)
            dr = obj.OpenDataReader3
            ctr = 1

            While dr.Read

                If ctr = 1 Then
                    cboCStoneNS.Text = dr.Item("SStone_Type")
                    cboCStoneNSQty.Text = dr.Item("SStone_Quality")
                    txtCStoneNSCW.Text = Format(dr.Item("SStone_CWT"), "#,###,##0.00")
                    lblCStoneNSPC.Text = Format(dr.Item("SStone_Price"), "#,###,##0.00")
                ElseIf ctr = 2 Then
                    cboCStoneNS2.Text = dr.Item("SStone_Type")
                    cboCStoneNSQty2.Text = dr.Item("SStone_Quality")
                    txtCStoneNSCW2.Text = Format(dr.Item("SStone_CWT"), "#,###,##0.00")
                    lblCStoneNSPC2.Text = Format(dr.Item("SStone_Price"), "#,###,##0.00")
                ElseIf ctr = 3 Then
                    cboCStoneNS3.Text = dr.Item("SStone_Type")
                    cboCStoneNSQty3.Text = dr.Item("SStone_Quality")
                    txtCStoneNSCW3.Text = Format(dr.Item("SStone_CWT"), "#,###,##0.00")
                    lblCStoneNSPC3.Text = Format(dr.Item("SStone_Price"), "#,###,##0.00")
                End If
                ctr = ctr + 1
            End While

            dr.Close()
            obj.Close3()
            '---- Synthetic [end] ----

            '--- Mounted Price [start] ---
            Call AllTotal()
            '''obj = New clsCommon
            '''obj.Connectionstring3()
            '''obj.Open3()

            '''str = "SELECT * FROM ASYS_MountedPrice WHERE Lotno = '" & tmpLotNo & "' AND AllBarcode = '" & Me.Tag & "'"

            '''obj.Command3(str)
            '''dr = obj.OpenDataReader3
            '''ctr = 1

            '''While dr.Read
            '''    lblTGoldPrice.Text = Format(dr.Item("Total_GoldPrice"), "#,###,##0.00")
            '''    lblTDiaPrice.Text = Format(dr.Item("Total_DiaPrice"), "#,###,##0.00")
            '''    lblTPearlPrice.Text = Format(dr.Item("Total_PearlPrice"), "#,###,##0.00")
            '''    lblTCStonePrice.Text = Format(dr.Item("Total_CStonePrice"), "#,###,##0.00")
            '''    lblTSellingPrice.Text = Format(dr.Item("Total_SellingPrice"), "#,###,##0.00")
            '''    lblTSellingPrice.Tag = dr.Item("Total_SellingPrice")
            '''End While

            '''dr.Close()
            '''obj.Close3()
            '---- Mounted Price [end] ----
        Catch ex As Exception
            MsgBox("frmRec/RetrieveData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub PopulateArray()
        Try
            ctrArrDia = 0
            ctrArrPearl = 0
            ctrArrPrecious = 0
            ctrArrSynthetic = 0

            ArrGold.Clear()
            ArrDia.Clear()
            ArrPearl.Clear()
            ArrPrecious.Clear()
            ArrSynthetic.Clear()
            ArrMountedTotal.Clear()

            '--- Gold [start]---
            If CDbl(lblGoldPrice.Tag) > 0 Then
                ArrGold.Add(cboGoldKarat.Text)
                ArrGold.Add(txtGoldKarat.Tag)
                ArrGold.Add(lblGoldKaratPrice.Tag)
                ArrGold.Add(lblGoldPrice.Tag)
            End If
            '---- Gold [end]----

            '--- Dia [start]---
            If CDbl(lblDiaPC.Text) > 0 Then
                ArrDia.Add(txtDiaNoDia.Tag) : ArrDia.Add(txtDiaCW.Tag) : ArrDia.Add(cboDiaCut.Text) : ArrDia.Add(cboDiaColor.Text) : ArrDia.Add(cboDiaClarity.Text) : ArrDia.Add(txtCW.Tag) : ArrDia.Add(lblDiaPC.Text)
                ctrArrDia = ctrArrDia + 1
            End If
            If CDbl(lblDiaPC2.Text) > 0 Then
                ArrDia.Add(txtDiaNoDia2.Tag) : ArrDia.Add(txtDiaCW2.Tag) : ArrDia.Add(cboDiaCut2.Text) : ArrDia.Add(cboDiaColor2.Text) : ArrDia.Add(cboDiaClarity2.Text) : ArrDia.Add(txtCW2.Tag) : ArrDia.Add(lblDiaPC2.Text)
                ctrArrDia = ctrArrDia + 1
            End If
            If CDbl(lblDiaPC3.Text) > 0 Then
                ArrDia.Add(txtDiaNoDia3.Tag) : ArrDia.Add(txtDiaCW3.Tag) : ArrDia.Add(cboDiaCut3.Text) : ArrDia.Add(cboDiaColor3.Text) : ArrDia.Add(cboDiaClarity3.Text) : ArrDia.Add(txtCW3.Tag) : ArrDia.Add(lblDiaPC3.Text)
                ctrArrDia = ctrArrDia + 1
            End If
            If CDbl(lblDiaPC4.Text) > 0 Then
                ArrDia.Add(txtDiaNoDia4.Tag) : ArrDia.Add(txtDiaCW4.Tag) : ArrDia.Add(cboDiaCut4.Text) : ArrDia.Add(cboDiaColor4.Text) : ArrDia.Add(cboDiaClarity4.Text) : ArrDia.Add(txtCW4.Tag) : ArrDia.Add(lblDiaPC4.Text)
                ctrArrDia = ctrArrDia + 1
            End If
            If CDbl(lblDiaPC5.Text) > 0 Then
                ArrDia.Add(txtDiaNoDia5.Tag) : ArrDia.Add(txtDiaCW5.Tag) : ArrDia.Add(cboDiaCut5.Text) : ArrDia.Add(cboDiaColor5.Text) : ArrDia.Add(cboDiaClarity5.Text) : ArrDia.Add(txtCW5.Tag) : ArrDia.Add(lblDiaPC5.Text)
                ctrArrDia = ctrArrDia + 1
            End If
            '--- Dia [end]---

            '--- Pearl [start]---
            If CDbl(lblPearPrice.Text) > 0 Then
                ArrPearl.Add(txtNoPearl.Text) : ArrPearl.Add(cboPearlName.Text) : ArrPearl.Add(cboPearlSize.Text) : ArrPearl.Add(cboPearlQty.Text) : ArrPearl.Add(lblPearPrice.Tag)
                ctrArrPearl = ctrArrPearl + 1
            End If
            If CDbl(lblPearPrice2.Text) > 0 Then
                ArrPearl.Add(txtNoPearl2.Text) : ArrPearl.Add(cboPearlName2.Text) : ArrPearl.Add(cboPearlSize2.Text) : ArrPearl.Add(cboPearlQty2.Text) : ArrPearl.Add(lblPearPrice2.Tag)
                ctrArrPearl = ctrArrPearl + 1
            End If
            If CDbl(lblPearPrice3.Text) > 0 Then
                ArrPearl.Add(txtNoPearl3.Text) : ArrPearl.Add(cboPearlName3.Text) : ArrPearl.Add(cboPearlSize3.Text) : ArrPearl.Add(cboPearlQty3.Text) : ArrPearl.Add(lblPearPrice3.Tag)
                ctrArrPearl = ctrArrPearl + 1
            End If
            '--- Pearl [end]---

            '--- Precious [start]---
            If CDbl(lblCStonePC.Text) > 0 Then
                ArrPrecious.Add(cboCStonePS.Text) : ArrPrecious.Add(cboCStoneQty.Text) : ArrPrecious.Add(txtCStonCW.Tag) : ArrPrecious.Add(lblCStonePC.Tag)
                ctrArrPrecious = ctrArrPrecious + 1
            End If
            If CDbl(lblCStonePC2.Text) > 0 Then
                ArrPrecious.Add(cboCStonePS2.Text) : ArrPrecious.Add(cboCStoneQty2.Text) : ArrPrecious.Add(txtCStonCW2.Tag) : ArrPrecious.Add(lblCStonePC2.Tag)
                ctrArrPrecious = ctrArrPrecious + 1
            End If
            If CDbl(lblCStonePC3.Text) > 0 Then
                ArrPrecious.Add(cboCStonePS3.Text) : ArrPrecious.Add(cboCStoneQty3.Text) : ArrPrecious.Add(txtCStonCW3.Tag) : ArrPrecious.Add(lblCStonePC3.Tag)
                ctrArrPrecious = ctrArrPrecious + 1
            End If
            '--- Precious [end]---

            '--- Synthetic [start]---
            If CDbl(lblCStoneNSPC.Text) > 0 Then
                ArrSynthetic.Add(cboCStoneNS.Text) : ArrSynthetic.Add(cboCStoneNSQty.Text) : ArrSynthetic.Add(txtCStoneNSCW.Tag) : ArrSynthetic.Add(lblCStoneNSPC.Tag)
                ctrArrSynthetic = ctrArrSynthetic + 1
            End If
            If CDbl(lblCStoneNSPC2.Text) > 0 Then
                ArrSynthetic.Add(cboCStoneNS2.Text) : ArrSynthetic.Add(cboCStoneNSQty2.Text) : ArrSynthetic.Add(txtCStoneNSCW2.Tag) : ArrSynthetic.Add(lblCStoneNSPC2.Tag)
                ctrArrSynthetic = ctrArrSynthetic + 1
            End If
            If CDbl(lblCStoneNSPC3.Text) > 0 Then
                ArrSynthetic.Add(cboCStoneNS3.Text) : ArrSynthetic.Add(cboCStoneNSQty3.Text) : ArrSynthetic.Add(txtCStoneNSCW3.Tag) : ArrSynthetic.Add(lblCStoneNSPC3.Tag)
                ctrArrSynthetic = ctrArrSynthetic + 1
            End If
            '--- Synthetic [end]---

            '--- Mounted Total [start]---
            If CDbl(lblTSellingPrice.Text) > 0 Then
                ArrMountedTotal.Add(lblTGoldPrice.Tag)
                ArrMountedTotal.Add(lblTDiaPrice.Tag)
                ArrMountedTotal.Add(lblTPearlPrice.Tag)
                ArrMountedTotal.Add(lblTCStonePrice.Tag)
                ArrMountedTotal.Add(lblTSellingPrice.Tag)
            End If
            '--- Mounted Total [end]---

        Catch ex As Exception
            MsgBox("frmRec/PopulateArray: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlName2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlName2.SelectedIndexChanged
        Try
            cboPearlSize2.Enabled = True
            tmpQuality = cboPearlQty2.Text
            If cboPearlName2.Text = "ROUND" Then
                cboPearlSize2.SelectedIndex = 1
            ElseIf cboPearlName2.Text = "SOUTH SEA PEARL" Then
                cboPearlSize2.SelectedIndex = 2
            Else
                cboPearlSize2.SelectedIndex = 0
                cboPearlSize2.Enabled = False
            End If

            tmpPearlType = cboPearlName2.Text + " (" + cboPearlSize2.Text + ")"
            lblPearPrice2.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice2.Tag = lblPearPrice2.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlName2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboPearlName3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPearlName3.SelectedIndexChanged
        Try
            cboPearlSize3.Enabled = True
            tmpQuality = cboPearlQty3.Text
            If cboPearlName3.Text = "ROUND" Then
                cboPearlSize3.SelectedIndex = 1
            ElseIf cboPearlName3.Text = "SOUTH SEA PEARL" Then
                cboPearlSize3.SelectedIndex = 2
            Else
                cboPearlSize3.SelectedIndex = 0
                cboPearlSize3.Enabled = False
            End If

            tmpPearlType = cboPearlName3.Text + " (" + cboPearlSize3.Text + ")"
            lblPearPrice3.Text = Format(Computation("PEARL"), "#,###,##0.00")
            lblPearPrice3.Tag = lblPearPrice3.Text
            AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/cboPearlName3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub getDiaPrice()
        If (cboDiaCut.Text = "DIAMANTE" Or cboDiaCut.Text = "OLD CUT" Or cboDiaCut.Text = "SINGLE CUT") Or (cboDiaCut2.Text = "DIAMANTE" Or cboDiaCut2.Text = "OLD CUT" Or cboDiaCut2.Text = "SINGLE CUT") Or (cboDiaCut3.Text = "DIAMANTE" Or cboDiaCut3.Text = "OLD CUT" Or cboDiaCut3.Text = "SINGLE CUT") Or (cboDiaCut4.Text = "DIAMANTE" Or cboDiaCut4.Text = "OLD CUT" Or cboDiaCut4.Text = "SINGLE CUT") Or (cboDiaCut5.Text = "DIAMANTE" Or cboDiaCut5.Text = "OLD CUT" Or cboDiaCut5.Text = "SINGLE CUT") Then
            If cboDiaCut.Text = "DIAMANTE" Then
                lblDiaPC.Text = "1,000.00"
                lblDiaPC.Tag = "1,000.00"
                txtDiaCW.Tag = 0
            ElseIf cboDiaCut.Text = "OLD CUT" Then
                lblDiaPC.Text = "15,000.00"
                lblDiaPC.Tag = "15,000.00"
                txtDiaCW.Tag = 0
            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                lblDiaPC.Text = "12,000.00"
                lblDiaPC.Tag = "12,000.00"
                txtDiaCW.Tag = 0
            End If
            lblDiaPC.Tag = lblDiaPC.Text
            If cboDiaCut2.Text = "DIAMANTE" Then
                lblDiaPC2.Text = "1,000.00"
                lblDiaPC2.Tag = "1,000.00"
                txtDiaCW2.Tag = 0
            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                lblDiaPC2.Text = "15,000.00"
                lblDiaPC2.Tag = "15,000.00"
                txtDiaCW2.Tag = 0
            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                lblDiaPC2.Text = "12,000.00"
                lblDiaPC2.Tag = "12,000.00"
                txtDiaCW2.Tag = 0
            End If

            lblDiaPC2.Tag = lblDiaPC2.Text


            If cboDiaCut3.Text = "DIAMANTE" Then
                lblDiaPC3.Text = "1,000.00"
                lblDiaPC3.Tag = "1,000.00"
                txtDiaCW3.Tag = 0
            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                lblDiaPC3.Text = "15,000.00"
                lblDiaPC3.Tag = "15,000.00"
                txtDiaCW3.Tag = 0
            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                lblDiaPC3.Text = "12,000.00"
                lblDiaPC3.Tag = "12,000.00"
                txtDiaCW3.Tag = 0
            End If

            lblDiaPC3.Tag = lblDiaPC3.Text

            If cboDiaCut4.Text = "DIAMANTE" Then
                lblDiaPC4.Text = "1,000.00"
                lblDiaPC4.Tag = "1,000.00"
                txtDiaCW4.Tag = 0
            ElseIf cboDiaCut4.Text = "OLD CUT" Then
                lblDiaPC4.Text = "15,000.00"
                lblDiaPC4.Tag = "15,000.00"
                txtDiaCW4.Tag = 0
            ElseIf cboDiaCut4.Text = "SINGLE CUT" Then
                lblDiaPC4.Text = "12,000.00"
                lblDiaPC4.Tag = "12,000.00"
                txtDiaCW4.Tag = 0
            End If

            lblDiaPC4.Tag = lblDiaPC4.Text

            If cboDiaCut5.Text = "DIAMANTE" Then
                lblDiaPC5.Text = "1,000.00"
                lblDiaPC5.Tag = "1,000.00"
                txtDiaCW5.Tag = 0
            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                lblDiaPC5.Text = "15,000.00"
                lblDiaPC5.Tag = "15,000.00"
                txtDiaCW5.Tag = 0
            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                lblDiaPC5.Text = "12,000.00"
                lblDiaPC5.Tag = "12,000.00"
                txtDiaCW5.Tag = 0
            End If

            lblDiaPC5.Tag = lblDiaPC5.Text
        End If

    End Sub
    Private Sub txtDiaNoDia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaNoDia.TextChanged
        Try
            If txtDiaNoDia.Text = "" Then
                txtDiaNoDia.Tag = "0"
                clearTotal()
                Exit Sub
            Else
                If txtDiaNoDia.Text = 0 Then
                    clearTotal()
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW.Text.Length <= 0, 0, txtDiaCW.Text)
            tmpDiaColor = cboDiaColor.Text
            tmpDiaClarity = cboDiaClarity.Text
            txtDiaCW.Tag = IIf(txtDiaCW.Text.Length <= 0, 0, txtDiaCW.Text)

            txtDiaNoDia.Tag = txtDiaNoDia.Text
            tmpDiaNoDia = txtDiaNoDia.Tag

            lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            getDiaPrice()
            lblDiaPC.Tag = lblDiaPC.Text
            Call AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub txtDiaNoDia2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaNoDia2.TextChanged
        Try

            txtDiaNoDia2.Tag = txtDiaNoDia2.Text


            If txtDiaNoDia2.Text = "" Then
                txtDiaNoDia2.Tag = "0"
                clearTotal()
                Exit Sub
            Else
                If txtDiaNoDia.Text = 0 Then
                    clearTotal()
                    Exit Sub
                End If
            End If

            tmpDiaNoDia = txtDiaNoDia2.Tag
            tmpDiaCW = IIf(txtDiaCW2.Text.Length <= 0, 0, txtDiaCW2.Text)
            tmpDiaColor = cboDiaColor2.Text
            tmpDiaClarity = cboDiaClarity2.Text
            txtDiaCW2.Tag = IIf(txtDiaCW2.Text.Length <= 0, 0, txtDiaCW2.Text)

            txtDiaNoDia2.Tag = txtDiaNoDia2.Text
            tmpDiaNoDia = txtDiaNoDia2.Tag

            lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            getDiaPrice()
            lblDiaPC2.Tag = lblDiaPC2.Text
            Call AllTotal()

        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaNoDia3.TextChanged
        Try
            If txtDiaNoDia3.Text = "" Then
                txtDiaNoDia3.Tag = "0"
                clearTotal()
                Exit Sub
            Else
                If txtDiaNoDia.Text = 0 Then
                    clearTotal()
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW3.Text.Length <= 0, 0, txtDiaCW3.Text)
            tmpDiaColor = cboDiaColor3.Text
            tmpDiaClarity = cboDiaClarity3.Text
            txtDiaCW3.Tag = IIf(txtDiaCW3.Text.Length <= 0, 0, txtDiaCW3.Text)

            txtDiaNoDia3.Tag = txtDiaNoDia3.Text
            tmpDiaNoDia = txtDiaNoDia3.Tag

            lblDiaPC3.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            getDiaPrice()
            lblDiaPC3.Tag = lblDiaPC3.Text
            Call AllTotal()
            clearTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaNoDia4.TextChanged
        Try
            If txtDiaNoDia4.Text = "" Then
                txtDiaNoDia4.Tag = "0"
                clearTotal()
                Exit Sub
            Else
                If txtDiaNoDia.Text = 0 Then
                    clearTotal()
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW4.Text.Length <= 0, 0, txtDiaCW4.Text)
            tmpDiaColor = cboDiaColor4.Text
            tmpDiaClarity = cboDiaClarity4.Text
            txtDiaCW4.Tag = IIf(txtDiaCW4.Text.Length <= 0, 0, txtDiaCW4.Text)

            txtDiaNoDia4.Tag = txtDiaNoDia4.Text
            tmpDiaNoDia = txtDiaNoDia4.Tag
            getDiaPrice()
            lblDiaPC4.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            getDiaPrice()
            lblDiaPC4.Tag = lblDiaPC4.Text
            Call AllTotal()
            clearTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia4_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDiaNoDia5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiaNoDia5.TextChanged
        Try
            If txtDiaNoDia5.Text = "" Then
                txtDiaNoDia5.Tag = "0"
                clearTotal()
                Exit Sub
            Else
                If txtDiaNoDia.Text = 0 Then
                    clearTotal()
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtDiaCW5.Text.Length <= 0, 0, txtDiaCW5.Text)
            tmpDiaColor = cboDiaColor5.Text
            tmpDiaClarity = cboDiaClarity5.Text
            txtDiaCW5.Tag = IIf(txtDiaCW5.Text.Length <= 0, 0, txtDiaCW5.Text)

            txtDiaNoDia5.Tag = txtDiaNoDia5.Text
            tmpDiaNoDia = txtDiaNoDia5.Tag


            lblDiaPC5.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
            getDiaPrice()
            lblDiaPC5.Tag = lblDiaPC5.Text
            Call AllTotal()
            clearTotal()

        Catch ex As Exception
            MsgBox("frmRec/txtDiaNoDia5_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoPearl.TextChanged
        Try
            txtNoPearl.Tag = txtNoPearl.Text
            If txtNoPearl.Text.Length = 0 Then
                txtNoPearl.Tag = 0
            End If
            tmpQuality = cboPearlQty.Text

            lblPearPrice.Text = Format(Computation("PEARL") * txtNoPearl.Tag, "#,###,##0.00")
            lblPearPrice.Tag = lblPearPrice.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoPearl2.TextChanged
        Try
            txtNoPearl2.Tag = txtNoPearl2.Text
            If txtNoPearl2.Text.Length = 0 Then
                txtNoPearl2.Tag = 0
            End If
            tmpQuality = cboPearlQty2.Text

            lblPearPrice2.Text = Format(Computation("PEARL") * txtNoPearl2.Tag, "#,###,##0.00")
            lblPearPrice2.Tag = lblPearPrice2.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoPearl3.TextChanged
        Try
            txtNoPearl3.Tag = txtNoPearl3.Text
            If txtNoPearl3.Text.Length = 0 Then
                txtNoPearl3.Tag = 0
            End If
            tmpQuality = cboPearlQty3.Text

            lblPearPrice3.Text = Format(Computation("PEARL") * txtNoPearl3.Tag, "#,###,##0.00")
            lblPearPrice3.Tag = lblPearPrice3.Text
            AllTotal()
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPearl.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtNoPearl.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPearl2.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtNoPearl2.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtNoPearl3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPearl3.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    txtNoPearl3.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtNoPearl3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub lblPearPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lblPearPrice.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    lblPearPrice.Tag = lblPearPrice.Text
                    lblPearPrice.Text = Format(CDbl(lblPearPrice.Text), "#,###,##0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/lblPearPrice_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub lblPearPrice2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lblPearPrice2.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    lblPearPrice2.Tag = lblPearPrice2.Text
                    lblPearPrice2.Text = Format(CDbl(lblPearPrice2.Text), "#,###,##0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/lblPearPrice2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub lblPearPrice3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lblPearPrice3.KeyPress
        Try
            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    lblPearPrice3.Tag = lblPearPrice3.Text
                    lblPearPrice3.Text = Format(CDbl(lblPearPrice3.Text), "#,###,##0.00")
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/lblPearPrice3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'gm codes from txtCW to txtCW5----
    Private Sub txtCW_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCW.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = "." Then
                If txtCW.Text.IndexOf(".") > -1 Then
                    e.Handled = True
                    Exit Sub
                End If
            End If

            If Not (e.KeyChar = ChrW(13)) And Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ChrW(Keys.Back)) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            Else
                If e.KeyChar = ChrW(13) Then
                    If txtCW.Text.Length >= 0 Then
                        If cboDiaClarity.SelectedIndex = -1 Then
                            MsgBox("Please select type of clarity.     ", MsgBoxStyle.OKOnly)
                            txtCW.Text = String.Empty
                            Exit Sub
                        End If
                    End If
                    txtDiaNoDia2.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmRec/txtCW_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub txtCW_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCW.TextChanged
        Try
            If txtCW.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCW.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtCW.Text.Length <= 0, 0, txtCW.Text)
            tmpDiaColor = cboDiaColor.Text
            tmpDiaClarity = cboDiaClarity.Text
            txtCW.Tag = txtCW.Text

            If cboDiaCut.Text = "DIAMANTE" Then
                txtCW.Text = ""

            ElseIf cboDiaCut.Text = "OLD CUT" Then
                txtCW.Text = ""

            ElseIf cboDiaCut.Text = "SINGLE CUT" Then
                txtCW.Text = ""

            Else
                lblDiaPC.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC.Tag = lblDiaPC.Text

            End If

        Catch ex As Exception
            MsgBox("frmRec/txtCW_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCW2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCW2.TextChanged
        Try
            If txtCW2.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCW2.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtCW2.Text.Length <= 0, 0, txtCW2.Text)
            tmpDiaColor = cboDiaColor2.Text
            tmpDiaClarity = cboDiaClarity2.Text
            txtCW2.Tag = txtCW2.Text


            If cboDiaCut2.Text = "DIAMANTE" Then
                txtCW2.Text = ""

            ElseIf cboDiaCut2.Text = "OLD CUT" Then
                txtCW2.Text = ""

            ElseIf cboDiaCut2.Text = "SINGLE CUT" Then
                txtCW2.Text = ""

            Else
                lblDiaPC2.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC2.Tag = lblDiaPC2.Text

            End If

        Catch ex As Exception
            MsgBox("frmRec/txtCW2_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCW3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCW3.TextChanged
        Try
            If txtCW3.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCW3.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtCW3.Text.Length <= 0, 0, txtCW3.Text)
            tmpDiaColor = cboDiaColor3.Text
            tmpDiaClarity = cboDiaClarity3.Text
            txtCW3.Tag = txtDiaCW3.Text

            If cboDiaCut3.Text = "DIAMANTE" Then
                txtCW3.Text = ""

            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                txtCW3.Text = ""

            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                txtCW3.Text = ""

            Else
                lblDiaPC3.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC3.Tag = lblDiaPC3.Text

            End If

        Catch ex As Exception
            MsgBox("frmRec/txtCW3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCW4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCW4.TextChanged
        Try
            If txtCW4.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCW4.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtCW4.Text.Length <= 0, 0, txtCW4.Text)
            tmpDiaColor = cboDiaColor4.Text
            tmpDiaClarity = cboDiaClarity4.Text
            txtCW4.Tag = txtCW4.Text

            If cboDiaCut4.Text = "DIAMANTE" Then
                txtCW4.Text = ""

            ElseIf cboDiaCut3.Text = "OLD CUT" Then
                txtCW4.Text = ""

            ElseIf cboDiaCut3.Text = "SINGLE CUT" Then
                txtCW4.Text = ""

            Else
                lblDiaPC4.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC4.Tag = lblDiaPC4.Text

            End If

        Catch ex As Exception
            MsgBox("frmRec/txtCW4_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtCW5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCW5.TextChanged
        Try
            If txtCW5.Text = "" Then
                Exit Sub
            Else
                If Replace(txtCW5.Text, ".", "").Length <= 0 Then
                    Exit Sub
                End If
            End If

            tmpDiaCW = IIf(txtCW5.Text.Length <= 0, 0, txtCW5.Text)
            tmpDiaColor = cboDiaColor5.Text
            tmpDiaClarity = cboDiaClarity5.Text
            txtCW5.Tag = txtCW5.Text

            If cboDiaCut5.Text = "DIAMANTE" Then
                txtCW5.Text = ""

            ElseIf cboDiaCut5.Text = "OLD CUT" Then
                txtCW5.Text = ""

            ElseIf cboDiaCut5.Text = "SINGLE CUT" Then
                txtCW5.Text = ""

            Else
                lblDiaPC5.Text = Format(Computation("DIAMOND"), "#,###,##0.00")
                lblDiaPC5.Tag = lblDiaPC5.Text

            End If

        Catch ex As Exception
            MsgBox("frmRec/txtCW5_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


   
End Class

