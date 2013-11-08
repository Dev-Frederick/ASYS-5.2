Imports System.Data.SqlClient
Imports System.IO
Public Class frmEditPricing
    Inherits System.Windows.Forms.Form
    Private picStrZoom As String
    Dim aydi As Integer
    Dim LocCur As String

#Region " private declarations "
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private sUserID, sAction, sSortClass, sGoldKarat As String()
    Private iDataEntry, iFocus As Integer
    Private sDivision, sDivisionname, iAction_id As String
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnForced As System.Windows.Forms.Button
    Friend WithEvents btnNorm As System.Windows.Forms.Button
    Friend WithEvents btnOUt As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboALL As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSaveMLWB As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtKarat As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtcarat As System.Windows.Forms.TextBox
    Friend WithEvents txtwt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPriceA As System.Windows.Forms.Label
    Friend WithEvents lblPriceB As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditPricing))
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSerialNo = New System.Windows.Forms.TextBox
        Me.txtwt = New System.Windows.Forms.TextBox
        Me.txtcarat = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.txtKarat = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.Label12 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox27 = New System.Windows.Forms.TextBox
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lblPriceB = New System.Windows.Forms.Label
        Me.lblPriceA = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.Button15 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.TextBox26 = New System.Windows.Forms.TextBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.btnForced = New System.Windows.Forms.Button
        Me.btnNorm = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOUt = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.cboALL = New System.Windows.Forms.ComboBox
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.btnSaveMLWB = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(152, 56)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(240, 20)
        Me.TextBox16.TabIndex = 5
        Me.TextBox16.Text = "TextBox16"
        Me.TextBox16.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 17)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "PTN"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(96, 56)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox2.TabIndex = 71
        Me.ComboBox2.Text = "ComboBox2"
        Me.ComboBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(144, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox1.TabIndex = 72
        Me.ComboBox1.Text = "ComboBox1"
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(152, 152)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox4.TabIndex = 37
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 154)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 24)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "ACTION"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "A.L.L. SORTING CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox15
        '
        Me.TextBox15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(144, 90)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(248, 20)
        Me.TextBox15.TabIndex = 2
        Me.TextBox15.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtSerialNo)
        Me.GroupBox3.Controls.Add(Me.txtwt)
        Me.GroupBox3.Controls.Add(Me.txtcarat)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.txtCost)
        Me.GroupBox3.Controls.Add(Me.txtKarat)
        Me.GroupBox3.Controls.Add(Me.txtQty)
        Me.GroupBox3.Controls.Add(Me.txtDesc)
        Me.GroupBox3.Controls.Add(Me.ListView2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(920, 168)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EDIT"
        '
        'txtSerialNo
        '
        Me.txtSerialNo.AcceptsReturn = True
        Me.txtSerialNo.AcceptsTab = True
        Me.txtSerialNo.BackColor = System.Drawing.Color.White
        Me.txtSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerialNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerialNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialNo.Location = New System.Drawing.Point(339, 80)
        Me.txtSerialNo.MaxLength = 25
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(127, 13)
        Me.txtSerialNo.TabIndex = 42
        Me.txtSerialNo.Text = ""
        '
        'txtwt
        '
        Me.txtwt.AcceptsReturn = True
        Me.txtwt.AcceptsTab = True
        Me.txtwt.BackColor = System.Drawing.Color.White
        Me.txtwt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtwt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwt.Location = New System.Drawing.Point(688, 80)
        Me.txtwt.MaxLength = 5
        Me.txtwt.Name = "txtwt"
        Me.txtwt.Size = New System.Drawing.Size(84, 13)
        Me.txtwt.TabIndex = 5
        Me.txtwt.Text = ""
        Me.txtwt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtcarat
        '
        Me.txtcarat.AcceptsReturn = True
        Me.txtcarat.AcceptsTab = True
        Me.txtcarat.BackColor = System.Drawing.Color.White
        Me.txtcarat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcarat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarat.Location = New System.Drawing.Point(610, 80)
        Me.txtcarat.MaxLength = 5
        Me.txtcarat.Name = "txtcarat"
        Me.txtcarat.Size = New System.Drawing.Size(76, 13)
        Me.txtcarat.TabIndex = 4
        Me.txtcarat.Text = ""
        Me.txtcarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.AcceptsTab = True
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(768, 128)
        Me.txtPrice.MaxLength = 10
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(144, 20)
        Me.txtPrice.TabIndex = 7
        Me.txtPrice.Text = ""
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCost
        '
        Me.txtCost.AcceptsReturn = True
        Me.txtCost.AcceptsTab = True
        Me.txtCost.BackColor = System.Drawing.Color.White
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCost.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(773, 80)
        Me.txtCost.MaxLength = 10
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(139, 13)
        Me.txtCost.TabIndex = 6
        Me.txtCost.Text = ""
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKarat
        '
        Me.txtKarat.AcceptsReturn = True
        Me.txtKarat.AcceptsTab = True
        Me.txtKarat.BackColor = System.Drawing.Color.White
        Me.txtKarat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKarat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKarat.Location = New System.Drawing.Point(534, 80)
        Me.txtKarat.MaxLength = 3
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.Size = New System.Drawing.Size(74, 13)
        Me.txtKarat.TabIndex = 3
        Me.txtKarat.Text = ""
        Me.txtKarat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQty
        '
        Me.txtQty.AcceptsReturn = True
        Me.txtQty.AcceptsTab = True
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(467, 80)
        Me.txtQty.MaxLength = 1
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(66, 13)
        Me.txtQty.TabIndex = 2
        Me.txtQty.Text = ""
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsReturn = True
        Me.txtDesc.AcceptsTab = True
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(10, 80)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(328, 13)
        Me.txtDesc.TabIndex = 1
        Me.txtDesc.Text = ""
        '
        'ListView2
        '
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader8, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Enabled = False
        Me.ListView2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 58)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(906, 40)
        Me.ListView2.TabIndex = 39
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "A.L.L. DESCRIPTION"
        Me.ColumnHeader12.Width = 331
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SERIAL NO."
        Me.ColumnHeader8.Width = 127
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "A.L.L. QTY"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 64
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "A.L.L. KARAT"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader14.Width = 76
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "A.L.L. CARAT"
        Me.ColumnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader15.Width = 78
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "A.L.L. WEIGHT"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 85
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "A.L.L. COST"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 143
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(696, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 24)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "A.L.L. PRICE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader11})
        Me.ListView1.Enabled = False
        Me.ListView1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(906, 72)
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
        Me.ColumnHeader3.Text = "DESCRIPTION"
        Me.ColumnHeader3.Width = 369
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY  "
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 41
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "KARAT    "
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CARAT     "
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "WEIGHT     "
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 78
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "COST                  "
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 138
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(768, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "CLEAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(848, 448)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "CLOSE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Panel8)
        Me.GroupBox4.Controls.Add(Me.Panel7)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.Location = New System.Drawing.Point(448, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(480, 256)
        Me.GroupBox4.TabIndex = 6
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
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblPriceB)
        Me.Panel7.Controls.Add(Me.lblPriceA)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.ComboBox6)
        Me.Panel7.Controls.Add(Me.Button15)
        Me.Panel7.Controls.Add(Me.Button14)
        Me.Panel7.Controls.Add(Me.PictureBox4)
        Me.Panel7.Controls.Add(Me.Label54)
        Me.Panel7.Controls.Add(Me.Label31)
        Me.Panel7.Controls.Add(Me.TextBox25)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.TextBox26)
        Me.Panel7.Controls.Add(Me.TextBox29)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Controls.Add(Me.GroupBox1)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(8, 8)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(464, 240)
        Me.Panel7.TabIndex = 65
        Me.Panel7.Visible = False
        '
        'lblPriceB
        '
        Me.lblPriceB.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPriceB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceB.Location = New System.Drawing.Point(256, 168)
        Me.lblPriceB.Name = "lblPriceB"
        Me.lblPriceB.Size = New System.Drawing.Size(80, 24)
        Me.lblPriceB.TabIndex = 139
        Me.lblPriceB.Text = "0.00"
        Me.lblPriceB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPriceA
        '
        Me.lblPriceA.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPriceA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPriceA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPriceA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPriceA.Location = New System.Drawing.Point(256, 136)
        Me.lblPriceA.Name = "lblPriceA"
        Me.lblPriceA.Size = New System.Drawing.Size(80, 24)
        Me.lblPriceA.TabIndex = 138
        Me.lblPriceA.Text = "0.00"
        Me.lblPriceA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "PRICE B"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "PRICE A"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(104, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 24)
        Me.Button1.TabIndex = 133
        Me.Button1.Text = "..."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 132
        Me.Label4.Text = "MOUNTED"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "GOLD KARAT"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.ItemHeight = 13
        Me.ComboBox6.Location = New System.Drawing.Point(104, 136)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox6.TabIndex = 130
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Enabled = False
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(400, 168)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(56, 24)
        Me.Button15.TabIndex = 104
        Me.Button15.Text = "CLEAR"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button14
        '
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.Enabled = False
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(400, 136)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(56, 24)
        Me.Button14.TabIndex = 105
        Me.Button14.Text = "CLEAR"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(112, 136)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 16)
        Me.Label54.TabIndex = 103
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(-208, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(145, 16)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "A.L.L Value :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox25.Location = New System.Drawing.Point(-120, 16)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(120, 23)
        Me.TextBox25.TabIndex = 101
        Me.TextBox25.Text = ""
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(-208, -8)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(145, 16)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Repair Cost :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox26.Location = New System.Drawing.Point(-120, 40)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(120, 23)
        Me.TextBox26.TabIndex = 100
        Me.TextBox26.Text = ""
        Me.TextBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox29
        '
        Me.TextBox29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(-120, -8)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(120, 23)
        Me.TextBox29.TabIndex = 102
        Me.TextBox29.Text = ""
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(-224, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(161, 16)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Cleaning Cost :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(-216, -32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(153, 32)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Cellular Cost :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 72)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURRENCY"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PHP"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "USD"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 104)
        Me.Label2.TabIndex = 129
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
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(8, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(344, 240)
        Me.Panel5.TabIndex = 61
        Me.Panel5.Visible = False
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(280, 192)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 23)
        Me.Button12.TabIndex = 987
        Me.Button12.TabStop = False
        Me.Button12.Text = "Clear"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button11
        '
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button11.Image = CType(resources.GetObject("Button11.Image"), System.Drawing.Image)
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(280, 168)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 23)
        Me.Button11.TabIndex = 989
        Me.Button11.TabStop = False
        Me.Button11.Text = "Clear"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button10
        '
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(280, 144)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(56, 23)
        Me.Button10.TabIndex = 990
        Me.Button10.TabStop = False
        Me.Button10.Text = "Clear"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button8
        '
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(224, 192)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(56, 23)
        Me.Button8.TabIndex = 991
        Me.Button8.TabStop = False
        Me.Button8.Text = "Cost D"
        '
        'Button7
        '
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(224, 168)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(56, 23)
        Me.Button7.TabIndex = 992
        Me.Button7.TabStop = False
        Me.Button7.Text = "Cost C"
        '
        'Button6
        '
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(224, 144)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(56, 23)
        Me.Button6.TabIndex = 993
        Me.Button6.TabStop = False
        Me.Button6.Text = "Cost B"
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(224, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 23)
        Me.Button5.TabIndex = 994
        Me.Button5.TabStop = False
        Me.Button5.Text = "Cost A"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label53.Location = New System.Drawing.Point(135, 216)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(81, 23)
        Me.Label53.TabIndex = 995
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label52.Location = New System.Drawing.Point(135, 192)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(81, 23)
        Me.Label52.TabIndex = 996
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label51.Location = New System.Drawing.Point(135, 168)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(81, 23)
        Me.Label51.TabIndex = 997
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label50.Location = New System.Drawing.Point(135, 144)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(81, 23)
        Me.Label50.TabIndex = 998
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label49.Location = New System.Drawing.Point(135, 120)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(81, 23)
        Me.Label49.TabIndex = 999
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(16, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 23)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "WG Cleaning Cost:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(16, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "YG Cleaning Cost:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(16, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 23)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Mount Cost:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(16, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 23)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Gold Cost:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(16, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 23)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "A.L.L Value:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button16)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(16, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 240)
        Me.Panel1.TabIndex = 140
        Me.Panel1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(184, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(120, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Button9
        '
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(296, 208)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(56, 24)
        Me.Button9.TabIndex = 104
        Me.Button9.Text = "CLEAR"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button16
        '
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Enabled = False
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.Location = New System.Drawing.Point(296, 184)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(56, 24)
        Me.Button16.TabIndex = 105
        Me.Button16.Text = "CLEAR"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 103
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "A.L.L. VALUE"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(200, 183)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 20)
        Me.TextBox1.TabIndex = 101
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 160)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "REPAIR COST"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(200, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(88, 20)
        Me.TextBox2.TabIndex = 100
        Me.TextBox2.Text = ""
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(200, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(88, 20)
        Me.TextBox3.TabIndex = 102
        Me.TextBox3.Text = ""
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(96, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "CLEANING COST"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "CELLULAR COST"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel4.Location = New System.Drawing.Point(8, 160)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(336, 88)
        Me.Panel4.TabIndex = 62
        Me.Panel4.Visible = False
        '
        'Button18
        '
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Enabled = False
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(264, 57)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(56, 23)
        Me.Button18.TabIndex = 25
        Me.Button18.Text = "CLEAR"
        '
        'Button19
        '
        Me.Button19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button19.Enabled = False
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(264, 33)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(56, 23)
        Me.Button19.TabIndex = 24
        Me.Button19.Text = "CLEAR"
        '
        'Button20
        '
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Enabled = False
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(208, 57)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(56, 23)
        Me.Button20.TabIndex = 23
        Me.Button20.Text = "COST C"
        '
        'Button21
        '
        Me.Button21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button21.Enabled = False
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(208, 33)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(56, 23)
        Me.Button21.TabIndex = 22
        Me.Button21.Text = "COST B"
        '
        'Button22
        '
        Me.Button22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button22.Enabled = False
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(208, 9)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(56, 23)
        Me.Button22.TabIndex = 21
        Me.Button22.Text = "COST A"
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(120, 56)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(88, 20)
        Me.TextBox17.TabIndex = 19
        Me.TextBox17.Text = ""
        Me.TextBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(24, 32)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 23)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "A.L.L. KARAT"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(24, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(88, 23)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "A.L.L. WEIGHT"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox23
        '
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(120, 32)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(88, 20)
        Me.TextBox23.TabIndex = 18
        Me.TextBox23.Text = ""
        Me.TextBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox24
        '
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox24.Location = New System.Drawing.Point(120, 8)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(88, 20)
        Me.TextBox24.TabIndex = 17
        Me.TextBox24.Text = ""
        Me.TextBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 23)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "A.L.L. VALUE"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(48, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(352, 95)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(608, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "SAVE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.Visible = False
        '
        'Button13
        '
        Me.Button13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(688, 448)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 40)
        Me.Button13.TabIndex = 8
        Me.Button13.Text = "SAVE"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label56
        '
        Me.Label56.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(16, 129)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(104, 24)
        Me.Label56.TabIndex = 118
        Me.Label56.Text = "BRANCH CODE"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBranchCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(152, 128)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.ReadOnly = True
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 13
        Me.txtBranchCode.Text = ""
        '
        'txtbrname
        '
        Me.txtbrname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbrname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbrname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbrname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrname.Location = New System.Drawing.Point(208, 128)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.ReadOnly = True
        Me.txtbrname.Size = New System.Drawing.Size(192, 20)
        Me.txtbrname.TabIndex = 14
        Me.txtbrname.Text = ""
        '
        'Label58
        '
        Me.Label58.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(16, 230)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(104, 16)
        Me.Label58.TabIndex = 120
        Me.Label58.Text = "A.L.L. BARCODE"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(440, 456)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 24)
        Me.Label43.TabIndex = 34
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Visible = False
        '
        'btnForced
        '
        Me.btnForced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForced.Enabled = False
        Me.btnForced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForced.Location = New System.Drawing.Point(400, 152)
        Me.btnForced.Name = "btnForced"
        Me.btnForced.Size = New System.Drawing.Size(32, 31)
        Me.btnForced.TabIndex = 122
        Me.btnForced.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnForced, "Cost Forced Received Items")
        Me.btnForced.Visible = False
        '
        'btnNorm
        '
        Me.btnNorm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNorm.Enabled = False
        Me.btnNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorm.Location = New System.Drawing.Point(400, 128)
        Me.btnNorm.Name = "btnNorm"
        Me.btnNorm.Size = New System.Drawing.Size(32, 31)
        Me.btnNorm.TabIndex = 123
        Me.btnNorm.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnNorm, "Cost Items Received from Replicated Data")
        Me.btnNorm.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
        '
        'btnOUt
        '
        Me.btnOUt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOUt.Enabled = False
        Me.btnOUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOUt.Location = New System.Drawing.Point(400, 176)
        Me.btnOUt.Name = "btnOUt"
        Me.btnOUt.Size = New System.Drawing.Size(32, 31)
        Me.btnOUt.TabIndex = 124
        Me.btnOUt.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnOUt, "Cost Outsource Items")
        Me.btnOUt.Visible = False
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
        Me.GroupBox6.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(432, 152)
        Me.GroupBox6.TabIndex = 125
        Me.GroupBox6.TabStop = False
        '
        'ComboBox5
        '
        Me.ComboBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Location = New System.Drawing.Point(144, 64)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox5.TabIndex = 38
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(144, 64)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(248, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'cboALL
        '
        Me.cboALL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboALL.ItemHeight = 13
        Me.cboALL.Location = New System.Drawing.Point(152, 224)
        Me.cboALL.MaxLength = 17
        Me.cboALL.Name = "cboALL"
        Me.cboALL.Size = New System.Drawing.Size(248, 21)
        Me.cboALL.TabIndex = 1
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
        Me.ListView3.Location = New System.Drawing.Point(16, 288)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(904, 40)
        Me.ListView3.TabIndex = 126
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Item ID"
        Me.ColumnHeader21.Width = 61
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
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Cleaning_Cost"
        Me.ColumnHeader25.Width = 111
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Gold_Cost"
        Me.ColumnHeader26.Width = 85
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Mount_Cost"
        Me.ColumnHeader27.Width = 88
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "YG_Cost"
        Me.ColumnHeader28.Width = 75
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "WG_Cost"
        Me.ColumnHeader29.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ALL_ValueCost"
        Me.ColumnHeader6.Width = 116
        '
        'btnSaveMLWB
        '
        Me.btnSaveMLWB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveMLWB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveMLWB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveMLWB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveMLWB.Image = CType(resources.GetObject("btnSaveMLWB.Image"), System.Drawing.Image)
        Me.btnSaveMLWB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveMLWB.Location = New System.Drawing.Point(688, 448)
        Me.btnSaveMLWB.Name = "btnSaveMLWB"
        Me.btnSaveMLWB.Size = New System.Drawing.Size(80, 40)
        Me.btnSaveMLWB.TabIndex = 127
        Me.btnSaveMLWB.Text = "Save"
        Me.btnSaveMLWB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmEditPricing
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(934, 503)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnOUt)
        Me.Controls.Add(Me.btnNorm)
        Me.Controls.Add(Me.btnForced)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.cboALL)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.btnSaveMLWB)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(944, 535)
        Me.MinimumSize = New System.Drawing.Size(944, 535)
        Me.Name = "frmEditPricing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM COSTING FORM"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim loc1 As String = Application.StartupPath
#Region " private sub "
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SearchFlag = False
            MountedPrice = 0
            photozoom = 0
            Me.CenterToScreen()
            Me.txtbrname.ReadOnly = True
            Me.txtbrname.BackColor = Color.White

            Dim dr As SqlDataReader
            Dim i As Integer

            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("select action_id, action_type from tbl_action where action_id in(1,2,3,4,5,6,7,8,9,10,11) order by action_type")
            dr = objclass.OpenDataReader5
            i = 0
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(Trim(UCase(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()

            '--- THIS IS FOR GOLD KARAT [START] -----
            objclass.Command5("SELECT GOLD_KARAT FROM ASYS_GOLDKARAT ORDER BY [ID]")
            dr = objclass.OpenDataReader5()
            While dr.Read
                ComboBox6.Items.Add(Trim(dr.Item("GOLD_KARAT")))
            End While
            dr.Close()
            objclass.Close5()
            '----- GOLD KARAT [END]------

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

            Button13.Enabled = False
            Button2.Enabled = False
            txtBranchCode.ReadOnly = True
            txtBranchCode.BackColor = Color.White
            If isedit = 1 Then
                RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                Exit Sub
            End If

            Call Clear()
            txtPrice.ReadOnly = True
            txtPrice.BackColor = Color.White
            Me.btnSaveMLWB.Enabled = False
            Me.Button14.Enabled = True
            Me.Button15.Enabled = True
            Panel7.Visible = True
            cboALL.Focus()
        Catch ex As Exception

        End Try
    End Sub
    Public Sub setptn(ByVal ptn1 As String)
        Try
            Dim ptn As String
            ptn1 = ptn
            TextBox15.Text = ptn
            TextBox15.Focus()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub SETIFEDIT(ByVal edited As String, ByVal txt As String, ByVal all As String)
        Try
            isedit = edited
            cboALL.Text = all
            TextBox15.Text = txt
            'MsgBox(isedit + txt)

        Catch ex As Exception

        End Try
    End Sub
    'displays or hides selected panels
    Private Sub Panels(ByVal bPanel4 As Boolean, ByVal bPanel5 As Boolean, ByVal bPanel6 As Boolean, ByVal bPanel7 As Boolean, ByVal bPanel8 As Boolean)
        Try

            Panel4.Visible = bPanel4
            Panel5.Visible = bPanel5
            'Panel6.Visible = bPanel6
            Panel1.Visible = bPanel7
            Panel7.Visible = bPanel8

        Catch ex As Exception

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

        End Try
    End Sub
    Private Sub PricingDisplayAction(ByVal iselect As String, ByVal iRecorded As Integer)
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

            'If iRecorded = 1 Then
            If iselect = "OverAppraised" Then
                objclass.Command3("select ALL_Wt, ALL_Karat, ALL_Cost from ASYS_Pricing_DEtail where ptn = " + TextBox15.Text + " ")
            ElseIf UCase(iselect) = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost, ALL_Cost from ASYS_Pricing_DEtail where refAllbarcode ='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')")
            ElseIf iselect = "TakenBack" Then
                objclass.Command3("select ALL_Cost from ASYS_Pricing_DEtail where ptn = " + TextBox15.Text + " and refAllbarcode ='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')")
            ElseIf iselect = "CELLULAR" Then
                objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_Pricing_DEtail where refAllbarcode ='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')")
            ElseIf iselect = "WATCH" Then
                objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_Pricing_DEtail where refAllbarcode ='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')")
            End If
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                If iselect = "OverAppraised" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Wt"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                ElseIf UCase(iselect) = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                    dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))

                    'If sDB = "" Then
                    '    ALLVALUE = Label44.Text
                    'End If

                ElseIf iselect = "TakenBack" Then
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                ElseIf iselect = "CELLULAR" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    If sDB = "" Then
                        ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    End If

                ElseIf iselect = "WATCH" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    If sDB = "" Then
                        ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    End If

                End If
            End If
            dr.Close()
            'End If
            objclass.Close3()

            If iselect = "OverAppraised" Then
                Panels(True, False, False, False, False)
                If iRecorded = 1 Then
                    TextBox24.Text = FormatNumber(dCost1)
                    TextBox23.Text = dCost2
                    TextBox17.Text = FormatNumber(dCost3)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = TextBox17.Text
                    If prcing = False Then
                        control(False)
                    Else
                        control(True)
                    End If

                Else
                    TextBox24.Text = FormatNumber(0)
                    TextBox23.Text = 0
                    TextBox17.Text = FormatNumber(0)
                    txtCost.Text = Label53.Text
                    control(True)
                End If
            ElseIf UCase(iselect) = "GOODSTOCK" Or iselect.ToUpper = "OUTSOURCE" Then
                Panels(False, False, False, False, True)
                Button5.Visible = False
                If iRecorded = 1 Then
                    Button5.Visible = True
                    Label49.Text = FormatNumber(dCost1)
                    Label50.Text = FormatNumber(dCost2)
                    Label51.Text = FormatNumber(dCost3)
                    Label52.Text = FormatNumber(dCost4)
                    Label53.Text = FormatNumber(dCost5)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = Label53.Text
                    If sDB = "" Then
                        Label53.Text = FormatNumber(ALLVALUE)
                    End If

                    If prcing = False Then
                        control(True)
                    Else
                        control(True)
                    End If

                Else
                    'Label49.Text = FormatNumber(CDbl(Label44.Text) + (CDbl(Label44.Text) * dCostA))
                    Label50.Text = FormatNumber(0)
                    Label51.Text = FormatNumber(0)
                    Label52.Text = FormatNumber(0)
                    Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
                    txtCost.Text = Label53.Text
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
            ElseIf iselect = "CELLULAR" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label11.Text = "CELLULAR COST "

                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label7.Text = FormatNumber(dCost1)
                    TextBox3.Text = FormatNumber(dCost2)
                    TextBox1.Text = FormatNumber(dCost3)
                    TextBox2.Text = FormatNumber(dCost4)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = TextBox2.Text
                    control(True)
                Else
                    'Label7.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox3.Text = FormatNumber(0)
                    TextBox1.Text = FormatNumber(0)
                    TextBox2.Text = Label7.Text
                    txtCost.Text = TextBox2.Text
                    control(True)
                End If
            ElseIf iselect = "WATCH" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label11.Text = "WATCH COST "
                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label7.Text = FormatNumber(dCost1)
                    TextBox3.Text = FormatNumber(dCost2)
                    TextBox1.Text = FormatNumber(dCost3)
                    TextBox2.Text = FormatNumber(dCost4)

                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = Label7.Text
                    control(True)

                Else
                    'Label7.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox3.Text = FormatNumber(0)
                    TextBox1.Text = FormatNumber(0)
                    TextBox2.Text = Label7.Text
                    txtCost.Text = TextBox2.Text
                    control(True)
                End If
            End If
            'Panel7.Enabled = False
            TextBox29.ReadOnly = False
            TextBox25.ReadOnly = False
            TextBox26.ReadOnly = False
            Button14.Enabled = True
            Button15.Enabled = True
            Button5.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False
            Button10.Enabled = False
            Button11.Enabled = False
            Button12.Enabled = False

            dr = Nothing
            objclass = Nothing

        Catch ex As Exception

        End Try
    End Sub
    'displays panels depending on what type of action is retrieve
    Private Sub MLWBDisplayAction(ByVal iselect As String, ByVal iRecorded As Integer)
        Try
            Dim dr As SqlDataReader
            Dim dCost1, dCost2, dCost3, dCost4, dCost5 As Double
            Dim ALLVALUE As Double

            If iselect = "OUTSOURCE" Then
                iselect = "GoodStock"
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

            'If iRecorded = 1 Then
            If iselect = "GoodStock" Or iselect.ToUpper = "OUTSOURCE" Then
                objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost, ALL_Cost from ASYS_MLWB_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'  and status <> 'RECPRICING'")
            ElseIf iselect = "Cellular" Then
                objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_MLWB_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'  and status <> 'RECPRICING'")
            ElseIf iselect = "Watch" Then
                objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_MLWB_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'  and status <> 'RECPRICING' ")
            End If
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                If iselect = "GoodStock" Or iselect.ToUpper = "OUTSOURCE" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                    dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))

                    'If sDB = "" Then
                    '    ALLVALUE = Label44.Text
                    'End If

                ElseIf iselect = "CELLULAR" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))

                    'If sDB = "" Then
                    '    ALLVALUE = Label44.Text
                    'End If

                ElseIf iselect = "WATCH" Then
                    dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                    dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                    dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                    dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    'If sDB = "" Then
                    '    ALLVALUE = Label44.Text
                    'End If

                End If
            End If

            dr.Close()
            'End If
            objclass.Close3()

            If iselect = "GoodStock" Or iselect.ToUpper = "OUTSOURCE" Then
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
                    'Label49.Text = FormatNumber(CDbl(Label44.Text) + (CDbl(Label44.Text) * dCostA))
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
            ElseIf iselect = "CELLULAR" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "CELLULAR COST:"

                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)
                    control(True)
                Else
                    'Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    control(True)
                End If
            ElseIf iselect = "WATCH" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "WATCH COST:"
                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)

                    control(True)

                Else
                    'Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    control(True)
                End If
            End If

            dr = Nothing
            objclass = Nothing

        Catch ex As Exception

        End Try
    End Sub
    Private Sub DisplayAction(ByVal iselect As String, ByVal iRecorded As Integer)
        Try
            Dim dr As SqlDataReader
            Dim dCost1, dCost2, dCost3, dCost4, dCost5 As Double
            Dim ALLVALUE As Double

            If iselect = "OUTSOURCE" Then
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
                If iselect = "OverAppraised" Then
                    objclass.Command3("select ALL_Wt, ALL_Karat, ALL_Cost from ASYS_REM_DEtail where ptn = " + TextBox15.Text + " and status <> 'RECMLWB'")
                ElseIf UCase(iselect) = "GOODSTOCK" Then
                    objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost, ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "TakenBack" Then
                    objclass.Command3("select ALL_Cost from ASYS_REM_DEtail where ptn = " + TextBox15.Text + " and refAllbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "CELLULAR" Then
                    objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "WATCH" Then
                    objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_REM_DEtail where refAllbarcode ='" & Me.cboALL.Text & "'and status <> 'RECMLWB'")
                End If
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    If iselect = "OverAppraised" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Wt"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    ElseIf UCase(iselect) = "GOODSTOCK" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                        dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))

                        'If sDB = "" Then
                        '    ALLVALUE = Label44.Text
                        'End If

                    ElseIf iselect = "TakenBack" Then
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    ElseIf iselect = "CELLULAR" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        End If

                    ElseIf iselect = "WATCH" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        End If

                    End If
                End If
                dr.Close()
                'End If
                objclass.Close3()

            Else
                'If iRecorded = 1 Then

                If iselect = "OverAppraised" Then
                    objclass.Command3("select ALL_Weight, ALL_Karat,ALL_Cost from ASYS_REMOutsource_detail where  refallbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf UCase(iselect) = "GOODSTOCK" Then
                    objclass.Command3("select Gold_Cost, Mount_Cost, YG_Cost, WG_Cost,  ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "TakenBack" Then
                    objclass.Command3("select  ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "CELLULAR" Then
                    objclass.Command3("select Cellular_Cost, Repair_Cost, Cleaning_Cost,ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                ElseIf iselect = "WATCH" Then
                    objclass.Command3("select Watch_Cost, Repair_Cost, Cleaning_Cost, ALL_Cost from ASYS_REMOutsource_detail where refallbarcode ='" & Me.cboALL.Text & "' and status <> 'RECMLWB'")
                End If
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    If iselect = "OverAppraised" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Weight"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        ' ALLVALUE = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Value")))))
                    ElseIf UCase(iselect) = "GOODSTOCK" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Gold_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Mount_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("YG_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("WG_Cost"))))
                        dCost5 = CStr(CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost")))))
                        If sDB = "" Then
                            ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        End If

                    ElseIf iselect = "TakenBack" Then
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    ElseIf iselect = "CELLULAR" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Cellular_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        End If

                    ElseIf iselect = "WATCH" Then
                        dCost1 = CDbl(Trim(objclass.IsNull(dr.Item("Watch_Cost"))))
                        dCost2 = CDbl(Trim(objclass.IsNull(dr.Item("Repair_Cost"))))
                        dCost3 = CDbl(Trim(objclass.IsNull(dr.Item("Cleaning_Cost"))))
                        dCost4 = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                        If sDB = "" Then
                            ALLVALUE = CDbl(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
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
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = TextBox17.Text
                    If prcing = False Then
                        control(False)
                    Else
                        control(True)
                    End If

                Else
                    TextBox24.Text = FormatNumber(0)
                    TextBox23.Text = 0
                    TextBox17.Text = FormatNumber(0)
                    txtCost.Text = Label53.Text
                    control(True)
                End If
            ElseIf UCase(iselect) = "GOODSTOCK" Then
                Panels(False, True, False, False, False)
                Button5.Visible = False
                If iRecorded = 1 Then
                    Button5.Visible = True
                    Label49.Text = FormatNumber(dCost1)
                    Label50.Text = FormatNumber(dCost2)
                    Label51.Text = FormatNumber(dCost3)
                    Label52.Text = FormatNumber(dCost4)
                    Label53.Text = FormatNumber(dCost5)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = Label53.Text
                    If sDB = "" Then
                        Label53.Text = FormatNumber(ALLVALUE)
                    End If

                    If prcing = False Then
                        control(True)
                    Else
                        control(True)
                    End If

                Else
                    'Label49.Text = FormatNumber(CDbl(Label44.Text) + (CDbl(Label44.Text) * dCostA))
                    Label50.Text = FormatNumber(0)
                    Label51.Text = FormatNumber(0)
                    Label52.Text = FormatNumber(0)
                    Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
                    txtCost.Text = Label53.Text
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
            ElseIf iselect = "CELLULAR" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "CELLULAR COST:"

                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = TextBox26.Text
                    control(True)
                Else
                    'Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label44.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    txtCost.Text = TextBox26.Text
                    control(True)
                End If
            ElseIf iselect = "WATCH" Then
                Panels(False, False, False, True, False)
                'Button9.Visible = False
                Label34.Text = "WATCH COST:"
                If iRecorded = 1 Then
                    'Button9.Visible = True
                    Label54.Text = FormatNumber(dCost1)
                    TextBox29.Text = FormatNumber(dCost2)
                    TextBox25.Text = FormatNumber(dCost3)
                    TextBox26.Text = FormatNumber(dCost4)

                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(5).Text = TextBox26.Text
                    control(True)

                Else
                    'Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label44.Text)))
                    TextBox29.Text = FormatNumber(0)
                    TextBox25.Text = FormatNumber(0)
                    TextBox26.Text = Label54.Text
                    txtCost.Text = TextBox26.Text
                    control(True)
                End If
            End If

            dr = Nothing
            objclass = Nothing

        Catch ex As Exception

        End Try
    End Sub
    'saves the provided costs and values of the ptn

    'updates the provided costs and values of the ptn



    'retrieves ptn and ptn barcode that are available for costing action
    Private Sub RetrievePTN_Barcode()
        Try
            Dim dr As SqlDataReader
            'Dim i As Double
            Dim dr2 As SqlDataReader
            Dim sptn, sptn_barcode, sBarcode As String
            Dim obj As New clsCommon
            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("SELECT dbo.ASYS_REM_Header.BranchCode, dbo.ASYS_REM_Header.BranchName, dbo.ASYS_REM_Header.PTN, dbo.ASYS_REM_Header.PTNBarcode, dbo.ASYS_REM_Detail.RefALLBarcode FROM  dbo.ASYS_REM_Detail INNER JOIN   dbo.ASYS_REM_Header ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN  where status = 'SORTED' and Actionclass in ('GoodStock','Watch','Cellular') and branchcode='" + txtBranchCode.Text + "'")
            dr = objclass.OpenDataReader()

            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            cboALL.Items.Clear()
            While dr.Read
                If Not (sptn Is "") Then
                    ComboBox1.Items.Add(CStr(objclass.IsNull(dr.Item("ptn"))))
                End If
                If Not (sptn_barcode Is "") Then
                    ComboBox2.Items.Add(CStr(objclass.IsNull(dr.Item("ptnbarcode"))))
                End If
                If Not (sBarcode Is "") Then
                    cboALL.Items.Add(CStr(Trim(objclass.IsNull(dr.Item("refAllBarcode")))))
                End If
            End While
            dr.Close()
            objclass.Close()
            objclass = Nothing


        Catch ex As Exception

        End Try

    End Sub
    'clear all text information
    Private Sub Clear()
        Try
            Dim objGold As New clsCommon
            Dim drGold As SqlDataReader
            LocCur = ""
            Label43.Text = ""
            'Label44.Text = ""
            'Label45.Text = ""
            'Label46.Text = ""
            'Label47.Text = ""
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
            Label7.Text = ""
            TextBox3.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""

            ComboBox6.Text = ""

            ''''ComboBox6.Items.Clear()
            '''''--- THIS IS FOR GOLD KARAT [START] -----
            ''''objGold.Connectionstring3()
            ''''objGold.Open3()
            ''''objGold.Command3("SELECT GOLD_KARAT FROM ASYS_GOLDKARAT ORDER BY [ID]")
            ''''drGold = objGold.OpenDataReader3()
            ''''While drGold.Read
            ''''    ComboBox6.Items.Add(Trim(drGold.Item("GOLD_KARAT")))
            ''''End While
            ''''drGold.Close()
            ''''objGold.Close3()
            '''''----- GOLD KARAT [END]------

            ''''ComboBox6.SelectedIndex = -1

            ''''ComboBox6.SelectedIndex = -1
            ComboBox1.SelectedText = ""
            ComboBox2.SelectedText = ""
            ListView1.Items.Clear()
            ListView3.Items.Clear()
            txtDesc.Text = ""
            txtSerialNo.Text = ""
            txtQty.Text = ""
            txtKarat.Text = ""
            txtcarat.Text = ""
            txtwt.Text = ""
            txtCost.Text = ""
            cboALL.Text = ""
            txtBranchCode.Text = ""
            txtbrname.Text = ""
            lblPriceA.Text = "0.00"
            lblPriceB.Text = "0.00"

            txtDesc.Enabled = False
            txtSerialNo.Enabled = False
            txtQty.Enabled = False
            txtKarat.Enabled = False
            txtcarat.Enabled = False
            txtCost.Enabled = False
            txtwt.Enabled = False
            Button13.Enabled = False
            txtPrice.Text = ""
            PictureBox1.Image = Nothing
            PictureBox4.Image = Nothing
            PictureBox2.Image = Nothing

            '-- clear array list --
            ArrGold.Clear()
            ArrDia.Clear()
            ArrPearl.Clear()
            ArrPrecious.Clear()
            ArrSynthetic.Clear()
            ArrMountedTotal.Clear()
            'Panels(False, False, False, False, False)

        Catch ex As Exception

        End Try
    End Sub
    'retrieves ptn information from tbl_pt_tran, tlb_ptn_item
    Private Sub RetrieveInfoRet(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Try
            Dim dr As SqlDataReader
            Dim sMPTN As String
            Dim iCost_id, iItem_id As Integer
            Dim iRecorded As Integer
            Dim sStatus, sort_code, iStatus, sSort_Code, picStr As String
            Dim img As Drawing.Image
            Dim obj As New clsCommon

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime



            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select 0 as st,photoname as photo,itemid ,costdate as cost_id,actionclass,sortcode,  status from ASYS_REMOutsource_detail where  refALLBarcode='" & Me.cboALL.Text & "' and status in ('RECEIVED','COSTED')")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                st = dr.Item("st")
                If IsDBNull(dr.Item("cost_id")) Then
                    iRecorded = 0
                Else
                    iRecorded = 1
                    'iCost_id = CInt(dr.Item("cost_id"))
                End If
                iItem_id = dr.Item("itemid")
                iRecord = iRecorded
                picStr = Trim(objclass.IsNull(dr.Item("photo")))
                iStatus = Trim(dr.Item("status"))

                If iStatus = "SORTED" Then
                    sStatus = "PTN received and sorted"
                ElseIf iStatus = "RELEASED" Then
                    sStatus = "PTN released"
                ElseIf iStatus = "COSTED" Then
                    sStatus = "PTN Already Costed"
                End If

                txtDesc.Enabled = True
                txtDesc.Focus()
                ComboBox4.Text = UCase(dr.Item("actionclass"))
                iAction_id = ComboBox4.SelectedIndex + 1
                sSort_Code = Trim(objclass.IsNull(dr.Item("sortcode")))

            Else
                iStatus = 0
                sStatus = "Item not received or already released"
            End If
            dr.Close()
            'objclass.Close3()

            'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
            objclass.Command3("select itemid,ptn,ptnbarcode,branchcode,branchname,loanvalue,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,all_desc,SerialNo,all_karat,all_carat,all_weight,currency,all_cost,photoname,all_price,appraisevalue,cellular_cost,watch_cost,repair_cost,cleaning_cost,gold_cost,mount_cost,yg_cost,wg_cost,status from ASYS_REMOutsource_detail where refallbarcode='" & Me.cboALL.Text & "' and status in ('RECEIVED','COSTED')")
            dr = objclass.OpenDataReader3()
            If dr.Read Then
                picStr = objclass.IsNull(dr.Item("photoname"))
                txtBranchCode.Text = Trim(objclass.IsNull(dr.Item("branchcode")))
                txtbrname.Text = Trim(objclass.IsNull(dr.Item("branchname")))
                sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
                Label43.Text = FormatNumber(objclass.IsNull(dr.Item("appraisevalue")))
                'Label44.Text = FormatNumber(objclass.IsNull(dr.Item("loanvalue")))
                TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))

                If Trim(objclass.IsNull(dr.Item("currency"))) = "PHP" Then
                    RadioButton2.Checked = True
                ElseIf Trim(objclass.IsNull(dr.Item("currency"))) = "USD" Then
                    RadioButton1.Checked = True
                End If

                ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("itemid"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("itemcode"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("karatgrading"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("caratsize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("weight"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SerialNo"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_karat"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_carat"))))
                'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Weight"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_cost"))))

                ListView3.Items.Add(Trim(dr.Item("itemid")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_cost")))
                txtPrice.Text = FormatNumber(objclass.IsNull(dr.Item("all_price")))

                txtDesc.Enabled = True
                txtDesc.Focus()
                If iStatus <> "RECEIVED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information, "ASYS 3.1 Item Costing")
                End If
            Else
                MsgBox("Item not found or already released.", MsgBoxStyle.Information, TitleMsgBox)
                objclass.Close()
                returnfocus1()
                Exit Sub
            End If
            dr.Close()


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
                'MsgBox("Image Don't Exist ", MsgBoxStyle.Information)
                'PictureBox1.Hide()
                'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information)
            End If


            Call List2()

            'objclass.ConnDb()
            'objclass.Open5()

            'If UCase(sDB) = "" Then
            '    objclass.Command5("select bedrnm from " & bedryf2 & " where bedrnr = '" + sDivision + "'")
            '    dr = objclass.OpenDataReader5
            '    If dr.Read Then
            '        txtBranchCode.Text = sDivision
            '        txtbrname.Text = Trim(objclass.IsNull(dr.Item("bedrnm")))
            '    Else
            '        txtBranchCode.Text = "0"
            '        txtbrname.Text = "NONE"
            '    End If
            '    dr.Close()
            '    objclass.Execute5()
            '    objclass.Close5()
            'End If


            If iRecorded = 1 Then
                DisplayAction(ComboBox4.Text, 1)
                'SelectUser(iCost_id)
                'SelectAction(iAction_id)
                If ComboBox5.Text = "Cellular" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                ElseIf ComboBox5.Text = "Watch" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)

                    'MsgBox(sStatus, MsgBoxStyle.Information)
                End If
            Else
                If iStatus = "SORTED" Or iStatus = "RECEIVED" Or iStatus = "COSTED" Then
                    DisplayAction(ComboBox4.Text, 1)
                    'SelectAction(iAction_id)
                    If ComboBox5.Text = "Cellular" Then
                        ComboBox5.Text = "Others"
                        ComboBox5.Enabled = False
                    ElseIf ComboBox5.Text = "Watch" Then
                        ComboBox5.Text = "Others"
                        ComboBox5.Enabled = False
                    Else
                        SelectClass(sSort_Code)
                    End If
                    'ComboBox3.Enabled = True
                ElseIf iStatus = "RELEASED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECEIVED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "COSTED" Then
                    MsgBox(sStatus, MsgBoxStyle.Information)
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECMLWB" Then
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
            picStrZoom = picStr
            txtDesc.Focus()
            iRecorded = Nothing
            objclass = Nothing

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RetrieveInfo(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Try
            Dim dr As SqlDataReader
            Dim sMPTN As String
            Dim iCost_id, iItem_id As Integer
            Dim iRecorded As Integer
            Dim sStatus, sort_code, iStatus, sSort_Code, picStr As String
            Dim img As Drawing.Image
            Dim obj As New clsCommon

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime

            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("If (Select Count(refallbarcode) from ASYS_REM_Detail  where refALLBarcode='" & Me.cboALL.Text & "')<> 0 begin select 1 as st,photoname as photo,itemID ,costdate as cost_id,actionclass,sortcode, status  from ASYS_REM_Detail  where  refALLBarcode='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECMLWB') end else select 0 as st,photoname as photo,itemid ,costdate as cost_id,actionclass,sortcode,  status from ASYS_REMOutsource_detail  where  refALLBarcode='" & Me.cboALL.Text & "' and status not in ('RELEASED','RECMLWB')")
            dr = objclass.OpenDataReader3
            If dr.Read Then
                st = dr.Item("st")
                'If IsDBNull(dr.Item("cost_id")) Then
                '    iRecorded = 0
                'Else
                '    iRecorded = 1
                '    'iCost_id = CInt(dr.Item("cost_id"))
                'End If
                iItem_id = dr.Item("itemid")
                iRecord = iRecorded
                picStr = Trim(objclass.IsNull(dr.Item("photo")))
                iStatus = Trim(dr.Item("status"))

                If iStatus = "SORTED" Then
                    sStatus = "PTN sorted"
                    iRecorded = 0
                ElseIf iStatus = "RELEASED" Then
                    sStatus = "PTN released"
                    iRecorded = 1
                ElseIf iStatus = "COSTED" Then
                    sStatus = "PTN Costed"
                    iRecorded = 1
                ElseIf iStatus = "RECEIVED" Then
                    sStatus = "PTN received"
                    iRecorded = 0
                Else
                    sStatus = "RECEIVED IN MLWB"
                    iRecorded = 1
                End If

                txtDesc.Enabled = True
                txtDesc.Focus()
                ComboBox4.Text = UCase(dr.Item("actionclass"))
                iAction_id = ComboBox4.SelectedIndex + 1
                sSort_Code = Trim(objclass.IsNull(dr.Item("sortcode")))
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
                'objclass.Command("select * from tbl_pt_tran where ptn = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                obj.Command("select branchcode,branchname,ptn,ptnbarcode,loanvalue,maturitydate,expirydate,loandate from ASYS_REM_Header  where ptn = '" + sPTN + "'")
                dr = obj.OpenDataReader()
                If dr.Read Then
                    txtBranchCode.Text = Trim(dr.Item("branchcode"))
                    txtbrname.Text = dr.Item("branchname")
                    'Label44.Text = FormatNumber(dr.Item("loanvalue"))
                    'Label45.Text = Trim(CStr(dr.Item("LoanDate")))
                    'Label46.Text = Trim(CStr(dr.Item("MaturityDate")))
                    'Label47.Text = Trim(CStr(dr.Item("ExpiryDate")))
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                    TextBox15.Text = Trim(dr.Item("ptn"))
                Else
                    MsgBox("Item not found.", MsgBoxStyle.Information, TitleMsgBox)
                    obj.Close()
                    returnfocus1()
                    Exit Sub
                End If
                dr.Close()
                obj.Close()
                'objclass.CloseDataReader()

                objclass.Command3("select itemid,refallbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,all_desc,SerialNo,all_karat,all_carat,all_weight,currency,all_cost,photoname,all_price,cellular_cost,watch_cost,repair_cost,cleaning_cost,Gold_cost,mount_cost,yg_cost,wg_cost,appraisevalue from ASYS_REM_Detail  where refALLBarcode = '" & AllBar & "'")
                dr = objclass.OpenDataReader3()
                ListView1.Items.Clear()
                ListView2.Items.Clear()
                ListView3.Items.Clear()
                If dr.Read Then
                    If Trim(objclass.IsNull(dr.Item("currency"))) = "PHP" Then
                        RadioButton2.Checked = True
                    ElseIf Trim(objclass.IsNull(dr.Item("currency"))) = "USD" Then
                        RadioButton1.Checked = True
                    End If
                    ListView1.Items.Add(Trim(dr.Item("itemid")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("itemcode"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("caratsize"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("weight"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("1")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SerialNo"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_carat"))))
                    'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_weight"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Cost"))))
                    txtPrice.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))

                    ListView3.Items.Add(Trim(dr.Item("itemid")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_cost")))
                    Label43.Text = FormatNumber(objclass.IsNull(dr.Item("appraisevalue")))
                End If
                dr.Close()
                objclass.Execute3()
                objclass.Close3()
            Else
                'objclass.Command("select * from tbl_pt_tran where ptn_barcode = " + sPTN + " and transtype <> 'LUKAT' and pulloutstocks = 1")
                objclass.Command3("select itemid,ptn,ptnbarcode,branchcode,branchname,loanvalue,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,all_desc,SerialNo,all_karat,all_carat,all_weight,all_cost,photoname,all_price,appraisevalue,cellular_cost,watch_cost,repair_cost,cleaning_cost,gold_cost,mount_cost,yg_cost,wg_cost,status from ASYS_REMOutsource_detail  where refallbarcode='" & Me.cboALL.Text & "'")
                dr = objclass.OpenDataReader3()
                If dr.Read Then
                    picStr = objclass.IsNull(dr.Item("photoname"))
                    sDivision = Trim(objclass.IsNull(dr.Item("branchcode")))
                    sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
                    Label43.Text = FormatNumber(objclass.IsNull(dr.Item("appraisevalue")))
                    'Label44.Text = FormatNumber(objclass.IsNull(dr.Item("loanvalue")))
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                    TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))

                    ListView1.Items.Add(Trim(objclass.IsNull(dr.Item("itemid"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("itemcode"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("caratsize"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("weight"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("1")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SerialNo"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_carat"))))
                    'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass_dfor"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Weight"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_cost"))))

                    ListView3.Items.Add(Trim(dr.Item("itemid")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("ALL_cost")))

                    txtDesc.Enabled = True
                    txtDesc.Focus()
                Else
                    MsgBox("Item not found.", MsgBoxStyle.Information, TitleMsgBox)
                    objclass.Close()
                    returnfocus1()
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
                'MsgBox("Image Don't Exist ", MsgBoxStyle.Information)
                'PictureBox1.Hide()
                'MsgBox("Image Don't Exist,Please Check Id ", MsgBoxStyle.Information)
            End If


            Call List2()

            objclass.ConnDb()
            objclass.Open5()

            If UCase(sDB) = "" Then
                objclass.Command5("select bedrnm from " & bedryf2 & " where bedrnr = '" + sDivision + "'")
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    txtBranchCode.Text = sDivision
                    txtbrname.Text = Trim(objclass.IsNull(dr.Item("bedrnm")))
                Else
                    txtBranchCode.Text = "0"
                    txtbrname.Text = "NONE"
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
            End If


            If iRecorded = 1 Then
                DisplayAction(ComboBox4.Text, 1)
                'SelectUser(iCost_id)
                'SelectAction(iAction_id)
                If ComboBox5.Text = "Cellular" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                ElseIf ComboBox5.Text = "Watch" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)

                    'MsgBox(sStatus, MsgBoxStyle.Information)
                End If
            End If
            If iStatus = "SORTED" Or iStatus = "RECEIVED" Then
                DisplayAction(ComboBox4.Text, 0)
                'SelectAction(iAction_id)
                If ComboBox5.Text = "Cellular" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                ElseIf ComboBox5.Text = "Watch" Then
                    ComboBox5.Text = "Others"
                    ComboBox5.Enabled = False
                Else
                    SelectClass(sSort_Code)
                End If
                'ComboBox3.Enabled = True
            ElseIf iStatus = "RELEASED" Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = "RECEIVED" Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = "COSTED" Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            ElseIf iStatus = "RECMLWB" Then
                MsgBox(sStatus, MsgBoxStyle.Information)
                Button13.Enabled = False
                Button2.Enabled = True
            Else
                MsgBox(sStatus, MsgBoxStyle.Exclamation)
                Button13.Enabled = True
                Button2.Enabled = True
            End If
            'Button13.Enabled = True
            Button2.Enabled = True
            'If CDbl(Label43.Text) < CDbl(Label44.Text) Then
            '    MsgBox("Warning!-Over Appraisal", MsgBoxStyle.Critical)
            'End If
            picStrZoom = picStr
            txtDesc.Focus()
            iRecorded = Nothing
            objclass = Nothing

        Catch ex As Exception

        End Try
    End Sub
    Private Sub RetrieveInfo1(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Try
            Dim dr As SqlDataReader
            Dim sMPTN As String
            Dim iCost_id, iItem_id, ibarcode As Integer
            Dim icostname, iStatus, SQuery As String
            Dim iRecorded As String
            Dim newstatus As Integer
            Dim sStatus, sort_code, sSort_Code, picStr As String
            Dim img As Drawing.Image

            Dim objGold As New clsCommon
            Dim drGold As SqlDataReader

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime

            ListView1.Items.Clear()
            ListView2.Items.Clear()

            objclass.Connectionstring3()
            objclass.Open3()
            SQuery = "SELECT RefLotno, RefallBarcode, PTN, ItemID, PTNBarcode, BranchCode, BranchName, Loanvalue, RefItemcode, Itemcode, BranchItemDesc, RefQty, Qty,"
            SQuery = SQuery + "  KaratGrading, CaratSize, Weight,Actionclass,Sortcode, ALL_desc,SerialNo, ALL_karat, ALL_carat, ALL_Cost, ALL_Weight,currency, PhotoName,all_price,price_DESC,price_karat,price_carat,price_weight, Cellular_cost, Watch_cost, Repair_cost,"
            SQuery = SQuery + "  Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, LoanDate, Status, GoldKaratPrice, MountedPrice, Gold_Karat"
            SQuery = SQuery + "  FROM dbo.ASYS_PRicing_detail where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')"

            objclass.Command3(SQuery)
            dr = objclass.OpenDataReader3
            If dr.Read Then

                iItem_id = dr.Item("ItemID")
                picStr = objclass.IsNull(dr.Item("photoname"))
                iStatus = Trim(objclass.IsNull(dr.Item("status")))

                txtBranchCode.Text = Trim(objclass.IsNull(dr.Item("branchcode")))
                txtbrname.Text = Trim(objclass.IsNull(dr.Item("branchname")))
                sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
                'Label44.Text = FormatNumber(objclass.IsNull(dr.Item("LoanValue")))
                'Label46.Text = objclass.IsNull(dr.Item("Maturitydate"))
                'Label47.Text = objclass.IsNull(dr.Item("Expirydate"))
                ComboBox4.Text = UCase(dr.Item("actionclass"))
                ComboBox5.Text = dr.Item("sortcode")

                If Trim(objclass.IsNull(dr.Item("Gold_Karat"))) = "0" Then
                    ComboBox6.Items.Clear()

                    '--- THIS IS FOR GOLD KARAT [START] -----
                    objGold.Connectionstring3()
                    objGold.Open3()
                    objGold.Command3("SELECT GOLD_KARAT FROM ASYS_GOLDKARAT ORDER BY [ID]")
                    drGold = objGold.OpenDataReader3()
                    While drGold.Read
                        ComboBox6.Items.Add(Trim(drGold.Item("GOLD_KARAT")))
                    End While
                    drGold.Close()
                    objGold.Close3()
                    '----- GOLD KARAT [END]------

                    ComboBox6.SelectedIndex = -1
                Else
                    ComboBox6.Text = dr.Item("Gold_Karat")
                End If

                'ComboBox6.Text = dr.Item("Gold_Karat") & ""
                TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))

                If Trim(objclass.IsNull(dr.Item("GoldKaratPrice"))) = "0" Then
                    lblPriceA.Text = "0.00"
                Else
                    lblPriceA.Text = Format(dr.Item("GoldKaratPrice"), "#,###,##0.00")
                End If

                If Trim(objclass.IsNull(dr.Item("MountedPrice"))) = "0" Then
                    lblPriceB.Text = "0.00"
                Else
                    lblPriceB.Text = Format(dr.Item("MountedPrice"), "#,###,##0.00")
                End If


                If Trim(objclass.IsNull(dr.Item("currency"))) = "PHP" Then
                    RadioButton2.Checked = True
                ElseIf Trim(objclass.IsNull(dr.Item("currency"))) = "USD" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True
                End If

                ListView1.Items.Add(Trim(objclass.IsNull(CStr(dr.Item("itemid")))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Karatgrading"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Caratsize"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("price_desc"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SerialNo"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_karat"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("price_carat"))))

                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("price_weight")))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))
                txtCost.Text = FormatNumber(IsNull_Value(dr.Item("all_cost")))
                txtPrice.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))


                ListView3.Items.Add(Trim(objclass.IsNull(dr.Item("itemid"))))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("all_cost")))

                txtDesc.Enabled = True
                txtDesc.Focus()
            Else
                MsgBox("Item not found in Pricing.", MsgBoxStyle.Information, TitleMsgBox)
                Button13.Enabled = False
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            End If
            dr.Close()
            'objclass.Execute3()
            objclass.Close3()

            Call List2()

            If File.Exists(picStr) Then
                img = img.FromFile(picStr)
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img
                PictureBox2.Image = img
            Else

                img = img.FromFile(loc1 & "\" & "questionmark2" & ".jpg")
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img
                PictureBox2.Image = img

            End If



            If iStatus.ToUpper = "RECEIVED" Or iStatus = "PRICED" Then
                PricingDisplayAction(ComboBox4.Text, 1)
                If iAction_id = "CELLULAR" Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                ElseIf iAction_id = "WATCH" Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                End If
                If iStatus = "PRICED" Then
                    MsgBox("Item already priced.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            Else
                If iStatus = "RELEASED" Then
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECEIVED" Then
                    Button13.Enabled = False
                    Button2.Enabled = True
                Else
                    MsgBox(sStatus, MsgBoxStyle.Exclamation)
                    Button13.Enabled = True
                    Button2.Enabled = True
                End If
            End If
            picStrZoom = picStr
            Button2.Enabled = True
            iRecorded = Nothing
            objclass = Nothing
            txtDesc.Focus()

        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub
    'validates data, if null returns a 0 else returns number
    Private Function IsNull_Value(ByVal odata As Object) As Double
        Try
            If IsDBNull(odata) Then
                Return "0"
            Else
                Return CDbl(odata)
            End If
        Catch ex As Exception

        End Try
    End Function
    Private Sub List2()
        Try
            If ListView2.Items.Count = 1 Then
                Dim g, h, i As Integer

                Me.txtDesc.Text = ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(0).Text
                Me.txtSerialNo.Text = ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Item(1).Text
                Me.txtQty.Text = ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Item(2).Text
                Me.txtKarat.Text = ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Item(3).Text
                Me.txtcarat.Text = ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Item(4).Text
                Me.txtwt.Text = ListView2.Items.Item(ListView2.Items.Count - 1).SubItems.Item(5).Text
                Me.txtCost.Text = FormatNumber(ListView2.Items(ListView2.Items.Count - 1).SubItems.Item(6).Text)

                'Me.TextBox1.Enabled = True
                'Me.txtqty.enabled = True
                'Me.txtkarat.enabled = True
                'Me.txtcarat.enabled = True
                'Me.TextBox18.Enabled = True
                'Me.txtwt.enabled = True
                'Me.txtcost.Enabled = True

                Me.txtDesc.BackColor = Color.White
                Me.txtSerialNo.BackColor = Color.White
                Me.txtQty.BackColor = Color.White
                Me.txtKarat.BackColor = Color.White
                Me.txtcarat.BackColor = Color.White
                Me.txtwt.BackColor = Color.White
                ' Me.txtCost.BackColor = Color.White

            Else
                'Me.TextBox1.Enabled = False
                Me.txtSerialNo.Enabled = False
                Me.txtQty.Enabled = False
                Me.txtKarat.Enabled = False
                Me.txtcarat.Enabled = False

                Me.txtwt.Enabled = False
                Me.txtCost.Enabled = False
            End If

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
    'selects sorting class
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

        End Try
    End Sub

    Private Sub returnfocus()
        Try
            If iFocus = 15 Then
                TextBox15.Focus()
            ElseIf iFocus = 16 Then
                TextBox16.Focus()
            End If
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
            iFocus = 0

        Catch ex As Exception

        End Try
    End Sub
    'calculates the provided cost of cleaning, repair, yg and wg cost
    Private Sub Calculate()
        Try
            Dim dRprCost As Double = 0
            Dim dClnCost As Double = 0
            If TextBox29.Text = "" Then
                dRprCost = 0
            Else
                If IsNumeric(TextBox29.Text) Then
                    dRprCost = CDbl(TextBox29.Text)
                Else
                    TextBox26.Text = FormatNumber(CDbl(Label54.Text) + dRprCost)
                    Exit Sub
                End If
            End If
            If TextBox25.Text = "" Then
                dClnCost = 0
            Else
                If IsNumeric(TextBox25.Text) Then
                    dClnCost = CDbl(TextBox25.Text)
                Else
                    TextBox26.Text = FormatNumber(CDbl(Label54.Text) + dClnCost + dRprCost)
                    Exit Sub
                End If
            End If
            TextBox26.Text = FormatNumber(CDbl(Label54.Text) + dRprCost + dClnCost)

        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region " control attributes "

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim frm As New frmPhotoZoom
            frm.Close()
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            iFocus = 15
            TextBox15.Text = Trim(ComboBox1.SelectedItem)
            'TextBox16.Text = sPTNBarcode(ComboBox1.SelectedIndex)
            RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
            TextBox15.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectionChangeCommitted
        Try
            iFocus = 16
            TextBox16.Text = ComboBox2.SelectedItem
            'TextBox15.Text = s_PTN(ComboBox2.SelectedIndex)
            RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
            TextBox16.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim a As Integer

            obj = New clsCommon
            obj.ConnectionString1()
            obj.Open()

            'If nonNumberEntered = True Then
            '    e.Handled = True
            'End If
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If Me.TextBox15.Text.Length > 11 And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If TextBox15.Text.Trim = "" Then
                    MsgBox("Select a PTN", MsgBoxStyle.Information)
                    TextBox15.Text = ""
                    TextBox15.Focus()
                ElseIf IsNumeric(TextBox15.Text) Then
                    iFocus = 15
                    obj.Command("Select * from ASYS_REM_Header where recptn =" & TextBox15.Text & "")
                    dr = obj.OpenDataReader
                    While dr.Read
                        cboALL.Items.Add(obj.IsNull(dr.Item("recallbarcode")))
                    End While
                    dr.Close()
                    obj.Execute()
                    obj.Close()
                    obj = Nothing

                    If cboALL.Text <> "" Then
                        RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                        cboALL.Focus()
                    Else
                        cboALL.Focus()
                    End If

                Else
                    MsgBox("Enter numeric", MsgBoxStyle.Information)
                    TextBox15.Text = ""
                    TextBox15.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox16.KeyPress

        Try
            If nonNumberEntered = True Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                If TextBox16.Text.Trim = "" Then
                    MsgBox("Select PTN barcode", MsgBoxStyle.Information)
                    TextBox16.Text = ""
                    TextBox16.Focus()
                ElseIf IsNumeric(TextBox16.Text) Then
                    iFocus = 16
                    RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                Else
                    MsgBox("Enter numeric", MsgBoxStyle.Information)
                    TextBox16.Text = ""
                    TextBox16.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'mao kini ako buttonclear.....
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Call Clear()
            Button13.Enabled = False
            Button2.Enabled = False
            Panel5.Visible = False
            Panel7.Visible = True
            Me.btnSaveMLWB.Enabled = False
            FlagPricingNotSave = False
            cboALL.Focus()
        Catch ex As Exception
        End Try
    End Sub
    '---button1 bsta button1 lang
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Call Calculate()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'mao kini ako buttonsave.....
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            If TextBox15.Text = "" Then
                MsgBox("Input PTN", MsgBoxStyle.Information)
                TextBox15.Focus()
                Exit Sub
            End If

            SaveMounted()
            Button13_Click(sender, e)
            'Dim objclass As New clsCommon
            'Dim dr As SqlDataReader
            'Dim iExisted As Integer
            'objclass.ConnectionString1()
            'objclass.Open()
            'If force = False Then
            '    objclass.Command("select reccostid from tbl_receiving_header where recptn = " + TextBox15.Text)
            '    dr = objclass.OpenDataReader()
            '    If dr.Read Then
            '        If IsDBNull(dr.Item("reccostid")) Then
            '            iExisted = 0
            '        Else
            '            iExisted = 1
            '        End If
            '    End If
            'Else
            '    objclass.Command("select reccostid_for from tbl_forcedoutrcv where ptn_for = " + TextBox15.Text)
            '    dr = objclass.OpenDataReader()
            '    If dr.Read Then
            '        If IsDBNull(dr.Item("reccostid_for")) Then
            '            iExisted = 0
            '        Else
            '            iExisted = 1
            '        End If
            '    End If
            'End If

            'dr.Close()
            'objclass.CloseDataReader()
            'objclass.Close()
            'objclass = Nothing
            'If iRecord = 0 And iExisted = 0 Then
            '    Call SaveALLValue()
            '    MsgBox("Saved", MsgBoxStyle.OKOnly)
            'Else
            '    Call EditALLValue()
            '    MsgBox("updated", MsgBoxStyle.OKOnly)
            'End If

            control(False)
            iRecord = Nothing
            ComboBox1.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Try
        '    Label49.Text = FormatNumber(CDbl(Label44.Text) + (CDbl(Label44.Text) * dCostA))
        '    Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text) * dCostA)
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            If Label50.Text <> "0.00" Then
                'costing bug.. 03302010
            Else
                'Label50.Text = FormatNumber(CDbl(Label44.Text) * dCostB)
                Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text) * dCostB)
                txtCost.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text) * dCostB)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Label51.Text = FormatNumber(dCostC)
            Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
            txtCost.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Label52.Text = FormatNumber(dCostD)
            Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
            txtCost.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Label54.Text = FormatNumber(CDbl(Label44.Text) + (dCostA * CDbl(Label43.Text)))
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            txtCost.Text = FormatNumber(CDbl(txtCost.Text) - CDbl(Label50.Text))
            Label50.Text = FormatNumber(0)
            Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label51.Text) + CDbl(Label52.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            txtCost.Text = FormatNumber(CDbl(txtCost.Text) - CDbl(Label51.Text))
            Label51.Text = FormatNumber(0)
            Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label52.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            txtCost.Text = FormatNumber(CDbl(txtCost.Text) - CDbl(Label52.Text))
            Label52.Text = FormatNumber(0)
            Label53.Text = FormatNumber(CDbl(Label49.Text) + CDbl(Label50.Text) + CDbl(Label51.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NewCostingSave(ByVal i As Integer)
        Dim obj As New clsCommon
        Try
            Dim str As String
            Dim curr As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            str = "Update ASYS_REM_Detail  set refqty = '" & txtQty.Text & "',all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',gold_cost = '" & CStr(CDbl(Label49.Text)) & "',mount_cost = '" & CStr(CDbl(Label50.Text)) & "',yg_cost = '" & CStr(CDbl(Label51.Text)) & "',wg_cost = '" & CStr(CDbl(Label52.Text)) & "',costdate = getdate(),costname = '" & userLog & "',status='COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update REMS" & sDB & ".dbo.ASYS_REM_Detail  set refqty = '" & txtQty.Text & "',all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',gold_cost = '" & CStr(CDbl(Label49.Text)) & "',mount_cost = '" & CStr(CDbl(Label50.Text)) & "',yg_cost = '" & CStr(CDbl(Label51.Text)) & "',wg_cost = '" & CStr(CDbl(Label52.Text)) & "',costdate = getdate(),costname = '" & userLog & "',status='COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update ASYS_REMOutsource_Detail  set refqty = '" & txtQty.Text & "',all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',gold_cost = '" & CStr(CDbl(Label49.Text)) & "',mount_cost = '" & CStr(CDbl(Label50.Text)) & "',yg_cost = '" & CStr(CDbl(Label51.Text)) & "',wg_cost = '" & CStr(CDbl(Label52.Text)) & "',costdate = getdate(),costname = '" & userLog & "',status='COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update REMS" & sDB & ".dbo.ASYS_REMOutsource_Detail  set refqty = '" & txtQty.Text & "',all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',gold_cost = '" & CStr(CDbl(Label49.Text)) & "',mount_cost = '" & CStr(CDbl(Label50.Text)) & "',yg_cost = '" & CStr(CDbl(Label51.Text)) & "',wg_cost = '" & CStr(CDbl(Label52.Text)) & "',costdate = getdate(),costname = '" & userLog & "',status='COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "update REMS.dbo.asys_barcodehistory  set description = '" & Me.txtDesc.Text & "', karat = '" & Me.txtKarat.Text & "', carat = '" & Me.txtcarat.Text & "', weight = '" & Me.txtwt.Text & "' where refallbarcode = '" & Me.cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()
            obj.CommitTrack()

            MsgBox("Item Saved!", MsgBoxStyle.Information, "ASYS 3.0 Costing")

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            obj.Close()
        End Try
    End Sub

    'Public Sub SaveGoodStocks(ByVal i As Integer)
    '    Dim obj As New clsCommon
    '    Dim dr2 As SqlDataReader
    '    Dim txtitemid As String
    '    Dim dr As SqlDataReader
    '    Dim squery As String

    '    objclass = New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("If (Select COunt(*) from tbl_receiving_detail where dallbarcode= '" & Me.cboALL.Text & "')<> 0 begin select all_karat,all_wt,all_carat,ALL_ValueCost from tbl_receiving_detail where dallbarcode= '" & Me.cboALL.Text & "' end else select all_karat_dfor as all_karat,all_wt_dfor as all_wt,all_carat_dfor as all_carat,ALL_ValueCost_dfor as all_valuecost from tbl_forcedoutrcv_detail  where allbarcode_dfor = '" & Me.cboALL.Text & "'")
    '    dr = objclass.OpenDataReader
    '    If dr.Read Then
    '        allkarat = FormatNumber(IsNull_Value(dr.Item("ALL_Karat")))
    '        allwt = FormatNumber(IsNull_Value(dr.Item("ALL_WT")))
    '        allcarat = FormatNumber(IsNull_Value(dr.Item("ALL_Carat")))
    '        allvaluecost = FormatNumber(IsNull_Value(dr.Item("ALL_ValueCost")))
    '    End If
    '    dr.Close()
    '    objclass.Execute()
    '    objclass.Close()
    '    objclass = Nothing

    '    trappedcost()
    '    obj.ConnectionString1()
    '    obj.Open()

    '    objclass = New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    If ListView2.Items.Item(i).SubItems.Item(1).Text <> "" Then
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text
    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost = " + CStr(CDbl(Label50.Text)) + ", YG_Cost = " + CStr(CDbl(Label51.Text)) + ", WG_Cost = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = " + CStr(CDbl(Label49.Text)) + ",ALL_Price='" & CStr(CDbl(Me.txtPrice.Text)) & "' where ID = '" + txtitemid + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost = " + CStr(CDbl(Label50.Text)) + ", YG_Cost = " + CStr(CDbl(Label51.Text)) + ", WG_Cost = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = " + CStr(CDbl(Label49.Text)) + ",ALL_Price='" & CStr(CDbl(Me.txtPrice.Text)) & "' where ID = '" + txtitemid + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else

    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost = " + CStr(CDbl(Label50.Text)) + ", YG_Cost = " + CStr(CDbl(Label51.Text)) + ", WG_Cost = " + CStr(CDbl(Label52.Text)) + ",all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = " + CStr(CDbl(Label49.Text)) + " where ID = '" + txtitemid + "' and  DallBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost = " + CStr(CDbl(Label50.Text)) + ", YG_Cost = " + CStr(CDbl(Label51.Text)) + ", WG_Cost = " + CStr(CDbl(Label52.Text)) + ",all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = " + CStr(CDbl(Label49.Text)) + " where ID = '" + txtitemid + "' and  DallBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()

    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost_dfor = " + CStr(CDbl(Label50.Text)) + ", YG_Cost_dfor = " + CStr(CDbl(Label51.Text)) + ", WG_Cost_dfor = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT_dfor =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc_dfor= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = " + CStr(CDbl(Label49.Text)) + ",ALL_Price_dfor='" & CStr(CDbl(Me.txtPrice.Text)) & "' where FOR_ID_dfor = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost_dfor = " + CStr(CDbl(Label50.Text)) + ", YG_Cost_dfor = " + CStr(CDbl(Label51.Text)) + ", WG_Cost_dfor = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT_dfor =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc_dfor= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = " + CStr(CDbl(Label49.Text)) + ",ALL_Price_dfor='" & CStr(CDbl(Me.txtPrice.Text)) & "' where FOR_ID_dfor = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost_dfor = " + CStr(CDbl(Label50.Text)) + ", YG_Cost_dfor = " + CStr(CDbl(Label51.Text)) + ", WG_Cost_dfor = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT_dfor =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc_dfor= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = " + CStr(CDbl(Label49.Text)) + " where FOR_ID_dfor = '" + txtitemid + "' and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Mount_Cost_dfor = " + CStr(CDbl(Label50.Text)) + ", YG_Cost_dfor = " + CStr(CDbl(Label51.Text)) + ", WG_Cost_dfor = " + CStr(CDbl(Label52.Text)) + ", ALL_ValueCost_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(0).SubItems.Item(5).Text, 2))) + ", ALL_WT_dfor =" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + ", ALL_Carat_dfor = " + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + " , ALL_Desc_dfor= '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = " + CStr(CDbl(Label49.Text)) + " where FOR_ID_dfor = '" + txtitemid + "' and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '    End If
    '    'objclass.CloseDataReader()

    '    If prcing = True Then
    '        obj.Command("update tbl_receiving_header set DeptStatus = 3 where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_receiving_header set DeptStatus = 3 where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    Else
    '        obj.Command("update tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    End If

    '    If prcing = True Then
    '        obj.Command("update tbl_forcedoutrcv set DeptStatus_for =3, reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_forcedoutrcv set DeptStatus_for =3, reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    Else
    '        obj.Command("update tbl_forcedoutrcv set forcedout_status_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where fOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_forcedoutrcv set forcedout_status_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where fOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    End If

    '    objclass.Close()
    '    objclass = Nothing

    '    objclass = New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    If ListView2.Items.Item(i).SubItems.Item(2).Text = 0 Then
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text
    '        ListView2.Items.Item(i).SubItems.Item(2).Text = ListView1.Items.Item(0).SubItems.Item(4).Text
    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.txtPrice.Text)) & "' where ID = '" + txtitemid + "'  and DAllbarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.txtPrice.Text)) & "' where ID = '" + txtitemid + "'  and DAllbarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else

    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' AND DAllbarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' AND DAllbarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()



    '        End If
    '        'objclass.OpenDataReader()
    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  AND Allbarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  AND Allbarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and Allbarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and Allbarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If
    '        'objclass.OpenDataReader()

    '    Else
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text
    '        If force = False And outsource = False Then
    '            If prcing = True Then
    '                obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '                obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '            Else
    '                obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '                obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DallBarcode='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '            End If

    '            If prcing = True Then
    '                obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '                obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '            Else
    '                obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "' where FOR_ID_DFOR = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '                obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(TextBox30.Text, 2))) + "' where FOR_ID_DFOR = '" + txtitemid + "'  and allBarcode_dfor='" & Me.cboALL.Text & "'")
    '                obj.Execute()
    '            End If

    '        End If
    '        'objclass.CloseDataReader()


    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_header set DeptStatus =3, reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where RECptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_header set DeptStatus =3, reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where RECptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where RECptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where RECptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv set DeptStatus_for =3, reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where ptn_for = '" + TextBox15.Text + "' and FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv set DeptStatus_for =3, reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where ptn_for = '" + TextBox15.Text + "' and FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv set ForcedOUt_status_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv set ForcedOUt_status_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        objclass.Close()
    '        objclass = Nothing

    '    End If

    '    objclass = New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    If ListView2.Items.Item(i).SubItems.Item(5).Text = 0 Then
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text
    '        ListView2.Items.Item(i).SubItems.Item(5).Text = ListView1.Items.Item(0).SubItems.Item(3).Text
    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALlBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALlBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALlBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',all_value = " + CStr(CDbl(FormatNumber(Label49.Text, 2))) + ", ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALlBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()

    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALlBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALlBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and ALlBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and ALlBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If
    '        'objclass.CloseDataReader()

    '    Else

    '        txtitemid = ListView1.Items.Item(i).SubItems.Item(0).Text
    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' AND DALLBARCODE='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' AND DALLBARCODE='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else

    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' AND DALLBARCODE='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' AND DALLBARCODE='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "' AND ALLBARCODE_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "' AND ALLBARCODE_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()

    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' AND ALLBARCODE_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' AND ALLBARCODE_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        ' objclass.CloseDataReader()

    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_header set DeptStatus =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_header set DeptStatus =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv set DeptStatus_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv set DeptStatus_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv set ForcedOut_status_FOR =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv set ForcedOut_status_FOR =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_for='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        objclass.Close()
    '        objclass = Nothing

    '    End If

    '    objclass = New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    If ListView2.Items.Item(i).SubItems.Item(3).Text = 0 Then
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text
    '        ListView2.Items.Item(i).SubItems.Item(3).Text = ListView1.Items.Item(0).SubItems.Item(5).Text
    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else

    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_Value = '" + CStr(CDbl(TextBox30.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "', ALL_Value = '" + CStr(CDbl(TextBox30.Text)) + "', ALL_ValueCost = '" + CStr(CDbl(TextBox30.Text)) + "' where ID = '" + txtitemid + "' and dDIVISION = '" + txtBranchCode.Text + "' and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()

    '        End If
    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat_dfor = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "' and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat_dfor = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "' and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat_dfor = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Carat_dfor = '" + CStr(CDbl(ListView2.Items.Item(i).SubItems.Item(3).Text)) + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "', ALL_ValueCost_dfor = '" + CStr(CDbl(TextBox30.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If

    '        'objclass.CloseDataReader()
    '    Else
    '        txtitemid = ListView1.Items.Item(0).SubItems.Item(0).Text

    '        If prcing = True Then
    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "'  and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price='" & CStr(CDbl(Me.TextBox32.Text)) & "' where ID = '" + txtitemid + "'  and DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else

    '            obj.Command("update tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_Value = '" + CStr(CDbl(FormatNumber(Label49.Text, 2))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "' where ID = '" + txtitemid + "' and  DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_receiving_detail set QUantity = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_Value = '" + CStr(CDbl(FormatNumber(Label49.Text, 2))) + "', All_ValueCost = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost = '" + CStr(CDbl(Label52.Text)) + "' where ID = '" + txtitemid + "' and  DALLBarcode='" & Me.cboALL.Text & "'")
    '            obj.Execute()

    '        End If

    '        If prcing = True Then
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "',ALL_Price_dfor='" & CStr(CDbl(Me.TextBox32.Text)) & "' where FOR_ID_DFOR = '" + txtitemid + "'  and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        Else
    '            obj.Command("update tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '            obj.Command("update rems.dbo.tbl_forcedoutrcv_detail set QUantity_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(1).Text)) + "',ALL_Karat_dfor = '" + CStr(CInt(ListView2.Items.Item(i).SubItems.Item(2).Text)) + "', ALL_WT_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(4).Text, 2))) + "', ALL_Carat_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(3).Text))) + "', All_ValueCost_dfor = '" + CStr(CDbl(FormatNumber(ListView2.Items.Item(i).SubItems.Item(5).Text, 2))) + "', ALL_Desc_dfor = '" + ListView2.Items.Item(i).SubItems.Item(0).Text + "', Gold_Cost_dfor = '" + CStr(CDbl(Label49.Text)) + "', Mount_Cost_dfor = '" + CStr(CDbl(Label50.Text)) + "', YG_Cost_dfor = '" + CStr(CDbl(Label51.Text)) + "', WG_Cost_dfor = '" + CStr(CDbl(Label52.Text)) + "' where FOR_ID_DFOR = '" + txtitemid + "' and ALLBarcode_dfor='" & Me.cboALL.Text & "'")
    '            obj.Execute()
    '        End If
    '    End If


    '    'objclass.CloseDataReader()


    '    If prcing = True Then
    '        obj.Command("update tbl_receiving_header set DeptStatus =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_receiving_header set DeptStatus =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    Else
    '        obj.Command("update tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_receiving_header set status_id =" + CStr(objclass.status.costed) + ", reccostid = '" + lblEmpIDNo.Text + "',reccostname='" & Me.lblName.Text & "', costdate = getdate() where recptn = '" + TextBox15.Text + "' and recItem_id='" & txtitemid & "' and recALLbArcode='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    End If


    '    If prcing = True Then
    '        obj.Command("update tbl_forcedoutrcv set DeptStatus_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_For='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_forcedoutrcv set DeptStatus_for =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_For='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    Else
    '        obj.Command("update tbl_forcedoutrcv set ForcedOut_status_FOR =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_For='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '        obj.Command("update rems.dbo.tbl_forcedoutrcv set ForcedOut_status_FOR =" + CStr(objclass.status.costed) + ", reccostid_for = '" + lblEmpIDNo.Text + "',reccostname_for='" & Me.lblName.Text & "', costdate_for = getdate() where  FOR_PTN_ID='" & txtitemid & "' and ALLbArcode_For='" & Me.cboALL.Text & "'")
    '        obj.Execute()
    '    End If

    '    objclass.Close()
    '    objclass = Nothing

    '    If prcing = True Then
    '        objclass = New clsCommon
    '        objclass.ConnectionString1()
    '        objclass.Open()
    '        objclass.Command("Update tbl_recrel_pricing set PrcingStat = 1 where allbarcode_rec ='" & Me.cboALL.Text & "'")
    '        objclass.Execute()
    '        objclass.Command("Update tbl_recrel_PRicing_dtail set dprcingstat =1 where allbarcode ='" & Me.cboALL.Text & "'")
    '        objclass.Execute()
    '        objclass.Command("Update rems.dbo.tbl_recrel_pricing set PrcingStat = 1 where allbarcode_rec ='" & Me.cboALL.Text & "'")
    '        objclass.Execute()
    '        objclass.Command("Update rems.dbo.tbl_recrel_PRicing_dtail set dprcingstat =1 where allbarcode ='" & Me.cboALL.Text & "'")
    '        objclass.Execute()
    '        objclass.Close()
    '        objclass = Nothing
    '    End If
    'End Sub

    Public Sub SaveMounted()
        Dim obj As New clsCommon
        Try
            Dim str As String
            Dim tmpLotNo As String
            Dim dr As SqlDataReader
            Dim ctr As Integer
            Dim i As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            str = "SELECT Lotno FROM ASYS_PRICING_detail WHERE refallbarcode = '" & cboALL.Text & "' AND status not in ('RELEASED','RECDISTRI')"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            While dr.Read
                tmpLotNo = Trim(dr.Item("Lotno"))
            End While

            dr.Close()
            obj.Close3()


            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()


            '--- Gold Saving [start] ---
            'If ArrGold.Count > 0 Then
            str = "DELETE FROM ASYS_Gold WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            If ArrGold.Count > 0 Then
                str = "INSERT INTO ASYS_Gold (Lotno, ALLBarcode, Karat, Grams, KaratPrice, GoldPrice) " & _
                      "VALUES ('" & tmpLotNo & "', '" & cboALL.Text & "', '" & ArrGold.Item(0) & "', '" & CStr(CDbl(ArrGold.Item(1))) & "', '" & CStr(CDbl(ArrGold.Item(2))) & "', '" & CStr(CDbl(ArrGold.Item(3))) & "')"

                obj.commandTrack(str)
                obj.TrackExecute()
            End If

            'End If
            '---- Gold Saving [end] ----

            '--- Dia Saving [start] ---
            'If ArrDia.Count > 0 Then
            str = "DELETE FROM ASYS_Diamond WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            ctr = 0
            If ArrDia.Count > 0 Then
                For i = 0 To ctrArrDia - 1

                    str = "INSERT INTO ASYS_Diamond (Lotno, ALLBarcode, NoOfDias, Diamond_Cut, Diamond_Color, Diamond_Clarity, Diamond_CWT, Diamond_Price) " & _
                          "VALUES ('" & tmpLotNo & "','" & cboALL.Text & "','" & CStr(CDbl(ArrDia.Item(ctr))) & "','" & ArrDia.Item(ctr + 2) & "','" & ArrDia.Item(ctr + 3) & "','" & ArrDia.Item(ctr + 4) & "','" & CStr(CDbl(ArrDia.Item(ctr + 1))) & "','" & CStr(CDbl(ArrDia.Item(ctr + 6))) & "')"
                    ctr = ctr + 7
                    obj.commandTrack(str)
                    obj.TrackExecute()
                Next
            End If
            
            'End If
            '---- Dia Saving [end] ----

            '--- Pearl Saving [start] ---
            'If ArrPearl.Count > 0 Then
            str = "DELETE FROM ASYS_Pearl WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            ctr = 0
            If ArrPearl.Count > 0 Then
                For i = 0 To ctrArrPearl - 1
                    str = "INSERT INTO ASYS_Pearl (Lotno, ALLBarcode, Pearl_No_of_Pear, Pearl_Type, Pearl_Size, Pearl_Quality, Pearl_Price) " & _
                          "VALUES ('" & tmpLotNo & "','" & cboALL.Text & "','" & ArrPearl.Item(ctr) & "','" & ArrPearl.Item(ctr + 1) & "','" & ArrPearl.Item(ctr + 2) & "','" & ArrPearl.Item(ctr + 3) & "','" & CStr(CDbl(ArrPearl.Item(ctr + 4))) & "')"
                    ctr = ctr + 5
                    obj.commandTrack(str)
                    obj.TrackExecute()
                Next
            End If
           
            'End If
            '---- Pearl Saving [end] ----

            '--- Precious Saving [start] ---
            'If ArrPrecious.Count > 0 Then
            str = "DELETE FROM ASYS_PreciousStone WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            ctr = 0
            If ArrPrecious.Count > 0 Then
                For i = 0 To ctrArrPrecious - 1

                    str = "INSERT INTO ASYS_PreciousStone (Lotno, ALLBarcode, PStone_Type, PStone_Quality, PStone_CWT, PStone_Price) " & _
                          "VALUES ('" & tmpLotNo & "','" & cboALL.Text & "','" & ArrPrecious.Item(ctr) & "','" & ArrPrecious.Item(ctr + 1) & "','" & CStr(CDbl(ArrPrecious.Item(ctr + 2))) & "','" & CStr(CDbl(ArrPrecious.Item(ctr + 3))) & "')"
                    ctr = ctr + 4
                    obj.commandTrack(str)
                    obj.TrackExecute()
                Next
            End If
           
            'End If
            '---- Precious Saving [end] ----

            '--- Synthetic Saving [start] ---
            'If ArrSynthetic.Count > 0 Then
            str = "DELETE FROM ASYS_SyntheticStone WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            ctr = 0
            If ArrSynthetic.Count > 0 Then
                For i = 0 To ctrArrSynthetic - 1

                    str = "INSERT INTO ASYS_SyntheticStone (Lotno, ALLBarcode, SStone_Type, SStone_Quality, SStone_CWT, SStone_Price) " & _
                          "VALUES ('" & tmpLotNo & "','" & cboALL.Text & "','" & ArrSynthetic.Item(ctr) & "','" & ArrSynthetic.Item(ctr + 1) & "','" & CStr(CDbl(ArrSynthetic.Item(ctr + 2))) & "','" & CStr(CDbl(ArrSynthetic.Item(ctr + 3))) & "')"
                    ctr = ctr + 4
                    obj.commandTrack(str)
                    obj.TrackExecute()
                Next
            End If
           
            'End If
            '---- Synthetic Saving [end] ----

            '--- Mounted Saving [start] ---

            str = "DELETE FROM ASYS_MountedPrice WHERE AllBarcode = '" & cboALL.Text & "'"
            obj.commandTrack(str)
            obj.TrackExecute()

            If ArrMountedTotal.Count > 0 Then
                str = "INSERT INTO ASYS_MountedPrice (Lotno, ALLBarcode, Total_GoldPrice, Total_DiaPrice, Total_PearlPrice, Total_CStonePrice, Total_SellingPrice) " & _
                      "VALUES ('" & tmpLotNo & "', '" & cboALL.Text & "', '" & CStr(CDbl(ArrMountedTotal.Item(0))) & "', '" & CStr(CDbl(ArrMountedTotal.Item(1))) & "', '" & CStr(CDbl(ArrMountedTotal.Item(2))) & "', '" & CStr(CDbl(ArrMountedTotal.Item(3))) & "', '" & CStr(CDbl(ArrMountedTotal.Item(4))) & "')"

                obj.commandTrack(str)
                obj.TrackExecute()
            End If
            '---- Mounted Saving [end] ----
            obj.CommitTrack()

            FlagPricingNotSave = False
        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(Err.Description)
        Finally
            obj.Close()
        End Try
    End Sub

    Public Sub SaveGoodStocks1(ByVal i As Integer)
        Dim obj As New clsCommon

        Try

            Dim str As String
            Dim curr As String
            Dim tmpLotNo As String
            Dim dr As SqlDataReader
            Dim ctr As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            str = "Update ASYS_Pricing_Detail  set refqty = '" & txtQty.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',all_price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',gold_cost = '" & CStr(CDbl(isEmptytext(Label49.Text))) & "',mount_cost = '" & CStr(CDbl(isEmptytext(Label50.Text))) & "',yg_cost = '" & CStr(CDbl(isEmptytext(Label51.Text))) & "',wg_cost = '" & CStr(CDbl(isEmptytext(Label52.Text))) & "', GoldKaratPrice ='" & CStr(CDbl(isEmptytext(lblPriceA.Text))) & "', MountedPrice ='" & CStr(CDbl(isEmptytext(lblPriceB.Text))) & "', Gold_Karat ='" & ComboBox6.Text & "', costdate = getdate(),costname = '" & userLog & "',status='PRICED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update ASYS_BarcodeHistory  set Description = '" & txtDesc.Text & "',  Weight = " & CStr(CDbl(txtwt.Text)) & ", Karat = " & txtKarat.Text & ", Carat = " & CStr(CDbl(txtcarat.Text)) & ",cost = " & CStr(CDbl(txtCost.Text)) & ",price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "' where refallbarcode ='" & cboALL.Text.Trim & "' and COSTCENTER = 'PRICING'"
            obj.commandTrack(str)
            obj.TrackExecute()

            obj.CommitTrack()

            MsgBox("Item Saved", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            obj.Close()
        End Try
    End Sub
    Private Function isEmptytext(ByVal ifempty As String)
        If ifempty = "" Then
            isEmptytext = "0"
        Else
            isEmptytext = ifempty
        End If

    End Function
    Public Sub saveCellular(ByVal ctr As Integer)
        Dim obj As New clsCommon

        Try
            Dim txtitemid, str As String
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
            Dim squery As String
            Dim curr As String

            trappedcost2()

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Opentracker2()
            objclass.CreateCom()



            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            If sDB <> "" Then
                str = "Update ASYS_REM_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & ListView3.Items(ctr).SubItems.Item(2).Text & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update rems" & sDB & ".dbo.ASYS_REM_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & ListView3.Items(ctr).SubItems.Item(2).Text & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & ListView3.Items(ctr).SubItems.Item(2).Text & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update rems" & sDB & ".dbo.ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & ListView3.Items(ctr).SubItems.Item(2).Text & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "update REMS.dbo.asys_barcodehistory  set description = '" & Me.txtDesc.Text & "', karat = '" & Me.txtKarat.Text & "', carat = '" & Me.txtcarat.Text & "', weight = '" & Me.txtwt.Text & "' where refallbarcode = '" & Me.cboALL.Text & "'"
                objclass.commandTrack(str)
                objclass.TrackExecute()
            Else
                str = "Update rems.dbo.ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & ListView3.Items(ctr).SubItems.Item(2).Text & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "update REMS.dbo.asys_barcodehistory  set description = '" & Me.txtDesc.Text & "', karat = '" & Me.txtKarat.Text & "', carat = '" & Me.txtcarat.Text & "', weight = '" & Me.txtwt.Text & "' where refallbarcode = '" & Me.cboALL.Text & "'"
                objclass.commandTrack(str)
                objclass.TrackExecute()
            End If


            objclass.CommitTrack()
            MsgBox("Item Saved!", MsgBoxStyle.Information, "ASYS 3.0 Costing")

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            objclass.Close()
        End Try

    End Sub

    Public Sub saveCellular1(ByVal i As Integer)
        Dim obj As New clsCommon

        Try
            Dim str As String
            Dim curr As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            str = "Update ASYS_Pricing_Detail  set refqty = '" & txtQty.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',all_price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost = '" & CStr(CDbl(Label7.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox3.Text)) & "',cleaning_cost = '" & CStr(CDbl(TextBox1.Text)) & "', GoldKaratPrice ='" & CStr(CDbl(isEmptytext(lblPriceA.Text))) & "', MountedPrice ='" & CStr(CDbl(isEmptytext(lblPriceB.Text))) & "',costdate = getdate(),costname = '" & userLog & "',status='PRICED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update ASYS_BarcodeHistory  set Description = '" & txtDesc.Text & "', serialno = '" & txtSerialNo.Text & "', Weight = " & CStr(CDbl(txtwt.Text)) & ", Karat = " & txtKarat.Text & ", Carat = " & CStr(CDbl(txtcarat.Text)) & ",cost = " & CStr(CDbl(txtCost.Text)) & ",price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "' where refallbarcode ='" & cboALL.Text.Trim & "' and COSTCENTER = 'PRICING'"
            obj.commandTrack(str)
            obj.TrackExecute()

            obj.CommitTrack()

            MsgBox("Item Saved!", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            obj.Close()
        End Try
    End Sub

    Public Sub savewatch1(ByVal i As Integer)
        Dim obj As New clsCommon
        Try
            Dim str As String
            Dim curr As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()


            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            str = "Update ASYS_Pricing_Detail  set refqty = '" & txtQty.Text & "',all_cost ='" & CStr(CDbl(txtCost.Text)) & "',all_price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "',price_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',watch_cost = '" & CStr(CDbl(Label7.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox3.Text)) & "',cleaning_cost = '" & CStr(CDbl(TextBox1.Text)) & "', GoldKaratPrice ='" & CStr(CDbl(isEmptytext(lblPriceA.Text))) & "', MountedPrice ='" & CStr(CDbl(isEmptytext(lblPriceB.Text))) & "',costdate = getdate(),costname = '" & userLog & "',status='PRICED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update ASYS_BarcodeHistory  set Description = '" & txtDesc.Text & "', serialno = '" & txtSerialNo.Text & "',   Weight = " & CStr(CDbl(txtwt.Text)) & ", Karat = " & txtKarat.Text & ", Carat = " & CStr(CDbl(txtcarat.Text)) & ",cost = " & CStr(CDbl(txtCost.Text)) & ",price = '" & CStr(CDbl(txtPrice.Text)) & "',currency =  '" & curr & "' where refallbarcode ='" & cboALL.Text.Trim & "' and COSTCENTER = 'PRICING'"
            obj.commandTrack(str)
            obj.TrackExecute()

            obj.CommitTrack()

            MsgBox("Item Saved!", MsgBoxStyle.Information, TitleMsgBox)

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            obj.Close()
        End Try
    End Sub

    Public Sub savewatch(ByVal ctr As Integer)
        Try
            Dim txtitemid, str As String
            Dim dr As SqlDataReader
            Dim obj As New clsCommon
            Dim dr2 As SqlDataReader
            Dim squery, curr As String

            trappedcost2()

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Opentracker2()
            objclass.CreateCom()


            If RadioButton1.Checked = True Then
                curr = RadioButton1.Text
            Else
                curr = RadioButton2.Text
            End If

            If sDB <> "" Then
                str = "Update ASYS_REM_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & CStr(CDbl(Label54.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update rems" & sDB & ".dbo.ASYS_REM_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & CStr(CDbl(Label54.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & CStr(CDbl(Label54.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "Update rems" & sDB & ".dbo.ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & CStr(CDbl(Label54.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "update REMS.dbo.asys_barcodehistory  set description = '" & Me.txtDesc.Text & "', karat = '" & Me.txtKarat.Text & "', carat = '" & Me.txtcarat.Text & "', weight = '" & Me.txtwt.Text & "' where refallbarcode = '" & Me.cboALL.Text & "'"
                objclass.commandTrack(str)
                objclass.TrackExecute()
            Else
                str = "Update rems.dbo.ASYS_REMOutsource_Detail  set all_desc = '" & txtDesc.Text & "',SerialNo = '" & txtSerialNo.Text & "',all_karat ='" & txtKarat.Text & "',all_carat = '" & txtcarat.Text & "',all_weight = '" & txtwt.Text & "',all_cost = '" & CStr(CDbl(txtCost.Text)) & "',currency = '" & curr & "',price_desc ='" & txtDesc.Text & "',price_karat = '" & txtKarat.Text & "',price_weight = '" & CStr(CDbl(txtwt.Text)) & "',price_carat = '" & CStr(CDbl(txtcarat.Text)) & "',cellular_cost ='" & CStr(CDbl(Label54.Text)) & "', watch_cost = '" & CStr(CDbl(Label54.Text)) & "',repair_cost = '" & CStr(CDbl(TextBox29.Text)) & "',cleaning_cost ='" & CStr(CDbl(TextBox25.Text)) & "',gold_cost = '" & ListView3.Items(ctr).SubItems.Item(5).Text & "',yg_cost = '" & ListView3.Items(ctr).SubItems.Item(7).Text & "',wg_cost = '" & ListView3.Items(ctr).SubItems.Item(8).Text & "',costdate = getdate(),costname = '" & userLog & "',status = 'COSTED' where refallbarcode = '" & cboALL.Text & "' and status not in ('RELEASED','RECMLWB')"
                objclass.commandTrack(str)
                objclass.TrackExecute()

                str = "update REMS.dbo.asys_barcodehistory  set description = '" & Me.txtDesc.Text & "', karat = '" & Me.txtKarat.Text & "', carat = '" & Me.txtcarat.Text & "', weight = '" & Me.txtwt.Text & "' where refallbarcode = '" & Me.cboALL.Text & "'"
                objclass.commandTrack(str)
                objclass.TrackExecute()

            End If

            objclass.CommitTrack()
            MsgBox("Item Saved!", MsgBoxStyle.Information, "ASYS 3.0 Costing")

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox(ex.Message)
        Finally
            objclass.Close()
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Dim i As Integer
            Dim frmPhoto As New frmPhotoMover

            If txtDesc.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtDesc.Focus()
                Exit Sub
            ElseIf txtSerialNo.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtSerialNo.Focus()
                Exit Sub
            ElseIf txtQty.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtQty.Focus()
                Exit Sub
            ElseIf txtKarat.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtKarat.Focus()
                Exit Sub
            ElseIf txtcarat.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtcarat.Focus()
                Exit Sub
            ElseIf txtwt.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtwt.Focus()
                Exit Sub
            ElseIf txtCost.Text = "" Then
                MsgBox("Please fill-up the blank boxe(s)", MsgBoxStyle.Information, TitleMsgBox)
                txtCost.Focus()
                Exit Sub
            End If

            If txtPrice.Text = 0 Or Trim(txtPrice.Text).Length <= 0 Then
                MsgBox("A.L.L. Price must not be zero.", MsgBoxStyle.Information, TitleMsgBox)
                txtPrice.Focus()
                Exit Sub
            End If

            If txtCost.Text = 0 Then
                MsgBox("A.L.L. cost must not be zero.", MsgBoxStyle.Information, TitleMsgBox)
                txtCost.Focus()
                Exit Sub
            End If

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
            txtDesc.Text = Replace(txtDesc.Text, "'", "''")

            For ctr = 0 To ListView2.Items.Count - 1
                If ComboBox4.Text.ToUpper = "GOODSTOCK" Or ComboBox4.Text.ToUpper = "OUTSOURCE" Or ComboBox4.Text.ToUpper = "RETURN" Then
                    'If ComboBox4.Text = "GOODSTOCK" Or ComboBox4.Text.ToUpper = "OUTSOURCE" Or ComboBox4.Text.ToUpper = "RETURN" Then
                    If prcing = True Then
                        If Me.txtPrice.Text <> "" Then
                            SaveMounted()
                            SaveGoodStocks1(ctr)
                        End If
                    Else
                        SaveMounted()
                        NewCostingSave(ctr)
                    End If
                End If

                If ComboBox4.Text.ToUpper = "CELLULAR" Then
                    If prcing = True Then
                        'SaveMounted()
                        saveCellular1(ctr)
                    Else
                        'SaveMounted()
                        saveCellular(ctr)
                    End If

                End If

                If ComboBox4.Text.ToUpper = "WATCH" Then
                    If prcing = True Then
                        'SaveMounted()
                        savewatch1(ctr)
                    Else
                        'SaveMounted()
                        savewatch(ctr)
                    End If

                End If
            Next

            Call Button2_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox29_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox29.KeyUp
        If Not IsNumeric(TextBox29.Text) Then
            Exit Sub
        End If
        Call Calculate()
    End Sub
    Private Sub TextBox25_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox25.KeyUp
        If Not IsNumeric(TextBox25.Text) Then
            Exit Sub
        End If
        Call Calculate()
    End Sub
    Private Sub TextBox25_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.LostFocus
        If Not IsNumeric(TextBox25.Text) Then
            MsgBox("enter numeric")
            TextBox25.Focus()
            Exit Sub
        End If
        TextBox25.Text = FormatNumber(CDbl(TextBox25.Text))
    End Sub
    Private Sub TextBox29_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.LostFocus
        If Not IsNumeric(TextBox29.Text) Then
            MsgBox("enter numeric")
            TextBox29.Focus()
            Exit Sub
        End If
        TextBox29.Text = FormatNumber(CDbl(TextBox29.Text))
    End Sub
    Private Sub TextBox24_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox24.LostFocus
        If Not IsNumeric(TextBox24.Text) Then
            MsgBox("Enter numeric")
            TextBox24.Focus()
            Exit Sub
        End If
        TextBox24.Text = FormatNumber(CDbl(TextBox24.Text))
    End Sub
    Private Sub TextBox23_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox23.LostFocus
        If Not IsNumeric(TextBox23.Text) Then
            MsgBox("Enter numeric")
            TextBox23.Focus()
            Exit Sub
        End If
        TextBox23.Text = FormatNumber(CDbl(TextBox23.Text), 0)
    End Sub
    Private Sub TextBox17_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox17.LostFocus
        If Not IsNumeric(TextBox17.Text) Then
            MsgBox("Enter numeric")
            TextBox17.Focus()
            Exit Sub
        End If
        TextBox17.Text = FormatNumber(CDbl(TextBox17.Text))
    End Sub
#End Region
    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        'Try
        '    Dim objclass As New clsCommon
        '    Dim dr As SqlDataReader
        '    Dim PTNStr As String
        '    Dim F As Integer

        '    If e.KeyCode = Keys.Enter Then
        '        If txtBranchCode.Text.Trim.Length = 0 Then
        '            Msgbox("Enter a Branch Code")
        '            txtBranchCode.Focus()
        '            Exit Sub
        '        End If

        '        objclass.ConnDb()
        '        objclass.Open5()
        '        If UCase(sDB) = "LUZON" Then
        '            objclass.Command5("Select * from  " & bedryfluzon2 & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
        '        ElseIf UCase(sDB) = "VISMIN" Then
        '            objclass.Command5("Select * from " & bedryfvismin2 & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
        '        Else
        '            objclass.Command5("Select * from " & bedryf2 & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
        '        End If

        '        dr = objclass.OpenDataReader5
        '        If dr.Read Then
        '            txtbrname.Text = Trim(dr.Item("bedrnm"))
        '            F = 1
        '        Else
        '            Msgbox("Branch Code does not exist")
        '            txtBranchCode.Focus()
        '        End If
        '        dr.Close()
        '        objclass.Execute5()
        '        objclass.Close5()

        '        If F = 1 Then
        '            Try
        '                Call RetrievePTN_Barcode()
        '                TextBox15.Focus()
        '            Catch ex As Exception

        '            End Try
        '        End If
        '        cboALL.Focus()
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtbrname_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbrname.KeyDown
        'Try
        '    Dim dr As SqlDataReader
        '    Dim f As Integer
        '    f = 0
        '    If e.KeyCode = Keys.Enter Then
        '        objclass = New clsCommon
        '        objclass.ConnDb()
        '        objclass.Open5()
        '        If UCase(sDB) = "LUZON" Then
        '            objclass.Command5("Select * from " & bedryfluzon2 & " where bedrnm='" + txtbrname.Text.Trim + "'")
        '        Else
        '            objclass.Command5("Select * from " & bedryfvismin2 & " where bedrnm='" + txtbrname.Text.Trim + "'")
        '        End If
        '        dr = objclass.OpenDataReader5
        '        If dr.Read Then
        '            txtBranchCode.Text = dr.Item("bedrnr")
        '            f = 1
        '        Else
        '            Msgbox("Branch Name does not exist")
        '            txtBranchCode.Focus()
        '        End If
        '        dr.Close()
        '        objclass.Execute5()
        '        objclass.Close5()
        '        objclass = Nothing
        '        If f = 1 Then
        '            Call RetrievePTN_Barcode()
        '        End If
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub TextBox15_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox15.KeyDown
        Try
            nonNumberEntered = False
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    If e.KeyCode <> Keys.Back Then
                        nonNumberEntered = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox16_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox16.KeyDown
        Try
            nonNumberEntered = False
            If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
                If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                    If e.KeyCode <> Keys.Back Then
                        nonNumberEntered = True
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub cboALL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboALL.KeyPress
        Try
            Dim tmpGoldKaratPrice As Double
            Dim tmpMountedPrice As Double
            Dim tmpGold_Karat As String
            Dim tmpobj As New clsCommon
            Dim tmpdr As SqlDataReader
            Dim sqlInsert As String

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If Me.cboALL.Text.Length = 17 Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim obj As New clsCommon
                    Dim dr As SqlDataReader
                    Dim str As String


                    ListView1.Items.Clear()
                    ListView2.Items.Clear()
                    ListView3.Items.Clear()


                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "if (Select Count(refallbarcode) from ASYS_REM_Detail where refallbarcode= '" & Me.cboALL.Text & "') <> 0 begin Select refAllBarcode from ASYS_REM_Detail where refallbarcode = '" & Me.cboALL.Text & "' end else Select refallbarcode from ASYS_REMOutsource_detail where refallbarcode = '" & Me.cboALL.Text & "'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = False Then
                        If TextBox15.Text <> "" Then
                            MsgBox("A.L.L. barcode already released.", MsgBoxStyle.Information, TitleMsgBox)
                            cboALL.Text = ""
                            cboALL.Focus()
                        Else
                            MsgBox("A.L.L. barcode not found.", MsgBoxStyle.Information, TitleMsgBox)
                            cboALL.Text = ""
                            cboALL.Focus()
                        End If
                    Else

                        obj = New clsCommon
                        obj.Connectionstring3()
                        obj.Open3()

                        obj.Command3("If (Select Count(refallbarcode) from ASYS_REM_detail where refallbarcode = '" & cboALL.Text & "') <> 0 begin select ptn from ASYS_REM_detail where refallbarcode = '" & cboALL.Text & "' end else select ptn  from ASYS_REMOutsource_detail where refallbarcode= '" & cboALL.Text & "'")
                        dr = obj.OpenDataReader3
                        If dr.Read Then
                            Me.TextBox15.Text = obj.IsNull(dr.Item("PTN"))
                            If prcing = False And mlPrcing = False Then
                                If sDB = "" Then
                                    RetrieveInfoRet(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                                Else
                                    RetrieveInfo(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                                End If
                            ElseIf prcing = True Then
                                RetrieveInfo1(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                            ElseIf mlPrcing = True Then
                                RetrieveInfo2(Trim(TextBox15.Text), 1, Trim(cboALL.Text))
                            End If

                            tmpobj = New clsCommon
                            tmpobj.Connectionstring3()
                            tmpobj.Open3()

                            sqlInsert = "SELECT GoldKaratPrice, MountedPrice, Gold_Karat FROM rems.dbo.ASYS_Pricing_detail WHERE RefallBarcode ='" & cboALL.Text & "' and status not in ('RELEASED','RECDISTRI')"
                            tmpobj.Command3(sqlInsert)
                            tmpdr = tmpobj.OpenDataReader3

                            If tmpdr.Read Then
                                lblPriceA.Text = Format(tmpdr.Item("GoldKaratPrice"), "#,###,##0.00")
                                lblPriceB.Text = Format(tmpdr.Item("MountedPrice"), "#,###,##0.00")

                                If IsDBNull(tmpdr.Item("Gold_Karat")) Then
                                    ComboBox6.Text = ""
                                Else
                                    ComboBox6.Text = tmpdr.Item("Gold_Karat")
                                End If

                                'ComboBox6.Text = tmpdr.Item("Gold_Karat")
                            End If

                            tmpdr.Close()
                            tmpobj.Close3()
                            tmpobj = Nothing

                        Else
                            MsgBox("A.L.L. barcode not found.", MsgBoxStyle.Information, TitleMsgBox)
                            cboALL.Text = ""
                            cboALL.Focus()
                        End If
                        dr.Close()
                        'obj.Execute3()
                        obj.Close3()
                        obj = Nothing
                        Me.btnSaveMLWB.Enabled = True
                    End If

                Else
                    MsgBox("Please enter correct barcode.", MsgBoxStyle.Information, TitleMsgBox)
                    cboALL.Text = ""
                    cboALL.Focus()
                End If

            End If

            Me.Cursor = Cursors.Arrow
            Button13.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListView2.Items.Item(0).SubItems.Item(3).Text = Me.txtcarat.Text

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListView2.Items.Item(0).SubItems.Item(4).Text = Me.txtwt.Text

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox21_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If sDB <> "" Then
                    txtCost.Enabled = True
                    txtCost.Focus()
                ElseIf sDB = "" And MainCost = "PRICING" Then
                    If RadioButton1.Checked = True Then
                        txtCost.Enabled = True
                        txtCost.Focus()
                    Else
                        txtCost.Enabled = False
                        txtPrice.Focus()
                    End If
                ElseIf sDB = "" And MainCost = "MLWB" Then
                    txtCost.Enabled = True
                    txtCost.Focus()
                ElseIf sDB = "" And MainCost = "REM" Then
                    txtCost.Enabled = True
                    txtCost.Focus()
                End If
            End If

            If e.KeyChar = ChrW(13) Then
                If txtwt.Text = "0" Or txtwt.Text = "" Then
                    txtwt.Text = "0.0"
                ElseIf txtwt.Text = "." Then
                    txtwt.Text = "0.0"
                ElseIf txtwt.Text <> "" Or txtwt.Text <> "0" Then
                    Dim x As Double = Me.txtwt.Text
                    txtwt.Text = x.ToString("##.##")
                End If
                txtCost.Enabled = True
                txtCost.Focus()
            End If
            ''usa ra ka decimal(.) iya dawaton... paopao 03222010
            'If txtWt.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
            '    If txtWt.SelectionStart > txtWt.Text.IndexOf(".") Then
            '        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
            '            e.Handled = True
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtcost_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCost.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                If prcing = True Then
                    Me.ListView2.Items(0).SubItems.Item(5).Text = Format(Me.txtCost.Text, "standard")
                    Me.txtCost.Text = Format(Me.txtCost.Text, "standard")
                    txtPrice.Focus()
                ElseIf mlPrcing = True Then
                    Me.ListView2.Items(0).SubItems.Item(5).Text = Format(Me.txtCost.Text, "standard")
                    Me.txtCost.Text = Format(Me.txtCost.Text, "standard")
                    Button13.Enabled = True
                    btnSaveMLWB.Focus()
                Else
                    Me.ListView2.Items(0).SubItems.Item(5).Text = Format(Me.txtCost.Text, "standard")
                    Me.txtCost.Text = Format(Me.txtCost.Text, "standard")
                    Button13.Enabled = True
                    Button13.Focus()
                End If

                If txtCost.Text = 0 Then
                    Button13.Enabled = False
                    MsgBox("A.L.L. cost must not be zero.", MsgBoxStyle.Information, TitleMsgBox)
                    txtCost.Focus()
                    Button13.Enabled = False
                    Exit Sub
                End If
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If MainCost = "REMS" Then
                    If txtCost.Text > 0 Then
                        Button13.Enabled = True
                    Else
                        Button13.Enabled = False
                    End If
                ElseIf MainCost = "MWLB" Then
                    If txtCost.Text > 0 Then
                        Button13.Enabled = True
                    Else
                        Button13.Enabled = False
                    End If
                ElseIf MainCost = "PRICING" Then
                    If txtPrice.Text > 0 Then
                        Button13.Enabled = True
                        
                    Else
                        Button13.Enabled = False
                        txtPrice.ReadOnly = False
                        txtPrice.Enabled = True
                        txtPrice.Focus()
                    End If
                End If
            End If
            'usa ra ka decimal(.) iya dawaton... paopao 03222010
            If txtCost.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If txtCost.SelectionStart > txtcarat.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub btnForced_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForced.Click
        Try
            force = True
            outsource = False
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub btnOUt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOUt.Click
        Try
            outsource = True
            force = False
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub btnNorm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorm.Click
        Try
            force = False
            outsource = False
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtprice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                txtPrice.Text = Format(txtPrice.Text.Trim, "standard")
                txtPrice.Focus() 'add 20120301
                Button13.Enabled = True
                Button13.Focus()
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If MainCost = "PRICING" Then
                    If txtPrice.Text = "" Then
                        Button13.Enabled = False
                        MsgBox("Please enter price value.", MsgBoxStyle.Information, TitleMsgBox)
                        txtPrice.Focus()
                    End If
                ElseIf MainCost = "REM" Then
                    If txtCost.Text = "" Then
                        Button13.Enabled = False
                        MsgBox("Please enter price value.", MsgBoxStyle.Information, TitleMsgBox)
                        txtCost.Focus()
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub frmCost_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            prcing = False
            mlPrcing = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged
        Try
            Me.txtCost.Text = TextBox26.Text

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox29_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox29.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TextBox29.Text = 0 Then
                    ListView3.Items.Item(0).SubItems.Item(3).Text = TextBox29.Text
                    TextBox25.Focus()
                ElseIf IsNumeric(TextBox29.Text) Then
                    TextBox26.Text = FormatNumber(CDbl(Label54.Text)) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text)
                    ListView3.Items.Item(0).SubItems.Item(3).Text = Trim(TextBox29.Text)
                    txtCost.Text = FormatNumber(CDbl(Label54.Text) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text))
                    ListView2.Items.Item(0).SubItems.Item(5).Text = FormatNumber(CDbl(Label54.Text) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text))
                End If
                TextBox25.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox25_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox25.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If TextBox25.Text = 0 Then
                    ListView3.Items.Item(0).SubItems.Item(4).Text = TextBox25.Text
                ElseIf IsNumeric(TextBox29.Text) Then
                    TextBox26.Text = FormatNumber((CDbl(Label54.Text)) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text), 2)
                    ListView3.Items.Item(0).SubItems.Item(4).Text = Trim(TextBox25.Text)
                    txtCost.Text = FormatNumber(CDbl(Label54.Text) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text))
                    ListView1.Items.Item(0).SubItems.Item(7).Text = FormatNumber(CDbl(Label54.Text) + CDbl(TextBox29.Text) + CDbl(TextBox25.Text))
                End If
                txtDesc.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub RetrieveInfo2(ByVal sPTN As String, ByVal iset As String, ByVal AllBar As String)
        Try
            Dim dr As SqlDataReader
            Dim sMPTN As String
            Dim iCost_id, iItem_id, ibarcode As Integer
            Dim icostname, iStatus, SQuery As String
            Dim iRecorded As String
            Dim newstatus As Integer
            Dim sStatus, sort_code, sSort_Code, picstr As String
            Dim img As Drawing.Image

            objclass = New clsCommon
            odatetime = New clsCommon.DateTime

            ListView1.Items.Clear()
            ListView2.Items.Clear()

            objclass.Connectionstring3()
            objclass.Open3()
            SQuery = "SELECT RefLotno, RefallBarcode, PTN, ItemID, PTNBarcode, BranchCode, BranchName, Loanvalue, RefItemcode, Itemcode, BranchItemDesc, RefQty, Qty,"
            SQuery = SQuery + "  KaratGrading, CaratSize, Weight,Actionclass,Sortcode, ALL_desc, SerialNo, ALL_karat, ALL_carat, ALL_Cost, ALL_Weight,currency, PhotoName,all_price, Cellular_cost, Watch_cost, Repair_cost,"
            SQuery = SQuery + "  Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, LoanDate, Status"
            SQuery = SQuery + "  FROM dbo.ASYS_MLWB_detail where refallbarcode = '" & cboALL.Text & "' and status <> 'RECPRICING'"

            objclass.Command3(SQuery)
            dr = objclass.OpenDataReader3
            If dr.Read Then
                If Trim(dr.Item("STATUS")) = "RECEIVED" Then
                    iItem_id = dr.Item("ItemID")
                    picstr = objclass.IsNull(dr.Item("photoname"))
                    iStatus = Trim(objclass.IsNull(dr.Item("status")))

                    txtBranchCode.Text = Trim(objclass.IsNull(dr.Item("branchcode")))
                    txtbrname.Text = Trim(objclass.IsNull(dr.Item("branchname")))
                    sPTN = Trim(objclass.IsNull(dr.Item("ptn")))
                    'Label44.Text = FormatNumber(objclass.IsNull(dr.Item("LoanValue")))
                    'Label46.Text = objclass.IsNull(dr.Item("Maturitydate"))
                    'Label47.Text = objclass.IsNull(dr.Item("Expirydate"))
                    ComboBox4.Text = UCase(dr.Item("actionclass"))
                    ComboBox5.Text = dr.Item("sortcode")
                    TextBox16.Text = Trim(objclass.IsNull(dr.Item("ptnbarcode")))
                    TextBox15.Text = Trim(objclass.IsNull(dr.Item("ptn")))

                    If Trim(objclass.IsNull(dr.Item("currency"))) = "PHP" Then
                        RadioButton2.Checked = True
                    ElseIf Trim(objclass.IsNull(dr.Item("currency"))) = "USD" Then
                        RadioButton1.Checked = True
                    Else
                        RadioButton2.Checked = True
                    End If

                    ListView1.Items.Add(Trim(objclass.IsNull(CStr(dr.Item("itemid")))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Karatgrading"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Caratsize"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))

                    ListView2.Items.Add(Trim(objclass.IsNull(dr.Item("all_desc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SerialNo"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("refqty"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ALL_Carat"))))

                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(FormatNumber(objclass.IsNull(dr.Item("ALL_Weight")))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_cost"))))
                    txtPrice.Text = FormatNumber(objclass.IsNull(dr.Item("ALL_price")))


                    ListView3.Items.Add(Trim(objclass.IsNull(dr.Item("itemid"))))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cellular_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("watch_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("repair_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("cleaning_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("gold_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("mount_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("YG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("WG_cost")))
                    ListView3.Items(ListView3.Items.Count - 1).SubItems.Add(objclass.IsNull(dr.Item("all_cost")))

                    txtDesc.Enabled = True
                    txtDesc.Focus()
                ElseIf Trim(dr.Item("STATUS")) = "RELEASED" Or Trim(dr.Item("STATUS")) = "RECPRICING" Then
                    MsgBox("ITEM ALREADY RELEASE IN MLWB.", MsgBoxStyle.Information, TitleMsgBox)
                    btnSaveMLWB.Enabled = False
                    cboALL.Text = ""
                    TextBox15.Text = ""
                    cboALL.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Item not found!", MsgBoxStyle.Information, TitleMsgBox)
                btnSaveMLWB.Enabled = False
                cboALL.Text = ""
                TextBox15.Text = ""
                cboALL.Focus()
                Exit Sub
            End If
            dr.Close()
            objclass.Execute3()

            Call List2()

            If File.Exists(picstr) Then
                img = img.FromFile(picstr)
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img
            Else

                img = img.FromFile(loc1 & "\" & "questionmark2" & ".jpg")
                PictureBox1.Show()
                PictureBox1.Image = img
                PictureBox4.Image = img

            End If
            If iStatus = "RECEIVED" Then
                MLWBDisplayAction(ComboBox4.Text, 1)
                If iAction_id = "Cellular" Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                ElseIf iAction_id = "Watch" Then
                    ComboBox5.SelectedIndex = -1
                    ComboBox5.Enabled = False
                End If
            Else
                If iStatus = "RELEASED" Then
                    Button13.Enabled = False
                    Button2.Enabled = True
                ElseIf iStatus = "RECEIVED" Then
                    Button13.Enabled = False
                    Button2.Enabled = True
                Else
                    MsgBox(sStatus, MsgBoxStyle.Exclamation, TitleMsgBox)
                    Button13.Enabled = True
                    Button2.Enabled = True
                End If
            End If
            picStrZoom = picstr
            Button2.Enabled = True
            iRecorded = Nothing
            objclass = Nothing
            txtDesc.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSaveMLWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMLWB.Click
        Dim obj As New clsCommon
        Try
            Dim str As String
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            str = "Update asys_MLWB_detail set all_desc = '" & txtDesc.Text & "', SerialNo = '" & txtSerialNo.Text & "', refqty = " & CStr(txtQty.Text) & ", all_weight = " & CStr(CDbl(txtwt.Text)) & ", all_karat = " & txtKarat.Text & ", all_carat = " & CStr(CDbl(txtcarat.Text)) & ",price_desc = '" & txtDesc.Text & "',  price_weight = " & CStr(CDbl(txtwt.Text)) & ", price_karat = " & txtKarat.Text & ", price_carat = " & CStr(CDbl(txtcarat.Text)) & ", cellular_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(1).Text)) & ", watch_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(2).Text)) & ", Repair_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(3).Text)) & ",cleaning_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(4).Text)) & ",gold_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(5).Text)) & ", mount_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(6).Text)) & ",yg_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(7).Text)) & ",wg_cost = " & CStr(CDbl(ListView3.Items(ListView3.Items.Count - 1).SubItems.Item(8).Text)) & ",all_cost = " & CStr(CDbl(txtCost.Text)) & " where refallbarcode ='" & cboALL.Text.Trim & "' and status = 'RECEIVED'"
            obj.commandTrack(str)
            obj.TrackExecute()

            str = "Update ASYS_BarcodeHistory set Description = '" & txtDesc.Text & "',  Weight = " & CStr(CDbl(txtwt.Text)) & ", Karat = " & txtKarat.Text & ", Carat = " & CStr(CDbl(txtcarat.Text)) & ",cost = " & CStr(CDbl(txtCost.Text)) & " where refallbarcode ='" & cboALL.Text.Trim & "' and COSTCENTER = 'MLWB' and status = 'RECEIVED'"
            obj.commandTrack(str)
            obj.TrackExecute()

            obj.CommitTrack()
            MsgBox("Successfully Edited!", MsgBoxStyle.Information, TitleMsgBox)
            Button2_Click(sender, e)

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox(ex.Message, , TitleMsgBox)
        Finally
            obj.Close()
        End Try
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Try
            If Me.TextBox15.Text <> "" Or Me.cboALL.Text <> "" Or Me.txtBranchCode.Text <> "" Then
                Button2.Enabled = True
            ElseIf Me.TextBox15.Text = "" Then
                Button2.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            If txtBranchCode.Text.Length <> 3 Then
                txtbrname.Text = ""
            End If
            If txtBranchCode.Text <> "" Or Me.TextBox15.Text <> "" Or Me.cboALL.Text <> "" Then
                Button2.Enabled = True
            ElseIf txtBranchCode.Text = "" Then
                Button2.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Try
            Dim frm As New frmPhotoZoom

            If cboALL.Text.Length <= 0 Then
                Exit Sub
            End If

            frm.photoname(picStrZoom)
            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim frm As New frmPhotoZoom

            frm.photoname(picStrZoom)
            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        'Try
        '    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
        '        e.Handled = True
        '    End If
        '    If txtBranchCode.Text.Length > 2 And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
        '        e.Handled = True
        '    End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboALL_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboALL.KeyUp
        Try
            If Me.cboALL.Text <> "" Or Me.TextBox15.Text <> "" Or Me.txtBranchCode.Text <> "" Then
                Button2.Enabled = True
            ElseIf Me.cboALL.Text = "" Then
                Button2.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCarat_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListView2.Items.Item(0).SubItems.Item(3).Text = Me.txtcarat.Text
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtWt_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ListView2.Items.Item(0).SubItems.Item(4).Text = Me.txtwt.Text
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtcarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." Then
                If txtcarat.Text.IndexOf(".") > -1 Then
                    txtcarat.Text = ""
                    e.Handled = False
                End If
            End If

            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtwt.Enabled = False Then
                    LocCur = ""
                    LocCur = "CARAT"
                End If

                'additional trappings
                If txtcarat.Text = "0" Or txtcarat.Text = "0." Or txtcarat.Text = ".0" Or txtcarat.Text = "" Or txtcarat.Text = "." Or txtcarat.Text = ".00" Or txtcarat.Text = "00." Or txtcarat.Text = "0.00" Or txtcarat.Text = "00.0" Or txtcarat.Text = "00.00" Then
                    txtcarat.Text = "00.00"
                    txtwt.Enabled = True
                    txtwt.Focus()
                Else
                    'rounding off decimal values... paopao 03302010
                    Dim giro As Double = txtcarat.Text
                    txtcarat.Text = giro.ToString("##.####")
                    txtwt.Enabled = True
                    txtwt.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtwt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwt.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                e.Handled = True
            End If

            If e.KeyChar = "." Then
                If txtwt.Text.IndexOf(".") > -1 Then
                    txtwt.Text = ""
                    e.Handled = False
                End If
            End If

            If e.KeyChar = ChrW(Keys.Back) Then
                e.Handled = False
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtwt.Text = "" Then
                    Button13.Enabled = False
                End If
            End If
            If RadioButton1.Checked = True And sDB = "" Then
                If e.KeyChar = ChrW(13) Then
                    If txtwt.Text = "" Then
                        'MsgBox("Enter valid value.", MsgBoxStyle.Information)
                        txtwt.Text = 0
                        txtCost.Focus()
                        txtPrice.Enabled = False
                    End If
                    If txtwt.Text = ".0" Or txtwt.Text = "." Or txtwt.Text = ".00" Or txtwt.Text = ".000" Or txtwt.Text = ".0000" Or txtwt.Text = "00.0" Or txtwt.Text = "00.00" Then
                        MsgBox("Weight must not equal to zero.", MsgBoxStyle.Information, TitleMsgBox)
                        txtCost.Enabled = False
                        txtwt.Focus()
                    Else

                        Dim giro As Double = txtwt.Text
                        txtwt.Text = giro.ToString("##.##")
                        txtCost.Enabled = True
                        txtCost.ReadOnly = False
                        txtCost.Focus()
                    End If
                End If
            ElseIf RadioButton1.Checked = False And sDB = "MLWB" Then
                If e.KeyChar = ChrW(Keys.Enter) Then
                    If txtwt.Text = "" Then
                        'MsgBox("Enter valid value.", MsgBoxStyle.Information)
                        txtwt.Text = 0
                        Button13.Focus()
                        txtPrice.Enabled = False
                    End If
                    If txtwt.Text = ".0" Or txtwt.Text = "." Or txtwt.Text = ".00" Or txtwt.Text = ".000" Or txtwt.Text = ".0000" Or txtwt.Text = "00.0" Or txtwt.Text = "00.00" Then
                        MsgBox("Weight must not equal to zero.", MsgBoxStyle.Information, TitleMsgBox)
                        txtCost.Enabled = False
                        txtwt.Focus()
                    Else

                        Dim giro As Double = txtwt.Text
                        txtwt.Text = giro.ToString("##.##")
                        Button13.Focus()
                    End If
                End If
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    If aydi <> "300" Then
                        If txtwt.Text = "0" Or txtwt.Text = ".0" Or txtwt.Text = "." Or txtwt.Text = ".00" Or txtwt.Text = ".000" Or txtwt.Text = ".0000" Or txtwt.Text = "00.0" Or txtwt.Text = "00.00" Then
                            MsgBox("Enter valid weight value.", MsgBoxStyle.Information, TitleMsgBox)
                            txtCost.Enabled = False
                            txtwt.Focus()
                            Exit Try
                        Else
                            Dim giro As Double = txtwt.Text
                            txtwt.Text = giro.ToString("##.##")

                            If ComboBox6.Text <> "" Then
                                txtPrice.Text = Format(RoundedTotal(Format(CDbl(lblPriceA.Text) * txtwt.Text, "#,###,##0.00")), "#,###,#0.00")
                            End If

                            If txtPrice.Text <> "0.00" Then
                                Button13.Enabled = True
                                Button13.Focus()
                            Else
                                txtPrice.Focus()
                            End If

                            'txtPrice.Enabled = True
                            'txtPrice.ReadOnly = True
                            'txtPrice.Focus()
                        End If
                    Else
                        txtPrice.Enabled = True
                        txtPrice.ReadOnly = False
                        txtPrice.Focus()
                    End If
                End If
            End If

            If e.KeyChar = ChrW(13) Then
                If sDB <> "" Then
                    txtCost.Enabled = True
                    txtCost.Focus()
                ElseIf sDB = "" And MainCost = "PRICING" Then
                    If RadioButton1.Checked = True Then
                        txtCost.Enabled = True
                        txtCost.Focus()
                    Else
                        txtCost.Enabled = False
                    End If
                ElseIf MainCost = "MLWB" Then
                    txtPrice.ReadOnly = True
                    txtCost.Enabled = False
                    txtPrice.Enabled = False
                    Button13.Focus()
                ElseIf sDB = "" And MainCost = "REM" Then
                    txtPrice.ReadOnly = True
                    txtCost.Enabled = True
                    txtCost.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txtcarat.Enabled = False Then
                    LocCur = ""
                    LocCur = "KARAT"
                End If

                txtcarat.Enabled = True
                txtcarat.Focus()
            End If

            If e.KeyChar = ChrW(13) Then
                If txtKarat.Text = "" Then
                    txtwt.Enabled = False
                    txtcarat.Enabled = False
                    txtCost.Enabled = False
                    txtPrice.Enabled = False
                    Button13.Enabled = True '201213 gm
                    'MsgBox("Please enter karat value.", MsgBoxStyle.Information)
                    txtKarat.Text = 0
                    txtKarat.Focus()
                    'Exit Sub
                End If
                If aydi = "300" Then
                    txtcarat.Enabled = True
                    txtcarat.Focus()
                Else
                    If txtKarat.Text = "0" Or txtKarat.Text = "0." Or txtKarat.Text = ".0" Or txtKarat.Text = "." Or txtKarat.Text = ".00" Or txtKarat.Text = "00." Or txtKarat.Text = "0.00" Or txtKarat.Text = "00.0" Or txtKarat.Text = "00.00" Then
                        'txtwt.Text = "00.00"
                        MsgBox("Karat must not equal to zero.", MsgBoxStyle.Information, TitleMsgBox)
                        txtcarat.Enabled = False
                        txtKarat.Focus()
                    Else
                        'rounding off decimal values... paopao 03302010
                        Dim giro As Double = txtKarat.Text
                        txtKarat.Text = giro.ToString("##.##")
                        txtcarat.Enabled = True
                        txtcarat.Focus()
                        txtPrice.ReadOnly = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDesc_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesc.KeyUp
        Try
            If txtDesc.Focus = True Then
                If e.KeyCode = Keys.Tab Then
                    'txtQty.Enabled = True
                    'txtQty.Focus()
                    txtSerialNo.Enabled = True
                    txtSerialNo.Focus()

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Try
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Try
            ListView2.Items.Item(0).SubItems.Item(1).Text = Me.txtQty.Text
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtcarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarat.TextChanged
        Try
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtwt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtwt.TextChanged
        Try
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.TextChanged
        Try
            If Me.txtCost.Text = "" Then
                Me.Button13.Enabled = False
            End If
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar <> "1" And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            'If MainCost = "REM" Then
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtKarat.Enabled = False Then
                    LocCur = ""
                    LocCur = "QTY"
                End If

                If aydi = "400" Then
                    If txtQty.Text <> "1" Then
                        txtKarat.Enabled = False
                        txtQty.Focus()
                    Else
                        txtCost.Enabled = True
                        txtCost.Focus()
                    End If
                Else
                    If txtQty.Text <> "1" Then
                        txtKarat.Enabled = False
                        txtQty.Focus()
                    Else
                        txtKarat.Enabled = True
                        txtKarat.Focus()
                    End If
                End If
            End If
            'Else
            '    If e.KeyChar = ChrW(Keys.Enter) Then
            '        If aydi = "400" Then
            '            If txtQty.Text <> "1" Then
            '                txtKarat.Enabled = False
            '                txtQty.Focus()
            '            Else
            '                txtPrice.Enabled = True
            '                txtPrice.Focus()
            '            End If
            '        Else
            '            If txtQty.Text <> "1" Then
            '                txtKarat.Enabled = False
            '                txtQty.Focus()
            '            Else
            '                txtPrice.Enabled = True
            '                txtPrice.Focus()
            '            End If
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtKarat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKarat.TextChanged
        Try
            ListView2.Items.Item(0).SubItems.Item(2).Text = Me.txtKarat.Text
            If txtKarat.Text.StartsWith(0) = True Then
                txtKarat.Text = "0"
            End If
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesc.TextChanged
        Try
            ListView2.Items.Item(0).SubItems.Item(0).Text = Me.txtDesc.Text
            If MainCost = "PRICING" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtPrice.Text = "" Then
                    Button13.Enabled = False
                End If
            ElseIf MainCost = "REM" Then
                If txtDesc.Text = "" Or txtSerialNo.Text = "" Or txtQty.Text = "" Or txtcarat.Text = "" Or txtKarat.Text = "" Or txtCost.Text = "" Then
                    Button13.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        Try
            If e.KeyChar = "?" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "{" Or e.KeyChar = "[" Or e.KeyChar = "}" Or e.KeyChar = "]" Then
                e.Handled = True
            End If
            If e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or e.KeyChar = "+" Or e.KeyChar = "|" Then
                e.Handled = True
            End If
            If e.KeyChar = "*" Or e.KeyChar = "_" Or e.KeyChar = "=" Or e.KeyChar = "`" Or e.KeyChar = "~" Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                If txtQty.Enabled = False Then
                    LocCur = ""
                    LocCur = "DESC"
                End If
                txtSerialNo.Enabled = True
                txtSerialNo.Focus()

                'txtQty.Enabled = True
                'txtQty.Focus()
            End If
            aydi = Mid(cboALL.Text, 1, 3)
            If e.KeyChar = ChrW(Keys.Enter) Then
                If MainCost = "PRICING" Then
                    If aydi = "400" Then
                        txtKarat.Text = 0
                        txtcarat.Text = 0
                        txtwt.Text = 0
                        txtKarat.Enabled = False
                        txtcarat.Enabled = False
                        txtwt.Enabled = False
                        If RadioButton1.Checked = True Then
                            txtCost.Enabled = True
                            txtCost.ReadOnly = False
                            txtCost.Focus()
                        Else
                            txtCost.Enabled = False
                            txtPrice.Enabled = True
                            txtKarat.Enabled = True
                            txtSerialNo.Enabled = True
                            txtSerialNo.Focus()
                        End If
                    Else
                        txtKarat.Enabled = True
                        txtSerialNo.Enabled = True
                        txtSerialNo.Focus()
                    End If
                    Exit Sub
                End If
            ElseIf MainCost = "REM" Then
                If aydi = "400" Then
                    txtKarat.Text = 0
                    txtcarat.Text = 0
                    txtwt.Text = 0
                    txtKarat.Enabled = False
                    txtcarat.Enabled = False
                    txtwt.Enabled = False
                    txtCost.Enabled = False
                    txtSerialNo.Enabled = False
                    txtSerialNo.Focus()

                Else
                    txtKarat.Enabled = True
                    txtSerialNo.Enabled = True
                    txtSerialNo.Focus()
                End If
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtDesc.Text = "" Then
                    txtSerialNo.Enabled = False
                    txtQty.Enabled = False
                    txtKarat.Enabled = False
                    txtwt.Enabled = False
                    txtcarat.Enabled = False
                    txtCost.Enabled = False
                    txtPrice.Enabled = False
                    MsgBox("Please enter item description.", MsgBoxStyle.Information, TitleMsgBox)
                    txtDesc.Focus()
                End If
            End If
            If txtDesc.Text = "" Then
                Button13.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim tmpTwt As Double

            If LocCur = "DESC" Then
                txtSerialNo.Focus()
            ElseIf LocCur = "SERIAL NO." Then
                txtQty.Focus()
            ElseIf LocCur = "QTY" Then
                txtKarat.Focus()
            ElseIf LocCur = "KARAT" Then
                txtcarat.Focus()
            ElseIf LocCur = "CARAT" Then
                txtwt.Focus()
            End If

            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()

            objclass.Command5("SELECT Gold_Karat, Plain FROM ASYS_GOLDKARAT WHERE Gold_Karat = '" & Me.ComboBox6.Text & "'")
            dr = objclass.OpenDataReader5()

            dr.Read()

            If txtwt.Text.Trim.Length <= 0 Then
                tmpTwt = 0
            Else
                tmpTwt = CDbl(txtwt.Text)
            End If


            lblPriceB.Text = "0.00"
            lblPriceA.Text = Format(dr.Item("Plain"), "#,###,##0.00")

            'If LocCur <> "" Then
            txtPrice.Text = Format(RoundedTotal(Format(CDbl(lblPriceA.Text * tmpTwt), "#,###,##0.00")), "#,##0.00") 'Format((CDbl(lblPriceA.Text) + CDbl(lblPriceB.Text)) * txtwt.Text, "#,###,##0.00")
            'End If

            'txtDesc.Focus()
            dr.Close()
            objclass.Close5()

        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
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

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            Dim tmpTwt As Double
            Dim dr As SqlDataReader

            If txtwt.Text.Trim.Length <= 0 Then
                tmpTwt = 0
            Else
                tmpTwt = CDbl(txtwt.Text)

            End If


            '--- THIS IS FOR GOLD KARAT [START] -----
            'objclass.Command5("SELECT GOLD_KARAT FROM ASYS_GOLDKARAT ORDER BY [ID]")
            'dr = objclass.OpenDataReader5()
            'ComboBox6.Items.Clear()
            'While dr.Read
            '    ComboBox6.Items.Add(Trim(dr.Item("GOLD_KARAT")))
            'End While
            'dr.Close()
            'objclass.Close5()
            ComboBox6.Text = ""

            '----- GOLD KARAT [END]------

            lblPriceA.Text = "0.00"
            txtPrice.Text = Format((CDbl(lblPriceA.Text) * CDbl(tmpTwt)) + CDbl(lblPriceB.Text), "#,###,##0.00")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            '-- clear array list --
            ArrGold.Clear()
            ArrDia.Clear()
            ArrPearl.Clear()
            ArrPrecious.Clear()
            ArrSynthetic.Clear()
            ArrMountedTotal.Clear()

            SearchFlag = False
            MountedPrice = 0
            lblPriceB.Text = "0.00"
            '''            txtPrice.Text = Format((CDbl(lblPriceA.Text) * CDbl(txtwt.Text)) + CDbl(lblPriceB.Text), "#,###,##0.00")
            lblPriceB.Text = txtPrice.Text = Format((CDbl(lblPriceA.Text) * CDbl(txtwt.Text)) + CDbl(lblPriceB.Text), "#,###,##0.00") ''''''''gmgmgmgmgmmg add =============
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComboBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox6.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim frm As New frmMountedPricing
            Dim tmptwt As Double

            frm.Tag = Me.cboALL.Text

            SPrice = txtPrice.Text
            Smounted = lblPriceB.Text
            frm.ShowDialog()

            If SearchFlag = True Then
                lblPriceA.Text = "0.00"
                lblPriceB.Text = Format(SPrice, "#,###,##0.00")
                txtPrice.Text = Format(CDbl(SPrice), "#,###,##0.00")
                MountedPrice = 0
                SearchFlag = False
                Button13.Enabled = True
                Button13.Focus()
                ComboBox6.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtSerialNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerialNo.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                ListView2.Items.Item(0).SubItems.Item(0).Text = Me.txtSerialNo.Text
                If txtSerialNo.Text = "" Then
                    txtSerialNo.Text = "0"
                End If
                txtQty.Enabled = True
                txtQty.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmEditPricing/txtSerialNo_keypress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboALL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboALL.SelectedIndexChanged

    End Sub

End Class


