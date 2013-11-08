Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmPRICINGInventory
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
    Friend WithEvents cborec As System.Windows.Forms.ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPRICINGInventory))
        Me.btnprint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cborec = New System.Windows.Forms.ComboBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnprint
        '
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Image = CType(resources.GetObject("btnprint.Image"), System.Drawing.Image)
        Me.btnprint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnprint.Location = New System.Drawing.Point(16, 16)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(72, 64)
        Me.btnprint.TabIndex = 0
        Me.btnprint.Text = "Preview"
        Me.btnprint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Custodian"
        '
        'cborec
        '
        Me.cborec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborec.Location = New System.Drawing.Point(192, 56)
        Me.cborec.Name = "cborec"
        Me.cborec.Size = New System.Drawing.Size(176, 21)
        Me.cborec.TabIndex = 2
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(592, 288)
        Me.CrystalReportViewer1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "User Name"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(192, 32)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(176, 20)
        Me.txtuser.TabIndex = 5
        Me.txtuser.Text = ""
        '
        'frmPRICINGInventory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 406)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.cborec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnprint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPRICINGInventory"
        Me.Text = "PRICING INVENTORY"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmPRICINGInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim objclass As New clsCommon
        Dim dr As SqlDataReader
        Dim str As String
        Try
            Me.WindowState = FormWindowState.Maximized

            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()

            str = "select distinct rtrim(fullname) as fullname from vw_humresall where job_title like 'pricing%'"
            objclass.Command3(str)
            dr = objclass.OpenDataReader3
            While dr.Read
                Me.cborec.Items.Add(UCase(dr.Item("fullname")))
            End While
            objclass.Close3()
            Me.btnprint.Enabled = False
            Me.txtuser.Text = userLog
            Me.txtuser.Enabled = False
            Me.txtuser.BackColor = Color.White
        Catch ex As Exception
            MsgBox("frmPricingInventory/frmPRICINGInventory_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        Try
            Dim ahm As String
            Dim comp As String
            Dim temp, month, temp2, temp3, str, comb, emp As String

            If Me.cborec.Text = "" Then
                MsgBox("Enter Receiver.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

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

            emp = userLog

            objcommom.Connectionstring3()
            oRPT.Load(sPath + "\ASYS_PRICINGInventory.rpt")
            oRPT.SetParameterValue("@receiver", Me.cborec.Text)
            oRPT.SetParameterValue("emp", Trim(userLog))

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_PRICINGInventory;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_PRICINGInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_PRICINGInventory"

            CrystalReportViewer1.ReportSource = oRPT
            btnprint.Enabled = True
            objclass = Nothing
            Me.CrystalReportViewer1.Focus()
        Catch ex As Exception
            MsgBox("frmPricingInventory/Print_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cborec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cborec.SelectedIndexChanged
        Try
            Dim kani As Boolean
            If kani = False Then
                btnprint.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmPricingInventory/Print_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
