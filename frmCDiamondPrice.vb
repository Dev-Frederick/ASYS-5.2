Imports System.Data.SqlClient
Public Class frmDiamondPrice
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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents txtColorType As System.Windows.Forms.TextBox
    Friend WithEvents txtVS As System.Windows.Forms.TextBox
    Friend WithEvents txtSI As System.Windows.Forms.TextBox
    Friend WithEvents txtI As System.Windows.Forms.TextBox
    Friend WithEvents txtCarat2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCarat1 As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDiamondPrice))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.btnChange = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtColorType = New System.Windows.Forms.TextBox
        Me.txtVS = New System.Windows.Forms.TextBox
        Me.txtSI = New System.Windows.Forms.TextBox
        Me.txtI = New System.Windows.Forms.TextBox
        Me.txtCarat2 = New System.Windows.Forms.TextBox
        Me.txtCarat1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(584, 248)
        Me.ListView1.TabIndex = 0
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "COLOR TYPE"
        Me.ColumnHeader1.Width = 96
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "VS      "
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SI          "
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "I       "
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CARAT WT FROM"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 123
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CARAT WT TO"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 103
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ID"
        Me.ColumnHeader7.Width = 0
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Image = CType(resources.GetObject("btnChange.Image"), System.Drawing.Image)
        Me.btnChange.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChange.Location = New System.Drawing.Point(432, 344)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(80, 40)
        Me.btnChange.TabIndex = 5
        Me.btnChange.Text = "CHANGE"
        Me.btnChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(512, 344)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 40)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "COLOR TYPE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "VS"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SI"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 23)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "I"
        '
        'txtColorType
        '
        Me.txtColorType.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtColorType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColorType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtColorType.Location = New System.Drawing.Point(96, 13)
        Me.txtColorType.Name = "txtColorType"
        Me.txtColorType.ReadOnly = True
        Me.txtColorType.Size = New System.Drawing.Size(184, 20)
        Me.txtColorType.TabIndex = 11
        Me.txtColorType.Text = ""
        '
        'txtVS
        '
        Me.txtVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVS.Enabled = False
        Me.txtVS.Location = New System.Drawing.Point(312, 13)
        Me.txtVS.MaxLength = 16
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(72, 20)
        Me.txtVS.TabIndex = 12
        Me.txtVS.Text = ""
        Me.txtVS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSI
        '
        Me.txtSI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSI.Enabled = False
        Me.txtSI.Location = New System.Drawing.Point(416, 13)
        Me.txtSI.MaxLength = 16
        Me.txtSI.Name = "txtSI"
        Me.txtSI.Size = New System.Drawing.Size(72, 20)
        Me.txtSI.TabIndex = 13
        Me.txtSI.Text = ""
        Me.txtSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtI
        '
        Me.txtI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtI.Enabled = False
        Me.txtI.Location = New System.Drawing.Point(512, 13)
        Me.txtI.MaxLength = 16
        Me.txtI.Name = "txtI"
        Me.txtI.Size = New System.Drawing.Size(80, 20)
        Me.txtI.TabIndex = 14
        Me.txtI.Text = ""
        Me.txtI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCarat2
        '
        Me.txtCarat2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCarat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarat2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarat2.Location = New System.Drawing.Point(192, 40)
        Me.txtCarat2.Name = "txtCarat2"
        Me.txtCarat2.ReadOnly = True
        Me.txtCarat2.Size = New System.Drawing.Size(72, 20)
        Me.txtCarat2.TabIndex = 18
        Me.txtCarat2.Text = ""
        '
        'txtCarat1
        '
        Me.txtCarat1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCarat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCarat1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCarat1.Location = New System.Drawing.Point(96, 40)
        Me.txtCarat1.Name = "txtCarat1"
        Me.txtCarat1.ReadOnly = True
        Me.txtCarat1.Size = New System.Drawing.Size(72, 20)
        Me.txtCarat1.TabIndex = 17
        Me.txtCarat1.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CARAT"
        '
        'frmDiamondPrice
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(600, 406)
        Me.Controls.Add(Me.txtCarat2)
        Me.Controls.Add(Me.txtCarat1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtI)
        Me.Controls.Add(Me.txtSI)
        Me.Controls.Add(Me.txtVS)
        Me.Controls.Add(Me.txtColorType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDiamondPrice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE DIAMOND PRICE"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub LoadDiamond_PriceItem()
        Try


            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            ListView1.Items.Clear()
            str = "Select id,color_type,vs,si,i,carat_wt_from,carat_wt_to from ASYS_DiaPriceGuide"
            obj.Command3(str)
            dr = obj.OpenDataReader3()
            While dr.Read
                ListView1.Items.Add(dr.Item("color_Type"))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("vs"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("si"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(FormatNumber(dr.Item("i")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("carat_wt_from"))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("carat_wt_to"))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("id"))
            End While
            dr.Close()
            obj.Close()
        Catch ex As Exception
            MsgBox("frmPhoto/LoadGoldItem: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmDiamondPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDiamond_PriceItem()
    End Sub

   
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
    Private Sub ClearItems()
        txtColorType.Text = ""
        txtVS.Text = ""
        txtSI.Text = ""
        txtI.Text = ""
        txtCarat1.Text = ""
        txtCarat2.Text = ""
        LoadDiamond_PriceItem()

        txtVS.Enabled = False
        txtSI.Enabled = False
        txtI.Enabled = False
        btnChange.Enabled = False
    End Sub
    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtColorType.Text = ListView1.FocusedItem.Text
        txtVS.Text = ListView1.FocusedItem.SubItems(1).Text
        txtSI.Text = ListView1.FocusedItem.SubItems(2).Text
        txtI.Text = ListView1.FocusedItem.SubItems(3).Text
        txtCarat1.Text = ListView1.FocusedItem.SubItems(4).Text
        txtCarat2.Text = ListView1.FocusedItem.SubItems(5).Text

        txtVS.Enabled = True
        txtSI.Enabled = True
        txtI.Enabled = True
        btnChange.Enabled = True
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Dim objclass As New clsCommon
        Dim sQuery As String
        Dim msgrep As Integer

        Try
            If txtVS.Text = "" Or txtSI.Text = "" Or txtI.Text = "" Then
                MsgBox("Some fields were empty.", MsgBoxStyle.Information, TitleMsgBox)
                txtVS.Focus()
                btnChange.Enabled = False
                Exit Sub
            Else
                msgrep = MsgBox("Are you sure you want to change the price?", MsgBoxStyle.YesNo, TitleMsgBox)
                If msgrep = vbYes Then
                    objclass = New clsCommon
                    objclass.Connectionstring3()
                    objclass.Opentracker2()
                    objclass.CreateCom()
                    sQuery = "UPDATE ASYS_DiaPriceGuide SET VS = " & CStr(CDbl((txtVS.Text))) & ",SI = " & CStr(CDbl((txtSI.Text))) & ",I = " & CStr(CDbl((txtI.Text))) & " WHERE ID = '" & ListView1.FocusedItem.SubItems(6).Text & "' AND color_type = '" & txtColorType.Text.Trim & "' "
                    objclass.commandTrack(sQuery)
                    objclass.TrackExecute()

                    objclass.CommitTrack()
                    objclass.Close()
                    MsgBox("Diamond Price was successfully change.", MsgBoxStyle.Information, TitleMsgBox)
                    ClearItems()
                Else
                    MsgBox("Changing diamond price was cancelled.", MsgBoxStyle.Information, TitleMsgBox)
                    txtVS.Focus()
                    Exit Sub
                End If
                ClearItems()
            End If

        Catch ex As Exception
            objclass.RollBackTrack()
            MsgBox("frmPhoto/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtVS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVS.TextChanged

    End Sub

    Private Sub txtVS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVS.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtVS.Text <> "" Then
                txtVS.Text = FormatNumber(txtVS.Text)
                btnChange.Focus()
            Else
                txtVS.Focus()
            End If

        End If
    End Sub

    Private Sub txtSI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSI.TextChanged

    End Sub

    Private Sub txtSI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSI.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtSI.Text <> "" Then
                txtSI.Text = FormatNumber(txtSI.Text)
                btnChange.Focus()
            Else
                txtSI.Focus()
            End If

        End If
    End Sub

    Private Sub txtI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtI.TextChanged

    End Sub

    Private Sub txtI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtI.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            If txtI.Text <> "" Then
                txtI.Text = FormatNumber(txtI.Text)
                btnChange.Focus()
            Else
                txtI.Focus()
            End If

        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class


