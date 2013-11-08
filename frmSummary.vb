Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmSummary
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Public iSummary As Integer

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
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSummary))
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(216, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox3.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "USER NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "HABWA MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = " --"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(304, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox2.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(216, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 64)
        Me.Button1.TabIndex = 20
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 128)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(608, 320)
        Me.CrystalReportViewer1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(440, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 32)
        Me.Label4.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "User name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox4.Location = New System.Drawing.Point(480, 16)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox4.TabIndex = 30
        Me.ComboBox4.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(448, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "DAY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "LOT NO."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(208, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(440, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 64)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 40)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "RETURN"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(16, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "OUTSOURCE"
        '
        'frmSummary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Report - Cellular"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ahm As String

            If ComboBox1.Text = "" Then
                MsgBox("Select year", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If ComboBox2.Text = "" Then
                MsgBox("Select month", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If ComboBox3.Text = "" Then
                MsgBox("Select sorter", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
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

            If sDB = "" Then
                objcommom.Connectionstring3()
            Else
                objcommom.ConnectionString1()
            End If


            Select Case iSummary
                Case 1
                    oRPT.Load(sPath + "\ASYS_REMSummaryCell.rpt")
                Case 2
                    oRPT.Load(sPath + "\ASYS_REMSummaryWatch.rpt")
                Case 3
                    oRPT.Load(sPath + "\ASYS_REMSummaryGoodStock.rpt")
                Case 5
                    oRPT.Load(sPath + "\ASYS_rptSumReceived.rpt")
                Case 6
                    oRPT.Load(sPath + "\ASYS_rptSumUnreceived.rpt")
                Case 7
                    oRPT.Load(sPath + "\ASYS_rptSumReleased.rpt")
                Case 8
                    oRPT.Load(sPath + "\ASYS_rptSumUnReleased.rpt")
            End Select

            If iSummary < 5 Then
                oRPT.SetParameterValue("prenda", UCase(Format(DateAdd("m", -7, CDate(ComboBox1.Text & "-1-" & ComboBox2.Text)), "yyyy MMMM"))) 'UCase(objclass.Prenda(ComboBox1, ComboBox2)))
                oRPT.SetParameterValue("habwa", UCase(ComboBox1.Text + " " + ComboBox2.Text))
                oRPT.SetParameterValue("@Pname", UCase(Trim(ComboBox3.Text)))
            End If

            If iSummary = 3 Then
                If Label4.Text <> "" Then
                    oRPT.SetParameterValue("@Hmonth", ComboBox2.SelectedIndex + 1)
                    oRPT.SetParameterValue("@Hyear", ComboBox1.SelectedItem)
                    oRPT.SetParameterValue("costcenter", Label4.Text)
                    oRPT.SetParameterValue("status", recrel)
                    oRPT.SetParameterValue("RLC", ahm)
                    oRPT.SetParameterValue("lotno", Label7.Text)
                    oRPT.SetParameterValue("day", ComboBox4.Text)
                Else
                    If sDB <> "" Then
                        oRPT.SetParameterValue("@Pmonth", ComboBox2.SelectedIndex + 1)
                        oRPT.SetParameterValue("@Pyear", ComboBox1.SelectedItem)
                        oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                    Else
                        oRPT.SetParameterValue("month", ComboBox2.SelectedIndex + 1)
                        oRPT.SetParameterValue("year", ComboBox1.SelectedItem)
                        oRPT.SetParameterValue("lotno", Label7.Text)
                        If RadioButton1.Checked = True Then
                            oRPT.SetParameterValue("outsourceorreturn", "Outsource")
                            oRPT.SetParameterValue("day", ComboBox4.Text)
                        Else
                            oRPT.SetParameterValue("outsourceorreturn", "Returns")
                            oRPT.SetParameterValue("day", ComboBox4.Text)
                        End If
                    End If

                End If
            ElseIf iSummary = 2 Or iSummary = 1 Then
                oRPT.SetParameterValue("@Pmonth", UCase(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("@Pyear", ComboBox1.SelectedItem)
                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            ElseIf iSummary = 5 Then
                oRPT.SetParameterValue("@MONTH", UCase(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("@YEAR", ComboBox1.SelectedItem)
                oRPT.SetParameterValue("@EMPNAME", UCase(fullname))
                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            ElseIf iSummary = 6 Then
                Dim habwadate As DateTime = UCase(ComboBox2.Text) & "-1-" & ComboBox1.Text
                oRPT.SetParameterValue("@HABWADATE", habwadate)
                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                oRPT.SetParameterValue("@EMPNAME", UCase(fullname))
                oRPT.SetParameterValue("@MONTH", UCase(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("@YEAR", ComboBox1.SelectedItem)
                oRPT.SetParameterValue("@ZONE", sDB)
            ElseIf iSummary = 7 Then
                oRPT.SetParameterValue("@MONTH", UCase(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("@YEAR", ComboBox1.SelectedItem)
                oRPT.SetParameterValue("@EMPNAME", UCase(fullname))
                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            ElseIf iSummary = 8 Then
                'Dim DateOfHabwa As DateTime = UCase(ComboBox2.Text) & "-1-" & ComboBox1.Text
                'oRPT.SetParameterValue("@DateOfHabwa", DateOfHabwa)
                oRPT.SetParameterValue("@EMPNAME", UCase(fullname))
                oRPT.SetParameterValue("@MONTH", UCase(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("@YEAR", ComboBox1.SelectedItem)
                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
            End If



            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            Select Case iSummary
                Case 1
                    crTables.Item("ASYS_REMSummaryCell_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMSummaryCell_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMSummaryCell_rpt;1"

                Case 2
                    crTables.Item("ASYS_REMSummaryWatch_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMSummaryWatch_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMSummaryWatch_rpt;1"
                Case 3
                    If Label4.Text = "" Then
                        crTables.Item("ASYS_REMSummaryGoodStock_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_REMSummaryGoodStock_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMSummaryGoodStock_rpt;1"
                    ElseIf Label4.Text <> "REM" Then
                        crTables.Item("spSummaryGood1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("spSummaryGood1").Location = objcommom.sDatabase1 + ".dbo.spSummaryGood1"
                    End If
                Case 4
                    crTables.Item("vw_summary_taken").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("vw_summary_taken").Location = objcommom.sDatabase1 + ".dbo.vw_summary_taken"
                Case 5
                    crTables.Item("procASYS_Received_Branches;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("procASYS_Received_Branches;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_Received_Branches"
                Case 6
                    crTables.Item("ASYS_Unreceived_Branches;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_Unreceived_Branches;1").Location = "REMS" + ".dbo.ASYS_Unreceived_Branches;1"
                    'crTables.Item("procASYS_Unreceived_Branches;1").ApplyLogOnInfo(crtableLogoninfo)
                    'crTables.Item("procASYS_Unreceived_Branches;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_Unreceived_Branches"
                Case 7
                    crTables.Item("procASYS_Released_Branches;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("procASYS_Released_Branches;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_Released_Branches"
                Case 8
                    crTables.Item("procASYS_Unreleased_Branches;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("procASYS_Unreleased_Branches;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_Unreleased_Branches"
            End Select

            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
            objclass = Nothing
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MsgBox("frmSummary/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub valEmp()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj.ConnDb()
            obj.Open5()
            obj.Command5("select fullname from rems.dbo.vw_humresvismin where (job_title like 'ALLB%' or  job_title like 'Sorter%' OR FULLNAME LIKE '%jADRAQUE' or job_title like '%Verifier%')  and fullname not like '%Pableo' and fullname not like '%Sasaban' and fullname not like '%Briones' and Fullname not like '%Baladjay'")
            dr = obj.OpenDataReader5
            While dr.Read
                ComboBox3.Items.Add(UCase(Trim(dr.Item("fullname"))))
            End While
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception
            MsgBox("frmSummary/valEmp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmSummaryCell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Me.WindowState = FormWindowState.Maximized

            'Me.ComboBox3.Items.Add(userLog)
            'Me.ComboBox3.Text = Trim(UCase(userLog))
            Me.ComboBox3.Text = Trim(UCase(userLog))
            callYear()
            If iSummary = 3 Then
                Label7.Visible = True
                Label8.Visible = True
            Else
                Label7.Visible = False
                Label8.Visible = False
            End If
            If sDB <> "" Then
                Me.Label5.Visible = True
                Label7.Visible = False
                Label8.Visible = False
            Else
                'Label7.Text = rellotno
                ComboBox1.Text = Now.Year
                ComboBox2.Text = Now.Month
                ComboBox4.Text = Now.Day
                Label8.Visible = True
                Label7.Visible = True
                Label6.Visible = True
                ComboBox4.Visible = True
                Me.Label3.Visible = False
            End If
            'Dim dr As SqlDataReader
            Dim sQuery As String
            If iSummary > 4 Then
                Label3.Visible = False
                Label5.Visible = False
                Label8.Visible = False
                ComboBox3.Visible = False
                Label7.Visible = False
                GroupBox1.Visible = False
                Label6.Visible = False
                ComboBox4.Visible = False
            End If

            Select Case iSummary
                Case 1
                    Me.Text = "SUMMARY REPORT - CELLULAR"
                Case 2
                    Me.Text = "SUMMARY REPORT - WATCH"
                Case 3
                    If sDB <> "" Then
                        Me.Text = "SUMMARY REPORT - GOOD STOCK"
                    Else
                        Me.Text = "F20"
                    End If
                Case 4
                    Me.Text = "SUMMARY REPORT - TAKEN BACK"
                Case 5
                    Me.Text = "SUMMARY OF RECEIVED BRANCHES"
                Case 6
                    Me.Text = "SUMMARY OF UNRECEIVED BRANCHES"
                Case 7
                    Me.Text = "SUMMARY OF RELEASED BRANCHES"
                Case 8
                    Me.Text = "SUMMARY OF UNRELEASED BRANCHES"
            End Select

            Call habwa_date()
            objcommom = New clsCommon
            Call valEmp()
            ComboBox3.Text = UCase(userLog)

            If outsource = True Then
                If MainCost = "REM" Then
                    RadioButton1.Checked = True
                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    obj.Command3("Select  top 1 lotno_for from tbl_Forcedoutrcv where recname_for = '" & userLog & "' and Month(receivedate_for)=MOnth(getdate()) and Year(receivedate_for)= YEar(getdate()) and Day(receivedate_for)= Day(getdate()) and outsource_status_for = 1")
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        Label7.Text = obj.IsNull(dr.Item("lotno_for"))
                    End If
                    dr.Close()
                    obj.Close3()
                    obj = Nothing
                End If
            Else
                GroupBox1.Visible = False
            End If

        Catch ex As Exception
            MsgBox("frmSummary/frmSummaryCell_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub habwa_date()
        Try
            Dim dr As SqlDataReader
            Dim iMonth, iYear, i As Integer
            If sDB = "" Then
                objcommom = New clsCommon
                objcommom.Connectionstring3()
                objcommom.Open3()
                objcommom.Command3("select cast(month(getdate()) as int) as month, cast(year(getdate()) as int) as year")
                dr = objcommom.OpenDataReader3
                If dr.Read Then
                    iMonth = dr.Item("month")
                    iYear = dr.Item("year")
                End If
                dr.Close()
                objcommom.Close3()

                ComboBox2.SelectedIndex = iMonth - 1
                For i = 0 To ComboBox1.Items.Count - 1
                    If CInt(ComboBox1.Items(i)) = iYear Then
                        ComboBox1.SelectedIndex = i
                        Exit For
                    End If
                Next
            Else
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
            End If
        Catch ex As Exception
            MsgBox("frmSummary/habwa_date: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function callYear()
        Try
            Dim tu, ig As Integer
            tu = Now.Year

            For ig = 1 To 5
                ComboBox1.Items.Add(tu)
                tu = tu - 1
            Next
        Catch ex As Exception
            MsgBox("frmSortedList/tuig: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSummary/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)

        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSummary/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmSummary_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            outsource = False
        Catch ex As Exception
        End Try
    End Sub
End Class
