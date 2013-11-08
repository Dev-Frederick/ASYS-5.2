Imports System.Data.SqlClient
Public Class BarcodeEditUtility
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BarcodeEditUtility))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A.L.L. BARCODE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "-"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(315, 21)
        Me.TextBox2.MaxLength = 1
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(28, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "1"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(98, 21)
        Me.TextBox1.MaxLength = 17
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(196, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'ListView1
        '
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(14, 77)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(350, 273)
        Me.ListView1.TabIndex = 2
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "OLD A.L.L. BARCODE"
        Me.ColumnHeader3.Width = 345
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(161, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CHANGE"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(301, 364)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "CLOSE"
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.GridLines = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(14, 77)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(350, 273)
        Me.ListView2.TabIndex = 5
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Old ALLBarcode"
        Me.ColumnHeader1.Width = 135
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "New Barcode"
        Me.ColumnHeader2.Width = 133
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 77
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(91, 364)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 28)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "REFRESH"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(231, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 28)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "REMOVE"
        '
        'BarcodeEditUtility
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(370, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ListView2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BarcodeEditUtility"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BARCODE UTILITY"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            ListView1.BringToFront()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Try
            Dim a As Integer
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String

            str = "If (Select Count(*) from ASYS_REM_Detail where refallbarcode = '" & TextBox1.Text & "')<> 0 begin Select refAllbarcode from ASYS_REM_Detail where refallbarcode ='" & TextBox1.Text & "' end else Select refallbarcode from ASYS_REMOutsource_detail where refallbarcode = '" & TextBox1.Text & "'"

            If e.KeyChar = ChrW(13) Then
                If TextBox1.Text <> "" And TextBox1.Text.Length = 17 Then

                    obj = New clsCommon
                    obj.Connectionstring3()
                    obj.Open3()
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        If ListView1.Items.Count > 0 Then
                            For a = 0 To ListView1.Items.Count - 1
                                If ListView1.Items(a).Text = TextBox1.Text Then
                                    MsgBox("ALLBarcode already exist.", MsgBoxStyle.Information, TitleMsgBox)
                                    TextBox1.Focus()
                                    Exit Sub
                                Else
                                    If a = ListView1.Items.Count - 1 Then
                                        Me.ListView1.Items.Add(Me.TextBox1.Text)
                                        TextBox1.Clear()
                                    End If

                                End If
                            Next
                        Else
                            Me.ListView1.Items.Add(Me.TextBox1.Text)
                            TextBox1.Clear()
                        End If

                    Else
                        MsgBox("ALLBarcode doesn't exist.", MsgBoxStyle.Information, TitleMsgBox)
                        TextBox1.Focus()
                        Exit Sub
                    End If
                    dr.Close()
                    obj.Execute3()
                    obj.Close3()
                    obj = Nothing
                End If
            End If
        Catch ex As Exception
            MsgBox("BarcodeEditUtility/TextBox1_KeyPress: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim a As Integer
            Dim barc, barcode, Barco, NewBarc As String
            Dim obj As New clsCommon
            Dim dr As SqlDataReader
            Dim str As String


            If TextBox2.Text = "" Then
                MsgBox("Some fields are empty.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox2.Focus()
                Exit Sub
            End If

            ListView2.Items.Clear()
            If ListView1.Items.Count > 0 Then
                obj = New clsCommon
                obj.Connectionstring3()
                obj.Open3()

                For a = 0 To ListView1.Items.Count - 1
                    barc = ListView1.Items(a).Text
                    barcode = Mid(barc, 1, 12)
                    Barco = TextBox2.Text + Mid(barc, 14, 5)

                    str = "Select refallbarcode as barcode from ASYS_REM_Detail where refallbarcode = '" & barcode & Barco & "' union all select refallbarcode as barcode from ASYS_REMOutsource_detail where refallbarcode = '" & barcode & Barco & "' "
                    obj.Command3(str)
                    dr = obj.OpenDataReader3
                    If dr.Read = True Then
                        ListView2.Items.Add(ListView1.Items(a).Text)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(barcode & Barco)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("Exist")
                        ListView2.BringToFront()
                    Else
                        ListView2.Items.Add(ListView1.Items(a).Text)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add(barcode & Barco)
                        ListView2.Items(ListView2.Items.Count - 1).SubItems.Add("Available")
                        ListView2.BringToFront()
                    End If
                    dr.Close()
                Next
                obj.Close3()
                obj = Nothing

            Else
                MsgBox("No allbarcode to change.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("BarcodeEditUtility/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim obj2 As New clsCommon
            Dim str As String
            Dim b As Integer
            Dim exitsbar As Boolean


            exitsbar = False
            obj2 = New clsCommon
            obj2.Connectionstring3()
            obj2.Open3()
            If ListView2.Items.Count > 0 Then
                For b = 0 To ListView2.Items.Count - 1
                    If ListView2.Items(b).SubItems.Item(2).Text = "Available" Then
                        str = "Update ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        str = "Update ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        '-----------------------------SDB Luzon------------------------------'
                        str = "Update [remsluzon].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()


                        str = "Update [remsluzon].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        '-------------------------SDB Vismin------------------------------'
                        ''str = "Update [remsVismin].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        ''obj2.Command3(str)
                        ''obj2.Execute3()

                        ''str = "Update [remsVismin].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        ''obj2.Command3(str)
                        ''obj2.Execute3()

                        '-------------------------SDB Visayas------------------------------'
                        str = "Update [remsvisayas].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        str = "Update [remsvisayas].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()
                        '-------------------------SDB Mindanao------------------------------'
                        str = "Update [remsmindanao].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        str = "Update [remsmindanao].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()
                        '-------------------------SDB Showroom------------------------------'
                        str = "Update [remsshowroom].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()

                        str = "Update [remsshowroom].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        obj2.Command3(str)
                        obj2.Execute3()
                        '-------------------------SDB LNCR------------------------------'
                        'str = "Update [remsLNCR].dbo.ASYS_REM_Detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        'obj2.Command3(str)
                        'obj2.Execute3()

                        'str = "Update [remsLNCR].dbo.ASYS_REMOutsource_detail set refallbarcode = '" & ListView2.Items(b).SubItems.Item(1).Text & "'  where refallbarcode = '" & ListView2.Items(b).SubItems.Item(0).Text & "'"
                        'obj2.Command3(str)
                        'obj2.Execute3()
                    Else
                        exitsbar = True
                    End If
                Next

                ListView1.Items.Clear()
                ListView2.Items.Clear()
                MsgBox("Available ALLBarcode was successfully updated.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
                'Exit Sub
            Else
                MsgBox("No allbarcode to edit.", MsgBoxStyle.Information, TitleMsgBox)
                TextBox1.Focus()
                Exit Sub
            End If

            If exitsbar = True Then
                MsgBox("Some New barcode are already exist.", MsgBoxStyle.Information, TitleMsgBox)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("BarcodeEditUtility/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            'ListView1_DoubleClick(sender, e)
            If ListView1.Items.Count <> 0 Then
                If ListView1.Focus Then
                    ListView1.FocusedItem.Remove()
                End If
            End If
            If ListView2.Items.Count <> 0 Then
                If ListView2.Focus Then
                    ListView2.FocusedItem.Remove()
                End If
            End If
        Catch ex As Exception
            MsgBox("BarcodeEditUtility/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Try
            ListView1.FocusedItem.Remove()
        Catch ex As Exception
        End Try
    End Sub
End Class
