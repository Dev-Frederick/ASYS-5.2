Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmJewelSum
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon

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
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJewelSum))
        Me.btnprev = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnprev
        '
        Me.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprev.Image = CType(resources.GetObject("btnprev.Image"), System.Drawing.Image)
        Me.btnprev.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnprev.Location = New System.Drawing.Point(40, 24)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(80, 56)
        Me.btnprev.TabIndex = 0
        Me.btnprev.Text = "PREVIEW"
        Me.btnprev.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PRENDA MONTH"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(280, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(424, 37)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(408, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "-"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(5, 104)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(616, 352)
        Me.CrystalReportViewer1.TabIndex = 5
        '
        'frmJewelSum
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 462)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprev)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJewelSum"
        Me.Text = "JEWELRY SUMMARY"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmJewelSum_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Dim syr, x As Integer
        syr = System.DateTime.Now.Year
        For x = 0 To 4
            Me.ComboBox2.Items.Add(syr)
            syr = syr - 1
        Next

        Me.ComboBox2.Text = Now.Year
        Me.ComboBox1.Text = UCase(MonthName(Now.Month))
    End Sub

    Private Sub btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprev.Click
        Try
            oRPT = New ReportDocument
            objcommom = New clsCommon
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            objcommom.ConnectionString1()

            oRPT.Load(sPath & "\ASYS_REMJewelrySummaryV3.1.rpt")

            oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            oRPT.SetParameterValue("@prenda_month", ComboBox1.SelectedIndex + 1)
            oRPT.SetParameterValue("@prenda_year", ComboBox2.Text)
            'oRPT.SetParameterValue("prenda", objclass.Prenda(ComboBox2, ComboBox1))
            oRPT.SetParameterValue("prenda", ComboBox2.Text & " " & UCase(ComboBox1.SelectedItem))
            Dim dt As Date
            Dim xt, tx As String
            dt = CDate(ComboBox2.Text & "-" & (ComboBox1.SelectedIndex + 1) & "-01")
            dt = DateAdd(DateInterval.Month, 7, dt)
            tx = Year(dt)
            xt = MonthName(Month(dt), False)
            'oRPT.SetParameterValue("habwa", CStr(ComboBox2.Text & " " & UCase(ComboBox1.SelectedItem)))
            oRPT.SetParameterValue("habwa", tx & " " & UCase(xt))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With

            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_REMJewelrySummaryV31;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_REMJewelrySummaryV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelrySummaryV31;1"

            CrystalReportViewer1.ReportSource = oRPT
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
