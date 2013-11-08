Option Explicit On 
Imports System.Data.SqlClient
Imports System.IO


Public Class frmPhotoMover
    Inherits System.Windows.Forms.Form
    Private folderCaptureImage As String = "C:\AsysCaptureImageFile1\"
    Private folderSaveImage As String = "C:\AsysSaveImageFile1\"
    Private folderUploadXML As String = "C:\UploadXML\"

    Private openFileDialog1 As OpenFileDialog = New OpenFileDialog
    Private strfileToSave As String = photodes
    Private strfileOnRecord As String
    Private fileNameInC As String
    Dim obj As clsCommon
    Dim img As Image


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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnEditPic As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPTN As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPhotoMover))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Save = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnEditPic = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPTN = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-95, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Location2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-103, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "File Name :"
        '
        'Save
        '
        Me.Save.Enabled = False
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Save.Location = New System.Drawing.Point(312, 184)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(80, 40)
        Me.Save.TabIndex = 3
        Me.Save.Text = "SAVE"
        Me.Save.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "A.L.L. BARCODE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(256, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 108
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 216)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(272, 200)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(312, 232)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 40)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(312, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 40)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "CLOSE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnEditPic
        '
        Me.btnEditPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditPic.Enabled = False
        Me.btnEditPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPic.Location = New System.Drawing.Point(290, 112)
        Me.btnEditPic.Name = "btnEditPic"
        Me.btnEditPic.Size = New System.Drawing.Size(64, 44)
        Me.btnEditPic.TabIndex = 110
        Me.btnEditPic.Text = "EDIT PICTURE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "tago me"
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(112, 112)
        Me.TextBox1.MaxLength = 17
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'OpenFileDialog2
        '
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(112, 112)
        Me.TextBox2.MaxLength = 17
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 111
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "PTN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPTN
        '
        Me.txtPTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPTN.Location = New System.Drawing.Point(112, 136)
        Me.txtPTN.MaxLength = 12
        Me.txtPTN.Name = "txtPTN"
        Me.txtPTN.Size = New System.Drawing.Size(176, 20)
        Me.txtPTN.TabIndex = 2
        Me.txtPTN.Text = ""
        '
        'frmPhotoMover
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(410, 392)
        Me.Controls.Add(Me.txtPTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEditPic)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(416, 424)
        Me.MinimumSize = New System.Drawing.Size(416, 424)
        Me.Name = "frmPhotoMover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM PHOTO"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmPhotoMover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim comm As String

            'MakeFolder()

            If pt = True Then
                btnEditPic.Enabled = False
                TextBox2.Focus()
            Else
                btnEditPic.Visible = False
                TextBox1.Focus()
            End If

            PictureBox1.Image = Nothing
            PictureBox3.Image = Nothing
            btnClear.Enabled = False
        Catch ex As Exception
            MsgBox("frmPhotoMover/frmPhotoMover_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            Exit Sub
        End Try
    End Sub

    Private Sub MakeFolder()
        Try
            Dim obj As New clsCommon

            obj.Connectionstring3()

            If Not Directory.Exists(LImageSource) Then
                IO.Directory.CreateDirectory(LImageSource)
            End If
            If Not Directory.Exists(LImageDestination) Then
                IO.Directory.CreateDirectory(LImageDestination)
            End If
            If Not Directory.Exists(XMLSource) Then
                IO.Directory.CreateDirectory(XMLSource)
            End If
            If Not Directory.Exists(ARJDestination) Then
                IO.Directory.CreateDirectory(ARJDestination)
            End If
        Catch ex As Exception
            MsgBox("frmPhotoMover/MakeFolder: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            Throw ex
        End Try
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            Dim str As String
            Dim img As Drawing.Image
            Dim strPath As String
            Dim strWhere As String

            If TextBox1.Text = "" And txtPTN.Text = "" Then
                MsgBox("Please Input file allbarcode/PTN.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Opentracker2()
            obj.CreateCom()

            If txtPTN.Enabled Then
                strWhere = "EXEC ASYS_UpdatePhotoField '" & JewelrySDestination & txtPTN.Text & ".JPG" & "','0','1','" & txtPTN.Text & "','" & UCase(sDB) & "'"
            Else
                strWhere = "EXEC ASYS_UpdatePhotoField '" & GoodstockSDestination & TextBox1.Text & ".JPG" & "','" & TextBox1.Text & "','0','0','0'"
            End If

            obj.commandTrack(strWhere)
            obj.TrackExecute()
            GC.Collect()
            PictureBox1.Image.Dispose()
            If txtPTN.Enabled Then
                File.Move(LImageSource & txtPTN.Text & ".JPG", LImageDestination & "\" & txtPTN.Text & ".JPG")
            Else
                File.Move(LImageSource & TextBox1.Text & ".JPG", LImageDestination & "\" & TextBox1.Text & ".JPG")
            End If
            obj.CommitTrack()
            '02122010
            ' PictureBox1.Image.Dispose()
            MsgBox("Image successfully saved!", MsgBoxStyle.Information, TitleMsgBox)
            Me.Save.Enabled = False
            PictureBox1.Image = Nothing
            If txtPTN.Enabled Then
                txtPTN.Text = ""
                txtPTN.Focus()
            Else
                TextBox1.Text = ""
                TextBox1.Focus()
            End If

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("frmPhotoMover/Save_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close()
        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            Save.Enabled = False
            TextBox1.Text = ""
            TextBox2.Text = ""
            txtPTN.Text = ""
            TextBox1.Enabled = True
            txtPTN.Enabled = True
            If btnEditPic.Visible = True Then
                TextBox2.Focus()
            Else
                TextBox1.Focus()
            End If
            strfileToSave = Nothing
            strfileOnRecord = Nothing
            btnClear.Enabled = False
            Me.PictureBox1.Image = Nothing
            PictureBox1.BringToFront()
        Catch ex As Exception
            MsgBox("frmPhotoMover/btnClear_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Function countitemsand()
        Try
            Dim fileNameInC As String
            Dim xff As Integer = System.IO.Directory.GetFiles(folderCaptureImage).Length
            Dim xname() As String = System.IO.Directory.GetFiles(folderCaptureImage)
            Dim y As Integer

            For y = 0 To xff - 1
                Dim currentfile As String = xname(y)
                fileNameInC = currentfile
            Next
        Catch ex As Exception
            MsgBox("frmPhotoMover/countitemsand: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Function IfFolderNotEmpty(ByVal filePath As String) As Boolean
        Try
            'Dim diContents As New DirectoryInfo(LImageSource)
            'Dim dirContents As FileInfo() = diContents.GetFiles("*.jpg")
            'Dim tmpFile As FileInfo
            'Dim ii, n, nCopy As Integer
            'Dim sCommand, F1, F2 As String
            'n = dirContents.GetUpperBound(0)

            'For ii = 0 To n

            '    F1 = dirContents.GetValue(ii).fullname
            '    F2 = filePath + "copy" + nCopy.ToString + dirContents.GetValue(ii).name

            '    nCopy = 0
            '    Do
            '        tmpFile = New FileInfo(photodes)
            '        If Not tmpFile.Exists() Then
            '            Exit Do
            '        End If
            '    Loop
            'Next

            'If n >= 0 Then
            '    Return True
            'Else
            '    Return False
            'End If
            IfFolderNotEmpty = False
            If Not File.Exists(filePath) Then
                MsgBox("A.L.L Barcode image doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
            Else
                IfFolderNotEmpty = True
            End If
        Catch ex As Exception
            MsgBox("frmPhotoMover/IfFolderNotEmpty: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            Return False
        End Try
    End Function

    Private Sub txtPTN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
        Dim exMsg As Integer
        Try
            Dim obj As New clsCommon
            Dim str As String
            Dim dr As SqlDataReader
            Dim img As Drawing.Image

            ' Dim fileNameInC As String = ""

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If Not e.KeyChar = ChrW(13) Then Exit Sub

            If txtPTN.Text.Trim.Length < 12 Then
                MsgBox("Pls. enter a 12-digit PTN.", MsgBoxStyle.Information, TitleMsgBox)
                PictureBox1.Image = Nothing
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Sub
            End If

            obj.Connectionstring3()
            obj.Open3()

            If Not System.IO.Directory.Exists(photodes) Then
                System.IO.Directory.CreateDirectory(photodes)
            End If

            If Not System.IO.Directory.Exists(photodes & "FakeAndCoated\") Then
                System.IO.Directory.CreateDirectory(photodes & "FakeAndCoated\")
            End If

            str = "Select refallbarcode,ptn,photoname  as photo from ASYS_REM_Detail " & _
                  "where ptn = '" & Me.txtPTN.Text & "' AND Actionclass in ('fake','coated')"

            obj.Command3(str)
            dr = obj.OpenDataReader3

            If dr.Read = False Then
                ''MsgBox("PTN is not sorted as fake or coated.", MsgBoxStyle.Information, TitleMsgBox)
                MsgBox("PTN doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                Save.Enabled = False
                txtPTN.Text = ""
                txtPTN.Focus()
                Exit Sub
            End If

            Dim strPhotoFolder As String
            Dim strPhotoFileName As String
            Dim strPhotoWholeFileName As String = ""

            strPhotoFileName = txtPTN.Text.Trim & ".jpg"


            If obj.IsNull(dr.Item("Photo")) <> "0" Then
                strPhotoWholeFileName = dr.Item("photo")
                strPhotoFolder = strPhotoWholeFileName.Replace(strPhotoFileName, "")

                If Not System.IO.File.Exists(strPhotoWholeFileName) Then
                    MsgBox("Itemcode has an attached photo already!" & vbNewLine & "Unable to display image, file Path not found!", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                Else
                    txtPTN.Text = dr.Item("ptn")
                    txtPTN.Enabled = True
                    GoTo DisplayImage
                End If


DisplayImage:
                If Me.Text = "EDIT PICTURE" Then
                    btnEditPic.Enabled = True
                Else
                    btnEditPic.Enabled = False
                    btnEditPic.Visible = False
                End If


                MsgBox("Itemcode has an attached photo already!", MsgBoxStyle.Information, TitleMsgBox)
                img = Image.FromFile(dr.Item("photo"))
                strfileOnRecord = dr.Item("photo")
                PictureBox1.Show()
                PictureBox1.Image = img
                Save.Enabled = False
                txtPTN.Focus()
                Exit Sub
            Else

                If IfFolderNotEmpty(LImageSource & "\" & strPhotoFileName) Then
                    fileNameInC = LImageSource & strPhotoFileName
                    PictureBox1.Show()
                    PictureBox1.Image = img.FromFile(fileNameInC)
                    Save.Enabled = True
                    Save.Focus()
                End If


                'Dim xname() As String = System.IO.Directory.GetFiles(LImageSource)
                'If IfFolderNotEmpty(photodes & "FakeAndCoated\" & strPhotoFileName) Then
                '    Dim xff As Integer = System.IO.Directory.GetFiles(folderCaptureImage).Length
                '    If xff = 0 Then
                '        MsgBox("No pictures found to be saved!", MsgBoxStyle.Information, TitleMsgBox)
                '        TextBox1.Focus()
                '    Else
                '        Dim currentfile As String = xname(0)
                '        fileNameInC = currentfile
                '        img = img.FromFile(fileNameInC)
                '        PictureBox1.Show()
                '        PictureBox1.Image = img
                '        strfileOnRecord = fileNameInC
                '        Save.Enabled = True
                '        Save.Focus()
                '    End If
                'Else
                '    MsgBox("No pictures found to be saved!", MsgBoxStyle.Information, TitleMsgBox)
                'End If
            End If
            dr.Close()
            obj.Close3()

        Catch ex As Exception
            If exMsg = ex.Message.IndexOf("Out of memory") Then
                MsgBox("The image was corrupt.")
                Exit Sub
            Else
                MsgBox("frmPhotoMover/txtPTN_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            End If

        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim exmsg As Integer
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim img As Drawing.Image
            Dim str As String
            Dim GetImageFile As String
            Dim strFileToSave As String

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If Not e.KeyChar = ChrW(Keys.Enter) Then Exit Sub

            If TextBox1.TextLength < 17 Then
                MsgBox("Pls. enter a 17-digit ALL barcode.", MsgBoxStyle.Information, TitleMsgBox)
                PictureBox1.Image = Nothing
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Try
            End If

            obj = New clsCommon
            obj.Connectionstring3()
            obj.Open3()

            If Not System.IO.Directory.Exists(photodes) Then
                System.IO.Directory.CreateDirectory(photodes)
                MsgBox("Itemcode has an attached photo already!" & vbNewLine & "Unable to display image, file Path not found!", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
                'Else
                'MsgBox("Itemcode has an attached photo already!" & vbNewLine & "Unable to display image, file Path not found!", MsgBoxStyle.Information, TitleMsgBox)
            End If

            str = "EXEC ASYS_GetBarcodePhoto '" & TextBox1.Text & "','0'"
            obj.Command3(str)
            dr = obj.OpenDataReader3
            If dr.Read = False Then
                MsgBox("ALLbarcode does not exist!", MsgBoxStyle.Information, TitleMsgBox)
                Save.Enabled = False
                TextBox1.Text = ""
                TextBox1.Focus()
                Exit Sub
            End If

            Dim strPhotoFolder As String
            Dim strPhotoFileName As String
            Dim strPhotoWholeFileName As String = ""

            strPhotoFileName = TextBox1.Text.Trim & ".jpg"


            If obj.IsNull(dr.Item("Photo")) <> "0" Then
                strPhotoWholeFileName = dr.Item("photo")
                strPhotoFolder = strPhotoWholeFileName.Replace(strPhotoFileName, "")
                If Not System.IO.File.Exists(strPhotoWholeFileName) Then
                    MsgBox("Itemcode has an attached photo already!" & vbNewLine & "Unable to display image, file Path not found!", MsgBoxStyle.Information, TitleMsgBox)
                    Exit Sub
                Else
                    MsgBox("Itemcode has an attached photo already!", MsgBoxStyle.Information, TitleMsgBox)
                    img = Image.FromFile(dr.Item("photo"))
                    strfileOnRecord = dr.Item("photo")
                    PictureBox1.Show()
                    PictureBox1.Image = img
                    PictPath = img
                    Save.Enabled = False
                    TextBox1.Focus()
                End If
                Exit Sub
            Else
                If IfFolderNotEmpty(LImageSource & "\" & strPhotoFileName) Then
                    fileNameInC = LImageSource & strPhotoFileName
                    PictureBox1.Show()
                    PictureBox1.Image = img.FromFile(fileNameInC)
                    Save.Enabled = True
                    Save.Focus()
                End If
            End If
            dr.Close()
            obj.Close3()
        Catch ex As Exception
            exmsg = ex.Message.IndexOf("Out of memory")
            If exmsg >= 0 Then
                MsgBox("The image was corrupt.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            Else
                MsgBox("frmPhotoMover/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            End If
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            strfileToSave = Nothing
            Me.PictureBox1.Image = Nothing
            Me.PictureBox3.Image = Nothing
            'PictureBox1.Dispose()
            'PictureBox3.Dispose()
            img.Dispose()
            PictPath.Dispose()
            Me.Close()
        Catch ex As Exception
            ' MsgBox("frmPhotoMover/Button3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
            Me.Close()
        End Try
    End Sub

    Private Sub btnEditPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPic.Click
        Try
            Dim myStream As Stream
            Dim openfiledialog2 As OpenFileDialog = New OpenFileDialog
            Dim obj As New clsCommon
            Dim str As String
            Dim img As Drawing.Image
            Dim strFileToSave As String
            Dim foldera As String = "C:\AsysCaptureImageFile1\"
            Dim FlagChanged As Boolean

            obj.Connectionstring3()

            openfiledialog2.InitialDirectory = LImageSource
            openfiledialog2.Filter = "jpeg files (*.jpeg)|*.jpg" '|All files (*.*)|*.*"
            openfiledialog2.FilterIndex = 2
            openfiledialog2.RestoreDirectory = True
            FlagChanged = False

            If openfiledialog2.ShowDialog() = DialogResult.OK Then
                myStream = openfiledialog2.OpenFile()
                If Not (myStream Is Nothing) Then
                    FlagChanged = True
                    If txtPTN.Enabled = True Then
                        strFileToSave = JewelrySDestination & txtPTN.Text & ".jpg"
                    Else
                        strFileToSave = photodes & TextBox2.Text & ".jpg"
                    End If
                    If txtPTN.Enabled = True Then
                        PictureBox1.Image.Dispose() '' gm 08-06-2013
                        PictureBox1.Image = Nothing
                        GC.Collect()
                        File.Copy(openfiledialog2.FileName, strFileToSave, True)
                        img = img.FromFile(JewelrySDestination & txtPTN.Text & ".jpg")
                        strFileToSave = openfiledialog2.FileName
                        PictureBox1.Image = img
                        PictureBox1.Show()
                    Else
                        PictureBox3.Image.Dispose() '' gm 08-06-2013
                        PictureBox3.Image = Nothing
                        GC.Collect()
                        File.Copy(openfiledialog2.FileName, strFileToSave, True)
                        img = img.FromFile(photodes & TextBox2.Text & ".jpg")
                        strFileToSave = openfiledialog2.FileName
                        PictureBox3.Image = img
                        PictureBox3.Show()
                    End If
                    openfiledialog2.Dispose()
                    myStream.Close()
                    myStream = Nothing
                    GC.Collect()
                    File.Delete(openfiledialog2.FileName)
                    strFileToSave = photodes & TextBox2.Text & ".jpg"
                    strfileOnRecord = strFileToSave
                End If
            End If

            openfiledialog2.Reset()
            btnClear.Enabled = True

            If FlagChanged = True Then
                MsgBox("Photo has been successfully updated.", MsgBoxStyle.Information, TitleMsgBox)
            End If

        Catch ex As Exception
            MsgBox("frmPhotoMover/btnEditPic_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try

    End Sub

    'Private Sub txtPTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        strfileOnRecord = Nothing
    '        PictureBox1.Image = Nothing
    '        TextBox1.Text = ""
    '        If txtPTN.Text <> "" Then
    '            TextBox1.Enabled = False
    '            btnClear.Enabled = True
    '        Else
    '            TextBox1.Enabled = True
    '            btnClear.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox("frmPhotoMover/txtPTN_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '    End Try
    'End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            txtPTN.Enabled = False
            btnClear.Enabled = True
        Else
            txtPTN.Enabled = True
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'gm changed combobox PTN to textbox PTN 12012011...
        Try
            strfileOnRecord = Nothing
            PictureBox1.Image = Nothing
            If TextBox1.Text <> "" Then
                txtPTN.Enabled = False
                btnClear.Enabled = True
            Else
                txtPTN.Enabled = True
                btnClear.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmPhotoMover/TextBox1_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub picturebox11_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try
            Dim frm As New frmPhotoZoom
            frm.photoname(strfileOnRecord)

            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmPhotoMover/picturebox11_click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Try
            Dim path As Image
            path = New Bitmap(openFileDialog1.FileName)
            PictureBox1.Image = path
        Catch ex As Exception
            MsgBox("frmPhotoMover/OpenFileDialog1_FileOk: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub c(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String
            Dim img As Drawing.Image

            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
                e.Handled = True
            End If

            If TextBox2.Text <> "" Then
                btnClear.Enabled = True
            Else
                btnClear.Enabled = False
            End If

            If e.KeyChar = ChrW(13) Then
                If TextBox2.TextLength = 17 Then
                    obj.Connectionstring3()
                    obj.Open3()
                    str = "exec ASYS_GetBarcodePhoto '" & TextBox2.Text & "','1'"
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = False Then
                        MsgBox("Wrong barcode or barcode doesn't have an attached photo.", MsgBoxStyle.Information, TitleMsgBox)
                        btnEditPic.Enabled = False
                        TextBox2.Text = ""
                        TextBox2.Focus()
                    Else
                        img = Image.FromFile(dr.Item("photo"))
                        strfileToSave = dr.Item("photo")
                        PictureBox3.Show()
                        PictureBox3.BringToFront()
                        PictureBox3.Image = img
                        btnEditPic.Enabled = True
                    End If
                    dr.Close()
                    obj.Close3()
                Else
                    PictureBox1.Image = Nothing
                    btnEditPic.Enabled = False
                    Save.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("frmPhotoMover/OpenFileDialog1_FileOk: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub OpenFileDialog2_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        Try
            Dim myStream As Stream
            Dim obj As New clsCommon
            Dim str As String
            Dim img As Drawing.Image
            Dim strFileToSave As String
            Dim foldera As String = "C:\AsysCaptureImageFile1\"

            Me.TextBox1.Visible = False
            Me.TextBox2.Visible = True

            PictureBox1.Image.Dispose()
            OpenFileDialog2.InitialDirectory = "C:\AsysCaptureImageFile1\"
            OpenFileDialog2.Filter = "jpeg files (*.jpeg)|*.jpg" '|All files (*.*)|*.*"
            OpenFileDialog2.FilterIndex = 2
            OpenFileDialog2.RestoreDirectory = True

            If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
                myStream = OpenFileDialog2.OpenFile()
                If Not (myStream Is Nothing) Then
                    strFileToSave = photodes & TextBox2.Text & ".jpg"
                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Opentracker2()
                    obj.CreateCom()

                    str = "If (Select Count(refallbarcode) from ASYS_REM_Detail where refallbarcode='" & Me.TextBox2.Text & "' )<> 0 begin Update ASYS_REM_Detail set photoname='" & strFileToSave & "' where refallbarcode='" & Me.TextBox2.Text & "' end else Update ASYS_REMOUtsource_Detail set photoname='" & strFileToSave & "' where refallbarcode='" & Me.TextBox2.Text & "'"
                    obj.commandTrack(str)
                    obj.TrackExecute()
                    obj.CommitTrack()

                    File.Copy(OpenFileDialog2.FileName, strFileToSave, True)
                    img = img.FromFile(photodes & TextBox2.Text & ".jpg")
                    strFileToSave = OpenFileDialog2.FileName
                    PictureBox1.Image = Nothing
                    PictureBox1.Image = img
                    PictureBox1.Show()
                    openFileDialog1.Dispose()
                    myStream.Close()
                    myStream = Nothing
                    'img.Dispose()
                    File.Delete(OpenFileDialog2.FileName)
                    strFileToSave = photodes & TextBox2.Text & ".jpg"

                    MsgBox("Photo has been successfully updated.", MsgBoxStyle.Information, TitleMsgBox)

                End If
            End If

            openFileDialog1.Reset()
            btnClear.Enabled = True

        Catch ex As Exception
            obj.RollBackTrack()
            MsgBox("frmPhotoMover/OpenFileDialog2_FileOk: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        Finally
            obj.Close()
        End Try

    End Sub

    Private Function box()
        Try
            Dim picturebox1 As New PictureBox
            'picturebox1.Image = Image.FromFile(strFileToSave)
            picturebox1.Visible = True
            picturebox1.Top = 20
            picturebox1.Width = 100
            picturebox1.Height = 50
            picturebox1.Left = 10
            Controls.Add(picturebox1)
        Catch ex As Exception
            MsgBox("frmPhotoMover/box: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Function

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            Dim frm As New frmPhotoZoom
            frm.photoname(strfileToSave)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmPhotoMover/PictureBox3_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub frmPhotoMover_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub frmPhotoMover_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim frmProgress As New frmImageProgress
        frmProgress.ShowDialog()

    End Sub

    Private Sub Save_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Save.DragEnter

    End Sub

    'Private Sub cmbPTN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPTN.SelectedIndexChanged
    '    Try
    '        strfileOnRecord = Nothing
    '        PictureBox1.Image = Nothing
    '        TextBox1.Text = ""
    '        If cmbPTN.Text <> "" Then
    '            TextBox1.Enabled = False
    '            btnClear.Enabled = True
    '        Else
    '            TextBox1.Enabled = True
    '            btnClear.Enabled = False
    '        End If
    '    Catch ex As Exception
    '        MsgBox("frmPhotoMover/txtPTN_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '    End Try
    'End Sub

    'Private Sub txtPTN_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTN.TextChanged
    '    Try
    '        strfileOnRecord = Nothing
    '        PictureBox1.Image = Nothing
    '        TextBox1.Text = ""
    '        If txtPTN.Text <> "" Then
    '            TextBox1.Enabled = False
    '            btnClear.Enabled = True
    '        Else
    '            TextBox1.Enabled = True
    '            btnClear.Enabled = False
    '        End If

    '    Catch ex As Exception
    '        MsgBox("frmPhotoMover/txtPTN_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '    End Try
    'End Sub 
    Private Sub txtPTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPTN.TextChanged
        Try
            strfileOnRecord = Nothing
            PictureBox1.Image = Nothing
            TextBox1.Text = ""
            If txtPTN.Text <> "" Then
                TextBox1.Enabled = False
                btnClear.Enabled = True
            Else
                TextBox1.Enabled = True
                btnClear.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("frmPhotoMover/txtPTN_TextChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub txtPTN_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
    '    Try
    '        If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
    '            e.Handled = True
    '        End If

    '        If Not e.KeyChar = ChrW(Keys.Enter) Then Exit Sub


    '    Catch ex As Exception
    '        MsgBox("frmPhotoMover/txtPTN_KeyPress1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '    End Try
    'End Sub
    '    Private Sub txtPTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPTN.KeyPress
    '        Dim exMsg As Integer
    '        Try
    '            Dim obj As New clsCommon
    '            Dim str As String
    '            Dim dr As SqlDataReader
    '            Dim img As Drawing.Image

    '            ' Dim fileNameInC As String = ""

    '            If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Enter) Then
    '                e.Handled = True
    '            End If

    '            If Not e.KeyChar = ChrW(13) Then Exit Sub

    '            If txtPTN.Text.Trim.Length < 12 Then
    '                MsgBox("Pls. enter a 12-digit PTN.", MsgBoxStyle.Information, TitleMsgBox)
    '                PictureBox1.Image = Nothing
    '                TextBox1.Text = ""
    '                TextBox1.Focus()
    '                Exit Sub
    '            End If

    '            obj.Connectionstring3()
    '            obj.Open3()

    '            If Not System.IO.Directory.Exists(photodes) Then
    '                System.IO.Directory.CreateDirectory(photodes)
    '            End If

    '            If Not System.IO.Directory.Exists(photodes & "FakeAndCoated\") Then
    '                System.IO.Directory.CreateDirectory(photodes & "FakeAndCoated\")
    '            End If

    '            str = "Select refallbarcode,ptn,photoname  as photo from ASYS_REM_Detail " & _
    '                  "where ptn = '" & Me.txtPTN.Text & "' AND Actionclass in ('fake','coated')"

    '            obj.Command3(str)
    '            dr = obj.OpenDataReader3

    '            If dr.Read = False Then
    '                MsgBox("PTN is not sorted as fake or coated.", MsgBoxStyle.Information, TitleMsgBox)
    '                Save.Enabled = False
    '                txtPTN.Text = ""
    '                txtPTN.Focus()
    '                Exit Sub
    '            End If

    '            Dim strPhotoFolder As String
    '            Dim strPhotoFileName As String
    '            Dim strPhotoWholeFileName As String = ""

    '            strPhotoFileName = txtPTN.Text.Trim & ".jpg"


    '            If obj.IsNull(dr.Item("Photo")) <> "0" Then
    '                strPhotoWholeFileName = dr.Item("photo")
    '                strPhotoFolder = strPhotoWholeFileName.Replace(strPhotoFileName, "")

    '                If Not System.IO.File.Exists(strPhotoWholeFileName) Then
    '                    MsgBox("Itemcode has an attached photo already!" & vbNewLine & "Unable to display image, file Path not found!", MsgBoxStyle.Information, TitleMsgBox)
    '                    Exit Sub
    '                Else
    '                    txtPTN.Text = dr.Item("ptn")
    '                    txtPTN.Enabled = True
    '                    GoTo DisplayImage
    '                End If

    'DisplayImage:
    '                MsgBox("Itemcode has an attached photo already!", MsgBoxStyle.Information, TitleMsgBox)
    '                img = Image.FromFile(dr.Item("photo"))
    '                strfileOnRecord = dr.Item("photo")
    '                PictureBox1.Show()
    '                PictureBox1.Image = img
    '                Save.Enabled = False
    '                txtPTN.Focus()
    '                Exit Sub
    '            Else

    '                If IfFolderNotEmpty(LImageSource & "\" & strPhotoFileName) Then
    '                    fileNameInC = LImageSource & strPhotoFileName
    '                    PictureBox1.Show()
    '                    PictureBox1.Image = img.FromFile(fileNameInC)
    '                    Save.Enabled = True
    '                    Save.Focus()
    '                End If


    '                'Dim xname() As String = System.IO.Directory.GetFiles(LImageSource)
    '                'If IfFolderNotEmpty(photodes & "FakeAndCoated\" & strPhotoFileName) Then
    '                '    Dim xff As Integer = System.IO.Directory.GetFiles(folderCaptureImage).Length
    '                '    If xff = 0 Then
    '                '        MsgBox("No pictures found to be saved!", MsgBoxStyle.Information, TitleMsgBox)
    '                '        TextBox1.Focus()
    '                '    Else
    '                '        Dim currentfile As String = xname(0)
    '                '        fileNameInC = currentfile
    '                '        img = img.FromFile(fileNameInC)
    '                '        PictureBox1.Show()
    '                '        PictureBox1.Image = img
    '                '        strfileOnRecord = fileNameInC
    '                '        Save.Enabled = True
    '                '        Save.Focus()
    '                '    End If
    '                'Else
    '                '    MsgBox("No pictures found to be saved!", MsgBoxStyle.Information, TitleMsgBox)
    '                'End If
    '            End If
    '            dr.Close()
    '            obj.Close3()

    '        Catch ex As Exception
    '            If exMsg = ex.Message.IndexOf("Out of memory") Then
    '                MsgBox("The image was corrupt.")
    '                Exit Sub
    '            Else
    '                MsgBox("frmPhotoMover/txtPTN_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
    '            End If
    '        End Try
    '    End Sub
End Class
