Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmComparative
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Private objcommom As clsCommon
    Public iComparative As Integer

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmComparative))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(121, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "YEAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(183, 20)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox2.TabIndex = 85
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(183, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 84
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 88)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(592, 352)
        Me.CrystalReportViewer1.TabIndex = 90
        '
        'frmComparative
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 445)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComparative"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COMPARATIVE REM REPORT - AVERAGE WEIGHT"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Select year", MsgBoxStyle.Information)
                Exit Sub
            End If
            If ComboBox2.SelectedIndex = -1 Then
                MsgBox("Select month", MsgBoxStyle.Information)
                Exit Sub
            End If
            Button1.Enabled = False
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

            If iComparative = 1 Then
                oRPT.Load(sPath + "\ASYS_ComparativeAveWeightV3.1.rpt")
            ElseIf iComparative = 2 Then
                oRPT.Load(sPath + "\ASYS_ComparativeOverAppraisedV3.1.rpt")
            ElseIf iComparative = 3 Then
                oRPT.Load(sPath + "\ASYS_ComparativeFakeCoatedV3.1.rpt")
            ElseIf iComparative = 4 Then
                oRPT.Load(sPath + "\ASYS_ComparativeCellWatchV3.1.rpt")
            End If

            Dim td As Date
            Dim prends, prendsjr, prends3rd, prevs, prevsjr As String
            td = CDate(ComboBox1.Text & "-" & (ComboBox2.SelectedIndex + 1) & "-01")
            prends = DateAdd(DateInterval.Month, -7, td)
            prevs = DateAdd(DateInterval.Month, -1, td)
            prendsjr = MonthName(Month(prends), False)
            prends3rd = Year(prends)
            prevsjr = MonthName(Month(prevs), False)
            oRPT.SetParameterValue("@habwamonth", td)
            oRPT.SetParameterValue("@habwa", UCase(ComboBox1.Text & " " & ComboBox2.Text))
            oRPT.SetParameterValue("@prenda", UCase(prends3rd & " " & prendsjr))
            oRPT.SetParameterValue("@prevmonth", UCase(prevsjr))
            oRPT.SetParameterValue("@habsmonth", UCase(ComboBox2.Text))
            oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            If iComparative = 1 Then
                crTables.Item("ASYS_ComparativeAveWt;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeAveWt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeAveWt;1"
            ElseIf iComparative = 2 Then
                crTables.Item("ASYS_ComparativeOverAppraisedV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeOverAppraisedV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeOverAppraisedV31;1"
            ElseIf iComparative = 3 Then
                crTables.Item("ASYS_ComparativeFakeCoatedV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeFakeCoatedV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeFakeCoatedV31;1"
            ElseIf iComparative = 4 Then
                crTables.Item("ASYS_ComparativeCellWatchV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeCellWatchV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeCellWatchV31;1"
            End If
            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox("frmComparative/Button1_Click " & ex.Message, MsgBoxStyle.Information)
            Button1.Enabled = True
        End Try
    End Sub

    Private Sub frmComparativeAveWt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.WindowState = FormWindowState.Maximized
            If iComparative = 1 Then
                Me.Text = "COMPRATIVE REM REPORT - AVE. WT." '"Comparative REM Report - Ave. Wt."
            ElseIf iComparative = 2 Then
                Me.Text = "COMPRATIVE REM REPORT - OVER APPRAISED" '"Comparative REM Report - Over Appraised"
            ElseIf iComparative = 3 Then
                Me.Text = "COMPRATIVE REM REPORT - FAKE AND COATED" '"Comparative REM Report - Fake and Coated"
            ElseIf iComparative = 4 Then
                Me.Text = "COMPRATIVE REM REPORT - CELL AND WATCH" '"Comparative REM Report - Cell and Watch"
            End If
            Dim dr As SqlDataReader
            Dim iMonth, iYear, i As Integer
            objcommom = New clsCommon
            objcommom.ConnectionString1()
            objcommom.Open()
            objcommom.Command("select cast(month(getdate()) as int) as month, cast(year(getdate()) as int) as year")
            dr = objcommom.OpenDataReader
            If dr.Read Then
                iMonth = dr.Item("month")
                iYear = dr.Item("year")
            End If
            dr.Close()
            objcommom.CloseDataReader()
            ComboBox2.SelectedIndex = iMonth - 1
            For i = 0 To ComboBox1.Items.Count - 1
                If CInt(ComboBox1.Items(i)) = iYear Then
                    ComboBox1.SelectedIndex = i
                    Exit For
                End If
            Next

            Dim ye, ar As Integer
            ye = Now.Year
            For ar = 1 To 5
                ComboBox1.Items.Add(ye)
                ye = ye - 1
            Next
            ComboBox1.Text = Now.Year
        Catch ex As Exception
            MsgBox("frmComparative/frmComparativeAveWt_Load " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmComparative/ComboBox1_KeyPress " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmComparative/ComboBox2_KeyPress " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
