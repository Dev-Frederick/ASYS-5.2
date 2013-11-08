Imports System.Data.SqlClient
Imports System.IO
Public Class frmSelfInventory
    Inherits System.Windows.Forms.Form
    Private WithEvents txtPTN As System.Windows.Forms.TextBox
    Private WithEvents txtBarcode As System.Windows.Forms.TextBox
    Private WithEvents txtTransNo As System.Windows.Forms.TextBox

    'button
    Private WithEvents cmdDelete As System.Windows.Forms.Button
    Private WithEvents dataTable As DataTable

    Dim dgtb As DataGridTextBoxColumn

    Private arrstr() As String
    Private arrstrX() As String

    Public sDatasource1 As String
    Public sDatabase1 As String
    Public sUsername1 As String
    Public sPassword1 As String


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        CreateGrid()
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DgEntry As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnAddRow As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents cboCostCenter As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnMissing As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboREMType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSelfInventory))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnAddRow = New System.Windows.Forms.Button
        Me.DgEntry = New System.Windows.Forms.DataGrid
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnMissing = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.cboCostCenter = New System.Windows.Forms.ComboBox
        Me.txtEmpID = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboREMType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "COST CENTER"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "EMPLOYEE ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnNew
        '
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(576, 168)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 32)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "NEW"
        '
        'btnAddRow
        '
        Me.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRow.Image = CType(resources.GetObject("btnAddRow.Image"), System.Drawing.Image)
        Me.btnAddRow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddRow.Location = New System.Drawing.Point(664, 168)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(88, 32)
        Me.btnAddRow.TabIndex = 8
        Me.btnAddRow.Text = "ADD ROW"
        Me.btnAddRow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DgEntry
        '
        Me.DgEntry.AlternatingBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackColor = System.Drawing.Color.OldLace
        Me.DgEntry.BackgroundColor = System.Drawing.Color.Tan
        Me.DgEntry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgEntry.CaptionBackColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.CaptionFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.CaptionForeColor = System.Drawing.Color.OldLace
        Me.DgEntry.DataMember = ""
        Me.DgEntry.FlatMode = True
        Me.DgEntry.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.GridLineColor = System.Drawing.Color.Tan
        Me.DgEntry.HeaderBackColor = System.Drawing.Color.Wheat
        Me.DgEntry.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgEntry.HeaderForeColor = System.Drawing.Color.SaddleBrown
        Me.DgEntry.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.DgEntry.Location = New System.Drawing.Point(8, 208)
        Me.DgEntry.Name = "DgEntry"
        Me.DgEntry.ParentRowsBackColor = System.Drawing.Color.OldLace
        Me.DgEntry.ParentRowsForeColor = System.Drawing.Color.DarkSlateGray
        Me.DgEntry.SelectionBackColor = System.Drawing.Color.SlateGray
        Me.DgEntry.SelectionForeColor = System.Drawing.Color.White
        Me.DgEntry.Size = New System.Drawing.Size(744, 288)
        Me.DgEntry.TabIndex = 9
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(672, 520)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(80, 48)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnProcess
        '
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Image = CType(resources.GetObject("btnProcess.Image"), System.Drawing.Image)
        Me.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProcess.Location = New System.Drawing.Point(392, 520)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(80, 48)
        Me.btnProcess.TabIndex = 10
        Me.btnProcess.Text = "PROCESS"
        Me.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnPrint
        '
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(472, 520)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(96, 48)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "PRINT SELF INVENTORY"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnMissing
        '
        Me.btnMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMissing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMissing.Image = CType(resources.GetObject("btnMissing.Image"), System.Drawing.Image)
        Me.btnMissing.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMissing.Location = New System.Drawing.Point(568, 520)
        Me.btnMissing.Name = "btnMissing"
        Me.btnMissing.Size = New System.Drawing.Size(104, 48)
        Me.btnMissing.TabIndex = 13
        Me.btnMissing.Text = "PRINT MISSING ITEMS"
        Me.btnMissing.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(136, 24)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(128, 20)
        Me.txtDate.TabIndex = 14
        Me.txtDate.Text = ""
        '
        'cboCostCenter
        '
        Me.cboCostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCostCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCostCenter.Items.AddRange(New Object() {"REM", "MLWB", "PRICING", "DISTRI"})
        Me.cboCostCenter.Location = New System.Drawing.Point(136, 48)
        Me.cboCostCenter.Name = "cboCostCenter"
        Me.cboCostCenter.Size = New System.Drawing.Size(128, 21)
        Me.cboCostCenter.TabIndex = 15
        '
        'txtEmpID
        '
        Me.txtEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(384, 24)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.ReadOnly = True
        Me.txtEmpID.Size = New System.Drawing.Size(168, 20)
        Me.txtEmpID.TabIndex = 16
        Me.txtEmpID.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboREMType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEmpID)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.cboCostCenter)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 80)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SELF INVENTORY"
        '
        'cboREMType
        '
        Me.cboREMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboREMType.Enabled = False
        Me.cboREMType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboREMType.ForeColor = System.Drawing.Color.Black
        Me.cboREMType.Items.AddRange(New Object() {"REMATADO", "TRADE-IN"})
        Me.cboREMType.Location = New System.Drawing.Point(384, 48)
        Me.cboREMType.Name = "cboREMType"
        Me.cboREMType.Size = New System.Drawing.Size(168, 21)
        Me.cboREMType.TabIndex = 18
        Me.cboREMType.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TYPE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 16)
        Me.Label1.TabIndex = 19
        '
        'frmSelfInventory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 582)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMissing)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.DgEntry)
        Me.Controls.Add(Me.btnAddRow)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSelfInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELF INVENTORY"
        CType(Me.DgEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub CreateGrid()
        Try
            'Declare and initialize local variables used
            Dim dtCol As DataColumn = Nothing 'Data Column variable
            'Create the String array object, initialize the array with the column names to be displayed
            arrstr = New String(12) {"NO.", "TRANSACTION NO.", "PTN", "A.L.L. BARCODE", "DESCRIPTION", "QTY", "WEIGHT", "KARAT", "CARAT", " LOAN VALUE ", "SELLING PRICE", "SERIAL NO", " "}
            arrstrX = New String(12) {"", "", "", "", "", 0, 0, 0, 0, 0.0, 0.0, 0, "DELETE"}
            'Create the Data Table object which will then be used to hold columns and rows
            dataTable = New DataTable("Controls")

            'Add the string array of columns to the DataColumn object 		
            Dim i As Integer
            For i = 0 To 12
                Dim str As String = arrstr(i)
                dtCol = New DataColumn(str)
                dtCol.DataType = System.Type.GetType("System.String")

                dtCol.DefaultValue = ""
                dataTable.Columns.Add(dtCol)
            Next i

            'Set the Data Grid Source as the Data Table created above
            DgEntry.DataSource = dataTable
            DgEntry.AllowSorting = False
            'set style property when first time the grid loads, next time onwards it will maintain its property
            If Not DgEntry.TableStyles.Contains("Controls") Then
                'Create a DataGridTableStyle object	
                Dim dgdtblStyle As New DataGridTableStyle
                'Set its properties
                dgdtblStyle.MappingName = dataTable.TableName 'its table name of dataset
                DgEntry.TableStyles.Add(dgdtblStyle)
                dgdtblStyle.RowHeadersVisible = False
                dgdtblStyle.PreferredRowHeight = 22
                DgEntry.BackgroundColor = Color.White

                DgEntry.ReadOnly = True
                'Take the columns in a GridColumnStylesCollection object and set the size of the individual columns	
                Dim colStyle As GridColumnStylesCollection
                colStyle = DgEntry.TableStyles(0).GridColumnStyles
                colStyle(0).Width = 50
                colStyle(1).Width = 120
                colStyle(2).Width = 120
                colStyle(3).Width = 130
                colStyle(4).Width = 230
                colStyle(5).Width = 60
                colStyle(5).Alignment = HorizontalAlignment.Right
                colStyle(6).Width = 60
                colStyle(6).Alignment = HorizontalAlignment.Right
                colStyle(7).Width = 60
                colStyle(7).Alignment = HorizontalAlignment.Right
                colStyle(8).Width = 60
                colStyle(8).Alignment = HorizontalAlignment.Right
                colStyle(9).Width = 130
                colStyle(9).Alignment = HorizontalAlignment.Right
                colStyle(10).Width = 130
                colStyle(10).Alignment = HorizontalAlignment.Right
                colStyle(11).Width = 130
                colStyle(11).Alignment = HorizontalAlignment.Right

                txtPTN = New TextBox
                txtPTN.Width = 120
                txtPTN.MaxLength = 12
                txtPTN.CharacterCasing = CharacterCasing.Upper

                txtBarcode = New TextBox
                txtBarcode.Width = 130
                txtBarcode.MaxLength = 17

                txtTransNo = New TextBox
                txtTransNo.Width = 120
                txtTransNo.MaxLength = 12

                cmdDelete = New Button
                cmdDelete.ForeColor = ForeColor.Transparent
                cmdDelete.Text = "DELETE"
                cmdDelete.Width = 50
                cmdDelete.Height = 20

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtTransNo)
                txtTransNo.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(2), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtPTN)
                txtPTN.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtBarcode)
                txtBarcode.BringToFront()

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(12), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(cmdDelete)
                cmdDelete.BringToFront()

            End If
            'Take the text box from the second column of the grid where u will be adding the controls of your choice	
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DgEntry_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DgEntry.MouseUp
        Try
            Select Case DgEntry.CurrentCell.ColumnNumber
                Case 1
                    txtPTN.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1).ToString
                Case 2
                    txtPTN.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2).ToString
                Case 3
                    txtBarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 3).ToString
                Case 12
                    cmdDelete_Click(sender, e)
            End Select
        Catch ex As Exception
            MsgBox("frmSelfInventory/DgEntry_MouseUp: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Try
            Me.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRow.Click
        Try
            If cboCostCenter.Text.Trim = "" Then
                MsgBox("Please select Cost Center", , TitleMsgBox)
                cboCostCenter.Focus()
                Exit Sub
            End If

            ''If cboCostCenter.Text = "REM" Then
            ''    If cboREMType.Text = "" Then
            ''        MsgBox("Please select type.", MsgBoxStyle.Information, TitleMsgBox)
            ''        cboREMType.Focus()
            ''        Exit Sub
            ''    End If
            ''End If

            Dim li_rowd As Integer = dataTable.Rows.Count
            If li_rowd = 0 Then
                AddRow(li_rowd)
                'ElseIf li_rowd = dataTable.Rows.Count Then
            Else
                If cboCostCenter.Text.Trim.ToUpper <> "REM" Then
                    If txtBarcode.Text <> "" Then
                        AddRow(li_rowd)
                    End If
                Else
                    If txtTransNo.Text <> "" Or txtPTN.Text <> "" Then
                        If DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "" Then
                            DgEntry.CurrentCell = New DataGridCell(li_rowd, 1)
                            DgEntry.Focus()
                            txtTransNo.Focus()
                            Exit Sub
                        End If
                        AddRow(li_rowd)
                    End If
                End If
                'ElseIf dataTable.Rows.Count = 0 Then
                '    If cboCostCenter.Text.ToUpper <> "REM" Then
                '        If txtBarcode.Text <> "" Then
                '            GoTo addrow
                '        End If
                '        If txtPTN.Text <> "" Then
                '            GoTo addrow
                '        End If
            End If
        Catch ex As Exception
            MsgBox("frmSelfInventory/btnAddRow_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub AddRow(ByVal li_rowd As Integer)
        Try
            bleh = True

            dgAutonumber()

            dataTable.LoadDataRow(arrstrX, True)

            If cboCostCenter.Text.Trim.ToUpper = "REM" Then
                txtPTN.ReadOnly = False
                txtBarcode.ReadOnly = False
                txtTransNo.ReadOnly = False

                txtTransNo = New TextBox
                txtTransNo.Width = 120
                txtTransNo.MaxLength = 12

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(1), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtTransNo)
                txtTransNo.BringToFront()

                DgEntry.CurrentCell = New DataGridCell(li_rowd, 1)
                DgEntry.Focus()
                txtTransNo.Focus()
            Else
                txtPTN.ReadOnly = True
                txtTransNo.ReadOnly = True
                txtBarcode = New TextBox
                txtBarcode.Width = 130
                txtBarcode.MaxLength = 17

                dgtb = CType(DgEntry.TableStyles(0).GridColumnStyles(3), DataGridTextBoxColumn)
                dgtb.TextBox.Controls.Add(txtBarcode)
                txtBarcode.BringToFront()

                DgEntry.CurrentCell = New DataGridCell(li_rowd, 3)
                DgEntry.Focus()
                txtBarcode.Focus()
            End If
        Catch ex As Exception
            MsgBox("frmSelfInventory/AddRow: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    Private Sub frmSelfInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            btnNew_Click(sender, e)
            btnProcess.Enabled = False
            cmdDelete.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Try
            'cboCostCenter.SelectedIndex = -1
            Dim frm As New frmLogin
            txtDate.Text = Date.Now.ToShortDateString
            txtEmpID.Text = GetResourceID()
            dataTable.Clear()

            cmdDelete.Enabled = True
            btnPrint.Enabled = False
            btnMissing.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Function GetResourceID() As String
        Try
            Dim objclass As New clsCommon
            Dim dr As SqlDataReader
            Dim squery As String


            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            squery = "Select usr_id from " & humres2 & " where res_id =" & UserPassW & " and blocked = 1"
            objclass.Command5(squery)
            dr = objclass.OpenDataReader5

            If dr.Read = True Then
                Return Trim(dr.Item("usr_id"))
            Else
                MsgBox("Username and Password did not match", MsgBoxStyle.Information, TitleMsgBox)
                Return ""
            End If


            dr.Close()
        Catch ex As Exception
            MsgBox("frmSelfInventory/GetResourceID: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Try
            'If Not e.KeyChar = ChrW(13) Then Exit Sub
            '''If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            '''    e.Handled = True
            '''    Exit Sub
            '''End If


            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Enter) And e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
            End If

            If e.KeyChar = ChrW(13) Then
                Dim SQuery As String
                Dim barcode As String = txtBarcode.Text.Trim
                Dim ds As New DataSet

                If barcode = "0" Or barcode = "" Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 0) = barcode
                    txtBarcode.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 0)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                    txtTransNo.Enabled = True
                    txtTransNo.Focus()
                Else

                    If cboCostCenter.Text.Trim.ToUpper = "REM" Then
                        If Val(DgEntry(DgEntry.CurrentCell.RowNumber, 1)) = 0 And Val(txtBarcode.Text) = 0 Then
                            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                            Exit Sub
                        End If
                    End If

                    Select Case cboCostCenter.Text.Trim.ToUpper
                        Case "REM"
                            If DgEntry(DgEntry.CurrentCell.RowNumber, 2) = "" Then
                                SQuery = "SELECT '',*,'' FROM vwASYS_REM_SelfInventory_Form WHERE ALLBARCODE = '" & barcode & "'"
                            Else
                                SQuery = "SELECT '',*,'' FROM vwASYS_REM_SelfInventory_Form WHERE ALLBARCODE = '" & barcode & "' and ptn = '" & DgEntry(DgEntry.CurrentCell.RowNumber, 1) & "'"
                            End If
                        Case "MLWB"
                            SQuery = "exec ASYS_spMLWB_SelfInventory '" & barcode & "'"
                        Case "PRICING"
                            SQuery = "exec ASYS_spPRICING_SelfInventory '" & barcode & "'"
                        Case "DISTRI"
                            SQuery = "exec ASYS_spDISTRI_SelfInventory '" & barcode & "'"
                    End Select

                    ds = ReturnDataset(SQuery)

                    Dim rowCount As Integer
                    If Not IsNothing(ds) Then
                        rowCount = ds.Tables(0).Rows.Count
                    Else
                        rowCount = 0
                        MsgBox("A.L.L. Barcode doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                        txtBarcode.Text = ""
                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 3)
                        DgEntry.Focus()
                        txtBarcode.Focus()
                        Exit Sub
                    End If

                    Dim a As Integer


                    '-------------------

                    'If dataTable.Rows.Count > 1 Then
                    'For a = 0 To dataTable.Rows.Count - 1
                    If DgEntry(a, 2) = UCase(txtBarcode.Text) Then
                        MsgBox("You have entered the same barcode", MsgBoxStyle.Information, TitleMsgBox)
                        'txtAllbarcode.Text = ""
                        DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 0)
                        txtBarcode.Focus()
                        'Exit For
                    Else
                        For i As Integer = 0 To rowCount - 1
                            Dim ptnStr As String
                            Dim barcodeStr As String
                            Dim descStr As String
                            Dim tmpQty As Double
                            Dim tmpWeight As Double
                            Dim tmpKarat As Double
                            Dim tmpCarat As Double
                            Dim tmpLoanValue As Double
                            Dim tmpSellingPrice As Double
                            Dim tmpSerialNo As String

                            ptnStr = Trim(ds.Tables(0).Rows(i)(2).ToString)
                            barcodeStr = Trim(ds.Tables(0).Rows(i)(3).ToString)
                            descStr = ds.Tables(0).Rows(i)(4).ToString
                            tmpQty = ds.Tables(0).Rows(i)(5).ToString
                            tmpWeight = ds.Tables(0).Rows(i)(6).ToString
                            tmpKarat = ds.Tables(0).Rows(i)(7).ToString
                            tmpCarat = ds.Tables(0).Rows(i)(8).ToString
                            tmpLoanValue = FormatNumber(ds.Tables(0).Rows(i)(9).ToString)
                            tmpSellingPrice = FormatNumber(ds.Tables(0).Rows(i)(10).ToString)
                            tmpSerialNo = ds.Tables(0).Rows(i)(12).ToString

                            If Not CheckGridIfExist(ptnStr, barcodeStr, descStr, tmpQty, tmpWeight, tmpKarat, tmpCarat, tmpLoanValue, tmpSellingPrice, tmpSerialNo) Then
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "0"
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ptnStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = barcodeStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = descStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ds.Tables(0).Rows(i)(5).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ds.Tables(0).Rows(i)(6).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ds.Tables(0).Rows(i)(7).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = ds.Tables(0).Rows(i)(8).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 9) = FormatNumber(ds.Tables(0).Rows(i)(9).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 10) = FormatNumber(ds.Tables(0).Rows(i)(10).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 11) = ds.Tables(0).Rows(i)(12).ToString

                                DgEntry(DgEntry.CurrentCell.RowNumber, 12) = "DELETE"
                                'txtBarcode.Text = barcodeStr
                                txtPTN.Text = ptnStr
                                btnAddRow_Click(sender, e)
                                txtBarcode.Text = "" 'txtPTN.Text = ""
                                txtTransNo.Text = ""
                                txtPTN.Text = ""
                                btnProcess.Enabled = True
                            Else
                                MsgBox("Item Already Exist", , TitleMsgBox)
                                txtBarcode.Text = ""
                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 3)
                                DgEntry.Focus()
                            End If
                        Next
                    End If
                    'Next
                    'End If
                    '-----------------------


                    '''If rowCount < 1 Or rowCount = Nothing Then
                    '''    MsgBox("ALLbarcode not found in Inventory.", MsgBoxStyle.Information, TitleMsgBox)
                    '''    txtBarcode.Text = ""
                    '''    txtBarcode.Focus()
                    '''Else
                    '''    For i As Integer = 0 To rowCount - 1
                    '''        Dim ptnStr As String
                    '''        Dim barcodeStr As String
                    '''        Dim descStr As String
                    '''        ptnStr = ds.Tables(0).Rows(i)(2).ToString
                    '''        barcodeStr = ds.Tables(0).Rows(i)(3).ToString
                    '''        descStr = ds.Tables(0).Rows(i)(4).ToString
                    '''        If Not CheckGridIfExist(ptnStr, barcodeStr, descStr) Then
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "0"
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ptnStr
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 3) = barcodeStr
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 4) = descStr
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ds.Tables(0).Rows(i)(5).ToString
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ds.Tables(0).Rows(i)(6).ToString
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ds.Tables(0).Rows(i)(7).ToString
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 8) = ds.Tables(0).Rows(i)(8).ToString
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 9) = FormatNumber(ds.Tables(0).Rows(i)(9).ToString)
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 10) = FormatNumber(ds.Tables(0).Rows(i)(10).ToString)
                    '''            DgEntry(DgEntry.CurrentCell.RowNumber, 11) = "DELETE"
                    '''            'txtBarcode.Text = barcodeStr
                    '''            txtPTN.Text = ptnStr
                    '''            btnAddRow_Click(sender, e)
                    '''            txtBarcode.Text = "" 'txtPTN.Text = ""
                    '''            txtTransNo.Text = ""
                    '''            txtPTN.Text = ""
                    '''            btnProcess.Enabled = True
                    '''        Else
                    '''            MsgBox("Item Already Exist", , TitleMsgBox)
                    '''            txtBarcode.Text = ""
                    '''            DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                    '''            DgEntry.Focus()
                    '''        End If
                    '''    Next
                    '''End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmSelfInventory/txtBarcode_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtPTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
        Try
            'If Not e.KeyChar = ChrW(13) Then Exit Sub

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(13) Then
                e.Handled = True
                Exit Sub
            End If

            Dim SQuery As String
            Dim ptn As String = txtPTN.Text.Trim
            Dim ds As New DataSet

            If e.KeyChar = ChrW(13) Then
                If ptn = "0" Or ptn = "" Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ptn
                    txtPTN.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 2)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 3)
                    txtBarcode.Enabled = True
                    txtBarcode.Focus()
                Else
                    ''''
                    'If cboREMType.Text = "REMATADO" Then
                    'SQuery = "SELECT '',*,'' FROM vwASYS_REM_SelfInventory WHERE ptn = '" & ptn & "'"
                    'Else
                    '    SQuery = "exec ASYS_spTRADEIN_SelfInventory '" & ptn & "'"
                    'End If
                    ''''undo 
                    ''''''''SQuery = "SELECT *,'' FROM vwASYS_REM_SelfInventory_Form with(nolock) WHERE ptn = '" & ptn & "'"
                    ''SQuery = "SELECT ASITransNo,PTN,ALLBARCODE,ALL_Desc,QTY,ALL_Weight,ALL_Karat,ALL_Carat,LOANVALUE,ALL_PRICE,ZoneCode,SerialNo,Actionclass,'' FROM vwASYS_REM_SelfInventory_Form WHERE ptn = '" & ptn & "'"

                    SQuery = "SELECT *,'' FROM vwASYS_REM_SelfInventory_Form WHERE ptn = '" & ptn & "'"
                    ds = ReturnDataset(SQuery)
                    Dim rowCount As Integer
                    If Not IsNothing(ds) Then
                        rowCount = ds.Tables(0).Rows.Count
                    Else
                        rowCount = 0
                    End If

                    If rowCount < 1 Or rowCount = Nothing Then
                        MsgBox("PTN not found in Inventory.", MsgBoxStyle.Information, TitleMsgBox)
                        txtPTN.Text = ""
                        txtPTN.Focus()
                    Else
                        For i As Integer = 0 To rowCount - 1 'If rowCount = 1 Then
                            Dim ptnStr As String
                            Dim barcodeStr As String
                            Dim descStr As String
                            Dim tmpQty As Double
                            Dim tmpWeight As Double
                            Dim tmpKarat As Double
                            Dim tmpCarat As Double
                            Dim tmpLoanValue As Double
                            Dim tmpSellingPrice As Double
                            Dim tmpSerialNo As String

                            ptnStr = ds.Tables(0).Rows(i)(1).ToString
                            barcodeStr = ds.Tables(0).Rows(i)(2).ToString
                            descStr = ds.Tables(0).Rows(i)(3).ToString
                            If Not CheckGridIfExist(ptnStr, Trim(barcodeStr), descStr, tmpQty, tmpWeight, tmpKarat, tmpCarat, tmpLoanValue, tmpSellingPrice, tmpSerialNo) Then
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = "0"
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = ptnStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = barcodeStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = UCase(descStr)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ds.Tables(0).Rows(i)(4).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ds.Tables(0).Rows(i)(5).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ds.Tables(0).Rows(i)(6).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = ds.Tables(0).Rows(i)(7).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 9) = FormatNumber(ds.Tables(0).Rows(i)(8).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 10) = FormatNumber(ds.Tables(0).Rows(i)(9).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 11) = ds.Tables(0).Rows(i)(11).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 12) = "DELETE"
                                txtPTN.Text = ptnStr
                                btnAddRow_Click(sender, e)
                                txtPTN.Text = ""
                                txtTransNo.Text = ""
                                txtBarcode.Text = ""
                                btnProcess.Enabled = True
                            Else
                                MsgBox("PTN:'" & ptnStr & "' with BARCODE:'" & barcodeStr & "' DESC:'" & descStr & "'" & vbNewLine & " (Note: Already in the list) ", , TitleMsgBox)
                                txtBarcode.Text = ""
                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                                txtPTN.Focus()
                                DgEntry.Focus()
                            End If
                        Next

                        'Else
                        '    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ptn
                        '    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                        '    txtBarcode.Enabled = True
                        '    txtBarcode.Focus()
                        'End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("frmSelfInventory/txtPTN_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub txtTransNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransNo.KeyPress
        Try
            'If Not e.KeyChar = ChrW(13) Then Exit Sub

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(13) Then
                e.Handled = True
                Exit Sub
            End If

            Dim SQuery As String
            Dim ptn As String = txtTransNo.Text.Trim
            Dim ds As New DataSet

            If e.KeyChar = ChrW(13) Then
                If ptn = "0" Or ptn = "" Then
                    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ptn
                    txtTransNo.Text = DgEntry(DgEntry.CurrentCell.RowNumber, 1)
                    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                    txtPTN.Enabled = True
                    txtPTN.Focus()
                Else
                    ''If cboREMType.Text = "REMATADO" Then
                    ''    SQuery = "SELECT '',*,'' FROM vwASYS_REM_SelfInventory WHERE ptn = '" & ptn & "'"
                    ''Else
                    ''    SQuery = "exec ASYS_spTRADEIN_SelfInventory '" & ptn & "'"
                    ''End If

                    SQuery = "exec ASYS_spTRADEIN_SelfInventory '" & ptn & "'"

                    ds = ReturnDataset(SQuery)

                    Dim rowCount As Integer
                    If Not IsNothing(ds) Then
                        rowCount = ds.Tables(0).Rows.Count
                    Else
                        rowCount = 0
                    End If

                    If rowCount < 1 Or rowCount = Nothing Then
                        MsgBox("PTN not found in Inventory.", MsgBoxStyle.Information, TitleMsgBox)
                        txtTransNo.Text = ""
                        txtTransNo.Focus()
                    Else
                        'If rowCount = 1 Then
                        For i As Integer = 0 To rowCount - 1
                            Dim ptnStr As String
                            Dim barcodeStr As String
                            Dim descStr As String
                            ptnStr = CDbl(ds.Tables(0).Rows(i)(0).ToString)
                            barcodeStr = ds.Tables(0).Rows(i)(2).ToString
                            descStr = ds.Tables(0).Rows(i)(3).ToString
                            If Not CheckGridIfExistTradeIn(ptnStr) Then
                                DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ptnStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 2) = "0"
                                DgEntry(DgEntry.CurrentCell.RowNumber, 3) = barcodeStr
                                DgEntry(DgEntry.CurrentCell.RowNumber, 4) = UCase(descStr)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 5) = ds.Tables(0).Rows(i)(4).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 6) = ds.Tables(0).Rows(i)(5).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 7) = ds.Tables(0).Rows(i)(6).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 8) = ds.Tables(0).Rows(i)(7).ToString
                                DgEntry(DgEntry.CurrentCell.RowNumber, 9) = FormatNumber(ds.Tables(0).Rows(i)(8).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 10) = FormatNumber(ds.Tables(0).Rows(i)(9).ToString)
                                DgEntry(DgEntry.CurrentCell.RowNumber, 11) = "DELETE"
                                txtTransNo.Text = ptnStr
                                btnAddRow_Click(sender, e)
                                txtTransNo.Text = ""
                                txtPTN.Text = ""
                                txtBarcode.Text = ""
                                btnProcess.Enabled = True
                            Else
                                MsgBox("PTN:'" & ptnStr & "' with BARCODE:'" & barcodeStr & "' DESC:'" & descStr & "'" & vbNewLine & " (Note: Already in the list) ", , TitleMsgBox)
                                txtBarcode.Text = ""
                                DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 1)
                                txtTransNo.Focus()
                                DgEntry.Focus()
                            End If
                        Next

                        'Else
                        '    DgEntry(DgEntry.CurrentCell.RowNumber, 1) = ptn
                        '    DgEntry.CurrentCell = New DataGridCell(DgEntry.CurrentCell.RowNumber, 2)
                        '    txtBarcode.Enabled = True
                        '    txtBarcode.Focus()
                        'End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("frmSelfInventory/txtPTN_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function CheckGridIfExist(ByVal ptn As String, ByVal barcode As String, ByVal desc As String, ByVal tmpQty As Double, ByVal tmpWeight As Double, ByVal tmpKarat As Double, ByVal tmpCarat As Double, ByVal tmpLoanValue As Double, ByVal tmpSellingPrice As Double, ByVal tmpSerial As String) As Boolean
        Try
            Dim ctr As Integer = 0
            Dim rowCount As Integer = DgEntry.BindingContext(DgEntry.DataSource, DgEntry.DataMember).Count

            For i As Integer = 0 To rowCount - 1
                Dim DgPTN As String = Trim(DgEntry.Item(i, 2))
                Dim DgBarcode As String = Trim(DgEntry.Item(i, 3))
                If i <> DgEntry.CurrentRowIndex Then
                    'MsgBox(ptn & " :PTN: " & DgEntry.Item(i, 2))
                    'MsgBox(barcode & " :BARCODE: " & DgEntry.Item(i, 3))
                    If (ptn = DgPTN And barcode = DgBarcode) And Trim(desc) = Trim(DgEntry.Item(i, 4)) Then 'And desc = DgEntry.Item(i, 4) And tmpQty = DgEntry.Item(i, 5) And tmpWeight = DgEntry.Item(i, 6) And tmpKarat = DgEntry.Item(i, 7) And tmpCarat = DgEntry.Item(i, 8) And tmpLoanValue = DgEntry.Item(i, 9) And tmpSellingPrice = DgEntry.Item(i, 10) Then
                        ctr += 1
                    End If
                End If
            Next

            If ctr > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("frmSelfInventory/CheckGridIfExist: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function CheckGridIfExistTradeIn(ByVal ptn As String) As Boolean
        Try
            Dim ctr As Integer = 0
            Dim rowCount As Integer = DgEntry.BindingContext(DgEntry.DataSource, DgEntry.DataMember).Count
            For i As Integer = 0 To rowCount - 1
                If i <> DgEntry.CurrentRowIndex Then
                    If ptn = DgEntry.Item(i, 1) Then ' And barcode = DgEntry.Item(i, 3) And desc = DgEntry.Item(i, 4) Then
                        ctr += 1
                    End If
                End If
            Next

            If ctr > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("frmSelfInventory/CheckGridIfExist: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        Dim obj As New clsCommon
        Dim obj1 As New clsCommon
        Dim sQuery As String


        Try
            Dim str As String

            Dim rowCount As Integer = DgEntry.BindingContext(DgEntry.DataSource, DgEntry.DataMember).Count
            If DgEntry.Item(rowCount - 1, 3) = "" Then
                rowCount = rowCount - 1
            End If
            obj1.Connectionstring3()
            obj1.Opentracker2()
            obj1.CreateCom()

            'obj.Connectionstring3()
            'obj.Open3()

            'obj.Command3("exec ASYS_DeleteSelfInventory '" & cboCostCenter.Text.Trim & "'")
            'obj.Execute3()

            obj1.commandTrack("exec ASYS_DeleteSelfInventory '" & cboCostCenter.Text.Trim & "'")
            obj1.TrackExecute()

            For i As Integer = 0 To rowCount - 1
                sQuery = "Insert into ASYS_SelfInventory(ASITransNo,ASIptn,ASIallBarcode,ASIDate,ASIDescription, " & _
                                   "ASIQty,ASIWeight,ASIKarat,ASICarat,ASILoanValue,ASISellingPrice, " & _
                                   "ASIItemCounter,ASICostCenter,ASIResource,ASISerialNo) " & _
                                   "Values(" & GetFieldValues(i) & ")"

                obj1.commandTrack(sQuery)
                obj1.TrackExecute()
            Next i

            obj1.CommitTrack()
            MsgBox("Process Complete", , TitleMsgBox)
            cmdDelete.Enabled = False
            txtPTN.ReadOnly = True
            txtBarcode.ReadOnly = True
            btnProcess.Enabled = False
            btnPrint.Enabled = True
            btnMissing.Enabled = True
        Catch ex As Exception
            obj1.RollBackTrack()
            MsgBox("frmSelfInventory/btnProcess_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close3()
            obj1.Close4()
            obj = Nothing
            obj1 = Nothing
        End Try
    End Sub

    Private Function GetFieldValues(ByVal row As Integer) As String
        Try
            Return Enclose(CDbl(DgEntry.Item(row, 1))) & "," & _
                    Enclose(CDbl(DgEntry.Item(row, 2))) & "," & _
                    Enclose(DgEntry.Item(row, 3)) & "," & _
                    Enclose(txtDate.Text) & "," & _
                    Enclose(DgEntry.Item(row, 4)) & "," & _
                    Enclose(CDbl(DgEntry.Item(row, 5))) & "," & _
                    Enclose(DgEntry.Item(row, 6)) & "," & _
                    Enclose(DgEntry.Item(row, 7)) & "," & _
                    Enclose(DgEntry.Item(row, 8)) & "," & _
                    CStr(CDbl(DgEntry.Item(row, 9))) & "," & _
                    CStr(CDbl(DgEntry.Item(row, 10))) & "," & _
                    DgEntry.Item(row, 0) & "," & _
                    Enclose(cboCostCenter.Text.Trim) & "," & _
                    Enclose(fullname) & "," & _
                     Enclose(DgEntry.Item(row, 11))

        Catch ex As Exception
            Return ""
            MsgBox("frmSelfInventory/GetFieldValues: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Dim sqlConn As New SqlConnection

    Private Function ReturnDataset(ByVal sql As String) As DataSet
        Try
            Dim sqlAdapter As SqlDataAdapter
            Dim sqlDataset As New DataSet

            ReturnDataset = Nothing

            Me.Open3(Connectionstring3())
            sqlAdapter = New SqlDataAdapter(sql, sqlConn)
            sqlAdapter.SelectCommand.CommandTimeout = 600
            sqlAdapter.Fill(sqlDataset)
            If Not sqlDataset Is Nothing Then
                If sqlDataset.Tables(0).Rows.Count <> 0 Then
                    ReturnDataset = sqlDataset
                    sqlDataset.Dispose()
                    sqlAdapter.Dispose()
                End If
            End If
            sqlAdapter.Dispose()
            '' sqlConn.Close() ''''12-26-2012 close 

        Catch ex As Exception
            Throw ex
            MsgBox("frmSelfInventory/ReturnDataset: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function Connectionstring3() As String
        Try
            Dim sPath As String
            Dim frmMain1 As New frmMain
            Dim cls As New clsCommon
            sPath = frmMain1.sPath

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
                    sPassword1 = cls.decryptPass(Replace(line, Key_Pass1, ""))
                End If
                If line.StartsWith(Key_Photo) Then
                    photodes = Replace(line, Key_Photo, "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()

            Connectionstring3 = "Data Source = " + sDatasource1 + ";"
            Connectionstring3 = Connectionstring3 + ";Initial Catalog = " + sDatabase1
            Connectionstring3 = Connectionstring3 + ";User ID = " + sUsername1
            Connectionstring3 = Connectionstring3 + ";Password = " + sPassword1
            ConStrs = Connectionstring3

        Catch Ex As Exception
            MsgBox("frmSelfInventory/Connectionstring3: " & Ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub Open3(ByVal conStr As String)
        Try
            sqlConn.ConnectionString = conStr
            sqlConn.Open()
        Catch ex As Exception
        End Try
    End Sub

    Public Function Enclose(ByVal str As String) As String
        Try
            Enclose = "'" & Replace(str, "'", "''") & "'"
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Dim frm As New frmSelfInventoryReport
            frm.REMTYPE = "SELFINVENTORY"
            frm.COSTCENTER = cboCostCenter.Text
            frm.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("frmSelfInventory/btnPrint_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnMissing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMissing.Click
        Try
            Dim frm As New frmSelfInventoryReport
            If cboCostCenter.Text = "REM" Then
                frm.REMTYPE = cboREMType.Text
            End If
            frm.COSTCENTER = cboCostCenter.Text.Trim.ToUpper
            frm.REMTYPE = "MISSINGITEM"
            frm.ShowDialog(Me)
        Catch ex As Exception
            MsgBox("frmSelfInventory/btnMissing_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim rply As Integer

            If btnProcess.Enabled = False Then
                Exit Sub
            End If

            If dataTable.Rows.Count > 0 Then
                rply = MsgBox("Are you sure you want to remove this item?", MsgBoxStyle.YesNo, TitleMsgBox)
                If rply = vbYes Then
                    dataTable.Rows.RemoveAt(DgEntry.CurrentRowIndex)
                    dgAutonumber()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub dgAutonumber()
        Try
            Dim totalRow As Integer = dataTable.Rows.Count - 1
            Dim row As Integer
            For row = 0 To totalRow
                DgEntry.Item(row, 0) = row + 1
            Next
            If totalRow < 0 Then
                btnProcess.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboCostCenter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCostCenter.SelectedIndexChanged
        Try
            dataTable.Clear()
            btnProcess.Enabled = False

            If cboCostCenter.Text = "REM" Then
                cboREMType.Enabled = True
            Else
                cboREMType.Enabled = False
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class
