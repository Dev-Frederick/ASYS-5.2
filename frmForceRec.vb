Imports System.data.SqlClient
Imports Microsoft
Public Class frmBranchInfo
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbranchcode As System.Windows.Forms.TextBox
    Friend WithEvents txtbranchname As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBranchInfo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbranchcode = New System.Windows.Forms.TextBox
        Me.txtbranchname = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BRANCH CODE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BRANCH NAME"
        '
        'txtbranchcode
        '
        Me.txtbranchcode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbranchcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbranchcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbranchcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchcode.Location = New System.Drawing.Point(128, 8)
        Me.txtbranchcode.MaxLength = 3
        Me.txtbranchcode.Name = "txtbranchcode"
        Me.txtbranchcode.Size = New System.Drawing.Size(48, 19)
        Me.txtbranchcode.TabIndex = 2
        Me.txtbranchcode.Text = ""
        '
        'txtbranchname
        '
        Me.txtbranchname.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtbranchname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbranchname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbranchname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbranchname.Location = New System.Drawing.Point(128, 32)
        Me.txtbranchname.MaxLength = 100
        Me.txtbranchname.Name = "txtbranchname"
        Me.txtbranchname.Size = New System.Drawing.Size(176, 19)
        Me.txtbranchname.TabIndex = 3
        Me.txtbranchname.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 64)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(296, 304)
        Me.ListView1.TabIndex = 4
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "BRANCH CODE"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "BRANCH NAME"
        Me.ColumnHeader2.Width = 210
        '
        'frmBranchInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(312, 374)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtbranchname)
        Me.Controls.Add(Me.txtbranchcode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(320, 408)
        Me.MinimumSize = New System.Drawing.Size(320, 408)
        Me.Name = "frmBranchInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEW BRANCH INFORMATION"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Search_bedryf()
        Try

            Dim objclass As New clsCommon
        Dim dr As SqlDataReader
        ListView1.Items.Clear()

        objclass = New clsCommon
        objclass.ConnDb()
        objclass.Open5()
            If Label1.Text.Trim.ToUpper = "BRANCH CODE" Then
                ListView1.Columns(0).Text = "BRANCH CODE"
                ListView1.Columns(1).Text = "BRANCH NAME"
                If txtbranchcode.Text.Trim.Length > 0 Then
                    objclass.Command5("Select bedrnr as code,bedrnm as [name] from " & bedryf2 & " where bedrnr like '" + txtbranchcode.Text.Trim + "%'")
                ElseIf txtbranchname.Text.Trim.Length > 0 Then
                    objclass.Command5("Select bedrnr as code,bedrnm as [name]  from " & bedryf2 & " where bedrnm like '" + txtbranchname.Text.Trim + "%'")
                Else
                    objclass.Command5("Select bedrnr as code,bedrnm as [name]  from " & bedryf2 & "")
                End If
            Else
                ListView1.Columns(0).Text = "CUSTOMER ID"
                ListView1.Columns(1).Text = "CUSTOMER NAME"
                If txtbranchcode.Text.Trim.Length > 0 Then
                    objclass.Command5("select customerid as code,rtrim(customerfname) + ' ' + rtrim(customerlname) as [name] from ASYS_CreateCustInfo where customerid like '" + txtbranchcode.Text.Trim + "%' ORDER BY [name]")
                ElseIf txtbranchname.Text.Trim.Length > 0 Then
                    objclass.Command5("select  customerid as code,rtrim(customerfname) + ' ' + rtrim(customerlname) as [name] from ASYS_CreateCustInfo where customerlname like '" + txtbranchname.Text.Trim + "%' ORDER BY [name]")
                Else
                    objclass.Command5("select customerid as code,rtrim(customerfname) + ' ' + rtrim(customerlname) as [name] from ASYS_CreateCustInfo ORDER BY [name]")
                End If
            End If

            dr = objclass.OpenDataReader5
            While dr.Read
                ListView1.Items.Add(Trim(UCase(dr.Item("code")))).Font = New Font(ListView1.Font, FontStyle.Regular)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(UCase(dr.Item("name"))))
            End While
            dr.Close()
            objclass.Close5()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbranchname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbranchname.TextChanged
        Try
            ListView1.Items.Clear()
            Search_bedryf()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbranchcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbranchcode.TextChanged
        Try
            ListView1.Items.Clear()
            Search_bedryf()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtbranchcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbranchcode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            Dim frm As New frmREMOutSourceBRcv
            frm.TextBox1.Text = Trim(ListView1.FocusedItem.Text)
            frm.TextBox2.Text = Trim(ListView1.FocusedItem.SubItems.Item(1).Text)
            frm.RadioButton2.Checked = True
            frm.txtControlNum.Focus()
            If Label1.Text.Trim = "BRANCH CODE" Then
                frm.RadioButton3.Checked = True
            Else
                frm.RadioButton4.Checked = True
            End If
            frm.Show()
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub WhatDisplay(ByVal bleh As Boolean)
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            obj = New clsCommon
            obj.ConnDb()
            obj.Open5()
            If bleh = True Then
                obj.Command5("select bedrnr,bedrnm from " & bedryf2 & "")
                ListView1.Items.Clear()
                dr = obj.OpenDataReader5
                While dr.Read
                    ListView1.Items.Add(UCase(dr.Item("bedrnr"))).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(dr.Item("bedrnm")))
                End While
                Me.Text = "VIEW BRANCH INFORMATION"
                Label1.Text = "BRANCH CODE"
                Label2.Text = "BRANCH NAME"
                ListView1.Columns(0).Text = "BRANCH CODE"
                ListView1.Columns(1).Text = "BRANCH NAME"
                txtbranchcode.ReadOnly = False
                txtbranchname.ReadOnly = False

            Else
                obj.Command5("select customerid,customerfname,customerlname from ASYS_CreateCustInfo ORDER BY customerfname")
                ListView1.Items.Clear()
                dr = obj.OpenDataReader5
                While dr.Read
                    ListView1.Items.Add(UCase(dr.Item("CustomerID"))).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(UCase(dr.Item("CustomerFname"))) & " " & Trim(dr.Item("CustomerLname")))
                End While
                Me.Text = "VIEW CUSTOMER INFORMATION"
                Label1.Text = "CUSTOMER ID"
                Label2.Text = "CUSTOMER NAME"
                ListView1.Columns(0).Text = "CUSTOMER ID"
                ListView1.Columns(1).Text = "CUSTOMER NAME"
                txtbranchcode.ReadOnly = False
                txtbranchname.ReadOnly = False
            End If
            dr.Close()
            '  obj.Execute5()
            obj.Close5()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmBranchInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class


