Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmMemo_rpt
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Private objcommom As clsCommon
    Public iMemo As Integer

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
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbSorterName As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMemo_rpt))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CmbSorterName = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "MONTH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(144, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "YEAR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox2.Location = New System.Drawing.Point(192, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox2.TabIndex = 78
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(192, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox1.TabIndex = 77
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(32, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 76
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(600, 328)
        Me.CrystalReportViewer1.TabIndex = 83
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CmbSorterName
        '
        Me.CmbSorterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSorterName.Location = New System.Drawing.Point(432, 16)
        Me.CmbSorterName.Name = "CmbSorterName"
        Me.CmbSorterName.Size = New System.Drawing.Size(184, 21)
        Me.CmbSorterName.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "SORTER NAME"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMemo_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 445)
        Me.Controls.Add(Me.CmbSorterName)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMemo_rpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INCIDENT REPORT"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmHRMemoAppliance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Dim dr As SqlDataReader
            Dim sQuery As String

            callYear()
            If iMemo = 1 Then
                Me.Text = "GM MEMO APPLIANCE REPORT"
            ElseIf iMemo = 2 Then
                Me.Text = "HR MEMO MISSING REPORT"
            ElseIf iMemo = 3 Then
                Me.Text = "HR MEMO FAKE REPORT"
            ElseIf iMemo = 4 Then
                Me.Text = "HR MEMO COATED REPORT"
            ElseIf iMemo = 5 Then
                Me.Text = "HR MEMO OVER APPRAISED REPORT"
            End If
            '
            CmbSorterName.Text = UCase(Trim(userLog))

            If UCase(job_title) = "SORTER" Then
                '    sQuery = "select distinct fullname,usr_id,blocked from " & humres2 & " where job_title like 'ALLBOS%' and blocked =1 "
                'Else
                sQuery = "select distinct fullname,usr_id,blocked from " & humres2 & " where (job_title like '%SORTER%' or job_title like '%ALLDEPT%') and blocked =1 "
            Else
                sQuery = "select distinct fullname,usr_id,blocked from " & humres2 & " where job_title like '%ALLDEPT%' and blocked =1 "
            End If

            '...................................................................
            objcommom = New clsCommon
            objcommom.ConnDb()
            objcommom.Open5()
            objcommom.Command5(sQuery)
            dr = objcommom.OpenDataReader5
            While dr.Read
                CmbSorterName.Items.Add(UCase(Trim(dr.Item("fullname"))))
            End While
            dr.Close()
            objcommom.Execute5()
            objcommom.Close5()
            objcommom = Nothing

            '...................................................................

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
        Catch ex As Exception
            MsgBox("frmMemo_rpt/Button27_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Select year.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If ComboBox2.SelectedIndex = -1 Then
                MsgBox("Select month.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If CmbSorterName.Text = "" Then
                MsgBox("Select Sorter.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            Button1.Enabled = False
            oRPT = New ReportDocument
            objcommom = New clsCommon
            Me.Cursor = Cursors.WaitCursor
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            objcommom.ConnectionString1()

            If iMemo = 2 Then
                oRPT.Load(sPath + "\ASYS_MemoMissingItem.rpt")
            ElseIf iMemo = 3 Then
                oRPT.Load(sPath + "\ASYS_MemoFakeItem.rpt")
            ElseIf iMemo = 4 Then
                oRPT.Load(sPath + "\ASYS_MemoCoatedItem.rpt")
            ElseIf iMemo = 5 Then
                oRPT.Load(sPath + "\ASYS_MemoOverAppItem.rpt")
            ElseIf iMemo = 6 Then
                oRPT.Load(sPath + "\InciRep.rpt")
            End If

            oRPT.SetParameterValue("@ZoneCode", sDB)
            oRPT.SetParameterValue("@pmonth", ComboBox2.SelectedIndex + 1)
            oRPT.SetParameterValue("@pyear", ComboBox1.SelectedItem)
            oRPT.SetParameterValue("@pname", UCase(Trim(CmbSorterName.Text)))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With

            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            If iMemo <> 6 Then
                crTables.Item("vw_hr_memo").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("vw_hr_memo").Location = objcommom.sDatabase1 + ".dbo.vw_hr_memo"
            End If
            If iMemo = 2 Then
                crTables.Item("ASYS_MemoMissingItem;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_MemoMissingItem;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MemoMissingItem;1"
            ElseIf iMemo = 3 Then
                crTables.Item("ASYS_MemoFakeItem;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_MemoFakeItem;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MemoFakeItem;1"
            ElseIf iMemo = 4 Then
                crTables.Item("ASYS_MemoCoatedItem;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_MemoCoatedItem;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MemoCoatedItem;1"
            ElseIf iMemo = 5 Then
                crTables.Item("ASYS_MemoOverAppItem;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_MemoOverAppItem;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MemoOverAppItem;1"
            ElseIf iMemo = 6 Then
                crTables.Item("vw_Memo_IR").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("vw_Memo_IR").Location = objcommom.sDatabase1 + ".dbo.vw_Memo_IR"
            End If
            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox("frmMemo_rpt/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMemo_rpt/ComboBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMemo_rpt/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CmbSorterName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSorterName.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmMemo_rpt/CmbSorterName_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmMemo_rpt_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub
End Class
