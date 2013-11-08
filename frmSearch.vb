Imports System.Data.SqlClient
Public Class frmSearch
    Inherits System.Windows.Forms.Form
    Public objclass As New clsCommon
    Public dr As SqlDataReader
    Public batchform As New frmBatch

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtregion As System.Windows.Forms.TextBox
    Friend WithEvents txtbcode As System.Windows.Forms.TextBox
    Friend WithEvents txtbname As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSearch))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboRegion = New System.Windows.Forms.ComboBox
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.txtBranchName = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.txtregion = New System.Windows.Forms.TextBox
        Me.txtbcode = New System.Windows.Forms.TextBox
        Me.txtbname = New System.Windows.Forms.TextBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BRANCH CODE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BRANCH NAME"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "REGION"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.Location = New System.Drawing.Point(304, 32)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(168, 21)
        Me.cboRegion.TabIndex = 3
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(56, 32)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(56, 20)
        Me.txtBranchCode.TabIndex = 0
        Me.txtBranchCode.Text = ""
        '
        'txtBranchName
        '
        Me.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(144, 32)
        Me.txtBranchName.MaxLength = 100
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(144, 20)
        Me.txtBranchName.TabIndex = 1
        Me.txtBranchName.Text = ""
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(24, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(456, 176)
        Me.ListView1.TabIndex = 4
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CODE"
        Me.ColumnHeader1.Width = 51
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                        NAME"
        Me.ColumnHeader2.Width = 189
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "REGION"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 198
        '
        'txtregion
        '
        Me.txtregion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtregion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtregion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregion.Location = New System.Drawing.Point(304, 32)
        Me.txtregion.MaxLength = 150
        Me.txtregion.Name = "txtregion"
        Me.txtregion.Size = New System.Drawing.Size(150, 20)
        Me.txtregion.TabIndex = 2
        Me.txtregion.Text = ""
        '
        'txtbcode
        '
        Me.txtbcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbcode.Location = New System.Drawing.Point(24, 280)
        Me.txtbcode.Name = "txtbcode"
        Me.txtbcode.TabIndex = 10
        Me.txtbcode.Text = ""
        Me.txtbcode.Visible = False
        '
        'txtbname
        '
        Me.txtbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbname.Location = New System.Drawing.Point(136, 280)
        Me.txtbname.Name = "txtbname"
        Me.txtbname.TabIndex = 11
        Me.txtbname.Text = ""
        Me.txtbname.Visible = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(400, 272)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 317)
        Me.Controls.Add(Me.txtbname)
        Me.Controls.Add(Me.txtbcode)
        Me.Controls.Add(Me.txtregion)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cboRegion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Branch Search"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            txtbcode.Text = Mid(ListView1.SelectedItems.Item(0).ToString.Trim, 16, 3)
            txtbname.Text = Mid(ListView1.FocusedItem.SubItems.Item(1).ToString, 19, CInt(ListView1.FocusedItem.SubItems.Item(1).ToString.Trim.Length) - 19)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            ListView1.Items.Clear()
            Search_bedryf()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchName.TextChanged
        Try
            ListView1.Items.Clear()
            Search_bedryf()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Search_bedryf()
        Try
            ListView1.Items.Clear()
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            If txtBranchCode.Text.Trim.Length > 0 And txtBranchName.Text.Trim.Length > 0 And txtregion.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "  where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "  where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "  where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "  where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")

                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "  where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                End If

            ElseIf txtBranchCode.Text.Trim.Length > 0 And txtBranchName.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%'")

                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'" + "and bedrnm like '" + txtBranchName.Text.Trim + "%'")
                End If

            ElseIf txtBranchCode.Text.Trim.Length > 0 And txtregion.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                End If

            ElseIf txtBranchName.Text.Trim.Length > 0 And txtregion.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and class_03 like '" + txtregion.Text.Trim + "%'")
                End If

            ElseIf txtBranchCode.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnr like '" + txtBranchCode.Text.Trim + "%'")
                End If

            ElseIf txtBranchName.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%'")
                ElseIf UCase(sDB) + "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where bedrnm like '" + txtBranchName.Text.Trim + "%'")
                End If

            ElseIf txtregion.Text.Trim.Length > 0 Then
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where class_03 like '" + txtregion.Text.Trim + "%' and Class_03 not like '%SHOWROOMS%' and Class_03 not like '%HO%'")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where class_03 like '" + txtregion.Text.Trim + "%'")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " where class_03 like '" + txtregion.Text.Trim + "%'")
                End If
            Else
                If UCase(sDB) = "LUZON" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " ")
                ElseIf UCase(sDB) = "VISMIN" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " ")
                ElseIf UCase(sDB) = "SHOWROOM" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " ")
                ElseIf UCase(sDB) = "MINDANAO" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & " ")
                ElseIf UCase(sDB) = "LNCR" Then
                    objclass.Command5("Select * from REMS.dbo.vw_bedryf" & sDB & "")
                End If

            End If
            dr = objclass.OpenDataReader5
            While dr.Read
                ListView1.Items.Add(UCase(Trim(dr.Item("bedrnr"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Trim(dr.Item("bedrnm"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(Trim(dr.Item("class_03"))))
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRegion.SelectedIndexChanged
        Try
            txtregion.Text = cboRegion.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Me.SetDesktopLocation(495, 85)
            objclass.ConnDb()
            objclass.Open5()
            If UCase(sDB) = "LUZON" Then
                objclass.Command5("Select distinct class_03 from REMS.dbo.vw_bedryf" & sDB & " where class_03 not like '%Showroom%'")
            ElseIf UCase(sDB) = "VISMIN" Then
                objclass.Command5("Select distinct class_03 from REMS.dbo.vw_bedryf" & sDB & " where class_03 not like '%Showroom%'")
            ElseIf UCase(sDB) = "SHOWROOM" Then
                objclass.Command5("Select distinct class_03 from REMS.dbo.vw_bedryf" & sDB & "")
            ElseIf UCase(sDB) = "MINDANAO" Then
                objclass.Command5("Select distinct class_03 from REMS.dbo.vw_bedryf" & sDB & "")
            ElseIf UCase(sDB) = "LNCR" Then
                objclass.Command5("Select distinct class_03 from REMS.dbo.vw_bedryf" & sDB & "")
            End If

            dr = objclass.OpenDataReader5
            While dr.Read
                cboRegion.Items.Add(UCase(dr.Item("class_03")))
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtregion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtregion.TextChanged
        Try
            ListView1.Items.Clear()
            Search_bedryf()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
