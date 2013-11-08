Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmSelfInventoryReport
    Inherits System.Windows.Forms.Form
    Public WithEvents oRpt As ReportDocument
    Public COSTCENTER As String
    Public REMTYPE As String
    Dim objcommom As New clsCommon

    Dim crtableLogoninfo As New TableLogOnInfo
    Dim crConnectionInfo As New ConnectionInfo
    Dim crTables As Tables
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
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelfInventoryReport))
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rptViewer.DisplayGroupTree = False
        Me.rptViewer.Location = New System.Drawing.Point(0, 0)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.Size = New System.Drawing.Size(768, 496)
        Me.rptViewer.TabIndex = 5
        '
        'frmSelfInventoryReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 494)
        Me.Controls.Add(Me.rptViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSelfInventoryReport"
        Me.Text = "SELF INVENTORY"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmSelfInventoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        oRpt = New ReportDocument
        objcommom = New clsCommon
       
        Dim objclass As New clsReport
        Dim frmMain1 As New frmMain
        Dim sPath As String = frmMain1.sPath

        objcommom.Connectionstring3()

        If REMTYPE = "SELFINVENTORY" Then
            oRpt.Load(sPath + "\rptSelfInventory.rpt")
            oRpt.SetParameterValue("@costcenter", COSTCENTER)
            SetUpReport()

            'crTables.Item("ASYS_SelfInvetory;1").ApplyLogOnInfo(crtableLogoninfo)
            'crTables.Item("ASYS_SelfInvetory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_SelfInvetory;1"

            crTables.Item("ASYS_SelfInventory_rpt;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_SelfInventory_rpt;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_SelfInventory_rpt;1"
         
        Else
            'If COSTCENTER = "REM" And REMTYPE = "TRADE-IN" Then
            '    oRpt.Load(sPath + "\ASYS_TradeIN_InventoryMissing.rpt")
            '    oRpt.SetParameterValue("@COSTCENTER", COSTCENTER)
            '    SetUpReport()
            '    crTables.Item("procASYS_TRADEIN_MissingItems;1").ApplyLogOnInfo(crtableLogoninfo)
            '    crTables.Item("procASYS_TRADEIN_MissingItems;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_TRADEIN_MissingItems;1"
            'Else
            oRpt.Load(sPath + "\rptSelfInventoryMissing.rpt")
            oRpt.SetParameterValue("@COSTCENTER", COSTCENTER)
            SetUpReport()
            crTables.Item("procASYS_MissingItems;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("procASYS_MissingItems;1").Location = objcommom.sDatabase1 + ".dbo.procASYS_MissingItems;1"
            'End If

        End If

        rptViewer.ReportSource = oRpt
    End Sub

    Private Sub SetUpReport()
        Try
            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With

            crTables = oRpt.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
        Catch ex As Exception

        End Try
    End Sub

End Class
