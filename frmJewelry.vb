Imports System.Data.SqlClient
Public Class frmJewelry
    Inherits System.Windows.Forms.Form

#Region " private declarations "

    Private objclass As clsCommon
    Private iselect As Integer

#End Region

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
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmJewelry))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Button5 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(16, 88)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(296, 144)
        Me.ListView1.TabIndex = 3
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "         CLASS"
        Me.ColumnHeader1.Width = 94
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "                     DESCRIPTION"
        Me.ColumnHeader2.Width = 202
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.ImageIndex = 2
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(328, 88)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "EDIT"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.ImageIndex = 5
        Me.Button4.ImageList = Me.ImageList1
        Me.Button4.Location = New System.Drawing.Point(328, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 40)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(328, 168)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 0
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(328, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "SAVE"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.ImageIndex = 4
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(328, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "NEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TEXTBOX1"
        '
        'TextBox2
        '
        Me.TextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(96, 48)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "TEXTBOX2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "CLASS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "DESCRIPTION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(8, 256)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 26
        Me.TextBox3.Text = "TextBox3"
        Me.TextBox3.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.ImageIndex = 1
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(328, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 40)
        Me.Button6.TabIndex = 27
        Me.Button6.Text = "CLOSE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmJewelry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(416, 261)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmJewelry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jewelry Class"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " private sub "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SetDesktopLocation(595, 85)
            Call clear()
            Call Control(False)
            Call retreivesortclass()
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'clears textboxes
    Private Sub clear()
        Try
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

    'retrieves sorting class
    Private Sub retreivesortclass()
        Try
            Dim dr As SqlDataReader
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select id, code, description from tbl_sortclass order by code")
            dr = objclass.OpenDataReader3()
            ListView1.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("id")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("code"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("description"))))
            End While
            dr.Close()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'enables or disables textboxes
    Private Sub Control(ByVal bEnabled As Boolean)
        Try
            TextBox1.Enabled = bEnabled
            TextBox2.Enabled = bEnabled
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'saves jewelry class to tbl_sortclass
    Private Sub SaveJewelryClass()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("insert into tbl_sortclass(code, description) Values('" + TextBox1.Text + "', '" + TextBox2.Text + "')")
            objclass.Execute3()
            objclass.Command3("insert into remsluzon.dbo.tbl_sortclass(code, description) Values('" + TextBox1.Text + "', '" + TextBox2.Text + "')")
            objclass.Execute3()
            objclass.Command3("insert into remsvismin.dbo.tbl_sortclass(code, description) Values('" + TextBox1.Text + "', '" + TextBox2.Text + "')")
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
            MsgBox("jewelry class Saved.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'updates jewelry class to tbl_sortclass
    Private Sub EditJewelryClass()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("update tbl_sortclass set code = '" + TextBox1.Text + "', description = '" + TextBox2.Text + "' where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Command3("update remsluzon.dbo.tbl_sortclass set code = '" + TextBox1.Text + "', description = '" + TextBox2.Text + "' where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Command3("update remsvismin.dbo.tbl_sortclass set code = '" + TextBox1.Text + "', description = '" + TextBox2.Text + "' where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
            MsgBox("jewelry class Updated.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub
    'deletes jewelry class to tbl_sortclass
    Private Sub DeleteJewelryClass()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("delete from tbl_sortclass where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Command3("delete from remsluzon.dbo.tbl_sortclass where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Command3("delete from remsvismin.dbo.tbl_sortclass where id = " + TextBox3.Text)
            objclass.Execute3()
            objclass.Close()
            objclass = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try
    End Sub

#End Region

#Region " control attributes "

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ListView1.Enabled = False
            Call Control(True)
            Call clear()
            iselect = 1
            TextBox1.Focus()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Call clear()
            Call Control(False)
            ListView1.Enabled = True
            ListView1.Focus()
            iselect = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox1.Text.Length <= 0 Then
                MsgBox("Nothing to edit. No record were selected.", MsgBoxStyle.Exclamation, "Asys3.1")
                Exit Sub
            End If
            ListView1.Enabled = False
            Call Control(True)
            iselect = 2
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text = "" Then
                MsgBox("Please provide class.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If TextBox2.Text = "" Then
                MsgBox("Please provide description.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            Try
                If iselect = 1 Then
                    Call SaveJewelryClass()

                Else
                    Call EditJewelryClass()

                End If
            Catch ex As Exception
                MsgBox(ex.Message, , TitleMsgBox)
            End Try
            ListView1.Enabled = True
            Call clear()
            Call Control(False)
            Call retreivesortclass()
            iselect = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox1.Text.Length <= 0 Then
                MsgBox("Nothing to delete. No record were selected.", MsgBoxStyle.Exclamation, "Asys3.1")
                Exit Sub
            End If

            Call DeleteJewelryClass()
            MsgBox("jewelry class deleted.", MsgBoxStyle.Information, TitleMsgBox)
            Call clear()
            Call Control(False)
            Call retreivesortclass()
        Catch ex As Exception
            MsgBox(ex.Message, , TitleMsgBox)
        End Try

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            TextBox3.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
            TextBox2.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            TextBox3.Text = ListView1.FocusedItem.Text
            TextBox1.Text = ListView1.FocusedItem.SubItems(1).Text
            TextBox2.Text = ListView1.FocusedItem.SubItems(2).Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
#End Region

End Class
