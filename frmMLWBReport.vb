Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmMLWBReport
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Dim month, temp3, temp2, tan As String
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents cbodate As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMLWBReport))
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.cbodate = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Location = New System.Drawing.Point(216, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox3.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "USER NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(24, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(608, 336)
        Me.CrystalReportViewer1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(440, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 32)
        Me.Label4.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(128, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "LOT NO."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(216, 64)
        Me.Label7.MaxLength = 10
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(408, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 64)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
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
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(216, 16)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(176, 20)
        Me.txtdate.TabIndex = 36
        Me.txtdate.Text = ""
        '
        'cbodate
        '
        Me.cbodate.Location = New System.Drawing.Point(216, 16)
        Me.cbodate.Name = "cbodate"
        Me.cbodate.Size = New System.Drawing.Size(88, 21)
        Me.cbodate.TabIndex = 37
        '
        'frmMLWBReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 445)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbodate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMLWBReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MLWB REPORT"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim ahm As String
            Dim comp As String
            Dim temp, month, temp2, temp3, str, comb As String

            If Me.txtdate.Text = "" Then
                MsgBox("Enter Lot Number.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If ComboBox3.Text = "" Then
                MsgBox("Select username.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            If SelectedForm = "frmMLWBReleasing" Then
                tan = Me.txtdate.Text
                recrel2 = "releasing"
            ElseIf SelectedForm = "frmMLWBReceiving" Then
                tan = Me.txtdate.Text
                recrel2 = "receiving"
            End If

            Me.Cursor = Cursors.WaitCursor
            Dim sdate As Date = tan
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

            objcommom.Connectionstring3()
            If recrel2 = "receiving" Then
                If Label4.Text = "REM" Then
                    'If recrel = 1 Then
                    comp = "rec"
                    oRPT.Load(sPath + "\ASYS_MLWB_GoodstockRcv.rpt")

                End If
            ElseIf recrel2 = "releasing" Then
                If Label4.Text = "PRICING" Then
                    comp = "rel"
                    oRPT.Load(sPath + "\ASYS_MLWB_GoodstockRel.rpt")
                End If
            End If

            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

            If recrel = 1 Then
                recrel2 = "receiving"
                ahm = "RECEIVING REPORT"
            Else
                recrel2 = "releasing"
                ahm = "RELEASING REPORT"
            End If

            'oRPT.SetParameterValue("prenda", objclass.Prenda(Me.txtdate.Text = temp3, Me.txtdate.Text = month))
            'oRPT.SetParameterValue("habwa", Me.txtdate.Text)

            If Label4.Text <> "" Then
                'oRPT.SetParameterValue("@hmonth", sdate.Month)
                'oRPT.SetParameterValue("@hyear", sdate.Year)
                'oRPT.SetParameterValue("costcenter", Label4.Text)
                'oRPT.SetParameterValue("status", recrel)
                'oRPT.SetParameterValue("RLC", ahm)
                If recrel = 1 Then
                    'oRPT.SetParameterValue("lotno", Label7.Text)
                    oRPT.SetParameterValue("@hlot", Label7.Text)
                Else
                    'oRPT.SetParameterValue("reflotno", Label7.Text)
                    oRPT.SetParameterValue("@hlot", Label7.Text)
                End If
                'oRPT.SetParameterValue("day", sdate)
            Else
                'oRPT.SetParameterValue("month", sdate.Month)
                'oRPT.SetParameterValue("year", sdate.Year)
                oRPT.SetParameterValue("@hlot", Label7.Text)
                If RadioButton1.Checked = True Then
                    oRPT.SetParameterValue("outsourceorreturn", "Outsource")
                    'oRPT.SetParameterValue("day", sdate.Day)
                Else
                    oRPT.SetParameterValue("outsourceorreturn", "Returns")
                    'oRPT.SetParameterValue("day", sdate.Day)
                End If
            End If
            'oRPT.SetParameterValue("uname", Trim(UCase(userLog)))
            oRPT.SetParameterValue("uname", Trim(UCase(ComboBox3.SelectedItem)))


            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            If comp = "rec" Then
                crTables.Item("ASYS_SummaryOfGoodStocks_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_SummaryOfGoodStocks_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_SummaryGoodStocks_rpt;1"
            ElseIf comp = "rel" Then
                crTables.Item("ASYS_SummaryGoodStocksRel_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_SummaryGoodStocksRel_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_SummaryGoodStocksRel_rpt;1"
            End If
            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
            objclass = Nothing
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox("frmMLWBReport/Label9_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmMLWBReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            Me.WindowState = FormWindowState.Maximized
            If Label7.Text = "0" Then
                Label7.Text = ""
            End If
            'Me.ComboBox3.Items.Add(userLog)

            If iSummary = 3 Then
                Label7.Visible = True
                Label8.Visible = True
            Else
                Label7.Visible = False
                Label8.Visible = False
            End If


            Label8.Visible = True
            Label7.Visible = True
            Me.Label3.Visible = True

            'Dim dr As SqlDataReader
            Dim sQuery As String

            'Me.Text = "F20"

            Call habwa_date()
            objcommom = New clsCommon
            sQuery = "select distinct upper(rtrim(fullname)) as fullname,blocked,job_title from " & humres2 & " where job_title in ('ALLBOSMAN', 'mlwb') and blocked =1  and fullname not in ('GENELOUIE NEMENO','PORTIA BRIONES','SHERYL LOVE ONG','ROWENA VILLENA') order by fullname"

            objcommom.ConnDb()
            objcommom.Open5()
            objcommom.Command5(sQuery)
            dr = objcommom.OpenDataReader5
            While dr.Read
                ComboBox3.Items.Add(Trim(dr.Item("fullname")))
            End While
            dr.Close()
            'objcommom.CloseDataReader()
            objcommom.Close5()
            objcommom = Nothing
            Me.ComboBox3.Enabled = True
            Me.ComboBox3.BackColor = Color.White
            Me.ComboBox3.Text = Trim(userLog)
            If Label4.Text = "MLWB" Then
                If recrel = 1 Then
                    recrel2 = "receiving"
                Else
                    recrel2 = "releasing"
                End If
            End If

            Dim objclass As New clsCommon
            Dim temp, str, comb As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            If recrel2 = "receiving" Then

                sQuery = "select top 1 reflotno as lotno, receivedate from ASYS_MLWB_detail where status = 'received' and reflotno = '" & Me.Label7.Text & "' order by receivedate desc"
                obj.Command3(sQuery)
                dr = obj.OpenDataReader3
                If dr.Read Then
                    Me.Label7.Text = Trim(dr.Item("lotno"))
                    txtdate.Text = dr.Item("receivedate")
                    tan = txtdate.Text
                    Me.Button1.Enabled = True
                End If
                dr.Close()
                obj.Close3()

                Me.cbodate.SendToBack()
                Me.cbodate.Enabled = False
                Me.cbodate.Visible = False
                Me.txtdate.BringToFront()
                Me.txtdate.ReadOnly = True
                Me.txtdate.BackColor = Color.White

            ElseIf recrel2 = "releasing" Then
                sQuery = "select top 1 reflotno as lotno,releasedate from ASYS_MLWB_detail where status = 'released' order by releasedate desc"
                obj.Command3(sQuery)
                dr = obj.OpenDataReader3
                If dr.Read Then
                    Me.Label7.Text = Trim(dr.Item("lotno"))
                    txtdate.Text = dr.Item("releasedate")
                    tan = txtdate.Text
                    Me.Button1.Enabled = True
                End If
                dr.Close()
                obj.Close3()
                Me.cbodate.SendToBack()
                Me.cbodate.Enabled = False
                Me.cbodate.Visible = False
                Me.txtdate.BringToFront()
                Me.txtdate.ReadOnly = True
                Me.txtdate.BackColor = Color.White
            End If
            Button1.Focus()
            Me.txtdate.ReadOnly = True
            Me.txtdate.BackColor = Color.White

            Me.ComboBox3.Text = userLog
            If txtdate.Text <> "" Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
            Label7.Focus()
        Catch ex As Exception
            MsgBox("frmMLWBReport/frmMLWBReport_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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

                'ComboBox2.SelectedIndex = iMonth - 1
                'For i = 0 To ComboBox1.Items.Count - 1
                '    If CInt(ComboBox1.Items(i)) = iYear Then
                '        ComboBox1.SelectedIndex = i
                '        Exit For
                '    End If
                'Next
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
                'ComboBox2.SelectedIndex = iMonth - 1
                'For i = 0 To ComboBox1.Items.Count - 1
                '    If CInt(ComboBox1.Items(i)) = iYear Then
                '        ComboBox1.SelectedIndex = i
                '        Exit For
                '    End If
                'Next
        End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/frmMLWBReport_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmSummary_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        outsource = False
    End Sub

    Private Sub Label7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Label7.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            Dim dr As SqlDataReader
            Dim objclass As New clsCommon
            Dim temp, str, comb As String
            If Me.txtdate.Text = "" Then
                Me.Button1.Enabled = False
            Else
                Me.Button1.Enabled = True
            End If

            If e.KeyChar = ChrW(13) Then
                objclass = New clsCommon
                objclass.Connectionstring3()
                objclass.Open3()
                If recrel2 = "receiving" Then
                    str = "Select month(receivedate) as month, day(receivedate) as day, year(receivedate) as year, receivedate from asys_MLWB_detail where lotno = '" & Label7.Text & "' order by receivedate desc"
                    objclass.Command3(str)
                    dr = objclass.OpenDataReader3()
                    If dr.Read Then
                        temp = dr.Item("month")
                        'month = temp
                        temp2 = dr.Item("day")
                        temp3 = dr.Item("year")
                        'Select Case month
                        '    Case "1"
                        '        month = "January"
                        '    Case "2"
                        '        month = "February"
                        '    Case "3"
                        '        month = "March"
                        '    Case "4"
                        '        month = "April"
                        '    Case "5"
                        '        month = "May"
                        '    Case "6"
                        '        month = "June"
                        '    Case "7"
                        '        month = "July"
                        '    Case "8"
                        '        month = "August"
                        '    Case "9"
                        '        month = "September"
                        '    Case "10"
                        '        month = "October"
                        '    Case "11"
                        '        month = "November"
                        '    Case "12"
                        '        month = "December"
                        'End Select
                        'comb = CStr(month + " " + temp2 + "," + " " + temp3)
                        'Me.cbodate.Text = comb
                        Me.txtdate.Text = Trim(dr.Item("receivedate"))
                        tan = temp3 + "-" + temp + "-" + temp2
                    End If
                    Me.cbodate.SendToBack()
                    Me.cbodate.Enabled = False
                    Me.cbodate.Visible = False
                    Me.txtdate.BringToFront()
                    Me.txtdate.ReadOnly = True
                    Me.txtdate.BackColor = Color.White
                    If txtdate.Text <> "" Then
                        Me.Button1.Enabled = True
                    Else
                        Me.Button1.Enabled = False
                    End If
                    Button1.Focus()
                ElseIf recrel2 = "releasing" Then
                    str = "Select month(releasedate) as month, day(releasedate) as day, year(releasedate) as year, releasedate from asys_MLWB_detail where reflotno = '" & Label7.Text & "' and status = 'released' order by releasedate desc"
                    objclass.Command3(str)
                    dr = objclass.OpenDataReader3()
                    If dr.Read Then
                        temp = dr.Item("month")
                        'month = MonthName(temp, False)
                        temp2 = dr.Item("day")
                        temp3 = dr.Item("year")
                        'comb = CStr(month + " " + temp2 + "," + " " + temp3)
                        'Me.cbodate.Text = comb
                        Me.txtdate.Text = Trim(dr.Item("releasedate"))
                        tan = temp3 + "-" + temp + "-" + temp2
                        Button1.Focus()
                    End If
                    Me.cbodate.SendToBack()
                    Me.cbodate.Enabled = False
                    Me.cbodate.Visible = False
                    Me.txtdate.BringToFront()
                    Me.txtdate.ReadOnly = False
                    Me.txtdate.BackColor = Color.White
                    If txtdate.Text <> "" Then
                        Me.Button1.Enabled = True
                    Else
                        Me.Button1.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/Label7_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Label7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.TextChanged
        Try
            If Label7.TextLength <> 10 Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
            If txtdate.Text = "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmMLWBReport/Label7_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
