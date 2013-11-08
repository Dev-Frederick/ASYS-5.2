Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmPRICINGReceiving_rpt
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Dim month, temp3, temp2 As String
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents cbouser As System.Windows.Forms.ComboBox
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPRICINGReceiving_rpt))
        Me.btnprint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtlot = New System.Windows.Forms.TextBox
        Me.cbouser = New System.Windows.Forms.ComboBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnprint.Location = New System.Drawing.Point(24, 24)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(80, 64)
        Me.btnprint.TabIndex = 0
        Me.btnprint.Text = "PREVIEW"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOT NO."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USER NAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DATE RECEIVED"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(640, 376)
        Me.CrystalReportViewer1.TabIndex = 4
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(232, 16)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(168, 20)
        Me.txtdate.TabIndex = 5
        Me.txtdate.Text = ""
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(232, 64)
        Me.txtlot.MaxLength = 10
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(168, 20)
        Me.txtlot.TabIndex = 6
        Me.txtlot.Text = ""
        '
        'cbouser
        '
        Me.cbouser.Location = New System.Drawing.Point(232, 40)
        Me.cbouser.Name = "cbouser"
        Me.cbouser.Size = New System.Drawing.Size(168, 21)
        Me.cbouser.TabIndex = 7
        '
        'txtuser
        '
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Location = New System.Drawing.Point(232, 40)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(168, 20)
        Me.txtuser.TabIndex = 8
        Me.txtuser.Text = ""
        '
        'frmPRICINGReceiving_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 486)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.cbouser)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPRICINGReceiving_rpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRICING RECEIVING REPORT"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPRICINGReceiving_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            Me.txtuser.Text = UCase(userLog)
            Me.txtuser.ReadOnly = True
            'Me.btnprint.Enabled = False
            Call habwa_date()

            Dim squery1 As String
            Dim dr1 As SqlDataReader
            Dim obj1 As New clsCommon
            obj1.Connectionstring3()
            obj1.Open3()

            If SearchFlag = False Then
                squery1 = "select top 1 lotno, receivedate from ASYS_PRICING_detail where status in ('received','priced') and lotno = '" & Me.txtlot.Text & "'"
            Else
                squery1 = "select top 1 lotno, receivedate from ASYS_PRICING_detail where lotno = '" & Me.txtlot.Text & "'"
            End If

            SearchFlag = False
            obj1.Command3(squery1)
            dr1 = obj1.OpenDataReader3
            If dr1.Read = True Then
                Me.txtlot.Text = Trim(dr1.Item("lotno"))
                Me.txtdate.Text = Trim(dr1.Item("receivedate"))
                Me.btnprint.Focus()
            Else
                Me.txtlot.Focus()
            End If
            dr1.Close()
            obj1.Close3()
        Catch ex As Exception
            MsgBox("frmPricingReceiving_rpt/frmPRICINGReceiving_rpt_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub tbnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim cntr As String
        Dim comp As String
        Dim temp, month, temp2, temp3, str, comb, costcenter As String
        Try
            If Me.txtdate.Text = "" Then
                MsgBox("Enter Lot Number", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If txtlot.Text = "" Then
                MsgBox("Enter Lot Number!", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            Dim sdate As Date = Me.txtdate.Text
            Dim emp As String = Me.txtuser.Text
            btnprint.Enabled = False
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
            costcenter = "PRICING"
            oRPT.Load(sPath + "\ASYS_PRICINGSummaryGoodStocks_Rcv.rpt")
            cntr = "RECEIVING REPORT"

            'oRPT.SetParameterValue("@hmonth", sdate.Month)
            'oRPT.SetParameterValue("@hyear", sdate.Year)
            'oRPT.SetParameterValue("RLC", cntr)
            'oRPT.SetParameterValue("lotno", Me.txtlot.Text)
            oRPT.SetParameterValue("@hlot", Me.txtlot.Text)
            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Date.Now, "MMMM dd, yyyy")))
            oRPT.SetParameterValue("name", Trim(UCase(txtuser.Text)))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_PRICINGSummaryGoodStocks_Rcv_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_PRICINGSummaryGoodStocks_Rcv_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_PRICINGSummaryGoodStocks_Rcv_rpt"

            CrystalReportViewer1.ReportSource = oRPT
            btnprint.Enabled = True
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmPricingReceiving_rpt/tbnprint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving_rpt/habwa_date: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlot.TextChanged
        Try
            If txtlot.TextLength <> 10 Then
                btnprint.Enabled = False
            Else
                btnprint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmPricingReceiving_rpt/txtlot_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlot.KeyPress
        Dim objclass As New clsCommon
        Dim dr As SqlDataReader
        Dim str, comb, temp As String

        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If Len(Me.txtlot.Text) = 10 Then
                    objclass = New clsCommon
                    objclass.Connectionstring3()
                    objclass.Open3()
                    'str = "Select Month(receivedate) as [Month],Year(receivedate) as [Year],Day(receivedate) as [day] from asys_PRICING_Detail where lotno = '" & Me.txtlot.Text & "'"
                    str = "Select receivedate from asys_PRICING_Detail where lotno = '" & Me.txtlot.Text & "'"
                    objclass.Command3(str)
                    dr = objclass.OpenDataReader3()
                    If dr.Read Then
                        'month = MonthName(dr.Item("month"), False)
                        'temp2 = dr.Item("day")
                        'temp3 = dr.Item("year")
                        'comb = month + " " + temp2 + ", " + " " + temp3
                        'Me.txtdate.Text = comb
                        txtdate.Text = Trim(dr.Item("receivedate"))
                        Me.btnprint.Enabled = True
                        btnprint.Focus()
                    Else
                        txtdate.Text = ""
                        Me.btnprint.Enabled = False
                        txtlot.Focus()
                    End If
                    Me.txtdate.BringToFront()
                    Me.txtdate.Enabled = False
                    Me.txtdate.BackColor = Color.White

                ElseIf Len(Me.txtlot.Text) <> 10 Then
                    Me.btnprint.Enabled = False
                    Me.txtdate.Text = ""
                    txtlot.Text = ""
                    txtlot.Focus()
                End If
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("frmPricingReceiving_rpt/txtlot_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
