Imports System.IO
Imports System.Data.SqlClient
Public Class frmReleaseIndividually
    Inherits System.Windows.Forms.Form
    Dim RELStat As Integer

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
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnOUt As System.Windows.Forms.Button
    Friend WithEvents btnForced As System.Windows.Forms.Button
    Friend WithEvents cboALL As System.Windows.Forms.ComboBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblEmpIDNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNorm As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label43 As System.Windows.Forms.Label
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox32 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents btnSaveMLWB As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReleaseIndividually))
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btnOUt = New System.Windows.Forms.Button
        Me.btnForced = New System.Windows.Forms.Button
        Me.cboALL = New System.Windows.Forms.ComboBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.lblEmpIDNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNorm = New System.Windows.Forms.Button
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label43 = New System.Windows.Forms.Label
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label27 = New System.Windows.Forms.Label
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
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox32 = New System.Windows.Forms.TextBox
        Me.TextBox30 = New System.Windows.Forms.TextBox
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.btnSaveMLWB = New System.Windows.Forms.Button
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Gold_Cost"
        Me.ColumnHeader26.Width = 85
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Cleaning_Cost"
        Me.ColumnHeader25.Width = 111
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Cellular_Cost"
        Me.ColumnHeader22.Width = 103
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Watch_Cost"
        Me.ColumnHeader23.Width = 92
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Repair_Cost"
        Me.ColumnHeader24.Width = 88
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(96, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(344, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 143
        Me.PictureBox3.TabStop = False
        '
        'btnOUt
        '
        Me.btnOUt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOUt.Enabled = False
        Me.btnOUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOUt.Location = New System.Drawing.Point(448, 175)
        Me.btnOUt.Name = "btnOUt"
        Me.btnOUt.Size = New System.Drawing.Size(32, 24)
        Me.btnOUt.TabIndex = 151
        Me.btnOUt.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnOUt, "Cost Outsource Items")
        '
        'btnForced
        '
        Me.btnForced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForced.Enabled = False
        Me.btnForced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForced.Location = New System.Drawing.Point(448, 151)
        Me.btnForced.Name = "btnForced"
        Me.btnForced.Size = New System.Drawing.Size(32, 24)
        Me.btnForced.TabIndex = 149
        Me.btnForced.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnForced, "Cost Forced Received Items")
        '
        'cboALL
        '
        Me.cboALL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboALL.ItemHeight = 16
        Me.cboALL.Location = New System.Drawing.Point(192, 223)
        Me.cboALL.Name = "cboALL"
        Me.cboALL.Size = New System.Drawing.Size(256, 24)
        Me.cboALL.TabIndex = 128
        '
        'Label58
        '
        Me.Label58.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(96, 231)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 16)
        Me.Label58.TabIndex = 148
        Me.Label58.Text = "A.L.L Barcode:"
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBranchCode.Location = New System.Drawing.Point(192, 127)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 130
        Me.txtBranchCode.Text = ""
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(152, 55)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(240, 20)
        Me.TextBox16.TabIndex = 131
        Me.TextBox16.Text = "TextBox16"
        Me.TextBox16.Visible = False
        '
        'Label56
        '
        Me.Label56.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(88, 127)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(104, 23)
        Me.Label56.TabIndex = 146
        Me.Label56.Text = "Branch Code :"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Item ID"
        Me.ColumnHeader21.Width = 61
        '
        'lblEmpIDNo
        '
        Me.lblEmpIDNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpIDNo.Location = New System.Drawing.Point(96, 455)
        Me.lblEmpIDNo.Name = "lblEmpIDNo"
        Me.lblEmpIDNo.Size = New System.Drawing.Size(64, 20)
        Me.lblEmpIDNo.TabIndex = 145
        Me.lblEmpIDNo.Visible = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(160, 455)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(168, 20)
        Me.lblName.TabIndex = 144
        Me.lblName.Visible = False
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ALL Desc"
        Me.ColumnHeader12.Width = 477
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ALL Qty"
        Me.ColumnHeader13.Width = 58
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ALL Karat"
        Me.ColumnHeader14.Width = 70
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ALL Carat"
        Me.ColumnHeader15.Width = 71
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "ALL Weight"
        Me.ColumnHeader17.Width = 85
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ALL Cost"
        Me.ColumnHeader18.Width = 143
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 369
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.Width = 41
        '
        'txtbrname
        '
        Me.txtbrname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbrname.Location = New System.Drawing.Point(248, 127)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.Size = New System.Drawing.Size(200, 20)
        Me.txtbrname.TabIndex = 147
        Me.txtbrname.Text = ""
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "YG_Cost"
        Me.ColumnHeader28.Width = 75
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Mount_Cost"
        Me.ColumnHeader27.Width = 88
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ALL_ValueCost"
        Me.ColumnHeader6.Width = 116
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "WG_Cost"
        Me.ColumnHeader29.Width = 81
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'btnNorm
        '
        Me.btnNorm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNorm.Enabled = False
        Me.btnNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorm.Location = New System.Drawing.Point(448, 127)
        Me.btnNorm.Name = "btnNorm"
        Me.btnNorm.Size = New System.Drawing.Size(32, 24)
        Me.btnNorm.TabIndex = 150
        Me.btnNorm.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnNorm, "Cost Items Received from Replicated Data")
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Code"
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item ID"
        Me.ColumnHeader1.Width = 58
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Karat"
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Carat"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Weight"
        Me.ColumnHeader9.Width = 78
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Cost"
        Me.ColumnHeader11.Width = 138
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 3
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(784, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 40)
        Me.Button2.TabIndex = 134
        Me.Button2.Text = "Clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label43
        '
        Me.Label43.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(440, 447)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 23)
        Me.Label43.TabIndex = 136
        Me.Label43.Text = "Label43"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Panel8)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Controls.Add(Me.Panel7)
        Me.GroupBox4.Controls.Add(Me.Panel6)
        Me.GroupBox4.Location = New System.Drawing.Point(576, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 256)
        Me.GroupBox4.TabIndex = 132
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
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(0, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(328, 248)
        Me.Panel5.TabIndex = 61
        Me.Panel5.Visible = False
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Location = New System.Drawing.Point(280, 192)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(48, 23)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "Clear"
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Location = New System.Drawing.Point(280, 168)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(48, 23)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "Clear"
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Location = New System.Drawing.Point(280, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(48, 23)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Clear"
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(224, 192)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 23)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "Cost D"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(224, 168)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 23)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Cost C"
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(224, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Cost B"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(224, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Cost A"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label53.Location = New System.Drawing.Point(135, 216)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 23)
        Me.Label53.TabIndex = 15
        Me.Label53.Text = "Label53"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label52.Location = New System.Drawing.Point(135, 192)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(81, 23)
        Me.Label52.TabIndex = 14
        Me.Label52.Text = "Label52"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Location = New System.Drawing.Point(136, 168)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 23)
        Me.Label51.TabIndex = 13
        Me.Label51.Text = "Label51"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label50.Location = New System.Drawing.Point(135, 144)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 23)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Label50"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Location = New System.Drawing.Point(135, 120)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(81, 23)
        Me.Label49.TabIndex = 11
        Me.Label49.Text = "Label49"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(8, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 23)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "WG Cleaning Cost :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(8, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "YG Cleaning Cost :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(48, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 23)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Mount Cost :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(56, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 23)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Gold Cost :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(95, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(48, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 23)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "A.L.L Value :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Panel7.Location = New System.Drawing.Point(0, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(328, 264)
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
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(224, 184)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(48, 23)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "Clear"
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Enabled = False
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(224, 160)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(48, 23)
        Me.Button15.TabIndex = 19
        Me.Button15.Text = "Clear"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.Location = New System.Drawing.Point(128, 136)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 23)
        Me.Label54.TabIndex = 11
        Me.Label54.Text = "Label54"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.Location = New System.Drawing.Point(40, 208)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 23)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "A.L.L Value :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Location = New System.Drawing.Point(128, 184)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(88, 23)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.Text = "TextBox25"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.Location = New System.Drawing.Point(40, 160)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 23)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Repair Cost :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Location = New System.Drawing.Point(128, 208)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(88, 23)
        Me.TextBox26.TabIndex = 9
        Me.TextBox26.Text = "TextBox26"
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Location = New System.Drawing.Point(128, 160)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(88, 23)
        Me.TextBox29.TabIndex = 14
        Me.TextBox29.Text = "TextBox29"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.Location = New System.Drawing.Point(24, 184)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 23)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Cleaning Cost :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.Location = New System.Drawing.Point(32, 136)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(96, 23)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Cellular Cost :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.ImageIndex = 1
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(856, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 135
        Me.Button3.Text = "Close"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 455)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 23)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = "Employee :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.ImageIndex = 3
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(712, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 40)
        Me.Button4.TabIndex = 133
        Me.Button4.Text = "Print"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button13
        '
        Me.Button13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.ImageIndex = 2
        Me.Button13.ImageList = Me.ImageList1
        Me.Button13.Location = New System.Drawing.Point(640, 448)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(72, 40)
        Me.Button13.TabIndex = 142
        Me.Button13.Text = "Save"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(152, 55)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox2.TabIndex = 137
        Me.ComboBox2.Text = "ComboBox2"
        Me.ComboBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TextBox32)
        Me.GroupBox3.Controls.Add(Me.TextBox30)
        Me.GroupBox3.Controls.Add(Me.TextBox21)
        Me.GroupBox3.Controls.Add(Me.TextBox12)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 271)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(920, 168)
        Me.GroupBox3.TabIndex = 141
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edit"
        '
        'TextBox32
        '
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox32.Location = New System.Drawing.Point(768, 112)
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.ReadOnly = True
        Me.TextBox32.Size = New System.Drawing.Size(144, 23)
        Me.TextBox32.TabIndex = 61
        Me.TextBox32.Text = ""
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.Color.White
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox30.Location = New System.Drawing.Point(771, 80)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.ReadOnly = True
        Me.TextBox30.Size = New System.Drawing.Size(140, 16)
        Me.TextBox30.TabIndex = 58
        Me.TextBox30.Text = ""
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.Color.White
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox21.Location = New System.Drawing.Point(686, 80)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.ReadOnly = True
        Me.TextBox21.Size = New System.Drawing.Size(82, 16)
        Me.TextBox21.TabIndex = 55
        Me.TextBox21.Text = ""
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.White
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Location = New System.Drawing.Point(614, 80)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(70, 16)
        Me.TextBox12.TabIndex = 49
        Me.TextBox12.Text = ""
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Location = New System.Drawing.Point(544, 80)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(68, 16)
        Me.TextBox9.TabIndex = 46
        Me.TextBox9.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(485, 80)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(57, 16)
        Me.TextBox4.TabIndex = 43
        Me.TextBox4.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(10, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(473, 16)
        Me.TextBox1.TabIndex = 40
        Me.TextBox1.Text = ""
        '
        'ListView2
        '
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Enabled = False
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 58)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(906, 43)
        Me.ListView2.TabIndex = 39
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label47.Location = New System.Drawing.Point(120, 136)
        Me.Label47.Name = "Label47"
        Me.Label47.TabIndex = 38
        Me.Label47.Text = "Label47"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label46.Location = New System.Drawing.Point(120, 112)
        Me.Label46.Name = "Label46"
        Me.Label46.TabIndex = 37
        Me.Label46.Text = "Label46"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label45.Location = New System.Drawing.Point(432, 136)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(104, 23)
        Me.Label45.TabIndex = 36
        Me.Label45.Text = "Label45"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label44.Location = New System.Drawing.Point(432, 112)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(104, 23)
        Me.Label44.TabIndex = 35
        Me.Label44.Text = "Label44"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(296, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Date Loan Granted :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(696, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "ALL Price:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(344, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 23)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Loan Value :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(16, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 23)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Maturity Date :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(24, 136)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 23)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Expiry Date :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.ListView1.Enabled = False
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(906, 77)
        Me.ListView1.TabIndex = 6
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(192, 151)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox4.TabIndex = 129
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(128, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 23)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "Action :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "ALL Sorting Class :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.ComboBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox15)
        Me.GroupBox6.Controls.Add(Me.ComboBox3)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.ComboBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(56, 111)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(432, 152)
        Me.GroupBox6.TabIndex = 152
        Me.GroupBox6.TabStop = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(136, 64)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox5.TabIndex = 75
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(136, 90)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(240, 20)
        Me.TextBox15.TabIndex = 2
        Me.TextBox15.Text = ""
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(136, 64)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox3.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(96, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 23)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "PTN :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(136, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox1.TabIndex = 72
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ListView3
        '
        Me.ListView3.AllowColumnReorder = True
        Me.ListView3.AllowDrop = True
        Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader6})
        Me.ListView3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView3.Enabled = False
        Me.ListView3.FullRowSelect = True
        Me.ListView3.GridLines = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.Location = New System.Drawing.Point(16, 287)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(904, 40)
        Me.ListView3.TabIndex = 153
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'btnSaveMLWB
        '
        Me.btnSaveMLWB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveMLWB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveMLWB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMLWB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveMLWB.ImageIndex = 2
        Me.btnSaveMLWB.ImageList = Me.ImageList1
        Me.btnSaveMLWB.Location = New System.Drawing.Point(640, 448)
        Me.btnSaveMLWB.Name = "btnSaveMLWB"
        Me.btnSaveMLWB.Size = New System.Drawing.Size(72, 40)
        Me.btnSaveMLWB.TabIndex = 154
        Me.btnSaveMLWB.Text = "Save"
        Me.btnSaveMLWB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmReleaseIndividually
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(936, 494)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnForced)
        Me.Controls.Add(Me.cboALL)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.lblEmpIDNo)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.btnNorm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.btnSaveMLWB)
        Me.Controls.Add(Me.btnOUt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReleaseIndividually"
        Me.Text = "Release Individually"
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " private declarations "
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private sUserID, sAction, sSortClass As String()
    Private iDataEntry, iFocus, iAction_id As Integer
    Private sDivision, sDivisionname As String
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
    Dim loc1 As String = "C:\Program Files\BOS\REMS"
    Private Sub cboALL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboALL.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                Dim obj As New clsCommon
                Dim dr As SqlDataReader
                Dim str As String

                obj = New clsCommon
                obj.ConnectionString1()
                obj.Open()

                obj.Command("If (Select Count(*) from tbl_receiving_header where recallbarcode = '" & cboALL.Text & "') <> 0 begin select recptn as ptn from tbl_receiving_header where recallbarcode = '" & cboALL.Text & "' end else select ptn_for as ptn from tbl_forcedoutrcv where allbarcode_for= '" & cboALL.Text & "'")
                dr = obj.OpenDataReader
                If dr.Read Then
                    Me.TextBox15.Text = obj.IsNull(dr.Item("PTN"))
                    RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                    Button13.Enabled = True
                    Button13.Focus()
                Else
                    MsgBox("NO DATA FOUND")
                    cboALL.Text = ""
                    cboALL.Focus()
                    Exit Sub
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmReleaseIndividually_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
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
            ComboBox4.Items.Add(Trim(dr.Item("action_type")))
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
            ComboBox5.Items.Add(Trim(dr.Item("description")))
            sSortClass(i) = Trim(dr.Item("code"))
            i = i + 1
        End While
        dr.Close()
        objclass.Close5()

        lblName.Text = fullname
        lblEmpIDNo.Text = idnumber
        Button13.Enabled = False
        Button2.Enabled = False

        If isedit = 1 Then
            'display2(Trim(TextBox15.Text), 1)
            RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
            Exit Sub
        End If

        Call Clear()

        cboALL.Focus()
    End Sub

    Private Sub RetrieveInfo(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Dim dr As SqlDataReader
        Dim sMPTN As String
        Dim iStatus, iCost_id, iItem_id As Integer
        Dim iRecorded As Integer
        Dim sStatus, sort_code, sSort_Code, picStr As String
        Dim img As Drawing.Image
        Dim obj As New clsCommon

        objclass = New clsCommon
        odatetime = New clsCommon.DateTime


        objclass.ConnectionString2()
        objclass.Open2()
        objclass.Command2("If (Select Count(*) from tbl_receiving_header where recALLBarcode='" & Me.cboALL.Text & "')<> 0 begin select 1 as st,photo as photo,recItem_ID as item_id,reccostid as cost_id, status_id , sortaction_id, sort_code from tbl_receiving_header where  recALLBarcode='" & Me.cboALL.Text & "' end else select 0 as st,photo_for as photo,FOR_PTN_ID as item_id,reccostid_for as cost_id, ForcedOut_status_FOR as status_id, sortaction_id_for as sortaction_id, sort_code_for as sort_code from tbl_ForcedOutRcv where  ALLBarcode_for='" & Me.cboALL.Text & "'")
        dr = objclass.OpenDataReader2
        If dr.Read Then
            st = dr.Item("st")
            If IsDBNull(dr.Item("cost_id")) Then
                iRecorded = 0
            Else
                iRecorded = 1
                iCost_id = CInt(dr.Item("cost_id"))
            End If
            iItem_id = dr.Item("item_id")
            iRecord = iRecorded
            picStr = objclass.IsNull(dr.Item("photo"))
            iStatus = CInt(dr.Item("status_id"))
            RELStat = iStatus
            If iStatus = objclass.status.sorting Then
                sStatus = "PTN received and sorted"
            ElseIf iStatus = objclass.status.released Then
                sStatus = "PTN released"
            ElseIf iStatus = objclass.status.costed Then
                sStatus = "PTN Costed"
            ElseIf iStatus = objclass.status.receivedByMLWB Then
                sStatus = "PTN received by MLWB"
            ElseIf iStatus = objclass.status.receivedByPRICING Then
                sStatus = "PTN received by PRICING"
            ElseIf iStatus = objclass.status.receivedByDISTRI Then
                sStatus = "PTN received by DISTRI"
            ElseIf iStatus = objclass.status.releasedByMLWB Then
                sStatus = "PTN released by MLWB"
            ElseIf iStatus = objclass.status.releasedByPRICING Then
                sStatus = "PTN released by PRICING"
            ElseIf iStatus = objclass.status.releasedByDISTRI Then
                sStatus = "PTN released by DISTRI"
            End If

            iAction_id = CInt(dr.Item("sortaction_id"))
            iDataEntry = iAction_id
            sSort_Code = Trim(objclass.IsNull(dr.Item("sort_code")))

        Else
            iStatus = 0
            sStatus = "Item not received"
        End If
        dr.Close()
        'objclass.Close3()

        If st = 1 Then
            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()
            If iset = 1 Then
                'objclass.Command("select * from tbl_pt_tran where ptn = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                obj.Command("select top 1 * from tbl_receiving_header where recptn = " + sPTN + "")
            Else
                'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                obj.Command("select top 1 * from tbl_receiving_header where recptnbarcode = " + sPTN + "")
            End If

            dr = obj.OpenDataReader()
            If dr.Read Then
                sDivision = Trim(dr.Item("recDivision"))
                odatetime.Split(dr.Item("Transdate"))
                Label43.Text = FormatNumber(dr.Item("rectotalAppraiseValue"))
                Label44.Text = FormatNumber(dr.Item("recloanvalue"))
                Label45.Text = Trim(CStr(dr.Item("LoanDate")))
                Label46.Text = Trim(CStr(dr.Item("MaturityDate")))
                Label47.Text = Trim(CStr(dr.Item("ExpiryDate")))

                If iset = 1 Then
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("recptnbarcode")))
                Else
                    TextBox15.Text = Trim(dr.Item("recptn"))
                End If
                odatetime = Nothing
            Else
                MsgBox("Item not found", MsgBoxStyle.Information)
                obj.Close()
                returnfocus1()
                Exit Sub
            End If
            dr.Close()
            'objclass.CloseDataReader()

            objclass.Command2("select distinct * from tbl_receiving_detail where DALLBarcode = '" & AllBar & "' and id = '" & iItem_id & "' order by itemcode")
            dr = objclass.OpenDataReader2()
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("ID")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("PTNItemDesc"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("ALL_Value"))))
                If objclass.IsNull(dr.Item("ALL_DEsc")) = "0" Then
                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("ptnitemdesc"))))
                Else
                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("ALL_Desc"))))
                End If
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
                If objclass.IsNull(dr.Item("All_Karat")) <> 0 Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                End If

                If objclass.IsNull(dr.Item("ALL_Carat")) = "" Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(0)
                Else
                    If objclass.IsNull(dr.Item("ALL_Carat")) <> 0 Then
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Carat"))))
                    Else
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                    End If
                End If
                'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                If objclass.IsNull(dr.Item("ALL_WT")) <> 0 Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_WT"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                End If
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_ValueCost"))))
                TextBox32.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))


                ListView3.Items.Add(Trim(dr.Item("ID")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_valuecost")))
            End While
            dr.Close()
            objclass.Execute2()
            objclass.Close2()
        Else
            'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
            objclass.Command2("select top 1 * from tbl_ForcedOutRcv where allbarcode_for='" & Me.cboALL.Text & "'")
            dr = objclass.OpenDataReader2()
            If dr.Read Then
                sDivision = Trim(objclass.IsNull(dr.Item("Division_for")))
                sPTN = Trim(objclass.IsNull(dr.Item("ptn_for")))
                Label43.Text = FormatNumber(objclass.IsNull(dr.Item("TotalAppraiseValue_FOR")))
                Label44.Text = FormatNumber(objclass.IsNull(dr.Item("LoanValue_FOR")))

                If iset = 1 Then
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode_for")))
                Else
                    TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn_for")))
                End If

            Else
                MsgBox("Item not found", MsgBoxStyle.Information)
                objclass.Close()
                returnfocus1()
                Exit Sub
            End If
            dr.Close()
            'objclass.Close2()

            objclass.Command2("select distinct * from tbl_ForcedOutRcv_detail where ALLBarcode_dfor = '" & AllBar & "' order by itemcode_dfor")
            dr = objclass.OpenDataReader2()
            ListView1.Items.Clear()
            ListView2.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("FOR_ID_DFOR"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("PTNItemDesc_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight_dfor"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("ALL_Value_DFOR"))))

                If objclass.IsNull(dr.Item("ALL_Desc_dfor")) = "0" Then
                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("ptnitemdesc_dfor"))))
                Else
                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("ALL_Desc_dfor"))))
                End If

                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity_dfor"))))
                If objclass.IsNull(dr.Item("all_karat_dfor")) <> 0 Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat_dfor"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading_dfor"))))
                End If

                If objclass.IsNull(dr.Item("ALL_Carat_dfor")) = 0 Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize_dfor"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Carat_dfor"))))
                End If
                'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
                If objclass.IsNull(dr.Item("ALL_WT_dfor")) <> 0 Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_WT_dfor"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight_dfor"))))
                End If

                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Valuecost_dfor"))))

                ListView3.Items.Add(Trim(dr.Item("FOR_ID_DFOR")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost_dfor")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_valuecost_dfor")))

            End While
            dr.Close()
            objclass.Execute2()
            objclass.Close2()

        End If


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
            'MsgBox("Image Don't Exist ", MsgBoxStyle.Information)
            'PictureBox1.Hide()
            'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information)
        End If


        Call List2()

        objclass.ConnDb()
        objclass.Open5()

        If UCase(sDB) = "LUZON" Then
            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + sDivision + "'")
        ElseIf UCase(sDB) = "VISMIN" Then
            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + sDivision + "'")
        ElseIf UCase(sDB) = "SHOWROOM" Then
            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + sDivision + "'")
        ElseIf UCase(sDB) = "MINDANAO" Then
            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + sDivision + "'")
        ElseIf UCase(sDB) = "LNCR" Then
            objclass.Command5("select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr = '" + sDivision + "'")
        End If

        dr = objclass.OpenDataReader5
        If dr.Read Then
            txtBranchCode.Text = sDivision
            txtbrname.Text = Trim(objclass.IsNull(dr.Item("bedrnm")))
        End If
        dr.Close()
        objclass.Execute5()
        objclass.Close5()

        If iRecorded = 1 Then
            DisplayAction(iAction_id, 1)
            'SelectUser(iCost_id)
            SelectAction(iAction_id)
            If iAction_id = objclass.action.Cellular Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            ElseIf iAction_id = objclass.action.Watch Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            Else
                SelectClass(sSort_Code)
                If iStatus = objclass.status.costed Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.released Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                End If
            End If
        Else
            If iStatus = objclass.status.sorting Or CStr(CDbl(iStatus)) = 0 Or CStr(CDbl(iStatus)) = 1 Then
                DisplayAction(iAction_id, 0)
                SelectAction(iAction_id)
                If iAction_id = objclass.action.Cellular Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                ElseIf iAction_id = objclass.action.Watch Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)
                End If
                'ComboBox3.Enabled = True
            ElseIf iStatus = objclass.status.released Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receiving Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.costed Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByPRICING Then
                If prcing = True Then
                    DisplayAction(iAction_id, 0)
                    SelectAction(iAction_id)
                    If iAction_id = objclass.action.Cellular Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    ElseIf iAction_id = objclass.action.Watch Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    Else
                        SelectClass(sSort_Code)
                    End If
                End If
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByPRICING Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            Else
                MsgBox(sStatus, MsgBoxStyle.Exclamation)
                Button13.Enabled = True
                Button2.Enabled = True
            End If
        End If
        'Button13.Enabled = True
        Button2.Enabled = True
        'If CDbl(Label43.Text) < CDbl(Label44.Text) Then
        '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical)
        'End If
        iRecorded = Nothing
        objclass = Nothing
    End Sub
    Private Sub RetrieveInfo1(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Dim dr As SqlDataReader
        Dim sMPTN As String
        Dim iStatus, iCost_id, iItem_id As Integer
        Dim iRecorded As Integer
        Dim sStatus, sort_code, sSort_Code, picStr As String

        Dim img As Drawing.Image

        objclass = New clsCommon
        odatetime = New clsCommon.DateTime


        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("if (Select Count(*) from tbl_receiving_header where recallbarcode = '" & Me.cboALL.Text & "') <> 0 begin select 1 as st,photo as photo,recItem_ID as item_id ,reccostid as cost_id, status_id, sortaction_id, sort_code from tbl_receiving_header where recALLBarcode='" & Me.cboALL.Text & "' end else select 0 as st,photo_for as photo,FOR_PTN_ID as item_id,reccostid_for as cost_id, ForcedOut_status_FOR as status_id, sortaction_id_for as sortaction_id, sort_code_for as sort_code from tbl_ForcedOutRcv where ALLBarcode_for='" & Me.cboALL.Text & "'")
        dr = objclass.OpenDataReader3
        If dr.Read Then
            If dr.Item("STATUS_ID") = 7 Then
                st = dr.Item("st")
                If IsDBNull(dr.Item("cost_id")) Then
                    iRecorded = 0
                Else
                    iRecorded = 1
                    iCost_id = CInt(dr.Item("cost_id"))
                End If
                iItem_id = dr.Item("item_id")
                iRecord = iRecorded
                picStr = objclass.IsNull(dr.Item("photo"))
                iStatus = CInt(dr.Item("status_id"))
                If iStatus = objclass.status.sorting Then
                    sStatus = "PTN received and sorted"
                ElseIf iStatus = objclass.status.released Then
                    sStatus = "PTN released"
                ElseIf iStatus = objclass.status.receiving Then
                    sStatus = "PTN received only"
                ElseIf iStatus = objclass.status.costed Then
                    sStatus = "PTN Costed"
                ElseIf iStatus = objclass.status.receivedByMLWB Then
                    sStatus = "PTN received by MLWB"
                ElseIf iStatus = objclass.status.receivedByPRICING Then
                    sStatus = "PTN received by PRICING"
                ElseIf iStatus = objclass.status.receivedByDISTRI Then
                    sStatus = "PTN received by DISTRI"
                ElseIf iStatus = objclass.status.releasedByMLWB Then
                    sStatus = "PTN released by MLWB"
                ElseIf iStatus = objclass.status.releasedByPRICING Then
                    sStatus = "PTN released by PRICING"
                ElseIf iStatus = objclass.status.releasedByDISTRI Then
                    sStatus = "PTN released by DISTRI"
                End If
                If iStatus <> 1 Then
                    iAction_id = CInt(dr.Item("sortaction_id"))
                End If
                iDataEntry = iAction_id
                sSort_Code = Trim(objclass.IsNull(dr.Item("sort_code")))
            ElseIf dr.Item("STATUS_ID") >= 8 Then
                MsgBox("ITEM ALREADY RELEASE IN PRICING")
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            Else
                MsgBox("Item not yet receive in PRICING!")
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Item not found!")
            cboALL.Text = ""
            TextBox15.Text = ""
            cboALL.Focus()
            Exit Sub
        End If
        dr.Close()
        objclass.Execute3()
        'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
        objclass.Command3("if (Select Count(*) from tbl_receiving_header where recallbarcode = '" & Me.cboALL.Text & "') <> 0 begin select reclotno as lotno,recdivision as division,recdivisionname as divisionname,recptn as ptn,recitem_id as item_id,recptnbarcode as ptnbarcode,recallbarcode as allbarcode,photo as photo,recCostCenter as costcenter,recactionid as action_id, sortaction_id as sortaction_id,sort_code as sort_code, recloanvalue as loanvalue,rectotalappraisevalue as appraisevalue,recId as rec_id,recname as recname,recsorterid as sorter_id, recsortername as sorter_name,recCostID as Cost_id, recCostName as Cost_name,recreleasingId as releasing_id,recreleasingname as releasing_name,receivedate as receivedate,pulloutdate as pulloutdate,sortdate as sortdate,costdate as costdate,releasedate as releasedate,status_id as status_id from tbl_receiving_header where recallbarcode ='" & Me.cboALL.Text & "' end else select lotno_for as lotno,division_for as division,divisionname_for as divisionname,ptn_for as ptn,for_ptn_id as item_id,ptnbarcode_for as ptnbarcode,allbarcode_for as allbarcode,photo_for as photo,CostCenter_for as costcenter,actionid_for as action_id, sortaction_id_for as sortaction_id,sort_code_for as sort_code, loanvalue_for as loanvalue,totalappraisevalue_for as appraisevalue,recId_for as rec_id,recname_for as recname,recsorterid_for as sorter_id, recsortername_for as sorter_name,recCostID_for as Cost_id, recCostName_for as Cost_name,recreleasingId_for as releasing_id,recreleasingname_for as releasing_name,receivedate_for as receivedate,pulloutdate_for as pulloutdate,sortdate_for as sortdate,costdate_for as costdate,releasedate_for as releasedate,forcedout_status_for as status_id from tbl_ForcedOutRcv where allbarcode_for = '" & Me.cboALL.Text & "'")
        dr = objclass.OpenDataReader3()
        If dr.Read Then
            sDivision = Trim(objclass.IsNull(dr.Item("Division")))
            sDivisionname = Trim(objclass.IsNull(dr.Item("Divisionname")))
            sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
            Label43.Text = FormatNumber(objclass.IsNull(dr.Item("AppraiseValue")))
            Label44.Text = FormatNumber(objclass.IsNull(dr.Item("LoanValue")))

            If iset = 1 Then
                TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
            Else
                TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))
            End If

        Else
            MsgBox("Item not found", MsgBoxStyle.Information)
            objclass.Close3()
            returnfocus1()
            Exit Sub
        End If
        dr.Close()
        objclass.Execute3()

        objclass.Command3("if (select COunt(*) from tbl_receiving_detail where dallbarcode = '" & cboALL.Text & "') <> 0 begin select distinct [id] as Item_id,itemcode,ptnitemdesc as itemdesc,quantity,karatgrading as karat,caratsize as carat,weight,ALL_DESC,ALL_value,ALL_valuecost,all_karat,all_carat,all_wt,all_price,Price_Desc,Price_Karat,Price_Weight,Price_Carat,cellular_cost as cellular,watch_Cost as watch,repair_cost as repair,cleaning_cost as cleaning,gold_cost as gold,mount_cost as mount,yg_cost as yg,wg_cost as wg from tbl_receiving_detail where DALLBarcode = '" & cboALL.Text & "' end else select distinct for_id_dfor as item_id,itemcode_dfor as itemcode,ptnitemdesc_dfor as itemdesc,quantity_dfor as quantity,karatgrading_dfor as karat,caratsize_dfor as carat,weight_dfor as weight,ALL_Desc_dfor as ALL_Desc,ALL_value_dfor as ALL_Value,ALL_valuecost_dfor as all_valuecost,all_karat_dfor as all_karat,all_carat_dfor as all_carat,all_wt_dfor as all_wt,all_price_dfor as all_price,Price_Desc_dfor as Price_desc,Price_Karat_dfor as Price_karat,Price_Weight_dfor as Price_weight,Price_Carat_dfor as Price_Carat,cellular_cost_dfor as cellular,watch_Cost_dfor as watch,repair_cost_dfor as repair,cleaning_cost_dfor as cleaning,gold_cost_dfor as gold,mount_cost_dfor as mount,yg_cost_dfor as yg,wg_cost_dfor as wg from tbl_forcedoutrcv_detail where ALLBarcode_dfor = '" & cboALL.Text & "'")
        dr = objclass.OpenDataReader3()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        While dr.Read
            ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("item_id"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemDesc"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Karat"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Carat"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("ALL_Value"))))
            If objclass.IsNull(dr.Item("Price_desc")) = "0" Then
                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
            Else
                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("Price_desc"))))
            End If
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
            If objclass.IsNull(dr.Item("Price_Karat")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Price_Karat"))))
            End If
            If objclass.IsNull(dr.Item("Price_Carat")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Carat"))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Price_Carat"))))
            End If
            'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
            If objclass.IsNull(dr.Item("Price_Weight")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("ALL_WT")))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("Price_WeighT")))))
            End If
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Valuecost"))))
            TextBox32.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))


            ListView3.Items.Add(Trim(objclass.IsNull(dr.Item("item_id"))))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_valuecost")))
        End While
        dr.Close()
        objclass.Execute3()
        objclass.Close3()




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
            'MsgBox("Image Don't Exist ", MsgBoxStyle.Information)
            'PictureBox1.Hide()
            'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information)
        End If

        Call List2()

        'objclass.ConnDb()
        'objclass.Open5()

        'objclass.Command5("select bedrnm from " & bedryf2 & " where bedrnr = '" + sDivision + "' order by bedrnm desc")

        'dr = objclass.OpenDataReader5
        'If dr.Read Then
        txtBranchCode.Text = sDivision
        txtbrname.Text = sDivisionname
        'End If
        'dr.Close()
        'objclass.Execute5()
        'objclass.Close5()

        If iRecorded = 1 Then
            DisplayAction(iAction_id, 1)
            'SelectUser(iCost_id)
            SelectAction(iAction_id)
            If iAction_id = objclass.action.Cellular Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            ElseIf iAction_id = objclass.action.Watch Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            Else
                SelectClass(sSort_Code)
                If iStatus = objclass.status.costed Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.released Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                End If
            End If
        Else
            If iStatus = objclass.status.sorting Then
                DisplayAction(iAction_id, 0)
                SelectAction(iAction_id)
                If iAction_id = objclass.action.Cellular Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                ElseIf iAction_id = objclass.action.Watch Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)
                End If
                'ComboBox3.Enabled = True
            ElseIf iStatus = objclass.status.released Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receiving Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.costed Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByPRICING Then
                If prcing = True Then
                    DisplayAction(iAction_id, 0)
                    SelectAction(iAction_id)
                    If iAction_id = objclass.action.Cellular Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    ElseIf iAction_id = objclass.action.Watch Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    Else
                        SelectClass(sSort_Code)
                    End If
                End If
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByPRICING Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            Else
                MsgBox(sStatus, MsgBoxStyle.Exclamation)
                Button13.Enabled = True
                Button2.Enabled = True
            End If
        End If
        'Button13.Enabled = True
        Button2.Enabled = True
        'If CDbl(Label43.Text) < CDbl(Label44.Text) Then
        '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical)
        'End If
        iRecorded = Nothing
        objclass = Nothing
        TextBox1.Focus()
    End Sub
    Private Sub RetrieveInfo2(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Dim dr As SqlDataReader
        Dim sMPTN As String
        Dim iStatus, iCost_id, iItem_id As Integer
        Dim iRecorded As Integer
        Dim sStatus, sort_code, sSort_Code, picStr As String

        Dim img As Drawing.Image

        objclass = New clsCommon
        odatetime = New clsCommon.DateTime


        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("if (Select Count(*) from tbl_receiving_header where recallbarcode = '" & Me.cboALL.Text & "') <> 0 begin select 1 as st,photo as photo,recItem_ID as item_id ,reccostid as cost_id, status_id, sortaction_id, sort_code from tbl_receiving_header where recALLBarcode='" & Me.cboALL.Text & "' end else select 0 as st,photo_for as photo,FOR_PTN_ID as item_id,reccostid_for as cost_id, ForcedOut_status_FOR as status_id, sortaction_id_for as sortaction_id, sort_code_for as sort_code from tbl_ForcedOutRcv where ALLBarcode_for='" & Me.cboALL.Text & "'")
        dr = objclass.OpenDataReader3
        If dr.Read Then
            If dr.Item("STATUS_ID") = 5 Then
                st = dr.Item("st")
                If IsDBNull(dr.Item("cost_id")) Then
                    iRecorded = 0
                Else
                    iRecorded = 1
                    iCost_id = CInt(dr.Item("cost_id"))
                End If
                iItem_id = dr.Item("item_id")
                iRecord = iRecorded
                picStr = objclass.IsNull(dr.Item("photo"))
                iStatus = CInt(dr.Item("status_id"))
                If iStatus = objclass.status.sorting Then
                    sStatus = "PTN received and sorted"
                ElseIf iStatus = objclass.status.released Then
                    sStatus = "PTN released"
                ElseIf iStatus = objclass.status.receiving Then
                    sStatus = "PTN received only"
                ElseIf iStatus = objclass.status.costed Then
                    sStatus = "PTN Costed"
                ElseIf iStatus = objclass.status.receivedByMLWB Then
                    sStatus = "PTN received by MLWB"
                ElseIf iStatus = objclass.status.receivedByPRICING Then
                    sStatus = "PTN received by PRICING"
                ElseIf iStatus = objclass.status.receivedByDISTRI Then
                    sStatus = "PTN received by DISTRI"
                ElseIf iStatus = objclass.status.releasedByMLWB Then
                    sStatus = "PTN released by MLWB"
                ElseIf iStatus = objclass.status.releasedByPRICING Then
                    sStatus = "PTN released by PRICING"
                ElseIf iStatus = objclass.status.releasedByDISTRI Then
                    sStatus = "PTN released by DISTRI"
                End If
                If iStatus <> 1 Then
                    iAction_id = CInt(dr.Item("sortaction_id"))
                End If
                iDataEntry = iAction_id
                sSort_Code = Trim(objclass.IsNull(dr.Item("sort_code")))
            ElseIf dr.Item("STATUS_ID") >= 6 Then
                MsgBox("ITEM ALREADY RELEASE IN MLWB")
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            Else
                MsgBox("Item not yet receive in MLWB!")
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Item not found!")
            cboALL.Text = ""
            TextBox15.Text = ""
            cboALL.Focus()
            Exit Sub
        End If
        dr.Close()
        objclass.Execute3()
        'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
        objclass.Command3("if (Select Count(*) from tbl_receiving_header where recallbarcode = '" & Me.cboALL.Text & "') <> 0 begin select reclotno as lotno,recdivision as division,recdivisionname as divisionname,recptn as ptn,recitem_id as item_id,recptnbarcode as ptnbarcode,recallbarcode as allbarcode,photo as photo,recCostCenter as costcenter,recactionid as action_id, sortaction_id as sortaction_id,sort_code as sort_code, recloanvalue as loanvalue,rectotalappraisevalue as appraisevalue,recId as rec_id,recname as recname,recsorterid as sorter_id, recsortername as sorter_name,recCostID as Cost_id, recCostName as Cost_name,recreleasingId as releasing_id,recreleasingname as releasing_name,receivedate as receivedate,pulloutdate as pulloutdate,sortdate as sortdate,costdate as costdate,releasedate as releasedate,status_id as status_id from tbl_receiving_header where recallbarcode ='" & Me.cboALL.Text & "' end else select lotno_for as lotno,division_for as division,divisionname_for as divisionname,ptn_for as ptn,for_ptn_id as item_id,ptnbarcode_for as ptnbarcode,allbarcode_for as allbarcode,photo_for as photo,CostCenter_for as costcenter,actionid_for as action_id, sortaction_id_for as sortaction_id,sort_code_for as sort_code, loanvalue_for as loanvalue,totalappraisevalue_for as appraisevalue,recId_for as rec_id,recname_for as recname,recsorterid_for as sorter_id, recsortername_for as sorter_name,recCostID_for as Cost_id, recCostName_for as Cost_name,recreleasingId_for as releasing_id,recreleasingname_for as releasing_name,receivedate_for as receivedate,pulloutdate_for as pulloutdate,sortdate_for as sortdate,costdate_for as costdate,releasedate_for as releasedate,forcedout_status_for as status_id from tbl_ForcedOutRcv where allbarcode_for = '" & Me.cboALL.Text & "'")
        dr = objclass.OpenDataReader3()
        If dr.Read Then
            sDivision = Trim(objclass.IsNull(dr.Item("Division")))
            sDivisionname = Trim(objclass.IsNull(dr.Item("Divisionname")))
            sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
            Label43.Text = FormatNumber(objclass.IsNull(dr.Item("AppraiseValue")))
            Label44.Text = FormatNumber(objclass.IsNull(dr.Item("LoanValue")))

            If iset = 1 Then
                TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
            Else
                TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))
            End If

        Else
            MsgBox("Item not found", MsgBoxStyle.Information)
            objclass.Close3()
            returnfocus1()
            Exit Sub
        End If
        dr.Close()
        objclass.Execute3()

        objclass.Command3("if (select COunt(*) from tbl_receiving_detail where dallbarcode = '" & cboALL.Text & "') <> 0 begin select distinct [id] as Item_id,itemcode,ptnitemdesc as itemdesc,quantity,karatgrading as karat,caratsize as carat,weight,ALL_DESC,ALL_value,ALL_valuecost,all_karat,all_carat,all_wt,all_price,Price_Desc,Price_Karat,Price_Weight,Price_Carat,cellular_cost as cellular,watch_Cost as watch,repair_cost as repair,cleaning_cost as cleaning,gold_cost as gold,mount_cost as mount,yg_cost as yg,wg_cost as wg from tbl_receiving_detail where DALLBarcode = '" & cboALL.Text & "' end else select distinct for_id_dfor as item_id,itemcode_dfor as itemcode,ptnitemdesc_dfor as itemdesc,quantity_dfor as quantity,karatgrading_dfor as karat,caratsize_dfor as carat,weight_dfor as weight,ALL_Desc_dfor as ALL_Desc,ALL_value_dfor as ALL_Value,ALL_valuecost_dfor as all_valuecost,all_karat_dfor as all_karat,all_carat_dfor as all_carat,all_wt_dfor as all_wt,all_price_dfor as all_price,Price_Desc_dfor as Price_desc,Price_Karat_dfor as Price_karat,Price_Weight_dfor as Price_weight,Price_Carat_dfor as Price_Carat,cellular_cost_dfor as cellular,watch_Cost_dfor as watch,repair_cost_dfor as repair,cleaning_cost_dfor as cleaning,gold_cost_dfor as gold,mount_cost_dfor as mount,yg_cost_dfor as yg,wg_cost_dfor as wg from tbl_forcedoutrcv_detail where ALLBarcode_dfor = '" & cboALL.Text & "'")
        dr = objclass.OpenDataReader3()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        While dr.Read
            ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("item_id"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemDesc"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Karat"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Carat"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("ALL_Value"))))
            If objclass.IsNull(dr.Item("Price_desc")) = "0" Then
                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
            Else
                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("Price_desc"))))
            End If
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
            If objclass.IsNull(dr.Item("Price_Karat")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Price_Karat"))))
            End If
            If objclass.IsNull(dr.Item("Price_Carat")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Carat"))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Price_Carat"))))
            End If
            'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
            If objclass.IsNull(dr.Item("Price_Weight")) = "0" Then
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("ALL_WT")))))
            Else
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("Price_WeighT")))))
            End If
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Valuecost"))))
            TextBox32.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))


            ListView3.Items.Add(Trim(objclass.IsNull(dr.Item("item_id"))))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG")))
            ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_valuecost")))
        End While
        dr.Close()
        objclass.Execute3()
        objclass.Close3()





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
            'MsgBox("Image Don't Exist ", MsgBoxStyle.Information)
            'PictureBox1.Hide()
            'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information)
        End If

        Call List2()

        'objclass.ConnDb()
        'objclass.Open5()

        'objclass.Command5("select bedrnm from " & bedryf2 & " where bedrnr = '" + sDivision + "' order by bedrnm desc")

        'dr = objclass.OpenDataReader5
        'If dr.Read Then
        txtBranchCode.Text = sDivision
        txtbrname.Text = sDivisionname
        'End If
        'dr.Close()
        'objclass.Execute5()
        'objclass.Close5()

        If iRecorded = 1 Then
            DisplayAction(iAction_id, 1)
            'SelectUser(iCost_id)
            SelectAction(iAction_id)
            If iAction_id = objclass.action.Cellular Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            ElseIf iAction_id = objclass.action.Watch Then
                ComboBox5.SelectedIndex = -1
                ComboBox5.Enabled = False
            Else
                SelectClass(sSort_Code)
                If iStatus = objclass.status.costed Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.released Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.receivedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByMLWB Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByPRICING Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                ElseIf iStatus = objclass.status.releasedByDISTRI Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                End If
            End If
        Else
            If iStatus = objclass.status.sorting Then
                DisplayAction(iAction_id, 0)
                SelectAction(iAction_id)
                If iAction_id = objclass.action.Cellular Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                ElseIf iAction_id = objclass.action.Watch Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)
                End If
                'ComboBox3.Enabled = True
            ElseIf iStatus = objclass.status.released Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receiving Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.costed Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByPRICING Then
                If prcing = True Then
                    DisplayAction(iAction_id, 0)
                    SelectAction(iAction_id)
                    If iAction_id = objclass.action.Cellular Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    ElseIf iAction_id = objclass.action.Watch Then
                        ComboBox5.SelectedIndex = -1
                        ComboBox5.Enabled = False
                    Else
                        SelectClass(sSort_Code)
                    End If
                End If
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.receivedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByMLWB Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByPRICING Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = objclass.status.releasedByDISTRI Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            Else
                MsgBox(sStatus, MsgBoxStyle.Exclamation)
                Button13.Enabled = True
                Button2.Enabled = True
            End If
        End If
        'Button13.Enabled = True
        Button2.Enabled = True
        'If CDbl(Label43.Text) < CDbl(Label44.Text) Then
        '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical)
        'End If
        iRecorded = Nothing
        objclass = Nothing
        TextBox1.Focus()
    End Sub
    Private Sub DisplayAction(ByVal iselect As Integer, ByVal iRecorded As Integer)
        Dim dr As SqlDataReader
        Dim dCost1, dCost2, dCost3, dCost4, dCost5 As Double
        Dim ALLVALUE As Double

        Panels(False, False, False, False, False)
        dCostA = Nothing
        dCostB = Nothing
        dCostC = Nothing
        dCostD = Nothing

        objclass = New clsCommon
        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("select CostA, CostB, CostC, CostD from tbl_action where action_id = " + CStr(iselect))
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
            If iselect = objclass.action.OverAppraised Then
                objclass.Command3("select ALL_Wt, ALL_Karat,ALL_VALUE, ALL_ValueCost from tbl_receiving_detail where Dptn = " + TextBox15.Text + " and DAllbarcode ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.GoodStock Then
                objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost,ALL_VALUE, ALL_ValueCost from tbl_receiving_detail where Dptn = " + TextBox15.Text + " and DAllbarcode ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.TakenBack Then
                objclass.Command3("select ALL_VALUE,ALL_ValueCost from tbl_receiving_detail where Dptn = " + TextBox15.Text + " and DAllbarcode ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.Cellular Then
                objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_VALUE, ALL_ValueCost from tbl_receiving_detail where Dptn = " + TextBox15.Text + " and DAllbarcode ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.Watch Then
                objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_VALUE,ALL_ValueCost from tbl_receiving_detail where Dptn = " + TextBox15.Text + " and DAllbarcode ='" & Me.cboALL.Text & "'")
            End If
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                If iselect = objclass.action.OverAppraised Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Wt"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value"))))
                ElseIf iselect = objclass.action.GoodStock Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                    dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost")))))

                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                ElseIf iselect = objclass.action.TakenBack Then
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost"))))
                ElseIf iselect = objclass.action.Cellular Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost"))))
                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                ElseIf iselect = objclass.action.Watch Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost"))))
                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                End If
            End If
            dr.Close()
            'End If
            objclass.Close3()

        Else
            'If iRecorded = 1 Then

            If iselect = objclass.action.OverAppraised Then
                objclass.Command3("select ALL_Wt_dfor, ALL_Karat_dfor, all_value_dfor as all_value,ALL_ValueCost_dfor from tbl_forcedOutRcv_detail where  Allbarcode_dfor ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.GoodStock Then
                objclass.Command3("select Gold_Cost_dfor, Mount_Cost_dfor, YG_Cost_dfor, WG_Cost_dfor, all_value_dfor as all_value, ALL_ValueCost_dfor from tbl_forcedOutRcv_detail where Allbarcode_dfor ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.TakenBack Then
                objclass.Command3("select  all_value_dfor as all_value,ALL_ValueCost_dfor from tbl_forcedOutRcv_detail where allbarcode_dfor ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.Cellular Then
                objclass.Command3("select Cellular_Cost_dfor, Repair_Cost_dfor, Cleaning_Cost_dfor,  all_value_dfor as all_value,ALL_ValueCost_dfor from tbl_receiving_detail where Allbarcode_dfor ='" & Me.cboALL.Text & "'")
            ElseIf iselect = objclass.action.Watch Then
                objclass.Command3("select Watch_Cost_dfor, Repair_Cost_dfor, Cleaning_Cost_dfor, all_value_dfor as all_value, ALL_ValueCost_dfor from tbl_receiving_detail where Allbarcode_dfor ='" & Me.cboALL.Text & "'")
            End If
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                If iselect = objclass.action.OverAppraised Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Wt_dfor"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat_dfor"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost_dfor"))))
                    ' ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                ElseIf iselect = objclass.action.GoodStock Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost_dfor"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost_dfor"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost_dfor"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost_dfor"))))
                    dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost_dfor")))))
                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                ElseIf iselect = objclass.action.TakenBack Then
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost_dfor"))))
                ElseIf iselect = objclass.action.Cellular Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost_dfor"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost_dfor"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost_dfor"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost_dfor"))))
                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                ElseIf iselect = objclass.action.Watch Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost_dfor"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost_dfor"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost_dfor"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_ValueCost_dfor"))))
                    If sDB = "" Then
                        ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    End If

                End If
            End If
            dr.Close()
            'End If
            objclass.Close3()
        End If

        If iselect = objclass.action.OverAppraised Then
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
        ElseIf iselect = objclass.action.GoodStock Then
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
        ElseIf iselect = objclass.action.TakenBack Then
            Panels(False, False, False, False, True)
            If iRecorded = 1 Then
                TextBox27.Text = FormatNumber(dCost3)
                control(False)
            Else
                TextBox27.Text = FormatNumber(0)
                control(True)
            End If
        ElseIf iselect = objclass.action.Cellular Then
            Panels(False, False, False, True, False)
            'Button9.Visible = False
            Label34.Text = "Cellular Cost :"

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
        ElseIf iselect = objclass.action.Watch Then
            Panels(False, False, False, True, False)
            'Button9.Visible = False
            Label34.Text = "Watch Cost :"
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
        ElseIf iselect = objclass.action.Fake Or iselect = objclass.action.Coated Then
            'Panels(False, False, True, False, False)
        Else
            'Panels(False, False, False, False, False)
        End If

        dr = Nothing
        objclass = Nothing
    End Sub
    Private Function IsNull_Value(ByVal odata As Object) As Double
        If IsDBNull(odata) Then
            Return "0"
        Else
            Return CDbl(odata)
        End If
    End Function
    Private Sub List2()
        If ListView2.Items.Count = 1 Then
            Dim g, h, i As Integer
            For g = 0 To ListView2.Items.Count - 1
                Me.TextBox1.Text = ListView2.Items.Item(g).SubItems.Item(0).Text
                Me.TextBox4.Text = ListView2.Items.Item(g).SubItems.Item(1).Text
                Me.TextBox9.Text = ListView2.Items.Item(g).SubItems.Item(2).Text
                Me.TextBox12.Text = ListView2.Items.Item(g).SubItems.Item(3).Text
                Me.TextBox21.Text = ListView2.Items.Item(g).SubItems.Item(4).Text
                Me.TextBox30.Text = FormatNumber(ListView2.Items.Item(g).SubItems.Item(5).Text)

                'Me.TextBox1.Enabled = True
                'Me.TextBox4.Enabled = True
                'Me.TextBox9.Enabled = True
                'Me.TextBox12.Enabled = True
                'Me.TextBox18.Enabled = True
                'Me.TextBox21.Enabled = True
                'Me.TextBox30.Enabled = True

                Me.TextBox1.BackColor = Color.White
                Me.TextBox4.BackColor = Color.White
                Me.TextBox9.BackColor = Color.White
                Me.TextBox12.BackColor = Color.White
                Me.TextBox21.BackColor = Color.White
                Me.TextBox30.BackColor = Color.White
            Next
        Else
            'Me.TextBox1.Enabled = False
            Me.TextBox4.Enabled = False
            Me.TextBox9.Enabled = False
            Me.TextBox12.Enabled = False

            Me.TextBox21.Enabled = False
            Me.TextBox30.Enabled = False
        End If
    End Sub
    ' selects action class
    Private Sub SelectAction(ByVal iAction As Integer)
        Dim i, itemp As Integer
        For i = 0 To sAction.Length - 1
            itemp = CInt(sAction(i))
            If itemp = iAction Then
                ComboBox4.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub
    'selects sorting class
    Private Sub SelectClass(ByVal sClass As String)
        Dim i As Integer
        Dim sTemp As String
        For i = 0 To sSortClass.Length - 1
            sTemp = sSortClass(i)
            If sTemp = sClass Then
                ComboBox5.SelectedIndex = i
                Exit Sub
            End If
        Next
    End Sub
    Private Sub Panels(ByVal bPanel4 As Boolean, ByVal bPanel5 As Boolean, ByVal bPanel6 As Boolean, ByVal bPanel7 As Boolean, ByVal bPanel8 As Boolean)
        Panel4.Visible = bPanel4
        Panel5.Visible = bPanel5
        Panel6.Visible = bPanel6
        Panel7.Visible = bPanel7
        Panel8.Visible = bPanel8
    End Sub
    Private Sub control(ByVal bEnabled As Boolean)
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
    End Sub
    Private Sub trappedcost()
        If mountcost = "" Then
            mountcost = FormatNumber(0)
        End If
        If ygcost = "" Then
            ygcost = FormatNumber(0)
        End If
        If wgcost = "" Then
            wgcost = FormatNumber(0)
        End If
    End Sub

    Private Sub trappedcost2()
        If repaircost = "" Then
            repaircost = FormatNumber(0)
        End If
        If cleaningcost = "" Then
            cleaningcost = FormatNumber(0)
        End If
    End Sub
    Private Sub returnfocus1()
        If iFocus = 15 Then
            TextBox15.Text = ""
            TextBox15.Focus()
        ElseIf iFocus = 16 Then
            TextBox16.Text = ""
            TextBox16.Focus()
        End If
        iFocus = 0
    End Sub

    Private Sub cboALL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboALL.SelectedIndexChanged

    End Sub
    Private Sub Clear()
        Label43.Text = ""
        Label44.Text = ""
        Label45.Text = ""
        Label46.Text = ""
        Label47.Text = ""
        TextBox15.Text = ""
        TextBox16.Text = ""
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
        Label54.Text = ""
        TextBox29.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox1.SelectedText = ""
        ComboBox2.SelectedText = ""
        ListView1.Items.Clear()
        ListView3.Items.Clear()
        TextBox1.Text = ""
        TextBox4.Text = ""
        TextBox9.Text = ""
        TextBox12.Text = ""
        TextBox21.Text = ""
        TextBox30.Text = ""
        cboALL.Text = ""
        txtBranchCode.Text = ""
        txtbrname.Text = ""
        TextBox4.Enabled = False
        TextBox9.Enabled = False
        TextBox12.Enabled = False
        TextBox21.Enabled = False
        TextBox30.Enabled = False
        Button13.Enabled = False
        TextBox32.Text = ""
        PictureBox1.Image = Nothing
        PictureBox4.Image = Nothing
        'Panels(False, False, False, False, False)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Clear()
        Button13.Enabled = False
        Button2.Enabled = False
        cboALL.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            If RELStat = 3 Then
                Dim rply As Integer
                Dim objclass As New clsCommon
                rply = MsgBox("Are you sure you want to RELEASE?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                If rply = vbYes Then
                    objclass.ConnectionString1()
                    objclass.Open()

                    objclass.Command("if (select Count(*) as a from tbl_receiving_header where recallbarcode='" & Trim(cboALL.Text) & "' and sortaction_id in (4,3,8)  and status_id = 3) = 0 begin Update tbl_forcedoutrcv set recreleasingid_for='" & Trim(Me.lblEmpIDNo.Text) & "',recreleasingname_for='" & Trim(Me.lblName.Text) & "', releasedate_for=getdate(), forcedout_status_for= 4 where allbarcode_for='" & Trim(cboALL.Text) & "' and sortaction_id_for in (4,3,8)  and forcedout_status_for = 3 end else Update tbl_receiving_header set recreleasingid='" & Me.lblEmpIDNo.Text & "',recreleasingname='" & Me.lblName.Text & "', releasedate=getdate(), status_id= 4 where  recallbarcode='" & Trim(cboALL.Text) & "' and sortaction_id in (4,3,8)  and status_id = 3")
                    objclass.Execute()
                    objclass.Command("if (select Count(*) as a from rems.dbo.tbl_receiving_header where recallbarcode='" & Trim(cboALL.Text) & "' and sortaction_id in (4,3,8)  and status_id = 3) = 0 begin Update rems.dbo.tbl_forcedoutrcv set recreleasingid_for='" & Trim(Me.lblEmpIDNo.Text) & "',recreleasingname_for='" & Trim(Me.lblName.Text) & "', releasedate_for=getdate(), forcedout_status_for= 4 where allbarcode_for='" & Trim(cboALL.Text) & "' and sortaction_id_for in (4,3,8)  and forcedout_status_for = 3 end else Update rems.dbo.tbl_receiving_header set recreleasingid='" & Me.lblEmpIDNo.Text & "',recreleasingname='" & Me.lblName.Text & "', releasedate=getdate(), status_id= 4 where recallbarcode='" & Trim(cboALL.Text) & "'  and sortaction_id in (4,3,8)  and status_id = 3")
                    objclass.Execute()
                    objclass.Close()
                    objclass = Nothing

                    MsgBox("ITEMCODE successfully release to REM", MsgBoxStyle.Information)
                    Call Clear()
                    Button13.Enabled = False
                    Button2.Enabled = False
                    cboALL.Focus()
                Else
                    Call Clear()
                    Button13.Enabled = False
                    Button2.Enabled = False
                    cboALL.Focus()
                End If
            ElseIf RELStat >= 4 Then
                MsgBox("Already RELEASE in REM", MsgBoxStyle.Exclamation)
                Button13.Enabled = False
                'Button2.Enabled = False
                cboALL.Focus()
            ElseIf RELStat <= 2 Then
                MsgBox(" NOT yet COSTED ", MsgBoxStyle.Exclamation)
                Button13.Enabled = False
                'Button2.Enabled = False
                cboALL.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSaveMLWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMLWB.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        outsource = True
        Dim frm As New Report
        If outsource = False Then
            frm.Label2.Text = "Month"
            frm.TextBox1.Text = rellot
        End If
        frm.Label6.Visible = True
        frm.TextBox2.Visible = True
        frm.Text = "Releasing Report ASYS 3.1"
        recrelrep = False
        frm.Show()
    End Sub
End Class
