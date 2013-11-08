Imports System.Data.SqlClient
Public Class frmREMOutSourceBRcv
    Inherits System.Windows.Forms.Form
    Private type As String
    Private WithEvents cmbItems As System.Windows.Forms.ComboBox
    Private WithEvents cmbsource As System.Windows.Forms.ComboBox
    Private WithEvents cmbbarcode As System.Windows.Forms.TextBox
    'textbox
    Private WithEvents txtAllbarcode As System.Windows.Forms.TextBox
    Private WithEvents txtItemcode As System.Windows.Forms.TextBox
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents txtQty As System.Windows.Forms.TextBox
    Private WithEvents txtWeight As System.Windows.Forms.TextBox
    Private WithEvents txtKarat As System.Windows.Forms.TextBox
    Private WithEvents txtCarat As System.Windows.Forms.TextBox
    Private WithEvents txtPrice As System.Windows.Forms.TextBox

    'button
    Private WithEvents cmdDelete As System.Windows.Forms.Button
    Private WithEvents dataTable As DataTable
    Private arrstr() As String
    Dim lot As String
    Dim dgtb As DataGridTextBoxColumn
    Dim whatto As Boolean

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        CreateGrid()
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLotno As System.Windows.Forms.TextBox
    Friend WithEvents lblReceiver As System.Windows.Forms.Label
    Friend WithEvents lblRDate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtControlNum As System.Windows.Forms.TextBox
    Friend WithEvents lblControlNum As System.Windows.Forms.Label
    Friend WithEvents btnUnRec As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmREMOutSourceBRcv))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblRDate = New System.Windows.Forms.Label
        Me.lblReceiver = New System.Windows.Forms.Label
        Me.txtLotno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtControlNum = New System.Windows.Forms.TextBox
        Me.lblControlNum = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.btnUnRec = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOT NUMBER"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.lblRDate)
        Me.GroupBox1.Controls.Add(Me.lblReceiver)
        Me.GroupBox1.Controls.Add(Me.txtLotno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(272, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 96)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(266, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(24, 20)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "...."
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "(none)"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"OUTSOURCE", "WATCH", "CELLULAR", "RETURN"})
        Me.ComboBox1.Location = New System.Drawing.Point(312, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(96, 21)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(232, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ACTION CLASS"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(293, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 20)
        Me.Button1.TabIndex = 6
        Me.Button1.TabStop = False
        Me.Button1.Text = "NEW LOTNO"
        Me.Button1.Visible = False
        '
        'lblRDate
        '
        Me.lblRDate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRDate.Location = New System.Drawing.Point(96, 64)
        Me.lblRDate.Name = "lblRDate"
        Me.lblRDate.Size = New System.Drawing.Size(136, 24)
        Me.lblRDate.TabIndex = 5
        Me.lblRDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReceiver
        '
        Me.lblReceiver.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReceiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceiver.Location = New System.Drawing.Point(96, 40)
        Me.lblReceiver.Name = "lblReceiver"
        Me.lblReceiver.Size = New System.Drawing.Size(192, 16)
        Me.lblReceiver.TabIndex = 4
        Me.lblReceiver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLotno
        '
        Me.txtLotno.BackColor = System.Drawing.Color.White
        Me.txtLotno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLotno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotno.Location = New System.Drawing.Point(96, 16)
        Me.txtLotno.Name = "txtLotno"
        Me.txtLotno.ReadOnly = True
        Me.txtLotno.Size = New System.Drawing.Size(168, 20)
        Me.txtLotno.TabIndex = 3
        Me.txtLotno.TabStop = False
        Me.txtLotno.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RECEIVE DATE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RECEIVER"
        '
        'DgEntry
        '
        Me.DgEntry.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackgroundColor = System.Drawing.Color.Tan
        Me.DgEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DgEntry.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DgEntry.DataMember = ""
        Me.DgEntry.FlatMode = True
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Tan
        Me.DgEntry.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DgEntry.Location = New System.Drawing.Point(8, 192)
        Me.DgEntry.Name = "DgEntry"
        Me.DgEntry.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DgEntry.SelectionForeColor = System.Drawing.Color.White
        Me.DgEntry.Size = New System.Drawing.Size(816, 264)
        Me.DgEntry.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(736, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ADD ROW"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(504, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(584, 472)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 40)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "ADD"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(744, 472)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(80, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "CLOSE"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(696, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 96)
        Me.GroupBox2.TabIndex = 11
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
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 477)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "TOTAL NO. OF QTY"
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(136, 472)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(40, 24)
        Me.label9.TabIndex = 13
        Me.label9.Text = "0"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(816, 16)
        Me.Label6.TabIndex = 14
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txt2)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txt3)
        Me.GroupBox4.Controls.Add(Me.txt1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(496, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 72)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SEARCH MAXIMUM BARCODE"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(168, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "YEAR"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "SUPPLIER"
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(80, 24)
        Me.txt2.MaxLength = 5
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(72, 20)
        Me.txt2.TabIndex = 2
        Me.txt2.TabStop = False
        Me.txt2.Text = ""
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ITEM CODE"
        '
        'txt3
        '
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(152, 24)
        Me.txt3.MaxLength = 4
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(72, 20)
        Me.txt3.TabIndex = 3
        Me.txt3.TabStop = False
        Me.txt3.Text = ""
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(8, 24)
        Me.txt1.MaxLength = 3
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(72, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.TabStop = False
        Me.txt1.Text = ""
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(664, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "PRINT"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtControlNum)
        Me.GroupBox3.Controls.Add(Me.lblControlNum)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(152, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 72)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SHOWROOM"
        Me.GroupBox3.Visible = False
        '
        'txtControlNum
        '
        Me.txtControlNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtControlNum.Enabled = False
        Me.txtControlNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlNum.Location = New System.Drawing.Point(432, 16)
        Me.txtControlNum.MaxLength = 20
        Me.txtControlNum.Name = "txtControlNum"
        Me.txtControlNum.Size = New System.Drawing.Size(128, 20)
        Me.txtControlNum.TabIndex = 6
        Me.txtControlNum.Text = ""
        '
        'lblControlNum
        '
        Me.lblControlNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlNum.Location = New System.Drawing.Point(344, 16)
        Me.lblControlNum.Name = "lblControlNum"
        Me.lblControlNum.Size = New System.Drawing.Size(104, 23)
        Me.lblControlNum.TabIndex = 5
        Me.lblControlNum.Text = "CONTROL NO."
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(257, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 20)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "...."
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(128, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 16)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "BRANCH NAME"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "BRANCH CODE"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.RadioButton3)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 72)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "RETURN FROM"
        Me.GroupBox5.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(24, 40)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "VIP"
        '
        'RadioButton3
        '
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(24, 16)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "SHOWROOM"
        '
        'btnUnRec
        '
        Me.btnUnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnRec.Image = CType(resources.GetObject("btnUnRec.Image"), System.Drawing.Image)
        Me.btnUnRec.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUnRec.Location = New System.Drawing.Point(424, 472)
        Me.btnUnRec.Name = "btnUnRec"
        Me.btnUnRec.Size = New System.Drawing.Size(80, 40)
        Me.btnUnRec.TabIndex = 21
        Me.btnUnRec.Text = "UNRECEIVED ITEMS"
        Me.btnUnRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUnRec.Visible = False
        '
        'frmREMOutSourceBRcv
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(830, 526)
        Me.Controls.Add(Me.btnUnRec)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmREMOutSourceBRcv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTSOURCE BATCH RECEIVING"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(8) {"A.L.L BARCODE", "ITEM CODE ", "DESCRIPTION", "QTY", "WEIGHT", "KARAT", "CARAT", "PRICE", " "}

            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")

            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 8
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
                'Set its properties
                dgdtblStyle.MappingName = dataTable.TableName 'its table name of dataset
                DgEntry.TableStyles.Add(dgdtblStyle)
                dgdtblStyle.RowHeadersVisible = False
                dgdtblStyle.PreferredRowHeight = 22
                DgEntry.BackgroundColor = Color.White

                DgEntry.ReadOnly = True
                'Take the columns in a GridColumnStylesCollection object and set the size of the individual columns	
                Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 150
                colStyle(1).Width = 65
                colStyle(2).Width = 300
                colStyle(3).Width = 60
                colStyle(4).Width = 60
                colStyle(4).Alignment = HorizontalAlignment.Right
                colStyle(5).Width = 60
                colStyle(5).Alignment = HorizontalAlignment.Right
                colStyle(6).Width = 60
                colStyle(6).Alignment = HorizontalAlignment.Right
                colStyle(7).Width = 60
                colStyle(7).Alignment = HorizontalAlignment.Right
                colStyle(8).Width = 100


                txtAllbarcode = New TextBox
                txtAllbarcode.Width = 150

                txtItemcode = New TextBox
                txtItemcode.Width = 60

                txtDescription = New TextBox
                txtDescription.Width = 300

                txtQty = New TextBox
                txtQty.Width = 60

                txtWeight = New TextBox
                txtWeight.Width = 60

                txtKarat = New TextBox
                txtKarat.Width = 60

                txtCarat = New TextBox
                txtCarat.Width = 60

                txtPrice = New TextBox
                txtPrice.Width = 60

                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtAllbarcode)
                txtAllbarcode.MaxLength = 17
                txtAllbarcode.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtItemcode)
                txtItemcode.MaxLength = 3
                txtItemcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtDescription)
                txtDescription.MaxLength = 150
                txtDescription.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtQty)
                txtQty.MaxLength = 1
                txtQty.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtWeight)
                txtWeight.MaxLength = 5
                txtWeight.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtKarat)
                txtKarat.MaxLength = 2
                txtKarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtCarat)
                txtCarat.MaxLength = 5
                txtCarat.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtPrice)
                txtPrice.MaxLength = 7
                txtPrice.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
        'Take the text box from the second column of the grid where u will be adding the controls of your choice	
    End Sub

    Private Sub Returnaddrow()
        Try
            Dim li_rowd As Integer = dataTable.Rows.Count
            Dim Addrow As String

            If label9.Text = 0 And txtDescription.Text <> "" Then
addrow:
                dataTable.LoadDataRow(arrstr, True)

                txtAllbarcode = New TextBox
                txtAllbarcode.Width = 150

                txtItemcode = New TextBox
                txtItemcode.Width = 60

                txtDescription = New TextBox
                txtDescription.Width = 300

                txtQty = New TextBox
                txtQty.Width = 60

                txtWeight = New TextBox
                txtWeight.Width = 60

                txtKarat = New TextBox
                txtKarat.Width = 60

                txtCarat = New TextBox
                txtCarat.Width = 60

                txtPrice = New TextBox
                txtPrice.Width = 60


                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtAllbarcode)
                txtAllbarcode.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtItemcode)
                txtItemcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtDescription)
                txtDescription.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtQty)
                txtQty.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtWeight)
                txtWeight.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtKarat)
                txtKarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtCarat)
                txtCarat.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtPrice)
                txtPrice.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

                DgEntry(li_rowd, 0) = ""
                DgEntry(li_rowd, 1) = ""
                DgEntry(li_rowd, 2) = ""
                DgEntry(li_rowd, 3) = ""
                DgEntry(li_rowd, 4) = ""
                DgEntry(li_rowd, 5) = ""
                DgEntry(li_rowd, 6) = ""
                DgEntry(li_rowd, 7) = ""
                DgEntry(li_rowd, 8) = "DELETE"


                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            ElseIf li_rowd = dataTable.Rows.Count And txtAllbarcode.Text <> "" And txtAllbarcode.Text.Length = 17 Then
                GoTo addrow
            ElseIf dataTable.Rows.Count = 0 Or txtAllbarcode.Text <> "" And txtAllbarcode.Text.Length = 17 Then
                GoTo addrow
            ElseIf label9.Text <> 0 And txtDescription.Text = "" Then
                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            Else
                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Returnaddrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ALLaddrow()
        Try
            Dim li_rowd As Integer = dataTable.Rows.Count
            Dim Addrow As String

            If label9.Text = 0 And txtDescription.Text <> "" Then
addrow:
                dataTable.LoadDataRow(arrstr, True)

                txtAllbarcode = New TextBox
                txtAllbarcode.Width = 150

                txtItemcode = New TextBox
                txtItemcode.Width = 60

                txtDescription = New TextBox
                txtDescription.Width = 300

                txtQty = New TextBox
                txtQty.Width = 60

                txtWeight = New TextBox
                txtWeight.Width = 60

                txtKarat = New TextBox
                txtKarat.Width = 60

                txtCarat = New TextBox
                txtCarat.Width = 60

                txtPrice = New TextBox
                txtPrice.Width = 60


                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(0), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtAllbarcode)
                txtAllbarcode.MaxLength = 17
                txtAllbarcode.BringToFront()


                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtItemcode)
                txtItemcode.MaxLength = 3
                txtItemcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtDescription)
                txtDescription.CharacterCasing = CharacterCasing.Upper
                txtDescription.MaxLength = 150
                txtDescription.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtQty)
                txtQty.MaxLength = 1
                txtQty.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(4), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtWeight)
                txtWeight.MaxLength = 5
                txtWeight.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(5), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtKarat)
                txtKarat.MaxLength = 2
                txtKarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(6), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtCarat)
                txtCarat.MaxLength = 5
                txtCarat.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(7), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtPrice)
                txtPrice.MaxLength = 7
                txtPrice.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(8), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

                DgEntry(li_rowd, 0) = ""
                DgEntry(li_rowd, 1) = ""
                DgEntry(li_rowd, 2) = ""
                DgEntry(li_rowd, 3) = ""
                DgEntry(li_rowd, 4) = ""
                DgEntry(li_rowd, 5) = ""
                DgEntry(li_rowd, 6) = ""
                DgEntry(li_rowd, 7) = ""
                DgEntry(li_rowd, 8) = "DELETE"


                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            ElseIf li_rowd = dataTable.Rows.Count And txtAllbarcode.Text <> "" And txtAllbarcode.Text.Length = 17 And txtDescription.Text <> "" Then
                GoTo addrow
            ElseIf dataTable.Rows.Count = 0 Or txtAllbarcode.Text <> "" And txtAllbarcode.Text.Length = 17 And txtDescription.Text <> "" Then
                GoTo addrow
            ElseIf label9.Text <> 0 And txtDescription.Text = "" Then
                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            Else
                DgEntry.CurrentCell = New DataGridCell(li_rowd, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Returnaddrow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If RadioButton2.Checked = True Then
                If TextBox1.Text = "" And TextBox2.Text = "" Then
                    MsgBox("Please input branchname", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox1.Focus()
                    Exit Sub
                Else
                    ALLaddrow()
                    'GroupBox4.Enabled = True
                End If
            Else
                ALLaddrow()
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Function GetLotno()
    '    Try
    '        Dim obj As New clsCommon
    '        Dim dr As SqlDataReader
    '        Dim str As String

    '        obj.Connectionstring3()
    '        obj.Open3()
    '        str = "Select Lotno from ASYS_Lotno_Gen"
    '        obj.Command3(str)
    '        dr = obj.OpenDataReader3
    '        If dr.Read Then
    '            GetLotno = dr.Item("lotno") + 1
    '        End If
    '        dr.Close()
    '        obj.Close3()
    '    Catch ex As Exception
    'msgbox(ex.message,,TitleMsgBox)
    '    End Try
    'End Function

    Private Sub frmREMOutSourceBRcv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            txtLotno.Focus()
            txtLotno.BackColor = Color.White
            lblReceiver.Text = UCase(userLog)
            lblRDate.Text = UCase(CStr(MonthName(Now.Month)) + " " + CStr(Now.Day) + ", " + CStr(Now.Year))
            txtLotno.Text = GetNewLotNumber("REM", "") 'GetLotno()
            If RadioButton1.Checked = True Then
                ComboBox1.Text = "OUTSOURCE"
            Else
                ComboBox1.Text = "RETURN"
                btnUnRec.Visible = True
            End If

            btnSave.Enabled = False
            label9.Text = "0"
            'GroupBox4.Enabled = False
            txt1.Focus()
            btnSearch.Focus()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/frmREMOutSourceBRcv_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ALLReturns(ByVal barcode As String)
        Try
            Dim obj1 As New clsCommon
            Dim dr1 As SqlDataReader
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, SQuery As String
            Dim a As Integer
            obj.Connectionstring3()
            obj.Open3()
            ' SQuery = "SELECT     RefallBarcode , PTN, RefItemcode, RefQty, price_desc as [desc],price_karat as karat, price_carat as carat, all_price as cost, price_Weight as wt,status FROM dbo.ASYS_DISTRI_detail  where refallbarcode = '" & barcode & "' and status = 'RELEASED'"

            SQuery = "SELECT dbo.ASYS_Consign_header.Lotno, dbo.ASYS_Consign_header.ConsignCode, dbo.ASYS_Consign_header.ConsignName, "
            SQuery = SQuery + "  dbo.ASYS_Consign_Detail.ALLBarcode as refallbarcode, dbo.ASYS_DISTRI_detail.PTN, dbo.ASYS_DISTRI_detail.RefItemcode, dbo.ASYS_DISTRI_detail.RefQty, "
            SQuery = SQuery + "                      dbo.ASYS_Consign_Detail.Description as [desc], dbo.ASYS_Consign_Detail.Karat, dbo.ASYS_Consign_Detail.Carat, dbo.ASYS_Consign_Detail.Price as cost, dbo.ASYS_Consign_Detail.Grams as wt, "
            SQuery = SQuery + "                      dbo.ASYS_DISTRI_detail.Status"
            SQuery = SQuery + " FROM         dbo.ASYS_Consign_Detail INNER JOIN"
            SQuery = SQuery + "                      dbo.ASYS_Consign_header ON dbo.ASYS_Consign_Detail.Lotno = dbo.ASYS_Consign_header.Lotno INNER JOIN"
            SQuery = SQuery + "                      dbo.ASYS_DISTRI_detail ON dbo.ASYS_Consign_Detail.ALLBarcode = dbo.ASYS_DISTRI_detail.RefALLBarcode"
            SQuery = SQuery + " WHERE   dbo.ASYS_Consign_Detail.ALLBarcode = '" & barcode & "' and  (dbo.ASYS_DISTRI_detail.Status in ('RELEASED')) and dbo.ASYS_Consign_header.ConsignCode = '" & TextBox1.Text.Trim & "' and dbo.ASYS_Consign_header.ConsignName = '" & TextBox2.Text & "'"
            SQuery = SQuery + " order by dbo.ASYS_Consign_Detail.[ID] desc"

            obj.Command3(SQuery)
            dr = obj.OpenDataReader3
            If dr.Read = True Then
                If dataTable.Rows.Count > 1 Then
                    For a = 0 To dataTable.Rows.Count - 1
                        If DgEntry(a, 0) = barcode Then
                            If a <> dataTable.Rows.Count - 1 Then
                                MsgBox("You have entered the same barcode", MsgBoxStyle.Information, TitleMsgBox)
                                'txtAllbarcode.Text = ""

                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                                DgEntry.Focus()

                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                                txtAllbarcode.Focus()
                                Exit For
                            End If

                        Else
                            If a = dataTable.Rows.Count - 1 Then
                                DgEntry(DgEntry.CurrentCell.RowNumber, 0) = barcode
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = UCase(dr.Item("refitemcode"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = UCase(dr.Item("desc"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = UCase(dr.Item("refqty"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = UCase(dr.Item("wt"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = UCase(dr.Item("karat"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = UCase(dr.Item("carat"))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = UCase(FormatNumber(dr.Item("cost")))
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = "DELETE"
                                Returnaddrow()
                            End If
                        End If
                    Next
                Else
                    DgEntry(DgEntry.CurrentCell.RowNumber, 0) = barcode
                    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = UCase(dr.Item("refitemcode"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 2) = UCase(dr.Item("desc"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 3) = UCase(dr.Item("refqty"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 4) = UCase(dr.Item("wt"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 5) = UCase(dr.Item("karat"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 6) = UCase(dr.Item("carat"))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 7) = UCase(FormatNumber(dr.Item("cost")))
                    DgEntry(DgEntry.CurrentCell.RowNumber, 8) = "DELETE"

                    Returnaddrow()
                End If
            Else
                MsgBox("ALLbarcode doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtAllbarcode.Text = ""
                txtAllbarcode.Focus()
            End If

            dr.Close()
            obj.Close3()

            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
            DgEntry.Focus()
            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            DgEntry.Focus()
            btnSave.Enabled = True
            btnEdit.Enabled = True
            txtAllbarcode.Focus()

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/ALLReturns: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ALLOutsource()
        Dim obj As New clsCommon
        Try
            Dim obj1 As New clsCommon
            Dim dr1 As SqlDataReader
            Dim dr As SqlDataReader
            Dim str As String
            Dim a As Integer

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            str = "Select refallbarcode from ASYS_REM_Detail  where refallbarcode = '" & txtAllbarcode.Text & "' union all Select refallbarcode from ASYS_REMOutSOurce_Detail  where refallbarcode = '" & txtAllbarcode.Text & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read = False Then
                If dataTable.Rows.Count > 1 Then
                    For a = 0 To dataTable.Rows.Count - 1
                        If DgEntry(a, 0) = UCase(txtAllbarcode.Text) Then
                            MsgBox("You have entered the same barcode", MsgBoxStyle.Information, TitleMsgBox)
                            'txtAllbarcode.Text = ""

                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                            txtAllbarcode.Focus()
                            Exit For
                        Else
                            If a = dataTable.Rows.Count - 1 Then
                                DgEntry(DgEntry.CurrentCell.RowNumber, 0) = txtAllbarcode.Text
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = Mid(txtAllbarcode.Text, 1, 3)

                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                                DgEntry.Focus()
                                txtDescription.Focus()
                                Exit For
                            End If
                        End If
                    Next
                Else
                    DgEntry(DgEntry.CurrentCell.RowNumber, 0) = txtAllbarcode.Text
                    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = Mid(txtAllbarcode.Text, 1, 3)

                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                    DgEntry.Focus()
                    txtDescription.Focus()
                End If
            Else
                MsgBox("A.L.L. barcode already received.", MsgBoxStyle.Information, TitleMsgBox)
                txtAllbarcode.Text = ""
                txtAllbarcode.Focus()
            End If

            dr.Close()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/ALLOutsource: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close3()
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

    Private Sub txtAllbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAllbarcode.KeyPress
        Try

            If e.KeyChar = ChrW(Keys.Escape) Then
                DgEntry(DgEntry.CurrentCell.RowNumber, 0) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ""
                txtAllbarcode.Focus()
                DgEntry.Focus()
                Exit Try
            End If

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
                Exit Try
            End If

            If e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or e.KeyChar = "*" Or e.KeyChar = "+" Or e.KeyChar = "=" Or e.KeyChar = "_" Or e.KeyChar = "{" Or e.KeyChar = "}" Or e.KeyChar = "<" Or e.KeyChar = ">" Then
                e.Handled = True
                Exit Try
            End If
            If e.KeyChar = ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                If txtAllbarcode.TextLength < 17 Then
                    MsgBox("Please enter a 17-digit A.L.L. barcode", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Try
                End If
            End If

            If txtAllbarcode.Text.Length = 17 Then
                If e.KeyChar = ChrW(13) Then
                    Dim a As Integer
                    Dim status As Integer
                    Dim rply As Integer
                    Dim proceed As String

                    If e.KeyChar = ChrW(13) Then
                        If txtAllbarcode.Text = "" Then
                            MsgBox("Please enter correct A.L.L. barcode", MsgBoxStyle.Information, TitleMsgBox)
                            txtAllbarcode.Focus()
                        ElseIf ITEMBarcode(txtAllbarcode.Text) = False Then
                            MsgBox("Please enter correct A.L.L. barcode", MsgBoxStyle.Information, TitleMsgBox)
                            txtAllbarcode.Focus()
                        ElseIf txtAllbarcode.Text.Length <> 17 Then
                            MsgBox("Please enter correct A.L.L. barcode", MsgBoxStyle.Information, TitleMsgBox)
                            txtAllbarcode.Focus()
                        Else
                            If RadioButton1.Checked = True Then
                                ALLOutsource()
                            Else
                                ALLReturns(txtAllbarcode.Text)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtAllbarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Escape) Then
                DgEntry(DgEntry.CurrentCell.RowNumber, 0) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ""
                txtDescription.Focus()
                DgEntry.Focus()

                Exit Try
            End If

            If e.KeyChar = ChrW(13) Then
                If txtDescription.Text = "" Then
                    MsgBox("Enter A.L.L. barcode description", MsgBoxStyle.Information, TitleMsgBox)
                Else
                    'txtDescription.Text = txtDescription.Text.Replace("'", "`")
                    DgEntry(DgEntry.CurrentCell.RowNumber, 2) = txtDescription.Text
                    DgEntry(DgEntry.CurrentCell.RowNumber, 3) = "1"

                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 4)
                    DgEntry.Focus()
                    txtWeight.Focus()
                End If
            End If
            If e.KeyChar = "!" And e.KeyChar = "@" And e.KeyChar = "$" And e.KeyChar = "%" And e.KeyChar = "^" And e.KeyChar = "&" And e.KeyChar = "*" And e.KeyChar = "(" And e.KeyChar = ")" And e.KeyChar = "_" And e.KeyChar = "=" And e.KeyChar = "+" And e.KeyChar = ChrW(34) Then
                e.Handled = True
            End If
            If e.KeyChar = "," And e.KeyChar = "<" And e.KeyChar = ">" And e.KeyChar = "?" And e.KeyChar = ChrW(96) And e.KeyChar = ChrW(39) And e.KeyChar = ":" And e.KeyChar = ";" And e.KeyChar = ChrW(44) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtDescription_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Try
            End If

            If txtWeight.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If txtWeight.SelectionStart > txtWeight.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If

            If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then 'Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" Then  '
                If e.KeyChar = "0" Then
                    e.Handled = False
                Else
                    e.Handled = True
                    txtWeight.Focus()
                End If
            End If


            If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then 'Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" Then '
                If e.KeyChar = ChrW(Keys.Enter) Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 4) = "0"
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 5)
                    DgEntry.Focus()
                    txtKarat.Focus()
                    Exit Try
                End If
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    If DgEntry(DgEntry.CurrentCell.RowNumber, 1) <> "300" Then
                        If txtWeight.Text = "" Or txtWeight.Text = "." Then  'Or txtWeight.Text.StartsWith(0) Then
                            MsgBox("Can't accept zero(0) or null as weight.", MsgBoxStyle.Information, TitleMsgBox)
                            txtWeight.Focus()
                            Exit Try
                        ElseIf (txtWeight.Text <= 0) Then
                            MsgBox("Can't accept zero(0) or null as weight.", MsgBoxStyle.Information, TitleMsgBox)
                            txtWeight.Focus()
                            Exit Try
                        Else
                            DgEntry(DgEntry.CurrentCell.RowNumber, 4) = CDbl(txtWeight.Text)
                        End If
                    Else
                        If txtWeight.Text = "" Or txtWeight.Text = "." Then  'Or txtWeight.Text.StartsWith(0) Then
                            DgEntry(DgEntry.CurrentCell.RowNumber, 4) = "0"
                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 5)
                            DgEntry.Focus()
                            txtKarat.Focus()
                            Exit Try
                        Else
                            DgEntry(DgEntry.CurrentCell.RowNumber, 4) = CDbl(txtWeight.Text)
                        End If

                    End If

                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 5)
                    DgEntry.Focus()
                    txtKarat.Focus()
                End If
            End If


            If e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = False
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtWeight_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtKarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            'If e.KeyChar = ChrW(13) Then
            '    If txtKarat.Text = "" Then
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = "0"

            '        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
            '        DgEntry.Focus()
            '        txtCarat.Focus()
            '    Else
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = txtKarat.Text

            '        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
            '        DgEntry.Focus()
            '        txtCarat.Focus()
            '    End If
            'End If


            'If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then
            '    If e.KeyChar = "0" Then
            '        e.Handled = False
            '    Else
            '        e.Handled = True
            '        txtKarat.Focus()
            '    End If
            'End If

            If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then
                If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" Then
                    If e.KeyChar = "0" Then
                        e.Handled = False
                    End If
                    If e.KeyChar = ChrW(Keys.Enter) Then
                        If txtKarat.Text = "" Then
                            DgEntry(DgEntry.CurrentCell.RowNumber, 5) = 0
                        Else
                            DgEntry(DgEntry.CurrentCell.RowNumber, 5) = txtKarat.Text
                        End If
                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
                        DgEntry.Focus()
                        txtCarat.Focus()
                    End If
                Else
                    If txtKarat.Text = "0" Or txtKarat.Text = "" Then
                        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = 0
                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
                        DgEntry.Focus()
                        txtCarat.Focus()

                    ElseIf IsNumeric(e.KeyChar) And e.KeyChar <> "0" Then
                        e.Handled = True
                    End If
                End If

            Else
                If e.KeyChar = ChrW(Keys.Enter) Then
                    '''If txtKarat.Text = "" Or txtKarat.Text = "0" Or txtKarat.Text = "00" Then
                    '''    MsgBox("Can't accept zero(0) or null as karat.", MsgBoxStyle.Information, TitleMsgBox)
                    '''    txtKarat.Text = ""
                    '''    txtKarat.Focus()
                    '''Else
                    If txtKarat.Text = "" Then
                        txtKarat.Text = 0
                    End If
                    DgEntry(DgEntry.CurrentCell.RowNumber, 5) = txtKarat.Text
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
                    DgEntry.Focus()
                    txtCarat.Focus()
                    '''End If

                End If
            End If

            'If e.KeyChar = ChrW(Keys.Enter) Then
            '    If (txtKarat.Text = "") Or txtKarat.Text = "00" Then
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = 0
            '    Else
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 5) = txtKarat.Text
            '        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 6)
            '        DgEntry.Focus()
            '        txtCarat.Focus()
            '    End If

            'End If

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtKarat_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtCarat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCarat.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> "." Then
                e.Handled = True
                Exit Try
            End If

            If txtCarat.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If txtCarat.SelectionStart > txtCarat.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If


            'If e.KeyChar = ChrW(13) Then
            '    If txtCarat.Text = "" Then
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = "0"
            '        Button2_Click(sender, e)
            '        btnSave.Enabled = True
            '        btnEdit.Enabled = True
            '        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            '        DgEntry.Focus()
            '        txtAllbarcode.Focus()
            '    Else
            '        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = txtCarat.Text

            '        Button2_Click(sender, e)
            '        btnSave.Enabled = True
            '        btnEdit.Enabled = True
            '        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
            '        DgEntry.Focus()
            '        txtAllbarcode.Focus()
            '    End If
            'End If

            If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then 'Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" 
                If e.KeyChar = "0" Then
                    e.Handled = False
                Else
                    e.Handled = True
                    txtCarat.Focus()
                End If
            End If

            If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "200" Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "400" Then 'Or DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "300" (commented: 2010/12/04)
                If e.KeyChar = ChrW(Keys.Enter) And (txtCarat.Text = "" Or txtCarat.Text = "0") Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 6) = "0"
                    Button2_Click(sender, e)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                    DgEntry.Focus()
                    txtAllbarcode.Focus()
                    'Exit Try <-- nigel comment this so that the code below will perform to enable the save button. anyway this is now use nothing to perform after the above codes will execute. 
                End If
            Else
                If e.KeyChar = ChrW(Keys.Enter) Then

                    If txtCarat.Text = "" Or txtCarat.Text = "." Then
                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = 0
                    Else
                        DgEntry(DgEntry.CurrentCell.RowNumber, 6) = FormatNumber(txtCarat.Text)
                    End If
                    Button2_Click(sender, e)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                    DgEntry.Focus()
                    txtAllbarcode.Focus()

                    '''If dataTable.Rows.Count <> 0 Then '<---- transfer to lower part of the code.
                    '''    btnSave.Enabled = True
                    '''Else
                    '''    btnSave.Enabled = False
                    '''End If

                End If
            End If


            If dataTable.Rows.Count <> 0 Then '<--- i'm here from above's comment.
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If

            If e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = False
            End If



        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtCarat_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgEntry.CurrentCellChanged
        Try

            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 0
                    txtAllbarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0)
                    Exit Select
                Case 1
                    txtItemcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1)
                    Exit Select
                Case 2
                    txtDescription.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2)
                    Exit Select
                Case 3
                    txtQty.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 3)
                    Exit Select
                Case 4
                    txtWeight.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 4)
                    Exit Select
                Case 5
                    txtKarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 5)
                    Exit Select
                Case 6
                    txtCarat.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 6)
                    Exit Select
            End Select

            If txtAllbarcode.Text <> "" Then
                label9.Text = dataTable.Rows.Count
            Else
                label9.Text = dataTable.Rows.Count - 1
            End If

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/DgEntry_CurrentCellChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            txtLotno.Text = GetNewLotNumber("REM", "")
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function IfBarcodeExist(ByVal barcode As String) As Boolean
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("Select refallbarcode from ASYS_BarcodeHistory where refallbarcode = '" & barcode & "'")
            dr = obj.OpenDataReader3
            If dr.Read Then
                IfBarcodeExist = True
            End If
            dr.Close()
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("Form2/IfBarcodeExist: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim obj As New clsCommon
        Try

            Dim dr As SqlDataReader
            Dim rply As Integer
            Dim str As String
            Dim i, u As Integer

            If RadioButton1.Checked = True Then
                type = RadioButton1.Text
            Else
                type = RadioButton2.Text
            End If

            If dataTable.Rows.Count <= 0 Then
                MsgBox("No data to save", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If


            rply = MsgBox("Are you sure you want to save?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
            If rply = vbYes Then

                obj = New clsCommon
                obj.Connectionstring3()
                obj.Opentracker2()
                obj.CreateCom()

                txtLotno.Text = GetNewLotNumber("REM", "")
                str = "Update ASYS_Lotno_Gen  set lotno = '" & Me.txtLotno.Text & "' WHERE BusinessCenter ='REM'"
                obj.commandTrack(str)
                obj.TrackExecute()

                str = "Insert into ASYS_REMOutSource_Header  (Lotno, TYPE)  values ('" & txtLotno.Text & "','" & type & "')"
                obj.commandTrack(str)
                obj.TrackExecute()

                For i = 0 To dataTable.Rows.Count - 1
                    If RadioButton1.Checked = True Then
                        If DgEntry(i, 0) = "" Or DgEntry(i, 0) = "NULL" Then
                            Exit For
                        End If
                        If IfBarcodeExist(DgEntry(i, 0)) = True Then
                            MsgBox("A.L.L Barcode " & DgEntry(i, 0) & " already exist.", MsgBoxStyle.Exclamation, TitleMsgBox)
                            obj.RollBackTrack()
                            Exit Try
                        Else
                            str = "Insert into ASYS_REMOutSource_detail  (Reflotno,lotno,refallbarcode,allbarcode,refitemcode,itemcode,branchitemdesc,refqty,qty,karatgrading,caratsize,weight,actionclass,sortcode,alL_desc,all_karat,all_carat,all_weight,price_desc,price_karat,price_weight,price_carat,sortdate,sortername,receivedate,receiver,status) values ('" & txtLotno.Text & "','" & txtLotno.Text & "','" & DgEntry(i, 0) & "','" & DgEntry(i, 0) & "','" & DgEntry(i, 1) & "','" & DgEntry(i, 1) & "','" & Replace(DgEntry(i, 2), "'", "''") & "','" & DgEntry(i, 3) & "','" & DgEntry(i, 3) & "','" & DgEntry(i, 5) & "','" & DgEntry(i, 6) & "','" & DgEntry(i, 4) & "','" & ComboBox1.Text & "','O','" & Replace(DgEntry(i, 2), "'", "''") & "','" & DgEntry(i, 5) & "','" & DgEntry(i, 6) & "','" & DgEntry(i, 4) & "','" & Replace(DgEntry(i, 2), "'", "''") & "','" & DgEntry(i, 5) & "','" & DgEntry(i, 4) & "','" & DgEntry(i, 6) & "',getdate(),'" & userLog & "',getdate(),'" & Trim(lblReceiver.Text) & "','RECEIVED')"
                            obj.commandTrack(str)
                            obj.TrackExecute()

                            str = " insert into ASYS_BarcodeHistory  (lotno,refallbarcode,allbarcode,itemcode,[description],karat,carat,weight,"
                            str = str + " empname,trandate,costcenter,status)"
                            str = str + " values ('" & txtLotno.Text & "','" & DgEntry(i, 0) & "','" & DgEntry(i, 0) & "',"
                            str = str + " '" & DgEntry(i, 1) & "','" & Replace(DgEntry(i, 2), "'", "''") & "',"
                            str = str + " '" & DgEntry(i, 5) & "','" & DgEntry(i, 6) & "',"
                            str = str + " '" & DgEntry(i, 4) & "','" & userLog & "',getdate(),'REM','RECEIVED')"
                            obj.commandTrack(str)
                            obj.TrackExecute()
                        End If


                    Else
                        str = "insert into ASYS_REMOutsource_detail  (RefLotno, Lotno, RefallBarcode, ALLbarcode, PTN, PTNbarcode, BranchCode, BranchName, Loanvalue, LoanDate, RefItemcode, Itemcode, BranchItemDesc, "
                        str = str + "                      RefQty, Qty, KaratGrading, CaratSize, Weight, ActionClass, SortCode, ALL_desc, ALL_karat, ALL_carat, ALL_Cost, ALL_weight, "
                        str = str + "   		      Currency, PhotoName, Price_desc, Price_karat, Price_weight, Price_carat, AppraiseValue, ALL_price, Cellular_cost, "
                        str = str + "   		      Watch_cost, Repair_cost, Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, Receivedate, Receiver, status)"
                        str = str + "   SELECT     '" & txtLotno.Text & "' as reflotno,'" & txtLotno.Text & "' as lotno, RefALLBarcode, refALLbarcode as ALLBarcode, PTN, PTNBarcode, '" & TextBox1.Text.Trim & "' as  BranchCode,'" & TextBox2.Text.Trim & "' as BranchName, Loanvalue, LoanDate, "
                        str = str + "   	  	      RefItemcode, ItemCode , BranchItemDesc, RefQty, Qty, KaratGrading, CaratSize, Weight, '" & ComboBox1.Text & "', SortCode,"
                        str = str + "   		      price_desc as all_desc,price_karat as all_karat,price_carat as all_carat,ALL_Cost,price_weight as all_weight,  Currency,"
                        str = str + "   		      PhotoName, Price_desc, Price_karat,  Price_weight,Price_carat,AppraiseValue, ALL_price, Cellular_cost, Watch_cost, Repair_cost,"
                        str = str + "    		      Cleaning_cost, Gold_cost, Mount_cost, YG_cost, WG_cost, MaturityDate, ExpiryDate, getdate(), '" & Trim(lblReceiver.Text) & "', 'COSTED' as status"
                        str = str + "   FROM         dbo.ASYS_DISTRI_detail  where refallbarcode = '" & DgEntry(i, 0) & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = " insert into ASYS_BarcodeHistory  (lotno,RefALLBarcode, allbarcode,itemcode,[description],karat,carat,weight,currency,price,cost,empname,trandate,costcenter,status)"
                        str = str + " SELECT     '" & txtLotno.Text & "' as lotno, RefALLBarcode,RefALLBarcode as allbarcode,  RefItemcode, Price_desc, Price_karat, Price_carat, "
                        str = str + " Price_weight, Currency, ALL_price, ALL_Cost,'" & userLog & "' as empname,getdate() as trandate,'REM' as costcenter,'RETURNED' as status"
                        str = str + " FROM dbo.ASYS_DISTRI_detail  where refallbarcode = '" & DgEntry(i, 0) & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = "Update [REMS].dbo.ASYS_Distri_detail  set status = 'RETURNED' where refallbarcode = '" & DgEntry(i, 0) & "' and status = 'RELEASED'"
                        obj.commandTrack(str)
                        obj.TrackExecute()

                        str = "Update [REMS].dbo.ASYS_Returned_Header  set HOStatus = 1 where stocksreturnnumber = '" & txtControlNum.Text.Trim & "' and bedrnr = '" & TextBox1.Text & "'"
                        obj.commandTrack(str)
                        obj.TrackExecute()
                    End If

                Next

                obj.CommitTrack()
                MsgBox("SAVE SUCCESSFULLY", MsgBoxStyle.Information, TitleMsgBox)
                lot = txtLotno.Text
                txtLotno.Text = GetNewLotNumber("REM", "")
                btnSave.Enabled = False
                btnEdit.Enabled = True
                txt1.Text = ""
                txt2.Text = ""
                txt3.Text = ""
                dataTable.Clear()
                label9.Text = 0
            Else
                MsgBox("Transaction Cancelled", MsgBoxStyle.Information, TitleMsgBox)
            End If

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("Transaction Not Saved: " & ex.Message, , TitleMsgBox)
        Finally
            obj.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try

            Dim frm As New frmOutSourceAdd_Edit
            frm.BringToFront()
            frm.ShowDialog()

            'Me.Dispose()
            'Me.Close()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/btnEdit_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub deleteRow(ByVal hi As DataGrid.HitTestInfo, ByVal ab_isEmpty As Boolean)
        Try
            If Not ab_isEmpty Then
                'If deleteData(hi) Then
                '    dataTable.Rows.RemoveAt(hi.Row)
                'Else
                '    MsgBox("Error in removing data!", MsgBoxStyle.YesNo, "Error!")
                'End If
                dataTable.Rows.RemoveAt(hi.Row)
            Else
                dataTable.Rows.RemoveAt(hi.Row)
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/deleteRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub dgEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try
            Dim hi As DataGrid.HitTestInfo
            Dim pt = New Point(e.X, e.Y)
            Dim hit As DataGrid.HitTestInfo = DgEntry.HitTest(pt)

            hi = DgEntry.HitTest(e.X, e.Y)

            If hi.Column = 1 Then
                DgEntry.CurrentCell = New DataGridCell(hit.Row, hit.Column)
                DgEntry.Select(hit.Row)
            End If
            Dim repz As String

            If hi.Column = 8 And hi.Row >= 0 Then
                repz = MsgBox("Are you sure you want to delete the selected item?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, TitleMsgBox)
                If repz = vbYes Then
                    If DgEntry(hi.Row, 1) <> "" Then
                        deleteRow(hi, False)
                        label9.Text = dataTable.Rows.Count
                    Else
                        deleteRow(hi, True)
                        label9.Text = dataTable.Rows.Count
                    End If
                Else
                    cmdDelete.BringToFront()
                End If
            End If

            If txtAllbarcode.Text = "" Then
                label9.Text = dataTable.Rows.Count
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                DgEntry.Focus()
                txtAllbarcode.Focus()
            End If
            If label9.Text = 0 Then
                btnSave.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/dgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function deleteData(ByVal hi As DataGrid.HitTestInfo) As Boolean
        Try
            Dim cm As New SqlClient.SqlCommand
            Dim ls_sql As String

            If cmdDelete.Text = "DELETE" Then
                deleteData = True
            Else
                deleteData = False
            End If

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/deleteData: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            deleteData = False
        End Try
    End Function

    Private Sub txtLotno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLotno.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If Me.txtLotno.Text.Length > 9 And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtLotno_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtItemcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtItemcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(Keys.Enter) Then
                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 4)
                DgEntry.Focus()
                txtWeight.Focus()
            End If

        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtQty_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then

                If Me.txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Then
                    MsgBox("Fill all the fields!", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If

                If txt3.Text.Length <> 4 Then
                    MsgBox("Please input a value year.", MsgBoxStyle.Information, TitleMsgBox)
                    txt3.Text = ""
                    txt3.Focus()
                    Exit Sub
                End If

                ALLaddrow()
                If DgEntry.VisibleRowCount > 0 Then

                    Dim obj As New clsCommon
                    Dim dr As SqlDataReader
                    Dim str, str1 As String
                    Dim maxbarc As String

                    If Me.txt1.Text = "" Or txt2.Text = "" Or txt3.Text = "" Then
                        MsgBox("Fill all the fields!", MsgBoxStyle.Information, TitleMsgBox)
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
                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                            DgEntry.Focus()
                            txtAllbarcode.Focus()

                        End If
                        dr.Close()
                        'obj.Execute3()
                        obj.Close3()
                        obj = Nothing
                        txt1.Text = ""
                        txt2.Text = ""
                        txt3.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txt3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub txt1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txt1.Text = "" Then
                    txt1.Focus()
                Else
                    If txt1.Text = "101" Or txt1.Text = "102" Or txt1.Text = "103" Or txt1.Text = "104" Or txt1.Text = "105" Or txt1.Text = "106" Or txt1.Text = "107" Or txt1.Text = "108" Or txt1.Text = "109" Or txt1.Text = "110" Or txt1.Text = "400" Or txt1.Text = "300" Then
                        txt2.Focus()
                    Else
                        MsgBox("Please input correct item code.", MsgBoxStyle.Information, TitleMsgBox)
                        txt1.Text = ""
                        txt1.Focus()
                    End If


                End If

                'If txt1.Text.Length < 3 Then
                '    MsgBox("Please input a value item code.", MsgBoxStyle.Information, TitleMsgBox)
                '    txt1.Text = ""
                '    txt1.Focus()
                'End If

            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txt1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txt2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txt2.Text = "" Then
                    txt2.Focus()
                Else
                    txt3.Focus()
                End If

                If txt2.Text.Length < 5 Then
                    MsgBox("Please input a valid supplier.", MsgBoxStyle.Information, TitleMsgBox)
                    txt2.Text = ""
                    txt2.Focus()
                    Exit Sub
                End If

            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txt2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub txtAllbarcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAllbarcode.TextChanged
    '    If txtAllbarcode.Text.Length = 17 Then
    '        btnEdit.Enabled = True
    '    ElseIf txtAllbarcode.Text.Length <> 17 Then
    '        btnEdit.Enabled = False
    '    End If
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim frm As New frmOutSource_Return
            outsource = True
            sDB = ""

            If Me.RadioButton1.Checked = True Then
                SelectedType = RadioButton1.Text
            Else
                SelectedType = RadioButton2.Text
            End If

            'frm.txtlotno.Text = txtLotno.Text
            frm.txtlotno.Text = lot
            frm.cmbEmp.Text = UCase(userLog)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Try
            GroupBox4.Visible = False
            GroupBox3.Visible = True
            GroupBox5.Visible = True
            ComboBox1.Text = "RETURN"
            ComboBox1.Enabled = False 'gm 03-13-2013
            lblControlNum.Visible = True
            txtControlNum.Visible = True
            btnUnRec.Visible = True
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Try
            GroupBox4.Visible = True
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            ComboBox1.Text = "OUTSOURCE"
            btnUnRec.Visible = False
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Try
            Button2.Enabled = True
            Label11.Text = "BRANCH CODE"
            Label12.Text = "BRANCH NAME"
            GroupBox3.Text = "SHOWROOM"
            TextBox2.Focus()
            whatto = True
            btnUnRec.Visible = True
            txtControlNum.Visible = True
            lblControlNum.Visible = True
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton3_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader


            If e.KeyChar = ChrW(13) Then
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                If RadioButton3.Checked = True Then

                    obj.Command3("Select branchname,branchcode from ASYS_BranchAddress where Branchname like '%" & TextBox2.Text.Trim & "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("BranchName")))
                        TextBox1.Text = Trim(obj.IsNull(dr.Item("Branchcode")))
                    Else
                        MsgBox("Branchname not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox2.Text = String.Empty
                        TextBox1.Text = String.Empty
                        TextBox2.Focus()
                    End If
                    dr.Close()
                Else

                    obj.Command3("Select customerid,customerfname,customerlname from ASYS_CreateCustInfo where CustomerLname like '%" + TextBox2.Text.Trim + "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox1.Text = obj.IsNull(dr.Item("customerid"))
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("customerfname"))) + " " + Trim(obj.IsNull(dr.Item("CustomerLname")))
                    Else
                        MsgBox("Customer name not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox2.Focus()
                    End If
                    dr.Close()
                End If
                obj.Close3()
                obj = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/TextBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                If RadioButton3.Checked = True Then

                    obj.Command3("Select branchname,branchcode from ASYS_BranchAddress where Branchcode like '%" & TextBox1.Text.Trim & "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("BranchName")))
                        TextBox1.Text = Trim(obj.IsNull(dr.Item("Branchcode")))
                    Else
                        MsgBox("Branchname not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Text = String.Empty
                        TextBox2.Text = String.Empty
                        TextBox1.Focus()
                    End If
                    dr.Close()
                Else

                    obj.Command3("Select customerid,customerfname,customerlname from ASYS_CreateCustInfo where customerid like '%" + TextBox1.Text.Trim + "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox1.Text = obj.IsNull(dr.Item("customerid"))
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("customerfname"))) + " " + Trim(obj.IsNull(dr.Item("CustomerLname")))
                    Else
                        MsgBox("Customer name not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Focus()
                    End If
                    dr.Close()
                End If
                obj.Close3()
                obj = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim frm As New frmBranchInfo
            frm.WhatDisplay(whatto)
            frm.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            GroupBox4.Visible = False
            GroupBox3.Visible = True
            GroupBox5.Visible = True
            ComboBox1.Text = "RETURN"

            Button2.Enabled = True
            TextBox1.Focus()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton2_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            GroupBox4.Visible = True
            GroupBox3.Visible = False
            GroupBox5.Visible = False
            ComboBox1.Text = "OUTSOURCE"
            ComboBox1.Enabled = True '03-13-2013 gm
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton1_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CustBranch(ByVal check As Boolean)
        Try
            If Me.RadioButton3.Text = "SHOWROOM" Then
                Label11.Text = "BRANCH CODE"
                Label12.Text = "BRANCH NAME"
                TextBox1.ReadOnly = False
                TextBox2.ReadOnly = False
                TextBox2.Focus()
                whatto = True
            Else
                Label11.Text = "CUSTOMER ID"
                Label12.Text = "CUSTOMER NAME"
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True
                TextBox2.Focus()
                whatto = False
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/CustBranch: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Try
            Button2.Enabled = True
            Label11.Text = "CUSTOMER ID"
            Label12.Text = "CUSTOMER NAME"
            GroupBox3.Text = "VIP"
            TextBox2.Focus()
            whatto = False
            btnUnRec.Visible = False
            txtControlNum.Visible = False
            lblControlNum.Visible = False


        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/RadioButton4_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles label9.Click
        Try
            If label9.Text <> "0" Then
                btnSave.Enabled = True
            Else
                btnSave.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/label9_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtAllbarcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAllbarcode.TextChanged
        Try

            If txtAllbarcode.Text.StartsWith(0) Then
                txtAllbarcode.Text = ""
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/txtAllbarcode_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub txtKarat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKarat.TextChanged
    '    Try
    '        'If txtItemcode.Text <> "300" Then
    '        '    If txtKarat.Text.StartsWith(0) = True Then
    '        '        txtKarat.Text = ""
    '        '    End If
    '        'End If

    '    Catch ex As Exception
    '        MsgBox("frmREMOutSourceBRcv/txtKarat_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '    End Try
    'End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frm As New frmSearchLotno
            If Me.RadioButton1.Checked = True Then
                SelectedType = RadioButton1.Text
            Else
                SelectedType = RadioButton2.Text
            End If

            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/btnSearch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescription.LostFocus
        Try
            txtDescription.Text = txtDescription.Text.Replace("'", "''")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If TextBox1.Text.Length >= 3 Then
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                If RadioButton3.Checked = True Then

                    obj.Command3("Select branchname,branchcode from ASYS_BranchAddress where Branchcode like '%" & TextBox1.Text.Trim & "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("BranchName")))
                        TextBox1.Text = Trim(obj.IsNull(dr.Item("Branchcode")))
                        txtControlNum.Enabled = True
                        txtControlNum.Focus()
                        Button2.Enabled = True
                    Else
                        MsgBox("Branch name not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Text = String.Empty
                        TextBox2.Text = String.Empty
                        TextBox1.Focus()
                    End If
                    dr.Close()
                Else

                    obj.Command3("Select customerid,customerfname,customerlname from ASYS_CreateCustInfo where customerid like '%" + TextBox1.Text.Trim + "%'")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        TextBox1.Text = obj.IsNull(dr.Item("customerid"))
                        TextBox2.Text = Trim(obj.IsNull(dr.Item("customerfname"))) + " " + Trim(obj.IsNull(dr.Item("CustomerLname")))
                        txtControlNum.Enabled = True
                        Button2.Enabled = True
                    Else
                        MsgBox("Customer name not found", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Focus()
                    End If
                    dr.Close()
                End If
                obj.Close3()
                obj = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmREMOutSourceBRcv/TextBox1_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub DgEntry_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgEntry.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Escape) Then
                DgEntry(DgEntry.CurrentCell.RowNumber, 0) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ""
                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ""
                txtDescription.Focus()
                'txtAllbarcode.Focus()
                DgEntry.Focus()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If

            If e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar = ChrW(Keys.Decimal) Then
                e.Handled = True
            End If

            If txtCarat.Text.IndexOf(".") > -1 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                If txtCarat.SelectionStart > txtCarat.Text.IndexOf(".") Then
                    If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                        e.Handled = True
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub txt3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt3.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnUnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnRec.Click
        Dim frm As New frmUnreceivedReport
        frm.GetDepartment("RETURN", 0, 0)
        frm.ShowDialog()
    End Sub

    Private Sub DgEntry_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DgEntry.Navigate

    End Sub

    Private Sub txtControlNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtControlNum.TextChanged
        If txtControlNum.Text.Length > 1 Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub txtControlNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtControlNum.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "-" Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                Dim sQuery As String
                Dim li_row As Integer
                Dim con As New clsCommon
                Dim com As SqlCommand
                Dim conn As New clsCommon
                Dim dr As SqlDataReader
                Dim dr1 As SqlDataReader



                If Me.txtControlNum.Text = "" Then
                    MsgBox("Please input Control No.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                Else
                    dataTable.Rows.Clear()
                    li_row = 0
                    con.Connectionstring3()
                    con.Open3()
                    sQuery = "ASYS_GetReturnStocks '" & txtControlNum.Text.Trim & "'"
                    con.Command3(sQuery)
                    dr = con.OpenDataReader3
                    While dr.Read
                        dataTable.LoadDataRow(arrstr, True)
                        DgEntry(li_row, 0) = con.IsNull(dr.Item("itemcode"))
                        DgEntry(li_row, 1) = con.IsNull(dr.Item("itemgroup"))
                        DgEntry(li_row, 2) = con.IsNull(dr.Item("description"))
                        DgEntry(li_row, 3) = con.IsNull(dr.Item("itemqty"))
                        DgEntry(li_row, 4) = con.IsNull(dr.Item("price_weight"))
                        DgEntry(li_row, 5) = con.IsNull(dr.Item("price_Karat"))
                        DgEntry(li_row, 6) = con.IsNull(dr.Item("price_carat"))
                        DgEntry(li_row, 7) = FormatNumber(con.IsNull(dr.Item("SalesPackagePrice")))
                        DgEntry(li_row, 8) = "DELETE"
                        li_row = li_row + 1
                    End While
                    dr.Close()
                    con.Close3()

                    btnSave.Enabled = True
                    btnSave.Focus()
                End If
            End If

        Catch ex As Exception
            MsgBox("txtControlNum_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
