Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class NewRematadoReport
    Inherits System.Windows.Forms.Form
    Public WithEvents oRpt As ReportDocument
    Dim objcommom As New clsCommon
    Dim objclass As New clsCommon
    Dim td, pd, habwa As Date
    Dim habwajr, habwa3rd As String


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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NewRematadoReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 88)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(600, 352)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 56)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(296, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.ItemHeight = 13
        Me.ComboBox2.Location = New System.Drawing.Point(208, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(208, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "YEAR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SORT MONTH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox4.Location = New System.Drawing.Point(440, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PREVIOUS MONTH"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ItemHeight = 13
        Me.ComboBox3.Location = New System.Drawing.Point(440, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox3.TabIndex = 11
        '
        'NewRematadoReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 438)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewRematadoReport"
        Me.Text = "REMATADO REPORT"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False
            oRpt = New ReportDocument
            objcommom = New clsCommon

            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim dr As SqlDataReader
            Dim obj As New clsCommon
            Dim sPath As String
            Dim frm As New Form1
            Dim a, b, c, d As Integer
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If Label3.Text = 1 Then
                oRpt.Load(sPath + "\ASYS_TOP10LuzonVisminV3.1.rpt") '' change header breakdown to vismin----------------11-4-2013
                Dim dt As Date
                dt = CDate(ComboBox2.Text & "-" & (ComboBox1.SelectedIndex + 1) & "-01")
                dt = DateAdd(DateInterval.Month, 7, dt)
                habwajr = MonthName(Month(dt), False)
                habwa3rd = Year(dt)
                oRpt.SetParameterValue("@habwamonth", dt)
                oRpt.SetParameterValue("habs", UCase(habwa3rd & " " & habwajr))
                oRpt.SetParameterValue("prends", UCase(ComboBox2.SelectedItem & " " & ComboBox1.SelectedItem))
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            ElseIf Label3.Text = 2 Then
                oRpt.Load(sPath + "\ASYS_LuzonVisminV3.1.rpt")
                oRpt.SetParameterValue("@habwamonth", ComboBox2.Text & "-" & ComboBox1.SelectedIndex + 1 & "-" & "01")
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                oRpt.SetParameterValue("@MonthOfHabwa", ComboBox2.Text & " " & ComboBox1.SelectedItem)
                oRpt.SetParameterValue("@MonthOfPrenda", UCase(Format(DateAdd(DateInterval.Month, -7, CDate(ComboBox2.Text & " " & ComboBox1.SelectedItem)), "yyyy MMMM")))

            ElseIf Label3.Text = 3 Or Label3.Text = 4 Then

                oRpt.Load(sPath + "\ASYS_ComparativeV3.1.rpt")
                Dim td, pd As Date
                td = CDate(ComboBox2.Text & "-" & (ComboBox1.SelectedIndex + 1) & "-01")
                pd = CDate(ComboBox3.Text & "-" & (ComboBox4.SelectedIndex + 1) & "-01")
                oRpt.SetParameterValue("@habwamonth", td)
                oRpt.SetParameterValue("@prevmonth", pd)
                oRpt.SetParameterValue("@MonthPrev", ComboBox3.Text & " " & UCase(ComboBox4.Text))
                oRpt.SetParameterValue("@MonthHabs", ComboBox2.Text & " " & UCase(ComboBox1.Text))
                oRpt.SetParameterValue("@curmonth", UCase(Trim(ComboBox1.SelectedItem)))
                oRpt.SetParameterValue("@pmonth", UCase(Trim(ComboBox4.SelectedItem)))
                oRpt.SetParameterValue("@HMonthPrev", UCase(Mid(ComboBox4.Text, 1, 3)) & "-" & ComboBox3.Text)
                oRpt.SetParameterValue("@HMonthHabs", UCase(Mid(ComboBox1.Text, 1, 3)) & "-" & ComboBox2.Text)
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                If sDB = "Luzon" Then
                    oRpt.SetParameterValue("header", "LUZON COMPARATIVE REPORT")
                ElseIf sDB = "Vismin" Then
                    oRpt.SetParameterValue("header", "VISMIN COMPARATIVE REPORT")
                End If

            ElseIf Label3.Text = 5 Then
                oRpt.Load(sPath + "\ASYS_LuzonVisminMonthLyComparativeV3.1.rpt")
                td = CDate(ComboBox2.Text & "-" & (ComboBox1.SelectedIndex + 1) & "-01")
                pd = CDate(ComboBox3.Text & "-" & (ComboBox4.SelectedIndex + 1) & "-01")
                oRpt.SetParameterValue("@habwamonth", UCase(td))
                oRpt.SetParameterValue("@prevmonth", UCase(pd))
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                oRpt.SetParameterValue("@MonthPrev", ComboBox3.Text & " " & UCase(ComboBox4.Text))
                oRpt.SetParameterValue("@MonthHabs", ComboBox2.Text & " " & UCase(ComboBox1.Text))
            End If

            'If Label3.Text = 0 And sDB = "Vismin" Then
            If Label3.Text = 0 And sDB = "Visayas" Then
                oRpt.Load(sPath + "\ASYS_TOP10BranchesV3.1.rpt")
                habwa = DateAdd(DateInterval.Month, 7, (ComboBox1.SelectedIndex + 1) & "-" & ComboBox2.SelectedItem)
                habwajr = MonthName(Month(habwa), False)
                habwa3rd = Year(habwa)
                oRpt.SetParameterValue("@habwamonth", habwa)
                oRpt.SetParameterValue("habs", UCase(habwa3rd & " " & habwajr))
                oRpt.SetParameterValue("prends", UCase(ComboBox2.SelectedItem & " " & ComboBox1.SelectedItem))
                oRpt.SetParameterValue("header", "REM JEWELRY REPORT VISMIN")
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))

            ElseIf Label3.Text = 0 And sDB = "Mindanao" Then
                oRpt.Load(sPath + "\ASYS_TOP10BranchesV3.1.rpt")
                habwa = DateAdd(DateInterval.Month, 7, (ComboBox1.SelectedIndex + 1) & "-" & ComboBox2.SelectedItem)
                habwajr = MonthName(Month(habwa), False)
                habwa3rd = Year(habwa)
                oRpt.SetParameterValue("@habwamonth", habwa)
                oRpt.SetParameterValue("habs", UCase(habwa3rd & " " & habwajr))
                oRpt.SetParameterValue("prends", UCase(ComboBox2.SelectedItem & " " & ComboBox1.SelectedItem))
                oRpt.SetParameterValue("header", "REM JEWELRY REPORT VISMIN")
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))

                '=========SHOWROOMS=========-
            ElseIf Label3.Text = 0 And sDB = "Showroom" Then
                oRpt.Load(sPath + "\ASYS_TOP10BranchesV3.1.rpt")
                habwa = DateAdd(DateInterval.Month, 7, (ComboBox1.SelectedIndex + 1) & "-" & ComboBox2.SelectedItem)
                habwajr = MonthName(Month(habwa), False)
                habwa3rd = Year(habwa)
                oRpt.SetParameterValue("@habwamonth", habwa)
                oRpt.SetParameterValue("habs", UCase(habwa3rd & " " & habwajr))
                oRpt.SetParameterValue("prends", UCase(ComboBox2.SelectedItem & " " & ComboBox1.SelectedItem))
                oRpt.SetParameterValue("header", "REM JEWELRY REPORT SHOWROOM")
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                '============================'

            ElseIf Label3.Text = 0 And sDB = "Luzon" Then
                oRpt.Load(sPath + "\ASYS_TOP10BranchesV3.1.rpt")
                habwa = DateAdd(DateInterval.Month, 7, (ComboBox1.SelectedIndex + 1) & "-" & ComboBox2.SelectedItem)
                habwajr = MonthName(Month(habwa), False)
                habwa3rd = Year(habwa)
                oRpt.SetParameterValue("@habwamonth", habwa)
                oRpt.SetParameterValue("habs", UCase(habwa3rd & " " & habwajr))
                oRpt.SetParameterValue("prends", UCase(ComboBox2.SelectedItem & " " & ComboBox1.SelectedItem))
                oRpt.SetParameterValue("header", "REM JEWELRY REPORT LUZON")
                oRpt.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            End If

            objcommom.ConnectionString1()

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                If Label3.Text = 1 Or Label3.Text = 2 Or Label3.Text = 5 Then
                    objcommom.sDatabase1 = "REMS"
                    .DatabaseName = objcommom.sDatabase1
                Else
                    .DatabaseName = objcommom.sDatabase1
                End If
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRpt.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            If Label3.Text = 1 Then
                crTables.Item("ASYS_Top10BranchesLuzonVisminV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_Top10BranchesLuzonVisminV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_Top10BranchesLuzonVisminV31;1"
            ElseIf Label3.Text = 2 Then
                crTables.Item("ASYS_MonthlyLuzonVisminV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_MonthlyLuzonVisminV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MonthlyLuzonVisminV31;1"
            ElseIf Label3.Text = 3 Then
                crTables.Item("ASYS_ComparativeV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeV31;1"
            ElseIf Label3.Text = 4 Then
                crTables.Item("ASYS_ComparativeV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ComparativeV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ComparativeV31;1"
            ElseIf Label3.Text = 5 Then
                crTables.Item("ASYS_LuzonVisminMonthlyComparativeV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_LuzonVisminMonthlyComparativeV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_LuzonVisminMonthlyComparativeV31;1"
            ElseIf Label3.Text = 0 Then
                crTables.Item("ASYS_TOP10BranchesV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_TOP10BranchesV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_TOP10BranchesV31;1"
            End If
            CrystalReportViewer1.ReportSource = oRpt
            Button1.Enabled = True
        Catch ex As Exception
            'MsgBox("NewRematadoReport/Button1_Click " & ex.Message, MsgBoxStyle.Exclamation)
            Button1.Enabled = True
        End Try
    End Sub

    Private Sub NewRematadoReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            ComboBox1.Text = MonthName(Now.Month, False)
            If Now.Month = 1 Then
                ComboBox4.Text = "December"
                ComboBox3.Text = CInt(Now.Year) - 1
            Else
                ComboBox4.Text = MonthName(Now.Month - 1, False)
                ComboBox3.Text = Now.Year
            End If

            Dim x As Integer = Now.Year
            Dim y As Integer
            For y = 1 To 5
                ComboBox2.Items.Add(x)
                x = x - 1
            Next

            Dim ye, ar As Integer
            ye = Now.Year
            For ar = 1 To 5
                ComboBox3.Items.Add(ye)
                ye = ye - 1
            Next

            ComboBox2.Text = Now.Year
            ComboBox3.Text = Now.Year

            oRpt = New ReportDocument
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim sPath As String
            'Dim objclass As New clsReport
            'Dim frmMain1 As New frmMain
            ' sPath = frmMain1.sPath
            Dim frm1 As New Form1
            sPath = frm1.spath
        Catch ex As Exception
            MsgBox("NewRematadoReport/NewRematadoReport_Load " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class
