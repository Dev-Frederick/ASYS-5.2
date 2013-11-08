Imports System.IO

Public Class frmImageProgress
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pgBar As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pgBar = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'pgBar
        '
        Me.pgBar.Location = New System.Drawing.Point(0, 0)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(432, 24)
        Me.pgBar.TabIndex = 0
        Me.pgBar.Value = 1
        '
        'frmImageProgress
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(434, 24)
        Me.Controls.Add(Me.pgBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImageProgress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sending Images : "
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmImageProgress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objconn As New clsCommon
        objconn.Connectionstring3()

        If IfImageExist(LImageDestination) Then
            Timer1.Start()
        Else
            Me.Close()
        End If
        'TransferImages(GoodstockSDestination, LImageDestination)
    End Sub

    Private Function TransferImages(ByVal imageSource As String) As Boolean
        Try

            Dim webclient As New System.Net.WebClient
            Dim verify As System.Net.ICredentials
            Dim ARFilename As String
            Dim getImages As New DirectoryInfo(imageSource)
            Dim getImageOnly As FileInfo() = getImages.GetFiles("*.JPG")
            Dim noOfFiles As Integer
            Dim i As Integer
            Dim sCommand As String = ""
            Dim RARFilename As String = Format(Now, "MM-dd-yy-ss:mm")
            Dim ImageFilename As String
            Dim clsImagePath As New clsCommon
            Dim ImageDestination As String

            clsImagePath.Connectionstring3()

            TransferImages = False
            verify = New System.Net.NetworkCredential(SUsername, SPassword)
            webclient.Credentials = verify

            '' a = Application.StartupPath & "\ARJ.exe a " & imageSource & ".ARJ" & " " & imageSource
            '' Shell(Application.StartupPath & "\ARJ.exe a " & imageSource & "*.ARJ" & " " & imageSource, AppWinStyle.NormalFocus, 10)

            '----Romar's zip
            'ARFilename = ZipFiles(LImageDestination, ARJDestination, "")
            'RARFilename = ARFilename
            'webclient.UploadFile(ImageDestination & "\" & ARFilename, "PUT", ARJDestination & ARFilename)
            'sCommand = Application.StartupPath & "\ARJ.exe e -y " & photodes & RARFilename + " " + photodes
            'Shell(sCommand, AppWinStyle.NormalFocus, True)
            'TransferImages = True

            '---Sir Mac's zip
            'a = Application.StartupPath & "\ARJ.exe a " & imageSource & "*.ARJ" & " " & imageSource

            ''''''''''Shell(Application.StartupPath & "\ARJ.exe a " & ARJDestination & RARFilename & ".ARJ" & " " & imageSource, AppWinStyle.NormalFocus, 10)
            ''''''''''webclient.UploadFile(ImageDestination & "" & RARFilename & ".ARJ", "PUT", ARJDestination & RARFilename & ".ARJ")
            '''''''''''---Sir Mac's unzip
            ''''''''''sCommand = Application.StartupPath & "\ARJ.exe e -y " & photodes & RARFilename + " " + photodes
            ''''''''''Shell(sCommand, AppWinStyle.NormalFocus, True)
            ''''''''''DeleteZippedFiles(LImageDestination, RARFilename & ".ARJ")
            ''''''''''TransferImages = True

            noOfFiles = getImageOnly.GetUpperBound(0)
            'a = Application.StartupPath & "\ARJ.exe a " & imageSource & ".ARJ" & " " & imageSource
            'Shell(Application.StartupPath & "\ARJ.exe a " & imageSource & "*.ARJ" & " " & imageSource, AppWinStyle.NormalFocus, 10)
            For i = 0 To noOfFiles
                pgBar.Value = 50
                Me.Text = i + 1 & " of " & noOfFiles + 1 & " Sending Image : " & Replace(getImageOnly.GetValue(i).name, ".JPG", "")
                ImageFilename = getImageOnly.GetValue(i).name

                If ImageFilename.Length = 16 Then
                    ImageDestination = JewelrySDestination
                    'webclient.UploadFile(ImageDestination & "\" & getImageOnly.GetValue(i).name, "PUT", getImageOnly.GetValue(i).fullname)
                    'File.Move(getImageOnly.GetValue(i).fullname, ImageDestination)
                Else
                    ImageDestination = GoodstockSDestination
                    'webclient.UploadFile(ImageDestination & "\" & getImageOnly.GetValue(i).name, "PUT", getImageOnly.GetValue(i).fullname)
                End If
                File.Move(getImageOnly.GetValue(i).fullname, ImageDestination & getImageOnly.GetValue(i).name)
                'GC.Collect()
                'File.Delete(imageSource & "\" & getImageOnly.GetValue(i).name)
            Next

            TransferImages = True

            'DeleteZippedFiles(LImageDestination)
            'kill()

        Catch ex As Exception
            TransferImages = False
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TransferImages(LImageDestination) = True Then
            Timer1.Stop()
            pgBar.Value = 100
            Me.Text = "Sending images done."
        Else
            pgBar.Value = pgBar.Value + 1
            If pgBar.Value = 95 Then
                pgBar.Value = 95
            End If
        End If
    End Sub
    Private Function DeleteZippedFiles(ByVal DestinationImage As String, ByVal RARFile As String) As Boolean
        Try


            Dim getImages As New DirectoryInfo(DestinationImage)
            Dim getImageOnly As FileInfo() = getImages.GetFiles("*.JPG")
            Dim noOfFiles As Integer
            Dim i As Integer

            noOfFiles = getImageOnly.GetUpperBound(0)
            '' a = Application.StartupPath & "\ARJ.exe a " & imageSource & ".ARJ" & " " & imageSource
            '' Shell(Application.StartupPath & "\ARJ.exe a " & imageSource & "*.ARJ" & " " & imageSource, AppWinStyle.NormalFocus, 10)
            For i = 0 To noOfFiles
                GC.Collect()
                File.Delete(DestinationImage & "\" & getImageOnly.GetValue(i).name)
            Next
            GC.Collect()
            File.Delete(ARJDestination & RARFile)
            File.Delete(photodes & RARFile)
            DeleteZippedFiles = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub frmImageProgress_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'DeleteZippedFiles(LImageDestination)
    End Sub
    Private Function IfImageExist(ByVal UploadImagePath As String) As Boolean
        Try


            Dim getImages As New DirectoryInfo(UploadImagePath)
            Dim getImageOnly As FileInfo() = getImages.GetFiles("*.JPG")
            Dim noOfFiles As Integer
            Dim i As Integer

            IfImageExist = False

            noOfFiles = getImageOnly.GetUpperBound(0)
            '' a = Application.StartupPath & "\ARJ.exe a " & imageSource & ".ARJ" & " " & imageSource
            '' Shell(Application.StartupPath & "\ARJ.exe a " & imageSource & "*.ARJ" & " " & imageSource, AppWinStyle.NormalFocus, 10)
            If noOfFiles > -1 Then
                IfImageExist = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class
