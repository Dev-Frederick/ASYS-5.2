Imports System.Data.SqlClient
Module Module1
    Public sDB As String
    Public fullname As String
    Public sdate As Date = Today ''gm01172013
    Public serverdate As String = sdate.ToString
    Public idnumber As Integer
    Public restrict As Integer
    Public BranchCode As String
    Public BranchName As String
    Public AllowMonth As Integer
    Public division As String
    Public AllowYear As Integer
    Public s_action As String
    Public s_class As String
    Public newreceiver As String
    Public SelectedForm As String
    Public SelectedType As String
    Public pricerel As String
    Public bleh As Boolean
    Public wee As Boolean '''2012-12-14 gm
    Public force As Boolean
    Public dserver As String
    Public outsource As Boolean
    Public radbutton As Integer
    Public rellot As Integer
    Public recrel2 As String
    Public recrel As Integer
    'NEW VERSION ELI ASYS 2.0
    Public dtrandate As DateTime
    'NEW VERSION ELI ASYS 2.0
    Public prcing As Boolean
    'Defined variable for connection
    Public pdate As Integer
    Public ConStrs As String
    Public sdatabases As String '= "remsLuzon"
    Public sdatasources As String '= "192.168.3.176"
    Public susernames As String '= "sa"
    Public spasswords As String '= "ml"
    Public recrelrep As Boolean
    Public userLog As String
    Public UserPassW As String
    Public mlwb, pricing, distri As Boolean
    Public rema As Boolean
    Public lot1234 As Integer
    Public ret As Boolean
    Public bc1 As String
    Public bn1 As String
    Public job_title As String
    Public ambot As Integer
    Public humres2 As String
    Public bedryf2 As String
    '''Public bedryfluzon2 As String
    Public zonebedryf As String   '''09-17-2013
    Public bedryfLuzon As String  '''09-17-2013
    '''Public bedryfvismin2 As String
    Public bedryfVismin As String '''09-17-2013
    Public bedryfVisayas As String '''10-30-2013 -------------
    Public bedryfShowroom As String
    Public bedryfMindanao As String
    Public bedryfLNCR As String
    Public mydb As String
    Public b1 As Integer
    Public b2 As String
    Public retbleh As Boolean
    Public relbleh As Boolean
    Public retcon As Boolean
    Public fixed As String
    Public st As Integer
    Public div1 As String
    Public month1 As Integer
    Public year1 As Integer
    Public myregion As String
    Public reclotno As Integer
    Public rellotno As Integer
    Public MainCost As String
    Public showvip As String
    Public p, a, o, l As String
    Public oo As Boolean
    Public form1user As String
    Public pao As Boolean
    Public recode As Boolean
    '--------Picture
    Public photodes As String
    Public LImageDestination As String
    Public LImageSource As String
    Public JewelrySDestination As String
    Public GoodstockSDestination As String
    Public SUsername As String
    Public SPassword As String
    Public XMLSource As String
    Public XMLDestination As String
    Public ARJDestination As String
    '----------
    Public pb_alreadysave As Boolean = Nothing
    '-----XML Consignment
    Public ImportExportServer As String
    Public ImportFolderJW As String
    Public ImportFolderWC As String
    Public ExportFolderBackup As String
    '-------------
    Public mlPrcing As Boolean
    Public photozoom As Integer
    Public lotreport As String
    Public mlwbreclot As String
    Public distrilot As String
    Public jobtitle As String
    Public pt As Boolean
    Public admintitle As Boolean
    Public mlwbq As String
    Public ispes As Boolean
    Public loadme As Boolean
    Public hulagway As Boolean
    Public bc As String
    Public bn As String
    Public byear As String
    Public bmonth As String
    Public SearchFlag As Boolean
    Public MountedPrice As Double
    Public SPrice As Double
    Public Smounted As Double
    Public ArrGold As New ArrayList
    Public ArrDia As New ArrayList
    Public ArrPearl As New ArrayList
    Public ArrPrecious As New ArrayList
    Public ArrSynthetic As New ArrayList
    Public ArrMountedTotal As New ArrayList
    Public ctrArrGold As Integer
    Public ctrArrDia As New Integer
    Public ctrArrPearl As New Integer
    Public ctrArrPrecious As New Integer
    Public ctrArrSynthetic As New Integer
    Public ctrArrMountedTotal As New Integer
    Public FlagGroup As Boolean
    Public SelectedTab As String
    Public TitleMsgBox As String = "ASYS 5.2"
    Public PictPath As Drawing.Image
    Public sort As Boolean
    Public FlagDistriClose As Boolean
    Public FlagPricingNotSave As Boolean
    Public FlagRptPrvw As Boolean
    Public GKarat As Double
    Public FlagLoggedIn As Boolean
    Public FlagClose As Boolean
    Public CreateDestination As String

    Function GetNewLotNumber(ByVal DeptType As String, ByVal TransType As String) As String
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            obj.Connectionstring3()
            obj.Open3()
            str = "Select Lotno from ASYS_Lotno_Gen WHERE BusinessCenter ='" & DeptType & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read Then
                GetNewLotNumber = dr.Item("lotno") + 1
            End If
            dr.Close()
            obj.Close3()
        Catch ex As Exception
        End Try
    End Function

End Module
