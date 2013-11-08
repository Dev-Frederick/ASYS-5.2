Imports WinHttp
Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Net.WebClient
Imports System.Net.Sockets.Socket
Imports System.Text
Public Class frmCreateXML
    Inherits System.Windows.Forms.Form
    Private strFile As String
    Public sDB, sServer, ssaPass, FirstTS As String
    Public bcbranch As String
    Dim Upload As String = "C:\UploadXML\"

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
    Friend WithEvents TxtFileSize As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtArj As System.Windows.Forms.TextBox
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCreateXML))
        Me.TxtFileSize = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TxtArj = New System.Windows.Forms.TextBox
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TxtFileSize
        '
        Me.TxtFileSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFileSize.Location = New System.Drawing.Point(16, 128)
        Me.TxtFileSize.Name = "TxtFileSize"
        Me.TxtFileSize.ReadOnly = True
        Me.TxtFileSize.Size = New System.Drawing.Size(224, 20)
        Me.TxtFileSize.TabIndex = 67
        Me.TxtFileSize.Text = "0"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(248, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 40)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "CREATE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtArj
        '
        Me.TxtArj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArj.Location = New System.Drawing.Point(16, 104)
        Me.TxtArj.Name = "TxtArj"
        Me.TxtArj.ReadOnly = True
        Me.TxtArj.Size = New System.Drawing.Size(320, 20)
        Me.TxtArj.TabIndex = 60
        Me.TxtArj.Text = "c:\x1.arj"
        '
        'txtFile
        '
        Me.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile.Location = New System.Drawing.Point(16, 80)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(320, 20)
        Me.txtFile.TabIndex = 58
        Me.txtFile.Text = "c:\x1.xml"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 136)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "LOT NO."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "DIVISION"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "DIVISION NAME"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(112, 8)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(112, 32)
        Me.TextBox3.MaxLength = 100
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(240, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(248, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(104, 20)
        Me.TextBox4.TabIndex = 3
        Me.TextBox4.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(16, 152)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 69
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Visible = False
        '
        'frmCreateXML
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 208)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TxtFileSize)
        Me.Controls.Add(Me.TxtArj)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 240)
        Me.MinimumSize = New System.Drawing.Size(300, 240)
        Me.Name = "frmCreateXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE XML"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim c As Integer
            Dim sdb As String
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            'Me.SetDesktopLocation(350, 85)
            SysInit()
            makefolder()
            TextBox2.Focus()
            TextBox4.ReadOnly = True
            TextBox4.BackColor = Color.White
            TextBox2.ReadOnly = True
            TextBox2.BackColor = Color.White
            TextBox3.ReadOnly = True
            TextBox3.BackColor = Color.White
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            str = "Select XMLAbbr from ASYS_BranchAddress where branchcode = '" & TextBox2.Text & "' and branchname = '" & TextBox3.Text.Trim & "' "
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read Then
                txtFile.Text = Upload & obj.IsNull(dr.Item("XMLAbbr")) & Mid(TextBox4.Text, 5, 6) & ".XML"
            Else
                MsgBox("No XML abbreviation")
            End If
            dr.Close()
            obj.Close()
            txtFile.ReadOnly = True
            txtFile.BackColor = Color.White
            Me.TextBox1.Visible = False
        Catch ex As Exception
            MsgBox("frmCreateXML/Form1_Load " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub makefolder()
        Try
            If Not Directory.Exists(Upload) Then
                IO.Directory.CreateDirectory(Upload)
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/makefolder() " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Function SplChars(ByVal line As String) As String
        Try
            Dim tmpstr As String
            tmpstr = line.Replace("&", "&amp;")
            ' Modified Oct 10 2007
            '  next line using tmpstr = line.Replace("<", "&lt;")
            tmpstr = tmpstr.Replace("<", "&lt;")
            tmpstr = tmpstr.Replace(">", "&gt;")
            tmpstr = tmpstr.Replace("'", "&apos;")

            '  to handle special characters
            SplChars = tmpstr
        Catch ex As Exception
            MsgBox("frmCreateXML/SplChars " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Private Function BptnInit() As String

        Dim INIText As TextReader
        BptnInit = "C:\"
        Try

            INIText = System.IO.File.OpenText(Application.StartupPath & "\UploadXML.ini")
            Dim LineIn As String
            While INIText.Peek <> -1
                LineIn = INIText.ReadLine()
                If LineIn.TrimStart.StartsWith("[BPTN FOLDER]=") Then
                    LineIn = LineIn.Replace("[BPTN FOLDER]=", "")
                    BptnInit = LineIn
                End If
            End While
            INIText.Close()
        Catch ex As Exception
            MsgBox("frmCreateXML/BptnInit() " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
    Private Sub SysInit()
        Dim INIText As TextReader
        Try

            INIText = System.IO.File.OpenText(Application.StartupPath & "\ASYSXML.ini")
            Dim LineIn As String
            While INIText.Peek <> -1
                LineIn = INIText.ReadLine()
                If LineIn.TrimStart.StartsWith("[Branch Code]=") Then
                    LineIn = LineIn.Replace("[Branch Code]=", "")
                    sDB = LineIn
                ElseIf LineIn.TrimStart.StartsWith("[Server]=") Then
                    LineIn = LineIn.Replace("[Server]=", "")
                    sServer = LineIn
                ElseIf LineIn.TrimStart.StartsWith("[Branch Reg Key]=") Then
                    LineIn = LineIn.Replace("[Branch Reg Key]=", "")
                    ssaPass = decrypt(LineIn)
                End If

            End While
            INIText.Close()
        Catch ex As Exception
            MsgBox("frmCreateXML/SysInit() " & ex.Message, MsgBoxStyle.Information)
        Finally
            Button2.Enabled = True
        End Try
    End Sub
    Private Function decrypt(ByVal regkey As String) As String
        Try
            Dim i As Integer
            Dim mypass As String
            mypass = ""
            For i = 0 To regkey.Length - 1
                'MsgBox(regkey.Substring(i, 1))
                If isprime(i + 1) Then
                    mypass = mypass + regkey.Substring(i, 1)
                End If
            Next
            Return (mypass)
        Catch ex As Exception
            MsgBox("frmCreateXML/decrypt " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Private Function isprime(ByVal n As Integer) As Boolean
        Try
            Dim x As Integer
            If n = 1 Or n = 2 Then
                isprime = False
            Else

                If n Mod 2 = 0 Or n Mod 3 = 0 Or n Mod 5 = 0 Or n Mod 7 = 0 Then
                    isprime = False
                Else
                    isprime = True
                End If
            End If
            If n = 3 Or n = 5 Or n = 7 Then
                isprime = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/isprime " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
    Public Function IsNull(ByVal odata As Object) As String
        Try
            If IsDBNull(odata) Then
                Return ""
            Else
                Return CStr(odata)
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/IsNull " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
    Private Function Connectionstring() As String
        Dim sPath As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath
        Dim Constr3, sDatasource1, sDatabase1, sPassword1, sUsername1 As String
        Try
            Dim sr As StreamReader = New StreamReader(sPath + "\REMS.INI")
            Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1, Key_Photo As String



            Key_Server1 = "[Server]="
            Key_DataBase1 = "[DataBase]="
            Key_User1 = "[User]="
            Key_Pass1 = "[Password]="
            Key_Photo = "[Photo]="

            Dim line As String
            line = sr.ReadLine()
            While Not line Is Nothing
                line.Replace(" =", "=").Replace("= ", "=")
                If line.StartsWith(Key_Server1) Then
                    sDatasource1 = Replace(line, Key_Server1, "")
                End If
                If line.StartsWith(Key_DataBase1) Then
                    sDatabase1 = Replace(line, Key_DataBase1, "")
                End If
                If line.StartsWith(Key_User1) Then
                    sUsername1 = Replace(line, Key_User1, "")
                End If
                If line.StartsWith(Key_Pass1) Then
                    sPassword1 = "ml"
                End If
                If line.StartsWith(Key_Photo) Then
                    photodes = Replace(line, Key_Photo, "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()

            Constr3 = "Data Source = " + sDatasource1 + ";"
            Constr3 = Constr3 + ";Initial Catalog = " + sDatabase1
            Constr3 = Constr3 + ";User ID = " + sUsername1
            Constr3 = Constr3 + ";Password = " + sPassword1
            ConStrs = Constr3

            Return ConStrs

        Catch ex As Exception
            MsgBox("frmCreateXML/Connectionstring() " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
    Private Function uploadFileToDatabase(ByVal picture As Byte(), ByVal fileName As String, ByVal allbarcode As String) As Long
        '
        ' Defining the variables required for accesing the database server.
        '
        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim kFileName As SqlParameter = Nothing
        'INSTANT VB NOTE: The local variable FileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
        Dim FileName_Renamed As SqlParameter = Nothing
        Dim pic As SqlParameter = Nothing
        ' By default, we assume we have an error. If we succed in uploading the file, we'll change this 
        '  to the unique id of the file
        Dim result As Long = -1

        Try
            '
            ' Connecting to database.
            '
            conn = New SqlConnection(Connectionstring())
            cmd = New SqlCommand("spUploadFile", conn) ' We assume there is a stored procedure called UploadFile
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            ' ----------------------------------------------

            '
            ' Initializing parameters and assigning the values to be sent to the server
            '
            kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.VarChar, 17)
            kFileName.Value = allbarcode
            ' This parameter does not have a size because we do not know what the size is going to be.
            pic = New SqlParameter("@picture", SqlDbType.Image)
            pic.Value = picture

            FileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
            FileName_Renamed.Value = fileName
            ' ----------------------------------------------

            '
            ' Adding the parameters to the database. Remember that the order in which the parameters 
            '  are added is VERY important!
            '
            cmd.Parameters.Add(pic)
            cmd.Parameters.Add(FileName_Renamed)
            cmd.Parameters.Add(kFileName)
            ' ----------------------------------------------

            '
            ' Opening the connection and executing the command.
            '
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            ' ----------------------------------------------

            '
            ' The result is the unique identifier created on the database.
            '
            'result = (long)kFileName.Value;
            result = CLng(kFileName.Value)
            ' ----------------------------------------------

            '
            ' Disposing of the objects so we don't occupy memory.
            '
            conn.Dispose()
            cmd.Dispose()
            ' ----------------------------------------------
        Catch ex As Exception
            '
            ' If an error occurs, we report it to the user, with StackTrace for debugging purposes
            Console.WriteLine(ex.Message & "	- " & ex.StackTrace)
            result = -1
            ' ----------------------------------------------
            MsgBox("frmCreateXML/uploadFileToDatabase " & ex.Message, MsgBoxStyle.Information)
        End Try
        Return result
    End Function
    Private Function UploadFile(ByVal FileName As String, ByVal allbarcode As String) As Long


        Dim fs As FileStream = Nothing
        Try
            If (Not File.Exists(FileName)) Then
                Return -1
            End If
            '#Region "Reading file"

            fs = New FileStream(FileName, FileMode.Open)

            '
            ' Finding out the size of the file to be uploaded
            '
            Dim fi As FileInfo = New FileInfo(FileName)
            Dim temp As Long = fi.Length
            Dim lung As Integer = Convert.ToInt32(temp)
            ' ------------------------------------------

            '
            ' Reading the content of the file into an array of bytes.
            '
            Dim picture As Byte() = New Byte(lung - 1) {}
            fs.Read(picture, 0, lung)
            fs.Close()
            ' ------------------------------------------
            '#End Region
            Dim result As Long = uploadFileToDatabase(picture, fi.Name, allbarcode)

            Return result
        Catch e As Exception
            Console.WriteLine(e.Message & "	- " & e.StackTrace)
            Return -1
        End Try
    End Function
 
    Public Function ToBase64(ByVal data() As Byte) As String
        Try
            If data Is Nothing Then Throw New ArgumentNullException("data")
            Return Convert.ToBase64String(data)
        Catch ex As Exception
            MsgBox("frmCreateXML/ToBase64 " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Public Function FromBase64(ByVal base64 As String) As Byte()
        Try
            If base64 Is Nothing Then Throw New ArgumentNullException("base64")
            Return Convert.FromBase64String(base64)
        Catch ex As Exception
            MsgBox("frmCreateXML/FromBase64 " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Private Function ts2String(ByVal ts As SqlTypes.SqlBinary) As String
        Try
            Dim i As Integer
            Dim sreturn, thisstr As String
            sreturn = "0x"
            For i = 0 To ts.Value.Length - 1
                thisstr = Format(ts.Value(i), "X")
                If thisstr = "0" Then
                    thisstr = "00"
                End If
                If thisstr.Trim.Length = 1 Then
                    thisstr = "0" + thisstr.Trim
                End If
                sreturn = sreturn + thisstr
            Next
            Return sreturn
        Catch ex As Exception
            MsgBox("frmCreateXML/ts2String " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Function

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim tmpFile As FileInfo
            Dim a, b As Integer
            Dim line As String

            If e.KeyChar = ChrW(13) Then
                obj.ConnDb()
                obj.Open5()
                obj.Command5("Select bedrnr,bedrnm from " & bedryf2 & " where bedrnm like '%" + TextBox3.Text.Trim + "%'")
                dr = obj.OpenDataReader5
                If dr.Read Then
                    TextBox2.Text = dr.Item("bedrnr")
                    TextBox3.Text = Trim(dr.Item("bedrnm"))
                End If
                dr.Close()
                obj.Execute5()
                obj.Close5()

                line = Me.TextBox3.Text
                tmpFile = New FileInfo(Application.StartupPath & "\UploadXML.ini")
                If tmpFile.Exists() Then
                    bcbranch = line.Replace(" ", "").Replace("SM", "").Replace("City", "").Replace("Showroom", "").Replace("ML", "")
                    txtFile.Text = BptnInit() + "\" + bcbranch + Mid(TextBox4.Text, 5, 10) + ".XML"
                Else
                    'txtFile.Text = "C:\PT" + Format(Now(), "yyMMdd") + ".XML"
                    MsgBox("Error: UploadXML.INI not found.")
                    Me.Close()
                End If
                TextBox4.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/TextBox3_KeyPress " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If TextBox2.Text.Length < 3 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            Dim obj As New clsCommon
            Dim dr As SqlDataReader

            If e.KeyChar = ChrW(13) Then
                obj.ConnDb()
                obj.Open5()
                obj.Command5("Select bedrnm from " & bedryf2 & " where bedrnr like '%" + TextBox2.Text.Trim + "%'")
                dr = obj.OpenDataReader5
                If dr.Read Then
                    TextBox3.Text = dr.Item("bedrnm")
                End If
                dr.Close()
                obj.Execute5()
                obj.Close5()
                TextBox4.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/TextBox2_KeyPress " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Try
            Dim tmpFile As FileInfo
            Dim a, b As Integer
            Dim line As String


            line = Me.TextBox3.Text
            tmpFile = New FileInfo(Application.StartupPath & "\UploadXML.ini")
            If tmpFile.Exists() Then
                bcbranch = line.Replace(" ", "").Replace("SM", "").Replace("City", "").Replace("Showroom", "").Replace("ML", "")
                txtFile.Text = BptnInit() + "\" + bcbranch + Mid(TextBox4.Text, 5, 10) + ".XML"
            Else
                'txtFile.Text = "C:\PT" + Format(Now(), "yyMMdd") + ".XML"
                MsgBox("Error: UploadXML.INI not found.")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/TextBox4_TextChanged " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
            If TextBox2.Text.Length < 3 And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmCreateXML/TextBox4_KeyPress " & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class
