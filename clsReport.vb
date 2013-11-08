Public Class clsReport
    Public iPrenda_month, iPrenda_year As Integer

    Public Function order(ByVal control As ComboBox) As Integer
        If control.Text = "" Then
            Return 0
        End If
        If control.SelectedIndex = 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function Prenda(ByVal control1 As ComboBox, ByVal control2 As ComboBox) As String
        Dim smonth, syear As String
        Dim imonth As Integer

        imonth = CInt(control2.SelectedIndex + 1) - 7
        If imonth <= 0 Then
            If imonth = 0 Then
                smonth = "DECEMBER"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 12
                iPrenda_year = CInt(syear)
            ElseIf imonth = -1 Then
                smonth = "OCTOBER"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 11
                iPrenda_year = CInt(syear)
            ElseIf imonth = -2 Then
                smonth = "OCTOBER"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 10
                iPrenda_year = CInt(syear)
            ElseIf imonth = -3 Then
                smonth = "SEPTEMBER"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 9
                iPrenda_year = CInt(syear)
            ElseIf imonth = -4 Then
                smonth = "AUGUST"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 8
                iPrenda_year = CInt(syear)
            ElseIf imonth = -5 Then
                smonth = "JULY"
                syear = CInt(control1.SelectedItem) - 1
                iPrenda_month = 7
                iPrenda_year = CInt(syear)
            End If
        Else
            If imonth = 1 Then
                smonth = "JANUARY"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 1
                iPrenda_year = CInt(syear)
            ElseIf imonth = 2 Then
                smonth = "FEBRUARY"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 2
                iPrenda_year = CInt(syear)
            ElseIf imonth = 3 Then
                smonth = "MARCH"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 3
                iPrenda_year = CInt(syear)
            ElseIf imonth = 4 Then
                smonth = "APRIL"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 4
                iPrenda_year = CInt(syear)
            ElseIf imonth = 5 Then
                smonth = "MAY"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 5
                iPrenda_year = CInt(syear)
            ElseIf imonth = 6 Then
                smonth = "JUNE"
                syear = CInt(control1.SelectedItem)
                iPrenda_month = 6
                iPrenda_year = CInt(syear)
            End If
        End If
        Return (syear + " " + smonth)
    End Function
    Public Function prevmonth(ByVal iselect As Integer) As String
        iselect = iselect - 1
        If iselect = 1 Then
            Return "JANUARY"
        ElseIf iselect = 2 Then
            Return "FEBRUARY"
        ElseIf iselect = 3 Then
            Return "MARCH"
        ElseIf iselect = 4 Then
            Return "APRIL"
        ElseIf iselect = 5 Then
            Return "MAY"
        ElseIf iselect = 6 Then
            Return "JUNE"
        ElseIf iselect = 7 Then
            Return "JULY"
        ElseIf iselect = 8 Then
            Return "AUGUST"
        ElseIf iselect = 9 Then
            Return "SEPTEMBER"
        ElseIf iselect = 10 Then
            Return "OCTOBER"
        ElseIf iselect = 11 Then
            Return "OCTOBER"
        ElseIf iselect = 0 Then
            Return "DECEMBER"
        End If

    End Function
    Public Function habwamonth(ByVal iselect As Integer) As String
        If iselect = 1 Then
            Return "JANUARY"
        ElseIf iselect = 2 Then
            Return "FEBRUARY"
        ElseIf iselect = 3 Then
            Return "MARCH"
        ElseIf iselect = 4 Then
            Return "APRIL"
        ElseIf iselect = 5 Then
            Return "MAY"
        ElseIf iselect = 6 Then
            Return "JUNE"
        ElseIf iselect = 7 Then
            Return "JULY"
        ElseIf iselect = 8 Then
            Return "AUGUST"
        ElseIf iselect = 9 Then
            Return "SEPTEMBER"
        ElseIf iselect = 10 Then
            Return "OCTOBER"
        ElseIf iselect = 11 Then
            Return "OCTOBER"
        ElseIf iselect = 12 Then
            Return "DECEMBER"
        End If
    End Function
End Class
