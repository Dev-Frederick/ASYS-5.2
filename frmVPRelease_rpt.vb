Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmVPRelease_rpt
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBRanchname As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVPRelease_rpt))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtBRanchname = New System.Windows.Forms.TextBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Month:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Action Class:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(160, 40)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ComboBox3
        '
        Me.ComboBox3.Location = New System.Drawing.Point(392, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Branch Code:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchCode.Location = New System.Drawing.Point(392, 16)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(40, 20)
        Me.txtBranchCode.TabIndex = 38
        Me.txtBranchCode.Text = ""
        '
        'txtBRanchname
        '
        Me.txtBRanchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBRanchname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBRanchname.Location = New System.Drawing.Point(440, 16)
        Me.txtBRanchname.MaxLength = 3
        Me.txtBRanchname.Name = "txtBRanchname"
        Me.txtBRanchname.Size = New System.Drawing.Size(184, 20)
        Me.txtBRanchname.TabIndex = 39
        Me.txtBRanchname.Text = ""
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(624, 384)
        Me.CrystalReportViewer1.TabIndex = 40
        '
        'frmVPRelease_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 470)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.txtBRanchname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVPRelease_rpt"
        Me.Text = "Jewelry Releasing Report Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub Print_VPReleasing(ByVal actionclass As String)
        ComboBox3.Text = actionclass
    End Sub
    Private Sub frmVPRelease_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim yr, tmp As Integer
            yr = Now.Year
            For tmp = 1 To 5
                ComboBox2.Items.Add(yr)
                yr = yr - 1
            Next
            Me.ComboBox2.Text = System.DateTime.Now.Year

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select * from tbl_action where action_id in(6,11,10,9,5,13) order by action_type")
            dr = objclass.OpenDataReader3
            While dr.Read
                If Trim(UCase(dr.Item("action_type"))) = "MISSINGITEM" Then
                    ComboBox3.Items.Add("MISSING ITEM")
                Else
                    ComboBox3.Items.Add(Trim(UCase(dr.Item("action_type"))))
                End If

            End While
            dr.Close()
            objclass.Close3()
            Me.txtBRanchname.ReadOnly = True
            Me.txtBRanchname.BackColor = Color.White
            Me.ComboBox1.Text = CStr(MonthName(System.DateTime.Now.Month))
            If txtBRanchname.Text <> "" Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            Dim dr As SqlDataReader
            Dim objclass As New clsCommon
            If e.KeyChar = ChrW(13) Then
                If txtBranchCode.Text.Trim.Length = 0 Then
                    Msgbox("Enter a valid Branch Code.", MsgBoxStyle.Information, TitleMsgBox)
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
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select bedrnm from REMS.dbo.vw_bedryf" & sDB & " where bedrnr='" + txtBranchCode.Text.Trim + "'")
                End If

                dr = objclass.OpenDataReader5
                If dr.Read = True Then
                    txtBRanchname.Text = Trim(dr.Item("bedrnm"))
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
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False
            oRPT = New ReportDocument
            objcommom = New clsCommon

            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frm As New Form1
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If ComboBox3.Text.ToUpper = "TRADE-IN" Then
                oRPT.Load(sPath + "\ASYS_TradeINReleasing.rpt")

                oRPT.SetParameterValue("@PMonth", ComboBox1.SelectedIndex + 1)
                oRPT.SetParameterValue("@PYear", ComboBox2.Text)
                oRPT.SetParameterValue("@PBranchcode", txtBranchCode.Text)
            Else
                If ComboBox3.Text = "MISSING ITEM" Then
                    ComboBox3.Text = "MISSINGITEM"
                End If
                oRPT.Load(sPath + "\ASYS_REMReleasing_Jewelry.rpt")
                oRPT.SetParameterValue("@pactionclass", ComboBox3.Text)
                oRPT.SetParameterValue("@Pmonth", ComboBox1.SelectedIndex + 1)
                oRPT.SetParameterValue("@Pyear", ComboBox2.Text)
                oRPT.SetParameterValue("@Pbranchcode", txtBranchCode.Text)
                oRPT.SetParameterValue("user", UCase(Trim(userLog)))
            End If

            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

            objcommom.ConnectionString1()
            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            If ComboBox3.Text.ToUpper = "TRADE-IN" Then
                crTables.Item("ASYS_TradeInReleasing;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_TradeInReleasing;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_TradeInReleasing;1"

            Else
                crTables.Item("ASYS_REMRELEASING_JEWELRY;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMRELEASING_JEWELRY;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMRELEASING_JEWELRY;1"

            End If
            'oRpt.Refresh()
            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            If txtBranchCode.Text.Length < 3 Then
                txtBRanchname.Text = ""
                Button1.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmVPRelease_rpt_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Dispose()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        If e.KeyChar <> ChrW(13) Then
            e.Handled = True
        End If
    End Sub
End Class
