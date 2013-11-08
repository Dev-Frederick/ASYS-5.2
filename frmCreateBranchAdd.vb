Imports System.Data.SqlClient
Public Class frmCreateBranchAdd
    Inherits System.Windows.Forms.Form
    Private radstat As Boolean
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtBranchName As System.Windows.Forms.TextBox
    Friend WithEvents txtBranchCode As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnBranchAdd As System.Windows.Forms.Button
    Friend WithEvents btnCustInfo As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtXMLAbbr As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCreateBranchAdd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtXMLAbbr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.txtBranchName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBranchCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBranchAdd = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.btnCustInfo = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtXMLAbbr)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.txtBranchName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtBranchCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBranchAdd)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 88)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CREATE BRANCH ADDRESS"
        '
        'txtXMLAbbr
        '
        Me.txtXMLAbbr.BackColor = System.Drawing.SystemColors.Window
        Me.txtXMLAbbr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtXMLAbbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtXMLAbbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXMLAbbr.Location = New System.Drawing.Point(368, 56)
        Me.txtXMLAbbr.MaxLength = 10
        Me.txtXMLAbbr.Name = "txtXMLAbbr"
        Me.txtXMLAbbr.Size = New System.Drawing.Size(80, 20)
        Me.txtXMLAbbr.TabIndex = 11
        Me.txtXMLAbbr.Text = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "XML CODE"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(112, 56)
        Me.TextBox3.MaxLength = 150
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 20)
        Me.TextBox3.TabIndex = 10
        Me.TextBox3.Text = ""
        '
        'txtBranchName
        '
        Me.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchName.Location = New System.Drawing.Point(224, 24)
        Me.txtBranchName.MaxLength = 100
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(224, 20)
        Me.txtBranchName.TabIndex = 9
        Me.txtBranchName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "BRANCH ADDRESS"
        '
        'txtBranchCode
        '
        Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBranchCode.Location = New System.Drawing.Point(96, 24)
        Me.txtBranchCode.MaxLength = 3
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(40, 20)
        Me.txtBranchCode.TabIndex = 8
        Me.txtBranchCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BRANCH NAME"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BRANCH CODE"
        '
        'btnBranchAdd
        '
        Me.btnBranchAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBranchAdd.Location = New System.Drawing.Point(176, 0)
        Me.btnBranchAdd.Name = "btnBranchAdd"
        Me.btnBranchAdd.Size = New System.Drawing.Size(24, 16)
        Me.btnBranchAdd.TabIndex = 13
        Me.btnBranchAdd.Text = "..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 64)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(208, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(224, 40)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "CREATE CUSTOMER INFORMATION"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(24, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(168, 32)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CREATE BRANCH NAME"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.btnCustInfo)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(456, 104)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CREATE CUSTOMER INFORMATION"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(80, 48)
        Me.TextBox9.MaxLength = 20
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(88, 20)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(88, 24)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(144, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(288, 24)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(160, 20)
        Me.TextBox6.TabIndex = 13
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(80, 72)
        Me.TextBox5.MaxLength = 50
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(368, 20)
        Me.TextBox5.TabIndex = 17
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(288, 48)
        Me.TextBox4.MaxLength = 20
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(160, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.Text = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ADDRESS"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "LAST NAME"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(248, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "DATE"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "CUSTOMER ID"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "FIRST NAME"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(176, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "M.I."
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(200, 48)
        Me.TextBox8.MaxLength = 1
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(24, 20)
        Me.TextBox8.TabIndex = 15
        Me.TextBox8.Text = ""
        '
        'btnCustInfo
        '
        Me.btnCustInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCustInfo.Location = New System.Drawing.Point(224, 0)
        Me.btnCustInfo.Name = "btnCustInfo"
        Me.btnCustInfo.Size = New System.Drawing.Size(24, 16)
        Me.btnCustInfo.TabIndex = 14
        Me.btnCustInfo.Text = "..."
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(224, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "SAVE"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(304, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 40)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "CLEAR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(384, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "CLOSE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEdit
        '
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEdit.Location = New System.Drawing.Point(224, 280)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(80, 40)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "UPDATE"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmCreateBranchAdd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(468, 340)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(478, 376)
        Me.MinimumSize = New System.Drawing.Size(478, 376)
        Me.Name = "frmCreateBranchAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE BRANCH/CUSTOMER INFORMATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Try
            GroupBox1.Enabled = True
            GroupBox3.Enabled = False
            txtBranchName.Focus()
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox6.Text = ""
            TextBox9.Text = ""
            radstat = True
            Button2.Enabled = False

        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/RadioButton1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Try
            GroupBox1.Enabled = False
            GroupBox3.Enabled = True
            TextBox6.Text = Format(Now, "General Date")
            TextBox9.Focus()
            radstat = True
            Button2.Enabled = False
            txtBranchCode.Text = ""
            txtBranchName.Text = ""
            txtXMLAbbr.Text = ""
            TextBox3.Text = ""
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/RadioButton2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            txtBranchCode.Text = ""
            txtBranchName.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            txtXMLAbbr.Text = ""
            txtBranchName.Enabled = True
            txtXMLAbbr.Enabled = False
            TextBox9.Text = ""
            btnEdit.Visible = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox8.Enabled = False
            TextBox5.Enabled = False
            Button1.Visible = True
            If RadioButton1.Checked = True Then
                RadioButton1_Click(sender, e)
                txtBranchCode.Focus()

            Else
                RadioButton2_Click(sender, e)
                TextBox9.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub Search_CustInfo()
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            objclass = New clsCommon
            objclass.Connectionstring4()
            objclass.Open4()

            objclass.Command4("Select * from ASYS_CreateCustInfo where CustomerLname = '" + TextBox4.Text.Trim + "'")
            dr = objclass.OpenDataReader4
            If dr.Read Then
                TextBox7.Text = "10000" + objclass.IsNull(dr.Item("CustomerID"))
                TextBox9.Text = objclass.IsNull(dr.Item("CustomerFname"))
                TextBox6.Text = objclass.IsNull(dr.Item("DateCreated"))
                TextBox8.Text = objclass.IsNull(dr.Item("CustomerMname"))
                TextBox4.Text = objclass.IsNull(dr.Item("CustomerLname"))
                TextBox5.Text = objclass.IsNull(dr.Item("CustomerAddress"))
                btnEdit.Visible = True
                Button1.Visible = False
            End If
            dr.Close()
            objclass.Execute4()
            objclass.Close4()
            objclass = Nothing
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/Search_CustInfo: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub Search_bedryf()
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            If txtBranchCode.Text <> "" Then
                objclass.Command5("Select * from " & bedryf2 & " where bedrnr like '%" + txtBranchCode.Text.Trim + "%'")
            Else
                objclass.Command5("Select * from " & bedryf2 & " where bedrnm like '%" + txtBranchName.Text.Trim + "%'")
            End If
            'If txtBranchCode.Text <> "" Then
            '    objclass.Command5("Select * from REMS.dbo.vw_bedryf(" & sDB & ") where bedrnr like '%" + txtBranchCode.Text.Trim + "%'")
            'Else
            '    objclass.Command5("Select * from REMS.dbo.vw_bedryf(" & sDB & ") where bedrnm like '%" + txtBranchName.Text.Trim + "%'")
            'End If

            dr = objclass.OpenDataReader5
            If dr.Read Then
                txtBranchCode.Text = objclass.IsNull(dr.Item("bedrnr"))
                txtBranchName.Text = objclass.IsNull(Trim(dr.Item("bedrnm")))
                TextBox3.Focus()
                Me.txtBranchName.Enabled = True
                Me.txtBranchName.Focus()
            Else
                MsgBox("Branch doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                txtBranchCode.Focus()
            End If
            dr.Close()
            ' objclass.Execute5()
            objclass.Close5()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/Search_bedryf: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchCode.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If Me.txtBranchCode.Text <> "" Then
                    Search_bedryf()
                    Call IfBranchAddExist()

                ElseIf Me.txtBranchCode.Text = "" Then
                    MsgBox("Enter branch code.", MsgBoxStyle.Information, TitleMsgBox)
                    Me.txtBranchCode.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtBranchCode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBranchName.KeyPress
        Try
            If txtBranchName.Text.Length > 24 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                Search_bedryf()
                Call IfBranchAddExist()
            End If

            ''Dim obj As New clsCommon
            ''Dim dr As SqlDataReader

            ''obj = New clsCommon
            ''obj.Connectionstring3()
            ''obj.Open3()
            ''If e.KeyChar = ChrW(13) Then
            ''    obj.Command3("Select * from ASYS_BranchAddress where Branchname like '%" & txtBranchName.Text & "%'")
            ''    dr = obj.OpenDataReader3
            ''    If dr.Read = True Then
            ''        txtBranchName.Text = obj.IsNull(Trim(dr.Item("BranchName")))
            ''        txtBranchCode.Text = obj.IsNull(dr.Item("Branchcode"))
            ''        TextBox3.Text = obj.IsNull(Trim(dr.Item("BranchAddress")))
            ''        txtXMLAbbr.Text = obj.IsNull(Trim(dr.Item("XMLAbbr")))
            ''        txtBranchName.Focus()
            ''        btnEdit.Visible = True
            ''        btnEdit.Enabled = True
            ''        Button1.Visible = False
            ''    Else
            ''        Search_bedryf()
            ''        btnEdit.Visible = False
            ''        btnEdit.Enabled = False
            ''        Button1.Visible = True
            ''        TextBox3.Text = ""
            ''        txtXMLAbbr.Text = ""
            ''    End If
            ''    dr.Close()
            ''    'obj.Execute3()
            ''    obj.Close3()
            ''    obj = Nothing
            ''End If

            If e.KeyChar = ChrW(Keys.Enter) Then
                If txtBranchCode.Text <> "" And txtBranchName.Text <> "" Then
                    Me.TextBox3.Enabled = True
                    Me.TextBox3.Focus()
                Else
                    If txtBranchCode.Text = "" And txtBranchName.Text = "" Then
                        MsgBox("Some fields were empty.", MsgBoxStyle.Information, TitleMsgBox)
                        Me.txtBranchName.Focus()
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtBranchName_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub IfBranchAddExist()
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            obj.Command3("Select * from ASYS_BranchAddress where Branchname = '" & txtBranchName.Text & "'")
            dr = obj.OpenDataReader3
            If dr.Read = True Then
                txtBranchName.Text = obj.IsNull(dr.Item("BranchName"))
                txtBranchCode.Text = obj.IsNull(dr.Item("Branchcode"))
                TextBox3.Text = obj.IsNull(dr.Item("BranchAddress"))
                txtXMLAbbr.Text = obj.IsNull(dr.Item("XMLAbbr"))
                txtBranchName.Focus()
                Button1.Enabled = False
                btnEdit.Visible = True
                btnEdit.Enabled = True
                Button1.Visible = False
            End If
            dr.Close()
            'obj.Execute3()
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/IfBranchAddExist: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If RadioButton1.Checked = True Then
                If txtBranchCode.Text = "" Or txtBranchName.Text = "" Or TextBox3.Text = "" Or txtXMLAbbr.Text = "" Then
                    MsgBox("Please input branch information.", MsgBoxStyle.Information, TitleMsgBox)
                    txtBranchName.Focus()
                    Exit Sub
                End If
            Else
                If TextBox9.Text = "" Or TextBox4.Text = "" Then
                    MsgBox("Please input customer information.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox9.Focus()
                    Exit Sub
                End If
            End If


            ButtonChecked(radstat)
            Button2_Click(sender, e)
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ButtonChecked(ByVal check As Boolean)
        Try
            Dim str As String
            Dim obj As New clsCommon
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader

            objclass = New clsCommon
            objclass.Connectionstring4()
            objclass.Open4()
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            If RadioButton1.Checked = check Then
                str = "Insert Into ASYS_BranchAddress(BranchCode,BrancHname,Branchaddress,XMLAbbr)values('" & txtBranchCode.Text & "','" & txtBranchName.Text & "','" & TextBox3.Text & "','" & txtXMLAbbr.Text & "')"
                obj.Command3(str)
                obj.Execute3()
                MsgBox("You have successfully added branch Address.", MsgBoxStyle.Information, TitleMsgBox)
            ElseIf RadioButton2.Checked = check Then
                objclass.Command4("Select Coalesce(Max(Cast(CustomerID as int)) + 1,1)  as CustID from ASYS_CreateCustinfo")
                dr = objclass.OpenDataReader4
                If dr.Read Then
                    str = "Insert Into ASYS_CreateCustinfo(CustomerID,CustomerFname,CustomerLname,CustomerMname,CustomerAddress,DateCreated)values('" & dr.Item("CustID") & "','" & TextBox9.Text & "','" & TextBox4.Text & "','" & TextBox8.Text & "','" & TextBox5.Text & "',getdate())"
                    obj.Command3(str)
                    obj.Execute3()
                End If
                dr.Close()
                objclass.Execute4()
                objclass.Close4()
                objclass = Nothing
                MsgBox("You have successfully added Customer Information.", MsgBoxStyle.Information, TitleMsgBox)
            End If
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/ButtonChecked: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.txtBranchCode.Text <> "" And Me.txtBranchName.Text <> "" And Me.TextBox3.Text <> "" Then
                    Me.txtXMLAbbr.Enabled = True
                    Me.txtXMLAbbr.Focus()
                Else
                    MsgBox("Supply missing information in the textbox(es).", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        Try
            If IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.TextBox9.Text <> "" Then
                    Me.TextBox8.Text = UCase(Me.TextBox8.Text)
                    Me.TextBox4.Enabled = True
                    Me.TextBox4.Focus()
                Else
                    MsgBox("Some field were empty.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox8_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Try
            If Me.TextBox9.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.TextBox9.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox9_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        Try
            If IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.TextBox9.Text <> "" Then
                    Me.TextBox9.Text = UCase(TextBox9.Text)
                    Me.TextBox8.Enabled = True
                    btnEdit.Enabled = True
                    Me.TextBox8.Focus()
                Else
                    MsgBox("Firstname is empty.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox9_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Try
            If IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.TextBox9.Text <> "" Then
                    Me.TextBox4.Text = UCase(Me.TextBox4.Text)
                    Me.TextBox5.Enabled = True
                    Me.TextBox5.Focus()
                Else
                    MsgBox("Firstname is empty.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox4_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.TextBox9.Text <> "" And Me.TextBox9.Text <> "" And Me.TextBox4.Text <> "" Then
                    Me.TextBox8.Text = UCase(Me.TextBox8.Text)
                    Me.Button1.Enabled = True
                    Me.Button1.Focus()
                Else
                    MsgBox("Some fields were empty.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox5_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ButtonCheckedUpdate(ByVal checkupdate As Boolean)
        Try
            Dim str As String
            Dim obj As New clsCommon
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader

            objclass = New clsCommon
            objclass.Connectionstring4()
            objclass.Open4()
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            If RadioButton1.Checked = checkupdate Then
                str = "Update  ASYS_BranchAddress set branchaddress = '" & TextBox3.Text & "', XMLAbbr = '" & txtXMLAbbr.Text & "' where branchname = '" & txtBranchName.Text & "' and branchcode = " & txtBranchCode.Text & ""
                obj.Command3(str)
                obj.Execute3()
                MsgBox("You have successfully updated branch Address.", MsgBoxStyle.Information, TitleMsgBox)
                btnEdit.Enabled = False
            ElseIf RadioButton2.Checked = checkupdate Then
                str = "Update ASYS_CreateCustInfo set CustomerAddress ='" & TextBox5.Text & "',customerLname = '" & TextBox4.Text & "' where customerId = " & Mid(TextBox7.Text, 6, 1) & ""
                obj.Command3(str)
                obj.Execute3()
                MsgBox("You have successfully updated Customer Information.", MsgBoxStyle.Information, TitleMsgBox)
                btnEdit.Enabled = False
            End If
            obj.Close3()
            obj = Nothing
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/ButtonCheckedUpdate: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            ButtonCheckedUpdate(radstat)
            Button2.Enabled = True
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/btnEdit_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBranchAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBranchAdd.Click
        Try
            Dim frm As New frmViewBRanchOrCustInfo
            frm.ListView1.Columns.Add("BranchCode", 70, HorizontalAlignment.Left)
            frm.ListView1.Columns.Add("BranchName", 175, HorizontalAlignment.Left)
            frm.ListView1.Columns.Add("BranchAddress", 250, HorizontalAlignment.Left)
            Call frm.ViewBranchorCustInfo(1)
            frm.Text = "VIEW BRANCH ADDRESS" ' "View Branch Address"
            Me.Hide()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/btnBranchAdd_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnCustInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustInfo.Click
        Try
            Dim frm As New frmViewBRanchOrCustInfo
            frm.ListView1.Columns.Add("Customer ID", 70, HorizontalAlignment.Left)
            frm.ListView1.Columns.Add("Customer Name", 175, HorizontalAlignment.Left)
            frm.ListView1.Columns.Add("Customer Address", 250, HorizontalAlignment.Left)
            frm.Text = "VIEW CUSTOMER ADDRESS" '"View Customer Address"
            Call frm.ViewBranchorCustInfo(2)
            Me.Hide()
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/btnCustInfo_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Try
            If Me.TextBox9.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.TextBox9.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox5_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmCreateBranchAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Button2_Click(sender, e)
            Me.Button2.Enabled = False
            Me.Button1.Enabled = False
            btnEdit.Enabled = False
            'for create branch
            Me.txtBranchName.Enabled = True
            Me.TextBox3.Enabled = False
            Me.txtXMLAbbr.Enabled = False
            Me.txtXMLAbbr.BackColor = Color.Empty
            'for customer info
            Me.TextBox7.Enabled = False
            Me.TextBox7.BackColor = Color.Empty
            Me.TextBox6.ReadOnly = False
            Me.TextBox6.BackColor = Color.Empty
            Me.txtBranchCode.Focus()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/frmCreateBranchAdd_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.TextChanged
        Try
            If Me.txtBranchCode.Text = "" Or Me.txtBranchName.Text = "" Or Me.TextBox3.Text = "" Or Me.txtXMLAbbr.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.txtBranchCode.Text <> "" Or Me.txtBranchName.Text <> "" Or Me.TextBox3.Text <> "" Or Me.txtXMLAbbr.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtBranchCode_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            If Me.txtBranchCode.Text = "" Or Me.txtBranchName.Text = "" Or Me.TextBox3.Text = "" Or Me.txtXMLAbbr.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.txtBranchCode.Text <> "" Or Me.txtBranchName.Text <> "" Or Me.TextBox3.Text <> "" Or Me.txtXMLAbbr.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtXMLAbbr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtXMLAbbr.TextChanged
        Try
            If Me.txtBranchCode.Text = "" Or Me.txtBranchName.Text = "" Or Me.TextBox3.Text = "" Or Me.txtXMLAbbr.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.txtBranchCode.Text <> "" Or Me.txtBranchName.Text <> "" Or Me.TextBox3.Text <> "" Or Me.txtXMLAbbr.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtXMLAbbr_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Try
            If Me.TextBox7.Text <> "" Or Me.TextBox9.Text <> "" Or Me.TextBox8.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            Else
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox6_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Try
            If Me.TextBox7.Text <> "" Or Me.TextBox9.Text <> "" Or Me.TextBox8.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            Else
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox7_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Try
            If Me.TextBox9.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.TextBox9.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox8_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Try
            If Me.TextBox9.Text = "" Or Me.TextBox4.Text = "" Or Me.TextBox5.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.TextBox9.Text <> "" Or Me.TextBox4.Text <> "" Or Me.TextBox5.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/TextBox4_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtXMLAbbr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtXMLAbbr.KeyPress
        Try
            If e.KeyChar = ChrW(Keys.Enter) Then
                If Me.txtXMLAbbr.Text <> "" And txtBranchName.Text <> "" And TextBox3.Text <> "" And Me.txtBranchCode.Text <> "" Then
                    Me.Button1.Enabled = True
                    Me.Button1.Focus()
                Else
                    Me.Button1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtXMLAbbr_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Try
            Me.Button1.Enabled = False
            Me.txtBranchName.Enabled = False
            Me.TextBox3.Enabled = False
            Me.txtXMLAbbr.Enabled = False
            Me.txtXMLAbbr.BackColor = Color.Empty
            Me.TextBox7.ReadOnly = True
            Me.TextBox7.BackColor = Color.Empty
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.BackColor = Color.Empty
            Me.Button1.BringToFront()
            Me.txtBranchCode.Focus()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/RadioButton1_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Try
            Me.Button1.Enabled = False
            Me.txtBranchCode.BackColor = Color.Empty
            Me.TextBox8.Enabled = False
            Me.TextBox4.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox7.ReadOnly = True
            Me.TextBox7.BackColor = Color.White
            Me.TextBox6.ReadOnly = True
            Me.TextBox6.BackColor = Color.White
            Me.Button1.BringToFront()
            Me.TextBox9.Focus()
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/RadioButton2_CheckedChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtBranchName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchName.TextChanged
        Try
            If Me.txtBranchCode.Text = "" Or Me.txtBranchName.Text = "" Or Me.TextBox3.Text = "" Or Me.txtXMLAbbr.Text = "" Then
                Me.Button2.Enabled = False
                Me.Button1.Enabled = False
            End If
            If Me.txtBranchCode.Text <> "" Or Me.txtBranchName.Text <> "" Or Me.TextBox3.Text <> "" Or Me.txtXMLAbbr.Text <> "" Then
                Me.Button2.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateBranchAdd/txtBranchName_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
End Class
