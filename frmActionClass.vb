Imports System.Data.SqlClient
Public Class frmActionClass
    Inherits System.Windows.Forms.Form
    Private objclass As clsCommon
    Private iSelect As Integer

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmActionClass))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(568, 194)
        Me.ListView1.TabIndex = 11
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "CLASS"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "COST A"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 89
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "COST B"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 87
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "COST C"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 89
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "COST D"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 81
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "TEXTBOX1"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(236, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(60, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = "TextBox2"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(324, 33)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(60, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "TextBox3"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(412, 33)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 20)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = "TextBox4"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(500, 33)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(60, 20)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "TextBox5"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ACTION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COST A"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "COST B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "COST C"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(500, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "COST D"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageIndex = 4
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(608, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "NEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 0
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(608, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SAVE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(608, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.ImageIndex = 5
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(608, 144)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(104, -24)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(56, 20)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.Text = "TextBox6"
        Me.TextBox6.Visible = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.ImageIndex = 2
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(608, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 40)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "EDIT"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 264)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ACTION CLASS"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "%"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.ImageIndex = 1
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(608, 224)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 40)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "CLOSE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmActionClass
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(688, 293)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmActionClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTION CLASS"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " private sub "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetDesktopLocation(317, 85)
        Call retreiveActionClass()
        Call control(False)
        Call clear()
    End Sub
    'retrieves action class
    Private Sub retreiveActionClass()
        Dim dr As SqlDataReader
        Dim dCostA, dCostB, dCostC, dCostD As Double
        objclass = New clsCommon
        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("select * from tbl_action where action_id <> " + CStr(objclass.action.Release) + " order by action_type")
        dr = objclass.OpenDataReader3()
        ListView1.Items.Clear()
        While dr.Read
            ListView1.Items.Add(Trim(dr.Item("action_id")))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(UCase(dr.Item("action_type")))))
            dCostA = CDbl(objclass.IsNull(dr.Item("costa"))) * 100
            dCostB = CDbl(objclass.IsNull(dr.Item("costb"))) * 100
            dCostC = CDbl(objclass.IsNull(dr.Item("costc")))
            dCostD = CDbl(objclass.IsNull(dr.Item("costd")))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(dCostA) + "%")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(dCostB) + "%")
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(dCostC))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(CStr(dCostD))
        End While
        dr.Close()
        objclass.Close3()
        objclass = Nothing
    End Sub
    'clears textboxes
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
    'enables or disbles control
    Private Sub control(ByVal bEnable As Boolean)
        TextBox1.Enabled = bEnable
        TextBox2.Enabled = bEnable
        TextBox3.Enabled = bEnable
        TextBox4.Enabled = bEnable
        TextBox5.Enabled = bEnable
    End Sub
    'save action class to tbl_action
    Private Sub SaveAction()
        objclass = New clsCommon
        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("insert into tbl_action(action_type, CostA, CostB, CostC, CostD) Values('" + TextBox1.Text + "'," + CStr(CDbl(TextBox2.Text) / 100) + "," + CStr(CDbl(TextBox3.Text) / 100) + "," + CStr(CDbl(TextBox4.Text)) + ", " + CStr(CDbl(TextBox5.Text)) + ")")
        objclass.Execute3()
        objclass.Command3("insert into remsluzon.dbo.tbl_action(action_type, CostA, CostB, CostC, CostD) Values('" + TextBox1.Text + "'," + CStr(CDbl(TextBox2.Text) / 100) + "," + CStr(CDbl(TextBox3.Text) / 100) + "," + CStr(CDbl(TextBox4.Text)) + ", " + CStr(CDbl(TextBox5.Text)) + ")")
        objclass.Execute3()
        objclass.Command3("insert into remsvismin.dbo.tbl_action(action_type, CostA, CostB, CostC, CostD) Values('" + TextBox1.Text + "'," + CStr(CDbl(TextBox2.Text) / 100) + "," + CStr(CDbl(TextBox3.Text) / 100) + "," + CStr(CDbl(TextBox4.Text)) + ", " + CStr(CDbl(TextBox5.Text)) + ")")
        objclass.Execute3()
        objclass.Close3()
        objclass = Nothing
    End Sub
    'updates action class to tbl_action
    Private Sub EditAction()
        objclass = New clsCommon
        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("update tbl_action set action_type = '" + TextBox1.Text + "', CostA = " + CStr(CDbl(TextBox2.Text) / 100) + ", CostB = " + CStr(CDbl(TextBox3.Text) / 100) + ", CostC = " + CStr(CDbl(TextBox4.Text)) + ", CostD = " + CStr(CDbl(TextBox5.Text)) + " where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Command3("update remsvismin.dbo.tbl_action set action_type = '" + TextBox1.Text + "', CostA = " + CStr(CDbl(TextBox2.Text) / 100) + ", CostB = " + CStr(CDbl(TextBox3.Text) / 100) + ", CostC = " + CStr(CDbl(TextBox4.Text)) + ", CostD = " + CStr(CDbl(TextBox5.Text)) + " where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Command3("update remsluzon.dbo.tbl_action set action_type = '" + TextBox1.Text + "', CostA = " + CStr(CDbl(TextBox2.Text) / 100) + ", CostB = " + CStr(CDbl(TextBox3.Text) / 100) + ", CostC = " + CStr(CDbl(TextBox4.Text)) + ", CostD = " + CStr(CDbl(TextBox5.Text)) + " where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Close3()
        objclass = Nothing
    End Sub
    'deletes action class to tbl_action
    Private Sub DeleteAction()
        objclass = New clsCommon
        objclass.Connectionstring3()
        objclass.Open3()
        objclass.Command3("delete from tbl_action where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Command3("delete from remsluzon.dbo.tbl_action where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Command3("delete from remsvismin.dbo.tbl_action where action_id = " + TextBox6.Text)
        objclass.Execute3()
        objclass.Close3()
        objclass = Nothing
    End Sub

#End Region

#Region " control attributes "

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call clear()
            Call control(False)
            ListView1.Enabled = True
            ListView1.Focus()
            iSelect = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ListView1.Enabled = False
            Call clear()
            Call control(True)
            iSelect = 1
            TextBox1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox1.Text.Length <= 0 Then
                MsgBox("Nothing to delete. No record were selected", MsgBoxStyle.Exclamation, TitleMsgBox)
                Exit Sub
            End If
            Call DeleteAction()
            MsgBox("action deleted", MsgBoxStyle.Information, TitleMsgBox)

            Call clear()
            Call control(False)
            Call retreiveActionClass()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Please provide action", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
                Exit Sub
            End If
            If TextBox2.Text = "" Then
                MsgBox("Please provide Cost A", MsgBoxStyle.Information, TitleMsgBox)
                TextBox2.Focus()
                Exit Sub
            End If
            If TextBox3.Text = "" Then
                MsgBox("Please provide Cost B", MsgBoxStyle.Information, TitleMsgBox)
                TextBox3.Focus()
                Exit Sub
            End If
            If TextBox4.Text = "" Then
                MsgBox("Please provide Cost C", MsgBoxStyle.Information, TitleMsgBox)
                TextBox4.Focus()
                Exit Sub
            End If
            If TextBox5.Text = "" Then
                MsgBox("Please provide Cost D", MsgBoxStyle.Information, TitleMsgBox)
                TextBox5.Focus()
                Exit Sub
            End If

            If Not IsNumeric(TextBox2.Text) Then
                MsgBox("Please enter numeric in Cost A", MsgBoxStyle.Information, TitleMsgBox)
                TextBox2.Focus()
                Exit Sub
            End If
            If Not IsNumeric(TextBox3.Text) Then
                MsgBox("Please enter numeric in Cost B", MsgBoxStyle.Information, TitleMsgBox)
                TextBox3.Focus()
                Exit Sub
            End If
            If Not IsNumeric(TextBox4.Text) Then
                MsgBox("Please enter numeric in Cost C", MsgBoxStyle.Information, TitleMsgBox)
                TextBox4.Focus()
                Exit Sub
            End If
            If Not IsNumeric(TextBox5.Text) Then
                MsgBox("Please enter numeric in Cost D", MsgBoxStyle.Information, TitleMsgBox)
                TextBox5.Focus()
                Exit Sub
            End If
            ListView1.Enabled = True
            Try
                If iSelect = 1 Then
                    Call SaveAction()
                    MsgBox("action Saved", MsgBoxStyle.Information, TitleMsgBox)
                Else
                    Call EditAction()
                    MsgBox("action Updated", MsgBoxStyle.Information, TitleMsgBox)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, TitleMsgBox)
            End Try
            Call clear()
            Call control(False)
            Call retreiveActionClass()
            iSelect = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            ListView1.Enabled = False
            Call control(True)
            iSelect = 2
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            TextBox6.Text = CDbl(ListView1.SelectedItems.Item(0).SubItems(0).Text)
            TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
            TextBox2.Text = CDbl(ListView1.SelectedItems.Item(0).SubItems(2).Text.Replace("%", ""))
            TextBox3.Text = CDbl(ListView1.SelectedItems.Item(0).SubItems(3).Text.Replace("%", ""))
            TextBox4.Text = CDbl(ListView1.SelectedItems.Item(0).SubItems(4).Text.Replace("%", ""))
            TextBox5.Text = CDbl(ListView1.SelectedItems.Item(0).SubItems(5).Text.Replace("%", ""))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            TextBox6.Text = ListView1.FocusedItem.Text
            TextBox1.Text = ListView1.FocusedItem.SubItems(1).Text
            TextBox2.Text = CDbl(ListView1.FocusedItem.SubItems(2).Text.Replace("%", ""))
            TextBox3.Text = CDbl(ListView1.FocusedItem.SubItems(3).Text.Replace("%", ""))
            TextBox4.Text = CDbl(ListView1.FocusedItem.SubItems(4).Text.Replace("%", ""))
            TextBox5.Text = CDbl(ListView1.FocusedItem.SubItems(5).Text.Replace("%", ""))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Try
            TextBox1.Text = TextBox1.Text.Replace("'", "`")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region
End Class
