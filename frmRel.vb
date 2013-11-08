Imports System.Data.SqlClient
Public Class frmRel
    Inherits System.Windows.Forms.Form
    Dim comp1 As Integer
#Region " private declaration "

    Private sUserID, sAction As String()
    Private objclass As clsCommon

#End Region
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
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSorterName As System.Windows.Forms.Label
    Friend WithEvents lblSorterIDNo As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbname As System.Windows.Forms.TextBox
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents lblpack As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnVPPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRel))
        Me.Label18 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblSorterName = New System.Windows.Forms.Label
        Me.lblSorterIDNo = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtbname = New System.Windows.Forms.TextBox
        Me.lblqty = New System.Windows.Forms.Label
        Me.lblpack = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.btnVPPrint = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(104, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 23)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Sorter:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.Location = New System.Drawing.Point(416, 56)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(168, 24)
        Me.ComboBox4.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(328, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 23)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Action:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(608, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Release"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView2
        '
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader12, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader18, Me.ColumnHeader3})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.Location = New System.Drawing.Point(8, 104)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(840, 248)
        Me.ListView2.TabIndex = 42
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "No."
        Me.ColumnHeader13.Width = 30
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "PTN"
        Me.ColumnHeader12.Width = 106
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Item Code"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 74
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Description"
        Me.ColumnHeader5.Width = 184
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "QTY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 53
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Karat"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 52
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Carat"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 51
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sorting Class"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 93
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Weight"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 66
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Loan Value"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 130
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "A.L.L. Value"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader18.Width = 50
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 50
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Items:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(768, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Close"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchCode.Location = New System.Drawing.Point(416, 32)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(40, 20)
        Me.txtBranchCode.TabIndex = 37
        Me.txtBranchCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Branch Code:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSorterName
        '
        Me.lblSorterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSorterName.Location = New System.Drawing.Point(304, 8)
        Me.lblSorterName.Name = "lblSorterName"
        Me.lblSorterName.Size = New System.Drawing.Size(200, 20)
        Me.lblSorterName.TabIndex = 51
        Me.lblSorterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSorterIDNo
        '
        Me.lblSorterIDNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSorterIDNo.Location = New System.Drawing.Point(200, 8)
        Me.lblSorterIDNo.Name = "lblSorterIDNo"
        Me.lblSorterIDNo.Size = New System.Drawing.Size(100, 20)
        Me.lblSorterIDNo.TabIndex = 111
        Me.lblSorterIDNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(200, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(120, 21)
        Me.ComboBox1.TabIndex = 112
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Location = New System.Drawing.Point(200, 56)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox2.TabIndex = 113
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Habwa Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Year:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 32)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "No. of Quantity:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(160, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Total Packs:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtbname
        '
        Me.txtbname.BackColor = System.Drawing.Color.White
        Me.txtbname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbname.ForeColor = System.Drawing.Color.Black
        Me.txtbname.Location = New System.Drawing.Point(464, 32)
        Me.txtbname.Name = "txtbname"
        Me.txtbname.ReadOnly = True
        Me.txtbname.Size = New System.Drawing.Size(200, 20)
        Me.txtbname.TabIndex = 120
        Me.txtbname.Text = ""
        '
        'lblqty
        '
        Me.lblqty.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblqty.ForeColor = System.Drawing.Color.Black
        Me.lblqty.Location = New System.Drawing.Point(112, 384)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(40, 16)
        Me.lblqty.TabIndex = 121
        Me.lblqty.Text = "0"
        '
        'lblpack
        '
        Me.lblpack.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpack.ForeColor = System.Drawing.Color.Black
        Me.lblpack.Location = New System.Drawing.Point(240, 384)
        Me.lblpack.Name = "lblpack"
        Me.lblpack.Size = New System.Drawing.Size(40, 16)
        Me.lblpack.TabIndex = 122
        Me.lblpack.Text = "0"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader1})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(312, 144)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(184, 160)
        Me.ListView1.TabIndex = 123
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "no"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ptn"
        Me.ColumnHeader1.Width = 127
        '
        'btnVPPrint
        '
        Me.btnVPPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVPPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVPPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVPPrint.Image = CType(resources.GetObject("btnVPPrint.Image"), System.Drawing.Image)
        Me.btnVPPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVPPrint.Location = New System.Drawing.Point(688, 376)
        Me.btnVPPrint.Name = "btnVPPrint"
        Me.btnVPPrint.Size = New System.Drawing.Size(80, 40)
        Me.btnVPPrint.TabIndex = 124
        Me.btnVPPrint.Text = "Print"
        Me.btnVPPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmRel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(854, 474)
        Me.Controls.Add(Me.btnVPPrint)
        Me.Controls.Add(Me.lblpack)
        Me.Controls.Add(Me.lblqty)
        Me.Controls.Add(Me.txtbname)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblSorterIDNo)
        Me.Controls.Add(Me.lblSorterName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(864, 510)
        Me.MinimumSize = New System.Drawing.Size(864, 510)
        Me.Name = "frmRel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REM Jewelry Releasing"
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " private sub "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim i As Integer
            lblSorterIDNo.Text = idnumber
            lblSorterName.Text = UCase(fullname)
            Me.txtbname.Enabled = True
            Me.txtbname.ReadOnly = True
            Me.txtbname.BackColor = Color.White
            Call RetrieveAction()
            Call genyear()
            Me.ComboBox1.Text = CStr(MonthName(Now.Month))
            Me.ComboBox2.Text = Now.Year
            Me.Button1.Enabled = False
            Me.ComboBox4.Text = "Jewelry"
        Catch ex As Exception
        End Try
    End Sub
    'retrieves action class
    Private Sub RetrieveAction()
        Try
            objclass = New clsCommon
            Dim dr As SqlDataReader
            Dim i As Double
            Dim sQuery As String

            sQuery = "select action_id,action_type from tbl_action where action_id not in (1,2,7,12)"

            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command(sQuery)
            dr = objclass.OpenDataReader
            i = 0
            ComboBox4.Items.Clear()
            ComboBox4.Text = ""
            While dr.Read
                ReDim Preserve sAction(i)
                ComboBox4.Items.Add(Trim(UCase(dr.Item("action_type"))))
                sAction(i) = Trim(dr.Item("action_id"))
                i = i + 1
            End While
            dr.Close()
            objclass.CloseDataReader()
            objclass.Close()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region " control attributes "

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        objclass = New clsCommon
        Dim i, iCnt As Integer

        If ComboBox4.Text = "" Then
            MsgBox("Select action.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Select Month.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            MsgBox("Select Year.", MsgBoxStyle.Information)
            Exit Sub
        End If
        ListView2.Focus()
       
        If MsgBox("Are you sure you want to release the listed items?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Try
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Opentracker()
                objclass.CreateCom()
                datereceived()
                If ListView2.FocusedItem.Selected = True Then

                    If ComboBox4.Text = "GoodStock" Or ComboBox4.Text = "Watch" Or ComboBox4.Text = "Cellular" Then
                        objclass.commandTrack("update ASYS_REM_Detail  set status_id ='PLUKAT',  releaser = '" + lblSorterName.Text.Trim + "', releasedate = getdate() where refallbarcode = '" & Trim(ListView2.FocusedItem.SubItems.Item(2).Text) & "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(15).Text + "'")
                        objclass.TrackExecute()
                        objclass.commandTrack("update REMS.dbo.ASYS_REM_Detail  set status_id ='PLUKAT',  releaser = '" + lblSorterName.Text.Trim + "', releasedate = getdate() where refallbarcode = '" & Trim(ListView2.FocusedItem.SubItems.Item(2).Text) & "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(15).Text + "'")
                        objclass.TrackExecute()
                    Else
                        objclass.commandTrack("update ASYS_REM_Detail  set status ='RELEASED',  releaser = '" + lblSorterName.Text.Trim + "', releasedate = getdate() where ptn = '" + ListView2.FocusedItem.SubItems.Item(1).Text + "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(15).Text + "'")
                        objclass.TrackExecute()
                        objclass.commandTrack("update REMS.dbo.ASYS_REM_Detail  set status ='RELEASED',  releaser = '" + lblSorterName.Text.Trim + "', releasedate = getdate() where ptn = '" + ListView2.FocusedItem.SubItems.Item(1).Text + "' and  itemid = '" + ListView2.FocusedItem.SubItems.Item(15).Text + "'")
                        objclass.TrackExecute()
                        'asys 3.0
                        'objclass.commandTrack("update Asys_REM_detail set status = 'SORTED', sortername = '" & userLog & "', sortdate = getdate(), actionclass = 'MissingItem' where exists (select * from asys_rem_header where ptn = asys_rem_detail.ptn and  branchcode = '" & Me.txtBranchCode.Text & "' and status = 'RECEIVED')")
                        objclass.commandTrack("update Asys_REM_detail set status = 'SORTED', sortername = '" & userLog & "', sortdate = getdate(), actionclass = 'MissingItem', sortcode = 'O' where exists (select * from asys_rem_header where ptn = asys_rem_detail.ptn and branchcode = '" & Me.txtBranchCode.Text & "' and status = 'RECEIVED') and month(receivedate) = '" & comp1 & "' and year(receivedate) = '" & Me.ComboBox2.Text & "'")
                        objclass.TrackExecute()
                    End If

                    objclass.CommitTrack()
                    MsgBox("PTN " + CStr(ListView2.FocusedItem.SubItems.Item(1).Text) + " successfully released.", MsgBoxStyle.Information)
                    ListView2.FocusedItem.Remove()
                Else
                    iCnt = ListView2.Items.Count
                    For i = 0 To ListView2.Items.Count - 1
                        objclass.commandTrack("update ASYS_REM_Detail  set status ='RELEASED', releaser = '" + Trim(userLog) + "', releasedate = getdate() where ptn = '" + ListView2.Items(i).SubItems(1).Text + "' and  itemid = '" + ListView2.Items(i).SubItems(15).Text + "'")
                        objclass.TrackExecute()
                        objclass.commandTrack("update REMS.dbo.ASYS_REM_Detail  set status ='RELEASED', releaser = '" + Trim(userLog) + "', releasedate = getdate() where ptn = '" + ListView2.Items(i).SubItems(1).Text + "' and  itemid = '" + ListView2.Items(i).SubItems(15).Text + "'")
                        objclass.TrackExecute()
                    Next
                    'asys 3.0
                    objclass.commandTrack("update Asys_REM_detail set status = 'SORTED', sortername = '" & userLog & "', sortdate = getdate(), actionclass = 'MissingItem', sortcode = 'O' where exists (select * from asys_rem_header where ptn = asys_rem_detail.ptn and branchcode = '" & Me.txtBranchCode.Text & "' and status = 'RECEIVED') and month(receivedate) = '" & comp1 & "' and year(receivedate) = '" & Me.ComboBox2.Text & "'")
                    objclass.TrackExecute()

                    objclass.CommitTrack()
                    'MsgBox(CStr(ListView2.Items.Count) + " item(s) released.", MsgBoxStyle.Information)
                    MsgBox(Me.lblqty.Text + " item(s) released.", MsgBoxStyle.Information)
                    lblqty.Text = "0"
                    lblpack.Text = "0"
                    bc = txtBranchCode.Text
                    bn = txtbname.Text
                    txtBranchCode.Text = ""
                    txtbname.Text = ""
                    Button1.Enabled = False
                    ListView2.Items.Clear()
                End If

            Catch ex As Exception
                objclass.RollBackTrack()
                MsgBox(ex.Message)
            Finally
                objclass.Close()
                objclass = Nothing
            End Try
        End If


        'lOADlISTVIEW()
    End Sub
    Private Sub lOADlISTVIEW()
        objclass = New clsCommon
        Dim dr As SqlDataReader
        Dim i, iCnt As Double
        Dim sQuery1, sQuery2, squery3 As String


        If ComboBox1.Text = "" Then
            MsgBox("Select Month.", MsgBoxStyle.Information)
            ComboBox1.Focus()
            Exit Sub
        End If

        If ComboBox2.Text = "" Then
            MsgBox("Select Year.", MsgBoxStyle.Information)
            ComboBox2.Focus()
            Exit Sub
        End If

        If txtBranchCode.Text = "" Then
            MsgBox("Enter branchcode.", MsgBoxStyle.Information)
            txtBranchCode.Focus()
            Exit Sub
        End If

        If ComboBox4.Text = "" Then
            MsgBox("Select Action Class")
            ComboBox4.Focus()
            Exit Sub
        End If

        objclass.ConnectionString1()
        objclass.Open()

        Try
            ListView2.Items.Clear()

            sQuery2 = "SELECT     dbo.ASYS_REM_Header.BranchCode, dbo.ASYS_REM_Header.BranchName, dbo.ASYS_REM_Header.PTN, dbo.ASYS_REM_Header.LoanValue,dbo.ASYS_REM_Detail.REFALLBARCODE, "
            sQuery2 = sQuery2 + " dbo.ASYS_REM_Detail.itemid,dbo.ASYS_REM_Detail.Itemcode, dbo.ASYS_REM_Detail.BranchItemDesc, dbo.ASYS_REM_Detail.Qty, dbo.ASYS_REM_Detail.KaratGrading, "
            sQuery2 = sQuery2 + " dbo.ASYS_REM_Detail.CaratSize, dbo.ASYS_REM_Detail.Weight, dbo.ASYS_REM_Detail.SortCode,dbo.ASYS_REM_Detail.ALL_Weight,dbo.ASYS_REM_Detail.ALL_KARAT, dbo.ASYS_REM_Detail.ALL_CARAT,dbo.ASYS_REM_Detail.ALL_Cost"
            sQuery2 = sQuery2 + " FROM         dbo.ASYS_REM_Detail  INNER JOIN"
            sQuery2 = sQuery2 + " dbo.ASYS_REM_Header  ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN"
            sQuery2 = sQuery2 + " WHERE     (YEAR(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox2.Text & "') AND (MONTH(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox1.SelectedIndex + 1 & "') AND (dbo.ASYS_REM_Header.BranchCode = '" & txtBranchCode.Text & "') "
            sQuery2 = sQuery2 + " AND (dbo.ASYS_REM_Detail.Status = 'SORTED') AND (dbo.ASYS_REM_Detail.actionclass = '" & ComboBox4.Text & "')"

            objclass.Command(sQuery2)
            dr = objclass.OpenDataReader()
            While dr.Read

                ListView2.Items.Add(ListView2.Items.Count + 1)
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ptn"))))
                If UCase(ComboBox4.Text) = "GOODSTOCK" Or UCase(ComboBox4.Text) = "CELLULAR" Or UCase(ComboBox4.Text) = "WATCH" Then
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("REFALLBARCODE"))))
                Else
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
                End If


                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("KaratGrading"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("CaratSize"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Sortcode"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Weight"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("loanvalue"))))
                ListView2.Columns(10).Width = 100
                ListView2.Columns(11).Width = 100
                ListView2.Columns(12).Width = 100
                ListView2.Columns(13).Width = 100
                ListView2.Columns(14).Width = 100
                ListView2.Columns(10).Text = "A.L.L Weight"
                ListView2.Columns(11).Text = "A.L.L Karat"
                ListView2.Columns(12).Width = 0
                ListView2.Columns(13).Width = 0
                ListView2.Columns(14).Text = "A.L.L. Value"
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_wEIGHt"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_karat"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))
                ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("itemid"))
            End While
            '  Me.lblqty.Text = ListView2.Items.Count
            objclass.CloseDataReader()
            objclass.Close()
            '----------------for total number of packs 10162009
            objclass.ConnectionString1()
            objclass.Open()
            ListView1.Items.Clear()

            squery3 = "select count(ptn) as noofpacks"
            squery3 = squery3 + " from ( SELECT  dbo.ASYS_REM_Detail.ptn"
            squery3 = squery3 + " FROM         dbo.ASYS_REM_Detail  INNER JOIN"
            squery3 = squery3 + " dbo.ASYS_REM_Header  ON dbo.ASYS_REM_Detail.PTN = dbo.ASYS_REM_Header.PTN"
            squery3 = squery3 + " WHERE     (YEAR(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox2.Text & "') AND (MONTH(dbo.ASYS_REM_Detail.SortDate) = '" & ComboBox1.SelectedIndex + 1 & "') AND (dbo.ASYS_REM_Header.BranchCode = '" & txtBranchCode.Text & "') "
            squery3 = squery3 + " AND (dbo.ASYS_REM_Detail.Status = 'SORTED')"
            squery3 = squery3 + " AND (dbo.ASYS_REM_Detail.actionclass = '" & ComboBox4.Text & "')"
            squery3 = squery3 + " group by dbo.ASYS_REM_Detail.ptn)a"

            objclass.Command(squery3)
            dr = objclass.OpenDataReader()
            If dr.Read Then
                Me.lblpack.Text = dr.Item("Noofpacks")
            End If
            dr.Close()
            objclass.CloseDataReader()

            Dim u, tempa, s As Integer


            If Me.ListView2.Items.Count > 0 Then
                For u = 1 To ListView2.Items.Count
                    If ListView2.Items(u - 1).SubItems.Item(4).Text = "" Then
                        Me.lblqty.Text = tempa
                    Else
                        s = ListView2.Items(u - 1).SubItems.Item(4).Text
                        tempa = tempa + s
                    End If
                Next
            End If

            Me.lblqty.Text = tempa

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dr.Close()
        objclass.CloseDataReader()
        objclass.Close()
        objclass = Nothing

        If ListView2.Items.Count > 0 Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

#End Region
#Region " private function "

    'validates data, if null returns a 0 else returns number
    Private Function IsNull_Value(ByVal odata As Object) As Double
        If IsDBNull(odata) Then
            Return "0"
        Else
            Return CDbl(odata)
        End If
    End Function

#End Region
    Private Sub ComboBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox4.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                objclass = New clsCommon
                Dim dr As SqlDataReader
                Dim i, iCnt As Double
                Dim sQuery1, sQuery2, squery3 As String


                If ComboBox1.Text = "" Then
                    MsgBox("Select Month.", MsgBoxStyle.Information)
                    ComboBox1.Focus()
                    Exit Sub
                End If

                If ComboBox2.Text = "" Then
                    MsgBox("Select Year.", MsgBoxStyle.Information)
                    ComboBox2.Focus()
                    Exit Sub
                End If

                If txtBranchCode.Text = "" Then
                    MsgBox("Enter branchcode.", MsgBoxStyle.Information)
                    txtBranchCode.Focus()
                    Exit Sub
                End If

                If ComboBox4.Text = "" Then
                    MsgBox("Select Action Class")
                    ComboBox4.Focus()
                    Exit Sub
                End If

                objclass.ConnectionString1()
                objclass.Open()

                ListView2.Items.Clear()

                sQuery2 = "SELECT   distinct  rems" & sDB & ".dbo.ASYS_REM_Header.BranchCode, rems" & sDB & ".dbo.ASYS_REM_Header.BranchName, rems" & sDB & ".dbo.ASYS_REM_Header.PTN, rems" & sDB & ".dbo.ASYS_REM_Header.LoanValue,rems" & sDB & ".dbo.ASYS_REM_Detail.REFALLBARCODE, "
                sQuery2 = sQuery2 + " rems" & sDB & ".dbo.ASYS_REM_Detail.itemid, rems" & sDB & ".dbo.ASYS_REM_Detail.Itemcode, rems" & sDB & ".dbo.ASYS_REM_Detail.BranchItemDesc, rems" & sDB & ".dbo.ASYS_REM_Detail.Qty, rems" & sDB & ".dbo.ASYS_REM_Detail.KaratGrading, "
                sQuery2 = sQuery2 + " rems" & sDB & ".dbo.ASYS_REM_Detail.CaratSize, rems" & sDB & ".dbo.ASYS_REM_Detail.Weight, rems" & sDB & ".dbo.ASYS_REM_Detail.SortCode,rems" & sDB & ".dbo.ASYS_REM_Detail.ALL_Weight,rems" & sDB & ".dbo.ASYS_REM_Detail.ALL_KARAT, rems" & sDB & ".dbo.ASYS_REM_Detail.ALL_CARAT,rems" & sDB & ".dbo.ASYS_REM_Detail.ALL_Cost"
                sQuery2 = sQuery2 + " FROM rems" & sDB & ".dbo.ASYS_REM_Detail INNER JOIN"
                sQuery2 = sQuery2 + " rems" & sDB & ".dbo.ASYS_REM_Header ON rems" & sDB & ".dbo.ASYS_REM_Detail.PTN = rems" & sDB & ".dbo.ASYS_REM_Header.PTN"
                sQuery2 = sQuery2 + " WHERE     (YEAR(rems" & sDB & ".dbo.ASYS_REM_Detail.Receivedate) = '" & ComboBox2.Text & "') AND (MONTH(rems" & sDB & ".dbo.ASYS_REM_Detail.Receivedate) = '" & ComboBox1.SelectedIndex + 1 & "') AND (rems" & sDB & ".dbo.ASYS_REM_Header.BranchCode = '" & txtBranchCode.Text & "') "
                sQuery2 = sQuery2 + " AND (rems" & sDB & ".dbo.ASYS_REM_Detail.Status = 'SORTED') AND (rems" & sDB & ".dbo.ASYS_REM_Detail.actionclass = '" & ComboBox4.SelectedItem & "')"

                objclass.Command(sQuery2)
                dr = objclass.OpenDataReader()
                While dr.Read

                    ListView2.Items.Add(ListView2.Items.Count + 1)
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ptn"))))
                    If UCase(ComboBox4.Text) = "GOODSTOCK" Or UCase(ComboBox4.Text) = "CELLULAR" Or UCase(ComboBox4.Text) = "WATCH" Then
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("REFALLBARCODE"))))
                    Else
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ItemCode"))))
                    End If

                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("branchitemdesc"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("qty"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_carat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("Sortcode"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("all_weight"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(objclass.IsNull(dr.Item("loanvalue"))))
                    ListView2.Columns(10).Width = 100
                    ListView2.Columns(11).Width = 100
                    ListView2.Columns(12).Width = 100
                    ListView2.Columns(13).Width = 100
                    ListView2.Columns(14).Width = 100
                    ListView2.Columns(10).Text = "A.L.L Weight"
                    ListView2.Columns(11).Text = "A.L.L Karat"
                    ListView2.Columns(12).Width = 0
                    ListView2.Columns(13).Width = 0
                    ListView2.Columns(14).Text = "A.L.L. Value"
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_wEIGHt"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_karat"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("")
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(FormatNumber(IsNull_Value(dr.Item("all_cost"))))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("itemid"))
                End While
                '  Me.lblqty.Text = ListView2.Items.Count
                dr.Close()
                objclass.Close()
                objclass = Nothing

                '----------------for total number of packs 10162009
                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                ListView1.Items.Clear()

                squery3 = "select count(ptn) as noofpacks"
                squery3 = squery3 + " from ( SELECT  rems" & sDB & ".dbo.ASYS_REM_Detail.ptn"
                squery3 = squery3 + " FROM         rems" & sDB & ".dbo.ASYS_REM_Detail  INNER JOIN"
                squery3 = squery3 + " rems" & sDB & ".dbo.ASYS_REM_Header  ON rems" & sDB & ".dbo.ASYS_REM_Detail.PTN = rems" & sDB & ".dbo.ASYS_REM_Header.PTN"
                squery3 = squery3 + " WHERE     (YEAR(rems" & sDB & ".dbo.ASYS_REM_Detail.receivedate) = '" & ComboBox2.Text & "') AND (MONTH(rems" & sDB & ".dbo.ASYS_REM_Detail.receivedate) = '" & ComboBox1.SelectedIndex + 1 & "') AND (rems" & sDB & ".dbo.ASYS_REM_Header.BranchCode = '" & txtBranchCode.Text & "') "
                squery3 = squery3 + " AND (rems" & sDB & ".dbo.ASYS_REM_Detail.Status = 'SORTED')"
                squery3 = squery3 + " AND (rems" & sDB & ".dbo.ASYS_REM_Detail.actionclass = '" & ComboBox4.Text & "')"
                squery3 = squery3 + " group by rems" & sDB & ".dbo.ASYS_REM_Detail.ptn)a"

                objclass.Command(squery3)
                dr = objclass.OpenDataReader()
                If dr.Read Then
                    Me.lblpack.Text = dr.Item("Noofpacks")
                End If
                dr.Close()
                objclass.Close()
                objclass = Nothing
                Dim u, tempa, s As Integer


                If Me.ListView2.Items.Count > 0 Then
                    For u = 1 To ListView2.Items.Count
                        If ListView2.Items(u - 1).SubItems.Item(4).Text = "" Then
                            Me.lblqty.Text = tempa
                        Else
                            s = ListView2.Items(u - 1).SubItems.Item(4).Text
                            tempa = tempa + s
                        End If
                    Next
                End If

                Me.lblqty.Text = tempa
                If lblqty.Text = "0" Then
                    Me.Button1.Enabled = False
                Else
                    Me.Button1.Enabled = True
                End If

                If lblqty.Text = "0" Then
                    MsgBox("No data to release")
                End If
                If ListView2.Items.Count > 0 Then
                    Button1.Enabled = True
                    Button1.Focus()
                Else
                    Button1.Enabled = False
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
        Try
            objclass = New clsCommon
            Dim dr As SqlDataReader
            If e.KeyCode = Keys.Enter Then
                objclass.ConnectionString1()
                objclass.Open()
                objclass.Command("Select branchcode,branchname from ASYS_REM_Header where branchcode='" + txtBranchCode.Text + "'")
                dr = objclass.OpenDataReader
                If dr.Read = False Then
                    Msgbox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchCode.Text = ""
                    txtBranchCode.Focus()
                Else
                    ComboBox4.Focus()
                    txtbname.Text = dr.Item("branchname")
                End If
                dr.Close()
                objclass.CloseDataReader()
                objclass.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            txtbname.Text = ""
            Button1.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                ComboBox4_KeyPress(sender, e)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                ComboBox4_KeyPress(sender, e)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnVPPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVPPrint.Click
        Try
            Dim frm As New frmVPRelease_rpt
            frm.txtBranchCode.Text = bc
            frm.txtBRanchname.Text = bn
            frm.Text = "JEWELRY RELEASING REPORT"
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Public Function genyear()
        Try
            Dim i, yr As Integer
            yr = Now.Year
            For i = 1 To 5
                ComboBox2.Items.Add(yr)
                yr = yr - 1
            Next
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmRel_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Dispose(True)
    End Sub

    Private Function datereceived() As Date
        Try
            Dim smonth As String

            smonth = ComboBox1.Text
            Select Case smonth
                Case "January"
                    smonth = "1"
                Case "February"
                    smonth = "2"
                Case "March"
                    smonth = "3"
                Case "April"
                    smonth = "4"
                Case "May5"
                    smonth = "5"
                Case "June"
                    smonth = "6"
                Case "July"
                    smonth = "7"
                Case "August"
                    smonth = "8"
                Case "September"
                    smonth = "9"
                Case "October"
                    smonth = "10"
                Case "November"
                    smonth = "11"
                Case "December"
                    smonth = "12"
            End Select
            comp1 = smonth
        Catch ex As Exception

        End Try
    End Function

End Class
