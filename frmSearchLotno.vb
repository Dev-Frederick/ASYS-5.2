Imports System.Data.SqlClient

Public Class frmSearchLotno
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvSearchLot As System.Windows.Forms.ListView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSearchLotno))
        Me.lvSearchLot = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lvSearchLot
        '
        Me.lvSearchLot.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvSearchLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvSearchLot.FullRowSelect = True
        Me.lvSearchLot.GridLines = True
        Me.lvSearchLot.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvSearchLot.Location = New System.Drawing.Point(3, 0)
        Me.lvSearchLot.Name = "lvSearchLot"
        Me.lvSearchLot.Size = New System.Drawing.Size(384, 336)
        Me.lvSearchLot.TabIndex = 0
        Me.lvSearchLot.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "EMPLOYEE NAME"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LOT NUMBER"
        Me.ColumnHeader2.Width = 115
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "RELEASED DATE"
        Me.ColumnHeader3.Width = 114
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(3, 338)
        Me.txtSearch.MaxLength = 10
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(133, 20)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Text = ""
        '
        'btnSearch
        '
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(144, 338)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 22)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Image)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(224, 338)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(80, 22)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(304, 338)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 22)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSearchLotno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 366)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lvSearchLot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSearchLotno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH LOT NUMBER"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim obj As New clsCommon
    Dim dr As SqlDataReader
    Dim str As String

    Private Sub frmSearchLotno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SearchFlag = False
            Search()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmSearchLotno_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            If txtSearch.Text.Length <= 0 Then
                MsgBox("Please supply Lot number in the text box.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            Search()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LVColumnHeader(ByVal TransType As String)
        Try
            Dim tmpHeaderName As ColumnHeader
            Dim tmpHeaderName2 As ColumnHeader
            Dim tmpHeaderName3 As ColumnHeader
            Dim ctr As Integer

            tmpHeaderName = New ColumnHeader
            tmpHeaderName2 = New ColumnHeader
            tmpHeaderName3 = New ColumnHeader

            lvSearchLot.Clear()

            tmpHeaderName.Text = "EMPLOYEE NAME"
            tmpHeaderName.TextAlign = HorizontalAlignment.Left
            tmpHeaderName.Width = 150

            tmpHeaderName2.Text = "LOT NUMBER"
            tmpHeaderName2.TextAlign = HorizontalAlignment.Left
            tmpHeaderName2.Width = 124


            If TransType = "RECEIVED" Then
                tmpHeaderName3.Text = "RECEIVED DATE"
            ElseIf TransType = "RELEASED" Then
                tmpHeaderName3.Text = "RELEASED DATE"
            ElseIf TransType = "CONSIGNED" Then
                tmpHeaderName3.Text = "CONSIGNMENT DATE"
            ElseIf TransType = "RETURNED" Then
                tmpHeaderName3.Text = "RETURNED DATE"
            End If

            tmpHeaderName3.TextAlign = HorizontalAlignment.Left
            tmpHeaderName3.Width = 114

            lvSearchLot.Columns.Add(tmpHeaderName)
            lvSearchLot.Columns.Add(tmpHeaderName2)
            lvSearchLot.Columns.Add(tmpHeaderName3)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Search()
        Try
            Dim frm As New frmREMOutSourceBRcv
            Dim tmpEmpName As String
            Dim tmpLotNo As String

            lvSearchLot.Items.Clear()

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            If MainCost = "PRICING" Then
                If SelectedForm = "FrmPricingReceiving" Then 'PRICING/RECEIVING
                    LVColumnHeader("RECEIVED")
                    str = "SELECT DISTINCT LotNo as LotNum, upper(receiver) as EmpName1, convert(nvarchar,receivedate,101) as receivedDate " & _
                          "FROM asys_PRICING_detail where actionclass in ('return','outsource','goodstock', 'cellular', 'watch') "
                ElseIf SelectedForm = "frmPRICINGReleasing" Then 'PRICING/RELEASING
                    LVColumnHeader("RELEASED")
                    str = "SELECT DISTINCT reflotno as LotNum, upper(releaser) as EmpName1, convert(nvarchar,ReleaseDate,101) as receivedDate " & _
                          "FROM asys_PRICING_detail where asys_PRICING_detail.actionclass in ('return','outsource','goodstock','watch','cellular') and asys_PRICING_detail.sortcode = 'O' and asys_PRICING_detail.status in ('RELEASED','RECDISTRI') "
                End If

            ElseIf MainCost = "REM" Or MainCost = Nothing Then
                str = "SELECT DISTINCT a.LotNo as LotNum, upper(a.Receiver) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,a.ReceiveDate,101) as receivedDate FROM "

                If sDB = "Vismin" Or sDB = "Luzon" Or sDB = "Showroom" Then  'add showroom 06-04-2013 m-g
                    If SelectedForm = "Form2" Then 'rem/receiving/item [pending]
                        str = str & "rems" & sDB & ".dbo.ASYS_REMOUTSOURCE_Detail a WHERE LotNo IS NOT NULL"

                    ElseIf SelectedForm = "FrmNewReceiving" Then 'rem/receiving/batch receiving [pending]
                        str = str & "rems" & sDB & ".dbo.ASYS_REM_Detail a WHERE LotNo IS NOT NULL"

                    ElseIf SelectedForm = "frmReleasing" Then
                        LVColumnHeader("RELEASED")
                        str = str & "rems" & sDB & ".dbo.ASYS_REM_Detail a " & _
                                    "WHERE status = 'RELEASED' AND LotNo IS NOT NULL AND " & _
                                    "a.receiver not in (select fullname from vw_humresAll where job_title = 'SORTER')"

                    ElseIf SelectedForm = "frmReleasingReceiving" Then 'rem/receiving/Releasing 
                        LVColumnHeader("RELEASED")
                        '''str = "SELECT DISTINCT LotNo as LotNum, upper(releaser) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,ReleaseDate,101) as receivedDate FROM ( SELECT     rtrim(reflotno) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate,upper(releaser) as Releaser, Convert(nvarchar,ReleaseDate,101) as ReleaseDate FROM remsVismin.dbo.ASYS_REM_Detail WHERE    Status in ('RELEASED', 'RECMLWB') and (actionclass  = 'goodstock' or actionclass = 'cellular' or actionclass = 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER') union all SELECT     rtrim(reflotno) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate,upper(releaser) as Releaser, Convert(nvarchar,ReleaseDate,101) as ReleaseDate FROM remsVismin.dbo.ASYS_REMOutsource_Detail WHERE    Status in ('RELEASED', 'RECMLWB') and actionclass in ('returns','outsource','goodstock', 'cellular', 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER'))a ORDER BY LotNum desc"
                        str = "SELECT DISTINCT LotNo as LotNum, upper(releaser) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,releasedate,101) as releasedate FROM "
                        str = str & "( 	SELECT     rtrim(reflotno) as LotNo, upper(releaser) as releaser, upper(CostName) as CostName, " & _
                                    "Convert(nvarchar,releasedate,101) as releasedate FROM ASYS_REM_Detail " & _
                                    "WHERE    Status in ('RELEASED', 'RECMLWB') " & _
                                    "and actionclass  in ('goodstock', 'cellular', 'watch') " & _
                                    "and receiver not in (select fullname from vw_humresall where job_title = 'SORTER') " & _
                                    "union all " & _
                                    "SELECT     rtrim(reflotno) as LotNo, upper(releaser) as releaser, upper(CostName) as CostName, " & _
                                    "Convert(nvarchar,releasedate,101) as releasedate FROM ASYS_REMOutsource_Detail " & _
                                    "WHERE    Status in ('RELEASED', 'RECMLWB') " & _
                                    "and actionclass in ('return','outsource','goodstock', 'cellular', 'watch') " & _
                                    "and receiver not in (select fullname from vw_humresall where job_title = 'SORTER'))a"

                    End If
                Else
                    If SelectedForm = "frmReleasingItem" Then 'rem/item/release
                        'str = str & "( SELECT     rtrim(LotNo) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate " & _
                        '            "FROM ASYS_REM_Detail " & _
                        '            "WHERE    Status in ('RELEASED', 'RECMLWB') and (actionclass  = 'goodstock' or actionclass = 'cellular' or actionclass = 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER') " & _
                        '            "union all " & _
                        '            "SELECT     rtrim(LotNo) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate " & _
                        '            "FROM ASYS_REMOutsource_Detail " & _
                        '            "WHERE    Status in ('RELEASED', 'RECMLWB') and actionclass in ('outsource','goodstock', 'cellular', 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER'))a"
                        LVColumnHeader("RELEASED")
                        str = "SELECT DISTINCT rtrim(RefLotno) as LotNum, releaser as EmpName1, Convert(nvarchar,ReleaseDate,101) as receivedDate " & _
                              "FROM ( " & _
                              "SELECT DISTINCT rtrim(RefLotno) as reflotno, releaser, Convert(nvarchar,ReleaseDate,101) as ReleaseDate " & _
                              "FROM  dbo.ASYS_REM_Detail " & _
                              "WHERE    Status in ('RELEASED', 'RECMLWB') and (actionclass  = 'goodstock' or actionclass = 'cellular' or actionclass = 'watch') " & _
                              "AND releaser not in (select fullname from vw_humresall where job_title = 'SORTER') " & _
                              "union all " & _
                              "SELECT DISTINCT rtrim(RefLotno) as reflotno, releaser, Convert(nvarchar,ReleaseDate,101) as ReleaseDate " & _
                              "FROM dbo.ASYS_REMOutsource_Detail " & _
                              "WHERE    Status in ('RELEASED', 'RECMLWB') and actionclass in ('return','outsource','goodstock', 'cellular', 'watch') " & _
                              "AND releaser not in (select fullname from vw_humresall where job_title = 'SORTER'))a"

                        'ElseIf SelectedForm = "frmReleasingReceiving" Then
                        '    LVColumnHeader("RELEASED")
                        '    str = str & "( SELECT     rtrim(LotNo) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate " & _
                        '                "FROM rems" & sDB & ".dbo.ASYS_REM_Detail " & _
                        '                "WHERE    Status in ('RELEASED', 'RECMLWB') and (actionclass  = 'goodstock' or actionclass = 'cellular' or actionclass = 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER') " & _
                        '                "union all " & _
                        '                "SELECT     rtrim(LotNo) as LotNo, upper(Receiver) as Receiver, upper(CostName) as CostName, Convert(nvarchar,ReceiveDate,101) as ReceiveDate " & _
                        '                "FROM rems" & sDB & ".dbo.ASYS_REMOutsource_Detail " & _
                        '                "WHERE    Status in ('RELEASED', 'RECMLWB') and actionclass in ('outsource','goodstock', 'cellular', 'watch') and receiver not in (select fullname from vw_humresall where job_title = 'SORTER'))a"

                    Else 'temporary else. it should be elseif
                        If SelectedType = "OUTSOURCE" Then
                            LVColumnHeader("RECEIVED")
                            str = str & "ASYS_REMOutSource_detail a INNER JOIN ASYS_REMOutSource_header b ON a.Lotno = b.Lotno " & _
                                        "WHERE a.LotNo IS NOT NULL AND b.TYPE = 'OUTSOURCE' " & _
                                        "AND a.receiver not in (select fullname from vw_humresall where job_title = 'SORTER') "

                        ElseIf SelectedType = "RETURN" Then
                            LVColumnHeader("RETURNED")
                            str = "SELECT a.Lotno as LotNum, convert(nvarchar,b.ReceiveDate,101) as receivedDate, upper(b.Receiver) as EmpName1 " & _
                                  "FROM dbo.ASYS_REMOutSource_detail b INNER JOIN " & _
                                  "dbo.ASYS_REMOutSource_header a ON b.Lotno = a.Lotno " & _
                                  "where a.type = 'RETURN'"
                        End If
                    End If
                End If

            ElseIf MainCost = "DISTRI" Then
                If SelectedForm = "Form1" Then 'distribution/Consignment
                    LVColumnHeader("CONSIGNED")
                    str = "SELECT DISTINCT LotNo as LotNum,consigncode,consignname, upper(Consignee) as EmpName1, convert(nvarchar,ConsignDate,101) as receivedDate FROM " & _
                          "ASYS_Consign_header "

                ElseIf SelectedForm = "FrmDISTRIReceiving" Then 'distribution/receiving
                    LVColumnHeader("RECEIVED")
                    str = "SELECT DISTINCT LotNo as LotNum, upper(Receiver) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,ReceiveDate,101) as receivedDate FROM " & _
                          "asys_DISTRI_detail where asys_DISTRI_detail.actionclass in ('return','outsource','goodstock','watch','cellular') and " & _
                          "asys_DISTRI_detail.sortcode = 'O' and asys_DISTRI_detail.status in ('RECEIVED','CONSIGNED','RELEASED','RETURNED') "

                ElseIf SelectedForm = "frmDISTRIReleasing" Then
                    LVColumnHeader("RELEASED")
                    str = "SELECT DISTINCT reflotno as LotNum, upper(releaser) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,ReleaseDate,101) as receivedDate FROM " & _
                          "asys_DISTRI_detail where asys_DISTRI_detail.actionclass in ('return','outsource','goodstock','watch','cellular') and " & _
                          "asys_DISTRI_detail.sortcode = 'O' and asys_DISTRI_detail.status in ('RELEASED','RETURNED') "
                End If

            ElseIf MainCost = "MLWB" Then
                If SelectedForm = "frmMLWBReceiving" Then 'MLWB/RECEIVING
                    LVColumnHeader("RECEIVED")
                    str = "SELECT DISTINCT LotNo as LotNum, upper(Receiver) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,ReceiveDate,101) as receivedDate FROM "
                    str = str & "ASYS_MLWB_detail WHERE actionclass in ('return','outsource','goodstock','cellular','watch') and asys_MLWB_detail.sortcode = 'O'  " & _
                                "AND status in ('RECEIVED','RELEASED','RECPRICING') " ' I remove 'NOT' in (between Receiver and in) ->> Receiver in (select fullname from vw_humresall where job_title in ('MLWB', 'ALLBOSMAN'))

                ElseIf SelectedForm = "frmMLWBReleasing" Then 'MLWB/RELEASING
                    LVColumnHeader("RELEASED")
                    str = "SELECT DISTINCT RefLotNo as LotNum, upper(releaser) as EmpName1, upper(CostName) as EmpName2, Convert(nvarchar,ReleaseDate,101) as receivedDate FROM "
                    str = str & "ASYS_MLWB_detail WHERE actionclass in ('return','outsource','goodstock','watch','cellular') and asys_MLWB_detail.sortcode = 'O' and status in ('RELEASED','RECPRICING') " '& _
                               '"" ' I remove 'NOT' in (between Receiver and in) ->> Receiver in (select fullname from vw_humresall where job_title in ('MLWB', 'ALLBOSMAN'))
                End If
            End If


            If txtSearch.Text.Length > 0 Then ' for search button
                If MainCost = "PRICING" Then
                    str = str & " AND Lotno like '" & txtSearch.Text & "%'"
                ElseIf MainCost = "REM" Then
                    If SelectedForm = "frmReleasingItem" Then
                        str = str & " WHERE rtrim(RefLotno) like '" & txtSearch.Text & "%'"
                    ElseIf SelectedForm = "frmReleasingReceiving" Then
                        str = str & " WHERE LotNo like '" & txtSearch.Text & "%'"
                    Else
                        str = str & " AND a.LotNo like '" & txtSearch.Text & "%'"
                    End If
                ElseIf MainCost = "DISTRI" Then
                    If SelectedForm = "Form1" Then 'distribution/Consignment
                        str = str & " WHERE LotNo like '" & txtSearch.Text & "%'"
                    Else
                        str = str & " AND LotNo like '" & txtSearch.Text & "%'"
                    End If
                ElseIf MainCost = "MLWB" Then
                    If SelectedForm = "frmMLWBReceiving" Then 'MLWB/RECEIVING
                        str = str & " AND LotNo like '" & txtSearch.Text & "%'"
                    ElseIf SelectedForm = "frmMLWBReleasing" Then 'MLWB/RELEASING
                        str = str & " AND RefLotNo like '" & txtSearch.Text & "%'"
                    End If

                End If
            End If

            str = str & " ORDER BY LotNum desc"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            While dr.Read
                If Trim(dr.Item("LotNum").ToString) <> tmpLotNo Then

                    If dr.Item("EmpName1").ToString.Length > 0 Then
                        tmpEmpName = dr.Item("EmpName1").ToString
                    Else
                        tmpEmpName = dr.Item("EmpName2")
                    End If
                    lvSearchLot.Items.Add(UCase(tmpEmpName)).Font = New Font(lvSearchLot.Font, FontStyle.Regular)
                    lvSearchLot.Items(lvSearchLot.Items.Count - 1).SubItems.Add(dr.Item("LotNum"))
                    If SelectedForm = "frmReleasingReceiving" Then
                        lvSearchLot.Items(lvSearchLot.Items.Count - 1).SubItems.Add(dr.Item("releasedate"))
                    Else
                        lvSearchLot.Items(lvSearchLot.Items.Count - 1).SubItems.Add(dr.Item("receivedDate"))
                    End If

                End If
                tmpLotNo = Trim(dr.Item("LotNum").ToString)

            End While

            dr.Close()
            obj.Close3()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> ChrW(13) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                Exit Sub
            End If
            If e.KeyChar = ChrW(13) Then
                btnSearch_Click(sender, e)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            ReadyPrintCheck()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lvSearchLot_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvSearchLot.DoubleClick
        Try
            ReadyPrintCheck()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintCheck()
        Try
            If MainCost = "PRICING" Then
                If SelectedForm = "FrmPricingReceiving" Then 'PRICING/RECEIVING
                    ReadyPrintPricingReceiving()
                ElseIf SelectedForm = "frmPRICINGReleasing" Then 'PRICING/RELEASING
                    ReadyPrintfrmPRICINGReleasing()
                End If

            ElseIf MainCost = "REM" Or MainCost = Nothing Then
                If sDB = "Vismin" Or sDB = "Luzon" Or sDB = "Showroom" Then '06-04-2013 m-g
                    If SelectedForm = "Form2" Then 'rem/receiving/item [pending]
                        ReadyPrintForm2()
                    ElseIf SelectedForm = "FrmNewReceiving" Then 'rem/receiving/batch receiving [pending]
                        ReadyPrintFrmNewReceiving()
                    ElseIf SelectedForm = "frmReleasingReceiving" Then 'rem/receiving/releasing
                        ReadyPrintfrmReleasingItem()
                    End If
                Else
                    If SelectedForm = "frmREMOutSourceBRcv" Then
                        ReadyPrintREMOutSource()
                    ElseIf SelectedForm = "frmReleasingItem" Then  'rem/item/release
                        ReadyPrintfrmReleasingItem()
                    End If
                End If

            ElseIf MainCost = "DISTRI" Then
                If SelectedForm = "Form1" Then 'distribution/Consignment 
                    ReadyPrintForm1()
                ElseIf SelectedForm = "FrmDISTRIReceiving" Then 'distribution/receiving
                    ReadyPrintFrmDISTRIReceiving()
                ElseIf SelectedForm = "frmDISTRIReleasing" Then
                    ReadyPrintfrmDISTRIReleasing()
                End If

            ElseIf MainCost = "MLWB" Then
                If SelectedForm = "frmMLWBReceiving" Then 'MLWB/RECEIVING
                    ReadyPrintfrmMLWBReceiving()
                ElseIf SelectedForm = "frmMLWBReleasing" Then 'MLWB/RELEASING
                    ReadyPrintfrmMLWBReleasing()
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReadyPrintfrmDISTRIReleasing()
        Try
            Dim frm As New frmDISTRIReleasing_rpt
            frm.txtlot.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(1).Text)
            frm.txtdate.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(2).Text)
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintFrmDISTRIReceiving()
        Try
            Dim frm As New frmDISTRIReceiving_rpt
            frm.txtlot.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(1).Text)
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintfrmPRICINGReleasing()
        Try
            Dim frm As New frmPRICINGReleasing_rpt
            frm.Text = "ASYS 5.1 SYNERGY SHOWROOM PRICING RELEASING REPORT"
            frm.txtlot.Tag = Trim(lvSearchLot.FocusedItem.SubItems.Item(1).Text)
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ReadyPrintfrmMLWBReleasing()
        Try
            Dim frm As New frmMLWBReport
            frm.Text = "F20"
            frm.Label7.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(1).Text)
            'frm.Label7.Text = tmp
            frm.Label4.Text = "PRICING"
            frm.txtdate.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(2).Text)
            recrel = 4
            recrel2 = ""
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintfrmMLWBReceiving()
        Try
            Dim frm As New frmMLWBReport

            recrel = 1
            frm.Label7.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(1).Text)
            frm.Label4.Text = "REM"
            frm.txtdate.Text = Trim(lvSearchLot.FocusedItem.SubItems.Item(2).Text)
            frm.ShowDialog()
            Me.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintForm1()
        Try
            Dim frm As New frmConsignRpt
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim month2 As Integer
            Dim year2 As Integer
            'frm.txtlotno.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            'frm.cmbEmp.Text = userLog


            month2 = Month(lvSearchLot.FocusedItem.SubItems.Item(2).Text)
            month1 = CStr(month2)
            year2 = Year((lvSearchLot.FocusedItem.SubItems.Item(2).Text))
            year1 = CStr(year2)
            lot1234 = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            'frm.Label1.Text = Label6.Text
            'frm.Label2.Text = Label7.Text
            'frm.TextBox1.Text = TextBox1.Text
            'frm.TextBox2.Text = TextBox2.Text
            frm.TextBox3.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()
            str = "Select consigncode,consignname from ASYS_Consign_Header where lotno = '" & lot1234 & "'"
            obj.Command3(str)
            dr = obj.OpenDataReader3()
            If dr.Read = True Then
                frm.TextBox1.Text = dr.Item("consigncode")
                frm.TextBox2.Text = dr.Item("consignname")
            End If
            dr.Close()
            obj.Close3()

            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintfrmReleasingItem()
        Try
            Dim frm As New Report

            'frm.Label2.Text = "MONTH"
            'frm.TextBox1.Text = rellot
            'frm.Label6.Visible = True
            'frm.TextBox2.Visible = True
            'frm.Lot.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            'frm.TextBox2.Text = UCase(userLog)
            'frm.Text = "RELEASING REPORT ASYS 3.0"
            'frm.ShowDialog()
            'Me.Dispose()

            If outsource = False And bleh = False Then
                frm.Label2.Text = "MONTH"
                frm.TextBox1.Text = rellot
                frm.Lot.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
                frm.Label6.Visible = True
                frm.TextBox2.Visible = True
            ElseIf bleh = True Then
                frm.TextBox1.Text = rellot
                frm.Label6.Visible = True
                frm.TextBox2.Visible = False
                frm.Label5.Text = "LOTNO"
                frm.Label5.Visible = False
                frm.TextBox1.Visible = True
            End If

            frm.TextBox2.Text = UCase(userLog)
            frm.Text = "RELEASING REPORT ASYS 5.1 SYNERGY SHOWROOM"
            recrelrep = False
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintFrmNewReceiving() 'pending
        Try
            Dim frm As New Report

            'frm.txtlot.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            'SearchFlag = True
            'Me.Dispose()
            'frm.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintForm2() 'pending
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintPricingReceiving()
        Try
            Dim frm As New frmPRICINGReceiving_rpt

            frm.txtlot.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            SearchFlag = True
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyPrintREMOutSource()
        Try
            Dim frm As New frmOutSource_Return
            frm.txtlotno.Text = lvSearchLot.FocusedItem.SubItems.Item(1).Text
            frm.cmbEmp.Text = UCase(userLog)
            frm.ShowDialog()
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub
End Class
