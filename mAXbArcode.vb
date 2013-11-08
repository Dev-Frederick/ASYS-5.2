Imports System.Data.SqlClient
Public Class mAXbArcode
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Clear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(mAXbArcode))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Clear = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM CODE"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ITEM SOURCE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "YEAR"
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(8, 24)
        Me.txt1.MaxLength = 3
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(104, 20)
        Me.txt1.TabIndex = 1
        Me.txt1.Text = ""
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(112, 24)
        Me.txt2.MaxLength = 5
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(104, 20)
        Me.txt2.TabIndex = 2
        Me.txt2.Text = ""
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt3
        '
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(216, 24)
        Me.txt3.MaxLength = 4
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(104, 20)
        Me.txt3.TabIndex = 3
        Me.txt3.Text = ""
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt3)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 80)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(112, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "SEARCH"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(248, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 48)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CLOSE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "MAXIMUM BARCODE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 24)
        Me.Label5.TabIndex = 10
        '
        'Clear
        '
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Image = CType(resources.GetObject("Clear.Image"), System.Drawing.Image)
        Me.Clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Clear.Location = New System.Drawing.Point(184, 144)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(72, 48)
        Me.Clear.TabIndex = 11
        Me.Clear.Text = "CLEAR"
        Me.Clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'mAXbArcode
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(338, 200)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mAXbArcode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Maximum Barcode"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Txt1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txt1.Text = "" Then
                    txt1.Focus()
                Else
                    txt2.Focus()
                End If

            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Txt2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt2.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txt2.Text = "" Then
                    txt2.Focus()
                Else
                    txt3.Focus()
                End If

            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Txt3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt3.KeyPress
        Try
            If e.KeyChar = ChrW(13) Then
                If txt3.Text = "" Then
                    txt3.Focus()
                Else
                    Button1.Focus()
                End If
            Else
                If Not IsNumeric(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> "." Then
                    e.Handled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mAXbArcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.txt3.Text = Now.Year
            Me.txt2.Text = 39033
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str, str1 As String
            Dim maxbarc, seqnc As String

            If Me.txt1.Text = "" And txt2.Text = "" And txt3.Text = "" Then
                MsgBox("Fill all the textboxes!")
                Exit Sub
            Else
                seqnc = "00001"
                obj.Connectionstring3()
                obj.Open3()


                str = "exec ASYS_Barcode_Generator '" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "'"

                obj.Command3(str)
                dr = obj.OpenDataReader3
                If dr.Read Then
                    maxbarc = obj.IsNull(dr.Item("maxBarcode"))
                End If
                dr.Close()
                'obj.Execute3()
                obj.Close3()
                obj = Nothing
                Label5.Text = maxbarc

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Try
            txt1.Text = ""
            'txt2.Text = ""
            'txt3.Text = ""
            Label5.Text = ""
            txt1.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class
