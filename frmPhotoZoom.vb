Imports System.IO
Public Class frmPhotoZoom
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPhotoZoom))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(497, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmPhotoZoom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 438)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 472)
        Me.MinimumSize = New System.Drawing.Size(520, 472)
        Me.Name = "frmPhotoZoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZOOM"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private path As String
    Private Sub frmPhotoZoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim frm As New frmPhotoZoom
            Dim img As Drawing.Image

            If File.Exists(path) Then
                img = img.FromFile(path)
                PictureBox1.Show()
                PictureBox1.Image = img
            Else
                img = img.FromFile(Application.StartupPath & "\" & "questionmark2" & ".jpg")
                PictureBox1.Show()
                PictureBox1.Image = img
            End If
            photozoom = photozoom + 1
        Catch ex As Exception

        End Try
    End Sub

    Public Sub photoname(ByVal path1 As String)
        Try
            path = path1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmPhotoZoom_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            photozoom = 0
            PictureBox1.Image.Dispose()
        Catch ex As Exception

        End Try
    End Sub
End Class
