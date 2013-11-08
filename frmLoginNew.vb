Imports System.Data.SqlClient
Imports System.Data
''Imports System.Drawing
Public Class frmLoginNew
    Inherits System.Windows.Forms.Form
    Private MainFrm As New frmMain
    Dim rply As Integer
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPWord As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdShowroom As System.Windows.Forms.RadioButton
    Friend WithEvents rdLNCR As System.Windows.Forms.RadioButton
    Friend WithEvents rdMindanao As System.Windows.Forms.RadioButton
    Friend WithEvents rdLuzon As System.Windows.Forms.RadioButton
    Friend WithEvents rdVisayas As System.Windows.Forms.RadioButton
    Friend WithEvents rdVismin As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLoginNew))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPWord = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdVisayas = New System.Windows.Forms.RadioButton
        Me.rdShowroom = New System.Windows.Forms.RadioButton
        Me.rdLNCR = New System.Windows.Forms.RadioButton
        Me.rdMindanao = New System.Windows.Forms.RadioButton
        Me.rdVismin = New System.Windows.Forms.RadioButton
        Me.rdLuzon = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPWord)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtPWord
        '
        Me.txtPWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPWord.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPWord.Location = New System.Drawing.Point(128, 96)
        Me.txtPWord.Name = "txtPWord"
        Me.txtPWord.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPWord.Size = New System.Drawing.Size(184, 26)
        Me.txtPWord.TabIndex = 6
        Me.txtPWord.Text = ""
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(128, 56)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(184, 26)
        Me.txtUserName.TabIndex = 5
        Me.txtUserName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USERNAME"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdVisayas)
        Me.GroupBox2.Controls.Add(Me.rdShowroom)
        Me.GroupBox2.Controls.Add(Me.rdLNCR)
        Me.GroupBox2.Controls.Add(Me.rdMindanao)
        Me.GroupBox2.Controls.Add(Me.rdVismin)
        Me.GroupBox2.Controls.Add(Me.rdLuzon)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 176)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rdVisayas
        '
        Me.rdVisayas.Location = New System.Drawing.Point(96, 80)
        Me.rdVisayas.Name = "rdVisayas"
        Me.rdVisayas.TabIndex = 13
        Me.rdVisayas.Text = "Visayas"
        '
        'rdShowroom
        '
        Me.rdShowroom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdShowroom.Location = New System.Drawing.Point(112, 112)
        Me.rdShowroom.Name = "rdShowroom"
        Me.rdShowroom.Size = New System.Drawing.Size(120, 24)
        Me.rdShowroom.TabIndex = 12
        Me.rdShowroom.Text = "Showroom"
        '
        'rdLNCR
        '
        Me.rdLNCR.Enabled = False
        Me.rdLNCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLNCR.Location = New System.Drawing.Point(176, 144)
        Me.rdLNCR.Name = "rdLNCR"
        Me.rdLNCR.Size = New System.Drawing.Size(88, 24)
        Me.rdLNCR.TabIndex = 11
        Me.rdLNCR.Text = "LNCR"
        Me.rdLNCR.Visible = False
        '
        'rdMindanao
        '
        Me.rdMindanao.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdMindanao.Location = New System.Drawing.Point(200, 80)
        Me.rdMindanao.Name = "rdMindanao"
        Me.rdMindanao.Size = New System.Drawing.Size(112, 24)
        Me.rdMindanao.TabIndex = 10
        Me.rdMindanao.Text = "Mindanao"
        '
        'rdVismin
        '
        Me.rdVismin.Enabled = False
        Me.rdVismin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdVismin.Location = New System.Drawing.Point(72, 144)
        Me.rdVismin.Name = "rdVismin"
        Me.rdVismin.Size = New System.Drawing.Size(96, 24)
        Me.rdVismin.TabIndex = 9
        Me.rdVismin.Text = "VisMin"
        Me.rdVismin.Visible = False
        '
        'rdLuzon
        '
        Me.rdLuzon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdLuzon.Location = New System.Drawing.Point(16, 80)
        Me.rdLuzon.Name = "rdLuzon"
        Me.rdLuzon.Size = New System.Drawing.Size(80, 24)
        Me.rdLuzon.TabIndex = 8
        Me.rdLuzon.Text = "Luzon"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SELECT A GROUP:"
        '
        'frmLoginNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(344, 182)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLoginNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS 5.2 LOG-IN"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtPWord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPWord.KeyPress
        Try
            If e.KeyChar = "." Or e.KeyChar = "/" Or e.KeyChar = "?" Or e.KeyChar = ">" Or e.KeyChar = "," Or e.KeyChar = "<" Or e.KeyChar = "{" Or e.KeyChar = "[" Or e.KeyChar = "}" Or e.KeyChar = "]" Or e.KeyChar = """" Then
                e.Handled = True
            End If
            If e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or e.KeyChar = "+" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "\" Or e.KeyChar = "|" Then
                e.Handled = True
            End If
            If e.KeyChar = "&" Or e.KeyChar = "'" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "_" Or e.KeyChar = "=" Or e.KeyChar = "`" Or e.KeyChar = "~" Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                If txtPWord.Text = "" Then
                    txtPWord.Focus()
                End If
            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
            MsgBox("frmLogin/txtPWord_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub txtPWord_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPWord.KeyDown
        Try
            Dim objclass As New clsCommon
            Dim frm As New frmMain
            Dim dr As SqlDataReader
            Dim flag As Boolean
            Dim UserFlag As Boolean
            Dim a, b, squery, msg As String

            If e.KeyCode = Keys.Enter Then
                If txtUserName.Text.Trim.Length = 0 Then
                    MsgBox("Enter a Username.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
                If txtPWord.Text.Trim.Length = 0 Then
                    MsgBox("Enter a Password.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
                If Mid(txtPWord.Text, 1, 1) = "0" Then
                    MsgBox("Username and Password did not match.", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                End If
                flag = True
                UserFlag = True

                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                squery = "Select top 1 * from " & humres2 & " where usr_id='" & txtUserName.Text & "' and res_id =" & Me.txtPWord.Text & " and blocked = 1  and job_title in ('sorter', 'allbosman','mlwb','pricing', 'distri', 'alldeptmngr', 'verifier')"
                objclass.Command5(squery)
                dr = objclass.OpenDataReader5
                If dr.Read = True Then
                    job_title = Trim(dr.Item("job_title"))
                    jobtitle = job_title
                    fullname = Trim(dr.Item("fullname"))
                    idnumber = dr.Item("res_id")
                    userLog = fullname
                    UserPassW = idnumber
                    UserFlag = True
                    FlagLoggedIn = True
                Else
                    MsgBox("Username and Password did not match.", MsgBoxStyle.Information, TitleMsgBox)
                    flag = False
                End If

                If UserFlag = False Then
                    MsgBox("You are unauthorized to use this application.", MsgBoxStyle.Information, TitleMsgBox)
                End If
                dr.Close()
                objclass.Close5()

                If flag = False Or UserFlag = False Then
                    txtPWord.Clear()
                    txtUserName.Focus()
                    Exit Sub
                End If
                If UCase(job_title) = "SORTER" Or job_title = "ALLDEPTMNGR" Then
                    GroupBox1.Visible = False
                    admintitle = False
                Else
                    Me.Visible = False
                    admintitle = True
                    MainFrm.Show()
                End If
            End If

        Catch ex As Exception
            rply = ex.Message.IndexOf("access denied")
            If rply > 0 Then
                MsgBox("The server did not respond.", , TitleMsgBox)
            Else
                MsgBox("frmLogin/txtPWord_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            End If
        End Try
    End Sub
    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        Try
            If e.KeyChar = "." Or e.KeyChar = "/" Or e.KeyChar = "?" Or e.KeyChar = ">" Or e.KeyChar = "," Or e.KeyChar = "<" Or e.KeyChar = "{" Or e.KeyChar = "[" Or e.KeyChar = "}" Or e.KeyChar = "]" Or e.KeyChar = """" Then
                e.Handled = True
            End If
            If e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or e.KeyChar = "+" Or e.KeyChar = ";" Or e.KeyChar = ":" Or e.KeyChar = "\" Or e.KeyChar = "|" Then
                e.Handled = True
            End If
            If e.KeyChar = "&" Or e.KeyChar = "'" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "_" Or e.KeyChar = "=" Or e.KeyChar = "`" Or e.KeyChar = "~" Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmLogin/txtUserName_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtUserName.Text.Trim.Length = 0 Then
                    MsgBox("Enter a Username.", MsgBoxStyle.Information, TitleMsgBox)
                    txtUserName.Focus()
                Else
                    txtPWord.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("frmLogin/txtUserName_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub rdLuzon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdLuzon.CheckedChanged, rdMindanao.CheckedChanged, rdLNCR.CheckedChanged, rdShowroom.CheckedChanged, rdVisayas.CheckedChanged
        Try
            If rdLuzon.Checked = True Then
                sDB = "Luzon"
                zonebedryf = "vw_bedryfLuzon"
            ElseIf rdVisayas.Checked = True Then
                sDB = "Visayas"
                zonebedryf = "vw_bedryfVisayas"
            ElseIf rdMindanao.Checked = True Then
                sDB = "Mindanao"
                zonebedryf = "vw_bedryfMindanao"
            ElseIf rdShowroom.Checked = True Then
                sDB = "Showroom"
                zonebedryf = "vw_bedryfShowroom"
            ElseIf rdLNCR.Checked = True Then
                sDB = "LNCR"
                zonebedryf = "vw_bedryfLNCR"
            End If
            myregion = sDB
            Me.Visible = False
            MainFrm.Show()
        Catch ex As Exception
            MsgBox(ex.Message, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmLoginNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rdVisayas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdVisayas.CheckedChanged

    End Sub
End Class
