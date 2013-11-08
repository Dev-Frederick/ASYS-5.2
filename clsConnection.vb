Imports System.Data.SqlClient
Imports System.IO
Imports System.Data


Public Class clsConnection
    Public sDatasource1 As String
    Public sDatabase1 As String
    Public sUsername1 As String
    Public sPassword1 As String
    Public sDatasource2 As String
    Public sDatabase2 As String
    Public sUsername2 As String
    Public sPassword2 As String
    '''''''''''''''''''01-04-2013
    Public ps_server As String
    Public ps_dbname As String
    Public ps_dbuser As String
    Public ps_dbpwd As String
    Public ps_photo As String
    '''''''''''''''''''''''''''''
    Dim con As SqlConnection
    Dim jpoy As String
    Private Shared instance As clsConnection
    Public Shared Function getInstance() As clsConnection
        If instance Is Nothing Then
            instance = New clsConnection
        End If
        Return instance
    End Function

    Public Sub New()
        con = New SqlClient.SqlConnection
    End Sub

    Public Sub Dispose()
        con.Close()
    End Sub

    Public Function Connection() As Boolean
        Dim sPath As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath
        Try
            If con.State Then
                con.Close()
            End If

            Dim sr As StreamReader = New StreamReader(sPath + "\REMS.INI")
            Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1 As String

            Key_Server1 = "[Server]="
            Key_DataBase1 = "[DataBase]="
            Key_User1 = "[User]="
            Key_Pass1 = "[Password]="

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
                    sPassword1 = decryptPass(Replace(line, Key_Pass1, ""))
                End If
                line = sr.ReadLine()
            End While
            sr.Close()

            jpoy = "Data Source = " + sDatasource1 + ";"          ' local is the source
            jpoy = jpoy + ";Initial Catalog = " + sDatabase1 ' poi is the name of the database
            jpoy = jpoy + ";User ID = " + sUsername1       ' sa is the username
            jpoy = jpoy + ";Password = " + sPassword1     ' ma is the password

            con.ConnectionString = jpoy
            con.Open()
            Connection = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Connection = False
        End Try
    End Function
    Function decryptPass(ByVal RawStr As String) As String
        Dim i As Integer
        Dim decryptedPass As String
        i = 3
        decryptedPass = ""
        While i < RawStr.Length
            decryptedPass = decryptedPass + RawStr.Substring(i - 1, 1)
            i = NextPrime(i)
        End While
        decryptPass = decryptedPass
    End Function
    Function NextPrime(ByVal i As Integer) As Integer
        Dim ctr As Integer
        ctr = i + 1
        While Not isPrime(ctr)
            ctr = ctr + 1
        End While
        NextPrime = ctr
    End Function
    Function isPrime(ByVal i As Integer) As Boolean
        If i = 3 Or i = 5 Then Return True
        If i Mod 2 = 0 Then Return False
        If i Mod 3 = 0 Then Return False
        If i Mod 5 = 0 Then Return False
        Return True
    End Function
    Public Function DR(ByVal sqltxt As String, ByRef rdr As SqlClient.SqlDataReader) As Boolean
        Try
            Dim com As SqlClient.SqlCommand
            com = con.CreateCommand
            com.CommandTimeout = 600
            com.CommandText = sqltxt
            rdr = com.ExecuteReader
            DR = True
        Catch ex As Exception
            MsgBox(ex.Message)
            DR = False
        End Try

    End Function
End Class
