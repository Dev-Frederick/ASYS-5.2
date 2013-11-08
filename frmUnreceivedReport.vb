Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmUnreceivedReport
    Inherits System.Windows.Forms.Form
    Public WithEvents oRpt As ReportDocument
    Dim REMRETURN As Boolean
    Dim ParamMonth As Integer
    Dim ParamYear As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbranchname As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchcode As System.Windows.Forms.TextBox
    Friend WithEvents lblbranchname As System.Windows.Forms.Label
    Friend WithEvents lblbranchcode As System.Windows.Forms.Label
    Friend WithEvents rdALL As System.Windows.Forms.RadioButton
    Friend WithEvents rdByBranch As System.Windows.Forms.RadioButton
    Friend WithEvents crUnreceivedItems As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUnreceivedReport))
        Me.txtbranchname = New System.Windows.Forms.TextBox
        Me.txtbranchcode = New System.Windows.Forms.TextBox
        Me.lblbranchname = New System.Windows.Forms.Label
        Me.lblbranchcode = New System.Windows.Forms.Label
        Me.btnPreview = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdALL = New System.Windows.Forms.RadioButton
        Me.rdByBranch = New System.Windows.Forms.RadioButton
        Me.crUnreceivedItems = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbranchname
        '
        Me.txtbranchname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtbranchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbranchname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchname.Location = New System.Drawing.Point(208, 48)
        Me.txtbranchname.MaxLength = 50
        Me.txtbranchname.Name = "txtbranchname"
        Me.txtbranchname.Size = New System.Drawing.Size(200, 20)
        Me.txtbranchname.TabIndex = 63
        Me.txtbranchname.Text = ""
        '
        'txtbranchcode
        '
        Me.txtbranchcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbranchcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbranchcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchcode.Location = New System.Drawing.Point(208, 24)
        Me.txtbranchcode.MaxLength = 3
        Me.txtbranchcode.Name = "txtbranchcode"
        Me.txtbranchcode.Size = New System.Drawing.Size(144, 20)
        Me.txtbranchcode.TabIndex = 62
        Me.txtbranchcode.Text = ""
        '
        'lblbranchname
        '
        Me.lblbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchname.Location = New System.Drawing.Point(104, 48)
        Me.lblbranchname.Name = "lblbranchname"
        Me.lblbranchname.Size = New System.Drawing.Size(96, 16)
        Me.lblbranchname.TabIndex = 61
        Me.lblbranchname.Text = "BRANCH NAME"
        Me.lblbranchname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbranchcode
        '
        Me.lblbranchcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranchcode.Location = New System.Drawing.Point(104, 24)
        Me.lblbranchcode.Name = "lblbranchcode"
        Me.lblbranchcode.Size = New System.Drawing.Size(96, 16)
        Me.lblbranchcode.TabIndex = 60
        Me.lblbranchcode.Text = "BRANCH CODE"
        Me.lblbranchcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPreview
        '
        Me.btnPreview.Enabled = False
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.Image = CType(resources.GetObject("btnPreview.Image"), System.Drawing.Image)
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPreview.Location = New System.Drawing.Point(8, 16)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(72, 56)
        Me.btnPreview.TabIndex = 59
        Me.btnPreview.Text = "PREVIEW"
        Me.btnPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdALL)
        Me.GroupBox1.Controls.Add(Me.rdByBranch)
        Me.GroupBox1.Location = New System.Drawing.Point(432, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 72)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        '
        'rdALL
        '
        Me.rdALL.Location = New System.Drawing.Point(8, 16)
        Me.rdALL.Name = "rdALL"
        Me.rdALL.Size = New System.Drawing.Size(72, 24)
        Me.rdALL.TabIndex = 0
        Me.rdALL.Text = "ALL"
        '
        'rdByBranch
        '
        Me.rdByBranch.Checked = True
        Me.rdByBranch.Location = New System.Drawing.Point(8, 40)
        Me.rdByBranch.Name = "rdByBranch"
        Me.rdByBranch.Size = New System.Drawing.Size(96, 24)
        Me.rdByBranch.TabIndex = 65
        Me.rdByBranch.TabStop = True
        Me.rdByBranch.Text = "BY BRANCH"
        '
        'crUnreceivedItems
        '
        Me.crUnreceivedItems.ActiveViewIndex = -1
        Me.crUnreceivedItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crUnreceivedItems.DisplayGroupTree = False
        Me.crUnreceivedItems.Location = New System.Drawing.Point(0, 96)
        Me.crUnreceivedItems.Name = "crUnreceivedItems"
        Me.crUnreceivedItems.Size = New System.Drawing.Size(592, 352)
        Me.crUnreceivedItems.TabIndex = 65
        '
        'frmUnreceivedReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 445)
        Me.Controls.Add(Me.crUnreceivedItems)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbranchname)
        Me.Controls.Add(Me.txtbranchcode)
        Me.Controls.Add(Me.lblbranchname)
        Me.Controls.Add(Me.lblbranchcode)
        Me.Controls.Add(Me.btnPreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUnreceivedReport"
        Me.Text = "UNRECEIVED ITEMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmUnreceivedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Function GetDepartment(ByVal depart As String, ByVal Smonth As Integer, ByVal Syear As String) As Boolean
        ParamMonth = Smonth
        ParamYear = Syear
        If depart = "REMATADO" Then
            REMRETURN = False
            Return False
        Else
            REMRETURN = True
            Return True
        End If
       
    End Function
    Private Sub rdALL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdALL.Click
        txtbranchcode.Enabled = False
        txtbranchname.Enabled = False
        lblbranchname.Enabled = False
        lblbranchcode.Enabled = False
        txtbranchcode.Text = ""
        txtbranchname.Text = ""
        btnPreview.Enabled = True
        btnPreview.Focus()
    End Sub

    Private Sub rdByBranch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdByBranch.CheckedChanged

    End Sub

    Private Sub rdByBranch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdByBranch.Click
        txtbranchcode.Enabled = True
        txtbranchname.Enabled = True
        lblbranchname.Enabled = True
        lblbranchcode.Enabled = True
        btnPreview.Enabled = False
        txtbranchcode.Focus()
    End Sub


    Private Sub txtbranchcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbranchcode.KeyPress
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then

                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()


                objclass.Command5("Select * from " & "REMS.dbo." & bedryf2 & sDB & " where bedrnr='" + txtbranchcode.Text.Trim + "'")


                dr = objclass.OpenDataReader5
                If dr.Read Then
                    div1 = txtbranchcode.Text
                    txtbranchname.Text = Trim(dr.Item("bedrnm"))
                    btnPreview.Enabled = True
                Else
                    MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtbranchcode.Focus()
                End If
                dr.Close()
                'objclass.CloseDataReader()
                objclass.Close5()
                objclass = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmConsignRpt/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim comp As String
        Dim objcommom As clsCommon
        Dim temp, month, temp2, temp3, str, comb As String

        Try

            btnPreview.Enabled = False
            oRpt = New ReportDocument
            objcommom = New clsCommon

            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frmMain1 As New frmMain
            sPath = frmMain1.sPath

            If REMRETURN = True Then
                objcommom.Connectionstring3()

                If rdALL.Checked = True Then
                    oRpt.Load(sPath + "\ASYS_UnreceivedItems.rpt")
                    oRpt.SetParameterValue("username", UCase(fullname))

                Else
                    oRpt.Load(sPath + "\ASYS_UnreceivedItemsbyBranch.rpt")
                    oRpt.SetParameterValue("@branchcode", txtbranchcode.Text.Trim)
                    oRpt.SetParameterValue("branchname", txtbranchname.Text.Trim)
                    oRpt.SetParameterValue("employee", fullname)
                End If
            Else

                objcommom.ConnectionString1()
                oRpt.Load(sPath + "\ASYS_REMUnreceive_itemsALLnew.rpt")
                ''oRpt.Load(sPath + "\ASYS_REMUnreceive_itemsALLNEW2.rpt")
                'oRpt.Load(sPath + "\ASYS_REMUnreceive_itemsALL.rpt") 
                oRpt.SetParameterValue("@username", UCase(userLog))
                oRpt.SetParameterValue("@sdb", sDB)
                Dim all As String = "ALL"
                If rdALL.Checked = True Then
                    oRpt.SetParameterValue("@type", all)
                    oRpt.SetParameterValue("@branchcode", "NONE")
                    'ibalik ra ne''oRpt.SetParameterValue("@PrintDate", UCase(Format(sdate, "MMMM dd,yyyy"))) '''gm 011713
                Else
                    oRpt.SetParameterValue("@type", UCase("BRANCH"))
                    'oRpt.SetParameterValue("@bcode", txtbranchcode.Text.Trim)
                    oRpt.SetParameterValue("@branchcode", txtbranchcode.Text.Trim)
                    'ibalik ra ne''oRpt.SetParameterValue("@PrintDate", UCase(Format(sdate, "MMMM dd,yyyy"))) '''gm 011713
                End If
            End If
            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRpt.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo


            If REMRETURN = True Then
                If rdALL.Checked = True Then
                    crTables.Item("ASYS_GetUnreceiveItems;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_GetUnreceiveItems;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_GetUnreceiveItems;1"

                Else
                    crTables.Item("ASYS_GetUnreceiveItemsbyBranch;1").ApplyLogOnInfo(crtableLogoninfo)
                    crTables.Item("ASYS_GetUnreceiveItemsbyBranch;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_GetUnreceiveItemsbyBranch;1"

                End If
            Else

                crTables.Item("Unrecievedview_All;1").ApplyLogOnInfo(crtableLogoninfo)
                crTables.Item("Unrecievedview_All;1").Location = "REMS.dbo.Unrecievedview_All;1"



            End If

            crUnreceivedItems.ReportSource = oRpt
            btnPreview.Enabled = True
            objcommom = Nothing
        Catch ex As Exception

            MsgBox("frmPricingReleasing_rpt/btnprint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub



    Private Sub txtbranchname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbranchname.KeyPress
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            If e.KeyChar = ChrW(13) Then
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                objclass.Command5("Select * from " & bedryf2 & " where bedrnm like '%" + txtbranchname.Text.Trim + "%'")


                dr = objclass.OpenDataReader5
                If dr.Read Then
                    div1 = txtbranchcode.Text
                    txtbranchcode.Text = Trim(dr.Item("bedrnr"))
                    txtbranchname.Text = Trim(dr.Item("bedrnm"))
                    btnPreview.Enabled = True
                Else
                    MsgBox("Branch name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtbranchcode.Focus()
                End If
                dr.Close()

                objclass.Close5()
                objclass = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
