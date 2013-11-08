'Imports System.Windows.Forms
'Imports System.IO
'Imports System

'Public Class clsKeyPressChar
'    Private Shared instance As clsKeyPressChar

'    Public Shared Function getInstace() As clsKeyPressChar
'        If instance Is Nothing Then
'            instance = New clsKeyPressChar
'        End If
'        Return instance
'    End Function

'    Public Function fnKeyPressAlpha(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
'        Try
'            'Dim ck As clsValidationChar = clsValidationChar.getInstace
'            fnKeyPressAlpha = True
'            If Not ck.isAlpha(e.KeyChar.ToString) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And e.KeyChar <> ChrW(Keys.F5) Then
'                e.Handled = True
'                fnKeyPressAlpha = False
'                Exit Function
'            End If
'        Catch ex As Exception
'            fnKeyPressAlpha = False
'            MessageBox.Show("Class Key Press::PressAlpha: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'        End Try

'    End Function

'    Public Function fnKeyPressNumber(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
'        Try
'            'Dim ck As clsValidationChar = clsValidationChar.getInstace
'            fnKeyPressNumber = True
'            If Not ck.isNumber(e.KeyChar.ToString) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And e.KeyChar <> ChrW(Keys.F5) Or LCase(e.KeyChar.ToString) = "t" Then
'                e.Handled = True
'                fnKeyPressNumber = False
'                Exit Function
'            End If
'        Catch ex As Exception
'            fnKeyPressNumber = False
'            MessageBox.Show("Class Key Press::PressNumber: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'        End Try

'    End Function

'    Public Function fnKeyPressAlphaNum(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
'        Try
'            'Dim ck As clsValidationChar = clsValidationChar.getInstace
'            fnKeyPressAlphaNum = True
'            If Not ck.isAlphaNum(e.KeyChar.ToString) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And e.KeyChar <> ChrW(Keys.F5) Then
'                e.Handled = True
'                fnKeyPressAlphaNum = False
'                Exit Function
'            End If
'        Catch ex As Exception
'            fnKeyPressAlphaNum = False
'            MessageBox.Show("Class Key Press::PressAlphaNum: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'        End Try

'    End Function

'    Public Function fnKeyPressAmount(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
'        Try
'            'Dim ck As clsValidationChar = clsValidationChar.getInstace
'            fnKeyPressAmount = True
'            If Not ck.isAmount(e.KeyChar.ToString) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And e.KeyChar <> ChrW(Keys.F5) Or LCase(e.KeyChar.ToString) = "t" Then
'                e.Handled = True
'                fnKeyPressAmount = False
'                Exit Function
'            End If
'        Catch ex As Exception
'            fnKeyPressAmount = False
'            MessageBox.Show("Class Key Press::PressAmount: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'        End Try
'    End Function

'    Public Function fnKeyPressNumberDash(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
'        Try
'            'Dim ck As clsValidationChar = clsValidationChar.getInstace
'            fnKeyPressNumberDash = True
'            If Not ck.isNumberDash(e.KeyChar.ToString) And e.KeyChar <> ChrW(13) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Delete) And e.KeyChar <> ChrW(Keys.F5) Then
'                e.Handled = True
'                fnKeyPressNumberDash = False
'                Exit Function
'            End If
'        Catch ex As Exception
'            fnKeyPressNumberDash = False
'            MessageBox.Show("Class Key Press::PressNumberDash: " & ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
'        End Try
'    End Function

'End Class
