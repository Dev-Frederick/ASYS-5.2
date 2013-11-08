Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmProcess
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Public iProcess As Integer

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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProcess))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
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
        Me.CrystalReportViewer1.TabIndex = 0
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
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(240, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(328, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(296, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " --"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "HABWA MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "DESCENDING ORDER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"yes", "no"})
        Me.ComboBox3.Location = New System.Drawing.Point(240, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox3.TabIndex = 11
        Me.ComboBox3.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 445)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REM PROCESS COUNT REPORT - QTY/PCS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.Text = "" Then
                MsgBox("Select year", MsgBoxStyle.Information)
                Exit Sub
            End If
            If ComboBox2.Text = "" Then
                MsgBox("Select month", MsgBoxStyle.Information)
                Exit Sub
            End If

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

            If iProcess = 1 Then
                'oRPT.Load(sPath + "\ASYS_ProcessQTYPcsV5.0S.rpt")
                oRPT.Load(sPath + "\ASYS_ProcessQTYPcsV3.1.rpt")
            ElseIf iProcess = 2 Then
                oRPT.Load(sPath + "\ASYS_ProcessTWTV3.1.rpt")
            ElseIf iProcess = 3 Then
                oRPT.Load(sPath + "\ASYS_ProcessAveWt.rpt")
            ElseIf iProcess = 4 Then
                oRPT.Load(sPath + "\ASYS_ProcessLoanAmountV3.1.rpt")
            ElseIf iProcess = 5 Then
                oRPT.Load(sPath + "\ASYS_ProcessTotalRem.rpt")
            ElseIf iProcess = 6 Then
                oRPT.Load(sPath + "\process_count_1RA15b.rpt")
            End If

            Dim a, b As Integer
            a = ComboBox2.SelectedIndex + 1
            b = ComboBox1.SelectedItem

            oRPT.SetParameterValue("@month", ComboBox2.SelectedIndex + 1)
            oRPT.SetParameterValue("@year", ComboBox1.SelectedItem)
            oRPT.SetParameterValue("habwa", UCase(ComboBox1.SelectedItem & " " & ComboBox2.SelectedItem))
            oRPT.SetParameterValue("prenda", UCase(Format(DateAdd("m", -7, CDate(ComboBox1.Text & "-1-" & ComboBox2.Text)), "yyyy MMMM")))
            oRPT.SetParameterValue("DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            'oRPT.SetParameterValue("@order", objclass.order(ComboBox3))
            If iProcess = 6 Then
                oRPT.SetParameterValue("@prenda_month", UCase(objclass.iPrenda_month))
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

            If iProcess = 2 Then
                crTables.Item("ASYS_REMProcessTWtV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessTWtV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessTWtV31;1"
            ElseIf iProcess = 1 Then

                'crTables.Item("ASYS_REMProcessQtyPcsV5S;1").ApplyLogOnInfo(crtableLogoninfo)
                'crTables.Item("ASYS_REMProcessQtyPcsV5S;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessQtyPcsV5S;1"

                crTables.Item("ASYS_REMProcessQtyPcsV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessQtyPcsV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessQtyPcsV31;1"
            ElseIf iProcess = 3 Then
                crTables.Item("ASYS_ProcessTWT_AveWT;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ProcessTWT_AveWT;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ProcessTWT_AveWT;1"
            ElseIf iProcess = 4 Then
                crTables.Item("ASYS_REMProcessLoanAmountV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMProcessLoanAmountV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMProcessLoanAmountV31;1"
            ElseIf iProcess = 5 Then
                crTables.Item("ASYS_ProcessTotalREM;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_ProcessTotalREM;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ProcessTotalREM;1"
            ElseIf iProcess = 6 Then
                crTables.Item("spReport3").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("spReport3").Location = objcommom.sDatabase1 + ".dbo.spReport3"
            End If
            CrystalReportViewer1.ReportSource = oRPT

        Catch ex As Exception
            MsgBox("frmProcess/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmProcessQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If iProcess = 1 Then
                Me.Text = "REM PROCESS COUNT REPORT - QTY/PCS" '"REM Process Count Report - Qty/Pcs."
            ElseIf iProcess = 2 Then
                Me.Text = "REM PROCESS COUNT REPORT - TWT" '"REM Process Count Report - TWT"
            ElseIf iProcess = 3 Then
                Me.Text = "REM PROCESS COUNT REPORT - AVE. WT." '"REM Process Count Report - Ave. Wt."
            ElseIf iProcess = 4 Then
                Me.Text = "REM PROCESS COUNT REPORT - LOAN" '"REM Process Count Report - LOAN"
            ElseIf iProcess = 5 Then
                Me.Text = "REM PROCESS COUNT REPORT - % TO TOTAL REM" '"REM Process Count Report - % to Total REM"
            ElseIf iProcess = 6 Then
                Me.Text = "REM PROCESS COUNT REPORT - % TO TOTAL PRENDA" '"REM Process Count Report - % to Total Prenda"
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

            Dim syr, x As Integer
            syr = System.DateTime.Now.Year
            For x = 0 To 4
                Me.ComboBox1.Items.Add(syr)
                syr = syr - 1
            Next

            ComboBox2.SelectedIndex = iMonth - 1
            For i = 0 To ComboBox1.Items.Count - 1
                If CInt(ComboBox1.Items(i)) = iYear Then
                    ComboBox1.SelectedIndex = i
                    Exit For
                End If
            Next



        Catch ex As Exception
            MsgBox("frmProcess/frmProcessQty_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmProcess/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmProcess/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmProcess/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
