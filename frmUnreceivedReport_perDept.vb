Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmUnreceivedReport_perDept
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
    Friend WithEvents cr_unreceived As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents lblcostcenter As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents txtCostcenter As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUnreceivedReport_perDept))
        Me.cr_unreceived = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnPreview = New System.Windows.Forms.Button
        Me.lblcostcenter = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.txtCostcenter = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cr_unreceived
        '
        Me.cr_unreceived.ActiveViewIndex = -1
        Me.cr_unreceived.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cr_unreceived.DisplayGroupTree = False
        Me.cr_unreceived.Location = New System.Drawing.Point(0, 104)
        Me.cr_unreceived.Name = "cr_unreceived"
        Me.cr_unreceived.ReportSource = Nothing
        Me.cr_unreceived.Size = New System.Drawing.Size(648, 288)
        Me.cr_unreceived.TabIndex = 0
        '
        'btnPreview
        '
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.Location = New System.Drawing.Point(16, 16)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(88, 64)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblcostcenter
        '
        Me.lblcostcenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcostcenter.Location = New System.Drawing.Point(136, 28)
        Me.lblcostcenter.Name = "lblcostcenter"
        Me.lblcostcenter.Size = New System.Drawing.Size(120, 13)
        Me.lblcostcenter.TabIndex = 2
        Me.lblcostcenter.Text = "COST CENTER"
        '
        'lblusername
        '
        Me.lblusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(136, 53)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.TabIndex = 3
        Me.lblusername.Text = "USERNAME"
        '
        'txtCostcenter
        '
        Me.txtCostcenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCostcenter.Enabled = False
        Me.txtCostcenter.Location = New System.Drawing.Point(240, 24)
        Me.txtCostcenter.Name = "txtCostcenter"
        Me.txtCostcenter.Size = New System.Drawing.Size(216, 20)
        Me.txtCostcenter.TabIndex = 4
        Me.txtCostcenter.Text = ""
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Enabled = False
        Me.txtusername.Location = New System.Drawing.Point(240, 48)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(216, 20)
        Me.txtusername.TabIndex = 5
        Me.txtusername.Text = ""
        '
        'frmUnreceivedReport_perDept
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 390)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtCostcenter)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.lblcostcenter)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.cr_unreceived)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUnreceivedReport_perDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNRECEIVED ITEMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCostcenter.TextChanged

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim comp As String
        Dim temp, month, temp2, temp3, str, comb As String

        Try
            

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
         
            oRPT.Load(sPath + "\ASYS_GetDeptUnreceived_ITems.rpt")

            oRPT.SetParameterValue("username", Trim(UCase(txtusername.Text)))
            oRPT.SetParameterValue("@costcenter", txtCostcenter.Text)

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_GetDeptUnreceived_Items;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_GetDeptUnreceived_Items;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_GetDeptUnreceived_Items"

            cr_unreceived.ReportSource = oRPT
            btnPreview.Enabled = True
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmUnreceivedReport_perDept/btnpreview_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmUnreceivedReport_perDept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
