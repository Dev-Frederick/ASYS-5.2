Imports System.Data.SqlClient
Public Class frmBarcodeHistory
    Inherits System.Windows.Forms.Form
    Private strfileOnRecord As String
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblitemdesc As System.Windows.Forms.Label
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblcarat As System.Windows.Forms.Label
    Friend WithEvents lblkarat As System.Windows.Forms.Label
    Friend WithEvents lblwt As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pbBarcodePic As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSerialNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBarcodeHistory))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblitemdesc = New System.Windows.Forms.Label
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblprice = New System.Windows.Forms.Label
        Me.lblcarat = New System.Windows.Forms.Label
        Me.lblkarat = New System.Windows.Forms.Label
        Me.lblwt = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.pbBarcodePic = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSerialNo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A.L.L. BARCODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 16)
        Me.TextBox1.MaxLength = 17
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader11})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView1.Location = New System.Drawing.Point(8, 136)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(584, 328)
        Me.ListView1.TabIndex = 2
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "              DATE"
        Me.ColumnHeader2.Width = 123
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "LOT NO.       "
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "        STATUS"
        Me.ColumnHeader3.Width = 98
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "COST CENTER"
        Me.ColumnHeader4.Width = 89
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "                   EMPLOYEE"
        Me.ColumnHeader11.Width = 173
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(426, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CLEAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(512, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DESCRIPTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "WEIGHT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "QTY"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRICE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "GOLD KARAT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(336, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 24)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "STONE CARAT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblitemdesc
        '
        Me.lblitemdesc.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblitemdesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblitemdesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblitemdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitemdesc.Location = New System.Drawing.Point(96, 40)
        Me.lblitemdesc.Name = "lblitemdesc"
        Me.lblitemdesc.Size = New System.Drawing.Size(336, 24)
        Me.lblitemdesc.TabIndex = 11
        Me.lblitemdesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblqty
        '
        Me.lblqty.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblqty.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(40, 104)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 24)
        Me.lblqty.TabIndex = 12
        Me.lblqty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprice.Location = New System.Drawing.Point(512, 104)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(80, 24)
        Me.lblprice.TabIndex = 13
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcarat
        '
        Me.lblcarat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcarat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcarat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblcarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarat.Location = New System.Drawing.Point(416, 104)
        Me.lblcarat.Name = "lblcarat"
        Me.lblcarat.Size = New System.Drawing.Size(48, 24)
        Me.lblcarat.TabIndex = 14
        Me.lblcarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblkarat
        '
        Me.lblkarat.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblkarat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblkarat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblkarat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkarat.Location = New System.Drawing.Point(280, 104)
        Me.lblkarat.Name = "lblkarat"
        Me.lblkarat.Size = New System.Drawing.Size(48, 24)
        Me.lblkarat.TabIndex = 15
        Me.lblkarat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblwt
        '
        Me.lblwt.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblwt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblwt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwt.Location = New System.Drawing.Point(136, 104)
        Me.lblwt.Name = "lblwt"
        Me.lblwt.Size = New System.Drawing.Size(56, 24)
        Me.lblwt.TabIndex = 16
        Me.lblwt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(328, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 20)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "VIEW"
        Me.Button3.Visible = False
        '
        'ListView2
        '
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(8, 136)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(584, 72)
        Me.ListView2.TabIndex = 18
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "OLD A.L.L. BARCODE"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ITEM CODE"
        Me.ColumnHeader6.Width = 71
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "                  DESCRIPTION"
        Me.ColumnHeader7.Width = 205
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "WEIGHT"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 56
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "KARAT"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 49
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "COST       "
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 88
        '
        'pbBarcodePic
        '
        Me.pbBarcodePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbBarcodePic.Location = New System.Drawing.Point(464, 8)
        Me.pbBarcodePic.Name = "pbBarcodePic"
        Me.pbBarcodePic.Size = New System.Drawing.Size(104, 80)
        Me.pbBarcodePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBarcodePic.TabIndex = 19
        Me.pbBarcodePic.TabStop = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 24)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "SERIAL NO."
        '
        'lblSerialNo
        '
        Me.lblSerialNo.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSerialNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSerialNo.Location = New System.Drawing.Point(96, 72)
        Me.lblSerialNo.Name = "lblSerialNo"
        Me.lblSerialNo.ReadOnly = True
        Me.lblSerialNo.Size = New System.Drawing.Size(232, 20)
        Me.lblSerialNo.TabIndex = 21
        Me.lblSerialNo.Text = ""
        '
        'frmBarcodeHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 528)
        Me.Controls.Add(Me.lblSerialNo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pbBarcodePic)
        Me.Controls.Add(Me.lblwt)
        Me.Controls.Add(Me.lblkarat)
        Me.Controls.Add(Me.lblcarat)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.lblitemdesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(584, 520)
        Me.Name = "frmBarcodeHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BARCODE HISTORY"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            TextBox1.Text = ""
            lblitemdesc.Text = ""
            lblqty.Text = ""
            lblwt.Text = ""
            lblkarat.Text = ""
            lblcarat.Text = ""
            lblprice.Text = ""
            lblSerialNo.Text = "" '''''gm 201218
            ListView1.Items.Clear()
            TextBox1.Focus()
            ListView2.Visible = False
            pbBarcodePic.Image = Nothing
            ListView1.SetBounds(8, 136, 584, 312)

        Catch ex As Exception
            MsgBox("frmBarcodeHistory/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function GetBarcodePhoto(ByVal barcode As String) As Boolean
        Dim obj As New clsCommon
        Dim dr As SqlDataReader
        Dim img As Drawing.Image

        Try
            GetBarcodePhoto = False

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            obj.Command3("select top 1 photoname from ASYS_REM_Detail where refallbarcode = '" & Me.TextBox1.Text & "' union all select top 1 photoname from ASYS_REMoutsource_Detail where refallbarcode = '" & Me.TextBox1.Text & "'")
            dr = obj.OpenDataReader3
            If dr.Read Then
                If obj.IsNull(dr.Item("photoname")) = "0" Then
                    pbBarcodePic.Show()
                    pbBarcodePic.Image = img.FromFile(Application.StartupPath & "\questionmark2.JPG")
                    MsgBox("Barcode has no photo", MsgBoxStyle.Information, TitleMsgBox)
                Else
                    pbBarcodePic.Show()
                    pbBarcodePic.Image = img.FromFile(dr.Item("photoname"))
                    GetBarcodePhoto = True
                End If
            Else
                MsgBox("Barcode doesn't exist!", MsgBoxStyle.Information, TitleMsgBox)
            End If
            dr.Close()
            obj.Close3()

        Catch ex As Exception
            pbBarcodePic = Nothing
            dr.Close()
            obj.Close3()
            MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim ifbarcodeexist As Boolean

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If TextBox1.Text.Length < 17 And TextBox1.Text.Length <> 0 Then
                    MsgBox("Barcode must be 17 digits.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox1.Focus()
                End If
                If TextBox1.Text = "" Then
                    MsgBox("Pls. supply a 17 digit A.L.L Barcode!", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox1.Focus()
                End If
            End If
            If e.KeyChar = ChrW(13) And Me.TextBox1.Text.Length = 17 Then


                ifbarcodeexist = False

                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()

                obj.Command3("select top 1 description,karat,carat,weight,SerialNo,price,cost from ASYS_BarcodeHistory where refallbarcode = '" & Me.TextBox1.Text & "' order by trandate desc ")
                dr = obj.OpenDataReader3
                If dr.Read Then

                    lblitemdesc.Text = obj.IsNull(dr.Item("description"))
                    lblqty.Text = obj.IsNull("1")
                    lblwt.Text = FormatNumber(obj.IsNull(dr.Item("weight")), 1)
                    lblkarat.Text = obj.IsNull(dr.Item("karat"))
                    lblcarat.Text = obj.IsNull(dr.Item("carat"))
                    lblSerialNo.Text = obj.IsNull(dr.Item("SerialNo"))
                    lblprice.Text = FormatNumber(obj.IsNull(dr.Item("price")))

                    ifbarcodeexist = True

                Else
                    MsgBox("Barcode doesn't exist!", MsgBoxStyle.Information, TitleMsgBox)
                    Me.Button3.Enabled = True
                    Me.Button3.Focus()
                    Exit Sub
                End If
                dr.Close()
                'obj.Execute3()
                obj.Close3()

                ' ListView2.Visible = True
                ListView1.SetBounds(8, 136, 584, 312)
                ListView2.Items.Clear()
                ListView1.Items.Clear()
                obj.Command3("Select lotno,trandate,costcenter,consignto,status,empname,custodian from ASYS_BarcodeHistory where refallbarcode = '" & TextBox1.Text & "' order by trandate desc")
                dr = obj.OpenDataReader3
                While dr.Read
                    ListView1.Items.Add(Format(obj.IsNull(dr.Item("trandate")), "General DATE"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(obj.IsNull(dr.Item("lotno")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("status"))
                    If Trim(dr.Item("status")) = "CONSIGNED" Then
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(obj.IsNull(dr.Item("consignto"))))
                    Else
                        ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(obj.IsNull(dr.Item("costcenter"))))
                    End If
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(UCase(obj.IsNull(dr.Item("empname"))))

                End While
                Me.Button3.Enabled = True
                dr.Close()
                'obj.Execute3()
                obj.Close3()

                If ifbarcodeexist = True Then
                    GetBarcodePhoto(TextBox1.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox("frmBarcodeHistory/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            ListView2.Visible = True
            ListView1.SetBounds(8, 176, 584, 248)
            ListView2.Items.Clear()
            obj.Connectionstring3()
            obj.Open3()
            'obj.Command3("Select allbarcode,itemcode,description,weight,karat,cost from ASYS_BarcodeHistory where refallbarcode='" & Me.TextBox1.Text & "' order by trandate desc")
            obj.Command3("Select receivedate,allbarcode,itemcode,branchitemdesc,weight,karatgrading,SerialNo,all_cost from (Select receivedate,allbarcode,itemcode,branchitemdesc,weight,karatgrading,SerialNo,all_cost from ASYS_REM_detail where refallbarcode='" & Me.TextBox1.Text & "' union all Select receivedate,allbarcode,itemcode,branchitemdesc,weight,karatgrading,SerialNo,all_cost from ASYS_REMoutsource_detail where refallbarcode='" & Me.TextBox1.Text & "')a order by receivedate desc")
            dr = obj.OpenDataReader3
            If dr.Read = True Then
                ListView2.Items.Add(dr.Item("allbarcode"))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("itemcode"))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("branchitemdesc"))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("weight"))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("karatgrading"))
                'ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("SerialNo"))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(obj.IsNull(dr.Item("all_cost"))))
            End If
            dr.Close()
            'obj.Execute3()
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("frmBarcodeHistory/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmBarcodeHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Button3.Visible = True
            Me.Button1.Enabled = False
        Catch ex As Exception
            MsgBox("frmBarcodeHistory/frmBarcodeHistory_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If TextBox1.Text <> "" Then
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmBarcodeHistory/TextBox1_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBarcodePic.Click
        Try
            Dim frm As New frmPhotoZoom
            frm.photoname(photodes & TextBox1.Text & ".JPG")
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmPhotoMover/picturebox11_click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    

End Class
