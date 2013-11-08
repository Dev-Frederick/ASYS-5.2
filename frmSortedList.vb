Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmSortedList
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Private division As New ArrayList
    Private objcommom As clsCommon

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSortedList))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtBranchName = New System.Windows.Forms.TextBox
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "HABWA MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 16)
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
        Me.ComboBox2.Location = New System.Drawing.Point(312, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 21)
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 104)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(776, 376)
        Me.CrystalReportViewer1.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(528, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 64)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPORT TYPE"
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(24, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "SUMMARY"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(128, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "DETAIL"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtBranchName
        '
        Me.txtBranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(216, 68)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(248, 20)
        Me.txtBranchName.TabIndex = 68
        Me.txtBranchName.Text = ""
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(216, 44)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 67
        Me.txtBranchCode.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "BRANCH CODE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "BRANCH NAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSortedList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 485)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSortedList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rematado Sorted List Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSortedList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call retreivebranch()
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim dr As SqlDataReader
            Dim iMonth, iYear, i As Integer
            If admintitle = True Then
                iMonth = Now.Month
                iYear = Now.Year
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
            ComboBox2.Text = CStr(MonthName(Now.Month))
            Call tuig()
            ComboBox1.Text = Now.Year
            Me.Button1.Enabled = False
            Me.txtBranchName.ReadOnly = True
            Me.txtBranchName.BackColor = Color.White
            Me.txtBranchCode.Focus()
        Catch ex As Exception
            MsgBox("frmSortedList/frmSortedList_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub retreivebranch()
    '    Dim dr As SqlDataReader
    '    objcommom = New clsCommon
    '    objcommom.ConnectionString1()
    '    objcommom.Open()
    '    objcommom.Command("select distinct division, dbo.vw_bedryf" + sDB + ".bedrnm from tbl_receiving inner join dbo.vw_bedryf" + sDB + " on tbl_receiving.division = dbo.vw_bedryf" + sDB + ".bedrnr order by dbo.vw_bedryf" + sDB + ".bedrnm")
    '    dr = objcommom.OpenDataReader
    '    division.Clear()
    '    While dr.Read
    '        division.Add(Trim(dr.Item("division")))
    '        ComboBox3.Items.Add(Trim(dr.Item("bedrnm")))
    '    End While
    '    dr.Close()
    '    objcommom.CloseDataReader()
    '    objcommom.Close()
    '    objcommom = Nothing
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Select a year", MsgBoxStyle.Information, TitleMsgBox)
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If
            If ComboBox2.SelectedIndex = -1 Then
                MsgBox("Select a month", MsgBoxStyle.Information, TitleMsgBox)
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            Dim objclass1 As New clsCommon
            objclass1 = New clsCommon
            objclass1.ConnectionString1()
            objclass1.Opentracker()
            objclass1.CreateCom()

            'asys 2.2
            'change for update 
            objclass1.commandTrack("update Asys_REM_detail set status = 'SORTED', sortername = '" & userLog & "', sortdate = getdate(), actionclass = 'MissingItem', sortcode = 'O' where Substring(ptn,1,3) = '" & Me.txtBranchCode.Text & "'  and month(receivedate) = '" & ComboBox2.SelectedIndex + 1 & "' and year(receivedate) = '" & Me.ComboBox1.Text & "' and status = 'received'")
            objclass1.TrackExecute()
            objclass1.commandTrack("update REMS.dbo.Asys_REM_detail set status = 'SORTED', sortername = '" & userLog & "', sortdate = getdate(), actionclass = 'MissingItem', sortcode = 'O' where Substring(ptn,1,3) = '" & Me.txtBranchCode.Text & "'  and month(receivedate) = '" & ComboBox2.SelectedIndex + 1 & "' and year(receivedate) = '" & Me.ComboBox1.Text & "' and status = 'received'")
            objclass1.TrackExecute()

            objclass1.CommitTrack()
            'MsgBox(CStr(ListView2.Items.Count) + " item(s) released.", MsgBoxStyle.Information)

            objclass1.Close()

            'If ComboBox3.SelectedIndex = -1 Then
            '    MsgBox("Select branch", MsgBoxStyle.Information, TitleMsgBox)
            '    Exit Sub
            'End If
            Me.Cursor = Cursors.WaitCursor
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
            If RadioButton1.Checked = True Then
                If UCase(sDB) = "LUZON" Then
                    oRPT.Load(sPath + "\ASYS_SortedListLuzon.rpt")
                    'ElseIf UCase(sDB) = "VISMIN" Then
                ElseIf UCase(sDB) = "VISAYAS" Then
                    oRPT.Load(sPath + "\ASYS_SortedListVismin.rpt")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    oRPT.Load(sPath + "\ASYS_SortedListVismin.rpt")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    oRPT.Load(sPath + "\ASYS_SortedListShowroom.rpt")
                End If
            Else
            oRPT.Load(sPath + "\ASYS_SortedListSummary.rpt")
            End If
            oRPT.SetParameterValue("prenda", UCase(Format(DateAdd("m", -7, CDate(ComboBox1.Text & "-1-" & ComboBox2.Text)), "yyyy MMMM"))) 'UCase(objclass.Prenda(ComboBox1, ComboBox2)))
            oRPT.SetParameterValue("habwa", ComboBox1.Text + " " + ComboBox2.Text)
            oRPT.SetParameterValue("@Pmonth", ComboBox2.SelectedIndex + 1)
            oRPT.SetParameterValue("@Pyear", ComboBox1.Text)
            'oRPT.SetParameterValue("branchname", ComboBox3.Text)
            oRPT.SetParameterValue("branchcode", txtBranchCode.Text)

            'repair line for v.21
            oRPT.SetParameterValue("branchname", txtBranchName.Text)
            oRPT.SetParameterValue("sorter", UCase(userLog))
            oRPT.SetParameterValue("@Pbranch", txtBranchCode.Text)
            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_REMSortedList_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_REMSortedList_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMSortedList_rpt;1"

            CrystalReportViewer1.ReportSource = oRPT
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MsgBox("frmSortedList/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "VISAYAS" Then
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
                    txtBranchName.Text = Trim(dr.Item("bedrnm"))
                    Me.Button1.Enabled = True
                Else
                    MsgBox("Branch code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Focus()
                End If
                dr.Close()
                objclass.Execute5()
                objclass.Close5()
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/txtBranchCode_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchName.KeyDown
        'Dim dr As SqlDataReader
        'Dim objclass As New clsCommon

        'If e.KeyCode = Keys.Enter Then
        '    If txtBranchName.Text.Trim.Length = 0 Then
        '        Msgbox("Enter a valid Branch Name.")
        '        txtBranchName.Focus()
        '        Exit Sub
        '    End If
        '    objclass = New clsCommon
        '    objclass.ConnDb()
        '    objclass.Open()
        '    If UCase(sDB) = "LUZON" Then
        '        objclass.Command5("Select bedrnr from " + bedryfluzon2 + " where bedrnm='" + txtBranchName.Text.Trim + "'")
        '    Else
        '        objclass.Command5("Select bedrnr from " + bedryfvismin2 + " where bedrnm='" + txtBranchName.Text.Trim + "'")
        '    End If

        '    dr = objclass.OpenDataReader5
        '    If dr.Read Then
        '        txtBranchCode.Text = dr.Item("bedrnr")
        '    Else
        '        Msgbox("Enter a valid Branch Name.")
        '        txtBranchName.Focus()
        '    End If
        '    dr.Close()
        '    objclass.Execute5()
        '    objclass.Close5()
        'End If
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            If txtBranchCode.Text.Length < 3 Then
                txtBranchName.Text = ""
                Button1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/txtBranchCode_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmSortedList/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function tuig()
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
End Class
