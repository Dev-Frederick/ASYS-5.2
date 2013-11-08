Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class Report
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Private division As New ArrayList
    Private objcommom As clsCommon
    Dim naa As Boolean
    Dim TradeIn As Boolean
    Dim REMstatus As String


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Llot As System.Windows.Forms.Label
    Friend WithEvents Lot As System.Windows.Forms.TextBox
    Friend WithEvents btnlot As System.Windows.Forms.RadioButton
    Friend WithEvents btnsorter As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Report))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtBranchName = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.btnlot = New System.Windows.Forms.RadioButton
        Me.btnsorter = New System.Windows.Forms.RadioButton
        Me.Llot = New System.Windows.Forms.Label
        Me.Lot = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(930, 360)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BRANCH NAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "HABWA MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(634, -208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 115)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Display 2"
        Me.Button2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(704, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 56)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPORT TYPE"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(8, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SUMMARY"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(88, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "DETAIL"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(24, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 56)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "PREVIEW"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = " --"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(304, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(112, 21)
        Me.ComboBox2.TabIndex = 28
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(224, 13)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox3.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "BRANCH CODE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(224, 40)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 31
        Me.txtBranchCode.Text = ""
        '
        'txtBranchName
        '
        Me.txtBranchName.BackColor = System.Drawing.Color.White
        Me.txtBranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(224, 64)
        Me.txtBranchName.MaxLength = 100
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.ReadOnly = True
        Me.txtBranchName.Size = New System.Drawing.Size(192, 20)
        Me.txtBranchName.TabIndex = 32
        Me.txtBranchName.Text = ""
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(704, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 24)
        Me.CheckBox1.TabIndex = 33
        Me.CheckBox1.Text = "Outsource"
        Me.CheckBox1.Visible = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "LOTNO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(224, 40)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "USER  NAME"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(224, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.Text = ""
        Me.TextBox2.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(224, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 38
        '
        'btnlot
        '
        Me.btnlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlot.Location = New System.Drawing.Point(560, 32)
        Me.btnlot.Name = "btnlot"
        Me.btnlot.Size = New System.Drawing.Size(96, 24)
        Me.btnlot.TabIndex = 39
        Me.btnlot.Text = "BY LOT NUM"
        '
        'btnsorter
        '
        Me.btnsorter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsorter.Location = New System.Drawing.Point(560, 56)
        Me.btnsorter.Name = "btnsorter"
        Me.btnsorter.Size = New System.Drawing.Size(88, 24)
        Me.btnsorter.TabIndex = 40
        Me.btnsorter.Text = "BY SORTER"
        '
        'Llot
        '
        Me.Llot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llot.Location = New System.Drawing.Point(128, 16)
        Me.Llot.Name = "Llot"
        Me.Llot.Size = New System.Drawing.Size(88, 23)
        Me.Llot.TabIndex = 41
        Me.Llot.Text = "LOT NUMBER"
        Me.Llot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Llot.Visible = False
        '
        'Lot
        '
        Me.Lot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lot.Location = New System.Drawing.Point(224, 16)
        Me.Lot.MaxLength = 10
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(144, 20)
        Me.Lot.TabIndex = 42
        Me.Lot.Text = ""
        Me.Lot.WordWrap = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(544, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(120, 72)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RELEASE TYPE"
        '
        'Report
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 485)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.btnsorter)
        Me.Controls.Add(Me.btnlot)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Llot)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Report"
        Me.Text = "Receiving Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub Print_TradeIn(ByVal TRan_TradeIN As Boolean, ByVal status As String)
        Try
            TradeIn = TRan_TradeIN
            REMstatus = status
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PrintTradeIn_Receiving()
        Try


            oRPT = New ReportDocument
            objcommom = New clsCommon
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim temp As SubreportContext
            Dim objclsreprt As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If REMstatus = "RECEIVING" Then
                If RadioButton1.Checked = True Then
                    oRPT.Load(sPath + "\ASYS_TradeInReceiving_Summary.rpt")
                Else
                    oRPT.Load(sPath + "\ASYS_TradeInReceiving.rpt")
                End If

            Else
                    oRPT.Load(sPath + "\ASYS_TradeInReleasing.rpt")
                End If

                oRPT.SetParameterValue("@PBranchCode", Trim(txtBranchCode.Text))
                oRPT.SetParameterValue("@PMonth", ComboBox2.SelectedIndex + 1)
                oRPT.SetParameterValue("@PYear", ComboBox3.Text)

                objcommom.ConnectionString1()


                With crConnectionInfo
                    .ServerName = objcommom.sDatasource1
                    .DatabaseName = objcommom.sDatabase1
                    .UserID = objcommom.sUsername1
                    .Password = objcommom.sPassword1
                End With

                crTables = oRPT.Database.Tables
                crtableLogoninfo.ConnectionInfo = crConnectionInfo

                If REMstatus = "RECEIVING" Then
                    crTables.Item("ASYS_TradeInReceiving;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_TradeInReceiving;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_TradeInReceiving;1"
                Else
                    crTables.Item("ASYS_TradeInReleasing;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_TradeInReleasing;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_TradeInReleasing;1"
                End If

                CrystalReportViewer1.ReportSource = oRPT
                Button3.Enabled = True
                Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Report/PrintTradeIn_Receiving: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        'Me.Cursor = Cursors.WaitCursor
        Try
            If TradeIn = True Then
                PrintTradeIn_Receiving()
                Exit Sub
            End If

            If outsource = False Then
                If Me.btnlot.Checked = True And Me.Lot.Visible = True Then
                    Call previewlotreport()
                    Exit Sub
                End If
                'ElseIf btnsorter.Enabled = False Then

                If recrelrep = True Then
                    If txtBranchCode.Text = "" Then
                        MsgBox("Branchcode is empty", MsgBoxStyle.Information, TitleMsgBox)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If

                    If txtBranchName.Text = "" Then
                        MsgBox("Branchname is empty", MsgBoxStyle.Information, TitleMsgBox)
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End If


                If ComboBox2.Text = "" Then
                    MsgBox("Select a month", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
                If ComboBox3.Text = "" Then
                    MsgBox("Select a year", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
            End If

            Button3.Enabled = False
            oRPT = New ReportDocument
            objcommom = New clsCommon
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim temp As SubreportContext
            Dim objclsreprt As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If TextBox1.Visible = False Then
                If recrelrep = True Then
                    If RadioButton1.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMReceivingReport_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMReceivingReport.rpt")
                    End If
                Else
                    If RadioButton1.Checked = True Then
                        MsgBox("Releasing Summary is not available.", MsgBoxStyle.Information, TitleMsgBox)
                        Cursor = Cursors.Default
                        Button3.Enabled = True
                        Exit Sub
                        oRPT.Load(sPath + "\release_rpt_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMReleasing.rpt")
                    End If
                End If
            Else
                If recrelrep = False Then
                    If RadioButton1.Checked = True Then
                        MsgBox("Releasing Summary is not available.", MsgBoxStyle.Information, TitleMsgBox)
                        Cursor = Cursors.Default
                        Button3.Enabled = True
                        Exit Sub
                        oRPT.Load(sPath + "\release_outsource_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMOutsourceRelease.rpt")
                    End If
                Else
                    If RadioButton1.Checked = True Then
                        oRPT.Load(sPath + "\receive_rpt_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\receive_rpt.rpt")
                    End If
                End If
            End If

            If recrelrep = True Then
                oRPT.SetParameterValue("@HBranchCode", txtBranchCode.Text.Trim)
                oRPT.SetParameterValue("prenda", UCase(objclsreprt.Prenda(ComboBox3, ComboBox2)))
                'oRPT.SetParameterValue("prenda", byear + " " + bmonth)
                oRPT.SetParameterValue("branchname", txtBranchName.Text.Trim)
                oRPT.SetParameterValue("habwa", ComboBox3.Text & " " & ComboBox2.Text)
                oRPT.SetParameterValue("@HMonth", ComboBox2.SelectedIndex + 1)
                oRPT.SetParameterValue("@HYear", ComboBox3.SelectedItem)
                oRPT.SetParameterValue("user", Trim(UCase(userLog)))
                oRPT.SetParameterValue("@Print", UCase(Format(Now.Date, "MMMM dd, yyyy")))
            Else
                If TextBox1.Visible = True Then
                    oRPT.SetParameterValue("@Plotno", Me.TextBox1.Text)
                Else
                    oRPT.SetParameterValue("@Pname", Trim(ComboBox1.Text))
                    oRPT.SetParameterValue("@Pmonth", ComboBox2.SelectedIndex + 1)
                    oRPT.SetParameterValue("@Pyear", ComboBox3.Text)
                    'oRPT.SetParameterValue("@sname", Trim(ComboBox1.Text))
                    'oRPT.SetParameterValue("@smonth", ComboBox2.SelectedIndex + 1)
                    'oRPT.SetParameterValue("@syear", ComboBox3.Text)
                End If
            End If

            If sDB <> "" Then
                objcommom.ConnectionString1()
            Else
                objcommom.Connectionstring3()
            End If

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With

            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            If recrelrep = True Then
                crTables.Item("ASYS_spREMReceivingReport;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_spREMReceivingReport;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_spREMReceivingReport;1"
            Else
                If TextBox1.Visible = True Then
                    crTables.Item("ASYS_REMReleaseOutsource_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMReleaseOutsource_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMReleaseOutsource_rpt;1"
                Else
                    crTables.Item("ASYS_REMRelease_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMRelease_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMRelease_rpt;1"
                End If

            End If

            CrystalReportViewer1.ReportSource = oRPT
            Button3.Enabled = True
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox("Report/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function previewlotreport()
        Try
            Button3.Enabled = False
            oRPT = New ReportDocument
            objcommom = New clsCommon
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim temp As SubreportContext
            Dim objclsreprt As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If TextBox1.Visible = False Then
                If recrelrep = True Then
                    If RadioButton1.Checked = True Then
                        oRPT.Load(sPath + "\REMReceivingReport_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\REMReceivingReport.rpt")
                    End If
                Else
                    If RadioButton1.Checked = True Then
                        MsgBox("Releasing Summary is not available.", MsgBoxStyle.Information, TitleMsgBox)
                        Cursor = Cursors.Default
                        Button3.Enabled = True
                        Exit Function
                        oRPT.Load(sPath + "\release_rpt_summary.rpt")

                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMReleasingbylot.rpt")
                        oRPT.SetParameterValue("@PrintedDat", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                    End If
                End If
            Else
                If recrelrep = False Then
                    If RadioButton1.Checked = True Then
                        MsgBox("Releasing Summary is not available.", MsgBoxStyle.Information, TitleMsgBox)
                        Cursor = Cursors.Default
                        Button3.Enabled = True
                        Exit Function
                        oRPT.Load(sPath + "\release_outsource_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\ASYS_REMOutsourceRelease.rpt")
                    End If
                Else
                    If RadioButton1.Checked = True Then
                        oRPT.Load(sPath + "\receive_rpt_summary.rpt")
                    ElseIf RadioButton2.Checked = True Then
                        oRPT.Load(sPath + "\receive_rpt.rpt")
                    End If
                End If
            End If

            oRPT.SetParameterValue("@lot", Me.Lot.Text)
            oRPT.SetParameterValue("@user", Trim(UCase(userLog)))

            'If sDB <> "" Then
            '    objcommom.ConnectionString1()
            'Else
            objcommom.Connectionstring3()
            'End If

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With

            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            If recrelrep = True Then
                crTables.Item("ASYS_spREMReceivingReport;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_spREMReceivingReport;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_spREMReceivingReport;1"
            Else
                If TextBox1.Visible = True Then
                    crTables.Item("ASYS_REMReleaseOutsource_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMReleaseOutsource_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMReleaseOutsource_rpt;1"
                Else
                    crTables.Item("ASYS_REMReleaseByLot_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_REMReleaseByLot_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMReleaseByLot_rpt;1"
                End If

            End If

            CrystalReportViewer1.ReportSource = oRPT
            Button3.Enabled = True
        Catch ex As Exception
            MsgBox("Report/previewlotreport: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    'Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Call retreivebranch()
    'End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Report/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Report/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Report/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim objclass As New clsCommon
            If e.KeyCode = Keys.Enter Then
                If txtBranchCode.Text.Trim.Length = 0 Then
                    MsgBox("Enter a valid Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                    Exit Sub
                End If
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                '' objclass.Command5("Select bedrnm from " & zonebedryf & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                End If

                dr = objclass.OpenDataReader5
                If dr.Read = True Then
                    txtBranchName.Text = UCase(dr.Item("bedrnm"))
                    Button3.Enabled = True
                Else
                    MsgBox("Branch code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
                Me.Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Report/txtBranchCode_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchName.KeyDown
        Try
            Dim dr As SqlDataReader
            Dim objclass As New clsCommon

            If e.KeyCode = Keys.Enter Then
                If txtBranchName.Text.Trim.Length = 0 Then
                    MsgBox("Enter a valid Branch Name.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchName.Focus()
                    Exit Sub
                End If
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtBranchName.Text.Trim + "'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtBranchName.Text.Trim + "'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtBranchName.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtBranchName.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnr from REMS.dbo.vw_bedryf" & sDB & " where bedrnm='" + txtBranchName.Text.Trim + "'")
                End If
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    txtBranchCode.Text = dr.Item("bedrnr")
                Else
                    MsgBox("Enter a valid Branch Name.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchName.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
            End If
        Catch ex As Exception
            MsgBox("Report/txtBranchName_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub valEmp()

        Dim obj As New clsCommon
        Dim dr As SqlDataReader
        Try
            obj.ConnDb()
            obj.Open5()
            obj.Command5("select * from rems.dbo.vw_humresvismin where (job_title like 'ALLB%' or  job_title like 'Sorter%' OR FULLNAME LIKE '%jADRAQUE')  and fullname not like '%Pableo' and fullname not like '%Sasaban' and fullname not like '%Briones' and Fullname not like '%Baladjay'")
            dr = obj.OpenDataReader5
            While dr.Read
                ComboBox1.Items.Add(UCase(dr.Item("fullname")))
            End While
            dr.Close()
            obj.Execute5()
            obj.Close5()

        Catch ex As Exception
            obj.Close5()
            dr.Close()
            MsgBox("Report/valEmp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function loadlot()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            If sDB = "" Then
                Exit Try
            ElseIf sDB <> "" Then
                obj = New clsCommon
                obj.ConnectionString1()
                obj.Open()
                btnlot.Visible = True
                Label5.Visible = True
                str = "select distinct isnull(reflotno,'') as reflotno from (select max(reflotno) as reflotno from ASYS_REM_Detail where releaser = '" & userLog & "' and actionclass in ('Outsource','GoodStock','Watch','Cellular') and actionclass is not null and status = 'released' union all select max(reflotno) refallbarcode from ASYS_REMOutsource_Detail where releaser = '" & userLog & "' and actionclass is not null and status = 'released' )a"
                obj.Command(str)
                dr = obj.OpenDataReader
                If dr.Read Then
                    Me.Lot.Text = obj.IsNull(Trim(dr.Item("reflotno")))
                End If
                dr.Close()
                obj.Close()
            End If
        Catch ex As Exception
            MsgBox("Report/loadlot: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Function callYear()
        Try
            Dim tu, ig As Integer
            tu = Now.Year

            For ig = 1 To 5
                ComboBox3.Items.Add(tu)
                tu = tu - 1
            Next
        Catch ex As Exception
            MsgBox("frmSortedList/tuig: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Call valEmp()
            Call callYear()
            ComboBox3.Text = Now.Year
            ComboBox2.Text = MonthName(Now.Month)
            Me.btnlot.Checked = True
            ComboBox1.Text = UCase(userLog)
            'Me.WindowState = FormWindowState.Maximized
            If outsource = False Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3("Select  isnull(max(reflotno), 0) as reflotno from ASYS_REMOutsource_detail where releaser = '" & userLog & "' and Month(releasedate)=MOnth(getdate()) and Year(releasedate)= YEar(getdate()) and status = 'RELEASED'") 'and Day(releasedate)= Day(getdate()) and status = 'RELEASED'")
                dr = obj.OpenDataReader3
                If dr.Read = True Then
                    'TextBox1.Text = obj.IsNull(Trim(dr.Item("reflotno")))
                    TextBox1.Text = Trim(dr.Item("reflotno"))
                End If
                dr.Close()
                'obj.Execute3()
                obj.Close3()
                obj = Nothing
                If TextBox1.TextLength = 10 Then
                    Button3.Enabled = True
                Else
                    Button3.Enabled = False
                End If
            End If
            'ComboBox2.Text = MonthName(Now.Month)
            'ComboBox3.Text = Now.Year
            TextBox2.Text = UCase(RTrim(userLog))
            If bleh = True Then
                'Me.TextBox1.Text = rellot
                'Me.Label6.Visible = False
                'Me.TextBox2.Visible = False
                'Me.Label5.Text = "LOTNO"
                'Me.Label5.Visible = True
                'Me.TextBox1.Visible = True
                'txtBranchName.Visible = False
                'Label1.Visible = False
                'CheckBox1.Checked = True
                'Exit Sub
            End If
            If recrelrep = False Then
                If bleh = False Then
                    If outsource = False Then
                        Me.txtBranchCode.Enabled = True
                        Me.txtBranchName.Enabled = True
                        Me.ComboBox2.Enabled = True
                        Me.ComboBox3.Enabled = True
                        Me.txtBranchCode.Visible = False
                        Me.txtBranchName.Visible = False
                        Me.ComboBox2.Visible = True
                        Me.ComboBox3.Visible = True
                        Label2.Visible = True
                        Label1.Visible = False
                        Label3.Visible = True
                        Label4.Visible = False
                        Me.Lot.Visible = True
                        Me.Lot.Enabled = True
                        Me.Label5.Visible = False
                        Me.TextBox1.Visible = False
                        naa = True
                        Me.txtBranchName.Visible = False
                        Me.RadioButton2.Checked = True
                    Else
                        TextBox1.Visible = True
                        Label5.Visible = False
                        Me.txtBranchCode.Enabled = False
                        Me.txtBranchName.Enabled = False
                        Me.ComboBox2.Enabled = False
                        Me.ComboBox3.Enabled = False
                        Me.txtBranchCode.Visible = False
                        Me.txtBranchName.Visible = False
                        Me.ComboBox2.Visible = False
                        Me.ComboBox3.Visible = False
                        TextBox2.Visible = False
                        Label6.Visible = True
                        Label2.Visible = False
                        Label1.Visible = False
                        Label3.Visible = False
                        Label4.Visible = False
                        Me.ComboBox1.Visible = False
                        Lot.Visible = False

                        Me.Label4.Visible = False
                        Me.Label5.Visible = False
                        Me.ComboBox1.Visible = False
                        Me.txtBranchCode.Visible = False
                        Me.Label6.Text = "LOTNO"
                        ' Me.TextBox1.Text = userLog
                    End If
                Else
                    TextBox1.Visible = True
                    Label5.Visible = True
                    Me.txtBranchCode.Enabled = False
                    Me.txtBranchName.Enabled = False
                    Me.ComboBox2.Enabled = False
                    Me.ComboBox3.Enabled = False
                    Me.txtBranchCode.Visible = False
                    Me.txtBranchName.Visible = False
                    Me.ComboBox2.Visible = False
                    Me.ComboBox3.Visible = False
                    TextBox2.Visible = False
                    Label6.Visible = False
                    Label2.Visible = False
                    Label1.Visible = False
                    Label3.Visible = False
                    Label4.Visible = False
                    Lot.Visible = False
                    Me.ComboBox1.Visible = False

                End If

            Else
                Me.txtBranchCode.Enabled = True
                Me.txtBranchName.Enabled = True
                Me.ComboBox2.Enabled = True
                Me.ComboBox3.Enabled = True
                Me.txtBranchCode.Visible = True
                Me.txtBranchName.Visible = True
                Me.ComboBox2.Visible = True
                Me.ComboBox3.Visible = True
                Me.Label5.Visible = False
                Me.ComboBox1.Visible = False
                Me.TextBox1.Visible = False
                Me.Lot.Visible = False
                Me.Llot.Visible = False
                Me.GroupBox2.Visible = False
                Me.btnlot.Visible = False
                Me.btnsorter.Visible = False
                Label4.Visible = True
                Label2.Visible = True
                Label1.Visible = True
                Label3.Visible = True
                Me.ComboBox2.Visible = True
                Me.ComboBox3.Visible = True
                Me.Button3.Enabled = True
                Exit Sub
            End If
            Me.Label2.Visible = False
            Me.ComboBox3.Visible = False
            Me.Label3.Visible = False
            Me.ComboBox2.Visible = False
            Me.txtBranchName.ReadOnly = True
            Me.txtBranchName.BackColor = Color.White
            'Call loadlot()
            If outsource = True Then
                If Me.TextBox1.TextLength = 10 Then
                    Button3.Enabled = True
                Else
                    Button3.Enabled = False
                    TextBox1.Focus()
                End If
            ElseIf outsource = False Then
                If Me.Lot.TextLength = 10 Then
                    Button3.Enabled = True
                Else
                    Button3.Enabled = False
                    Me.Lot.Focus()
                End If
            End If
            RadioButton2.Checked = True
        Catch ex As Exception
            MsgBox("Report/Report_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            'obj.Close3()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then
                ' Report_Load(sender, e)
                txtBranchCode.Text = 0
                txtBranchName.Text = "NONE"
            Else
                txtBranchCode.Text = ""
                txtBranchName.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Report/CheckBox1_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Report_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Dim frm As New FrmNewReceiving
            FlagRptPrvw = False
            outsource = False
            bleh = False
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Report/Report_Closed: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlot.CheckedChanged
        Try
            If btnlot.Checked = True Then
                'Me.Lot.Text = ""
                If outsource = False Then
                    Me.Llot.Visible = True
                    Me.Lot.Visible = True
                End If
                'If naa = True Then
                '    Me.Llot.Visible = False
                '    Lot.Visible = True
                'End If

                Me.txtBranchName.Visible = False
                Me.Label1.Visible = False
                Me.Label2.Visible = False
                Me.ComboBox3.Visible = False
                Me.Label3.Visible = False
                Me.ComboBox2.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Report/RadioButton3_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnsorter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsorter.CheckedChanged
        Try
            If btnsorter.Checked = True Then
                Me.ComboBox2.Text = CStr(MonthName(Now.Month))
                Me.Llot.Visible = False
                Me.Lot.Visible = False
                Me.txtBranchName.Visible = True
                Me.Label1.Visible = True
                Me.Label2.Text = "MONTH"
                Me.Label2.Visible = True
                Me.ComboBox3.Visible = True
                Me.Label3.Visible = True
                Me.ComboBox2.Visible = True
                Me.ComboBox2.Enabled = True
                Me.ComboBox3.Enabled = True
                Me.txtBranchName.Visible = False
                Label1.Visible = False
            End If
        Catch ex As Exception
            MsgBox("Report/btnsorter_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Lot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Lot.KeyPress
        Try
            Dim dr As SqlDataReader
            Dim objclass As New clsCommon

            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Lot.Text = "" Then
                    MsgBox("Enter Lot Number.", MsgBoxStyle.Information, TitleMsgBox)
                    Lot.Focus()
                    Exit Sub
                ElseIf Lot.Text.Length < 10 Then
                    MsgBox("Lot Number doesn't exist", MsgBoxStyle.Information, TitleMsgBox)
                    Lot.Focus()
                    Exit Sub
                End If
                Me.Button3.Enabled = True
                Me.Button3.Focus()
            End If
        Catch ex As Exception
            MsgBox("Report/Lot_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Lot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lot.TextChanged
        Try
            If Lot.TextLength = 10 Then
                Me.Button3.Enabled = True
            Else
                Me.Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Report/Lot_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        'txtBranchName.Text = ""
        'If txtBranchCode.Text.Length < 3 Then
        '    txtBranchName.Text = ""
        '    Button3.Enabled = False
        'End If
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("Report/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Try
            If TextBox1.Text <> "" Then
                Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Report/RadioButton2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Try
            If TextBox1.Text <> "" Then
                Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Report/RadioButton1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnsorter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsorter.Click
        Try
            If TextBox1.Text <> "" Then
                Button3.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Report/btnsorter_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If TextBox1.TextLength = 10 Then
                Button3.Enabled = True
            Else
                Button3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Report/TextBox1_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
    End Sub

End Class
