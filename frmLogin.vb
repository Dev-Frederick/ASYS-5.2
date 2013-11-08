'Imports System.Windows.Forms
Imports System.Data.SqlClient
'Imports System.Drawing.Graphics

Public Class frmLogin 'GrpSelect
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
    Friend WithEvents btnLuzon As System.Windows.Forms.Button
    Friend WithEvents btnVismin As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPWord As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.btnLuzon = New System.Windows.Forms.Button
        Me.btnVismin = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPWord = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLuzon
        '
        Me.btnLuzon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLuzon.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuzon.Location = New System.Drawing.Point(112, 80)
        Me.btnLuzon.Name = "btnLuzon"
        Me.btnLuzon.Size = New System.Drawing.Size(120, 40)
        Me.btnLuzon.TabIndex = 4
        Me.btnLuzon.Text = "LUZON"
        '
        'btnVismin
        '
        Me.btnVismin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVismin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVismin.Location = New System.Drawing.Point(112, 128)
        Me.btnVismin.Name = "btnVismin"
        Me.btnVismin.Size = New System.Drawing.Size(120, 40)
        Me.btnVismin.TabIndex = 5
        Me.btnVismin.Text = "VISMIN"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECT A GROUP:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPWord)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 184)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
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
        Me.txtPWord.TabIndex = 2
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
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "USERNAME"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(349, 192)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVismin)
        Me.Controls.Add(Me.btnLuzon)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS 5.1 LOG-IN"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnVisMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVismin.Click
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            If ambot = 2 Then
                sDB = "Vismin"
                Me.Visible = False
                MainFrm.Show()
            ElseIf ambot = 1 Then
                Dim frmrec2 As New FrmNewReceiving
                sDB = "Vismin"
                Me.Visible = False
                frmrec2.Show()
            ElseIf ambot = 3 Then
                Dim frmrel As New frmReleasing
                sDB = "Vismin"
                Me.Visible = False
                frmrel.Show()

            End If
            myregion = sDB

        Catch ex As Exception
            MsgBox("frmLogin/btnVisMin_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnLuzon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuzon.Click
        Try
            Dim objclass As New clsCommon
            Dim str As String

            If ambot = 2 Then
                sDB = "Luzon"
                Me.Visible = False
                MainFrm.Show()
            ElseIf ambot = 1 Then
                Dim frmrec2 As New FrmNewReceiving
                sDB = "Luzon"
                Me.Visible = False
                frmrec2.Show()
            ElseIf ambot = 3 Then
                Dim frmrel As New frmReleasing
                sDB = "Luzon"
                Me.Visible = False
                frmrel.Show()

            End If
            myregion = sDB
            'If ambot = 2 Then
            '    sDB = "Luzon"
            '    myregion = sDB
            '    Me.Visible = False
            '    'If loadme = True Then
            '    Me.Close()
            '    Me.Dispose()
            '    'Else
            '    MainFrm.ShowDialog()
            '    'End If
            'ElseIf ambot = 1 Then
            '    Dim frmrec2 As New FrmNewReceiving
            '    sDB = "Luzon"
            '    myregion = sDB
            '    Me.Visible = False
            '    frmrec2.Show()
            'ElseIf ambot = 3 Then
            '    Dim frmrel As New frmReleasing
            '    sDB = "Luzon"
            '    myregion = sDB
            '    Me.Visible = False
            '    frmrel.Show()
            'End If
            'myregion = sDB
        Catch ex As Exception
            MsgBox("frmLogin/btnLuzon_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
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
            ambot = 2
        Catch ex As Exception
            rply = ex.Message.IndexOf("access denied")
            If rply > 0 Then
                MsgBox("The server did not respond.", , TitleMsgBox)
            Else
                MsgBox("frmLogin/txtPWord_KeyDown: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            End If

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

    Private Sub frmLogin_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try

            FlagClose = False
            If FlagLoggedIn = True Then
                FlagClose = True
                Me.Hide()
                'MainFrm.Show()
                Exit Sub
            End If

            If UCase(jobtitle) = "SORTER" Or UCase(jobtitle) = "ALLDEPTMNGR" Then
                End
            Else
                'Me.Close()
                End
            End If
        Catch ex As Exception
            MsgBox("frmLogin/frmLogin_Closed: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '''If CheckInstance() = True Then
            '''    End
            '''Else

            '''    GroupBox1.Visible = True
            '''    If GroupBox1.Visible = False Then
            '''        Me.Text = TitleMsgBox
            '''    End If
            '''    txtUserName.Focus()
            '''End If
            GroupBox1.Visible = True
            If GroupBox1.Visible = False Then
                Me.Text = TitleMsgBox
            End If
            txtUserName.Focus()
        Catch ex As Exception
            MsgBox("frmLogin/frmLogin_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function CheckInstance() As Boolean
        Try
            Dim appProc() As Process


            Dim strModName, strProcName As String
            strModName = Process.GetCurrentProcess.MainModule.ModuleName
            strProcName = System.IO.Path.GetFileNameWithoutExtension(strModName)


            appProc = Process.GetProcessesByName(strProcName)
            If appProc.Length > 1 Then
                MsgBox("ASYS 3.1 is already running.", MsgBoxStyle.Information, TitleMsgBox)
                CheckInstance = True
            Else
                CheckInstance = False
            End If
        Catch ex As Exception
            MsgBox("frmLogin/CheckInstance: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtPWord_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPWord.TextChanged

    End Sub
End Class