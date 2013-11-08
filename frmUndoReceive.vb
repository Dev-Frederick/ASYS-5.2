Imports System.Data.SqlClient

Public Class frmUndoReceive
    Inherits System.Windows.Forms.Form
    Public objclass As New clsCommon
    Private nonNumberEntered As Boolean = False
    Private mptn As String
    Private loanvalue As String

    Dim dr As SqlDataReader
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
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    'Friend WithEvents grd As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUndoReceive))
        Me.lblsearch = New System.Windows.Forms.Label
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2.SuspendLayout()
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
        'cmdsearch
        '
        Me.cmdsearch.AccessibleDescription = resources.GetString("cmdsearch.AccessibleDescription")
        Me.cmdsearch.AccessibleName = resources.GetString("cmdsearch.AccessibleName")
        Me.cmdsearch.Anchor = CType(resources.GetObject("cmdsearch.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdsearch.BackgroundImage = CType(resources.GetObject("cmdsearch.BackgroundImage"), System.Drawing.Image)
        Me.cmdsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsearch.Dock = CType(resources.GetObject("cmdsearch.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdsearch.Enabled = CType(resources.GetObject("cmdsearch.Enabled"), Boolean)
        Me.cmdsearch.FlatStyle = CType(resources.GetObject("cmdsearch.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdsearch.Font = CType(resources.GetObject("cmdsearch.Font"), System.Drawing.Font)
        Me.cmdsearch.Image = CType(resources.GetObject("cmdsearch.Image"), System.Drawing.Image)
        Me.cmdsearch.ImageAlign = CType(resources.GetObject("cmdsearch.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdsearch.ImageIndex = CType(resources.GetObject("cmdsearch.ImageIndex"), Integer)
        Me.cmdsearch.ImeMode = CType(resources.GetObject("cmdsearch.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdsearch.Location = CType(resources.GetObject("cmdsearch.Location"), System.Drawing.Point)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.RightToLeft = CType(resources.GetObject("cmdsearch.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdsearch.Size = CType(resources.GetObject("cmdsearch.Size"), System.Drawing.Size)
        Me.cmdsearch.TabIndex = CType(resources.GetObject("cmdsearch.TabIndex"), Integer)
        Me.cmdsearch.Text = resources.GetString("cmdsearch.Text")
        Me.cmdsearch.TextAlign = CType(resources.GetObject("cmdsearch.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdsearch.Visible = CType(resources.GetObject("cmdsearch.Visible"), Boolean)
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleDescription = resources.GetString("ComboBox1.AccessibleDescription")
        Me.ComboBox1.AccessibleName = resources.GetString("ComboBox1.AccessibleName")
        Me.ComboBox1.AllowDrop = True
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
        'GroupBox2
        '
        Me.GroupBox2.AccessibleDescription = resources.GetString("GroupBox2.AccessibleDescription")
        Me.GroupBox2.AccessibleName = resources.GetString("GroupBox2.AccessibleName")
        Me.GroupBox2.Anchor = CType(resources.GetObject("GroupBox2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.cmddelete)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Dock = CType(resources.GetObject("GroupBox2.Dock"), System.Windows.Forms.DockStyle)
        Me.GroupBox2.Enabled = CType(resources.GetObject("GroupBox2.Enabled"), Boolean)
        Me.GroupBox2.Font = CType(resources.GetObject("GroupBox2.Font"), System.Drawing.Font)
        Me.GroupBox2.ImeMode = CType(resources.GetObject("GroupBox2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.GroupBox2.Location = CType(resources.GetObject("GroupBox2.Location"), System.Drawing.Point)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = CType(resources.GetObject("GroupBox2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.GroupBox2.Size = CType(resources.GetObject("GroupBox2.Size"), System.Drawing.Size)
        Me.GroupBox2.TabIndex = CType(resources.GetObject("GroupBox2.TabIndex"), Integer)
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = resources.GetString("GroupBox2.Text")
        Me.GroupBox2.Visible = CType(resources.GetObject("GroupBox2.Visible"), Boolean)
        '
        'cmddelete
        '
        Me.cmddelete.AccessibleDescription = resources.GetString("cmddelete.AccessibleDescription")
        Me.cmddelete.AccessibleName = resources.GetString("cmddelete.AccessibleName")
        Me.cmddelete.Anchor = CType(resources.GetObject("cmddelete.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmddelete.BackgroundImage = CType(resources.GetObject("cmddelete.BackgroundImage"), System.Drawing.Image)
        Me.cmddelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmddelete.Dock = CType(resources.GetObject("cmddelete.Dock"), System.Windows.Forms.DockStyle)
        Me.cmddelete.Enabled = CType(resources.GetObject("cmddelete.Enabled"), Boolean)
        Me.cmddelete.FlatStyle = CType(resources.GetObject("cmddelete.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmddelete.Font = CType(resources.GetObject("cmddelete.Font"), System.Drawing.Font)
        Me.cmddelete.Image = CType(resources.GetObject("cmddelete.Image"), System.Drawing.Image)
        Me.cmddelete.ImageAlign = CType(resources.GetObject("cmddelete.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmddelete.ImageIndex = CType(resources.GetObject("cmddelete.ImageIndex"), Integer)
        Me.cmddelete.ImeMode = CType(resources.GetObject("cmddelete.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmddelete.Location = CType(resources.GetObject("cmddelete.Location"), System.Drawing.Point)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.RightToLeft = CType(resources.GetObject("cmddelete.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmddelete.Size = CType(resources.GetObject("cmddelete.Size"), System.Drawing.Size)
        Me.cmddelete.TabIndex = CType(resources.GetObject("cmddelete.TabIndex"), Integer)
        Me.cmddelete.Text = resources.GetString("cmddelete.Text")
        Me.cmddelete.TextAlign = CType(resources.GetObject("cmddelete.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmddelete.Visible = CType(resources.GetObject("cmddelete.Visible"), Boolean)
        '
        'cmdclose
        '
        Me.cmdclose.AccessibleDescription = resources.GetString("cmdclose.AccessibleDescription")
        Me.cmdclose.AccessibleName = resources.GetString("cmdclose.AccessibleName")
        Me.cmdclose.Anchor = CType(resources.GetObject("cmdclose.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdclose.BackgroundImage = CType(resources.GetObject("cmdclose.BackgroundImage"), System.Drawing.Image)
        Me.cmdclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdclose.Dock = CType(resources.GetObject("cmdclose.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdclose.Enabled = CType(resources.GetObject("cmdclose.Enabled"), Boolean)
        Me.cmdclose.FlatStyle = CType(resources.GetObject("cmdclose.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdclose.Font = CType(resources.GetObject("cmdclose.Font"), System.Drawing.Font)
        Me.cmdclose.Image = CType(resources.GetObject("cmdclose.Image"), System.Drawing.Image)
        Me.cmdclose.ImageAlign = CType(resources.GetObject("cmdclose.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdclose.ImageIndex = CType(resources.GetObject("cmdclose.ImageIndex"), Integer)
        Me.cmdclose.ImeMode = CType(resources.GetObject("cmdclose.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdclose.Location = CType(resources.GetObject("cmdclose.Location"), System.Drawing.Point)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.RightToLeft = CType(resources.GetObject("cmdclose.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdclose.Size = CType(resources.GetObject("cmdclose.Size"), System.Drawing.Size)
        Me.cmdclose.TabIndex = CType(resources.GetObject("cmdclose.TabIndex"), Integer)
        Me.cmdclose.Text = resources.GetString("cmdclose.Text")
        Me.cmdclose.TextAlign = CType(resources.GetObject("cmdclose.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdclose.Visible = CType(resources.GetObject("cmdclose.Visible"), Boolean)
        '
        'ListView1
        '
        Me.ListView1.AccessibleDescription = resources.GetString("ListView1.AccessibleDescription")
        Me.ListView1.AccessibleName = resources.GetString("ListView1.AccessibleName")
        Me.ListView1.Alignment = CType(resources.GetObject("ListView1.Alignment"), System.Windows.Forms.ListViewAlignment)
        Me.ListView1.Anchor = CType(resources.GetObject("ListView1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackgroundImage = CType(resources.GetObject("ListView1.BackgroundImage"), System.Drawing.Image)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader16, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader12, Me.ColumnHeader14})
        Me.ListView1.Dock = CType(resources.GetObject("ListView1.Dock"), System.Windows.Forms.DockStyle)
        Me.ListView1.Enabled = CType(resources.GetObject("ListView1.Enabled"), Boolean)
        Me.ListView1.Font = CType(resources.GetObject("ListView1.Font"), System.Drawing.Font)
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.ImeMode = CType(resources.GetObject("ListView1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListView1.LabelWrap = CType(resources.GetObject("ListView1.LabelWrap"), Boolean)
        Me.ListView1.Location = CType(resources.GetObject("ListView1.Location"), System.Drawing.Point)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.RightToLeft = CType(resources.GetObject("ListView1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListView1.Size = CType(resources.GetObject("ListView1.Size"), System.Drawing.Size)
        Me.ListView1.TabIndex = CType(resources.GetObject("ListView1.TabIndex"), Integer)
        Me.ListView1.Text = resources.GetString("ListView1.Text")
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = CType(resources.GetObject("ListView1.Visible"), Boolean)
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = resources.GetString("ColumnHeader13.Text")
        Me.ColumnHeader13.TextAlign = CType(resources.GetObject("ColumnHeader13.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader13.Width = CType(resources.GetObject("ColumnHeader13.Width"), Integer)
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = resources.GetString("ColumnHeader16.Text")
        Me.ColumnHeader16.TextAlign = CType(resources.GetObject("ColumnHeader16.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader16.Width = CType(resources.GetObject("ColumnHeader16.Width"), Integer)
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = resources.GetString("ColumnHeader1.Text")
        Me.ColumnHeader1.TextAlign = CType(resources.GetObject("ColumnHeader1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader1.Width = CType(resources.GetObject("ColumnHeader1.Width"), Integer)
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = resources.GetString("ColumnHeader2.Text")
        Me.ColumnHeader2.TextAlign = CType(resources.GetObject("ColumnHeader2.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader2.Width = CType(resources.GetObject("ColumnHeader2.Width"), Integer)
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = resources.GetString("ColumnHeader3.Text")
        Me.ColumnHeader3.TextAlign = CType(resources.GetObject("ColumnHeader3.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader3.Width = CType(resources.GetObject("ColumnHeader3.Width"), Integer)
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = resources.GetString("ColumnHeader4.Text")
        Me.ColumnHeader4.TextAlign = CType(resources.GetObject("ColumnHeader4.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader4.Width = CType(resources.GetObject("ColumnHeader4.Width"), Integer)
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = resources.GetString("ColumnHeader5.Text")
        Me.ColumnHeader5.TextAlign = CType(resources.GetObject("ColumnHeader5.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader5.Width = CType(resources.GetObject("ColumnHeader5.Width"), Integer)
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = resources.GetString("ColumnHeader12.Text")
        Me.ColumnHeader12.TextAlign = CType(resources.GetObject("ColumnHeader12.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader12.Width = CType(resources.GetObject("ColumnHeader12.Width"), Integer)
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = resources.GetString("ColumnHeader14.Text")
        Me.ColumnHeader14.TextAlign = CType(resources.GetObject("ColumnHeader14.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader14.Width = CType(resources.GetObject("ColumnHeader14.Width"), Integer)
        '
        'ListView2
        '
        Me.ListView2.AccessibleDescription = resources.GetString("ListView2.AccessibleDescription")
        Me.ListView2.AccessibleName = resources.GetString("ListView2.AccessibleName")
        Me.ListView2.Alignment = CType(resources.GetObject("ListView2.Alignment"), System.Windows.Forms.ListViewAlignment)
        Me.ListView2.Anchor = CType(resources.GetObject("ListView2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BackgroundImage = CType(resources.GetObject("ListView2.BackgroundImage"), System.Drawing.Image)
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView2.Dock = CType(resources.GetObject("ListView2.Dock"), System.Windows.Forms.DockStyle)
        Me.ListView2.Enabled = CType(resources.GetObject("ListView2.Enabled"), Boolean)
        Me.ListView2.Font = CType(resources.GetObject("ListView2.Font"), System.Drawing.Font)
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.ImeMode = CType(resources.GetObject("ListView2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ListView2.LabelWrap = CType(resources.GetObject("ListView2.LabelWrap"), Boolean)
        Me.ListView2.Location = CType(resources.GetObject("ListView2.Location"), System.Drawing.Point)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.RightToLeft = CType(resources.GetObject("ListView2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ListView2.Size = CType(resources.GetObject("ListView2.Size"), System.Drawing.Size)
        Me.ListView2.TabIndex = CType(resources.GetObject("ListView2.TabIndex"), Integer)
        Me.ListView2.Text = resources.GetString("ListView2.Text")
        Me.ListView2.View = System.Windows.Forms.View.Details
        Me.ListView2.Visible = CType(resources.GetObject("ListView2.Visible"), Boolean)
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = resources.GetString("ColumnHeader15.Text")
        Me.ColumnHeader15.TextAlign = CType(resources.GetObject("ColumnHeader15.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader15.Width = CType(resources.GetObject("ColumnHeader15.Width"), Integer)
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = resources.GetString("ColumnHeader6.Text")
        Me.ColumnHeader6.TextAlign = CType(resources.GetObject("ColumnHeader6.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader6.Width = CType(resources.GetObject("ColumnHeader6.Width"), Integer)
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = resources.GetString("ColumnHeader7.Text")
        Me.ColumnHeader7.TextAlign = CType(resources.GetObject("ColumnHeader7.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader7.Width = CType(resources.GetObject("ColumnHeader7.Width"), Integer)
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = resources.GetString("ColumnHeader8.Text")
        Me.ColumnHeader8.TextAlign = CType(resources.GetObject("ColumnHeader8.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader8.Width = CType(resources.GetObject("ColumnHeader8.Width"), Integer)
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = resources.GetString("ColumnHeader9.Text")
        Me.ColumnHeader9.TextAlign = CType(resources.GetObject("ColumnHeader9.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader9.Width = CType(resources.GetObject("ColumnHeader9.Width"), Integer)
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = resources.GetString("ColumnHeader10.Text")
        Me.ColumnHeader10.TextAlign = CType(resources.GetObject("ColumnHeader10.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader10.Width = CType(resources.GetObject("ColumnHeader10.Width"), Integer)
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = resources.GetString("ColumnHeader11.Text")
        Me.ColumnHeader11.TextAlign = CType(resources.GetObject("ColumnHeader11.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.ColumnHeader11.Width = CType(resources.GetObject("ColumnHeader11.Width"), Integer)
        '
        'frmUndoReceive
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmUndoReceive"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Retreive all records from tbl_receiving
    'Private Sub retreive_receiving()
    '    Dim dr As SqlDataReader
    '    Dim objclass As New clsCommon
    '    Dim tmp, sdate, mdate As String
    '    Dim odatetime As clsCommon.DateTime

    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("select * from tbl_receiving_header where recPTN = '" + ComboBox1.Text + "'")
    '    dr = objclass.OpenDataReader()

    '    If dr.Read Then
    '        grd.set_TextMatrix(grd.Rows - 1, 0, Trim(dr.Item("recDivision")))
    '        grd.set_TextMatrix(grd.Rows - 1, 1, Trim(objclass.IsNull(dr.Item("recptn"))))
    '        tmp=(dr.Item("Receivedate"))
    '        mdate = Microsoft.VisualBasic.DateAndTime.Day(tmp)
    '        sdate = Month(dr.Item("Receivedate")) & "/" & mdate & "/" & Year(dr.Item("Receivedate"))
    '        grd.set_TextMatrix(grd.Rows - 1, 2, sdate)
    '        grd.set_TextMatrix(grd.Rows - 1, 3, Trim(objclass.IsNull(dr.Item("recname"))))
    '        loanvalue = dr.Item("recloanvalue")
    '    End If
    '    dr.Close()
    '    objclass.Close()
    '    dr = Nothing
    '    objclass = Nothing

    'End Sub
    'Form Load
    Dim myconnection As New SqlConnection

    Private Sub frmUndoReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ComboBox1.Text = ""
        Me.cmddelete.Enabled = False
        Me.cmdsearch.Enabled = False
        'Call retreive_ptn()
    End Sub
    'GO Button
    'Private Sub cmdsearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsearch.Click
    '    Dim dr As SqlDataReader
    '    Dim objclass As New clsCommon
    '    grd.Rows = 1
    '    grd.Rows = 2
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("select * from tbl_receiving_header where status_id = 1 and recptn = '" + ComboBox1.Text.Trim + "'")
    '    dr = objclass.OpenDataReader()

    '    If ComboBox1.Text = "" Then
    '        MsgBox("Input or search PTN first.", MsgBoxStyle.Information)
    '        Me.ComboBox1.Focus()
    '    ElseIf dr.Read = False Then
    '        grd.Rows = 1
    '        grd.Rows = 2
    '        Me.cmddelete.Enabled = False
    '        MsgBox("No record(s) found. PTN may not yet received or already sorted, costed, or released.", MsgBoxStyle.Information)
    '        ComboBox1.Text = ""
    '        Me.ComboBox1.Focus()

    '    Else
    '        Call retreive_receiving()
    '        Call get_mptn()
    '        grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
    '        Call retreive_items()
    '        Me.cmddelete.Enabled = True
    '    End If


    '    dr.Close()
    '    objclass.Close()
    '    dr = Nothing
    '    objclass = Nothing

    'End Sub
    'Retreive PTN from tbl_receiving and pass to combobox1
    Private Sub retreive_ptn()
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        ComboBox1.Text = ComboBox1.SelectedItem
        objclass.Command("select distinct recptn from tbl_receiving_header where status_id = 1")
        dr = objclass.OpenDataReader()
        Me.ComboBox1.Items.Clear()

        While dr.Read
            Me.ComboBox1.Items.Add(Trim(dr.Item("recptn")))
        End While
        dr.Close()
        objclass.Close()
        dr = Nothing
        objclass = Nothing
    End Sub
    'Delete Receiving
    Private Sub delete_receiving()
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        objclass.ConnectionString1()
        objclass.Open()
        objclass.Command("delete from tbl_receiving_header where recptn = '" + ListView1.Items(0).SubItems.Item(4).Text + "'")
        objclass.Execute()
        objclass.Command("delete from tbl_receiving_detail where dptn = '" + ListView1.Items(0).SubItems.Item(4).Text + "'")
        objclass.Execute()
        objclass.Command("delete from rems.dbo.tbl_receiving_header where recptn = '" + ListView1.Items(0).SubItems.Item(4).Text + "'")
        objclass.Execute()
        objclass.Command("delete from rems.dbo.tbl_receiving_detail where dptn ='" + ListView1.Items(0).SubItems.Item(4).Text + "'")
        objclass.Execute()
        objclass.Close()
        objclass = Nothing
    End Sub
    'Update tbl_pt_tran
    'Private Sub update_tbl_pt_tran()
    '    Dim objclass As New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("update tbl_pt_tran set received = 0 where ptn = '" + grd.get_TextMatrix(1, 1) + "'")
    '    objclass.Execute()
    '    objclass.Close()
    '    objclass = Nothing
    'End Sub

    'Close Button
    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdsearch_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsearch.MouseHover
        cmdsearch.Text = "[ GO ]"
    End Sub

    Private Sub cmdsearch_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsearch.MouseLeave
        cmdsearch.Text = "GO"
    End Sub
    'Combobox1 Keydown
    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        Try

       
        Dim dr As SqlDataReader
        Dim objclass As New clsCommon
        Dim str As String
        Dim ifnorows As Boolean

        nonNumberEntered = False
        If e.KeyCode < Keys.D0 OrElse e.KeyCode > Keys.D9 Then
            If e.KeyCode < Keys.NumPad0 OrElse e.KeyCode > Keys.NumPad9 Then
                If e.KeyCode <> Keys.Back Then
                    nonNumberEntered = True
                End If
            End If
        End If

            If e.KeyCode = Keys.Enter Then
                'grd.Rows = 1
                'grd.Rows = 2
                'objclass.ConnectionString1()
                'objclass.Open()
                'objclass.Command("select * from tbl_receiving_header where  recptn = '" + ComboBox1.Text.Trim + "'")
                'dr = objclass.OpenDataReader()


                'If dr.Read = False Then
                '    MsgBox("No record(s) found. PTN may not yet received or already sorted, costed, or released.", MsgBoxStyle.Information)
                '    ComboBox1.Text = ""
                '    Me.ComboBox1.Focus()
                '    dr.Close()
                '    objclass.Close()
                '    dr = Nothing
                '    Exit Sub
                'End If

                'If ComboBox1.Text = "" Then
                '    MsgBox("Search PTN first.", MsgBoxStyle.Information)
                '    Me.ComboBox1.Focus()
                '    grd.Rows = 1
                '    grd.Rows = 1
                '    Me.cmddelete.Enabled = False
                'Else
                '    Call retreive_receiving()
                '    Call get_mptn()
                '    grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
                '    Call retreive_items()
                '    Me.cmddelete.Enabled = True
                'End If
                'dr.Close()
                'objclass.Close()
                'dr = Nothing
                ifnorows = False
                ListView1.Items.Clear()
                ListView2.Items.Clear()

                objclass = New clsCommon
                objclass.ConnectionString1()
                objclass.Open()
                str = "Select Header_id,recDivision,recDivisionName,recptn,recItem_Id,recLoanValue,recName,receivedate,status_id from tbl_receiving_header where recptn = '" & ComboBox1.Text & "'"
                objclass.Command(str)
                dr = objclass.OpenDataReader
                While dr.Read
                    ifnorows = True
                    ListView1.Items.Add(dr.Item("Header_id"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("recItem_Id"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("recDivision"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("recDivisionname")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("recptn"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Format(dr.Item("receivedate"), "Short Date"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(dr.Item("recname")))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("recloanvalue"))
                    ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr.Item("status_id"))
                End While
                dr.Close()

                str = "Select detail_id,id,ptnitemdesc,quantity,karatgrading,caratsize,weight from tbl_receiving_detail where dptn = '" & ComboBox1.Text & "'"
                objclass.Command(str)
                dr = objclass.OpenDataReader
                While dr.Read
                    ListView2.Items.Add(dr.Item("detail_id"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("id"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(Trim(dr.Item("ptnitemdesc")))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("quantity"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("karatgrading"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("caratsize"))
                    ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(dr.Item("weight"))
                End While
                dr.Close()

                objclass.Close()
                objclass = Nothing


                If ifnorows = False Then
                    MsgBox("PTN not Found")
                End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Public Sub get_mptn()
    '    Dim dr As SqlDataReader
    '    Dim objclass As New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("select * from tbl_receiving_detail where dPTN = '" + grd.get_TextMatrix(1, 1) + "'")
    '    dr = objclass.OpenDataReader()
    '    If dr.Read Then
    '        mptn = dr.Item("mptn")
    '    End If
    '    dr.Close()
    '    objclass.CloseDataReader()
    '    objclass = Nothing
    'End Sub

    'Delete Button
    Private Sub cmddelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmddelete.Click

        If MsgBox("Are you sure you want Undo Receive this record(s)?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then

            Call delete_receiving()
            'Call update_tbl_pt_tran()
            'grd.Rows = 1
            ' grd.Rows = 2
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            Me.cmddelete.Enabled = False
            MsgBox("Record(s) successfully deleted from Database, Table: tbl_receiving.", MsgBoxStyle.Information)
            ' Call retreive_ptn()
            Me.Refresh()
            Me.ComboBox1.Focus()
            cmddelete.Enabled = False
        Else
            Me.Refresh()
        End If
    End Sub

    Private Sub cmdclose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Hide()
    End Sub

    Private Sub cmddelete_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmddelete.MouseHover
        Me.cmddelete.Text = "[ Delete ]"
    End Sub

    Private Sub cmddelete_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmddelete.MouseLeave
        Me.cmddelete.Text = "Undo Receive"
    End Sub

    Private Sub cmdclose_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdclose.MouseHover
        Me.cmdclose.Text = "[ Close ]"
    End Sub

    Private Sub cmdclose_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdclose.MouseLeave
        Me.cmdclose.Text = "Close"
    End Sub

    'Retreive records from table: tbl_ptn_item
    'Private Sub retreive_items()
    '    Dim dr As SqlDataReader
    '    Dim objclass As New clsCommon
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    objclass.Command("select distinct * from tbl_receiving_detail where MPTN = '" + Trim(mptn) + "' order by itemcode")
    '    dr = objclass.OpenDataReader()
    '    While dr.Read
    '        grd.set_TextMatrix(grd.Rows - 1, 4, Trim(objclass.IsNull(dr.Item("PTNITEMDesc"))))
    '        grd.set_TextMatrix(grd.Rows - 1, 5, Trim(objclass.IsNull(dr.Item("Quantity"))))
    '        grd.set_TextMatrix(grd.Rows - 1, 6, Trim(objclass.IsNull(dr.Item("KaratGrading"))))
    '        grd.set_TextMatrix(grd.Rows - 1, 7, Trim(objclass.IsNull(dr.Item("CaratSize"))))
    '        grd.set_TextMatrix(grd.Rows - 1, 8, Trim(objclass.IsNull(FormatNumber(dr.Item("Weight"), 2))))
    '        grd.Rows += 1
    '    End While

    '    dr.Close()
    '    objclass.Close()
    '    dr = Nothing
    '    objclass = Nothing

    'End Sub


    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

        If nonNumberEntered = True Then
            e.Handled = True
        End If

    End Sub

    'Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
    '    If ComboBox1.Text = "" Then
    '        cmddelete.Enabled = False
    '        Me.cmdsearch.Enabled = False
    '        grd.Rows = 1
    '        grd.Rows = 2
    '    Else
    '        Me.cmdsearch.Enabled = True
    '    End If

    'End Sub

    'Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectionChangeCommitted
    '    Dim dr As SqlDataReader
    '    Dim objclass As New clsCommon
    '    grd.Rows = 1
    '    grd.Rows = 2
    '    objclass.ConnectionString1()
    '    objclass.Open()
    '    ComboBox1.Text = ComboBox1.SelectedItem
    '    objclass.Command("select * from tbl_receiving_header where recptn = '" + ComboBox1.Text.Trim + "'")
    '    dr = objclass.OpenDataReader()


    '    If dr.Read = False Then
    '        MsgBox("No record(s) found. PTN may not yet received or already sorted, costed, or released.", MsgBoxStyle.Information)
    '        ComboBox1.Text = ""
    '        Me.ComboBox1.Focus()
    '    Else
    '        Call retreive_receiving()
    '        Call get_mptn()
    '        grd.set_TextMatrix(1, 9, FormatNumber(loanvalue, 2))
    '        Call retreive_items()
    '        Me.cmddelete.Enabled = True
    '    End If

    '    dr.Close()
    '    objclass.Close()
    '    dr = Nothing
    'End Sub

    Private Sub cmdsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsearch.Click

    End Sub
End Class


