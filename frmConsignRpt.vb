Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports WinHttp
Imports System.IO
Imports System
Imports System.Net.WebClient
Imports System.Net.Sockets.Socket
Imports System.Text
Public Class frmConsignRpt
    Inherits System.Windows.Forms.Form
    Public WithEvents oRpt As ReportDocument
    Dim objcommom As New clsCommon
    Dim objclass As New clsCommon
    Private strFile As String
    Public sDB, sServer, ssaPass, FirstTS As String
    Public bcbranch As String
    Dim Upload As String = "C:\UploadXML\"
    Dim ShowALL As String
    Dim zonecode As String
    Dim serverDate As Date
    Dim XMLSequenceNO As String

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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConsignRpt))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 96)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(672, 344)
        Me.CrystalReportViewer1.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "PREVIEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "BRANCH CODE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "BRANCH NAME"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(216, 24)
        Me.TextBox1.MaxLength = 3
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 57
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(216, 48)
        Me.TextBox2.MaxLength = 50
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 58
        Me.TextBox2.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(392, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "MONTH"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(560, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "YEAR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(512, 48)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(144, 20)
        Me.TextBox3.TabIndex = 61
        Me.TextBox3.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "LOT NO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER"})
        Me.ComboBox1.Location = New System.Drawing.Point(448, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(104, 21)
        Me.ComboBox1.TabIndex = 63
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(600, 24)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(56, 21)
        Me.ComboBox2.TabIndex = 64
        '
        'frmConsignRpt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 438)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConsignRpt"
        Me.Text = "HEAD OFFICE ISSUANCE FORM"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConsignRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            Me.WindowState = FormWindowState.Maximized
            oRpt = New ReportDocument
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim crTables As Tables
            Dim sPath As String
            'Dim objclass As New clsReport
            'Dim frmMain1 As New frmMain
            ' sPath = frmMain1.sPath
            ComboBox1.Text = MonthName(Now.Month, False)
            Call pets()
            ComboBox2.Text = Now.Year
            Dim frm1 As New Form1
            sPath = frm1.spath
            'Me.TextBox3.ReadOnly = True
            TextBox3.BackColor = Color.White
        Catch ex As Exception
            MsgBox("frmConsignRpt/frmConsignRpt_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Button1.Enabled = False
            oRpt = New ReportDocument
            objcommom = New clsCommon
          
            Dim crtableLogoninfo As New TableLogOnInfo
            Dim crConnectionInfo As New ConnectionInfo
            Dim objclass1 As New clsCommon
            Dim crTables As Tables
            Dim objclass As New clsReport
            Dim sPath As String
            Dim frm As New Form1
            Dim frmMain1 As New frmMain

            sPath = frmMain1.sPath


            oRpt.Load(sPath + "\ASYS_Distri_Consignment.rpt")
            oRpt.SetParameterValue("@plotno", lot1234)

            objcommom.Connectionstring3()
            With crConnectionInfo
                .ServerName = objcommom.sDatasource1
                .DatabaseName = objcommom.sDatabase1
                .UserID = objcommom.sUsername1
                .Password = objcommom.sPassword1
            End With
            crTables = oRpt.Database.Tables
            crtableLogoninfo.ConnectionInfo = crConnectionInfo

            crTables.Item("ASYS_Consignment;1").ApplyLogOnInfo(crtableLogoninfo)
            crTables.Item("ASYS_Consignment;1").Location = objcommom.sDatabase1 + ".dbo.ASYS_Consignment;1"
            'oRpt.Refresh()
            CrystalReportViewer1.ReportSource = oRpt
            Button1.Enabled = True

            'If Label1.Text = "BRANCH CODE" Then
            '    If fnGetZoneCode() = True Then
            '        If zonecode <> "<none>" Then
            '            Upload = "\\" & objcommom.sDatasource1 & "\c$\IMPORT\" & zonecode & "\" & div1 & "\"
            '        End If
            '        If Not Directory.Exists(Upload) Then
            '            IO.Directory.CreateDirectory(Upload)
            '        End If
            '    Else
            '        MsgBox("XML not successfully uploaded.", MsgBoxStyle.Information, TitleMsgBox)
            '        Exit Sub
            '    End If
           

            If Label1.Text = "BRANCH CODE" Then
                If GetIsCreated(TextBox3.Text) <> True Then

                    XMLSequenceNO = GetNewLotNumber("XMLSEQUENCE", "").ToString.PadLeft(6, "0")
                    UpdateLOTNO()

                    If Not Directory.Exists(XMLSource) Then
                        IO.Directory.CreateDirectory(XMLSource)
                    End If

                    CreateXML(XMLSource & TextBox1.Text & Mid(TextBox3.Text, 1, 4) & XMLSequenceNO & ".XML")
                End If
            End If

            'End If

        Catch ex As Exception
            MsgBox("frmConsignRpt/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function GetIsCreated(ByVal CLotno As String) As Boolean

        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            GetIsCreated = False
            obj.Connectionstring3()
            obj.Open3()
            str = "Select IsCreated from ASYS_Consign_Header WHERE lotno ='" & CLotno & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read Then
                If dr.Item("IsCreated") <> 0 Then
                    GetIsCreated = True
                End If
            End If
            dr.Close()
            obj.Close3()
        Catch ex As Exception

        End Try
    End Function
    Private Sub UpdateLOTNO()
        Dim obj As New clsCommon
        Dim dr As SqlDataReader
        Dim objSEQ As New clsCommon

        objSEQ = New clsCommon
        objSEQ.Connectionstring3()
        objSEQ.Opentracker2()
        objSEQ.CreateCom()

        objSEQ.commandTrack("Update ASYS_Lotno_gen set lotno =lotno + 1 WHERE BusinessCenter ='XMLSEQUENCE'")
        objSEQ.TrackExecute()
        objSEQ.CommitTrack()
        objSEQ.Close()
    End Sub

    Private Function fnGetZoneCode() As Boolean
        Dim objclass1 As New clsCommon
        Dim dr As SqlDataReader

        fnGetZoneCode = False
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            objclass1 = New clsCommon
            objclass1.ConnDb()
            objclass1.Open5()
            'nigel commented here bang.. aheheh
            'If sDB = "" Then
            objclass1.Command5("Select getdate() as ServerDate,* from " & bedryf2 & " where bedrnr='" + TextBox1.Text.Trim + "' and bedrnm = '" & TextBox2.Text.Trim & "'")
            'End If

            dr = objclass1.OpenDataReader5
            If dr.Read Then
                serverDate = dr.Item("ServerDate")
                zonecode = UCase(Trim(dr.Item("class_02")))
                ShowALL = Trim(dr.Item("class_03"))
                div1 = TextBox1.Text
            Else
                MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
            End If
            dr.Close()
            'objclass.CloseDataReader()
            objclass1.Close5()
            objclass1 = Nothing
            fnGetZoneCode = True
        End If
        ''If (zonecode = "MINDANAO") Or (zonecode = "VISAYAS") Then
        ''    zonecode = "VISMIN"
        If zonecode = "VISAYAS" Then
            zonecode = "VISAYAS"
        ElseIf zonecode = "MINDANAO" Then
            zonecode = "MINDANAO"
        ElseIf zonecode = "LUZON" Then
            zonecode = "LUZON"
        ElseIf zonecode = "SHOWROOMS" Then
            ShowALL = Replace(ShowALL, "/NCR-SHOWROOMS", "")
            ShowALL = Replace(ShowALL, "-SHOWROOMS", "")
            zonecode = ShowALL
            '' zonecode = "SHOWROOM"
        End If
        If zonecode = "<NONE>" Then
            zonecode = "US-HO"
        End If

        'If (zonecode <> "LUZON") Or (zonecode <> "VISMIN") Or (zonecode <> "VISAYAS") Or (zonecode <> "LUZON") Then
        '    ShowALL = Replace(ShowALL, "/NCR-SHOWROOMS", "")
        '    ShowALL = Replace(ShowALL, "-SHOWROOMS", "")
        '    zonecode = ShowALL
        'End If
    End Function
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            Dim dr As SqlDataReader
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
            If e.KeyChar = ChrW(13) Then
                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()
                If sDB = "" Then
                    objclass.Command5("Select * from " & bedryf2 & " where bedrnr='" + TextBox1.Text.Trim + "'")
                End If

                dr = objclass.OpenDataReader5
                If dr.Read Then
                    div1 = TextBox1.Text
                    TextBox2.Text = Trim(dr.Item("bedrnm"))
                Else
                    MsgBox("Branch Code does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox1.Focus()
                End If
                dr.Close()
                'objclass.CloseDataReader()
                objclass.Close5()
                objclass = Nothing
            End If
        Catch ex As Exception
            MsgBox("frmConsignRpt/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try

            If e.KeyChar = ChrW(13) Then
                Dim dr As SqlDataReader
                Dim str As String

                objclass = New clsCommon
                objclass.ConnDb()
                objclass.Open5()

                str = "Select top 1* from " & bedryf2 & " where bedrnm like '%" + TextBox2.Text.Trim + "%'"
                objclass.Command5(str)
                dr = objclass.OpenDataReader5
                If dr.Read Then
                    TextBox1.Text = Trim(dr.Item("bedrnr"))
                    TextBox2.Text = Trim(dr.Item("bedrnm"))
                    div1 = TextBox1.Text
                Else
                    MsgBox("Branch Name does not exist.", MsgBoxStyle.Information, TitleMsgBox)
                    TextBox1.Focus()
                End If
                dr.Close()
                'objclass.CloseDataReader()
                objclass.Close5()
                objclass = Nothing
            End If

        Catch ex As Exception
            MsgBox("frmConsignRpt/TextBox2_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            month1 = ComboBox1.SelectedIndex + 1
        Catch ex As Exception
            MsgBox("frmConsignRpt/ComboBox1_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            year1 = ComboBox2.Text
        Catch ex As Exception
            MsgBox("frmConsignRpt/ComboBox2_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Try
            lot1234 = TextBox3.Text


        Catch ex As Exception
            MsgBox("frmConsignRpt/TextBox3_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If
        Catch ex As Exception
            MsgBox("frmConsignRpt/TextBox3_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Function pets()
        Try
            Dim pe, ts, petsa As Integer
            petsa = Now.Year
            For pe = 1 To 5
                Me.ComboBox2.Items.Add(petsa)
                petsa = petsa - 1
            Next
        Catch ex As Exception
            MsgBox("frmConsignRpt/pets: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub CreateXML(ByVal serverIP As String)
Errmsg:
        Dim a As Integer
        'Start,analisa comment for trappings of cellphone and watches 20110822
        'Transfer below
        'Dim FO As New StreamWriter(serverIP)
        'FO.WriteLine("<?xml version=""1.0"" ?>")
        'FO.WriteLine("<eExact xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""eExact-Schema.xsd"">")
        'End,analisa comment for trappings of cellphone and watches 20110822
        Dim conn As New SqlConnection
        Dim com As New SqlCommand
        Dim dr As SqlDataReader
        Dim ConStr, SelectStr, gl, b As String
        Dim Constr1 As String
        Dim conn2 As New SqlConnection
        Dim com2 As New SqlCommand
        Dim dr2 As SqlDataReader
        Dim dr3 As SqlDataReader
        Dim conn4 As New SqlConnection
        Dim conn6 As New SqlConnection
        Dim conn7 As New SqlConnection
        Dim com7 As New SqlCommand
        Dim dr7 As SqlDataReader
        Dim str7 As String
        Dim com6 As New SqlCommand
        Dim dr6 As SqlDataReader
        Dim com4 As New SqlCommand
        Dim dr4 As SqlDataReader
        Dim conn3 As New SqlConnection
        Dim conn5 As New SqlConnection
        Dim com5 As New SqlCommand
        Dim dr5 As SqlDataReader
        Dim com3 As New SqlCommand
        Dim hasCond As Boolean
        Dim tmpLast, str1, str2 As String
        Dim tmp1, dtabs As String
        Dim frm1 As New Form1
        Dim tmpLastBin As String
        Dim picBlob As String
        Dim ErrMsg As Integer



        '/*analisa 20110822
        Dim assortment As SqlDataReader
        'analisa 20110822*/
        Try
            If Me.TextBox1.Text = "" Then
                MsgBox("Please enter branch code.")
                Exit Sub
            ElseIf Me.TextBox2.Text = "" Then
                MsgBox("Please enter branch name.")
                Exit Sub
            ElseIf Me.TextBox3.Text = "" Then
                MsgBox("Please enter lotno.")
                Exit Sub
            Else

                objcommom.Connectionstring3()

                dtabs = dserver
                If sDB = "" Then
                    sDB = "REMS"
                End If
                Constr1 = "Data Source =" & dtabs & ""
                Constr1 = Constr1 + ";Initial Catalog = " + sDB
                Constr1 = Constr1 + ";User ID = sa"
                Constr1 = Constr1 + ";Password = ml"

                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If

                conn.ConnectionString = Constr1
                conn.Open()
                com = conn.CreateCommand
                hasCond = False
                'SelectStr = "Select * from Items where Len(itemcode)=17 and UserDate_05 is not null and UserNumber_01 is not null"
                'SelectStr = "Select * from [264].DBO.Items where Len(itemcode)=17 and UserDate_05 is not null and UserNumber_01 is not null and Month(Userdate_05)=" & Now.Month & ""
                'SelectStr = "Select picture,* from [264].DBO.Items where Len(itemcode)=17 and UserDate_05 is not null and UserNumber_01 is not null and itemcode in(Select allbarcode from rems.dbo.ASYS_Consign_detail where lotno ='" & TextBox3.Text & "')"
                'SelectStr = "Select picture,* from [264].DBO.Items where Len(itemcode)=17 and UserDate_05 is not null and UserNumber_01 is not null and itemcode in(Select allbarcode from rems.dbo.ASYS_Consign_detail where lotno ='" & TextBox3.Text & "')"
                SelectStr = "SELECT TOP 1 a.Assortment FROM [264].dbo.Items a INNER JOIN REMS.dbo.ASYS_Consign_Detail b ON a.ItemCode = b.ALLBarcode WHERE (LEN(a.ItemCode) = 17) AND (a.UserDate_05 IS NOT NULL) AND (a.UserNumber_01 IS NOT NULL) and b.lotno = '" & TextBox3.Text & "'"
                com.CommandText = SelectStr
                assortment = com.ExecuteReader

                assortment.Read()
                If Not assortment Is Nothing Then
                    If assortment.FieldCount > 0 Then
                        If assortment.Item(0).ToString = "400" Or assortment.Item(0).ToString = "300" Then
                            If Label1.Text = "BRANCH CODE" Then
                                If fnGetZoneCode() = True Then
                                    If zonecode <> "<none>" Then
                                        Upload = ImportFolderWC & zonecode & "\" & div1 & "\"
                                    End If
                                    CreateDestination = "\\" & ImportExportServer & "\c$\IMPORT\WC\" & zonecode & "\" & div1 & "\"
                                    If Not Directory.Exists(CreateDestination) Then
                                        IO.Directory.CreateDirectory(CreateDestination)
                                    End If
                                Else
                                    MsgBox("XML not successfully uploaded.", MsgBoxStyle.Information, TitleMsgBox)
                                    Exit Sub
                                End If

                                CreateXML(Upload & div1 & serverDate.Year & Mid(TextBox3.Text, 5, 6) & ".XML")
                            End If
                        Else

                            If Label1.Text = "BRANCH CODE" Then
                                If fnGetZoneCode() = True Then
                                    If zonecode <> "<none>" Then
                                        Upload = ImportFolderJW & zonecode & "\" & div1 & "\"
                                    End If
                                    CreateDestination = "\\" & ImportExportServer & "\c$\IMPORT\JW\" & zonecode & "\" & div1 & "\"
                                    If Not Directory.Exists(CreateDestination) Then
                                        IO.Directory.CreateDirectory(CreateDestination)
                                    End If
                                Else
                                    MsgBox("XML not successfully uploaded.", MsgBoxStyle.Information, TitleMsgBox)
                                    Exit Sub
                                End If
                                ''CreateXML(Upload & div1 & serverDate.Year & Mid(TextBox3.Text, 5, 6) & ".XML")
                            End If
                        End If
                    End If
                End If
                assortment.Close()


                SelectStr = "SELECT     b.PhotoName AS photoname, a.Picture AS picture, * FROM [264].dbo.Items a INNER JOIN REMS.dbo.ASYS_Consign_Detail b ON a.ItemCode = b.ALLBarcode WHERE (LEN(a.ItemCode) = 17) AND (a.UserDate_05 IS NOT NULL) AND (a.UserNumber_01 IS NOT NULL) and b.lotno = '" & TextBox3.Text & "'"
                com.CommandText = SelectStr

                If conn2.State = ConnectionState.Open Then
                    conn2.Close()
                End If
                conn2.ConnectionString = Constr1
                conn2.Open()
                com2 = conn2.CreateCommand
                dr = com.ExecuteReader
                Dim i, rctr As Integer

                'Start,analisa comment for trappings of cellphone and watches 20110822
                'Edit for fixes


                Dim FO As New StreamWriter(serverIP)
                FO.WriteLine("<?xml version=""1.0"" ?>")
                FO.WriteLine("<eExact xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:noNamespaceSchemaLocation=""eExact-Schema.xsd"">")
                'End,analisa comment for trappings of cellphones and watches 201108
                FO.WriteLine("<Items>")
                rctr = 0
                FO.AutoFlush = True
                Dim by As System.Data.SqlTypes.SqlBinary
                While dr.Read

                    Call UploadFile(dr.Item("Photoname"), dr.Item("itemcode"))

                    rctr = rctr + 1
                    If rctr Mod 20 Then
                        FO.Flush()
                        'TxtFileSize.Text = Format(Microsoft.VisualBasic.FileSystem.FileLen(txtFile.Text), "#,###")
                    End If
                    'TextBox1.Text = dr.Item("Ptn").ToString
                    'TextBox1.Text = tmpLast
                    Me.Refresh()
                    FO.WriteLine(" <Item code=""" & dr.Item("Itemcode") & """  type=""" & dr.Item("Type") & """ searchcode=""" & dr.Item("searchcode") & """>")
                    FO.WriteLine(" <Description>" + SplChars(dr.Item("Description")) + "</Description>")
                    FO.WriteLine(" <MultiDescriptions>")
                    a = 0
                    For i = 114 To 119 - 1
                        'by = dr.GetSqlBinary(i)
                        tmpLast = SplChars(IsNull(dr.Item("Description_" & a & "")))
                        ConStr = " <MultiDescription number=""" & a & """>"
                        ConStr = ConStr + tmpLast

                        ConStr = ConStr + " </MultiDescription>"
                        FO.WriteLine(ConStr)
                        a += 1
                    Next
                    FO.WriteLine(" </MultiDescriptions>")
                    FO.WriteLine("  <Assortment number=""" & dr.Item("assortment") & """ code=""" & dr.Item("assortment") & """>")

                    If conn6.State = ConnectionState.Open Then
                        conn6.Close()
                    End If

                    Dim GLRevenueVal As String = ""
                    Dim GLCostVal As String = ""
                    Dim GLPurchaseVal As String = ""
                    Dim reknrVal As String

                    conn6.ConnectionString = Constr1
                    conn6.Open()
                    com6 = conn6.CreateCommand
                    com6.CommandText = "Select * from [264].DBO.ItemAssortment where assortment=" & dr.Item("Assortment") & ""
                    dr6 = com6.ExecuteReader
                    If dr6.Read Then
                        GLRevenueVal = dr6.Item("GLRevenue")
                        GLCostVal = dr6.Item("GLCostofGoodsSold")
                        GLPurchaseVal = dr6.Item("GLStock")

                        If dr6.Item("Assortment") = 103 Then
                            FO.WriteLine("   <Description>Bracelet &amp; Anklets</Description>")
                        ElseIf dr6.Item("Assortment") = 107 Then
                            FO.WriteLine("   <Description>Terno &amp; Set</Description>")
                        Else
                            FO.WriteLine("   <Description>" & dr6.Item("Description") & "</Description>")
                        End If
                    End If
                    dr6.Close()
                    conn6.Close()
                    For a = 122 To 124
                        If a = 122 Then
                            gl = "GLRevenue"
                            reknrVal = GLRevenueVal
                        ElseIf a = 123 Then
                            gl = "GLCost"
                            reknrVal = GLCostVal
                        Else
                            gl = "GLPurchase"
                            reknrVal = GLPurchaseVal
                        End If


                        Dim sqlStr As String
                        sqlStr = "Select * from [264].DBO.grtbk Where reknr='" + reknrVal + "'"
                        com2.CommandText = sqlStr
                        dr2 = com2.ExecuteReader
                        If dr2.Read Then
                            FO.WriteLine("  <" & gl & " code=""" & dr2.Item("reknr") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                            FO.WriteLine("   <Description>" & dr2.Item("oms25_0") & "</Description>")
                            FO.WriteLine("  </" & gl & ">")
                        Else
                            FO.WriteLine("  <" & gl & " code="" side="" type="" subtype="">")
                            FO.WriteLine("   <Description></Description>")
                            FO.WriteLine("  </" & gl & ">")
                        End If
                        dr2.Close()
                    Next
                    FO.WriteLine("  </Assortment>")

                    If conn3.State = ConnectionState.Open Then
                        conn3.Close()
                    End If

                    conn3.ConnectionString = Constr1
                    conn3.Open()
                    com3 = conn3.CreateCommand
                    com3.CommandText = "Select * from [264].DBO.Itemcountries where itemcode='" & dr.Item("itemcode") & "'"
                    dr3 = com3.ExecuteReader
                    If dr3.Read Then
                        FO.WriteLine("  <Availability>")
                        FO.WriteLine("   <DateStart>" & Format(dr3.Item("AvailableFrom"), "yyyy-MM-dd") & "</DateStart>")
                        FO.WriteLine("  </Availability>")
                    Else
                        FO.WriteLine("  <Availability>")
                        FO.WriteLine("   <DateStart></DateStart>")
                        FO.WriteLine("  </Availability>")

                    End If
                    dr3.Close()
                    FO.WriteLine("  <Condition>" & dr.Item("Condition") & "</Condition>")
                    FO.WriteLine("  <IsSalesItem>" & CInt(dr.Item("IsSalesItem")) & "</IsSalesItem>")
                    FO.WriteLine("  <IsPurchaseItem>" & CInt(dr.Item("IsPurchaseItem")) & "</IsPurchaseItem>")
                    FO.WriteLine("  <IsSerialNumberItem>" & CInt(dr.Item("IsSerialNumberItem")) & "</IsSerialNumberItem>")
                    FO.WriteLine("  <IsBatchItem>" & CInt(dr.Item("Isbatchitem")) & "</IsBatchItem>")
                    FO.WriteLine("  <IsSubAssemblyItem>" & CInt(dr.Item("IsSubAssemblyItem")) & "</IsSubAssemblyItem>")
                    FO.WriteLine("  <IsAssembledItem>" & CInt(dr.Item("IsAssembled")) & "</IsAssembledItem>")
                    FO.WriteLine("  <IsStockItem>" & CInt(dr.Item("IsStockItem")) & " </IsStockItem>")
                    FO.WriteLine("  <IsBackOrderItem>" & CInt(dr.Item("IsBackOrderItem")) & "</IsBackOrderItem>")
                    FO.WriteLine("  <IsPriceRegulationItem>" & CInt(dr.Item("IsPriceRegulationItem")) & "</IsPriceRegulationItem>")
                    FO.WriteLine("  <IsTextItem>" & CInt(dr.Item("IsTextItem")) & "</IsTextItem>")
                    FO.WriteLine("  <IsDiscountItem>" & CInt(dr.Item("IsDiscount")) & "</IsDiscountItem>")
                    FO.WriteLine("  <IsPrintItem>" & CInt(dr.Item("IsPrintItem")) & "</IsPrintItem>")
                    FO.WriteLine("  <RequiresApprovedSupplier>" & CInt(dr.Item("RequiresApprovedSupplier")) & "</RequiresApprovedSupplier>")
                    For a = 122 To 124
                        If a = 122 Then
                            gl = "GLRevenue"
                            reknrVal = GLRevenueVal
                        ElseIf a = 123 Then
                            gl = "GLCost"
                            reknrVal = GLCostVal
                        Else
                            gl = "GLPurchase"
                            reknrVal = GLPurchaseVal
                        End If

                        com2.CommandText = "Select * from [264].DBO.grtbk Where reknr='" + reknrVal + "'"
                        dr2 = com2.ExecuteReader
                        If dr2.Read Then
                            FO.WriteLine("   <" & gl & " code=""" & dr2.Item("reknr") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                            FO.WriteLine("    <Description>" & dr2.Item("oms25_0") & "</Description>")
                            FO.WriteLine("   </" & gl & ">")
                        End If
                        dr2.Close()
                    Next

                    FO.WriteLine("   <Sales>")
                    FO.WriteLine("    <Price type=""" & dr.Item("type") & """>")
                    FO.WriteLine("     <Currency code=""" & dr.Item("CostPRiceCurrency") & """/>")
                    FO.WriteLine("     <Value>" & dr.Item("SalesPackagePrice") & "</Value>")

                    If conn4.State = ConnectionState.Open Then
                        conn4.Close()
                    End If

                    conn4.ConnectionString = Constr1
                    conn4.Open()
                    com4 = conn4.CreateCommand
                    com4.CommandText = "Select top 1 * from [264].DBO.btwtrs order by btwtrans desc"
                    dr4 = com4.ExecuteReader
                    If dr4.Read Then
                        FO.WriteLine("      <VAT code=""" & dr4.Item("btwtrans") & """ type=""" & dr4.Item("code_iv") & """ vattype=""" & dr4.Item("exclus") & """>")
                        FO.WriteLine("      <Description>" & dr4.Item("oms30_0") & "</Description>")
                        FO.WriteLine("      <Percentage>" & dr4.Item("btwper") & "</Percentage>")
                        FO.WriteLine("      <Charged>" & dr4.Item("levy_per") & "</Charged>")
                    Else
                        FO.WriteLine("      <VAT code="" type="" vattype="">")
                        FO.WriteLine("      <Description></Description>")
                        FO.WriteLine("      <Percentage></Percentage>")
                        FO.WriteLine("      <Charged></Charged>")
                    End If

                    com2 = conn2.CreateCommand
                    com2.CommandText = "Select * from [264].DBO.grtbk Where reknr='" + dr4.Item("rek_btw_vk") + "'"
                    dr2 = com2.ExecuteReader
                    If dr2.Read Then
                        FO.WriteLine("      <GLToPay code=""" & dr4.Item("rek_btw_vk") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                        FO.WriteLine("       <Description>" & dr2.Item("oms25_0") & "</Description>")
                        FO.WriteLine("      </GLToPay>")
                    Else
                        FO.WriteLine("      <GLToPay code="""" side="""" type="""">")
                        FO.WriteLine("       <Description></Description>")
                        FO.WriteLine("      </GLToPay>")
                    End If
                    dr2.Close()

                    com2 = conn2.CreateCommand
                    com2.CommandText = "Select * from [264].DBO.grtbk Where reknr='" + dr4.Item("reknr") + "'"
                    dr2 = com2.ExecuteReader
                    If dr2.Read Then
                        FO.WriteLine("      <GLToClaim code=""" & dr4.Item("reknr") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                        FO.WriteLine("       <Description>" & dr2.Item("oms25_0") & "</Description>")
                        FO.WriteLine("      </GLToClaim>")
                    Else
                        FO.WriteLine("      <GLToClaim code="" side="" type="" subtype="">")
                        FO.WriteLine("       <Description></Description>")
                        FO.WriteLine("      </GLToClaim>")
                    End If


                    conn7.ConnectionString = Constr1
                    conn7.Open()
                    com7 = conn7.CreateCommand
                    com7.CommandText = "select Cost as CostPrice,currency as costpricecurrency,SerialNo from [REMS].DBO.ASYS_Consign_detail where allbarcode ='" & dr.Item("Itemcode") & "' and lotno ='" & TextBox3.Text & "'"
                    dr7 = com7.ExecuteReader
                    If dr7.Read Then
                        FO.WriteLine("        <Creditor code=""" & dr4.Item("creditor") & """ number=""" & dr4.Item("creditor") & """ type=""" & dr.Item("type") & """>")
                        FO.WriteLine("         <Name>Bureau of Internal Revenue</Name>")
                        FO.WriteLine("        </Creditor>")
                        FO.WriteLine("          <PaymentPeriod>" & dr4.Item("pay_period") & "</PaymentPeriod>")
                        FO.WriteLine("         </VAT>")
                        FO.WriteLine("       </Price>")
                        FO.WriteLine("       <Unit unit=""" & dr.Item("PackageDescription") & """ type=""" & dr2.Item("type_rek") & """>")
                        FO.WriteLine("       </Unit>")
                        FO.WriteLine("      </Sales>")
                        FO.WriteLine("      <Costs>")
                        FO.WriteLine("       <Price>")
                        FO.WriteLine("        <Currency code=""" & dr7.Item("CostPRiceCurrency") & """/>")
                        FO.WriteLine("        <Value>" & dr7.Item("CostPrice") & "</Value>")
                        FO.WriteLine("       </Price>")
                        FO.WriteLine("      </Costs>")
                        FO.WriteLine("       <Dimension>")
                        FO.WriteLine("        <WeightNet>" & dr.Item("Netweight") & "</WeightNet>")
                        FO.WriteLine("        <WeightGross>" & dr.Item("Netweight") & "</WeightGross>")
                        FO.WriteLine("       </Dimension>")
                    End If

                    If conn5.State = ConnectionState.Open Then
                        conn5.Close()
                    End If

                    conn5.ConnectionString = Constr1
                    conn5.Open()
                    com5 = conn5.CreateCommand
                    com5.CommandText = "Select * from [264].DBO.humres where res_id=" & dr.Item("syscreator") & ""
                    dr5 = com5.ExecuteReader
                    If dr5.Read Then
                        FO.WriteLine("    <Resource number=""" & dr5.Item("res_id") & """ code=""" & dr5.Item("usr_id") & """>")
                        FO.WriteLine("     <LastName>" & dr5.Item("sur_name") & "</LastName>")
                        FO.WriteLine("     <FirstName>" & dr5.Item("first_name") & "</FirstName>")
                        FO.WriteLine("     <MiddleName>" & dr5.Item("middle_name") & "</MiddleName>")
                        FO.WriteLine("    </Resource>")
                    Else
                        FO.WriteLine("    <Resource number="""" code="""">")
                        FO.WriteLine("     <LastName/>")
                        FO.WriteLine("     <FirstName/>")
                        FO.WriteLine("     <MiddleName/>")
                        FO.WriteLine("    </Resource>")
                    End If
                    dr5.Close()
                    conn5.Close()


                    ' picBlob = ImageToBase64(dr.Item("picture"), System.Drawing.Imaging.ImageFormat.Jpeg)

                    picBlob = ToBase64(dr.Item("picture"))
                    tmpLastBin = picBlob
                    FO.WriteLine("   <Image>")
                    FO.WriteLine("    <Name>" & dr.Item("Picturefilename") & "</Name>")
                    FO.WriteLine("    <BinaryData> " & tmpLastBin & " </BinaryData>")
                    FO.WriteLine("   </Image>")


                    FO.WriteLine("      <FreeFields>")
                    FO.WriteLine("      <FreeTexts>")
                    For a = 1 To 10
                        If a = 10 Then
                            b = a
                        Else
                            b = "0" & a
                        End If
                        If a = 1 Then
                            FO.WriteLine("         <FreeText number=""" & a & """>" & TextBox3.Text & "</FreeText>")
                        ElseIf a = 2 Then
                            FO.WriteLine("         <FreeText number=""" & a & """>" & dr7.Item("SerialNO") & "</FreeText>")
                        Else
                            FO.WriteLine("         <FreeText number=""" & a & """>" & dr.Item("UserField_" & b & "") & "</FreeText>")
                        End If

                    Next
                    FO.WriteLine("        </FreeTexts>")
                    FO.WriteLine("        <FreeDates>")
                    For a = 1 To 5
                        If IsNull(dr.Item("UserDate_0" & a & "")) = "" Then
                            tmp1 = IsNull(dr.Item("UserDate_0" & a & ""))
                        Else
                            tmp1 = Format(dr.Item("UserDate_0" & a & ""), "yyyy-MM-dd")

                        End If
                        FO.WriteLine("         <FreeDate number=""" & a & """ xsi:nil=""true"">" & tmp1 & "</FreeDate>")
                    Next
                    FO.WriteLine("        </FreeDates>")
                    FO.WriteLine("        <FreeNumbers>")
                    For a = 1 To 5
                        FO.WriteLine("         <FreeNumber number=""" & a & """>" & dr.Item("UserNumber_0" & a & "") & "</FreeNumber>")
                    Next
                    FO.WriteLine("        </FreeNumbers>")
                    FO.WriteLine("        <FreeYesNos>")
                    For a = 1 To 5
                        FO.WriteLine("         <FreeYesNo number=""" & a & """>" & CInt(dr.Item("UserYesNo_0" & a & "")) & "</FreeYesNo>")
                    Next
                    FO.WriteLine("        </FreeYesNos>")
                    FO.WriteLine("       </FreeFields>")
                    FO.WriteLine("       <ItemCategory number=""" & dr.Item("SecurityLevel") & """ code=""" & dr.Item("Class_10") & """>")
                    If IsNull(dr.Item("Class_10")) = "ML" Then
                        FO.WriteLine("        <Description>Money Lending</Description>")
                    ElseIf IsNull(dr.Item("Class_10")) = "JW" Then
                        FO.WriteLine("        <Description>Jewellers</Description>")
                    Else
                        FO.WriteLine("        <Description></Description>")
                    End If
                    FO.WriteLine("       </ItemCategory>")
                    FO.WriteLine("       <ItemAccounts>")
                    FO.WriteLine("        <ItemAccount default=""" & dr.Item("StatisticalFactorSales") & """>")
                    FO.WriteLine("         <Account Code=""" & dr.Item("lev_crdnr") & """ type=""" & dr.Item("type") & """ status=""" & dr.Item("Condition") & """>")

                    conn5.ConnectionString = Constr1
                    conn5.Open()
                    com5 = conn5.CreateCommand
                    com5.CommandText = "Select * from [264].DBO.kstpl where oms25_0 ='A.L.L. CEBU'"
                    dr5 = com5.ExecuteReader
                    If dr5.Read Then
                        FO.WriteLine("          <Name>" & dr5.Item("oms25_0") & "</Name>")
                        FO.WriteLine("          <Creditor Number=""" & dr.Item("lev_crdnr") & """ code=""" & dr.Item("lev_crdnr") & """>")
                        FO.WriteLine("           <Name>" & dr5.Item("oms25_0") & "</Name>")
                        FO.WriteLine("          </Creditor>")
                        FO.WriteLine("         </Account>")
                    Else
                        FO.WriteLine("          <Name></Name>")
                        FO.WriteLine("          <Creditor Number="" code="">")
                        FO.WriteLine("           <Name></Name>")
                        FO.WriteLine("          </Creditor>")
                        FO.WriteLine("         </Account>")
                    End If
                    dr5.Close()
                    conn5.Close()

                    conn5.ConnectionString = Constr1
                    conn5.Open()
                    com5 = conn5.CreateCommand
                    com5.CommandText = "Select * from [264].DBO.ItemAccounts where itemcode ='" & dr.Item("itemcode") & "'"
                    dr5 = com5.ExecuteReader
                    If dr5.Read Then
                        FO.WriteLine("            <ItemCode>" & dr5.Item("Itemcode") & "</ItemCode>")
                        FO.WriteLine("            <SupplierPreference>" & dr5.Item("SupplierPreference") & "</SupplierPreference>")
                        FO.WriteLine("            <EANCode>" & dr5.Item("EANCode") & "</EANCode>")
                    Else
                        FO.WriteLine("            <ItemCode></ItemCode>")
                        FO.WriteLine("            <SupplierPreference></SupplierPreference>")
                        FO.WriteLine("            <EANCode></EANCode>")
                    End If
                    FO.WriteLine("            <Purchase>")
                    FO.WriteLine("              <Price type=""P"">")
                    FO.WriteLine("                <Currency code=""" & dr.Item("CostPriceCurrency") & """/>")
                    FO.WriteLine("                <Value>" & dr7.Item("CostPrice") & "</Value>")

                    dr7.Close()


                    dr4.Close()
                    conn4.Close()

                    conn4.ConnectionString = Constr1
                    conn4.Open()
                    com4 = conn4.CreateCommand
                    com4.CommandText = "Select top 1 * from [264].DBO.btwtrs"
                    dr4 = com4.ExecuteReader
                    If dr4.Read Then
                        FO.WriteLine("                <VAT code=""" & dr4.Item("btwtrans") & """ type=""" & dr4.Item("code_iv") & """ vattype=""" & dr4.Item("exclus") & """>")
                        FO.WriteLine("                  <Description>" & dr4.Item("oms30_0") & "</Description>")
                        FO.WriteLine("                  <Percentage>" & dr4.Item("btwper") & "</Percentage>")
                        FO.WriteLine("                  <Charged>" & dr4.Item("levy_per") & "</Charged>")
                    Else
                        FO.WriteLine("                <VAT code="" type="" vattype="">")
                        FO.WriteLine("                  <Description></Description>")
                        FO.WriteLine("                  <Percentage></Percentage>")
                        FO.WriteLine("                  <Charged></Charged>")
                    End If

                    dr2.Close()

                    com2 = conn2.CreateCommand
                    com2.CommandText = "Select * from [264].DBO.grtbk Where reknr='" + dr4.Item("rek_btw_vk") + "'"
                    dr2 = com2.ExecuteReader
                    If dr2.Read Then
                        FO.WriteLine("                  <GLToPay code=""" & dr4.Item("rek_btw_vk") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                        FO.WriteLine("                    <Description>" & dr2.Item("oms25_0") & "</Description>")
                        FO.WriteLine("                  </GLToPay>")
                    Else
                        FO.WriteLine("                  <GLToPay code="" side="" type="" subtype="">")
                        FO.WriteLine("                    <Description></Description>")
                        FO.WriteLine("                  </GLToPay>")
                    End If
                    dr2.Close()

                    com2 = conn2.CreateCommand
                    com2.CommandText = "Select * from [264].DBO.grtbk Where reknr='" + dr4.Item("reknr") + "'"
                    dr2 = com2.ExecuteReader
                    If dr2.Read Then
                        FO.WriteLine("                  <GLToClaim code=""" & dr4.Item("reknr") & """ side=""" & dr2.Item("debcrd") & """ type=""" & dr2.Item("bal_vw") & """ subtype=""" & dr2.Item("omzrek") & """>")
                        FO.WriteLine("                    <Description>" & dr2.Item("oms25_0") & "</Description>")
                        FO.WriteLine("                  </GLToClaim>")
                    Else
                        FO.WriteLine("                  <GLToClaim code="" side="" type="" subtype="">")
                        FO.WriteLine("                    <Description></Description>")
                        FO.WriteLine("                  </GLToClaim>")
                    End If
                    FO.WriteLine("                  <Creditor code=""" & dr4.Item("creditor") & """ number=""" & dr4.Item("creditor") & """ type=""" & dr.Item("type") & """>")
                    FO.WriteLine("                    <Name>Bureau of Internal Revenue</Name>")
                    FO.WriteLine("                  </Creditor>")
                    FO.WriteLine("                  <PaymentPeriod>" & dr4.Item("pay_period") & "</PaymentPeriod>")
                    FO.WriteLine("                 </VAT>")
                    FO.WriteLine("               </Price>")
                    FO.WriteLine("               <Unit unit=""" & IsNull(dr5.Item("PurchasePackage")) & """ type=""" & dr2.Item("type_rek") & """/>")
                    FO.WriteLine("               <SalesUnit>" & IsNull(dr5.Item("PurchaseUnittoPurchasePackageFactor")) & "</SalesUnit>")
                    FO.WriteLine("               <OrderSize>" & IsNull(CInt(dr5.Item("PurchaseOrderSize"))) & "</OrderSize>")
                    FO.WriteLine("             </Purchase>")
                    FO.WriteLine("             <Delivery>")
                    FO.WriteLine("               <TimeInDays>" & IsNull(dr5.Item("DeliveryTimeinDAys")) & "</TimeInDays>")
                    FO.WriteLine("               <FromStock>" & IsNull(CInt(dr5.Item("DeliverableFromStock"))) & "</FromStock>")
                    FO.WriteLine("             </Delivery>")
                    FO.WriteLine("           </ItemAccount>")
                    FO.WriteLine("         </ItemAccounts>")
                    dr5.Close()
                    conn5.Close()

                    conn5.ConnectionString = Constr1
                    conn5.Open()
                    com5 = conn5.CreateCommand
                    com5.CommandText = "Select * from [264].DBO.magaz where magcode=" & dr.Item("Warehouse") & ""
                    dr5 = com5.ExecuteReader
                    If dr5.Read Then
                        FO.WriteLine("         <ItemWarehouses>")
                        FO.WriteLine("           <ItemWarehouse default=""" & dr.Item("Warehouse") & """>")
                        FO.WriteLine("             <Warehouse code=""" & dr5.Item("magcode") & """ blocked=""" & dr5.Item("blokkeer") & """>")
                        FO.WriteLine("              <Description>" & dr5.Item("naam") & "</Description>")
                        FO.WriteLine("              <Address>")
                        FO.WriteLine("               <AddressLine1>" & dr5.Item("adr_addressline1") & "</AddressLine1>")
                        FO.WriteLine("               <AddressLine2>" & dr5.Item("adr_addressline2") & "</AddressLine2>")
                        FO.WriteLine("               <AddressLine3>" & dr5.Item("adr_addressline3") & "</AddressLine3>")
                        FO.WriteLine("               <PostalCode/>")
                        FO.WriteLine("               <City/>")
                        FO.WriteLine("               <Country code=""" & dr5.Item("adr_landcode") & """/>")
                        FO.WriteLine("             </Address>")
                        FO.WriteLine("            </Warehouse>")
                        FO.WriteLine("          </ItemWarehouse>")
                        FO.WriteLine("        </ItemWarehouses>")
                    Else
                        FO.WriteLine("         <ItemWarehouses>")
                        FO.WriteLine("           <ItemWarehouse default="">")
                        FO.WriteLine("             <Warehouse code="" blocked="">")
                        FO.WriteLine("              <Description></Description>")
                        FO.WriteLine("              <Address>")
                        FO.WriteLine("               <AddressLine1></AddressLine1>")
                        FO.WriteLine("               <AddressLine2></AddressLine2>")
                        FO.WriteLine("               <AddressLine3></AddressLine3>")
                        FO.WriteLine("               <PostalCode/>")
                        FO.WriteLine("               <City/>")
                        FO.WriteLine("               <Country code=""/>")
                        FO.WriteLine("             </Address>")
                        FO.WriteLine("            </Warehouse>")
                        FO.WriteLine("          </ItemWarehouse>")
                        FO.WriteLine("        </ItemWarehouses>")
                    End If
                    dr5.Close()
                    conn5.Close()
                    conn7.Close()
                    ' dr.Close()
                    dr2.Close()
                    dr3.Close()
                    dr4.Close()
                    dr5.Close()
                    FO.WriteLine(" </Item>")
                    Me.Refresh()
                End While
                FO.WriteLine("</Items>")
                FO.WriteLine("</eExact>")
                dr.Close()
                FO.Close()
                conn.Close()


                'Dim webclient As New System.Net.WebClient
                'Dim verify As System.Net.ICredentials
                'Dim UploadPath As String = Upload & div1 & serverDate.Year & Mid(TextBox3.Text, 5, 6) & ".XML"

                'verify = New System.Net.NetworkCredential(SUsername, SPassword)
                'webclient.Credentials = verify
                'webclient.UploadFile(UploadPath, "PUT", serverIP)
                Dim xmlFile As String
                xmlFile = TextBox1.Text & serverDate.Year & XMLSequenceNO & ".XML"

                'GC.Collect()
                'File.Copy(serverIP, CreateDestination & xmlFile, True)





                Dim sQLUpdate As String = ""
                objclass = New clsCommon
                objclass.Connectionstring4()
                objclass.Opentracker3()
                objclass.CreateCom()
                sQLUpdate = "UPDATE REMS.DBO.ASYS_CONSIGN_HEADER SET ISCREATED = 1,XMLFilename = '" & xmlFile & "' WHERE LOTNO = '" & TextBox3.Text.Trim & "'"
                objclass.commandTrack(sQLUpdate)
                objclass.TrackExecute()
                objclass.CommitTrack()
                MsgBox("XML has been successfully CREATED", MsgBoxStyle.Information, TitleMsgBox)

            End If
        Catch ex As Exception
            MsgBox(ex.Message & ": " & "Check item pictures or spUpload at 264")
            'FO.Close()
            GC.Collect()
            File.Delete(serverIP)
            GoTo Errmsg

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
            'Button2.Enabled = True
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
End Class
