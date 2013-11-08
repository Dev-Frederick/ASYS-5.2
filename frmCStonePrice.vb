Imports System.Data.SqlClient
Public Class frmCStonePrice
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCStone As System.Windows.Forms.TextBox
    Friend WithEvents txtVG As System.Windows.Forms.TextBox
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCStonePrice))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCStone = New System.Windows.Forms.TextBox
        Me.txtVG = New System.Windows.Forms.TextBox
        Me.txtG = New System.Windows.Forms.TextBox
        Me.txtP = New System.Windows.Forms.TextBox
        Me.btnChange = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 72)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(448, 144)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "COLORED STONE TYPE"
        Me.ColumnHeader1.Width = 156
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "VERY GOOD    "
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 116
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "GOOD    "
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 86
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "POOR    "
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 86
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COLORED STONE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "VERY GOOD"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "GOOD"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(312, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "POOR"
        '
        'txtCStone
        '
        Me.txtCStone.BackColor = System.Drawing.Color.White
        Me.txtCStone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCStone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCStone.Location = New System.Drawing.Point(120, 8)
        Me.txtCStone.Name = "txtCStone"
        Me.txtCStone.ReadOnly = True
        Me.txtCStone.Size = New System.Drawing.Size(328, 20)
        Me.txtCStone.TabIndex = 5
        Me.txtCStone.Text = ""
        '
        'txtVG
        '
        Me.txtVG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVG.Enabled = False
        Me.txtVG.Location = New System.Drawing.Point(120, 32)
        Me.txtVG.MaxLength = 16
        Me.txtVG.Name = "txtVG"
        Me.txtVG.Size = New System.Drawing.Size(72, 20)
        Me.txtVG.TabIndex = 6
        Me.txtVG.Text = ""
        '
        'txtG
        '
        Me.txtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtG.Enabled = False
        Me.txtG.Location = New System.Drawing.Point(232, 32)
        Me.txtG.MaxLength = 16
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(75, 20)
        Me.txtG.TabIndex = 7
        Me.txtG.Text = ""
        '
        'txtP
        '
        Me.txtP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtP.Enabled = False
        Me.txtP.Location = New System.Drawing.Point(352, 32)
        Me.txtP.MaxLength = 16
        Me.txtP.Name = "txtP"
        Me.txtP.Size = New System.Drawing.Size(96, 20)
        Me.txtP.TabIndex = 8
        Me.txtP.Text = ""
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChange.Location = New System.Drawing.Point(288, 224)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(80, 40)
        Me.btnChange.TabIndex = 11
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(368, 224)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmCStonePrice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(458, 272)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtVG)
        Me.Controls.Add(Me.txtCStone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCStonePrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE COLORED STONE PRICE"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCStonePrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadPearl_PriceItem()
    End Sub
    Private Sub LoadPearl_PriceItem()
        Try

            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            ListView1.Items.Clear()
            str = "Select id,colstone_type,colstoneverygood,colstonegood,colstonepoor from ASYS_ColStoneGuide"
            obj.Command3(str)
            dr = obj.OpenDataReader3()
            While dr.Read
                ListView1.Items.Add(dr.Item("colstone_type"))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("colstoneverygood"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("colstonegood"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(dr.Item("colstonepoor")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("id"))
            End While
            dr.Close()
            obj.Close()
        Catch ex As Exception
            MsgBox("frmPhoto/LoadGoldItem: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ClearItems()
        txtCStone.Text = ""
        txtVG.Text = ""
        txtG.Text = ""
        txtP.Text = ""
        LoadPearl_PriceItem()

        txtVG.Enabled = False
        txtG.Enabled = False
        txtP.Enabled = False
        btnChange.Enabled = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtCStone.Text = ListView1.FocusedItem.Text
        txtVG.Text = ListView1.FocusedItem.SubItems(1).Text
        txtG.Text = ListView1.FocusedItem.SubItems(2).Text
        txtP.Text = ListView1.FocusedItem.SubItems(3).Text

        txtVG.Enabled = True
        txtG.Enabled = True
        txtP.Enabled = True
        btnChange.Enabled = True
    End Sub

    Private Sub txtVG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVG.TextChanged

    End Sub

    Private Sub txtVG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVG.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtVG.Text <> "" Then
                txtVG.Text = FormatNumber(txtVG.Text)
                btnChange.Focus()
            Else
                txtVG.Focus()
            End If

        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtG.TextChanged

    End Sub

    Private Sub txtG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtG.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtG.Text <> "" Then
                txtG.Text = FormatNumber(txtG.Text)
                btnChange.Focus()
            Else
                txtG.Focus()
            End If

        End If
    End Sub

    Private Sub txtP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtP.TextChanged

    End Sub

    Private Sub txtP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtP.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtP.Text <> "" Then
                txtP.Text = FormatNumber(txtP.Text)
                btnChange.Focus()
            Else
                txtP.Focus()
            End If

        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim objclass As New clsCommon
        Dim sQuery As String
        Dim msgrep As Integer

        Try
            If txtVG.Text = "" Or txtG.Text = "" Or txtP.Text = "" Then
                MsgBox("Some fields were empty.", MsgBoxStyle.Information, TitleMsgBox)
                txtVG.Focus()
                btnChange.Enabled = False
                Exit Sub
            Else
                msgrep = MsgBox("Are you sure you want to change the price?", MsgBoxStyle.YesNo, TitleMsgBox)
                If msgrep = vbYes Then
                    objclass = New clsCommon
                    objclass.Connectionstring3()
                    objclass.Opentracker2()
                    objclass.CreateCom()
                    sQuery = "UPDATE ASYS_ColStoneGuide SET colstoneverygood = " & CStr(CDbl((txtVG.Text))) & ",colstonegood = " & CStr(CDbl((txtG.Text))) & ",colstonepoor = " & CStr(CDbl((txtP.Text))) & " WHERE ID = '" & ListView1.FocusedItem.SubItems(4).Text & "' AND colstone_type = '" & txtCStone.Text.Trim & "' "
                    objclass.commandTrack(sQuery)
                    objclass.TrackExecute()

                    objclass.CommitTrack()
                    objclass.Close()
                    MsgBox("Colored Stone Price was successfully change.", MsgBoxStyle.Information, TitleMsgBox)
                    ClearItems()
                Else
                    MsgBox("Changing Colored Stone Price was cancelled.", MsgBoxStyle.Information, TitleMsgBox)
                    txtVG.Focus()
                    Exit Sub
                End If
                ClearItems()
            End If

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmPhoto/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
