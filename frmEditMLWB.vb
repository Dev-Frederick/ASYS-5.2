Public Class frmEditMLWB
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
    Friend WithEvents btnOUt As System.Windows.Forms.Button
    Friend WithEvents btnNorm As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbrname As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnForced As System.Windows.Forms.Button
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtwt As System.Windows.Forms.TextBox
    Friend WithEvents txtcarat As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtKarat As System.Windows.Forms.TextBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label12 As System.Windows.Forms.Label
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
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboALL As System.Windows.Forms.ComboBox
    Friend WithEvents btnSaveMLWB As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
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
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmpIDNo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEditMLWB))
        Me.btnOUt = New System.Windows.Forms.Button
        Me.btnNorm = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.txtbrname = New System.Windows.Forms.TextBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnForced = New System.Windows.Forms.Button
        Me.Label58 = New System.Windows.Forms.Label
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtwt = New System.Windows.Forms.TextBox
        Me.txtcarat = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.txtKarat = New System.Windows.Forms.TextBox
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.txtDesc = New System.Windows.Forms.TextBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
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
        Me.lblEmpIDNo = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.cboALL = New System.Windows.Forms.ComboBox
        Me.btnSaveMLWB = New System.Windows.Forms.Button
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox27 = New System.Windows.Forms.TextBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
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
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label56 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ListView3 = New System.Windows.Forms.ListView
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOUt
        '
        Me.btnOUt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOUt.Enabled = False
        Me.btnOUt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOUt.Location = New System.Drawing.Point(400, 178)
        Me.btnOUt.Name = "btnOUt"
        Me.btnOUt.Size = New System.Drawing.Size(32, 31)
        Me.btnOUt.TabIndex = 152
        Me.btnOUt.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnOUt, "Cost Outsource Items")
        Me.btnOUt.Visible = False
        '
        'btnNorm
        '
        Me.btnNorm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNorm.Enabled = False
        Me.btnNorm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNorm.Location = New System.Drawing.Point(400, 130)
        Me.btnNorm.Name = "btnNorm"
        Me.btnNorm.Size = New System.Drawing.Size(32, 31)
        Me.btnNorm.TabIndex = 151
        Me.btnNorm.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnNorm, "Cost Items Received from Replicated Data")
        Me.btnNorm.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(456, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 72)
        Me.GroupBox1.TabIndex = 156
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURRENCY"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PHP"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "USD"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Cellular_Cost"
        Me.ColumnHeader22.Width = 103
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Cleaning_Cost"
        Me.ColumnHeader25.Width = 111
        '
        'txtbrname
        '
        Me.txtbrname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbrname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbrname.Location = New System.Drawing.Point(200, 130)
        Me.txtbrname.Name = "txtbrname"
        Me.txtbrname.ReadOnly = True
        Me.txtbrname.Size = New System.Drawing.Size(200, 20)
        Me.txtbrname.TabIndex = 148
        Me.txtbrname.Text = ""
        '
        'ComboBox4
        '
        Me.ComboBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(144, 154)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox4.TabIndex = 129
        '
        'Label19
        '
        Me.Label19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 24)
        Me.Label19.TabIndex = 140
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
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "ALL SORTING CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnForced
        '
        Me.btnForced.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnForced.Enabled = False
        Me.btnForced.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForced.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForced.Location = New System.Drawing.Point(400, 154)
        Me.btnForced.Name = "btnForced"
        Me.btnForced.Size = New System.Drawing.Size(32, 31)
        Me.btnForced.TabIndex = 150
        Me.btnForced.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnForced, "Cost Forced Received Items")
        Me.btnForced.Visible = False
        '
        'Label58
        '
        Me.Label58.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(16, 227)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(112, 16)
        Me.Label58.TabIndex = 149
        Me.Label58.Text = "A.L.L BARCODE"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "YG_Cost"
        Me.ColumnHeader28.Width = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox3.Controls.Add(Me.lblEmpIDNo)
        Me.GroupBox3.Controls.Add(Me.lblName)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(920, 168)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "EDIT"
        '
        'txtwt
        '
        Me.txtwt.BackColor = System.Drawing.SystemColors.Window
        Me.txtwt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtwt.Location = New System.Drawing.Point(688, 80)
        Me.txtwt.MaxLength = 5
        Me.txtwt.Name = "txtwt"
        Me.txtwt.Size = New System.Drawing.Size(80, 16)
        Me.txtwt.TabIndex = 63
        Me.txtwt.Text = ""
        '
        'txtcarat
        '
        Me.txtcarat.BackColor = System.Drawing.SystemColors.Window
        Me.txtcarat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcarat.Location = New System.Drawing.Point(616, 80)
        Me.txtcarat.MaxLength = 5
        Me.txtcarat.Name = "txtcarat"
        Me.txtcarat.Size = New System.Drawing.Size(80, 16)
        Me.txtcarat.TabIndex = 62
        Me.txtcarat.Text = ""
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(768, 120)
        Me.txtPrice.MaxLength = 7
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(144, 23)
        Me.txtPrice.TabIndex = 61
        Me.txtPrice.Text = ""
        '
        'txtCost
        '
        Me.txtCost.BackColor = System.Drawing.Color.White
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCost.Location = New System.Drawing.Point(770, 80)
        Me.txtCost.MaxLength = 7
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(140, 16)
        Me.txtCost.TabIndex = 58
        Me.txtCost.Text = ""
        '
        'txtKarat
        '
        Me.txtKarat.BackColor = System.Drawing.Color.White
        Me.txtKarat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtKarat.Location = New System.Drawing.Point(544, 80)
        Me.txtKarat.MaxLength = 3
        Me.txtKarat.Name = "txtKarat"
        Me.txtKarat.Size = New System.Drawing.Size(72, 16)
        Me.txtKarat.TabIndex = 46
        Me.txtKarat.Text = ""
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.White
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtQty.Location = New System.Drawing.Point(488, 80)
        Me.txtQty.MaxLength = 1
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 16)
        Me.txtQty.TabIndex = 43
        Me.txtQty.Text = ""
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesc.Location = New System.Drawing.Point(10, 80)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(478, 16)
        Me.txtDesc.TabIndex = 40
        Me.txtDesc.Text = ""
        '
        'ListView2
        '
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.BackColor = System.Drawing.SystemColors.Window
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.ListView2.Enabled = False
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 58)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(906, 43)
        Me.ListView2.TabIndex = 39
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "ALL DESCRIPTION"
        Me.ColumnHeader12.Width = 477
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "ALL QTY"
        Me.ColumnHeader13.Width = 58
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ALL KARAT"
        Me.ColumnHeader14.Width = 70
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "ALL CARAT"
        Me.ColumnHeader15.Width = 72
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "ALL WEIGHT"
        Me.ColumnHeader17.Width = 81
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "ALL COST"
        Me.ColumnHeader18.Width = 143
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(688, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "ALL PRICE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ColumnHeader3.Text = "A.L.L. DESCRIPTION"
        Me.ColumnHeader3.Width = 369
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.Width = 41
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "KARAT"
        Me.ColumnHeader5.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CARAT"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 72
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "WEIGHT"
        Me.ColumnHeader9.Width = 78
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "COST"
        Me.ColumnHeader11.Width = 138
        '
        'lblEmpIDNo
        '
        Me.lblEmpIDNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmpIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpIDNo.Location = New System.Drawing.Point(88, 120)
        Me.lblEmpIDNo.Name = "lblEmpIDNo"
        Me.lblEmpIDNo.Size = New System.Drawing.Size(64, 24)
        Me.lblEmpIDNo.TabIndex = 146
        Me.lblEmpIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEmpIDNo.Visible = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(152, 120)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(256, 24)
        Me.lblName.TabIndex = 145
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblName.Visible = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "EMPLOYEE"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Visible = False
        '
        'Label43
        '
        Me.Label43.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label43.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(432, 120)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(104, 24)
        Me.Label43.TabIndex = 137
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Visible = False
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ALL_ValueCost"
        Me.ColumnHeader6.Width = 116
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 50
        Me.ToolTip1.AutoPopDelay = 500
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 10
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
        'cboALL
        '
        Me.cboALL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboALL.ItemHeight = 16
        Me.cboALL.Location = New System.Drawing.Point(144, 226)
        Me.cboALL.MaxLength = 17
        Me.cboALL.Name = "cboALL"
        Me.cboALL.Size = New System.Drawing.Size(256, 24)
        Me.cboALL.TabIndex = 130
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
        Me.btnSaveMLWB.Location = New System.Drawing.Point(688, 450)
        Me.btnSaveMLWB.Name = "btnSaveMLWB"
        Me.btnSaveMLWB.Size = New System.Drawing.Size(80, 40)
        Me.btnSaveMLWB.TabIndex = 155
        Me.btnSaveMLWB.Text = "Save"
        Me.btnSaveMLWB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Item ID"
        Me.ColumnHeader21.Width = 61
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
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 114)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(432, 152)
        Me.GroupBox6.TabIndex = 153
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
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox15.Enabled = False
        Me.TextBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(136, 90)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(240, 23)
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
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 90)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "PTN "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(136, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 24)
        Me.ComboBox1.TabIndex = 72
        Me.ComboBox1.Text = "ComboBox1"
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(152, 48)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(240, 23)
        Me.TextBox16.TabIndex = 132
        Me.TextBox16.Text = "TextBox16"
        Me.TextBox16.Visible = False
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Repair_Cost"
        Me.ColumnHeader24.Width = 88
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(768, 450)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 135
        Me.Button2.Text = "Clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Panel8)
        Me.GroupBox4.Controls.Add(Me.Panel5)
        Me.GroupBox4.Controls.Add(Me.Panel7)
        Me.GroupBox4.Controls.Add(Me.Panel4)
        Me.GroupBox4.Location = New System.Drawing.Point(568, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(360, 263)
        Me.GroupBox4.TabIndex = 133
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button1)
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
        Me.Panel5.Size = New System.Drawing.Size(344, 248)
        Me.Panel5.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(280, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Clear"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button12
        '
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button12.Image = CType(resources.GetObject("Button12.Image"), System.Drawing.Image)
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(280, 192)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(56, 23)
        Me.Button12.TabIndex = 12
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
        Me.Button11.TabIndex = 11
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
        Me.Button10.TabIndex = 10
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
        Me.Label51.Location = New System.Drawing.Point(135, 168)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(81, 23)
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
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(8, 192)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(128, 23)
        Me.Label26.TabIndex = 8
        Me.Label26.Text = "WG CLEANING COST"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(128, 23)
        Me.Label25.TabIndex = 7
        Me.Label25.Text = "YG CLEANING COST"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 144)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(104, 23)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "MOUNT COST"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 23)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "GOLD COST"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(8, 216)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 23)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "A.L.L VALUE"
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
        Me.Panel7.Size = New System.Drawing.Size(344, 248)
        Me.Panel7.TabIndex = 65
        Me.Panel7.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(120, 16)
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
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(240, 176)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(56, 24)
        Me.Button14.TabIndex = 20
        Me.Button14.Text = "Clear"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button15
        '
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.Enabled = False
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(240, 152)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(56, 24)
        Me.Button15.TabIndex = 19
        Me.Button15.Text = "Clear"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(144, 119)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 24)
        Me.Label54.TabIndex = 11
        Me.Label54.Text = "Label54"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.Location = New System.Drawing.Point(56, 192)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 16)
        Me.Label31.TabIndex = 10
        Me.Label31.Text = "A.L.L Value :"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox25
        '
        Me.TextBox25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Location = New System.Drawing.Point(144, 168)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(88, 23)
        Me.TextBox25.TabIndex = 15
        Me.TextBox25.Text = "TextBox25"
        Me.TextBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label33.Location = New System.Drawing.Point(56, 144)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Repair Cost :"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox26
        '
        Me.TextBox26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Location = New System.Drawing.Point(144, 192)
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
        Me.TextBox29.Location = New System.Drawing.Point(144, 144)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(88, 23)
        Me.TextBox29.TabIndex = 14
        Me.TextBox29.Text = "TextBox29"
        Me.TextBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label32.Location = New System.Drawing.Point(40, 168)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 16)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Cleaning Cost :"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.Location = New System.Drawing.Point(48, 120)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(96, 16)
        Me.Label34.TabIndex = 6
        Me.Label34.Text = "Cellular Cost :"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Button3
        '
        Me.Button3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(848, 450)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 136
        Me.Button3.Text = "Close"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label56
        '
        Me.Label56.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(16, 130)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(128, 24)
        Me.Label56.TabIndex = 147
        Me.Label56.Text = "BRANCH CODE"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(96, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(344, 95)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 144
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(608, 450)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 40)
        Me.Button4.TabIndex = 134
        Me.Button4.Text = "Save"
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
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button13.Location = New System.Drawing.Point(688, 450)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(80, 40)
        Me.Button13.TabIndex = 143
        Me.Button13.Text = "Save"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBranchCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtBranchCode.Location = New System.Drawing.Point(144, 130)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.ReadOnly = True
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 131
        Me.txtBranchCode.Text = ""
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Watch_Cost"
        Me.ColumnHeader23.Width = 92
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
        Me.ListView3.Location = New System.Drawing.Point(16, 290)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(904, 40)
        Me.ListView3.TabIndex = 154
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "WG_Cost"
        Me.ColumnHeader29.Width = 81
        '
        'frmEditMLWB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(936, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbrname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnForced)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cboALL)
        Me.Controls.Add(Me.btnSaveMLWB)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.btnOUt)
        Me.Controls.Add(Me.btnNorm)
        Me.Controls.Add(Me.GroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditMLWB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIT ITEM FORM"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub frmEditMLWB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
