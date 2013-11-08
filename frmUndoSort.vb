Imports System.Data.SqlClient
Public Class frmUndoSort
    Inherits System.Windows.Forms.Form
    Public objclass As New clsCommon
    Private nonNumberEntered As Boolean = False
    Private mptn As String
    Private loanvalue As Double

    'Public dr As SqlDataReader
    'Public batchform As New frmBatch

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
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents grd As AxMSFlexGridLib.AxMSFlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUndoSort))
        Me.lblsearch = New System.Windows.Forms.Label
        Me.btnsearch = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnclose = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        Me.grd = New AxMSFlexGridLib.AxMSFlexGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsearch
        '
        Me.lblsearch.AccessibleDescription = resources.GetString("lblsearch.AccessibleDescription")
        Me.lblsearch.AccessibleName = resources.GetString("lblsearch.AccessibleName")
        Me.lblsearch.Anchor = CType(resources.GetObject("lblsearch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblsearch.AutoSize = CType(resources.GetObject("lblsearch.AutoSize"), Boolean)
        Me.lblsearch.Dock = CType(resources.GetObject("lblsearch.Dock"), System.Windows.Forms.DockStyle)
        Me.lblsearch.Enabled = CType(resources.GetObject("lblsearch.Enabled"), Boolean)
        Me.lblsearch.Font = CType(resources.GetObject("lblsearch.Font"), System.Drawing.Font)
        Me.lblsearch.Image = CType(resources.GetObject("lblsearch.Image"), System.Drawing.Image)
        Me.lblsearch.ImageAlign = CType(resources.GetObject("lblsearch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblsearch.ImageIndex = CType(resources.GetObject("lblsearch.ImageIndex"), Integer)
        Me.lblsearch.ImeMode = CType(resources.GetObject("lblsearch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblsearch.Location = CType(resources.GetObject("lblsearch.Location"), System.Drawing.Point)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.RightToLeft = CType(resources.GetObject("lblsearch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblsearch.Size = CType(resources.GetObject("lblsearch.Size"), System.Drawing.Size)
        Me.lblsearch.TabIndex = CType(resources.GetObject("lblsearch.TabIndex"), Integer)
        Me.lblsearch.Text = resources.GetString("lblsearch.Text")
        Me.lblsearch.TextAlign = CType(resources.GetObject("lblsearch.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblsearch.Visible = CType(resources.GetObject("lblsearch.Visible"), Boolean)
        '
        'btnsearch
        '
        Me.btnsearch.AccessibleDescription = resources.GetString("btnsearch.AccessibleDescription")
        Me.btnsearch.AccessibleName = resources.GetString("btnsearch.AccessibleName")
        Me.btnsearch.Anchor = CType(resources.GetObject("btnsearch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnsearch.BackgroundImage = CType(resources.GetObject("btnsearch.BackgroundImage"), System.Drawing.Image)
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.Dock = CType(resources.GetObject("btnsearch.Dock"), System.Windows.Forms.DockStyle)
        Me.btnsearch.Enabled = CType(resources.GetObject("btnsearch.Enabled"), Boolean)
        Me.btnsearch.FlatStyle = CType(resources.GetObject("btnsearch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnsearch.Font = CType(resources.GetObject("btnsearch.Font"), System.Drawing.Font)
        Me.btnsearch.Image = CType(resources.GetObject("btnsearch.Image"), System.Drawing.Image)
        Me.btnsearch.ImageAlign = CType(resources.GetObject("btnsearch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnsearch.ImageIndex = CType(resources.GetObject("btnsearch.ImageIndex"), Integer)
        Me.btnsearch.ImeMode = CType(resources.GetObject("btnsearch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnsearch.Location = CType(resources.GetObject("btnsearch.Location"), System.Drawing.Point)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.RightToLeft = CType(resources.GetObject("btnsearch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnsearch.Size = CType(resources.GetObject("btnsearch.Size"), System.Drawing.Size)
        Me.btnsearch.TabIndex = CType(resources.GetObject("btnsearch.TabIndex"), Integer)
        Me.btnsearch.Text = resources.GetString("btnsearch.Text")
        Me.btnsearch.TextAlign = CType(resources.GetObject("btnsearch.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnsearch.Visible = CType(resources.GetObject("btnsearch.Visible"), Boolean)
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleDescription = resources.GetString("ComboBox1.AccessibleDescription")
        Me.ComboBox1.AccessibleName = resources.GetString("ComboBox1.AccessibleName")
        Me.ComboBox1.Anchor = CType(resources.GetObject("ComboBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackgroundImage = CType(resources.GetObject("ComboBox1.BackgroundImage"), System.Drawing.Image)
        Me.ComboBox1.Dock = CType(resources.GetObject("ComboBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.ComboBox1.Enabled = CType(resources.GetObject("ComboBox1.Enabled"), Boolean)
        Me.ComboBox1.Font = CType(resources.GetObject("ComboBox1.Font"), System.Drawing.Font)
        Me.ComboBox1.ImeMode = CType(resources.GetObject("ComboBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ComboBox1.IntegralHeight = CType(resources.GetObject("ComboBox1.IntegralHeight"), Boolean)
        Me.ComboBox1.ItemHeight = CType(resources.GetObject("ComboBox1.ItemHeight"), Integer)
        Me.ComboBox1.Location = CType(resources.GetObject("ComboBox1.Location"), System.Drawing.Point)
        Me.ComboBox1.MaxDropDownItems = CType(resources.GetObject("ComboBox1.MaxDropDownItems"), Integer)
        Me.ComboBox1.MaxLength = CType(resources.GetObject("ComboBox1.MaxLength"), Integer)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = CType(resources.GetObject("ComboBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ComboBox1.Size = CType(resources.GetObject("ComboBox1.Size"), System.Drawing.Size)
        Me.ComboBox1.TabIndex = CType(resources.GetObject("ComboBox1.TabIndex"), Integer)
        Me.ComboBox1.Text = resources.GetString("ComboBox1.Text")
        Me.ComboBox1.Visible = CType(resources.GetObject("ComboBox1.Visible"), Boolean)
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = resources.GetString("GroupBox1.AccessibleDescription")
        Me.GroupBox1.AccessibleName = resources.GetString("GroupBox1.AccessibleName")
        Me.GroupBox1.Anchor = CType(resources.GetObject("GroupBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.btnclose)
        Me.GroupBox1.Controls.Add(Me.btndelete)
        Me.GroupBox1.Dock = CType(resources.GetObject("GroupBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox1.Enabled = CType(resources.GetObject("GroupBox1.Enabled"), Boolean)
        Me.GroupBox1.Font = CType(resources.GetObject("GroupBox1.Font"), System.Drawing.Font)
        Me.GroupBox1.ImeMode = CType(resources.GetObject("GroupBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox1.Location = CType(resources.GetObject("GroupBox1.Location"), System.Drawing.Point)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = CType(resources.GetObject("GroupBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox1.Size = CType(resources.GetObject("GroupBox1.Size"), System.Drawing.Size)
        Me.GroupBox1.TabIndex = CType(resources.GetObject("GroupBox1.TabIndex"), Integer)
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        Me.GroupBox1.Visible = CType(resources.GetObject("GroupBox1.Visible"), Boolean)
        '
        'btnclose
        '
        Me.btnclose.AccessibleDescription = resources.GetString("btnclose.AccessibleDescription")
        Me.btnclose.AccessibleName = resources.GetString("btnclose.AccessibleName")
        Me.btnclose.Anchor = CType(resources.GetObject("btnclose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Dock = CType(resources.GetObject("btnclose.Dock"), System.Windows.Forms.DockStyle)
        Me.btnclose.Enabled = CType(resources.GetObject("btnclose.Enabled"), Boolean)
        Me.btnclose.FlatStyle = CType(resources.GetObject("btnclose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btnclose.Font = CType(resources.GetObject("btnclose.Font"), System.Drawing.Font)
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageAlign = CType(resources.GetObject("btnclose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btnclose.ImageIndex = CType(resources.GetObject("btnclose.ImageIndex"), Integer)
        Me.btnclose.ImeMode = CType(resources.GetObject("btnclose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btnclose.Location = CType(resources.GetObject("btnclose.Location"), System.Drawing.Point)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.RightToLeft = CType(resources.GetObject("btnclose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btnclose.Size = CType(resources.GetObject("btnclose.Size"), System.Drawing.Size)
        Me.btnclose.TabIndex = CType(resources.GetObject("btnclose.TabIndex"), Integer)
        Me.btnclose.Text = resources.GetString("btnclose.Text")
        Me.btnclose.TextAlign = CType(resources.GetObject("btnclose.TextAlign"), System.Drawing.ContentAlignment)
        Me.btnclose.Visible = CType(resources.GetObject("btnclose.Visible"), Boolean)
        '
        'btndelete
        '
        Me.btndelete.AccessibleDescription = resources.GetString("btndelete.AccessibleDescription")
        Me.btndelete.AccessibleName = resources.GetString("btndelete.AccessibleName")
        Me.btndelete.Anchor = CType(resources.GetObject("btndelete.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.btndelete.BackgroundImage = CType(resources.GetObject("btndelete.BackgroundImage"), System.Drawing.Image)
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Dock = CType(resources.GetObject("btndelete.Dock"), System.Windows.Forms.DockStyle)
        Me.btndelete.Enabled = CType(resources.GetObject("btndelete.Enabled"), Boolean)
        Me.btndelete.FlatStyle = CType(resources.GetObject("btndelete.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.btndelete.Font = CType(resources.GetObject("btndelete.Font"), System.Drawing.Font)
        Me.btndelete.Image = CType(resources.GetObject("btndelete.Image"), System.Drawing.Image)
        Me.btndelete.ImageAlign = CType(resources.GetObject("btndelete.ImageAlign"), System.Drawing.ContentAlignment)
        Me.btndelete.ImageIndex = CType(resources.GetObject("btndelete.ImageIndex"), Integer)
        Me.btndelete.ImeMode = CType(resources.GetObject("btndelete.ImeMode"), System.Windows.Forms.ImeMode)
        Me.btndelete.Location = CType(resources.GetObject("btndelete.Location"), System.Drawing.Point)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.RightToLeft = CType(resources.GetObject("btndelete.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.btndelete.Size = CType(resources.GetObject("btndelete.Size"), System.Drawing.Size)
        Me.btndelete.TabIndex = CType(resources.GetObject("btndelete.TabIndex"), Integer)
        Me.btndelete.Text = resources.GetString("btndelete.Text")
        Me.btndelete.TextAlign = CType(resources.GetObject("btndelete.TextAlign"), System.Drawing.ContentAlignment)
        Me.btndelete.Visible = CType(resources.GetObject("btndelete.Visible"), Boolean)
        '
        'grd
        '
        Me.grd.AccessibleDescription = resources.GetString("grd.AccessibleDescription")
        Me.grd.AccessibleName = resources.GetString("grd.AccessibleName")
        Me.grd.Anchor = CType(resources.GetObject("grd.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.grd.BackgroundImage = CType(resources.GetObject("grd.BackgroundImage"), System.Drawing.Image)
        Me.grd.Dock = CType(resources.GetObject("grd.Dock"), System.Windows.Forms.DockStyle)
        Me.grd.ImeMode = CType(resources.GetObject("grd.ImeMode"), System.Windows.Forms.ImeMode)
        Me.grd.Location = CType(resources.GetObject("grd.Location"), System.Drawing.Point)
        Me.grd.Name = "grd"
        Me.grd.OcxState = CType(resources.GetObject("grd.OcxState"), System.Windows.Forms.AxHost.State)
        Me.grd.Size = CType(resources.GetObject("grd.Size"), System.Drawing.Size)
        Me.grd.TabIndex = CType(resources.GetObject("grd.TabIndex"), Integer)
        Me.grd.Visible = CType(resources.GetObject("grd.Visible"), Boolean)
        '
        'frmUndoSort
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmUndoSort"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Retreive Sorted Records
    Private Sub retreivesortedrecords()
        Dim drsort As SqlDataReader
        Dim mdate, tmp, sdate As String
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select * from tbl_receiving where PTN=" + ComboBox1.Text)
        drsort = objclass.OpenDataReader()
        grd.Rows = 1
        grd.Rows = 2
        While drsort.Read
            grd.set_TextMatrix(grd.Rows - 1, 0, Trim(drsort.Item("Division")))
            grd.set_TextMatrix(grd.Rows - 1, 1, Trim(objclass.IsNull(drsort.Item("ptn"))))
            tmp = (drsort.Item("Receivedate"))
            mdate = Microsoft.VisualBasic.DateAndTime.Day(tmp)
            sdate = Month(drsort.Item("Receivedate")) & "/" & mdate & "/" & Year(drsort.Item("Receivedate"))
            grd.set_TextMatrix(grd.Rows - 1, 2, sdate)
            grd.set_TextMatrix(grd.Rows - 1, 3, Trim(objclass.IsNull(drsort.Item("sorter_name"))))
        End While
        drsort.Close()
        objclass.Close()
        drsort = Nothing
        objclass = Nothing
    End Sub
    'Retreive PTN from tbl_receiving and pass to combobox
    Private Sub retreive_ptn()
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select distinct top 100 ptn  from tbl_receiving where status_id=2")
        dr = objclass.OpenDataReader()
        Me.ComboBox1.Items.Clear()

        While dr.Read
            Me.ComboBox1.Items.Add(Trim(dr.Item("ptn")))
        End While

        dr.Close()
        objclass.Close()
        dr = Nothing
        objclass = Nothing
    End Sub
    Private myConn As SqlConnection

    Private Sub frmUndoSort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Text = ""
        Call retreive_ptn()
        Me.btndelete.Enabled = False
        Me.btnsearch.Enabled = False
    End Sub
    'GO Button
    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select * from tbl_receiving where status_id=2 and ptn = '" + ComboBox1.Text.Trim + "'")
        dr = objclass.OpenDataReader()


        If dr.Read = False Then
            grd.Rows = 1
            grd.Rows = 2
            MsgBox("No record(s) found. PTN may not yet sorted or already costed or released.", MsgBoxStyle.Information)
            ComboBox1.Text = ""
            Me.ComboBox1.Focus()
        Else
            Call retreivesortedrecords()
            Call getmptn()
            grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
            Call retreive_items()
            Me.btndelete.Enabled = True
        End If

        dr.Close()
        objclass.Close()
        dr = Nothing
        objclass = Nothing
    End Sub

    'Combobox1 Keydown
    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                If e.KeyCode <> Keys.Back Then
                    nonNumberEntered = True

                End If
            End If
        End If

        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select * from tbl_receiving where status_id=2 and ptn = '" + ComboBox1.Text.Trim + "'")
        dr = objclass.OpenDataReader()

        If e.KeyCode = Keys.Enter Then
            If ComboBox1.Text = "" Then
                MsgBox("Search PTN first.", MsgBoxStyle.Information)
                Me.ComboBox1.Focus()
            ElseIf dr.Read = False Then
                grd.Rows = 1
                grd.Rows = 2
                MsgBox("No record(s) found. PTN may not yet sorted or already costed or released.", MsgBoxStyle.Information)
                ComboBox1.Text = ""
                Me.ComboBox1.Focus()
            Else
                Call retreivesortedrecords()
                Call getmptn()
                grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
                Call retreive_items()
                Me.btndelete.Enabled = True
            End If
        End If

        dr.Close()
        objclass.Close()
        dr = Nothing
        objclass = Nothing

    End Sub

    'Retreive records from table: tbl_ptn_item
    Private Sub retreive_items()
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select distinct * from tbl_ptn_item where MPTN = '" + Trim(mptn) + "' order by itemcode")
        dr = objclass.OpenDataReader()
        While dr.Read
            grd.set_TextMatrix(grd.Rows - 1, 4, Trim(objclass.IsNull(dr.Item("PTNITEMDesc"))))
            grd.set_TextMatrix(grd.Rows - 1, 5, Trim(objclass.IsNull(dr.Item("Quantity"))))
            grd.set_TextMatrix(grd.Rows - 1, 6, Trim(objclass.IsNull(dr.Item("KaratGrading"))))
            grd.set_TextMatrix(grd.Rows - 1, 7, Trim(objclass.IsNull(dr.Item("CaratSize"))))
            grd.set_TextMatrix(grd.Rows - 1, 8, Trim(objclass.IsNull(FormatNumber(dr.Item("Weight"), 2))))
            grd.Rows += 1
        End While

        dr.Close()
        objclass.Close()
        dr = Nothing
        objclass = Nothing
    End Sub

    Public Sub getmptn()
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("select top 1* from tbl_pt_tran where PTN = '" + grd.get_TextMatrix(1, 1) + "'")
        dr = objclass.OpenDataReader()
        If dr.Read Then
            mptn = dr.Item("mptn")
            loanvalue = dr.Item("PTNPrincipal")
        End If
        dr.Close()
        objclass.CloseDataReader()
        objclass = Nothing
    End Sub

    'Combobox1 KeyPress
    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        If nonNumberEntered = True Then
            e.Handled = True
        End If
    End Sub
    'Update Table: tbl_receiving
    Private Sub update_tbl_receiving()
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("update tbl_receiving set [sorter_id]=null, [sorter_name]=null, [sortaction_id]=null, [sort_code]=null, [sortdate]=null, [status_id]=1 where ptn = '" + grd.get_TextMatrix(1, 1) + "'")
        objclass.Execute()
        objclass.Close()
        objclass = Nothing
    End Sub
    'Update Table: tbl_ptn_item
    Private Sub update_tbl_ptn_item()
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("update tbl_ptn_item set  [ALL_WT]=null, [ALL_KARAT]=null, [ALL_VALUE]=null, [ALL_Carat]=null, [ALL_PRICE]=null, [CELLULAR_COST]=null, [REPAIR_COST]=null, [CLEANING_COST]=null, [GOLD_COST]=null,[YG_COST]=null,[WG_COST]=null, [ALL_VALUECOST]=null where mptn='" + mptn + "'")
        objclass.Execute()
        objclass.Close()
        objclass = Nothing
    End Sub
    'Undo Sort Button
    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        Dim drsort As SqlDataReader
        Dim objclass As New clsCommon

        If MsgBox("Are you sure you want to undo sort this record(s)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            objclass.ConnectionString1()
            objclass.Open()
            objclass.Command("select mptn from tbl_pt_tran where ptn='" + grd.get_TextMatrix(1, 1) + "'")
            drsort = objclass.OpenDataReader()
            drsort.Read()
            mptn = drsort.Item(Trim("mptn"))

            Call update_tbl_receiving()
            Call update_tbl_ptn_item()
            grd.Rows = 1
            grd.Rows = 2
            Me.ComboBox1.Items.Clear()
            Me.ComboBox1.Text = ""
            MsgBox("Record(s) successfully updated.", MsgBoxStyle.Information)
            Call retreive_ptn()
            mptn = Nothing
            drsort.Close()
            drsort = Nothing
            objclass = Nothing
            ComboBox1.Focus()
            Me.btndelete.Enabled = False
        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
        mptn = Nothing
    End Sub

    'Combobox1 Textchanged
    Private Sub ComboBox1_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "" Then
            Me.btnsearch.Enabled = False
            grd.Rows = 1
            grd.Rows = 2
            Me.btndelete.Enabled = False
        Else
            Me.btnsearch.Enabled = True
        End If
    End Sub

    Private Sub btndelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.MouseHover
        Me.btndelete.Text = "[ Delete ]"
    End Sub

    Private Sub btndelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndelete.MouseLeave
        Me.btndelete.Text = "Undo Sort"
    End Sub

    Private Sub btnsearch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.MouseHover
        Me.btnsearch.Text = "[ GO ]"
    End Sub

    Private Sub btnsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnsearch.MouseLeave
        Me.btnsearch.Text = "GO"
    End Sub

    Private Sub btnclose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseHover
        Me.btnclose.Text = "[ Close ]"
    End Sub

    Private Sub btnclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnclose.MouseLeave
        Me.btnclose.Text = "Close"
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        grd.Rows = 1
        grd.Rows = 2
        objclass.ConnectionString1()
        objclass.Open()
        ComboBox1.Text = ComboBox1.SelectedItem
        objclass.Command("select * from tbl_receiving where status_id=2 and ptn = '" + ComboBox1.Text.Trim + "'")
        dr = objclass.OpenDataReader()

        If dr.Read = False Then
            MsgBox("No record(s) found. PTN may not yet received or already sorted, costed, or released.", MsgBoxStyle.Information)
            ComboBox1.Text = ""
            Me.ComboBox1.Focus()
        Else
            Call retreivesortedrecords()
            Call getmptn()
            grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
            Call retreive_items()
            Me.btndelete.Enabled = True
        End If

        dr.Close()
        objclass.Close()
        dr = Nothing
    End Sub
End Class
