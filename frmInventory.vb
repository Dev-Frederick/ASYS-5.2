Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class frmInventory
    Inherits System.Windows.Forms.Form
    Public objcommom As clsCommon
    Public WithEvents oRPT As ReportDocument
    Dim tmpCombo6 As String
    Dim tmpCostNameDistri As String


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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cb As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents lblREMInv As System.Windows.Forms.Label
    Friend WithEvents rdConsigned As System.Windows.Forms.RadioButton
    Friend WithEvents rdUncogsigned As System.Windows.Forms.RadioButton
    Friend WithEvents cboConsignee As System.Windows.Forms.ComboBox
    Friend WithEvents grpStocks As System.Windows.Forms.GroupBox
    Friend WithEvents lblConsignee As System.Windows.Forms.Label
    Friend WithEvents rdALL As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInventory))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.cb = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.lblREMInv = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.grpStocks = New System.Windows.Forms.GroupBox
        Me.rdALL = New System.Windows.Forms.RadioButton
        Me.cboConsignee = New System.Windows.Forms.ComboBox
        Me.lblConsignee = New System.Windows.Forms.Label
        Me.rdUncogsigned = New System.Windows.Forms.RadioButton
        Me.rdConsigned = New System.Windows.Forms.RadioButton
        Me.GroupBox3.SuspendLayout()
        Me.grpStocks.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "USERNAME"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "INVENTORY TYPE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "COST CENTER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(416, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "SUPPLIER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(416, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 24)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "ITEM GROUP"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Items.AddRange(New Object() {"DEPARTMENT", "SUPPLIER", "ITEM"})
        Me.ComboBox2.Location = New System.Drawing.Point(240, 64)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'cb
        '
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cb.Enabled = False
        Me.cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb.Location = New System.Drawing.Point(240, 40)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(168, 21)
        Me.cb.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 64)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(672, 88)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 20)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button7, "Click here to clear text.")
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(672, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 20)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "..."
        Me.ToolTip1.SetToolTip(Me.Button3, "Click here to search item source.")
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.Items.AddRange(New Object() {"<NONE>", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "300", "400"})
        Me.ComboBox5.Location = New System.Drawing.Point(528, 88)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox5.TabIndex = 4
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.ItemHeight = 13
        Me.ComboBox3.Location = New System.Drawing.Point(128, 72)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.ItemHeight = 13
        Me.ComboBox4.Items.AddRange(New Object() {"<NONE>", "BRANCH", "MLWB", "OUTSOURCED"})
        Me.ComboBox4.Location = New System.Drawing.Point(528, 64)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox4.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.ComboBox6)
        Me.GroupBox3.Controls.Add(Me.lblREMInv)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(112, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 104)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'ComboBox6
        '
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.Items.AddRange(New Object() {"<NONE>"})
        Me.ComboBox6.Location = New System.Drawing.Point(416, 24)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(136, 21)
        Me.ComboBox6.TabIndex = 14
        '
        'lblREMInv
        '
        Me.lblREMInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblREMInv.Location = New System.Drawing.Point(304, 24)
        Me.lblREMInv.Name = "lblREMInv"
        Me.lblREMInv.Size = New System.Drawing.Size(104, 24)
        Me.lblREMInv.TabIndex = 16
        Me.lblREMInv.Text = "CLASSIFICATION"
        Me.lblREMInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(304, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "CUSTODIAN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(528, 65)
        Me.TextBox1.MaxLength = 5
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = ""
        Me.TextBox1.Visible = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 144)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1048, 368)
        Me.CrystalReportViewer1.TabIndex = 14
        '
        'grpStocks
        '
        Me.grpStocks.Controls.Add(Me.rdALL)
        Me.grpStocks.Controls.Add(Me.cboConsignee)
        Me.grpStocks.Controls.Add(Me.lblConsignee)
        Me.grpStocks.Controls.Add(Me.rdUncogsigned)
        Me.grpStocks.Controls.Add(Me.rdConsigned)
        Me.grpStocks.Location = New System.Drawing.Point(736, 16)
        Me.grpStocks.Name = "grpStocks"
        Me.grpStocks.Size = New System.Drawing.Size(296, 104)
        Me.grpStocks.TabIndex = 15
        Me.grpStocks.TabStop = False
        Me.grpStocks.Text = "STOCKS"
        Me.grpStocks.Visible = False
        '
        'rdALL
        '
        Me.rdALL.Checked = True
        Me.rdALL.Location = New System.Drawing.Point(232, 24)
        Me.rdALL.Name = "rdALL"
        Me.rdALL.Size = New System.Drawing.Size(56, 24)
        Me.rdALL.TabIndex = 4
        Me.rdALL.TabStop = True
        Me.rdALL.Text = "ALL"
        Me.rdALL.Visible = False
        '
        'cboConsignee
        '
        Me.cboConsignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConsignee.Items.AddRange(New Object() {"<NONE>"})
        Me.cboConsignee.Location = New System.Drawing.Point(88, 56)
        Me.cboConsignee.Name = "cboConsignee"
        Me.cboConsignee.Size = New System.Drawing.Size(192, 21)
        Me.cboConsignee.TabIndex = 3
        '
        'lblConsignee
        '
        Me.lblConsignee.Location = New System.Drawing.Point(8, 60)
        Me.lblConsignee.Name = "lblConsignee"
        Me.lblConsignee.TabIndex = 2
        Me.lblConsignee.Text = "CONSIGNEE"
        '
        'rdUncogsigned
        '
        Me.rdUncogsigned.Location = New System.Drawing.Point(120, 24)
        Me.rdUncogsigned.Name = "rdUncogsigned"
        Me.rdUncogsigned.Size = New System.Drawing.Size(120, 24)
        Me.rdUncogsigned.TabIndex = 1
        Me.rdUncogsigned.Text = "UNCONSIGNED"
        '
        'rdConsigned
        '
        Me.rdConsigned.Location = New System.Drawing.Point(8, 24)
        Me.rdConsigned.Name = "rdConsigned"
        Me.rdConsigned.TabIndex = 0
        Me.rdConsigned.Text = "CONSIGNED"
        '
        'frmInventory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1050, 512)
        Me.Controls.Add(Me.grpStocks)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.grpStocks.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim objclass As New clsCommon
    Dim dr As SqlDataReader
    Dim SQuery As String
    Private Sub frmInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cb.Text = UCase(userLog)
            CostCenter()
            Call_GetConsignee()
            RemInv(False)
            Me.ComboBox4.SelectedIndex = 0
            Me.ComboBox5.SelectedIndex = 0
            Me.ComboBox6.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("frmInventory/frmInventory_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub
    Private Sub Call_GetConsignee()
        Try
            Dim objcon As New clsCommon
            Dim dr As SqlDataReader
            Dim strQ As String

            strQ = "Select * from ASYS_vw_GetConsignee"
            objcon = New clsCommon
            objcon.Connectionstring3()
            objcon.Open3()
            objcon.Command3(strQ)
            dr = objcon.OpenDataReader3
            While dr.Read
                cboConsignee.Items.Add(Trim(dr.Item("Consignee")))
            End While
            dr.Close()
            objcon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub call_Custodian(ByVal costcenter As String)
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            If costcenter = "DISTRIBUTION" Then
                costcenter = "DISTRI"
            End If

            str = "Select distinct fullname from vw_humresvismin where job_title like '%" & costcenter & "%'"
            ComboBox6.Items.Clear()
            ComboBox6.Text = "<NONE>"
            ComboBox6.Items.Add("<NONE>")
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3(str)
            dr = obj.OpenDataReader3
            While dr.Read
                ComboBox6.Items.Add(Trim(UCase(dr.Item("fullname"))))
            End While
            dr.Close()
            obj.Close3()
            ComboBox6.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("frmInventory/call_Custodian: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub valEmp()
        Try
            Dim CapName As String
            SQuery = "select distinct fullname from " & humres2 & " where sur_name not like '%Ong%' and job_title like 'ALLB%' or  first_name like '%Debbie Rose%' or fullname like '%DINNA CAÑETE PARREÑO%' or sur_name like '%BRIONES%'"
            objclass.ConnDb()
            objclass.Open5()
            cb.Items.Clear()
            objclass.Command5(SQuery)
            dr = objclass.OpenDataReader5
            While dr.Read
                CapName = dr.Item("fullname")
                cb.Items.Add(UCase(CapName))
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        Catch ex As Exception
            MsgBox("frmInventory/valEmp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub CostCenter()
        Try
            SQuery = "Select * from tbl_CostCenter where CostDept not in ('SHOWROOM','VIP')"
            objclass.Connectionstring3()
            objclass.Open3()
            ComboBox3.Items.Clear()
            objclass.Command3(SQuery)
            dr = objclass.OpenDataReader3
            '''While dr.Read
            '''    ComboBox3.Items.Add(dr.Item(UCase("CostDept")))
            '''End While
            While dr.Read
                If dr.Item(UCase("CostDept")) = "DISTRI" Then
                    ComboBox3.Items.Add(dr.Item(UCase("CostDept")) & "BUTION")
                    tmpCostNameDistri = dr.Item(UCase("CostDept"))
                Else
                    ComboBox3.Items.Add(dr.Item(UCase("CostDept")))
                End If
            End While
            dr.Close()
            objclass.Execute3()
            objclass.Close3()
        Catch ex As Exception
            MsgBox("frmInventory/CostCenter: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            dr.Close()
            objclass.Close3()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub fnPrintPreview()
        Try
            If Me.cb.Text = "" Then
                MsgBox("Please select valid user.", MsgBoxStyle.Information, TitleMsgBox)
                Me.cb.Focus()
            ElseIf Me.ComboBox2.Text = "" Then
                MsgBox("Please select Inventory Type.", MsgBoxStyle.Information, TitleMsgBox)
                Me.ComboBox2.Focus()
            ElseIf Me.ComboBox3.SelectedIndex = -1 Then
                MsgBox("Please select Cost Center.", MsgBoxStyle.Information, TitleMsgBox)
                Me.ComboBox3.Focus()
            Else
                Dim crtableLogoninfo As New TableLogOnInfo
                Dim crConnectionInfo As New ConnectionInfo
                Dim crTables As Tables
                Dim objclass As New clsReport

                ' Dim frm As New frmInventory_rpt
                oRPT = New ReportDocument
                Dim sPath As String
                Dim frmMain1 As New frmMain
                sPath = frmMain1.sPath
                objcommom = New clsCommon

                objcommom.Connectionstring3()


                If ComboBox3.Text = "REM" And ComboBox6.Text <> "<NONE>" Then
                    If UCase(ComboBox6.Text) = "OUTSOURCE" Then 'Inventory Outsource
                        oRPT.Load(sPath + "\ASYS_REMOutsource_Inventory.rpt")
                        If TextBox1.Text.Length <= 0 And (ComboBox5.SelectedIndex = -1 Or ComboBox5.SelectedIndex = 0) Then
                            oRPT.Load(sPath + "\ASYS_REMJewelryOutsourceAll.rpt")
                            oRPT.SetParameterValue("UName", UCase(userLog))
                            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                        ElseIf TextBox1.Text.Length > 0 And (ComboBox5.SelectedIndex = -1 Or ComboBox5.SelectedIndex = 0) Then
                            oRPT.SetParameterValue("@rptFlag", 1)
                            oRPT.SetParameterValue("@SupplierCode", Me.TextBox1.Text)
                            oRPT.SetParameterValue("@ItemCode", "0")
                        ElseIf TextBox1.Text.Length <= 0 And (ComboBox5.SelectedIndex <> -1 Or ComboBox5.SelectedIndex <> 0) Then
                            oRPT.SetParameterValue("@rptFlag", 2)
                            oRPT.SetParameterValue("@ItemCode", Me.ComboBox5.Text)
                            oRPT.SetParameterValue("@SupplierCode", "0")
                        ElseIf TextBox1.Text.Length > 0 And (ComboBox5.SelectedIndex <> -1 Or ComboBox5.SelectedIndex <> 0) Then
                            oRPT.SetParameterValue("@rptFlag", 3)
                            oRPT.SetParameterValue("@SupplierCode", Me.TextBox1.Text)
                            oRPT.SetParameterValue("@ItemCode", Me.ComboBox5.Text)
                        End If
                        oRPT.SetParameterValue("UName", UCase(userLog))
                        oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))

                    ElseIf UCase(ComboBox6.Text) = "RETURNS" Then 'Inventory Returns
                        oRPT.Load(sPath + "\ASYS_REMJewelryReturn.rpt")

                        If TextBox1.Text.Length <= 0 And (ComboBox5.SelectedIndex = -1 Or ComboBox5.SelectedIndex = 0) Then
                            oRPT.Load(sPath + "\ASYS_REMJewelryReturnALL.rpt")
                            oRPT.SetParameterValue("UName", UCase(userLog))
                            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                        ElseIf TextBox1.Text.Length > 0 And (ComboBox5.SelectedIndex = -1 Or ComboBox5.SelectedIndex = 0) Then
                            oRPT.SetParameterValue("@rptFlag", 1)
                            oRPT.SetParameterValue("@SupplierCode", Me.TextBox1.Text)
                            oRPT.SetParameterValue("@ItemCode", "")
                            oRPT.SetParameterValue("UName", UCase(userLog))
                            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                        ElseIf TextBox1.Text.Length <= 0 And (ComboBox5.SelectedIndex <> -1 Or ComboBox5.SelectedIndex <> 0) Then
                            oRPT.SetParameterValue("@rptFlag", 2)
                            oRPT.SetParameterValue("@ItemCode", Me.ComboBox5.Text)
                            oRPT.SetParameterValue("@SupplierCode", "")
                            oRPT.SetParameterValue("UName", UCase(userLog))
                            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                        ElseIf TextBox1.Text.Length > 0 And (ComboBox5.SelectedIndex <> -1 Or ComboBox5.SelectedIndex <> 0) Then
                            oRPT.SetParameterValue("@rptFlag", 3)
                            oRPT.SetParameterValue("@SupplierCode", Me.TextBox1.Text)
                            oRPT.SetParameterValue("@ItemCode", Me.ComboBox5.Text)
                            oRPT.SetParameterValue("UName", UCase(userLog))
                            oRPT.SetParameterValue("@PrintedDate", UCase(Format(Now.Date, "MMMM dd, yyyy")))
                        End If
                    ElseIf UCase(ComboBox6.Text) = "TRADE-IN" Then
                        oRPT.Load(sPath + "\ASYS_TradeInInventory.rpt")
                        oRPT.SetParameterValue("@Username", UCase(userLog))
                    Else
                        If (ComboBox6.Text) = "RETURN" Then

                            'oRPT.Load(sPath + "\ASYS_REM_ReturnInventory.rpt")
                            oRPT.Load(sPath + "\ASYS_REM_ReturnInventory_V5S.rpt") '----ASYS 5.0 Showroom

                            oRPT.SetParameterValue("@DatePrinted", UCase(Format(Date.Now, "MMMM dd, yyyy")))
                            oRPT.SetParameterValue("@pactionclass", Replace(ComboBox6.Text.Trim, " ", ""))
                            oRPT.SetParameterValue("Name", UCase(userLog))
                        Else
                            'oRPT.Load(sPath + "\ASYS_REMInventory.rpt")

                            oRPT.Load(sPath + "\ASYS_REMInventory_V5S.rpt") '----ASYS V5S
                            oRPT.SetParameterValue("@DatePrinted", UCase(Format(Date.Now, "MMMM dd, yyyy")))
                            oRPT.SetParameterValue("@pactionclass", Replace(ComboBox6.Text.Trim, " ", ""))
                            oRPT.SetParameterValue("Name", UCase(userLog))
                        End If
                    End If
                ElseIf ComboBox3.Text.Length > 0 And (ComboBox6.Text = "<NONE>" Or ComboBox6.Text = "") Then
                    If UCase(Me.ComboBox2.Text) = "DEPARTMENT" Then
                        If ComboBox3.Text = "DISTRIBUTION" Then
                            If rdConsigned.Checked = True Then
                                oRPT.Load(sPath + "\ASYS_InventorybyConsignStockAll.rpt")
                                oRPT.SetParameterValue("User", UCase(Me.cb.Text))
                                oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                                oRPT.SetParameterValue("@TimePrinted", String.Format("{0:t}", Now))
                                oRPT.SetParameterValue("ConTYPE", cboConsignee.Text.Trim)
                                ' oRPT.Load(sPath + "\ASYS_InventorybyCostCenter.rpt") ' 7/25/2012 TOLIN
                            ElseIf rdUncogsigned.Checked = True Then
                                'If (cboConsignee.Text = "<NONE>" And cboConsignee.Text = "") And ComboBox5.Text = "<NONE>" And TextBox1.Text = "<NONE>" And ComboBox6.Text = "<NONE>" Then
                                oRPT.Load(sPath + "\ASYS_InventorybyuNConsignStock.rpt")
                                'Else
                                '    oRPT.Load(sPath + "\ASYS_InventorybyCostCenter.rpt")
                                'End If
                            ElseIf rdALL.Checked = True Then
                                ' If (cboConsignee.Text = "<NONE>" And cboConsignee.Text = "") And ComboBox5.Text = "<NONE>" And TextBox1.Text = "<NONE>" And ComboBox6.Text = "<NONE>" Then
                                ' oRPT.Load(sPath + "\ASYS_InventorybyCostCenter.rpt")
                                oRPT.Load(sPath + "\ASYS_InventorybyCostCenter_V5S.rpt") '---------This part here is use for Asys 5.0 Showroom
                                'End If
                            End If
                        Else
                            'oRPT.Load(sPath + "\ASYS_InventorybyCostCenter.rpt") ASYS 5.0
                            oRPT.Load(sPath + "\ASYS_InventorybyCostCenter_V5S.rpt") '---------This part here is use for Asys 5.0 Showroom
                        End If

                    ElseIf UCase(Me.ComboBox2.Text) = "ITEM" Then
                        oRPT.Load(sPath + "\ASYS_InventorybyItemcode.rpt")
                    ElseIf UCase(Me.ComboBox2.Text) = "SUPPLIER" Then
                        oRPT.Load(sPath + "\ASYS_InventorybyItemsource.rpt")
                        If TextBox1.Text = "" Then
                            oRPT.SetParameterValue("supplier", ComboBox4.SelectedItem)
                        Else
                            oRPT.SetParameterValue("supplier", TextBox1.Text)
                        End If
                    End If

                    oRPT.SetParameterValue("User", UCase(Me.cb.Text))
                    oRPT.SetParameterValue("@DatePrinted", UCase(Format(Now, "MMMM dd, yyyy")))
                    oRPT.SetParameterValue("@TimePrinted", String.Format("{0:t}", Now)) 'UCase(Format(Date.Now, "HH:mm AM/PM")))


                    If rdALL.Checked = True Then
                        'If ComboBox5.Text <> "<NONE>" Or TextBox1.Text <> "" Or ComboBox6.Text <> "<NONE>" Then
                        If Me.ComboBox5.Text <> "<NONE>" Then
                            oRPT.SetParameterValue("@itemcode", Me.ComboBox5.Text)
                        Else
                            oRPT.SetParameterValue("@itemcode", "0")
                        End If
                        If Me.ComboBox3.Text <> "" Then
                            oRPT.SetParameterValue("@costcenter", Me.ComboBox3.Text)
                        Else
                            oRPT.SetParameterValue("@costcenter", "0")
                        End If
                        If Me.TextBox1.Text <> "" Then
                            oRPT.SetParameterValue("@itemsource", Me.TextBox1.Text)
                        Else
                            oRPT.SetParameterValue("@itemsource", "0")
                        End If
                        'End If  
                    End If

                ElseIf ComboBox3.Text <> "REM" And ComboBox6.Text <> "<NONE>" Then

                    If ComboBox3.Text = "MLWB" Then
                        oRPT.Load(sPath + "\ASYS_MLWBInventory.rpt")
                        oRPT.SetParameterValue("@receiver", Me.ComboBox6.SelectedItem)
                        oRPT.SetParameterValue("emp", UCase(userLog))
                    ElseIf ComboBox3.Text = "PRICING" Then
                        oRPT.Load(sPath + "\ASYS_PRICINGInventory.rpt")
                        oRPT.SetParameterValue("@receiver", Me.ComboBox6.Text)
                        oRPT.SetParameterValue("emp", UCase(userLog))
                    ElseIf ComboBox3.Text = "DISTRIBUTION" Then
                        oRPT.Load(sPath + "\ASYS_DistriInventory.rpt")
                        oRPT.SetParameterValue("@receiver", Me.ComboBox6.SelectedItem)
                        oRPT.SetParameterValue("emp", UCase(userLog))
                    Else
                        MsgBox("Not Applicable to REM Department.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If
                End If

                With crConnectionInfo
                    .ServerName = objcommom.sDatasource1
                    .DatabaseName = objcommom.sDatabase1
                    .UserID = objcommom.sUsername1
                    .Password = objcommom.sPassword1

                End With

                crTables = oRPT.Database.Tables
                crtableLogoninfo.ConnectionInfo = crConnectionInfo

                If ComboBox3.Text = "REM" And ComboBox6.Text <> "<NONE>" Then
                    If UCase(ComboBox6.Text) = "OUTSOURCE" Then
                        If TextBox1.Text.Length <= 0 And (ComboBox5.Text.Length <= 0 Or ComboBox5.Text = "<NONE>") Then
                            crTables.Item("ASYS_REMJewelryOutsourceAll;1").ApplyLogOnInfo(crtableLogoninfo)
                            crTables.Item("ASYS_REMJewelryOutsourceAll;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelryOutsourceAll;1"
                        Else
                            crTables.Item("ASYS_REMJewelryOutsource;1").ApplyLogOnInfo(crtableLogoninfo)
                            crTables.Item("ASYS_REMJewelryOutsource;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelryOutsource;1"
                        End If
                    ElseIf UCase(ComboBox6.Text) = "RETURNS" Then
                        If TextBox1.Text.Length <= 0 And (ComboBox5.Text.Length <= 0 Or ComboBox5.Text = "<NONE>") Then
                            crTables.Item("ASYS_REMJewelryReturnsAll;1").ApplyLogOnInfo(crtableLogoninfo)
                            crTables.Item("ASYS_REMJewelryReturnsAll;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelryReturnsAll;1"
                        Else
                            crTables.Item("ASYS_REMJewelryReturns;1").ApplyLogOnInfo(crtableLogoninfo)
                            crTables.Item("ASYS_REMJewelryReturns;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_REMJewelryReturns;1"
                        End If
                    ElseIf UCase(ComboBox6.Text) = "TRADE-IN" Then
                        crTables.Item("ASYS_TradeInInventory;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_TradeInInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_TradeInInventory;1"
                    Else
                        'crTables.Item("ASYS_spREMInventory;1").ApplyLogOnInfo(crtableLogoninfo)
                        'crTables.Item("ASYS_spREMInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_spREMInventory;1"

                        crTables.Item("ASYS_spREMInventory_V5S;1").ApplyLogOnInfo(crtableLogoninfo) '-----ASYS V5.0 SHOWROOM
                        crTables.Item("ASYS_spREMInventory_V5S;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_spREMInventory_V5S;1"
                    End If
                ElseIf ComboBox3.Text.Length > 0 And ComboBox6.Text = "<NONE>" Then
                    If UCase(Me.ComboBox2.Text) = "DEPARTMENT" Then

                        If ComboBox3.Text = "DISTRIBUTION" Then
                            If rdConsigned.Checked = True Then

                                crTables.Item("ASYS_InventoryALLConsign;1").ApplyLogOnInfo(crtableLogoninfo)
                                crTables.Item("ASYS_InventoryALLConsign;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventoryALLConsign;1"


                            ElseIf rdUncogsigned.Checked = True Then
                                'If (cboConsignee.Text = "<NONE>" And cboConsignee.Text = "") And ComboBox5.Text = "<NONE>" And TextBox1.Text = "<NONE>" And ComboBox6.Text = "<NONE>" Then
                                crTables.Item("ASYS_ReportsInventoryUnconsignment;1").ApplyLogOnInfo(crtableLogoninfo)
                                crTables.Item("ASYS_ReportsInventoryUnconsignment;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_ReportsInventoryUnconsignment;1"

                                'Else
                                '    crTables.Item("ASYS_InventorybyCostCenter;1").ApplyLogOnInfo(crtableLogoninfo)
                                '    crTables.Item("ASYS_InventorybyCostCenter;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventorybyCostCenter;1"

                                'End If
                            ElseIf rdALL.Checked = True Then
                                'crTables.Item("ASYS_InventorybyCostCenter;1").ApplyLogOnInfo(crtableLogoninfo)
                                'crTables.Item("ASYS_InventorybyCostCenter;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventorybyCostCenter;1"

                                crTables.Item("ASYS_InventorybyCostCenter_V5S;1").ApplyLogOnInfo(crtableLogoninfo) '---------This part here is use for Asys 5.0 Showroom
                                crTables.Item("ASYS_InventorybyCostCenter_V5S;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventorybyCostCenter_V5S;1"
                            End If
                        Else



                            'crTables.Item("ASYS_InventorybyCostCenter;1").ApplyLogOnInfo(crtableLogoninfo)        '--ASYS 5.0
                            'crTables.Item("ASYS_InventorybyCostCenter;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventorybyCostCenter;1"

                            crTables.Item("ASYS_InventorybyCostCenter_V5S;1").ApplyLogOnInfo(crtableLogoninfo) '---------This part here is use for Asys 5.0 Showroom
                            crTables.Item("ASYS_InventorybyCostCenter_V5S;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_InventorybyCostCenter_V5S;1"
                        End If

                    ElseIf UCase(Me.ComboBox2.Text) = "ITEM" Then
                        crTables.Item("ASYS_Inventorybyitemcode;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_Inventorybyitemcode;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_Inventorybyitemcode;1"

                    ElseIf UCase(Me.ComboBox2.Text) = "SUPPLIER" Then
                        crTables.Item("ASYS_Inventorybyitemsource;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_Inventorybyitemsource;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_Inventorybyitemsource;1"
                    End If
                ElseIf ComboBox3.Text <> "REM" And ComboBox6.Text <> "<NONE>" Then
                    If ComboBox3.Text = "MLWB" Then
                        crTables.Item("ASYS_MLWBInventory;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_MLWBInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_MLWBInventory"
                    ElseIf ComboBox3.Text = "PRICING" Then
                        crTables.Item("ASYS_PRICINGInventory;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_PRICINGInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_PRICINGInventory"
                    ElseIf ComboBox3.Text = "DISTRIBUTION" Then
                        crTables.Item("ASYS_DistriInventory;1").ApplyLogOnInfo(crtableLogoninfo)
                        crTables.Item("ASYS_DistriInventory;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_DistriInventory;1"
                    Else
                        MsgBox("Not Applicable to REM Department.", MsgBoxStyle.Information, TitleMsgBox)
                        Exit Sub
                    End If

                End If

                CrystalReportViewer1.ReportSource = oRPT
                Me.Cursor = Cursors.Arrow
                End If
            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            MsgBox("frmInventory/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fnPrintPreview()
    End Sub
    Private Sub cb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cb.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                Me.ComboBox2.Focus()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmInventory/cb_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmInventory/ComboBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox3.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmInventory/ComboBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmInventory/ComboBox4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox5.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmInventory/ComboBox5_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub ComboBox3_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectionChangeCommitted
    '    callItem()
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            'ComboBox6.Text = "<NONE>"

            If Me.TextBox1.Visible = True Then
                Me.TextBox1.Visible = False
                Me.ComboBox4.Visible = True
            Else
                TextBox1.Text = ""
                TextBox1.Visible = True
                ComboBox4.Visible = False
            End If
        Catch ex As Exception
            MsgBox("frmInventory/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim Squery As String

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
                Exit Sub
            End If

            If e.KeyChar = ChrW(13) Then
                obj.Connectionstring3()
                obj.Open3()

                If ComboBox3.Text = "MLWB" Then
                    Squery = "Select substring(allbarcode, 4, 5) as refitemcode from asys_mlwb_detail where substring(allbarcode, 4, 5) ='" & Me.TextBox1.Text & "'"
                ElseIf ComboBox3.Text = "PRICING" Then
                    Squery = "Select substring(allbarcode, 4, 5) as refitemcode from asys_pricing_detail where substring(allbarcode, 4, 5) ='" & Me.TextBox1.Text & "'"
                ElseIf ComboBox3.Text = "DISTRIBUTION" Then
                    Squery = "Select substring(allbarcode, 4, 5) as refitemcode from asys_distri_detail where substring(allbarcode, 4, 5) ='" & Me.TextBox1.Text & "'"
                ElseIf ComboBox3.Text = "REM" Then
                    Squery = "Select substring(allbarcode, 4, 5) as refitemcode from asys_rem_detail where substring(allbarcode, 4, 5) ='" & Me.TextBox1.Text & "'"
                Else
                    Squery = "Select itemsource from vw_REMItemsource where itemsource = '" & Me.TextBox1.Text & "'"
                End If
                obj.Command3(Squery)
                dr = obj.OpenDataReader3
                If dr.Read = False Then
                    MsgBox("Itemsource doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.TextBox1.Clear()
                    Me.TextBox1.Focus()
                End If
                dr.Close()
                obj.Execute3()
                obj.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("frmInventory/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.cb.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ComboBox2.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ComboBox3.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Me.ComboBox5.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            grpStocks.Visible = False
            rdALL.Checked = True
            cboConsignee.Enabled = False
            If ComboBox3.Text = "DISTRIBUTION" Then
                ComboBox6.Enabled = True
                    ComboBox4.Enabled = False
                    ComboBox5.Enabled = False
                    grpStocks.Visible = True
            End If


            If ComboBox3.Text = "REM" Then
                'Call call_Custodian("SORTER")
                RemInv(True)
            Else
                'RemInv(False)
                Me.lblREMInv.Visible = False
                Call call_Custodian(ComboBox3.Text)
            End If
        Catch ex As Exception
            MsgBox("frmInventory/ComboBox3_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RemInv(ByVal RemInvFlag As Boolean)
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            str = "SELECT action_type FROM tbl_action WHERE action_type not in ('Appliance','AuctionBuyer','TakenBack','Release') ORDER BY action_type"
            Me.ComboBox6.Items.Clear()
            ComboBox6.Text = "<NONE>"
            ComboBox6.Items.Add("<NONE>")
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3(str)
            dr = obj.OpenDataReader3
            While dr.Read
                If dr.Item("action_type") = "MissingItem" Then
                    ComboBox6.Items.Add("MISSING ITEM")
                ElseIf dr.Item("action_type") = "OverAppraised" Then
                    ComboBox6.Items.Add("OVER APPRAISED")
                Else
                    ComboBox6.Items.Add(Trim(UCase(dr.Item("action_type"))))
                End If
            End While
            dr.Close()
            obj.Close3()

            Me.lblREMInv.Visible = RemInvFlag
            ComboBox6.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("frmInventory/RemInv: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try

            If ComboBox6.Text <> "OUTSOURCE" Then
                ComboBox6.Text = "<NONE>"
            ElseIf ComboBox6.Text <> "RETURN" Then
                ComboBox6.Text = "<NONE>"
            End If
            ComboBox6.Enabled = True

        Catch ex As Exception
            MsgBox("frmInventory/ComboBox5_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If TextBox1.Text.Length > 4 Then
                ComboBox6.Enabled = False
            Else
                ComboBox6.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmInventory/TextBox1_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmInventory_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
    '    Try
    '        If ComboBox6.Text <> "<NONE>" Then
    '            TextBox1.Text = ""
    '            ComboBox4.Text = ""
    '            ComboBox5.Text = ""
    '            TextBox1.Enabled = False
    '            ComboBox4.Enabled = False
    '            ComboBox5.Enabled = False
    '        Else
    '            TextBox1.Enabled = True
    '            ComboBox4.Enabled = True
    '            ComboBox5.Enabled = True

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        Try
            ComboBox4.Visible = True
            If ComboBox6.Text <> "<NONE>" Then
                If ComboBox6.Text = "OUTSOURCE" Or ComboBox6.Text = "RETURNS" Then
                    TextBox1.Enabled = True
                    ComboBox4.Enabled = True
                    ComboBox5.Enabled = True
                    ComboBox4.Enabled = True
                    ComboBox5.Enabled = True
                    Button3.Enabled = False
                    Button7.Enabled = True
                    ComboBox4.Visible = False
                    TextBox1.Visible = True
                    Exit Sub
                End If

                TextBox1.Text = ""
                ComboBox4.Text = ""
                ComboBox5.Text = ""
                TextBox1.Enabled = False
                TextBox1.Visible = False
                ComboBox4.Enabled = False
                ComboBox5.Enabled = False
                Button3.Enabled = False
                Button7.Enabled = False

                'ComboBox4.Enabled = True
                'ComboBox5.Enabled = True
                'Button3.Enabled = True
                'Button7.Enabled = True
            Else
                TextBox1.Enabled = True
                ComboBox4.Enabled = True
                ComboBox5.Enabled = True
                'ComboBox4.Enabled = True
                'ComboBox5.Enabled = True
                Button3.Enabled = True
                Button7.Enabled = True

            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rdConsigned_checkedchanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdConsigned.CheckedChanged

        Try
            cboConsignee.Enabled = True
            ComboBox4.Enabled = False
            ComboBox5.Enabled = False
            ComboBox6.Enabled = False
            ComboBox4.Text = "<NONE>"
            ComboBox5.Text = "<NONE>"
            ComboBox6.Text = "<NONE>"
            cboConsignee.Text = "<NONE>"
        Catch ex As Exception
            MsgBox("frmInventory/rdConsigned_checkedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub rdUncogsigned_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdUncogsigned.CheckedChanged
        cboConsignee.Enabled = False
        cboConsignee.Text = ""
        Try
            If Me.rdUncogsigned.Checked = True Then
                ComboBox4.Enabled = False
                ComboBox5.Enabled = False
                ComboBox6.Enabled = False

                ComboBox4.Text = "<NONE>"
                ComboBox5.Text = "<NONE>"
                ComboBox6.Text = "<NONE>"
            End If

        Catch ex As Exception
            MsgBox("frmInventory/rdUnconsigned_checkedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cboConsignee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConsignee.SelectedIndexChanged
        If cboConsignee.Text <> "" Then
            ComboBox6.Enabled = False
            ComboBox4.Enabled = False
            ComboBox5.Enabled = False
        Else
            ComboBox6.Enabled = True
            ComboBox4.Enabled = True
            ComboBox5.Enabled = True
        End If
    End Sub

    Private Sub rdALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdALL.CheckedChanged
        ComboBox4.Enabled = True
        ComboBox5.Enabled = True
        ComboBox6.Enabled = True

        ComboBox4.Text = "<NONE>"
        ComboBox5.Text = "<NONE>"
        ComboBox6.Text = "<NONE>"
    End Sub
End Class
