Imports System.Data.SqlClient
Public Class frmViewBRanchOrCustInfo
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmViewBRanchOrCustInfo))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(8, 8)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(512, 408)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'frmViewBRanchOrCustInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 422)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmViewBRanchOrCustInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Branch/Customer Information"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub ViewBranchorCustInfo(ByVal b As Integer)
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            ListView1.Items.Clear()
            obj = New clsCommon
            obj.Connectionstring4()
            obj.Open4()
            If b = 1 Then
                str = "Select branchcode as code,branchname as name,branchaddress as address from ASYS_BranchAddress order by branchcode"
                Me.Text = "View Branch Information"
            Else
                str = "select '10000' + customerid as code, CustomerFname + ' ' + RTRIM(CustomerMname) + '.' + ' ' +  CustomerLname as [Name],customeraddress as address from ASYS_CreateCustinfo order by customerfname"
                Me.Text = "View Customer Information"
            End If
            obj.Command4(str)
            dr = obj.OpenDataReader4
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("code")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("name")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("address")))
            End While
            dr.Close()
            ' obj.Execute4()
            obj.Close4()
            obj = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            If Me.Text = "VIEW BRANCH ADDRESS" Then
                ClickInfo(1, ListView1.FocusedItem.SubItems(0).Text, ListView1.FocusedItem.SubItems(1).Text)
            Else
                ClickInfo(2, ListView1.FocusedItem.SubItems(0).Text, ListView1.FocusedItem.SubItems(1).Text)
            End If
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ClickInfo(ByVal s As Integer, ByVal h As Integer, ByVal a As String)
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim frm As New frmCreateBranchAdd

            obj = New clsCommon
            obj.Connectionstring4()
            obj.Open4()
            If s = 1 Then
                str = "Select branchcode,branchname,branchaddress,XMLAbbr from ASYS_BranchAddress where branchcode = " & h & " and branchname = '" & a & "' order by branchcode"
                obj.Command4(str)
                dr = obj.OpenDataReader4
                If dr.Read Then
                    frm.txtBranchCode.Text = dr.Item("branchcode")
                    frm.txtBranchName.Text = dr.Item("branchname")
                    frm.TextBox3.Text = dr.Item("branchaddress")
                    frm.txtXMLAbbr.Text = obj.IsNull(dr.Item("XMLAbbr"))
                    frm.btnEdit.BringToFront()
                    frm.RadioButton1.Checked = True
                    frm.btnEdit.Enabled = True
                End If
                dr.Close()
            Else
                str = "Select customerid,customerfname,customermname,customerlname,customeraddress from ASYS_CreateCustInfo where CustomerID = " & Replace(h, "10000", "") & ""
                obj.Command4(str)
                dr = obj.OpenDataReader4
                If dr.Read Then
                    frm.TextBox7.Text = "10000" + dr.Item("CustomerID")
                    frm.TextBox9.Text = dr.Item("CustomerFname")
                    frm.TextBox8.Text = dr.Item("CustomerMName")
                    frm.TextBox4.Text = dr.Item("CustomerLname")
                    frm.TextBox5.Text = dr.Item("CustomerAddress")
                    frm.btnEdit.BringToFront()
                    frm.RadioButton2.Checked = True
                    frm.btnEdit.Enabled = True
                End If
                dr.Close()
            End If
            'obj.Execute4()
            obj.Close4()
            obj = Nothing
            frm.btnEdit.BringToFront()

            Me.Hide()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    Private Sub frmViewBRanchOrCustInfo_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            If Me.Text = "VIEW BRANCH ADDESS" Then
                Dim frm As New frmCreateBranchAdd
                frm.btnEdit.BringToFront()

                Me.Hide()
                frm.ShowDialog()
            Else
                Dim frm As New frmCreateBranchAdd
                frm.btnEdit.BringToFront()

                Me.Hide()
                frm.ShowDialog()
            End If
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmViewBRanchOrCustInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
