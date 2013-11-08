Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmDISTRIReceiving_rpt
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
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdate As System.Windows.Forms.TextBox
    Friend WithEvents txtemp As System.Windows.Forms.TextBox
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDISTRIReceiving_rpt))
        Me.btnprint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtdate = New System.Windows.Forms.TextBox
        Me.txtemp = New System.Windows.Forms.TextBox
        Me.txtlot = New System.Windows.Forms.TextBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnprint.Location = New System.Drawing.Point(24, 16)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(80, 64)
        Me.btnprint.TabIndex = 0
        Me.btnprint.Text = "PREVIEW"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATE RECEIVED"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EMPLOYEE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "LOT NUMBER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(232, 16)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(160, 20)
        Me.txtdate.TabIndex = 4
        Me.txtdate.Text = ""
        '
        'txtemp
        '
        Me.txtemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemp.Location = New System.Drawing.Point(232, 40)
        Me.txtemp.Name = "txtemp"
        Me.txtemp.Size = New System.Drawing.Size(160, 20)
        Me.txtemp.TabIndex = 5
        Me.txtemp.Text = ""
        '
        'txtlot
        '
        Me.txtlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.Location = New System.Drawing.Point(232, 66)
        Me.txtlot.MaxLength = 10
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(160, 20)
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 112)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(616, 344)
        Me.CrystalReportViewer1.TabIndex = 7
        '
        'frmDISTRIReceiving_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 454)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.txtemp)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDISTRIReceiving_rpt"
        Me.Text = "DISTRI RECEIVING OF GOODSTOCKS REPORT"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDISTRIReceiving_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.txtemp.ReadOnly = True
        Me.txtemp.BackColor = Color.White
        Me.txtdate.ReadOnly = True
        Me.txtdate.BackColor = Color.White
        Me.txtemp.Text = UCase(newreceiver)
        Try
            Dim squery1 As String
            Dim squery As String
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader
            Dim obj As New clsCommon
            Dim obj1 As New clsCommon
           
            obj.Connectionstring3()
            obj.Open3()
            If txtlot.Text <> "" Then
                SearchFlag = True
            Else
                SearchFlag = False
            End If

            If SearchFlag = False Then
                squery = "select top 1 lotno,receivedate from ASYS_Distri_detail where status = 'received' order by receivedate desc"
            Else
                squery = "select top 1 lotno,receivedate from ASYS_Distri_detail where lotno = '" & Me.txtlot.Text & "'"
            End If

            obj.Command3(squery)
            dr = obj.OpenDataReader3
            If dr.Read Then
                Me.txtlot.Text = Trim(dr.Item("lotno"))
                txtdate.Text = dr.Item("receivedate")
                btnprint.Focus()
            End If
            dr.Close()
            obj.Close3()

            If txtlot.Text = "" Then
                btnprint.Enabled = False
            Else
                btnprint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReceiving_rpt/frmDISTRIReceiving_rpt_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Dim cntr As String
        Dim comp As String
        Dim temp, month, temp2, temp3, str, comb, costcenter As String
        Try
            If Me.txtdate.Text = "" Then
                MsgBox("Enter Lot Number.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If txtlot.Text = "" Then
                MsgBox("Enter Lot Number!", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            Dim sdate As Date = Me.txtdate.Text
            Dim emp As String = Me.txtemp.Text
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

            objcommom.Connectionstring3()
            costcenter = "PRICING"
            oRPT.Load(sPath + "\ASYS_DISTRISummaryGoodStocks_Rcv.rpt")

            'oRPT.SetParameterValue("@month", sdate.Month)
            'oRPT.SetParameterValue("@year", sdate.Year)
            'oRPT.SetParameterValue("lotno", Me.txtlot.Text)
            oRPT.SetParameterValue("@hlot", Me.txtlot.Text)
            oRPT.SetParameterValue("name", Trim(UCase(txtemp.Text)))
            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_DISTRISummaryGoodStock_Rcv_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_DISTRISummaryGoodStock_Rcv_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_DISTRISummaryGoodstock_Rcv_rpt"

            CrystalReportViewer1.ReportSource = oRPT
            btnprint.Enabled = True
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmDISTRIReceiving_rpt/btnprint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlot.TextChanged
        Try
            If txtlot.Text = "" Then
                btnprint.Enabled = False
            Else
                btnprint.Enabled = True
            End If
            If txtlot.TextLength <> 10 Then
                btnprint.Enabled = False
            Else
                btnprint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReceiving_rpt/txtlot_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtlot_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlot.KeyPress 'paopao asys 3.0 upgrade

        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                Dim objclass As New clsCommon
                Dim dr As SqlDataReader
                Dim str, comb, temp As String
                If Len(Me.txtlot.Text) = 10 Then
                    objclass = New clsCommon
                    objclass.Connectionstring3()
                    objclass.Open3()
                    str = "Select month(receivedate)as month, day(receivedate) as day, year(receivedate) as year from asys_DISTRI_detail where lotno = '" & Me.txtlot.Text & "' order by receivedate desc"
                    objclass.Command3(str)
                    dr = objclass.OpenDataReader3()
                    If dr.Read Then
                        temp = dr.Item("month")
                        month = temp
                        temp2 = dr.Item("day")
                        temp3 = dr.Item("year")
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
                        comb = CStr(month + " " + temp2 + ", " + temp3)
                        Me.txtdate.Text = comb
                        btnprint.Focus()
                    End If
                    Me.txtdate.BringToFront()
                    Me.txtdate.Enabled = False
                    Me.txtdate.BackColor = Color.White
                    If Me.txtlot.Text = "" Then
                        Me.txtdate.Text = ""
                    End If
                ElseIf Len(Me.txtlot.Text) <> 10 Then
                    Me.txtdate.Text = ""
                    Me.btnprint.Enabled = False
                End If
                If Me.txtdate.Text = "" Then
                    Me.btnprint.Enabled = False
                Else
                    Me.btnprint.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("frmDISTRIReceiving_rpt/txtlot_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub
End Class
