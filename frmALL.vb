Imports System.Data.SqlClient

Public Class frmALL
    Inherits System.Windows.Forms.Form
    Dim sel As Boolean

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
    Friend WithEvents BranchCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents BranchName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmALL))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.BranchCode = New System.Windows.Forms.ColumnHeader
        Me.BranchName = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.BranchName})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(376, 344)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BRANCH CODE"
        Me.BranchCode.Width = 110
        '
        'BranchName
        '
        Me.BranchName.Text = "                 BRANCH NAME"
        Me.BranchName.Width = 282
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BRANCH CODE"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(128, 16)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BRANCH NAME"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(128, 40)
        Me.TextBox2.MaxLength = 100
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(248, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'frmALL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(394, 424)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmALL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ML BRANCHES"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub WhatDisplay(ByVal bleh As Boolean)
        Try
            If bleh = True Then
                Call SHOWROOMS()
                sel = True
            Else
                Call VIP()
                sel = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Function VIP()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj = New clsCommon
            obj.ConnDb()
            obj.Open5()
            obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo order by customerfname")
            ListView1.Items.Clear()
            dr = obj.OpenDataReader5
            While dr.Read
                ListView1.Items.Add(dr.Item("CustomerID")).Font = New Font(ListView1.Font, FontStyle.Regular)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname")))
            End While
            Label1.Text = "CUSTOMER ID"
            Label2.Text = "CUSTOMER NAME"
            ListView1.Columns(0).Text = "CUSTOMER ID"
            ListView1.Columns(1).Text = "                 CUSTOMER NAME"
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            Me.Text = "VIEW CUSTOMER INFORMATION"
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception

        End Try
    End Function
    Private Function SHOWROOMS()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj = New clsCommon
            obj.ConnDb()
            obj.Open5()
            obj.Command5("select bedrnr,bedrnm from " & bedryf2 & " where bedrnr not in ('001','002') order by bedrnr")
            ListView1.Items.Clear()
            dr = obj.OpenDataReader5
            While dr.Read
                ListView1.Items.Add(dr.Item("bedrnr")).Font = New Font(ListView1.Font, FontStyle.Regular)
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("bedrnm"))
            End While
            Label1.Text = "BRANCH CODE"
            Label2.Text = "BRANCH NAME"
            ListView1.Columns(0).Text = "BRANCH CODE"
            ListView1.Columns(1).Text = "                 BRANCH NAME"
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            Me.Text = "VIEW BRANCH INFORMATION"
            dr.Close()
            obj.Execute5()
            obj.Close5()
        Catch ex As Exception

        End Try
    End Function

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            Dim frm As New Form1
            frm.TextBox1.Text = ListView1.FocusedItem.Text
            frm.TextBox2.Text = Trim(ListView1.FocusedItem.SubItems.Item(1).Text)
            frm.Label6.Text = Label1.Text
            frm.Label7.Text = Label2.Text()

            p = ListView1.FocusedItem.Text
            a = Trim(ListView1.FocusedItem.SubItems.Item(1).Text)
            o = Label1.Text
            l = Label2.Text()
            If Label1.Text.ToUpper = "BRANCH CODE" Then
                frm.cmbCostCenter.Text = "SHOWROOM"
            Else
                frm.cmbCostCenter.Text = "VIP"
            End If
            Me.Hide()
            frm.ShowDialog()
            'frm.TopMost = True
            'FlagDistriClose = False
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            If sel = True Then
                ListView1.Items.Clear()
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3("Select bedrnr,bedrnm from " & bedryf2 & " where bedrnm like '" & TextBox2.Text & "%'")
                dr = obj.OpenDataReader3
                While dr.Read
                    ListView1.Items.Add(dr.Item("bedrnr")).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("bedrnm"))
                End While
                dr.Close()
                obj.Execute3()
                obj.Close3()
            Else
                obj = New clsCommon
                obj.ConnDb()
                obj.Open5()
                obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo where customerlname like '" & TextBox2.Text & "%' or customerfname like '" & TextBox2.Text & "%' order by customerfname")
                ListView1.Items.Clear()
                dr = obj.OpenDataReader5
                While dr.Read
                    ListView1.Items.Add(dr.Item("CustomerID")).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname")))
                End While
                dr.Close()
                obj.Execute5()
                obj.Close5()
        End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            If TextBox1.Text = "" Then
                TextBox2.Text = ""
            End If
            If sel = True Then
                ListView1.Items.Clear()
                obj.Connectionstring3()
                obj.Open3()
                obj.Command3("Select bedrnr,bedrnm from " & bedryf2 & " where bedrnr like '" & TextBox1.Text & "%'")
                dr = obj.OpenDataReader3
                While dr.Read
                    ListView1.Items.Add(dr.Item("bedrnr")).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("bedrnm"))
                End While
                dr.Close()
                obj.Execute3()
                obj.Close3()
            Else
                obj = New clsCommon
                obj.ConnDb()
                obj.Open5()
                obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo where customerid like '" & TextBox1.Text & "%' order by customerfname")
                ListView1.Items.Clear()
                dr = obj.OpenDataReader5
                While dr.Read
                    ListView1.Items.Add(dr.Item("CustomerID")).Font = New Font(ListView1.Font, FontStyle.Regular)
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname")))
                End While
                dr.Close()
                obj.Execute5()
                obj.Close5()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim obj As New clsCommon
        Dim dr As SqlDataReader
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                    Exit Try
                End If
                If sel = True Then
                    ListView1.Items.Clear()
                    obj.Connectionstring3()
                    obj.Open3()
                    obj.Command3("Select bedrnr,bedrnm from " & bedryf2 & " where bedrnr like '" & TextBox1.Text & "%'")
                    dr = obj.OpenDataReader3
                    While dr.Read
                        TextBox1.Text = dr.Item("bedrnr")
                        TextBox2.Text = dr.Item("bedrnm")
                    End While
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                Else
                    obj = New clsCommon
                    obj.ConnDb()
                    obj.Open5()
                    obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo where customerid like '" & TextBox1.Text & "%' order by customerfname")
                    ListView1.Items.Clear()
                    dr = obj.OpenDataReader5
                    While dr.Read
                        If ListView1.Items.Count > 1 Then
                            TextBox2.Text = ""
                        Else
                            Dim cust As String
                            cust = dr.Item("customerfname") + " " + dr.Item("customerlname")
                            TextBox2.Text = Trim(cust)
                        End If
                        ListView1.Items.Add(dr.Item("CustomerID")).Font = New Font(ListView1.Font, FontStyle.Regular)
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname")))
                    End While
                    dr.Close()
                    obj.Execute5()
                    obj.Close5()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If e.KeyChar = ChrW(13) Then
                If sel = True Then
                    ListView1.Items.Clear()
                    obj.Connectionstring3()
                    obj.Open3()
                    obj.Command3("Select bedrnr,bedrnm from " & bedryf2 & " where bedrnm like '" & TextBox2.Text & "%'")
                    dr = obj.OpenDataReader3
                    While dr.Read
                        TextBox1.Text = dr.Item("bedrnr")
                        TextBox2.Text = dr.Item("bedrnm")
                    End While
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                Else
                    obj = New clsCommon
                    obj.ConnDb()
                    obj.Open5()
                    obj.Command5("select customerid,customerfname,customerlname  from ASYS_CreateCustInfo where customerlname like '" & TextBox2.Text & "%' or customerfname like '" & TextBox2.Text & "%' order by customerfname")
                    ListView1.Items.Clear()
                    dr = obj.OpenDataReader5
                    While dr.Read
                        ListView1.Items.Add(dr.Item("CustomerID")).Font = New Font(ListView1.Font, FontStyle.Regular)
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("CustomerFname")) & " " & Trim(dr.Item("CustomerLname")))
                    End While
                    dr.Close()
                    obj.Execute5()
                    obj.Close5()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmALL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TextBox1.Enabled = True
            Me.TextBox2.Enabled = True
            pao = True
            FlagDistriClose = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_QueryContinueDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs) Handles ListView1.QueryContinueDrag

    End Sub
End Class
