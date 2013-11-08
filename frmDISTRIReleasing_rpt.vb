Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmDISTRIReleasing_rpt
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Dim temp3, temp2 As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDISTRIReleasing_rpt))
        Me.btnpreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.txtlot = New System.Windows.Forms.TextBox
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
        Me.btnpreview.Size = New System.Drawing.Size(80, 62)
        Me.btnpreview.TabIndex = 0
        Me.btnpreview.Text = "PREVIEW"
        Me.btnpreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "USER NAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LOT NUMBER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DATE RELEASE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(232, 16)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(136, 20)
        Me.txtdate.TabIndex = 4
        Me.txtdate.Text = ""
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(232, 40)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(136, 20)
        Me.txtuser.TabIndex = 5
        Me.txtuser.Text = ""
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(232, 64)
        Me.txtlot.MaxLength = 10
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(136, 20)
        Me.txtlot.TabIndex = 6
        Me.txtlot.Text = ""
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(648, 328)
        Me.CrystalReportViewer1.TabIndex = 7
        '
        'frmDISTRIReleasing_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 446)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDISTRIReleasing_rpt"
        Me.Text = "DISTRI RELEASING REPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDISTRIReleasing_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            Me.txtuser.ReadOnly = True
            txtuser.BackColor = Color.White
            Me.txtuser.Text = UCase(fullname)
            Me.txtdate.ReadOnly = True
            txtdate.BackColor = Color.White
            Me.btnpreview.Enabled = True

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            'squery = "select top 1 reflotno as lotno, releasedate from ASYS_DISTRI_detail where status = 'released' and reflotno = '" & distrilot & "' order by releasedate desc"
            squery = "select releasedate from ASYS_DISTRI_detail where status = 'released' and reflotno = '" & txtlot.Text & "'"
            obj.Command3(squery)
            dr = obj.OpenDataReader3
            If dr.Read Then
                'Me.txtlot.Text = Trim(dr.Item("lotno"))
                txtdate.Text = dr.Item("releasedate")
                btnpreview.Focus()
            End If
            dr.Close()
            obj.Close3()

        Catch ex As Exception
            MsgBox("frmDISTRIReleasing_rpt/frmDISTRIReleasing_rpt_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Dim comp As String
        Dim temp, month, temp2, temp3, str, comb As String
        Try
            If Me.txtdate.Text = "" Then
                MsgBox("Enter Date.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If txtlot.Text = "" Then
                MsgBox("Enter Lot Number!", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            Dim sdate As Date = Me.txtdate.Text
            btnpreview.Enabled = False
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
            oRPT.Load(sPath + "\ASYS_DISTRISummaryGoodStocks_Rel.rpt")

            'oRPT.SetParameterValue("@hmonth", sdate.Month)
            'oRPT.SetParameterValue("@hyear", sdate.Year)
            'oRPT.SetParameterValue("reflotno", Me.txtlot.Text)
            oRPT.SetParameterValue("@hlot", Me.txtlot.Text)
            oRPT.SetParameterValue("name", Trim(UCase(txtuser.Text)))
            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_DISTRISummaryGoodStocks_Rel_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_DISTRISummaryGoodStocks_Rel_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_DISTRISummaryGoodStocks_Rel_rpt"

            CrystalReportViewer1.ReportSource = oRPT
            btnpreview.Enabled = True
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing_rpt/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlot.TextChanged
        Try
            If txtlot.TextLength <> 10 Then
                btnpreview.Enabled = False
            Else
                btnpreview.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReleasing_rpt/txtlot_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlot.KeyPress

        If e.KeyChar = ChrW(13) Then
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader

            Dim month, str, comb, temp, refl As String
            Try
                If Len(Me.txtlot.Text) = 10 Then
                    objclass = New clsCommon
                    objclass.Connectionstring3()
                    objclass.Open3()
                    str = "Select month(releasedate)as month, day(releasedate) as day, year(releasedate) as year from asys_DISTRI_header inner join asys_distri_detail on asys_distri_header.lotno = asys_distri_detail.lotno where asys_distri_detail.reflotno = '" & Me.txtlot.Text & "'"
                    objclass.Command3(str)
                    dr = objclass.OpenDataReader3()
                    If dr.Read Then
                        temp = objclass.IsNull(dr.Item("month"))
                        month = temp
                        temp2 = objclass.IsNull(dr.Item("day"))
                        temp3 = objclass.IsNull(dr.Item("year"))

                        Select Case month
                            Case "1"
                                month = "January"
                            Case "2"
                                month = "February"
                            Case "3"
                                month = "March"
                            Case "4"
                                month = "April"
                            Case "5"
                                month = "May"
                            Case "6"
                                month = "June"
                            Case "7"
                                month = "July"
                            Case "8"
                                month = "August"
                            Case "9"
                                month = "September"
                            Case "10"
                                month = "October"
                            Case "11"
                                month = "November"
                            Case "12"
                                month = "December"
                        End Select
                        comb = CStr(month + " " + temp2 + "," + " " + temp3)
                        Me.txtdate.Text = comb
                        If temp = "0" Or temp2 = "0" Or temp3 = "0" Then
                            Me.txtdate.Text = ""
                        End If
                        Me.btnpreview.Enabled = True
                        btnpreview.Focus()
                    End If
                ElseIf Len(Me.txtlot.Text) <> 10 Then
                    Me.txtdate.Text = ""
                    Me.btnpreview.Enabled = False
                End If
                If Me.txtdate.Text = "" Then
                    Me.btnpreview.Enabled = False
                Else
                    Me.btnpreview.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("frmDISTRIReleasing_rpt/txtlot_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            End Try
        End If
        If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        Else
            Exit Sub
        End If
    End Sub
End Class
