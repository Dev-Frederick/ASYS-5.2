Imports System.Data.SqlClient
Public Class frmBatch
    Inherits System.Windows.Forms.Form
    Private objclass As clsCommon
    Private sUserID, sDivision As String()
    Private sJewelry, sAppliance, sWatch, sCellular As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblrcvrname As System.Windows.Forms.Label
    Friend WithEvents lblRcvrIDNo As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents lblcellr As System.Windows.Forms.Label
    Friend WithEvents lblwatchr As System.Windows.Forms.Label
    Friend WithEvents lblappr As System.Windows.Forms.Label
    Friend WithEvents lbljewelr As System.Windows.Forms.Label
    Friend WithEvents lblcellos As System.Windows.Forms.Label
    Friend WithEvents lblwatchos As System.Windows.Forms.Label
    Friend WithEvents lblappos As System.Windows.Forms.Label
    Friend WithEvents lbljewelos As System.Windows.Forms.Label
    Friend WithEvents lblos As System.Windows.Forms.Label
    Friend WithEvents lblcellnn As System.Windows.Forms.Label
    Friend WithEvents lblwatchnn As System.Windows.Forms.Label
    Friend WithEvents lblappnn As System.Windows.Forms.Label
    Friend WithEvents lbljewelnn As System.Windows.Forms.Label
    Friend WithEvents lblnn As System.Windows.Forms.Label
    Friend WithEvents lblna As System.Windows.Forms.Label
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents lblcellna As System.Windows.Forms.Label
    Friend WithEvents lblwatchna As System.Windows.Forms.Label
    Friend WithEvents lblappna As System.Windows.Forms.Label
    Friend WithEvents lbljewelna As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBatch))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBranchName = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblrcvrname = New System.Windows.Forms.Label
        Me.lblRcvrIDNo = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.lblr = New System.Windows.Forms.Label
        Me.lblcellr = New System.Windows.Forms.Label
        Me.lblwatchr = New System.Windows.Forms.Label
        Me.lblappr = New System.Windows.Forms.Label
        Me.lbljewelr = New System.Windows.Forms.Label
        Me.lblcellos = New System.Windows.Forms.Label
        Me.lblwatchos = New System.Windows.Forms.Label
        Me.lblappos = New System.Windows.Forms.Label
        Me.lbljewelos = New System.Windows.Forms.Label
        Me.lblos = New System.Windows.Forms.Label
        Me.lblcellnn = New System.Windows.Forms.Label
        Me.lblwatchnn = New System.Windows.Forms.Label
        Me.lblappnn = New System.Windows.Forms.Label
        Me.lbljewelnn = New System.Windows.Forms.Label
        Me.lblnn = New System.Windows.Forms.Label
        Me.lblna = New System.Windows.Forms.Label
        Me.btnDetails = New System.Windows.Forms.Button
        Me.lblcellna = New System.Windows.Forms.Label
        Me.lblwatchna = New System.Windows.Forms.Label
        Me.lblappna = New System.Windows.Forms.Label
        Me.lbljewelna = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(72, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Branch Name "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(184, 62)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(184, 21)
        Me.txtBranchName.TabIndex = 3
        Me.txtBranchName.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox2.Location = New System.Drawing.Point(184, 86)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(184, 23)
        Me.ComboBox2.TabIndex = 4
        Me.ComboBox2.Text = "ComboBox2"
        '
        'ComboBox3
        '
        Me.ComboBox3.Items.AddRange(New Object() {"2005", "2006", "2007", "2008", "2009", "2010"})
        Me.ComboBox3.Location = New System.Drawing.Point(376, 86)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(72, 23)
        Me.ComboBox3.TabIndex = 5
        Me.ComboBox3.Text = "ComboBox3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(183, 176)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(64, 21)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "TextBox2"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(183, 200)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(64, 21)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Text = "TextBox3"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(183, 224)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(64, 21)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "TextBox4"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(183, 248)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(64, 21)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.Text = "TextBox5"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(119, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jewelry"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(119, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Appliance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(119, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Watch"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(119, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cellular"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Count PTN"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(152, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Receive"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(288, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Close"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(120, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Total"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(184, 272)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(64, 21)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = "TextBox6"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(72, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Prenda Month "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(112, 352)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(296, 32)
        Me.ProgressBar1.TabIndex = 21
        Me.ProgressBar1.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(80, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 23)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Branch Code"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblrcvrname
        '
        Me.lblrcvrname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblrcvrname.Location = New System.Drawing.Point(248, 8)
        Me.lblrcvrname.Name = "lblrcvrname"
        Me.lblrcvrname.Size = New System.Drawing.Size(200, 21)
        Me.lblrcvrname.TabIndex = 108
        '
        'lblRcvrIDNo
        '
        Me.lblRcvrIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRcvrIDNo.Location = New System.Drawing.Point(184, 8)
        Me.lblRcvrIDNo.Name = "lblRcvrIDNo"
        Me.lblRcvrIDNo.Size = New System.Drawing.Size(64, 21)
        Me.lblRcvrIDNo.TabIndex = 109
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Location = New System.Drawing.Point(184, 36)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(64, 21)
        Me.txtBranchCode.TabIndex = 2
        Me.txtBranchCode.Text = ""
        '
        'lblr
        '
        Me.lblr.Location = New System.Drawing.Point(254, 151)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(56, 22)
        Me.lblr.TabIndex = 131
        Me.lblr.Text = "Received"
        Me.lblr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblr.Visible = False
        '
        'lblcellr
        '
        Me.lblcellr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcellr.Location = New System.Drawing.Point(254, 247)
        Me.lblcellr.Name = "lblcellr"
        Me.lblcellr.Size = New System.Drawing.Size(56, 23)
        Me.lblcellr.TabIndex = 130
        Me.lblcellr.Text = "Label10"
        Me.lblcellr.Visible = False
        '
        'lblwatchr
        '
        Me.lblwatchr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblwatchr.Location = New System.Drawing.Point(254, 223)
        Me.lblwatchr.Name = "lblwatchr"
        Me.lblwatchr.Size = New System.Drawing.Size(56, 23)
        Me.lblwatchr.TabIndex = 129
        Me.lblwatchr.Text = "Label15"
        Me.lblwatchr.Visible = False
        '
        'lblappr
        '
        Me.lblappr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblappr.Location = New System.Drawing.Point(254, 199)
        Me.lblappr.Name = "lblappr"
        Me.lblappr.Size = New System.Drawing.Size(56, 23)
        Me.lblappr.TabIndex = 128
        Me.lblappr.Text = "Label14"
        Me.lblappr.Visible = False
        '
        'lbljewelr
        '
        Me.lbljewelr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbljewelr.Location = New System.Drawing.Point(254, 175)
        Me.lbljewelr.Name = "lbljewelr"
        Me.lbljewelr.Size = New System.Drawing.Size(56, 23)
        Me.lbljewelr.TabIndex = 127
        Me.lbljewelr.Text = "Label13"
        Me.lbljewelr.Visible = False
        '
        'lblcellos
        '
        Me.lblcellos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcellos.Location = New System.Drawing.Point(433, 247)
        Me.lblcellos.Name = "lblcellos"
        Me.lblcellos.Size = New System.Drawing.Size(56, 23)
        Me.lblcellos.TabIndex = 126
        Me.lblcellos.Text = "Label24"
        Me.lblcellos.Visible = False
        '
        'lblwatchos
        '
        Me.lblwatchos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblwatchos.Location = New System.Drawing.Point(433, 223)
        Me.lblwatchos.Name = "lblwatchos"
        Me.lblwatchos.Size = New System.Drawing.Size(56, 23)
        Me.lblwatchos.TabIndex = 125
        Me.lblwatchos.Text = "Label23"
        Me.lblwatchos.Visible = False
        '
        'lblappos
        '
        Me.lblappos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblappos.Location = New System.Drawing.Point(433, 199)
        Me.lblappos.Name = "lblappos"
        Me.lblappos.Size = New System.Drawing.Size(56, 23)
        Me.lblappos.TabIndex = 124
        Me.lblappos.Text = "Label22"
        Me.lblappos.Visible = False
        '
        'lbljewelos
        '
        Me.lbljewelos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbljewelos.Location = New System.Drawing.Point(433, 175)
        Me.lbljewelos.Name = "lbljewelos"
        Me.lbljewelos.Size = New System.Drawing.Size(56, 23)
        Me.lbljewelos.TabIndex = 123
        Me.lbljewelos.Text = "Label21"
        Me.lbljewelos.Visible = False
        '
        'lblos
        '
        Me.lblos.Location = New System.Drawing.Point(437, 151)
        Me.lblos.Name = "lblos"
        Me.lblos.Size = New System.Drawing.Size(40, 24)
        Me.lblos.TabIndex = 122
        Me.lblos.Text = "Open"
        Me.lblos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblos.Visible = False
        '
        'lblcellnn
        '
        Me.lblcellnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcellnn.Location = New System.Drawing.Point(373, 247)
        Me.lblcellnn.Name = "lblcellnn"
        Me.lblcellnn.Size = New System.Drawing.Size(56, 23)
        Me.lblcellnn.TabIndex = 121
        Me.lblcellnn.Text = "Label19"
        Me.lblcellnn.Visible = False
        '
        'lblwatchnn
        '
        Me.lblwatchnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblwatchnn.Location = New System.Drawing.Point(373, 223)
        Me.lblwatchnn.Name = "lblwatchnn"
        Me.lblwatchnn.Size = New System.Drawing.Size(56, 23)
        Me.lblwatchnn.TabIndex = 120
        Me.lblwatchnn.Text = "Label18"
        Me.lblwatchnn.Visible = False
        '
        'lblappnn
        '
        Me.lblappnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblappnn.Location = New System.Drawing.Point(373, 199)
        Me.lblappnn.Name = "lblappnn"
        Me.lblappnn.Size = New System.Drawing.Size(56, 23)
        Me.lblappnn.TabIndex = 119
        Me.lblappnn.Text = "Label17"
        Me.lblappnn.Visible = False
        '
        'lbljewelnn
        '
        Me.lbljewelnn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbljewelnn.Location = New System.Drawing.Point(373, 175)
        Me.lbljewelnn.Name = "lbljewelnn"
        Me.lbljewelnn.Size = New System.Drawing.Size(56, 23)
        Me.lbljewelnn.TabIndex = 118
        Me.lbljewelnn.Text = "Label16"
        Me.lbljewelnn.Visible = False
        '
        'lblnn
        '
        Me.lblnn.Location = New System.Drawing.Point(381, 151)
        Me.lblnn.Name = "lblnn"
        Me.lblnn.Size = New System.Drawing.Size(48, 24)
        Me.lblnn.TabIndex = 117
        Me.lblnn.Text = "Noticed"
        Me.lblnn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblnn.Visible = False
        '
        'lblna
        '
        Me.lblna.Location = New System.Drawing.Point(307, 151)
        Me.lblna.Name = "lblna"
        Me.lblna.Size = New System.Drawing.Size(72, 24)
        Me.lblna.TabIndex = 116
        Me.lblna.Text = "Auctioned"
        Me.lblna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblna.Visible = False
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(264, 124)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(88, 23)
        Me.btnDetails.TabIndex = 115
        Me.btnDetails.Text = "Show Details"
        Me.btnDetails.Visible = False
        '
        'lblcellna
        '
        Me.lblcellna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcellna.Location = New System.Drawing.Point(315, 247)
        Me.lblcellna.Name = "lblcellna"
        Me.lblcellna.Size = New System.Drawing.Size(56, 23)
        Me.lblcellna.TabIndex = 114
        Me.lblcellna.Text = "Label10"
        Me.lblcellna.Visible = False
        '
        'lblwatchna
        '
        Me.lblwatchna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblwatchna.Location = New System.Drawing.Point(315, 223)
        Me.lblwatchna.Name = "lblwatchna"
        Me.lblwatchna.Size = New System.Drawing.Size(56, 23)
        Me.lblwatchna.TabIndex = 113
        Me.lblwatchna.Text = "Label15"
        Me.lblwatchna.Visible = False
        '
        'lblappna
        '
        Me.lblappna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblappna.Location = New System.Drawing.Point(315, 199)
        Me.lblappna.Name = "lblappna"
        Me.lblappna.Size = New System.Drawing.Size(56, 23)
        Me.lblappna.TabIndex = 112
        Me.lblappna.Text = "Label14"
        Me.lblappna.Visible = False
        '
        'lbljewelna
        '
        Me.lbljewelna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbljewelna.Location = New System.Drawing.Point(315, 175)
        Me.lbljewelna.Name = "lbljewelna"
        Me.lbljewelna.Size = New System.Drawing.Size(56, 23)
        Me.lbljewelna.TabIndex = 111
        Me.lbljewelna.Text = "Label13"
        Me.lbljewelna.Visible = False
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(352, 117)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(144, 24)
        Me.lblDate.TabIndex = 133
        Me.lblDate.Text = "Label11"
        Me.lblDate.Visible = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(264, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 23)
        Me.Label10.TabIndex = 132
        Me.Label10.Text = "Last Transdate"
        Me.Label10.Visible = False
        '
        'frmBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(560, 405)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.lblcellr)
        Me.Controls.Add(Me.lblwatchr)
        Me.Controls.Add(Me.lblappr)
        Me.Controls.Add(Me.lbljewelr)
        Me.Controls.Add(Me.lblcellos)
        Me.Controls.Add(Me.lblwatchos)
        Me.Controls.Add(Me.lblappos)
        Me.Controls.Add(Me.lbljewelos)
        Me.Controls.Add(Me.lblcellnn)
        Me.Controls.Add(Me.lblwatchnn)
        Me.Controls.Add(Me.lblappnn)
        Me.Controls.Add(Me.lbljewelnn)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblcellna)
        Me.Controls.Add(Me.lblwatchna)
        Me.Controls.Add(Me.lblappna)
        Me.Controls.Add(Me.lbljewelna)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.lblRcvrIDNo)
        Me.Controls.Add(Me.lblrcvrname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnn)
        Me.Controls.Add(Me.lblos)
        Me.Controls.Add(Me.lblna)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Batch Receiving "
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetDesktopLocation(450, 85)
        Dim dr As SqlDataReader
        Dim iMonth, iYear As Integer

        Call clear()
        'objclass = New clsCommon

        'objclass.ConnectionString1()
        'objclass.Open()
        'objclass.Command("select distinct a.division, b.bedrnm from tbl_pt_tran a inner join dbo.vw_bedryf b on a.division = b.bedrnr where a.pulloutstocks = 1 and a.transtype <> 'LUKAT' order by b.bedrnm")
        'objclass.Command("Select count(*) as nBranch from vw_RematadoBC ")
        'dr = objclass.OpenDataReader
        'i = 0
        'If dr.Read Then
        '    i = dr.Item("nBranch")
        'End If
        'dr.Close()
        'ReDim Preserve sDivision(i)

        'objclass.Command("select cast(month(getdate()) as int) as month, cast(year(getdate()) as int) as year")
        'dr = objclass.OpenDataReader
        'If dr.Read Then
        '    iMonth = dr.Item("month")
        '    iYear = dr.Item("year")
        'End If
        'dr.Close()
        'objclass.CloseDataReader()
        'ComboBox2.SelectedIndex = iMonth - 1
        'For i = 0 To ComboBox3.Items.Count - 1
        '    If CInt(ComboBox3.Items(i)) = iYear Then
        '        ComboBox3.SelectedIndex = i
        '        Exit For
        '    End If
        'Next
        'objclass.Close()
        'objclass = Nothing
        lblRcvrIDNo.Text = idnumber
        lblrcvrname.Text = fullname
    End Sub

    Private Sub clear()
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader
        Dim i As Double
        Dim sQuery As String


        lbljewelna.Visible = False
        lbljewelnn.Visible = False
        lbljewelos.Visible = False

        lblappna.Visible = False
        lblappnn.Visible = False
        lblappos.Visible = False

        lblwatchna.Visible = False
        lblwatchnn.Visible = False
        lblwatchos.Visible = False

        lblcellna.Visible = False
        lblcellnn.Visible = False
        lblcellos.Visible = False

        lbljewelr.Visible = False
        lblappr.Visible = False
        lblwatchr.Visible = False
        lblcellr.Visible = False

        lblr.Visible = False
        lblna.Visible = False
        lblnn.Visible = False
        lblos.Visible = False

        Label10.Visible = False
        lblDate.Visible = False

        If txtBranchName.Text.Trim.Length = 0 Or txtBranchCode.Text.Trim.Length = 0 Then
            MsgBox("Enter a branch.", MsgBoxStyle.Information, TitleMsgBox)
            txtBranchCode.Focus()
            Exit Sub
        End If

        If ComboBox2.Text.Trim.Length = 0 Then
            Msgbox("Select a month.", MsgBoxStyle.Information, TitleMsgBox)
            ComboBox2.Focus()
            Exit Sub
        End If

        If ComboBox3.Text.Trim.Length = 0 Then
            Msgbox("Select a year.", MsgBoxStyle.Information, TitleMsgBox)
            ComboBox3.Focus()
            Exit Sub
        End If

        Button1.Enabled = False
        Button2.Enabled = False

        sQuery = "Select count(a.Jewelry) as Jewelry,count(a.Appliance) as Appliance, count(a.watches) as Watches, count(a.Cellular) as Cellular from (" + _
" Select distinct t.mptn as Jewelry, null as Appliance,null as Watches, null as Cellular From tbl_pt_tran t Inner join tbl_ptn_item i on t.division =i.division and t.mptn=i.mptn    and i.itemcode >= 100 and i.itemcode <= 199  Where t.transtype <> 'LUKAT' and t.pulloutstocks = 1 and t.received = 0   and  t.division = '" + txtBranchCode.Text.Trim + "'  and month(t.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(t.transdate)=" + ComboBox3.SelectedItem + _
" Union " + _
" Select distinct null as Jewelry, t.mptn as Appliance,null as Watches, null as Cellular From tbl_pt_tran t Inner join tbl_ptn_item i on t.division =i.division and t.mptn=i.mptn    and i.itemcode >= 200 and i.itemcode <= 299  Where t.transtype <> 'LUKAT' and t.pulloutstocks = 1 and t.received = 0   and  t.division = '" + txtBranchCode.Text.Trim + "'  and month(t.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(t.transdate)=" + ComboBox3.SelectedItem + _
" union " + _
" Select distinct null as Jewelry, null as Appliance,t.mptn  as Watches, null as Cellular From tbl_pt_tran t Inner join tbl_ptn_item i on t.division =i.division and t.mptn=i.mptn    and i.itemcode >= 300 and i.itemcode <= 399  Where t.transtype <> 'LUKAT' and t.pulloutstocks = 1 and t.received = 0   and  t.division = '" + txtBranchCode.Text.Trim + "'  and month(t.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(t.transdate)=" + ComboBox3.SelectedItem + _
" union " + _
" Select distinct null as Jewelry, null as Appliance,null  as Watches, t.mptn as Cellular From tbl_pt_tran t Inner join tbl_ptn_item i on t.division =i.division and t.mptn=i.mptn    and i.itemcode >= 400 and i.itemcode <= 499  Where t.transtype <> 'LUKAT' and t.pulloutstocks = 1 and t.received = 0   and  t.division = '" + txtBranchCode.Text.Trim + "'  and month(t.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(t.transdate)=" + ComboBox3.SelectedItem + _
" ) a"

        objclass = New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command(sQuery)
        dr = objclass.OpenDataReader
        Dim iii As Integer
        iii = dr.RecordsAffected
        If dr.Read Then
            TextBox2.Text = CInt(dr.Item("jewelry"))
            TextBox3.Text = CInt(dr.Item("appliance"))
            TextBox4.Text = CInt(dr.Item("watches"))
            TextBox5.Text = CInt(dr.Item("cellular"))
        End If
        dr.Close()
        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing
        TextBox6.Text = FormatNumber(CInt(TextBox2.Text) + CInt(TextBox3.Text) + CInt(TextBox4.Text) + CInt(TextBox5.Text), 0)
        If CInt(TextBox6.Text) = 0 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
        Button1.Enabled = True
        sQuery = Nothing

        If TextBox6.Text = 0 Then
            btnDetails.Visible = True
        End If
    End Sub
    Private Function GenerateLot() As String
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim FormatYear, FormatMonth, FormatSeq, FormatLot, temps As String


            

            FormatYear = Now.Year
            If Now.Month >= 10 Then
                FormatMonth = Now.Month
                FormatSeq = "0000"
                FormatLot = FormatYear & FormatMonth & "" & FormatSeq
            Else
                FormatMonth = Now.Month
                FormatSeq = "0000"
                FormatLot = FormatYear & "0" & FormatMonth & "" & FormatSeq
            End If

            'MsgBox(FormatLot)
            obj = New clsCommon

            obj.ConnectionString2()
            obj.Open2()

            obj.Command2("IF (SELECT Coalesce(isnull(Max(DLotno),'" + FormatLot + "') + 1,'" + FormatLot + "') as lotno FROM rems.dbo.tbl_receiving_detail) >= (SELECT Coalesce(ISNUll(Max(LOtno_dfor),'" + FormatLot + "') + 1 ,'" + FormatLot + "') as lotno FROM rems.dbo.tbl_ForcedOutRcv_detail ) BEGIN (SELECT Coalesce(isnull(Max(DLotno),'" + FormatLot + "') + 1,'" + FormatLot + "') as lotno FROM rems.dbo.tbl_receiving_detail) END ELSE (SELECT Coalesce(ISNUll(Max(LOtno_dfor),'" + FormatLot + "') + 1 ,'" + FormatLot + "') as lotno FROM rems.dbo.tbl_ForcedOutRcv_detail )")
            dr = obj.OpenDataReader2
            If dr.Read Then
                GenerateLot = dr.Item("lotno")
            End If
            dr.Close()
            obj.Execute2()
            obj.Close2()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'Me.cmbCostCenter.Text = GenerateLot
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sQuery1, sQuery2, sQuery3, tmpS, strQuery As String

        If TextBox6.Text = "" Then
            MsgBox("Click on count button first.", MsgBoxStyle.Information, TitleMsgBox)
            Exit Sub
        End If
        Button2.Enabled = False
        Button3.Enabled = False
        ProgressBar1.Visible = True
        ProgressBar1.Focus()
        Try
            'ProgressBar1.Value = 10
            'sQuery2 = " from tbl_pt_tran a inner join dbo.vw_bedryf  b on a.division = b.bedrnr where transtype <> 'LUKAT' and pulloutstocks = 1 and received = 0 and division = '" + txtBranchName.Text + "' and mptn in("
            'sJewelry = "from tbl_pt_tran t inner join dbo.vw_bedryf b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 100 and i. itemcode <= 199 "
            'sAppliance = "from tbl_pt_tran t inner join dbo.vw_bedryf b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 200 and i. itemcode <= 299 "
            'sWatch = "from tbl_pt_tran t inner join dbo.vw_bedryf b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 300 and i. itemcode <= 399 "
            'sCellular = "from tbl_pt_tran t inner join dbo.vw_bedryf b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 400 and i. itemcode <= 499 "
            'tmpS = "where t. division = '" + txtBranchName.Text + "' and t.transtype <> 'LUKAT'  and pulloutstocks = 1 and received = 0 and month(t.transdate) = " + CStr(ComboBox2.SelectedIndex + 1) + "  and year(t.Transdate) = " + ComboBox3.SelectedItem
            'ProgressBar1.Value = 20

            ProgressBar1.Value = 10
            sQuery2 = " from tbl_pt_tran a inner join dbo.vw_bedryf" + sDB + "  b on a.division = b.bedrnr where transtype <> 'LUKAT' and pulloutstocks = 1 and received = 0 and division = '" + txtBranchCode.Text.Trim + "' and mptn in("
            sJewelry = "from tbl_pt_tran t inner join dbo.vw_bedryf" + sDB + " b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 100 and i. itemcode <= 199 "
            sAppliance = "from tbl_pt_tran t inner join dbo.vw_bedryf" + sDB + " b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 200 and i. itemcode <= 299 "
            sWatch = "from tbl_pt_tran t inner join dbo.vw_bedryf" + sDB + " b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 300 and i. itemcode <= 399 "
            sCellular = "from tbl_pt_tran t inner join dbo.vw_bedryf" + sDB + " b on t.division = b.bedrnr Inner join tbl_ptn_item i on  t. division = i.division and t.mptn =i.mptn and i.itemcode >= 400 and i. itemcode <= 499 "
            ''repair line for v.1.21
            tmpS = "where t. division = '" + txtBranchCode.Text.Trim + "' and t.transtype <> 'LUKAT'  and pulloutstocks = 1 and received = 0 and month(t.transdate) = " + CStr(ComboBox2.SelectedIndex + 1) + "  and year(t.Transdate) = " + ComboBox3.SelectedItem
            ProgressBar1.Value = 20

            objclass = New clsCommon
            objclass.ConnectionString1()
            objclass.Open()

            sQuery1 = " select distinct " & GenerateLot() & " as Lotno,b.bedrnr, b.bedrnm,t.ptn, t.ptn_barcode,i.id,'REM' as recCostCenter,6 as recactionid,t.ptnprincipal,t.appraisevalue, " + lblRcvrIDNo.Text + " as recid, '" + lblrcvrname.Text + "' as fullname,  getdate() as receivedate,t.pulloutdate, 1 as status_id "
            sQuery2 = sJewelry
            sQuery3 = tmpS
            strQuery = "insert into tbl_receiving_header(reclotno,recdivision,recdivisionname,recptn,recptnbarcode,recitem_id,reccostcenter,recactionid,recloanvalue,rectotalappraisevalue,recid,recname,receivedate,pulloutdate,status_id) " + sQuery1 + sQuery2 + sQuery3
            objclass.Command(strQuery)
            objclass.Execute()
            ProgressBar1.Value = 30

            sQuery2 = sAppliance
            sQuery3 = tmpS
            objclass.Command("insert into tbl_receiving_header(reclotno,recdivision,recdivisionname,recptn,recptnbarcode,recitem_id,reccostcenter,recactionid,recloanvalue,rectotalappraisevalue,recid,recname,receivedate,pulloutdate,status_id) " + sQuery1 + sQuery2 + sQuery3)
            objclass.Execute()
            ProgressBar1.Value = 40

            sQuery2 = sWatch
            objclass.Command("insert into tbl_receiving_header(reclotno,recdivision,recdivisionname,recptn,recptnbarcode,recitem_id,reccostcenter,recactionid,recloanvalue,rectotalappraisevalue,recid,recname,receivedate,pulloutdate,status_id) " + sQuery1 + sQuery2 + sQuery3)
            objclass.Execute()
            ProgressBar1.Value = 50

            sQuery2 = sCellular
            objclass.Command("insert into tbl_receiving_header(reclotno,recdivision,recdivisionname,recptn,recptnbarcode,recitem_id,reccostcenter,recactionid,recloanvalue,rectotalappraisevalue,recid,recname,receivedate,pulloutdate,status_id) " + sQuery1 + sQuery2 + sQuery3)
            objclass.Execute()
            ProgressBar1.Value = 60

            '------uncomment when deployment------'
            '         objclass.Command("update tbl_pt_tran  set received = 1 " + _
            '"where division = '" + txtBranchCode.Text.Trim + "' and transtype <> 'LUKAT'  and pulloutstocks = 1 and received = 0 and month(transdate) = " + CStr(ComboBox2.SelectedIndex + 1) + "  and year(Transdate) = " + ComboBox3.SelectedItem)
            '         objclass.Execute()

            ProgressBar1.Value = 100
            Me.Refresh()
            objclass.Close()
            objclass = Nothing
            MsgBox(TextBox6.Text + " PTN transaction of " + txtBranchName.Text + " successfully received.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Dim dr As SqlDataReader

        If e.KeyCode = Keys.Enter Then
            If txtBranchCode.Text.Trim.Length = 0 Then
                Msgbox("Enter a valid Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Focus()
                Exit Sub
            End If
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("Select bedrnm from vw_bedryf" + sDB + " where bedrnr='" + txtBranchCode.Text.Trim + "'")
            dr = objclass.OpenDataReader5
            If dr.Read = True Then
                txtBranchName.Text = dr.Item("bedrnm")
            Else
                Msgbox("Branch code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Focus()
            End If
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        End If
    End Sub

    Private Sub txtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchName.KeyDown
        Dim dr As SqlDataReader

        If e.KeyCode = Keys.Enter Then
            If txtBranchName.Text.Trim.Length = 0 Then
                Msgbox("Enter a valid Branch Name.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchName.Focus()
                Exit Sub
            End If
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("Select bedrnr,bedrnm from vw_bedryf" + sDB + " where bedrnm like '%" + txtBranchName.Text.Trim + "%'")
            dr = objclass.OpenDataReader5
            If dr.Read Then
                txtBranchCode.Text = dr.Item("bedrnr")
                txtBranchName.Text = dr.Item("bedrnm")
            Else
                Msgbox("Enter a valid Branch Name.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchName.Focus()
            End If
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        End If
    End Sub

    Private Sub btnDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetails.Click
        Dim PullOutCtr As Integer
        Dim AuctionCtr As Integer
        Dim NoticeCtr As Integer
        Dim Received As Integer
        Dim sQuery As String
        Dim dr As SqlDataReader

        PullOutCtr = 0
        AuctionCtr = 0
        NoticeCtr = 0

        objclass = New clsCommon
        objclass.ConnectionString1()
        objclass.Open()

        lblr.Visible = True
        lblna.Visible = True
        lblnn.Visible = True
        lblos.Visible = True
        lblDate.Visible = True
        Label10.Visible = True

        If TextBox2.Text = 0 Then 'jewelry nn
            lbljewelr.Visible = True
            lbljewelna.Visible = True
            lbljewelnn.Visible = True
            lbljewelos.Visible = True

            sQuery = "" 'received
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 100 and b.itemcode <= 199 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.received=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                Received = CInt(dr.Item("ctr"))
            Else
                Received = 0
            End If
            lbljewelr.Text = Received
            dr.Close()

            sQuery = "" 'nn
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 100 and b.itemcode <= 199 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionnotice= 1"
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                NoticeCtr = CInt(dr.Item("ctr"))
            Else
                NoticeCtr = 0
            End If
            lbljewelnn.Text = NoticeCtr
            dr.Close()

            'sQuery = "" 'nn
            'sQuery = sQuery + "Select distinct a.ptn as ctr from tbl_pt_tran "

            'sQuery = sQuery + "and b.itemcode >= 100 and b.itemcode <= 199 "
            'sQuery = sQuery + "and cancelstatus is null "
            'sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            'sQuery = sQuery + "and a.auctionnotice= 1"
            'sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            'sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            'objclass.Command(sQuery)
            'dr = objclass.OpenDataReader
            'If dr.Read = True Then
            '    NoticeCtr = CInt(dr.Item("ctr"))
            'Else
            '    NoticeCtr = 0
            'End If
            'lbljewelnn.Text = NoticeCtr
            'dr.Close()

            sQuery = ""  'na
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 100 and b.itemcode <= 199 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionsalestatus=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                AuctionCtr = CInt(dr.Item("ctr"))
            Else
                AuctionCtr = 0
            End If
            lbljewelna.Text = AuctionCtr
            dr.Close()

            sQuery = "" 'os
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 100 and b.itemcode <= 199 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.ptstatus=0 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                PullOutCtr = CInt(dr.Item("ctr"))
            Else
                PullOutCtr = 0
            End If
            lbljewelos.Text = PullOutCtr
            dr.Close()
        End If

        If TextBox3.Text = 0 Then 'appliance nn
            lblappr.Visible = True
            lblappna.Visible = True
            lblappnn.Visible = True
            lblappos.Visible = True

            sQuery = "" 'received
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 200 and b.itemcode <= 299 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.received=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                Received = CInt(dr.Item("ctr"))
            Else
                Received = 0
            End If
            lblappr.Text = Received
            dr.Close()

            sQuery = ""
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 200 and b.itemcode <= 299 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionnotice=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                NoticeCtr = CInt(dr.Item("ctr"))
            Else
                NoticeCtr = 0
            End If
            lblappnn.Text = NoticeCtr
            dr.Close()

            sQuery = ""  'na
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 200 and b.itemcode <= 299 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionsalestatus=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                AuctionCtr = CInt(dr.Item("ctr"))
            Else
                AuctionCtr = 0
            End If
            lblappna.Text = AuctionCtr
            dr.Close()

            sQuery = "" 'os
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 200 and b.itemcode <= 299 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.ptstatus=0 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                PullOutCtr = CInt(dr.Item("ctr"))
            Else
                PullOutCtr = 0
            End If
            lblappos.Text = PullOutCtr
            dr.Close()
        End If


        If TextBox4.Text = 0 Then 'watch nn
            lblwatchr.Visible = True
            lblwatchna.Visible = True
            lblwatchnn.Visible = True
            lblwatchos.Visible = True

            sQuery = "" 'received
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 300 and b.itemcode <= 399 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.received=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                Received = CInt(dr.Item("ctr"))
            Else
                Received = 0
            End If
            lblwatchr.Text = Received
            dr.Close()

            sQuery = ""
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 300 and b.itemcode <= 399 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionnotice=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                NoticeCtr = CInt(dr.Item("ctr"))
            Else
                NoticeCtr = 0
            End If
            lblwatchnn.Text = NoticeCtr
            dr.Close()

            sQuery = ""  'na
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 300 and b.itemcode <= 399 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionsalestatus=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                AuctionCtr = CInt(dr.Item("ctr"))
            Else
                AuctionCtr = 0
            End If
            lblwatchna.Text = AuctionCtr
            dr.Close()

            sQuery = "" 'os
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 300 and b.itemcode <= 399 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.ptstatus=0 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                PullOutCtr = CInt(dr.Item("ctr"))
            Else
                PullOutCtr = 0
            End If
            lblwatchos.Text = PullOutCtr
            dr.Close()
        End If

        If TextBox5.Text = 0 Then 'cell nn
            lblcellr.Visible = True
            lblcellna.Visible = True
            lblcellnn.Visible = True
            lblcellos.Visible = True

            sQuery = "" 'received
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 400 and b.itemcode <= 499 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.received=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                Received = CInt(dr.Item("ctr"))
            Else
                Received = 0
            End If
            lblcellr.Text = Received
            dr.Close()

            sQuery = ""
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 400 and b.itemcode <= 499 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionnotice=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                NoticeCtr = CInt(dr.Item("ctr"))
            Else
                NoticeCtr = 0
            End If
            lblcellnn.Text = NoticeCtr
            dr.Close()

            sQuery = ""  'na
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 400 and b.itemcode <= 499 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.auctionsalestatus=1 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                AuctionCtr = CInt(dr.Item("ctr"))
            Else
                AuctionCtr = 0
            End If
            lblcellna.Text = AuctionCtr
            dr.Close()

            sQuery = "" 'os
            sQuery = sQuery + "Select count(c.ctr) as ctr "
            sQuery = sQuery + "From (Select distinct a.ptn as ctr from tbl_pt_tran a "
            sQuery = sQuery + "inner join tbl_ptn_item b "
            sQuery = sQuery + "on a.division=b.division and a.mptn=b.mptn "
            sQuery = sQuery + "and b.itemcode >= 400 and b.itemcode <= 499 "
            sQuery = sQuery + "and cancelstatus is null "
            sQuery = sQuery + "where a.transtype <> 'LUKAT' "
            sQuery = sQuery + "and a.ptstatus=0 "
            sQuery = sQuery + "and a.division = '" + txtBranchCode.Text + "' "
            sQuery = sQuery + "and month(a.transdate) =" + CStr(ComboBox2.SelectedIndex + 1) + " and year(a.transdate)=" + ComboBox3.SelectedItem + ")c"
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            If dr.Read = True Then
                PullOutCtr = CInt(dr.Item("ctr"))
            Else
                PullOutCtr = 0
            End If
            lblcellos.Text = PullOutCtr
            dr.Close()
        End If

        Dim Ldate As String
        sQuery = ""
        sQuery = sQuery + "Select top 1 *  from tbl_pt_tran "
        sQuery = sQuery + "where transtype <> 'LUKAT' "
        sQuery = sQuery + "and division = '" + txtBranchCode.Text + "' "
        sQuery = sQuery + "Order by transdate desc"
        objclass.Command(sQuery)
        dr = objclass.OpenDataReader
        If dr.Read Then
            Ldate = dr.Item("transdate")
        End If
        lblDate.Text = Ldate
        dr.Close()

        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing

        btnDetails.Visible = False
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged

    End Sub

    Private Sub txtBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchName.TextChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub
End Class
