Imports System.Data.SqlClient
Public Class frmListReceiver
    Inherits System.Windows.Forms.Form
    Private objclass As clsCommon
    Private odatetime As clsCommon.DateTime
    Private sUserID, sDivision As String()
    Private Const s_Jewelry As String = "Jewelry"
    Private Const s_Appliance As String = "Appliance"
    Private Const s_Watch As String = "Watch"
    Private Const s_Cellular As String = "Cellular"
    Private Const s_Missing As String = "Missing Item"

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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
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
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmListReceiver))
        Me.Label18 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
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
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Receiver :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(88, 8)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(208, 24)
        Me.ComboBox3.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(616, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 23)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "BC"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(648, 8)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 23)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.Text = ""
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(424, 8)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(184, 24)
        Me.ComboBox4.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(312, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Branch Name "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(784, 108)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Details"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Window
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 20)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(760, 74)
        Me.ListView1.TabIndex = 29
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 77
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Desc."
        Me.ColumnHeader2.Width = 206
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "QTY"
        Me.ColumnHeader3.Width = 59
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Karat"
        Me.ColumnHeader4.Width = 61
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Carat"
        Me.ColumnHeader5.Width = 61
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sorting Class"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 98
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Weight"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 78
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Appraised Value"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader22, Me.ColumnHeader12, Me.ColumnHeader10, Me.ColumnHeader28, Me.ColumnHeader11, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(8, 40)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(784, 272)
        Me.ListView2.TabIndex = 28
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "No"
        Me.ColumnHeader13.Width = 32
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Action"
        Me.ColumnHeader22.Width = 111
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "PTN"
        Me.ColumnHeader12.Width = 123
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Barcode"
        Me.ColumnHeader10.Width = 112
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "MPTN"
        Me.ColumnHeader28.Width = 97
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "ID #."
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Name"
        Me.ColumnHeader14.Width = 192
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Address"
        Me.ColumnHeader15.Width = 240
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "City"
        Me.ColumnHeader16.Width = 87
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Gender"
        Me.ColumnHeader17.Width = 89
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Tel."
        Me.ColumnHeader18.Width = 75
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Pawn Ticket Time"
        Me.ColumnHeader19.Width = 130
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Pawn Ticket Date"
        Me.ColumnHeader20.Width = 132
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Appraiser"
        Me.ColumnHeader21.Width = 189
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Appraised Value"
        Me.ColumnHeader23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader23.Width = 138
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Loan Value"
        Me.ColumnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader24.Width = 128
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Loan Date"
        Me.ColumnHeader25.Width = 112
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Maturity Date"
        Me.ColumnHeader26.Width = 123
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Expiry Date"
        Me.ColumnHeader27.Width = 138
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(648, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Clear"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(568, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Receive"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 496)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(536, 16)
        Me.ProgressBar1.TabIndex = 46
        Me.ProgressBar1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 1
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(728, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 40)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Close"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(40, 424)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 40)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Count PTN"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(136, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Jewelry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(240, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 50
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(240, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 51
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(136, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Appliance"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(360, 424)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Watch"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(360, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Cellular"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(464, 424)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 23)
        Me.Label8.TabIndex = 55
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(464, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 56
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(584, 424)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Missing Item"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(688, 424)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 23)
        Me.Label12.TabIndex = 58
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(552, 23)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Press action key :   J - Jewelry    A - Appliance    W- Watch    C - Cellular  M " & _
        "- Missing Item"
        '
        'frmListReceiver
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(808, 527)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ComboBox3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 554)
        Me.MinimumSize = New System.Drawing.Size(816, 554)
        Me.Name = "frmListReceiver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receiving by Branch"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmListReceiver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dr As SqlDataReader
        Dim i As Integer

        objclass = New clsCommon
        objclass.ConnDb()
        objclass.Open5()
        objclass.Command5("select fullname, res_id from " & humres2 & " where emp_stat = 'A' and comp='001' and (job_title like 'ALL%' or Job_title ='SORTER') order by fullname")
        dr = objclass.OpenDataReader5
        i = 0
        ComboBox3.Items.Clear()
        While dr.Read
            ReDim Preserve sUserID(i)
            ComboBox3.Items.Add(Trim(dr.Item("fullname")))
            sUserID(i) = Trim(dr.Item("res_id"))
            i = i + 1
        End While
        dr.Close()
        objclass.Close5()
        objclass = Nothing

        objclass = New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select distinct a.division, b.bedrnm from tbl_pt_tran a inner join dbo.vw_bedryf b on a.division = b.bedrnr where a.pulloutstocks = 1 and a.transtype = 'PRENDA' order by b.bedrnm")
        dr = objclass.OpenDataReader
        i = 0
        ComboBox4.Items.Clear()
        While dr.Read
            ReDim Preserve sDivision(i)
            ComboBox4.Items.Add(Trim(objclass.IsNull(dr.Item("bedrnm"))))
            sDivision(i) = Trim(objclass.IsNull(dr.Item("division")))
            i = i + 1
        End While
        dr.Close()
        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing
    End Sub
    Private Sub RetreivePTN()
        TextBox1.Text = sDivision(ComboBox4.SelectedIndex)
        Dim dr As SqlDataReader
        objclass = New clsCommon
        odatetime = New clsCommon.DateTime
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select * from tbl_pt_tran where division = " + TextBox1.Text + " and pulloutstocks = 1 and transtype <> 'LUKAT' and received = 0 order by ptn")
        dr = objclass.OpenDataReader
        ListView2.Items.Clear()
        While dr.Read
            ListView2.Items.Add(ListView2.Items.Count + 1)
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ptn"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ptn_barcode"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("mptn"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("custid"))))

            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(dr.Item("custfirstname")) + " " + Trim(dr.Item("custlastname")) + " " + Trim(dr.Item("custmiddleinitial")))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("custadd"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("custcity"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("custgender"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("custtelno"))))
            odatetime.Split(dr.Item("Transdate"))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(odatetime.Time))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(odatetime.PTNDate))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Appraiser"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(Trim(objclass.IsNull(dr.Item("AppraiseValue")))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(Trim(objclass.IsNull(dr.Item("PTNPrincipal"))), 0))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("LoanDate"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("MaturityDate"))))
            ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ExpiryDate"))))
        End While
        dr.Close()
        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing
    End Sub

    Private Sub ComboBox4_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectionChangeCommitted
        If ComboBox3.SelectedIndex = -1 Then
            MsgBox("Select Receiver.", MsgBoxStyle.Information, TitleMsgBox)
            ComboBox4.SelectedIndex = -1
            Exit Sub
        End If
        Call RetreivePTN()
    End Sub
    Private Sub ListView2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView2.KeyUp
        If e.KeyValue = e.KeyCode.J Then
            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If
            ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text = s_Jewelry
        ElseIf e.KeyValue = e.KeyCode.A Then
            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If
            ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text = s_Appliance
        ElseIf e.KeyValue = e.KeyCode.W Then
            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If
            ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text = s_Watch
        ElseIf e.KeyValue = e.KeyCode.C Then
            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If
            ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text = s_Cellular
        ElseIf e.KeyValue = e.KeyCode.M Then
            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If
            ListView2.Items(ListView2.FocusedItem.Index).SubItems(1).Text = s_Missing
        End If
        ListView2.Focus()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged
        Dim dr As SqlDataReader
        Dim MPTN As String
        objclass = New clsCommon
        MPTN = ListView2.Items(ListView2.FocusedItem.Index).SubItems(4).Text
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select * from tbl_ptn_item where mptn = " + MPTN + " order by itemcode")
        ListView1.Items.Clear()
        dr = objclass.OpenDataReader
        While dr.Read
            ListView1.Items.Add(Trim(dr.Item("ItemCode")))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("PTNItemDesc"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Quantity"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("SortingClass"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(Trim(dr.Item("ItemAppraiseValue"))))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratCode"))))
        End While
        dr.Close()
        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call clear()
    End Sub
    Private Sub clear()
        ListView1.Items.Clear()
        ListView2.Items.Clear()
        Label3.Text = ""
        Label4.Text = ""
        Label8.Text = ""
        Label10.Text = ""
        Label12.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call SavePTN()
            MsgBox("Process successfully saved.", MsgBoxStyle.Information, TitleMsgBox)
            Call clear()
            Call RetreivePTN()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function ActionClass(ByVal sAction As String) As String
        If sAction = s_Jewelry Then
            Return "6"
        ElseIf sAction = s_Appliance Then
            Return "1"
        ElseIf sAction = s_Watch Then
            Return "8"
        ElseIf sAction = s_Cellular Then
            Return "3"
        ElseIf sAction = s_Missing Then
            Return "11"
        End If
    End Function
    Private Function Barcode(ByVal sbarcode As String) As String
        If sbarcode = "" Then
            Return "NULL"
        Else
            Return sbarcode
        End If
    End Function

    Private Sub SavePTN()
        Dim i As Integer
        objclass = New clsCommon
        ProgressBar1.Visible = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = ListView2.Items.Count - 1

        objclass.ConnectionString1()
        objclass.Open()
        For i = 0 To ListView2.Items.Count - 1
            If Trim(ListView2.Items(i).SubItems(1).Text) <> "" Then
                objclass.Command("insert into tbl_receiving(division, division_name, PTN, PTNBarcode, rec_id, full_name, action_id, receivedate, status_id) Values('" + TextBox1.Text + "','" + ComboBox4.Text + "'," + ListView2.Items(i).SubItems(2).Text + "," + Barcode(Trim(ListView2.Items(i).SubItems(3).Text)) + "," + sUserID(ComboBox3.SelectedIndex) + ", '" + ComboBox3.Text + "', " + ActionClass(Trim(ListView2.Items(i).SubItems(1).Text)) + ", getdate(), " + CStr(objclass.status.receiving) + ")")
                objclass.Execute()
                objclass.Command("update tbl_pt_tran set received = 1 where ptn =" + ListView2.Items(i).SubItems(2).Text)
                objclass.Execute()
            End If
            ProgressBar1.Value = i
        Next
        objclass.Close()
        objclass = Nothing
        ProgressBar1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListView2.Items.Count = 0 Then
            Exit Sub
        End If
        Dim i, iJewelry, iAppliance, iWatch, iCell, iMissing As Integer
        For i = 0 To ListView2.Items.Count - 1
            If Trim(ListView2.Items(i).SubItems(1).Text) = s_Jewelry Then
                iJewelry = iJewelry + 1
            ElseIf Trim(ListView2.Items(i).SubItems(1).Text) = s_Appliance Then
                iAppliance = iAppliance + 1
            ElseIf Trim(ListView2.Items(i).SubItems(1).Text) = s_Watch Then
                iWatch = iWatch + 1
            ElseIf Trim(ListView2.Items(i).SubItems(1).Text) = s_Cellular Then
                iCell = iCell + 1
            ElseIf Trim(ListView2.Items(i).SubItems(1).Text) = s_Missing Then
                iMissing = iMissing + 1
            End If
        Next
        Label3.Text = iJewelry
        Label4.Text = iAppliance
        Label8.Text = iWatch
        Label10.Text = iCell
        Label12.Text = iMissing
        If iJewelry + iAppliance + iWatch + iCell + iMissing <> 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub
End Class
