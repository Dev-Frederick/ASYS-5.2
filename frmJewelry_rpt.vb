Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmJewelry_rpt
    Inherits System.Windows.Forms.Form
    Public WithEvents oRPT As ReportDocument
    Public objcommom As clsCommon
    Public iJewelry As Integer

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJewelry_rpt))
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.Items.AddRange(New Object() {"yes", "no"})
        Me.ComboBox3.Location = New System.Drawing.Point(256, 40)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(56, 23)
        Me.ComboBox3.TabIndex = 47
        Me.ComboBox3.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(120, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "DESCENDING ORDER:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "HABWA MONTH:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = " --"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox2.Location = New System.Drawing.Point(344, 16)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(88, 23)
        Me.ComboBox2.TabIndex = 43
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(256, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(56, 23)
        Me.ComboBox1.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 56)
        Me.Button1.TabIndex = 41
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 88)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(592, 352)
        Me.CrystalReportViewer1.TabIndex = 48
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmJewelry_rpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(608, 445)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmJewelry_rpt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REM JEWELRY REPORT - QTY/PCS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = -1 Then
                MsgBox("Select year", MsgBoxStyle.Information)
                Exit Sub
            End If
            If ComboBox2.SelectedIndex = -1 Then
                MsgBox("Select month", MsgBoxStyle.Information)
                Exit Sub
            End If
            Button1.Enabled = False
            oRPT = New ReportDocument
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim mnth As Integer
            Dim yr As Integer
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            objcommom = New clsCommon
            objcommom.ConnectionString1()

            If iJewelry = 1 Then
                oRPT.Load(sPath + "\ASYS_JewelryQtyPcs.rpt")
            ElseIf iJewelry = 2 Then
                oRPT.Load(sPath + "\ASYS_REMJewelryTWT.rpt")
            ElseIf iJewelry = 3 Then
                oRPT.Load(sPath + "\ASYS_JewelryAveWT.rpt")
            ElseIf iJewelry = 4 Then
                oRPT.Load(sPath + "\ASYS_REMJewelryLoanAmnt.rpt")
            ElseIf iJewelry = 5 Then
                oRPT.Load(sPath + "\ASYS_JewelryTotalREM.rpt")
            ElseIf iJewelry = 6 Then
                oRPT.Load(sPath + "\ASYS_JewelryTotalPrenda.rpt")
            ElseIf iJewelry = 7 Then
                oRPT.Load(sPath + "\ASYS_REMJewelrySummaryV3.1.rpt")
            End If

            oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))

            If iJewelry = 1 Or iJewelry = 2 Or iJewelry = 3 Or iJewelry = 4 Or iJewelry = 5 Then
                oRPT.SetParameterValue("@Pmonth", ComboBox2.SelectedIndex + 1)
                oRPT.SetParameterValue("@pyear", CInt(ComboBox1.Text))
                oRPT.SetParameterValue("prenda", objclass.Prenda(ComboBox1, ComboBox2))


            ElseIf iJewelry = 6 Then
                'oRPT.SetParameterValue("prenda", objclass.Prenda(ComboBox1, ComboBox2))
                mnth = ComboBox2.SelectedIndex + 1
                yr = ComboBox1.Text
                oRPT.SetParameterValue("@pmonth", mnth)
                oRPT.SetParameterValue("@pyear", yr)

            End If

            If iJewelry = 7 Then
                oRPT.SetParameterValue("@prenda_month", ComboBox2.SelectedIndex + 1)
                oRPT.SetParameterValue("@prenda_year", ComboBox1.Text)
                oRPT.SetParameterValue("prenda", objclass.Prenda(ComboBox1, ComboBox2))
                Dim z As String
                z = CStr(ComboBox1.Text & " " & MonthName(CInt(ComboBox2.SelectedIndex + 1)))
                'oRPT.SetParameterValue("habwa", objclass.habwamonth(ComboBox2.SelectedIndex + 1) & " " & CInt(ComboBox1.Text))
                'oRPT.SetParameterValue("habwa", objclass.habwamonth(ComboBox1.Text) & " " & CInt(ComboBox2.SelectedIndex + 1))
                oRPT.SetParameterValue("habwa", z)
            End If

            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRPT.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            If iJewelry = 1 Then
                crTables.Item("ASYS_JewelryQtyPcs;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_JewelryQtyPcs;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_JewelryQtyPcs;1"
            ElseIf iJewelry = 2 Then
                crTables.Item("ASYS_REMJewelryWT;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMJewelryWT;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelryWT;1"
            ElseIf iJewelry = 3 Then
                crTables.Item("ASYS_JewelryAveWT;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_JewelryAveWT;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_JewelryAveWT;1"
            ElseIf iJewelry = 4 Or iJewelry = 5 Then
                crTables.Item("ASYS_JewelryLoanAmount;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_JewelryLoanAmount;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_JewelryLoanAmount;1"
            ElseIf iJewelry = 6 Then
                crTables.Item("ASYS_JewelryTotalPrenda;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_JewelryTotalPrenda;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_JewelryTotalPrenda;1"
            ElseIf iJewelry = 7 Then
                crTables.Item("ASYS_REMJewelrySummaryV31;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("ASYS_REMJewelrySummaryV31;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelrySummaryV31;1"
            End If
            CrystalReportViewer1.ReportSource = oRPT
            Button1.Enabled = True
        Catch ex As Exception
            MsgBox("frmJewelry_rpt/Button1_Click " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub frmJewelryQty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If iJewelry = 1 Then
                Me.Text = "REM JEWELRY REPORT - QTY/PCS"
            ElseIf iJewelry = 2 Then
                Me.Text = "REM JEWELRY REPORTt - TWT"
            ElseIf iJewelry = 3 Then
                Me.Text = "REM JEWELRY REPORT - AVE. WT."
            ElseIf iJewelry = 4 Then
                Me.Text = "REM JEWELRY REPORT - LOAN"
            ElseIf iJewelry = 5 Then
                Me.Text = "REM JEWELRY REPORT - % TO TOTAL REM"
            ElseIf iJewelry = 6 Then
                Me.Text = "REM JEWELRY REPORT - % TO TOTAL PRENDA"
            ElseIf iJewelry = 7 Then
                Me.Text = "REM JEWELRY REPORT - SUMMARY"
                Label2.Text = "PRENDA MONTH"
            End If

            Dim dr As SqlDataReader
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

            Dim ye, ar As Integer
            ye = Now.Year
            For ar = 1 To 5
                ComboBox1.Items.Add(ye)
                ye = ye - 1
            Next
            ComboBox1.Text = Now.Year
        Catch ex As Exception
            MsgBox("frmJewelry_rpt/frmJewelryQty_Load " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmJewelry_rpt/ComboBox1_KeyPress " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmJewelry_rpt/ComboBox2_KeyPress " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub ComboBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar <> ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmJewelry_rpt/ComboBox3_KeyPress " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class
