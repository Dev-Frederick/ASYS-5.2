Imports System.Data.SqlClient
Public Class frmMemo
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
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMemo))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(8, 104)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(552, 128)
        Me.ListView1.TabIndex = 4
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "OFFICE"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 164
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "VISMIN OFFICIAL"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NCR OFFCIAL"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 188
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(120, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(136, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OFFICE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "VISMIN OFFICIAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NCR OFFICIAL"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.ImageIndex = 2
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(576, 92)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 40)
        Me.Button5.TabIndex = 7
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
        Me.Button4.Location = New System.Drawing.Point(576, 132)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 40)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ImageList1
        Me.Button3.Location = New System.Drawing.Point(576, 172)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 40)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "CLEAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.ImageIndex = 0
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(576, 52)
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
        Me.Button1.Location = New System.Drawing.Point(576, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "NEW"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(320, -16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.Text = "TextBox4"
        Me.TextBox4.Visible = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.ImageIndex = 1
        Me.Button6.ImageList = Me.ImageList1
        Me.Button6.Location = New System.Drawing.Point(576, 212)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 40)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "CLOSE"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Location = New System.Drawing.Point(120, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.Text = "ComboBox1"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 20)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.Text = "TextBox2"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.Location = New System.Drawing.Point(120, 64)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.Text = "ComboBox2"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(120, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 20)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "TextBox3"
        '
        'frmMemo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 261)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Memo Receiver"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " private sub "

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SetDesktopLocation(350, 85)
            Dim dr As SqlDataReader
            objclass = New clsCommon
            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("select fullname from " & humres2 & " where emp_stat = 'A' order by fullname")
            dr = objclass.OpenDataReader5
            While dr.Read
                ComboBox1.Items.Add(Trim(dr.Item("fullname")))
                ComboBox2.Items.Add(Trim(dr.Item("fullname")))
            End While
            dr.Close()
            objclass.Execute5()
            objclass.Close5()
            objclass = Nothing
            Call retreivememnoreceiver()
            Call Control(False)
            Call clear()
        Catch ex As Exception

        End Try
    End Sub
    'clears combobox text and textbox text
    Private Sub clear()
        Try
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    'enables or disables combobox and textbox
    Private Sub Control(ByVal bEnabled As Boolean)
        Try
            TextBox1.Enabled = bEnabled
            TextBox2.Enabled = bEnabled
            TextBox3.Enabled = bEnabled
            ComboBox1.Enabled = bEnabled
            ComboBox2.Enabled = bEnabled
        Catch ex As Exception

        End Try
    End Sub
    'retrieves memo receiver list
    Private Sub retreivememnoreceiver()
        Try
            Dim dr As SqlDataReader
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("select id, office, visminofficial, ncrofficial from REMSvismin.dbo.tbl_memo_receiver order by office")
            dr = objclass.OpenDataReader3()
            ListView1.Items.Clear()
            While dr.Read
                ListView1.Items.Add(Trim(dr.Item("id")))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("office"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("visminofficial"))))
                ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(Trim(objclass.IsNull(dr.Item("ncrofficial"))))
            End While
            dr.Close()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
    'saves memo receiver
    Private Sub SaveMemoReceiever()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("insert into tbl_memo_receiver(office, visminofficial, ncrofficial) Values('" + Trim(TextBox1.Text) + "', '" + Trim(TextBox2.Text) + "', '" + Trim(TextBox3.Text) + "')")
            objclass.Execute3()
            objclass.Command3("insert into remsluzon.dbo.tbl_memo_receiver(office, visminofficial, ncrofficial) Values('" + Trim(TextBox1.Text) + "', '" + Trim(TextBox2.Text) + "', '" + Trim(TextBox3.Text) + "')")
            objclass.Execute3()
            objclass.Command3("insert into remsvismin.dbo.tbl_memo_receiver(office, visminofficial, ncrofficial) Values('" + Trim(TextBox1.Text) + "', '" + Trim(TextBox2.Text) + "', '" + Trim(TextBox3.Text) + "')")
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
    'updates memo receiver
    Private Sub EditMemoReceiver()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("update tbl_memo_receiver set office = '" + Trim(TextBox1.Text) + "', visminofficial = '" + Trim(TextBox2.Text) + "', ncrofficial = '" + Trim(TextBox3.Text) + "' where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Command3("update remsluzon.dbo.tbl_memo_receiver set office = '" + Trim(TextBox1.Text) + "', visminofficial = '" + Trim(TextBox2.Text) + "', ncrofficial = '" + Trim(TextBox3.Text) + "' where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Command3("update remsvismin.dbo.tbl_memo_receiver set office = '" + Trim(TextBox1.Text) + "', visminofficial = '" + Trim(TextBox2.Text) + "', ncrofficial = '" + Trim(TextBox3.Text) + "' where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
    'delete memo receiver
    Private Sub DeleteMemoReceiver()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            objclass.Command3("delete from tbl_memo_receiver where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Command3("delete from remsluzon.dbo.tbl_memo_receiver where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Command3("delete from remsvismin.dbo.tbl_memo_receiver where id = " + TextBox4.Text)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region " control attributes "

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            TextBox4.Text = ListView1.FocusedItem.Text
            TextBox1.Text = ListView1.FocusedItem.SubItems(1).Text
            TextBox2.Text = ListView1.FocusedItem.SubItems(2).Text
            TextBox3.Text = ListView1.FocusedItem.SubItems(3).Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        Try
            TextBox4.Text = ListView1.SelectedItems.Item(0).SubItems(0).Text
            TextBox1.Text = ListView1.SelectedItems.Item(0).SubItems(1).Text
            TextBox2.Text = ListView1.SelectedItems.Item(0).SubItems(2).Text
            TextBox3.Text = ListView1.SelectedItems.Item(0).SubItems(3).Text
        Catch ex As Exception
        End Try
    End Sub

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If iselect = 0 Then
                MsgBox("create new data first.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            If TextBox1.Text = "" Then
                MsgBox("Please provide office.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            Try
                If iselect = 1 Then
                    Call SaveMemoReceiever()
                    MsgBox("data Saved.", MsgBoxStyle.Information, TitleMsgBox)
                Else
                    Call EditMemoReceiver()
                    MsgBox("data Updated.", MsgBoxStyle.Information, TitleMsgBox)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, , TitleMsgBox)
            End Try
            ListView1.Enabled = True
            Call clear()
            Call Control(False)
            Call retreivememnoreceiver()
            iselect = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            If TextBox4.Text = "" Then
                MsgBox("please select item.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            ListView1.Enabled = False
            Call Control(True)
            iselect = 2
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If TextBox4.Text = "" Then
                MsgBox("please select item.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
            Try
                Call DeleteMemoReceiver()
                MsgBox("data deleted.", MsgBoxStyle.Information, TitleMsgBox)
            Catch ex As Exception
                MsgBox(ex.Message, , TitleMsgBox)
            End Try
            Call clear()
            Call Control(False)
            Call retreivememnoreceiver()
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            TextBox2.Text = ComboBox1.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            TextBox3.Text = ComboBox2.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

#End Region

End Class
