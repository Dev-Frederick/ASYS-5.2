Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms

Public Class clsCommon
    Private Shared instance As clsCommon
    Public Shared Function getInstance() As clsCommon
        If instance Is Nothing Then
            instance = New clsCommon
        End If
        Return instance
    End Function
    Private conn As New SqlConnection '(System.Configuration.ConfigurationSettings.AppSettings.Item("sqlconntracker"))
    Private connTrack As New SqlConnection '(System.Configuration.ConfigurationSettings.AppSettings.Item("sqlconntracker"))
    Private conn2 As New SqlConnection
    Private conn3 As New SqlConnection
    Private conn4 As New SqlConnection
    Private conn5 As New SqlConnection
    Private comTracker As SqlTransaction
    Private comTrack As New SqlCommand
    Private com5 As New SqlCommand
    Private com4 As New SqlCommand
    Private com As New SqlCommand
    Private com2 As New SqlCommand
    Private com3 As New SqlCommand
    Private ConStr As String
    Private ConStr2 As String
    Private Constr3 As String
    Private Constr4 As String
    Private ConStr5 As String
    Private dr5 As SqlDataReader
    Private dr4 As SqlDataReader
    Private dr3 As SqlDataReader
    Private dr As SqlDataReader
    Private dr2 As SqlDataReader
    'Private cn As SqlConnection
    Public sDatasource1 As String
    Public sDatabase1 As String
    Public sUsername1 As String
    Public sPassword1 As String
    Public sDatasource2 As String
    Public sDatabase2 As String
    Public sUsername2 As String
    Public sPassword2 As String
    Public sDatasource3 As String
    Public sDatabase3 As String
    Public sUsername3 As String
    Public sPassword3 As String
    Public FlagLoggedIn As Boolean
    Public Enum status
        receiving = 1
        sorting = 2
        released = 4
        costed = 3
        receivedByMLWB = 5
        releasedByMLWB = 6
        receivedByPRICING = 7
        releasedByPRICING = 8
        receivedByDISTRI = 9
        consign = 10
        releasedByDISTRI = 11
        PartialLukat = 12
        'add new status
        'forcedreceived = 5
    End Enum
    Public Function Newstatus(ByVal status As String) As Integer
        If Trim(status) = "RECEIVED" Then
            Newstatus = 1
        ElseIf Trim(status) = "SORTED" Then
            Newstatus = 2
        ElseIf Trim(status) = "COSTED" Then
            Newstatus = 3
        ElseIf Trim(status) = "RELEASED" Then
            Newstatus = 4
        End If
    End Function
    Public Function NewAction(ByVal action As String) As Integer
        If action = "OverAppraised" Then
            NewAction = 10
        ElseIf action = "GoodStock" Then
            NewAction = 4
        ElseIf action = "TakenBack" Then
            NewAction = 7
        ElseIf action = "Cellular" Then
            NewAction = 3
        ElseIf action = "Watch" Then
            NewAction = 8
        ElseIf action = "Fake" Then
            NewAction = 9
        ElseIf action = "Coated" Then
            NewAction = 5
        ElseIf action = "Jewelry" Then
            NewAction = 6
        ElseIf action = "Appliance" Then
            NewAction = 1
        ElseIf action = "AuctionBuyer" Then
            NewAction = 2
        ElseIf action = "MissingItem" Then
            NewAction = 12
        End If
    End Function
    Public Enum action As Integer
        OverAppraised = 10
        GoodStock = 4
        TakenBack = 7
        Cellular = 3
        Watch = 8
        Fake = 9
        Coated = 5
        Jewelry = 6
        Appliance = 1
        AuctionBuyer = 2
        MissingItem = 11
        Release = 12
    End Enum
    Public Sub ConnDb()
        Dim sPath, msg As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath

        Try
            Dim sr As StreamReader = New StreamReader(sPath + "\REMSystem1.INI")
            Dim Key_Server1, Key_Database1, Key_User1, Key_Pass1, Key_Humres, Key_Bedryf, Key_BedryfL, Key_BedryfVis As String
            Dim Key_BedryfS, Key_BedryfM, Key_BedryfLNCR As String


            Key_Server1 = "[Server]="
            Key_User1 = "[User]="
            Key_Database1 = "[Database]="
            Key_Pass1 = "[Password]="
            Key_Humres = "[Humres]="
            Key_Bedryf = "[Bedryf]="
            Key_BedryfL = "[BedryfL]="
            Key_BedryfVis = "[BedryfVis]="
            Key_BedryfS = "[BedryfS]="
            Key_BedryfM = "[BedryfM]="
            Key_BedryfLNCR = "[BedryfLNCR]="

            Dim line As String
            line = sr.ReadLine()
            While Not line Is Nothing
                line.Replace(" =", "=").Replace("= ", "=")
                If line.StartsWith(Key_Server1) Then
                    sDatasource1 = Replace(line, Key_Server1, "")
                    dserver = sDatasource1
                End If
                If line.StartsWith(Key_Database1) Then
                    sDatabase1 = Replace(line, Key_Database1, "")
                End If
                If line.StartsWith(Key_User1) Then
                    sUsername1 = Replace(line, Key_User1, "")
                End If
                If line.StartsWith(Key_Pass1) Then
                    sPassword1 = decryptPass(Replace(line, Key_Pass1, ""))
                End If
                If line.StartsWith(Key_Humres) Then
                    humres2 = Replace(line, Key_Humres, "")
                End If
                If line.StartsWith(Key_Bedryf) Then
                    bedryf2 = Replace(line, Key_Bedryf, "")
                End If
                If line.StartsWith(Key_BedryfL) Then
                    bedryfLuzon = Replace(line, Key_BedryfL, "")
                End If
                If line.StartsWith(Key_BedryfVis) Then
                    bedryfVisayas = Replace(line, Key_BedryfVis, "")
                End If
                If line.StartsWith(Key_BedryfS) Then
                    bedryfShowroom = Replace(line, Key_BedryfS, "")
                End If
                If line.StartsWith(Key_BedryfM) Then
                    bedryfMindanao = Replace(line, Key_BedryfM, "")
                End If
                If line.StartsWith(Key_BedryfLNCR) Then
                    bedryfLNCR = Replace(line, Key_BedryfLNCR, "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()



        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try


        ConStr5 = "Data Source = " + sDatasource1 + ";"
        ConStr5 = ConStr5 + ";Initial Catalog = " + sDatabase1
        ConStr5 = ConStr5 + ";User ID = " + sUsername1
        ConStr5 = ConStr5 + ";Password = " + sPassword1
        ConStrs = ConStr5

    End Sub
    Public Sub ConnectionString1()
        Dim sPath As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath
        Try
            Dim sr As StreamReader = New StreamReader(sPath + "\REMSystem.INI")
            Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1 As String

            If sDB = "" Then
                sDB = myregion
            End If
            If sDB = "Luzon" Then
                Key_Server1 = "[ServerL]="
                Key_DataBase1 = "[DataBaseL]="
                Key_User1 = "[UserL]="
                Key_Pass1 = "[PasswordL]="
            ElseIf sDB = "Vismin" Then
                Key_Server1 = "[ServerV]="
                Key_DataBase1 = "[DataBaseV]="
                Key_User1 = "[UserV]="
                Key_Pass1 = "[PasswordV]="
            ElseIf sDB = "Showroom" Then
                Key_Server1 = "[ServerS]="
                Key_DataBase1 = "[DataBaseS]="
                Key_User1 = "[UserS]="
                Key_Pass1 = "[PasswordS]="
            ElseIf sDB = "Visayas" Then
                Key_Server1 = "[ServerVis]="
                Key_DataBase1 = "[DataBaseVis]="
                Key_User1 = "[UserVis]="
                Key_Pass1 = "[PasswordVis]="
            ElseIf sDB = "Mindanao" Then
                Key_Server1 = "[ServerM]="
                Key_DataBase1 = "[DataBaseM]="
                Key_User1 = "[UserM]="
                Key_Pass1 = "[PasswordM]="
            ElseIf sDB = "LNCR" Then
                Key_Server1 = "[ServerLNCR]="
                Key_DataBase1 = "[DataBaseLNCR]="
                Key_User1 = "[UserLNCR]="
                Key_Pass1 = "[PasswordLNCR]="
            End If

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
        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try

        ConStr = "Data Source = " + sDatasource1 + ";"
        ConStr = ConStr + ";Initial Catalog = " + sDatabase1
        ConStr = ConStr + ";User ID = " + sUsername1
        ConStr = ConStr + ";Password = " + sPassword1
        ConStrs = ConStr
    End Sub

    Public Sub Connectionstring3()
        Dim sPath As String
        Dim frmMain1 As New frmMain
        Dim frm1 As New frmLoginNew
        sPath = frmMain1.sPath
        Try
            Dim sr As StreamReader = New StreamReader(sPath + "\REMS.INI")
            Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1, Key_Photo, Key_LImageDestination As String
            Dim Key_LImageSource, Key_JewelrySDestination, Key_GoodstockSDestination, Key_SUsername, Key_SPassword As String
            Dim Key_XMLSource, Key_XMLDestination, Key_ARJDestination, Key_ImportExportServer, Key_ImportFolderJW, Key_ImportFolderWC As String
            Dim Key_ExportFolderBackup As String


            Key_Server1 = "[Server]="
            Key_DataBase1 = "[DataBase]="
            Key_User1 = "[User]="
            Key_Pass1 = "[Password]="
            Key_Photo = "[Photo]="
            Key_LImageDestination = "[LImageDestination]="
            Key_LImageSource = "[LImageSource]="
            Key_JewelrySDestination = "[JewelrySDestination]="
            Key_GoodstockSDestination = "[GoodstockSDes]="
            Key_SUsername = "[SUsername]="
            Key_SPassword = "[SPassword]="
            Key_XMLSource = "[XMLSource]="
            Key_XMLDestination = "[XMLDestination]="
            Key_ARJDestination = "[ARJDestination]="
            Key_ImportExportServer = "[ImportExportServer]="
            Key_ImportFolderJW = "[ImportFolderJW]="
            Key_ImportFolderWC = "[ImportFolderWC]="
            Key_ExportFolderBackup = "[ExportFolderBackUp]="

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
                If line.StartsWith(Key_Photo) Then
                    photodes = Replace(line, Key_Photo, "")
                End If

                If line.StartsWith(Key_LImageDestination) Then
                    LImageDestination = Replace(line, Key_LImageDestination, "")
                End If
                If line.StartsWith(Key_LImageSource) Then
                    LImageSource = Replace(line, Key_LImageSource, "")
                End If
                If line.StartsWith(Key_JewelrySDestination) Then
                    JewelrySDestination = Replace(line, Key_JewelrySDestination, "")
                End If
                If line.StartsWith(Key_GoodstockSDestination) Then
                    GoodstockSDestination = Replace(line, Key_GoodstockSDestination, "")
                End If
                If line.StartsWith(Key_SUsername) Then
                    SUsername = Replace(line, Key_SUsername, "")
                End If
                If line.StartsWith(Key_SPassword) Then
                    SPassword = Replace(line, Key_SPassword, "")
                End If

                If line.StartsWith(Key_XMLSource) Then
                    XMLSource = Replace(line, Key_XMLSource, "")
                End If
                If line.StartsWith(Key_XMLDestination) Then
                    XMLDestination = Replace(line, Key_XMLDestination, "")
                End If

                If line.StartsWith(Key_ARJDestination) Then
                    ARJDestination = Replace(line, Key_ARJDestination, "")
                End If

                If line.StartsWith(Key_ImportExportServer) Then
                    ImportExportServer = Replace(line, Key_ImportExportServer, "")
                End If

                If line.StartsWith(Key_ImportFolderJW) Then
                    ImportFolderJW = Replace(line, Key_ImportFolderJW, "")
                End If
                '+ sDB + div1
                If line.StartsWith(Key_ImportFolderWC) Then
                    ImportFolderWC = Replace(line, Key_ImportFolderWC, "")
                End If

                If line.StartsWith(Key_ExportFolderBackup) Then
                    ExportFolderBackup = Replace(line, Key_ExportFolderBackup, "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()
        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try
        Constr3 = "Data Source = " + sDatasource1 + ";"
        Constr3 = Constr3 + ";Initial Catalog = " + sDatabase1
        Constr3 = Constr3 + ";User ID = " + sUsername1
        Constr3 = Constr3 + ";Password = " + sPassword1
        ConStrs = Constr3
    End Sub
    Public Sub Connectionstring4()
        Dim sPath As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath
        Try
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
        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try

        Constr4 = "Data Source = " + sDatasource1 + ";"
        Constr4 = Constr4 + ";Initial Catalog = " + sDatabase1
        Constr4 = Constr4 + ";User ID = " + sUsername1
        Constr4 = Constr4 + ";Password = " + sPassword1
        ConStrs = Constr4
    End Sub
    Public Sub ConnectionString2()
        Dim sPath As String
        Dim frmMain1 As New frmMain
        sPath = frmMain1.sPath
        Try
            Dim sr As StreamReader = New StreamReader(sPath + "\REMSystem.INI")
            Dim Key_Server1, Key_DataBase1, Key_User1, Key_Pass1 As String

            If sDB = "" Then
                sDB = myregion
            End If

            If sDB = "Luzon" Then
                Key_Server1 = "[ServerL]="
                Key_DataBase1 = "[DataBaseL]="
                Key_User1 = "[UserL]="
                Key_Pass1 = "[PasswordL]="
            ElseIf sDB = "Vismin" Then
                Key_Server1 = "[ServerV]="
                Key_DataBase1 = "[DataBaseV]="
                Key_User1 = "[UserV]="
                Key_Pass1 = "[PasswordV]="
            ElseIf sDB = "Showroom" Then
                Key_Server1 = "[ServerS]="
                Key_DataBase1 = "[DataBaseS]="
                Key_User1 = "[UserS]="
                Key_Pass1 = "[PasswordS]="
            ElseIf sDB = "Mindanao" Then
                Key_Server1 = "[ServerM]="
                Key_DataBase1 = "[DataBaseM]="
                Key_User1 = "[UserM]="
                Key_Pass1 = "[PasswordM]="
            ElseIf sDB = "LNCR" Then
                Key_Server1 = "[ServerLNCR]="
                Key_DataBase1 = "[DataBaseLNCR]="
                Key_User1 = "[UserLNCR]="
                Key_Pass1 = "[PasswordLNCR]="
            End If

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
        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try

        ConStr2 = "Data Source = " + sDatasource1 + ";"
        ConStr2 = ConStr2 + ";Initial Catalog = " + sDatabase1
        ConStr2 = ConStr2 + ";User ID = " + sUsername1
        ConStr2 = ConStr2 + ";Password = " + sPassword1

    End Sub
    Public Function Opentracker2()
        connTrack.ConnectionString = Constr3
        connTrack.Open()
    End Function
    Public Function Opentracker3()
        connTrack.ConnectionString = Constr4
        connTrack.Open()
    End Function
    Public Function Opentracker()
        connTrack.ConnectionString = ConStr
        connTrack.Open()
    End Function
    Public Function Open()
        conn.ConnectionString = ConStr
        conn.Open()
    End Function
    Public Function Open3()
        conn3.ConnectionString = Constr3
        conn3.Open()
    End Function
    Public Function Open4()
        conn4.ConnectionString = Constr4
        conn4.Open()
    End Function
    Public Function Open5()
        conn5.ConnectionString = ConStr5
        conn5.Open()
    End Function
    Public Sub Open2()
        conn.ConnectionString = ConStr2
        conn.Open()
    End Sub
    Public Sub Close()
        conn.Close()
    End Sub
    Public Sub Close4()
        conn.Close()
    End Sub
    Public Sub Close5()
        conn.Close()
    End Sub
    Public Sub Close3()
        conn.Close()
    End Sub
    Public Sub Close2()
        conn.Close()
    End Sub
    Public Sub CreateCom()
        comTracker = connTrack.BeginTransaction()
        comTrack = connTrack.CreateCommand
    End Sub

    Public Sub commandTrack(ByVal sCommand As String)
        comTrack.Connection = connTrack
        comTrack.Transaction = comTracker
        comTrack.CommandTimeout = 600
        comTrack.CommandText = sCommand
    End Sub
    Public Sub Command(ByVal sCommand As String)
        com = conn.CreateCommand
        com.CommandTimeout = 600
        com.CommandText = sCommand
    End Sub
    Public Sub Command2(ByVal sCommand As String)
        com2 = conn.CreateCommand
        com2.CommandTimeout = 600
        com2.CommandText = sCommand
    End Sub
    Public Sub Command3(ByVal sCommand As String)
        com3 = conn3.CreateCommand
        com3.CommandTimeout = 600
        com3.CommandText = sCommand
    End Sub
    Public Sub Command4(ByVal sCommand As String)
        com4 = conn4.CreateCommand
        com4.CommandTimeout = 600
        com4.CommandText = sCommand
    End Sub
    Public Sub Command5(ByVal sCommand As String)
        com5 = conn5.CreateCommand
        com5.CommandTimeout = 600
        com5.CommandText = sCommand
    End Sub
    Public Function OpenDataReader() As SqlDataReader
        dr = com.ExecuteReader
        Return dr
    End Function
    Public Function OpenDataReader3() As SqlDataReader
        dr3 = com3.ExecuteReader
        Return dr3
    End Function
    Public Function OpenDataReader4() As SqlDataReader
        dr4 = com4.ExecuteReader
        Return dr4
    End Function
    Public Function OpenDataReader5() As SqlDataReader
        dr5 = com5.ExecuteReader
        Return dr5
    End Function
    Public Function OpenDataReader2() As SqlDataReader
        dr2 = com2.ExecuteReader
        Return dr2
    End Function
    Public Sub CloseDataReader()
        dr.Close()
    End Sub
    Public Sub RollBackTrack()
        comTracker.Rollback()
    End Sub
    Public Sub CommitTrack()
        comTracker.Commit()
    End Sub
    Public Function TrackExecute() As Integer
        Return comTrack.ExecuteNonQuery()
    End Function
    Public Function Execute() As Integer
        Return com.ExecuteNonQuery()
    End Function
    Public Function Execute2() As Integer
        Return com2.ExecuteNonQuery()
    End Function
    Public Function Execute3() As Integer
        Return com3.ExecuteNonQuery()
    End Function
    Public Function Execute4() As Integer
        Return com4.ExecuteNonQuery()
    End Function
    Public Function Execute5() As Integer
        Return com5.ExecuteNonQuery()
    End Function
    Public Sub Release()
        conn = Nothing
        com = Nothing
        ConStr = Nothing
        dr = Nothing
    End Sub
    Public Class DateTime
        Public s_Time As String
        Public s_Date As String
        Public Sub Split(ByVal odatetime As Object)
            Dim sdate As String = CDate(odatetime)
            s_Time = ""
            s_Date = ""
            If sdate.Length = 19 Then
                s_Time = sdate.Substring(8).Trim
                s_Date = sdate.Substring(0, 9).Trim
            ElseIf sdate.Length = 20 Then
                s_Time = sdate.Substring(9).Trim
                s_Date = sdate.Substring(0, 9).Trim
            ElseIf sdate.Length = 21 Then
                s_Time = sdate.Substring(10).Trim
                s_Date = sdate.Substring(0, 10).Trim
            ElseIf sdate.Length = 22 Then
                s_Time = sdate.Substring(11).Trim
                s_Date = sdate.Substring(0, 10).Trim
            End If
        End Sub

        Public Function Time() As String
            Return s_Time
        End Function
        Public Function PTNDate() As String
            Return s_Date
        End Function
    End Class

#Region " private function "
    'validates data if null returns a word null else returns string 
    Public Function iSnullDBl(ByVal Sdata As Object) As Double
        If Sdata = "" Then
            Return "0"
        Else
            Return CDbl(Sdata)
        End If
    End Function
    Public Function IsNull(ByVal odata As Object) As String
        If IsDBNull(odata) Then
            Return "0"
        Else
            Return CStr(odata)
        End If
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

#End Region
End Class
