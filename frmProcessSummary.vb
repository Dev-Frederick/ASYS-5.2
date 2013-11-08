Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmProcessSummary
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Public sProcess As Integer

    'Public sProcess As Integer

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
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProcessSummary))
        Me.btnpreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnpreview
        '
        Me.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Image = CType(resources.GetObject("btnpreview.Image"), System.Drawing.Image)
        Me.btnpreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpreview.Location = New System.Drawing.Point(16, 16)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(72, 56)
        Me.btnpreview.TabIndex = 0
        Me.btnpreview.Text = "PREVIEW"
        Me.btnpreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HABWA MONTH"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(216, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "_"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(352, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 96)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(528, 288)
        Me.CrystalReportViewer1.TabIndex = 5
        '
        'frmProcessSummary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 382)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProcessSummary"
        Me.Text = "frmProcessSummary"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Try
            oRPT = New ReportDocument
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            objcommom = New clsCommon

            objcommom.ConnectionString1()
            If sProcess = 1 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessQTYPcsV3.1.rpt")
            ElseIf sProcess = 2 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessTWTV3.1.rpt")
            ElseIf sProcess = 3 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessAveWt.rpt")
            ElseIf sProcess = 4 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessLoanAmountV3.1.rpt")
            ElseIf sProcess = 5 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessTotalRem.rpt")
            ElseIf sProcess = 6 Then
                oRPT.Load(sPath + "\ASYS_SummaryProcessTotalPren.rpt")
            End If

            oRPT.SetParameterValue("prenda", UCase(Format(DateAdd("m", -7, CDate(ComboBox1.Text & "-1-" & ComboBox2.Text)), "yyyy MMMM")))
            oRPT.SetParameterValue("habwa", CStr(ComboBox2.SelectedItem) + " " + CStr(ComboBox1.SelectedItem))
            oRPT.SetParameterValue("@month", ComboBox1.SelectedIndex + 1)
            oRPT.SetParameterValue("@year", ComboBox2.SelectedItem)
            oRPT.SetParameterValue("DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))

            If sProcess = 6 Then
                oRPT.SetParameterValue("@prenda_month", objclass.iPrenda_month)
                oRPT.SetParameterValue("@prenda_year", objclass.iPrenda_year)
            End If

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            If sProcess = 2 Then
                crTables.Item("ASYS_REMProcessTWtV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessTWtV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessTWtV31;1"
            ElseIf sProcess = 1 Then
                crTables.Item("ASYS_REMProcessQtyPcsV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessQtyPcsV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessQtyPcsV31;1"
            ElseIf sProcess = 3 Then
                crTables.Item("ASYS_ProcessTWT_AveWt;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ProcessTWT_AveWt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ProcessTWT_AveWt;1"
            ElseIf sProcess = 4 Then
                crTables.Item("ASYS_REMProcessLoanAmountV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessLoanAmountV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessLoanAmountV31;1"
            ElseIf sProcess = 5 Then
                crTables.Item("ASYS_ProcessTotalRem;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ProcessTotalRem;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ProcessTotalRem;1"
            ElseIf sProcess = 6 Then
                crTables.Item("ASYS_SummaryProcessTotalPren;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_SummaryProcessTotalPren;1").Location = objcommom.sDatabase1 + ".dbo.spReport3"
            End If
            CrystalReportViewer1.ReportSource = oRPT
            btnpreview.Enabled = True
        Catch ex As Exception
            MsgBox("frmProcessSummary/btnpreview_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            btnpreview.Enabled = True
        End Try
    End Sub

    Private Sub frmProcessSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Me.btnpreview.Enabled = False
            If sProcess = 1 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - QTY/PCS." '"REM Summary Process Report - Qty/Pcs."
            ElseIf sProcess = 2 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - TWT" '"REM Summary Process Report - TWT"
            ElseIf sProcess = 3 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - AVE. WT." '"REM Summary Process Report - Ave. Wt."
            ElseIf sProcess = 4 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - LOAN" '"REM Summary Process Report - LOAN"
            ElseIf sProcess = 5 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - % TO TOTAL REM" '"REM Summary Process Report - % to Total REM"
            ElseIf sProcess = 6 Then
                Me.Text = "REM SUMMARY PROCESS REPORT - % TO TOTAL PRENDA" '"REM Summary Process Report - % to Total Prenda"
            End If

            Dim syr, x As Integer
            syr = System.DateTime.Now.Year
            For x = 0 To 4
                Me.ComboBox2.Items.Add(syr)
                syr = syr - 1
            Next

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
            Me.ComboBox2.Text = Now.Year
            'ComboBox2.SelectedIndex = iMonth - 1
            'For i = 0 To ComboBox1.Items.Count - 1
            '    If CInt(ComboBox1.Items(i)) = iYear Then
            '        ComboBox1.SelectedIndex = i
            '        Exit For
            '    End If
            'Next
            Me.ComboBox1.Text = MonthName(Now.Month)
        Catch ex As Exception
            MsgBox("frmProcessSummary/frmProcessSummary_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            If CStr(ComboBox1.SelectedItem) <> "" AndAlso CStr(ComboBox2.SelectedItem) <> "" Then
                Me.btnpreview.Enabled = True
                Me.btnpreview.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmProcessSummary/ComboBox1_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            If CStr(ComboBox2.SelectedItem) <> "" AndAlso CStr(ComboBox1.SelectedItem) <> "" Then
                Me.btnpreview.Enabled = True
                Me.btnpreview.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmProcessSummary/ComboBox2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
